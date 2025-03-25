<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menú
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menú))
        btn_Compras = New Button()
        btn_cubicacion = New Button()
        btn_inventario = New Button()
        btn_reportes = New Button()
        Label1 = New Label()
        btn_logout = New Button()
        btnVerInventario = New Button()
        btnAutorizar = New Button()
        SuspendLayout()
        ' 
        ' btn_Compras
        ' 
        btn_Compras.BackColor = Color.Moccasin
        btn_Compras.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btn_Compras.ForeColor = SystemColors.ActiveCaptionText
        btn_Compras.Location = New Point(243, 58)
        btn_Compras.Margin = New Padding(3, 2, 3, 2)
        btn_Compras.Name = "btn_Compras"
        btn_Compras.Size = New Size(149, 34)
        btn_Compras.TabIndex = 0
        btn_Compras.Text = "Compras"
        btn_Compras.UseVisualStyleBackColor = False
        ' 
        ' btn_cubicacion
        ' 
        btn_cubicacion.BackColor = Color.Moccasin
        btn_cubicacion.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btn_cubicacion.ForeColor = SystemColors.ActiveCaptionText
        btn_cubicacion.Location = New Point(243, 210)
        btn_cubicacion.Margin = New Padding(3, 2, 3, 2)
        btn_cubicacion.Name = "btn_cubicacion"
        btn_cubicacion.Size = New Size(149, 34)
        btn_cubicacion.TabIndex = 1
        btn_cubicacion.Text = "Cubicacion"
        btn_cubicacion.UseVisualStyleBackColor = False
        ' 
        ' btn_inventario
        ' 
        btn_inventario.BackColor = Color.Moccasin
        btn_inventario.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btn_inventario.ForeColor = SystemColors.ActiveCaptionText
        btn_inventario.Location = New Point(243, 134)
        btn_inventario.Margin = New Padding(3, 2, 3, 2)
        btn_inventario.Name = "btn_inventario"
        btn_inventario.Size = New Size(149, 34)
        btn_inventario.TabIndex = 2
        btn_inventario.Text = "Modificar Material"
        btn_inventario.UseVisualStyleBackColor = False
        ' 
        ' btn_reportes
        ' 
        btn_reportes.BackColor = Color.Moccasin
        btn_reportes.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btn_reportes.ForeColor = SystemColors.ActiveCaptionText
        btn_reportes.Location = New Point(243, 248)
        btn_reportes.Margin = New Padding(3, 2, 3, 2)
        btn_reportes.Name = "btn_reportes"
        btn_reportes.Size = New Size(149, 34)
        btn_reportes.TabIndex = 3
        btn_reportes.Text = "Reportar"
        btn_reportes.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Moccasin
        Label1.Font = New Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Desktop
        Label1.Location = New Point(141, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(343, 21)
        Label1.TabIndex = 4
        Label1.Text = "Bienvenidos al menú principal C.Bucalemu"
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = Color.RosyBrown
        btn_logout.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_logout.Location = New Point(270, 408)
        btn_logout.Margin = New Padding(3, 2, 3, 2)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(95, 45)
        btn_logout.TabIndex = 5
        btn_logout.Text = "Cerrar Sesión"
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' btnVerInventario
        ' 
        btnVerInventario.BackColor = Color.Moccasin
        btnVerInventario.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btnVerInventario.ForeColor = SystemColors.ActiveCaptionText
        btnVerInventario.Location = New Point(243, 172)
        btnVerInventario.Margin = New Padding(3, 2, 3, 2)
        btnVerInventario.Name = "btnVerInventario"
        btnVerInventario.Size = New Size(149, 34)
        btnVerInventario.TabIndex = 6
        btnVerInventario.Text = "Ver Inventario"
        btnVerInventario.UseVisualStyleBackColor = False
        ' 
        ' btnAutorizar
        ' 
        btnAutorizar.BackColor = Color.Moccasin
        btnAutorizar.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btnAutorizar.ForeColor = SystemColors.ActiveCaptionText
        btnAutorizar.Location = New Point(243, 96)
        btnAutorizar.Margin = New Padding(3, 2, 3, 2)
        btnAutorizar.Name = "btnAutorizar"
        btnAutorizar.Size = New Size(149, 34)
        btnAutorizar.TabIndex = 7
        btnAutorizar.Text = "Autorizar"
        btnAutorizar.UseVisualStyleBackColor = False
        ' 
        ' Menú
        ' 
        AccessibleRole = AccessibleRole.None
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(640, 476)
        Controls.Add(btnAutorizar)
        Controls.Add(btnVerInventario)
        Controls.Add(btn_logout)
        Controls.Add(Label1)
        Controls.Add(btn_reportes)
        Controls.Add(btn_inventario)
        Controls.Add(btn_cubicacion)
        Controls.Add(btn_Compras)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Menú"
        Text = "Menú"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Compras As Button
    Friend WithEvents btn_cubicacion As Button
    Friend WithEvents btn_inventario As Button
    Friend WithEvents btn_reportes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_logout As Button
    Friend WithEvents btnVerInventario As Button
    Friend WithEvents btnAutorizar As Button
End Class
