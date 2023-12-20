Public Class Ejercicio12

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles C.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles B.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, o, l, d, f, Y As Integer
        p = A.Text
        o = B.Text
        l = C.Text
        d = (p + o) / 2
        f = l
        Y = (d + f) / 2
        MsgBox(Y)
        Me.Close()
    End Sub
End Class