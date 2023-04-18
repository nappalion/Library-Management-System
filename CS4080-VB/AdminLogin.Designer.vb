<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Label3 = New Label()
        Panel1 = New Panel()
        PictureBox5 = New PictureBox()
        BackBtn = New Label()
        LoginBtn = New Button()
        Label2 = New Label()
        PasswordTb = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label3.Location = New Point(312, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(197, 33)
        Label3.TabIndex = 6
        Label3.Text = "ADMIN LOGIN"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(-12, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(846, 75)
        Panel1.TabIndex = 32
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
        ' BackBtn
        ' 
        BackBtn.AutoSize = True
        BackBtn.Font = New Font("Century Gothic", 15F, FontStyle.Underline, GraphicsUnit.Point)
        BackBtn.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        BackBtn.Location = New Point(370, 348)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(58, 23)
        BackBtn.TabIndex = 36
        BackBtn.Text = "Back"
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        LoginBtn.Font = New Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LoginBtn.ForeColor = Color.White
        LoginBtn.Location = New Point(317, 284)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(171, 46)
        LoginBtn.TabIndex = 35
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label2.Location = New Point(193, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 23)
        Label2.TabIndex = 34
        Label2.Text = "Password"
        ' 
        ' PasswordTb
        ' 
        PasswordTb.Location = New Point(317, 192)
        PasswordTb.Name = "PasswordTb"
        PasswordTb.Size = New Size(244, 23)
        PasswordTb.TabIndex = 33
        ' 
        ' AdminLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BackBtn)
        Controls.Add(LoginBtn)
        Controls.Add(Label2)
        Controls.Add(PasswordTb)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminLogin"
        Text = "AdminLogin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents BackBtn As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordTb As TextBox
End Class
