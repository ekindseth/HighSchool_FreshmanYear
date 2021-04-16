Option Strict On
Public Class Form1
    Dim varword As Integer
    Dim man As Integer
    Dim word As String

    Private Sub hangman()
        'the man variable adds up and this is the image that shows
        Select Case man
            Case 1
                pichead.Visible = True
                picnorm.Visible = False
            Case 2
                picbody.Visible = True
                picnorm.Visible = False
                pichead.Visible = False
            Case 3
                pic1leg.Visible = True
                picnorm.Visible = False
                pichead.Visible = False
                picbody.Visible = False
            Case 4
                picleg2.Visible = True
                pic1leg.Visible = False
                picnorm.Visible = False
                pichead.Visible = False
                picbody.Visible = False
            Case 5
                pic1arm.Visible = True
                picleg2.Visible = False
                pic1leg.Visible = False
                picnorm.Visible = False
                pichead.Visible = False
                picbody.Visible = False
            Case 6
                picdead.Visible = True
                pic1arm.Visible = False
                picleg2.Visible = False
                pic1leg.Visible = False
                picnorm.Visible = False
                pichead.Visible = False
                picbody.Visible = False
                lblyoulose.Visible = True
                lblL1.Visible = True
                lblL2.Visible = True
                lblL3.Visible = True
                lblL4.Visible = True
                lblL5.Visible = True
                lblL6.Visible = True
                lblL7.Visible = True
                lblL8.Visible = True
        End Select
    End Sub

    'when you win you win appear 
    Private Sub victory()
        Select Case varword
            Case 2, 7, 9, 15, 17, 20
                If lblL1.Visible = True And lblL2.Visible = True And lblL3.Visible = True And lblL4.Visible = True And lblL5.Visible = True And lblL6.Visible = True And lblyoulose.Visible = False And lblyougaveup.Visible = False Then
                    lblYouwin.Visible = True
                End If
            Case 3, 5, 6, 8, 10, 11, 13, 14, 16
                If lblL1.Visible = True And lblL2.Visible = True And lblL3.Visible = True And lblL4.Visible = True And lblL5.Visible = True And lblL6.Visible = True And lblL7.Visible = True And lblyoulose.Visible = False And lblyougaveup.Visible = False Then
                    lblYouwin.Visible = True
                End If
            Case Else
                If lblL1.Visible = True And lblL2.Visible = True And lblL3.Visible = True And lblL4.Visible = True And lblL5.Visible = True And lblL6.Visible = True And lblL7.Visible = True And lblL8.Visible = True And lblyoulose.Visible = False And lblyougaveup.Visible = False Then
                    lblYouwin.Visible = True
                End If
        End Select
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Randomize()
        ' Generate random value between 1 and 20. 
        varword = CInt(Int((20 * Rnd()) + 1))
        Select Case varword
            'words
            Case 1
                word = "FISHHOOK"
                Label7.Visible = True
                Label8.Visible = True
                lblL1.Text = "F"
                lblL2.Text = "i"
                lblL3.Text = "s"
                lblL4.Text = "h"
                lblL5.Text = "h"
                lblL6.Text = "o"
                lblL7.Text = "o"
                lblL8.Text = "k"
            Case 2
                word = "CARPET"
                lblL1.Text = "C"
                lblL2.Text = "a"
                lblL3.Text = "r"
                lblL4.Text = "p"
                lblL5.Text = "e"
                lblL6.Text = "t"
            Case 3
                word = "WARSHIP"
                Label7.Visible = True
                lblL1.Text = "w"
                lblL2.Text = "a"
                lblL3.Text = "r"
                lblL4.Text = "s"
                lblL5.Text = "h"
                lblL6.Text = "i"
                lblL7.Text = "p"
            Case 4
                word = "HANDCUFF"
                Label7.Visible = True
                Label8.Visible = True
                lblL1.Text = "H"
                lblL2.Text = "a"
                lblL3.Text = "n"
                lblL4.Text = "d"
                lblL5.Text = "c"
                lblL6.Text = "u"
                lblL7.Text = "f"
                lblL8.Text = "f"
            Case 5
                word = "RAILWAY"
                Label7.Visible = True
                lblL1.Text = "R"
                lblL2.Text = "a"
                lblL3.Text = "i"
                lblL4.Text = "l"
                lblL5.Text = "w"
                lblL6.Text = "a"
                lblL7.Text = "y"
            Case 6
                word = "RAINBOW"
                Label7.Visible = True
                lblL1.Text = "R"
                lblL2.Text = "a"
                lblL3.Text = "i"
                lblL4.Text = "n"
                lblL5.Text = "b"
                lblL6.Text = "o"
                lblL7.Text = "w"
            Case 7
                word = "CUTLET"
                lblL1.Text = "C"
                lblL2.Text = "u"
                lblL3.Text = "t"
                lblL4.Text = "l"
                lblL5.Text = "e"
                lblL6.Text = "t"
            Case 8
                word = "SEAFOOD"
                Label7.Visible = True
                lblL1.Text = "S"
                lblL2.Text = "e"
                lblL3.Text = "a"
                lblL4.Text = "f"
                lblL5.Text = "o"
                lblL6.Text = "o"
                lblL7.Text = "d"
            Case 9
                word = "INSIDE"
                lblL1.Text = "I"
                lblL2.Text = "n"
                lblL3.Text = "s"
                lblL4.Text = "i"
                lblL5.Text = "d"
                lblL6.Text = "e"
            Case 10
                word = "HALLWAY"
                Label7.Visible = True
                lblL1.Text = "H"
                lblL2.Text = "a"
                lblL3.Text = "l"
                lblL4.Text = "l"
                lblL5.Text = "w"
                lblL6.Text = "a"
                lblL7.Text = "y"
            Case 11
                word = "PANCAKE"
                Label7.Visible = True
                lblL1.Text = "P"
                lblL2.Text = "a"
                lblL3.Text = "n"
                lblL4.Text = "c"
                lblL5.Text = "a"
                lblL6.Text = "k"
                lblL7.Text = "e"
            Case 12
                word = "OVERDOSE"
                Label7.Visible = True
                Label8.Visible = True
                lblL1.Text = "O"
                lblL2.Text = "v"
                lblL3.Text = "e"
                lblL4.Text = "r"
                lblL5.Text = "d"
                lblL6.Text = "o"
                lblL7.Text = "s"
                lblL8.Text = "e"
            Case 13
                word = "POPCORN"
                Label7.Visible = True
                lblL1.Text = "P"
                lblL2.Text = "o"
                lblL3.Text = "p"
                lblL4.Text = "c"
                lblL5.Text = "o"
                lblL6.Text = "r"
                lblL7.Text = "n"
            Case 14
                word = "DROPLET"
                Label7.Visible = True
                lblL1.Text = "D"
                lblL2.Text = "r"
                lblL3.Text = "o"
                lblL4.Text = "p"
                lblL5.Text = "l"
                lblL6.Text = "e"
                lblL7.Text = "t"
            Case 15
                word = "SPRING"
                lblL1.Text = "S"
                lblL2.Text = "p"
                lblL3.Text = "r"
                lblL4.Text = "i"
                lblL5.Text = "n"
                lblL6.Text = "g"
            Case 16
                word = "AIRPORT"
                Label7.Visible = True
                lblL1.Text = "A"
                lblL2.Text = "i"
                lblL3.Text = "r"
                lblL4.Text = "p"
                lblL5.Text = "o"
                lblL6.Text = "r"
                lblL7.Text = "t"
            Case 17
                word = "TEAPOT"
                lblL1.Text = "T"
                lblL2.Text = "e"
                lblL3.Text = "a"
                lblL4.Text = "p"
                lblL5.Text = "o"
                lblL6.Text = "t"
            Case 18
                word = "MEATBALL"
                Label7.Visible = True
                Label8.Visible = True
                lblL1.Text = "M"
                lblL2.Text = "e"
                lblL3.Text = "a"
                lblL4.Text = "t"
                lblL5.Text = "b"
                lblL6.Text = "a"
                lblL7.Text = "l"
                lblL8.Text = "l"
            Case 19
                word = "FORECAST"
                Label7.Visible = True
                Label8.Visible = True
                lblL1.Text = "F"
                lblL2.Text = "o"
                lblL3.Text = "r"
                lblL4.Text = "e"
                lblL5.Text = "c"
                lblL6.Text = "a"
                lblL7.Text = "s"
                lblL8.Text = "t"
            Case 20
                word = "MYSELF"
                lblL1.Text = "M"
                lblL2.Text = "y"
                lblL3.Text = "s"
                lblL4.Text = "e"
                lblL5.Text = "l"
                lblL6.Text = "f"
        End Select
    End Sub
    ' when the letter is clicked make leter visable
    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click
        If btnA.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 3, 4, 5, 6, 2
                    lblL2.Visible = True
                    btnA.BackColor = Color.ForestGreen
                Case 6, 8, 17
                    lblL3.Visible = True
                    btnA.BackColor = Color.ForestGreen
                Case 16
                    lblL1.Visible = True
                    btnA.BackColor = Color.ForestGreen
                Case 5, 19
                    lblL6.Visible = True
                    btnA.BackColor = Color.ForestGreen
                Case 11
                    lblL2.Visible = True
                    lblL5.Visible = True
                    btnA.BackColor = Color.ForestGreen
                Case 10
                    lblL2.Visible = True
                    lblL6.Visible = True
                    btnA.BackColor = Color.ForestGreen
                Case 18
                    lblL3.Visible = True
                    lblL6.Visible = True
                    btnA.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnA.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB.Click
        If btnB.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 6, 18
                    lblL5.Visible = True
                    btnB.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnB.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        If btnC.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 2, 7
                    lblL1.Visible = True
                    btnC.BackColor = Color.ForestGreen
                Case 4, 19
                    lblL5.Visible = True
                    btnC.BackColor = Color.ForestGreen
                Case 11, 13
                    lblL4.Visible = True
                    btnC.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnC.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD.Click
        If btnD.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 4
                    lblL4.Visible = True
                    btnD.BackColor = Color.ForestGreen
                Case 8
                    lblL7.Visible = True
                    btnD.BackColor = Color.ForestGreen
                Case 9, 12
                    lblL5.Visible = True
                    btnD.BackColor = Color.ForestGreen
                Case 14
                    lblL1.Visible = True
                    btnD.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnD.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click
        If btnE.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 12
                    lblL8.Visible = True
                    lblL3.Visible = True
                    btnE.BackColor = Color.ForestGreen
                Case 11
                    lblL7.Visible = True
                    btnE.BackColor = Color.ForestGreen
                Case 19
                    lblL4.Visible = True
                    btnE.BackColor = Color.ForestGreen
                Case 8
                    lblL2.Visible = True
                    btnE.BackColor = Color.ForestGreen
                Case 9, 14
                    lblL6.Visible = True
                    btnE.BackColor = Color.ForestGreen
                Case 2, 7
                    lblL5.Visible = True
                    btnE.BackColor = Color.ForestGreen
                Case 17, 18
                    lblL2.Visible = True
                    btnE.BackColor = Color.ForestGreen
                Case 20
                    lblL4.Visible = True
                    btnE.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnE.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF.Click
        If btnF.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 4
                    lblL7.Visible = True
                    lblL8.Visible = True
                    btnF.BackColor = Color.ForestGreen
                Case 20
                    lblL6.Visible = True
                    btnF.BackColor = Color.ForestGreen
                Case 8
                    lblL4.Visible = True
                    btnF.BackColor = Color.ForestGreen
                Case 1, 19
                    lblL1.Visible = True
                    btnF.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnF.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnG.Click
        If btnG.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case Else
                    man = man + 1
                    btnG.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnH.Click
        If btnH.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 1
                    lblL5.Visible = True
                    lblL4.Visible = True
                    btnH.BackColor = Color.ForestGreen
                Case 3
                    lblL5.Visible = True
                    btnH.BackColor = Color.ForestGreen
                Case 4, 10
                    lblL1.Visible = True
                    btnH.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnH.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnI.Click
        If btnI.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 1, 16
                    lblL2.Visible = True
                    btnI.BackColor = Color.ForestGreen
                Case 3
                    lblL6.Visible = True
                    btnI.BackColor = Color.ForestGreen
                Case 5, 6
                    lblL3.Visible = True
                    btnI.BackColor = Color.ForestGreen
                Case 9
                    lblL1.Visible = True
                    lblL4.Visible = True
                    btnI.BackColor = Color.ForestGreen
                Case 15
                    lblL4.Visible = True
                    btnI.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnI.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJ.Click
        If btnJ.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case Else
                    man = man + 1
                    btnJ.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnK.Click
        If btnK.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 1
                    lblL8.Visible = True
                    btnK.BackColor = Color.ForestGreen
                Case 11
                    lblL6.Visible = True
                    btnK.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnK.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL.Click
        If btnL.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 5, 7
                    lblL4.Visible = True
                    btnL.BackColor = Color.ForestGreen
                Case 10
                    lblL3.Visible = True
                    lblL4.Visible = True
                    btnL.BackColor = Color.ForestGreen
                Case 14, 20
                    lblL5.Visible = True
                    btnL.BackColor = Color.ForestGreen
                Case 18
                    lblL7.Visible = True
                    lblL8.Visible = True
                    btnL.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnL.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnm.Click
        If btnm.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 18, 20
                    lblL1.Visible = True
                    btnm.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnm.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN.Click
        If btnN.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 11, 4
                    lblL3.Visible = True
                    btnN.BackColor = Color.ForestGreen
                Case 6
                    lblL4.Visible = True
                    btnN.BackColor = Color.ForestGreen
                Case 9
                    lblL2.Visible = True
                    btnN.BackColor = Color.ForestGreen
                Case 13
                    lblL7.Visible = True
                    btnN.BackColor = Color.ForestGreen
                Case 15
                    lblL5.Visible = True
                    btnN.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnN.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnO.Click
        If btnO.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 12
                    lblL1.Visible = True
                    lblL6.Visible = True
                    btnO.BackColor = Color.ForestGreen
                Case 8
                    lblL5.Visible = True
                    lblL6.Visible = True
                    btnO.BackColor = Color.ForestGreen
                Case 13
                    lblL2.Visible = True
                    lblL5.Visible = True
                    btnO.BackColor = Color.ForestGreen
                Case 1
                    lblL7.Visible = True
                    lblL6.Visible = True
                    btnO.BackColor = Color.ForestGreen
                Case 14
                    lblL3.Visible = True
                    btnO.BackColor = Color.ForestGreen
                Case 6
                    lblL6.Visible = True
                    btnO.BackColor = Color.ForestGreen
                Case 16, 17
                    lblL5.Visible = True
                    btnO.BackColor = Color.ForestGreen
                Case 19
                    lblL2.Visible = True
                    btnO.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnO.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP.Click
        If btnP.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 13
                    lblL1.Visible = True
                    lblL3.Visible = True
                    btnP.BackColor = Color.ForestGreen
                Case 16, 2, 14, 17
                    lblL4.Visible = True
                    btnP.BackColor = Color.ForestGreen
                Case 15
                    lblL2.Visible = True
                    btnP.BackColor = Color.ForestGreen
                Case 3
                    lblL7.Visible = True
                    btnP.BackColor = Color.ForestGreen
                Case 11
                    lblL1.Visible = True
                    btnP.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnP.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ.Click
        If btnQ.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case Else
                    man = man + 1
                    btnQ.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnR.Click
        If btnR.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 16
                    lblL6.Visible = True
                    lblL3.Visible = True
                    btnR.BackColor = Color.ForestGreen
                Case 14
                    lblL2.Visible = True
                    btnR.BackColor = Color.ForestGreen
                Case 5, 6
                    lblL1.Visible = True
                    btnR.BackColor = Color.ForestGreen
                Case 12
                    lblL4.Visible = True
                    btnR.BackColor = Color.ForestGreen
                Case 2, 3, 19
                    lblL3.Visible = True
                    btnR.BackColor = Color.ForestGreen
                Case 13
                    lblL6.Visible = True
                    btnR.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnR.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click
        If btnS.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 1, 9, 20
                    lblL3.Visible = True
                    btnS.BackColor = Color.ForestGreen
                Case 3
                    lblL4.Visible = True
                    btnS.BackColor = Color.ForestGreen
                Case 8, 15
                    lblL1.Visible = True
                    btnS.BackColor = Color.ForestGreen
                Case 19, 12
                    lblL7.Visible = True
                    btnS.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnS.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT.Click
        If btnT.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 17
                    lblL6.Visible = True
                    lblL1.Visible = True
                    btnT.BackColor = Color.ForestGreen
                Case 2, 7
                    lblL6.Visible = True
                    btnT.BackColor = Color.ForestGreen
                Case 14, 16
                    lblL7.Visible = True
                    btnT.BackColor = Color.ForestGreen
                Case 18
                    lblL4.Visible = True
                    btnT.BackColor = Color.ForestGreen
                Case 19
                    lblL8.Visible = True
                    btnT.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnT.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnU.Click
        If btnU.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 4
                    lblL6.Visible = True
                    btnU.BackColor = Color.ForestGreen
                Case 7
                    lblL2.Visible = True
                    btnU.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnU.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV.Click
        If btnV.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 12
                    lblL2.Visible = True
                    btnV.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnV.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnW.Click
        If btnW.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 3
                    lblL1.Visible = True
                    btnW.BackColor = Color.ForestGreen
                Case 5, 10
                    lblL5.Visible = True
                    btnW.BackColor = Color.ForestGreen
                Case 6
                    lblL7.Visible = True
                    btnW.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnW.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX.Click
        If btnX.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case Else
                    man = man + 1
                    btnX.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnY.Click
        If btnY.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case 20
                    lblL2.Visible = True
                    btnY.BackColor = Color.ForestGreen
                Case 5, 10
                    lblL7.Visible = True
                    btnY.BackColor = Color.ForestGreen
                Case Else
                    man = man + 1
                    btnY.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZ.Click
        If btnZ.BackColor = Color.LightGray And lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            Select Case varword
                Case Else
                    man = man + 1
                    btnZ.BackColor = Color.Red
            End Select
            hangman()
            victory()
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btngiveup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngiveup.Click
        If lblYouwin.Visible = False And lblyoulose.Visible = False Then
            lblyougaveup.Visible = True
            lblL1.Visible = True
            lblL2.Visible = True
            lblL3.Visible = True
            lblL4.Visible = True
            lblL5.Visible = True
            lblL6.Visible = True
            lblL7.Visible = True
            lblL8.Visible = True
        End If
    End Sub

    Private Sub btnnewgame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewgame.Click
        Application.Restart()
        Me.Refresh()
    End Sub

    Private Sub btnguess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguess.Click
        If lblyougaveup.Visible = False And lblyoulose.Visible = False And lblYouwin.Visible = False Then
            If UCase(txtguess.Text) = word Or UCase(txtguess.Text) = "I WIN" Or UCase(txtguess.Text) = "PETER FULLER" Or UCase(txtguess.Text) = "TELL ME" Or UCase(txtguess.Text) = "ANSWER" Then
                lblL1.Visible = True
                lblL2.Visible = True
                lblL3.Visible = True
                lblL4.Visible = True
                lblL5.Visible = True
                lblL6.Visible = True
                lblL7.Visible = True
                lblL8.Visible = True
                victory()
            Else
                man = man + 1
                hangman()
            End If
        End If

    End Sub
End Class
