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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbSuma = New System.Windows.Forms.CheckBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.cbRaiz = New System.Windows.Forms.CheckBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cbDivision = New System.Windows.Forms.CheckBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cbPotencia = New System.Windows.Forms.CheckBox()
        Me.cbMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.cbResta = New System.Windows.Forms.CheckBox()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.cbSuma)
        Me.GroupBox1.Controls.Add(Me.txtResultado)
        Me.GroupBox1.Controls.Add(Me.cbRaiz)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.cbDivision)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.cbPotencia)
        Me.GroupBox1.Controls.Add(Me.cbMultiplicacion)
        Me.GroupBox1.Controls.Add(Me.cbResta)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(133, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 340)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione la Operación"
        '
        'cbSuma
        '
        Me.cbSuma.AutoSize = True
        Me.cbSuma.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSuma.ForeColor = System.Drawing.Color.White
        Me.cbSuma.Location = New System.Drawing.Point(43, 46)
        Me.cbSuma.Name = "cbSuma"
        Me.cbSuma.Size = New System.Drawing.Size(88, 27)
        Me.cbSuma.TabIndex = 2
        Me.cbSuma.Text = "Suma"
        Me.cbSuma.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Enabled = False
        Me.txtResultado.Location = New System.Drawing.Point(114, 256)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(117, 29)
        Me.txtResultado.TabIndex = 10
        '
        'cbRaiz
        '
        Me.cbRaiz.AutoSize = True
        Me.cbRaiz.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRaiz.ForeColor = System.Drawing.Color.White
        Me.cbRaiz.Location = New System.Drawing.Point(43, 195)
        Me.cbRaiz.Name = "cbRaiz"
        Me.cbRaiz.Size = New System.Drawing.Size(74, 27)
        Me.cbRaiz.TabIndex = 8
        Me.cbRaiz.Text = "Raíz"
        Me.cbRaiz.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(224, 146)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 37)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'cbDivision
        '
        Me.cbDivision.AutoSize = True
        Me.cbDivision.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDivision.ForeColor = System.Drawing.Color.White
        Me.cbDivision.Location = New System.Drawing.Point(43, 136)
        Me.cbDivision.Name = "cbDivision"
        Me.cbDivision.Size = New System.Drawing.Size(107, 27)
        Me.cbDivision.TabIndex = 6
        Me.cbDivision.Text = "División"
        Me.cbDivision.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(224, 93)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(94, 37)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'cbPotencia
        '
        Me.cbPotencia.AutoSize = True
        Me.cbPotencia.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPotencia.ForeColor = System.Drawing.Color.White
        Me.cbPotencia.Location = New System.Drawing.Point(43, 166)
        Me.cbPotencia.Name = "cbPotencia"
        Me.cbPotencia.Size = New System.Drawing.Size(112, 27)
        Me.cbPotencia.TabIndex = 7
        Me.cbPotencia.Text = "Potencia"
        Me.cbPotencia.UseVisualStyleBackColor = True
        '
        'cbMultiplicacion
        '
        Me.cbMultiplicacion.AutoSize = True
        Me.cbMultiplicacion.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMultiplicacion.ForeColor = System.Drawing.Color.White
        Me.cbMultiplicacion.Location = New System.Drawing.Point(43, 106)
        Me.cbMultiplicacion.Name = "cbMultiplicacion"
        Me.cbMultiplicacion.Size = New System.Drawing.Size(156, 27)
        Me.cbMultiplicacion.TabIndex = 5
        Me.cbMultiplicacion.Text = "Multiplicación"
        Me.cbMultiplicacion.UseVisualStyleBackColor = True
        '
        'cbResta
        '
        Me.cbResta.AutoSize = True
        Me.cbResta.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbResta.ForeColor = System.Drawing.Color.White
        Me.cbResta.Location = New System.Drawing.Point(43, 76)
        Me.cbResta.Name = "cbResta"
        Me.cbResta.Size = New System.Drawing.Size(87, 27)
        Me.cbResta.TabIndex = 4
        Me.cbResta.Text = "Resta"
        Me.cbResta.UseVisualStyleBackColor = True
        '
        'btnValidar
        '
        Me.btnValidar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnValidar.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.ForeColor = System.Drawing.Color.White
        Me.btnValidar.Location = New System.Drawing.Point(393, 28)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(96, 37)
        Me.btnValidar.TabIndex = 24
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = False
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(243, 60)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(117, 26)
        Me.txtValor2.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(155, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Valor 2 "
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(243, 9)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(117, 26)
        Me.txtValor1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(155, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Valor 1 "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(589, 474)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Tarea 2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbSuma As CheckBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents cbRaiz As CheckBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents cbDivision As CheckBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cbPotencia As CheckBox
    Friend WithEvents cbMultiplicacion As CheckBox
    Friend WithEvents cbResta As CheckBox
    Friend WithEvents btnValidar As Button
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents Label1 As Label
End Class
