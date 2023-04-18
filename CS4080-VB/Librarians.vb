Imports System.Data.SqlClient

Public Class Librarians

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\piolo\Documents\LibraryVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub DisplayLibrarians()
        Con.Open()
        Dim query = "select * from LibrarianTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        LibrariansDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Dim key = 0

    Private Sub Reset()
        LibNameTb.Text = ""
        PhoneTb.Text = ""
        PasswordTb.Text = ""
        key = 0
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If LibNameTb.Text = "" Or PhoneTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.open()
            Dim query = "insert into LibrarianTbl values ('" & LibNameTb.Text & "', '" & PhoneTb.Text & "', '" & PasswordTb.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Librarian Saved")
            Con.close()
            DisplayLibrarians()
            Reset()
        End If
    End Sub

    Private Sub LibrariansDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles LibrariansDGV.CellMouseClick
        Dim row As DataGridViewRow = LibrariansDGV.Rows(e.RowIndex)
        LibNameTb.Text = row.Cells(1).Value.ToString
        PhoneTb.Text = row.Cells(2).Value.ToString
        PasswordTb.Text = row.Cells(3).Value.ToString
        If LibNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If LibNameTb.Text = "" Or PhoneTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.open()
            Dim query = "update LibrarianTbl set LibName='" & LibNameTb.Text & "', LibPhone='" & PhoneTb.Text & "',  LibPass='" & PasswordTb.Text & "' where LibId=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Librarian Edited")
            Con.close()
            DisplayLibrarians()
            Reset()
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            Con.open()
            Dim query = "delete from LibrarianTbl where LibId=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Librarian Deleted")
            Con.close()
            DisplayLibrarians()
            Reset()
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub



    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim Obj = New AdminLogin
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Application.Exit()
    End Sub

    Private Sub Librarians_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayLibrarians()
    End Sub


End Class