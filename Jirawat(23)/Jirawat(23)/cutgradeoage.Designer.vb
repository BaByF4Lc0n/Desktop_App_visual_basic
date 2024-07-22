<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cutgradeoage
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
        Me.enternum = New System.Windows.Forms.TextBox()
        Me.enterclass = New System.Windows.Forms.TextBox()
        Me.entersurename = New System.Windows.Forms.TextBox()
        Me.entername = New System.Windows.Forms.TextBox()
        Me.lbnum = New System.Windows.Forms.Label()
        Me.lbclass = New System.Windows.Forms.Label()
        Me.lbsurename = New System.Windows.Forms.Label()
        Me.lbname = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.enterscore3 = New System.Windows.Forms.TextBox()
        Me.enterscore2 = New System.Windows.Forms.TextBox()
        Me.enterscore1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btcutgrade = New System.Windows.Forms.Button()
        Me.sumtotalpoint = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.totalresult = New System.Windows.Forms.TextBox()
        Me.enterscorefinalscore = New System.Windows.Forms.TextBox()
        Me.enterscoremidterm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lboutputall = New System.Windows.Forms.Label()
        Me.output = New System.Windows.Forms.Button()
        Me.btback = New System.Windows.Forms.Button()
        Me.btclose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.enternum)
        Me.GroupBox1.Controls.Add(Me.enterclass)
        Me.GroupBox1.Controls.Add(Me.entersurename)
        Me.GroupBox1.Controls.Add(Me.entername)
        Me.GroupBox1.Controls.Add(Me.lbnum)
        Me.GroupBox1.Controls.Add(Me.lbclass)
        Me.GroupBox1.Controls.Add(Me.lbsurename)
        Me.GroupBox1.Controls.Add(Me.lbname)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รับข้อมูลนักเรียน"
        '
        'enternum
        '
        Me.enternum.Location = New System.Drawing.Point(95, 131)
        Me.enternum.Name = "enternum"
        Me.enternum.Size = New System.Drawing.Size(229, 20)
        Me.enternum.TabIndex = 1
        '
        'enterclass
        '
        Me.enterclass.Location = New System.Drawing.Point(95, 97)
        Me.enterclass.Name = "enterclass"
        Me.enterclass.Size = New System.Drawing.Size(229, 20)
        Me.enterclass.TabIndex = 1
        '
        'entersurename
        '
        Me.entersurename.Location = New System.Drawing.Point(95, 62)
        Me.entersurename.Name = "entersurename"
        Me.entersurename.Size = New System.Drawing.Size(229, 20)
        Me.entersurename.TabIndex = 1
        '
        'entername
        '
        Me.entername.Location = New System.Drawing.Point(95, 29)
        Me.entername.Name = "entername"
        Me.entername.Size = New System.Drawing.Size(229, 20)
        Me.entername.TabIndex = 1
        '
        'lbnum
        '
        Me.lbnum.AutoSize = True
        Me.lbnum.Location = New System.Drawing.Point(19, 134)
        Me.lbnum.Name = "lbnum"
        Me.lbnum.Size = New System.Drawing.Size(31, 13)
        Me.lbnum.TabIndex = 0
        Me.lbnum.Text = "เลขที่"
        '
        'lbclass
        '
        Me.lbclass.AutoSize = True
        Me.lbclass.Location = New System.Drawing.Point(19, 100)
        Me.lbclass.Name = "lbclass"
        Me.lbclass.Size = New System.Drawing.Size(50, 13)
        Me.lbclass.TabIndex = 0
        Me.lbclass.Text = "ระดับชั้น:"
        '
        'lbsurename
        '
        Me.lbsurename.AutoSize = True
        Me.lbsurename.Location = New System.Drawing.Point(19, 65)
        Me.lbsurename.Name = "lbsurename"
        Me.lbsurename.Size = New System.Drawing.Size(29, 13)
        Me.lbsurename.TabIndex = 0
        Me.lbsurename.Text = "สกุล:"
        '
        'lbname
        '
        Me.lbname.AutoSize = True
        Me.lbname.Location = New System.Drawing.Point(19, 29)
        Me.lbname.Name = "lbname"
        Me.lbname.Size = New System.Drawing.Size(23, 13)
        Me.lbname.TabIndex = 0
        Me.lbname.Text = "ชื่อ:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(71, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 65)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายละเอียดวิชา"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ว30293 เขียนแบบเบื้องต้น", "ว30298 ฐานข้อมูลและมัลติมีเดีย", "ว30224 เคมีเพิ่มเติม"})
        Me.ComboBox1.Location = New System.Drawing.Point(95, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(229, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสวิชา:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.enterscore3)
        Me.GroupBox3.Controls.Add(Me.enterscore2)
        Me.GroupBox3.Controls.Add(Me.enterscore1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(500, 68)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(345, 165)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "คะแนนเก็บ 60 คะแนน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(154, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "*คะแนนหน่วยละ 20 คะแนน"
        '
        'enterscore3
        '
        Me.enterscore3.Location = New System.Drawing.Point(157, 93)
        Me.enterscore3.Name = "enterscore3"
        Me.enterscore3.Size = New System.Drawing.Size(136, 20)
        Me.enterscore3.TabIndex = 1
        Me.enterscore3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'enterscore2
        '
        Me.enterscore2.Location = New System.Drawing.Point(157, 62)
        Me.enterscore2.Name = "enterscore2"
        Me.enterscore2.Size = New System.Drawing.Size(136, 20)
        Me.enterscore2.TabIndex = 1
        Me.enterscore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'enterscore1
        '
        Me.enterscore1.Location = New System.Drawing.Point(157, 29)
        Me.enterscore1.Name = "enterscore1"
        Me.enterscore1.Size = New System.Drawing.Size(136, 20)
        Me.enterscore1.TabIndex = 1
        Me.enterscore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "คะแนนเก็บ หน่วยที่ 3:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "คะแนนเก็บ หน่วยที่ 2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "คะแนนเก็บ หน่วยที่ 1:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btcutgrade)
        Me.GroupBox4.Controls.Add(Me.sumtotalpoint)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.totalresult)
        Me.GroupBox4.Controls.Add(Me.enterscorefinalscore)
        Me.GroupBox4.Controls.Add(Me.enterscoremidterm)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(500, 254)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(345, 185)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "คะแนนสอบ 40 คะแนน"
        '
        'btcutgrade
        '
        Me.btcutgrade.Location = New System.Drawing.Point(121, 156)
        Me.btcutgrade.Name = "btcutgrade"
        Me.btcutgrade.Size = New System.Drawing.Size(88, 23)
        Me.btcutgrade.TabIndex = 5
        Me.btcutgrade.Text = "ตัดเกรด"
        Me.btcutgrade.UseVisualStyleBackColor = True
        '
        'sumtotalpoint
        '
        Me.sumtotalpoint.Location = New System.Drawing.Point(179, 94)
        Me.sumtotalpoint.Name = "sumtotalpoint"
        Me.sumtotalpoint.Size = New System.Drawing.Size(88, 23)
        Me.sumtotalpoint.TabIndex = 5
        Me.sumtotalpoint.Text = "รวมคะแนน"
        Me.sumtotalpoint.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(71, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "คะแนนรวม:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(154, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "*คะแนนหน่วยละ 20 คะแนน"
        '
        'totalresult
        '
        Me.totalresult.BackColor = System.Drawing.SystemColors.Control
        Me.totalresult.ForeColor = System.Drawing.Color.LimeGreen
        Me.totalresult.Location = New System.Drawing.Point(156, 123)
        Me.totalresult.Name = "totalresult"
        Me.totalresult.ReadOnly = True
        Me.totalresult.Size = New System.Drawing.Size(137, 20)
        Me.totalresult.TabIndex = 1
        Me.totalresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'enterscorefinalscore
        '
        Me.enterscorefinalscore.Location = New System.Drawing.Point(157, 61)
        Me.enterscorefinalscore.Name = "enterscorefinalscore"
        Me.enterscorefinalscore.Size = New System.Drawing.Size(137, 20)
        Me.enterscorefinalscore.TabIndex = 1
        Me.enterscorefinalscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'enterscoremidterm
        '
        Me.enterscoremidterm.Location = New System.Drawing.Point(157, 31)
        Me.enterscoremidterm.Name = "enterscoremidterm"
        Me.enterscoremidterm.Size = New System.Drawing.Size(137, 20)
        Me.enterscoremidterm.TabIndex = 1
        Me.enterscoremidterm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "คะแนนสอบปลายภาค:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "คะแนนสอบกลางภาค:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lboutputall)
        Me.GroupBox5.Controls.Add(Me.output)
        Me.GroupBox5.Location = New System.Drawing.Point(71, 325)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(282, 114)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "แสดงผล"
        '
        'lboutputall
        '
        Me.lboutputall.AutoSize = True
        Me.lboutputall.Location = New System.Drawing.Point(22, 20)
        Me.lboutputall.Name = "lboutputall"
        Me.lboutputall.Size = New System.Drawing.Size(0, 13)
        Me.lboutputall.TabIndex = 1
        '
        'output
        '
        Me.output.Location = New System.Drawing.Point(198, 59)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(75, 23)
        Me.output.TabIndex = 0
        Me.output.Text = "แสดงผล"
        Me.output.UseVisualStyleBackColor = True
        '
        'btback
        '
        Me.btback.Location = New System.Drawing.Point(770, 460)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(75, 23)
        Me.btback.TabIndex = 5
        Me.btback.Text = "ย้อนกลับ"
        Me.btback.UseVisualStyleBackColor = True
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(864, 460)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(75, 23)
        Me.btclose.TabIndex = 5
        Me.btclose.Text = "จบการทำงาน"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'cutgradeoage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 495)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "cutgradeoage"
        Me.Text = "โปรแกรมตัดเกรดรายวิชา"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbname As System.Windows.Forms.Label
    Friend WithEvents lbnum As System.Windows.Forms.Label
    Friend WithEvents lbclass As System.Windows.Forms.Label
    Friend WithEvents lbsurename As System.Windows.Forms.Label
    Friend WithEvents enternum As System.Windows.Forms.TextBox
    Friend WithEvents enterclass As System.Windows.Forms.TextBox
    Friend WithEvents entersurename As System.Windows.Forms.TextBox
    Friend WithEvents entername As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents enterscore3 As System.Windows.Forms.TextBox
    Friend WithEvents enterscore2 As System.Windows.Forms.TextBox
    Friend WithEvents enterscore1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btcutgrade As System.Windows.Forms.Button
    Friend WithEvents sumtotalpoint As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents totalresult As System.Windows.Forms.TextBox
    Friend WithEvents enterscorefinalscore As System.Windows.Forms.TextBox
    Friend WithEvents enterscoremidterm As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents output As System.Windows.Forms.Button
    Friend WithEvents btback As System.Windows.Forms.Button
    Friend WithEvents btclose As System.Windows.Forms.Button
    Friend WithEvents lboutputall As Label
End Class
