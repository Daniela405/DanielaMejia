
Public Class Form1
        Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        End Sub

        Private Sub cbSuma_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbSuma.CheckedChanged
            Dim suma As Integer
            suma = Val(txtValor1.Text) + Val(txtValor2.Text)

            cbDivision.Checked = False
            cbResta.Checked = False
            cbMultiplicacion.Checked = False
            cbRaiz.Checked = False
            cbPotencia.Checked = False

            txtResultado.Text = suma
        End Sub

        Private Sub cbResta_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbResta.CheckedChanged
            Dim resta As Integer
            resta = Val(txtValor1.Text) - Val(txtValor2.Text)
            cbDivision.Checked = False
            cbSuma.Checked = False
            cbMultiplicacion.Checked = False
            cbRaiz.Checked = False
            cbPotencia.Checked = False

            txtResultado.Text = resta
        End Sub

        Private Sub cbMultiplicacion_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbMultiplicacion.CheckedChanged
            Dim multiplicacion As Integer


            multiplicacion = txtValor1.Text * txtValor2.Text

            cbDivision.Checked = False
            cbResta.Checked = False
            cbSuma.Checked = False
            cbRaiz.Checked = False
            cbPotencia.Checked = False

            txtResultado.Text = multiplicacion
        End Sub

        Private Sub cbDivision_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbDivision.CheckedChanged
            Dim division As Double
            division = txtValor1.Text / txtValor2.Text

            cbSuma.Checked = False
            cbResta.Checked = False
            cbMultiplicacion.Checked = False
            cbRaiz.Checked = False
            cbPotencia.Checked = False

            txtResultado.Text = division
        End Sub

        Private Sub cbPotencia_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbPotencia.CheckedChanged
            Dim potencia As Integer
            potencia = txtValor1.Text ^ txtValor2.Text

            cbDivision.Checked = False
            cbResta.Checked = False
            cbMultiplicacion.Checked = False
            cbRaiz.Checked = False
            cbSuma.Checked = False

            txtResultado.Text = potencia
        End Sub

        Private Sub cbRaiz_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbRaiz.CheckedChanged
            Dim raiz As Integer
            If txtValor1.Text > 0 Then
                raiz = txtValor1.Text ^ (1 / 2)
                txtResultado.Text = raiz
            Else
                MsgBox("La raiz no tiene valor")
            End If

            cbDivision.Checked = False
            cbResta.Checked = False
            cbMultiplicacion.Checked = False
            cbSuma.Checked = False
            cbPotencia.Checked = False
        End Sub

        Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
            End
        End Sub

        Private Sub btnLimpiar_Click_1(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            txtValor1.Clear()
            txtValor2.Clear()
            txtResultado.Clear()
        End Sub

        Private Sub btnValidar_Click_1(sender As Object, e As EventArgs) Handles btnValidar.Click
            If (txtValor1.Text = "") Or (txtValor2.Text = "") Then
                MsgBox("Escriba un numero en la casilla", vbInformation)

            ElseIf Not IsNumeric(txtValor1.Text) Or Not IsNumeric(txtValor2.Text) Then

                MsgBox("Ingrese un valor numerico", vbInformation)


            End If
        End Sub
    End Class
