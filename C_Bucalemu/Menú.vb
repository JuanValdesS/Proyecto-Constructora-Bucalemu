﻿Public Class Menú
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
End Class