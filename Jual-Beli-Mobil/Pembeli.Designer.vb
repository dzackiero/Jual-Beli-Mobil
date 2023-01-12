<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pembeli
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridViewPembeli = New System.Windows.Forms.DataGridView()
        Me.label_pembeli = New System.Windows.Forms.Label()
        Me.Button_tambahpembeli = New System.Windows.Forms.Button()
        Me.Button_editpembeli = New System.Windows.Forms.Button()
        Me.Button_hapuspembeli = New System.Windows.Forms.Button()
        CType(Me.DataGridViewPembeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewPembeli
        '
        Me.DataGridViewPembeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPembeli.Location = New System.Drawing.Point(12, 43)
        Me.DataGridViewPembeli.Name = "DataGridViewPembeli"
        Me.DataGridViewPembeli.RowTemplate.Height = 25
        Me.DataGridViewPembeli.Size = New System.Drawing.Size(654, 263)
        Me.DataGridViewPembeli.TabIndex = 0
        '
        'label_pembeli
        '
        Me.label_pembeli.AutoSize = True
        Me.label_pembeli.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label_pembeli.Location = New System.Drawing.Point(12, 10)
        Me.label_pembeli.Name = "label_pembeli"
        Me.label_pembeli.Size = New System.Drawing.Size(86, 30)
        Me.label_pembeli.TabIndex = 1
        Me.label_pembeli.Text = "Pembeli"
        '
        'Button_tambahpembeli
        '
        Me.Button_tambahpembeli.Location = New System.Drawing.Point(429, 14)
        Me.Button_tambahpembeli.Name = "Button_tambahpembeli"
        Me.Button_tambahpembeli.Size = New System.Drawing.Size(75, 23)
        Me.Button_tambahpembeli.TabIndex = 2
        Me.Button_tambahpembeli.Text = "Tambah"
        Me.Button_tambahpembeli.UseVisualStyleBackColor = True
        '
        'Button_editpembeli
        '
        Me.Button_editpembeli.Location = New System.Drawing.Point(510, 14)
        Me.Button_editpembeli.Name = "Button_editpembeli"
        Me.Button_editpembeli.Size = New System.Drawing.Size(75, 23)
        Me.Button_editpembeli.TabIndex = 3
        Me.Button_editpembeli.Text = "Edit"
        Me.Button_editpembeli.UseVisualStyleBackColor = True
        '
        'Button_hapuspembeli
        '
        Me.Button_hapuspembeli.Location = New System.Drawing.Point(591, 14)
        Me.Button_hapuspembeli.Name = "Button_hapuspembeli"
        Me.Button_hapuspembeli.Size = New System.Drawing.Size(75, 23)
        Me.Button_hapuspembeli.TabIndex = 4
        Me.Button_hapuspembeli.Text = "Hapus"
        Me.Button_hapuspembeli.UseVisualStyleBackColor = True
        '
        'Pembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 318)
        Me.Controls.Add(Me.Button_hapuspembeli)
        Me.Controls.Add(Me.Button_editpembeli)
        Me.Controls.Add(Me.Button_tambahpembeli)
        Me.Controls.Add(Me.label_pembeli)
        Me.Controls.Add(Me.DataGridViewPembeli)
        Me.Name = "Pembeli"
        Me.Text = "Pembeli"
        CType(Me.DataGridViewPembeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewPembeli As DataGridView
    Friend WithEvents label_pembeli As Label
    Friend WithEvents Button_tambahpembeli As Button
    Friend WithEvents Button_editpembeli As Button
    Friend WithEvents Button_hapuspembeli As Button
End Class
