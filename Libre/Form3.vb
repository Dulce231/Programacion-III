Public Class Form3
    Private Articulos As List(Of String)

    ' Constructor que recibe los productos seleccionados
    Public Sub New(productos As List(Of String))
        InitializeComponent()
        Articulos = productos
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Calcular el total de la compra
        Dim total As Decimal = CalcularTotal()

        ' Mostrar la información del cliente ingresada en Form1
        lblInfo.Text =
                       "Nombre: " & Form1.Nombre & vbCrLf &
                       "Dirección: " & Form1.Direccion & vbCrLf &
                       "Referencia: " & Form1.ReferenciaUbicacion & vbCrLf &
                       "Método de Pago: " & Form1.MetodoPago & vbCrLf & vbCrLf &
                       "Artículos seleccionados:" & vbCrLf &
                       String.Join(vbCrLf, Articulos) & vbCrLf & vbCrLf &
                       "Total a pagar: $" & total.ToString("0.00")
    End Sub

    ' Método para calcular el total de la compra
    Private Function CalcularTotal() As Decimal
        Dim total As Decimal = 0

        For Each articulo In Articulos
            ' Extraer el precio de cada artículo (último valor después del "$")
            Dim partes As String() = articulo.Split("$"c)
            If partes.Length > 1 Then
                Dim precio As Decimal
                If Decimal.TryParse(partes(1).Trim(), precio) Then
                    total += precio
                End If
            End If
        Next

        Return total
    End Function

    ' Evento para cerrar la aplicación cuando se presiona el botón Salir
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
