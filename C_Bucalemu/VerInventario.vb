Imports Newtonsoft.Json
Imports System.Net

Public Class VerInventario
    Private Sub VerInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Puede ir lógica adicional si es necesario
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim firebaseUrl As String = "https://db-cbucalemu-b8965-default-rtdb.firebaseio.com/Inventario.json"

        Try
            Dim client As New WebClient()
            Dim response As String = client.DownloadString(firebaseUrl)

            ' Deserializar JSON a un diccionario
            Dim inventario As Dictionary(Of String, Material) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Material))(response)


            ' Limpiar la ListBox antes de cargar los datos
            lstMateriales.Items.Clear()

            ' Agregar elementos a la ListBox con el formato deseado
            For Each item In inventario
                lstMateriales.Items.Add(item.Value.Material & " " & item.Value.cantidad)
            Next

        Catch ex As Exception
            MessageBox.Show("Error al obtener los datos: " & ex.Message)
        End Try
    End Sub
End Class

' Definir la clase Material para mapear los datos de Firebase
Public Class Material
    Public Property Material As String
    Public Property cantidad As String
    Public Property fecha As String
End Class