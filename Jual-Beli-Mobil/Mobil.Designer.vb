<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mobil
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
        Me.DataGridViewMobil = New System.Windows.Forms.DataGridView()
        Me.LabelMobil = New System.Windows.Forms.Label()
        Me.ButtonTambahMobil = New System.Windows.Forms.Button()
        Me.ButtonEditMobil = New System.Windows.Forms.Button()
        Me.ButtonHapusMobil = New System.Windows.Forms.Button()
        CType(Me.DataGridViewMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewMobil
        '
        Me.DataGridViewMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMobil.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewMobil.Name = "DataGridViewMobil"
        Me.DataGridViewMobil.RowHeadersWidth = 51
        Me.DataGridViewMobil.RowTemplate.Height = 29
        Me.DataGridViewMobil.Size = New System.Drawing.Size(776, 188)
        Me.DataGridViewMobil.TabIndex = 0
        '
        'LabelMobil
        '
        Me.LabelMobil.AutoSize = True
        Me.LabelMobil.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelMobil.Location = New System.Drawing.Point(12, 206)
        Me.LabelMobil.Name = "LabelMobil"
        Me.LabelMobil.Size = New System.Drawing.Size(88, 38)
        Me.LabelMobil.TabIndex = 1
        Me.LabelMobil.Text = "Mobil"
        '
        'ButtonTambahMobil
        '
        Me.ButtonTambahMobil.Location = New System.Drawing.Point(494, 216)
        Me.ButtonTambahMobil.Name = "ButtonTambahMobil"
        Me.ButtonTambahMobil.Size = New System.Drawing.Size(94, 29)
        Me.ButtonTambahMobil.TabIndex = 2
        Me.ButtonTambahMobil.Text = "Tambah"
        Me.ButtonTambahMobil.UseVisualStyleBackColor = True
        '
        'ButtonEditMobil
        '
        Me.ButtonEditMobil.Location = New System.Drawing.Point(594, 216)
        Me.ButtonEditMobil.Name = "ButtonEditMobil"
        Me.ButtonEditMobil.Size = New System.Drawing.Size(94, 29)
        Me.ButtonEditMobil.TabIndex = 3
        Me.ButtonEditMobil.Text = "Edit"
        Me.ButtonEditMobil.UseVisualStyleBackColor = True
        '
        'ButtonHapusMobil
        '
        Me.ButtonHapusMobil.Location = New System.Drawing.Point(694, 216)
        Me.ButtonHapusMobil.Name = "ButtonHapusMobil"
        Me.ButtonHapusMobil.Size = New System.Drawing.Size(94, 29)
        Me.ButtonHapusMobil.TabIndex = 4
        Me.ButtonHapusMobil.Text = "Hapus"
        Me.ButtonHapusMobil.UseVisualStyleBackColor = True
        '
        'Mobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonHapusMobil)
        Me.Controls.Add(Me.ButtonEditMobil)
        Me.Controls.Add(Me.ButtonTambahMobil)
        Me.Controls.Add(Me.LabelMobil)
        Me.Controls.Add(Me.DataGridViewMobil)
        Me.Name = "Mobil"
        Me.Text = "Mobil"
        CType(Me.DataGridViewMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewMobil As DataGridView
    Friend WithEvents LabelMobil As Label
    Friend WithEvents ButtonTambahMobil As Button
    Friend WithEvents ButtonEditMobil As Button
    Friend WithEvents ButtonHapusMobil As Button
End Class
