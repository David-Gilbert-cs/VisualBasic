<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainPage
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
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoClickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClickHolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 11
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
        Me.MainPageToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MainPageToolStripMenuItem.Text = "Main Page"
        '
        'AreaCalculatorToolStripMenuItem
        '
        Me.AreaCalculatorToolStripMenuItem.Name = "AreaCalculatorToolStripMenuItem"
        Me.AreaCalculatorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AreaCalculatorToolStripMenuItem.Text = "Area Calculator"
        '
        'AutoClickerToolStripMenuItem
        '
        Me.AutoClickerToolStripMenuItem.Name = "AutoClickerToolStripMenuItem"
        Me.AutoClickerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AutoClickerToolStripMenuItem.Text = "AutoClicker"
        '
        'ClickHolderToolStripMenuItem
        '
        Me.ClickHolderToolStripMenuItem.Name = "ClickHolderToolStripMenuItem"
        Me.ClickHolderToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClickHolderToolStripMenuItem.Text = "ClickHolder"
        '
        'mainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "mainPage"
        Me.Text = "Main Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MainPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AreaCalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoClickerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClickHolderToolStripMenuItem As ToolStripMenuItem
End Class
