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
        Me.btnmenos = New System.Windows.Forms.Button()
        Me.btnmas = New System.Windows.Forms.Button()
        Me.btnmenos2 = New System.Windows.Forms.Button()
        Me.btnmas2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numero1 = New System.Windows.Forms.Label()
        Me.numero2 = New System.Windows.Forms.Label()
        Me.lbResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnmenos
        '
        Me.btnmenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenos.Location = New System.Drawing.Point(117, 67)
        Me.btnmenos.Name = "btnmenos"
        Me.btnmenos.Size = New System.Drawing.Size(48, 49)
        Me.btnmenos.TabIndex = 0
        Me.btnmenos.Text = "-"
        Me.btnmenos.UseVisualStyleBackColor = True
        '
        'btnmas
        '
        Me.btnmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmas.Location = New System.Drawing.Point(239, 67)
        Me.btnmas.Name = "btnmas"
        Me.btnmas.Size = New System.Drawing.Size(47, 49)
        Me.btnmas.TabIndex = 1
        Me.btnmas.Text = "+"
        Me.btnmas.UseVisualStyleBackColor = True
        '
        'btnmenos2
        '
        Me.btnmenos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenos2.Location = New System.Drawing.Point(117, 159)
        Me.btnmenos2.Name = "btnmenos2"
        Me.btnmenos2.Size = New System.Drawing.Size(48, 50)
        Me.btnmenos2.TabIndex = 2
        Me.btnmenos2.Text = "-"
        Me.btnmenos2.UseVisualStyleBackColor = True
        '
        'btnmas2
        '
        Me.btnmas2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmas2.Location = New System.Drawing.Point(239, 159)
        Me.btnmas2.Name = "btnmas2"
        Me.btnmas2.Size = New System.Drawing.Size(47, 50)
        Me.btnmas2.TabIndex = 3
        Me.btnmas2.Text = "+"
        Me.btnmas2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(363, 67)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Sumar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(363, 96)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Restar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(363, 125)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Multiplicar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(363, 154)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Dividir"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(363, 200)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Limpiar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "B"
        '
        'numero1
        '
        Me.numero1.AutoSize = True
        Me.numero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero1.Location = New System.Drawing.Point(189, 79)
        Me.numero1.Name = "numero1"
        Me.numero1.Size = New System.Drawing.Size(25, 25)
        Me.numero1.TabIndex = 11
        Me.numero1.Text = "0"
        '
        'numero2
        '
        Me.numero2.AutoSize = True
        Me.numero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero2.Location = New System.Drawing.Point(189, 172)
        Me.numero2.Name = "numero2"
        Me.numero2.Size = New System.Drawing.Size(25, 25)
        Me.numero2.TabIndex = 12
        Me.numero2.Text = "0"
        '
        'lbResultado
        '
        Me.lbResultado.AutoSize = True
        Me.lbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResultado.Location = New System.Drawing.Point(189, 256)
        Me.lbResultado.Name = "lbResultado"
        Me.lbResultado.Size = New System.Drawing.Size(177, 25)
        Me.lbResultado.TabIndex = 13
        Me.lbResultado.Text = "El resultado es:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbResultado)
        Me.Controls.Add(Me.numero2)
        Me.Controls.Add(Me.numero1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnmas2)
        Me.Controls.Add(Me.btnmenos2)
        Me.Controls.Add(Me.btnmas)
        Me.Controls.Add(Me.btnmenos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnmenos As Button
    Friend WithEvents btnmas As Button
    Friend WithEvents btnmenos2 As Button
    Friend WithEvents btnmas2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numero1 As Label
    Friend WithEvents numero2 As Label
    Friend WithEvents lbResultado As Label
End Class
