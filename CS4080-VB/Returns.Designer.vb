<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Returns
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Returns))
        Label8 = New Label()
        IssueDate = New DateTimePicker()
        Panel1 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label3 = New Label()
        StIdCb = New ComboBox()
        Label4 = New Label()
        BIdCb = New ComboBox()
        ReturnBtn = New Button()
        Label5 = New Label()
        BNameTb = New TextBox()
        BackBtn = New Button()
        ResetBtn = New Button()
        StNameTb = New TextBox()
        Label7 = New Label()
        Label1 = New Label()
        IssuesDGV = New DataGridView()
        Label6 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        CalcBtn = New Button()
        Label10 = New Label()
        FineTb = New TextBox()
        ReturnDate = New DateTimePicker()
        Label9 = New Label()
        ReturnsDGV = New DataGridView()
        Label11 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(IssuesDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(ReturnsDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label8.Location = New Point(210, 43)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 21)
        Label8.TabIndex = 33
        Label8.Text = "Book ID"
        ' 
        ' IssueDate
        ' 
        IssueDate.Location = New Point(401, 80)
        IssueDate.Name = "IssueDate"
        IssueDate.Size = New Size(112, 23)
        IssueDate.TabIndex = 30
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
        Panel1.TabIndex = 30
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
        Label3.Size = New Size(172, 33)
        Label3.TabIndex = 6
        Label3.Text = "Return Book"
        ' 
        ' StIdCb
        ' 
        StIdCb.FormattingEnabled = True
        StIdCb.Location = New Point(12, 80)
        StIdCb.Name = "StIdCb"
        StIdCb.Size = New Size(58, 23)
        StIdCb.TabIndex = 30
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label4.Location = New Point(3, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 21)
        Label4.TabIndex = 31
        Label4.Text = "Student ID"
        ' 
        ' BIdCb
        ' 
        BIdCb.FormattingEnabled = True
        BIdCb.Location = New Point(216, 80)
        BIdCb.Name = "BIdCb"
        BIdCb.Size = New Size(58, 23)
        BIdCb.TabIndex = 32
        ' 
        ' ReturnBtn
        ' 
        ReturnBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        ReturnBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ReturnBtn.ForeColor = Color.White
        ReturnBtn.Location = New Point(213, 136)
        ReturnBtn.Name = "ReturnBtn"
        ReturnBtn.Size = New Size(163, 35)
        ReturnBtn.TabIndex = 13
        ReturnBtn.Text = "Return"
        ReturnBtn.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label5.Location = New Point(280, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 21)
        Label5.TabIndex = 12
        Label5.Text = "Book Name"
        ' 
        ' BNameTb
        ' 
        BNameTb.Location = New Point(280, 80)
        BNameTb.Name = "BNameTb"
        BNameTb.Size = New Size(115, 23)
        BNameTb.TabIndex = 11
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        BackBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BackBtn.ForeColor = Color.White
        BackBtn.Location = New Point(311, 415)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(163, 35)
        BackBtn.TabIndex = 33
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        ResetBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ResetBtn.ForeColor = Color.White
        ResetBtn.Location = New Point(382, 136)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(163, 35)
        ResetBtn.TabIndex = 16
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' StNameTb
        ' 
        StNameTb.Location = New Point(100, 80)
        StNameTb.Name = "StNameTb"
        StNameTb.Size = New Size(110, 23)
        StNameTb.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label7.Location = New Point(148, 293)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 21)
        Label7.TabIndex = 32
        Label7.Text = "Book Issued"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label1.Location = New Point(100, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 21)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' IssuesDGV
        ' 
        IssuesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        IssuesDGV.Location = New Point(13, 318)
        IssuesDGV.Name = "IssuesDGV"
        IssuesDGV.RowTemplate.Height = 25
        IssuesDGV.Size = New Size(377, 87)
        IssuesDGV.TabIndex = 34
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label2.Location = New Point(401, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 21)
        Label2.TabIndex = 8
        Label2.Text = "Issue Date"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(CalcBtn)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(FineTb)
        Panel2.Controls.Add(ReturnDate)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(BIdCb)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(IssueDate)
        Panel2.Controls.Add(StIdCb)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(ResetBtn)
        Panel2.Controls.Add(StNameTb)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(ReturnBtn)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(BNameTb)
        Panel2.Location = New Point(9, 93)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(767, 189)
        Panel2.TabIndex = 31
        ' 
        ' CalcBtn
        ' 
        CalcBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        CalcBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CalcBtn.ForeColor = Color.White
        CalcBtn.Location = New Point(642, 104)
        CalcBtn.Name = "CalcBtn"
        CalcBtn.Size = New Size(104, 29)
        CalcBtn.TabIndex = 38
        CalcBtn.Text = "Calculate"
        CalcBtn.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label10.Location = New Point(637, 43)
        Label10.Name = "Label10"
        Label10.Size = New Size(41, 21)
        Label10.TabIndex = 37
        Label10.Text = "Fine"
        ' 
        ' FineTb
        ' 
        FineTb.Location = New Point(637, 80)
        FineTb.Name = "FineTb"
        FineTb.Size = New Size(115, 23)
        FineTb.TabIndex = 36
        ' 
        ' ReturnDate
        ' 
        ReturnDate.Location = New Point(519, 80)
        ReturnDate.Name = "ReturnDate"
        ReturnDate.Size = New Size(112, 23)
        ReturnDate.TabIndex = 35
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label9.Location = New Point(519, 43)
        Label9.Name = "Label9"
        Label9.Size = New Size(106, 21)
        Label9.TabIndex = 34
        Label9.Text = "Return Date"
        ' 
        ' ReturnsDGV
        ' 
        ReturnsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ReturnsDGV.Location = New Point(392, 317)
        ReturnsDGV.Name = "ReturnsDGV"
        ReturnsDGV.RowTemplate.Height = 25
        ReturnsDGV.Size = New Size(396, 87)
        ReturnsDGV.TabIndex = 35
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label11.Location = New Point(529, 293)
        Label11.Name = "Label11"
        Label11.Size = New Size(124, 21)
        Label11.TabIndex = 36
        Label11.Text = "Book Returned"
        ' 
        ' Returns
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label11)
        Controls.Add(ReturnsDGV)
        Controls.Add(Panel1)
        Controls.Add(BackBtn)
        Controls.Add(Label7)
        Controls.Add(IssuesDGV)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Returns"
        Text = "Returns"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(IssuesDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ReturnsDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents IssueDate As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents StIdCb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BIdCb As ComboBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BNameTb As TextBox
    Friend WithEvents BackBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents StNameTb As TextBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IssuesDGV As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents EditBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents FineTb As TextBox
    Friend WithEvents ReturnDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents ReturnsDGV As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents CalcBtn As Button
    Friend WithEvents ReturnBtn As Button
End Class
