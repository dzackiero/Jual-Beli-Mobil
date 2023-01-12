Public Class SignUp
    Private Sub buttonCreate_Click(sender As Object, e As EventArgs) Handles buttonCreate.Click
        Dim username = textBoxUsername.Text
        Dim password = textBoxPassword.Text
        Dim email = textBoxEmail.Text
        SignIn.addUser(username, password, email)
        Me.Close()
    End Sub
End Class