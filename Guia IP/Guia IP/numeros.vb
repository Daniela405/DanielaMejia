Public Class numeros
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pares, impares1, positivos, negativos, suma, n As Integer
        Dim numer As Int64
        numer = Val(txtcantidad.Text)



        For i = 1 To numer Step 1
            numer = InputBox("Ingrese la cantidad de digitos", " Ingresar")
            ComboBox1.Items.Add(numer)

            If numer = Int(numer / 2) * 2 Then
                pares = pares + 1
            Else
                impares1 = impares1 + 1
            End If

            If numer < 0 Then
                negativos = negativos + 1
            Else
                positivos = positivos + 1
            End If
            suma = suma + numer
        Next

        n = Val(txtcantidad.Text)
        txtimpares.Text = impares1
        txtpares.Text = pares
        txtnegativos.Text = negativos
        txtpositivos.Text = positivos
        txtsuma.Text = suma
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtsuma.Clear()
        txtpositivos.Clear()
        txtpares.Clear()
        txtnegativos.Clear()
        txtimpares.Clear()
        txtcantidad.Clear()
        ComboBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Desea salir de la aplicacion", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub
End Class