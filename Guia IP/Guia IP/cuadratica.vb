Public Class cuadratica
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Desea salir de la aplicacion", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, resul As Double

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)

        resul = (((-1) * b) + ((((b) ^ (2)) - (4 * a * c)) ^ (1 / 2))) / (2 * a)
        TextBox4.Text = resul

        resul = (((-1) * b) - ((((b) ^ (2)) - (4 * a * c)) ^ (1 / 2))) / (2 * a)
        TextBox5.Text = resul



    End Sub
End Class