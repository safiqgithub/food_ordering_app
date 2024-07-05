<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        MenuStrip1 = New MenuStrip()
        OrderFoodToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {OrderFoodToolStripMenuItem, LogoutToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(882, 91)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' OrderFoodToolStripMenuItem
        ' 
        OrderFoodToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        OrderFoodToolStripMenuItem.ForeColor = Color.Maroon
        OrderFoodToolStripMenuItem.Image = CType(resources.GetObject("OrderFoodToolStripMenuItem.Image"), Image)
        OrderFoodToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        OrderFoodToolStripMenuItem.Name = "OrderFoodToolStripMenuItem"
        OrderFoodToolStripMenuItem.Size = New Size(128, 87)
        OrderFoodToolStripMenuItem.Text = "Order Food"
        OrderFoodToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LogoutToolStripMenuItem.ForeColor = Color.Maroon
        LogoutToolStripMenuItem.Image = My.Resources.Resources.logout1
        LogoutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(89, 87)
        LogoutToolStripMenuItem.Text = "Logout"
        LogoutToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources.rice_bowl
        PictureBox1.Location = New Point(305, 128)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(229, 186)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
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
        ' Home1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(240), CByte(220))
        ClientSize = New Size(882, 450)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        ForeColor = Color.Black
        MainMenuStrip = MenuStrip1
        Name = "Home1"
        Text = "RiceBowl"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OrderFoodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
