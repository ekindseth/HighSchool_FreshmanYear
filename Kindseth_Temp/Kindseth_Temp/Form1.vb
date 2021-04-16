Public Class Form1 
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        vsbTemp.Value = 32
        txtCentigrade.Text = 0
        txtFahrenheit.Text = 32
    End Sub
    Private Sub vsbTemp_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsbTemp.Scroll
        txtFahrenheit.Text = vsbTemp.Value
        txtCentigrade.Text = (txtFahrenheit.Text - 32) * (5 / 9)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
