<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class holdClicker
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
        Me.components = New System.ComponentModel.Container()
        Me.lblHold = New System.Windows.Forms.Label()
        Me.lblHoldTime = New System.Windows.Forms.Label()
        Me.txtHoldTime = New System.Windows.Forms.RichTextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoClickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClickHolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHold
        '
        Me.lblHold.AutoSize = True
        Me.lblHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHold.Location = New System.Drawing.Point(37, 35)
        Me.lblHold.Name = "lblHold"
        Me.lblHold.Size = New System.Drawing.Size(129, 25)
        Me.lblHold.TabIndex = 14
        Me.lblHold.Text = "Click Holder"
        '
        'lblHoldTime
        '
        Me.lblHoldTime.AutoSize = True
        Me.lblHoldTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoldTime.Location = New System.Drawing.Point(37, 73)
        Me.lblHoldTime.Name = "lblHoldTime"
        Me.lblHoldTime.Size = New System.Drawing.Size(399, 18)
        Me.lblHoldTime.TabIndex = 13
        Me.lblHoldTime.Text = "Hold for how long in ms (start holding again after how long) "
        '
        'txtHoldTime
        '
        Me.txtHoldTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoldTime.Location = New System.Drawing.Point(42, 104)
        Me.txtHoldTime.Name = "txtHoldTime"
        Me.txtHoldTime.Size = New System.Drawing.Size(93, 30)
        Me.txtHoldTime.TabIndex = 12
        Me.txtHoldTime.Text = "3000"
        '
        'Timer2
        '
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(37, 196)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Padding = New System.Windows.Forms.Padding(1)
        Me.lblInfo.Size = New System.Drawing.Size(200, 50)
        Me.lblInfo.TabIndex = 16
        Me.lblInfo.Text = "PRESS HOME TO START PRESS END TO STOP"
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Location = New System.Drawing.Point(50, 233)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(258, 13)
        Me.lblWarning.TabIndex = 17
        Me.lblWarning.Text = "*Wont interrupt hold, only stop the repeating process*"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(453, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoToolTip = True
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainPageToolStripMenuItem, Me.AreaCalculatorToolStripMenuItem, Me.AutoClickerToolStripMenuItem, Me.ClickHolderToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.ToolStripMenuItem1.Text = "options"
        '
        'MainPageToolStripMenuItem
        '
        Me.MainPageToolStripMenuItem.Name = "MainPageToolStripMenuItem"
        Me.MainPageToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.MainPageToolStripMenuItem.Text = "Main Page"
        '
        'AreaCalculatorToolStripMenuItem
        '
        Me.AreaCalculatorToolStripMenuItem.Name = "AreaCalculatorToolStripMenuItem"
        Me.AreaCalculatorToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AreaCalculatorToolStripMenuItem.Text = "Area Calculator"
        '
        'AutoClickerToolStripMenuItem
        '
        Me.AutoClickerToolStripMenuItem.Name = "AutoClickerToolStripMenuItem"
        Me.AutoClickerToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AutoClickerToolStripMenuItem.Text = "AutoClicker"
        '
        'ClickHolderToolStripMenuItem
        '
        Me.ClickHolderToolStripMenuItem.Name = "ClickHolderToolStripMenuItem"
        Me.ClickHolderToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ClickHolderToolStripMenuItem.Text = "ClickHolder"
        '
        'holdClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 293)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblHold)
        Me.Controls.Add(Me.lblHoldTime)
        Me.Controls.Add(Me.txtHoldTime)
        Me.Name = "holdClicker"
        Me.Text = "holdClicker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHold As Label
    Friend WithEvents lblHoldTime As Label
    Friend WithEvents txtHoldTime As RichTextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblWarning As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MainPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AreaCalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoClickerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClickHolderToolStripMenuItem As ToolStripMenuItem
End Class
