<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.summath = New System.Windows.Forms.Button()
        Me.cutgrade = New System.Windows.Forms.Button()
        Me.close1 = New System.Windows.Forms.Button()
        Me.btregister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'summath
        '
        Me.summath.Location = New System.Drawing.Point(295, 42)
        Me.summath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.summath.Name = "summath"
        Me.summath.Size = New System.Drawing.Size(612, 149)
        Me.summath.TabIndex = 0
        Me.summath.Text = "โปรแกรมคำนวนเลข"
        Me.summath.UseVisualStyleBackColor = True
        '
        'cutgrade
        '
        Me.cutgrade.Location = New System.Drawing.Point(295, 217)
        Me.cutgrade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cutgrade.Name = "cutgrade"
        Me.cutgrade.Size = New System.Drawing.Size(612, 149)
        Me.cutgrade.TabIndex = 0
        Me.cutgrade.Text = "โปรแกรมตัดเกรด"
        Me.cutgrade.UseVisualStyleBackColor = True
        '
        'close1
        '
        Me.close1.Location = New System.Drawing.Point(1084, 540)
        Me.close1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.close1.Name = "close1"
        Me.close1.Size = New System.Drawing.Size(123, 54)
        Me.close1.TabIndex = 0
        Me.close1.Text = "close"
        Me.close1.UseVisualStyleBackColor = True
        '
        'btregister
        '
        Me.btregister.Location = New System.Drawing.Point(295, 383)
        Me.btregister.Margin = New System.Windows.Forms.Padding(4)
        Me.btregister.Name = "btregister"
        Me.btregister.Size = New System.Drawing.Size(612, 149)
        Me.btregister.TabIndex = 0
        Me.btregister.Text = "ลงทะเบียน"
        Me.btregister.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 609)
        Me.Controls.Add(Me.close1)
        Me.Controls.Add(Me.btregister)
        Me.Controls.Add(Me.cutgrade)
        Me.Controls.Add(Me.summath)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "main"
        Me.Text = "main"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents summath As System.Windows.Forms.Button
    Friend WithEvents cutgrade As System.Windows.Forms.Button
    Friend WithEvents close1 As System.Windows.Forms.Button
    Friend WithEvents btregister As Button
End Class
