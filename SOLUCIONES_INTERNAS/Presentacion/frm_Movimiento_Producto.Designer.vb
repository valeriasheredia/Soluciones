<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Movimiento_Producto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_id_producto_movimiento = New System.Windows.Forms.TextBox()
        Me.txt_id_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.txt_id_producto = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_numero_orden = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnBuscar_cliente = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_Tipo_Producto = New System.Windows.Forms.ComboBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnIngresar_Stock = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupListadoProductos = New System.Windows.Forms.GroupBox()
        Me.lblTotal_Productos = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txt_Buscar_Producto = New System.Windows.Forms.TextBox()
        Me.dgvLista_Productos = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupListadoProductos.SuspendLayout()
        CType(Me.dgvLista_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(447, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(447, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 383)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "id_producto_movimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(242, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fecha"
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(76, 20)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(86, 20)
        Me.txt_Codigo.TabIndex = 5
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(285, 20)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(89, 20)
        Me.dtpFecha.TabIndex = 6
        '
        'txt_id_producto_movimiento
        '
        Me.txt_id_producto_movimiento.Location = New System.Drawing.Point(249, 380)
        Me.txt_id_producto_movimiento.Name = "txt_id_producto_movimiento"
        Me.txt_id_producto_movimiento.Size = New System.Drawing.Size(24, 20)
        Me.txt_id_producto_movimiento.TabIndex = 8
        '
        'txt_id_orden_trabajo
        '
        Me.txt_id_orden_trabajo.Location = New System.Drawing.Point(602, 81)
        Me.txt_id_orden_trabajo.Name = "txt_id_orden_trabajo"
        Me.txt_id_orden_trabajo.Size = New System.Drawing.Size(15, 20)
        Me.txt_id_orden_trabajo.TabIndex = 9
        '
        'txt_id_producto
        '
        Me.txt_id_producto.Location = New System.Drawing.Point(417, 27)
        Me.txt_id_producto.Name = "txt_id_producto"
        Me.txt_id_producto.Size = New System.Drawing.Size(24, 20)
        Me.txt_id_producto.TabIndex = 10
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.Location = New System.Drawing.Point(76, 117)
        Me.txt_Cantidad.Multiline = True
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(90, 33)
        Me.txt_Cantidad.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Cantidad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_numero_orden)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.btnBuscar_cliente)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbo_Tipo_Producto)
        Me.GroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnIngresar_Stock)
        Me.GroupBox1.Controls.Add(Me.txt_Cantidad)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_id_orden_trabajo)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txt_Codigo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 162)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Producto"
        '
        'txt_numero_orden
        '
        Me.txt_numero_orden.Location = New System.Drawing.Point(76, 85)
        Me.txt_numero_orden.Name = "txt_numero_orden"
        Me.txt_numero_orden.Size = New System.Drawing.Size(466, 20)
        Me.txt_numero_orden.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(325, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(34, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "Orden"
        '
        'btnBuscar_cliente
        '
        Me.btnBuscar_cliente.Location = New System.Drawing.Point(548, 83)
        Me.btnBuscar_cliente.Name = "btnBuscar_cliente"
        Me.btnBuscar_cliente.Size = New System.Drawing.Size(52, 23)
        Me.btnBuscar_cliente.TabIndex = 2
        Me.btnBuscar_cliente.Text = "..."
        Me.btnBuscar_cliente.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(63, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(63, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "*"
        '
        'cbo_Tipo_Producto
        '
        Me.cbo_Tipo_Producto.FormattingEnabled = True
        Me.cbo_Tipo_Producto.Items.AddRange(New Object() {"Alta", "Baja"})
        Me.cbo_Tipo_Producto.Location = New System.Drawing.Point(481, 20)
        Me.cbo_Tipo_Producto.Name = "cbo_Tipo_Producto"
        Me.cbo_Tipo_Producto.Size = New System.Drawing.Size(119, 21)
        Me.cbo_Tipo_Producto.TabIndex = 73
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(76, 52)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(524, 20)
        Me.txt_descripcion.TabIndex = 72
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(525, 117)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnIngresar_Stock
        '
        Me.btnIngresar_Stock.Location = New System.Drawing.Point(419, 117)
        Me.btnIngresar_Stock.Name = "btnIngresar_Stock"
        Me.btnIngresar_Stock.Size = New System.Drawing.Size(100, 33)
        Me.btnIngresar_Stock.TabIndex = 4
        Me.btnIngresar_Stock.Text = "Ingresar Stock"
        Me.btnIngresar_Stock.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(5, 380)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 13)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "* (Campo Requerido)"
        '
        'GroupListadoProductos
        '
        Me.GroupListadoProductos.Controls.Add(Me.lblTotal_Productos)
        Me.GroupListadoProductos.Controls.Add(Me.Label10)
        Me.GroupListadoProductos.Controls.Add(Me.btnEliminar)
        Me.GroupListadoProductos.Controls.Add(Me.txt_Buscar_Producto)
        Me.GroupListadoProductos.Controls.Add(Me.Label13)
        Me.GroupListadoProductos.Controls.Add(Me.dgvLista_Productos)
        Me.GroupListadoProductos.Controls.Add(Me.Label11)
        Me.GroupListadoProductos.Controls.Add(Me.txt_id_producto_movimiento)
        Me.GroupListadoProductos.Controls.Add(Me.Label7)
        Me.GroupListadoProductos.Controls.Add(Me.txt_id_producto)
        Me.GroupListadoProductos.Controls.Add(Me.Label1)
        Me.GroupListadoProductos.Location = New System.Drawing.Point(12, 180)
        Me.GroupListadoProductos.Name = "GroupListadoProductos"
        Me.GroupListadoProductos.Size = New System.Drawing.Size(620, 408)
        Me.GroupListadoProductos.TabIndex = 68
        Me.GroupListadoProductos.TabStop = False
        Me.GroupListadoProductos.Text = "Listado de Productos"
        '
        'lblTotal_Productos
        '
        Me.lblTotal_Productos.AutoSize = True
        Me.lblTotal_Productos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal_Productos.Location = New System.Drawing.Point(385, 383)
        Me.lblTotal_Productos.Name = "lblTotal_Productos"
        Me.lblTotal_Productos.Size = New System.Drawing.Size(2, 15)
        Me.lblTotal_Productos.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(282, 383)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total de Productos"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(536, 20)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 33)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txt_Buscar_Producto
        '
        Me.txt_Buscar_Producto.Location = New System.Drawing.Point(102, 25)
        Me.txt_Buscar_Producto.Name = "txt_Buscar_Producto"
        Me.txt_Buscar_Producto.Size = New System.Drawing.Size(272, 20)
        Me.txt_Buscar_Producto.TabIndex = 6
        '
        'dgvLista_Productos
        '
        Me.dgvLista_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Productos.Location = New System.Drawing.Point(8, 59)
        Me.dgvLista_Productos.Name = "dgvLista_Productos"
        Me.dgvLista_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Productos.Size = New System.Drawing.Size(603, 315)
        Me.dgvLista_Productos.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Ingrese Nombre"
        '
        'frm_Movimiento_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 600)
        Me.Controls.Add(Me.GroupListadoProductos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Movimiento_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento de Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupListadoProductos.ResumeLayout(False)
        Me.GroupListadoProductos.PerformLayout()
        CType(Me.dgvLista_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_id_producto_movimiento As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_producto As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupListadoProductos As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal_Productos As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_Producto As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnIngresar_Stock As System.Windows.Forms.Button
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents cbo_Tipo_Producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_orden As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_cliente As System.Windows.Forms.Button
End Class
