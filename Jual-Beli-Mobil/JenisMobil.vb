Public Class JenisMobil
    Public Shared datajenismobil As DataJenisMobil
    Public selectedJenisID As Integer
    Public selectedJenisNamaMobil As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        datajenismobil = New DataJenisMobil()
        ReloadDataJenisMobilDatabase()
    End Sub

    Private Sub ReloadDataJenisMobilDatabase()
        DataGridViewJenisMobil.DataSource = datajenismobil.GetDataJenisMobilDatabase()
    End Sub

    Private Sub JenisMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataJenisMobilDatabase()
    End Sub

    Private Sub ButtonTambahJenisMobil_Click(sender As Object, e As EventArgs) Handles ButtonTambahJenisMobil.Click
        Dim tambahjenismobil = New TambahJenisMobil()
        tambahjenismobil.Show()
    End Sub

    Private Sub ButtonHapusJenisMobil_Click(sender As Object, e As EventArgs) Handles ButtonHapusJenisMobil.Click
        Dim hapusjenismobil = New HapusJenisMobil()
        hapusjenismobil.Show()
    End Sub

    Private Sub DataGridViewJenisMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJenisMobil.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJenisMobil.Rows(index)

        selectedJenisID = selectedRow.Cells(0).Value
        selectedJenisNamaMobil = selectedRow.Cells(1).Value
    End Sub

    Private Sub ButtonEditJenisMobil_Click(sender As Object, e As EventArgs) Handles ButtonEditJenisMobil.Click
        Dim editjenismobil = New EditJenisMobil()
        editjenismobil.Show()
    End Sub
End Class