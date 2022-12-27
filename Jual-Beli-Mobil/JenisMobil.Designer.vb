<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JenisMobil
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
        Me.DataGridViewJenisMobil = New System.Windows.Forms.DataGridView()
        Me.ButtonTambahJenisMoobil = New System.Windows.Forms.Button()
        Me.ButtonHapusJenisMobil = New System.Windows.Forms.Button()
        CType(Me.DataGridViewJenisMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewJenisMobil
        '
        Me.DataGridViewJenisMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJenisMobil.Location = New System.Drawing.Point(190, 112)
        Me.DataGridViewJenisMobil.Name = "DataGridViewJenisMobil"
        Me.DataGridViewJenisMobil.RowHeadersWidth = 62
        Me.DataGridViewJenisMobil.RowTemplate.Height = 33
        Me.DataGridViewJenisMobil.Size = New System.Drawing.Size(620, 225)
        Me.DataGridViewJenisMobil.TabIndex = 0
        '
        'ButtonTambahJenisMoobil
        '
        Me.ButtonTambahJenisMoobil.Location = New System.Drawing.Point(249, 433)
        Me.ButtonTambahJenisMoobil.Name = "ButtonTambahJenisMoobil"
        Me.ButtonTambahJenisMoobil.Size = New System.Drawing.Size(112, 69)
        Me.ButtonTambahJenisMoobil.TabIndex = 1
        Me.ButtonTambahJenisMoobil.Text = "Tambah Jenis Mobil"
        Me.ButtonTambahJenisMoobil.UseVisualStyleBackColor = True
        '
        'ButtonHapusJenisMobil
        '
        Me.ButtonHapusJenisMobil.Location = New System.Drawing.Point(620, 433)
        Me.ButtonHapusJenisMobil.Name = "ButtonHapusJenisMobil"
        Me.ButtonHapusJenisMobil.Size = New System.Drawing.Size(112, 69)
        Me.ButtonHapusJenisMobil.TabIndex = 2
        Me.ButtonHapusJenisMobil.Text = "Hapus Jenis Mobil"
        Me.ButtonHapusJenisMobil.UseVisualStyleBackColor = True
        '
        'JenisMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 703)
        Me.Controls.Add(Me.ButtonHapusJenisMobil)
        Me.Controls.Add(Me.ButtonTambahJenisMoobil)
        Me.Controls.Add(Me.DataGridViewJenisMobil)
        Me.Name = "JenisMobil"
        Me.Text = "JenisMobil"
        CType(Me.DataGridViewJenisMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewJenisMobil As DataGridView
    Friend WithEvents ButtonTambahJenisMoobil As Button
    Friend WithEvents ButtonHapusJenisMobil As Button
End Class
