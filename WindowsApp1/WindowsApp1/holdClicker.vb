
Imports System.Runtime.InteropServices
Public Class holdClicker




    Declare Sub mouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)


    Private Const MOUSEEVENTF_LEFTDOWN = &H2
    Private Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Private Const MOUSEEVENTF_MIDDLEUP = &H40
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10
    Private holdBolean = False


    <DllImport("user32.dll")>
    Public Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function



    'start timer for keylogger when loading form
    Private Sub autoClickerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = 1
        Timer2.Start()
    End Sub






    ' timer to check for  home and end keys

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If GetAsyncKeyState(Keys.Home) <> 0 Then

            holdBolean = True
            While (holdBolean = True)

                mouse_event(MOUSEEVENTF_LEFTDOWN, 0&, 0&, 0, 0)
                Threading.Thread.Sleep(txtHoldTime.Text)
                mouse_event(MOUSEEVENTF_LEFTUP, 0&, 0&, 0, 0)

                If GetAsyncKeyState(Keys.End) <> 0 Then
                    holdBolean = False
                End If


            End While


            Me.Activate()
        End If


        If GetAsyncKeyState(Keys.End) <> 0 Then
            holdBolean = False
        End If

    End Sub

    'TOOL BAR
    Private Sub AreaCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreaCalculatorToolStripMenuItem.Click
        areaCalculator.Show()
    End Sub

    Private Sub AutoClickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoClickerToolStripMenuItem.Click
        autoClicker.Show()
    End Sub

    Private Sub ClickHolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClickHolderToolStripMenuItem.Click
        Me.Show()
    End Sub

End Class