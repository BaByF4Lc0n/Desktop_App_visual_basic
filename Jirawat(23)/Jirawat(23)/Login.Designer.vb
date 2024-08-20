<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btclose = New System.Windows.Forms.Button()
        Me.textboxuser = New System.Windows.Forms.TextBox()
        Me.textboxpassword = New System.Windows.Forms.TextBox()
        Me.btlog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password:"
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(317, 220)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(75, 23)
        Me.btclose.TabIndex = 1
        Me.btclose.Text = "Close"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'textboxuser
        '
        Me.textboxuser.Location = New System.Drawing.Point(105, 54)
        Me.textboxuser.Name = "textboxuser"
        Me.textboxuser.Size = New System.Drawing.Size(187, 22)
        Me.textboxuser.TabIndex = 2
        '
        'textboxpassword
        '
        Me.textboxpassword.Location = New System.Drawing.Point(105, 99)
        Me.textboxpassword.Name = "textboxpassword"
        Me.textboxpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textboxpassword.Size = New System.Drawing.Size(187, 22)
        Me.textboxpassword.TabIndex = 3
        '
        'btlog
        '
        Me.btlog.Location = New System.Drawing.Point(145, 150)
        Me.btlog.Name = "btlog"
        Me.btlog.Size = New System.Drawing.Size(116, 49)
        Me.btlog.TabIndex = 4
        Me.btlog.Text = "LOG-IN"
        Me.btlog.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 255)
        Me.Controls.Add(Me.btlog)
        Me.Controls.Add(Me.textboxpassword)
        Me.Controls.Add(Me.textboxuser)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "เข้าสู่่ระบบการใช้งาน: นายจิรวัฒน์  ดอนโบราณ ม.6/4 เลขที่ 23"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btclose As Button
    Friend WithEvents textboxuser As TextBox
    Friend WithEvents textboxpassword As TextBox
    Friend WithEvents btlog As Button
End Class
