Public Class Ejercicio4Cic

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim B, M, G, K, Cont, Cont1, Cont2, Cont3 As Integer
        B = A.Text
        K = 0
        Cont = 0
        Cont1 = 0
        Cont2 = 0
        Cont3 = 0
        For M = 1 To B

            Cont = Cont + 1
            G = InputBox("Digite recaudado " & Cont)
            If G > 1000 And K Then
                Cont1 = Cont1 + 1
            ElseIf G > 500 And G <= 1000 Then
                Cont2 = Cont2 + 1
            ElseIf G >= 1 And G <= 500 Then
                Cont3 = Cont3 + 1
            End If
            K = K + G
        Next
        MsgBox("El total de las ventas es " & K & " Recaudos mayores a 1000 son " & Cont1 &
               " Recaudos mayores a 500 pero menores o iguales a 1000 son " & Cont2 &
               " Recaudos menores a 500 son " & Cont3)
        Me.Close()
    End Sub
End Class