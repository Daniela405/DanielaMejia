Public Class SAR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim suel, deduccion, total As Double

        suel = Val(TextBox1.Text)

        If suel < 16582.62 Then
            MessageBox.Show("Su sueldo esta excento de deduccion ", "sueldo excento")
            deduccion = suel

            TextBox2.Text = deduccion
            TextBox3.Text = 0
            TextBox4.Text = deduccion
        Else



        End If


        If suel > 16582.62 And suel < 23536.661 Then
            MessageBox.Show("Su sueldo tiene un 15% de deduccion ", "sueldo con deduccion")
            deduccion = suel * 0.15
            total = suel - deduccion
            TextBox2.Text = suel
            TextBox3.Text = deduccion
            TextBox4.Text = total
        Else
        End If
        If suel > 23536.62 And suel < 50317.69 Then
            MessageBox.Show("Su sueldo tiene un 20% de deduccion ", "sueldo con deduccion")
            deduccion = suel * 0.2
            total = suel - deduccion
            TextBox2.Text = suel
            TextBox3.Text = deduccion
            TextBox4.Text = total
        Else
        End If

        If suel > 50317.7 Then
            MessageBox.Show("Su sueldo tiene un 25% de deduccion ", "sueldo con deduccion")
            deduccion = suel * 0.25
            total = suel - deduccion
            TextBox2.Text = suel
            TextBox3.Text = deduccion
            TextBox4.Text = total
        Else
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Desea salir de la aplicacion", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub
End Class