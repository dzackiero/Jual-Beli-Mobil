Public Class TambahMobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dsJenisMobil = Mobil.dataJenisMobil.GetDataJenisMobilDatabase
        ComboBoxJenisMobil.DataSource = dsJenisMobil
        ComboBoxJenisMobil.ValueMember = "ID"
        ComboBoxJenisMobil.DisplayMember = "Jenis Mobil"
    End Sub



    Private Sub OnlyNumberTextBox(sender As Object, e As KeyPressEventArgs) Handles TextBoxHarga.KeyPress, TextBoxTahunPembuatan.KeyPress, TextBoxGaransi.KeyPress, TextBoxHargaDefault.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            'MessageBox.Show("Hanya Menerima Angka")
        End If
    End Sub

    Private Sub ButtonTambahMobil_Click(sender As Object, e As EventArgs) Handles ButtonTambahMobil.Click

        Try
            Mobil.dataMobil.GSTipeMobil = TextBoxTipeMobil.Text
            Mobil.dataMobil.GSJenisMobil = CInt(ComboBoxJenisMobil.SelectedItem()(0))
            Mobil.dataMobil.GSHarga = TextBoxHarga.Text
            Mobil.dataMobil.GSHargaDefault = TextBoxHargaDefault.Text
            Mobil.dataMobil.GSTahunPembuatan = TextBoxTahunPembuatan.Text
            Mobil.dataMobil.GSKondisi = TextBoxKondisi.Text
            Mobil.dataMobil.GSGaransi = TextBoxGaransi.Text

            Mobil.dataMobil.AddDataMobilDatabase(
                                         Mobil.dataMobil.GSTipeMobil,
                                         Mobil.dataMobil.GSJenisMobil,
                                         Mobil.dataMobil.GSHarga,
                                         Mobil.dataMobil.GSHargaDefault,
                                         Mobil.dataMobil.GSTahunPembuatan,
                                         Mobil.dataMobil.GSKondisi,
                                         Mobil.dataMobil.GSGaransi
                                        )
            MessageBox.Show("Berhasil Menambahkan Mobil")
            Close()
        Catch ex As Exception
            MessageBox.Show("Masukan Data Dengan Sesuai. Error: " + ex.Message)
        End Try

    End Sub

End Class