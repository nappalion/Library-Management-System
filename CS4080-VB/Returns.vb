Imports System.Data.SqlClient

Public Class Returns

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\piolo\Documents\LibraryVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Application.Exit()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim Obj = New MainForm
        Obj.Show()
        Me.Hide()
    End Sub
    Private Sub DisplayBook()
        Con.Open()
        Dim query = "select * from IssueTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        IssuesDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub DisplayReturnedBook()
        Con.Open()
        Dim query = "select * from ReturnTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ReturnsDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Dim key = 0
    Private Sub IssuesDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles IssuesDGV.CellMouseClick
        Dim row As DataGridViewRow = IssuesDGV.Rows(e.RowIndex)

        StIdCb.Text = row.Cells(1).Value.ToString
        StNameTb.Text = row.Cells(2).Value.ToString
        BIdCb.Text = row.Cells(3).Value.ToString
        BNameTb.Text = row.Cells(4).Value.ToString
        IssueDate.Text = row.Cells(5).Value.ToString

        If StNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub ReturnsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ReturnsDGV.CellMouseClick

    End Sub

    Private Sub Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
        DisplayReturnedBook()
    End Sub

    'After 5 days a student is fined $100 a day
    Dim Fine As Integer
    Private Sub CalcBtn_Click(sender As Object, e As EventArgs) Handles CalcBtn.Click
        Dim Dif As TimeSpan
        Dim Fine As Integer
        Dif = ReturnDate.Value.Date - IssueDate.Value.Date
        Dim Days = Dif.Days
        If Days <= 5 Then
            Fine = 0
            FineTb.Text = "No Fine"
        Else
            Fine = Days - 5
            FineTb.Text = "$" + Convert.ToString(Fine * 100)
        End If
    End Sub

    Private Sub Reset()
        StIdCb.SelectedIndex = -1
        BIdCb.SelectedIndex = -1
        StNameTb.Text = ""
        BNameTb.Text = ""
        FineTb.Text = ""
        key = 0
    End Sub

    Private Sub RemoveFromIssue()
        Try
            Con.open()
            Dim query = "delete from IssueTbl where Num=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Issue Removed")
            Con.close()
            'DisplayBook()
            'Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click, ReturnBtn.Click
        If StIdCb.Text = "" Or BIdCb.Text = "" Or StNameTb.Text = "" Or BNameTb.Text = "" Or FineTb.Text = "" Then
            MsgBox("Missing information.")
        Else
            Try
                Con.open()
                Dim query = "insert into ReturnTbl values (" & StIdCb.Text & ", '" & StNameTb.Text & "', " & BIdCb.Text & ", '" & BNameTb.Text & "','" & IssueDate.Value.Date & "','" & ReturnDate.Value.Date & "', " & Fine & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Book Returned")
                Con.close()
                RemoveFromIssue()
                DisplayReturnedBook()
                DisplayBook()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub
End Class