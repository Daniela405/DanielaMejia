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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtResta = New System.Windows.Forms.TextBox()
        Me.txtMultiplicacion = New System.Windows.Forms.TextBox()
        Me.txtdivision = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Maroon
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(187, 170)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(93, 37)
        Me.btnLimpiar.TabIndex = 31
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'txtResta
        '
        Me.txtResta.Enabled = False
        Me.txtResta.Location = New System.Drawing.Point(188, 273)
        Me.txtResta.Name = "txtResta"
        Me.txtResta.Size = New System.Drawing.Size(100, 26)
        Me.txtResta.TabIndex = 42
        '
        'txtMultiplicacion
        '
        Me.txtMultiplicacion.Enabled = False
        Me.txtMultiplicacion.Location = New System.Drawing.Point(188, 315)
        Me.txtMultiplicacion.Name = "txtMultiplicacion"
        Me.txtMultiplicacion.Size = New System.Drawing.Size(100, 26)
        Me.txtMultiplicacion.TabIndex = 41
        '
        'txtdivision
        '
        Me.txtdivision.Enabled = False
        Me.txtdivision.Location = New System.Drawing.Point(188, 351)
        Me.txtdivision.Name = "txtdivision"
        Me.txtdivision.Size = New System.Drawing.Size(100, 26)
        Me.txtdivision.TabIndex = 40
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(78, 277)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(52, 20)
        Me.label6.TabIndex = 39
        Me.label6.Text = "Resta"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(78, 318)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(103, 20)
        Me.label5.TabIndex = 38
        Me.label5.Text = "Multiplicación"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(78, 353)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(63, 20)
        Me.label4.TabIndex = 37
        Me.label4.Text = "División"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Maroon
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(290, 170)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 37)
        Me.btnSalir.TabIndex = 32
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnSuma
        '
        Me.btnSuma.BackColor = System.Drawing.Color.Maroon
        Me.btnSuma.ForeColor = System.Drawing.Color.White
        Me.btnSuma.Location = New System.Drawing.Point(88, 170)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(93, 37)
        Me.btnSuma.TabIndex = 30
        Me.btnSuma.Text = "Calcular"
        Me.btnSuma.UseVisualStyleBackColor = False
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(195, 98)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 26)
        Me.txtValor2.TabIndex = 29
        '
        'txtSuma
        '
        Me.txtSuma.Enabled = False
        Me.txtSuma.Location = New System.Drawing.Point(188, 237)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.Size = New System.Drawing.Size(100, 26)
        Me.txtSuma.TabIndex = 36
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(195, 41)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 26)
        Me.txtValor1.TabIndex = 28
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(78, 237)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(51, 20)
        Me.label3.TabIndex = 35
        Me.label3.Text = "Suma"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(104, 104)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 20)
        Me.label2.TabIndex = 34
        Me.label2.Text = "Valor 2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(104, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(59, 20)
        Me.label1.TabIndex = 33
        Me.label1.Text = "Valor 1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(424, 450)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtResta)
        Me.Controls.Add(Me.txtMultiplicacion)
        Me.Controls.Add(Me.txtdivision)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtSuma)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnLimpiar As Button
    Private WithEvents txtResta As TextBox
    Private WithEvents txtMultiplicacion As TextBox
    Private WithEvents txtdivision As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents btnSalir As Button
    Private WithEvents btnSuma As Button
    Private WithEvents txtValor2 As TextBox
    Private WithEvents txtSuma As TextBox
    Private WithEvents txtValor1 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
