Public Class menu2
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.Close()
        cliente.Show()

    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
        Form1.Show()


    End Sub

    Private Sub BoletosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoletosToolStripMenuItem.Click
        boletos.Show()

    End Sub
End Class