Public Class main

    Private Sub summath_Click(sender As System.Object, e As System.EventArgs) Handles summath.Click
        Me.Hide()
        sum.Show()
    End Sub

    Private Sub close1_Click(sender As System.Object, e As System.EventArgs) Handles close1.Click
        Me.Close()
    End Sub

    Private Sub cutgrade_Click(sender As System.Object, e As System.EventArgs) Handles cutgrade.Click, btregister.Click
        Me.Hide()
        cutgradeoage.Show()
    End Sub
End Class
