<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerInventario
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
        btnCargar = New Button()
        lstMateriales = New ListBox()
        Prueba = New Label()
        SuspendLayout()
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(655, 89)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(75, 23)
        btnCargar.TabIndex = 0
        btnCargar.Text = "Cargar"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' lstMateriales
        ' 
        lstMateriales.FormattingEnabled = True
        lstMateriales.ItemHeight = 15
        lstMateriales.Location = New Point(61, 89)
        lstMateriales.Name = "lstMateriales"
        lstMateriales.Size = New Size(536, 304)
        lstMateriales.TabIndex = 1
        ' 
        ' Prueba
        ' 
        Prueba.AutoSize = True
        Prueba.Location = New Point(61, 51)
        Prueba.Name = "Prueba"
        Prueba.Size = New Size(28, 15)
        Prueba.TabIndex = 2
        Prueba.Text = "Info"
        ' 
        ' VerInventario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Prueba)
        Controls.Add(lstMateriales)
        Controls.Add(btnCargar)
        Name = "VerInventario"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCargar As Button
    Friend WithEvents lstMateriales As ListBox
    Friend WithEvents Prueba As Label
End Class
