Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim usuario As String
        Dim contraseña As Integer
        usuario = TextBox1.Text
        contraseña = TextBox2.Text
        If usuario = "admin" And contraseña = "123" Then

            menu2.Show()
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            MsgBox("Usuario o Contraseña Incorrecta, verifica")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("¿Desea salir de la aplicacion", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If

    End Sub
End Class
