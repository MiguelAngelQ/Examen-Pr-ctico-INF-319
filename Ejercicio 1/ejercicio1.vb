Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim num1 As Single = Single.Parse(TextBox1.Text)
        Dim num2 As Single = Single.Parse(TextBox2.Text)
        Dim num3 As Single = Single.Parse(TextBox3.Text)

        If num1 <= num2 And num2 <= num3 Then
            GoTo Resultado
        End If

        If num1 > num2 Then
            Dim temp As Single = num1
            num1 = num2
            num2 = temp
        End If

        If num1 <= num2 And num2 <= num3 Then GoTo Resultado
        If num1 > num3 Then
            Dim temp As Single = num1
            num1 = num3
            num3 = temp
        End If
        If num1 <= num2 And num2 <= num3 Then GoTo Resultado
        If num2 > num3 Then
            Dim temp As Single = num2
            num2 = num3
            num3 = temp
        End If
        GoTo Resultado

Resultado:
        TextBox1.Text = num1.ToString
        TextBox2.Text = num2.ToString
        TextBox3.Text = num3.ToString

    End Sub

End Class
