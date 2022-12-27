<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textBoxUsername = New System.Windows.Forms.TextBox()
        Me.buttonLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.linkLabelSignUp = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textBoxPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'textBoxUsername
        '
        Me.textBoxUsername.Location = New System.Drawing.Point(129, 106)
        Me.textBoxUsername.Name = "textBoxUsername"
        Me.textBoxUsername.Size = New System.Drawing.Size(100, 23)
        Me.textBoxUsername.TabIndex = 2
        '
        'buttonLogin
        '
        Me.buttonLogin.Location = New System.Drawing.Point(257, 326)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(75, 23)
        Me.buttonLogin.TabIndex = 4
        Me.buttonLogin.Text = "Login"
        Me.buttonLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dont have an account?"
        '
        'linkLabelSignUp
        '
        Me.linkLabelSignUp.AutoSize = True
        Me.linkLabelSignUp.Location = New System.Drawing.Point(31, 240)
        Me.linkLabelSignUp.Name = "linkLabelSignUp"
        Me.linkLabelSignUp.Size = New System.Drawing.Size(51, 15)
        Me.linkLabelSignUp.TabIndex = 6
        Me.linkLabelSignUp.TabStop = True
        Me.linkLabelSignUp.Text = "Sign Up!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Login"
        '
        'textBoxPassword
        '
        Me.textBoxPassword.Location = New System.Drawing.Point(129, 162)
        Me.textBoxPassword.Name = "textBoxPassword"
        Me.textBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9734)
        Me.textBoxPassword.Size = New System.Drawing.Size(100, 23)
        Me.textBoxPassword.TabIndex = 9
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 361)
        Me.Controls.Add(Me.textBoxPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.linkLabelSignUp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.buttonLogin)
        Me.Controls.Add(Me.textBoxUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SignIn"
        Me.Text = "SignIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textBoxUsername As TextBox
    Friend WithEvents buttonLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents linkLabelSignUp As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents textBoxPassword As TextBox
End Class
