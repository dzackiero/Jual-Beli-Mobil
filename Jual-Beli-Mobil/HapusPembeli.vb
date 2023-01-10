Public Class HapusPembeli

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Label_datahapuspembeli.Text = Pembeli.selectedIdPembeli
    End Sub
    Private Sub Button_hapuspembeli_Click(sender As Object, e As EventArgs) Handles Button_hapuspembeli.Click
        Pembeli.dataPembeli.DeleteDataPembeliDatabase(Pembeli.selectedIdPembeli)
        MessageBox.Show("Berhasil dihapus!")
        Close()
    End Sub
End Class