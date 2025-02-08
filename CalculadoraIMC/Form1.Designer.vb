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
        Me.cmbEdad = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEstatura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbFemenino = New System.Windows.Forms.RadioButton()
        Me.rdbMasculino = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lstNacionalidad = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkMedicamentos = New System.Windows.Forms.CheckBox()
        Me.chkDrogas = New System.Windows.Forms.CheckBox()
        Me.chkTabaco = New System.Windows.Forms.CheckBox()
        Me.chkAlcohol = New System.Windows.Forms.CheckBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbEdad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPeso)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEstatura)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 201)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del paciente"
        '
        'cmbEdad
        '
        Me.cmbEdad.FormattingEnabled = True
        Me.cmbEdad.Items.AddRange(New Object() {"10-20", "20-30", "30-40", "40-50", "50-60"})
        Me.cmbEdad.Location = New System.Drawing.Point(159, 157)
        Me.cmbEdad.Name = "cmbEdad"
        Me.cmbEdad.Size = New System.Drawing.Size(151, 28)
        Me.cmbEdad.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rango de edad"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(115, 121)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(144, 26)
        Me.txtPeso.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Peso"
        '
        'txtEstatura
        '
        Me.txtEstatura.Location = New System.Drawing.Point(115, 81)
        Me.txtEstatura.Name = "txtEstatura"
        Me.txtEstatura.Size = New System.Drawing.Size(144, 26)
        Me.txtEstatura.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Estatura"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(91, 33)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(219, 26)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(-638, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbFemenino)
        Me.GroupBox3.Controls.Add(Me.rdbMasculino)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(440, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(132, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sexo"
        '
        'rdbFemenino
        '
        Me.rdbFemenino.AutoSize = True
        Me.rdbFemenino.Location = New System.Drawing.Point(7, 50)
        Me.rdbFemenino.Name = "rdbFemenino"
        Me.rdbFemenino.Size = New System.Drawing.Size(103, 24)
        Me.rdbFemenino.TabIndex = 1
        Me.rdbFemenino.TabStop = True
        Me.rdbFemenino.Text = "Femenino"
        Me.rdbFemenino.UseVisualStyleBackColor = True
        '
        'rdbMasculino
        '
        Me.rdbMasculino.AutoSize = True
        Me.rdbMasculino.Location = New System.Drawing.Point(7, 22)
        Me.rdbMasculino.Name = "rdbMasculino"
        Me.rdbMasculino.Size = New System.Drawing.Size(106, 24)
        Me.rdbMasculino.TabIndex = 0
        Me.rdbMasculino.TabStop = True
        Me.rdbMasculino.Text = "Masculino"
        Me.rdbMasculino.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstNacionalidad)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 278)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 136)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Nacionalidad"
        '
        'lstNacionalidad
        '
        Me.lstNacionalidad.FormattingEnabled = True
        Me.lstNacionalidad.ItemHeight = 20
        Me.lstNacionalidad.Items.AddRange(New Object() {"Mexicana", "Estadounidense", "Españona", "Inglesa"})
        Me.lstNacionalidad.Location = New System.Drawing.Point(13, 30)
        Me.lstNacionalidad.Name = "lstNacionalidad"
        Me.lstNacionalidad.Size = New System.Drawing.Size(162, 84)
        Me.lstNacionalidad.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkMedicamentos)
        Me.GroupBox5.Controls.Add(Me.chkDrogas)
        Me.GroupBox5.Controls.Add(Me.chkTabaco)
        Me.GroupBox5.Controls.Add(Me.chkAlcohol)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(265, 278)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(431, 132)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "¿Usted consume alguna de estas sustancias?"
        '
        'chkMedicamentos
        '
        Me.chkMedicamentos.AutoSize = True
        Me.chkMedicamentos.Location = New System.Drawing.Point(153, 57)
        Me.chkMedicamentos.Name = "chkMedicamentos"
        Me.chkMedicamentos.Size = New System.Drawing.Size(211, 24)
        Me.chkMedicamentos.TabIndex = 3
        Me.chkMedicamentos.Text = "Medicamento prescritos"
        Me.chkMedicamentos.UseVisualStyleBackColor = True
        '
        'chkDrogas
        '
        Me.chkDrogas.AutoSize = True
        Me.chkDrogas.Location = New System.Drawing.Point(153, 33)
        Me.chkDrogas.Name = "chkDrogas"
        Me.chkDrogas.Size = New System.Drawing.Size(86, 24)
        Me.chkDrogas.TabIndex = 2
        Me.chkDrogas.Text = "Drogas"
        Me.chkDrogas.UseVisualStyleBackColor = True
        '
        'chkTabaco
        '
        Me.chkTabaco.AutoSize = True
        Me.chkTabaco.Location = New System.Drawing.Point(7, 61)
        Me.chkTabaco.Name = "chkTabaco"
        Me.chkTabaco.Size = New System.Drawing.Size(86, 24)
        Me.chkTabaco.TabIndex = 1
        Me.chkTabaco.Text = "Tabaco"
        Me.chkTabaco.UseVisualStyleBackColor = True
        '
        'chkAlcohol
        '
        Me.chkAlcohol.AutoSize = True
        Me.chkAlcohol.Location = New System.Drawing.Point(7, 33)
        Me.chkAlcohol.Name = "chkAlcohol"
        Me.chkAlcohol.Size = New System.Drawing.Size(86, 24)
        Me.chkAlcohol.TabIndex = 0
        Me.chkAlcohol.Text = "Alcohol"
        Me.chkAlcohol.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnCalcular.Location = New System.Drawing.Point(152, 452)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(163, 48)
        Me.btnCalcular.TabIndex = 5
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(392, 452)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(148, 48)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(92, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(528, 29)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Calculadora de indice de masa corporal (IMC)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 585)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Calculadora de IMC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbEdad As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEstatura As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdbFemenino As RadioButton
    Friend WithEvents rdbMasculino As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lstNacionalidad As ListBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents chkMedicamentos As CheckBox
    Friend WithEvents chkDrogas As CheckBox
    Friend WithEvents chkTabaco As CheckBox
    Friend WithEvents chkAlcohol As CheckBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label5 As Label
End Class
