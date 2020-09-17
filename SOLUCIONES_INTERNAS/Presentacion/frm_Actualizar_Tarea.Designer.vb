<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Actualizar_Tarea
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
        Me.btn_Actualizar_Tarea = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_hora_fin = New System.Windows.Forms.TextBox()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.txt_tiempo_estimado = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txt_tiempo_real = New System.Windows.Forms.TextBox()
        Me.txt_numero_orden = New System.Windows.Forms.TextBox()
        Me.btn_buscar_numero_orden = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txt_id_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txt_tarea = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSalida = New System.Windows.Forms.TextBox()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Carga_Horaria = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btn_buscar_colaborador = New System.Windows.Forms.Button()
        Me.txt_nombre_colaborador = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id_colaborador = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_id_tarea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Actualizar_Tarea
        '
        Me.btn_Actualizar_Tarea.Location = New System.Drawing.Point(430, 303)
        Me.btn_Actualizar_Tarea.Name = "btn_Actualizar_Tarea"
        Me.btn_Actualizar_Tarea.Size = New System.Drawing.Size(75, 33)
        Me.btn_Actualizar_Tarea.TabIndex = 10
        Me.btn_Actualizar_Tarea.Text = "Actualizar"
        Me.btn_Actualizar_Tarea.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(511, 303)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 33)
        Me.btn_Cancelar.TabIndex = 11
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(349, 303)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 33)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_hora_fin)
        Me.GroupBox3.Controls.Add(Me.txt_observaciones)
        Me.GroupBox3.Controls.Add(Me.txt_tiempo_estimado)
        Me.GroupBox3.Controls.Add(Me.Label58)
        Me.GroupBox3.Controls.Add(Me.Label59)
        Me.GroupBox3.Controls.Add(Me.txt_tiempo_real)
        Me.GroupBox3.Controls.Add(Me.txt_numero_orden)
        Me.GroupBox3.Controls.Add(Me.btn_buscar_numero_orden)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.txt_id_orden_trabajo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label57)
        Me.GroupBox3.Controls.Add(Me.txt_tarea)
        Me.GroupBox3.Controls.Add(Me.Label61)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(574, 189)
        Me.GroupBox3.TabIndex = 189
        Me.GroupBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(430, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 204
        Me.Label6.Text = "*"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Red
        Me.Label37.Location = New System.Drawing.Point(55, 25)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(11, 13)
        Me.Label37.TabIndex = 203
        Me.Label37.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "Hs de Fin"
        '
        'txt_hora_fin
        '
        Me.txt_hora_fin.Location = New System.Drawing.Point(282, 59)
        Me.txt_hora_fin.Name = "txt_hora_fin"
        Me.txt_hora_fin.Size = New System.Drawing.Size(55, 20)
        Me.txt_hora_fin.TabIndex = 188
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(96, 98)
        Me.txt_observaciones.MaxLength = 200
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(469, 78)
        Me.txt_observaciones.TabIndex = 191
        '
        'txt_tiempo_estimado
        '
        Me.txt_tiempo_estimado.Location = New System.Drawing.Point(68, 58)
        Me.txt_tiempo_estimado.Name = "txt_tiempo_estimado"
        Me.txt_tiempo_estimado.Size = New System.Drawing.Size(44, 20)
        Me.txt_tiempo_estimado.TabIndex = 189
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(6, 62)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(63, 13)
        Me.Label58.TabIndex = 200
        Me.Label58.Text = "T. Estimado"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(118, 62)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(42, 13)
        Me.Label59.TabIndex = 201
        Me.Label59.Text = "T. Real"
        '
        'txt_tiempo_real
        '
        Me.txt_tiempo_real.Location = New System.Drawing.Point(166, 58)
        Me.txt_tiempo_real.Name = "txt_tiempo_real"
        Me.txt_tiempo_real.Size = New System.Drawing.Size(45, 20)
        Me.txt_tiempo_real.TabIndex = 190
        '
        'txt_numero_orden
        '
        Me.txt_numero_orden.Location = New System.Drawing.Point(442, 58)
        Me.txt_numero_orden.Name = "txt_numero_orden"
        Me.txt_numero_orden.Size = New System.Drawing.Size(71, 20)
        Me.txt_numero_orden.TabIndex = 199
        '
        'btn_buscar_numero_orden
        '
        Me.btn_buscar_numero_orden.Location = New System.Drawing.Point(519, 58)
        Me.btn_buscar_numero_orden.Name = "btn_buscar_numero_orden"
        Me.btn_buscar_numero_orden.Size = New System.Drawing.Size(49, 23)
        Me.btn_buscar_numero_orden.TabIndex = 187
        Me.btn_buscar_numero_orden.Text = "..."
        Me.btn_buscar_numero_orden.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(346, 61)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(86, 13)
        Me.Label36.TabIndex = 196
        Me.Label36.Text = "Orden de trabajo"
        '
        'txt_id_orden_trabajo
        '
        Me.txt_id_orden_trabajo.Location = New System.Drawing.Point(73, 133)
        Me.txt_id_orden_trabajo.Name = "txt_id_orden_trabajo"
        Me.txt_id_orden_trabajo.Size = New System.Drawing.Size(13, 20)
        Me.txt_id_orden_trabajo.TabIndex = 198
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(346, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 197
        Me.Label2.Text = "Orden de trabajo"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(12, 101)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(78, 13)
        Me.Label57.TabIndex = 194
        Me.Label57.Text = "Observaciones"
        '
        'txt_tarea
        '
        Me.txt_tarea.Location = New System.Drawing.Point(68, 19)
        Me.txt_tarea.MaxLength = 100
        Me.txt_tarea.Name = "txt_tarea"
        Me.txt_tarea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_tarea.Size = New System.Drawing.Size(500, 20)
        Me.txt_tarea.TabIndex = 186
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(15, 22)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(40, 13)
        Me.Label61.TabIndex = 195
        Me.Label61.Text = "Tareas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtSalida)
        Me.GroupBox2.Controls.Add(Me.txtEntrada)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_Carga_Horaria)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.Label62)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.btn_buscar_colaborador)
        Me.GroupBox2.Controls.Add(Me.txt_nombre_colaborador)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_id_colaborador)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(574, 90)
        Me.GroupBox2.TabIndex = 188
        Me.GroupBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(282, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(82, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 204
        Me.Label9.Text = "*"
        '
        'txtSalida
        '
        Me.txtSalida.Location = New System.Drawing.Point(299, 60)
        Me.txtSalida.Name = "txtSalida"
        Me.txtSalida.Size = New System.Drawing.Size(51, 20)
        Me.txtSalida.TabIndex = 202
        '
        'txtEntrada
        '
        Me.txtEntrada.Location = New System.Drawing.Point(99, 60)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(51, 20)
        Me.txtEntrada.TabIndex = 203
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(219, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 200
        Me.Label8.Text = "Hora Salida:"
        '
        'txt_Carga_Horaria
        '
        Me.txt_Carga_Horaria.Location = New System.Drawing.Point(504, 60)
        Me.txt_Carga_Horaria.Name = "txt_Carga_Horaria"
        Me.txt_Carga_Horaria.Size = New System.Drawing.Size(49, 20)
        Me.txt_Carga_Horaria.TabIndex = 191
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(433, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 196
        Me.Label13.Text = "Carga horaria"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(11, 63)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(73, 13)
        Me.Label33.TabIndex = 201
        Me.Label33.Text = "Hora Entrada:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(83, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 199
        Me.Label7.Text = "*"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(471, 23)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpFecha.TabIndex = 190
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(428, 26)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(37, 13)
        Me.Label62.TabIndex = 197
        Me.Label62.Text = "Fecha"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(428, 26)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(37, 13)
        Me.Label31.TabIndex = 198
        Me.Label31.Text = "Fecha"
        '
        'btn_buscar_colaborador
        '
        Me.btn_buscar_colaborador.Location = New System.Drawing.Point(343, 20)
        Me.btn_buscar_colaborador.Name = "btn_buscar_colaborador"
        Me.btn_buscar_colaborador.Size = New System.Drawing.Size(54, 23)
        Me.btn_buscar_colaborador.TabIndex = 189
        Me.btn_buscar_colaborador.Text = "..."
        Me.btn_buscar_colaborador.UseVisualStyleBackColor = True
        '
        'txt_nombre_colaborador
        '
        Me.txt_nombre_colaborador.Location = New System.Drawing.Point(99, 22)
        Me.txt_nombre_colaborador.Name = "txt_nombre_colaborador"
        Me.txt_nombre_colaborador.Size = New System.Drawing.Size(238, 20)
        Me.txt_nombre_colaborador.TabIndex = 195
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 192
        Me.Label4.Text = "Colaborador"
        '
        'txt_id_colaborador
        '
        Me.txt_id_colaborador.Location = New System.Drawing.Point(398, 22)
        Me.txt_id_colaborador.Name = "txt_id_colaborador"
        Me.txt_id_colaborador.Size = New System.Drawing.Size(13, 20)
        Me.txt_id_colaborador.TabIndex = 194
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "Colaborador"
        '
        'txt_id_tarea
        '
        Me.txt_id_tarea.Location = New System.Drawing.Point(297, 310)
        Me.txt_id_tarea.Name = "txt_id_tarea"
        Me.txt_id_tarea.Size = New System.Drawing.Size(27, 20)
        Me.txt_id_tarea.TabIndex = 192
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 193
        Me.Label1.Text = "id_tarea"
        '
        'frm_Actualizar_Tarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 350)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Actualizar_Tarea)
        Me.Controls.Add(Me.txt_id_tarea)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_Actualizar_Tarea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Tarea"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Actualizar_Tarea As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_hora_fin As System.Windows.Forms.TextBox
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents txt_tiempo_estimado As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txt_tiempo_real As System.Windows.Forms.TextBox
    Friend WithEvents txt_numero_orden As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar_numero_orden As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txt_id_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txt_tarea As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSalida As System.Windows.Forms.TextBox
    Friend WithEvents txtEntrada As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Carga_Horaria As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar_colaborador As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_id_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_id_tarea As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
