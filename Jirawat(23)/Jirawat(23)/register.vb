Imports System.Data.OleDb
'Imports System.Data
Imports System.IO
Imports System.Data.SqlClient

Public Class register
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\student.accdb")
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim ds As New DataSet
    Private Sub Register_load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Closed Then
            con.Open()
            MsgBox("open")
        End If
        showtable()
    End Sub
    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        main.Show()
        Me.Hide()
    End Sub
    Private Function checkdata()
        Dim result As Boolean 'function check data before save file
        If enterid.Text = "" Or entername.Text = "" Or entersurename.Text = "" Or textboxentersex.Text = "" Or entermajor.Text = "" Then
            MessageBox.Show("กรุณาใส่ข้อมูลให้ครบ")
            result = False
        Else
            result = True
        End If
        Return result
    End Function
    Private Sub showtable()
        Dim sqlQuery As String
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        sqlQuery = "select * from std"
        da = New OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns.Item(0).HeaderText() = "รหัสนักเรียน" 'change name data english to thailang
        DataGridView1.Columns.Item(1).HeaderText() = "ชื่อ"
        DataGridView1.Columns.Item(2).HeaderText() = "สกุล"
        DataGridView1.Columns.Item(3).HeaderText() = "เพศ"
        DataGridView1.Columns.Item(4).HeaderText() = "สาขาวิชา"
    End Sub
    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        enterid.Text = DataGridView1.Item(0, i).Value
        entername.Text = DataGridView1.Item(1, i).Value
        entersurename.Text = DataGridView1.Item(2, i).Value
        textboxentersex.Text = DataGridView1.Item(3, i).Value
        entermajor.Text = DataGridView1.Item(4, i).Value
    End Sub

    Private Sub cleardata_Click(sender As Object, e As EventArgs) Handles cleardata.Click
        enterid.Clear()
        entername.Clear()
        entersurename.Clear()
        textboxentersex.Clear()
        entermajor.Clear()
    End Sub
    Private Function GetCon(con As SqlConnection) As SqlConnection
        Return con
    End Function

    Private Sub save_button_Click(sender As Object, e As EventArgs) Handles save_button.Click
        Dim sqlQuery As String
        Dim result As Boolean
        result = checkdata()
        If result = True Then
            Try
                sqlQuery = "INSERT INTO std(std_id,std_Name,std_Sname,std_sex,std_major) VALUES ('" & enterid.Text & "','" & entername.Text & "','" & entersurename.Text & "','" & textboxentersex.Text & "','" & entermajor.Text & "')"
                'With SqlCommand
                '.CommandText = sqlQuery
                '.Connection = con
                '.ExecuteNonQuery()
                'End With
                Dim cmd As New OleDbCommand(sqlQuery, con)
                cmd.ExecuteNonQuery()
                MsgBox("บันทึกข้อมูลสำเร็จ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        showtable()
    End Sub
End Class