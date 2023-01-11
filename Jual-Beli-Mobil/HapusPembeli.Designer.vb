<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusPembeli
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
        Me.Label_hapuspembeli = New System.Windows.Forms.Label()
        Me.Label_datahapuspembeli = New System.Windows.Forms.Label()
        Me.Button_hapuspembeli = New System.Windows.Forms.Button()
        Me.Button_batalhapuspembeli = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_hapuspembeli
        '
        Me.Label_hapuspembeli.AutoSize = True
        Me.Label_hapuspembeli.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_hapuspembeli.Location = New System.Drawing.Point(53, 9)
        Me.Label_hapuspembeli.Name = "Label_hapuspembeli"
        Me.Label_hapuspembeli.Size = New System.Drawing.Size(221, 37)
        Me.Label_hapuspembeli.TabIndex = 0
        Me.Label_hapuspembeli.Text = "Hapus Pembeli?"
        '
        'Label_datahapuspembeli
        '
        Me.Label_datahapuspembeli.AutoSize = True
        Me.Label_datahapuspembeli.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_datahapuspembeli.Location = New System.Drawing.Point(145, 95)
        Me.Label_datahapuspembeli.Name = "Label_datahapuspembeli"
        Me.Label_datahapuspembeli.Size = New System.Drawing.Size(31, 30)
        Me.Label_datahapuspembeli.TabIndex = 1
        Me.Label_datahapuspembeli.Text = "..."
        '
        'Button_hapuspembeli
        '
        Me.Button_hapuspembeli.Location = New System.Drawing.Point(53, 143)
        Me.Button_hapuspembeli.Name = "Button_hapuspembeli"
        Me.Button_hapuspembeli.Size = New System.Drawing.Size(75, 23)
        Me.Button_hapuspembeli.TabIndex = 2
        Me.Button_hapuspembeli.Text = "Hapus"
        Me.Button_hapuspembeli.UseVisualStyleBackColor = True
        '
        'Button_batalhapuspembeli
        '
        Me.Button_batalhapuspembeli.Location = New System.Drawing.Point(199, 143)
        Me.Button_batalhapuspembeli.Name = "Button_batalhapuspembeli"
        Me.Button_batalhapuspembeli.Size = New System.Drawing.Size(75, 23)
        Me.Button_batalhapuspembeli.TabIndex = 3
        Me.Button_batalhapuspembeli.Text = "Batal"
        Me.Button_batalhapuspembeli.UseVisualStyleBackColor = True
        '
        'HapusPembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 210)
        Me.Controls.Add(Me.Button_batalhapuspembeli)
        Me.Controls.Add(Me.Button_hapuspembeli)
        Me.Controls.Add(Me.Label_datahapuspembeli)
        Me.Controls.Add(Me.Label_hapuspembeli)
        Me.Name = "HapusPembeli"
        Me.Text = "HapusPembeli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_hapuspembeli As Label
    Friend WithEvents Label_datahapuspembeli As Label
    Friend WithEvents Button_hapuspembeli As Button
    Friend WithEvents Button_batalhapuspembeli As Button
End Class
