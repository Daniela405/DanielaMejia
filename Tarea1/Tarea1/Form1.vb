Public Class Form1

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim Suma As Integer
        Dim Resta As Integer
        Dim Multiplicar As Integer
        Dim Dividir As Double

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        Suma = valor1 + valor2
        Resta = valor1 - valor2
        Multiplicar = valor1 * valor2
        Dividir = valor1 / valor2


        txtSuma.Text = Suma
        txtResta.Text = Resta
        txtMultiplicacion.Text = Multiplicar
        txtdivision.Text = Dividir

        If valor2 = 0 Then
            MsgBox("No se puede dividir entre 0")
        ElseIf valor2 <> 0 Then
            txtdivision.Text = Dividir
        End If


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor1.Clear()
        txtValor2.Clear()
        txtdivision.Clear()
        txtMultiplicacion.Clear()
        txtResta.Clear()
        txtSuma.Clear()



    End Sub
End Class

