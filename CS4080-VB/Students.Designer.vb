<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Students))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label3 = New Label()
        StNameTb = New TextBox()
        SemesterCb = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        DepartmentTb = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        PhoneTb = New TextBox()
        SaveBtn = New Button()
        EditBtn = New Button()
        DeleteBtn = New Button()
        ResetBtn = New Button()
        Panel2 = New Panel()
        Label6 = New Label()
        Label7 = New Label()
        Button5 = New Button()
        StudentsDGV = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(StudentsDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(-10, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(827, 79)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(22, 16)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
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
        Label3.Size = New Size(127, 33)
        Label3.TabIndex = 6
        Label3.Text = "Students"
        ' 
        ' StNameTb
        ' 
        StNameTb.Location = New Point(15, 80)
        StNameTb.Name = "StNameTb"
        StNameTb.Size = New Size(168, 23)
        StNameTb.TabIndex = 2
        ' 
        ' SemesterCb
        ' 
        SemesterCb.FormattingEnabled = True
        SemesterCb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        SemesterCb.Location = New Point(405, 80)
        SemesterCb.Name = "SemesterCb"
        SemesterCb.Size = New Size(142, 23)
        SemesterCb.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label1.Location = New Point(15, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 21)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label2.Location = New Point(207, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 21)
        Label2.TabIndex = 8
        Label2.Text = "Department"
        ' 
        ' DepartmentTb
        ' 
        DepartmentTb.Location = New Point(207, 80)
        DepartmentTb.Name = "DepartmentTb"
        DepartmentTb.Size = New Size(169, 23)
        DepartmentTb.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label4.Location = New Point(405, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 21)
        Label4.TabIndex = 10
        Label4.Text = "Semester"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label5.Location = New Point(579, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 21)
        Label5.TabIndex = 12
        Label5.Text = "Phone"
        ' 
        ' PhoneTb
        ' 
        PhoneTb.Location = New Point(579, 80)
        PhoneTb.Name = "PhoneTb"
        PhoneTb.Size = New Size(177, 23)
        PhoneTb.TabIndex = 11
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        SaveBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SaveBtn.ForeColor = Color.White
        SaveBtn.Location = New Point(47, 124)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(163, 35)
        SaveBtn.TabIndex = 13
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        EditBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EditBtn.ForeColor = Color.White
        EditBtn.Location = New Point(216, 124)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(163, 35)
        EditBtn.TabIndex = 14
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        DeleteBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DeleteBtn.ForeColor = Color.White
        DeleteBtn.Location = New Point(385, 124)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(163, 35)
        DeleteBtn.TabIndex = 15
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        ResetBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ResetBtn.ForeColor = Color.White
        ResetBtn.Location = New Point(559, 124)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(163, 35)
        ResetBtn.TabIndex = 16
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(ResetBtn)
        Panel2.Controls.Add(StNameTb)
        Panel2.Controls.Add(DeleteBtn)
        Panel2.Controls.Add(SemesterCb)
        Panel2.Controls.Add(EditBtn)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(SaveBtn)
        Panel2.Controls.Add(DepartmentTb)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(PhoneTb)
        Panel2.Location = New Point(12, 81)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(767, 189)
        Panel2.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label6.Location = New Point(314, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 21)
        Label6.TabIndex = 17
        Label6.Text = "Student Details"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label7.Location = New Point(344, 281)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 21)
        Label7.TabIndex = 18
        Label7.Text = "Student List"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Button5.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(314, 403)
        Button5.Name = "Button5"
        Button5.Size = New Size(163, 35)
        Button5.TabIndex = 18
        Button5.Text = "Back"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' StudentsDGV
        ' 
        StudentsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StudentsDGV.Location = New Point(12, 305)
        StudentsDGV.Name = "StudentsDGV"
        StudentsDGV.RowTemplate.Height = 25
        StudentsDGV.Size = New Size(767, 87)
        StudentsDGV.TabIndex = 19
        ' 
        ' Students
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StudentsDGV)
        Controls.Add(Button5)
        Controls.Add(Label7)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Students"
        Text = "Students"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(StudentsDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StNameTb As TextBox
    Friend WithEvents SemesterCb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DepartmentTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PhoneTb As TextBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents StudentsDGV As DataGridView
End Class
