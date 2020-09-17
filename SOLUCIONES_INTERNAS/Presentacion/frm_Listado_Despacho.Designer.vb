<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Listado_Despacho
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
        Me.dgv_remitos = New System.Windows.Forms.DataGridView()
        Me.dgv_orden_x_remito = New System.Windows.Forms.DataGridView()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.rbt_remito = New System.Windows.Forms.RadioButton()
        Me.rbt_despacho = New System.Windows.Forms.RadioButton()
        Me.rbt_entrega = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha_salida = New System.Windows.Forms.DateTimePicker()
        Me.btn_agregarodt = New System.Windows.Forms.Button()
        Me.btn_generar_informe = New System.Windows.Forms.Button()
        CType(Me.dgv_remitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_orden_x_remito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_remitos
        '
        Me.dgv_remitos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_remitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_remitos.Location = New System.Drawing.Point(13, 93)
        Me.dgv_remitos.MultiSelect = False
        Me.dgv_remitos.Name = "dgv_remitos"
        Me.dgv_remitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_remitos.Size = New System.Drawing.Size(859, 193)
        Me.dgv_remitos.TabIndex = 0
        '
        'dgv_orden_x_remito
        '
        Me.dgv_orden_x_remito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_orden_x_remito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_orden_x_remito.Location = New System.Drawing.Point(13, 292)
        Me.dgv_orden_x_remito.MultiSelect = False
        Me.dgv_orden_x_remito.Name = "dgv_orden_x_remito"
        Me.dgv_orden_x_remito.Size = New System.Drawing.Size(859, 188)
        Me.dgv_orden_x_remito.TabIndex = 1
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(12, 53)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(168, 20)
        Me.txt_buscar.TabIndex = 2
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(664, 486)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(101, 33)
        Me.btn_modificar.TabIndex = 5
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(664, 486)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(101, 33)
        Me.btn_eliminar.TabIndex = 6
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(771, 486)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(101, 33)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'rbt_remito
        '
        Me.rbt_remito.AutoSize = True
        Me.rbt_remito.Location = New System.Drawing.Point(95, 19)
        Me.rbt_remito.Name = "rbt_remito"
        Me.rbt_remito.Size = New System.Drawing.Size(68, 17)
        Me.rbt_remito.TabIndex = 8
        Me.rbt_remito.TabStop = True
        Me.rbt_remito.Text = "N° remito"
        Me.rbt_remito.UseVisualStyleBackColor = True
        '
        'rbt_despacho
        '
        Me.rbt_despacho.AutoSize = True
        Me.rbt_despacho.Location = New System.Drawing.Point(6, 19)
        Me.rbt_despacho.Name = "rbt_despacho"
        Me.rbt_despacho.Size = New System.Drawing.Size(87, 17)
        Me.rbt_despacho.TabIndex = 9
        Me.rbt_despacho.TabStop = True
        Me.rbt_despacho.Text = "N° despacho"
        Me.rbt_despacho.UseVisualStyleBackColor = True
        '
        'rbt_entrega
        '
        Me.rbt_entrega.AutoSize = True
        Me.rbt_entrega.Location = New System.Drawing.Point(169, 19)
        Me.rbt_entrega.Name = "rbt_entrega"
        Me.rbt_entrega.Size = New System.Drawing.Size(85, 17)
        Me.rbt_entrega.TabIndex = 10
        Me.rbt_entrega.TabStop = True
        Me.rbt_entrega.Text = "Fecha salida"
        Me.rbt_entrega.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbt_remito)
        Me.GroupBox1.Controls.Add(Me.rbt_entrega)
        Me.GroupBox1.Controls.Add(Me.rbt_despacho)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 45)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por"
        '
        'dtp_fecha_salida
        '
        Me.dtp_fecha_salida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_salida.Location = New System.Drawing.Point(186, 53)
        Me.dtp_fecha_salida.Name = "dtp_fecha_salida"
        Me.dtp_fecha_salida.Size = New System.Drawing.Size(92, 20)
        Me.dtp_fecha_salida.TabIndex = 12
        '
        'btn_agregarodt
        '
        Me.btn_agregarodt.Location = New System.Drawing.Point(557, 486)
        Me.btn_agregarodt.Name = "btn_agregarodt"
        Me.btn_agregarodt.Size = New System.Drawing.Size(101, 33)
        Me.btn_agregarodt.TabIndex = 13
        Me.btn_agregarodt.Text = "Agregar odt"
        Me.btn_agregarodt.UseVisualStyleBackColor = True
        '
        'btn_generar_informe
        '
        Me.btn_generar_informe.Location = New System.Drawing.Point(12, 486)
        Me.btn_generar_informe.Name = "btn_generar_informe"
        Me.btn_generar_informe.Size = New System.Drawing.Size(101, 33)
        Me.btn_generar_informe.TabIndex = 14
        Me.btn_generar_informe.Text = "Generar informe"
        Me.btn_generar_informe.UseVisualStyleBackColor = True
        '
        'frm_Listado_Despacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 521)
        Me.Controls.Add(Me.btn_generar_informe)
        Me.Controls.Add(Me.btn_agregarodt)
        Me.Controls.Add(Me.dtp_fecha_salida)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.dgv_orden_x_remito)
        Me.Controls.Add(Me.dgv_remitos)
        Me.Name = "frm_Listado_Despacho"
        Me.Text = "Listado de despachos"
        CType(Me.dgv_remitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_orden_x_remito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_remitos As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_orden_x_remito As System.Windows.Forms.DataGridView
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents rbt_remito As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_despacho As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_entrega As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_salida As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_agregarodt As System.Windows.Forms.Button
    Friend WithEvents btn_generar_informe As System.Windows.Forms.Button
End Class
