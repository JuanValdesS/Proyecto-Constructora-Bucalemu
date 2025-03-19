Public Class Inventario

    Private fcon As New FireSharp.Config.FirebaseConfig With {
    .AuthSecret = "N6kTJwGfYKq9AVH7i3yJ6aTk95ZXw8F3nY1aZFUy",
    .BasePath = "https://db-cbucalemu-b8965-default-rtdb.firebaseio.com/"
}

    Private client As FireSharp.Interfaces.IFirebaseClient
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)

            If client IsNot Nothing Then
                MessageBox.Show("Conectado a Firebase correctamente")
            Else
                MessageBox.Show("Error al conectar con Firebase")
            End If

        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            ' Verificar si client está inicializado
            If client Is Nothing Then
                MessageBox.Show("No hay conexión con Firebase.")
                Exit Sub
            End If

            ' Crear el objeto con los datos
            Dim material As New Dictionary(Of String, Object) From {
                {"nombre", txtMaterial.Text},
                {"cantidad", txtCantidad.Text}
            }

            ' Generar un ID único basado en la fecha/hora
            Dim materialId As String = "mat_" & DateTime.Now.Ticks

            ' Guardar en Firebase con un ID personalizado
            Dim response = client.Set("Inventario/" & materialId, material)

            ' Mostrar mensaje de éxito
            MessageBox.Show("Material agregado correctamente")

            ' Recargar el inventario después de agregar un dato
            CargarInventario()

        Catch ex As Exception
            MessageBox.Show("Error al agregar material: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarInventario()
        Try
            Dim respuesta = client.Get("Inventario")

            If respuesta.Body IsNot Nothing AndAlso respuesta.Body <> "null" Then
                Dim inventario = respuesta.ResultAs(Of Dictionary(Of String, Object))

                DataGridView1.Rows.Clear()

                If inventario IsNot Nothing Then
                    For Each item In inventario
                        Dim datos = CType(item.Value, Dictionary(Of String, Object))
                        DataGridView1.Rows.Add(datos("nombre"), datos("cantidad"))
                    Next
                End If
            Else
                MessageBox.Show("No hay datos en el inventario.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar inventario: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class