Public Class Mobil
    Public Shared dataMobil As DataMobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        dataMobil = New DataMobil()
    End Sub

    Public Sub ReloadDataTableDatabase()
        DataGridViewMobil.DataSource = dataMobil.GetDataMobilDatabase()
    End Sub

    Private Sub ButtonTambahMobil_Click(sender As Object, e As EventArgs) Handles ButtonTambahMobil.Click
        Dim tambahMobil = New TambahMobil()
        tambahMobil.Show()
    End Sub
End Class