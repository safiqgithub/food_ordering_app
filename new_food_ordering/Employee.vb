Public Class Employee
    Private Sub OrderFoodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderFoodToolStripMenuItem.Click
        Dim orderfoodform As New OrderFoodForm()
        orderfoodform.ShowDialog()
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