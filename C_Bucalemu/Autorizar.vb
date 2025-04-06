Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Diagnostics.Eventing.Reader
Imports System.Net

Public Class Autorizar
    Private comprasData As Dictionary(Of String, JArray) ' Guardar datos globalmente
    Private Sub Autorizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' URL de Firebase (ajústala según la estructura de tu base de datos)
        Dim firebaseUrl As String = "https://db-cbucalemu-b8965-default-rtdb.firebaseio.com/Compras.json"

        Try
            Dim client As New WebClient()
            Dim response As String = client.DownloadString(firebaseUrl)

            ' Validar si la respuesta está vacía o es "null"
            If String.IsNullOrEmpty(response) OrElse response = "null" Then
                MessageBox.Show("No hay solicitudes pendientes.")
                Exit Sub
            End If
            Try

                comprasData = JsonConvert.DeserializeObject(Of Dictionary(Of String, JArray))(response)


                If comprasData Is Nothing OrElse comprasData.Count = 0 Then
                    MessageBox.Show("No hay solicitudes pendientes.")
                    Exit Sub

                End If

            Catch ex As Exception
                MessageBox.Show("Error al deserializar los datos: " & ex.Message)
                Exit Sub

            End Try

            ' Limpiar DataGridView
            ConfigurarEstiloDataGridView()
            dgAutorizar.Rows.Clear()
            dgAutorizar.Columns.Clear()

            ' Agregar columnas (ajustarlas según la estructura)
            dgAutorizar.Columns.Add("RealID", "ID Real")
            dgAutorizar.Columns("RealID").Visible = False ' Ocultar la columna en la interfaz
            dgAutorizar.Columns.Add("ID", "ID de Solicitud")
            dgAutorizar.Columns.Add("Materiales", "Materiales")
            dgAutorizar.Columns.Add("Fecha", "Fecha de Ingreso")
            Dim contador As Integer = 1


            For Each compra In comprasData

                Dim solicitud As String = "Solicitud " + contador.ToString()
                Dim solicitudID As String = compra.Key

                Dim fecha As String = ""

                ' Convertir la sublista de materiales en un JArray
                Dim listaMateriales As JArray = compra.Value

                Dim materialesTexto As New List(Of String)
                ' Recorrer cada material en la lista
                For Each material In listaMateriales
                    Dim datosMaterial As JObject = JObject.Parse(material.ToString())
                    Dim nombreMaterial As String = datosMaterial("Material").ToString()
                    Dim cantidad As String = datosMaterial("Cantidad").ToString()
                    Dim unidad As String = datosMaterial("Unidad").ToString()
                    materialesTexto.Add($"{nombreMaterial} {cantidad} {unidad}")
                    fecha = datosMaterial("Fecha").ToString()
                Next
                Dim materialesTextoTexto As String = String.Join(", ", materialesTexto)


                contador += 1
                ' Agregar la solicitud con todos sus materiales en una sola fila
                dgAutorizar.Rows.Add(solicitudID, solicitud, materialesTextoTexto, fecha)
            Next



        Catch ex As Exception
            MessageBox.Show("Error al obtener los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub btnMenu_Cdjlick(sender As Object, e As EventArgs) Handles btnMenu.Click
        Menú.Show()
        Me.Close()

    End Sub
    Private Sub ConfigurarEstiloDataGridView()
        ''Elementos que hacen que el datagrid se vea mas formal y con mas diseño
        With dgAutorizar
            ' Establecer el color de fondo y alternar filas en gris claro
            .BackgroundColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

            ' Cambiar el color de los encabezados de columna
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)

            ' Borde de celda y alineación
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Ajustar tamaño de columnas automáticamente
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            ' Deshabilitar la edición de celdas
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

            ' Cambiar estilo del grid
            .BorderStyle = BorderStyle.Fixed3D
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' Verificar que haya datos en el DataGridView
        If dgAutorizar.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para enviar.")
            Exit Sub
        End If
        ' Verificar que se haya seleccionado una fila   
        If dgAutorizar.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor seleccione una solicitud.")
            Exit Sub
        End If


        ' Obtener la solicitud seleccionada
        Dim row As DataGridViewRow = dgAutorizar.SelectedRows(0)
        Dim solicitudID As String = row.Cells("RealID").Value.ToString()
        ' Dim listaMateriales As JArray = comprasData(solicitudID)

        ' URL de Firebase para Inventario
        Dim firebaseInventarioUrl As String = "https://db-cbucalemu-b8965-default-rtdb.firebaseio.com/Inventario.json"
        Dim firebaseComprasUrl As String = $"https://db-cbucalemu-b8965-default-rtdb.firebaseio.com/Compras/{solicitudID}.json"



        Try
            Dim client As New WebClient()
            Dim inventarioResponse As String = client.DownloadString(firebaseInventarioUrl)
            Dim inventarioData As Dictionary(Of String, JObject) = JsonConvert.DeserializeObject(Of Dictionary(Of String, JObject))(inventarioResponse)

            Dim materiales As String = row.Cells("Materiales").Value.ToString()
            Dim Texto() As String = materiales.Split(",")
            For Each palabra In Texto
                Dim Material() As String = palabra.Trim().Split(" ")
                Dim Nombre As String = Material(0).ToUpper()
                Dim Cantidad As String = Material(1)
                Dim unidad As String = Material(2)

                ' Verificar si el material ya existe en el inventario
                Dim materialEncontrado As Boolean = False
                For Each item In inventarioData
                    Dim datosMaterial As JObject = item.Value
                    If datosMaterial("Material").ToString() = Nombre AndAlso datosMaterial("unidad").ToString() = unidad Then
                        ' Actualizar la cantidad
                        datosMaterial("cantidad") = (Integer.Parse(datosMaterial("cantidad").ToString()) + Cantidad).ToString()
                        materialEncontrado = True
                        Exit For
                    End If
                Next
                ' Si no se encontró, agregar nuevo material
                If Not materialEncontrado Then
                    Dim nuevoMaterial As New JObject()
                    nuevoMaterial("Material") = Nombre
                    nuevoMaterial("cantidad") = Cantidad.ToString()
                    nuevoMaterial("unidad") = unidad
                    nuevoMaterial("fecha") = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")


                    inventarioData($"mat_{Nombre.Substring(0, 3).ToUpper()}000001") = nuevoMaterial
                End If
            Next
            ' Actualizar Firebase con los nuevos datos
            Dim updateJson As String = JsonConvert.SerializeObject(inventarioData)
            client.UploadString(firebaseInventarioUrl, "PUT", updateJson)
            ' Eliminar la solicitud aceptada de Compras
            client.UploadString(firebaseComprasUrl, "DELETE", String.Empty)
            ' Recargar los datos del DataGridView para reflejar los cambios
            Autorizar_Load(Me, EventArgs.Empty)


            MessageBox.Show("Inventario actualizado correctamente.")

        Catch ex As Exception
            MessageBox.Show("Error al actualizar el inventario: " & ex.Message)
        End Try



    End Sub

    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click
        ' Verificar que haya datos en el DataGridView
        If dgAutorizar.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para eliminar.")
            Exit Sub
        End If
        ' Verificar que se haya seleccionado una fila   
        If dgAutorizar.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor seleccione una solicitud.")
            Exit Sub
        End If

        ' Obtener la solicitud seleccionada
        Dim row As DataGridViewRow = dgAutorizar.SelectedRows(0)
        Dim solicitudID As String = row.Cells("RealID").Value.ToString()
        Dim firebaseComprasUrl As String = $"https://db-cbucalemu-b8965-default-rtdb.firebaseio.com/Compras/{solicitudID}.json"
        Try
            Dim client As New WebClient()
            client.UploadString(firebaseComprasUrl, "DELETE", String.Empty)
            ' Eliminar la fila del DataGridView y recargar la lista actualizada
            dgAutorizar.Rows.Remove(row)
            ' Mensaje de confirmación
            MessageBox.Show($"La solicitud con ID {solicitudID} fue rechazada correctamente.")

        Catch ex As Exception
            MessageBox.Show("Error al eliminar la solicitud: " & ex.Message)
        End Try

        ' Recargar los datos del DataGridView para reflejar los cambios
    End Sub
End Class