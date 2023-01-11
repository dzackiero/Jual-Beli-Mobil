<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tester
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
        Me.ButtonMobil = New System.Windows.Forms.Button()
        Me.ButtonPembeli = New System.Windows.Forms.Button()
        Me.ButtonBukuPenjualan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonMobil
        '
        Me.ButtonMobil.Location = New System.Drawing.Point(12, 12)
        Me.ButtonMobil.Name = "ButtonMobil"
        Me.ButtonMobil.Size = New System.Drawing.Size(286, 42)
        Me.ButtonMobil.TabIndex = 1
        Me.ButtonMobil.Text = "Mobil"
        Me.ButtonMobil.UseVisualStyleBackColor = True
        '
        'ButtonPembeli
        '
        Me.ButtonPembeli.Location = New System.Drawing.Point(12, 60)
        Me.ButtonPembeli.Name = "ButtonPembeli"
        Me.ButtonPembeli.Size = New System.Drawing.Size(286, 42)
        Me.ButtonPembeli.TabIndex = 2
        Me.ButtonPembeli.Text = "Pembeli"
        Me.ButtonPembeli.UseVisualStyleBackColor = True
        '
        'ButtonBukuPenjualan
        '
        Me.ButtonBukuPenjualan.Location = New System.Drawing.Point(12, 108)
        Me.ButtonBukuPenjualan.Name = "ButtonBukuPenjualan"
        Me.ButtonBukuPenjualan.Size = New System.Drawing.Size(286, 42)
        Me.ButtonBukuPenjualan.TabIndex = 3
        Me.ButtonBukuPenjualan.Text = "Buku Penjualan"
        Me.ButtonBukuPenjualan.UseVisualStyleBackColor = True
        '
        'tester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 161)
        Me.Controls.Add(Me.ButtonBukuPenjualan)
        Me.Controls.Add(Me.ButtonPembeli)
        Me.Controls.Add(Me.ButtonMobil)
        Me.Name = "tester"
        Me.Text = "tester"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonJenisMobil As Button
    Friend WithEvents ButtonMobil As Button
    Friend WithEvents ButtonPembeli As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ButtonBukuPenjualan As Button
End Class
