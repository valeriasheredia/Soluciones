<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Colaborador
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupListadoColaboradores = New System.Windows.Forms.GroupBox()
        Me.lblTotal_Colaboradores = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEliminar_Colaborador = New System.Windows.Forms.Button()
        Me.txt_Buscar_Colaborador = New System.Windows.Forms.TextBox()
        Me.dgvLista_Colaboradores = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupNuevoColaborador = New System.Windows.Forms.GroupBox()
        Me.btnNuevo_Colaborador = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_sector = New System.Windows.Forms.ComboBox()
        Me.txt_apellido_colaborador = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancelar_Colaborador = New System.Windows.Forms.Button()
        Me.btnActualizar_Colaborador = New System.Windows.Forms.Button()
        Me.btnGuardar_Colaborador = New System.Windows.Forms.Button()
        Me.txt_nombre_colaborador = New System.Windows.Forms.TextBox()
        Me.txt_id_colaborador = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btn_enviar_mensaje = New System.Windows.Forms.Button()
        Me.btn_Ver_Respuesta = New System.Windows.Forms.Button()
        Me.btn_Respuesta_Fecha = New System.Windows.Forms.Button()
        Me.GroupListadoColaboradores.SuspendLayout()
        CType(Me.dgvLista_Colaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupNuevoColaborador.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupListadoColaboradores
        '
        Me.GroupListadoColaboradores.Controls.Add(Me.lblTotal_Colaboradores)
        Me.GroupListadoColaboradores.Controls.Add(Me.Label5)
        Me.GroupListadoColaboradores.Controls.Add(Me.Label8)
        Me.GroupListadoColaboradores.Controls.Add(Me.btnEliminar_Colaborador)
        Me.GroupListadoColaboradores.Controls.Add(Me.txt_Buscar_Colaborador)
        Me.GroupListadoColaboradores.Controls.Add(Me.dgvLista_Colaboradores)
        Me.GroupListadoColaboradores.Controls.Add(Me.Label4)
        Me.GroupListadoColaboradores.Location = New System.Drawing.Point(12, 177)
        Me.GroupListadoColaboradores.Name = "GroupListadoColaboradores"
        Me.GroupListadoColaboradores.Size = New System.Drawing.Size(498, 348)
        Me.GroupListadoColaboradores.TabIndex = 5
        Me.GroupListadoColaboradores.TabStop = False
        Me.GroupListadoColaboradores.Text = "Listado de Colaborador"
        '
        'lblTotal_Colaboradores
        '
        Me.lblTotal_Colaboradores.AutoSize = True
        Me.lblTotal_Colaboradores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal_Colaboradores.Location = New System.Drawing.Point(448, 327)
        Me.lblTotal_Colaboradores.Name = "lblTotal_Colaboradores"
        Me.lblTotal_Colaboradores.Size = New System.Drawing.Size(2, 15)
        Me.lblTotal_Colaboradores.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total de Colaboradores"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(16, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "(Campo Requerido)"
        '
        'btnEliminar_Colaborador
        '
        Me.btnEliminar_Colaborador.Location = New System.Drawing.Point(409, 12)
        Me.btnEliminar_Colaborador.Name = "btnEliminar_Colaborador"
        Me.btnEliminar_Colaborador.Size = New System.Drawing.Size(75, 33)
        Me.btnEliminar_Colaborador.TabIndex = 7
        Me.btnEliminar_Colaborador.Text = "Eliminar"
        Me.btnEliminar_Colaborador.UseVisualStyleBackColor = True
        '
        'txt_Buscar_Colaborador
        '
        Me.txt_Buscar_Colaborador.Location = New System.Drawing.Point(110, 25)
        Me.txt_Buscar_Colaborador.Name = "txt_Buscar_Colaborador"
        Me.txt_Buscar_Colaborador.Size = New System.Drawing.Size(180, 20)
        Me.txt_Buscar_Colaborador.TabIndex = 6
        '
        'dgvLista_Colaboradores
        '
        Me.dgvLista_Colaboradores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista_Colaboradores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista_Colaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Colaboradores.Location = New System.Drawing.Point(17, 55)
        Me.dgvLista_Colaboradores.Name = "dgvLista_Colaboradores"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista_Colaboradores.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvLista_Colaboradores.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLista_Colaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Colaboradores.Size = New System.Drawing.Size(467, 266)
        Me.dgvLista_Colaboradores.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ingrese Nombre"
        '
        'GroupNuevoColaborador
        '
        Me.GroupNuevoColaborador.Controls.Add(Me.btnNuevo_Colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label7)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label6)
        Me.GroupNuevoColaborador.Controls.Add(Me.cbo_sector)
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_apellido_colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label9)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnCancelar_Colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnActualizar_Colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnGuardar_Colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_nombre_colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_id_colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label3)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label2)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label1)
        Me.GroupNuevoColaborador.Location = New System.Drawing.Point(12, 12)
        Me.GroupNuevoColaborador.Name = "GroupNuevoColaborador"
        Me.GroupNuevoColaborador.Size = New System.Drawing.Size(498, 159)
        Me.GroupNuevoColaborador.TabIndex = 4
        Me.GroupNuevoColaborador.TabStop = False
        Me.GroupNuevoColaborador.Text = "Nuevo Colaborador"
        '
        'btnNuevo_Colaborador
        '
        Me.btnNuevo_Colaborador.Location = New System.Drawing.Point(166, 110)
        Me.btnNuevo_Colaborador.Name = "btnNuevo_Colaborador"
        Me.btnNuevo_Colaborador.Size = New System.Drawing.Size(75, 33)
        Me.btnNuevo_Colaborador.TabIndex = 13
        Me.btnNuevo_Colaborador.Text = "Nuevo"
        Me.btnNuevo_Colaborador.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(61, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(61, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "*"
        '
        'cbo_sector
        '
        Me.cbo_sector.FormattingEnabled = True
        Me.cbo_sector.Location = New System.Drawing.Point(74, 83)
        Me.cbo_sector.Name = "cbo_sector"
        Me.cbo_sector.Size = New System.Drawing.Size(248, 21)
        Me.cbo_sector.TabIndex = 3
        '
        'txt_apellido_colaborador
        '
        Me.txt_apellido_colaborador.Location = New System.Drawing.Point(74, 51)
        Me.txt_apellido_colaborador.MaxLength = 50
        Me.txt_apellido_colaborador.Name = "txt_apellido_colaborador"
        Me.txt_apellido_colaborador.Size = New System.Drawing.Size(410, 20)
        Me.txt_apellido_colaborador.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Apellido"
        '
        'btnCancelar_Colaborador
        '
        Me.btnCancelar_Colaborador.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar_Colaborador.Location = New System.Drawing.Point(409, 110)
        Me.btnCancelar_Colaborador.Name = "btnCancelar_Colaborador"
        Me.btnCancelar_Colaborador.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar_Colaborador.TabIndex = 5
        Me.btnCancelar_Colaborador.Text = "Cancelar"
        Me.btnCancelar_Colaborador.UseVisualStyleBackColor = True
        '
        'btnActualizar_Colaborador
        '
        Me.btnActualizar_Colaborador.Location = New System.Drawing.Point(328, 110)
        Me.btnActualizar_Colaborador.Name = "btnActualizar_Colaborador"
        Me.btnActualizar_Colaborador.Size = New System.Drawing.Size(75, 33)
        Me.btnActualizar_Colaborador.TabIndex = 10
        Me.btnActualizar_Colaborador.Text = "Actualizar"
        Me.btnActualizar_Colaborador.UseVisualStyleBackColor = True
        '
        'btnGuardar_Colaborador
        '
        Me.btnGuardar_Colaborador.Location = New System.Drawing.Point(247, 110)
        Me.btnGuardar_Colaborador.Name = "btnGuardar_Colaborador"
        Me.btnGuardar_Colaborador.Size = New System.Drawing.Size(75, 33)
        Me.btnGuardar_Colaborador.TabIndex = 4
        Me.btnGuardar_Colaborador.Text = "Guardar"
        Me.btnGuardar_Colaborador.UseVisualStyleBackColor = True
        '
        'txt_nombre_colaborador
        '
        Me.txt_nombre_colaborador.Location = New System.Drawing.Point(74, 19)
        Me.txt_nombre_colaborador.MaxLength = 50
        Me.txt_nombre_colaborador.Name = "txt_nombre_colaborador"
        Me.txt_nombre_colaborador.Size = New System.Drawing.Size(410, 20)
        Me.txt_nombre_colaborador.TabIndex = 1
        '
        'txt_id_colaborador
        '
        Me.txt_id_colaborador.Location = New System.Drawing.Point(461, 83)
        Me.txt_id_colaborador.Name = "txt_id_colaborador"
        Me.txt_id_colaborador.Size = New System.Drawing.Size(23, 20)
        Me.txt_id_colaborador.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sector"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(378, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_colaborador"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btn_enviar_mensaje
        '
        Me.btn_enviar_mensaje.Location = New System.Drawing.Point(410, 531)
        Me.btn_enviar_mensaje.Name = "btn_enviar_mensaje"
        Me.btn_enviar_mensaje.Size = New System.Drawing.Size(100, 33)
        Me.btn_enviar_mensaje.TabIndex = 13
        Me.btn_enviar_mensaje.Text = "Enviar Mensaje"
        Me.btn_enviar_mensaje.UseVisualStyleBackColor = True
        '
        'btn_Ver_Respuesta
        '
        Me.btn_Ver_Respuesta.Location = New System.Drawing.Point(304, 531)
        Me.btn_Ver_Respuesta.Name = "btn_Ver_Respuesta"
        Me.btn_Ver_Respuesta.Size = New System.Drawing.Size(100, 33)
        Me.btn_Ver_Respuesta.TabIndex = 14
        Me.btn_Ver_Respuesta.Text = "Ver Respuesta"
        Me.btn_Ver_Respuesta.UseVisualStyleBackColor = True
        '
        'btn_Respuesta_Fecha
        '
        Me.btn_Respuesta_Fecha.Location = New System.Drawing.Point(165, 531)
        Me.btn_Respuesta_Fecha.Name = "btn_Respuesta_Fecha"
        Me.btn_Respuesta_Fecha.Size = New System.Drawing.Size(133, 33)
        Me.btn_Respuesta_Fecha.TabIndex = 15
        Me.btn_Respuesta_Fecha.Text = "Respuestas por Fecha"
        Me.btn_Respuesta_Fecha.UseVisualStyleBackColor = True
        '
        'frm_Colaborador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar_Colaborador
        Me.ClientSize = New System.Drawing.Size(522, 576)
        Me.Controls.Add(Me.btn_Respuesta_Fecha)
        Me.Controls.Add(Me.btn_Ver_Respuesta)
        Me.Controls.Add(Me.btn_enviar_mensaje)
        Me.Controls.Add(Me.GroupNuevoColaborador)
        Me.Controls.Add(Me.GroupListadoColaboradores)
        Me.Name = "frm_Colaborador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colaborador"
        Me.GroupListadoColaboradores.ResumeLayout(False)
        Me.GroupListadoColaboradores.PerformLayout()
        CType(Me.dgvLista_Colaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupNuevoColaborador.ResumeLayout(False)
        Me.GroupNuevoColaborador.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupListadoColaboradores As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal_Colaboradores As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Colaborador As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_Colaborador As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Colaboradores As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupNuevoColaborador As System.Windows.Forms.GroupBox
    Friend WithEvents txt_apellido_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar_Colaborador As System.Windows.Forms.Button
    Friend WithEvents btnActualizar_Colaborador As System.Windows.Forms.Button
    Friend WithEvents btnGuardar_Colaborador As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_sector As System.Windows.Forms.ComboBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo_Colaborador As System.Windows.Forms.Button
    Friend WithEvents btn_enviar_mensaje As System.Windows.Forms.Button
    Friend WithEvents btn_Ver_Respuesta As System.Windows.Forms.Button
    Friend WithEvents btn_Respuesta_Fecha As System.Windows.Forms.Button
End Class
