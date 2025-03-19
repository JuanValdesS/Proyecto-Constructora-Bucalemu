Public Class Compras
    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles nCantidad.ValueChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMaterial.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lstMaterial.SelectedIndex <> -1 Then
            lstMaterial.Items.RemoveAt(lstMaterial.SelectedIndex)
        Else
            MessageBox.Show("Seleccione un material para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class