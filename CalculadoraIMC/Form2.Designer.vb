<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblEstatura = New System.Windows.Forms.Label()
        Me.LblEdad = New System.Windows.Forms.Label()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblSustancias = New System.Windows.Forms.Label()
        Me.LblIMC = New System.Windows.Forms.Label()
        Me.LblCondicion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Location = New System.Drawing.Point(417, 362)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(130, 44)
        Me.btnRegresar.TabIndex = 9
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(219, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 29)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Resultados"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(41, 53)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 20)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "Label11"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.Location = New System.Drawing.Point(41, 90)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(68, 20)
        Me.lblPeso.TabIndex = 12
        Me.lblPeso.Text = "Label12"
        '
        'lblEstatura
        '
        Me.lblEstatura.AutoSize = True
        Me.lblEstatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatura.Location = New System.Drawing.Point(41, 128)
        Me.lblEstatura.Name = "lblEstatura"
        Me.lblEstatura.Size = New System.Drawing.Size(68, 20)
        Me.lblEstatura.TabIndex = 13
        Me.lblEstatura.Text = "Label13"
        '
        'LblEdad
        '
        Me.LblEdad.AutoSize = True
        Me.LblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdad.Location = New System.Drawing.Point(41, 163)
        Me.LblEdad.Name = "LblEdad"
        Me.LblEdad.Size = New System.Drawing.Size(68, 20)
        Me.LblEdad.TabIndex = 14
        Me.LblEdad.Text = "Label14"
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacionalidad.Location = New System.Drawing.Point(41, 201)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(68, 20)
        Me.lblNacionalidad.TabIndex = 15
        Me.lblNacionalidad.Text = "Label15"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(41, 234)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(68, 20)
        Me.lblSexo.TabIndex = 16
        Me.lblSexo.Text = "Label16"
        '
        'lblSustancias
        '
        Me.lblSustancias.AutoSize = True
        Me.lblSustancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSustancias.Location = New System.Drawing.Point(41, 267)
        Me.lblSustancias.Name = "lblSustancias"
        Me.lblSustancias.Size = New System.Drawing.Size(68, 20)
        Me.lblSustancias.TabIndex = 17
        Me.lblSustancias.Text = "Label17"
        '
        'LblIMC
        '
        Me.LblIMC.AutoSize = True
        Me.LblIMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIMC.Location = New System.Drawing.Point(41, 306)
        Me.LblIMC.Name = "LblIMC"
        Me.LblIMC.Size = New System.Drawing.Size(68, 20)
        Me.LblIMC.TabIndex = 18
        Me.LblIMC.Text = "Label18"
        '
        'LblCondicion
        '
        Me.LblCondicion.AutoSize = True
        Me.LblCondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCondicion.Location = New System.Drawing.Point(41, 341)
        Me.LblCondicion.Name = "LblCondicion"
        Me.LblCondicion.Size = New System.Drawing.Size(68, 20)
        Me.LblCondicion.TabIndex = 19
        Me.LblCondicion.Text = "Label19"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 467)
        Me.Controls.Add(Me.LblCondicion)
        Me.Controls.Add(Me.LblIMC)
        Me.Controls.Add(Me.lblSustancias)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblNacionalidad)
        Me.Controls.Add(Me.LblEdad)
        Me.Controls.Add(Me.lblEstatura)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnRegresar)
        Me.Name = "Form2"
        Me.Text = "Resultados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblEstatura As Label
    Friend WithEvents LblEdad As Label
    Friend WithEvents lblNacionalidad As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblSustancias As Label
    Friend WithEvents LblIMC As Label
    Friend WithEvents LblCondicion As Label
End Class
