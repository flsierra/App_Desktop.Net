Public Class barra

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 4
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            MsgBox(" Bienvenido Empecemos")
            Me.Hide()
            Form1.Show()

        End If
    End Sub

    Private Sub barra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)


    End Sub
End Class