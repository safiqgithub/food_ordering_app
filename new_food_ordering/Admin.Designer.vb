<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        MenuStrip1 = New MenuStrip()
        AddFoodToolStripMenuItem = New ToolStripMenuItem()
        AddEmployeeToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AddFoodToolStripMenuItem, AddEmployeeToolStripMenuItem, LogoutToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(905, 91)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AddFoodToolStripMenuItem
        ' 
        AddFoodToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AddFoodToolStripMenuItem.ForeColor = Color.Maroon
        AddFoodToolStripMenuItem.Image = CType(resources.GetObject("AddFoodToolStripMenuItem.Image"), Image)
        AddFoodToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        AddFoodToolStripMenuItem.Name = "AddFoodToolStripMenuItem"
        AddFoodToolStripMenuItem.Size = New Size(114, 87)
        AddFoodToolStripMenuItem.Text = "Add Food"
        AddFoodToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage
        ' 
        ' AddEmployeeToolStripMenuItem
        ' 
        AddEmployeeToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AddEmployeeToolStripMenuItem.ForeColor = Color.Maroon
        AddEmployeeToolStripMenuItem.Image = CType(resources.GetObject("AddEmployeeToolStripMenuItem.Image"), Image)
        AddEmployeeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        AddEmployeeToolStripMenuItem.Size = New Size(154, 87)
        AddEmployeeToolStripMenuItem.Text = "Add Employee"
        AddEmployeeToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LogoutToolStripMenuItem.ForeColor = Color.Maroon
        LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), Image)
        LogoutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(89, 87)
        LogoutToolStripMenuItem.Text = "Logout"
        LogoutToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ExitToolStripMenuItem.ForeColor = Color.Maroon
        ExitToolStripMenuItem.Image = My.Resources.Resources.switch
        ExitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(69, 87)
        ExitToolStripMenuItem.Text = "Exit"
        ExitToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources.rice_bowl
        PictureBox1.Location = New Point(327, 118)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(170, 170)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(240), CByte(220))
        ClientSize = New Size(905, 442)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Admin"
        Text = "RiceBowl"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddFoodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
