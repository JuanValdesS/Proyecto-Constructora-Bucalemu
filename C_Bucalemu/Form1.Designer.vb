<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnLogin = New Button()
        btnResgistrar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtUsuario = New TextBox()
        txtPassword = New TextBox()
        lblMensaje = New Label()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Cursor = Cursors.Hand
        btnLogin.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic)
        btnLogin.Location = New Point(306, 292)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(104, 69)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnResgistrar
        ' 
        btnResgistrar.Cursor = Cursors.Hand
        btnResgistrar.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic)
        btnResgistrar.Location = New Point(458, 292)
        btnResgistrar.Name = "btnResgistrar"
        btnResgistrar.Size = New Size(104, 69)
        btnResgistrar.TabIndex = 1
        btnResgistrar.Text = "Registro"
        btnResgistrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(306, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 2
        Label1.Text = "Correo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(306, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 20)
        Label2.TabIndex = 3
        Label2.Text = "Contraseña"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Cursor = Cursors.IBeam
        txtUsuario.Font = New Font("Segoe UI Symbol", 9F)
        txtUsuario.Location = New Point(306, 95)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.PlaceholderText = "Correo Electrónico"
        txtUsuario.Size = New Size(255, 27)
        txtUsuario.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Font = New Font("Segoe UI Symbol", 9F)
        txtPassword.Location = New Point(306, 181)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Contraseña"
        txtPassword.Size = New Size(255, 27)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblMensaje
        ' 
        lblMensaje.AutoSize = True
        lblMensaje.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic)
        lblMensaje.Location = New Point(306, 242)
        lblMensaje.Name = "lblMensaje"
        lblMensaje.Size = New Size(71, 20)
        lblMensaje.TabIndex = 6
        lblMensaje.Text = "Mensaje"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(900, 450)
        Controls.Add(lblMensaje)
        Controls.Add(txtPassword)
        Controls.Add(txtUsuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnResgistrar)
        Controls.Add(btnLogin)
        Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Inicio de Sesión"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnResgistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblMensaje As Label

End Class
