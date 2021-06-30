<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnChef = New System.Windows.Forms.Button()
        Me.btnCus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightPink
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Restaurant Putri"
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.HotPink
        Me.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdmin.Location = New System.Drawing.Point(610, 362)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(106, 37)
        Me.btnAdmin.TabIndex = 1
        Me.btnAdmin.Text = "ADMIN"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnChef
        '
        Me.btnChef.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChef.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnChef.Location = New System.Drawing.Point(465, 361)
        Me.btnChef.Name = "btnChef"
        Me.btnChef.Size = New System.Drawing.Size(83, 37)
        Me.btnChef.TabIndex = 2
        Me.btnChef.Text = "CHEF"
        Me.btnChef.UseVisualStyleBackColor = False
        '
        'btnCus
        '
        Me.btnCus.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCus.Location = New System.Drawing.Point(293, 361)
        Me.btnCus.Name = "btnCus"
        Me.btnCus.Size = New System.Drawing.Size(112, 38)
        Me.btnCus.TabIndex = 3
        Me.btnCus.Text = "CUSTOMER"
        Me.btnCus.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurant_System.My.Resources.Resources.เพลินไปกับความคิวท์ของคาเฟ่สีชมพูสาขาใหม่ที่_House_Of_Eden_at_Siam_Discovery
        Me.ClientSize = New System.Drawing.Size(996, 655)
        Me.Controls.Add(Me.btnCus)
        Me.Controls.Add(Me.btnChef)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnChef As Button
    Friend WithEvents btnCus As Button
End Class
