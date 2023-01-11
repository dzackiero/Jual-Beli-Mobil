Public Class Mobil
    Public Shared dataMobil As DataMobil
    Public Shared dataJenisMobil As DataJenisMobil
    Public selectedIdMobil As Integer
    Public selectedJenisMobil As Integer


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        dataMobil = New DataMobil()
        dataJenisMobil = New DataJenisMobil()
        ReloadDataTableDatabase()
    End Sub

    Private Sub Mobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Public Sub ReloadDataTableDatabase()
        Dim datas = dataMobil.GetDataMobilDatabase()
        DataGridViewMobil.DataSource = dataMobil.GetDataMobilDatabase()
    End Sub

    Private Sub ButtonTambahMobil_Click(sender As Object, e As EventArgs) Handles ButtonTambahMobil.Click
        Dim tambahMobil = New TambahMobil()
        tambahMobil.Show()
    End Sub

    Private Sub ButtonJenisMobil_Click(sender As Object, e As EventArgs) Handles ButtonJenisMobil.Click
        Dim jenisMobil = New JenisMobil()
        jenisMobil.Show()
    End Sub

    Private Sub DataGridViewMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMobil.CellClick
        Try
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewMobil.Rows(index)

            selectedIdMobil = Int(selectedRow.Cells(0).Value)
            selectedJenisMobil = Int(selectedRow.Cells(1).Value)

        Catch ex As Exception
            MessageBox.Show("Tidak Ada Data Disini.")
        End Try
    End Sub

    Private Sub ButtonEditMobil_Click(sender As Object, e As EventArgs) Handles ButtonEditMobil.Click
        Dim selectedMobil As List(Of String) = dataMobil.GetDataMobilByIDDatabase(selectedIdMobil)
        Try
            dataMobil.GSIdMobil = selectedIdMobil
            dataMobil.GSTipeMobil = selectedMobil(0)
            dataMobil.GSJenisMobil = selectedMobil(1)
            dataMobil.GSTahunPembuatan = selectedMobil(2)
            dataMobil.GSKondisi = selectedMobil(3)
            dataMobil.GSHarga = selectedMobil(4)
            dataMobil.GSGaransi = selectedMobil(5)
            dataMobil.GSHargaDefault = selectedMobil(6)

            Dim editMobil = New EditMobil()
            editMobil.Show()
        Catch ex As Exception
            MessageBox.Show("Tidak dapat melakukan edit. Error :" + ex.Message)
        End Try
    End Sub

    Private Sub ButtonHapusMobil_Click(sender As Object, e As EventArgs) Handles ButtonHapusMobil.Click
        Try

            Dim hapusMobil = New HapusMobil()
            hapusMobil.Show()
        Catch ex As Exception
            MessageBox.Show("Tidak dapat melakukan hapus. Error :" + ex.Message)
        End Try

    End Sub
End Class