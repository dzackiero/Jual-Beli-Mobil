Imports MySql.Data.MySqlClient
Public Class DataBukuPenjualan
    Private id_buku As Integer
    Private id_mobil As Integer
    Private id_pembeli As Integer
    Private harga_terjual As Integer
    Private tanggal_terjual As Date

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "jualbelimobil"

    Public Function GetDataBukuDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT 
                                id_penjualan as 'ID',
                                id_mobil AS 'Mobil', 
                                id_pembeli AS 'Pembeli',
                                harga_terjual AS 'Harga Terjual',
                                tanggal_penjualan AS 'Tanggal Terjual'
                                FROM buku_penjualan
                                "

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataBukuDatabase(
                                        id_mobil As Integer,
                                        id_pembeli As Integer,
                                        harga_terjual As Integer,
                                        tanggal_terjual As Date
                                        )
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO mobil(id_mobil, id_pembeli, harga_terjual, tanggal_penjualan)
                         VALUE('" _
                                & id_mobil & "', '" _
                                & id_pembeli & "', '" _
                                & harga_terjual & "', '" _
                                & tanggal_terjual & "')"

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

    Public Function GetDataBukuByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_penjualan,
                                id_mobil, 
                                id_pembeli,
                                harga_terjual,
                                tanggal_penjualan
                            FROM buku_penjualan
                            WHERE id_penjualan ='" & ID & "'"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function EditDataBukuByIDDatabase(
                                         id_buku As Integer,
                                        id_mobil As Integer,
                                        id_pembeli As Integer,
                                        harga_terjual As Integer,
                                        tanggal_terjual As Date
                                        )
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE buku_penjualan SET " &
                            "id_mobil='" & id_mobil & "'," &
                            "id_pembeli='" & id_pembeli & "', " &
                            "harga_terjual='" & harga_terjual & "', " &
                            "tanggal_penjualan='" & harga_terjual & "' " &
                            "WHERE id_penjualan=" & id_buku & ""

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

    Public Function DeleteBukuMobilDatabase(ID As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM buku_penjualan " &
                        "WHERE id_penjualan='" & ID & "'"

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

    Public Property GSIdBuku As Integer
        Get
            Return id_buku
        End Get
        Set(value As Integer)
            id_buku = value
        End Set
    End Property
    Public Property GSIdMobil As Integer
        Get
            Return id_mobil
        End Get
        Set(value As Integer)
            id_mobil = value
        End Set
    End Property

    Public Property GSHargaTerjual As Integer
        Get
            Return harga_terjual
        End Get
        Set(value As Integer)
            harga_terjual = value
        End Set
    End Property

    Public Property GSIdPembeli As Integer
        Get
            Return id_pembeli
        End Get
        Set(value As Integer)
            id_pembeli = value
        End Set
    End Property

    Public Property GSTanggalTerjual As Date
        Get
            Return tanggal_terjual
        End Get
        Set(value As Date)
            tanggal_terjual = value
        End Set
    End Property


End Class
