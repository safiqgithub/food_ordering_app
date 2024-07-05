<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployeeForm
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        txtempuser = New TextBox()
        txtemppass = New TextBox()
        btnaddemp = New Button()
        btndelemp = New Button()
        btnuptemp = New Button()
        emplistform = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        username = New DataGridViewTextBoxColumn()
        password = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        txtempid = New TextBox()
        btnClear = New Button()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(emplistform, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = My.Resources.Resources.rice_bowl
        PictureBox1.Location = New Point(12, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(170, 137)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(209, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 28)
        Label1.TabIndex = 14
        Label1.Text = "username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(209, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 28)
        Label2.TabIndex = 15
        Label2.Text = "password:"
        ' 
        ' txtempuser
        ' 
        txtempuser.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtempuser.Location = New Point(315, 84)
        txtempuser.Name = "txtempuser"
        txtempuser.Size = New Size(182, 34)
        txtempuser.TabIndex = 16
        ' 
        ' txtemppass
        ' 
        txtemppass.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtemppass.Location = New Point(315, 140)
        txtemppass.Name = "txtemppass"
        txtemppass.Size = New Size(182, 34)
        txtemppass.TabIndex = 17
        txtemppass.UseSystemPasswordChar = True
        ' 
        ' btnaddemp
        ' 
        btnaddemp.FlatStyle = FlatStyle.Popup
        btnaddemp.Location = New Point(114, 209)
        btnaddemp.Name = "btnaddemp"
        btnaddemp.Size = New Size(94, 29)
        btnaddemp.TabIndex = 18
        btnaddemp.Text = "Add"
        btnaddemp.UseVisualStyleBackColor = True
        ' 
        ' btndelemp
        ' 
        btndelemp.FlatStyle = FlatStyle.Popup
        btndelemp.Location = New Point(269, 209)
        btndelemp.Name = "btndelemp"
        btndelemp.Size = New Size(94, 29)
        btndelemp.TabIndex = 19
        btndelemp.Text = "Delete"
        btndelemp.UseVisualStyleBackColor = True
        ' 
        ' btnuptemp
        ' 
        btnuptemp.FlatStyle = FlatStyle.Popup
        btnuptemp.Location = New Point(426, 209)
        btnuptemp.Name = "btnuptemp"
        btnuptemp.Size = New Size(94, 29)
        btnuptemp.TabIndex = 20
        btnuptemp.Text = "Update"
        btnuptemp.UseVisualStyleBackColor = True
        ' 
        ' emplistform
        ' 
        emplistform.AllowUserToAddRows = False
        emplistform.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        emplistform.BackgroundColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        emplistform.BorderStyle = BorderStyle.None
        emplistform.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        emplistform.Columns.AddRange(New DataGridViewColumn() {id, username, password})
        emplistform.Location = New Point(12, 250)
        emplistform.Name = "emplistform"
        emplistform.RowHeadersWidth = 51
        emplistform.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        emplistform.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        emplistform.Size = New Size(774, 188)
        emplistform.TabIndex = 21
        ' 
        ' id
        ' 
        id.HeaderText = "Emp_Id"
        id.MinimumWidth = 6
        id.Name = "id"
        ' 
        ' username
        ' 
        username.HeaderText = "Username"
        username.MinimumWidth = 6
        username.Name = "username"
        ' 
        ' password
        ' 
        password.HeaderText = "Password"
        password.MinimumWidth = 6
        password.Name = "password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(522, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 28)
        Label3.TabIndex = 22
        Label3.Text = "emp_id:"
        ' 
        ' txtempid
        ' 
        txtempid.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtempid.Location = New Point(608, 140)
        txtempid.Name = "txtempid"
        txtempid.Size = New Size(150, 34)
        txtempid.TabIndex = 23
        ' 
        ' btnClear
        ' 
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Location = New Point(584, 209)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 24
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Maroon
        Label4.Location = New Point(315, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(196, 38)
        Label4.TabIndex = 25
        Label4.Text = "Add Employee"
        ' 
        ' AddEmployeeForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(240), CByte(220))
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(btnClear)
        Controls.Add(txtempid)
        Controls.Add(Label3)
        Controls.Add(emplistform)
        Controls.Add(btnuptemp)
        Controls.Add(btndelemp)
        Controls.Add(btnaddemp)
        Controls.Add(txtemppass)
        Controls.Add(txtempuser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "AddEmployeeForm"
        Text = "RiceBowl"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(emplistform, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtempuser As TextBox
    Friend WithEvents txtemppass As TextBox
    Friend WithEvents btnaddemp As Button
    Friend WithEvents btndelemp As Button
    Friend WithEvents btnuptemp As Button
    Friend WithEvents emplistform As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtempid As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents btnClear As Button
    Friend WithEvents Label4 As Label
End Class
