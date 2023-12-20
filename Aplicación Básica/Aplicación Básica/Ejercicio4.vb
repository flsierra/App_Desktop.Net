Public Class EJERCICIO4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, Y As Integer
        p = A.Text
        Y = p * p * 100
        MsgBox(Y)
        Me.Close()
    End Sub
End Class