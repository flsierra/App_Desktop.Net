Public Class Ejercicio1Cic

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub T_TextChanged(sender As Object, e As EventArgs) Handles T.TextChanged

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim O, H, G, J, I, K, Cont As Double
        O = T.Text
        K = 0
        Cont = 0
        For H = 1 To O
            Cont = Cont + 1
            G = InputBox("Digite horas Trabajador" & Cont)
            J = InputBox("Digite precio hora")
            I = G * J
            K = K + I
        Next
        MsgBox("El total que paga la emresa or los trabajadores " & K)
    End Sub
End Class