Imports Newtonsoft.Json
Imports System.Net

Public Class Autorizar
    Private Sub Autorizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSolicitudes()
    End Sub

    ' Método para cargar las solicitudes
    Private Sub CargarSolicitudes()
        Dim firebaseUrl As String = "https://db-cbucalemu-b8965-default-rtdb.firebaseio.com/Compras.json"

        Try
            Dim client As New WebClient()
            Dim response As String = client.DownloadString(firebaseUrl)

            ' Deserializar JSON en un diccionario
            Dim solicitudes As Dictionary(Of String, Object) =
                JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)

            ' Limpiar DataGridView
            dgAutorizar.Rows.Clear()
            dgAutorizar.Columns.Clear()

            ' Definir columnas si no existen
            If dgAutorizar.Columns.Count = 0 Then
                dgAutorizar.Columns.Add("ID", "N°")
                dgAutorizar.Columns.Add("Solicitud", "Código de Solicitud")
                dgAutorizar.Columns.Add("CantidadItems", "Cantidad de Ítems")
            End If

            Dim contador As Integer = 1
            For Each solicitud In solicitudes
                Dim claveSolicitud As String = solicitud.Key
                Dim subLista As Dictionary(Of String, Object) =
                    JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(solicitud.Value.ToString())

                Dim cantidadItems As Integer = subLista.Count
                dgAutorizar.Rows.Add(contador, claveSolicitud, cantidadItems)
                contador += 1
            Next

        Catch ex As Exception
            MessageBox.Show("Error al obtener las solicitudes: " & ex.Message)
        End Try
    End Sub

    ' Método para mostrar detalles cuando se hace clic en una fila
    Private Sub dgAutorizar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAutorizar.CellClick
        If e.RowIndex >= 0 Then
            Dim codigoSolicitud As String = dgAutorizar.Rows(e.RowIndex).Cells("Solicitud").Value.ToString()

        End If
    End Sub


End Class