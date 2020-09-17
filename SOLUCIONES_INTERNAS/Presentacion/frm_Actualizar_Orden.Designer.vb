<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Actualizar_Orden
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
        Me.dtpFecha_Entrega = New System.Windows.Forms.DateTimePicker()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtNumero_Orden_Trabajo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombre_cliente = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboTipo_Orden = New System.Windows.Forms.ComboBox()
        Me.btnBuscar_cliente = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_id_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.txt_id_cliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpFecha_Orden_Trabajo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar_Vendedor = New System.Windows.Forms.Button()
        Me.txtNombre_vendedor = New System.Windows.Forms.TextBox()
        Me.txtid_vendedor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboDireccion_Entrega = New System.Windows.Forms.ComboBox()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFecha_Entrega
        '
        Me.dtpFecha_Entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_Entrega.Location = New System.Drawing.Point(289, 98)
        Me.dtpFecha_Entrega.Name = "dtpFecha_Entrega"
        Me.dtpFecha_Entrega.Size = New System.Drawing.Size(82, 20)
        Me.dtpFecha_Entrega.TabIndex = 90
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(206, 101)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(77, 13)
        Me.Label54.TabIndex = 89
        Me.Label54.Text = "Fecha Entrega"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.Red
        Me.Label46.Location = New System.Drawing.Point(121, 46)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(11, 13)
        Me.Label46.TabIndex = 88
        Me.Label46.Text = "*"
        '
        'txtNumero_Orden_Trabajo
        '
        Me.txtNumero_Orden_Trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero_Orden_Trabajo.Location = New System.Drawing.Point(134, 28)
        Me.txtNumero_Orden_Trabajo.Multiline = True
        Me.txtNumero_Orden_Trabajo.Name = "txtNumero_Orden_Trabajo"
        Me.txtNumero_Orden_Trabajo.Size = New System.Drawing.Size(165, 48)
        Me.txtNumero_Orden_Trabajo.TabIndex = 66
        Me.txtNumero_Orden_Trabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 26)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Número" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orden"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_nombre_cliente
        '
        Me.txt_nombre_cliente.Location = New System.Drawing.Point(86, 164)
        Me.txt_nombre_cliente.Name = "txt_nombre_cliente"
        Me.txt_nombre_cliente.Size = New System.Drawing.Size(283, 20)
        Me.txt_nombre_cliente.TabIndex = 86
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(86, 182)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Cliente"
        '
        'cboTipo_Orden
        '
        Me.cboTipo_Orden.FormattingEnabled = True
        Me.cboTipo_Orden.Items.AddRange(New Object() {"DG", "DO", "DI", "DV", "DS"})
        Me.cboTipo_Orden.Location = New System.Drawing.Point(381, 55)
        Me.cboTipo_Orden.Name = "cboTipo_Orden"
        Me.cboTipo_Orden.Size = New System.Drawing.Size(66, 21)
        Me.cboTipo_Orden.TabIndex = 65
        '
        'btnBuscar_cliente
        '
        Me.btnBuscar_cliente.Location = New System.Drawing.Point(387, 176)
        Me.btnBuscar_cliente.Name = "btnBuscar_cliente"
        Me.btnBuscar_cliente.Size = New System.Drawing.Size(52, 23)
        Me.btnBuscar_cliente.TabIndex = 68
        Me.btnBuscar_cliente.Text = "..."
        Me.btnBuscar_cliente.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Tipo Orden"
        '
        'txt_id_orden_trabajo
        '
        Me.txt_id_orden_trabajo.Location = New System.Drawing.Point(381, 33)
        Me.txt_id_orden_trabajo.Name = "txt_id_orden_trabajo"
        Me.txt_id_orden_trabajo.Size = New System.Drawing.Size(66, 20)
        Me.txt_id_orden_trabajo.TabIndex = 75
        '
        'txt_id_cliente
        '
        Me.txt_id_cliente.Location = New System.Drawing.Point(429, 166)
        Me.txt_id_cliente.Name = "txt_id_cliente"
        Me.txt_id_cliente.Size = New System.Drawing.Size(12, 20)
        Me.txt_id_cliente.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(355, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "TN"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(17, 196)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 26)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = " Dirección " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Entrega"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(86, 148)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "*"
        '
        'dtpFecha_Orden_Trabajo
        '
        Me.dtpFecha_Orden_Trabajo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_Orden_Trabajo.Location = New System.Drawing.Point(94, 101)
        Me.dtpFecha_Orden_Trabajo.Name = "dtpFecha_Orden_Trabajo"
        Me.dtpFecha_Orden_Trabajo.Size = New System.Drawing.Size(82, 20)
        Me.dtpFecha_Orden_Trabajo.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Fecha Ingreso"
        '
        'btnBuscar_Vendedor
        '
        Me.btnBuscar_Vendedor.Location = New System.Drawing.Point(387, 141)
        Me.btnBuscar_Vendedor.Name = "btnBuscar_Vendedor"
        Me.btnBuscar_Vendedor.Size = New System.Drawing.Size(52, 23)
        Me.btnBuscar_Vendedor.TabIndex = 67
        Me.btnBuscar_Vendedor.Text = "..."
        Me.btnBuscar_Vendedor.UseVisualStyleBackColor = True
        '
        'txtNombre_vendedor
        '
        Me.txtNombre_vendedor.Location = New System.Drawing.Point(98, 144)
        Me.txtNombre_vendedor.Name = "txtNombre_vendedor"
        Me.txtNombre_vendedor.Size = New System.Drawing.Size(283, 20)
        Me.txtNombre_vendedor.TabIndex = 80
        '
        'txtid_vendedor
        '
        Me.txtid_vendedor.Location = New System.Drawing.Point(441, 142)
        Me.txtid_vendedor.Name = "txtid_vendedor"
        Me.txtid_vendedor.Size = New System.Drawing.Size(12, 20)
        Me.txtid_vendedor.TabIndex = 79
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Vendedor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboDireccion_Entrega)
        Me.GroupBox1.Controls.Add(Me.txt_observaciones)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_cliente)
        Me.GroupBox1.Controls.Add(Me.txtNumero_Orden_Trabajo)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.dtpFecha_Orden_Trabajo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFecha_Entrega)
        Me.GroupBox1.Controls.Add(Me.txt_id_orden_trabajo)
        Me.GroupBox1.Controls.Add(Me.Label54)
        Me.GroupBox1.Controls.Add(Me.txt_id_cliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboTipo_Orden)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 351)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        '
        'cboDireccion_Entrega
        '
        Me.cboDireccion_Entrega.FormattingEnabled = True
        Me.cboDireccion_Entrega.Items.AddRange(New Object() {"Casa Central", "Planta Industrial"})
        Me.cboDireccion_Entrega.Location = New System.Drawing.Point(86, 201)
        Me.cboDireccion_Entrega.MaxLength = 250
        Me.cboDireccion_Entrega.Name = "cboDireccion_Entrega"
        Me.cboDireccion_Entrega.Size = New System.Drawing.Size(283, 21)
        Me.cboDireccion_Entrega.TabIndex = 129
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(86, 236)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(341, 98)
        Me.txt_observaciones.TabIndex = 91
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 239)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 13)
        Me.Label18.TabIndex = 92
        Me.Label18.Text = "Observaciones"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(309, 369)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 33)
        Me.btnActualizar.TabIndex = 92
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(390, 369)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar.TabIndex = 92
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frm_Actualizar_Orden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 410)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnBuscar_cliente)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnBuscar_Vendedor)
        Me.Controls.Add(Me.txtNombre_vendedor)
        Me.Controls.Add(Me.txtid_vendedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Actualizar_Orden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Orden"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFecha_Entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_Orden_Trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboTipo_Orden As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar_cliente As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_id_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_Orden_Trabajo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_Vendedor As System.Windows.Forms.Button
    Friend WithEvents txtNombre_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtid_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboDireccion_Entrega As System.Windows.Forms.ComboBox
End Class
