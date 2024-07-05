Imports MySql.Data.MySqlClient


Public Class Login
    Private connString As String = "server=localhost;port=3306;username=root;password=;database=food_ordering"

    Private Sub admin_login_btn_Click(sender As Object, e As EventArgs) Handles admin_login_btn.Click
        Dim username As String = admin_user_text.Text
        Dim password As String = admin_pass_text.Text

        If AuthenticateUser(username, password) Then
            '  MessageBox.Show("Login successful!")
            Dim homeForm As New Admin()
            homeForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub
    Private Sub admin_user_text_KeyDown(sender As Object, e As KeyEventArgs) Handles admin_user_text.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the "ding" sound
            admin_pass_text.Focus() ' Set focus to the admin_pass_text textbox
        End If
    End Sub
    Private Sub admin_pass_text_KeyDown(sender As Object, e As KeyEventArgs) Handles admin_pass_text.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the "ding" sound
            admin_login_btn.PerformClick() ' Simulate a click on the admin_login_btn button
        End If
    End Sub


    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Try
            Using connection As New MySqlConnection(connString)
                connection.Open()

                ' Use parameterized query to prevent SQL injection
                Dim query As String = "SELECT * FROM admin WHERE Username = @Username AND Password = @Password"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Return reader.HasRows
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Log the error to a file or another logging system
            Console.WriteLine("Error authenticating user: " & ex.Message)
            Return False
        End Try
    End Function
    Private Sub emp_login_btn_Click(sender As Object, e As EventArgs) Handles emp_login_btn.Click
        Dim username As String = emp_user_text.Text
        Dim password As String = emp_pass_text.Text

        If AuthenticateUser1(username, password) Then
            '  MessageBox.Show("Login successful!")
            Dim homeForm As New Employee()
            homeForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Sub emp_user_text_KeyDown(sender As Object, e As KeyEventArgs) Handles emp_user_text.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the "ding" sound
            emp_pass_text.Focus() ' Set focus to the admin_pass_text textbox
        End If
    End Sub
    Private Sub emp_pass_text_KeyDown(sender As Object, e As KeyEventArgs) Handles emp_pass_text.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the "ding" sound
            emp_login_btn.PerformClick() ' Simulate a click on the admin_login_btn button
        End If
    End Sub

    Private Function AuthenticateUser1(username As String, password As String) As Boolean
        Try
            Using connection As New MySqlConnection(connString)
                connection.Open()

                ' Use parameterized query to prevent SQL injection
                Dim query As String = "SELECT * FROM employees WHERE username = @username AND password = @password"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Return reader.HasRows
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Log the error to a file or another logging system
            Console.WriteLine("Error authenticating user: " & ex.Message)
            Return False
        End Try
    End Function



End Class
