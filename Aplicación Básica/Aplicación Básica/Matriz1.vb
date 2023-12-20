Public Class Matriz2
    Public Matriz1(3, 3) As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j As Integer
        For i = 0 To 3
            For j = 0 To 3
                Matriz1(i, j) = InputBox("Digite numeros")
            Next
        Next
        For i = 0 To 3
            For j = 0 To 3
                TextBox1.Text = TextBox1.Text + CStr(Matriz1(i, j)) + " "
            Next
            TextBox1.Text = TextBox1.Text + vbCrLf
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i, j, Cont1 As Integer
        Cont1 = 0
        For i = 0 To 3
            For j = 0 To 3
                If Matriz1(i, j) = 0 Then
                    Cont1 = Cont1 + 1
                End If
            Next
        Next
        TextBox2.Text = Cont1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()


    End Sub
End Class