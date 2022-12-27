Public Class JenisMobil
    Public Shared datajenismobil As DataJenisMobil

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
End Class