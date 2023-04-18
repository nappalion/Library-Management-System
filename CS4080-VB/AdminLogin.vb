Public Class AdminLogin
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If PasswordTb.Text = "" Then
            MsgBox("Enter the Admin Password")
        ElseIf PasswordTb.Text = "admin" Then
            Dim Obj = New Librarians
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Password")
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Application.Exit()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub
End Class