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
        Me.ButtonTambahJenisMobil = New System.Windows.Forms.Button()
        Me.ButtonHapusJenisMobil = New System.Windows.Forms.Button()
        Me.ButtonEditJenisMobil = New System.Windows.Forms.Button()
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
        'ButtonTambahJenisMobil
        '
        Me.ButtonTambahJenisMobil.Location = New System.Drawing.Point(249, 433)
        Me.ButtonTambahJenisMobil.Name = "ButtonTambahJenisMobil"
        Me.ButtonTambahJenisMobil.Size = New System.Drawing.Size(112, 69)
        Me.ButtonTambahJenisMobil.TabIndex = 1
        Me.ButtonTambahJenisMobil.Text = "Tambah Jenis Mobil"
        Me.ButtonTambahJenisMobil.UseVisualStyleBackColor = True
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
        'ButtonEditJenisMobil
        '
        Me.ButtonEditJenisMobil.Location = New System.Drawing.Point(437, 433)
        Me.ButtonEditJenisMobil.Name = "ButtonEditJenisMobil"
        Me.ButtonEditJenisMobil.Size = New System.Drawing.Size(112, 69)
        Me.ButtonEditJenisMobil.TabIndex = 3
        Me.ButtonEditJenisMobil.Text = "Edit Jenis Mobil"
        Me.ButtonEditJenisMobil.UseVisualStyleBackColor = True
        '
        'JenisMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 572)
        Me.Controls.Add(Me.ButtonEditJenisMobil)
        Me.Controls.Add(Me.ButtonHapusJenisMobil)
        Me.Controls.Add(Me.ButtonTambahJenisMobil)
        Me.Controls.Add(Me.DataGridViewJenisMobil)
        Me.Name = "JenisMobil"
        Me.Text = "JenisMobil"
        CType(Me.DataGridViewJenisMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewJenisMobil As DataGridView
    Friend WithEvents ButtonTambahJenisMobil As Button
    Friend WithEvents ButtonHapusJenisMobil As Button
    Friend WithEvents ButtonEditJenisMobil As Button
End Class
