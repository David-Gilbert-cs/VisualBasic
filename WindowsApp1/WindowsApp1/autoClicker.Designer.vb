<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class autoClicker
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
        Me.start = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnHold = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblHoldTime = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblHold = New System.Windows.Forms.Label()
        Me.lblAutoClick = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoClickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClickHolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(24, 82)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(111, 48)
        Me.start.TabIndex = 0
        Me.start.Text = "&Start"
        Me.start.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "S&top"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(42, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 48)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "click counter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Location = New System.Drawing.Point(159, 172)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(13, 13)
        Me.lblCounter.TabIndex = 3
        Me.lblCounter.Text = "0"
        '
        'Timer2
        '
        '
        'btnHold
        '
        Me.btnHold.Location = New System.Drawing.Point(216, 350)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(103, 70)
        Me.btnHold.TabIndex = 4
        Me.btnHold.Text = "Hold Click"
        Me.btnHold.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(42, 208)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "press start for autoclick"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(60, 371)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(93, 24)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = "3000"
        '
        'lblHoldTime
        '
        Me.lblHoldTime.AutoSize = True
        Me.lblHoldTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoldTime.Location = New System.Drawing.Point(12, 317)
        Me.lblHoldTime.Name = "lblHoldTime"
        Me.lblHoldTime.Size = New System.Drawing.Size(218, 18)
        Me.lblHoldTime.TabIndex = 7
        Me.lblHoldTime.Text = "Hold for how long (miliseconds)"
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(21, 250)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(277, 13)
        Me.lblLine.TabIndex = 9
        Me.lblLine.Text = "_____________________________________________"
        '
        'lblHold
        '
        Me.lblHold.AutoSize = True
        Me.lblHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHold.Location = New System.Drawing.Point(12, 279)
        Me.lblHold.Name = "lblHold"
        Me.lblHold.Size = New System.Drawing.Size(129, 25)
        Me.lblHold.TabIndex = 10
        Me.lblHold.Text = "Click Holder"
        '
        'lblAutoClick
        '
        Me.lblAutoClick.AutoSize = True
        Me.lblAutoClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutoClick.Location = New System.Drawing.Point(17, 23)
        Me.lblAutoClick.Name = "lblAutoClick"
        Me.lblAutoClick.Size = New System.Drawing.Size(124, 25)
        Me.lblAutoClick.TabIndex = 11
        Me.lblAutoClick.Text = "AutoClicker"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 12
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
        'autoClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblAutoClick)
        Me.Controls.Add(Me.lblHold)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.lblHoldTime)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnHold)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.start)
        Me.KeyPreview = True
        Me.Name = "autoClicker"
        Me.Text = "Autoclicker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents start As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents lblCounter As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnHold As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lblHoldTime As Label
    Friend WithEvents lblLine As Label
    Friend WithEvents lblHold As Label
    Friend WithEvents lblAutoClick As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MainPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AreaCalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoClickerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClickHolderToolStripMenuItem As ToolStripMenuItem
End Class
