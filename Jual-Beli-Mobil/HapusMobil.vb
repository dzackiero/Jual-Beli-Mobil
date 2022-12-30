Public Class HapusMobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelNama.Text = Mobil.selectedIdMobil
    End Sub
    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Mobil.dataMobil.DeleteDataMobilDatabase(Mobil.selectedIdMobil)
        MessageBox.Show("Berhasil dihapus!")
        Close()
    End Sub
End Class