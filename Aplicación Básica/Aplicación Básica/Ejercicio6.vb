﻿Public Class Ejercicio6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, o, Y As Integer
        p = A.Text
        o = B.Text
        Y = p * o
        MsgBox(Y)
        Me.Close()
    End Sub
End Class