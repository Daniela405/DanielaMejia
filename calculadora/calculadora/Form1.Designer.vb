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
        Me.Button10 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.ButtonSuma = New System.Windows.Forms.Button()
        Me.ButtonResta = New System.Windows.Forms.Button()
        Me.ButtonMultiplicacion = New System.Windows.Forms.Button()
        Me.ButtonDivison = New System.Windows.Forms.Button()
        Me.ButtonBorrar = New System.Windows.Forms.Button()
        Me.ButtonIgual = New System.Windows.Forms.Button()
        Me.ButtonPunto = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Gray
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button10.Location = New System.Drawing.Point(245, 388)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(95, 38)
        Me.Button10.TabIndex = 39
        Me.Button10.Text = "Salir"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1.Location = New System.Drawing.Point(387, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(211, 354)
        Me.DataGridView1.TabIndex = 38
        '
        'Column1
        '
        Me.Column1.HeaderText = "Operaciones"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(44, 49)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(235, 26)
        Me.TxtResultado.TabIndex = 37
        Me.TxtResultado.Text = "0"
        Me.TxtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonSuma
        '
        Me.ButtonSuma.Location = New System.Drawing.Point(285, 20)
        Me.ButtonSuma.Name = "ButtonSuma"
        Me.ButtonSuma.Size = New System.Drawing.Size(72, 66)
        Me.ButtonSuma.TabIndex = 36
        Me.ButtonSuma.Text = "+"
        Me.ButtonSuma.UseVisualStyleBackColor = True
        '
        'ButtonResta
        '
        Me.ButtonResta.Location = New System.Drawing.Point(282, 92)
        Me.ButtonResta.Name = "ButtonResta"
        Me.ButtonResta.Size = New System.Drawing.Size(72, 66)
        Me.ButtonResta.TabIndex = 35
        Me.ButtonResta.Text = "-"
        Me.ButtonResta.UseVisualStyleBackColor = True
        '
        'ButtonMultiplicacion
        '
        Me.ButtonMultiplicacion.Location = New System.Drawing.Point(282, 164)
        Me.ButtonMultiplicacion.Name = "ButtonMultiplicacion"
        Me.ButtonMultiplicacion.Size = New System.Drawing.Size(72, 66)
        Me.ButtonMultiplicacion.TabIndex = 34
        Me.ButtonMultiplicacion.Text = "*"
        Me.ButtonMultiplicacion.UseVisualStyleBackColor = True
        '
        'ButtonDivison
        '
        Me.ButtonDivison.Location = New System.Drawing.Point(283, 236)
        Me.ButtonDivison.Name = "ButtonDivison"
        Me.ButtonDivison.Size = New System.Drawing.Size(72, 66)
        Me.ButtonDivison.TabIndex = 33
        Me.ButtonDivison.Text = "/"
        Me.ButtonDivison.UseVisualStyleBackColor = True
        '
        'ButtonBorrar
        '
        Me.ButtonBorrar.Location = New System.Drawing.Point(285, 308)
        Me.ButtonBorrar.Name = "ButtonBorrar"
        Me.ButtonBorrar.Size = New System.Drawing.Size(72, 66)
        Me.ButtonBorrar.TabIndex = 32
        Me.ButtonBorrar.Text = "C"
        Me.ButtonBorrar.UseVisualStyleBackColor = True
        '
        'ButtonIgual
        '
        Me.ButtonIgual.Location = New System.Drawing.Point(202, 308)
        Me.ButtonIgual.Name = "ButtonIgual"
        Me.ButtonIgual.Size = New System.Drawing.Size(72, 66)
        Me.ButtonIgual.TabIndex = 31
        Me.ButtonIgual.Text = "="
        Me.ButtonIgual.UseVisualStyleBackColor = True
        '
        'ButtonPunto
        '
        Me.ButtonPunto.Location = New System.Drawing.Point(122, 308)
        Me.ButtonPunto.Name = "ButtonPunto"
        Me.ButtonPunto.Size = New System.Drawing.Size(72, 66)
        Me.ButtonPunto.TabIndex = 30
        Me.ButtonPunto.Text = "."
        Me.ButtonPunto.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Location = New System.Drawing.Point(44, 308)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(72, 66)
        Me.Button0.TabIndex = 29
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(202, 92)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(72, 66)
        Me.Button9.TabIndex = 28
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(122, 92)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(72, 66)
        Me.Button8.TabIndex = 27
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(44, 92)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(72, 66)
        Me.Button7.TabIndex = 26
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(202, 164)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 66)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(122, 164)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 66)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(44, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 66)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(202, 236)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 66)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(122, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 66)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(44, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 66)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(646, 450)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.ButtonSuma)
        Me.Controls.Add(Me.ButtonResta)
        Me.Controls.Add(Me.ButtonMultiplicacion)
        Me.Controls.Add(Me.ButtonDivison)
        Me.Controls.Add(Me.ButtonBorrar)
        Me.Controls.Add(Me.ButtonIgual)
        Me.Controls.Add(Me.ButtonPunto)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button10 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents ButtonSuma As Button
    Friend WithEvents ButtonResta As Button
    Friend WithEvents ButtonMultiplicacion As Button
    Friend WithEvents ButtonDivison As Button
    Friend WithEvents ButtonBorrar As Button
    Friend WithEvents ButtonIgual As Button
    Friend WithEvents ButtonPunto As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
