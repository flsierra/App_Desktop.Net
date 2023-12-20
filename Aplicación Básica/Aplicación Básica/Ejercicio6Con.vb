Public Class Ejercicio6Con

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim O As Integer
        O = A.Text
        If O >= 50000 Then
            MsgBox("Puede comprar el paquete A: " &
    "Se comprará un televisor, un modular, tres pares de zapatos, cinco camisas y cinco pantalones.")
        ElseIf O < 50000 And O >= 20000 Then
            MsgBox("Puede comprar paquete B: " &
    "Se comprará una grabadora, tres pares de zapatos, cinco camisas y cinco pantalones.")
        ElseIf O < 20000 And O >= 10000 Then
            MsgBox("Puede comprar el paquete C: " &
    "Se comprará dos pares de zapatos, tres camisas y tres pantalones.")
        ElseIf O < 10000 Then
            MsgBox("Puede comprar el paquete C : " &
    "Solo podra comprar un par de zapatos, dos pantalones y dos camisas. ")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        A.Clear()
        Me.Close()

    End Sub
End Class