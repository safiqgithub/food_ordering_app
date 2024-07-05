<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddFoodForm
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
    ' Friend WithEvents DgvFoods As System.Windows.Forms.DataGridView


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer



    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cmbFoodType = New ComboBox()
        txtPrice = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnAddFood = New Button()
        btnDeleteFood = New Button()
        Label4 = New Label()
        txtFoodId = New TextBox()
        btnUpdateFood = New Button()
        FoodListForm = New DataGridView()
        FoodId = New DataGridViewTextBoxColumn()
        FoodName = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        FoodType = New DataGridViewTextBoxColumn()
        PictureBox1 = New PictureBox()
        cmbFoodName = New ComboBox()
        btnClear = New Button()
        Label5 = New Label()
        CType(FoodListForm, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbFoodType
        ' 
        cmbFoodType.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbFoodType.FormattingEnabled = True
        cmbFoodType.Items.AddRange(New Object() {"starters", "soups", "main course", "noodles", "deserts"})
        cmbFoodType.Location = New Point(432, 97)
        cmbFoodType.Name = "cmbFoodType"
        cmbFoodType.Size = New Size(297, 36)
        cmbFoodType.TabIndex = 1
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPrice.Location = New Point(432, 205)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(297, 34)
        txtPrice.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(329, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 28)
        Label1.TabIndex = 3
        Label1.Text = "foodtype:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(329, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 28)
        Label2.TabIndex = 4
        Label2.Text = "foodname:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(329, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 28)
        Label3.TabIndex = 5
        Label3.Text = "price:"
        ' 
        ' btnAddFood
        ' 
        btnAddFood.FlatStyle = FlatStyle.Popup
        btnAddFood.Location = New Point(59, 256)
        btnAddFood.Name = "btnAddFood"
        btnAddFood.Size = New Size(94, 29)
        btnAddFood.TabIndex = 6
        btnAddFood.Text = "Add"
        btnAddFood.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteFood
        ' 
        btnDeleteFood.FlatStyle = FlatStyle.Popup
        btnDeleteFood.Location = New Point(218, 256)
        btnDeleteFood.Name = "btnDeleteFood"
        btnDeleteFood.Size = New Size(94, 29)
        btnDeleteFood.TabIndex = 7
        btnDeleteFood.Text = "Delete"
        btnDeleteFood.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(59, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 28)
        Label4.TabIndex = 8
        Label4.Text = "foodId:"
        ' 
        ' txtFoodId
        ' 
        txtFoodId.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFoodId.Location = New Point(140, 205)
        txtFoodId.Name = "txtFoodId"
        txtFoodId.Size = New Size(151, 34)
        txtFoodId.TabIndex = 9
        ' 
        ' btnUpdateFood
        ' 
        btnUpdateFood.FlatStyle = FlatStyle.Popup
        btnUpdateFood.Location = New Point(375, 256)
        btnUpdateFood.Name = "btnUpdateFood"
        btnUpdateFood.Size = New Size(94, 29)
        btnUpdateFood.TabIndex = 10
        btnUpdateFood.Text = "Update"
        btnUpdateFood.UseVisualStyleBackColor = True
        ' 
        ' FoodListForm
        ' 
        FoodListForm.AllowUserToAddRows = False
        FoodListForm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        FoodListForm.BackgroundColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        FoodListForm.BorderStyle = BorderStyle.None
        FoodListForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        FoodListForm.Columns.AddRange(New DataGridViewColumn() {FoodId, FoodName, Price, FoodType})
        FoodListForm.Location = New Point(59, 319)
        FoodListForm.Name = "FoodListForm"
        FoodListForm.RowHeadersWidth = 51
        FoodListForm.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        FoodListForm.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        FoodListForm.Size = New Size(796, 198)
        FoodListForm.TabIndex = 11
        ' 
        ' FoodId
        ' 
        FoodId.HeaderText = "Food ID"
        FoodId.MinimumWidth = 6
        FoodId.Name = "FoodId"
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
        ' FoodType
        ' 
        FoodType.HeaderText = "Food Type"
        FoodType.MinimumWidth = 6
        FoodType.Name = "FoodType"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = My.Resources.Resources.rice_bowl
        PictureBox1.Location = New Point(59, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(170, 137)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' cmbFoodName
        ' 
        cmbFoodName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbFoodName.FormattingEnabled = True
        cmbFoodName.Items.AddRange(New Object() {"mutton biriyani", "chicken biriyani", "beef biriyani", "chicken fried rice", "egg fried rice", "szechwan chicken fried rice", "chicken noodles", "egg noodles", "szechwan chicken noodles", "spl. ricebowl chicken dry", "mutton chukka varuval", "tandoori full", "barbeque full", "mutton nalli soup", "veg soup", "gulab jamun", "carrot halwa", "elaneer payasam"})
        cmbFoodName.Location = New Point(432, 153)
        cmbFoodName.Name = "cmbFoodName"
        cmbFoodName.Size = New Size(297, 36)
        cmbFoodName.TabIndex = 13
        ' 
        ' btnClear
        ' 
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Location = New Point(536, 256)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 14
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Maroon
        Label5.Location = New Point(406, 26)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 38)
        Label5.TabIndex = 15
        Label5.Text = "Add Food"
        ' 
        ' AddFoodForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(240), CByte(220))
        ClientSize = New Size(912, 565)
        Controls.Add(Label5)
        Controls.Add(btnClear)
        Controls.Add(cmbFoodName)
        Controls.Add(PictureBox1)
        Controls.Add(FoodListForm)
        Controls.Add(btnUpdateFood)
        Controls.Add(txtFoodId)
        Controls.Add(Label4)
        Controls.Add(btnDeleteFood)
        Controls.Add(btnAddFood)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPrice)
        Controls.Add(cmbFoodType)
        Name = "AddFoodForm"
        Text = "Ricebowl"
        CType(FoodListForm, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cmbFoodType As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddFood As Button
    Friend WithEvents btnDeleteFood As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFoodId As TextBox
    Friend WithEvents btnUpdateFood As Button
    Friend WithEvents FoodListForm As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FoodId As DataGridViewTextBoxColumn
    Friend WithEvents FoodName As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents FoodType As DataGridViewTextBoxColumn
    Friend WithEvents cmbFoodName As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label5 As Label
End Class
