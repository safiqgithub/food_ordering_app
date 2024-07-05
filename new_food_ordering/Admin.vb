Public Class Admin
    Private Sub AddFoodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFoodToolStripMenuItem.Click
        Dim addFoodForm As New AddFoodForm()
        addFoodForm.ShowDialog()
    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        Dim addemployeeForm As New AddEmployeeForm()
        addemployeeForm.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ' Close the Home form
        Me.Close()

        ' Create and show the Login form
        Dim loginForm As New Login()
        loginForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class