Public Class Matriz3
    Public Matriz1(11, 11) As Integer
    Public Matriz2(11, 11) As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j As Integer
        For i = 0 To 11
            For j = 0 To 11
                Matriz1(i, j) = InputBox("Digite numeros")
            Next
        Next
        For i = 0 To 11
            For j = 0 To 11
                TextBox1.Text = TextBox1.Text + CStr(Matriz1(i, j)) + " "
            Next
            TextBox1.Text = TextBox1.Text + vbCrLf
        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i, j As Integer
        For i = 0 To 11
            For j = 0 To 11
                Matriz2(i, j) = InputBox("Digite numeros")
            Next
        Next
        For i = 0 To 11
            For j = 0 To 11
                TextBox2.Text = TextBox2.Text + CStr(Matriz2(i, j)) + " "
            Next
            TextBox2.Text = TextBox2.Text + vbCrLf
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i, j, Acum As Integer
        Acum = 0
        For i = 0 To 11
            For j = 0 To 11
                If i = j Then
                    If Matriz1(i, j) = Matriz2(i, j) Then
                        Acum = Acum + 1
                        If Acum = 1 Then
                            MsgBox("Las diagonales son iguales")
                            Me.Close()


                        Else
                            MsgBox("Las diagonales no son iguales")
                            Me.Close()

                        End If
                        Acum = 0
                    End If
                End If
            Next
        Next
    End Sub

    
End Class