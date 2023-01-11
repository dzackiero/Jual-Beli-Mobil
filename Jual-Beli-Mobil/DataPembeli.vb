Imports MySql.Data.MySqlClient
Public Class DataPembeli
    Private id_pembeli As Integer
    Private nik As Integer
    Private nama As String
    Private alamat As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "jualbelimobil"

    Public Function GetDataPembeliDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT
                                 id_pembeli AS 'id',
                                 nik AS 'NIK',
                                 nama AS 'Nama',
                                 alamat AS 'Alamat'
                                 FROM pembeli
                                 "

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataPembeliDatabase(
                                          nik As String,
                                          nama As String,
                                          alamat As String
                                          )

        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO pembeli(nik, nama, alamat)
                        VALUE('" _
                                    & nik & "', '" _
                                    & nama & "', '" _
                                    & alamat & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataPembeliByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT nik, nama, alamat
                            FROM pembeli
                            WHERE id_pembeli ='" & ID & "'"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function EditDataPembeliByIDDatabase(
                                         id_pembeli As Integer,
                                         nik As Integer,
                                         nama As String,
                                         alamat As String
                                        )
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database

        'Try
        dbConn.Open()
            sqlCommand.Connection = dbConn
        sqlQuery = "UPDATE pembeli SET " &
                            "nik='" & nik & "'," &
                            "nama='" & nama & "', " &
                            "alamat='" & alamat & "' " &
                            "WHERE id_pembeli=" & id_pembeli & ""

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()
            sqlRead.Close()
            dbConn.Close()

        'Catch ex As Exception
        'Return ex.Message
        'Finally
        dbConn.Dispose()
        'End Try
    End Function

    Public Function DeleteDataPembeliDatabase(ID As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM pembeli " &
                        "WHERE id_pembeli='" & ID & "'"

            Debug.WriteLine(sqlQuery)

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
    Public Property GSIdPembeli As Integer
        Get
            Return id_pembeli
        End Get
        Set(value As Integer)
            id_pembeli  = value
        End Set
    End Property

    Public Property GSnik As Integer
        Get
            Return nik
        End Get
        Set(value As Integer)
            nik = value
        End Set
    End Property

    Public Property GSnama As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property GSalamat As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property
End Class


