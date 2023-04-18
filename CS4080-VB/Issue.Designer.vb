<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Issue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Issue))
        Label2 = New Label()
        Panel1 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label3 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        ResetBtn = New Button()
        StNameTb = New TextBox()
        EditBtn = New Button()
        BackBtn = New Button()
        IssueBtn = New Button()
        Label5 = New Label()
        Label7 = New Label()
        Panel2 = New Panel()
        BIdCb = New ComboBox()
        Label8 = New Label()
        IssueDate = New DateTimePicker()
        StIdCb = New ComboBox()
        Label4 = New Label()
        BNameTb = New TextBox()
        IssueDGV = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(IssueDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label2.Location = New Point(545, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 21)
        Label2.TabIndex = 8
        Label2.Text = "Issue Date"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(-13, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(827, 87)
        Panel1.TabIndex = 25
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(35, 24)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(38, 41)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(766, 16)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(35, 35)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 10
        PictureBox5.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label3.Location = New Point(79, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 33)
        Label3.TabIndex = 6
        Label3.Text = "Issue Book"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label6.Location = New Point(314, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 21)
        Label6.TabIndex = 17
        Label6.Text = "Issue Details"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label1.Location = New Point(112, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 21)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        ResetBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ResetBtn.ForeColor = Color.White
        ResetBtn.Location = New Point(483, 124)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(163, 35)
        ResetBtn.TabIndex = 16
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' StNameTb
        ' 
        StNameTb.Enabled = False
        StNameTb.Location = New Point(112, 80)
        StNameTb.Name = "StNameTb"
        StNameTb.Size = New Size(168, 23)
        StNameTb.TabIndex = 2
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        EditBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EditBtn.ForeColor = Color.White
        EditBtn.Location = New Point(117, 124)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(163, 35)
        EditBtn.TabIndex = 14
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        BackBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BackBtn.ForeColor = Color.White
        BackBtn.Location = New Point(311, 415)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(163, 35)
        BackBtn.TabIndex = 28
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' IssueBtn
        ' 
        IssueBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        IssueBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        IssueBtn.ForeColor = Color.White
        IssueBtn.Location = New Point(301, 124)
        IssueBtn.Name = "IssueBtn"
        IssueBtn.Size = New Size(163, 35)
        IssueBtn.TabIndex = 13
        IssueBtn.Text = "Submit"
        IssueBtn.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label5.Location = New Point(385, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 21)
        Label5.TabIndex = 12
        Label5.Text = "Book Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label7.Location = New Point(335, 285)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 21)
        Label7.TabIndex = 27
        Label7.Text = "Books Issued"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(BIdCb)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(IssueDate)
        Panel2.Controls.Add(StIdCb)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(ResetBtn)
        Panel2.Controls.Add(StNameTb)
        Panel2.Controls.Add(EditBtn)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(IssueBtn)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(BNameTb)
        Panel2.Location = New Point(9, 93)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(767, 189)
        Panel2.TabIndex = 26
        ' 
        ' BIdCb
        ' 
        BIdCb.FormattingEnabled = True
        BIdCb.Location = New Point(301, 80)
        BIdCb.Name = "BIdCb"
        BIdCb.Size = New Size(58, 23)
        BIdCb.TabIndex = 32
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label8.Location = New Point(296, 43)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 21)
        Label8.TabIndex = 33
        Label8.Text = "Book ID"
        ' 
        ' IssueDate
        ' 
        IssueDate.Location = New Point(545, 80)
        IssueDate.Name = "IssueDate"
        IssueDate.Size = New Size(200, 23)
        IssueDate.TabIndex = 30
        ' 
        ' StIdCb
        ' 
        StIdCb.FormattingEnabled = True
        StIdCb.Location = New Point(29, 80)
        StIdCb.Name = "StIdCb"
        StIdCb.Size = New Size(58, 23)
        StIdCb.TabIndex = 30
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label4.Location = New Point(12, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 21)
        Label4.TabIndex = 31
        Label4.Text = "Student ID"
        ' 
        ' BNameTb
        ' 
        BNameTb.Enabled = False
        BNameTb.Location = New Point(385, 80)
        BNameTb.Name = "BNameTb"
        BNameTb.Size = New Size(148, 23)
        BNameTb.TabIndex = 11
        ' 
        ' IssueDGV
        ' 
        IssueDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        IssueDGV.Location = New Point(9, 317)
        IssueDGV.Name = "IssueDGV"
        IssueDGV.RowTemplate.Height = 25
        IssueDGV.Size = New Size(767, 87)
        IssueDGV.TabIndex = 29
        ' 
        ' Issue
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(BackBtn)
        Controls.Add(Label7)
        Controls.Add(Panel2)
        Controls.Add(IssueDGV)
        FormBorderStyle = FormBorderStyle.None
        Name = "Issue"
        Text = "Issue"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(IssueDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ResetBtn As Button
    Friend WithEvents StNameTb As TextBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents IssueBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BNameTb As TextBox
    Friend WithEvents IssueDGV As DataGridView
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents StIdCb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BIdCb As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents IssueDate As DateTimePicker
    Friend WithEvents BackBtn As Button
End Class
