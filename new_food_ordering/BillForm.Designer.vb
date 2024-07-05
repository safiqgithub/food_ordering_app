<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillForm
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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        RichTextBox1 = New RichTextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(247, 413)
        Label1.Name = "Label1"
        Label1.Size = New Size(360, 35)
        Label1.TabIndex = 1
        Label1.Text = "Thank you ! Visit Again"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.rice_bowl
        PictureBox1.Location = New Point(29, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(141, 135)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(247, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(349, 35)
        Label2.TabIndex = 3
        Label2.Text = "RICE BOWL RESTAURANT"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(192, 111)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(452, 276)
        RichTextBox1.TabIndex = 4
        RichTextBox1.Text = ""
        ' 
        ' BillForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(240), CByte(220))
        ClientSize = New Size(858, 476)
        Controls.Add(RichTextBox1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "BillForm"
        Text = "RiceBowl"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
