<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainForm))
        Panel1 = New Panel()
        PictureBox5 = New PictureBox()
        Label3 = New Label()
        StudentBtn = New PictureBox()
        BooksBtn = New PictureBox()
        IssueBtn = New PictureBox()
        ReturnBtn = New PictureBox()
        Label8 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        Label6 = New Label()
        LoginBtn = New PictureBox()
        Label5 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(StudentBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(BooksBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(IssueBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(ReturnBtn, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(LoginBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(-4, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(832, 69)
        Panel1.TabIndex = 31
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
        Label3.Location = New Point(182, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(445, 33)
        Label3.TabIndex = 6
        Label3.Text = "Welcome to the Library Software"
        ' 
        ' StudentBtn
        ' 
        StudentBtn.Image = CType(resources.GetObject("StudentBtn.Image"), Image)
        StudentBtn.Location = New Point(58, 176)
        StudentBtn.Name = "StudentBtn"
        StudentBtn.Size = New Size(124, 111)
        StudentBtn.SizeMode = PictureBoxSizeMode.StretchImage
        StudentBtn.TabIndex = 32
        StudentBtn.TabStop = False
        ' 
        ' BooksBtn
        ' 
        BooksBtn.Image = CType(resources.GetObject("BooksBtn.Image"), Image)
        BooksBtn.Location = New Point(242, 176)
        BooksBtn.Name = "BooksBtn"
        BooksBtn.Size = New Size(124, 111)
        BooksBtn.SizeMode = PictureBoxSizeMode.StretchImage
        BooksBtn.TabIndex = 33
        BooksBtn.TabStop = False
        ' 
        ' IssueBtn
        ' 
        IssueBtn.Image = CType(resources.GetObject("IssueBtn.Image"), Image)
        IssueBtn.Location = New Point(429, 176)
        IssueBtn.Name = "IssueBtn"
        IssueBtn.Size = New Size(124, 111)
        IssueBtn.SizeMode = PictureBoxSizeMode.StretchImage
        IssueBtn.TabIndex = 34
        IssueBtn.TabStop = False
        ' 
        ' ReturnBtn
        ' 
        ReturnBtn.Image = CType(resources.GetObject("ReturnBtn.Image"), Image)
        ReturnBtn.Location = New Point(618, 176)
        ReturnBtn.Name = "ReturnBtn"
        ReturnBtn.Size = New Size(124, 111)
        ReturnBtn.SizeMode = PictureBoxSizeMode.StretchImage
        ReturnBtn.TabIndex = 35
        ReturnBtn.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label8.Location = New Point(81, 302)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 22)
        Label8.TabIndex = 36
        Label8.Text = "Student"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label1.Location = New Point(271, 302)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 22)
        Label1.TabIndex = 37
        Label1.Text = "Books"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label2.Location = New Point(467, 302)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 22)
        Label2.TabIndex = 38
        Label2.Text = "Issue"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label4.Location = New Point(647, 302)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 22)
        Label4.TabIndex = 39
        Label4.Text = "Return"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Red
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(LoginBtn)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(-4, 391)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(832, 69)
        Panel2.TabIndex = 32
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label6.Location = New Point(666, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 22)
        Label6.TabIndex = 40
        Label6.Text = "Logout"
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Image = CType(resources.GetObject("LoginBtn.Image"), Image)
        LoginBtn.Location = New Point(747, 3)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(45, 50)
        LoginBtn.SizeMode = PictureBoxSizeMode.StretchImage
        LoginBtn.TabIndex = 7
        LoginBtn.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label5.Location = New Point(16, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(256, 22)
        Label5.TabIndex = 6
        Label5.Text = "Napoleon Torrico, Ethan La"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label8)
        Controls.Add(ReturnBtn)
        Controls.Add(IssueBtn)
        Controls.Add(BooksBtn)
        Controls.Add(StudentBtn)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MainForm"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(StudentBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(BooksBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(IssueBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(ReturnBtn, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(LoginBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents StudentBtn As PictureBox
    Friend WithEvents BooksBtn As PictureBox
    Friend WithEvents IssueBtn As PictureBox
    Friend WithEvents ReturnBtn As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LoginBtn As PictureBox
End Class
