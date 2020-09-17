<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Actualizar_Producto_Orden
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
        Me.GroupProducto1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txt_id_detalle_orden_trabajo1 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.cboPiezas = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cboFormato3_Soporte = New System.Windows.Forms.ComboBox()
        Me.cboFormato2_Soporte = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_Cantidad3_Soporte = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad2_Soporte = New System.Windows.Forms.TextBox()
        Me.cboFormato1_Soporte = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_Cantidad1_Soporte = New System.Windows.Forms.TextBox()
        Me.cboTipoImpresion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTamaño = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.txtNumero_Orden_Trabajo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPapel1 = New System.Windows.Forms.ComboBox()
        Me.cboPapel2 = New System.Windows.Forms.ComboBox()
        Me.cboPapel3 = New System.Windows.Forms.ComboBox()
        Me.cboGramaje1 = New System.Windows.Forms.ComboBox()
        Me.cboGramaje2 = New System.Windows.Forms.ComboBox()
        Me.cboGramaje3 = New System.Windows.Forms.ComboBox()
        Me.GroupProducto1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupProducto1
        '
        Me.GroupProducto1.Controls.Add(Me.Label7)
        Me.GroupProducto1.Controls.Add(Me.btnCancelar)
        Me.GroupProducto1.Controls.Add(Me.btnActualizar)
        Me.GroupProducto1.Controls.Add(Me.Label51)
        Me.GroupProducto1.Controls.Add(Me.txt_id_detalle_orden_trabajo1)
        Me.GroupProducto1.Controls.Add(Me.Label50)
        Me.GroupProducto1.Controls.Add(Me.Label49)
        Me.GroupProducto1.Controls.Add(Me.Label45)
        Me.GroupProducto1.Controls.Add(Me.Label48)
        Me.GroupProducto1.Controls.Add(Me.cboPiezas)
        Me.GroupProducto1.Controls.Add(Me.GroupBox5)
        Me.GroupProducto1.Controls.Add(Me.cboTipoImpresion)
        Me.GroupProducto1.Controls.Add(Me.Label8)
        Me.GroupProducto1.Controls.Add(Me.Label3)
        Me.GroupProducto1.Controls.Add(Me.Label2)
        Me.GroupProducto1.Controls.Add(Me.txtTamaño)
        Me.GroupProducto1.Controls.Add(Me.txt_cantidad)
        Me.GroupProducto1.Location = New System.Drawing.Point(12, 69)
        Me.GroupProducto1.Name = "GroupProducto1"
        Me.GroupProducto1.Size = New System.Drawing.Size(456, 258)
        Me.GroupProducto1.TabIndex = 60
        Me.GroupProducto1.TabStop = False
        Me.GroupProducto1.Text = "Producto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(242, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Tamaño (°°° x °°° Mm)"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(369, 214)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar.TabIndex = 62
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(288, 214)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 33)
        Me.btnActualizar.TabIndex = 61
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.Red
        Me.Label51.Location = New System.Drawing.Point(441, 26)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(11, 13)
        Me.Label51.TabIndex = 60
        Me.Label51.Text = "*"
        '
        'txt_id_detalle_orden_trabajo1
        '
        Me.txt_id_detalle_orden_trabajo1.Location = New System.Drawing.Point(137, 213)
        Me.txt_id_detalle_orden_trabajo1.Name = "txt_id_detalle_orden_trabajo1"
        Me.txt_id_detalle_orden_trabajo1.Size = New System.Drawing.Size(38, 20)
        Me.txt_id_detalle_orden_trabajo1.TabIndex = 57
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.Red
        Me.Label50.Location = New System.Drawing.Point(348, 27)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(11, 13)
        Me.Label50.TabIndex = 59
        Me.Label50.Text = "*"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.Red
        Me.Label49.Location = New System.Drawing.Point(166, 27)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(11, 13)
        Me.Label49.TabIndex = 58
        Me.Label49.Text = "*"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(8, 216)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(129, 13)
        Me.Label45.TabIndex = 56
        Me.Label45.Text = "id_detalle_orden_trabajo1"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.Color.Red
        Me.Label48.Location = New System.Drawing.Point(65, 26)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(11, 13)
        Me.Label48.TabIndex = 57
        Me.Label48.Text = "*"
        '
        'cboPiezas
        '
        Me.cboPiezas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPiezas.FormattingEnabled = True
        Me.cboPiezas.Location = New System.Drawing.Point(80, 41)
        Me.cboPiezas.Name = "cboPiezas"
        Me.cboPiezas.Size = New System.Drawing.Size(162, 21)
        Me.cboPiezas.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cboGramaje3)
        Me.GroupBox5.Controls.Add(Me.cboGramaje2)
        Me.GroupBox5.Controls.Add(Me.cboGramaje1)
        Me.GroupBox5.Controls.Add(Me.cboPapel3)
        Me.GroupBox5.Controls.Add(Me.cboPapel2)
        Me.GroupBox5.Controls.Add(Me.cboPapel1)
        Me.GroupBox5.Controls.Add(Me.cboFormato3_Soporte)
        Me.GroupBox5.Controls.Add(Me.cboFormato2_Soporte)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txt_Cantidad3_Soporte)
        Me.GroupBox5.Controls.Add(Me.txt_Cantidad2_Soporte)
        Me.GroupBox5.Controls.Add(Me.cboFormato1_Soporte)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.txt_Cantidad1_Soporte)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 84)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(433, 124)
        Me.GroupBox5.TabIndex = 55
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Soportes"
        '
        'cboFormato3_Soporte
        '
        Me.cboFormato3_Soporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato3_Soporte.FormattingEnabled = True
        Me.cboFormato3_Soporte.Items.AddRange(New Object() {"Mts.", "Mts2", "Unidad"})
        Me.cboFormato3_Soporte.Location = New System.Drawing.Point(338, 89)
        Me.cboFormato3_Soporte.Name = "cboFormato3_Soporte"
        Me.cboFormato3_Soporte.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato3_Soporte.TabIndex = 22
        '
        'cboFormato2_Soporte
        '
        Me.cboFormato2_Soporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato2_Soporte.FormattingEnabled = True
        Me.cboFormato2_Soporte.Items.AddRange(New Object() {"Mts.", "Mts2", "Unidad"})
        Me.cboFormato2_Soporte.Location = New System.Drawing.Point(338, 64)
        Me.cboFormato2_Soporte.Name = "cboFormato2_Soporte"
        Me.cboFormato2_Soporte.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato2_Soporte.TabIndex = 18
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
        'txt_Cantidad3_Soporte
        '
        Me.txt_Cantidad3_Soporte.Location = New System.Drawing.Point(263, 89)
        Me.txt_Cantidad3_Soporte.Name = "txt_Cantidad3_Soporte"
        Me.txt_Cantidad3_Soporte.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad3_Soporte.TabIndex = 21
        '
        'txt_Cantidad2_Soporte
        '
        Me.txt_Cantidad2_Soporte.Location = New System.Drawing.Point(263, 63)
        Me.txt_Cantidad2_Soporte.Name = "txt_Cantidad2_Soporte"
        Me.txt_Cantidad2_Soporte.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad2_Soporte.TabIndex = 17
        '
        'cboFormato1_Soporte
        '
        Me.cboFormato1_Soporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato1_Soporte.FormattingEnabled = True
        Me.cboFormato1_Soporte.Items.AddRange(New Object() {"Mts.", "Mts2", "Unidad"})
        Me.cboFormato1_Soporte.Location = New System.Drawing.Point(338, 38)
        Me.cboFormato1_Soporte.Name = "cboFormato1_Soporte"
        Me.cboFormato1_Soporte.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato1_Soporte.TabIndex = 14
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(335, 17)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 13)
        Me.Label26.TabIndex = 29
        Me.Label26.Text = "Formato"
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
        Me.Label25.Location = New System.Drawing.Point(21, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 13)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "Papel/Sustrato"
        '
        'txt_Cantidad1_Soporte
        '
        Me.txt_Cantidad1_Soporte.Location = New System.Drawing.Point(263, 38)
        Me.txt_Cantidad1_Soporte.Name = "txt_Cantidad1_Soporte"
        Me.txt_Cantidad1_Soporte.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad1_Soporte.TabIndex = 13
        '
        'cboTipoImpresion
        '
        Me.cboTipoImpresion.FormattingEnabled = True
        Me.cboTipoImpresion.Items.AddRange(New Object() {"1/0", "1/1", "1/4", "4/0", "4/1", "4/4"})
        Me.cboTipoImpresion.Location = New System.Drawing.Point(373, 41)
        Me.cboTipoImpresion.Name = "cboTipoImpresion"
        Me.cboTipoImpresion.Size = New System.Drawing.Size(63, 21)
        Me.cboTipoImpresion.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(367, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Tipo Impresión"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Piezas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Cantidad"
        '
        'txtTamaño
        '
        Me.txtTamaño.Location = New System.Drawing.Point(248, 41)
        Me.txtTamaño.Name = "txtTamaño"
        Me.txtTamaño.Size = New System.Drawing.Size(106, 20)
        Me.txtTamaño.TabIndex = 9
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(15, 42)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(59, 20)
        Me.txt_cantidad.TabIndex = 7
        '
        'txtNumero_Orden_Trabajo
        '
        Me.txtNumero_Orden_Trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero_Orden_Trabajo.Location = New System.Drawing.Point(195, 12)
        Me.txtNumero_Orden_Trabajo.Multiline = True
        Me.txtNumero_Orden_Trabajo.Name = "txtNumero_Orden_Trabajo"
        Me.txtNumero_Orden_Trabajo.Size = New System.Drawing.Size(118, 48)
        Me.txtNumero_Orden_Trabajo.TabIndex = 63
        Me.txtNumero_Orden_Trabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(143, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 26)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Número" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orden"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_id_orden_trabajo
        '
        Me.txt_id_orden_trabajo.Location = New System.Drawing.Point(381, 28)
        Me.txt_id_orden_trabajo.Name = "txt_id_orden_trabajo"
        Me.txt_id_orden_trabajo.Size = New System.Drawing.Size(35, 20)
        Me.txt_id_orden_trabajo.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "id_orden"
        '
        'cboPapel1
        '
        Me.cboPapel1.FormattingEnabled = True
        Me.cboPapel1.Location = New System.Drawing.Point(24, 38)
        Me.cboPapel1.Name = "cboPapel1"
        Me.cboPapel1.Size = New System.Drawing.Size(163, 21)
        Me.cboPapel1.TabIndex = 59
        '
        'cboPapel2
        '
        Me.cboPapel2.FormattingEnabled = True
        Me.cboPapel2.Location = New System.Drawing.Point(24, 63)
        Me.cboPapel2.Name = "cboPapel2"
        Me.cboPapel2.Size = New System.Drawing.Size(163, 21)
        Me.cboPapel2.TabIndex = 59
        '
        'cboPapel3
        '
        Me.cboPapel3.FormattingEnabled = True
        Me.cboPapel3.Location = New System.Drawing.Point(24, 89)
        Me.cboPapel3.Name = "cboPapel3"
        Me.cboPapel3.Size = New System.Drawing.Size(163, 21)
        Me.cboPapel3.TabIndex = 59
        '
        'cboGramaje1
        '
        Me.cboGramaje1.FormattingEnabled = True
        Me.cboGramaje1.Items.AddRange(New Object() {"70", "75", "80", "90", "115", "120", "130", "150", "170", "180", "200", "210", "220", "225", "240", "250", "300", "310", "350"})
        Me.cboGramaje1.Location = New System.Drawing.Point(193, 38)
        Me.cboGramaje1.Name = "cboGramaje1"
        Me.cboGramaje1.Size = New System.Drawing.Size(63, 21)
        Me.cboGramaje1.TabIndex = 60
        '
        'cboGramaje2
        '
        Me.cboGramaje2.FormattingEnabled = True
        Me.cboGramaje2.Items.AddRange(New Object() {"70", "75", "80", "90", "115", "120", "130", "150", "170", "180", "200", "210", "220", "225", "240", "250", "300", "310", "350"})
        Me.cboGramaje2.Location = New System.Drawing.Point(193, 64)
        Me.cboGramaje2.Name = "cboGramaje2"
        Me.cboGramaje2.Size = New System.Drawing.Size(63, 21)
        Me.cboGramaje2.TabIndex = 60
        '
        'cboGramaje3
        '
        Me.cboGramaje3.FormattingEnabled = True
        Me.cboGramaje3.Items.AddRange(New Object() {"70", "75", "80", "90", "115", "120", "130", "150", "170", "180", "200", "210", "220", "225", "240", "250", "300", "310", "350"})
        Me.cboGramaje3.Location = New System.Drawing.Point(193, 89)
        Me.cboGramaje3.Name = "cboGramaje3"
        Me.cboGramaje3.Size = New System.Drawing.Size(63, 21)
        Me.cboGramaje3.TabIndex = 60
        '
        'frm_Actualizar_Producto_Orden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 337)
        Me.Controls.Add(Me.txt_id_orden_trabajo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumero_Orden_Trabajo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupProducto1)
        Me.Name = "frm_Actualizar_Producto_Orden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Producto de la Orden"
        Me.GroupProducto1.ResumeLayout(False)
        Me.GroupProducto1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupProducto1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txt_id_detalle_orden_trabajo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents cboPiezas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFormato3_Soporte As System.Windows.Forms.ComboBox
    Friend WithEvents cboFormato2_Soporte As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_Cantidad3_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad2_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents cboFormato1_Soporte As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_Cantidad1_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoImpresion As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTamaño As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero_Orden_Trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txt_id_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboPapel3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPapel2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPapel1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboGramaje3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboGramaje2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboGramaje1 As System.Windows.Forms.ComboBox
End Class
