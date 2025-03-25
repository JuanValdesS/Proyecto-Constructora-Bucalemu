<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compras))
        btnAgregar = New Button()
        btnEliminar = New Button()
        btnSolicitar = New Button()
        lstMaterial = New ListBox()
        txtMaterial = New TextBox()
        nCantidad = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        CType(nCantidad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = SystemColors.ActiveCaption
        btnAgregar.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btnAgregar.Location = New Point(619, 204)
        btnAgregar.Margin = New Padding(3, 4, 3, 4)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(97, 31)
        btnAgregar.TabIndex = 0
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = SystemColors.ActiveCaption
        btnEliminar.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btnEliminar.Location = New Point(619, 255)
        btnEliminar.Margin = New Padding(3, 4, 3, 4)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(97, 31)
        btnEliminar.TabIndex = 1
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnSolicitar
        ' 
        btnSolicitar.BackColor = SystemColors.ActiveCaption
        btnSolicitar.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btnSolicitar.Location = New Point(619, 307)
        btnSolicitar.Margin = New Padding(3, 4, 3, 4)
        btnSolicitar.Name = "btnSolicitar"
        btnSolicitar.Size = New Size(97, 31)
        btnSolicitar.TabIndex = 2
        btnSolicitar.Text = "Solicitar"
        btnSolicitar.UseVisualStyleBackColor = False
        ' 
        ' lstMaterial
        ' 
        lstMaterial.BackColor = Color.AliceBlue
        lstMaterial.Font = New Font("Arial Narrow", 9F, FontStyle.Bold)
        lstMaterial.FormattingEnabled = True
        lstMaterial.Location = New Point(156, 204)
        lstMaterial.Margin = New Padding(3, 4, 3, 4)
        lstMaterial.Name = "lstMaterial"
        lstMaterial.Size = New Size(410, 124)
        lstMaterial.TabIndex = 3
        ' 
        ' txtMaterial
        ' 
        txtMaterial.BackColor = Color.AliceBlue
        txtMaterial.Font = New Font("Arial Narrow", 9F, FontStyle.Bold)
        txtMaterial.Location = New Point(156, 109)
        txtMaterial.Margin = New Padding(3, 4, 3, 4)
        txtMaterial.Name = "txtMaterial"
        txtMaterial.Size = New Size(154, 25)
        txtMaterial.TabIndex = 4
        ' 
        ' nCantidad
        ' 
        nCantidad.BackColor = Color.AliceBlue
        nCantidad.Font = New Font("Arial Narrow", 9F, FontStyle.Bold)
        nCantidad.Location = New Point(630, 109)
        nCantidad.Margin = New Padding(3, 4, 3, 4)
        nCantidad.Name = "nCantidad"
        nCantidad.Size = New Size(173, 25)
        nCantidad.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightSteelBlue
        Label1.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Label1.Location = New Point(156, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 20)
        Label1.TabIndex = 6
        Label1.Text = "Ingrese Material"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LightSteelBlue
        Label2.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Label2.Location = New Point(560, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 20)
        Label2.TabIndex = 7
        Label2.Text = "Agregar Cantidad"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Button1.Location = New Point(789, 404)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(97, 31)
        Button1.TabIndex = 8
        Button1.Text = "Menu"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Compras
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(900, 451)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(nCantidad)
        Controls.Add(txtMaterial)
        Controls.Add(lstMaterial)
        Controls.Add(btnSolicitar)
        Controls.Add(btnEliminar)
        Controls.Add(btnAgregar)
        Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Name = "Compras"
        Text = "Compras"
        CType(nCantidad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents lstMaterial As ListBox
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents nCantidad As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
