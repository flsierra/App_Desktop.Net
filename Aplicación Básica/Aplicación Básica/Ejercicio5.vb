Public Class Ejercicio5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, o, Y, X As Integer
        p = A.Text
        o = B.Text
        Y = (p * p) + (o * o)
        X = Y ^ 0.5
        MsgBox(X)
        Me.Close()
    End Sub
End Class