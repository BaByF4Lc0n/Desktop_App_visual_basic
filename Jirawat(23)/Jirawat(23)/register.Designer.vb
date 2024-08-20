<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btdelete = New System.Windows.Forms.Button()
        Me.cleardata = New System.Windows.Forms.Button()
        Me.editbutton = New System.Windows.Forms.Button()
        Me.save_button = New System.Windows.Forms.Button()
        Me.entermajor = New System.Windows.Forms.TextBox()
        Me.textboxentersex = New System.Windows.Forms.TextBox()
        Me.entersurename = New System.Windows.Forms.TextBox()
        Me.entername = New System.Windows.Forms.TextBox()
        Me.enterid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btback = New System.Windows.Forms.Button()
        Me.btclose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btdelete)
        Me.GroupBox1.Controls.Add(Me.cleardata)
        Me.GroupBox1.Controls.Add(Me.editbutton)
        Me.GroupBox1.Controls.Add(Me.save_button)
        Me.GroupBox1.Controls.Add(Me.entermajor)
        Me.GroupBox1.Controls.Add(Me.textboxentersex)
        Me.GroupBox1.Controls.Add(Me.entersurename)
        Me.GroupBox1.Controls.Add(Me.entername)
        Me.GroupBox1.Controls.Add(Me.enterid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(560, 286)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ลงทะเบียนนักเรียน"
        '
        'btdelete
        '
        Me.btdelete.Location = New System.Drawing.Point(329, 137)
        Me.btdelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(75, 23)
        Me.btdelete.TabIndex = 3
        Me.btdelete.Text = "Delete"
        Me.btdelete.UseVisualStyleBackColor = True
        '
        'cleardata
        '
        Me.cleardata.Location = New System.Drawing.Point(329, 186)
        Me.cleardata.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cleardata.Name = "cleardata"
        Me.cleardata.Size = New System.Drawing.Size(75, 23)
        Me.cleardata.TabIndex = 3
        Me.cleardata.Text = "Reset"
        Me.cleardata.UseVisualStyleBackColor = True
        '
        'editbutton
        '
        Me.editbutton.Location = New System.Drawing.Point(329, 89)
        Me.editbutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.editbutton.Name = "editbutton"
        Me.editbutton.Size = New System.Drawing.Size(75, 23)
        Me.editbutton.TabIndex = 3
        Me.editbutton.Text = "Edit"
        Me.editbutton.UseVisualStyleBackColor = True
        '
        'save_button
        '
        Me.save_button.Location = New System.Drawing.Point(329, 46)
        Me.save_button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.save_button.Name = "save_button"
        Me.save_button.Size = New System.Drawing.Size(75, 23)
        Me.save_button.TabIndex = 3
        Me.save_button.Text = "Save"
        Me.save_button.UseVisualStyleBackColor = True
        '
        'entermajor
        '
        Me.entermajor.Location = New System.Drawing.Point(117, 240)
        Me.entermajor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.entermajor.Name = "entermajor"
        Me.entermajor.Size = New System.Drawing.Size(135, 22)
        Me.entermajor.TabIndex = 1
        '
        'textboxentersex
        '
        Me.textboxentersex.Location = New System.Drawing.Point(117, 186)
        Me.textboxentersex.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textboxentersex.Name = "textboxentersex"
        Me.textboxentersex.Size = New System.Drawing.Size(135, 22)
        Me.textboxentersex.TabIndex = 1
        '
        'entersurename
        '
        Me.entersurename.Location = New System.Drawing.Point(117, 137)
        Me.entersurename.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.entersurename.Name = "entersurename"
        Me.entersurename.Size = New System.Drawing.Size(135, 22)
        Me.entersurename.TabIndex = 1
        '
        'entername
        '
        Me.entername.Location = New System.Drawing.Point(117, 89)
        Me.entername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.entername.Name = "entername"
        Me.entername.Size = New System.Drawing.Size(135, 22)
        Me.entername.TabIndex = 1
        '
        'enterid
        '
        Me.enterid.Location = New System.Drawing.Point(117, 47)
        Me.enterid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.enterid.Name = "enterid"
        Me.enterid.Size = New System.Drawing.Size(135, 22)
        Me.enterid.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "สาขาวิชา:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เพศ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "นามสกุล:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสนักเรียน:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(60, 348)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(560, 226)
        Me.DataGridView1.TabIndex = 1
        '
        'btback
        '
        Me.btback.Location = New System.Drawing.Point(901, 569)
        Me.btback.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(68, 34)
        Me.btback.TabIndex = 2
        Me.btback.Text = "Back"
        Me.btback.UseVisualStyleBackColor = True
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(1016, 569)
        Me.btclose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(75, 34)
        Me.btclose.TabIndex = 2
        Me.btclose.Text = "Close"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 624)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "register"
        Me.Text = "register"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents entermajor As TextBox
    Friend WithEvents entersurename As TextBox
    Friend WithEvents entername As TextBox
    Friend WithEvents enterid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cleardata As Button
    Friend WithEvents editbutton As Button
    Friend WithEvents save_button As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btback As Button
    Friend WithEvents btclose As Button
    Friend WithEvents btdelete As Button
    Friend WithEvents textboxentersex As TextBox
End Class
