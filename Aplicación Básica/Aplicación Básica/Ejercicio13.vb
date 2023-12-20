Public Class Ejercicio13

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Edad As Integer
        Edad = DateDiff(DateInterval.Year, FechaNacimiento.Value, FechaActual.Value)
        LblCumpleaños.Text = "Estimado usuario su edad y la fecha: " & FechaActual.Text & vbCrLf & " Es de " & Edad.ToString
        Button2.Visible = True
        Button1.Visible = False


    End Sub

    Private Sub Ejercicio13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class