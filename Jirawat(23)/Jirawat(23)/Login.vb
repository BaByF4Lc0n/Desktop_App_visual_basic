Imports System.Data.OleDb
'Imports System.Data
Imports System.IO

Public Class Login
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\student.accdb")
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim ds As New DataSet
    Public Function chek()
        con.Open()
        dt = New DataTable
        ds = New DataSet
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("select * from login", con)
        da.Fill(dt)

        For Each DataRow In dt.Rows
            If textboxuser.Text = DataRow(0) And textboxpassword.Text = DataRow(1) Then
                con.Close()
                Return True
            End If
        Next
        con.Close()
    End Function
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lgin_Click(sender As Object, e As EventArgs)
        If chek() = True Then
            Me.Hide()
            MessageBox.Show("เข้าสู่ระบบสำเร็จ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            main.Show()
        Else

            MessageBox.Show("ผิดไอควายยยยยยยยยยยยยยยยย", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textboxpassword.TextChanged

    End Sub

    Private Sub btlog_Click(sender As Object, e As EventArgs) Handles btlog.Click
        If chek() = True Then
            Me.Hide()
            MessageBox.Show("เข้าสู่ระบบสำเร็จ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            main.Show()
        Else

            MessageBox.Show("ผิดไอควายยยยยยยยยยยยยยยยย", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class