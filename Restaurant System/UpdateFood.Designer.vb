<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateFood
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
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblMedicine = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMedic
        '
        Me.txtMedic.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtMedic.Location = New System.Drawing.Point(217, 211)
        Me.txtMedic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMedic.Name = "txtMedic"
        Me.txtMedic.Size = New System.Drawing.Size(193, 29)
        Me.txtMedic.TabIndex = 220
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 32)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "Food ID:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtQuantity.Location = New System.Drawing.Point(601, 213)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(193, 29)
        Me.txtQuantity.TabIndex = 218
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtName.Location = New System.Drawing.Point(217, 349)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(193, 29)
        Me.txtName.TabIndex = 215
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtCode.Location = New System.Drawing.Point(217, 279)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(193, 29)
        Me.txtCode.TabIndex = 214
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(467, 213)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(139, 32)
        Me.lblQuantity.TabIndex = 213
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblMedicine
        '
        Me.lblMedicine.AutoSize = True
        Me.lblMedicine.BackColor = System.Drawing.Color.LightPink
        Me.lblMedicine.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblMedicine.ForeColor = System.Drawing.Color.Black
        Me.lblMedicine.Location = New System.Drawing.Point(308, 87)
        Me.lblMedicine.Name = "lblMedicine"
        Me.lblMedicine.Size = New System.Drawing.Size(296, 49)
        Me.lblMedicine.TabIndex = 212
        Me.lblMedicine.Text = "FOOD DETAILS"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(485, 277)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(91, 32)
        Me.lblType.TabIndex = 211
        Me.lblType.Text = "Type:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(63, 349)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(103, 32)
        Me.lblName.TabIndex = 210
        Me.lblName.Text = "Name:"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(63, 277)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(162, 32)
        Me.lblCode.TabIndex = 209
        Me.lblCode.Text = "Item Code:"
        '
        'txtType
        '
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtType.Location = New System.Drawing.Point(601, 279)
        Me.txtType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(193, 29)
        Me.txtType.TabIndex = 216
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(126, 475)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 49)
        Me.btnSave.TabIndex = 208
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(571, 475)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(125, 49)
        Me.btnCancel.TabIndex = 207
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(349, 475)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(124, 49)
        Me.btnDelete.TabIndex = 206
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'UpdateFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurant_System.My.Resources.Resources.Gülmen_Interiors_presents__Istanbul_Coffee_Shop___Store
        Me.ClientSize = New System.Drawing.Size(860, 635)
        Me.Controls.Add(Me.txtMedic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblMedicine)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Name = "UpdateFood"
        Me.Text = "UpdateFood"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMedic As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblMedicine As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
End Class
