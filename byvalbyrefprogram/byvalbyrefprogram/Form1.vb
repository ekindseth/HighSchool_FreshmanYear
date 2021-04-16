Public Class Form1
    Private Sub power(ByVal num As Integer)
        Debug.WriteLine("in Power num starts at " & num.ToString)
        num = num ^ 2
        Debug.WriteLine("After num = num ^ 2 num = " & num.ToString)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer = 5
        Debug.WriteLine("before calling power x= " & x.ToString)
        power(x)
        Debug.WriteLine("After calling power x = " & x.ToString)
    End Sub
End Class
