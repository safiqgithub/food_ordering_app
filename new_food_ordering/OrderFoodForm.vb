Imports MySql.Data.MySqlClient


Public Class OrderFoodForm
    Private connString As String = "server=localhost;port=3306;username=root;password=;database=food_ordering"
    Dim dr As MySqlDataReader
    Dim connection As New MySqlConnection(connString)

    Public Sub DGV_load()
        Try
            connection.Open()
            Dim cmd As New MySqlCommand("SELECT FoodType, FoodName, Price  FROM foods", connection)
            dr = cmd.ExecuteReader
            While dr.Read
                OrderFoodList.Rows.Add(dr.Item("FoodType"), dr.Item("FoodName"), dr.Item("Price"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub InitializeDataGridView()
        '   Add columns to the DataGridView
        Dim pickColumn As New DataGridViewCheckBoxColumn()
        pickColumn.HeaderText = "Pick"
        pickColumn.Name = "Pick"
        OrderFoodList.Columns.Add(pickColumn)

        Dim quantityColumn As New DataGridViewTextBoxColumn()
        quantityColumn.HeaderText = "Quantity"
        quantityColumn.Name = "Quantity"
        OrderFoodList.Columns.Add(quantityColumn)

        Dim amountColumn As New DataGridViewTextBoxColumn()
        amountColumn.HeaderText = "Amount"
        amountColumn.Name = "Amount"
        OrderFoodList.Columns.Add(amountColumn)

        ' Event handler to handle changes in the Quantity column
        AddHandler OrderFoodList.CellValueChanged, AddressOf OrderFoodList_CellValueChanged
        ' Add event handler for cell click
        AddHandler OrderFoodList.CellContentClick, AddressOf OrderFoodList_CellContentClick
    End Sub

    Private Sub OrderFoodList_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        ' Check if the changed cell is in the Quantity column
        If e.ColumnIndex = OrderFoodList.Columns("Quantity").Index AndAlso e.RowIndex >= 0 Then
            ' Calculate the amount based on the quantity and price
            Dim quantity As Integer
            If Integer.TryParse(OrderFoodList.Rows(e.RowIndex).Cells("Quantity").Value.ToString(), quantity) Then
                Dim price As Decimal = Convert.ToDecimal(OrderFoodList.Rows(e.RowIndex).Cells("Price").Value)
                Dim amount As Decimal = quantity * price
                ' Update the amount cell with the calculated value
                OrderFoodList.Rows(e.RowIndex).Cells("Amount").Value = amount
            End If
        End If
        ' Check if the changed cell is in the "Pick" checkbox column
        If e.ColumnIndex >= 0 AndAlso OrderFoodList.Columns(e.ColumnIndex).Name = "Pick" Then
            Dim row As DataGridViewRow = OrderFoodList.Rows(e.RowIndex)
            Dim pickCell As DataGridViewCheckBoxCell = CType(row.Cells("Pick"), DataGridViewCheckBoxCell)

            ' Check if the checkbox is checked
            If CType(pickCell.Value, Boolean) Then
                ' Set the value of the "Quantity" cell to 1
                row.Cells("Quantity").Value = 1
            End If
        End If
    End Sub

    Private Sub OrderFoodList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrderFoodList.CellContentClick
        ' Check if the clicked cell is in the "Pick" checkbox column
        If e.ColumnIndex >= 0 AndAlso OrderFoodList.Columns(e.ColumnIndex).Name = "Pick" Then
            Dim row As DataGridViewRow = OrderFoodList.Rows(e.RowIndex)
            Dim pickCell As DataGridViewCheckBoxCell = CType(row.Cells("Pick"), DataGridViewCheckBoxCell)

            ' Check if the checkbox is checked
            If CType(pickCell.Value, Boolean) Then
                ' Set the value of the "Quantity" cell to 1
                row.Cells("Quantity").Value = 1
            Else
                ' Uncheck the checkbox, so set the "Quantity" cell value to DBNull
                row.Cells("Quantity").Value = DBNull.Value
            End If
        End If
    End Sub





    Private Sub OrderFoodList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
        InitializeDataGridView()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim totalAmount As Decimal = 0

        ' Loop through the DataGridView to calculate the total amount
        For Each row As DataGridViewRow In OrderFoodList.Rows
            ' Check if the Amount cell is not null or empty
            If Not row.Cells("Amount").Value Is Nothing AndAlso Not String.IsNullOrEmpty(row.Cells("Amount").Value.ToString()) Then
                ' Add the amount to the total
                totalAmount += Convert.ToDecimal(row.Cells("Amount").Value)
            End If
        Next

        ' Display the total amount in the textbox
        txtTotalAmount.Text = totalAmount.ToString("0.00")
    End Sub

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        ' Check if at least one item is selected
        Dim hasSelectedItems As Boolean = False

        For Each row As DataGridViewRow In OrderFoodList.Rows
            Dim picked As Boolean = Convert.ToBoolean(row.Cells("Pick").Value)
            If picked Then
                hasSelectedItems = True
                Exit For
            End If
        Next

        If Not hasSelectedItems Then
            MessageBox.Show("Please select at least one food item.", "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Option 1: Display bill in a separate form
        Dim billForm As New BillForm()
        billForm.DisplayBill(OrderFoodList, GetTotalAmount())
        billForm.Show()



    End Sub

    Private Function GetTotalAmount() As Decimal
        Dim totalAmount As Decimal = 0

        If Decimal.TryParse(txtTotalAmount.Text, totalAmount) Then
            Return totalAmount
        Else
            ' Handle invalid total amount
            MessageBox.Show("Invalid total amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If
    End Function




End Class