Public Class MainForm
    Private Sub StudentBtn_Click(sender As Object, e As EventArgs) Handles StudentBtn.Click
        Dim Obj = New Students
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BooksBtn_Click(sender As Object, e As EventArgs) Handles BooksBtn.Click
        Dim Obj = New Books
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub IssueBtn_Click(sender As Object, e As EventArgs) Handles IssueBtn.Click
        Dim Obj = New Issue
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Dim Obj = New Returns
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Application.Exit()
    End Sub
End Class