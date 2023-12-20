Public Class Ejercicio5Con

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim P, O, Y, SA, J, G, K As Double
        P = A.Text
        O = B.Text
        Y = C.Text
        SA = P + O - Y
        J = SA * 15 / 100
        G = InputBox("Digite 1 si pago el saldo minimo si no digite 0")
        If G = 0 Then
            K = (SA * 97) / 100 + 200
        Else
            K = SA * 85 / 100
        End If
        MsgBox("El saldo actual es " & SA & ", el pago minimo es " & J & ", el saldo sin interese es " & K)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        A.Clear()
        B.Clear()
        C.Clear()
        Me.Close()

    End Sub
End Class