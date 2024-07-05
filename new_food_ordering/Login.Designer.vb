<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        admin_user_text = New TextBox()
        admin_pass_text = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        admin_login_btn = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        emp_user_text = New TextBox()
        emp_pass_text = New TextBox()
        emp_login_btn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' admin_user_text
        ' 
        admin_user_text.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        admin_user_text.Location = New Point(147, 218)
        admin_user_text.Name = "admin_user_text"
        admin_user_text.Size = New Size(255, 34)
        admin_user_text.TabIndex = 0
        ' 
        ' admin_pass_text
        ' 
        admin_pass_text.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        admin_pass_text.Location = New Point(147, 273)
        admin_pass_text.Name = "admin_pass_text"
        admin_pass_text.Size = New Size(255, 34)
        admin_pass_text.TabIndex = 1
        admin_pass_text.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(40, 221)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 28)
        Label1.TabIndex = 2
        Label1.Text = "username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(41, 276)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 28)
        Label2.TabIndex = 3
        Label2.Text = "password:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(167, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 38)
        Label3.TabIndex = 4
        Label3.Text = "Admin"
        ' 
        ' admin_login_btn
        ' 
        admin_login_btn.FlatStyle = FlatStyle.Popup
        admin_login_btn.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        admin_login_btn.Location = New Point(167, 356)
        admin_login_btn.Name = "admin_login_btn"
        admin_login_btn.Size = New Size(98, 38)
        admin_login_btn.TabIndex = 5
        admin_login_btn.Text = "login"
        admin_login_btn.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(664, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 38)
        Label4.TabIndex = 6
        Label4.Text = "Employee"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(523, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 28)
        Label5.TabIndex = 7
        Label5.Text = "username:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(524, 276)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 28)
        Label6.TabIndex = 8
        Label6.Text = "password:"
        ' 
        ' emp_user_text
        ' 
        emp_user_text.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emp_user_text.Location = New Point(640, 215)
        emp_user_text.Name = "emp_user_text"
        emp_user_text.Size = New Size(255, 34)
        emp_user_text.TabIndex = 9
        ' 
        ' emp_pass_text
        ' 
        emp_pass_text.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emp_pass_text.Location = New Point(640, 270)
        emp_pass_text.Name = "emp_pass_text"
        emp_pass_text.Size = New Size(255, 34)
        emp_pass_text.TabIndex = 10
        emp_pass_text.UseSystemPasswordChar = True
        ' 
        ' emp_login_btn
        ' 
        emp_login_btn.FlatStyle = FlatStyle.Popup
        emp_login_btn.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emp_login_btn.Location = New Point(687, 356)
        emp_login_btn.Name = "emp_login_btn"
        emp_login_btn.Size = New Size(98, 38)
        emp_login_btn.TabIndex = 11
        emp_login_btn.Text = "login"
        emp_login_btn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.rice_bowl
        PictureBox1.Location = New Point(335, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(260, 185)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(240), CByte(220))
        ClientSize = New Size(939, 450)
        Controls.Add(emp_login_btn)
        Controls.Add(emp_pass_text)
        Controls.Add(emp_user_text)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(admin_login_btn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(admin_pass_text)
        Controls.Add(admin_user_text)
        Controls.Add(PictureBox1)
        Name = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents admin_user_text As TextBox
    Friend WithEvents admin_pass_text As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents admin_login_btn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents emp_user_text As TextBox
    Friend WithEvents emp_pass_text As TextBox
    Friend WithEvents emp_login_btn As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
