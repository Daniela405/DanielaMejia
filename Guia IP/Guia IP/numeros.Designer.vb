<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class numeros
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtsuma = New System.Windows.Forms.TextBox()
        Me.txtnegativos = New System.Windows.Forms.TextBox()
        Me.txtimpares = New System.Windows.Forms.TextBox()
        Me.txtpositivos = New System.Windows.Forms.TextBox()
        Me.txtpares = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(444, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 47)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(444, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 47)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtsuma)
        Me.GroupBox2.Controls.Add(Me.txtnegativos)
        Me.GroupBox2.Controls.Add(Me.txtimpares)
        Me.GroupBox2.Controls.Add(Me.txtpositivos)
        Me.GroupBox2.Controls.Add(Me.txtpares)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(386, 246)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acumulado de Números"
        '
        'txtsuma
        '
        Me.txtsuma.Enabled = False
        Me.txtsuma.Location = New System.Drawing.Point(117, 186)
        Me.txtsuma.Name = "txtsuma"
        Me.txtsuma.Size = New System.Drawing.Size(153, 26)
        Me.txtsuma.TabIndex = 13
        '
        'txtnegativos
        '
        Me.txtnegativos.Enabled = False
        Me.txtnegativos.Location = New System.Drawing.Point(117, 154)
        Me.txtnegativos.Name = "txtnegativos"
        Me.txtnegativos.Size = New System.Drawing.Size(153, 26)
        Me.txtnegativos.TabIndex = 12
        '
        'txtimpares
        '
        Me.txtimpares.Enabled = False
        Me.txtimpares.Location = New System.Drawing.Point(117, 78)
        Me.txtimpares.Name = "txtimpares"
        Me.txtimpares.Size = New System.Drawing.Size(153, 26)
        Me.txtimpares.TabIndex = 11
        '
        'txtpositivos
        '
        Me.txtpositivos.Enabled = False
        Me.txtpositivos.Location = New System.Drawing.Point(117, 115)
        Me.txtpositivos.Name = "txtpositivos"
        Me.txtpositivos.Size = New System.Drawing.Size(153, 26)
        Me.txtpositivos.TabIndex = 10
        '
        'txtpares
        '
        Me.txtpares.Enabled = False
        Me.txtpares.Location = New System.Drawing.Point(118, 42)
        Me.txtpares.Name = "txtpares"
        Me.txtpares.Size = New System.Drawing.Size(153, 26)
        Me.txtpares.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Suma"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Negativos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Impares"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Positivos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pares"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(444, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 47)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(236, 84)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(153, 28)
        Me.ComboBox1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Cantidad de Números"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(236, 35)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(153, 26)
        Me.txtcantidad.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(31, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 160)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Solicitar Números"
        '
        'numeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(642, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "numeros"
        Me.Text = "Numeros"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtsuma As TextBox
    Friend WithEvents txtnegativos As TextBox
    Friend WithEvents txtimpares As TextBox
    Friend WithEvents txtpositivos As TextBox
    Friend WithEvents txtpares As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
