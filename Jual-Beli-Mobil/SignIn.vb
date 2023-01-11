Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class SignIn
    Private TripleDes As New TripleDESCryptoServiceProvider()
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
            pw as 'Password',
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
            newUser = New DataUser(row(0), row(1), EncryptData(row(2)), row(3))
            arr.Add(newUser)
        Next
        Return arr
    End Function
    Public Function addUser(uuname As String, upassword As String, uemail As String)
        Dim newUser As DataUser = New DataUser(0, uuname, EncryptData(upassword), uemail)
        dbConn.ConnectionString = "server =" + server + ";" +
            "user id=" + username + ";" +
            "password=" + password + ";" +
            "database =" + database + ";"
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "insert into users(username, pw, email) value('" _
                & uuname & "', '" _
                & upassword & "', '" _
                & uemail & "')"
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function EncryptData(plainText As String)
        Dim plainTextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plainText)

        Dim ms As New IO.MemoryStream
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            CryptoStreamMode.Write)

        encStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray())
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
                MessageBox.Show("Logged in")
                Dim mobil = New Mobil()
                mobil.Show()
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

    Private Sub linkLabelSignUp_Click(sender As Object, e As EventArgs) Handles linkLabelSignUp.Click
        Dim signUpForm = New signUp()
        signUpForm.Show()
    End Sub
End Class