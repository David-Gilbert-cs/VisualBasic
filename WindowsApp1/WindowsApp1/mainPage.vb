Public Class mainPage
    Private Sub RectangleToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub AreaCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreaCalculatorToolStripMenuItem.Click
        areaCalculator.Show()
    End Sub

    Private Sub AutoClickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoClickerToolStripMenuItem.Click
        autoClicker.Show()
    End Sub

    Private Sub ClickHolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClickHolderToolStripMenuItem.Click
        holdClicker.Show()
    End Sub
End Class