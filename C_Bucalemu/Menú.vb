Public Class Menú
    Dim compra As New Compras()
    Dim mod_material As New mod_material()
    Dim repo As New Reportes()
    Dim VerInventario As New Inventario()
    Dim Autorizar As New Autorizar()
    Private Sub btn_Compras_Click(sender As Object, e As EventArgs) Handles btn_Compras.Click
        compra.Show()
        Me.Close()
    End Sub

    Private Sub btn_inventario_Click(sender As Object, e As EventArgs) Handles btn_inventario.Click
        mod_material.Show()
        Hide()
    End Sub

    Private Sub btn_cubicacion_Click(sender As Object, e As EventArgs) Handles btn_cubicacion.Click
        ''Lo agregaremos después
    End Sub

    Private Sub btn_reportes_Click(sender As Object, e As EventArgs) Handles btn_reportes.Click

    End Sub

    Private Sub Menú_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim sh As New Login()
        ' Mostrar cuadro de mensaje con opciones Sí y No
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario selecciona "Sí", proceder a redirigir al login
        If resultado = DialogResult.Yes Then
            ' Aquí debes redirigir al formulario de login
            ' Por ejemplo, si tu formulario de login se llama "FormLogin"
            Me.Close() ' Oculta el formulario actual
            sh.Show() ' Muestra el formulario de login
        End If
    End Sub

    Private Sub btnVerInventario_Click(sender As Object, e As EventArgs) Handles btnVerInventario.Click
        VerInventario.Show()
        Me.Close()

    End Sub

    Private Sub btnAutorizar_Click(sender As Object, e As EventArgs) Handles btnAutorizar.Click
        Autorizar.Show()
        Me.Close()
    End Sub
End Class