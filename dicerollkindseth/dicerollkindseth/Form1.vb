Option Strict On
Public Class Form1
    Dim num As Integer
    Dim times As Integer
    Dim row As Integer
    Dim dice As Integer
    Private Sub btnquit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnquit.Click
        Me.Close()
    End Sub
    Private Sub btnroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnroll.Click
        num = Integer.Parse(txtnum.Text)
        times = Integer.Parse(txttimes.Text)
        row = 0
        dice = 0
        Do Until row = times
            ' Initialize the random-number generator.
            Randomize()
            ' Generate random value between 1 and 6. 
            Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
            If value = num Then
                row = row + 1
            Else
                row = 0
            End If
            dice = dice + 1
        Loop
        answer.Text = dice.ToString
    End Sub
End Class
