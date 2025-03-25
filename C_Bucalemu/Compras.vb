Public Class Compras
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim material As String = txtMaterial.Text
        Dim cantidad As Integer = nCantidad.Value
        If material <> "" And cantidad > 0 Then
            lstMaterial.Items.Add(material & " " & cantidad.ToString())
            txtMaterial.Clear()
            nCantidad.Value = 0
        Else
            MessageBox.Show("ingrese un material y una cantidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If lstMaterial.SelectedIndex <> -1 Then
            lstMaterial.Items.RemoveAt(lstMaterial.SelectedIndex)
        Else
            MessageBox.Show("Seleccione un material para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub lstMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMaterial.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menú.Show()
        Me.Close()
    End Sub
End Class