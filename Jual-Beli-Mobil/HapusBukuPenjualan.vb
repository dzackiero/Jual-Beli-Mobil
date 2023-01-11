Public Class HapusBukuPenjualan
    Dim idbuku As Integer
    Public Sub New(id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelNama.Text = id
        idbuku = id


    End Sub
    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        BukuPenjualan.dataPenjualan.DeleteDataBukuDatabase(idbuku)
        MessageBox.Show("Berhasil dihapus!")
        Close()

    End Sub
End Class