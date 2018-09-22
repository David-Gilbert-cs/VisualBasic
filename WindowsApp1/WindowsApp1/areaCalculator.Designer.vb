<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class areaCalculator
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(areaCalculator))
        Me.popUpButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtLenght = New System.Windows.Forms.TextBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblLenght = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.MainPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectangleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'popUpButton
        '
        Me.popUpButton.Location = New System.Drawing.Point(233, 403)
        Me.popUpButton.Name = "popUpButton"
        Me.popUpButton.Size = New System.Drawing.Size(111, 35)
        Me.popUpButton.TabIndex = 0
        Me.popUpButton.Text = "&Help"
        Me.popUpButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoToolTip = True
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainPageToolStripMenuItem, Me.AreaCalculatorToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.ToolStripMenuItem1.Text = "options"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 196)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'calculateButton
        '
        Me.calculateButton.AccessibleName = "calculateButton"
        Me.calculateButton.Location = New System.Drawing.Point(367, 57)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 5
        Me.calculateButton.Text = "&calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'txtWidth
        '
        Me.txtWidth.AccessibleDescription = "math stuff"
        Me.txtWidth.AccessibleName = "width"
        Me.txtWidth.Location = New System.Drawing.Point(70, 62)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 6
        Me.txtWidth.Tag = "tagName"
        '
        'txtLenght
        '
        Me.txtLenght.AccessibleDescription = "math stuff"
        Me.txtLenght.AccessibleName = "lenght"
        Me.txtLenght.Location = New System.Drawing.Point(244, 62)
        Me.txtLenght.Name = "txtLenght"
        Me.txtLenght.Size = New System.Drawing.Size(100, 20)
        Me.txtLenght.TabIndex = 7
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(8, 62)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(32, 13)
        Me.lblWidth.TabIndex = 8
        Me.lblWidth.Text = "width"
        '
        'lblLenght
        '
        Me.lblLenght.AutoSize = True
        Me.lblLenght.Location = New System.Drawing.Point(182, 62)
        Me.lblLenght.Name = "lblLenght"
        Me.lblLenght.Size = New System.Drawing.Size(40, 13)
        Me.lblLenght.TabIndex = 9
        Me.lblLenght.Text = "Lenght"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Area"
        '
        'txtAns
        '
        Me.txtAns.AccessibleDescription = "math stuff"
        Me.txtAns.AccessibleName = "input"
        Me.txtAns.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAns.Location = New System.Drawing.Point(102, 126)
        Me.txtAns.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAns.Multiline = True
        Me.txtAns.Name = "txtAns"
        Me.txtAns.ReadOnly = True
        Me.txtAns.Size = New System.Drawing.Size(312, 42)
        Me.txtAns.TabIndex = 3
        Me.txtAns.Text = "answer"
        '
        'MainPageToolStripMenuItem
        '
        Me.MainPageToolStripMenuItem.Name = "MainPageToolStripMenuItem"
        Me.MainPageToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MainPageToolStripMenuItem.Text = "Main Page"
        '
        'AreaCalculatorToolStripMenuItem
        '
        Me.AreaCalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RectangleToolStripMenuItem})
        Me.AreaCalculatorToolStripMenuItem.Name = "AreaCalculatorToolStripMenuItem"
        Me.AreaCalculatorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AreaCalculatorToolStripMenuItem.Text = "Area Calculator"
        '
        'RectangleToolStripMenuItem
        '
        Me.RectangleToolStripMenuItem.Name = "RectangleToolStripMenuItem"
        Me.RectangleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RectangleToolStripMenuItem.Text = "rectangle"
        '
        'areaCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 450)
        Me.Controls.Add(Me.lblLenght)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.txtLenght)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.popUpButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "areaCalculator"
        Me.Tag = "rad"
        Me.Text = "Rectangle area calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents popUpButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtLenght As TextBox
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblLenght As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAns As TextBox
    Friend WithEvents MainPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AreaCalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RectangleToolStripMenuItem As ToolStripMenuItem
End Class
