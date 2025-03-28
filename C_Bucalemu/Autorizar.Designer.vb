<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Autorizar
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
        btnAceptar = New Button()
        btnRechazar = New Button()
        btnMenu = New Button()
        dgAutorizar = New DataGridView()
        CType(dgAutorizar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(648, 72)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(75, 23)
        btnAceptar.TabIndex = 1
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' btnRechazar
        ' 
        btnRechazar.Location = New Point(648, 101)
        btnRechazar.Name = "btnRechazar"
        btnRechazar.Size = New Size(75, 23)
        btnRechazar.TabIndex = 2
        btnRechazar.Text = "Rechazar"
        btnRechazar.UseVisualStyleBackColor = True
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(648, 398)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(75, 23)
        btnMenu.TabIndex = 3
        btnMenu.Text = "Menu"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' dgAutorizar
        ' 
        dgAutorizar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgAutorizar.Location = New Point(59, 72)
        dgAutorizar.Name = "dgAutorizar"
        dgAutorizar.Size = New Size(528, 349)
        dgAutorizar.TabIndex = 4
        ' 
        ' Autorizar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgAutorizar)
        Controls.Add(btnMenu)
        Controls.Add(btnRechazar)
        Controls.Add(btnAceptar)
        Name = "Autorizar"
        Text = "Form1"
        CType(dgAutorizar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnRechazar As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents dgAutorizar As DataGridView
End Class
