<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listado_orden_trabajo_ampliada
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupDetallesOrden = New System.Windows.Forms.GroupBox()
        Me.btn_Imprimir_Orden = New System.Windows.Forms.Button()
        Me.btn_ODT_mostrar_listado_pdf = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnEliminar_Producto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_detalle_orden = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupListadoPiezas = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.rbtFechaEntrega = New System.Windows.Forms.RadioButton()
        Me.rbtCliente = New System.Windows.Forms.RadioButton()
        Me.rbtNroOrden = New System.Windows.Forms.RadioButton()
        Me.dtp_Buscar_Fecha_Entrega = New System.Windows.Forms.DateTimePicker()
        Me.txt_Buscar_Cliente = New System.Windows.Forms.TextBox()
        Me.btnEliminar_Orden = New System.Windows.Forms.Button()
        Me.btnModificar_Orden = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Buscar_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.dgvLista_Orden_Trabajo = New System.Windows.Forms.DataGridView()
        Me.btnDuplicar_Orden = New System.Windows.Forms.Button()
        Me.GroupDetallesOrden.SuspendLayout()
        CType(Me.dgv_detalle_orden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupListadoPiezas.SuspendLayout()
        CType(Me.dgvLista_Orden_Trabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupDetallesOrden
        '
        Me.GroupDetallesOrden.Controls.Add(Me.btnDuplicar_Orden)
        Me.GroupDetallesOrden.Controls.Add(Me.btn_Imprimir_Orden)
        Me.GroupDetallesOrden.Controls.Add(Me.btn_ODT_mostrar_listado_pdf)
        Me.GroupDetallesOrden.Controls.Add(Me.btn_Cancelar)
        Me.GroupDetallesOrden.Controls.Add(Me.btnVer)
        Me.GroupDetallesOrden.Controls.Add(Me.btnModificarProducto)
        Me.GroupDetallesOrden.Controls.Add(Me.btnEliminar_Producto)
        Me.GroupDetallesOrden.Controls.Add(Me.Label1)
        Me.GroupDetallesOrden.Controls.Add(Me.dgv_detalle_orden)
        Me.GroupDetallesOrden.Controls.Add(Me.Label2)
        Me.GroupDetallesOrden.Location = New System.Drawing.Point(14, 459)
        Me.GroupDetallesOrden.Name = "GroupDetallesOrden"
        Me.GroupDetallesOrden.Size = New System.Drawing.Size(1091, 304)
        Me.GroupDetallesOrden.TabIndex = 32
        Me.GroupDetallesOrden.TabStop = False
        Me.GroupDetallesOrden.Text = "Productos de la órden"
        '
        'btn_Imprimir_Orden
        '
        Me.btn_Imprimir_Orden.Location = New System.Drawing.Point(452, 256)
        Me.btn_Imprimir_Orden.Name = "btn_Imprimir_Orden"
        Me.btn_Imprimir_Orden.Size = New System.Drawing.Size(98, 33)
        Me.btn_Imprimir_Orden.TabIndex = 40
        Me.btn_Imprimir_Orden.Text = "Imprimir Orden"
        Me.btn_Imprimir_Orden.UseVisualStyleBackColor = True
        '
        'btn_ODT_mostrar_listado_pdf
        '
        Me.btn_ODT_mostrar_listado_pdf.Location = New System.Drawing.Point(556, 256)
        Me.btn_ODT_mostrar_listado_pdf.Name = "btn_ODT_mostrar_listado_pdf"
        Me.btn_ODT_mostrar_listado_pdf.Size = New System.Drawing.Size(128, 33)
        Me.btn_ODT_mostrar_listado_pdf.TabIndex = 37
        Me.btn_ODT_mostrar_listado_pdf.Text = "Exportar Listado a PDF"
        Me.btn_ODT_mostrar_listado_pdf.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(1007, 256)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(67, 33)
        Me.btn_Cancelar.TabIndex = 39
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(690, 256)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(67, 33)
        Me.btnVer.TabIndex = 37
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        Me.btnVer.Visible = False
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Location = New System.Drawing.Point(763, 256)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(119, 33)
        Me.btnModificarProducto.TabIndex = 38
        Me.btnModificarProducto.Text = "Modificar Producto"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnEliminar_Producto
        '
        Me.btnEliminar_Producto.Location = New System.Drawing.Point(888, 256)
        Me.btnEliminar_Producto.Name = "btnEliminar_Producto"
        Me.btnEliminar_Producto.Size = New System.Drawing.Size(113, 33)
        Me.btnEliminar_Producto.TabIndex = 35
        Me.btnEliminar_Producto.Text = "Eliminar Producto"
        Me.btnEliminar_Producto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(127, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 15)
        Me.Label1.TabIndex = 34
        '
        'dgv_detalle_orden
        '
        Me.dgv_detalle_orden.AllowUserToAddRows = False
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_detalle_orden.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgv_detalle_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_detalle_orden.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgv_detalle_orden.Location = New System.Drawing.Point(17, 19)
        Me.dgv_detalle_orden.MultiSelect = False
        Me.dgv_detalle_orden.Name = "dgv_detalle_orden"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_detalle_orden.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgv_detalle_orden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle_orden.Size = New System.Drawing.Size(1057, 216)
        Me.dgv_detalle_orden.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Productos de la orden"
        '
        'GroupListadoPiezas
        '
        Me.GroupListadoPiezas.Controls.Add(Me.LinkLabel1)
        Me.GroupListadoPiezas.Controls.Add(Me.btnAgregarProducto)
        Me.GroupListadoPiezas.Controls.Add(Me.rbtFechaEntrega)
        Me.GroupListadoPiezas.Controls.Add(Me.rbtCliente)
        Me.GroupListadoPiezas.Controls.Add(Me.rbtNroOrden)
        Me.GroupListadoPiezas.Controls.Add(Me.dtp_Buscar_Fecha_Entrega)
        Me.GroupListadoPiezas.Controls.Add(Me.txt_Buscar_Cliente)
        Me.GroupListadoPiezas.Controls.Add(Me.btnEliminar_Orden)
        Me.GroupListadoPiezas.Controls.Add(Me.btnModificar_Orden)
        Me.GroupListadoPiezas.Controls.Add(Me.Label3)
        Me.GroupListadoPiezas.Controls.Add(Me.Label7)
        Me.GroupListadoPiezas.Controls.Add(Me.txt_Buscar_orden_trabajo)
        Me.GroupListadoPiezas.Controls.Add(Me.dgvLista_Orden_Trabajo)
        Me.GroupListadoPiezas.Location = New System.Drawing.Point(12, 12)
        Me.GroupListadoPiezas.Name = "GroupListadoPiezas"
        Me.GroupListadoPiezas.Size = New System.Drawing.Size(1091, 441)
        Me.GroupListadoPiezas.TabIndex = 31
        Me.GroupListadoPiezas.TabStop = False
        Me.GroupListadoPiezas.Text = "Listado de Ordenes"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.LinkLabel1.Location = New System.Drawing.Point(333, 418)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 41
        Me.LinkLabel1.Text = "LinkLabel1"
        Me.LinkLabel1.Visible = False
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(713, 402)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(119, 33)
        Me.btnAgregarProducto.TabIndex = 40
        Me.btnAgregarProducto.Text = "Agregar Producto"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'rbtFechaEntrega
        '
        Me.rbtFechaEntrega.AutoSize = True
        Me.rbtFechaEntrega.Location = New System.Drawing.Point(478, 20)
        Me.rbtFechaEntrega.Name = "rbtFechaEntrega"
        Me.rbtFechaEntrega.Size = New System.Drawing.Size(110, 17)
        Me.rbtFechaEntrega.TabIndex = 5
        Me.rbtFechaEntrega.TabStop = True
        Me.rbtFechaEntrega.Text = "Fecha de Entrega"
        Me.rbtFechaEntrega.UseVisualStyleBackColor = True
        '
        'rbtCliente
        '
        Me.rbtCliente.AutoSize = True
        Me.rbtCliente.Location = New System.Drawing.Point(240, 19)
        Me.rbtCliente.Name = "rbtCliente"
        Me.rbtCliente.Size = New System.Drawing.Size(131, 17)
        Me.rbtCliente.TabIndex = 3
        Me.rbtCliente.TabStop = True
        Me.rbtCliente.Text = "Cliente / Razón Social"
        Me.rbtCliente.UseVisualStyleBackColor = True
        '
        'rbtNroOrden
        '
        Me.rbtNroOrden.AutoSize = True
        Me.rbtNroOrden.Location = New System.Drawing.Point(59, 19)
        Me.rbtNroOrden.Name = "rbtNroOrden"
        Me.rbtNroOrden.Size = New System.Drawing.Size(74, 17)
        Me.rbtNroOrden.TabIndex = 1
        Me.rbtNroOrden.TabStop = True
        Me.rbtNroOrden.Text = "Nro Orden"
        Me.rbtNroOrden.UseVisualStyleBackColor = True
        '
        'dtp_Buscar_Fecha_Entrega
        '
        Me.dtp_Buscar_Fecha_Entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Buscar_Fecha_Entrega.Location = New System.Drawing.Point(594, 19)
        Me.dtp_Buscar_Fecha_Entrega.Name = "dtp_Buscar_Fecha_Entrega"
        Me.dtp_Buscar_Fecha_Entrega.Size = New System.Drawing.Size(134, 20)
        Me.dtp_Buscar_Fecha_Entrega.TabIndex = 6
        '
        'txt_Buscar_Cliente
        '
        Me.txt_Buscar_Cliente.Location = New System.Drawing.Point(377, 18)
        Me.txt_Buscar_Cliente.Name = "txt_Buscar_Cliente"
        Me.txt_Buscar_Cliente.Size = New System.Drawing.Size(95, 20)
        Me.txt_Buscar_Cliente.TabIndex = 4
        '
        'btnEliminar_Orden
        '
        Me.btnEliminar_Orden.Location = New System.Drawing.Point(963, 402)
        Me.btnEliminar_Orden.Name = "btnEliminar_Orden"
        Me.btnEliminar_Orden.Size = New System.Drawing.Size(113, 33)
        Me.btnEliminar_Orden.TabIndex = 28
        Me.btnEliminar_Orden.Text = "Eliminar Orden"
        Me.btnEliminar_Orden.UseVisualStyleBackColor = True
        '
        'btnModificar_Orden
        '
        Me.btnModificar_Orden.Location = New System.Drawing.Point(838, 402)
        Me.btnModificar_Orden.Name = "btnModificar_Orden"
        Me.btnModificar_Orden.Size = New System.Drawing.Size(119, 33)
        Me.btnModificar_Orden.TabIndex = 29
        Me.btnModificar_Orden.Text = "Modificar Orden"
        Me.btnModificar_Orden.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(108, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 15)
        Me.Label3.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 412)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total de ordenes"
        '
        'txt_Buscar_orden_trabajo
        '
        Me.txt_Buscar_orden_trabajo.Location = New System.Drawing.Point(139, 19)
        Me.txt_Buscar_orden_trabajo.Name = "txt_Buscar_orden_trabajo"
        Me.txt_Buscar_orden_trabajo.Size = New System.Drawing.Size(95, 20)
        Me.txt_Buscar_orden_trabajo.TabIndex = 2
        '
        'dgvLista_Orden_Trabajo
        '
        Me.dgvLista_Orden_Trabajo.AllowUserToAddRows = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista_Orden_Trabajo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvLista_Orden_Trabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista_Orden_Trabajo.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvLista_Orden_Trabajo.Location = New System.Drawing.Point(17, 45)
        Me.dgvLista_Orden_Trabajo.Name = "dgvLista_Orden_Trabajo"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista_Orden_Trabajo.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvLista_Orden_Trabajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Orden_Trabajo.Size = New System.Drawing.Size(1057, 351)
        Me.dgvLista_Orden_Trabajo.TabIndex = 0
        '
        'btnDuplicar_Orden
        '
        Me.btnDuplicar_Orden.Location = New System.Drawing.Point(348, 256)
        Me.btnDuplicar_Orden.Name = "btnDuplicar_Orden"
        Me.btnDuplicar_Orden.Size = New System.Drawing.Size(98, 33)
        Me.btnDuplicar_Orden.TabIndex = 41
        Me.btnDuplicar_Orden.Text = "Duplicar Orden"
        Me.btnDuplicar_Orden.UseVisualStyleBackColor = True
        Me.btnDuplicar_Orden.Visible = False
        '
        'frm_listado_orden_trabajo_ampliada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.GroupDetallesOrden)
        Me.Controls.Add(Me.GroupListadoPiezas)
        Me.Name = "frm_listado_orden_trabajo_ampliada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de órdenes"
        Me.GroupDetallesOrden.ResumeLayout(False)
        Me.GroupDetallesOrden.PerformLayout()
        CType(Me.dgv_detalle_orden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupListadoPiezas.ResumeLayout(False)
        Me.GroupListadoPiezas.PerformLayout()
        CType(Me.dgvLista_Orden_Trabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupDetallesOrden As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarProducto As System.Windows.Forms.Button
    Friend WithEvents btnEliminar_Producto As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_detalle_orden As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupListadoPiezas As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ODT_mostrar_listado_pdf As System.Windows.Forms.Button
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents rbtFechaEntrega As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNroOrden As System.Windows.Forms.RadioButton
    Friend WithEvents dtp_Buscar_Fecha_Entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Buscar_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar_Orden As System.Windows.Forms.Button
    Friend WithEvents btnModificar_Orden As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Buscar_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Orden_Trabajo As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarProducto As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_Imprimir_Orden As System.Windows.Forms.Button
    Friend WithEvents btnDuplicar_Orden As System.Windows.Forms.Button
End Class
