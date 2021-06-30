<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtphoneNum = New System.Windows.Forms.TextBox()
        Me.lblphoneNum = New System.Windows.Forms.Label()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.LabelPATIENT = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.idcustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameCus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ageCus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addressCus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phoneNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genderCus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(682, 546)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(129, 49)
        Me.btnCancel.TabIndex = 190
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(437, 546)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 49)
        Me.btnUpdate.TabIndex = 189
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(195, 546)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 49)
        Me.btnAdd.TabIndex = 188
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtGender.Location = New System.Drawing.Point(682, 117)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(164, 29)
        Me.txtGender.TabIndex = 187
        '
        'txtphoneNum
        '
        Me.txtphoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtphoneNum.Location = New System.Drawing.Point(682, 230)
        Me.txtphoneNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtphoneNum.Name = "txtphoneNum"
        Me.txtphoneNum.Size = New System.Drawing.Size(221, 29)
        Me.txtphoneNum.TabIndex = 186
        '
        'lblphoneNum
        '
        Me.lblphoneNum.AutoSize = True
        Me.lblphoneNum.BackColor = System.Drawing.Color.Transparent
        Me.lblphoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphoneNum.Location = New System.Drawing.Point(560, 235)
        Me.lblphoneNum.Name = "lblphoneNum"
        Me.lblphoneNum.Size = New System.Drawing.Size(116, 24)
        Me.lblphoneNum.TabIndex = 185
        Me.lblphoneNum.Text = "Phone No.:"
        '
        'dgvCustomer
        '
        Me.dgvCustomer.BackgroundColor = System.Drawing.Color.Linen
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcustomer, Me.bil, Me.nameCus, Me.ageCus, Me.addressCus, Me.phoneNum, Me.genderCus})
        Me.dgvCustomer.Location = New System.Drawing.Point(71, 303)
        Me.dgvCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.RowHeadersWidth = 51
        Me.dgvCustomer.RowTemplate.Height = 24
        Me.dgvCustomer.Size = New System.Drawing.Size(856, 206)
        Me.dgvCustomer.TabIndex = 184
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtAddress.Location = New System.Drawing.Point(682, 178)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(257, 29)
        Me.txtAddress.TabIndex = 183
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtAge.Location = New System.Drawing.Point(219, 235)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(133, 29)
        Me.txtAge.TabIndex = 182
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtName.Location = New System.Drawing.Point(219, 178)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(257, 29)
        Me.txtName.TabIndex = 181
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtID.Location = New System.Drawing.Point(219, 111)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(133, 29)
        Me.txtID.TabIndex = 180
        '
        'LabelPATIENT
        '
        Me.LabelPATIENT.AutoSize = True
        Me.LabelPATIENT.BackColor = System.Drawing.Color.LightPink
        Me.LabelPATIENT.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelPATIENT.ForeColor = System.Drawing.Color.Black
        Me.LabelPATIENT.Location = New System.Drawing.Point(289, 25)
        Me.LabelPATIENT.Name = "LabelPATIENT"
        Me.LabelPATIENT.Size = New System.Drawing.Size(397, 49)
        Me.LabelPATIENT.TabIndex = 179
        Me.LabelPATIENT.Text = "CUSTOMER DETAILS"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(50, 240)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(54, 24)
        Me.lblAge.TabIndex = 178
        Me.lblAge.Text = "Age:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(560, 182)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(93, 24)
        Me.lblAddress.TabIndex = 177
        Me.lblAddress.Text = "Address:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(50, 178)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(71, 24)
        Me.lblName.TabIndex = 176
        Me.lblName.Text = "Name:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(49, 115)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(139, 25)
        Me.lblID.TabIndex = 175
        Me.lblID.Text = "Customer ID:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(560, 117)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(86, 24)
        Me.lblGender.TabIndex = 191
        Me.lblGender.Text = "Gender:"
        '
        'idcustomer
        '
        Me.idcustomer.HeaderText = "idcustomer"
        Me.idcustomer.MinimumWidth = 6
        Me.idcustomer.Name = "idcustomer"
        Me.idcustomer.Visible = False
        Me.idcustomer.Width = 125
        '
        'bil
        '
        Me.bil.HeaderText = "Bil"
        Me.bil.MinimumWidth = 6
        Me.bil.Name = "bil"
        Me.bil.Width = 125
        '
        'nameCus
        '
        Me.nameCus.HeaderText = "Name"
        Me.nameCus.MinimumWidth = 6
        Me.nameCus.Name = "nameCus"
        Me.nameCus.Width = 125
        '
        'ageCus
        '
        Me.ageCus.HeaderText = "Age"
        Me.ageCus.MinimumWidth = 6
        Me.ageCus.Name = "ageCus"
        Me.ageCus.Width = 125
        '
        'addressCus
        '
        Me.addressCus.HeaderText = "Address"
        Me.addressCus.MinimumWidth = 6
        Me.addressCus.Name = "addressCus"
        Me.addressCus.Width = 125
        '
        'phoneNum
        '
        Me.phoneNum.HeaderText = "Phone No."
        Me.phoneNum.MinimumWidth = 6
        Me.phoneNum.Name = "phoneNum"
        Me.phoneNum.Width = 125
        '
        'genderCus
        '
        Me.genderCus.HeaderText = "Gender"
        Me.genderCus.MinimumWidth = 6
        Me.genderCus.Name = "genderCus"
        Me.genderCus.Width = 125
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurant_System.My.Resources.Resources.Gülmen_Interiors_presents__Istanbul_Coffee_Shop___Store
        Me.ClientSize = New System.Drawing.Size(985, 639)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtphoneNum)
        Me.Controls.Add(Me.lblphoneNum)
        Me.Controls.Add(Me.dgvCustomer)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabelPATIENT)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblID)
        Me.Name = "Customer"
        Me.Text = "Customer"
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtphoneNum As TextBox
    Friend WithEvents lblphoneNum As Label
    Friend WithEvents dgvCustomer As DataGridView
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents LabelPATIENT As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents idcustomer As DataGridViewTextBoxColumn
    Friend WithEvents bil As DataGridViewTextBoxColumn
    Friend WithEvents nameCus As DataGridViewTextBoxColumn
    Friend WithEvents ageCus As DataGridViewTextBoxColumn
    Friend WithEvents addressCus As DataGridViewTextBoxColumn
    Friend WithEvents phoneNum As DataGridViewTextBoxColumn
    Friend WithEvents genderCus As DataGridViewTextBoxColumn
End Class
