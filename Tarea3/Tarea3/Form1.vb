
Public Class Form1
        Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
            txtCantidad.Clear()
            txtDescuento.Clear()
            txtISV.Clear()
            txtPrecio.Clear()
            txtSubtotal.Clear()
            txtTotal.Clear()
            comImpuesto.Text = ""
            comDescuento.Text = ""
            CheckBox1.Checked = False
            CheckBox2.Checked = False

            If btnNuevo.Enabled = True Then
                btnNuevo.Enabled = False
            End If

        End Sub

        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
            End
        End Sub

        Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
            'declaracion de variables
            Dim pUnitario, cantidad As Integer
            Dim descuento, impuesto, subtotal, total As Double


            pUnitario = Val(txtPrecio.Text)
            cantidad = Val(txtCantidad.Text)


            descuento = 0
            subtotal = pUnitario * cantidad

            'condicion para calcular el descuento
            If comDescuento.Text = "5%" Then
                descuento = subtotal * 0.05
                total = subtotal - descuento
            ElseIf comDescuento.Text = "10%" Then
                descuento = subtotal * 0.1
                total = subtotal - descuento
            ElseIf comDescuento.Text = "15%" Then
                descuento = subtotal * 0.15
                total = subtotal - descuento
            ElseIf comDescuento.Text = "20%" Then
                descuento = subtotal * 0.2
                total = subtotal - descuento
            ElseIf comDescuento.Text = "30%" Then
                descuento = subtotal * 0.3
                total = subtotal - descuento
            ElseIf comDescuento.Text = "50%" Then
                descuento = subtotal * 0.5
                total = subtotal - descuento
            End If

            'condicion para calcular el impuesto
            If comImpuesto.Text = "15%" Then
                impuesto = subtotal * 0.15
                total = subtotal + impuesto
            ElseIf comImpuesto.Text = "17%" Then
                impuesto = subtotal * 0.17
                total = subtotal + impuesto

            End If


            txtSubtotal.Text = subtotal
            txtDescuento.Text = descuento
            txtISV.Text = impuesto
            txtTotal.Text = total


            'condicion para desabilitar el boton de nuevo 
            If btnCalcular.Enabled = True Then
                btnNuevo.Enabled = True
            Else
                btnNuevo.Enabled = False
            End If


            'condiciones para validar los digitos ingresados por el usuario
            If txtPrecio.Text = "" And txtCantidad.Text = "" Then
                MsgBox("Escriba un numero en la casilla", vbInformation)
            ElseIf Not IsNumeric(txtPrecio.Text) And Not IsNumeric(txtCantidad.Text) Then
                MsgBox("Ingrese un valor numerico", vbInformation)
                txtCantidad.Text = ""
                txtPrecio.Text = ""
            ElseIf txtPrecio.Text < 0 Then
                MsgBox("Número negativo", vbInformation)
                txtPrecio.Text = ""
            ElseIf txtCantidad.Text < 0 Then
                MsgBox("Numero negativo", vbInformation)
                txtCantidad.Text = ""
            End If


        End Sub

        Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
            If CheckBox1.Checked = False Then
                comDescuento.Enabled = False
            ElseIf CheckBox1.Checked = True Then
                comDescuento.Enabled = True

            End If

            CheckBox2.Checked = False
        End Sub

        Private Sub comDescuento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comDescuento.SelectedIndexChanged
            If CheckBox1.Checked = False Then
                comDescuento.Enabled = False
            ElseIf CheckBox1.Checked = True Then
                comDescuento.Enabled = True
            End If

            If CheckBox2.Checked = False Then
                comImpuesto.Enabled = False
            ElseIf CheckBox2.Checked = True Then
                comImpuesto.Enabled = True

            End If
        End Sub

        Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
            CheckBox1.Checked = False
            If CheckBox2.Checked = False Then
                comImpuesto.Enabled = False
            ElseIf CheckBox2.Checked = True Then
                comImpuesto.Enabled = True

            End If

            If CheckBox1.Checked = False Then
                comDescuento.Enabled = False
            ElseIf CheckBox1.Checked = True Then
                comDescuento.Enabled = True

            End If
        End Sub

        Private Sub comImpuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comImpuesto.SelectedIndexChanged
            If CheckBox2.Checked = False Then
                comImpuesto.Enabled = False
            ElseIf CheckBox2.Checked = True Then
                comImpuesto.Enabled = True

            End If

            If CheckBox2.Checked = True Then
                comImpuesto.Enabled = True
            ElseIf CheckBox1.Checked = False Then
                comDescuento.Enabled = False

            End If
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            btnNuevo.Enabled = False
            comDescuento.Enabled = False
            comImpuesto.Enabled = False

        End Sub
    End Class
