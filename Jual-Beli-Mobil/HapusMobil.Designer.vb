<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusMobil
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonHapusMobil = New System.Windows.Forms.Button()
        Me.ButtonBatalHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(32, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 38)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Hapus Mobil?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(105, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 38)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "..."
        '
        'ButtonHapusMobil
        '
        Me.ButtonHapusMobil.Location = New System.Drawing.Point(23, 105)
        Me.ButtonHapusMobil.Name = "ButtonHapusMobil"
        Me.ButtonHapusMobil.Size = New System.Drawing.Size(94, 29)
        Me.ButtonHapusMobil.TabIndex = 35
        Me.ButtonHapusMobil.Text = "Hapus"
        Me.ButtonHapusMobil.UseVisualStyleBackColor = True
        '
        'ButtonBatalHapus
        '
        Me.ButtonBatalHapus.Location = New System.Drawing.Point(123, 105)
        Me.ButtonBatalHapus.Name = "ButtonBatalHapus"
        Me.ButtonBatalHapus.Size = New System.Drawing.Size(94, 29)
        Me.ButtonBatalHapus.TabIndex = 36
        Me.ButtonBatalHapus.Text = "Batal"
        Me.ButtonBatalHapus.UseVisualStyleBackColor = True
        '
        'HapusMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 151)
        Me.Controls.Add(Me.ButtonBatalHapus)
        Me.Controls.Add(Me.ButtonHapusMobil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Name = "HapusMobil"
        Me.Text = "HapusMobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonHapusMobil As Button
    Friend WithEvents ButtonBatalHapus As Button
End Class
