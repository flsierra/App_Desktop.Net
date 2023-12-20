Public Class Ejercicio1Con

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        A.Clear()
        B.Clear()
        C.Clear()
        D.Clear()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim U, I, O, P, R, U1, I1, O1, P1 As Integer
        U = A.Text
        I = B.Text
        O = C.Text
        P = D.Text
        If U = 1 Then
            U1 = 950 * 10 / 100
        Else
            U1 = 0
        End If
        If I = 1 Then
            I1 = 950 * 5 / 100
        Else
            I1 = 0
        End If
        If O = 1 Then
            O1 = 950 * 5 / 100
        Else
            O1 = 0
        End If
        If P = 1 Then
            P1 = 950 * 20 / 100
        Else
            P1 = 950 * 10 / 100
        End If
        R = U1 + I1 + O1 + P1 + 950
        MsgBox(R)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim U, I, O, P, R, U1, I1, O1, P1 As Integer
        U = A.Text
        I = B.Text
        O = C.Text
        P = D.Text
        If U = 1 Then
            U1 = 1200 * 10 / 100
        Else
            U1 = 0
        End If
        If I = 1 Then
            I1 = 1200 * 5 / 100
        Else
            I1 = 0
        End If
        If O = 1 Then
            O1 = 1200 * 5 / 100
        Else
            O1 = 0
        End If
        If P = 1 Then
            P1 = 1200 * 20 / 100
        Else
            P1 = 1200 * 10 / 100
        End If
        R = U1 + I1 + O1 + P1 + 1200
        MsgBox(R)


    End Sub
End Class