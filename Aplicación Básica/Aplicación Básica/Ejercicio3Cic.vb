Public Class Ejercicio3Cic

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B, V As Integer
        V = 10
        A = 0
        For B = 1 To 20
            MsgBox("Este mes debe pagar " & V)
            V = V * 2
            A = V + A
        Next
        MsgBox("Usted paga un tottal de " & A)
    End Sub
End Class