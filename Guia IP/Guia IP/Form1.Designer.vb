<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuadraticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CantidadDeNúmerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SARHondurasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Guia_IP.My.Resources.Resources._58532354_código_de_programación_en_pantalla_en_negro_texto_verde_resumen_de_desarrollo_de_software_código_fuente_
        Me.PictureBox1.Location = New System.Drawing.Point(-14, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(879, 427)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.CuadraticaToolStripMenuItem, Me.AlmacenesToolStripMenuItem, Me.CantidadDeNúmerosToolStripMenuItem, Me.SARHondurasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(860, 33)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(120, 29)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'CuadraticaToolStripMenuItem
        '
        Me.CuadraticaToolStripMenuItem.Name = "CuadraticaToolStripMenuItem"
        Me.CuadraticaToolStripMenuItem.Size = New System.Drawing.Size(111, 29)
        Me.CuadraticaToolStripMenuItem.Text = "Cuadratica"
        '
        'AlmacenesToolStripMenuItem
        '
        Me.AlmacenesToolStripMenuItem.Name = "AlmacenesToolStripMenuItem"
        Me.AlmacenesToolStripMenuItem.Size = New System.Drawing.Size(113, 29)
        Me.AlmacenesToolStripMenuItem.Text = "Almacenes"
        '
        'CantidadDeNúmerosToolStripMenuItem
        '
        Me.CantidadDeNúmerosToolStripMenuItem.Name = "CantidadDeNúmerosToolStripMenuItem"
        Me.CantidadDeNúmerosToolStripMenuItem.Size = New System.Drawing.Size(202, 29)
        Me.CantidadDeNúmerosToolStripMenuItem.Text = "Cantidad de Números"
        '
        'SARHondurasToolStripMenuItem
        '
        Me.SARHondurasToolStripMenuItem.Name = "SARHondurasToolStripMenuItem"
        Me.SARHondurasToolStripMenuItem.Size = New System.Drawing.Size(144, 29)
        Me.SARHondurasToolStripMenuItem.Text = "SAR Honduras"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 481)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuadraticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmacenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CantidadDeNúmerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SARHondurasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
