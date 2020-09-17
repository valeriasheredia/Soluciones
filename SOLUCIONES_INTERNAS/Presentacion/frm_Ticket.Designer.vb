<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Ticket
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chk_Nuevo = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupReceptor = New System.Windows.Forms.GroupBox()
        Me.btn_Cancelar_Receptor = New System.Windows.Forms.Button()
        Me.btn_respuesta = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_comentarios = New System.Windows.Forms.TextBox()
        Me.dtp_fecha_estimada = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha_real = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbo_estado = New System.Windows.Forms.ComboBox()
        Me.cbo_prioridad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_sector_dirigido = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupSolicitante = New System.Windows.Forms.GroupBox()
        Me.btnCancelar_Solicitante = New System.Windows.Forms.Button()
        Me.btn_Solicitud = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_id_ticket = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtp_fecha_pedido = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_herramienta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_plazo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_id_usuario = New System.Windows.Forms.TextBox()
        Me.txt_recurso = New System.Windows.Forms.TextBox()
        Me.txt_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_Exportar_EXCEL = New System.Windows.Forms.Button()
        Me.cbo_busqueda_estado = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.dgv_lista_ticket = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupReceptor.SuspendLayout()
        Me.GroupSolicitante.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_lista_ticket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(835, 630)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.chk_Nuevo)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.GroupReceptor)
        Me.TabPage1.Controls.Add(Me.GroupSolicitante)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(827, 604)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Solicitud"
        '
        'chk_Nuevo
        '
        Me.chk_Nuevo.AutoSize = True
        Me.chk_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Nuevo.Location = New System.Drawing.Point(384, 6)
        Me.chk_Nuevo.Name = "chk_Nuevo"
        Me.chk_Nuevo.Size = New System.Drawing.Size(73, 24)
        Me.chk_Nuevo.TabIndex = 26
        Me.chk_Nuevo.Text = "Nuevo"
        Me.chk_Nuevo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "id_ticket"
        '
        'GroupReceptor
        '
        Me.GroupReceptor.Controls.Add(Me.btn_Cancelar_Receptor)
        Me.GroupReceptor.Controls.Add(Me.btn_respuesta)
        Me.GroupReceptor.Controls.Add(Me.Label4)
        Me.GroupReceptor.Controls.Add(Me.txt_comentarios)
        Me.GroupReceptor.Controls.Add(Me.dtp_fecha_estimada)
        Me.GroupReceptor.Controls.Add(Me.dtp_fecha_real)
        Me.GroupReceptor.Controls.Add(Me.Label14)
        Me.GroupReceptor.Controls.Add(Me.cbo_estado)
        Me.GroupReceptor.Controls.Add(Me.cbo_prioridad)
        Me.GroupReceptor.Controls.Add(Me.Label6)
        Me.GroupReceptor.Controls.Add(Me.Label8)
        Me.GroupReceptor.Controls.Add(Me.txt_sector_dirigido)
        Me.GroupReceptor.Controls.Add(Me.Label12)
        Me.GroupReceptor.Controls.Add(Me.Label13)
        Me.GroupReceptor.Location = New System.Drawing.Point(7, 338)
        Me.GroupReceptor.Name = "GroupReceptor"
        Me.GroupReceptor.Size = New System.Drawing.Size(812, 260)
        Me.GroupReceptor.TabIndex = 19
        Me.GroupReceptor.TabStop = False
        Me.GroupReceptor.Text = "Receptor"
        '
        'btn_Cancelar_Receptor
        '
        Me.btn_Cancelar_Receptor.Location = New System.Drawing.Point(731, 219)
        Me.btn_Cancelar_Receptor.Name = "btn_Cancelar_Receptor"
        Me.btn_Cancelar_Receptor.Size = New System.Drawing.Size(75, 33)
        Me.btn_Cancelar_Receptor.TabIndex = 34
        Me.btn_Cancelar_Receptor.Text = "Cancelar"
        Me.btn_Cancelar_Receptor.UseVisualStyleBackColor = True
        '
        'btn_respuesta
        '
        Me.btn_respuesta.Location = New System.Drawing.Point(650, 219)
        Me.btn_respuesta.Name = "btn_respuesta"
        Me.btn_respuesta.Size = New System.Drawing.Size(75, 33)
        Me.btn_respuesta.TabIndex = 33
        Me.btn_respuesta.Text = "Respuesta"
        Me.btn_respuesta.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Comentarios"
        '
        'txt_comentarios
        '
        Me.txt_comentarios.Location = New System.Drawing.Point(86, 140)
        Me.txt_comentarios.MaxLength = 350
        Me.txt_comentarios.Multiline = True
        Me.txt_comentarios.Name = "txt_comentarios"
        Me.txt_comentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_comentarios.Size = New System.Drawing.Size(720, 71)
        Me.txt_comentarios.TabIndex = 31
        '
        'dtp_fecha_estimada
        '
        Me.dtp_fecha_estimada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_estimada.Location = New System.Drawing.Point(146, 67)
        Me.dtp_fecha_estimada.Name = "dtp_fecha_estimada"
        Me.dtp_fecha_estimada.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fecha_estimada.TabIndex = 30
        '
        'dtp_fecha_real
        '
        Me.dtp_fecha_real.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_real.Location = New System.Drawing.Point(553, 67)
        Me.dtp_fecha_real.Name = "dtp_fecha_real"
        Me.dtp_fecha_real.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fecha_real.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Fecha estimada de cierre"
        '
        'cbo_estado
        '
        Me.cbo_estado.FormattingEnabled = True
        Me.cbo_estado.Items.AddRange(New Object() {"Abierto", "Atendido", "Frenado", "Resuelto"})
        Me.cbo_estado.Location = New System.Drawing.Point(553, 28)
        Me.cbo_estado.Name = "cbo_estado"
        Me.cbo_estado.Size = New System.Drawing.Size(156, 21)
        Me.cbo_estado.TabIndex = 28
        '
        'cbo_prioridad
        '
        Me.cbo_prioridad.FormattingEnabled = True
        Me.cbo_prioridad.Items.AddRange(New Object() {"Baja", "Media", "Alta"})
        Me.cbo_prioridad.Location = New System.Drawing.Point(94, 28)
        Me.cbo_prioridad.Name = "cbo_prioridad"
        Me.cbo_prioridad.Size = New System.Drawing.Size(156, 21)
        Me.cbo_prioridad.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(446, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fecha real de cierre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Sector dirigido"
        '
        'txt_sector_dirigido
        '
        Me.txt_sector_dirigido.Location = New System.Drawing.Point(86, 109)
        Me.txt_sector_dirigido.MaxLength = 50
        Me.txt_sector_dirigido.Name = "txt_sector_dirigido"
        Me.txt_sector_dirigido.Size = New System.Drawing.Size(720, 20)
        Me.txt_sector_dirigido.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(507, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Estado"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Prioridad"
        '
        'GroupSolicitante
        '
        Me.GroupSolicitante.Controls.Add(Me.btnCancelar_Solicitante)
        Me.GroupSolicitante.Controls.Add(Me.btn_Solicitud)
        Me.GroupSolicitante.Controls.Add(Me.Label18)
        Me.GroupSolicitante.Controls.Add(Me.txt_id_ticket)
        Me.GroupSolicitante.Controls.Add(Me.Label15)
        Me.GroupSolicitante.Controls.Add(Me.dtp_fecha_pedido)
        Me.GroupSolicitante.Controls.Add(Me.Label5)
        Me.GroupSolicitante.Controls.Add(Me.Label1)
        Me.GroupSolicitante.Controls.Add(Me.Label11)
        Me.GroupSolicitante.Controls.Add(Me.txt_herramienta)
        Me.GroupSolicitante.Controls.Add(Me.Label9)
        Me.GroupSolicitante.Controls.Add(Me.txt_plazo)
        Me.GroupSolicitante.Controls.Add(Me.Label10)
        Me.GroupSolicitante.Controls.Add(Me.txt_descripcion)
        Me.GroupSolicitante.Controls.Add(Me.txt_id_usuario)
        Me.GroupSolicitante.Controls.Add(Me.txt_recurso)
        Me.GroupSolicitante.Controls.Add(Me.txt_nombre_usuario)
        Me.GroupSolicitante.Controls.Add(Me.Label3)
        Me.GroupSolicitante.Controls.Add(Me.Label2)
        Me.GroupSolicitante.Location = New System.Drawing.Point(7, 32)
        Me.GroupSolicitante.Name = "GroupSolicitante"
        Me.GroupSolicitante.Size = New System.Drawing.Size(812, 300)
        Me.GroupSolicitante.TabIndex = 18
        Me.GroupSolicitante.TabStop = False
        Me.GroupSolicitante.Text = "Solicitante"
        '
        'btnCancelar_Solicitante
        '
        Me.btnCancelar_Solicitante.Location = New System.Drawing.Point(731, 258)
        Me.btnCancelar_Solicitante.Name = "btnCancelar_Solicitante"
        Me.btnCancelar_Solicitante.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar_Solicitante.TabIndex = 38
        Me.btnCancelar_Solicitante.Text = "Cancelar"
        Me.btnCancelar_Solicitante.UseVisualStyleBackColor = True
        '
        'btn_Solicitud
        '
        Me.btn_Solicitud.Location = New System.Drawing.Point(650, 258)
        Me.btn_Solicitud.Name = "btn_Solicitud"
        Me.btn_Solicitud.Size = New System.Drawing.Size(75, 33)
        Me.btn_Solicitud.TabIndex = 37
        Me.btn_Solicitud.Text = "Solicitud"
        Me.btn_Solicitud.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(20, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "N° de Ticket"
        '
        'txt_id_ticket
        '
        Me.txt_id_ticket.Location = New System.Drawing.Point(94, 19)
        Me.txt_id_ticket.MaxLength = 10
        Me.txt_id_ticket.Name = "txt_id_ticket"
        Me.txt_id_ticket.Size = New System.Drawing.Size(73, 20)
        Me.txt_id_ticket.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(81, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "*"
        '
        'dtp_fecha_pedido
        '
        Me.dtp_fecha_pedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_pedido.Location = New System.Drawing.Point(391, 19)
        Me.dtp_fecha_pedido.Name = "dtp_fecha_pedido"
        Me.dtp_fecha_pedido.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fecha_pedido.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(298, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Fecha de pedido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "días"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Herramienta"
        '
        'txt_herramienta
        '
        Me.txt_herramienta.Location = New System.Drawing.Point(94, 119)
        Me.txt_herramienta.MaxLength = 50
        Me.txt_herramienta.Name = "txt_herramienta"
        Me.txt_herramienta.Size = New System.Drawing.Size(712, 20)
        Me.txt_herramienta.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Plazo de resolución requerido"
        '
        'txt_plazo
        '
        Me.txt_plazo.Location = New System.Drawing.Point(169, 148)
        Me.txt_plazo.MaxLength = 5
        Me.txt_plazo.Name = "txt_plazo"
        Me.txt_plazo.Size = New System.Drawing.Size(36, 20)
        Me.txt_plazo.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Descripción"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(94, 176)
        Me.txt_descripcion.MaxLength = 350
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_descripcion.Size = New System.Drawing.Size(712, 71)
        Me.txt_descripcion.TabIndex = 5
        '
        'txt_id_usuario
        '
        Me.txt_id_usuario.Location = New System.Drawing.Point(247, 19)
        Me.txt_id_usuario.MaxLength = 10
        Me.txt_id_usuario.Name = "txt_id_usuario"
        Me.txt_id_usuario.Size = New System.Drawing.Size(45, 20)
        Me.txt_id_usuario.TabIndex = 4
        '
        'txt_recurso
        '
        Me.txt_recurso.Location = New System.Drawing.Point(94, 89)
        Me.txt_recurso.MaxLength = 50
        Me.txt_recurso.Name = "txt_recurso"
        Me.txt_recurso.Size = New System.Drawing.Size(712, 20)
        Me.txt_recurso.TabIndex = 1
        '
        'txt_nombre_usuario
        '
        Me.txt_nombre_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nombre_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nombre_usuario.Location = New System.Drawing.Point(94, 57)
        Me.txt_nombre_usuario.MaxLength = 50
        Me.txt_nombre_usuario.Name = "txt_nombre_usuario"
        Me.txt_nombre_usuario.Size = New System.Drawing.Size(712, 20)
        Me.txt_nombre_usuario.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Recurso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuario"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.btn_Exportar_EXCEL)
        Me.TabPage2.Controls.Add(Me.cbo_busqueda_estado)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.btn_cancelar)
        Me.TabPage2.Controls.Add(Me.btn_eliminar)
        Me.TabPage2.Controls.Add(Me.dgv_lista_ticket)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(827, 604)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Búsqueda"
        '
        'btn_Exportar_EXCEL
        '
        Me.btn_Exportar_EXCEL.Location = New System.Drawing.Point(549, 564)
        Me.btn_Exportar_EXCEL.Name = "btn_Exportar_EXCEL"
        Me.btn_Exportar_EXCEL.Size = New System.Drawing.Size(108, 33)
        Me.btn_Exportar_EXCEL.TabIndex = 31
        Me.btn_Exportar_EXCEL.Text = "Exportar a EXCEL"
        Me.btn_Exportar_EXCEL.UseVisualStyleBackColor = True
        '
        'cbo_busqueda_estado
        '
        Me.cbo_busqueda_estado.FormattingEnabled = True
        Me.cbo_busqueda_estado.Items.AddRange(New Object() {"Todos", "Abierto", "Atendido", "Frenado", "Resuelto"})
        Me.cbo_busqueda_estado.Location = New System.Drawing.Point(703, 15)
        Me.cbo_busqueda_estado.Name = "cbo_busqueda_estado"
        Me.cbo_busqueda_estado.Size = New System.Drawing.Size(116, 21)
        Me.cbo_busqueda_estado.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(657, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Estado"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(744, 564)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 33)
        Me.btn_cancelar.TabIndex = 21
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(663, 564)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 33)
        Me.btn_eliminar.TabIndex = 21
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'dgv_lista_ticket
        '
        Me.dgv_lista_ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista_ticket.Location = New System.Drawing.Point(8, 49)
        Me.dgv_lista_ticket.Name = "dgv_lista_ticket"
        Me.dgv_lista_ticket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista_ticket.Size = New System.Drawing.Size(811, 508)
        Me.dgv_lista_ticket.TabIndex = 0
        '
        'frm_Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 632)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_Ticket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ticket"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupReceptor.ResumeLayout(False)
        Me.GroupReceptor.PerformLayout()
        Me.GroupSolicitante.ResumeLayout(False)
        Me.GroupSolicitante.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_lista_ticket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txt_id_ticket As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupReceptor As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_comentarios As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha_estimada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_real As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbo_estado As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_prioridad As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_sector_dirigido As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupSolicitante As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_pedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_herramienta As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_plazo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_recurso As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_lista_ticket As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents cbo_busqueda_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chk_Nuevo As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Exportar_EXCEL As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar_Receptor As System.Windows.Forms.Button
    Friend WithEvents btn_respuesta As System.Windows.Forms.Button
    Friend WithEvents btnCancelar_Solicitante As System.Windows.Forms.Button
    Friend WithEvents btn_Solicitud As System.Windows.Forms.Button
End Class
