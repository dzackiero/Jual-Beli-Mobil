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

    Public Property GSGarasi As Integer
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


