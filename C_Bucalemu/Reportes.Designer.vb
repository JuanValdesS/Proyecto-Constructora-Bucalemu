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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes))
        btn_reporte = New Button()
        txtObservacion = New TextBox()
        data_repo = New DataGridView()
        Button1 = New Button()
        Label1 = New Label()
        CType(data_repo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_reporte
        ' 
        btn_reporte.BackColor = Color.LightSteelBlue
        btn_reporte.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_reporte.Location = New Point(110, 148)
        btn_reporte.Name = "btn_reporte"
        btn_reporte.Size = New Size(159, 47)
        btn_reporte.TabIndex = 0
        btn_reporte.Text = "Enviar Reporte"
        btn_reporte.UseVisualStyleBackColor = False
        ' 
        ' txtObservacion
        ' 
        txtObservacion.BackColor = Color.AliceBlue
        txtObservacion.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtObservacion.Location = New Point(110, 83)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.PlaceholderText = "Ingrese Reporte"
        txtObservacion.Size = New Size(159, 25)
        txtObservacion.TabIndex = 1
        ' 
        ' data_repo
        ' 
        data_repo.BackgroundColor = Color.AliceBlue
        data_repo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        data_repo.Location = New Point(375, 83)
        data_repo.Name = "data_repo"
        data_repo.RowHeadersWidth = 51
        data_repo.Size = New Size(325, 251)
        data_repo.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(149, 212)
        Button1.Name = "Button1"
        Button1.Size = New Size(74, 51)
        Button1.TabIndex = 3
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightSteelBlue
        Label1.Font = New Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(110, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(330, 23)
        Label1.TabIndex = 4
        Label1.Text = "Ingrese breve descripción del reporte" & vbCrLf
        ' 
        ' Reportes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(723, 357)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(data_repo)
        Controls.Add(txtObservacion)
        Controls.Add(btn_reporte)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Reportes"
        Text = "Reportes"
        CType(data_repo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_reporte As Button
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents data_repo As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
