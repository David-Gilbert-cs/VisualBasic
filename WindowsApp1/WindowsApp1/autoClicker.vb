Imports System.Runtime.InteropServices

Public Class autoClicker

    Declare Sub mouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)


    Private Const MOUSEEVENTF_LEFTDOWN = &H2
    Private Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Private Const MOUSEEVENTF_MIDDLEUP = &H40
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10


    <DllImport("user32.dll")>
    Public Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function



    'start timer for keylogger when loading form
    Private Sub autoClickerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = 1
        Timer2.Start()
    End Sub


    'start timer for autoclicker
    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        Timer1.Start()

        Me.Activate()
    End Sub
    'stop timer for autoclcker
    Private Sub stop_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()

        TextBox1.Text = "press start for autoclick"

    End Sub


    'every timer tick click mouse at current location
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)

        mouse_event(&H4, 0, 0, 0, 1) ' right button

    End Sub

    Private Sub counter_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.lblCounter.Text += 1
    End Sub

    ' timer to check for  home and end keys

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If GetAsyncKeyState(Keys.Home) <> 0 Then
            Timer1.Start()

        End If


        If GetAsyncKeyState(Keys.End) <> 0 Then
            Timer1.Stop()

            TextBox1.Text = "press Home for autoclick"
        Else
            TextBox1.Text = "Press End key to stop autoclicker "
        End If

    End Sub



    'CLICK HOLDER

    Private Sub btnHold_Click(sender As Object, e As EventArgs) Handles btnHold.Click
        For i = 0 To 10
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0&, 0&, 0, 0)
            Threading.Thread.Sleep(lblHoldTime.Text)
            mouse_event(MOUSEEVENTF_LEFTUP, 0&, 0&, 0, 0)

        Next i
    End Sub

    'TOOL BAR
    Private Sub AreaCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreaCalculatorToolStripMenuItem.Click
        areaCalculator.Show()
    End Sub

    Private Sub AutoClickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoClickerToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ClickHolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClickHolderToolStripMenuItem.Click
        holdClicker.Show()
    End Sub

End Class