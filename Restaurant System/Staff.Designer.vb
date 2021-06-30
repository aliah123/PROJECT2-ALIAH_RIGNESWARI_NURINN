<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtphoneNum = New System.Windows.Forms.TextBox()
        Me.lblphoneNum = New System.Windows.Forms.Label()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtdateInCharge = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtStaffId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.LabelPATIENT = New System.Windows.Forms.Label()
        Me.idstaff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameStaff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.positionStaff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phoneNumStaff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genderStaff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateInChargeStaff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(620, 561)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(129, 49)
        Me.btnCancel.TabIndex = 193
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(421, 561)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 49)
        Me.btnUpdate.TabIndex = 192
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(196, 561)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 49)
        Me.btnAdd.TabIndex = 191
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtGender.Location = New System.Drawing.Point(771, 113)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(164, 29)
        Me.txtGender.TabIndex = 190
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(552, 111)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(107, 28)
        Me.lblGender.TabIndex = 189
        Me.lblGender.Text = "Gender:"
        '
        'txtphoneNum
        '
        Me.txtphoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtphoneNum.Location = New System.Drawing.Point(771, 168)
        Me.txtphoneNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtphoneNum.Name = "txtphoneNum"
        Me.txtphoneNum.Size = New System.Drawing.Size(221, 29)
        Me.txtphoneNum.TabIndex = 188
        '
        'lblphoneNum
        '
        Me.lblphoneNum.AutoSize = True
        Me.lblphoneNum.BackColor = System.Drawing.Color.Transparent
        Me.lblphoneNum.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphoneNum.Location = New System.Drawing.Point(552, 163)
        Me.lblphoneNum.Name = "lblphoneNum"
        Me.lblphoneNum.Size = New System.Drawing.Size(137, 28)
        Me.lblphoneNum.TabIndex = 187
        Me.lblphoneNum.Text = "Phone No.:"
        '
        'dgvStaff
        '
        Me.dgvStaff.BackgroundColor = System.Drawing.Color.Linen
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idstaff, Me.bil, Me.nameStaff, Me.positionStaff, Me.phoneNumStaff, Me.genderStaff, Me.dateInChargeStaff})
        Me.dgvStaff.Location = New System.Drawing.Point(64, 326)
        Me.dgvStaff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.RowHeadersWidth = 51
        Me.dgvStaff.RowTemplate.Height = 24
        Me.dgvStaff.Size = New System.Drawing.Size(871, 216)
        Me.dgvStaff.TabIndex = 186
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtPosition.Location = New System.Drawing.Point(213, 220)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(257, 29)
        Me.txtPosition.TabIndex = 185
        '
        'txtdateInCharge
        '
        Me.txtdateInCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtdateInCharge.Location = New System.Drawing.Point(771, 219)
        Me.txtdateInCharge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdateInCharge.Name = "txtdateInCharge"
        Me.txtdateInCharge.Size = New System.Drawing.Size(164, 29)
        Me.txtdateInCharge.TabIndex = 184
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtName.Location = New System.Drawing.Point(213, 162)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(257, 29)
        Me.txtName.TabIndex = 182
        '
        'txtStaffId
        '
        Me.txtStaffId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtStaffId.Location = New System.Drawing.Point(213, 111)
        Me.txtStaffId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffId.Name = "txtStaffId"
        Me.txtStaffId.Size = New System.Drawing.Size(133, 29)
        Me.txtStaffId.TabIndex = 181
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(774, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 17)
        Me.Label9.TabIndex = 180
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(552, 220)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(197, 28)
        Me.lblDate.TabIndex = 178
        Me.lblDate.Text = "Date In Charge:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(71, 219)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(106, 28)
        Me.lblPosition.TabIndex = 177
        Me.lblPosition.Text = "Position:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(71, 163)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(91, 28)
        Me.lblName.TabIndex = 176
        Me.lblName.Text = "Name:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(71, 111)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(99, 28)
        Me.lblID.TabIndex = 175
        Me.lblID.Text = "Staff ID:"
        '
        'LabelPATIENT
        '
        Me.LabelPATIENT.AutoSize = True
        Me.LabelPATIENT.BackColor = System.Drawing.Color.LightPink
        Me.LabelPATIENT.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelPATIENT.ForeColor = System.Drawing.Color.Black
        Me.LabelPATIENT.Location = New System.Drawing.Point(336, 34)
        Me.LabelPATIENT.Name = "LabelPATIENT"
        Me.LabelPATIENT.Size = New System.Drawing.Size(307, 49)
        Me.LabelPATIENT.TabIndex = 173
        Me.LabelPATIENT.Text = "STAFF DETAILS"
        '
        'idstaff
        '
        Me.idstaff.HeaderText = "idstaff"
        Me.idstaff.MinimumWidth = 6
        Me.idstaff.Name = "idstaff"
        Me.idstaff.Visible = False
        Me.idstaff.Width = 125
        '
        'bil
        '
        Me.bil.HeaderText = "Bil"
        Me.bil.MinimumWidth = 6
        Me.bil.Name = "bil"
        Me.bil.Width = 125
        '
        'nameStaff
        '
        Me.nameStaff.HeaderText = "Name"
        Me.nameStaff.MinimumWidth = 6
        Me.nameStaff.Name = "nameStaff"
        Me.nameStaff.Width = 125
        '
        'positionStaff
        '
        Me.positionStaff.HeaderText = "Position"
        Me.positionStaff.MinimumWidth = 6
        Me.positionStaff.Name = "positionStaff"
        Me.positionStaff.Width = 125
        '
        'phoneNumStaff
        '
        Me.phoneNumStaff.HeaderText = "Phone No."
        Me.phoneNumStaff.MinimumWidth = 6
        Me.phoneNumStaff.Name = "phoneNumStaff"
        Me.phoneNumStaff.Width = 125
        '
        'genderStaff
        '
        Me.genderStaff.HeaderText = "Gender"
        Me.genderStaff.MinimumWidth = 6
        Me.genderStaff.Name = "genderStaff"
        Me.genderStaff.Width = 125
        '
        'dateInChargeStaff
        '
        Me.dateInChargeStaff.HeaderText = "Date In Charge"
        Me.dateInChargeStaff.MinimumWidth = 6
        Me.dateInChargeStaff.Name = "dateInChargeStaff"
        Me.dateInChargeStaff.Width = 125
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurant_System.My.Resources.Resources.Gülmen_Interiors_presents__Istanbul_Coffee_Shop___Store
        Me.ClientSize = New System.Drawing.Size(996, 638)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtphoneNum)
        Me.Controls.Add(Me.lblphoneNum)
        Me.Controls.Add(Me.dgvStaff)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtdateInCharge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtStaffId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.LabelPATIENT)
        Me.Name = "Staff"
        Me.Text = "Staff"
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtphoneNum As TextBox
    Friend WithEvents lblphoneNum As Label
    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtdateInCharge As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStaffId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents LabelPATIENT As Label
    Friend WithEvents idstaff As DataGridViewTextBoxColumn
    Friend WithEvents bil As DataGridViewTextBoxColumn
    Friend WithEvents nameStaff As DataGridViewTextBoxColumn
    Friend WithEvents positionStaff As DataGridViewTextBoxColumn
    Friend WithEvents phoneNumStaff As DataGridViewTextBoxColumn
    Friend WithEvents genderStaff As DataGridViewTextBoxColumn
    Friend WithEvents dateInChargeStaff As DataGridViewTextBoxColumn
End Class
