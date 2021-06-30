<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerHome
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FoListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FoodOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.FoListToolStripMenuItem, Me.CustomerDetailToolStripMenuItem, Me.FoodOrderToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(976, 31)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(71, 27)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FoListToolStripMenuItem
        '
        Me.FoListToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FoListToolStripMenuItem.Name = "FoListToolStripMenuItem"
        Me.FoListToolStripMenuItem.Size = New System.Drawing.Size(92, 27)
        Me.FoListToolStripMenuItem.Text = "Food List"
        '
        'CustomerDetailToolStripMenuItem
        '
        Me.CustomerDetailToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.CustomerDetailToolStripMenuItem.Name = "CustomerDetailToolStripMenuItem"
        Me.CustomerDetailToolStripMenuItem.Size = New System.Drawing.Size(147, 27)
        Me.CustomerDetailToolStripMenuItem.Text = "Customer Detail"
        '
        'FoodOrderToolStripMenuItem
        '
        Me.FoodOrderToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FoodOrderToolStripMenuItem.Name = "FoodOrderToolStripMenuItem"
        Me.FoodOrderToolStripMenuItem.Size = New System.Drawing.Size(111, 27)
        Me.FoodOrderToolStripMenuItem.Text = "Food Order"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Brown
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(51, 27)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightPink
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 49)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome to Restaurant Putri"
        '
        'CustomerHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurant_System.My.Resources.Resources.VENDIDA_A_UN_NARCO__IMAGINA_CON_JUNGKOOK_
        Me.ClientSize = New System.Drawing.Size(976, 665)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CustomerHome"
        Me.Text = "CustomerHome"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerDetailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FoodOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents FoListToolStripMenuItem As ToolStripMenuItem
End Class
