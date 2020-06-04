Imports System.ComponentModel

Public Class cliente
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        menu2.Show()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox5.Text = "") Or (MaskedTextBox1.Text = "") Or (MaskedTextBox2.Text = "") Then
                MsgBox("Es obligario llenar todos los campos", vbInformation)
            Else
                DataGridView1.Rows.Add(MaskedTextBox2.Text, TextBox2.Text, TextBox3.Text, MaskedTextBox1.Text, TextBox5.Text, Button1.Text, Button2.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        MaskedTextBox2.Text = ""
        TextBox2.Clear()
        TextBox3.Clear()
        MaskedTextBox1.Clear()
        TextBox5.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
















    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If Val(RadioButton2.Text) - Int(Val(RadioButton2.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub



    Private Sub MaskedTextBox2_Validating(sender As Object, e As CancelEventArgs) Handles MaskedTextBox2.Validating
        If Val(MaskedTextBox2.Text) - Int(Val(MaskedTextBox2.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs) Handles TextBox2.Validating
        If Val(TextBox2.Text) - Int(Val(TextBox2.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub

    Private Sub TextBox3_Validating(sender As Object, e As CancelEventArgs) Handles TextBox3.Validating
        If Val(TextBox3.Text) - Int(Val(TextBox3.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub

    Private Sub MaskedTextBox1_Validating(sender As Object, e As CancelEventArgs) Handles MaskedTextBox1.Validating
        If Val(MaskedTextBox1.Text) - Int(Val(MaskedTextBox2.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub

    Private Sub TextBox5_Validating(sender As Object, e As CancelEventArgs) Handles TextBox5.Validating
        If Val(TextBox5.Text) - Int(Val(TextBox5.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub

    Private Sub RadioButton1_Validating(sender As Object, e As CancelEventArgs) Handles RadioButton1.Validating
        If Val(RadioButton1.Text) - Int(Val(RadioButton1.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub

    Private Sub RadioButton2_Validating(sender As Object, e As CancelEventArgs) Handles RadioButton2.Validating
        If Val(RadioButton2.Text) - Int(Val(RadioButton2.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub
End Class