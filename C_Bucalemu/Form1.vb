Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class Form1

    Dim sh As New Form2()
    Dim firebaseApiKey As String = "AIzaSyAGoZxK9tfLNIxHHsmiQQAIq_k2TnscOro"
    Private Function FirebaseRequest(ByVal url As String, ByVal jsonData As String) As String
        Try
            Dim request As WebRequest = WebRequest.Create(url)
            request.Method = "POST"
            request.ContentType = "application/json"

            Dim data As Byte() = Encoding.UTF8.GetBytes(jsonData)
            request.ContentLength = data.Length

            Using stream As Stream = request.GetRequestStream()
                stream.Write(data, 0, data.Length)
            End Using

            Dim response As WebResponse = request.GetResponse()
            Using reader As New StreamReader(response.GetResponseStream())
                Return reader.ReadToEnd()
            End Using
        Catch ex As WebException
            Return "Error: " & ex.Message
        End Try
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtUsuario.Text
        Dim password As String = txtPassword.Text

        If email = "" Or password = "" Then
            lblMensaje.Text = "Ingresa correo y contraseña"
            Return
        End If

        Dim url As String = "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=" & firebaseApiKey
        Dim json As String = "{""email"":""" & email & """, ""password"":""" & password & """, ""returnSecureToken"":true}"

        Dim response As String = FirebaseRequest(url, json)
        If response.Contains("idToken") Then
            MessageBox.Show("¡¡Inicio de sesión exitoso!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsuario.Clear()
            txtPassword.Clear()
            sh.Show()
            Me.Hide()

        Else
            MessageBox.Show("Error en el inicio de sesión", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Clear()
            txtPassword.Clear()
            txtUsuario.Focus()
        End If
    End Sub

    Private Sub btnResgistrar_Click(sender As Object, e As EventArgs) Handles btnResgistrar.Click
        Dim email As String = txtUsuario.Text
        Dim password As String = txtPassword.Text

        If email = "" Or password = "" Then
            lblMensaje.Text = "Ingresa correo y contraseña"
            Return
        End If

        Dim url As String = "https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=" & firebaseApiKey
        Dim json As String = "{""email"":""" & email & """, ""password"":""" & password & """, ""returnSecureToken"":true}"

        Dim response As String = FirebaseRequest(url, json)
        If response.Contains("idToken") Then
            MessageBox.Show("¡¡Usuario registrado correctamente!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsuario.Clear()
            txtPassword.Clear()
        Else
            MessageBox.Show("Error en el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Clear()
            txtPassword.Clear()
        End If
    End Sub
End Class