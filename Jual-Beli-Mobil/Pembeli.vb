Public Class Pembeli
    Public Shared dataPembeli As DataPembeli
    Public selectedIdPembeli As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataPembeli = New DataPembeli()
        ReloadDataTableDatabase()
    End Sub

    Private Sub Pembeli_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Public Sub ReloadDataTableDatabase()
        Dim datas = dataPembeli.GetDataPembeliDatabase()
        DataGridViewPembeli.DataSource = dataPembeli.GetDataPembeliDatabase()
    End Sub

    Private Sub Button_tambahpembeli_Click(sender As Object, e As EventArgs) Handles Button_tambahpembeli.Click
        Dim tambahPembeli = New TambahPembeli()
        tambahPembeli.Show()
    End Sub



    Private Sub Button_editpembeli_Click(sender As Object, e As EventArgs) Handles Button_editpembeli.Click
        Dim selectedPembeli As List(Of String) = dataPembeli.GetDataPembeliByIDDatabase(selectedIdPembeli)
        Try
            dataPembeli.GSIdPembeli = selectedIdPembeli
            dataPembeli.GSnik = selectedPembeli(0)
            dataPembeli.GSnama = selectedPembeli(1)
            dataPembeli.GSalamat = selectedPembeli(2)

            Dim editPembeli = New EditPembeli()
            editPembeli.Show()
        Catch ex As Exception
            MessageBox.Show("TIdak dapat melakukan edit. Error :" + ex.Message)

        End Try
    End Sub

    Private Sub Button_hapuspembeli_Click(sender As Object, e As EventArgs) Handles Button_hapuspembeli.Click
        Try
            Dim selectedPembeli As List(Of String) = dataPembeli.GetDataPembeliByIDDatabase(selectedIdPembeli)

            dataPembeli.GSIdPembeli = selectedIdPembeli
            dataPembeli.GSnama = selectedPembeli(1)

            Dim hapusMobil = New HapusPembeli()
            HapusPembeli.Show()
        Catch ex As Exception
            MessageBox.Show("Tidak dapat melakukan hapus. Error:" + ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewPembeli_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPembeli.CellClick
        Try
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewPembeli.Rows(index)

            selectedIdPembeli = Int(selectedRow.Cells(0).Value)
        Catch ex As Exception
            MessageBox.Show("Tidak ada data disini.")
        End Try
    End Sub

End Class
