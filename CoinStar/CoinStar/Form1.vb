Option Strict On
Public Class
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtQuarters.Text = " "
        txtpennies.Text = " "
        txtDimes.Text = " "
        txtNickels.Text = " "
        lblNbrDollars.Text = "0"
        lblNbrQuarters.Text = "0"
        lblNbrDimes.Text = "0"
        lblNbrNickels.Text = "0"
        lblNbrPennies.Text = "0"
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Integer.Parse(txtQuarters.Text)
        Integer.Parse(txtDimes.Text)
        Integer.Parse(txtNickels.Text)
        Integer.Parse(txtpennies.Text)
        Integer.Parse(lblNbrDollars.Text)
        txtQuarters.Text*25 + txtpennies.Text =txtNbrPennies.Text
        txtDimes.Text*10 + txtJNbrPennies.Text =txtNbrPennies.Text
        txtNickels.text*5 + txtJNbrPennies.Text =txtNbrPennies.Text
    End Sub
End Class
