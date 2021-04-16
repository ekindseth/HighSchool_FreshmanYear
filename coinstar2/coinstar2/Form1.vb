Public Class Form1
    Dim intpennies As Integer
    Dim intnickels As Integer
    Dim intdimes As Integer
    Dim intquarters As Integer
    Dim intdollar As Integer
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtQuarters.Text = ""
        txtpennies.Text = ""
        txtDimes.Text = ""
        txtNickels.Text = ""
        lblNbrDollars.Text = "0"
        lblNbrQuarters.Text = "0"
        lblNbrDimes.Text = "0"
        lblNbrNickels.Text = "0"
        lblNbrPennies.Text = "0"
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        intquarters = (Integer.Parse(txtQuarters.Text) * 25)
        intdimes = (Integer.Parse(txtDimes.Text) * 10)
        intnickels = (Integer.Parse(txtNickels.Text) * 5)
        intpennies = (Integer.Parse(txtpennies.Text) * 1)
        intpennies = ((intquarters + intdimes) + (intnickels + intpennies))
        lblNbrNickels.Text = intpennies / 5 as 

    End Sub
End Class
