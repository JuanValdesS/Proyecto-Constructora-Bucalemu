﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        txtMaterial = New TextBox()
        nCantidad = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        cbUnidad = New ComboBox()
        dgCompras = New DataGridView()
        cbMedidas = New CheckBox()
        cmMedida = New ComboBox()
        txtMedidas = New TextBox()
        lbl_medida = New Label()
        CType(nCantidad, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgCompras, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = SystemColors.ActiveCaption
        btnAgregar.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btnAgregar.Location = New Point(769, 138)
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
        btnEliminar.Location = New Point(769, 216)
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
        btnSolicitar.Location = New Point(769, 177)
        btnSolicitar.Margin = New Padding(3, 4, 3, 4)
        btnSolicitar.Name = "btnSolicitar"
        btnSolicitar.Size = New Size(97, 31)
        btnSolicitar.TabIndex = 2
        btnSolicitar.Text = "Solicitar"
        btnSolicitar.UseVisualStyleBackColor = False
        ' 
        ' txtMaterial
        ' 
        txtMaterial.BackColor = Color.AliceBlue
        txtMaterial.Font = New Font("Arial Narrow", 9F, FontStyle.Bold)
        txtMaterial.Location = New Point(136, 28)
        txtMaterial.Margin = New Padding(3, 4, 3, 4)
        txtMaterial.Name = "txtMaterial"
        txtMaterial.Size = New Size(132, 21)
        txtMaterial.TabIndex = 4
        ' 
        ' nCantidad
        ' 
        nCantidad.BackColor = Color.AliceBlue
        nCantidad.Font = New Font("Arial Narrow", 9F, FontStyle.Bold)
        nCantidad.Location = New Point(136, 74)
        nCantidad.Margin = New Padding(3, 4, 3, 4)
        nCantidad.Name = "nCantidad"
        nCantidad.Size = New Size(143, 21)
        nCantidad.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightSteelBlue
        Label1.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Label1.Location = New Point(136, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 15)
        Label1.TabIndex = 6
        Label1.Text = "Ingrese Material"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LightSteelBlue
        Label2.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Label2.Location = New Point(136, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 15)
        Label2.TabIndex = 7
        Label2.Text = "Agregar Cantidad"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Button1.Location = New Point(769, 372)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(97, 31)
        Button1.TabIndex = 8
        Button1.Text = "Menu"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(315, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 9
        Label3.Text = "Unidad"
        ' 
        ' cbUnidad
        ' 
        cbUnidad.FormattingEnabled = True
        cbUnidad.Items.AddRange(New Object() {"Unidade(s)", "Kilogramo(s)", "Litro(s)", "Metros", "Metros cuadrado(s)", "Metros Cúbico(s)", "Milímetro(s)"})
        cbUnidad.Location = New Point(315, 29)
        cbUnidad.Name = "cbUnidad"
        cbUnidad.Size = New Size(121, 23)
        cbUnidad.TabIndex = 10
        ' 
        ' dgCompras
        ' 
        dgCompras.AllowUserToAddRows = False
        dgCompras.AllowUserToDeleteRows = False
        dgCompras.BackgroundColor = Color.LightSteelBlue
        dgCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgCompras.Location = New Point(136, 138)
        dgCompras.Name = "dgCompras"
        dgCompras.ReadOnly = True
        dgCompras.RowHeadersWidth = 51
        dgCompras.Size = New Size(528, 265)
        dgCompras.TabIndex = 11
        ' 
        ' cbMedidas
        ' 
        cbMedidas.AutoSize = True
        cbMedidas.Location = New Point(315, 76)
        cbMedidas.Name = "cbMedidas"
        cbMedidas.Size = New Size(131, 19)
        cbMedidas.TabIndex = 12
        cbMedidas.Text = "Agregar medidas"
        cbMedidas.UseVisualStyleBackColor = True
        ' 
        ' cmMedida
        ' 
        cmMedida.FormattingEnabled = True
        cmMedida.Items.AddRange(New Object() {"cm", "mm", "m"})
        cmMedida.Location = New Point(595, 76)
        cmMedida.Name = "cmMedida"
        cmMedida.Size = New Size(69, 23)
        cmMedida.TabIndex = 13
        ' 
        ' txtMedidas
        ' 
        txtMedidas.Location = New Point(463, 74)
        txtMedidas.Name = "txtMedidas"
        txtMedidas.Size = New Size(100, 23)
        txtMedidas.TabIndex = 14
        ' 
        ' lbl_medida
        ' 
        lbl_medida.AutoSize = True
        lbl_medida.BackColor = Color.LightSteelBlue
        lbl_medida.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        lbl_medida.ForeColor = SystemColors.ActiveCaptionText
        lbl_medida.Location = New Point(463, 53)
        lbl_medida.Name = "lbl_medida"
        lbl_medida.Size = New Size(131, 15)
        lbl_medida.TabIndex = 16
        lbl_medida.Text = "Medida del material"
        ' 
        ' Compras
        ' 
        AutoScaleDimensions = New SizeF(8F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(887, 451)
        Controls.Add(lbl_medida)
        Controls.Add(txtMedidas)
        Controls.Add(cmMedida)
        Controls.Add(cbMedidas)
        Controls.Add(dgCompras)
        Controls.Add(cbUnidad)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(nCantidad)
        Controls.Add(txtMaterial)
        Controls.Add(btnSolicitar)
        Controls.Add(btnEliminar)
        Controls.Add(btnAgregar)
        Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Compras"
        Text = "Compras"
        CType(nCantidad, ComponentModel.ISupportInitialize).EndInit()
        CType(dgCompras, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents nCantidad As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbUnidad As ComboBox
    Friend WithEvents dgCompras As DataGridView
    Friend WithEvents cbMedidas As CheckBox
    Friend WithEvents cmMedida As ComboBox
    Friend WithEvents txtMedidas As TextBox
    Friend WithEvents lbl_medida As Label
End Class
