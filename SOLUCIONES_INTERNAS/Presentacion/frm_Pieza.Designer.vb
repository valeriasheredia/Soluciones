<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Pieza
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
        Me.GroupListadoPiezas = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar_Pieza = New System.Windows.Forms.Button()
        Me.txt_Buscar_Pieza = New System.Windows.Forms.TextBox()
        Me.dgvLista_Piezas = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupNuevaPieza = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelar_Pieza = New System.Windows.Forms.Button()
        Me.btnActualizar_Pieza = New System.Windows.Forms.Button()
        Me.btnGuardar_Pieza = New System.Windows.Forms.Button()
        Me.btnNuevo_Pieza = New System.Windows.Forms.Button()
        Me.txt_nombre_pieza = New System.Windows.Forms.TextBox()
        Me.txt_id_pieza = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupListadoPiezas.SuspendLayout()
        CType(Me.dgvLista_Piezas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupNuevaPieza.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupListadoPiezas
        '
        Me.GroupListadoPiezas.Controls.Add(Me.Label8)
        Me.GroupListadoPiezas.Controls.Add(Me.Label6)
        Me.GroupListadoPiezas.Controls.Add(Me.Label5)
        Me.GroupListadoPiezas.Controls.Add(Me.btnEliminar_Pieza)
        Me.GroupListadoPiezas.Controls.Add(Me.txt_Buscar_Pieza)
        Me.GroupListadoPiezas.Controls.Add(Me.dgvLista_Piezas)
        Me.GroupListadoPiezas.Controls.Add(Me.Label4)
        Me.GroupListadoPiezas.Location = New System.Drawing.Point(12, 123)
        Me.GroupListadoPiezas.Name = "GroupListadoPiezas"
        Me.GroupListadoPiezas.Size = New System.Drawing.Size(348, 260)
        Me.GroupListadoPiezas.TabIndex = 3
        Me.GroupListadoPiezas.TabStop = False
        Me.GroupListadoPiezas.Text = "Listado de Piezas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(10, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "(Campo Requerido)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(309, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(2, 15)
        Me.Label6.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total de Piezas"
        '
        'btnEliminar_Pieza
        '
        Me.btnEliminar_Pieza.Location = New System.Drawing.Point(262, 12)
        Me.btnEliminar_Pieza.Name = "btnEliminar_Pieza"
        Me.btnEliminar_Pieza.Size = New System.Drawing.Size(75, 33)
        Me.btnEliminar_Pieza.TabIndex = 3
        Me.btnEliminar_Pieza.Text = "Eliminar"
        Me.btnEliminar_Pieza.UseVisualStyleBackColor = True
        '
        'txt_Buscar_Pieza
        '
        Me.txt_Buscar_Pieza.Location = New System.Drawing.Point(106, 19)
        Me.txt_Buscar_Pieza.Name = "txt_Buscar_Pieza"
        Me.txt_Buscar_Pieza.Size = New System.Drawing.Size(150, 20)
        Me.txt_Buscar_Pieza.TabIndex = 2
        '
        'dgvLista_Piezas
        '
        Me.dgvLista_Piezas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvLista_Piezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Piezas.Location = New System.Drawing.Point(10, 51)
        Me.dgvLista_Piezas.Name = "dgvLista_Piezas"
        Me.dgvLista_Piezas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Piezas.Size = New System.Drawing.Size(327, 176)
        Me.dgvLista_Piezas.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ingrese Nombre"
        '
        'GroupNuevaPieza
        '
        Me.GroupNuevaPieza.Controls.Add(Me.Label3)
        Me.GroupNuevaPieza.Controls.Add(Me.btnCancelar_Pieza)
        Me.GroupNuevaPieza.Controls.Add(Me.btnActualizar_Pieza)
        Me.GroupNuevaPieza.Controls.Add(Me.btnGuardar_Pieza)
        Me.GroupNuevaPieza.Controls.Add(Me.btnNuevo_Pieza)
        Me.GroupNuevaPieza.Controls.Add(Me.txt_nombre_pieza)
        Me.GroupNuevaPieza.Controls.Add(Me.txt_id_pieza)
        Me.GroupNuevaPieza.Controls.Add(Me.Label2)
        Me.GroupNuevaPieza.Controls.Add(Me.Label1)
        Me.GroupNuevaPieza.Location = New System.Drawing.Point(12, 12)
        Me.GroupNuevaPieza.Name = "GroupNuevaPieza"
        Me.GroupNuevaPieza.Size = New System.Drawing.Size(348, 105)
        Me.GroupNuevaPieza.TabIndex = 2
        Me.GroupNuevaPieza.TabStop = False
        Me.GroupNuevaPieza.Text = "Nueva Pieza"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(63, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "*"
        '
        'btnCancelar_Pieza
        '
        Me.btnCancelar_Pieza.Location = New System.Drawing.Point(262, 59)
        Me.btnCancelar_Pieza.Name = "btnCancelar_Pieza"
        Me.btnCancelar_Pieza.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar_Pieza.TabIndex = 3
        Me.btnCancelar_Pieza.Text = "Cancelar"
        Me.btnCancelar_Pieza.UseVisualStyleBackColor = True
        '
        'btnActualizar_Pieza
        '
        Me.btnActualizar_Pieza.Location = New System.Drawing.Point(181, 59)
        Me.btnActualizar_Pieza.Name = "btnActualizar_Pieza"
        Me.btnActualizar_Pieza.Size = New System.Drawing.Size(75, 33)
        Me.btnActualizar_Pieza.TabIndex = 4
        Me.btnActualizar_Pieza.Text = "Actualizar"
        Me.btnActualizar_Pieza.UseVisualStyleBackColor = True
        '
        'btnGuardar_Pieza
        '
        Me.btnGuardar_Pieza.Location = New System.Drawing.Point(100, 59)
        Me.btnGuardar_Pieza.Name = "btnGuardar_Pieza"
        Me.btnGuardar_Pieza.Size = New System.Drawing.Size(75, 33)
        Me.btnGuardar_Pieza.TabIndex = 2
        Me.btnGuardar_Pieza.Text = "Guardar"
        Me.btnGuardar_Pieza.UseVisualStyleBackColor = True
        '
        'btnNuevo_Pieza
        '
        Me.btnNuevo_Pieza.Location = New System.Drawing.Point(19, 59)
        Me.btnNuevo_Pieza.Name = "btnNuevo_Pieza"
        Me.btnNuevo_Pieza.Size = New System.Drawing.Size(75, 33)
        Me.btnNuevo_Pieza.TabIndex = 5
        Me.btnNuevo_Pieza.Text = "Nuevo"
        Me.btnNuevo_Pieza.UseVisualStyleBackColor = True
        '
        'txt_nombre_pieza
        '
        Me.txt_nombre_pieza.Location = New System.Drawing.Point(80, 23)
        Me.txt_nombre_pieza.MaxLength = 30
        Me.txt_nombre_pieza.Name = "txt_nombre_pieza"
        Me.txt_nombre_pieza.Size = New System.Drawing.Size(257, 20)
        Me.txt_nombre_pieza.TabIndex = 1
        '
        'txt_id_pieza
        '
        Me.txt_id_pieza.Location = New System.Drawing.Point(5, 55)
        Me.txt_id_pieza.Name = "txt_id_pieza"
        Me.txt_id_pieza.Size = New System.Drawing.Size(12, 20)
        Me.txt_id_pieza.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_pieza"
        '
        'frm_Pieza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 392)
        Me.Controls.Add(Me.GroupListadoPiezas)
        Me.Controls.Add(Me.GroupNuevaPieza)
        Me.Name = "frm_Pieza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Piezas"
        Me.GroupListadoPiezas.ResumeLayout(False)
        Me.GroupListadoPiezas.PerformLayout()
        CType(Me.dgvLista_Piezas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupNuevaPieza.ResumeLayout(False)
        Me.GroupNuevaPieza.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupListadoPiezas As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Pieza As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_Pieza As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Piezas As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupNuevaPieza As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar_Pieza As System.Windows.Forms.Button
    Friend WithEvents btnActualizar_Pieza As System.Windows.Forms.Button
    Friend WithEvents btnGuardar_Pieza As System.Windows.Forms.Button
    Friend WithEvents btnNuevo_Pieza As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_pieza As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_pieza As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
