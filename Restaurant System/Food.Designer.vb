<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Food
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
        Me.txtMedic = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.dgvFood = New System.Windows.Forms.DataGridView()
        Me.idmedicine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblMedicine = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        CType(Me.dgvFood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMedic
        '
        Me.txtMedic.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtMedic.Location = New System.Drawing.Point(328, 104)
        Me.txtMedic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMedic.Name = "txtMedic"
        Me.txtMedic.Size = New System.Drawing.Size(193, 29)
        Me.txtMedic.TabIndex = 174
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 25)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Food ID :"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(756, 525)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(129, 49)
        Me.btnCancel.TabIndex = 172
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(517, 525)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 49)
        Me.btnUpdate.TabIndex = 171
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(250, 525)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 49)
        Me.btnAdd.TabIndex = 170
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtQuantity.Location = New System.Drawing.Point(743, 104)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(193, 29)
        Me.txtQuantity.TabIndex = 169
        '
        'dgvFood
        '
        Me.dgvFood.BackgroundColor = System.Drawing.Color.Linen
        Me.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFood.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idmedicine, Me.bil, Me.itemCode, Me.nameM, Me.quantity, Me.type})
        Me.dgvFood.Location = New System.Drawing.Point(157, 275)
        Me.dgvFood.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvFood.Name = "dgvFood"
        Me.dgvFood.RowHeadersWidth = 51
        Me.dgvFood.RowTemplate.Height = 24
        Me.dgvFood.Size = New System.Drawing.Size(779, 207)
        Me.dgvFood.TabIndex = 168
        '
        'idmedicine
        '
        Me.idmedicine.HeaderText = "idmedicine"
        Me.idmedicine.MinimumWidth = 6
        Me.idmedicine.Name = "idmedicine"
        Me.idmedicine.Visible = False
        Me.idmedicine.Width = 125
        '
        'bil
        '
        Me.bil.HeaderText = "Bil"
        Me.bil.MinimumWidth = 6
        Me.bil.Name = "bil"
        Me.bil.Width = 125
        '
        'itemCode
        '
        Me.itemCode.HeaderText = "Item Code"
        Me.itemCode.MinimumWidth = 6
        Me.itemCode.Name = "itemCode"
        Me.itemCode.Width = 125
        '
        'nameM
        '
        Me.nameM.HeaderText = "Name"
        Me.nameM.MinimumWidth = 6
        Me.nameM.Name = "nameM"
        Me.nameM.Width = 125
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.MinimumWidth = 6
        Me.quantity.Name = "quantity"
        Me.quantity.Width = 125
        '
        'type
        '
        Me.type.HeaderText = "Type"
        Me.type.MinimumWidth = 6
        Me.type.Name = "type"
        Me.type.Width = 125
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtName.Location = New System.Drawing.Point(328, 215)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(193, 29)
        Me.txtName.TabIndex = 166
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtCode.Location = New System.Drawing.Point(328, 158)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(193, 29)
        Me.txtCode.TabIndex = 165
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuantity.Location = New System.Drawing.Point(598, 106)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(100, 25)
        Me.lblQuantity.TabIndex = 164
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblMedicine
        '
        Me.lblMedicine.AutoSize = True
        Me.lblMedicine.BackColor = System.Drawing.Color.LightPink
        Me.lblMedicine.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblMedicine.ForeColor = System.Drawing.Color.Black
        Me.lblMedicine.Location = New System.Drawing.Point(419, 31)
        Me.lblMedicine.Name = "lblMedicine"
        Me.lblMedicine.Size = New System.Drawing.Size(296, 49)
        Me.lblMedicine.TabIndex = 163
        Me.lblMedicine.Text = "FOOD DETAILS"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblType.Location = New System.Drawing.Point(598, 160)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(68, 25)
        Me.lblType.TabIndex = 162
        Me.lblType.Text = "Type:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(196, 215)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(75, 25)
        Me.lblName.TabIndex = 161
        Me.lblName.Text = "Name:"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(196, 158)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(118, 25)
        Me.lblCode.TabIndex = 160
        Me.lblCode.Text = "Item Code:"
        '
        'txtType
        '
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtType.Location = New System.Drawing.Point(743, 162)
        Me.txtType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(193, 29)
        Me.txtType.TabIndex = 167
        '
        'Food
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurant_System.My.Resources.Resources.Gülmen_Interiors_presents__Istanbul_Coffee_Shop___Store
        Me.ClientSize = New System.Drawing.Size(1067, 640)
        Me.Controls.Add(Me.txtMedic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.dgvFood)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblMedicine)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.txtType)
        Me.Name = "Food"
        Me.Text = "Food"
        CType(Me.dgvFood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMedic As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents dgvFood As DataGridView
    Friend WithEvents idmedicine As DataGridViewTextBoxColumn
    Friend WithEvents bil As DataGridViewTextBoxColumn
    Friend WithEvents itemCode As DataGridViewTextBoxColumn
    Friend WithEvents nameM As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblMedicine As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents txtType As TextBox
End Class
