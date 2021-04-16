Option Strict On
Public Class Form1
    Dim points1 As Integer
    Dim points2 As Integer
    Dim pick1 As Integer
    Dim good As Integer
    Dim ties As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        good1.Visible = False
        good2.Visible = False
        good3.Visible = False
        good = 0
        Randomize()
        Dim pick2 As Integer = CInt(Int((3 * Rnd()) + 1))
        Select Case pick2
            Case 1
                lblcp.Text = "Rock"
            Case 2
                lblcp.Text = "Paper"
            Case 3
                lblcp.Text = "Scissors"
        End Select
        If RadioButton1.Checked = True Then
            pick1 = 2
            lblyp.Text = "Paper"
        End If
        If RadioButton2.Checked = True Then
            pick1 = 1
            lblyp.Text = "Rock"
        End If
        If RadioButton3.Checked = True Then
            pick1 = 3
            lblyp.Text = "Scissors"
        End If
        If pick2 = 1 Then
            Select Case pick1
                Case 1
                    good = 2
                Case 2
                    good = 3
                Case 3
                    good = 1
            End Select
        End If
        If pick2 = 2 Then
            Select Case pick1
                Case 1
                    good = 1
                Case 2
                    good = 2
                Case 3
                    good = 3
            End Select
        End If
        If pick2 = 3 Then
            Select Case pick1
                Case 1
                    good = 3
                Case 2
                    good = 1
                Case 3
                    good = 2
            End Select
        End If
        Select Case good
            Case 1
                good1.Visible = True
                points2 = points2 + 1
                lblp2.Text = points2.ToString
            Case 2
                good2.Visible = True
                ties = ties + 1
                lblt.Text = ties.ToString
            Case 3
                good3.Visible = True
                points1 = points1 + 1
                lblp.Text = points1.ToString
        End Select
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        points1 = 0
        points2 = 0
        ties = 0
        lblp.Text = "0"
        lblt.Text = "0"
        lblp2.Text = "0"
    End Sub
End Class
