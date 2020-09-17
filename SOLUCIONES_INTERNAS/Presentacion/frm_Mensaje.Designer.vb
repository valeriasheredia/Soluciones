<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Mensaje
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
        Me.GroupRespuesta = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_respuesta = New System.Windows.Forms.TextBox()
        Me.btn_respuesta = New System.Windows.Forms.Button()
        Me.GroupComentario = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Titulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Envio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_id_mensaje = New System.Windows.Forms.TextBox()
        Me.dtp_fecha_pedido = New System.Windows.Forms.DateTimePicker()
        Me.txt_id_usuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.txt_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtFecha = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dgv_Listado_Mensajes = New System.Windows.Forms.DataGridView()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupRespuesta.SuspendLayout()
        Me.GroupComentario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_Listado_Mensajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(715, 540)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupRespuesta)
        Me.TabPage1.Controls.Add(Me.GroupComentario)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(707, 514)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mensaje"
        '
        'GroupRespuesta
        '
        Me.GroupRespuesta.Controls.Add(Me.Label8)
        Me.GroupRespuesta.Controls.Add(Me.Label15)
        Me.GroupRespuesta.Controls.Add(Me.Label4)
        Me.GroupRespuesta.Controls.Add(Me.txt_respuesta)
        Me.GroupRespuesta.Controls.Add(Me.btn_respuesta)
        Me.GroupRespuesta.Location = New System.Drawing.Point(9, 310)
        Me.GroupRespuesta.Name = "GroupRespuesta"
        Me.GroupRespuesta.Size = New System.Drawing.Size(688, 198)
        Me.GroupRespuesta.TabIndex = 30
        Me.GroupRespuesta.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(91, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Fundamente su Respuesta"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(82, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Respuesta"
        '
        'txt_respuesta
        '
        Me.txt_respuesta.Location = New System.Drawing.Point(94, 19)
        Me.txt_respuesta.MaxLength = 350
        Me.txt_respuesta.Multiline = True
        Me.txt_respuesta.Name = "txt_respuesta"
        Me.txt_respuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_respuesta.Size = New System.Drawing.Size(576, 131)
        Me.txt_respuesta.TabIndex = 42
        '
        'btn_respuesta
        '
        Me.btn_respuesta.Location = New System.Drawing.Point(595, 156)
        Me.btn_respuesta.Name = "btn_respuesta"
        Me.btn_respuesta.Size = New System.Drawing.Size(75, 33)
        Me.btn_respuesta.TabIndex = 41
        Me.btn_respuesta.Text = "Respuesta"
        Me.btn_respuesta.UseVisualStyleBackColor = True
        '
        'GroupComentario
        '
        Me.GroupComentario.Controls.Add(Me.PictureBox1)
        Me.GroupComentario.Controls.Add(Me.Label7)
        Me.GroupComentario.Controls.Add(Me.Label6)
        Me.GroupComentario.Controls.Add(Me.txt_Titulo)
        Me.GroupComentario.Controls.Add(Me.Label3)
        Me.GroupComentario.Controls.Add(Me.btn_Envio)
        Me.GroupComentario.Controls.Add(Me.Label1)
        Me.GroupComentario.Controls.Add(Me.Label18)
        Me.GroupComentario.Controls.Add(Me.txt_id_mensaje)
        Me.GroupComentario.Controls.Add(Me.dtp_fecha_pedido)
        Me.GroupComentario.Controls.Add(Me.txt_id_usuario)
        Me.GroupComentario.Controls.Add(Me.Label5)
        Me.GroupComentario.Controls.Add(Me.Label10)
        Me.GroupComentario.Controls.Add(Me.txt_comentario)
        Me.GroupComentario.Controls.Add(Me.txt_nombre_usuario)
        Me.GroupComentario.Controls.Add(Me.Label2)
        Me.GroupComentario.Location = New System.Drawing.Point(9, 6)
        Me.GroupComentario.Name = "GroupComentario"
        Me.GroupComentario.Size = New System.Drawing.Size(688, 298)
        Me.GroupComentario.TabIndex = 29
        Me.GroupComentario.TabStop = False
        Me.GroupComentario.Text = "Comentario"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(551, 131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(80, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(82, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "*"
        '
        'txt_Titulo
        '
        Me.txt_Titulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_Titulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_Titulo.Location = New System.Drawing.Point(94, 93)
        Me.txt_Titulo.MaxLength = 50
        Me.txt_Titulo.Name = "txt_Titulo"
        Me.txt_Titulo.Size = New System.Drawing.Size(576, 20)
        Me.txt_Titulo.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Título"
        '
        'btn_Envio
        '
        Me.btn_Envio.Location = New System.Drawing.Point(595, 256)
        Me.btn_Envio.Name = "btn_Envio"
        Me.btn_Envio.Size = New System.Drawing.Size(75, 33)
        Me.btn_Envio.TabIndex = 41
        Me.btn_Envio.Text = "Envío"
        Me.btn_Envio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "id_usuario"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(316, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "id_mensaje"
        '
        'txt_id_mensaje
        '
        Me.txt_id_mensaje.Location = New System.Drawing.Point(382, 22)
        Me.txt_id_mensaje.MaxLength = 10
        Me.txt_id_mensaje.Name = "txt_id_mensaje"
        Me.txt_id_mensaje.Size = New System.Drawing.Size(46, 20)
        Me.txt_id_mensaje.TabIndex = 24
        '
        'dtp_fecha_pedido
        '
        Me.dtp_fecha_pedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_pedido.Location = New System.Drawing.Point(94, 22)
        Me.dtp_fecha_pedido.Name = "dtp_fecha_pedido"
        Me.dtp_fecha_pedido.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fecha_pedido.TabIndex = 34
        '
        'txt_id_usuario
        '
        Me.txt_id_usuario.Location = New System.Drawing.Point(273, 22)
        Me.txt_id_usuario.MaxLength = 10
        Me.txt_id_usuario.Name = "txt_id_usuario"
        Me.txt_id_usuario.Size = New System.Drawing.Size(22, 20)
        Me.txt_id_usuario.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Fecha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 26)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Observación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   de Carga"
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(94, 132)
        Me.txt_comentario.MaxLength = 350
        Me.txt_comentario.Multiline = True
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_comentario.Size = New System.Drawing.Size(451, 119)
        Me.txt_comentario.TabIndex = 5
        '
        'txt_nombre_usuario
        '
        Me.txt_nombre_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nombre_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nombre_usuario.Location = New System.Drawing.Point(94, 57)
        Me.txt_nombre_usuario.MaxLength = 50
        Me.txt_nombre_usuario.Name = "txt_nombre_usuario"
        Me.txt_nombre_usuario.Size = New System.Drawing.Size(576, 20)
        Me.txt_nombre_usuario.TabIndex = 0
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
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.dgv_Listado_Mensajes)
        Me.TabPage2.Controls.Add(Me.btn_cancelar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(707, 514)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Informes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtFecha)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 58)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'rbtFecha
        '
        Me.rbtFecha.AutoSize = True
        Me.rbtFecha.Location = New System.Drawing.Point(263, 22)
        Me.rbtFecha.Name = "rbtFecha"
        Me.rbtFecha.Size = New System.Drawing.Size(55, 17)
        Me.rbtFecha.TabIndex = 39
        Me.rbtFecha.TabStop = True
        Me.rbtFecha.Text = "Fecha"
        Me.rbtFecha.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(324, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker1.TabIndex = 38
        '
        'dgv_Listado_Mensajes
        '
        Me.dgv_Listado_Mensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Listado_Mensajes.Location = New System.Drawing.Point(10, 68)
        Me.dgv_Listado_Mensajes.Name = "dgv_Listado_Mensajes"
        Me.dgv_Listado_Mensajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Listado_Mensajes.Size = New System.Drawing.Size(687, 395)
        Me.dgv_Listado_Mensajes.TabIndex = 36
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(622, 472)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 33)
        Me.btn_cancelar.TabIndex = 34
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_Mensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 538)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_Mensaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensaje"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupRespuesta.ResumeLayout(False)
        Me.GroupRespuesta.PerformLayout()
        Me.GroupComentario.ResumeLayout(False)
        Me.GroupComentario.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_Listado_Mensajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupRespuesta As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_respuesta As System.Windows.Forms.TextBox
    Friend WithEvents btn_respuesta As System.Windows.Forms.Button
    Friend WithEvents GroupComentario As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Titulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_Envio As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_id_mensaje As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha_pedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_id_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_comentario As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents dgv_Listado_Mensajes As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtFecha As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
