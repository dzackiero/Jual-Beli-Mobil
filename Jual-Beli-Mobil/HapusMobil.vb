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

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click

    End Sub

    Private Sub LabelNama_Click(sender As Object, e As EventArgs) Handles LabelNama.Click

    End Sub

    Private Sub LabelTitle_Click(sender As Object, e As EventArgs) Handles LabelTitle.Click

    End Sub
End Class