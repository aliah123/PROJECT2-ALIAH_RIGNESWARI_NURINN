<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chef
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
        Me.txtdateInCharge = New System.Windows.Forms.TextBox()
        Me.LabelPATIENT = New System.Windows.Forms.Label()
        Me.dgvChef = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblphoneNum = New System.Windows.Forms.Label()
        Me.txtphoneNum = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.idchef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namechef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.positionChef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phoneNumChef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genderChef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateInChargeChef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvChef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdateInCharge
        '
        Me.txtdateInCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtdateInCharge.Location = New System.Drawing.Point(713, 181)
        Me.txtdateInCharge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdateInCharge.Name = "txtdateInCharge"
        Me.txtdateInCharge.Size = New System.Drawing.Size(164, 29)
        Me.txtdateInCharge.TabIndex = 178
        '
        'LabelPATIENT
        '
        Me.LabelPATIENT.AutoSize = True
        Me.LabelPATIENT.BackColor = System.Drawing.Color.LightPink
        Me.LabelPATIENT.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelPATIENT.ForeColor = System.Drawing.Color.Black
        Me.LabelPATIENT.Location = New System.Drawing.Point(354, 37)
        Me.LabelPATIENT.Name = "LabelPATIENT"
        Me.LabelPATIENT.Size = New System.Drawing.Size(303, 49)
        Me.LabelPATIENT.TabIndex = 172
        Me.LabelPATIENT.Text = "CHEF  DETAILS"
        '
        'dgvChef
        '
        Me.dgvChef.BackgroundColor = System.Drawing.Color.Linen
        Me.dgvChef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChef.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idchef, Me.bil, Me.namechef, Me.positionChef, Me.phoneNumChef, Me.genderChef, Me.dateInChargeChef})
        Me.dgvChef.GridColor = System.Drawing.SystemColors.ControlText
        Me.dgvChef.Location = New System.Drawing.Point(80, 300)
        Me.dgvChef.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvChef.Name = "dgvChef"
        Me.dgvChef.RowHeadersWidth = 51
        Me.dgvChef.RowTemplate.Height = 24
        Me.dgvChef.Size = New System.Drawing.Size(870, 191)
        Me.dgvChef.TabIndex = 180
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(206, 542)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 49)
        Me.btnAdd.TabIndex = 181
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(448, 542)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 49)
        Me.btnUpdate.TabIndex = 182
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(644, 542)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(129, 49)
        Me.btnCancel.TabIndex = 183
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblphoneNum
        '
        Me.lblphoneNum.AutoSize = True
        Me.lblphoneNum.BackColor = System.Drawing.Color.Transparent
        Me.lblphoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphoneNum.Location = New System.Drawing.Point(67, 241)
        Me.lblphoneNum.Name = "lblphoneNum"
        Me.lblphoneNum.Size = New System.Drawing.Size(116, 24)
        Me.lblphoneNum.TabIndex = 184
        Me.lblphoneNum.Text = "Phone No.:"
        '
        'txtphoneNum
        '
        Me.txtphoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtphoneNum.Location = New System.Drawing.Point(197, 236)
        Me.txtphoneNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtphoneNum.Name = "txtphoneNum"
        Me.txtphoneNum.Size = New System.Drawing.Size(221, 29)
        Me.txtphoneNum.TabIndex = 185
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(533, 132)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(86, 24)
        Me.lblGender.TabIndex = 186
        Me.lblGender.Text = "Gender:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(67, 181)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(71, 24)
        Me.lblName.TabIndex = 174
        Me.lblName.Text = "Name:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(533, 236)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(90, 24)
        Me.lblPosition.TabIndex = 175
        Me.lblPosition.Text = "Position:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.Location = New System.Drawing.Point(532, 181)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(165, 25)
        Me.lblDate.TabIndex = 176
        Me.lblDate.Text = "Date In Charge:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtName.Location = New System.Drawing.Point(197, 177)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(257, 29)
        Me.txtName.TabIndex = 177
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtGender.Location = New System.Drawing.Point(713, 128)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(164, 29)
        Me.txtGender.TabIndex = 187
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(66, 128)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(92, 25)
        Me.lblID.TabIndex = 188
        Me.lblID.Text = "Chef ID:"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtID.Location = New System.Drawing.Point(197, 132)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(133, 29)
        Me.txtID.TabIndex = 189
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtPosition.Location = New System.Drawing.Point(713, 237)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(257, 29)
        Me.txtPosition.TabIndex = 179
        '
        'idchef
        '
        Me.idchef.HeaderText = "idchef"
        Me.idchef.MinimumWidth = 6
        Me.idchef.Name = "idchef"
        Me.idchef.Visible = False
        Me.idchef.Width = 125
        '
        'bil
        '
        Me.bil.HeaderText = "Bil"
        Me.bil.MinimumWidth = 6
        Me.bil.Name = "bil"
        Me.bil.Width = 125
        '
        'namechef
        '
        Me.namechef.HeaderText = "Name"
        Me.namechef.MinimumWidth = 6
        Me.namechef.Name = "namechef"
        Me.namechef.Width = 125
        '
        'positionChef
        '
        Me.positionChef.HeaderText = "Position"
        Me.positionChef.MinimumWidth = 6
        Me.positionChef.Name = "positionChef"
        Me.positionChef.Width = 125
        '
        'phoneNumChef
        '
        Me.phoneNumChef.HeaderText = "Phone No."
        Me.phoneNumChef.MinimumWidth = 6
        Me.phoneNumChef.Name = "phoneNumChef"
        Me.phoneNumChef.Width = 125
        '
        'genderChef
        '
        Me.genderChef.HeaderText = "Gender"
        Me.genderChef.MinimumWidth = 6
        Me.genderChef.Name = "genderChef"
        Me.genderChef.Width = 125
        '
        'dateInChargeChef
        '
        Me.dateInChargeChef.HeaderText = "Date In Charge"
        Me.dateInChargeChef.MinimumWidth = 6
        Me.dateInChargeChef.Name = "dateInChargeChef"
        Me.dateInChargeChef.Width = 125
        '
        'Chef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurant_System.My.Resources.Resources.Gülmen_Interiors_presents__Istanbul_Coffee_Shop___Store2
        Me.ClientSize = New System.Drawing.Size(999, 629)
        Me.Controls.Add(Me.txtdateInCharge)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtphoneNum)
        Me.Controls.Add(Me.lblphoneNum)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvChef)
        Me.Controls.Add(Me.LabelPATIENT)
        Me.Name = "Chef"
        Me.Text = "Chef"
        CType(Me.dgvChef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtdateInCharge As TextBox
    Friend WithEvents LabelPATIENT As Label
    Friend WithEvents dgvChef As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblphoneNum As Label
    Friend WithEvents txtphoneNum As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents idchef As DataGridViewTextBoxColumn
    Friend WithEvents bil As DataGridViewTextBoxColumn
    Friend WithEvents namechef As DataGridViewTextBoxColumn
    Friend WithEvents positionChef As DataGridViewTextBoxColumn
    Friend WithEvents phoneNumChef As DataGridViewTextBoxColumn
    Friend WithEvents genderChef As DataGridViewTextBoxColumn
    Friend WithEvents dateInChargeChef As DataGridViewTextBoxColumn
End Class
