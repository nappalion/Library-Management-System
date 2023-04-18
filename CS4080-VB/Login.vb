Imports System.Data.SqlClient

Public Class Login
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Application.Exit()
    End Sub

    Private Sub AdminBtn_Click(sender As Object, e As EventArgs) Handles AdminBtn.Click
        Dim Obj = New AdminLogin
        Obj.Show()
        Me.Hide()

    End Sub

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\piolo\Documents\LibraryVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UsernameTb.Text = "" Then
            MsgBox("Enter Librarian Name")
        ElseIf PasswordTb.Text = "" Then
            MsgBox("Enter the Password")
        Else
            Con.Open()
            Dim query = "select * from LibrarianTbl where LibName = '" & UsernameTb.Text & "' and LibPass='" & PasswordTb.Text & "'"
            Dim cmd = New SqlCommand(query, Con)
            Dim adapter = New SqlDataAdapter(cmd)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong username or password!")
            Else
                Dim Obj = New MainForm
                Obj.Show()
                Me.Hide()
            End If
            Con.Close()
        End If


    End Sub
End Class