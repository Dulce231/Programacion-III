Public Class Form1
    ' Variables para almacenar los datos del cliente
    Public Shared Nombre As String
    Public Shared Direccion As String
    Public Shared ReferenciaUbicacion As String
    Public Shared MetodoPago As String

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        ' Guardar los datos en variables compartidas
        Nombre = txtNombre.Text
        Direccion = txtDireccion.Text
        ReferenciaUbicacion = txtReferencia.Text

        ' Verificar el método de pago seleccionado
        If rbtnEfectivo.Checked Then
            MetodoPago = "Efectivo"
        ElseIf rbtnTarjeta.Checked Then
            MetodoPago = "Tarjeta"
        End If

        ' Abrir Form2 y ocultar Form1
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub
End Class
