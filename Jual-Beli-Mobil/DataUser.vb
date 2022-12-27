Imports System.Security.Cryptography
Public Class DataUser
    Private TripleDes As New TripleDESCryptoServiceProvider()
    Private userId As Integer
    Private realUsername As String
    Private realPassword As String
    Private realEmail As String

    Sub New(id As Integer, username As String, password As String, email As String)
        userId = id
        realUsername = username
        realPassword = EncryptData(password)
        realEmail = email
    End Sub
    Public Function EncryptData(plainText As String)
        Dim plainTextBytes() As Byte = Text.Encoding.Unicode.GetBytes(plainText)

        Dim ms As New IO.MemoryStream
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            CryptoStreamMode.Write)

        encStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray())
    End Function
    Public Function CheckAuth(username As String, plainPassword As String) As Boolean
        'Dim realPassword As String = EncryptData("1234")
        'Dim realUsername As String = "bassamtiano"

        If String.Compare(username, realUsername) = 0 And
            String.Compare(EncryptData(plainPassword), realPassword) = 0 Then
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
