Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Newtonsoft.Json.Linq

Public Class Reportes

    Private fcon As New FireSharp.Config.FirebaseConfig With {
    .AuthSecret = "N6kTJwGfYKq9AVH7i3yJ6aTk95ZXw8F3nY1aZFUy",
    .BasePath = "https://db-cbucalemu-b8965-default-rtdb.firebaseio.com/"
}

    Private client As FireSharp.Interfaces.IFirebaseClient
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            client = New FireSharp.FirebaseClient(fcon)

            If client IsNot Nothing Then
                CargarInventario()
            Else
                MsgBox("Error al conectar con la base de datos", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox("Error de conexión: " & ex.Message, MsgBoxStyle.Critical)
        End Try


        ' Ocultar el botón por defecto
        data_repo.Visible = False

        ' Obtener el rol del usuario autenticado
        Dim rolUsuario As String = My.Settings.RolUsuario

        ' Mostrar el botón solo si el usuario es Administrador
        If rolUsuario = "Administrador" Then
            data_repo.Visible = True
        End If

        If rolUsuario = "Jefe" Then
            data_repo.Visible = True
        End If
    End Sub
    Private Sub btn_reporte_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click

        Try
            Dim fechareporte = Date.Now.ToString(" dd/MM/yyyy-HH:mm")
            Dim observacion = txtObservacion.Text
            Dim reporteid = "Reporte" & fechareporte

            If String.IsNullOrWhiteSpace(observacion) Then
                MsgBox("Por favor, ingrese su reporte", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If

            ' Verificar si client está inicializado
            If client Is Nothing Then
                MsgBox("No hay conexión con la base de datos.", MsgBoxStyle.Critical, "error")
                Exit Sub
            End If

            ' Crear el objeto con los datos
            Dim reporte As New Dictionary(Of String, Object) From {
                {"Reporte", observacion},
                {"Fecha", Date.Now.ToString("dd-MM-yyyy HH:mm:ss")}
            }


            ' Guardar en Firebase con el nuevo ID
            client.Set("Reportes/" & reporteid, reporte)

            ' Mostrar mensaje de éxito
            MsgBox("Reporte agregado correctamente", MsgBoxStyle.Information, "Éxito")

            'Limpiamos los campos
            txtObservacion.Text = ""

            ' Recargar el reportes después de agregar un dato
            CargarInventario()

        Catch ex As Exception
            MsgBox("Error al agregar Reporte: " & ex.Message, MsgBoxStyle.Critical, "error")
        End Try


    End Sub
    Private Sub CargarInventario()
        Try
            Dim respuesta = client.Get("Reportes")

            If String.IsNullOrEmpty(respuesta.Body) OrElse respuesta.Body = "null" Then
                data_repo.Rows.Clear()
                data_repo.Columns.Clear()

                If data_repo.Columns.Count = 0 Then
                    data_repo.Columns.Add("ID", "N°")
                    data_repo.Columns.Add("Reporte", "Descripción del reporte")
                End If

                MsgBox("No hay reportes disponibles.", MsgBoxStyle.Information, "Aviso")
                Return
            End If

            Dim jsonData As JObject = JObject.Parse(respuesta.Body)

            ConfigurarEstiloDataGridView()
            data_repo.Rows.Clear()
            data_repo.Columns.Clear()

            If data_repo.Columns.Count = 0 Then
                data_repo.Columns.Add("ID", "N°")
                data_repo.Columns.Add("Reporte", "Descripción del reporte")
            End If

            Dim contador As Integer = 1
            For Each item As KeyValuePair(Of String, JToken) In jsonData
                Dim reporte As String = If(item.Value("Reporte") IsNot Nothing, item.Value("Reporte").ToString(), "No registrada")
                data_repo.Rows.Add(contador, reporte)
                contador += 1
            Next

        Catch ex As Exception
            MsgBox("Error al cargar los reportes: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub ConfigurarEstiloDataGridView()
        ''Elementos que hacen que el datagrid se vea mas formal y con mas diseño
        With data_repo
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
        Dim sh As New Menú()
        Me.Close()
        sh.Show()

    End Sub
End Class