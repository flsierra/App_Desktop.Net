Public Class Ejercicio3

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles A.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, v, b, Y As Integer
        p = A.Text
        v = 19.9
        b = 1
        Y = (p * b) / v

        MsgBox(Y)
        Me.Close()
    End Sub
End Class