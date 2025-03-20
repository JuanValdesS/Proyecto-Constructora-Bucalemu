Imports Newtonsoft.Json.Linq

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
                CargarInventario()
            Else
                MsgBox("Error al conectar con la base de datos", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox("Error de conexión: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

            ' Capturar los datos del material
            Dim nombre As String = txtMaterial.Text
            Dim cantidad As String = txtCantidad.Text
            ' Obtener la fecha y hora actuales en formato adecuado
            Dim fechaIngreso As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            ' Verificar si client está inicializado
            If client Is Nothing Then
                MsgBox("No hay conexión con la base de datos.", MsgBoxStyle.Critical, "error")
                Exit Sub
            End If

            ' Validar que los campos no estén vacíos
            If String.IsNullOrWhiteSpace(nombre) OrElse String.IsNullOrWhiteSpace(cantidad) Then
                MsgBox("Por favor, ingrese nombre y cantidad del material.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Crear el objeto con los datos
            Dim material As New Dictionary(Of String, Object) From {
                {"Material", txtMaterial.Text},
                {"cantidad", txtCantidad.Text},
                {"fecha", fechaIngreso}
            }

            ' Generar un ID único basado en la fecha/hora
            Dim materialId As String = "mat_" & DateTime.Now.Ticks

            ' Guardar en Firebase con un ID personalizado
            Dim response = client.Set("Inventario/" & materialId, material)

            ' Mostrar mensaje de éxito
            MsgBox("Material agregado correctamente", MsgBoxStyle.Information)
            txtCantidad.Text = ""
            txtMaterial.Text = ""

            ' Recargar el inventario después de agregar un dato
            CargarInventario()

        Catch ex As Exception
            MsgBox("Error al agregar material: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub CargarInventario()
        Try
            ' Obtener los datos desde Firebase
            Dim respuesta = client.Get("Inventario")

            ' Verificar que la respuesta no sea nula
            If respuesta.Body IsNot "null" Then
                ' Convertir la respuesta a un JObject (Newtonsoft.Json.Linq)
                Dim jsonData As JObject = JObject.Parse(respuesta.Body)

                ' Limpiar el DataGridView antes de cargar los datos
                ConfigurarEstiloDataGridView()
                DataGridView1.Rows.Clear()
                DataGridView1.Columns.Clear()

                ' Definir columnas si no existen
                If DataGridView1.Columns.Count = 0 Then
                    DataGridView1.Columns.Add("ID", "N°")
                    DataGridView1.Columns.Add("Nombre", "Nombre del Material")
                    DataGridView1.Columns.Add("Cantidad", "Cantidad")
                    DataGridView1.Columns.Add("Fecha", "Fecha de Ingreso")
                End If

                Dim contador As Integer = 1 ' Para numerar las filas

                ' Recorrer cada elemento del inventario en el JObject
                For Each item As KeyValuePair(Of String, JToken) In jsonData
                    ' Obtener los valores, con control de existencia
                    Dim nombre As String = If(item.Value("Material") IsNot Nothing, item.Value("Material").ToString(), "Desconocido")
                    Dim cantidad As String = If(item.Value("cantidad") IsNot Nothing, item.Value("cantidad").ToString(), "0")
                    Dim fechaIngreso As String = If(item.Value("fecha") IsNot Nothing, item.Value("fecha").ToString(), "No registrada")

                    ' Agregar la fila con los datos al DataGridView
                    DataGridView1.Rows.Add(contador, nombre, cantidad, fechaIngreso)

                    ' Incrementar contador para la numeración
                    contador += 1
                Next
            End If
        Catch ex As Exception
            MsgBox("Error al cargar inventario: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ConfigurarEstiloDataGridView()
        ''Elementos que hacen que el datagrid se vea mas formal y con mas diseño
        With DataGridView1
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
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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

    Private Sub txtMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaterial.KeyPress
        ' Convertir el carácter presionado a mayúscula
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        ' Convertir el carácter presionado a mayúscula
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Dim sh As New Menú()
        Me.Close()
        sh.Show()
    End Sub
End Class