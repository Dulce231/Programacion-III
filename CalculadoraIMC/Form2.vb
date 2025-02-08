Public Class Form2
    ' Variables para recibir los datos del Form1
    Private imc As Double
    Private condicion As String
    Private edad As String
    Private nombre As String
    Private sexo As String
    Private nacionalidad As String
    Private sustancias As String
    Private peso As Double
    Private estatura As Double

    ' Constructor para recibir datos desde Form1
    Public Sub New(imcResultado As Double, condicionResultado As String, edadSeleccionada As String,
                   nombrePaciente As String, sexoPaciente As String, nacionalidadPaciente As String,
                   sustanciasPaciente As String, pesoPaciente As Double, estaturaPaciente As Double)

        InitializeComponent()
        Me.imc = imcResultado
        Me.condicion = condicionResultado
        Me.edad = edadSeleccionada
        Me.nombre = nombrePaciente
        Me.sexo = sexoPaciente
        Me.nacionalidad = nacionalidadPaciente
        Me.sustancias = sustanciasPaciente
        Me.peso = pesoPaciente
        Me.estatura = estaturaPaciente
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar los valores en las etiquetas
        lblNombre.Text = $"Nombre: {nombre}"
        LblEdad.Text = $"Edad: {edad}"
        lblSexo.Text = $"Sexo: {sexo}"
        lblNacionalidad.Text = $"Nacionalidad: {nacionalidad}"
        lblPeso.Text = $"Peso: {peso:F2} kg"
        lblEstatura.Text = $"Estatura: {estatura:F2} m"
        LblIMC.Text = $"IMC: {imc:F2}"
        LblCondicion.Text = $"Condición: {condicion}"
        lblSustancias.Text = $"Sustancias consumidas: {sustancias}"
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
