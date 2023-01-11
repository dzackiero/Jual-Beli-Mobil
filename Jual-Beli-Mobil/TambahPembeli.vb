Public Class TambahPembeli

    Private Sub OnlyNumberTextBox(sender As Object, e As KeyPressEventArgs) Handles TextBox_nik.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            'MessageBox.Show("Hanya Menerima Angka")
        End If
    End Sub

    Private Sub btntambahpembeli_Click(sender As Object, e As EventArgs) Handles btntambahpembeli.Click
        Try
            Pembeli.dataPembeli.GSnik = TextBox_nik.Text
            Pembeli.dataPembeli.GSnama = TextBox_nama.Text
            Pembeli.dataPembeli.GSalamat = RichTextBox_alamat.Text

            Pembeli.dataPembeli.AddDataPembeliDatabase(
                                               Pembeli.dataPembeli.GSnik,
                                               Pembeli.dataPembeli.GSnama,
                                               Pembeli.dataPembeli.GSalamat
                                               )

            MessageBox.Show("Berhasil Menambahkan Mobil")
            Close()
        Catch ex As Exception
            MessageBox.Show("Masukan data dengan sesuai. Error: " + ex.Message)
        End Try
    End Sub
End Class