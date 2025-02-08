Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ComboBox de rango de edad
        cmbEdad.Items.Add("10-20")
        cmbEdad.Items.Add("20-30")
        cmbEdad.Items.Add("30-40")
        cmbEdad.Items.Add("40-50")
        cmbEdad.Items.Add("50-60")
        cmbEdad.SelectedIndex = 0 ' Valor por defecto

        ' Seleccionar un valor por defecto en la lista de nacionalidad
        lstNacionalidad.SelectedIndex = 0
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            ' Capturar valores ingresados
            Dim nombre As String = txtNombre.Text.Trim()
            Dim peso As Double
            Dim estatura As Double
            Dim edadSeleccionada As String = cmbEdad.SelectedItem.ToString()
            Dim nacionalidad As String = lstNacionalidad.SelectedItem.ToString()

            ' Validar que el nombre no esté vacío
            If String.IsNullOrWhiteSpace(nombre) Then
                MessageBox.Show("Por favor, ingrese su nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar que los valores sean numéricos
            If Not Double.TryParse(txtPeso.Text, peso) OrElse peso <= 0 Then
                MessageBox.Show("Ingrese un peso válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not Double.TryParse(txtEstatura.Text, estatura) OrElse estatura <= 0 Then
                MessageBox.Show("Ingrese una estatura válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If estatura > 3 Then
                MessageBox.Show("La estatura debe estar en metros. Ejemplo: 1.75", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Determinar el sexo seleccionado
            Dim sexo As String
            If rdbMasculino.Checked Then
                sexo = "Masculino"
            ElseIf rdbFemenino.Checked Then
                sexo = "Femenino"
            Else
                sexo = "No especificado"
            End If

            ' Calcular IMC
            Dim imc As Double = peso / Math.Pow(estatura, 2)

            ' Determinar condición según IMC
            Dim condicion As String
            If imc < 18.5 Then
                condicion = "Infrapeso: Usted se encuentra por debajo del IMC normal."
            ElseIf imc >= 18.5 AndAlso imc <= 25 Then
                condicion = "Normal: Usted se encuentra en el IMC adecuado."
            Else
                condicion = "Sobrepeso: Usted tiene sobrepeso."
            End If

            Dim sustancias As String = ""
            If chkAlcohol.Checked Then sustancias &= "Alcohol, "
            If chkTabaco.Checked Then sustancias &= "Tabaco, "
            If chkDrogas.Checked Then sustancias &= "Drogas, "
            If chkMedicamentos.Checked Then sustancias &= "Medicamentos prescritos, "


            If sustancias.Length > 0 Then
                sustancias = sustancias.Substring(0, sustancias.Length - 2)
            Else
                sustancias = "Ninguna"
            End If


            Dim formResultado As New Form2(imc, condicion, edadSeleccionada, nombre, sexo, nacionalidad, sustancias, peso, estatura)
            formResultado.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Ingrese valores numéricos válidos en Peso y Estatura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Application.Exit()
    End Sub
End Class
