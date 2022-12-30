Public Class HapusJenisMobil
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelHapusJenis.Text = JenisMobil.selectedJenisNamaMobil + " ?"
    End Sub

    Private Sub ButtonHapusJenis_Click(sender As Object, e As EventArgs) Handles ButtonHapusJenis.Click
        JenisMobil.datajenismobil.DeleteDataJenisMobilDatabase(JenisMobil.selectedJenisID)
        Me.Close()
    End Sub
End Class