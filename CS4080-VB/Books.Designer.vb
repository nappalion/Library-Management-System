<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Books
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Books))
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label3 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        ResetBtn = New Button()
        BNameTb = New TextBox()
        DeleteBtn = New Button()
        EditBtn = New Button()
        BackBtn = New Button()
        SaveBtn = New Button()
        Label5 = New Label()
        BooksDGV = New DataGridView()
        Panel2 = New Panel()
        Label8 = New Label()
        BQuantityTb = New TextBox()
        Label2 = New Label()
        BPriceTb = New TextBox()
        Label4 = New Label()
        BPublisherTb = New TextBox()
        BAuthorTb = New TextBox()
        Label7 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(BooksDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(-13, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(827, 87)
        Panel1.TabIndex = 25
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(25, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(58, 58)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
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
        Label3.Location = New Point(89, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 33)
        Label3.TabIndex = 6
        Label3.Text = "Books"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label6.Location = New Point(325, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 21)
        Label6.TabIndex = 17
        Label6.Text = "Books Details"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label1.Location = New Point(12, 43)
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
        ResetBtn.Location = New Point(559, 124)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(163, 35)
        ResetBtn.TabIndex = 16
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' BNameTb
        ' 
        BNameTb.Location = New Point(12, 80)
        BNameTb.Name = "BNameTb"
        BNameTb.Size = New Size(145, 23)
        BNameTb.TabIndex = 2
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label5.Location = New Point(163, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 21)
        Label5.TabIndex = 12
        Label5.Text = "Author"
        ' 
        ' BooksDGV
        ' 
        BooksDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BooksDGV.Location = New Point(9, 317)
        BooksDGV.Name = "BooksDGV"
        BooksDGV.RowTemplate.Height = 25
        BooksDGV.Size = New Size(767, 87)
        BooksDGV.TabIndex = 29
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(BQuantityTb)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(BPriceTb)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(BPublisherTb)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(ResetBtn)
        Panel2.Controls.Add(BNameTb)
        Panel2.Controls.Add(DeleteBtn)
        Panel2.Controls.Add(EditBtn)
        Panel2.Controls.Add(SaveBtn)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(BAuthorTb)
        Panel2.Location = New Point(9, 93)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(767, 189)
        Panel2.TabIndex = 26
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label8.Location = New Point(614, 43)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 21)
        Label8.TabIndex = 23
        Label8.Text = "Quantity"
        ' 
        ' BQuantityTb
        ' 
        BQuantityTb.Location = New Point(614, 80)
        BQuantityTb.Name = "BQuantityTb"
        BQuantityTb.Size = New Size(143, 23)
        BQuantityTb.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label2.Location = New Point(507, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 21)
        Label2.TabIndex = 21
        Label2.Text = "Price"
        ' 
        ' BPriceTb
        ' 
        BPriceTb.Location = New Point(507, 80)
        BPriceTb.Name = "BPriceTb"
        BPriceTb.Size = New Size(101, 23)
        BPriceTb.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label4.Location = New Point(314, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 21)
        Label4.TabIndex = 19
        Label4.Text = "Publisher"
        ' 
        ' BPublisherTb
        ' 
        BPublisherTb.Location = New Point(314, 80)
        BPublisherTb.Name = "BPublisherTb"
        BPublisherTb.Size = New Size(187, 23)
        BPublisherTb.TabIndex = 18
        ' 
        ' BAuthorTb
        ' 
        BAuthorTb.Location = New Point(163, 80)
        BAuthorTb.Name = "BAuthorTb"
        BAuthorTb.Size = New Size(143, 23)
        BAuthorTb.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label7.Location = New Point(353, 293)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 21)
        Label7.TabIndex = 27
        Label7.Text = "Books List"
        ' 
        ' Books
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(BackBtn)
        Controls.Add(BooksDGV)
        Controls.Add(Panel2)
        Controls.Add(Label7)
        FormBorderStyle = FormBorderStyle.None
        Name = "Books"
        Text = "Books"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(BooksDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ResetBtn As Button
    Friend WithEvents BNameTb As TextBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BooksDGV As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BAuthorTb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BQuantityTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BPriceTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BPublisherTb As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
