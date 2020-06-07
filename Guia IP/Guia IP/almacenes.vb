Public Class almacenes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim media, almacen1, almacen2, almacen3, almacen4, almacen5, almacen6, almacen7, almacen8, almacen9, almacen10 As Double
        Dim nom1, nom2, mom3, mom4, mom5, mom6, mom7, mom8, mom9, mom10 As String

        almacen1 = Val(txt1.Text)
        almacen2 = Val(txt2.Text)
        almacen3 = Val(txt3.Text)
        almacen4 = Val(txt4.Text)
        almacen5 = Val(txt5.Text)
        almacen6 = Val(txt6.Text)
        almacen7 = Val(txt7.Text)
        almacen8 = Val(txt8.Text)
        almacen9 = Val(txt9.Text)
        almacen10 = Val(txt10.Text)
        nom1 = "Almacen 1"
        nom2 = "Almacen 2"
        mom3 = "Almacen 3"
        mom4 = "Almacen 4"
        mom5 = "Almacen 5"
        mom6 = "Almacen 6"
        mom7 = "Almacen 7"
        mom8 = "Almacen 8"
        mom9 = "Almacen 9"
        mom10 = "Almacen 10"

        media = (almacen1 + almacen2 + almacen3 + almacen4 + almacen5 + almacen6 + almacen7 + almacen8 + almacen9 + almacen10) / 10
        TextBox11.Text = media

        If almacen1 >= media Then
            ListBox1.Items.Add(nom1)
        Else
        End If

        If almacen2 >= media Then
            ListBox1.Items.Add(nom2)
        Else
        End If

        If almacen3 >= media Then
            ListBox1.Items.Add(mom3)
        Else
        End If

        If almacen4 >= media Then
            ListBox1.Items.Add(mom4)
        Else
        End If

        If almacen5 >= media Then
            ListBox1.Items.Add(mom5)
        Else
        End If

        If almacen6 >= media Then
            ListBox1.Items.Add(mom6)
        Else
        End If

        If almacen7 >= media Then
            ListBox1.Items.Add(mom7)
        Else
        End If

        If almacen8 >= media Then
            ListBox1.Items.Add(mom8)
        Else
        End If

        If almacen9 >= media Then
            ListBox1.Items.Add(mom9)
        Else
        End If

        If almacen10 >= media Then
            ListBox1.Items.Add(mom10)
        Else
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Desea salir de la aplicacion", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox11.Clear()
        txt1.Clear()
        txt10.Clear()
        txt2.Clear()
        txt3.Clear()
        txt4.Clear()
        txt5.Clear()
        txt6.Clear()
        txt7.Clear()
        txt8.Clear()
        txt9.Clear()


    End Sub
End Class