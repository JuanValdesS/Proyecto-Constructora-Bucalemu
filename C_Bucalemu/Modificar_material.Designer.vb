<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mod_material
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mod_material))
        btnAgregar = New Button()
        txtMaterial = New TextBox()
        txtCantidad = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        btn_regresar = New Button()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        txtbox1 = New ComboBox()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.LightSteelBlue
        btnAgregar.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btnAgregar.ForeColor = SystemColors.ActiveCaptionText
        btnAgregar.Location = New Point(47, 144)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(141, 43)
        btnAgregar.TabIndex = 0
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' txtMaterial
        ' 
        txtMaterial.BackColor = Color.AliceBlue
        txtMaterial.Font = New Font("Segoe UI Symbol", 7.8F)
        txtMaterial.Location = New Point(47, 88)
        txtMaterial.Name = "txtMaterial"
        txtMaterial.PlaceholderText = "Nombre del material"
        txtMaterial.Size = New Size(146, 25)
        txtMaterial.TabIndex = 1
        ' 
        ' txtCantidad
        ' 
        txtCantidad.BackColor = Color.AliceBlue
        txtCantidad.Font = New Font("Segoe UI Symbol", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCantidad.Location = New Point(265, 54)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.PlaceholderText = "cantidad"
        txtCantidad.Size = New Size(77, 25)
        txtCantidad.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightSteelBlue
        Label1.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(47, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 20)
        Label1.TabIndex = 3
        Label1.Text = "Material"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LightSteelBlue
        Label2.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(265, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 4
        Label2.Text = "Cantidad"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.BackgroundColor = Color.AliceBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(47, 213)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(501, 261)
        DataGridView1.TabIndex = 5
        ' 
        ' btn_regresar
        ' 
        btn_regresar.BackColor = Color.Transparent
        btn_regresar.BackgroundImage = CType(resources.GetObject("btn_regresar.BackgroundImage"), Image)
        btn_regresar.BackgroundImageLayout = ImageLayout.Stretch
        btn_regresar.ImageAlign = ContentAlignment.BottomCenter
        btn_regresar.Location = New Point(515, 31)
        btn_regresar.Name = "btn_regresar"
        btn_regresar.Size = New Size(57, 48)
        btn_regresar.TabIndex = 6
        btn_regresar.TabStop = False
        btn_regresar.Tag = "Regresar al menú"
        btn_regresar.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.LightSteelBlue
        Label3.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(368, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 7
        Label3.Text = "Unidades"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.AliceBlue
        ComboBox1.Font = New Font("Segoe UI Symbol", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Unidade(s)", "Kilogramo(s)", "Metros", "Metros cuadrado(s)", "Metros Cúbico(s)", "Milímetro(s)"})
        ComboBox1.Location = New Point(368, 54)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(79, 25)
        ComboBox1.TabIndex = 8
        ' 
        ' txtbox1
        ' 
        txtbox1.BackColor = Color.AliceBlue
        txtbox1.FormattingEnabled = True
        txtbox1.Location = New Point(47, 57)
        txtbox1.Name = "txtbox1"
        txtbox1.Size = New Size(146, 25)
        txtbox1.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(213, 144)
        Button1.Name = "Button1"
        Button1.Size = New Size(148, 43)
        Button1.TabIndex = 10
        Button1.Text = "Retirar Material"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' mod_material
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(598, 513)
        Controls.Add(Button1)
        Controls.Add(txtbox1)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(btn_regresar)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtCantidad)
        Controls.Add(txtMaterial)
        Controls.Add(btnAgregar)
        Font = New Font("Segoe UI Symbol", 7.8F)
        ForeColor = SystemColors.ActiveCaptionText
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "mod_material"
        Text = "Modificar Material"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_regresar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtbox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
