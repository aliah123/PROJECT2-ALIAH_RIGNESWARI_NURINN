<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStaff
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
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtphoneNum = New System.Windows.Forms.TextBox()
        Me.lblphoneNum = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.LabelPATIENT = New System.Windows.Forms.Label()
        Me.txtdateInCharge = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtGender.Location = New System.Drawing.Point(763, 173)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(164, 29)
        Me.txtGender.TabIndex = 201
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(204, 463)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 49)
        Me.btnSave.TabIndex = 200
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(663, 463)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(125, 49)
        Me.btnCancel.TabIndex = 199
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(420, 463)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(124, 49)
        Me.btnDelete.TabIndex = 198
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(529, 168)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(125, 32)
        Me.lblGender.TabIndex = 197
        Me.lblGender.Text = "Gender:"
        '
        'txtphoneNum
        '
        Me.txtphoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtphoneNum.Location = New System.Drawing.Point(228, 297)
        Me.txtphoneNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtphoneNum.Name = "txtphoneNum"
        Me.txtphoneNum.Size = New System.Drawing.Size(221, 29)
        Me.txtphoneNum.TabIndex = 196
        '
        'lblphoneNum
        '
        Me.lblphoneNum.AutoSize = True
        Me.lblphoneNum.BackColor = System.Drawing.Color.Transparent
        Me.lblphoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphoneNum.Location = New System.Drawing.Point(21, 301)
        Me.lblphoneNum.Name = "lblphoneNum"
        Me.lblphoneNum.Size = New System.Drawing.Size(167, 32)
        Me.lblphoneNum.TabIndex = 195
        Me.lblphoneNum.Text = "Phone No.:"
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtPosition.Location = New System.Drawing.Point(763, 297)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(164, 29)
        Me.txtPosition.TabIndex = 194
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtName.Location = New System.Drawing.Point(228, 238)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(257, 29)
        Me.txtName.TabIndex = 191
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtID.Location = New System.Drawing.Point(228, 172)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(133, 29)
        Me.txtID.TabIndex = 190
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(797, 314)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 17)
        Me.Label9.TabIndex = 189
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(529, 293)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(135, 32)
        Me.lblPosition.TabIndex = 186
        Me.lblPosition.Text = "Position:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(21, 234)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(103, 32)
        Me.lblName.TabIndex = 185
        Me.lblName.Text = "Name:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(21, 168)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(125, 32)
        Me.lblID.TabIndex = 184
        Me.lblID.Text = "Staff ID:"
        '
        'LabelPATIENT
        '
        Me.LabelPATIENT.AutoSize = True
        Me.LabelPATIENT.BackColor = System.Drawing.Color.Transparent
        Me.LabelPATIENT.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelPATIENT.ForeColor = System.Drawing.Color.Black
        Me.LabelPATIENT.Location = New System.Drawing.Point(322, 64)
        Me.LabelPATIENT.Name = "LabelPATIENT"
        Me.LabelPATIENT.Size = New System.Drawing.Size(307, 49)
        Me.LabelPATIENT.TabIndex = 182
        Me.LabelPATIENT.Text = "STAFF DETAILS"
        '
        'txtdateInCharge
        '
        Me.txtdateInCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtdateInCharge.Location = New System.Drawing.Point(763, 238)
        Me.txtdateInCharge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdateInCharge.Name = "txtdateInCharge"
        Me.txtdateInCharge.Size = New System.Drawing.Size(164, 29)
        Me.txtdateInCharge.TabIndex = 203
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(529, 235)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(228, 32)
        Me.lblDate.TabIndex = 202
        Me.lblDate.Text = "Date In Charge:"
        '
        'UpdateStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurant_System.My.Resources.Resources.Gülmen_Interiors_presents__Istanbul_Coffee_Shop___Store1
        Me.ClientSize = New System.Drawing.Size(997, 638)
        Me.Controls.Add(Me.txtdateInCharge)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtphoneNum)
        Me.Controls.Add(Me.lblphoneNum)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.LabelPATIENT)
        Me.Name = "UpdateStaff"
        Me.Text = "UpdateStaff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblGender As Label
    Friend WithEvents txtphoneNum As TextBox
    Friend WithEvents lblphoneNum As Label
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents LabelPATIENT As Label
    Friend WithEvents txtdateInCharge As TextBox
    Friend WithEvents lblDate As Label
End Class
