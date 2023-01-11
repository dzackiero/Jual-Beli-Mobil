<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditBukuPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dateTimePickerTanggalPenjualan = New System.Windows.Forms.DateTimePicker()
        Me.comboBoxTipeMobil = New System.Windows.Forms.ComboBox()
        Me.LabelHargaDefault = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.LabelPembeli = New System.Windows.Forms.Label()
        Me.TextBoxHargaTerjual = New System.Windows.Forms.TextBox()
        Me.LabelHarga = New System.Windows.Forms.Label()
        Me.ComboBoxPembeli = New System.Windows.Forms.ComboBox()
        Me.LabelTipeMobil = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dateTimePickerTanggalPenjualan
        '
        Me.dateTimePickerTanggalPenjualan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimePickerTanggalPenjualan.Location = New System.Drawing.Point(149, 136)
        Me.dateTimePickerTanggalPenjualan.Name = "dateTimePickerTanggalPenjualan"
        Me.dateTimePickerTanggalPenjualan.Size = New System.Drawing.Size(133, 23)
        Me.dateTimePickerTanggalPenjualan.TabIndex = 47
        '
        'comboBoxTipeMobil
        '
        Me.comboBoxTipeMobil.FormattingEnabled = True
        Me.comboBoxTipeMobil.Location = New System.Drawing.Point(149, 49)
        Me.comboBoxTipeMobil.Name = "comboBoxTipeMobil"
        Me.comboBoxTipeMobil.Size = New System.Drawing.Size(133, 23)
        Me.comboBoxTipeMobil.TabIndex = 46
        '
        'LabelHargaDefault
        '
        Me.LabelHargaDefault.AutoSize = True
        Me.LabelHargaDefault.Location = New System.Drawing.Point(18, 138)
        Me.LabelHargaDefault.Name = "LabelHargaDefault"
        Me.LabelHargaDefault.Size = New System.Drawing.Size(103, 15)
        Me.LabelHargaDefault.TabIndex = 45
        Me.LabelHargaDefault.Text = "Tanggal Penjualan"
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTitle.Location = New System.Drawing.Point(12, 9)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(211, 30)
        Me.LabelTitle.TabIndex = 44
        Me.LabelTitle.Text = "Edit Buku Penjualan"
        '
        'ButtonUbah
        '
        Me.ButtonUbah.Location = New System.Drawing.Point(199, 258)
        Me.ButtonUbah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(82, 22)
        Me.ButtonUbah.TabIndex = 41
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = True
        '
        'LabelPembeli
        '
        Me.LabelPembeli.AutoSize = True
        Me.LabelPembeli.Location = New System.Drawing.Point(19, 81)
        Me.LabelPembeli.Name = "LabelPembeli"
        Me.LabelPembeli.Size = New System.Drawing.Size(50, 15)
        Me.LabelPembeli.TabIndex = 43
        Me.LabelPembeli.Text = "Pembeli"
        '
        'TextBoxHargaTerjual
        '
        Me.TextBoxHargaTerjual.Location = New System.Drawing.Point(149, 108)
        Me.TextBoxHargaTerjual.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxHargaTerjual.Name = "TextBoxHargaTerjual"
        Me.TextBoxHargaTerjual.Size = New System.Drawing.Size(133, 23)
        Me.TextBoxHargaTerjual.TabIndex = 40
        '
        'LabelHarga
        '
        Me.LabelHarga.AutoSize = True
        Me.LabelHarga.Location = New System.Drawing.Point(18, 110)
        Me.LabelHarga.Name = "LabelHarga"
        Me.LabelHarga.Size = New System.Drawing.Size(39, 15)
        Me.LabelHarga.TabIndex = 42
        Me.LabelHarga.Text = "Harga"
        '
        'ComboBoxPembeli
        '
        Me.ComboBoxPembeli.FormattingEnabled = True
        Me.ComboBoxPembeli.Location = New System.Drawing.Point(149, 78)
        Me.ComboBoxPembeli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxPembeli.Name = "ComboBoxPembeli"
        Me.ComboBoxPembeli.Size = New System.Drawing.Size(133, 23)
        Me.ComboBoxPembeli.TabIndex = 39
        '
        'LabelTipeMobil
        '
        Me.LabelTipeMobil.AutoSize = True
        Me.LabelTipeMobil.Location = New System.Drawing.Point(18, 52)
        Me.LabelTipeMobil.Name = "LabelTipeMobil"
        Me.LabelTipeMobil.Size = New System.Drawing.Size(63, 15)
        Me.LabelTipeMobil.TabIndex = 38
        Me.LabelTipeMobil.Text = "Tipe Mobil"
        '
        'EditBukuPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 293)
        Me.Controls.Add(Me.dateTimePickerTanggalPenjualan)
        Me.Controls.Add(Me.comboBoxTipeMobil)
        Me.Controls.Add(Me.LabelHargaDefault)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.LabelPembeli)
        Me.Controls.Add(Me.TextBoxHargaTerjual)
        Me.Controls.Add(Me.LabelHarga)
        Me.Controls.Add(Me.ComboBoxPembeli)
        Me.Controls.Add(Me.LabelTipeMobil)
        Me.Name = "EditBukuPenjualan"
        Me.Text = "EditBukuPenjualan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dateTimePickerTanggalPenjualan As DateTimePicker
    Friend WithEvents comboBoxTipeMobil As ComboBox
    Friend WithEvents LabelHargaDefault As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents ButtonUbah As Button
    Friend WithEvents LabelPembeli As Label
    Friend WithEvents TextBoxHargaTerjual As TextBox
    Friend WithEvents LabelHarga As Label
    Friend WithEvents ComboBoxPembeli As ComboBox
    Friend WithEvents LabelTipeMobil As Label
End Class
