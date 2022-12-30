Public Class EditJenisMobil
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TextBoxEditJenis.Text = JenisMobil.datajenismobil.GSJenis
    End Sub

    Private Sub ButtonEditJenis_Click(sender As Object, e As EventArgs) Handles ButtonEditJenis.Click
        JenisMobil.datajenismobil.GSJenis = TextBoxEditJenis.Text.ToString()

        JenisMobil.datajenismobil.EditDataJenisMobilByIDDatabase(JenisMobil.selectedJenisID,
                                                               JenisMobil.datajenismobil.GSJenis
                                                               )
        Me.Close()
    End Sub
End Class