<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahMobil
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
        Me.LabelTipeMobil = New System.Windows.Forms.Label()
        Me.TextBoxTipeMobil = New System.Windows.Forms.TextBox()
        Me.ComboBoxJenisMobil = New System.Windows.Forms.ComboBox()
        Me.TextBoxTahunPembuatan = New System.Windows.Forms.TextBox()
        Me.LabelTahunPembuatan = New System.Windows.Forms.Label()
        Me.TextBoxKondisi = New System.Windows.Forms.TextBox()
        Me.LabelKondisi = New System.Windows.Forms.Label()
        Me.TextBoxHarga = New System.Windows.Forms.TextBox()
        Me.LabelHarga = New System.Windows.Forms.Label()
        Me.TextBoxGaransi = New System.Windows.Forms.TextBox()
        Me.LabelGaransi = New System.Windows.Forms.Label()
        Me.LabelJenisMobil = New System.Windows.Forms.Label()
        Me.ButtonTambahMobil = New System.Windows.Forms.Button()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelTipeMobil
        '
        Me.LabelTipeMobil.AutoSize = True
        Me.LabelTipeMobil.Location = New System.Drawing.Point(12, 67)
        Me.LabelTipeMobil.Name = "LabelTipeMobil"
        Me.LabelTipeMobil.Size = New System.Drawing.Size(81, 20)
        Me.LabelTipeMobil.TabIndex = 0
        Me.LabelTipeMobil.Text = "Tipe Mobil"
        '
        'TextBoxTipeMobil
        '
        Me.TextBoxTipeMobil.Location = New System.Drawing.Point(161, 64)
        Me.TextBoxTipeMobil.Name = "TextBoxTipeMobil"
        Me.TextBoxTipeMobil.Size = New System.Drawing.Size(151, 27)
        Me.TextBoxTipeMobil.TabIndex = 1
        '
        'ComboBoxJenisMobil
        '
        Me.ComboBoxJenisMobil.FormattingEnabled = True
        Me.ComboBoxJenisMobil.Location = New System.Drawing.Point(161, 102)
        Me.ComboBoxJenisMobil.Name = "ComboBoxJenisMobil"
        Me.ComboBoxJenisMobil.Size = New System.Drawing.Size(151, 28)
        Me.ComboBoxJenisMobil.TabIndex = 3
        '
        'TextBoxTahunPembuatan
        '
        Me.TextBoxTahunPembuatan.Location = New System.Drawing.Point(161, 179)
        Me.TextBoxTahunPembuatan.Name = "TextBoxTahunPembuatan"
        Me.TextBoxTahunPembuatan.Size = New System.Drawing.Size(151, 27)
        Me.TextBoxTahunPembuatan.TabIndex = 9
        '
        'LabelTahunPembuatan
        '
        Me.LabelTahunPembuatan.AutoSize = True
        Me.LabelTahunPembuatan.Location = New System.Drawing.Point(12, 182)
        Me.LabelTahunPembuatan.Name = "LabelTahunPembuatan"
        Me.LabelTahunPembuatan.Size = New System.Drawing.Size(117, 20)
        Me.LabelTahunPembuatan.TabIndex = 8
        Me.LabelTahunPembuatan.Text = "Tahun Perbuatan"
        '
        'TextBoxKondisi
        '
        Me.TextBoxKondisi.Location = New System.Drawing.Point(161, 218)
        Me.TextBoxKondisi.Name = "TextBoxKondisi"
        Me.TextBoxKondisi.Size = New System.Drawing.Size(151, 27)
        Me.TextBoxKondisi.TabIndex = 11
        '
        'LabelKondisi
        '
        Me.LabelKondisi.AutoSize = True
        Me.LabelKondisi.Location = New System.Drawing.Point(12, 221)
        Me.LabelKondisi.Name = "LabelKondisi"
        Me.LabelKondisi.Size = New System.Drawing.Size(58, 20)
        Me.LabelKondisi.TabIndex = 10
        Me.LabelKondisi.Text = "Kondisi"
        '
        'TextBoxHarga
        '
        Me.TextBoxHarga.Location = New System.Drawing.Point(161, 141)
        Me.TextBoxHarga.Name = "TextBoxHarga"
        Me.TextBoxHarga.Size = New System.Drawing.Size(151, 27)
        Me.TextBoxHarga.TabIndex = 13
        '
        'LabelHarga
        '
        Me.LabelHarga.AutoSize = True
        Me.LabelHarga.Location = New System.Drawing.Point(12, 144)
        Me.LabelHarga.Name = "LabelHarga"
        Me.LabelHarga.Size = New System.Drawing.Size(50, 20)
        Me.LabelHarga.TabIndex = 12
        Me.LabelHarga.Text = "Harga"
        '
        'TextBoxGaransi
        '
        Me.TextBoxGaransi.Location = New System.Drawing.Point(161, 256)
        Me.TextBoxGaransi.Name = "TextBoxGaransi"
        Me.TextBoxGaransi.Size = New System.Drawing.Size(151, 27)
        Me.TextBoxGaransi.TabIndex = 15
        '
        'LabelGaransi
        '
        Me.LabelGaransi.AutoSize = True
        Me.LabelGaransi.Location = New System.Drawing.Point(12, 259)
        Me.LabelGaransi.Name = "LabelGaransi"
        Me.LabelGaransi.Size = New System.Drawing.Size(58, 20)
        Me.LabelGaransi.TabIndex = 14
        Me.LabelGaransi.Text = "Garansi"
        '
        'LabelJenisMobil
        '
        Me.LabelJenisMobil.AutoSize = True
        Me.LabelJenisMobil.Location = New System.Drawing.Point(13, 105)
        Me.LabelJenisMobil.Name = "LabelJenisMobil"
        Me.LabelJenisMobil.Size = New System.Drawing.Size(83, 20)
        Me.LabelJenisMobil.TabIndex = 16
        Me.LabelJenisMobil.Text = "Jenis Mobil"
        '
        'ButtonTambahMobil
        '
        Me.ButtonTambahMobil.Location = New System.Drawing.Point(218, 303)
        Me.ButtonTambahMobil.Name = "ButtonTambahMobil"
        Me.ButtonTambahMobil.Size = New System.Drawing.Size(94, 29)
        Me.ButtonTambahMobil.TabIndex = 17
        Me.ButtonTambahMobil.Text = "Tambah"
        Me.ButtonTambahMobil.UseVisualStyleBackColor = True
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTitle.Location = New System.Drawing.Point(4, 9)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(199, 38)
        Me.LabelTitle.TabIndex = 18
        Me.LabelTitle.Text = "Tambah Mobil"
        '
        'TambahMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 361)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.ButtonTambahMobil)
        Me.Controls.Add(Me.LabelJenisMobil)
        Me.Controls.Add(Me.TextBoxGaransi)
        Me.Controls.Add(Me.LabelGaransi)
        Me.Controls.Add(Me.TextBoxHarga)
        Me.Controls.Add(Me.LabelHarga)
        Me.Controls.Add(Me.TextBoxKondisi)
        Me.Controls.Add(Me.LabelKondisi)
        Me.Controls.Add(Me.TextBoxTahunPembuatan)
        Me.Controls.Add(Me.LabelTahunPembuatan)
        Me.Controls.Add(Me.ComboBoxJenisMobil)
        Me.Controls.Add(Me.TextBoxTipeMobil)
        Me.Controls.Add(Me.LabelTipeMobil)
        Me.Name = "TambahMobil"
        Me.Text = "TambahMobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTipeMobil As Label
    Friend WithEvents TextBoxTipeMobil As TextBox
    Friend WithEvents ComboBoxJenisMobil As ComboBox
    Friend WithEvents TextBoxTahunPembuatan As TextBox
    Friend WithEvents LabelTahunPembuatan As Label
    Friend WithEvents TextBoxKondisi As TextBox
    Friend WithEvents LabelKondisi As Label
    Friend WithEvents TextBoxHarga As TextBox
    Friend WithEvents LabelHarga As Label
    Friend WithEvents TextBoxGaransi As TextBox
    Friend WithEvents LabelGaransi As Label
    Friend WithEvents LabelJenisMobil As Label
    Friend WithEvents ButtonTambahMobil As Button
    Friend WithEvents LabelTitle As Label
End Class
