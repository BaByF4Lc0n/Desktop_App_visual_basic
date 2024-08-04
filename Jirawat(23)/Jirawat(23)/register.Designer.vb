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
        Me.cleardata = New System.Windows.Forms.Button()
        Me.editbutton = New System.Windows.Forms.Button()
        Me.addbutton = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.entermajor = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.Controls.Add(Me.cleardata)
        Me.GroupBox1.Controls.Add(Me.editbutton)
        Me.GroupBox1.Controls.Add(Me.addbutton)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.entermajor)
        Me.GroupBox1.Controls.Add(Me.entersurename)
        Me.GroupBox1.Controls.Add(Me.entername)
        Me.GroupBox1.Controls.Add(Me.enterid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 46)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(420, 232)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ลงทะเบียนนักเรียน"
        '
        'cleardata
        '
        Me.cleardata.Location = New System.Drawing.Point(247, 111)
        Me.cleardata.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cleardata.Name = "cleardata"
        Me.cleardata.Size = New System.Drawing.Size(56, 19)
        Me.cleardata.TabIndex = 3
        Me.cleardata.Text = "Reset"
        Me.cleardata.UseVisualStyleBackColor = True
        '
        'editbutton
        '
        Me.editbutton.Location = New System.Drawing.Point(247, 72)
        Me.editbutton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.editbutton.Name = "editbutton"
        Me.editbutton.Size = New System.Drawing.Size(56, 19)
        Me.editbutton.TabIndex = 3
        Me.editbutton.Text = "Edit"
        Me.editbutton.UseVisualStyleBackColor = True
        '
        'addbutton
        '
        Me.addbutton.Location = New System.Drawing.Point(247, 37)
        Me.addbutton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addbutton.Name = "addbutton"
        Me.addbutton.Size = New System.Drawing.Size(56, 19)
        Me.addbutton.TabIndex = 3
        Me.addbutton.Text = "Add"
        Me.addbutton.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(140, 151)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "หญิง"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(88, 151)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ชาย"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'entermajor
        '
        Me.entermajor.Location = New System.Drawing.Point(88, 195)
        Me.entermajor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.entermajor.Name = "entermajor"
        Me.entermajor.Size = New System.Drawing.Size(102, 20)
        Me.entermajor.TabIndex = 1
        '
        'entersurename
        '
        Me.entersurename.Location = New System.Drawing.Point(88, 111)
        Me.entersurename.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.entersurename.Name = "entersurename"
        Me.entersurename.Size = New System.Drawing.Size(102, 20)
        Me.entersurename.TabIndex = 1
        '
        'entername
        '
        Me.entername.Location = New System.Drawing.Point(88, 72)
        Me.entername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.entername.Name = "entername"
        Me.entername.Size = New System.Drawing.Size(102, 20)
        Me.entername.TabIndex = 1
        '
        'enterid
        '
        Me.enterid.Location = New System.Drawing.Point(88, 38)
        Me.enterid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.enterid.Name = "enterid"
        Me.enterid.Size = New System.Drawing.Size(102, 20)
        Me.enterid.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 195)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "สาขาวิชา:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เพศ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "นามสกุล:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสนักเรียน:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 283)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(420, 184)
        Me.DataGridView1.TabIndex = 1
        '
        'btback
        '
        Me.btback.Location = New System.Drawing.Point(676, 462)
        Me.btback.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(51, 28)
        Me.btback.TabIndex = 2
        Me.btback.Text = "Back"
        Me.btback.UseVisualStyleBackColor = True
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(762, 462)
        Me.btclose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(56, 28)
        Me.btclose.TabIndex = 2
        Me.btclose.Text = "Close"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 507)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents cleardata As Button
    Friend WithEvents editbutton As Button
    Friend WithEvents addbutton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btback As Button
    Friend WithEvents btclose As Button
End Class
