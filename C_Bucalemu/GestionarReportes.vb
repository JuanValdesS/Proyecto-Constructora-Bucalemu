Imports Newtonsoft.Json.Linq

Public Class GestionarReportes
    Private fcon As New FireSharp.Config.FirebaseConfig With {
    .AuthSecret = "N6kTJwGfYKq9AVH7i3yJ6aTk95ZXw8F3nY1aZFUy",
    .BasePath = "https://db-cbucalemu-b8965-default-rtdb.firebaseio.com/"
}

    Private client As FireSharp.Interfaces.IFirebaseClient

    Private Sub GestionarReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            client = New FireSharp.FirebaseClient(fcon)

            If client IsNot Nothing Then
                CargarInventario()
            Else
                MsgBox("Error al conectar con la base de datos", MsgBoxStyle.Critical, "Error")
            End If

        Catch ex As Exception
            MsgBox("Error de conexión: " & ex.Message, MsgBoxStyle.Critical, "Error")
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
                    data_repo.Columns.Add("Titulo del reporte", "Titulo")
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
                data_repo.Columns.Add("Titulo del reporte", "Titulo")
                data_repo.Columns.Add("Reporte", "Descripción del reporte")
            End If

            Dim contador As Integer = 1
            For Each item As KeyValuePair(Of String, JToken) In jsonData
                Dim titulo As String = If(item.Value("Titulo del correo") IsNot Nothing, item.Value("Titulo del correo").ToString(), "Sin título")
                Dim descripcion As String = If(item.Value("Descripcion") IsNot Nothing, item.Value("Descripcion").ToString(), "No registrada")

                data_repo.Rows.Add(contador, titulo, descripcion)
                contador += 1
            Next

        Catch ex As Exception
            MsgBox("Error al cargar los reportes: " & ex.Message, MsgBoxStyle.Critical, "Error")
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sh As New Menú()
        Me.Close()
        sh.Show()
    End Sub

    Private Sub data_repo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_repo.CellContentClick

    End Sub
End Class