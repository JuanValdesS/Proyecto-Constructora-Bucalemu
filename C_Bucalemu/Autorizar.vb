Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net

Public Class Autorizar
    Private comprasData As Dictionary(Of String, JArray) ' Guardar datos globalmente
    Private Sub Autorizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' URL de Firebase (ajústala según la estructura de tu base de datos)
        Dim firebaseUrl As String = "https://db-cbucalemu-b8965-default-rtdb.firebaseio.com/Compras.json"

        Try
            Dim client As New WebClient()
            Dim response As String = client.DownloadString(firebaseUrl)
            ' Dim compras As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
            comprasData = JsonConvert.DeserializeObject(Of Dictionary(Of String, JArray))(response)


            ' Limpiar DataGridView
            ConfigurarEstiloDataGridView()
            dgAutorizar.Rows.Clear()
            dgAutorizar.Columns.Clear()

            ' Agregar columnas (ajustarlas según la estructura)
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
                Dim materialesTexto As String = ""

                ' Recorrer los materiales dentro de la solicitud
                For Each material In listaMateriales
                    Dim datosMaterial As JObject = JObject.Parse(material.ToString())
                    Dim nombreMaterial As String = datosMaterial("Material").ToString()
                    Dim cantidad As String = datosMaterial("Cantidad").ToString()
                    Dim unidad As String = datosMaterial("Unidad").ToString()
                    materialesTexto &= $"{nombreMaterial} ({cantidad} {unidad}), "
                    fecha = datosMaterial("Fecha").ToString()
                Next


                contador += 1

                If materialesTexto.Length > 2 Then
                    materialesTexto = materialesTexto.Substring(0, materialesTexto.Length - 2)
                End If


                ' Agregar la solicitud con todos sus materiales en una sola fila
                dgAutorizar.Rows.Add(solicitud, materialesTexto, fecha)
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

        ' Obtener la solicitud seleccionada
        Dim row As DataGridViewRow = dgAutorizar.SelectedRows(0)
        Dim solicitudID As String = row.Cells("ID").Value.ToString()
        ' Dim listaMateriales As JArray = comprasData(solicitudID)

        Dim materiales As String = row.Cells("Materiales").Value.ToString()
        Dim Texto() As String = materiales.Split(",")
        For Each letra In Texto
            MsgBox(letra)
        Next






    End Sub




End Class