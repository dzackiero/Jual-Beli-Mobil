Public Class TambahJenisMobil
    Private Sub ButtonTambahJenis_Click(sender As Object, e As EventArgs) Handles ButtonTambahJenis.Click
        Dim tambahjenis = TextBoxTambahJenisMobil.Text
        JenisMobil.datajenismobil.AddJenisMobilDatabase(tambahjenis)
        Me.Close()
    End Sub
End Class