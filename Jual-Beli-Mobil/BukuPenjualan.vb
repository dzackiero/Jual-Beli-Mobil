Public Class BukuPenjualan
    Public Shared dataMobil As DataMobil
    Public Shared dataPenjualan As DataBukuPenjualan
    'Public Shared dataPenjual As DataPenjual

    Public selectedIdMobil As Integer
    Public selectedJenisMobil As Integer


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataPenjualan = New DataBukuPenjualan
        dataMobil = New DataMobil()
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

            selectedIdMobil = Int(selectedRow.Cells(0).Value)
            selectedJenisMobil = Int(selectedRow.Cells(1).Value)

        Catch ex As Exception
            MessageBox.Show("Tidak Ada Data Disini.")
        End Try
    End Sub

    'Private Sub ButtonEditMobil_Click(sender As Object, e As EventArgs) Handles ButtonEditMobil.Click
    '    Dim selectedMobil As List(Of String) = dataMobil.GetDataMobilByIDDatabase(selectedIdMobil)
    '    Try
    '        dataMobil.GSIdMobil = selectedIdMobil
    '        dataMobil.GSTipeMobil = selectedMobil(0)
    '        dataMobil.GSJenisMobil = selectedMobil(1)
    '        dataMobil.GSTahunPembuatan = selectedMobil(2)
    '        dataMobil.GSKondisi = selectedMobil(3)
    '        dataMobil.GSHarga = selectedMobil(4)
    '        dataMobil.GSGaransi = selectedMobil(5)
    '        dataMobil.GSHargaDefault = selectedMobil(6)
    '        Dim editMobil = New EditMobil()
    '        editMobil.Show()
    '    Catch ex As Exception
    '        MessageBox.Show("Tidak dapat melakukan edit. Error :" + ex.Message)
    '    End Try
    'End Sub

    'Private Sub ButtonHapusMobil_Click(sender As Object, e As EventArgs) Handles ButtonHapusMobil.Click
    '    Try
    '        Dim selectedMobil As List(Of String) = dataMobil.GetDataMobilByIDDatabase(selectedIdMobil)
    '        selectedJenisMobil = selectedMobil(1)
    '        Dim hapusMobil = New HapusMobil()
    '        hapusMobil.Show()
    '    Catch ex As Exception
    '        MessageBox.Show("Tidak dapat melakukan hapus. Error :" + ex.Message)
    '    End Try
    'End Sub
    Private Sub ButtonTambahBuku_Click(sender As Object, e As EventArgs) Handles ButtonTambahBuku.Click
        Dim formTambahBuku = New TambahBukuPenjualan
        formTambahBuku.Show()

    End Sub
End Class
