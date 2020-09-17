<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Despacho
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
        Me.tbc_despacho = New System.Windows.Forms.TabControl()
        Me.tbp_empaque = New System.Windows.Forms.TabPage()
        Me.btn_emp_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_emp_quitar_orden = New System.Windows.Forms.Button()
        Me.dgv_emp_lista_ordenes = New System.Windows.Forms.DataGridView()
        Me.btn_emp_buscar_orden = New System.Windows.Forms.Button()
        Me.dtp_fecha_estado = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_emp_guardar = New System.Windows.Forms.Button()
        Me.tbp_logistica = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_numero_despacho = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_chofer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_Hora_salida = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Fecha_salida = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_numero_remito = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_quitar_orden = New System.Windows.Forms.Button()
        Me.dgv_lista_ordenes = New System.Windows.Forms.DataGridView()
        Me.btnBuscar_orden = New System.Windows.Forms.Button()
        Me.Btn_guardar = New System.Windows.Forms.Button()
        Me.tbc_despacho.SuspendLayout()
        Me.tbp_empaque.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_emp_lista_ordenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbp_logistica.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_lista_ordenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbc_despacho
        '
        Me.tbc_despacho.Controls.Add(Me.tbp_empaque)
        Me.tbc_despacho.Controls.Add(Me.tbp_logistica)
        Me.tbc_despacho.Location = New System.Drawing.Point(9, 12)
        Me.tbc_despacho.Name = "tbc_despacho"
        Me.tbc_despacho.SelectedIndex = 0
        Me.tbc_despacho.Size = New System.Drawing.Size(766, 523)
        Me.tbc_despacho.TabIndex = 5
        '
        'tbp_empaque
        '
        Me.tbp_empaque.Controls.Add(Me.btn_emp_cancelar)
        Me.tbp_empaque.Controls.Add(Me.GroupBox4)
        Me.tbp_empaque.Controls.Add(Me.Btn_emp_guardar)
        Me.tbp_empaque.Location = New System.Drawing.Point(4, 22)
        Me.tbp_empaque.Name = "tbp_empaque"
        Me.tbp_empaque.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_empaque.Size = New System.Drawing.Size(758, 497)
        Me.tbp_empaque.TabIndex = 0
        Me.tbp_empaque.Text = "Empaque"
        Me.tbp_empaque.UseVisualStyleBackColor = True
        '
        'btn_emp_cancelar
        '
        Me.btn_emp_cancelar.Location = New System.Drawing.Point(626, 455)
        Me.btn_emp_cancelar.Name = "btn_emp_cancelar"
        Me.btn_emp_cancelar.Size = New System.Drawing.Size(107, 30)
        Me.btn_emp_cancelar.TabIndex = 12
        Me.btn_emp_cancelar.Text = "Cancelar"
        Me.btn_emp_cancelar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_emp_quitar_orden)
        Me.GroupBox4.Controls.Add(Me.dgv_emp_lista_ordenes)
        Me.GroupBox4.Controls.Add(Me.btn_emp_buscar_orden)
        Me.GroupBox4.Controls.Add(Me.dtp_fecha_estado)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(731, 438)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle de órdenes"
        '
        'btn_emp_quitar_orden
        '
        Me.btn_emp_quitar_orden.Location = New System.Drawing.Point(99, 19)
        Me.btn_emp_quitar_orden.Name = "btn_emp_quitar_orden"
        Me.btn_emp_quitar_orden.Size = New System.Drawing.Size(87, 21)
        Me.btn_emp_quitar_orden.TabIndex = 21
        Me.btn_emp_quitar_orden.Text = "Quitar orden"
        Me.btn_emp_quitar_orden.UseVisualStyleBackColor = True
        '
        'dgv_emp_lista_ordenes
        '
        Me.dgv_emp_lista_ordenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_emp_lista_ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_emp_lista_ordenes.Location = New System.Drawing.Point(5, 45)
        Me.dgv_emp_lista_ordenes.Name = "dgv_emp_lista_ordenes"
        Me.dgv_emp_lista_ordenes.Size = New System.Drawing.Size(722, 393)
        Me.dgv_emp_lista_ordenes.TabIndex = 1
        '
        'btn_emp_buscar_orden
        '
        Me.btn_emp_buscar_orden.Location = New System.Drawing.Point(6, 19)
        Me.btn_emp_buscar_orden.Name = "btn_emp_buscar_orden"
        Me.btn_emp_buscar_orden.Size = New System.Drawing.Size(87, 21)
        Me.btn_emp_buscar_orden.TabIndex = 10
        Me.btn_emp_buscar_orden.Text = "Agregar orden"
        Me.btn_emp_buscar_orden.UseVisualStyleBackColor = True
        '
        'dtp_fecha_estado
        '
        Me.dtp_fecha_estado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_estado.Location = New System.Drawing.Point(642, 20)
        Me.dtp_fecha_estado.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dtp_fecha_estado.Name = "dtp_fecha_estado"
        Me.dtp_fecha_estado.Size = New System.Drawing.Size(85, 20)
        Me.dtp_fecha_estado.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(519, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Fecha  de planificacion"
        '
        'Btn_emp_guardar
        '
        Me.Btn_emp_guardar.Location = New System.Drawing.Point(513, 455)
        Me.Btn_emp_guardar.Name = "Btn_emp_guardar"
        Me.Btn_emp_guardar.Size = New System.Drawing.Size(107, 30)
        Me.Btn_emp_guardar.TabIndex = 11
        Me.Btn_emp_guardar.Text = "Guardar"
        Me.Btn_emp_guardar.UseVisualStyleBackColor = True
        '
        'tbp_logistica
        '
        Me.tbp_logistica.Controls.Add(Me.GroupBox1)
        Me.tbp_logistica.Controls.Add(Me.btn_cancelar)
        Me.tbp_logistica.Controls.Add(Me.GroupBox2)
        Me.tbp_logistica.Controls.Add(Me.Btn_guardar)
        Me.tbp_logistica.Location = New System.Drawing.Point(4, 22)
        Me.tbp_logistica.Name = "tbp_logistica"
        Me.tbp_logistica.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_logistica.Size = New System.Drawing.Size(758, 497)
        Me.tbp_logistica.TabIndex = 1
        Me.tbp_logistica.Text = "Logística"
        Me.tbp_logistica.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_numero_despacho)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_chofer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtp_Hora_salida)
        Me.GroupBox1.Controls.Add(Me.dtp_Fecha_salida)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_numero_remito)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 74)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del remito"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Despacho Nº"
        '
        'txt_numero_despacho
        '
        Me.txt_numero_despacho.Enabled = False
        Me.txt_numero_despacho.Location = New System.Drawing.Point(130, 13)
        Me.txt_numero_despacho.Name = "txt_numero_despacho"
        Me.txt_numero_despacho.Size = New System.Drawing.Size(177, 20)
        Me.txt_numero_despacho.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(350, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Chofer"
        '
        'cmb_chofer
        '
        Me.cmb_chofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_chofer.FormattingEnabled = True
        Me.cmb_chofer.Items.AddRange(New Object() {"Seleccionar", "Javier Perea", "Walter Farías", "Laureano", "Guillermo Akerman", "Sebastián Agote", "Marcelo Domínguez", "Tercero", "Retira de planta", "Retira de central", "Instalaciones"})
        Me.cmb_chofer.Location = New System.Drawing.Point(394, 13)
        Me.cmb_chofer.Name = "cmb_chofer"
        Me.cmb_chofer.Size = New System.Drawing.Size(255, 21)
        Me.cmb_chofer.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Remito N°"
        '
        'dtp_Hora_salida
        '
        Me.dtp_Hora_salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Hora_salida.Location = New System.Drawing.Point(564, 46)
        Me.dtp_Hora_salida.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hora_salida.Name = "dtp_Hora_salida"
        Me.dtp_Hora_salida.Size = New System.Drawing.Size(85, 20)
        Me.dtp_Hora_salida.TabIndex = 17
        '
        'dtp_Fecha_salida
        '
        Me.dtp_Fecha_salida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha_salida.Location = New System.Drawing.Point(473, 46)
        Me.dtp_Fecha_salida.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dtp_Fecha_salida.Name = "dtp_Fecha_salida"
        Me.dtp_Fecha_salida.Size = New System.Drawing.Size(85, 20)
        Me.dtp_Fecha_salida.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(350, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Fecha  y hora de salida"
        '
        'txt_numero_remito
        '
        Me.txt_numero_remito.Location = New System.Drawing.Point(130, 44)
        Me.txt_numero_remito.Name = "txt_numero_remito"
        Me.txt_numero_remito.Size = New System.Drawing.Size(177, 20)
        Me.txt_numero_remito.TabIndex = 12
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(630, 450)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(107, 30)
        Me.btn_cancelar.TabIndex = 8
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_quitar_orden)
        Me.GroupBox2.Controls.Add(Me.dgv_lista_ordenes)
        Me.GroupBox2.Controls.Add(Me.btnBuscar_orden)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(731, 360)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle del remito"
        '
        'btn_quitar_orden
        '
        Me.btn_quitar_orden.Location = New System.Drawing.Point(99, 19)
        Me.btn_quitar_orden.Name = "btn_quitar_orden"
        Me.btn_quitar_orden.Size = New System.Drawing.Size(87, 21)
        Me.btn_quitar_orden.TabIndex = 21
        Me.btn_quitar_orden.Text = "Quitar orden"
        Me.btn_quitar_orden.UseVisualStyleBackColor = True
        '
        'dgv_lista_ordenes
        '
        Me.dgv_lista_ordenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_lista_ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista_ordenes.Location = New System.Drawing.Point(5, 45)
        Me.dgv_lista_ordenes.Name = "dgv_lista_ordenes"
        Me.dgv_lista_ordenes.Size = New System.Drawing.Size(722, 309)
        Me.dgv_lista_ordenes.TabIndex = 1
        '
        'btnBuscar_orden
        '
        Me.btnBuscar_orden.Location = New System.Drawing.Point(6, 19)
        Me.btnBuscar_orden.Name = "btnBuscar_orden"
        Me.btnBuscar_orden.Size = New System.Drawing.Size(87, 21)
        Me.btnBuscar_orden.TabIndex = 10
        Me.btnBuscar_orden.Text = "Agregar orden"
        Me.btnBuscar_orden.UseVisualStyleBackColor = True
        '
        'Btn_guardar
        '
        Me.Btn_guardar.Location = New System.Drawing.Point(517, 450)
        Me.Btn_guardar.Name = "Btn_guardar"
        Me.Btn_guardar.Size = New System.Drawing.Size(107, 30)
        Me.Btn_guardar.TabIndex = 7
        Me.Btn_guardar.Text = "Guardar"
        Me.Btn_guardar.UseVisualStyleBackColor = True
        '
        'frm_Despacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 539)
        Me.Controls.Add(Me.tbc_despacho)
        Me.Name = "frm_Despacho"
        Me.Text = "Despacho"
        Me.tbc_despacho.ResumeLayout(False)
        Me.tbp_empaque.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgv_emp_lista_ordenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbp_logistica.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_lista_ordenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbc_despacho As System.Windows.Forms.TabControl
    Friend WithEvents tbp_empaque As System.Windows.Forms.TabPage
    Friend WithEvents tbp_logistica As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_despacho As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_chofer As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp_Hora_salida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Fecha_salida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_remito As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_quitar_orden As System.Windows.Forms.Button
    Friend WithEvents dgv_lista_ordenes As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar_orden As System.Windows.Forms.Button
    Friend WithEvents Btn_guardar As System.Windows.Forms.Button
    Friend WithEvents dtp_fecha_estado As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_emp_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_emp_quitar_orden As System.Windows.Forms.Button
    Friend WithEvents dgv_emp_lista_ordenes As System.Windows.Forms.DataGridView
    Friend WithEvents btn_emp_buscar_orden As System.Windows.Forms.Button
    Friend WithEvents Btn_emp_guardar As System.Windows.Forms.Button
End Class
