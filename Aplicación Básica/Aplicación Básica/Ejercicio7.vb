Public Class Ejercicio7

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles A.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, o, Y As Integer
        p = A.Text
        o = B.Text
        Y = p / o
        MsgBox(Y)
        Me.Close()
    End Sub
End Class