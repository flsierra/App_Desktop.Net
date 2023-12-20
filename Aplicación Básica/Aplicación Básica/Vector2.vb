Public Class Vector2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, Cont, B, M As Integer
        Dim arreglo(D.Text), arreglo1(D.Text) As String
        Cont = 0
        B = D.Text
        For A = 1 To B
            Cont = Cont + 1
            arreglo(B) = InputBox("Digite numerso A" & Cont)
            arreglo1(B) = InputBox("Digite numeros B" & Cont)
            M = M + arreglo(B) + arreglo1(B)
            MsgBox("la suma de los numeros es " & M)
            M = 0
            Me.Close()
        Next
    End Sub

    Private Sub Vector2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class