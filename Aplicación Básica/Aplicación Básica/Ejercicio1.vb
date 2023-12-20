Public Class Ejercicio1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, o, R As Integer

        p = A.Text
        o = B.Text
        R = p + o
        MsgBox(R)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        A.Clear()
        B.Clear()
        Me.Close()
        Form1.Visible = True


    End Sub
End Class