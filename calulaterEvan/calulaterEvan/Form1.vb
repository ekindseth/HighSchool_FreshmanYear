Option Strict On
Public Class Form1
    Dim DblNbrOne As Double
    Dim DblNbrTwo As Double
    Dim DblNbrE As Double
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNbr1.Text = ""
        txtNbr2.Text = ""
        lblE.Text = ""
    End Sub
    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click
        DblNbrOne = (Integer.Parse(txtNbr1.Text))
        DblNbrTwo = (Integer.Parse(txtNbr2.Text))
        DblNbrE = DblNbrOne + DblNbrTwo
        lblE.Text = DblNbrE.ToString
    End Sub
    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click
        DblNbrOne = (Integer.Parse(txtNbr1.Text))
        DblNbrTwo = (Integer.Parse(txtNbr2.Text))
        DblNbrE = DblNbrOne - DblNbrTwo
        lblE.Text = DblNbrE.ToString
    End Sub
    Private Sub btnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD.Click
        DblNbrOne = (Integer.Parse(txtNbr1.Text))
        DblNbrTwo = (Integer.Parse(txtNbr2.Text))
        DblNbrE = DblNbrOne / DblNbrTwo
        lblE.Text = DblNbrE.ToString
        If DblNbrTwo = 0 Then
            lblE.Text = "Undifined"
        End If
    End Sub
    Private Sub btnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM.Click
        DblNbrOne = (Integer.Parse(txtNbr1.Text))
        DblNbrTwo = (Integer.Parse(txtNbr2.Text))
        DblNbrE = DblNbrOne * DblNbrTwo
        lblE.Text = DblNbrE.ToString
    End Sub
End Class
