<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Prueba = New Label()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
<<<<<<< HEAD
=======
        Button2 = New Button()
        btn_total = New Button()
        btn_reestablecer = New Button()
>>>>>>> main
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Prueba
        ' 
<<<<<<< HEAD
        btnAgregar.Location = New Point(47, 86)
        btnAgregar.Margin = New Padding(3, 2, 3, 2)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(141, 38)
        btnAgregar.TabIndex = 0
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' txtMaterial
        ' 
        txtMaterial.Location = New Point(47, 44)
        txtMaterial.Margin = New Padding(3, 2, 3, 2)
        txtMaterial.Name = "txtMaterial"
        txtMaterial.Size = New Size(146, 23)
        txtMaterial.TabIndex = 1
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(265, 44)
        txtCantidad.Margin = New Padding(3, 2, 3, 2)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(80, 23)
        txtCantidad.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 3
        Label1.Text = "Material"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(265, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 4
        Label2.Text = "Cantidad"
=======
        Prueba.AutoSize = True
        Prueba.BackColor = Color.LightSteelBlue
        Prueba.FlatStyle = FlatStyle.Flat
        Prueba.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Prueba.ForeColor = SystemColors.ControlText
        Prueba.Location = New Point(54, 49)
        Prueba.Name = "Prueba"
        Prueba.Size = New Size(39, 20)
        Prueba.TabIndex = 2
        Prueba.Text = "Info"
>>>>>>> main
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.LightSteelBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
<<<<<<< HEAD
        DataGridView1.Location = New Point(47, 146)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(501, 164)
        DataGridView1.TabIndex = 5
=======
        DataGridView1.Location = New Point(54, 72)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(545, 421)
        DataGridView1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(687, 294)
        Button1.Name = "Button1"
        Button1.Size = New Size(61, 50)
        Button1.TabIndex = 4
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSteelBlue
        Button2.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(630, 72)
        Button2.Name = "Button2"
        Button2.Size = New Size(169, 63)
        Button2.TabIndex = 5
        Button2.Text = "Gestión de Inventario"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btn_total
        ' 
        btn_total.BackColor = Color.LightSteelBlue
        btn_total.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_total.Location = New Point(630, 141)
        btn_total.Name = "btn_total"
        btn_total.Size = New Size(169, 63)
        btn_total.TabIndex = 6
        btn_total.Text = "Total de Material"
        btn_total.UseVisualStyleBackColor = False
        ' 
        ' btn_reestablecer
        ' 
        btn_reestablecer.BackColor = Color.IndianRed
        btn_reestablecer.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_reestablecer.Location = New Point(630, 210)
        btn_reestablecer.Name = "btn_reestablecer"
        btn_reestablecer.Size = New Size(169, 63)
        btn_reestablecer.TabIndex = 7
        btn_reestablecer.Text = "Reestablecer inventario"
        btn_reestablecer.UseVisualStyleBackColor = False
>>>>>>> main
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(613, 287)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Menu"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Inventario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
<<<<<<< HEAD
        ClientSize = New Size(700, 338)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtCantidad)
        Controls.Add(txtMaterial)
        Controls.Add(btnAgregar)
        Margin = New Padding(3, 2, 3, 2)
=======
        BackColor = Color.LightSteelBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(857, 553)
        Controls.Add(btn_reestablecer)
        Controls.Add(btn_total)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Prueba)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
>>>>>>> main
        Name = "Inventario"
        Text = "Inventario"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Prueba As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
<<<<<<< HEAD
=======
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_total As Button
    Friend WithEvents btn_reestablecer As Button
>>>>>>> main
End Class
