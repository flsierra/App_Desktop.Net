Public Class Vector3

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arreglo(5) As String
        arreglo(0) = InputBox("Digite los numero")
        arreglo(1) = InputBox("Digite los numero")
        arreglo(2) = InputBox("Digite los numero")
        arreglo(3) = InputBox("Digite los numero")
        arreglo(4) = InputBox("Digite los numero")
        arreglo(5) = InputBox("Digite los numero")
        MsgBox(arreglo(5))
        MsgBox(arreglo(4))
        MsgBox(arreglo(3))
        MsgBox(arreglo(2))
        MsgBox(arreglo(1))
        MsgBox(arreglo(0))
        Me.Close()
    End Sub
End Class