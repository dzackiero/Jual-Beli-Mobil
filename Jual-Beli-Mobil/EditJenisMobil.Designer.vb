<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditJenisMobil
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
        Me.ButtonEditJenis = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxEditJenis = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonEditJenis
        '
        Me.ButtonEditJenis.Location = New System.Drawing.Point(484, 108)
        Me.ButtonEditJenis.Name = "ButtonEditJenis"
        Me.ButtonEditJenis.Size = New System.Drawing.Size(141, 34)
        Me.ButtonEditJenis.TabIndex = 5
        Me.ButtonEditJenis.Text = "Edit Jenis"
        Me.ButtonEditJenis.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Edit Jenis Mobil" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBoxEditJenis
        '
        Me.TextBoxEditJenis.Location = New System.Drawing.Point(280, 108)
        Me.TextBoxEditJenis.Name = "TextBoxEditJenis"
        Me.TextBoxEditJenis.Size = New System.Drawing.Size(167, 31)
        Me.TextBoxEditJenis.TabIndex = 3
        '
        'EditJenisMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonEditJenis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxEditJenis)
        Me.Name = "EditJenisMobil"
        Me.Text = "EditJenisMobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEditJenis As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxEditJenis As TextBox
End Class
