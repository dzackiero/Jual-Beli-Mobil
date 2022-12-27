Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DataJenisMobil
    Private jenis As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String
    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "jualbelimobil"


    Public Property GSJenis() As String
        Get
            Return jenis
        End Get
        Set(ByVal value As String)
            jenis = value
        End Set
    End Property

    Public Function GetDataJenisMobilDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis AS 'ID',
                                  jenis as 'Jenis Mobil'                      
                                  FROM jenis_mobil"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddJenisMobilDatabase(
                                        jenis As String
                                       )

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO jenis_mobil (jenis) VALUE('" _
                        & jenis & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
