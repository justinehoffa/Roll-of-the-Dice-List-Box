<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RolloftheDice
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
        Dim RolloftheDiceLabel As System.Windows.Forms.Label
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiceListBox = New System.Windows.Forms.ListBox()
        RolloftheDiceLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'RolloftheDiceLabel
        '
        RolloftheDiceLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        RolloftheDiceLabel.AutoSize = True
        RolloftheDiceLabel.Font = New System.Drawing.Font("Rockwell", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RolloftheDiceLabel.Location = New System.Drawing.Point(374, 56)
        RolloftheDiceLabel.Name = "RolloftheDiceLabel"
        RolloftheDiceLabel.Size = New System.Drawing.Size(388, 59)
        RolloftheDiceLabel.TabIndex = 5
        RolloftheDiceLabel.Text = "Roll of the Dice"
        '
        'RollButton
        '
        Me.RollButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.RollButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RollButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RollButton.Font = New System.Drawing.Font("Rockwell", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RollButton.Location = New System.Drawing.Point(126, 638)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(237, 132)
        Me.RollButton.TabIndex = 0
        Me.RollButton.Text = "&Roll"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ClearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClearButton.Font = New System.Drawing.Font("Rockwell", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(466, 638)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(237, 132)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ExitButton.Font = New System.Drawing.Font("Rockwell", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(806, 638)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(237, 132)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1163, 40)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RollToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(98, 36)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'RollToolStripMenuItem
        '
        Me.RollToolStripMenuItem.Name = "RollToolStripMenuItem"
        Me.RollToolStripMenuItem.Size = New System.Drawing.Size(203, 44)
        Me.RollToolStripMenuItem.Text = "Roll"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(203, 44)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(203, 44)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(85, 36)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'DiceListBox
        '
        Me.DiceListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiceListBox.Font = New System.Drawing.Font("Ebrima", 8.25!)
        Me.DiceListBox.FormattingEnabled = True
        Me.DiceListBox.ItemHeight = 30
        Me.DiceListBox.Location = New System.Drawing.Point(37, 135)
        Me.DiceListBox.Name = "DiceListBox"
        Me.DiceListBox.Size = New System.Drawing.Size(1095, 454)
        Me.DiceListBox.TabIndex = 4
        '
        'RolloftheDice
        '
        Me.AcceptButton = Me.RollButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1163, 799)
        Me.ControlBox = False
        Me.Controls.Add(RolloftheDiceLabel)
        Me.Controls.Add(Me.DiceListBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RolloftheDice"
        Me.Text = "Roll of the Dice"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents RollButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiceListBox As ListBox
End Class
