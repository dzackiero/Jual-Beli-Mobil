<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembeli
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Id_Pembeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nik_pembeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama_pembeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alamat_pembeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Pembeli, Me.Nik_pembeli, Me.Nama_pembeli, Me.Alamat_pembeli})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(654, 263)
        Me.DataGridView1.TabIndex = 0
        '
        'Id_Pembeli
        '
        Me.Id_Pembeli.HeaderText = "Id Pembeli"
        Me.Id_Pembeli.Name = "Id_Pembeli"
        '
        'Nik_pembeli
        '
        Me.Nik_pembeli.HeaderText = "Nik Pembeli"
        Me.Nik_pembeli.Name = "Nik_pembeli"
        Me.Nik_pembeli.Width = 140
        '
        'Nama_pembeli
        '
        Me.Nama_pembeli.HeaderText = "Nama Pembeli"
        Me.Nama_pembeli.Name = "Nama_pembeli"
        Me.Nama_pembeli.Width = 180
        '
        'Alamat_pembeli
        '
        Me.Alamat_pembeli.HeaderText = "Alamat Pembeli"
        Me.Alamat_pembeli.Name = "Alamat_pembeli"
        Me.Alamat_pembeli.Width = 190
        '
        'Pembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Pembeli"
        Me.Text = "Pembeli"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Id_Pembeli As DataGridViewTextBoxColumn
    Friend WithEvents Nik_pembeli As DataGridViewTextBoxColumn
    Friend WithEvents Nama_pembeli As DataGridViewTextBoxColumn
    Friend WithEvents Alamat_pembeli As DataGridViewTextBoxColumn
End Class
