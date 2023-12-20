Public Class Ejercicio15

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o, p, X As Integer
        o = A.Text
        p = B.Text
        X = o * p
        MsgBox(X)
        Me.Close()
    End Sub
End Class