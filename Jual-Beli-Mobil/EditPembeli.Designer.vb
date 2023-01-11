<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPembeli
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
        Me.Labeldada = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_editnik = New System.Windows.Forms.TextBox()
        Me.TextBox_editnama = New System.Windows.Forms.TextBox()
        Me.RichTextBox_editalamat = New System.Windows.Forms.RichTextBox()
        Me.Button_edit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edit Pembeli"
        '
        'Labeldada
        '
        Me.Labeldada.AutoSize = True
        Me.Labeldada.Location = New System.Drawing.Point(12, 54)
        Me.Labeldada.Name = "Labeldada"
        Me.Labeldada.Size = New System.Drawing.Size(25, 15)
        Me.Labeldada.TabIndex = 1
        Me.Labeldada.Text = "Nik"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'TextBox_editnik
        '
        Me.TextBox_editnik.Location = New System.Drawing.Point(133, 54)
        Me.TextBox_editnik.Name = "TextBox_editnik"
        Me.TextBox_editnik.Size = New System.Drawing.Size(226, 23)
        Me.TextBox_editnik.TabIndex = 4
        '
        'TextBox_editnama
        '
        Me.TextBox_editnama.Location = New System.Drawing.Point(133, 91)
        Me.TextBox_editnama.Name = "TextBox_editnama"
        Me.TextBox_editnama.Size = New System.Drawing.Size(226, 23)
        Me.TextBox_editnama.TabIndex = 5
        '
        'RichTextBox_editalamat
        '
        Me.RichTextBox_editalamat.Location = New System.Drawing.Point(133, 129)
        Me.RichTextBox_editalamat.Name = "RichTextBox_editalamat"
        Me.RichTextBox_editalamat.Size = New System.Drawing.Size(226, 96)
        Me.RichTextBox_editalamat.TabIndex = 6
        Me.RichTextBox_editalamat.Text = ""
        '
        'Button_edit
        '
        Me.Button_edit.Location = New System.Drawing.Point(284, 275)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_edit.TabIndex = 7
        Me.Button_edit.Text = "Edit"
        Me.Button_edit.UseVisualStyleBackColor = True
        '
        'EditPembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 319)
        Me.Controls.Add(Me.Button_edit)
        Me.Controls.Add(Me.RichTextBox_editalamat)
        Me.Controls.Add(Me.TextBox_editnama)
        Me.Controls.Add(Me.TextBox_editnik)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Labeldada)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditPembeli"
        Me.Text = "EditPembeli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Labeldada As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_editnik As TextBox
    Friend WithEvents TextBox_editnama As TextBox
    Friend WithEvents RichTextBox_editalamat As RichTextBox
    Friend WithEvents Button_edit As Button
End Class
