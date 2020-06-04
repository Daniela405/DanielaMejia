
Imports System.ComponentModel

Public Class boletos
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        menu2.Show()

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            Dim cantidad, precio, subtotal, descuento, isv, total As Double


            cantidad = Convert.ToDouble(txtCantidad.Text)
            precio = Convert.ToDouble(txtPrecio.Text)
            subtotal = subtotal + precio * cantidad
            txtSub.Text = Convert.ToString(FormatNumber(subtotal, 2))


            If cantidad > 3 And cantidad <= 7 Then
                descuento = subtotal * 0.08
            Else
                If cantidad > 7 Then
                    descuento = subtotal * 0.1
                End If
            End If

            txtDescuento.Text = Convert.ToString(FormatNumber(descuento, 2))
            isv = subtotal * 0.15
            txtImporte.Text = Convert.ToString(FormatNumber(isv, 2))

            If RadioButton1.Checked = True Then
                subtotal += 30
            End If
            If RadioButton2.Checked = True Then
                subtotal += 23
            End If
            If RadioButton3.Checked = True Then
                subtotal += 15
            End If


            If CheckBox1.Checked = True Then
                total += 40
            End If
            If CheckBox2.Checked = True Then
                total += 30
            End If
            If CheckBox3.Checked = True Then
                total += 20
            End If
            total = total + subtotal + isv - descuento
            txtTotal.Text = Convert.ToString(FormatNumber(total, 2))
            DataGridView1.Rows.Add(cmbPelicula.Text, txtPrecio.Text, txtDuracion.Text, txtCantidad.Text, txtSub.Text, txtDescuento.Text, txtImporte.Text, txtTotal.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbPelicula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPelicula.SelectedIndexChanged
        Dim precio, duracion As Integer
        Select Case cmbPelicula.SelectedIndex
            Case 0
                precio = 100
                txtPrecio.Text = Convert.ToString(FormatNumber(precio, 2))
                duracion = 60
                txtDuracion.Text = Convert.ToString(duracion)

            Case 1
                precio = 120
                txtPrecio.Text = Convert.ToString(FormatNumber(precio, 2))
                duracion = 85
                txtDuracion.Text = Convert.ToString(duracion)

            Case 2
                precio = 115
                txtPrecio.Text = Convert.ToString(FormatNumber(precio, 2))
                duracion = 70
                txtDuracion.Text = Convert.ToString(duracion)

            Case 3
                precio = 90
                txtPrecio.Text = Convert.ToString(FormatNumber(precio, 2))
                duracion = 60
                txtDuracion.Text = Convert.ToString(duracion)

            Case 4
                precio = 60
                txtPrecio.Text = Convert.ToString(FormatNumber(precio, 2))
                duracion = 80
                txtDuracion.Text = Convert.ToString(duracion)

            Case 5
                precio = 100
                txtPrecio.Text = Convert.ToString(FormatNumber(precio, 2))
                duracion = 70
                txtDuracion.Text = Convert.ToString(duracion)

            Case 6
                precio = 110
                txtPrecio.Text = Convert.ToString(FormatNumber(precio, 2))
                duracion = 60
                txtDuracion.Text = Convert.ToString(duracion)

            Case 0
                precio = 85
                txtPrecio.Text = Convert.ToString(FormatNumber(precio, 2))
                duracion = 80
                txtDuracion.Text = Convert.ToString(duracion)
        End Select
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCantidad.Clear()
        txtDescuento.Clear()
        txtDuracion.Clear()
        txtImporte.Clear()
        txtPrecio.Clear()
        txtSub.Clear()
        txtTotal.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        cmbPelicula.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
    End Sub

    Private Sub cmbPelicula_Validating(sender As Object, e As CancelEventArgs) Handles cmbPelicula.Validating
        If Val(cmbPelicula.Text) - Int(Val(cmbPelicula.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub


    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If Val(txtPrecio.Text) - Int(Val(txtPrecio.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub

    Private Sub txtDuracion_Validating(sender As Object, e As CancelEventArgs) Handles txtDuracion.Validating
        If Val(txtDuracion.Text) - Int(Val(txtDuracion.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub


    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub
End Class