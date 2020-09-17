<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Listado_Empaque
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
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.rbt_orden = New System.Windows.Forms.RadioButton()
        Me.rbt_estado = New System.Windows.Forms.RadioButton()
        Me.rbt_entrega = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha_estado = New System.Windows.Forms.DateTimePicker()
        Me.btn_generar_informe = New System.Windows.Forms.Button()
        Me.dgv_planificacion = New System.Windows.Forms.DataGridView()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.Gbx_rango = New System.Windows.Forms.GroupBox()
        Me.rbt_rango_sinenviar = New System.Windows.Forms.RadioButton()
        Me.rbt_rango_enviadas = New System.Windows.Forms.RadioButton()
        Me.rbt_rango_todas = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_planificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_rango.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(19, 53)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(113, 20)
        Me.txt_buscar.TabIndex = 2
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(664, 486)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(101, 30)
        Me.btn_modificar.TabIndex = 5
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(664, 486)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(101, 30)
        Me.btn_eliminar.TabIndex = 6
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(771, 486)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(101, 30)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cerrar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'rbt_orden
        '
        Me.rbt_orden.AutoSize = True
        Me.rbt_orden.Location = New System.Drawing.Point(6, 19)
        Me.rbt_orden.Name = "rbt_orden"
        Me.rbt_orden.Size = New System.Drawing.Size(67, 17)
        Me.rbt_orden.TabIndex = 8
        Me.rbt_orden.TabStop = True
        Me.rbt_orden.Text = "N° orden"
        Me.rbt_orden.UseVisualStyleBackColor = True
        '
        'rbt_estado
        '
        Me.rbt_estado.AutoSize = True
        Me.rbt_estado.Location = New System.Drawing.Point(125, 19)
        Me.rbt_estado.Name = "rbt_estado"
        Me.rbt_estado.Size = New System.Drawing.Size(58, 17)
        Me.rbt_estado.TabIndex = 9
        Me.rbt_estado.TabStop = True
        Me.rbt_estado.Text = "Estado"
        Me.rbt_estado.UseVisualStyleBackColor = True
        '
        'rbt_entrega
        '
        Me.rbt_entrega.AutoSize = True
        Me.rbt_entrega.Location = New System.Drawing.Point(243, 19)
        Me.rbt_entrega.Name = "rbt_entrega"
        Me.rbt_entrega.Size = New System.Drawing.Size(117, 17)
        Me.rbt_entrega.TabIndex = 10
        Me.rbt_entrega.TabStop = True
        Me.rbt_entrega.Text = "Fecha planificación"
        Me.rbt_entrega.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbt_orden)
        Me.GroupBox1.Controls.Add(Me.rbt_entrega)
        Me.GroupBox1.Controls.Add(Me.rbt_estado)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 45)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por"
        '
        'dtp_fecha_estado
        '
        Me.dtp_fecha_estado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_estado.Location = New System.Drawing.Point(256, 53)
        Me.dtp_fecha_estado.Name = "dtp_fecha_estado"
        Me.dtp_fecha_estado.Size = New System.Drawing.Size(117, 20)
        Me.dtp_fecha_estado.TabIndex = 12
        '
        'btn_generar_informe
        '
        Me.btn_generar_informe.Location = New System.Drawing.Point(12, 486)
        Me.btn_generar_informe.Name = "btn_generar_informe"
        Me.btn_generar_informe.Size = New System.Drawing.Size(101, 30)
        Me.btn_generar_informe.TabIndex = 14
        Me.btn_generar_informe.Text = "Generar informe"
        Me.btn_generar_informe.UseVisualStyleBackColor = True
        '
        'dgv_planificacion
        '
        Me.dgv_planificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_planificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_planificacion.Location = New System.Drawing.Point(13, 79)
        Me.dgv_planificacion.MultiSelect = False
        Me.dgv_planificacion.Name = "dgv_planificacion"
        Me.dgv_planificacion.Size = New System.Drawing.Size(859, 401)
        Me.dgv_planificacion.TabIndex = 1
        '
        'cmb_estado
        '
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Items.AddRange(New Object() {"PLANIFICADO", "IMPRESION", "TERMINACION", "TERCERO", "ENTREGADO"})
        Me.cmb_estado.Location = New System.Drawing.Point(138, 52)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(112, 21)
        Me.cmb_estado.TabIndex = 15
        '
        'Gbx_rango
        '
        Me.Gbx_rango.Controls.Add(Me.rbt_rango_sinenviar)
        Me.Gbx_rango.Controls.Add(Me.rbt_rango_enviadas)
        Me.Gbx_rango.Controls.Add(Me.rbt_rango_todas)
        Me.Gbx_rango.Location = New System.Drawing.Point(396, 2)
        Me.Gbx_rango.Name = "Gbx_rango"
        Me.Gbx_rango.Size = New System.Drawing.Size(221, 45)
        Me.Gbx_rango.TabIndex = 16
        Me.Gbx_rango.TabStop = False
        Me.Gbx_rango.Text = "Rango de búsqueda"
        '
        'rbt_rango_sinenviar
        '
        Me.rbt_rango_sinenviar.AutoSize = True
        Me.rbt_rango_sinenviar.Location = New System.Drawing.Point(81, 19)
        Me.rbt_rango_sinenviar.Name = "rbt_rango_sinenviar"
        Me.rbt_rango_sinenviar.Size = New System.Drawing.Size(72, 17)
        Me.rbt_rango_sinenviar.TabIndex = 2
        Me.rbt_rango_sinenviar.TabStop = True
        Me.rbt_rango_sinenviar.Text = "Sin enviar"
        Me.rbt_rango_sinenviar.UseVisualStyleBackColor = True
        '
        'rbt_rango_enviadas
        '
        Me.rbt_rango_enviadas.AutoSize = True
        Me.rbt_rango_enviadas.Location = New System.Drawing.Point(6, 19)
        Me.rbt_rango_enviadas.Name = "rbt_rango_enviadas"
        Me.rbt_rango_enviadas.Size = New System.Drawing.Size(69, 17)
        Me.rbt_rango_enviadas.TabIndex = 1
        Me.rbt_rango_enviadas.TabStop = True
        Me.rbt_rango_enviadas.Text = "Enviadas"
        Me.rbt_rango_enviadas.UseVisualStyleBackColor = True
        '
        'rbt_rango_todas
        '
        Me.rbt_rango_todas.AutoSize = True
        Me.rbt_rango_todas.Location = New System.Drawing.Point(159, 19)
        Me.rbt_rango_todas.Name = "rbt_rango_todas"
        Me.rbt_rango_todas.Size = New System.Drawing.Size(55, 17)
        Me.rbt_rango_todas.TabIndex = 0
        Me.rbt_rango_todas.TabStop = True
        Me.rbt_rango_todas.Text = "Todas"
        Me.rbt_rango_todas.UseVisualStyleBackColor = True
        '
        'frm_Listado_Empaque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 519)
        Me.Controls.Add(Me.Gbx_rango)
        Me.Controls.Add(Me.cmb_estado)
        Me.Controls.Add(Me.btn_generar_informe)
        Me.Controls.Add(Me.dtp_fecha_estado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.dgv_planificacion)
        Me.Name = "frm_Listado_Empaque"
        Me.Text = "Listado de empaques"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_planificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_rango.ResumeLayout(False)
        Me.Gbx_rango.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents rbt_orden As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_estado As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_entrega As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_estado As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_generar_informe As System.Windows.Forms.Button
    Friend WithEvents dgv_planificacion As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Gbx_rango As System.Windows.Forms.GroupBox
    Friend WithEvents rbt_rango_sinenviar As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_rango_enviadas As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_rango_todas As System.Windows.Forms.RadioButton
End Class
