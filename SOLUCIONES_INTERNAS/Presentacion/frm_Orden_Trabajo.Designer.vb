<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Orden_Trabajo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Orden_Trabajo))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnBuscar_cliente = New System.Windows.Forms.Button()
        Me.txt_id_cliente = New System.Windows.Forms.TextBox()
        Me.cboTipo_Orden = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_mejoras = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.txt_id_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpFecha_Orden_Trabajo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar_Vendedor = New System.Windows.Forms.Button()
        Me.txtNombre_vendedor = New System.Windows.Forms.TextBox()
        Me.txtid_vendedor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txt_nombre_cliente = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtNumero_Orden_Trabajo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnImprimirFormulario = New System.Windows.Forms.Button()
        Me.GroupProducto3 = New System.Windows.Forms.GroupBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txt_id_detalle_orden_trabajo3 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.cboPiezas3_Detalle3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnProceso3 = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.cboFormato3_Soporte3 = New System.Windows.Forms.ComboBox()
        Me.cboFormato2_Soporte3 = New System.Windows.Forms.ComboBox()
        Me.cboFormato1_Soporte3 = New System.Windows.Forms.ComboBox()
        Me.txt_Cantidad3_Soporte3 = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje3_Soporte3 = New System.Windows.Forms.TextBox()
        Me.txt_Papel3_Soporte3 = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad2_Soporte3 = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje2_Soporte3 = New System.Windows.Forms.TextBox()
        Me.txt_Papel2_Soporte3 = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad1_Soporte3 = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje1_Soporte3 = New System.Windows.Forms.TextBox()
        Me.txt_Papel1_Soporte3 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cboTipoImpresion3_Detalle3 = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtTamaño3_Detalle3 = New System.Windows.Forms.TextBox()
        Me.txt_cantidad3_detalle3 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnGuardar_Orden_Trabajo = New System.Windows.Forms.Button()
        Me.GroupProducto2 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_id_detalle_orden_trabajo2 = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.cboPiezas2_Detalle2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnProceso2 = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cboFormato3_Soporte2 = New System.Windows.Forms.ComboBox()
        Me.cboFormato2_Soporte2 = New System.Windows.Forms.ComboBox()
        Me.cboFormato1_Soporte2 = New System.Windows.Forms.ComboBox()
        Me.txt_Cantidad3_Soporte2 = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje3_Soporte2 = New System.Windows.Forms.TextBox()
        Me.txt_Papel3_Soporte2 = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad2_Soporte2 = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje2_Soporte2 = New System.Windows.Forms.TextBox()
        Me.txt_Papel2_Soporte2 = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad1_Soporte2 = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje1_Soporte2 = New System.Windows.Forms.TextBox()
        Me.txt_Papel1_Soporte2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboTipoImpresion2_Detalle2 = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtTamaño2_Detalle2 = New System.Windows.Forms.TextBox()
        Me.txt_cantidad2_detalle2 = New System.Windows.Forms.TextBox()
        Me.GroupProducto1 = New System.Windows.Forms.GroupBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txt_id_detalle_orden_trabajo1 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.cboPiezas1_Detalle1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnProceso1 = New System.Windows.Forms.Button()
        Me.cboFormato3_Soporte1 = New System.Windows.Forms.ComboBox()
        Me.cboFormato2_Soporte1 = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_Cantidad3_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje3_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Papel3_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad2_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje2_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Papel2_Soporte1 = New System.Windows.Forms.TextBox()
        Me.cboFormato1_Soporte1 = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_Cantidad1_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje1_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Papel1_Soporte1 = New System.Windows.Forms.TextBox()
        Me.cboTipoImpresion1_Detalle1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTamaño1_Detalle1 = New System.Windows.Forms.TextBox()
        Me.txt_cantidad1_detalle1 = New System.Windows.Forms.TextBox()
        Me.btnCancelar_Orden_Trabajo = New System.Windows.Forms.Button()
        Me.btnActualizar_Orden_Trabajo = New System.Windows.Forms.Button()
        Me.btnNueva_Orden_Trabajo = New System.Windows.Forms.Button()
        Me.dtpFecha_Entrega = New System.Windows.Forms.DateTimePicker()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupProducto3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupProducto2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupProducto1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(78, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Cliente"
        '
        'btnBuscar_cliente
        '
        Me.btnBuscar_cliente.Location = New System.Drawing.Point(365, 117)
        Me.btnBuscar_cliente.Name = "btnBuscar_cliente"
        Me.btnBuscar_cliente.Size = New System.Drawing.Size(52, 23)
        Me.btnBuscar_cliente.TabIndex = 4
        Me.btnBuscar_cliente.Text = "..."
        Me.btnBuscar_cliente.UseVisualStyleBackColor = True
        '
        'txt_id_cliente
        '
        Me.txt_id_cliente.Location = New System.Drawing.Point(423, 117)
        Me.txt_id_cliente.Name = "txt_id_cliente"
        Me.txt_id_cliente.Size = New System.Drawing.Size(17, 20)
        Me.txt_id_cliente.TabIndex = 16
        '
        'cboTipo_Orden
        '
        Me.cboTipo_Orden.FormattingEnabled = True
        Me.cboTipo_Orden.Items.AddRange(New Object() {"DG", "DO", "DI", "DV", "DS"})
        Me.cboTipo_Orden.Location = New System.Drawing.Point(93, 46)
        Me.cboTipo_Orden.MaxLength = 10
        Me.cboTipo_Orden.Name = "cboTipo_Orden"
        Me.cboTipo_Orden.Size = New System.Drawing.Size(94, 21)
        Me.cboTipo_Orden.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cboTipo_Orden, "Si el tipo de Orden no está en el listado, puede agregarla")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Tipo Orden"
        '
        'txt_mejoras
        '
        Me.txt_mejoras.Location = New System.Drawing.Point(615, 117)
        Me.txt_mejoras.MaxLength = 250
        Me.txt_mejoras.Multiline = True
        Me.txt_mejoras.Name = "txt_mejoras"
        Me.txt_mejoras.Size = New System.Drawing.Size(294, 20)
        Me.txt_mejoras.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txt_mejoras, "Por favor, verifique que la Dirección de Entrega sea la correcta.")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(716, 101)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 13)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Dirección de Entrega"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(615, 30)
        Me.txt_observaciones.MaxLength = 250
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(294, 65)
        Me.txt_observaciones.TabIndex = 5
        '
        'txt_id_orden_trabajo
        '
        Me.txt_id_orden_trabajo.Location = New System.Drawing.Point(93, 16)
        Me.txt_id_orden_trabajo.Name = "txt_id_orden_trabajo"
        Me.txt_id_orden_trabajo.Size = New System.Drawing.Size(94, 20)
        Me.txt_id_orden_trabajo.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(722, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 13)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "TN"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(78, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "*"
        '
        'dtpFecha_Orden_Trabajo
        '
        Me.dtpFecha_Orden_Trabajo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_Orden_Trabajo.Location = New System.Drawing.Point(497, 46)
        Me.dtpFecha_Orden_Trabajo.Name = "dtpFecha_Orden_Trabajo"
        Me.dtpFecha_Orden_Trabajo.Size = New System.Drawing.Size(82, 20)
        Me.dtpFecha_Orden_Trabajo.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(502, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Fecha Ingreso"
        '
        'btnBuscar_Vendedor
        '
        Me.btnBuscar_Vendedor.Location = New System.Drawing.Point(365, 85)
        Me.btnBuscar_Vendedor.Name = "btnBuscar_Vendedor"
        Me.btnBuscar_Vendedor.Size = New System.Drawing.Size(52, 23)
        Me.btnBuscar_Vendedor.TabIndex = 3
        Me.btnBuscar_Vendedor.Text = "..."
        Me.btnBuscar_Vendedor.UseVisualStyleBackColor = True
        '
        'txtNombre_vendedor
        '
        Me.txtNombre_vendedor.Location = New System.Drawing.Point(93, 87)
        Me.txtNombre_vendedor.Name = "txtNombre_vendedor"
        Me.txtNombre_vendedor.Size = New System.Drawing.Size(266, 20)
        Me.txtNombre_vendedor.TabIndex = 37
        '
        'txtid_vendedor
        '
        Me.txtid_vendedor.Location = New System.Drawing.Point(423, 86)
        Me.txtid_vendedor.Name = "txtid_vendedor"
        Me.txtid_vendedor.Size = New System.Drawing.Size(17, 20)
        Me.txtid_vendedor.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Vendedor"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.Red
        Me.Label47.Location = New System.Drawing.Point(76, 52)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(11, 13)
        Me.Label47.TabIndex = 49
        Me.Label47.Text = "*"
        '
        'txt_nombre_cliente
        '
        Me.txt_nombre_cliente.Location = New System.Drawing.Point(93, 118)
        Me.txt_nombre_cliente.Name = "txt_nombre_cliente"
        Me.txt_nombre_cliente.Size = New System.Drawing.Size(266, 20)
        Me.txt_nombre_cliente.TabIndex = 50
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.Red
        Me.Label46.Location = New System.Drawing.Point(292, 36)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(11, 13)
        Me.Label46.TabIndex = 53
        Me.Label46.Text = "*"
        '
        'txtNumero_Orden_Trabajo
        '
        Me.txtNumero_Orden_Trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero_Orden_Trabajo.Location = New System.Drawing.Point(306, 16)
        Me.txtNumero_Orden_Trabajo.MaxLength = 10
        Me.txtNumero_Orden_Trabajo.Multiline = True
        Me.txtNumero_Orden_Trabajo.Name = "txtNumero_Orden_Trabajo"
        Me.txtNumero_Orden_Trabajo.Size = New System.Drawing.Size(118, 48)
        Me.txtNumero_Orden_Trabajo.TabIndex = 2
        Me.txtNumero_Orden_Trabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(217, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Número Orden"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnImprimirFormulario
        '
        Me.btnImprimirFormulario.Location = New System.Drawing.Point(558, 654)
        Me.btnImprimirFormulario.Name = "btnImprimirFormulario"
        Me.btnImprimirFormulario.Size = New System.Drawing.Size(108, 33)
        Me.btnImprimirFormulario.TabIndex = 61
        Me.btnImprimirFormulario.Text = "Imprimir Formulario"
        Me.btnImprimirFormulario.UseVisualStyleBackColor = True
        '
        'GroupProducto3
        '
        Me.GroupProducto3.Controls.Add(Me.Label42)
        Me.GroupProducto3.Controls.Add(Me.txt_id_detalle_orden_trabajo3)
        Me.GroupProducto3.Controls.Add(Me.Label53)
        Me.GroupProducto3.Controls.Add(Me.cboPiezas3_Detalle3)
        Me.GroupProducto3.Controls.Add(Me.GroupBox6)
        Me.GroupProducto3.Controls.Add(Me.cboTipoImpresion3_Detalle3)
        Me.GroupProducto3.Controls.Add(Me.Label41)
        Me.GroupProducto3.Controls.Add(Me.Label43)
        Me.GroupProducto3.Controls.Add(Me.Label44)
        Me.GroupProducto3.Controls.Add(Me.txtTamaño3_Detalle3)
        Me.GroupProducto3.Controls.Add(Me.txt_cantidad3_detalle3)
        Me.GroupProducto3.Location = New System.Drawing.Point(20, 481)
        Me.GroupProducto3.Name = "GroupProducto3"
        Me.GroupProducto3.Size = New System.Drawing.Size(889, 167)
        Me.GroupProducto3.TabIndex = 61
        Me.GroupProducto3.TabStop = False
        Me.GroupProducto3.Text = "Producto 3"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(78, 93)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(110, 13)
        Me.Label42.TabIndex = 62
        Me.Label42.Text = "Tamaño (°°° x °°° Mm)"
        '
        'txt_id_detalle_orden_trabajo3
        '
        Me.txt_id_detalle_orden_trabajo3.Location = New System.Drawing.Point(366, 139)
        Me.txt_id_detalle_orden_trabajo3.Name = "txt_id_detalle_orden_trabajo3"
        Me.txt_id_detalle_orden_trabajo3.Size = New System.Drawing.Size(61, 20)
        Me.txt_id_detalle_orden_trabajo3.TabIndex = 61
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(237, 142)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(129, 13)
        Me.Label53.TabIndex = 60
        Me.Label53.Text = "id_detalle_orden_trabajo3"
        '
        'cboPiezas3_Detalle3
        '
        Me.cboPiezas3_Detalle3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPiezas3_Detalle3.FormattingEnabled = True
        Me.cboPiezas3_Detalle3.Location = New System.Drawing.Point(132, 48)
        Me.cboPiezas3_Detalle3.Name = "cboPiezas3_Detalle3"
        Me.cboPiezas3_Detalle3.Size = New System.Drawing.Size(162, 21)
        Me.cboPiezas3_Detalle3.TabIndex = 42
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnProceso3)
        Me.GroupBox6.Controls.Add(Me.Label39)
        Me.GroupBox6.Controls.Add(Me.Label40)
        Me.GroupBox6.Controls.Add(Me.cboFormato3_Soporte3)
        Me.GroupBox6.Controls.Add(Me.cboFormato2_Soporte3)
        Me.GroupBox6.Controls.Add(Me.cboFormato1_Soporte3)
        Me.GroupBox6.Controls.Add(Me.txt_Cantidad3_Soporte3)
        Me.GroupBox6.Controls.Add(Me.txt_Gramaje3_Soporte3)
        Me.GroupBox6.Controls.Add(Me.txt_Papel3_Soporte3)
        Me.GroupBox6.Controls.Add(Me.txt_Cantidad2_Soporte3)
        Me.GroupBox6.Controls.Add(Me.txt_Gramaje2_Soporte3)
        Me.GroupBox6.Controls.Add(Me.txt_Papel2_Soporte3)
        Me.GroupBox6.Controls.Add(Me.txt_Cantidad1_Soporte3)
        Me.GroupBox6.Controls.Add(Me.txt_Gramaje1_Soporte3)
        Me.GroupBox6.Controls.Add(Me.txt_Papel1_Soporte3)
        Me.GroupBox6.Controls.Add(Me.Label34)
        Me.GroupBox6.Controls.Add(Me.Label35)
        Me.GroupBox6.Controls.Add(Me.Label36)
        Me.GroupBox6.Controls.Add(Me.Label37)
        Me.GroupBox6.Controls.Add(Me.Label38)
        Me.GroupBox6.Location = New System.Drawing.Point(442, 11)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(433, 148)
        Me.GroupBox6.TabIndex = 55
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Soportes"
        '
        'btnProceso3
        '
        Me.btnProceso3.Location = New System.Drawing.Point(168, 118)
        Me.btnProceso3.Name = "btnProceso3"
        Me.btnProceso3.Size = New System.Drawing.Size(112, 23)
        Me.btnProceso3.TabIndex = 57
        Me.btnProceso3.Text = "Cargar Proceso"
        Me.btnProceso3.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(186, 18)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(82, 13)
        Me.Label39.TabIndex = 87
        Me.Label39.Text = "Gramaje/Grosor"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(68, 18)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(78, 13)
        Me.Label40.TabIndex = 86
        Me.Label40.Text = "Papel/Sustrato"
        '
        'cboFormato3_Soporte3
        '
        Me.cboFormato3_Soporte3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato3_Soporte3.FormattingEnabled = True
        Me.cboFormato3_Soporte3.Items.AddRange(New Object() {"630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato3_Soporte3.Location = New System.Drawing.Point(338, 93)
        Me.cboFormato3_Soporte3.Name = "cboFormato3_Soporte3"
        Me.cboFormato3_Soporte3.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato3_Soporte3.TabIndex = 56
        '
        'cboFormato2_Soporte3
        '
        Me.cboFormato2_Soporte3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato2_Soporte3.FormattingEnabled = True
        Me.cboFormato2_Soporte3.Items.AddRange(New Object() {"630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato2_Soporte3.Location = New System.Drawing.Point(338, 68)
        Me.cboFormato2_Soporte3.Name = "cboFormato2_Soporte3"
        Me.cboFormato2_Soporte3.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato2_Soporte3.TabIndex = 52
        '
        'cboFormato1_Soporte3
        '
        Me.cboFormato1_Soporte3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato1_Soporte3.FormattingEnabled = True
        Me.cboFormato1_Soporte3.Items.AddRange(New Object() {"630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato1_Soporte3.Location = New System.Drawing.Point(338, 42)
        Me.cboFormato1_Soporte3.Name = "cboFormato1_Soporte3"
        Me.cboFormato1_Soporte3.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato1_Soporte3.TabIndex = 48
        '
        'txt_Cantidad3_Soporte3
        '
        Me.txt_Cantidad3_Soporte3.Location = New System.Drawing.Point(263, 92)
        Me.txt_Cantidad3_Soporte3.Name = "txt_Cantidad3_Soporte3"
        Me.txt_Cantidad3_Soporte3.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad3_Soporte3.TabIndex = 55
        '
        'txt_Gramaje3_Soporte3
        '
        Me.txt_Gramaje3_Soporte3.Location = New System.Drawing.Point(193, 92)
        Me.txt_Gramaje3_Soporte3.MaxLength = 10
        Me.txt_Gramaje3_Soporte3.Name = "txt_Gramaje3_Soporte3"
        Me.txt_Gramaje3_Soporte3.Size = New System.Drawing.Size(64, 20)
        Me.txt_Gramaje3_Soporte3.TabIndex = 54
        '
        'txt_Papel3_Soporte3
        '
        Me.txt_Papel3_Soporte3.Location = New System.Drawing.Point(24, 93)
        Me.txt_Papel3_Soporte3.MaxLength = 50
        Me.txt_Papel3_Soporte3.Name = "txt_Papel3_Soporte3"
        Me.txt_Papel3_Soporte3.Size = New System.Drawing.Size(163, 20)
        Me.txt_Papel3_Soporte3.TabIndex = 53
        '
        'txt_Cantidad2_Soporte3
        '
        Me.txt_Cantidad2_Soporte3.Location = New System.Drawing.Point(263, 66)
        Me.txt_Cantidad2_Soporte3.Name = "txt_Cantidad2_Soporte3"
        Me.txt_Cantidad2_Soporte3.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad2_Soporte3.TabIndex = 51
        '
        'txt_Gramaje2_Soporte3
        '
        Me.txt_Gramaje2_Soporte3.Location = New System.Drawing.Point(193, 66)
        Me.txt_Gramaje2_Soporte3.MaxLength = 10
        Me.txt_Gramaje2_Soporte3.Name = "txt_Gramaje2_Soporte3"
        Me.txt_Gramaje2_Soporte3.Size = New System.Drawing.Size(64, 20)
        Me.txt_Gramaje2_Soporte3.TabIndex = 50
        '
        'txt_Papel2_Soporte3
        '
        Me.txt_Papel2_Soporte3.Location = New System.Drawing.Point(24, 67)
        Me.txt_Papel2_Soporte3.MaxLength = 50
        Me.txt_Papel2_Soporte3.Name = "txt_Papel2_Soporte3"
        Me.txt_Papel2_Soporte3.Size = New System.Drawing.Size(163, 20)
        Me.txt_Papel2_Soporte3.TabIndex = 49
        '
        'txt_Cantidad1_Soporte3
        '
        Me.txt_Cantidad1_Soporte3.Location = New System.Drawing.Point(263, 41)
        Me.txt_Cantidad1_Soporte3.Name = "txt_Cantidad1_Soporte3"
        Me.txt_Cantidad1_Soporte3.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad1_Soporte3.TabIndex = 47
        '
        'txt_Gramaje1_Soporte3
        '
        Me.txt_Gramaje1_Soporte3.Location = New System.Drawing.Point(193, 41)
        Me.txt_Gramaje1_Soporte3.MaxLength = 10
        Me.txt_Gramaje1_Soporte3.Name = "txt_Gramaje1_Soporte3"
        Me.txt_Gramaje1_Soporte3.Size = New System.Drawing.Size(64, 20)
        Me.txt_Gramaje1_Soporte3.TabIndex = 46
        '
        'txt_Papel1_Soporte3
        '
        Me.txt_Papel1_Soporte3.Location = New System.Drawing.Point(24, 42)
        Me.txt_Papel1_Soporte3.MaxLength = 50
        Me.txt_Papel1_Soporte3.Name = "txt_Papel1_Soporte3"
        Me.txt_Papel1_Soporte3.Size = New System.Drawing.Size(163, 20)
        Me.txt_Papel1_Soporte3.TabIndex = 45
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(5, 95)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 13)
        Me.Label34.TabIndex = 58
        Me.Label34.Text = "3"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(5, 70)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(13, 13)
        Me.Label35.TabIndex = 57
        Me.Label35.Text = "2"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(5, 44)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(13, 13)
        Me.Label36.TabIndex = 56
        Me.Label36.Text = "1"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(350, 18)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(71, 13)
        Me.Label37.TabIndex = 29
        Me.Label37.Text = "Formato (Mm)"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(273, 18)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(49, 13)
        Me.Label38.TabIndex = 39
        Me.Label38.Text = "Cantidad"
        '
        'cboTipoImpresion3_Detalle3
        '
        Me.cboTipoImpresion3_Detalle3.FormattingEnabled = True
        Me.cboTipoImpresion3_Detalle3.Items.AddRange(New Object() {"1/0", "1/1", "1/4", "4/0", "4/1", "4/4"})
        Me.cboTipoImpresion3_Detalle3.Location = New System.Drawing.Point(221, 112)
        Me.cboTipoImpresion3_Detalle3.Name = "cboTipoImpresion3_Detalle3"
        Me.cboTipoImpresion3_Detalle3.Size = New System.Drawing.Size(73, 21)
        Me.cboTipoImpresion3_Detalle3.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.cboTipoImpresion3_Detalle3, "Si el tipo de impresión no está en el listado, puede agregarlo.")
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(217, 93)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(76, 13)
        Me.Label41.TabIndex = 36
        Me.Label41.Text = "Tipo Impresión"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(182, 25)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(38, 13)
        Me.Label43.TabIndex = 35
        Me.Label43.Text = "Piezas"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(71, 25)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(49, 13)
        Me.Label44.TabIndex = 35
        Me.Label44.Text = "Cantidad"
        '
        'txtTamaño3_Detalle3
        '
        Me.txtTamaño3_Detalle3.Location = New System.Drawing.Point(67, 113)
        Me.txtTamaño3_Detalle3.MaxLength = 50
        Me.txtTamaño3_Detalle3.Name = "txtTamaño3_Detalle3"
        Me.txtTamaño3_Detalle3.Size = New System.Drawing.Size(134, 20)
        Me.txtTamaño3_Detalle3.TabIndex = 43
        '
        'txt_cantidad3_detalle3
        '
        Me.txt_cantidad3_detalle3.Location = New System.Drawing.Point(67, 48)
        Me.txt_cantidad3_detalle3.Name = "txt_cantidad3_detalle3"
        Me.txt_cantidad3_detalle3.Size = New System.Drawing.Size(59, 20)
        Me.txt_cantidad3_detalle3.TabIndex = 41
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(27, 659)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 13)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "* (campos requeridos)"
        '
        'btnGuardar_Orden_Trabajo
        '
        Me.btnGuardar_Orden_Trabajo.Location = New System.Drawing.Point(672, 654)
        Me.btnGuardar_Orden_Trabajo.Name = "btnGuardar_Orden_Trabajo"
        Me.btnGuardar_Orden_Trabajo.Size = New System.Drawing.Size(75, 33)
        Me.btnGuardar_Orden_Trabajo.TabIndex = 58
        Me.btnGuardar_Orden_Trabajo.Text = "Guardar"
        Me.btnGuardar_Orden_Trabajo.UseVisualStyleBackColor = True
        '
        'GroupProducto2
        '
        Me.GroupProducto2.Controls.Add(Me.Label31)
        Me.GroupProducto2.Controls.Add(Me.txt_id_detalle_orden_trabajo2)
        Me.GroupProducto2.Controls.Add(Me.Label52)
        Me.GroupProducto2.Controls.Add(Me.cboPiezas2_Detalle2)
        Me.GroupProducto2.Controls.Add(Me.GroupBox2)
        Me.GroupProducto2.Controls.Add(Me.cboTipoImpresion2_Detalle2)
        Me.GroupProducto2.Controls.Add(Me.Label30)
        Me.GroupProducto2.Controls.Add(Me.Label32)
        Me.GroupProducto2.Controls.Add(Me.Label33)
        Me.GroupProducto2.Controls.Add(Me.txtTamaño2_Detalle2)
        Me.GroupProducto2.Controls.Add(Me.txt_cantidad2_detalle2)
        Me.GroupProducto2.Location = New System.Drawing.Point(20, 313)
        Me.GroupProducto2.Name = "GroupProducto2"
        Me.GroupProducto2.Size = New System.Drawing.Size(889, 162)
        Me.GroupProducto2.TabIndex = 60
        Me.GroupProducto2.TabStop = False
        Me.GroupProducto2.Text = "Producto 2"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(81, 95)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(110, 13)
        Me.Label31.TabIndex = 60
        Me.Label31.Text = "Tamaño (°°° x °°° Mm)"
        '
        'txt_id_detalle_orden_trabajo2
        '
        Me.txt_id_detalle_orden_trabajo2.Location = New System.Drawing.Point(366, 136)
        Me.txt_id_detalle_orden_trabajo2.Name = "txt_id_detalle_orden_trabajo2"
        Me.txt_id_detalle_orden_trabajo2.Size = New System.Drawing.Size(61, 20)
        Me.txt_id_detalle_orden_trabajo2.TabIndex = 59
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(237, 139)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(129, 13)
        Me.Label52.TabIndex = 58
        Me.Label52.Text = "id_detalle_orden_trabajo2"
        '
        'cboPiezas2_Detalle2
        '
        Me.cboPiezas2_Detalle2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPiezas2_Detalle2.FormattingEnabled = True
        Me.cboPiezas2_Detalle2.Location = New System.Drawing.Point(132, 45)
        Me.cboPiezas2_Detalle2.Name = "cboPiezas2_Detalle2"
        Me.cboPiezas2_Detalle2.Size = New System.Drawing.Size(162, 21)
        Me.cboPiezas2_Detalle2.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnProceso2)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.cboFormato3_Soporte2)
        Me.GroupBox2.Controls.Add(Me.cboFormato2_Soporte2)
        Me.GroupBox2.Controls.Add(Me.cboFormato1_Soporte2)
        Me.GroupBox2.Controls.Add(Me.txt_Cantidad3_Soporte2)
        Me.GroupBox2.Controls.Add(Me.txt_Gramaje3_Soporte2)
        Me.GroupBox2.Controls.Add(Me.txt_Papel3_Soporte2)
        Me.GroupBox2.Controls.Add(Me.txt_Cantidad2_Soporte2)
        Me.GroupBox2.Controls.Add(Me.txt_Gramaje2_Soporte2)
        Me.GroupBox2.Controls.Add(Me.txt_Papel2_Soporte2)
        Me.GroupBox2.Controls.Add(Me.txt_Cantidad1_Soporte2)
        Me.GroupBox2.Controls.Add(Me.txt_Gramaje1_Soporte2)
        Me.GroupBox2.Controls.Add(Me.txt_Papel1_Soporte2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Location = New System.Drawing.Point(443, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 145)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Soportes"
        '
        'btnProceso2
        '
        Me.btnProceso2.Location = New System.Drawing.Point(167, 113)
        Me.btnProceso2.Name = "btnProceso2"
        Me.btnProceso2.Size = New System.Drawing.Size(112, 23)
        Me.btnProceso2.TabIndex = 40
        Me.btnProceso2.Text = "Cargar Proceso"
        Me.btnProceso2.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(186, 17)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(82, 13)
        Me.Label28.TabIndex = 75
        Me.Label28.Text = "Gramaje/Grosor"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(67, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(78, 13)
        Me.Label29.TabIndex = 74
        Me.Label29.Text = "Papel/Sustrato"
        '
        'cboFormato3_Soporte2
        '
        Me.cboFormato3_Soporte2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato3_Soporte2.FormattingEnabled = True
        Me.cboFormato3_Soporte2.Items.AddRange(New Object() {"630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato3_Soporte2.Location = New System.Drawing.Point(338, 88)
        Me.cboFormato3_Soporte2.Name = "cboFormato3_Soporte2"
        Me.cboFormato3_Soporte2.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato3_Soporte2.TabIndex = 39
        '
        'cboFormato2_Soporte2
        '
        Me.cboFormato2_Soporte2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato2_Soporte2.FormattingEnabled = True
        Me.cboFormato2_Soporte2.Items.AddRange(New Object() {"630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato2_Soporte2.Location = New System.Drawing.Point(338, 63)
        Me.cboFormato2_Soporte2.Name = "cboFormato2_Soporte2"
        Me.cboFormato2_Soporte2.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato2_Soporte2.TabIndex = 35
        '
        'cboFormato1_Soporte2
        '
        Me.cboFormato1_Soporte2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato1_Soporte2.FormattingEnabled = True
        Me.cboFormato1_Soporte2.Items.AddRange(New Object() {"630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato1_Soporte2.Location = New System.Drawing.Point(338, 37)
        Me.cboFormato1_Soporte2.Name = "cboFormato1_Soporte2"
        Me.cboFormato1_Soporte2.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato1_Soporte2.TabIndex = 31
        '
        'txt_Cantidad3_Soporte2
        '
        Me.txt_Cantidad3_Soporte2.Location = New System.Drawing.Point(263, 87)
        Me.txt_Cantidad3_Soporte2.Name = "txt_Cantidad3_Soporte2"
        Me.txt_Cantidad3_Soporte2.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad3_Soporte2.TabIndex = 38
        '
        'txt_Gramaje3_Soporte2
        '
        Me.txt_Gramaje3_Soporte2.Location = New System.Drawing.Point(193, 87)
        Me.txt_Gramaje3_Soporte2.MaxLength = 10
        Me.txt_Gramaje3_Soporte2.Name = "txt_Gramaje3_Soporte2"
        Me.txt_Gramaje3_Soporte2.Size = New System.Drawing.Size(64, 20)
        Me.txt_Gramaje3_Soporte2.TabIndex = 37
        '
        'txt_Papel3_Soporte2
        '
        Me.txt_Papel3_Soporte2.Location = New System.Drawing.Point(24, 88)
        Me.txt_Papel3_Soporte2.MaxLength = 50
        Me.txt_Papel3_Soporte2.Name = "txt_Papel3_Soporte2"
        Me.txt_Papel3_Soporte2.Size = New System.Drawing.Size(163, 20)
        Me.txt_Papel3_Soporte2.TabIndex = 36
        '
        'txt_Cantidad2_Soporte2
        '
        Me.txt_Cantidad2_Soporte2.Location = New System.Drawing.Point(263, 61)
        Me.txt_Cantidad2_Soporte2.Name = "txt_Cantidad2_Soporte2"
        Me.txt_Cantidad2_Soporte2.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad2_Soporte2.TabIndex = 34
        '
        'txt_Gramaje2_Soporte2
        '
        Me.txt_Gramaje2_Soporte2.Location = New System.Drawing.Point(193, 61)
        Me.txt_Gramaje2_Soporte2.MaxLength = 10
        Me.txt_Gramaje2_Soporte2.Name = "txt_Gramaje2_Soporte2"
        Me.txt_Gramaje2_Soporte2.Size = New System.Drawing.Size(64, 20)
        Me.txt_Gramaje2_Soporte2.TabIndex = 33
        '
        'txt_Papel2_Soporte2
        '
        Me.txt_Papel2_Soporte2.Location = New System.Drawing.Point(24, 62)
        Me.txt_Papel2_Soporte2.MaxLength = 50
        Me.txt_Papel2_Soporte2.Name = "txt_Papel2_Soporte2"
        Me.txt_Papel2_Soporte2.Size = New System.Drawing.Size(163, 20)
        Me.txt_Papel2_Soporte2.TabIndex = 32
        '
        'txt_Cantidad1_Soporte2
        '
        Me.txt_Cantidad1_Soporte2.Location = New System.Drawing.Point(263, 36)
        Me.txt_Cantidad1_Soporte2.Name = "txt_Cantidad1_Soporte2"
        Me.txt_Cantidad1_Soporte2.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad1_Soporte2.TabIndex = 30
        '
        'txt_Gramaje1_Soporte2
        '
        Me.txt_Gramaje1_Soporte2.Location = New System.Drawing.Point(193, 36)
        Me.txt_Gramaje1_Soporte2.MaxLength = 10
        Me.txt_Gramaje1_Soporte2.Name = "txt_Gramaje1_Soporte2"
        Me.txt_Gramaje1_Soporte2.Size = New System.Drawing.Size(64, 20)
        Me.txt_Gramaje1_Soporte2.TabIndex = 29
        '
        'txt_Papel1_Soporte2
        '
        Me.txt_Papel1_Soporte2.Location = New System.Drawing.Point(24, 37)
        Me.txt_Papel1_Soporte2.MaxLength = 50
        Me.txt_Papel1_Soporte2.Name = "txt_Papel1_Soporte2"
        Me.txt_Papel1_Soporte2.Size = New System.Drawing.Size(163, 20)
        Me.txt_Papel1_Soporte2.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "3"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "1"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(349, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 13)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "Formato (Mm)"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(273, 17)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 13)
        Me.Label27.TabIndex = 39
        Me.Label27.Text = "Cantidad"
        '
        'cboTipoImpresion2_Detalle2
        '
        Me.cboTipoImpresion2_Detalle2.FormattingEnabled = True
        Me.cboTipoImpresion2_Detalle2.Items.AddRange(New Object() {"1/0", "1/1", "1/4", "4/0", "4/1", "4/4"})
        Me.cboTipoImpresion2_Detalle2.Location = New System.Drawing.Point(221, 118)
        Me.cboTipoImpresion2_Detalle2.Name = "cboTipoImpresion2_Detalle2"
        Me.cboTipoImpresion2_Detalle2.Size = New System.Drawing.Size(72, 21)
        Me.cboTipoImpresion2_Detalle2.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.cboTipoImpresion2_Detalle2, "Si el tipo de impresión no está en el listado, puede agregarlo.")
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(218, 95)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(76, 13)
        Me.Label30.TabIndex = 36
        Me.Label30.Text = "Tipo Impresión"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(182, 28)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(38, 13)
        Me.Label32.TabIndex = 35
        Me.Label32.Text = "Piezas"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(71, 28)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(49, 13)
        Me.Label33.TabIndex = 35
        Me.Label33.Text = "Cantidad"
        '
        'txtTamaño2_Detalle2
        '
        Me.txtTamaño2_Detalle2.Location = New System.Drawing.Point(67, 119)
        Me.txtTamaño2_Detalle2.MaxLength = 50
        Me.txtTamaño2_Detalle2.Name = "txtTamaño2_Detalle2"
        Me.txtTamaño2_Detalle2.Size = New System.Drawing.Size(134, 20)
        Me.txtTamaño2_Detalle2.TabIndex = 26
        '
        'txt_cantidad2_detalle2
        '
        Me.txt_cantidad2_detalle2.Location = New System.Drawing.Point(67, 45)
        Me.txt_cantidad2_detalle2.Name = "txt_cantidad2_detalle2"
        Me.txt_cantidad2_detalle2.Size = New System.Drawing.Size(59, 20)
        Me.txt_cantidad2_detalle2.TabIndex = 24
        '
        'GroupProducto1
        '
        Me.GroupProducto1.Controls.Add(Me.Label51)
        Me.GroupProducto1.Controls.Add(Me.txt_id_detalle_orden_trabajo1)
        Me.GroupProducto1.Controls.Add(Me.Label50)
        Me.GroupProducto1.Controls.Add(Me.Label49)
        Me.GroupProducto1.Controls.Add(Me.Label45)
        Me.GroupProducto1.Controls.Add(Me.Label48)
        Me.GroupProducto1.Controls.Add(Me.cboPiezas1_Detalle1)
        Me.GroupProducto1.Controls.Add(Me.GroupBox5)
        Me.GroupProducto1.Controls.Add(Me.cboTipoImpresion1_Detalle1)
        Me.GroupProducto1.Controls.Add(Me.Label8)
        Me.GroupProducto1.Controls.Add(Me.Label7)
        Me.GroupProducto1.Controls.Add(Me.Label3)
        Me.GroupProducto1.Controls.Add(Me.Label2)
        Me.GroupProducto1.Controls.Add(Me.txtTamaño1_Detalle1)
        Me.GroupProducto1.Controls.Add(Me.txt_cantidad1_detalle1)
        Me.GroupProducto1.Location = New System.Drawing.Point(20, 143)
        Me.GroupProducto1.Name = "GroupProducto1"
        Me.GroupProducto1.Size = New System.Drawing.Size(889, 164)
        Me.GroupProducto1.TabIndex = 59
        Me.GroupProducto1.TabStop = False
        Me.GroupProducto1.Text = "Producto 1"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.Red
        Me.Label51.Location = New System.Drawing.Point(293, 96)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(11, 13)
        Me.Label51.TabIndex = 60
        Me.Label51.Text = "*"
        '
        'txt_id_detalle_orden_trabajo1
        '
        Me.txt_id_detalle_orden_trabajo1.Location = New System.Drawing.Point(366, 136)
        Me.txt_id_detalle_orden_trabajo1.Name = "txt_id_detalle_orden_trabajo1"
        Me.txt_id_detalle_orden_trabajo1.Size = New System.Drawing.Size(61, 20)
        Me.txt_id_detalle_orden_trabajo1.TabIndex = 57
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.Red
        Me.Label50.Location = New System.Drawing.Point(186, 95)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(11, 13)
        Me.Label50.TabIndex = 59
        Me.Label50.Text = "*"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.Red
        Me.Label49.Location = New System.Drawing.Point(218, 34)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(11, 13)
        Me.Label49.TabIndex = 58
        Me.Label49.Text = "*"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(237, 139)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(129, 13)
        Me.Label45.TabIndex = 56
        Me.Label45.Text = "id_detalle_orden_trabajo1"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.Color.Red
        Me.Label48.Location = New System.Drawing.Point(117, 33)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(11, 13)
        Me.Label48.TabIndex = 57
        Me.Label48.Text = "*"
        '
        'cboPiezas1_Detalle1
        '
        Me.cboPiezas1_Detalle1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPiezas1_Detalle1.FormattingEnabled = True
        Me.cboPiezas1_Detalle1.Location = New System.Drawing.Point(132, 52)
        Me.cboPiezas1_Detalle1.Name = "cboPiezas1_Detalle1"
        Me.cboPiezas1_Detalle1.Size = New System.Drawing.Size(162, 21)
        Me.cboPiezas1_Detalle1.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnProceso1)
        Me.GroupBox5.Controls.Add(Me.cboFormato3_Soporte1)
        Me.GroupBox5.Controls.Add(Me.cboFormato2_Soporte1)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txt_Cantidad3_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Gramaje3_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Papel3_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Cantidad2_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Gramaje2_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Papel2_Soporte1)
        Me.GroupBox5.Controls.Add(Me.cboFormato1_Soporte1)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.txt_Cantidad1_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Gramaje1_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Papel1_Soporte1)
        Me.GroupBox5.Location = New System.Drawing.Point(443, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(433, 146)
        Me.GroupBox5.TabIndex = 55
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Soportes"
        '
        'btnProceso1
        '
        Me.btnProceso1.Location = New System.Drawing.Point(167, 115)
        Me.btnProceso1.Name = "btnProceso1"
        Me.btnProceso1.Size = New System.Drawing.Size(112, 23)
        Me.btnProceso1.TabIndex = 59
        Me.btnProceso1.Text = "Cargar Proceso"
        Me.btnProceso1.UseVisualStyleBackColor = True
        '
        'cboFormato3_Soporte1
        '
        Me.cboFormato3_Soporte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato3_Soporte1.FormattingEnabled = True
        Me.cboFormato3_Soporte1.Items.AddRange(New Object() {"630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato3_Soporte1.Location = New System.Drawing.Point(338, 89)
        Me.cboFormato3_Soporte1.Name = "cboFormato3_Soporte1"
        Me.cboFormato3_Soporte1.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato3_Soporte1.TabIndex = 22
        '
        'cboFormato2_Soporte1
        '
        Me.cboFormato2_Soporte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato2_Soporte1.FormattingEnabled = True
        Me.cboFormato2_Soporte1.Items.AddRange(New Object() {"630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato2_Soporte1.Location = New System.Drawing.Point(338, 64)
        Me.cboFormato2_Soporte1.Name = "cboFormato2_Soporte1"
        Me.cboFormato2_Soporte1.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato2_Soporte1.TabIndex = 18
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 94)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 13)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "3"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 69)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 13)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "1"
        '
        'txt_Cantidad3_Soporte1
        '
        Me.txt_Cantidad3_Soporte1.Location = New System.Drawing.Point(263, 89)
        Me.txt_Cantidad3_Soporte1.Name = "txt_Cantidad3_Soporte1"
        Me.txt_Cantidad3_Soporte1.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad3_Soporte1.TabIndex = 21
        '
        'txt_Gramaje3_Soporte1
        '
        Me.txt_Gramaje3_Soporte1.Location = New System.Drawing.Point(193, 89)
        Me.txt_Gramaje3_Soporte1.MaxLength = 10
        Me.txt_Gramaje3_Soporte1.Name = "txt_Gramaje3_Soporte1"
        Me.txt_Gramaje3_Soporte1.Size = New System.Drawing.Size(64, 20)
        Me.txt_Gramaje3_Soporte1.TabIndex = 20
        '
        'txt_Papel3_Soporte1
        '
        Me.txt_Papel3_Soporte1.Location = New System.Drawing.Point(24, 90)
        Me.txt_Papel3_Soporte1.MaxLength = 50
        Me.txt_Papel3_Soporte1.Name = "txt_Papel3_Soporte1"
        Me.txt_Papel3_Soporte1.Size = New System.Drawing.Size(163, 20)
        Me.txt_Papel3_Soporte1.TabIndex = 19
        '
        'txt_Cantidad2_Soporte1
        '
        Me.txt_Cantidad2_Soporte1.Location = New System.Drawing.Point(263, 63)
        Me.txt_Cantidad2_Soporte1.Name = "txt_Cantidad2_Soporte1"
        Me.txt_Cantidad2_Soporte1.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad2_Soporte1.TabIndex = 17
        '
        'txt_Gramaje2_Soporte1
        '
        Me.txt_Gramaje2_Soporte1.Location = New System.Drawing.Point(193, 63)
        Me.txt_Gramaje2_Soporte1.MaxLength = 10
        Me.txt_Gramaje2_Soporte1.Name = "txt_Gramaje2_Soporte1"
        Me.txt_Gramaje2_Soporte1.Size = New System.Drawing.Size(64, 20)
        Me.txt_Gramaje2_Soporte1.TabIndex = 16
        '
        'txt_Papel2_Soporte1
        '
        Me.txt_Papel2_Soporte1.Location = New System.Drawing.Point(24, 64)
        Me.txt_Papel2_Soporte1.MaxLength = 50
        Me.txt_Papel2_Soporte1.Name = "txt_Papel2_Soporte1"
        Me.txt_Papel2_Soporte1.Size = New System.Drawing.Size(163, 20)
        Me.txt_Papel2_Soporte1.TabIndex = 15
        '
        'cboFormato1_Soporte1
        '
        Me.cboFormato1_Soporte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato1_Soporte1.FormattingEnabled = True
        Me.cboFormato1_Soporte1.Items.AddRange(New Object() {"630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato1_Soporte1.Location = New System.Drawing.Point(338, 38)
        Me.cboFormato1_Soporte1.Name = "cboFormato1_Soporte1"
        Me.cboFormato1_Soporte1.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato1_Soporte1.TabIndex = 14
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(349, 17)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(71, 13)
        Me.Label26.TabIndex = 29
        Me.Label26.Text = "Formato (Mm)"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(273, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 13)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "Cantidad"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(186, 17)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(82, 13)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "Gramaje/Grosor"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(67, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 13)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "Papel/Sustrato"
        '
        'txt_Cantidad1_Soporte1
        '
        Me.txt_Cantidad1_Soporte1.Location = New System.Drawing.Point(263, 38)
        Me.txt_Cantidad1_Soporte1.Name = "txt_Cantidad1_Soporte1"
        Me.txt_Cantidad1_Soporte1.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad1_Soporte1.TabIndex = 13
        '
        'txt_Gramaje1_Soporte1
        '
        Me.txt_Gramaje1_Soporte1.Location = New System.Drawing.Point(193, 38)
        Me.txt_Gramaje1_Soporte1.MaxLength = 10
        Me.txt_Gramaje1_Soporte1.Name = "txt_Gramaje1_Soporte1"
        Me.txt_Gramaje1_Soporte1.Size = New System.Drawing.Size(64, 20)
        Me.txt_Gramaje1_Soporte1.TabIndex = 12
        '
        'txt_Papel1_Soporte1
        '
        Me.txt_Papel1_Soporte1.Location = New System.Drawing.Point(24, 39)
        Me.txt_Papel1_Soporte1.MaxLength = 50
        Me.txt_Papel1_Soporte1.Name = "txt_Papel1_Soporte1"
        Me.txt_Papel1_Soporte1.Size = New System.Drawing.Size(163, 20)
        Me.txt_Papel1_Soporte1.TabIndex = 11
        '
        'cboTipoImpresion1_Detalle1
        '
        Me.cboTipoImpresion1_Detalle1.FormattingEnabled = True
        Me.cboTipoImpresion1_Detalle1.Items.AddRange(New Object() {"1/0", "1/1", "1/4", "4/0", "4/1", "4/4"})
        Me.cboTipoImpresion1_Detalle1.Location = New System.Drawing.Point(221, 114)
        Me.cboTipoImpresion1_Detalle1.Name = "cboTipoImpresion1_Detalle1"
        Me.cboTipoImpresion1_Detalle1.Size = New System.Drawing.Size(73, 21)
        Me.cboTipoImpresion1_Detalle1.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.cboTipoImpresion1_Detalle1, "Si el tipo de impresión no está en el listado, puede agregarlo.")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(218, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Tipo Impresión"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Tamaño (°°° x °°° Mm)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(182, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Piezas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Cantidad"
        '
        'txtTamaño1_Detalle1
        '
        Me.txtTamaño1_Detalle1.Location = New System.Drawing.Point(67, 115)
        Me.txtTamaño1_Detalle1.MaxLength = 50
        Me.txtTamaño1_Detalle1.Name = "txtTamaño1_Detalle1"
        Me.txtTamaño1_Detalle1.Size = New System.Drawing.Size(134, 20)
        Me.txtTamaño1_Detalle1.TabIndex = 9
        '
        'txt_cantidad1_detalle1
        '
        Me.txt_cantidad1_detalle1.Location = New System.Drawing.Point(67, 53)
        Me.txt_cantidad1_detalle1.Name = "txt_cantidad1_detalle1"
        Me.txt_cantidad1_detalle1.Size = New System.Drawing.Size(59, 20)
        Me.txt_cantidad1_detalle1.TabIndex = 7
        '
        'btnCancelar_Orden_Trabajo
        '
        Me.btnCancelar_Orden_Trabajo.Location = New System.Drawing.Point(834, 654)
        Me.btnCancelar_Orden_Trabajo.Name = "btnCancelar_Orden_Trabajo"
        Me.btnCancelar_Orden_Trabajo.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar_Orden_Trabajo.TabIndex = 59
        Me.btnCancelar_Orden_Trabajo.Text = "Cancelar"
        Me.btnCancelar_Orden_Trabajo.UseVisualStyleBackColor = True
        '
        'btnActualizar_Orden_Trabajo
        '
        Me.btnActualizar_Orden_Trabajo.Location = New System.Drawing.Point(753, 654)
        Me.btnActualizar_Orden_Trabajo.Name = "btnActualizar_Orden_Trabajo"
        Me.btnActualizar_Orden_Trabajo.Size = New System.Drawing.Size(75, 33)
        Me.btnActualizar_Orden_Trabajo.TabIndex = 62
        Me.btnActualizar_Orden_Trabajo.Text = "Actualizar"
        Me.btnActualizar_Orden_Trabajo.UseVisualStyleBackColor = True
        '
        'btnNueva_Orden_Trabajo
        '
        Me.btnNueva_Orden_Trabajo.Location = New System.Drawing.Point(477, 654)
        Me.btnNueva_Orden_Trabajo.Name = "btnNueva_Orden_Trabajo"
        Me.btnNueva_Orden_Trabajo.Size = New System.Drawing.Size(75, 33)
        Me.btnNueva_Orden_Trabajo.TabIndex = 60
        Me.btnNueva_Orden_Trabajo.Text = "Nuevo"
        Me.btnNueva_Orden_Trabajo.UseVisualStyleBackColor = True
        '
        'dtpFecha_Entrega
        '
        Me.dtpFecha_Entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_Entrega.Location = New System.Drawing.Point(497, 119)
        Me.dtpFecha_Entrega.Name = "dtpFecha_Entrega"
        Me.dtpFecha_Entrega.Size = New System.Drawing.Size(82, 20)
        Me.dtpFecha_Entrega.TabIndex = 64
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(497, 104)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(77, 13)
        Me.Label54.TabIndex = 63
        Me.Label54.Text = "Fecha Entrega"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.Red
        Me.Label55.Location = New System.Drawing.Point(582, 123)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(11, 13)
        Me.Label55.TabIndex = 65
        Me.Label55.Text = "*"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.Color.Red
        Me.Label56.Location = New System.Drawing.Point(822, 102)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(11, 13)
        Me.Label56.TabIndex = 66
        Me.Label56.Text = "*"
        '
        'frm_Orden_Trabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 696)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.dtpFecha_Entrega)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.btnImprimirFormulario)
        Me.Controls.Add(Me.GroupProducto3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnGuardar_Orden_Trabajo)
        Me.Controls.Add(Me.GroupProducto2)
        Me.Controls.Add(Me.GroupProducto1)
        Me.Controls.Add(Me.btnCancelar_Orden_Trabajo)
        Me.Controls.Add(Me.btnActualizar_Orden_Trabajo)
        Me.Controls.Add(Me.btnNueva_Orden_Trabajo)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.txtNumero_Orden_Trabajo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_nombre_cliente)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboTipo_Orden)
        Me.Controls.Add(Me.btnBuscar_cliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_id_orden_trabajo)
        Me.Controls.Add(Me.txt_id_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_mejoras)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dtpFecha_Orden_Trabajo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBuscar_Vendedor)
        Me.Controls.Add(Me.txtNombre_vendedor)
        Me.Controls.Add(Me.txtid_vendedor)
        Me.Controls.Add(Me.Label9)
        Me.Name = "frm_Orden_Trabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de trabajo"
        Me.GroupProducto3.ResumeLayout(False)
        Me.GroupProducto3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupProducto2.ResumeLayout(False)
        Me.GroupProducto2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupProducto1.ResumeLayout(False)
        Me.GroupProducto1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_cliente As System.Windows.Forms.Button
    Friend WithEvents txt_id_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboTipo_Orden As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_mejoras As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_Orden_Trabajo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_Vendedor As System.Windows.Forms.Button
    Friend WithEvents txtNombre_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtid_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_Orden_Trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnImprimirFormulario As System.Windows.Forms.Button
    Friend WithEvents GroupProducto3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id_detalle_orden_trabajo3 As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents cboPiezas3_Detalle3 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProceso3 As System.Windows.Forms.Button
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents cboFormato3_Soporte3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboFormato2_Soporte3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboFormato1_Soporte3 As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Cantidad3_Soporte3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje3_Soporte3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel3_Soporte3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad2_Soporte3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje2_Soporte3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel2_Soporte3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad1_Soporte3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje1_Soporte3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel1_Soporte3 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents cboTipoImpresion3_Detalle3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtTamaño3_Detalle3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad3_detalle3 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar_Orden_Trabajo As System.Windows.Forms.Button
    Friend WithEvents GroupProducto2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id_detalle_orden_trabajo2 As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents cboPiezas2_Detalle2 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProceso2 As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cboFormato3_Soporte2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboFormato2_Soporte2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboFormato1_Soporte2 As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Cantidad3_Soporte2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje3_Soporte2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel3_Soporte2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad2_Soporte2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje2_Soporte2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel2_Soporte2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad1_Soporte2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje1_Soporte2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel1_Soporte2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cboTipoImpresion2_Detalle2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtTamaño2_Detalle2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad2_detalle2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupProducto1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txt_id_detalle_orden_trabajo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents cboPiezas1_Detalle1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFormato3_Soporte1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboFormato2_Soporte1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_Cantidad3_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje3_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel3_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad2_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje2_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel2_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents cboFormato1_Soporte1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_Cantidad1_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje1_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel1_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoImpresion1_Detalle1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTamaño1_Detalle1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad1_detalle1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar_Orden_Trabajo As System.Windows.Forms.Button
    Friend WithEvents btnActualizar_Orden_Trabajo As System.Windows.Forms.Button
    Friend WithEvents btnNueva_Orden_Trabajo As System.Windows.Forms.Button
    Friend WithEvents btnProceso1 As System.Windows.Forms.Button
    Friend WithEvents dtpFecha_Entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
