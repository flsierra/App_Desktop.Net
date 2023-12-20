Public Class Ejercicio11

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, Y As Integer
        p = I.Text
        Y = (4 * p * p)
        MsgBox(Y)
        Me.Close()
    End Sub
End Class