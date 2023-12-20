Public Class Ejercicio9

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, b, c, d As Integer
        p = A.Text
        b = (15 * p) / 100
        c = b * 4
        d = c * 12
        MsgBox(d)
        Me.Close()
    End Sub
End Class