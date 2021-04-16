Public Class Form1

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Const PixPerIn As Integer = 120
        Debug.WriteLine(Me.Height / PixPerIn)
    End Sub
End Class
