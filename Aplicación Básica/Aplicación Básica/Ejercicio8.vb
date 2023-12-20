Public Class Ejercicio8

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, o, Y As Integer
        p = A.Text
        o = B.Text
        Y = o * p
        MsgBox(Y)
        Me.Close()
    End Sub
End Class