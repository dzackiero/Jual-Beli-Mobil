Imports MySql.Data.MySqlClient
Public Class SignIn
    Dim users As New List(Of DataUser)
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "jualbelimobil"
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        users = getUserFromDb()

    End Sub
    Function getUserFromDb()
        Dim arr As New List(Of DataUser)
        Dim result As New DataTable
        'Get From Database
        dbConn.ConnectionString = "server =" + server + ";" +
            "user id=" + username + ";" +
            "password=" + password + ";" +
            "database =" + database + ";"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "select 
            id_user as 'ID',
            username as 'Username',
            email as 'Email'
            from users"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()

        'Insert to array

        For i As Integer = 0 To result.Rows.Count - 1
            Dim row As DataRow = result(i)
            Dim newUser As DataUser
            newUser = New DataUser(row(0), row(1), row(2), row(3))
            arr.Add(newUser)
        Next
        Return arr
    End Function
    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Try
            Dim flag As Boolean = False
            Dim usernameInput As String = textBoxUsername.Text
            Dim passwordInput As String = textBoxPassword.Text
            Dim LoggedUser As DataUser

            For Each usr In users
                If usr.CheckAuth(usernameInput, passwordInput) And Not flag Then
                    flag = True
                    LoggedUser = usr
                End If
            Next
            If flag Then
                'FormSelanjutnya.Show()
            Else
                MessageBox.Show("Wrong Username or Password!!!!!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub SignIn_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        users = getUserFromDb()
    End Sub
End Class