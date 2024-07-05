<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderFoodForm
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
        OrderFoodList = New DataGridView()
        FoodType = New DataGridViewTextBoxColumn()
        FoodName = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        txtTotalAmount = New TextBox()
        btnTotal = New Button()
        Label1 = New Label()
        btnBill = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PictureBox1 = New PictureBox()
        CType(OrderFoodList, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OrderFoodList
        ' 
        OrderFoodList.AllowUserToAddRows = False
        OrderFoodList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        OrderFoodList.BackgroundColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        OrderFoodList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        OrderFoodList.Columns.AddRange(New DataGridViewColumn() {FoodType, FoodName, Price})
        OrderFoodList.Location = New Point(38, 152)
        OrderFoodList.Name = "OrderFoodList"
        OrderFoodList.RowHeadersWidth = 51
        OrderFoodList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        OrderFoodList.Size = New Size(846, 255)
        OrderFoodList.TabIndex = 0
        ' 
        ' FoodType
        ' 
        FoodType.HeaderText = "Food Type"
        FoodType.MinimumWidth = 6
        FoodType.Name = "FoodType"
        ' 
        ' FoodName
        ' 
        FoodName.HeaderText = "Food Name"
        FoodName.MinimumWidth = 6
        FoodName.Name = "FoodName"
        ' 
        ' Price
        ' 
        Price.HeaderText = "Price"
        Price.MinimumWidth = 6
        Price.Name = "Price"
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTotalAmount.Location = New Point(708, 434)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.Size = New Size(176, 43)
        txtTotalAmount.TabIndex = 1
        ' 
        ' btnTotal
        ' 
        btnTotal.FlatStyle = FlatStyle.Popup
        btnTotal.Location = New Point(586, 435)
        btnTotal.Name = "btnTotal"
        btnTotal.Size = New Size(105, 45)
        btnTotal.TabIndex = 2
        btnTotal.Text = "Total"
        btnTotal.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(375, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 38)
        Label1.TabIndex = 3
        Label1.Text = "Order Food"
        ' 
        ' btnBill
        ' 
        btnBill.FlatStyle = FlatStyle.Popup
        btnBill.Location = New Point(400, 435)
        btnBill.Name = "btnBill"
        btnBill.Size = New Size(116, 45)
        btnBill.TabIndex = 4
        btnBill.Text = "Order"
        btnBill.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.rice_bowl
        PictureBox1.Location = New Point(38, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(151, 122)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' OrderFoodForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(240), CByte(220))
        ClientSize = New Size(920, 512)
        Controls.Add(PictureBox1)
        Controls.Add(btnBill)
        Controls.Add(Label1)
        Controls.Add(btnTotal)
        Controls.Add(txtTotalAmount)
        Controls.Add(OrderFoodList)
        Name = "OrderFoodForm"
        Text = "RiceBowl"
        CType(OrderFoodList, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents OrderFoodList As DataGridView
    Friend WithEvents btnBill As Button
    Friend WithEvents FoodType As DataGridViewTextBoxColumn
    Friend WithEvents FoodName As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PictureBox1 As PictureBox
End Class
