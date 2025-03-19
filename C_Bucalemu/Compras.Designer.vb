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
        Button1 = New Button()
        txtMaterial = New TextBox()
        Label1 = New Label()
        nCantidad = New NumericUpDown()
        lstMaterial = New ListBox()
        Label2 = New Label()
        btnAgregar = New Button()
        Button3 = New Button()
        Button2 = New Button()
        CType(nCantidad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(323, 229)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Solicitar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtMaterial
        ' 
        txtMaterial.Location = New Point(90, 88)
        txtMaterial.Name = "txtMaterial"
        txtMaterial.Size = New Size(175, 23)
        txtMaterial.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(90, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 15)
        Label1.TabIndex = 2
        Label1.Text = "Escriba el material que necesite"
        ' 
        ' nCantidad
        ' 
        nCantidad.Location = New Point(323, 88)
        nCantidad.Name = "nCantidad"
        nCantidad.Size = New Size(120, 23)
        nCantidad.TabIndex = 3
        ' 
        ' lstMaterial
        ' 
        lstMaterial.FormattingEnabled = True
        lstMaterial.ItemHeight = 15
        lstMaterial.Location = New Point(90, 158)
        lstMaterial.Name = "lstMaterial"
        lstMaterial.Size = New Size(175, 94)
        lstMaterial.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(90, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 15)
        Label2.TabIndex = 5
        Label2.Text = "Materiales solicitados"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(323, 158)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 23)
        btnAgregar.TabIndex = 6
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(323, 194)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 7
        Button3.Text = "Limpiar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(556, 332)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 8
        Button2.Text = "Menu"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Compras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(643, 367)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(btnAgregar)
        Controls.Add(Label2)
        Controls.Add(lstMaterial)
        Controls.Add(nCantidad)
        Controls.Add(Label1)
        Controls.Add(txtMaterial)
        Controls.Add(Button1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Compras"
        Text = "Compras"
        CType(nCantidad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nCantidad As NumericUpDown
    Friend WithEvents lstMaterial As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
