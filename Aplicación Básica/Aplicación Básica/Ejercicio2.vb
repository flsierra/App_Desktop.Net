Public Class Ejercicio2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, o, r, x, Y As Integer
        p = A.Text
        o = B.Text
        r = C.Text
        x = D.Text
        Y = (p - o) / (r - x)
        MsgBox(Y)
        Me.Close()
    End Sub
End Class