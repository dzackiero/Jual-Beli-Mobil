<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusJenisMobil
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelHapusJenis = New System.Windows.Forms.Label()
        Me.ButtonHapusJenis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hapus Jenis Mobil"
        '
        'LabelHapusJenis
        '
        Me.LabelHapusJenis.AutoSize = True
        Me.LabelHapusJenis.Location = New System.Drawing.Point(279, 79)
        Me.LabelHapusJenis.Name = "LabelHapusJenis"
        Me.LabelHapusJenis.Size = New System.Drawing.Size(105, 25)
        Me.LabelHapusJenis.TabIndex = 1
        Me.LabelHapusJenis.Text = "Hapus Jenis"
        '
        'ButtonHapusJenis
        '
        Me.ButtonHapusJenis.Location = New System.Drawing.Point(183, 157)
        Me.ButtonHapusJenis.Name = "ButtonHapusJenis"
        Me.ButtonHapusJenis.Size = New System.Drawing.Size(155, 34)
        Me.ButtonHapusJenis.TabIndex = 2
        Me.ButtonHapusJenis.Text = "Hapus Jenis"
        Me.ButtonHapusJenis.UseVisualStyleBackColor = True
        '
        'HapusJenisMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 299)
        Me.Controls.Add(Me.ButtonHapusJenis)
        Me.Controls.Add(Me.LabelHapusJenis)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusJenisMobil"
        Me.Text = "HapusJenisMobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelHapusJenis As Label
    Friend WithEvents ButtonHapusJenis As Button
End Class
