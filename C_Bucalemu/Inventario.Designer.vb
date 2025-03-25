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
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Prueba
        ' 
        Prueba.AutoSize = True
        Prueba.BackColor = Color.LightSteelBlue
        Prueba.FlatStyle = FlatStyle.Flat
        Prueba.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Prueba.ForeColor = SystemColors.ControlText
        Prueba.Location = New Point(89, 36)
        Prueba.Name = "Prueba"
        Prueba.Size = New Size(39, 20)
        Prueba.TabIndex = 2
        Prueba.Text = "Info"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.AliceBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(89, 59)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(649, 422)
        DataGridView1.TabIndex = 3
        ' 
        ' Inventario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(823, 553)
        Controls.Add(DataGridView1)
        Controls.Add(Prueba)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Inventario"
        Text = "Inventario"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Prueba As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
