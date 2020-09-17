<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Productos
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
        Me.btn_prod_guardar = New System.Windows.Forms.Button()
        Me.tb_prod_descripcion = New System.Windows.Forms.TextBox()
        Me.tb_prod_stock = New System.Windows.Forms.TextBox()
        Me.dgvLista_Productos = New System.Windows.Forms.DataGridView()
        Me.btn_prod_actualizar = New System.Windows.Forms.Button()
        Me.tb_prod_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboDeposito = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_prod_stock_minimo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_prod_codigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbo_busqueda_deposito = New System.Windows.Forms.ComboBox()
        Me.rbtDeposito = New System.Windows.Forms.RadioButton()
        Me.rbtCodigo = New System.Windows.Forms.RadioButton()
        Me.rbtProducto = New System.Windows.Forms.RadioButton()
        Me.tb_cod_busqueda = New System.Windows.Forms.TextBox()
        Me.tb_prod_busqueda = New System.Windows.Forms.TextBox()
        Me.btnExportarPDF = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_prod_eliminar = New System.Windows.Forms.Button()
        Me.btn_prod_cancelar = New System.Windows.Forms.Button()
        Me.btn_Exportar_Excel = New System.Windows.Forms.Button()
        CType(Me.dgvLista_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_prod_guardar
        '
        Me.btn_prod_guardar.Location = New System.Drawing.Point(499, 94)
        Me.btn_prod_guardar.Name = "btn_prod_guardar"
        Me.btn_prod_guardar.Size = New System.Drawing.Size(90, 33)
        Me.btn_prod_guardar.TabIndex = 5
        Me.btn_prod_guardar.Text = "Guardar"
        Me.btn_prod_guardar.UseVisualStyleBackColor = True
        '
        'tb_prod_descripcion
        '
        Me.tb_prod_descripcion.Location = New System.Drawing.Point(301, 27)
        Me.tb_prod_descripcion.MaxLength = 50
        Me.tb_prod_descripcion.Name = "tb_prod_descripcion"
        Me.tb_prod_descripcion.Size = New System.Drawing.Size(384, 20)
        Me.tb_prod_descripcion.TabIndex = 2
        '
        'tb_prod_stock
        '
        Me.tb_prod_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_prod_stock.Location = New System.Drawing.Point(301, 65)
        Me.tb_prod_stock.Multiline = True
        Me.tb_prod_stock.Name = "tb_prod_stock"
        Me.tb_prod_stock.Size = New System.Drawing.Size(91, 20)
        Me.tb_prod_stock.TabIndex = 4
        Me.tb_prod_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvLista_Productos
        '
        Me.dgvLista_Productos.AllowUserToAddRows = False
        Me.dgvLista_Productos.AllowUserToDeleteRows = False
        Me.dgvLista_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Productos.Location = New System.Drawing.Point(6, 75)
        Me.dgvLista_Productos.Name = "dgvLista_Productos"
        Me.dgvLista_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Productos.Size = New System.Drawing.Size(680, 367)
        Me.dgvLista_Productos.TabIndex = 10
        '
        'btn_prod_actualizar
        '
        Me.btn_prod_actualizar.Location = New System.Drawing.Point(595, 94)
        Me.btn_prod_actualizar.Name = "btn_prod_actualizar"
        Me.btn_prod_actualizar.Size = New System.Drawing.Size(90, 33)
        Me.btn_prod_actualizar.TabIndex = 7
        Me.btn_prod_actualizar.Text = "Actualizar"
        Me.btn_prod_actualizar.UseVisualStyleBackColor = True
        '
        'tb_prod_id
        '
        Me.tb_prod_id.Location = New System.Drawing.Point(368, 107)
        Me.tb_prod_id.Name = "tb_prod_id"
        Me.tb_prod_id.Size = New System.Drawing.Size(14, 20)
        Me.tb_prod_id.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(298, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Id_producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cant. en stock"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cboDeposito)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_prod_id)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tb_prod_stock_minimo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tb_prod_codigo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_prod_actualizar)
        Me.GroupBox1.Controls.Add(Me.btn_prod_guardar)
        Me.GroupBox1.Controls.Add(Me.tb_prod_stock)
        Me.GroupBox1.Controls.Add(Me.tb_prod_descripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(691, 148)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestión de productos"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(75, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "*"
        '
        'cboDeposito
        '
        Me.cboDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeposito.FormattingEnabled = True
        Me.cboDeposito.Items.AddRange(New Object() {"Seleccionar", "Central", "Planta"})
        Me.cboDeposito.Location = New System.Drawing.Point(93, 107)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Size = New System.Drawing.Size(190, 21)
        Me.cboDeposito.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Depósito"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(284, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Stock mínimo"
        '
        'tb_prod_stock_minimo
        '
        Me.tb_prod_stock_minimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_prod_stock_minimo.Location = New System.Drawing.Point(96, 68)
        Me.tb_prod_stock_minimo.Multiline = True
        Me.tb_prod_stock_minimo.Name = "tb_prod_stock_minimo"
        Me.tb_prod_stock_minimo.Size = New System.Drawing.Size(91, 20)
        Me.tb_prod_stock_minimo.TabIndex = 3
        Me.tb_prod_stock_minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Código"
        '
        'tb_prod_codigo
        '
        Me.tb_prod_codigo.Location = New System.Drawing.Point(96, 27)
        Me.tb_prod_codigo.MaxLength = 15
        Me.tb_prod_codigo.Name = "tb_prod_codigo"
        Me.tb_prod_codigo.Size = New System.Drawing.Size(91, 20)
        Me.tb_prod_codigo.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(78, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(79, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(283, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "*"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.dgvLista_Productos)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(692, 448)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de productos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbo_busqueda_deposito)
        Me.GroupBox3.Controls.Add(Me.rbtDeposito)
        Me.GroupBox3.Controls.Add(Me.rbtCodigo)
        Me.GroupBox3.Controls.Add(Me.rbtProducto)
        Me.GroupBox3.Controls.Add(Me.tb_cod_busqueda)
        Me.GroupBox3.Controls.Add(Me.tb_prod_busqueda)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(680, 50)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Búsqueda"
        '
        'cbo_busqueda_deposito
        '
        Me.cbo_busqueda_deposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_busqueda_deposito.FormattingEnabled = True
        Me.cbo_busqueda_deposito.Items.AddRange(New Object() {"Todos", "Central", "Planta"})
        Me.cbo_busqueda_deposito.Location = New System.Drawing.Point(507, 18)
        Me.cbo_busqueda_deposito.Name = "cbo_busqueda_deposito"
        Me.cbo_busqueda_deposito.Size = New System.Drawing.Size(111, 21)
        Me.cbo_busqueda_deposito.TabIndex = 27
        '
        'rbtDeposito
        '
        Me.rbtDeposito.AutoSize = True
        Me.rbtDeposito.Location = New System.Drawing.Point(433, 19)
        Me.rbtDeposito.Name = "rbtDeposito"
        Me.rbtDeposito.Size = New System.Drawing.Size(67, 17)
        Me.rbtDeposito.TabIndex = 26
        Me.rbtDeposito.TabStop = True
        Me.rbtDeposito.Text = "Depósito"
        Me.rbtDeposito.UseVisualStyleBackColor = True
        '
        'rbtCodigo
        '
        Me.rbtCodigo.AutoSize = True
        Me.rbtCodigo.Location = New System.Drawing.Point(256, 19)
        Me.rbtCodigo.Name = "rbtCodigo"
        Me.rbtCodigo.Size = New System.Drawing.Size(58, 17)
        Me.rbtCodigo.TabIndex = 24
        Me.rbtCodigo.TabStop = True
        Me.rbtCodigo.Text = "Código"
        Me.rbtCodigo.UseVisualStyleBackColor = True
        '
        'rbtProducto
        '
        Me.rbtProducto.AutoSize = True
        Me.rbtProducto.Location = New System.Drawing.Point(68, 19)
        Me.rbtProducto.Name = "rbtProducto"
        Me.rbtProducto.Size = New System.Drawing.Size(68, 17)
        Me.rbtProducto.TabIndex = 24
        Me.rbtProducto.TabStop = True
        Me.rbtProducto.Text = "Producto"
        Me.rbtProducto.UseVisualStyleBackColor = True
        '
        'tb_cod_busqueda
        '
        Me.tb_cod_busqueda.Location = New System.Drawing.Point(320, 18)
        Me.tb_cod_busqueda.Name = "tb_cod_busqueda"
        Me.tb_cod_busqueda.Size = New System.Drawing.Size(99, 20)
        Me.tb_cod_busqueda.TabIndex = 23
        '
        'tb_prod_busqueda
        '
        Me.tb_prod_busqueda.Location = New System.Drawing.Point(142, 18)
        Me.tb_prod_busqueda.Name = "tb_prod_busqueda"
        Me.tb_prod_busqueda.Size = New System.Drawing.Size(99, 20)
        Me.tb_prod_busqueda.TabIndex = 21
        '
        'btnExportarPDF
        '
        Me.btnExportarPDF.Location = New System.Drawing.Point(430, 620)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Size = New System.Drawing.Size(112, 33)
        Me.btnExportarPDF.TabIndex = 24
        Me.btnExportarPDF.Text = "Exportar a PDF"
        Me.btnExportarPDF.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(20, 640)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "* (Campo Requerido)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(117, 617)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(2, 15)
        Me.Label9.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 619)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Total de Productos"
        '
        'btn_prod_eliminar
        '
        Me.btn_prod_eliminar.Location = New System.Drawing.Point(548, 620)
        Me.btn_prod_eliminar.Name = "btn_prod_eliminar"
        Me.btn_prod_eliminar.Size = New System.Drawing.Size(74, 33)
        Me.btn_prod_eliminar.TabIndex = 20
        Me.btn_prod_eliminar.Text = "Eliminar"
        Me.btn_prod_eliminar.UseVisualStyleBackColor = True
        '
        'btn_prod_cancelar
        '
        Me.btn_prod_cancelar.Location = New System.Drawing.Point(628, 620)
        Me.btn_prod_cancelar.Name = "btn_prod_cancelar"
        Me.btn_prod_cancelar.Size = New System.Drawing.Size(74, 33)
        Me.btn_prod_cancelar.TabIndex = 19
        Me.btn_prod_cancelar.Text = "Cancelar"
        Me.btn_prod_cancelar.UseVisualStyleBackColor = True
        '
        'btn_Exportar_Excel
        '
        Me.btn_Exportar_Excel.Location = New System.Drawing.Point(293, 620)
        Me.btn_Exportar_Excel.Name = "btn_Exportar_Excel"
        Me.btn_Exportar_Excel.Size = New System.Drawing.Size(131, 33)
        Me.btn_Exportar_Excel.TabIndex = 25
        Me.btn_Exportar_Excel.Text = "Exportar a EXCEL"
        Me.btn_Exportar_Excel.UseVisualStyleBackColor = True
        '
        'frm_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 662)
        Me.Controls.Add(Me.btn_Exportar_Excel)
        Me.Controls.Add(Me.btnExportarPDF)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_prod_eliminar)
        Me.Controls.Add(Me.btn_prod_cancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.dgvLista_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_prod_guardar As System.Windows.Forms.Button
    Friend WithEvents tb_prod_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents tb_prod_stock As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_prod_actualizar As System.Windows.Forms.Button
    Friend WithEvents tb_prod_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tb_prod_stock_minimo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_prod_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnExportarPDF As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_prod_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_prod_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtProducto As System.Windows.Forms.RadioButton
    Friend WithEvents tb_cod_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents tb_prod_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents btn_Exportar_Excel As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rbtDeposito As System.Windows.Forms.RadioButton
    Friend WithEvents cbo_busqueda_deposito As System.Windows.Forms.ComboBox
End Class
