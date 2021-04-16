Option Strict On
Public Class Form1
    Dim Strvar As String


    Private Sub btnBuild_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuild.Click
        Strvar = Microsoft.VisualBasic.Left(txtMDY.Text, 2) + Microsoft.VisualBasic.Left(txtLastName.Text, 1) + Microsoft.VisualBasic.Right(txtLastName.Text, 1) + Microsoft.VisualBasic.Left(txtFirstName.Text, 1) + Microsoft.VisualBasic.Right(txtMDY.Text, 2) + Microsoft.VisualBasic.Mid(txtMDY.Text, 4, 2) + CStr(CInt(Rnd() * 9))
        Strvar = UCase(Strvar)
        lblLnResult.Text = Strvar


    End Sub



    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Randomize()


    End Sub
End Class
