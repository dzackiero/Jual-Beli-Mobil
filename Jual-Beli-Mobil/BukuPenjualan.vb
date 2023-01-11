Public Class BukuPenjualan
    Public Shared dataMobil As DataMobil
    Public Shared dataPenjualan As DataBukuPenjualan
    Public Shared dataPembeli As DataPembeli

    Public selectedIdMobil As Integer
    Public selectedIdBuku As Integer
    Public selectedIdPenjual As Integer


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataPenjualan = New DataBukuPenjualan
        dataMobil = New DataMobil()
        dataPembeli = New DataPembeli
        ReloadDataTableDatabase()
    End Sub

    Private Sub Mobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Public Sub ReloadDataTableDatabase()

        DataGridViewBuku.DataSource = dataPenjualan.GetDataBukuDatabase()
    End Sub

    Private Sub DataGridViewBuku_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBuku.CellClick
        Try
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewBuku.Rows(index)

            selectedIdBuku = Int(selectedRow.Cells(0).Value)
            selectedIdMobil = Int(selectedRow.Cells(1).Value)
            selectedIdPenjual = Int(selectedRow.Cells(2).Value)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub ButtonTambahBuku_Click(sender As Object, e As EventArgs) Handles ButtonTambahBuku.Click
        Dim formTambahBuku = New TambahBukuPenjualan
        formTambahBuku.Show()

    End Sub

    Private Sub ButtonHapusBuku_Click(sender As Object, e As EventArgs) Handles ButtonHapusBuku.Click

        Try
            Dim selectedBuku As List(Of String) = dataPenjualan.GetDataBukuByIDDatabase(selectedIdBuku)

            Dim hapusBuku = New HapusBukuPenjualan(selectedIdBuku)
            hapusBuku.Show()
        Catch ex As Exception
            MessageBox.Show("Tidak dapat melakukan hapus. Error :" + ex.Message)
        End Try
    End Sub

    Private Sub ButtonEditBuku_Click(sender As Object, e As EventArgs) Handles ButtonEditBuku.Click
        Dim selectedBuku As List(Of String) = dataPenjualan.GetDataBukuByIDDatabase(selectedIdBuku)
        Try
            dataPenjualan.GSIdBuku = selectedIdBuku
            dataPenjualan.GSIdMobil = selectedBuku(1)
            dataPenjualan.GSIdPembeli = selectedBuku(2)
            dataPenjualan.GSHargaTerjual = selectedBuku(3)
            dataPenjualan.GSTanggalTerjual = selectedBuku(4)
            Dim formEditBuku = New EditBukuPenjualan
            formEditBuku.Show()
        Catch ex As Exception
            MessageBox.Show("Tidak dapat melakukan edit. Error :" + ex.Message)
        End Try
    End Sub
End Class
