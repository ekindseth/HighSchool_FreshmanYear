Option Strict On
Public Class Form1
    Dim total As Double
    Dim tax As Double = 0.0635
    Const smr As Double = 0.75
    Const sms As Double = 1
    Const mr As Double = 1
    Const ms As Double = 1.25
    Const lr As Double = 1.75
    Const ls As Double = 2.25
    Const xlr As Double = 2
    Const xls As Double = 2.5
    Const small As Double = 6.5
    Const medium As Double = 8.5
    Const large As Double = 11.5
    Const xlarge As Double = 14.5
    Dim taxs As Double
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        total = 0
        lblSubTotal.Text = ""
        lbltax.Text = ""
        lbltotal.Text = ""
        RadioButton1.Checked = True
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        CheckBox20.Checked = False
        CheckBox21.Checked = False
        CheckBox22.Checked = False
        CheckBox23.Checked = False
        CheckBox24.Checked = False
        CheckBox25.Checked = False
    End Sub
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        total = 0
        If RadioButton1.Checked = True Then
            total = total + small
            If CheckBox1.Checked = True Then
                total = total + smr
            End If
            If CheckBox2.Checked = True Then
                total = total + smr
            End If
            If CheckBox3.Checked = True Then
                total = total + smr
            End If
            If CheckBox4.Checked = True Then
                total = total + smr
            End If
            If CheckBox5.Checked = True Then
                total = total + smr
            End If
            If CheckBox6.Checked = True Then
                total = total + smr
            End If
            If CheckBox7.Checked = True Then
                total = total + smr
            End If
            If CheckBox8.Checked = True Then
                total = total + smr
            End If
            If CheckBox9.Checked = True Then
                total = total + smr
            End If
            If CheckBox10.Checked = True Then
                total = total + smr
            End If
            If CheckBox11.Checked = True Then
                total = total + smr
            End If
            If CheckBox12.Checked = True Then
                total = total + smr
            End If
            If CheckBox13.Checked = True Then
                total = total + smr
            End If
            If CheckBox14.Checked = True Then
                total = total + smr
            End If
            If CheckBox15.Checked = True Then
                total = total + smr
            End If
            If CheckBox16.Checked = True Then
                total = total + sms
            End If
            If CheckBox17.Checked = True Then
                total = total + sms
            End If
            If CheckBox18.Checked = True Then
                total = total + sms
            End If
            If CheckBox19.Checked = True Then
                total = total + sms
            End If
            If CheckBox20.Checked = True Then
                total = total + sms
            End If
            If CheckBox21.Checked = True Then
                total = total + sms
            End If
            If CheckBox22.Checked = True Then
                total = total + sms
            End If
            If CheckBox23.Checked = True Then
                total = total + sms
            End If
            If CheckBox24.Checked = True Then
                total = total + sms
            End If
            If CheckBox25.Checked = True Then
                total = total + sms
            End If
        End If
        If RadioButton2.Checked = True Then
            total = total + medium
            If CheckBox1.Checked = True Then
                total = total + mr
            End If
            If CheckBox2.Checked = True Then
                total = total + mr
            End If
            If CheckBox3.Checked = True Then
                total = total + mr
            End If
            If CheckBox4.Checked = True Then
                total = total + mr
            End If
            If CheckBox5.Checked = True Then
                total = total + mr
            End If
            If CheckBox6.Checked = True Then
                total = total + mr
            End If
            If CheckBox7.Checked = True Then
                total = total + mr
            End If
            If CheckBox8.Checked = True Then
                total = total + mr
            End If
            If CheckBox9.Checked = True Then
                total = total + mr
            End If
            If CheckBox10.Checked = True Then
                total = total + mr
            End If
            If CheckBox11.Checked = True Then
                total = total + mr
            End If
            If CheckBox12.Checked = True Then
                total = total + mr
            End If
            If CheckBox13.Checked = True Then
                total = total + mr
            End If
            If CheckBox14.Checked = True Then
                total = total + mr
            End If
            If CheckBox15.Checked = True Then
                total = total + mr
            End If
            If CheckBox16.Checked = True Then
                total = total + ms
            End If
            If CheckBox17.Checked = True Then
                total = total + ms
            End If
            If CheckBox18.Checked = True Then
                total = total + ms
            End If
            If CheckBox19.Checked = True Then
                total = total + ms
            End If
            If CheckBox20.Checked = True Then
                total = total + ms
            End If
            If CheckBox21.Checked = True Then
                total = total + ms
            End If
            If CheckBox22.Checked = True Then
                total = total + ms
            End If
            If CheckBox23.Checked = True Then
                total = total + ms
            End If
            If CheckBox24.Checked = True Then
                total = total + ms
            End If
            If CheckBox25.Checked = True Then
                total = total + ms
            End If
        End If
        If RadioButton3.Checked = True Then
            total = total + large
            If CheckBox1.Checked = True Then
                total = total + lr
            End If
            If CheckBox2.Checked = True Then
                total = total + lr
            End If
            If CheckBox3.Checked = True Then
                total = total + lr
            End If
            If CheckBox4.Checked = True Then
                total = total + lr
            End If
            If CheckBox5.Checked = True Then
                total = total + lr
            End If
            If CheckBox6.Checked = True Then
                total = total + lr
            End If
            If CheckBox7.Checked = True Then
                total = total + lr
            End If
            If CheckBox8.Checked = True Then
                total = total + lr
            End If
            If CheckBox9.Checked = True Then
                total = total + lr
            End If
            If CheckBox10.Checked = True Then
                total = total + lr
            End If
            If CheckBox11.Checked = True Then
                total = total + lr
            End If
            If CheckBox12.Checked = True Then
                total = total + lr
            End If
            If CheckBox13.Checked = True Then
                total = total + lr
            End If
            If CheckBox14.Checked = True Then
                total = total + lr
            End If
            If CheckBox15.Checked = True Then
                total = total + lr
            End If
            If CheckBox16.Checked = True Then
                total = total + ls
            End If
            If CheckBox17.Checked = True Then
                total = total + ls
            End If
            If CheckBox18.Checked = True Then
                total = total + ls
            End If
            If CheckBox19.Checked = True Then
                total = total + ls
            End If
            If CheckBox20.Checked = True Then
                total = total + ls
            End If
            If CheckBox21.Checked = True Then
                total = total + ls
            End If
            If CheckBox22.Checked = True Then
                total = total + ls
            End If
            If CheckBox23.Checked = True Then
                total = total + ls
            End If
            If CheckBox24.Checked = True Then
                total = total + ls
            End If
            If CheckBox25.Checked = True Then
                total = total + ls
            End If
        End If
        If RadioButton4.Checked = True Then
            total = total + xlarge
            If CheckBox1.Checked = True Then
                total = total + xlr
            End If
            If CheckBox2.Checked = True Then
                total = total + xlr
            End If
            If CheckBox3.Checked = True Then
                total = total + xlr
            End If
            If CheckBox4.Checked = True Then
                total = total + xlr
            End If
            If CheckBox5.Checked = True Then
                total = total + xlr
            End If
            If CheckBox6.Checked = True Then
                total = total + xlr
            End If
            If CheckBox7.Checked = True Then
                total = total + xlr
            End If
            If CheckBox8.Checked = True Then
                total = total + xlr
            End If
            If CheckBox9.Checked = True Then
                total = total + xlr
            End If
            If CheckBox10.Checked = True Then
                total = total + xlr
            End If
            If CheckBox11.Checked = True Then
                total = total + xlr
            End If
            If CheckBox12.Checked = True Then
                total = total + xlr
            End If
            If CheckBox13.Checked = True Then
                total = total + xlr
            End If
            If CheckBox14.Checked = True Then
                total = total + xlr
            End If
            If CheckBox15.Checked = True Then
                total = total + xlr
            End If
            If CheckBox16.Checked = True Then
                total = total + xls
            End If
            If CheckBox17.Checked = True Then
                total = total + xls
            End If
            If CheckBox18.Checked = True Then
                total = total + xls
            End If
            If CheckBox19.Checked = True Then
                total = total + xls
            End If
            If CheckBox20.Checked = True Then
                total = total + xls
            End If
            If CheckBox21.Checked = True Then
                total = total + xls
            End If
            If CheckBox22.Checked = True Then
                total = total + xls
            End If
            If CheckBox23.Checked = True Then
                total = total + xls
            End If
            If CheckBox24.Checked = True Then
                total = total + xls
            End If
            If CheckBox25.Checked = True Then
                total = total + xls
            End If
        End If
        taxs = 0
        lblSubTotal.Text = total.ToString("C")
        taxs = total * tax
        lbltax.Text = taxs.ToString("C")
        total = total + taxs
        lbltotal.Text = total.ToString("C")
    End Sub
End Class
