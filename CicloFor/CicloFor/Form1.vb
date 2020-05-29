Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For a = 1 To Val(TextBox1.Text)
            Label1.Text = Label1.Text & " " & a
        Next
    End Sub
End Class
