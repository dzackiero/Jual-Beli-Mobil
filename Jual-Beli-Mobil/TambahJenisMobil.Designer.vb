<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahJenisMobil
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
        Me.TextBoxTambahJenisMobil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonTambahJenis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxTambahJenisMobil
        '
        Me.TextBoxTambahJenisMobil.Location = New System.Drawing.Point(308, 89)
        Me.TextBoxTambahJenisMobil.Name = "TextBoxTambahJenisMobil"
        Me.TextBoxTambahJenisMobil.Size = New System.Drawing.Size(167, 31)
        Me.TextBoxTambahJenisMobil.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(308, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tambah Jenis Mobil" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ButtonTambahJenis
        '
        Me.ButtonTambahJenis.Location = New System.Drawing.Point(512, 89)
        Me.ButtonTambahJenis.Name = "ButtonTambahJenis"
        Me.ButtonTambahJenis.Size = New System.Drawing.Size(141, 34)
        Me.ButtonTambahJenis.TabIndex = 2
        Me.ButtonTambahJenis.Text = "Tambah Jenis"
        Me.ButtonTambahJenis.UseVisualStyleBackColor = True
        '
        'TambahJenisMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonTambahJenis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxTambahJenisMobil)
        Me.Name = "TambahJenisMobil"
        Me.Text = "TambahJenisMobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxTambahJenisMobil As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonTambahJenis As Button
End Class
