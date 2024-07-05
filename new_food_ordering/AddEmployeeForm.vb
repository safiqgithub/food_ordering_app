Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class AddEmployeeForm
    Private connString As String = "server=localhost;port=3306;username=root;password=;database=food_ordering"
    Dim dr As MySqlDataReader
    Dim connection As New MySqlConnection(connString)
    Public Sub DGV_load()
        Try
            Connection.Open()
            Dim cmd As New MySqlCommand("SELECT id, username, password FROM employees", connection)
            dr = cmd.ExecuteReader
            While dr.Read
                emplistform.Rows.Add(dr.Item("id"), dr.Item("username"), dr.Item("password"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try
    End Sub

    Private Sub btnaddemp_Click(sender As Object, e As EventArgs) Handles btnaddemp.Click
        Dim username As String = txtempuser.Text
        Dim password As String = txtemppass.Text

        ' Check if username and password are empty
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Username and password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the event handler
        End If

        Try
            Using connection As New MySqlConnection(connString)
                connection.Open()

                ' Insert the new employee into the database
                Dim query As String = "INSERT INTO employees (username, password) VALUES (@username, @password)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Employee added successfully!")
            '  Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error adding employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btndelemp_Click(sender As Object, e As EventArgs) Handles btndelemp.Click
        Dim Id As Integer


        If Integer.TryParse(txtempid.Text, Id) Then
            Try
                Using connection As New MySqlConnection(connString)
                    connection.Open()

                    ' Delete the employees from the database
                    Dim query As String = "DELETE FROM employees WHERE id = @id"
                    Using cmd As New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@id", Id)

                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("employee deleted successfully!")
                ' Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error deleting employee: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please enter a valid empId.")
        End If
    End Sub

    Private Sub btnuptemp_Click(sender As Object, e As EventArgs) Handles btnuptemp.Click
        Dim Id As Integer
        Dim updateusername As String = txtempuser.Text
        Dim updatepassword As String = txtemppass.Text


        If Integer.TryParse(txtempid.Text, Id) Then
            Try
                Using connection As New MySqlConnection(connString)
                    connection.Open()

                    ' Update the employees from the database
                    Dim query As String = "UPDATE employees SET username = @username, password = @password WHERE id = @id"
                    Using cmd As New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@id", Id)
                        cmd.Parameters.AddWithValue("@username", updateusername)
                        cmd.Parameters.AddWithValue("@password", updatepassword)

                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("employee updated successfully!")
                ' Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error updating employee: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please enter a valid empId.")
        End If
    End Sub

    Private Sub emplistform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Private Sub emplistform_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles emplistform.CellClick
        txtempid.Text = emplistform.CurrentRow.Cells(0).Value
        txtempuser.Text = emplistform.CurrentRow.Cells(1).Value
        txtemppass.Text = emplistform.CurrentRow.Cells(2).Value

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text boxes
        txtempuser.Text = ""
        txtempid.Text = ""
        txtemppass.Text = ""
    End Sub
End Class