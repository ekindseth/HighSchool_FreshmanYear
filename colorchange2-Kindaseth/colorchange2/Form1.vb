Public Class Form1

    Private Sub btnblue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnblue.Click
        Me.BackColor = Color.Blue
    End Sub

    Private Sub btnYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYellow.Click
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.BackColor = Color.Red
    End Sub

    Private Sub Form1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Me.BackColor = Color.Green
    End Sub
End Class
