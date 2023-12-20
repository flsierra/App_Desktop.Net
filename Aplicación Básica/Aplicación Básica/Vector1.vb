Public Class Vector1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, Cont, B As Integer
        Dim arreglo(9) As String
        Cont = 0
        For A = 1 To 10
            Cont = Cont + 1
            arreglo(9) = InputBox("Digite numero " & Cont)
            B = B + arreglo(9)
        Next
        MsgBox("la suma es " & B)
        Me.Close()
    End Sub
End Class