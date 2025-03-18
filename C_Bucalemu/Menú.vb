Public Class Menú
    Dim compras As New Compras()
    Dim inventario As New Inventario()
    Dim repo As New Reportes()
    Private Sub btn_Compras_Click(sender As Object, e As EventArgs) Handles btn_Compras.Click
        compras.Show()
        Me.Close()
    End Sub

    Private Sub btn_inventario_Click(sender As Object, e As EventArgs) Handles btn_inventario.Click
        inventario.Show()
        Hide()
    End Sub

    Private Sub btn_cubicacion_Click(sender As Object, e As EventArgs) Handles btn_cubicacion.Click
        ''Lo agregaremos después
    End Sub

    Private Sub btn_reportes_Click(sender As Object, e As EventArgs) Handles btn_reportes.Click

    End Sub

    Private Sub Menú_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class