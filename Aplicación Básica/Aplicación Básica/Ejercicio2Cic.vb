Public Class Ejercicio2Cic

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim O, H, Cont, J, K, Cont1, G, Cont2, F, D, A As Integer
        O = C.Text
        Cont = 0
        Cont1 = 0
        Cont2 = 0
        For H = 1 To O
            Cont = Cont + 1
            J = InputBox("Digite Cantidad de tiendas en ciudad " & Cont)
            For D = 1 To J
                Cont1 = Cont1 + 1
                K = InputBox("Digite Cantidad de trabajadores en Tienda " & Cont1)
                For A = 1 To K
                    Cont2 = Cont2 + 1
                    G = InputBox("Digite recaudo en trabajador " & Cont2)
                    F = F + G
                Next
            Next
        Next
        MsgBox("El total recaudado es de " & F)
    End Sub
End Class