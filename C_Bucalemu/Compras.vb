Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq
Imports System.Text
Imports Newtonsoft.Json
Imports System.Net

Public Class Compras
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim material As String = txtMaterial.Text
        Dim cantidad As Integer = nCantidad.Value
        Dim unidad As String = cbUnidad.Text
        Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") ' Fecha actual

        ' Verificar que no haya campos vacíos
        If String.IsNullOrWhiteSpace(material) OrElse String.IsNullOrWhiteSpace(unidad) Then
            MessageBox.Show("Por favor, ingrese todos los campos.")
            Return
        End If

        ' Verificar si las columnas están definidas (solo la primera vez)
        If dgCompras.Columns.Count = 0 Then
            dgCompras.Columns.Add("ID", "N°")
            dgCompras.Columns.Add("Nombre", "Nombre del Material")
            dgCompras.Columns.Add("Cantidad", "Cantidad")
            dgCompras.Columns.Add("Unidad", "Unidad")
            dgCompras.Columns.Add("Fecha", "Fecha de Ingreso")
        End If

        ' Agregar una nueva fila al DataGridView
        Dim rowIndex As Integer = dgCompras.Rows.Add() ' Añadir una nueva fila
        Dim row As DataGridViewRow = dgCompras.Rows(rowIndex)

        ' Asignar los valores a las celdas de la nueva fila
        row.Cells("ID").Value = rowIndex + 1 ' Número de fila
        row.Cells("Nombre").Value = material
        row.Cells("Cantidad").Value = cantidad
        row.Cells("Unidad").Value = unidad
        row.Cells("Fecha").Value = fecha

        ' Limpiar los controles de entrada después de agregar
        txtMaterial.Clear()
        nCantidad.Value = 0
        cbUnidad.SelectedIndex = -1
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Verificar que haya una fila seleccionada
        If dgCompras.SelectedRows.Count > 0 Then
            ' Obtener el índice de la fila seleccionada y eliminarla
            dgCompras.Rows.RemoveAt(dgCompras.SelectedRows(0).Index)

            ' Llamar a la función para actualizar los IDs
            ReindexarIDs()
        Else
            MessageBox.Show("Por favor, seleccione una fila para eliminar.")
        End If
    End Sub

    Private Sub ReindexarIDs()
        ' Recorrer todas las filas y actualizar el número de ID
        For i As Integer = 0 To dgCompras.Rows.Count - 1
            dgCompras.Rows(i).Cells("ID").Value = i + 1 ' Asigna un ID consecutivo
        Next
    End Sub

    Private Sub ConfigurarEstiloDataGridView()
        ''Elementos que hacen que el datagrid se vea mas formal y con mas diseño
        With dgCompras
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menú.Show()
        Me.Close()
    End Sub




    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarEstiloDataGridView()
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        ' Verificar que haya datos en el DataGridView
        If dgCompras.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para enviar.")
            Exit Sub
        End If

        ' URL de la base de datos en Firebase (reemplaza con tu URL real)
        Dim firebaseUrl As String = "https://db-cbucalemu-b8965-default-rtdb.firebaseio.com/Compras.json"

        ' Crear una lista para almacenar los datos
        Dim listaCompras As New List(Of Object)

        ' Recorrer las filas del DataGridView y agregar los datos a la lista
        For Each row As DataGridViewRow In dgCompras.Rows
            ' Verificar que la fila no esté vacía
            If Not row.IsNewRow Then
                Dim compra As New Dictionary(Of String, Object) From {
                    {"ID", row.Cells("ID").Value},
                    {"Material", row.Cells("Nombre").Value},
                    {"Cantidad", row.Cells("Cantidad").Value},
                    {"Unidad", row.Cells("Unidad").Value},
                    {"Fecha", row.Cells("Fecha").Value}
                }
                listaCompras.Add(compra)
            End If
        Next

        ' Convertir la lista a JSON
        Dim jsonData As String = JsonConvert.SerializeObject(listaCompras, Formatting.Indented)

        ' Enviar los datos a Firebase
        Try
            Dim client As New WebClient()
            client.Headers(HttpRequestHeader.ContentType) = "application/json"
            Dim response As String = client.UploadString(firebaseUrl, "POST", jsonData)

            MessageBox.Show("Datos enviados correctamente a Firebase.")
        Catch ex As Exception
            MessageBox.Show("Error al enviar datos: " & ex.Message)
        End Try
    End Sub
End Class