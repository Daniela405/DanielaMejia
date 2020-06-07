Public Class Form1
    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        calculadora.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AlmacenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenesToolStripMenuItem.Click
        almacenes.Show()
    End Sub

    Private Sub CuadraticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadraticaToolStripMenuItem.Click
        cuadratica.Show()
    End Sub

    Private Sub CantidadDeNúmerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CantidadDeNúmerosToolStripMenuItem.Click
        numeros.Show()
    End Sub

    Private Sub SARHondurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SARHondurasToolStripMenuItem.Click
        SAR.Show()
    End Sub
End Class
