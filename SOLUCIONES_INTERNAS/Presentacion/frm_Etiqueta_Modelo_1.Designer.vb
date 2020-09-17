<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Etiqueta_Modelo_1
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescripcionEntrega = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtSolicitante = New System.Windows.Forms.TextBox()
        Me.txtId_Cliente = New System.Windows.Forms.TextBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtDirigidoA = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cboLogo = New System.Windows.Forms.ComboBox()
        Me.txtSeccion = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtTotalBultos = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtUnidadxBulto = New System.Windows.Forms.TextBox()
        Me.txtCantidadBultos = New System.Windows.Forms.TextBox()
        Me.txtDespachado = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnLimpiarEtiqueta = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txt_id_orden = New System.Windows.Forms.TextBox()
        Me.btnBuscar_Orden = New System.Windows.Forms.Button()
        Me.txt_orden = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.dgv_Etiquetas = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGenerarEtiquetas = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_Etiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(10, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descripción: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirigido a: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(496, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Solicitante: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(496, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Domicilio: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(502, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Localidad: "
        '
        'txtDescripcionEntrega
        '
        Me.txtDescripcionEntrega.Location = New System.Drawing.Point(94, 19)
        Me.txtDescripcionEntrega.Multiline = True
        Me.txtDescripcionEntrega.Name = "txtDescripcionEntrega"
        Me.txtDescripcionEntrega.Size = New System.Drawing.Size(379, 49)
        Me.txtDescripcionEntrega.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionEntrega)
        Me.GroupBox1.Controls.Add(Me.txtCodigoPostal)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtLocalidad)
        Me.GroupBox1.Controls.Add(Me.txtDomicilio)
        Me.GroupBox1.Controls.Add(Me.txtSolicitante)
        Me.GroupBox1.Controls.Add(Me.txtId_Cliente)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.txtDirigidoA)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(954, 112)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(548, 53)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 13)
        Me.Label27.TabIndex = 28
        Me.Label27.Text = "* "
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(78, 81)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 13)
        Me.Label26.TabIndex = 27
        Me.Label26.Text = "* "
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Location = New System.Drawing.Point(870, 81)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(75, 20)
        Me.txtCodigoPostal.TabIndex = 8
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(797, 84)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Cód. Postal: "
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(566, 81)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(208, 20)
        Me.txtLocalidad.TabIndex = 7
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(566, 50)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(379, 20)
        Me.txtDomicilio.TabIndex = 6
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Location = New System.Drawing.Point(566, 19)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(192, 20)
        Me.txtSolicitante.TabIndex = 4
        '
        'txtId_Cliente
        '
        Me.txtId_Cliente.Location = New System.Drawing.Point(443, 78)
        Me.txtId_Cliente.Name = "txtId_Cliente"
        Me.txtId_Cliente.Size = New System.Drawing.Size(30, 20)
        Me.txtId_Cliente.TabIndex = 8
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(384, 76)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(49, 23)
        Me.btnBuscarCliente.TabIndex = 7
        Me.btnBuscarCliente.Text = "..."
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtDirigidoA
        '
        Me.txtDirigidoA.Location = New System.Drawing.Point(94, 78)
        Me.txtDirigidoA.Name = "txtDirigidoA"
        Me.txtDirigidoA.Size = New System.Drawing.Size(275, 20)
        Me.txtDirigidoA.TabIndex = 3
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Red
        Me.Label32.Location = New System.Drawing.Point(76, 40)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(14, 13)
        Me.Label32.TabIndex = 28
        Me.Label32.Text = "* "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.cboLogo)
        Me.GroupBox2.Controls.Add(Me.txtSeccion)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtPeso)
        Me.GroupBox2.Controls.Add(Me.txtTotalBultos)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtUnidadxBulto)
        Me.GroupBox2.Controls.Add(Me.txtCantidadBultos)
        Me.GroupBox2.Controls.Add(Me.txtDespachado)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(954, 109)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Entrega"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Red
        Me.Label31.Location = New System.Drawing.Point(140, 26)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(14, 13)
        Me.Label31.TabIndex = 31
        Me.Label31.Text = "* "
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(399, 54)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(14, 13)
        Me.Label30.TabIndex = 30
        Me.Label30.Text = "* "
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(400, 83)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 13)
        Me.Label29.TabIndex = 29
        Me.Label29.Text = "* "
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(399, 23)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 13)
        Me.Label28.TabIndex = 28
        Me.Label28.Text = "* "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(365, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Logo:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(837, 66)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(108, 33)
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cboLogo
        '
        Me.cboLogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLogo.FormattingEnabled = True
        Me.cboLogo.Items.AddRange(New Object() {"Aguas Cordobesas", "Fsc", "Soluciones Graficas", "Tarjeta Naranja", "Ninguno"})
        Me.cboLogo.Location = New System.Drawing.Point(418, 78)
        Me.cboLogo.Name = "cboLogo"
        Me.cboLogo.Size = New System.Drawing.Size(231, 21)
        Me.cboLogo.TabIndex = 16
        '
        'txtSeccion
        '
        Me.txtSeccion.Location = New System.Drawing.Point(157, 49)
        Me.txtSeccion.Name = "txtSeccion"
        Me.txtSeccion.Size = New System.Drawing.Size(151, 20)
        Me.txtSeccion.TabIndex = 10
        Me.txtSeccion.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(96, 52)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 13)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Sección:"
        Me.Label23.Visible = False
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(594, 49)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(55, 20)
        Me.txtPeso.TabIndex = 15
        '
        'txtTotalBultos
        '
        Me.txtTotalBultos.Enabled = False
        Me.txtTotalBultos.Location = New System.Drawing.Point(594, 23)
        Me.txtTotalBultos.Name = "txtTotalBultos"
        Me.txtTotalBultos.Size = New System.Drawing.Size(55, 20)
        Me.txtTotalBultos.TabIndex = 14
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(551, 54)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Peso: "
        '
        'txtUnidadxBulto
        '
        Me.txtUnidadxBulto.Location = New System.Drawing.Point(418, 49)
        Me.txtUnidadxBulto.Name = "txtUnidadxBulto"
        Me.txtUnidadxBulto.Size = New System.Drawing.Size(55, 20)
        Me.txtUnidadxBulto.TabIndex = 13
        '
        'txtCantidadBultos
        '
        Me.txtCantidadBultos.Location = New System.Drawing.Point(418, 23)
        Me.txtCantidadBultos.Name = "txtCantidadBultos"
        Me.txtCantidadBultos.Size = New System.Drawing.Size(55, 20)
        Me.txtCantidadBultos.TabIndex = 11
        '
        'txtDespachado
        '
        Me.txtDespachado.Location = New System.Drawing.Point(157, 22)
        Me.txtDespachado.Name = "txtDespachado"
        Me.txtDespachado.Size = New System.Drawing.Size(151, 20)
        Me.txtDespachado.TabIndex = 9
        Me.txtDespachado.Text = "Soluciones Graficas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(507, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Total de Bultos:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(329, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Unid. x Bulto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(347, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Cantidad:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(67, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Despachado:"
        '
        'btnLimpiarEtiqueta
        '
        Me.btnLimpiarEtiqueta.Location = New System.Drawing.Point(756, 551)
        Me.btnLimpiarEtiqueta.Name = "btnLimpiarEtiqueta"
        Me.btnLimpiarEtiqueta.Size = New System.Drawing.Size(108, 33)
        Me.btnLimpiarEtiqueta.TabIndex = 25
        Me.btnLimpiarEtiqueta.Text = "Limpiar Campos"
        Me.btnLimpiarEtiqueta.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.txt_id_orden)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.btnBuscar_Orden)
        Me.GroupBox3.Controls.Add(Me.txt_orden)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.dgv_Etiquetas)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(966, 533)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(40, 18)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 39
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Red
        Me.Label33.Location = New System.Drawing.Point(391, 37)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(14, 13)
        Me.Label33.TabIndex = 38
        Me.Label33.Text = "* "
        '
        'txt_id_orden
        '
        Me.txt_id_orden.Location = New System.Drawing.Point(643, 28)
        Me.txt_id_orden.Name = "txt_id_orden"
        Me.txt_id_orden.Size = New System.Drawing.Size(28, 20)
        Me.txt_id_orden.TabIndex = 37
        '
        'btnBuscar_Orden
        '
        Me.btnBuscar_Orden.Location = New System.Drawing.Point(524, 29)
        Me.btnBuscar_Orden.Name = "btnBuscar_Orden"
        Me.btnBuscar_Orden.Size = New System.Drawing.Size(51, 29)
        Me.btnBuscar_Orden.TabIndex = 36
        Me.btnBuscar_Orden.Text = "..."
        Me.btnBuscar_Orden.UseVisualStyleBackColor = True
        '
        'txt_orden
        '
        Me.txt_orden.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orden.Location = New System.Drawing.Point(407, 22)
        Me.txt_orden.Multiline = True
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.Size = New System.Drawing.Size(111, 36)
        Me.txt_orden.TabIndex = 1
        Me.txt_orden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(336, 32)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(57, 26)
        Me.Label34.TabIndex = 34
        Me.Label34.Text = " Número" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Orden: "
        '
        'dgv_Etiquetas
        '
        Me.dgv_Etiquetas.AllowUserToAddRows = False
        Me.dgv_Etiquetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_Etiquetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Etiquetas.Location = New System.Drawing.Point(6, 302)
        Me.dgv_Etiquetas.Name = "dgv_Etiquetas"
        Me.dgv_Etiquetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Etiquetas.Size = New System.Drawing.Size(954, 217)
        Me.dgv_Etiquetas.TabIndex = 23
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(870, 551)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 33)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGenerarEtiquetas
        '
        Me.btnGenerarEtiquetas.Location = New System.Drawing.Point(528, 551)
        Me.btnGenerarEtiquetas.Name = "btnGenerarEtiquetas"
        Me.btnGenerarEtiquetas.Size = New System.Drawing.Size(108, 33)
        Me.btnGenerarEtiquetas.TabIndex = 18
        Me.btnGenerarEtiquetas.Text = "Generar Etiquetas"
        Me.btnGenerarEtiquetas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(10, 760)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "* (Campo Requerido)"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(642, 551)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(108, 33)
        Me.btnEliminar.TabIndex = 27
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 561)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Cantidad de Etiquetas:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(393, 561)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(15, 551)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "* (Campo Requerido)"
        '
        'frm_Etiqueta_Modelo_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 593)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiarEtiqueta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGenerarEtiquetas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frm_Etiqueta_Modelo_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Etiqueta "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_Etiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionEntrega As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtSolicitante As System.Windows.Forms.TextBox
    Friend WithEvents txtId_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents txtDirigidoA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalBultos As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidadxBulto As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadBultos As System.Windows.Forms.TextBox
    Friend WithEvents txtDespachado As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSeccion As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents dgv_Etiquetas As System.Windows.Forms.DataGridView
    Friend WithEvents btnGenerarEtiquetas As System.Windows.Forms.Button
    Friend WithEvents btnLimpiarEtiqueta As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboLogo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txt_id_orden As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar_Orden As System.Windows.Forms.Button
    Friend WithEvents txt_orden As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
