Public Class register
    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        main.Show()
        Me.Hide()
    End Sub

    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        Me.Close()
    End Sub
End Class