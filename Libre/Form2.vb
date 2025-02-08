Public Class Form2
    ' Lista para almacenar los artículos seleccionados
    Public Shared ArticulosSeleccionados As New List(Of String)

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        ' Limpiar la lista antes de agregar los artículos
        ArticulosSeleccionados.Clear()

        ' Verificar qué artículos han sido seleccionados
        If chkSerum.Checked Then ArticulosSeleccionados.Add("Sérum facial de noche - $269.00")
        If chkCerave.Checked Then ArticulosSeleccionados.Add("CeraVe Blemish Control - $371.66")
        If chkGarnier.Checked Then ArticulosSeleccionados.Add("Gel facial Garnier - $170.00")
        If chkPonds.Checked Then ArticulosSeleccionados.Add("Gel facial Pond's Hydra - $145.00")
        If chkBase.Checked Then ArticulosSeleccionados.Add("Base de maquillaje Maybelline - $301.00")
        If chkRubor.Checked Then ArticulosSeleccionados.Add("Rubor en polvo Covergirl - $200.00")
        If chkMascara.Checked Then ArticulosSeleccionados.Add("Máscara de pestañas Maybelline - $209.00")
        If chkFijador.Checked Then ArticulosSeleccionados.Add("Spray fijador de maquillaje - $155.00")

        ' Abrir Form3 pasando los productos seleccionados
        Dim form3 As New Form3(ArticulosSeleccionados)
        form3.Show()

        ' Ocultar Form2
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
