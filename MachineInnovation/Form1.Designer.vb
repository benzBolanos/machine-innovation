<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.logingb = New System.Windows.Forms.GroupBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.logingb.SuspendLayout()
        Me.SuspendLayout()
        '
        'logingb
        '
        Me.logingb.Controls.Add(Me.btn_exit)
        Me.logingb.Controls.Add(Me.Label2)
        Me.logingb.Controls.Add(Me.txt_password)
        Me.logingb.Controls.Add(Me.Label1)
        Me.logingb.Controls.Add(Me.txt_username)
        Me.logingb.Controls.Add(Me.btn_login)
        Me.logingb.Location = New System.Drawing.Point(12, 12)
        Me.logingb.Name = "logingb"
        Me.logingb.Size = New System.Drawing.Size(447, 187)
        Me.logingb.TabIndex = 0
        Me.logingb.TabStop = False
        Me.logingb.Text = "Log-in"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(149, 51)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(229, 22)
        Me.txt_username.TabIndex = 3
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(149, 118)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(94, 26)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "Log-in"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password : "
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(149, 90)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(229, 22)
        Me.txt_password.TabIndex = 5
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(284, 118)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(94, 26)
        Me.btn_exit.TabIndex = 7
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 211)
        Me.Controls.Add(Me.logingb)
        Me.Name = "frmlogin"
        Me.Text = "Log-in "
        Me.logingb.ResumeLayout(False)
        Me.logingb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents logingb As GroupBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents btn_login As Button
End Class
