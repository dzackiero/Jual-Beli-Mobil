Public Class EditBukuPenjualan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dataSourceMobil = BukuPenjualan.dataMobil.GetDataMobilDatabase
        comboBoxTipeMobil.DataSource = dataSourceMobil
        comboBoxTipeMobil.ValueMember = "ID"
        comboBoxTipeMobil.DisplayMember = "Tipe Mobil"

        Dim dataSourcePembeli = BukuPenjualan.dataPembeli.GetDataPembeliDatabase
        ComboBoxPembeli.DataSource = dataSourcePembeli
        ComboBoxPembeli.ValueMember = "id"
        ComboBoxPembeli.DisplayMember = "Nama"

        TextBoxHargaTerjual.Text = BukuPenjualan.dataPenjualan.GSHargaTerjual
        dateTimePickerTanggalPenjualan.Value = Date.Parse(BukuPenjualan.dataPenjualan.GSTanggalTerjual)
    End Sub
    Private Sub ButtonUbah_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        Try
            BukuPenjualan.dataPenjualan.GSIdPembeli = CInt(ComboBoxPembeli.SelectedItem()(0))
            BukuPenjualan.dataPenjualan.GSIdMobil = CInt(comboBoxTipeMobil.SelectedItem()(0))
            BukuPenjualan.dataPenjualan.GSHargaTerjual = TextBoxHargaTerjual.Text
            BukuPenjualan.dataPenjualan.GSTanggalTerjual = dateTimePickerTanggalPenjualan.Value.ToString("yyyy-M-dd")

            BukuPenjualan.dataPenjualan.EditDataBukuByIDDatabase(
                                            BukuPenjualan.dataPenjualan.GSIdBuku,
                                            BukuPenjualan.dataPenjualan.GSIdMobil,
                                            BukuPenjualan.dataPenjualan.GSIdPembeli,
                                            BukuPenjualan.dataPenjualan.GSHargaTerjual,
                                            BukuPenjualan.dataPenjualan.GSTanggalTerjual
                                        )
            MessageBox.Show("Berhasil Menambahkan Buku Penjualan")
            Close()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub OnlyNumberTextBox(sender As Object, e As KeyPressEventArgs) Handles TextBoxHargaTerjual.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            'MessageBox.Show("Hanya Menerima Angka")
        End If
    End Sub

End Class