<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuadratica
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
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(434, 138)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 26)
        Me.TextBox5.TabIndex = 38
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(434, 93)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 26)
        Me.TextBox4.TabIndex = 37
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(98, 149)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 26)
        Me.TextBox3.TabIndex = 28
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(98, 107)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "X2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(382, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "X1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "c"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "b"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "a"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(336, 266)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 45)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(219, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 46)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(260, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 52)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cuadratica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(636, 350)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "cuadratica"
        Me.Text = "Cuadratica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
