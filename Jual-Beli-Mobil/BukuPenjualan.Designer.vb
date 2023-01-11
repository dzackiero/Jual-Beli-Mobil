<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BukuPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonHapusBuku = New System.Windows.Forms.Button()
        Me.ButtonEditBuku = New System.Windows.Forms.Button()
        Me.ButtonTambahBuku = New System.Windows.Forms.Button()
        Me.LabelMobil = New System.Windows.Forms.Label()
        Me.DataGridViewBuku = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mobil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pembeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga_Terjual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tanggal_Penjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonHapusBuku
        '
        Me.ButtonHapusBuku.Location = New System.Drawing.Point(522, 13)
        Me.ButtonHapusBuku.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonHapusBuku.Name = "ButtonHapusBuku"
        Me.ButtonHapusBuku.Size = New System.Drawing.Size(82, 22)
        Me.ButtonHapusBuku.TabIndex = 15
        Me.ButtonHapusBuku.Text = "Hapus"
        Me.ButtonHapusBuku.UseVisualStyleBackColor = True
        '
        'ButtonEditBuku
        '
        Me.ButtonEditBuku.Location = New System.Drawing.Point(609, 13)
        Me.ButtonEditBuku.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEditBuku.Name = "ButtonEditBuku"
        Me.ButtonEditBuku.Size = New System.Drawing.Size(82, 22)
        Me.ButtonEditBuku.TabIndex = 14
        Me.ButtonEditBuku.Text = "Edit"
        Me.ButtonEditBuku.UseVisualStyleBackColor = True
        '
        'ButtonTambahBuku
        '
        Me.ButtonTambahBuku.Location = New System.Drawing.Point(434, 13)
        Me.ButtonTambahBuku.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonTambahBuku.Name = "ButtonTambahBuku"
        Me.ButtonTambahBuku.Size = New System.Drawing.Size(82, 22)
        Me.ButtonTambahBuku.TabIndex = 13
        Me.ButtonTambahBuku.Text = "Tambah"
        Me.ButtonTambahBuku.UseVisualStyleBackColor = True
        '
        'LabelMobil
        '
        Me.LabelMobil.AutoSize = True
        Me.LabelMobil.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelMobil.Location = New System.Drawing.Point(12, 9)
        Me.LabelMobil.Name = "LabelMobil"
        Me.LabelMobil.Size = New System.Drawing.Size(158, 30)
        Me.LabelMobil.TabIndex = 12
        Me.LabelMobil.Text = "Buku Penjualan"
        '
        'DataGridViewBuku
        '
        Me.DataGridViewBuku.AllowUserToDeleteRows = False
        Me.DataGridViewBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBuku.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Mobil, Me.Pembeli, Me.Harga_Terjual, Me.Tanggal_Penjualan})
        Me.DataGridViewBuku.Location = New System.Drawing.Point(12, 39)
        Me.DataGridViewBuku.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewBuku.Name = "DataGridViewBuku"
        Me.DataGridViewBuku.ReadOnly = True
        Me.DataGridViewBuku.RowHeadersWidth = 51
        Me.DataGridViewBuku.RowTemplate.Height = 29
        Me.DataGridViewBuku.Size = New System.Drawing.Size(679, 195)
        Me.DataGridViewBuku.TabIndex = 11
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Mobil
        '
        Me.Mobil.HeaderText = "Mobil"
        Me.Mobil.Name = "Mobil"
        Me.Mobil.ReadOnly = True
        '
        'Pembeli
        '
        Me.Pembeli.HeaderText = "Pembeli"
        Me.Pembeli.Name = "Pembeli"
        Me.Pembeli.ReadOnly = True
        '
        'Harga_Terjual
        '
        Me.Harga_Terjual.HeaderText = "Harga Terjual"
        Me.Harga_Terjual.Name = "Harga_Terjual"
        Me.Harga_Terjual.ReadOnly = True
        '
        'Tanggal_Penjualan
        '
        Me.Tanggal_Penjualan.HeaderText = "Tanggal Penjualan"
        Me.Tanggal_Penjualan.Name = "Tanggal_Penjualan"
        Me.Tanggal_Penjualan.ReadOnly = True
        '
        'BukuPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 244)
        Me.Controls.Add(Me.ButtonHapusBuku)
        Me.Controls.Add(Me.ButtonEditBuku)
        Me.Controls.Add(Me.ButtonTambahBuku)
        Me.Controls.Add(Me.LabelMobil)
        Me.Controls.Add(Me.DataGridViewBuku)
        Me.Name = "BukuPenjualan"
        Me.Text = "Form1"
        CType(Me.DataGridViewBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonHapusBuku As Button
    Friend WithEvents ButtonEditBuku As Button
    Friend WithEvents ButtonTambahBuku As Button
    Friend WithEvents LabelMobil As Label
    Friend WithEvents DataGridViewBuku As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Mobil As DataGridViewTextBoxColumn
    Friend WithEvents Pembeli As DataGridViewTextBoxColumn
    Friend WithEvents Harga_Terjual As DataGridViewTextBoxColumn
    Friend WithEvents Tanggal_Penjualan As DataGridViewTextBoxColumn
End Class
