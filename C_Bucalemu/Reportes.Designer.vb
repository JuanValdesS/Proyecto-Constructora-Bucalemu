<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btn_guardar = New Button()
        txtNombre = New TextBox()
        txtEmail = New TextBox()
        Nombre = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Location = New Point(341, 232)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(154, 60)
        btn_guardar.TabIndex = 0
        btn_guardar.Text = "Guardar"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(283, 92)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(277, 27)
        txtNombre.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(283, 176)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(277, 27)
        txtEmail.TabIndex = 2
        ' 
        ' Nombre
        ' 
        Nombre.AutoSize = True
        Nombre.Location = New Point(283, 69)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(64, 20)
        Nombre.TabIndex = 3
        Nombre.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(283, 153)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 4
        Label1.Text = "Email"
        ' 
        ' Reportes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Nombre)
        Controls.Add(txtEmail)
        Controls.Add(txtNombre)
        Controls.Add(btn_guardar)
        Name = "Reportes"
        Text = "Reportes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_guardar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Nombre As Label
    Friend WithEvents Label1 As Label
End Class
