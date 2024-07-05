Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class BillForm
    Public Sub DisplayBill(orderFoodList As DataGridView, totalAmount As String)
        ' Clear any existing content in the RichTextBox
        RichTextBox1.Clear()

        ' Set the font to a fixed-width font
        RichTextBox1.SelectionFont = New Font("Courier New", 10) ' Adjust font size as needed

        ' Add bill header
        RichTextBox1.AppendText("=========================================" & vbCrLf)
        RichTextBox1.AppendText("                Bill Receipt             " & vbCrLf)
        RichTextBox1.AppendText("=========================================" & vbCrLf)

        ' Add column headers
        Dim columnHeader As String = String.Format("{0,-20} {1,5} {2,10}", "Food Name", "Qty", "Amount")
        RichTextBox1.AppendText(columnHeader & vbCrLf)
        RichTextBox1.AppendText("=========================================" & vbCrLf)

        ' Add bill items
        For Each row As DataGridViewRow In orderFoodList.Rows
            If row.Cells("FoodName").Value IsNot Nothing AndAlso row.Cells("Quantity").Value IsNot Nothing AndAlso row.Cells("Amount").Value IsNot Nothing Then
                Dim foodName As String = TruncateString(row.Cells("FoodName").Value.ToString(), 20)
                Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                Dim amount As Decimal = Convert.ToDecimal(row.Cells("Amount").Value)

                ' Add item details to the RichTextBox
                Dim itemLine As String = String.Format("{0,-20} {1,5} x {2,10}", foodName, quantity, amount.ToString("0.00"))
                RichTextBox1.AppendText(itemLine & vbCrLf)
            End If
        Next

        ' Add total amount
        RichTextBox1.AppendText("=========================================" & vbCrLf)
        RichTextBox1.AppendText(String.Format("{0,35}", $"Total Amount: {totalAmount}") & vbCrLf)

        ' Make the RichTextBox read-only
        RichTextBox1.ReadOnly = True
    End Sub

    Private Function TruncateString(value As String, maxLength As Integer) As String
        If value.Length > maxLength Then
            Return value.Substring(0, maxLength)
        Else
            Return value
        End If
    End Function


End Class




