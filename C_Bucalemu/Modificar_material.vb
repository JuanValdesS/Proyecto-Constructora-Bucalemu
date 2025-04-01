Imports Newtonsoft.Json.Linq

Public Class mod_material

    Private fcon As New FireSharp.Config.FirebaseConfig With {
    .AuthSecret = "N6kTJwGfYKq9AVH7i3yJ6aTk95ZXw8F3nY1aZFUy",
    .BasePath = "https://db-cbucalemu-b8965-default-rtdb.firebaseio.com/"
}

    Private client As FireSharp.Interfaces.IFirebaseClient
    Private Sub Modificar_material_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtMaterial.Visible = False
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

        Try
            Dim response = client.Get("Inventario")
            If response.Body <> "null" Then
                Dim inventario As Dictionary(Of String, Object) = response.ResultAs(Of Dictionary(Of String, Object))

                ' Llenar el ComboBox con los materiales
                txtbox1.Items.Clear()

                ' Lista para almacenar materiales únicos
                Dim materialesUnicos As New HashSet(Of String)

                ' Recorrer cada material en el inventario y agregar su nombre al ComboBox
                For Each item In inventario
                    Dim datosMaterial As Dictionary(Of String, Object) = CType(Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(item.Value.ToString()), Dictionary(Of String, Object))

                    ' Agregar el nombre del material si existe en el registro
                    If datosMaterial.ContainsKey("Material") Then
                        materialesUnicos.Add(datosMaterial("Material").ToString())
                    End If
                Next

                ' Agregar materiales únicos al ComboBox
                For Each material In materialesUnicos
                    txtbox1.Items.Add(material)
                Next

            End If

        Catch ex As Exception
            MsgBox("Error al cargar materiales: " & ex.Message)
        End Try

        ' Agregar "OTRO" al final
        If Not txtbox1.Items.Contains("OTRO") Then
            txtbox1.Items.Add("OTRO")
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim nombre = txtbox1.Text
            ' Capturar los datos del material
            Dim cantidad = txtCantidad.Text
            ' Obtener la fecha y hora actuales en formato adecuado
            Dim fechaIngreso = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim unidades = ComboBox1.Text

            ' Verificar si se seleccionó "Otro" en el ComboBox
            If nombre = "OTRO" Then
                nombre = txtMaterial.Text.Trim
                txtbox1.Items.Add(nombre)
            End If

            ' Verificar si client está inicializado
            If client Is Nothing Then
                MsgBox("No hay conexión con la base de datos.", MsgBoxStyle.Critical, "error")
                Exit Sub
            End If

            ' Validar que los campos no estén vacíos
            If String.IsNullOrWhiteSpace(nombre) OrElse String.IsNullOrWhiteSpace(cantidad) OrElse String.IsNullOrWhiteSpace(unidades) Then
                MsgBox("Por favor, ingrese nombre, cantidad del material y su unidad", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Crear el objeto con los datos
            Dim material As New Dictionary(Of String, Object) From {
                {"Material", nombre},
                {"cantidad", cantidad},
                {"unidad", unidades},
                {"fecha", fechaIngreso}
            }

            ' Generar un ID único basado en la fecha/hora
            Dim materialId = "mat_" & Date.Now.Ticks

            ' Guardar en Firebase con un ID personalizado
            Dim response = client.Set("Inventario/" & materialId, material)

            ' Mostrar mensaje de éxito
            MsgBox("Material agregado correctamente", MsgBoxStyle.Information)
            txtbox1.Text = ""
            txtCantidad.Text = ""
            txtMaterial.Text = ""
            ComboBox1.Text = ""

            ' Recargar el inventario después de agregar un dato
            CargarInventario

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
                    DataGridView1.Columns.Add("Unidad", "Unidad")
                    DataGridView1.Columns.Add("Fecha", "Fecha de Ingreso")
                End If

                Dim contador As Integer = 1 ' Para numerar las filas

                ' Recorrer cada elemento del inventario en el JObject
                For Each item As KeyValuePair(Of String, JToken) In jsonData
                    ' Obtener los valores, con control de existencia
                    Dim nombre As String = If(item.Value("Material") IsNot Nothing, item.Value("Material").ToString(), "Desconocido")
                    Dim cantidad As String = If(item.Value("cantidad") IsNot Nothing, item.Value("cantidad").ToString(), "0")
                    Dim unidades As String = If(item.Value("unidad") IsNot Nothing, item.Value("unidad").ToString(), "No registrada")
                    Dim fechaIngreso As String = If(item.Value("fecha") IsNot Nothing, item.Value("fecha").ToString(), "No registrada")

                    ' Agregar la fila con los datos al DataGridView
                    DataGridView1.Rows.Add(contador, nombre, cantidad, unidades, fechaIngreso)

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

    Private Sub txtbox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtbox1.SelectedIndexChanged
        If txtbox1.Text = "OTRO" Then
            txtMaterial.Visible = True
        Else
            txtMaterial.Visible = False
        End If
    End Sub
End Class