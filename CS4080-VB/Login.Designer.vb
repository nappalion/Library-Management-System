<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        UsernameTb = New TextBox()
        Label2 = New Label()
        PasswordTb = New TextBox()
        LoginBtn = New Button()
        AdminBtn = New Label()
        Label4 = New Label()
        PictureBox5 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(120, 123)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 159)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label1.Location = New Point(328, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 23)
        Label1.TabIndex = 9
        Label1.Text = "Username"
        ' 
        ' UsernameTb
        ' 
        UsernameTb.Location = New Point(452, 163)
        UsernameTb.Name = "UsernameTb"
        UsernameTb.Size = New Size(244, 23)
        UsernameTb.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label2.Location = New Point(328, 219)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 23)
        Label2.TabIndex = 11
        Label2.Text = "Password"
        ' 
        ' PasswordTb
        ' 
        PasswordTb.Location = New Point(452, 219)
        PasswordTb.Name = "PasswordTb"
        PasswordTb.Size = New Size(244, 23)
        PasswordTb.TabIndex = 10
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        LoginBtn.Font = New Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LoginBtn.ForeColor = Color.White
        LoginBtn.Location = New Point(305, 317)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(171, 46)
        LoginBtn.TabIndex = 14
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' AdminBtn
        ' 
        AdminBtn.AutoSize = True
        AdminBtn.Font = New Font("Century Gothic", 15F, FontStyle.Underline, GraphicsUnit.Point)
        AdminBtn.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        AdminBtn.Location = New Point(350, 375)
        AdminBtn.Name = "AdminBtn"
        AdminBtn.Size = New Size(73, 23)
        AdminBtn.TabIndex = 15
        AdminBtn.Text = "Admin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label4.Location = New Point(186, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(422, 36)
        Label4.TabIndex = 16
        Label4.Text = "Library Management System"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(753, 12)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(35, 35)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 17
        PictureBox5.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox5)
        Controls.Add(Label4)
        Controls.Add(AdminBtn)
        Controls.Add(LoginBtn)
        Controls.Add(Label2)
        Controls.Add(PasswordTb)
        Controls.Add(Label1)
        Controls.Add(UsernameTb)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents AdminBtn As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
