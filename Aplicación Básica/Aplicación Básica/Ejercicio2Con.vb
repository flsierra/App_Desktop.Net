Public Class Ejercicio2Con

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, w As Integer
        p = X.Text
        w = S.Text
        If p >= 70 Then
            MsgBox("Tipo de vacuna es C")
        ElseIf p <= 16 Then
            MsgBox("Tipo de vacuna es A ")
        ElseIf p >= 16 Or p <= 69 Then
            If w = 1 Then
                MsgBox("Tipo de vacuna A")
            Else
                MsgBox("Tipo de vacuna B")


            End If
            Button2.Visible = True




        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        X.Clear()
        S.Clear()
        Me.Close()
    End Sub
End Class