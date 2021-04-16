Option strict on 
Public Class Form1
    Dim hours As Integer
    Dim money As Double
    Dim days As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        money = 0
        hours = 0
        days = 0
        hours = (Integer.Parse(TextBox1.Text))
        If RadioButton1.Checked = True Then
            If CheckBox1.Checked = False Then
                days = hours \ 24
                hours = hours Mod 24
                money = days * 14
                Select Case hours
                    Case 13 To 23
                        hours = 13
                    Case 0
                        hours = -1
                End Select
                money = money + hours + 1
            End If
            If CheckBox1.Checked = True Then
                days = hours \ 24
                hours = hours Mod 24
                Select Case hours
                    Case 13 To 23
                        hours = 13
                    Case 0
                        hours = -1
                    Case Else
                        hours = hours
                End Select
                Select Case days
                    Case 1
                        days = 0
                    Case 0
                        days = 0
                    Case Else
                        days = days - 1
                End Select
                Select Case days
                    Case 0
                        money = 10
                    Case Else
                        money = days * 14 + hours + 11
                End Select
            End If
        End If
        If RadioButton2.Checked = True Then
            If CheckBox1.Checked = False Then
                days = hours \ 24
                hours = hours Mod 24
                money = days * 20.5
                Select Case hours
                    Case 13 To 23
                        hours = 13
                    Case 0
                        hours = -1
                End Select
                money = money + (hours * 1.5) + 1
            End If
            If CheckBox1.Checked = True Then
                days = hours \ 24
                hours = hours Mod 24
                Select Case hours
                    Case 13 To 23
                        hours = 13
                    Case 0
                        hours = -1
                    Case Else
                        hours = hours
                End Select
                Select Case days
                    Case 1
                        days = 0
                    Case 0
                        days = 0
                    Case Else
                        days = days - 1
                End Select
                Select Case days
                    Case 0
                        money = 13
                    Case Else
                        money = days * 20.5 + hours + 14
                End Select
            End If
        End If
        If RadioButton3.Checked = True Then
            If CheckBox1.Checked = False Then
                days = hours \ 24
                hours = hours Mod 24
                money = days * 20
                Select Case hours
                    Case 13 To 23
                        hours = 13
                    Case 0
                        hours = -1
                End Select
                money = money + (hours * 2) + 1
            End If
            If CheckBox1.Checked = True Then
                days = hours \ 24
                hours = hours Mod 24
                Select Case hours
                    Case 13 To 23
                        hours = 13
                    Case 0
                        hours = -1
                    Case Else
                        hours = hours
                End Select
                Select Case days
                    Case 1
                        days = 0
                    Case 0
                        days = 0
                    Case Else
                        days = days - 1
                End Select
                Select Case days
                    Case 0
                        money = 16
                    Case Else
                        money = days * 27 + hours + 17
                End Select
            End If
        End If
        Label4.Text = money.ToString("C")
        TextBox1.Text = "Have a Nice Day"
    End Sub
End Class
