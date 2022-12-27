<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahPembeli
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
        Me.btntambahpembeli = New System.Windows.Forms.Button()
        Me.idbeli = New System.Windows.Forms.Label()
        Me.nikbeli = New System.Windows.Forms.Label()
        Me.namabeli = New System.Windows.Forms.Label()
        Me.alamatbeli = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btntambahpembeli
        '
        Me.btntambahpembeli.Location = New System.Drawing.Point(257, 290)
        Me.btntambahpembeli.Name = "btntambahpembeli"
        Me.btntambahpembeli.Size = New System.Drawing.Size(108, 23)
        Me.btntambahpembeli.TabIndex = 0
        Me.btntambahpembeli.Text = "Tambah Pembeli"
        Me.btntambahpembeli.UseVisualStyleBackColor = True
        '
        'idbeli
        '
        Me.idbeli.AutoSize = True
        Me.idbeli.Location = New System.Drawing.Point(42, 36)
        Me.idbeli.Name = "idbeli"
        Me.idbeli.Size = New System.Drawing.Size(20, 15)
        Me.idbeli.TabIndex = 1
        Me.idbeli.Text = "Id "
        '
        'nikbeli
        '
        Me.nikbeli.AutoSize = True
        Me.nikbeli.Location = New System.Drawing.Point(42, 74)
        Me.nikbeli.Name = "nikbeli"
        Me.nikbeli.Size = New System.Drawing.Size(28, 15)
        Me.nikbeli.TabIndex = 2
        Me.nikbeli.Text = "Nik "
        '
        'namabeli
        '
        Me.namabeli.AutoSize = True
        Me.namabeli.Location = New System.Drawing.Point(42, 116)
        Me.namabeli.Name = "namabeli"
        Me.namabeli.Size = New System.Drawing.Size(42, 15)
        Me.namabeli.TabIndex = 3
        Me.namabeli.Text = "Nama "
        '
        'alamatbeli
        '
        Me.alamatbeli.AutoSize = True
        Me.alamatbeli.Location = New System.Drawing.Point(42, 155)
        Me.alamatbeli.Name = "alamatbeli"
        Me.alamatbeli.Size = New System.Drawing.Size(45, 15)
        Me.alamatbeli.TabIndex = 4
        Me.alamatbeli.Text = "Alamat"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(122, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(243, 23)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(122, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(243, 23)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(122, 116)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(243, 23)
        Me.TextBox3.TabIndex = 7
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(122, 155)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(243, 96)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = ""
        '
        'TambahPembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 341)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.alamatbeli)
        Me.Controls.Add(Me.namabeli)
        Me.Controls.Add(Me.nikbeli)
        Me.Controls.Add(Me.idbeli)
        Me.Controls.Add(Me.btntambahpembeli)
        Me.Name = "TambahPembeli"
        Me.Text = "TambahPembeli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btntambahpembeli As Button
    Friend WithEvents idbeli As Label
    Friend WithEvents nikbeli As Label
    Friend WithEvents namabeli As Label
    Friend WithEvents alamatbeli As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
