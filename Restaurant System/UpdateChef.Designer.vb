<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateChef
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtdateInCharge = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtphoneNum = New System.Windows.Forms.TextBox()
        Me.lblphoneNum = New System.Windows.Forms.Label()
        Me.LabelPATIENT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtID.Location = New System.Drawing.Point(240, 211)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(133, 29)
        Me.txtID.TabIndex = 197
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(68, 211)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(125, 32)
        Me.lblID.TabIndex = 196
        Me.lblID.Text = "Chef ID:"
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtGender.Location = New System.Drawing.Point(738, 213)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(164, 29)
        Me.txtGender.TabIndex = 195
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(191, 481)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 49)
        Me.btnSave.TabIndex = 194
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(697, 481)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(125, 49)
        Me.btnCancel.TabIndex = 193
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(465, 481)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(124, 49)
        Me.btnDelete.TabIndex = 192
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtPosition.Location = New System.Drawing.Point(738, 337)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(164, 29)
        Me.txtPosition.TabIndex = 188
        '
        'txtdateInCharge
        '
        Me.txtdateInCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtdateInCharge.Location = New System.Drawing.Point(738, 274)
        Me.txtdateInCharge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdateInCharge.Name = "txtdateInCharge"
        Me.txtdateInCharge.Size = New System.Drawing.Size(164, 29)
        Me.txtdateInCharge.TabIndex = 187
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtName.Location = New System.Drawing.Point(240, 279)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(257, 29)
        Me.txtName.TabIndex = 186
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(516, 275)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(228, 32)
        Me.lblDate.TabIndex = 185
        Me.lblDate.Text = "Date In Charge:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(570, 334)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(135, 32)
        Me.lblPosition.TabIndex = 184
        Me.lblPosition.Text = "Position:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(69, 277)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(103, 32)
        Me.lblName.TabIndex = 183
        Me.lblName.Text = "Name:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(583, 210)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(125, 32)
        Me.lblGender.TabIndex = 191
        Me.lblGender.Text = "Gender:"
        '
        'txtphoneNum
        '
        Me.txtphoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtphoneNum.Location = New System.Drawing.Point(240, 342)
        Me.txtphoneNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtphoneNum.Name = "txtphoneNum"
        Me.txtphoneNum.Size = New System.Drawing.Size(221, 29)
        Me.txtphoneNum.TabIndex = 190
        '
        'lblphoneNum
        '
        Me.lblphoneNum.AutoSize = True
        Me.lblphoneNum.BackColor = System.Drawing.Color.Transparent
        Me.lblphoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphoneNum.ForeColor = System.Drawing.Color.Black
        Me.lblphoneNum.Location = New System.Drawing.Point(69, 345)
        Me.lblphoneNum.Name = "lblphoneNum"
        Me.lblphoneNum.Size = New System.Drawing.Size(167, 32)
        Me.lblphoneNum.TabIndex = 189
        Me.lblphoneNum.Text = "Phone No.:"
        '
        'LabelPATIENT
        '
        Me.LabelPATIENT.AutoSize = True
        Me.LabelPATIENT.BackColor = System.Drawing.Color.LightPink
        Me.LabelPATIENT.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelPATIENT.ForeColor = System.Drawing.Color.Black
        Me.LabelPATIENT.Location = New System.Drawing.Point(382, 89)
        Me.LabelPATIENT.Name = "LabelPATIENT"
        Me.LabelPATIENT.Size = New System.Drawing.Size(293, 49)
        Me.LabelPATIENT.TabIndex = 181
        Me.LabelPATIENT.Text = "CHEF DETAILS"
        '
        'UpdateChef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurant_System.My.Resources.Resources.Gülmen_Interiors_presents__Istanbul_Coffee_Shop___Store
        Me.ClientSize = New System.Drawing.Size(991, 625)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtdateInCharge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtphoneNum)
        Me.Controls.Add(Me.lblphoneNum)
        Me.Controls.Add(Me.LabelPATIENT)
        Me.Name = "UpdateChef"
        Me.Text = "UpdateChef"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtdateInCharge As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtphoneNum As TextBox
    Friend WithEvents lblphoneNum As Label
    Friend WithEvents LabelPATIENT As Label
End Class
