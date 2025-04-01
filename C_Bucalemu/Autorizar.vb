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




End Class