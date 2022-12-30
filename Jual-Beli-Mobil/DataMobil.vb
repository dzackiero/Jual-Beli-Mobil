Imports MySql.Data.MySqlClient
Public Class DataMobil
    Private id_mobil As Integer
    Private jenis_mobil As Integer
    Private tipe_mobil As String
    Private tahun_pembuatan As Integer
    Private kondisi As String
    Private harga As Integer
    Private garansi As Integer
    Private status_terjual As Boolean
    Private harga_default As Integer

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "jualbelimobil"

    Public Function GetDataMobilDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT 
                                id_mobil AS 'ID', 
                                id_jenis_mobil AS 'Jenis Mobil',
                                tipe_mobil AS 'Tipe Mobil',
                                tahun_pembuatan AS 'Tahun Pembuatan',
                                kondisi AS 'Kondisi',
                                harga AS 'Harga',
                                garansi AS 'Garansi',
                                status_terjual AS 'Status',
                                harga_default AS 'Base Price'
                                FROM mobil
                                "

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataMobilDatabase(
                                         tipe_mobil As String,
                                         jenis_mobil As Integer,
                                         harga As Integer,
                                         harga_dasar As Integer,
                                         tahun_pembuatan As Integer,
                                         kondisi As String,
                                         garansi As String
                                        )
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO mobil(tipe_mobil, id_jenis_mobil, tahun_pembuatan, kondisi, harga, harga_default, status_terjual, garansi)
                         VALUE('" _
                                & tipe_mobil & "', '" _
                                & jenis_mobil & "', '" _
                                & tahun_pembuatan & "', '" _
                                & kondisi & "', '" _
                                & harga & "', '" _
                                & harga_dasar & "', '" _
                                & False & "', '" _
                                & garansi & "')"

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

    Public Function GetDataMobilByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT tipe_mobil, id_jenis_mobil, tahun_pembuatan, kondisi, harga, garansi, harga_default
                            FROM mobil
                            WHERE id_mobil ='" & ID & "'"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function EditDataMobilByIDDatabase(
                                         id_mobil As Integer,
                                         tipe_mobil As String,
                                         jenis_mobil As Integer,
                                         harga As Integer,
                                         harga_dasar As Integer,
                                         tahun_pembuatan As Integer,
                                         kondisi As String,
                                         garansi As String
                                        )
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE mobil SET " &
                            "id_jenis_mobil='" & jenis_mobil & "'," &
                            "tipe_mobil='" & tipe_mobil & "', " &
                            "harga='" & harga & "', " &
                            "harga_default='" & harga_dasar & "', " &
                            "tahun_pembuatan='" & tahun_pembuatan & "', " &
                            "kondisi='" & kondisi & "', " &
                            "garansi='" & garansi & "' " &
                            "WHERE id_mobil=" & id_mobil & ""

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

    Public Function DeleteDataMobilDatabase(ID As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM mobil " &
                        "WHERE id_mobil='" & ID & "'"

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
    Public Property GSIdMobil As Integer
        Get
            Return id_mobil
        End Get
        Set(value As Integer)
            id_mobil = value
        End Set
    End Property

    Public Property GSJenisMobil As Integer
        Get
            Return jenis_mobil
        End Get
        Set(value As Integer)
            jenis_mobil = value
        End Set
    End Property

    Public Property GSTipeMobil As String
        Get
            Return tipe_mobil
        End Get
        Set(value As String)
            tipe_mobil = value
        End Set
    End Property

    Public Property GSTahunPembuatan As Integer
        Get
            Return tahun_pembuatan
        End Get
        Set(value As Integer)
            tahun_pembuatan = value
        End Set
    End Property

    Public Property GSKondisi As String
        Get
            Return kondisi
        End Get
        Set(value As String)
            kondisi = value
        End Set
    End Property

    Public Property GSHarga As Integer
        Get
            Return harga
        End Get
        Set(value As Integer)
            harga = value
        End Set
    End Property

    Public Property GSGaransi As Integer
        Get
            Return garansi
        End Get
        Set(value As Integer)
            garansi = value
        End Set
    End Property

    Public Property GSStatusTerjual As Boolean
        Get
            Return status_terjual
        End Get
        Set(value As Boolean)
            status_terjual = value
        End Set
    End Property

    Public Property GSHargaDefault As Integer
        Get
            Return harga_default
        End Get
        Set(value As Integer)
            harga_default = value
        End Set
    End Property
End Class


