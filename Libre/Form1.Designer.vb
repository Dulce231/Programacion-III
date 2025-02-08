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
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.rbtnTarjeta = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbtnEfectivo = New System.Windows.Forms.RadioButton()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnContinuar
        '
        Me.btnContinuar.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.Location = New System.Drawing.Point(618, 262)
        Me.btnContinuar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(143, 41)
        Me.btnContinuar.TabIndex = 32
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'rbtnTarjeta
        '
        Me.rbtnTarjeta.AutoSize = True
        Me.rbtnTarjeta.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnTarjeta.Location = New System.Drawing.Point(288, 262)
        Me.rbtnTarjeta.Name = "rbtnTarjeta"
        Me.rbtnTarjeta.Size = New System.Drawing.Size(102, 24)
        Me.rbtnTarjeta.TabIndex = 31
        Me.rbtnTarjeta.TabStop = True
        Me.rbtnTarjeta.Text = "Tarjeta"
        Me.rbtnTarjeta.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(117, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Metodo de pago"
        '
        'rbtnEfectivo
        '
        Me.rbtnEfectivo.AutoSize = True
        Me.rbtnEfectivo.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnEfectivo.Location = New System.Drawing.Point(121, 262)
        Me.rbtnEfectivo.Name = "rbtnEfectivo"
        Me.rbtnEfectivo.Size = New System.Drawing.Size(112, 24)
        Me.rbtnEfectivo.TabIndex = 29
        Me.rbtnEfectivo.TabStop = True
        Me.rbtnEfectivo.Text = "Efectivo"
        Me.rbtnEfectivo.UseVisualStyleBackColor = True
        '
        'txtReferencia
        '
        Me.txtReferencia.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Location = New System.Drawing.Point(378, 174)
        Me.txtReferencia.Multiline = True
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(281, 30)
        Me.txtReferencia.TabIndex = 28
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(263, 131)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(282, 30)
        Me.txtDireccion.TabIndex = 27
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(236, 95)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(191, 30)
        Me.txtNombre.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(117, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Referencia de ubicacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Direccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 52)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Candy's Vanity"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(800, 364)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.rbtnTarjeta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rbtnEfectivo)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Datos Personales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnContinuar As Button
    Friend WithEvents rbtnTarjeta As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents rbtnEfectivo As RadioButton
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
