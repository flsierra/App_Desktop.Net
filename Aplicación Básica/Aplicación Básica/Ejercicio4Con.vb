Public Class Ejercicio4Con

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim O, P, W, X, Y, Q, K, J As Integer
        O = A.Text
        P = B.Text
        If O > 2 And O < 5 Then
            W = 20 * P / 100
            MsgBox("Su bono es de " & W)
        ElseIf O > 5 Then
            X = 30 * P / 100
            MsgBox("Su bono es de " & X)
        ElseIf O <= 2 Then
            J = 0
            MsgBox("Subo es de cero " & J)
        End If
        If P < 100000 Then
            Y = 25 * P / 100
            MsgBox("Su bono es de " & Y)
        ElseIf P > 100000 Or P < 350000 Then
            Q = 15 * P / 100
            MsgBox("Su bono es de " & Q)
        ElseIf P > 350000 Then
            K = 10 * P / 100
            MsgBox("Su bono es de " & K)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        A.Clear()
        B.Clear()
        Me.Close()
    End Sub
End Class