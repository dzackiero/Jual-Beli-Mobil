Public Class TambahBukuPenjualan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dataSourceMobil = BukuPenjualan.dataMobil.GetDataMobilDatabase
        comboBoxTipeMobil.DataSource = dataSourceMobil
        comboBoxTipeMobil.ValueMember = "ID"
        comboBoxTipeMobil.DisplayMember = "Tipe Mobil"
    End Sub



    Private Sub OnlyNumberTextBox(sender As Object, e As KeyPressEventArgs) Handles TextBoxHargaTerjual.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            'MessageBox.Show("Hanya Menerima Angka")
        End If
    End Sub

    Private Sub ButtonTambahMobil_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click

        Try
            BukuPenjualan.dataPenjualan.GSIdPembeli = CInt(ComboBoxPembeli.SelectedItem()(0))
            BukuPenjualan.dataPenjualan.GSIdMobil = CInt(comboBoxTipeMobil.SelectedItem()(0))
            BukuPenjualan.dataPenjualan.GSHargaTerjual = TextBoxHargaTerjual.Text
            BukuPenjualan.dataPenjualan.GSTanggalTerjual = dateTimePickerTanggalPenjualan.Value

            BukuPenjualan.dataPenjualan.AddDataBukuDatabase(
                                            BukuPenjualan.dataPenjualan.GSIdPembeli,
                                            BukuPenjualan.dataPenjualan.GSIdMobil,
                                            BukuPenjualan.dataPenjualan.GSHargaTerjual,
                                            BukuPenjualan.dataPenjualan.GSTanggalTerjual
                                        )
            MessageBox.Show("Berhasil Menambahkan Buku Penjualan")
            Close()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class