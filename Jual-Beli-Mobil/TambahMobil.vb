Public Class TambahMobil

    Private Sub OnlyNumberTextBox(sender As Object, e As KeyPressEventArgs) Handles TextBoxHarga.KeyPress, TextBoxTahunPembuatan.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            'MessageBox.Show("Hanya Menerima Angka")
        End If
    End Sub

    Private Sub ButtonTambahMobil_Click(sender As Object, e As EventArgs) Handles ButtonTambahMobil.Click
        Mobil.dataMobil.gs
    End Sub
End Class