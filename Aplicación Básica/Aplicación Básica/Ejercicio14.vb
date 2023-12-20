Public Class Ejercicio14

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o, Y As Integer
        o = A.Text
        Y = (1 * o * 100)
        MsgBox(Y)
        Me.Close()
    End Sub
End Class