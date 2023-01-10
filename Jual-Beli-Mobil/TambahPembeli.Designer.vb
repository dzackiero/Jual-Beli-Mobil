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
        Me.nikbeli = New System.Windows.Forms.Label()
        Me.namabeli = New System.Windows.Forms.Label()
        Me.alamatbeli = New System.Windows.Forms.Label()
        Me.TextBox_nik = New System.Windows.Forms.TextBox()
        Me.TextBox_nama = New System.Windows.Forms.TextBox()
        Me.RichTextBox_alamat = New System.Windows.Forms.RichTextBox()
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
        'nikbeli
        '
        Me.nikbeli.AutoSize = True
        Me.nikbeli.Location = New System.Drawing.Point(29, 23)
        Me.nikbeli.Name = "nikbeli"
        Me.nikbeli.Size = New System.Drawing.Size(28, 15)
        Me.nikbeli.TabIndex = 2
        Me.nikbeli.Text = "Nik "
        '
        'namabeli
        '
        Me.namabeli.AutoSize = True
        Me.namabeli.Location = New System.Drawing.Point(29, 65)
        Me.namabeli.Name = "namabeli"
        Me.namabeli.Size = New System.Drawing.Size(42, 15)
        Me.namabeli.TabIndex = 3
        Me.namabeli.Text = "Nama "
        '
        'alamatbeli
        '
        Me.alamatbeli.AutoSize = True
        Me.alamatbeli.Location = New System.Drawing.Point(29, 104)
        Me.alamatbeli.Name = "alamatbeli"
        Me.alamatbeli.Size = New System.Drawing.Size(45, 15)
        Me.alamatbeli.TabIndex = 4
        Me.alamatbeli.Text = "Alamat"
        '
        'TextBox_nik
        '
        Me.TextBox_nik.Location = New System.Drawing.Point(109, 23)
        Me.TextBox_nik.Name = "TextBox_nik"
        Me.TextBox_nik.Size = New System.Drawing.Size(243, 23)
        Me.TextBox_nik.TabIndex = 6
        '
        'TextBox_nama
        '
        Me.TextBox_nama.Location = New System.Drawing.Point(109, 65)
        Me.TextBox_nama.Name = "TextBox_nama"
        Me.TextBox_nama.Size = New System.Drawing.Size(243, 23)
        Me.TextBox_nama.TabIndex = 7
        '
        'RichTextBox_alamat
        '
        Me.RichTextBox_alamat.Location = New System.Drawing.Point(109, 104)
        Me.RichTextBox_alamat.Name = "RichTextBox_alamat"
        Me.RichTextBox_alamat.Size = New System.Drawing.Size(243, 96)
        Me.RichTextBox_alamat.TabIndex = 8
        Me.RichTextBox_alamat.Text = ""
        '
        'TambahPembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 341)
        Me.Controls.Add(Me.RichTextBox_alamat)
        Me.Controls.Add(Me.TextBox_nama)
        Me.Controls.Add(Me.TextBox_nik)
        Me.Controls.Add(Me.alamatbeli)
        Me.Controls.Add(Me.namabeli)
        Me.Controls.Add(Me.nikbeli)
        Me.Controls.Add(Me.btntambahpembeli)
        Me.Name = "TambahPembeli"
        Me.Text = "TambahPembeli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btntambahpembeli As Button
    Friend WithEvents nikbeli As Label
    Friend WithEvents namabeli As Label
    Friend WithEvents alamatbeli As Label
    Friend WithEvents TextBox_nik As TextBox
    Friend WithEvents TextBox_nama As TextBox
    Friend WithEvents RichTextBox_alamat As RichTextBox
End Class
