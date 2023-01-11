
Public Class DataUser
    Private userId As Integer
    Public realUsername As String
    Public realPassword As String
    Private realEmail As String

    Sub New(id As Integer, username As String, password As String, email As String)
        userId = id
        realUsername = username
        realPassword = password
        realEmail = email
        'MessageBox.Show(password)
    End Sub
    Public Function CheckAuth(username As String, plainPassword As String) As Boolean

        'MessageBox.Show(SignIn.EncryptData(plainPassword), realPassword)
        If String.Compare(username, realUsername) = 0 And
            String.Compare(SignIn.EncryptData(plainPassword), realPassword) = 0 Then
            Return True
        Else
            Return False
        End If


    End Function

    Public ReadOnly Property getUsername
        Get
            Return realUsername
        End Get
    End Property
End Class
