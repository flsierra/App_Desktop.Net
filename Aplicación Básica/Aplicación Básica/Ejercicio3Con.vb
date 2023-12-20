Public Class Ejercicio3Con

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A.Clear()
        B.Clear()
        Me.Close()
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim O, P As Integer
        O = A.Text
        P = B.Text
        If O > 18 Then
            If P >= 90 Then
                MsgBox("Su beca es de $2000000")
            Else
                If P < 90 Or P > 75 Then
                    MsgBox("Su beca es de $1000000")
                Else
                    If P > 60 Or P < 75 Then
                        MsgBox("Su beca es de $500000")
                    Else
                        If P < 60 Then
                            MsgBox("Estidantes los invitamos a mejorar")

                        End If
                    End If
                End If
            End If
        Else
            If O <= 18 Then
                If P >= 90 Then
                    MsgBox("Su beca es de $300000")
                Else
                    If P < 90 Or P > 80 Then
                        MsgBox("Su beca es de $200000")
                    Else
                        If P < 80 Or P > 60 Then
                            MsgBox("Su beca es de 100000")
                        Else
                            If P < 60 Then
                                MsgBox("Estidantes los invitamos a mejorar")
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class