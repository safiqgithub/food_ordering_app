Imports MySql.Data.MySqlClient



Public Class AddFoodForm
    Private connString As String = "server=localhost;port=3306;username=root;password=;database=food_ordering"
    Dim dr As MySqlDataReader
    Dim connection As New MySqlConnection(connString)

    Public Sub DGV_load()
        Try
            connection.Open()
            Dim cmd As New MySqlCommand("SELECT FoodId, FoodName, Price, FoodType FROM foods", connection)
            dr = cmd.ExecuteReader
            While dr.Read
                FoodListForm.Rows.Add(dr.Item("FoodId"), dr.Item("FoodName"), dr.Item("Price"), dr.Item("FoodType"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnAddFood_Click(sender As Object, e As EventArgs) Handles btnAddFood.Click
        If cmbFoodName.SelectedItem IsNot Nothing AndAlso cmbFoodType.SelectedItem IsNot Nothing Then
            Dim foodName As String = cmbFoodName.SelectedItem.ToString()
            Dim price As Decimal = Convert.ToDecimal(txtPrice.Text)
            Dim foodType As String = cmbFoodType.SelectedItem.ToString()

            Try
                Using connection As New MySqlConnection(connString)
                    connection.Open()

                    ' Insert the new food into the database
                    Dim query As String = "INSERT INTO foods (FoodName, Price, FoodType) VALUES (@FoodName, @Price, @FoodType)"
                    Using cmd As New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@FoodName", foodName)
                        cmd.Parameters.AddWithValue("@Price", price)
                        cmd.Parameters.AddWithValue("@FoodType", foodType)

                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Food added successfully!")
                '  Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error adding food: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select both a food item and a food type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnDeleteFood_Click(sender As Object, e As EventArgs) Handles btnDeleteFood.Click
        Dim FoodId As Integer


        If Integer.TryParse(txtFoodId.Text, FoodId) Then
            Try
                Using connection As New MySqlConnection(connString)
                    connection.Open()

                    ' Delete the food from the database
                    Dim query As String = "DELETE FROM foods WHERE FoodId = @FoodId"
                    Using cmd As New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@FoodId", FoodId)

                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Food deleted successfully!")
                ' Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error deleting food: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please enter a valid FoodId.")
        End If
    End Sub

    Private Sub btnUpdateFood_Click(sender As Object, e As EventArgs) Handles btnUpdateFood.Click
        Dim FoodId As Integer
        If Integer.TryParse(txtFoodId.Text, FoodId) Then
            ' Retrieve updated values from UI controls
            Dim updatedFoodName As String = cmbFoodName.SelectedItem.ToString()
            Dim updatedPrice As Decimal = Convert.ToDecimal(txtPrice.Text)
            Dim updatedFoodType As String = cmbFoodType.SelectedItem.ToString()

            Try
                Using connection As New MySqlConnection(connString)
                    connection.Open()

                    ' Update the food in the database
                    Dim query As String = "UPDATE foods SET FoodName = @FoodName, Price = @Price, FoodType = @FoodType WHERE FoodId = @FoodId"
                    Using cmd As New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@FoodName", updatedFoodName)
                        cmd.Parameters.AddWithValue("@Price", updatedPrice)
                        cmd.Parameters.AddWithValue("@FoodType", updatedFoodType)
                        cmd.Parameters.AddWithValue("@FoodId", FoodId)

                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Food updated successfully!")
                '     Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error updating food: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please enter a valid FoodId.")
        End If
    End Sub


    Private Sub FoodListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Private Sub FoodListForm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FoodListForm.CellClick
        txtFoodId.Text = FoodListForm.CurrentRow.Cells(0).Value
        cmbFoodName.Text = FoodListForm.CurrentRow.Cells(1).Value
        txtPrice.Text = FoodListForm.CurrentRow.Cells(2).Value
        cmbFoodType.Text = FoodListForm.CurrentRow.Cells(3).Value



    End Sub



    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text boxes
        txtFoodId.Text = ""
        txtPrice.Text = ""

        ' Clear combo boxes
        cmbFoodName.SelectedIndex = -1
        cmbFoodType.SelectedIndex = -1
    End Sub
End Class