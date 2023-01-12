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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembeliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridViewBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonHapusBuku
        '
        Me.ButtonHapusBuku.Location = New System.Drawing.Point(522, 32)
        Me.ButtonHapusBuku.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonHapusBuku.Name = "ButtonHapusBuku"
        Me.ButtonHapusBuku.Size = New System.Drawing.Size(82, 22)
        Me.ButtonHapusBuku.TabIndex = 15
        Me.ButtonHapusBuku.Text = "Hapus"
        Me.ButtonHapusBuku.UseVisualStyleBackColor = True
        '
        'ButtonEditBuku
        '
        Me.ButtonEditBuku.Location = New System.Drawing.Point(609, 32)
        Me.ButtonEditBuku.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEditBuku.Name = "ButtonEditBuku"
        Me.ButtonEditBuku.Size = New System.Drawing.Size(82, 22)
        Me.ButtonEditBuku.TabIndex = 14
        Me.ButtonEditBuku.Text = "Edit"
        Me.ButtonEditBuku.UseVisualStyleBackColor = True
        '
        'ButtonTambahBuku
        '
        Me.ButtonTambahBuku.Location = New System.Drawing.Point(434, 32)
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
        Me.LabelMobil.Location = New System.Drawing.Point(12, 28)
        Me.LabelMobil.Name = "LabelMobil"
        Me.LabelMobil.Size = New System.Drawing.Size(158, 30)
        Me.LabelMobil.TabIndex = 12
        Me.LabelMobil.Text = "Buku Penjualan"
        '
        'DataGridViewBuku
        '
        Me.DataGridViewBuku.AllowUserToDeleteRows = False
        Me.DataGridViewBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBuku.Location = New System.Drawing.Point(12, 58)
        Me.DataGridViewBuku.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewBuku.Name = "DataGridViewBuku"
        Me.DataGridViewBuku.ReadOnly = True
        Me.DataGridViewBuku.RowHeadersWidth = 51
        Me.DataGridViewBuku.RowTemplate.Height = 29
        Me.DataGridViewBuku.Size = New System.Drawing.Size(679, 195)
        Me.DataGridViewBuku.TabIndex = 11
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(700, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MobilToolStripMenuItem, Me.PembeliToolStripMenuItem})
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.FormToolStripMenuItem.Text = "Data"
        '
        'MobilToolStripMenuItem
        '
        Me.MobilToolStripMenuItem.Name = "MobilToolStripMenuItem"
        Me.MobilToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MobilToolStripMenuItem.Text = "Mobil"
        '
        'PembeliToolStripMenuItem
        '
        Me.PembeliToolStripMenuItem.Name = "PembeliToolStripMenuItem"
        Me.PembeliToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PembeliToolStripMenuItem.Text = "Pembeli"
        '
        'BukuPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 264)
        Me.Controls.Add(Me.ButtonHapusBuku)
        Me.Controls.Add(Me.ButtonEditBuku)
        Me.Controls.Add(Me.ButtonTambahBuku)
        Me.Controls.Add(Me.LabelMobil)
        Me.Controls.Add(Me.DataGridViewBuku)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "BukuPenjualan"
        Me.Text = "Buku Penjualan"
        CType(Me.DataGridViewBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonHapusBuku As Button
    Friend WithEvents ButtonEditBuku As Button
    Friend WithEvents ButtonTambahBuku As Button
    Friend WithEvents LabelMobil As Label
    Friend WithEvents DataGridViewBuku As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MobilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembeliToolStripMenuItem As ToolStripMenuItem
End Class
