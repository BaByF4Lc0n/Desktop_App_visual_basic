Public Class sum
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim names As String
    Dim Cl As String
    Dim num As String

    Private Sub plus_Click(sender As System.Object, e As System.EventArgs) Handles plus.Click
        a = enter1.Text
        b = enter2.Text
        c = a + b
        MessageBox.Show("name: " & nametoolbox.Text &
                        " class: " & classtoolbox.Text &
                        " number: " & numbertoolbox.Text &
                        " คำตอบ:" & c)

    End Sub

    Private Sub enter1_TextChanged(sender As System.Object, e As System.EventArgs) Handles enter1.TextChanged

    End Sub

    Private Sub enter2_TextChanged(sender As System.Object, e As System.EventArgs) Handles enter2.TextChanged

    End Sub

    Private Sub back_Click(sender As System.Object, e As System.EventArgs) Handles back.Click
        Me.Hide()
        main.Show()

    End Sub

    Private Sub close2_Click(sender As System.Object, e As System.EventArgs) Handles close2.Click
        Me.Close()
    End Sub

    Private Sub minus_Click(sender As System.Object, e As System.EventArgs) Handles minus.Click
        a = enter1.Text
        b = enter2.Text
        c = a - b
        MessageBox.Show("name: " & nametoolbox.Text &
                        " class: " & classtoolbox.Text &
                        " number: " & numbertoolbox.Text &
                        " คำตอบ:" & c)

    End Sub

    Private Sub time_Click(sender As System.Object, e As System.EventArgs) Handles time.Click
        a = enter1.Text
        b = enter2.Text
        c = a * b
        MessageBox.Show("name: " & nametoolbox.Text &
                        " class: " & classtoolbox.Text &
                        " number: " & numbertoolbox.Text &
                        " คำตอบ:" & c)
    End Sub

    Private Sub divid_Click(sender As System.Object, e As System.EventArgs) Handles divid.Click
        a = enter1.Text
        b = enter2.Text
        c = a / b
        MessageBox.Show("name: " & nametoolbox.Text &
                        " class: " & classtoolbox.Text &
                        " number: " & numbertoolbox.Text &
                        " คำตอบ:" & c)
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click, Label5.Click, Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles nametoolbox.TextChanged

    End Sub
End Class