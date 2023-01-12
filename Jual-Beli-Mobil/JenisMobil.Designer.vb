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
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewJenisMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewJenisMobil
        '
        Me.DataGridViewJenisMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJenisMobil.Location = New System.Drawing.Point(11, 53)
        Me.DataGridViewJenisMobil.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewJenisMobil.Name = "DataGridViewJenisMobil"
        Me.DataGridViewJenisMobil.RowHeadersWidth = 62
        Me.DataGridViewJenisMobil.RowTemplate.Height = 33
        Me.DataGridViewJenisMobil.Size = New System.Drawing.Size(453, 135)
        Me.DataGridViewJenisMobil.TabIndex = 0
        '
        'ButtonTambahJenisMobil
        '
        Me.ButtonTambahJenisMobil.Location = New System.Drawing.Point(231, 26)
        Me.ButtonTambahJenisMobil.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonTambahJenisMobil.Name = "ButtonTambahJenisMobil"
        Me.ButtonTambahJenisMobil.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambahJenisMobil.TabIndex = 1
        Me.ButtonTambahJenisMobil.Text = "Tambah"
        Me.ButtonTambahJenisMobil.UseVisualStyleBackColor = True
        '
        'ButtonHapusJenisMobil
        '
        Me.ButtonHapusJenisMobil.Location = New System.Drawing.Point(389, 26)
        Me.ButtonHapusJenisMobil.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonHapusJenisMobil.Name = "ButtonHapusJenisMobil"
        Me.ButtonHapusJenisMobil.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapusJenisMobil.TabIndex = 2
        Me.ButtonHapusJenisMobil.Text = "Hapus"
        Me.ButtonHapusJenisMobil.UseVisualStyleBackColor = True
        '
        'ButtonEditJenisMobil
        '
        Me.ButtonEditJenisMobil.Location = New System.Drawing.Point(310, 26)
        Me.ButtonEditJenisMobil.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditJenisMobil.Name = "ButtonEditJenisMobil"
        Me.ButtonEditJenisMobil.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditJenisMobil.TabIndex = 3
        Me.ButtonEditJenisMobil.Text = "Edit"
        Me.ButtonEditJenisMobil.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Jenis Mobil"
        '
        'JenisMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 204)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonEditJenisMobil)
        Me.Controls.Add(Me.ButtonHapusJenisMobil)
        Me.Controls.Add(Me.ButtonTambahJenisMobil)
        Me.Controls.Add(Me.DataGridViewJenisMobil)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "JenisMobil"
        Me.Text = "JenisMobil"
        CType(Me.DataGridViewJenisMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewJenisMobil As DataGridView
    Friend WithEvents ButtonTambahJenisMobil As Button
    Friend WithEvents ButtonHapusJenisMobil As Button
    Friend WithEvents ButtonEditJenisMobil As Button
    Friend WithEvents Label1 As Label
End Class
