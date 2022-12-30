Public Class EditMobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim dsJenisMobil = Mobil.dataJenisMobil.GetDataJenisMobilDatabase
        ComboBoxJenisMobil.DataSource = dsJenisMobil
        ComboBoxJenisMobil.ValueMember = "ID"
        ComboBoxJenisMobil.DisplayMember = "Jenis Mobil"

        TextBoxTipeMobil.Text = Mobil.dataMobil.GSTipeMobil
        ComboBoxJenisMobil.SelectedValue = Mobil.dataMobil.GSJenisMobil
        TextBoxHarga.Text = Mobil.dataMobil.GSHarga
        TextBoxHargaDefault.Text = Mobil.dataMobil.GSHargaDefault
        TextBoxTahunPembuatan.Text = Mobil.dataMobil.GSTahunPembuatan
        TextBoxKondisi.Text = Mobil.dataMobil.GSKondisi
        TextBoxGaransi.Text = Mobil.dataMobil.GSGaransi
    End Sub
    Private Sub ButtonEditMobil_Click(sender As Object, e As EventArgs) Handles ButtonEditMobil.Click
        Try
            Mobil.dataMobil.GSTipeMobil = TextBoxTipeMobil.Text
            Mobil.dataMobil.GSJenisMobil = CInt(ComboBoxJenisMobil.SelectedItem()(0))
            Mobil.dataMobil.GSHarga = TextBoxHarga.Text
            Mobil.dataMobil.GSHargaDefault = TextBoxHargaDefault.Text
            Mobil.dataMobil.GSTahunPembuatan = TextBoxTahunPembuatan.Text
            Mobil.dataMobil.GSKondisi = TextBoxKondisi.Text
            Mobil.dataMobil.GSGaransi = TextBoxGaransi.Text

            Mobil.dataMobil.EditDataMobilByIDDatabase(
                                         Mobil.dataMobil.GSIdMobil,
                                         Mobil.dataMobil.GSTipeMobil,
                                         Mobil.dataMobil.GSJenisMobil,
                                         Mobil.dataMobil.GSHarga,
                                         Mobil.dataMobil.GSHargaDefault,
                                         Mobil.dataMobil.GSTahunPembuatan,
                                         Mobil.dataMobil.GSKondisi,
                                         Mobil.dataMobil.GSGaransi
                                        )
            MessageBox.Show("Berhasil Mengedit Mobil")
            Close()
        Catch ex As Exception
            MessageBox.Show("Masukan Data Dengan Sesuai. Error: " + ex.Message)
        End Try
    End Sub

    Private Sub OnlyNumberTextBox(sender As Object, e As KeyPressEventArgs) Handles TextBoxHarga.KeyPress, TextBoxTahunPembuatan.KeyPress, TextBoxGaransi.KeyPress, TextBoxHargaDefault.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            'MessageBox.Show("Hanya Menerima Angka")
        End If
    End Sub
End Class