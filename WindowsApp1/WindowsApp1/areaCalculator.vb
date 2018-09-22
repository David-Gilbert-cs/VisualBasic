Public Class areaCalculator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles popUpButton.Click
        MessageBox.Show("to calculate area of your rectangle please insert the width and height in labelled boxes then press calculate ")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        Try
            txtAns.Text = "the area of the rectangle is :" & vbNewLine & txtLenght.Text & "*" & txtWidth.Text & "=" & txtLenght.Text * txtWidth.Text
            txtAns.AutoSize = True
        Catch ex As Exception
            txtAns.Text = "Please input numerical value only"
        End Try




    End Sub

    Private Sub txtwidth_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged

    End Sub

    Private Sub RectangleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RectangleToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub MainPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainPageToolStripMenuItem.Click
        mainPage.Show()
    End Sub
End Class
