<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.txt_welcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_welcome
        '
        Me.txt_welcome.AutoSize = True
        Me.txt_welcome.Location = New System.Drawing.Point(283, 162)
        Me.txt_welcome.Name = "txt_welcome"
        Me.txt_welcome.Size = New System.Drawing.Size(51, 17)
        Me.txt_welcome.TabIndex = 0
        Me.txt_welcome.Text = "Label1"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 419)
        Me.Controls.Add(Me.txt_welcome)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_welcome As Label
End Class
