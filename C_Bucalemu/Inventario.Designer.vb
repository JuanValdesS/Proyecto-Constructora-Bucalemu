﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Button2 = New Button()
        btn_total = New Button()
        btn_reestablecer = New Button()
        txt_buscar = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Prueba
        ' 
        Prueba.AutoSize = True
        Prueba.BackColor = Color.CornflowerBlue
        Prueba.FlatStyle = FlatStyle.Flat
        Prueba.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Prueba.ForeColor = SystemColors.ControlText
        Prueba.Location = New Point(54, 9)
        Prueba.Name = "Prueba"
        Prueba.Size = New Size(208, 20)
        Prueba.TabIndex = 2
        Prueba.Text = "Información de materiales"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.AliceBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(54, 89)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(545, 421)
        DataGridView1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(687, 311)
        Button1.Name = "Button1"
        Button1.Size = New Size(61, 50)
        Button1.TabIndex = 4
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.CornflowerBlue
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(630, 89)
        Button2.Name = "Button2"
        Button2.Size = New Size(169, 63)
        Button2.TabIndex = 5
        Button2.Text = "Gestión de Inventario"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btn_total
        ' 
        btn_total.BackColor = Color.CornflowerBlue
        btn_total.Cursor = Cursors.Hand
        btn_total.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_total.ForeColor = SystemColors.ControlText
        btn_total.Location = New Point(630, 158)
        btn_total.Name = "btn_total"
        btn_total.Size = New Size(169, 63)
        btn_total.TabIndex = 6
        btn_total.Text = "Total de Material"
        btn_total.UseVisualStyleBackColor = False
        ' 
        ' btn_reestablecer
        ' 
        btn_reestablecer.BackColor = Color.IndianRed
        btn_reestablecer.Cursor = Cursors.Hand
        btn_reestablecer.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_reestablecer.Location = New Point(630, 227)
        btn_reestablecer.Name = "btn_reestablecer"
        btn_reestablecer.Size = New Size(169, 63)
        btn_reestablecer.TabIndex = 7
        btn_reestablecer.Text = "Reestablecer inventario"
        btn_reestablecer.UseVisualStyleBackColor = False
        ' 
        ' txt_buscar
        ' 
        txt_buscar.BackColor = Color.AliceBlue
        txt_buscar.Cursor = Cursors.IBeam
        txt_buscar.Font = New Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_buscar.Location = New Point(54, 42)
        txt_buscar.Name = "txt_buscar"
        txt_buscar.PlaceholderText = "Ingrese material a buscar"
        txt_buscar.Size = New Size(317, 25)
        txt_buscar.TabIndex = 8
        ' 
        ' Inventario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(857, 553)
        Controls.Add(txt_buscar)
        Controls.Add(btn_reestablecer)
        Controls.Add(btn_total)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Prueba)
        Cursor = Cursors.Default
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Inventario"
        Text = "Inventario"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Prueba As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_total As Button
    Friend WithEvents btn_reestablecer As Button
    Friend WithEvents txt_buscar As TextBox
End Class
