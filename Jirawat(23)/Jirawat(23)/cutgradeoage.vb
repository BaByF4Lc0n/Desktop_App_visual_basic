Public Class cutgradeoage
    Dim num As Integer
    Dim score1, score2, score3, mid, final As Integer
    Dim sum As Integer
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles lbname.Click, lbnum.Click, lbclass.Click, lbsurename.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub cutgradeoage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btclose_Click(sender As System.Object, e As System.EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub btback_Click(sender As System.Object, e As System.EventArgs) Handles btback.Click
        Me.Hide()
        main.Show()
    End Sub

    Private Sub entername_TextChanged(sender As System.Object, e As System.EventArgs) Handles entername.TextChanged

    End Sub

    Private Sub enternum_TextChanged(sender As System.Object, e As System.EventArgs) Handles enternum.TextChanged
        If (IsNumeric(enternum.Text)) Then
            num = enternum.Text
        Else
            enternum.Clear()
            MessageBox.Show("คุณกรอกข้อมูลไม่ถูกต้อง")
        End If

    End Sub

    Private Sub entersurename_TextChanged(sender As System.Object, e As System.EventArgs) Handles entersurename.TextChanged

    End Sub

    Private Sub enterscore1_TextChanged(sender As System.Object, e As System.EventArgs) Handles enterscore1.TextChanged
        If (IsNumeric(enterscore1.Text)) Then
            If (enterscore1.Text > 20) Then
                enterscore1.Clear()
                MessageBox.Show("กรอกผิด ไอควายย ห้ามเกิน 20 ไอโง่")
            ElseIf (enterscore1.Text < 0) Then
                enterscore1.Clear()
                MessageBox.Show("กรอกผิด ไอควายย ห้ามต่ำกว่า 20 ไอโง่")
            Else
                score1 = enterscore1.Text
            End If
        Else
            enterscore1.Clear()
            MessageBox.Show("มึงกรอกข้อมูลผิดประเภทไองั้ง")
        End If
    End Sub

    Private Sub enterscore2_TextChanged(sender As System.Object, e As System.EventArgs) Handles enterscore2.TextChanged
        If (IsNumeric(enterscore2.Text)) Then
            If (enterscore2.Text > 20) Then
                enterscore2.Clear()
                MessageBox.Show("กรอกผิด ไอควายย ห้ามเกิน 20 ไอโง่")
            ElseIf (enterscore2.Text < 0) Then
                enterscore2.Clear()
                MessageBox.Show("กรอกผิด ไอควายย ห้ามต่ำกว่า 20 ไอโง่")
            Else
                score2 = enterscore2.Text
            End If
        Else
            enterscore2.Clear()
            MessageBox.Show("มึงกรอกข้อมูลผิดประเภทไองั้ง")
        End If
    End Sub

    Private Sub enterscore3_TextChanged(sender As System.Object, e As System.EventArgs) Handles enterscore3.TextChanged
        If (IsNumeric(enterscore3.Text)) Then
            If (enterscore3.Text > 20) Then
                enterscore3.Clear()
                MessageBox.Show("กรอกผิด ไอควายย ห้ามเกิน 20 ไอโง่")
            ElseIf (enterscore3.Text < 0) Then
                enterscore3.Clear()
                MessageBox.Show("กรอกผิด ไอควายย ห้ามต่ำกว่า 20 ไอโง่")
            Else
                score3 = enterscore3.Text
            End If
        Else
            enterscore3.Clear()
            MessageBox.Show("มึงกรอกข้อมูลผิดประเภทไองั้ง")
        End If
    End Sub

    Private Sub output_Click(sender As Object, e As EventArgs) Handles output.Click
        If sum > 80 Then
            lboutputall.Text = "ชื่อ:" & entername.Text & vbNewLine &
                           "นามสกุล:" & entersurename.Text & vbNewLine &
                           "ชั้น:" & enterclass.Text & vbNewLine &
                           "เลขที่:" & enternum.Text & vbNewLine &
                           "วิชา:" & ComboBox1.Text & vbNewLine &
                           "คะแนนรวม:" & sum & vbNewLine &
                           "เกรดที่ได้:" & "4"
        ElseIf (sum < 80) Then
            lboutputall.Text = "ชื่อ:" & entername.Text & vbNewLine &
                           "นามสกุล:" & entersurename.Text & vbNewLine &
                           "ชั้น:" & enterclass.Text & vbNewLine &
                           "เลขที่:" & enternum.Text & vbNewLine &
                           "วิชา:" & ComboBox1.Text & vbNewLine &
                           "คะแนนรวม:" & sum & vbNewLine &
                           "เกรดที่ได้:" & "3"
        ElseIf (sum < 70) Then
            lboutputall.Text = "ชื่อ:" & entername.Text & vbNewLine &
                           "นามสกุล:" & entersurename.Text & vbNewLine &
                           "ชั้น:" & enterclass.Text & vbNewLine &
                           "เลขที่:" & enternum.Text & vbNewLine &
                           "วิชา:" & ComboBox1.Text & vbNewLine &
                           "คะแนนรวม:" & sum & vbNewLine &
                           "เกรดที่ได้:" & "2"
        ElseIf (sum < 60) Then
            lboutputall.Text = "ชื่อ:" & entername.Text & vbNewLine &
                           "นามสกุล:" & entersurename.Text & vbNewLine &
                           "ชั้น:" & enterclass.Text & vbNewLine &
                           "เลขที่:" & enternum.Text & vbNewLine &
                           "วิชา:" & ComboBox1.Text & vbNewLine &
                           "คะแนนรวม:" & sum & vbNewLine &
                           "เกรดที่ได้:" & "1"
        ElseIf (sum < 50) Then
            lboutputall.Text = "ชื่อ:" & entername.Text & vbNewLine &
                           "นามสกุล:" & entersurename.Text & vbNewLine &
                           "ชั้น:" & enterclass.Text & vbNewLine &
                           "เลขที่:" & enternum.Text & vbNewLine &
                           "วิชา:" & ComboBox1.Text & vbNewLine &
                           "คะแนนรวม:" & sum & vbNewLine &
                           "เกรดที่ได้:" & "0"
        End If
    End Sub

    Private Sub lboutputall_Click(sender As Object, e As EventArgs) Handles lboutputall.Click

    End Sub

    Private Sub totalresult_TextChanged(sender As Object, e As EventArgs) Handles totalresult.TextChanged

    End Sub

    Private Sub enterscoremidterm_TextChanged(sender As System.Object, e As System.EventArgs) Handles enterscoremidterm.TextChanged
        If (IsNumeric(enterscoremidterm.Text)) Then
            If (enterscoremidterm.Text > 20) Then
                enterscoremidterm.Clear()
                MessageBox.Show("กรอกผิด ไอควายย ห้ามเกิน 20 ไอโง่")
            ElseIf (enterscoremidterm.Text < 0) Then
                enterscoremidterm.Clear()
                MessageBox.Show("กรอกผิด ไอควายย ห้ามต่ำกว่า 20 ไอโง่")
            Else
                mid = enterscoremidterm.Text
            End If
        Else
            enterscoremidterm.Clear()
            MessageBox.Show("มึงกรอกข้อมูลผิดประเภทไองั้ง")
        End If
    End Sub

    Private Sub enterscorefinalscore_TextChanged(sender As System.Object, e As System.EventArgs) Handles enterscorefinalscore.TextChanged
        If (IsNumeric(enterscorefinalscore.Text)) Then
            If (enterscorefinalscore.Text > 20) Then
                enterscorefinalscore.Clear()
                MessageBox.Show("กรอกผิด ไอควายย ห้ามเกิน 20 ไอโง่")
            ElseIf (enterscorefinalscore.Text < 0) Then
                enterscorefinalscore.Clear()
                MessageBox.Show("กรอกผิด ไอควายย ห้ามต่ำกว่า 20 ไอโง่")
            Else
                final = enterscorefinalscore.Text
            End If
        Else
            enterscorefinalscore.Clear()
            MessageBox.Show("มึงกรอกข้อมูลผิดประเภทไองั้ง")
        End If
    End Sub

    Private Sub sumtotalpoint_Click(sender As System.Object, e As System.EventArgs) Handles sumtotalpoint.Click
        sum = score1 + score2 + score3 + mid + final
        totalresult.Text = sum
    End Sub

    Private Sub btcutgrade_Click(sender As System.Object, e As System.EventArgs) Handles btcutgrade.Click
        If (sum < 50) Then
            MessageBox.Show("ชื่อ:" & entername.Text & vbNewLine &
                            "สกุล:" & entersurename.Text & vbNewLine &
                            "ชั้น:" & enterclass.Text & vbNewLine &
                            "เลขที่:" & enternum.Text & vbNewLine &
                            "คะแนนรวม:" & totalresult.Text & vbNewLine &
                            "เกรด: 0" & vbNewLine)
        ElseIf (sum <= 60) Then
            MessageBox.Show("ชื่อ:" & entername.Text & vbNewLine &
                            "สกุล:" & entersurename.Text & vbNewLine &
                            "ชั้น:" & enterclass.Text & vbNewLine &
                            "เลขที่:" & enternum.Text & vbNewLine &
                            "คะแนนรวม:" & totalresult.Text & vbNewLine &
                            "เกรด: 2" & vbNewLine)
        ElseIf (sum <= 70) Then
            MessageBox.Show("ชื่อ:" & entername.Text & vbNewLine &
                            "สกุล:" & entersurename.Text & vbNewLine &
                            "ชั้น:" & enterclass.Text & vbNewLine &
                            "เลขที่:" & enternum.Text & vbNewLine &
                            "คะแนนรวม:" & totalresult.Text & vbNewLine &
                            "เกรด: 3" & vbNewLine)
        ElseIf (sum >= 80) Then
            MessageBox.Show("ชื่อ:" & entername.Text & vbNewLine &
                            "สกุล:" & entersurename.Text & vbNewLine &
                            "ชั้น:" & enterclass.Text & vbNewLine &
                            "เลขที่:" & enternum.Text & vbNewLine &
                            "คะแนนรวม:" & totalresult.Text & vbNewLine &
                            "เกรด: 4" & vbNewLine)
        End If
    End Sub
End Class