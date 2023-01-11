Public Class TambahBukuPenjualan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dateTimePickerTanggalPenjualan.CustomFormat = "yyyy-MM-dd"
        Try
        Dim dataSourceMobil = BukuPenjualan.dataMobil.GetDataMobilDatabase
            comboBoxTipeMobil.DataSource = dataSourceMobil
            comboBoxTipeMobil.ValueMember = "ID"
            comboBoxTipeMobil.DisplayMember = "Tipe Mobil"

            Dim dataSourcePembeli = BukuPenjualan.dataPembeli.GetDataPembeliDatabase
            ComboBoxPembeli.DataSource = dataSourcePembeli
            ComboBoxPembeli.ValueMember = "id"
            ComboBoxPembeli.DisplayMember = "Nama"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
            BukuPenjualan.dataPenjualan.GSTanggalTerjual = dateTimePickerTanggalPenjualan.Value.ToString("yyyy-M-dd")

            BukuPenjualan.dataPenjualan.AddDataBukuDatabase(
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

    Private Sub comboBoxTipeMobil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxTipeMobil.SelectedIndexChanged

    End Sub

    Private Sub LabelHargaDefault_Click(sender As Object, e As EventArgs) Handles LabelHargaDefault.Click

    End Sub

    Private Sub LabelTitle_Click(sender As Object, e As EventArgs) Handles LabelTitle.Click

    End Sub

    Private Sub dateTimePickerTanggalPenjualan_ValueChanged(sender As Object, e As EventArgs) Handles dateTimePickerTanggalPenjualan.ValueChanged

    End Sub

    Private Sub LabelPembeli_Click(sender As Object, e As EventArgs) Handles LabelPembeli.Click

    End Sub

    Private Sub TextBoxHargaTerjual_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHargaTerjual.TextChanged

    End Sub

    Private Sub LabelHarga_Click(sender As Object, e As EventArgs) Handles LabelHarga.Click

    End Sub

    Private Sub ComboBoxPembeli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPembeli.SelectedIndexChanged

    End Sub

    Private Sub LabelTipeMobil_Click(sender As Object, e As EventArgs) Handles LabelTipeMobil.Click

    End Sub
End Class