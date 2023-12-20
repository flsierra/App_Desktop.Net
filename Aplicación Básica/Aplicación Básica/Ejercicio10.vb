Public Class Ejercicio10

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, o, l, x, Y As Integer
        p = A.Text
        o = B.Text
        l = C.Text
        x = 100000
        Y = ((p * x) + o + l)
        MsgBox(Y)
        Me.Close()
    End Sub
End Class