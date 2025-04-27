Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Newtonsoft.Json.Linq
Imports System.Net.Mail
Imports System.Net

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

        Dim observacion As String = txtObservacion.Text.Trim()
        Dim email As String = TxtEmail.Text.Trim()
        Dim reporteGuardado As Boolean = False
        Dim emailEnviado As Boolean = False

        'validaciones
        If client Is Nothing Then
            MsgBox("Error de conexión a la base de datos.", MsgBoxStyle.Critical)
            Return
        End If

        If String.IsNullOrEmpty(observacion) Then
            MsgBox("Por favor, ingrese un reporte.", MsgBoxStyle.Exclamation, "Advertencia")
            txtObservacion.Focus()
            Return
        End If

        If String.IsNullOrEmpty(email) Then
            MsgBox("Por favor, ingrese el correo electrónico del destinatario.", MsgBoxStyle.Exclamation, "Advertencia")
            TxtEmail.Focus()
            Return
        End If

        Try
            Dim direcccionEmail As New MailAddress(email)
        Catch exFormat As FormatException
            MsgBox("El formato del correo electrónico es inválido.", MsgBoxStyle.Exclamation, "Advertencia")
            TxtEmail.Focus()
            Exit Sub
        Catch ex As Exception
            MsgBox("Error al validar el correo electrónico: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub

        End Try

        Dim reporteid As String = "Reporte_" & Date.Now.ToString("yyyyMMdd_HHmmssfff")

        ' guardar el reporte en firebase
        Try
            Dim reporte As New Dictionary(Of String, Object) From {
                {"Reporte", observacion},
                {"Email", email},
                {"Fecha", Date.Now.ToString("dd/MM/yyyy HH:mm:ss")}
            }
            client.Set("Reportes/" & reporteid, reporte)
            reporteGuardado = True
        Catch fbEx As Exception
            MsgBox("Error al guardar el reporte en Firebase: " & fbEx.Message, MsgBoxStyle.Critical)
            Exit Sub

        End Try

        'enviar el reporte por correo electronico
        If reporteGuardado Then
            Try
                'configuracion SMTP
                Dim smtpServer As String = "smtp.live.com"
                Dim smtpPort As Integer = 587
                Dim direccionEnvio As String = "diegovasquezvaldivia@hotmail.com"
                Dim contrasena As String = "pzogumuramucgbbu"

                Dim mensaje As New MailMessage()
                mensaje.From = New MailAddress(direccionEnvio, "Constructora bucalemu - reportes")
                mensaje.To.Add(email)
                mensaje.Subject = "Nuevo reporte " & Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
                mensaje.Body = "Se ha registrado un nuevo reporte: " & observacion & vbCrLf & vbCrLf &
                               "Fecha: " & Date.Now.ToString("dd/MM/yyyy HH:mm:ss") & vbCrLf &
                               "Por favor, revise la aplicación para más detalles."
                mensaje.IsBodyHtml = False

                Dim smtp As New SmtpClient(smtpServer)
                smtp.Port = smtpPort
                smtp.Credentials = New NetworkCredential(direccionEnvio, contrasena)
                smtp.EnableSsl = True

                smtp.Send(mensaje)
                emailEnviado = True

            Catch mensajeEx As SmtpException
                MsgBox($"Reporte guardado en la base de datos, PERO ocurrió un error al enviar el correo:{vbCrLf}{vbCrLf}" &
                   $"Mensaje: {mensajeEx.Message}{vbCrLf}" &
                   $"Código SMTP: {mensajeEx.StatusCode}{vbCrLf}{vbCrLf}" &
                   "Verifica la configuración del servidor, puerto, TUS CREDENCIALES (¿Contraseña de Aplicación?) y la conexión a internet.", MsgBoxStyle.Critical, "Error de Envío de Correo")
            Catch mensajeex As Exception
                MsgBox($"Reporte guardado en la base de datos, PERO ocurrió un error al intentar enviar el correo:{vbCrLf}{vbCrLf}" &
                    $"Mensaje: {mensajeex.Message}", MsgBoxStyle.Critical, "Error de Correo")


            End Try

        End If

        If reporteGuardado AndAlso emailEnviado Then
            MsgBox("Reporte guardado y enviado por correo electrónico con éxito.", MsgBoxStyle.Information, "Éxito")
            txtObservacion.Clear()
            TxtEmail.Clear()
            CargarInventario()
        End If





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