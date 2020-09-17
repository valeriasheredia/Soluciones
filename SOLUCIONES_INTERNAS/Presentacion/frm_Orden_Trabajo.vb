Public Class frm_Orden_Trabajo

    Dim datacontext As New DataS_Interno
    Public quienllamo_listado_orden As Form
    Dim cargamasprod As String = "NO"


    Private Sub frm_Orden_Trabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If quienllamo_listado_orden.Name <> frm_Listado_Orden_Trabajo.Name Then
            'CARGA COMBOBOX PIEZA DETALLE 1
            Dim combopieza1 = (From sec In datacontext.PIEZA
                               Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                               Order By PIE_nombre_pie Ascending)
            cboPiezas1_Detalle1.DataSource = combopieza1
            cboPiezas1_Detalle1.DisplayMember = "PIE_nombre_pie"
            cboPiezas1_Detalle1.ValueMember = "PIE_id_pieza"
            cboPiezas1_Detalle1.SelectedIndex = -1

            'CARGA COMBOBOX PIEZA DETALLE 2
            Dim combopieza2 = (From sec In datacontext.PIEZA
                               Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                               Order By PIE_nombre_pie Ascending)
            cboPiezas2_Detalle2.DataSource = combopieza2
            cboPiezas2_Detalle2.DisplayMember = "PIE_nombre_pie"
            cboPiezas2_Detalle2.ValueMember = "PIE_id_pieza"
            cboPiezas2_Detalle2.SelectedIndex = -1

            'CARGA COMBOBOX PIEZA DETALLE 3
            Dim combopieza3 = (From sec In datacontext.PIEZA
                               Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                               Order By PIE_nombre_pie Ascending)
            cboPiezas3_Detalle3.DataSource = combopieza3
            cboPiezas3_Detalle3.DisplayMember = "PIE_nombre_pie"
            cboPiezas3_Detalle3.ValueMember = "PIE_id_pieza"
            cboPiezas3_Detalle3.SelectedIndex = -1
        Else
            cboPiezas1_Detalle1.SelectedValue = frm_Listado_Orden_Trabajo.dgv_detalle_orden.Item("PIE_id_pieza", frm_Listado_Orden_Trabajo.dgv_detalle_orden.Rows(0).Index).Value
            cboPiezas2_Detalle2.SelectedValue = frm_Listado_Orden_Trabajo.dgv_detalle_orden.Item("PIE_id_pieza", frm_Listado_Orden_Trabajo.dgv_detalle_orden.Rows(1).Index).Value
            cboPiezas3_Detalle3.SelectedValue = frm_Listado_Orden_Trabajo.dgv_detalle_orden.Item("PIE_id_pieza", frm_Listado_Orden_Trabajo.dgv_detalle_orden.Rows(2).Index).Value
        End If
    End Sub

    Sub limpiarcontroles()
        'LIMPIA ORDEN TRABAJO
        txt_id_orden_trabajo.Clear()
        dtpFecha_Orden_Trabajo.Text = Now
        dtpFecha_Entrega.Text = Now
        cboTipo_Orden.SelectedIndex = -1
        txtNumero_Orden_Trabajo.Clear()
        txt_observaciones.Clear()
        txt_mejoras.Clear()
        txtid_vendedor.Clear()
        txtNombre_vendedor.Clear()
        txt_id_cliente.Clear()
        txt_nombre_cliente.Clear()
        limpiardetalles()
    End Sub

    Sub limpiardetalles()
        'LIMPIA DETALLE DE LA ORDEN
        txt_cantidad1_detalle1.Clear()
        txt_cantidad2_detalle2.Clear()
        txt_cantidad3_detalle3.Clear()
        cboPiezas1_Detalle1.SelectedIndex = -1
        cboPiezas2_Detalle2.SelectedIndex = -1
        cboPiezas3_Detalle3.SelectedIndex = -1
        txtTamaño1_Detalle1.Clear()
        txtTamaño2_Detalle2.Clear()
        txtTamaño3_Detalle3.Clear()
        cboTipoImpresion1_Detalle1.SelectedIndex = -1
        cboTipoImpresion2_Detalle2.SelectedIndex = -1
        cboTipoImpresion3_Detalle3.SelectedIndex = -1
        txt_Papel1_Soporte1.Clear()
        txt_Papel2_Soporte1.Clear()
        txt_Papel3_Soporte1.Clear()
        txt_Papel1_Soporte2.Clear()
        txt_Papel2_Soporte2.Clear()
        txt_Papel3_Soporte2.Clear()
        txt_Papel1_Soporte3.Clear()
        txt_Papel2_Soporte3.Clear()
        txt_Papel3_Soporte3.Clear()
        txt_Gramaje1_Soporte1.Clear()
        txt_Gramaje2_Soporte1.Clear()
        txt_Gramaje3_Soporte1.Clear()
        txt_Gramaje1_Soporte2.Clear()
        txt_Gramaje2_Soporte2.Clear()
        txt_Gramaje3_Soporte2.Clear()
        txt_Gramaje1_Soporte3.Clear()
        txt_Gramaje2_Soporte3.Clear()
        txt_Gramaje3_Soporte3.Clear()
        txt_Cantidad1_Soporte1.Clear()
        txt_Cantidad2_Soporte1.Clear()
        txt_Cantidad3_Soporte1.Clear()
        txt_Cantidad1_Soporte2.Clear()
        txt_Cantidad2_Soporte2.Clear()
        txt_Cantidad3_Soporte2.Clear()
        txt_Cantidad1_Soporte3.Clear()
        txt_Cantidad2_Soporte3.Clear()
        txt_Cantidad3_Soporte3.Clear()
        cboFormato1_Soporte1.SelectedIndex = -1
        cboFormato2_Soporte1.SelectedIndex = -1
        cboFormato3_Soporte1.SelectedIndex = -1
        cboFormato1_Soporte2.SelectedIndex = -1
        cboFormato2_Soporte2.SelectedIndex = -1
        cboFormato3_Soporte2.SelectedIndex = -1
        cboFormato1_Soporte3.SelectedIndex = -1
        cboFormato2_Soporte3.SelectedIndex = -1
        cboFormato3_Soporte3.SelectedIndex = -1
    End Sub

    Private Sub btnBuscar_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_cliente.Click
        frm_Cliente.quienllamocliente = Me
        frm_Cliente.Text = "Seleccionar Cliente"
        frm_Cliente.btnEliminar_Cliente.Enabled = False
        frm_Cliente.GroupNuevoCliente.Enabled = False
        frm_Cliente.Show()
    End Sub

    Private Sub btnBuscar_Vendedor_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Vendedor.Click
        frm_Vendedor.quienllamovendedor = Me
        frm_Vendedor.Text = "Seleccionar Vendedor"
        frm_Vendedor.btnEliminar_vendedor.Enabled = False
        frm_Vendedor.GroupNuevoVendedor.Enabled = False
        frm_Vendedor.Show()
    End Sub

    Private Sub txt_cantidad1_detalle1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad2_detalle2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad3_detalle3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Cantidad1_Soporte1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Cantidad2_Soporte1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Cantidad3_Soporte1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Cantidad1_Soporte2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Cantidad2_Soporte2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Cantidad3_Soporte2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Cantidad1_Soporte3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Cantidad2_Soporte3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Cantidad3_Soporte3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancelar_Orden_Trabajo_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnProceso2.Click
        frm_Proceso2.txt_id_detalle_orden.Visible = False
        If Me.Text = "Ver Orden" Then

            If txt_id_detalle_orden_trabajo2.Text <> "" Then
                Dim TraerProcesos2 = (From c In datacontext.PROCESO
                                     Select c.PROC_descrip_digital,
                                     c.PROC_descrip_gran_formato,
                                     c.PROC_descrip_logistica,
                                     c.PROC_descrip_offset,
                                     c.PROC_descrip_terminacion,
                                     c.id_detalle_orden_trabajo
                Where CInt(id_detalle_orden_trabajo) = CInt(txt_id_detalle_orden_trabajo2.Text)).ToList()(0)


                frm_Proceso2.txt_descripc_digital.Text = TraerProcesos2.PROC_descrip_digital
                frm_Proceso2.txt_descripc_gran_formato.Text = TraerProcesos2.PROC_descrip_gran_formato
                frm_Proceso2.txt_descripc_logistica.Text = TraerProcesos2.PROC_descrip_logistica
                frm_Proceso2.txt_descripc_offset.Text = TraerProcesos2.PROC_descrip_offset
                frm_Proceso2.txt_descripc_terminacion.Text = TraerProcesos2.PROC_descrip_terminacion

                frm_Proceso2.txt_descripc_digital.Enabled = False
                frm_Proceso2.txt_descripc_gran_formato.Enabled = False
                frm_Proceso2.txt_descripc_logistica.Enabled = False
                frm_Proceso2.txt_descripc_offset.Enabled = False
                frm_Proceso2.txt_descripc_terminacion.Enabled = False
                frm_Proceso2.btnAceptar.Enabled = False
                frm_Proceso2.ShowDialog()
            Else
                MsgBox("No se ha cargado ningún registro")
            End If

        ElseIf Me.Text = "Modificar Orden" Then
            If txt_id_detalle_orden_trabajo2.Text <> "" Then
                Dim TraerProcesos = (From c In datacontext.PROCESO
                                                Select c.PROC_descrip_digital,
                                                c.PROC_descrip_gran_formato,
                                                c.PROC_descrip_logistica,
                                                c.PROC_descrip_offset,
                                                c.PROC_descrip_terminacion,
                                                c.id_detalle_orden_trabajo
                           Where CInt(id_detalle_orden_trabajo) = CInt(txt_id_detalle_orden_trabajo2.Text)).ToList()(0)

                frm_Proceso2.txt_descripc_digital.Text = TraerProcesos.PROC_descrip_digital
                frm_Proceso2.txt_descripc_gran_formato.Text = TraerProcesos.PROC_descrip_gran_formato
                frm_Proceso2.txt_descripc_logistica.Text = TraerProcesos.PROC_descrip_logistica
                frm_Proceso2.txt_descripc_offset.Text = TraerProcesos.PROC_descrip_offset
                frm_Proceso2.txt_descripc_terminacion.Text = TraerProcesos.PROC_descrip_terminacion

                frm_Proceso2.txt_descripc_digital.Enabled = True
                frm_Proceso2.txt_descripc_gran_formato.Enabled = True
                frm_Proceso2.txt_descripc_logistica.Enabled = True
                frm_Proceso2.txt_descripc_offset.Enabled = True
                frm_Proceso2.txt_descripc_terminacion.Enabled = True
                frm_Proceso2.btnAceptar.Enabled = True
                frm_Proceso2.ShowDialog()
            Else
                MsgBox("No se ha cargado ningún producto")
            End If
        Else
            frm_Proceso2.Text = "Proceso Segundo Producto"
            frm_Proceso2.ShowDialog()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnProceso3.Click
        frm_proceso3.txt_id_detalle_orden.Visible = False
        If Me.Text = "Ver Orden" Then

            If txt_id_detalle_orden_trabajo3.Text <> "" Then
                Dim TraerProcesos = (From c In datacontext.PROCESO
                                     Select c.PROC_descrip_digital,
                                     c.PROC_descrip_gran_formato,
                                     c.PROC_descrip_logistica,
                                     c.PROC_descrip_offset,
                                     c.PROC_descrip_terminacion,
                                     c.id_detalle_orden_trabajo
                Where CInt(id_detalle_orden_trabajo) = CInt(txt_id_detalle_orden_trabajo3.Text)).ToList()(0)

                frm_proceso3.txt_descripc_digital.Text = TraerProcesos.PROC_descrip_digital
                frm_proceso3.txt_descripc_gran_formato.Text = TraerProcesos.PROC_descrip_gran_formato
                frm_proceso3.txt_descripc_logistica.Text = TraerProcesos.PROC_descrip_logistica
                frm_proceso3.txt_descripc_offset.Text = TraerProcesos.PROC_descrip_offset
                frm_proceso3.txt_descripc_terminacion.Text = TraerProcesos.PROC_descrip_terminacion

                frm_proceso3.txt_descripc_digital.Enabled = False
                frm_proceso3.txt_descripc_gran_formato.Enabled = False
                frm_proceso3.txt_descripc_logistica.Enabled = False
                frm_proceso3.txt_descripc_offset.Enabled = False
                frm_proceso3.txt_descripc_terminacion.Enabled = False
                frm_proceso3.btnAceptar.Enabled = False
                frm_proceso3.ShowDialog()

            Else
                MsgBox("No se ha cargado ningún registro")
            End If

        ElseIf Me.Text = "Modificar Orden" Then

            If txt_id_detalle_orden_trabajo3.Text <> "" Then
                Dim TraerProcesos = (From c In datacontext.PROCESO
                                                Select c.PROC_descrip_digital,
                                                c.PROC_descrip_gran_formato,
                                                c.PROC_descrip_logistica,
                                                c.PROC_descrip_offset,
                                                c.PROC_descrip_terminacion,
                                                c.id_detalle_orden_trabajo
                           Where CInt(id_detalle_orden_trabajo) = CInt(txt_id_detalle_orden_trabajo3.Text)).ToList()(0)

                frm_proceso3.txt_descripc_digital.Text = TraerProcesos.PROC_descrip_digital
                frm_proceso3.txt_descripc_gran_formato.Text = TraerProcesos.PROC_descrip_gran_formato
                frm_proceso3.txt_descripc_logistica.Text = TraerProcesos.PROC_descrip_logistica
                frm_proceso3.txt_descripc_offset.Text = TraerProcesos.PROC_descrip_offset
                frm_proceso3.txt_descripc_terminacion.Text = TraerProcesos.PROC_descrip_terminacion

                frm_proceso3.txt_descripc_digital.Enabled = True
                frm_proceso3.txt_descripc_gran_formato.Enabled = True
                frm_proceso3.txt_descripc_logistica.Enabled = True
                frm_proceso3.txt_descripc_offset.Enabled = True
                frm_proceso3.txt_descripc_terminacion.Enabled = True
                frm_proceso3.btnAceptar.Enabled = True
                frm_proceso3.ShowDialog()
            Else
                MsgBox("No se ha cargado ningún producto")
            End If
        Else
            frm_proceso3.Text = "Proceso Tercer Producto"
            frm_proceso3.ShowDialog()
        End If
    End Sub

    Private Sub btnNueva_Orden_Trabajo_Click_2(sender As System.Object, e As System.EventArgs) Handles btnNueva_Orden_Trabajo.Click
        Select Case MsgBox("Se limpiarán todos los campos, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Limpiar campos")
            Case MsgBoxResult.Yes
                limpiarcontroles()
        End Select
    End Sub

    Private Sub btnCancelar_Orden_Trabajo_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar_Orden_Trabajo.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnImprimir_Click_1(sender As System.Object, e As System.EventArgs) Handles btnImprimirFormulario.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        ' PrintForm1.PrinterSettings.DefaultPageSettings.PaperSize.PaperName = "A4"

        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 65
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 0
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 60
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0

        btnNueva_Orden_Trabajo.Visible = False
        btnImprimirFormulario.Visible = False
        btnGuardar_Orden_Trabajo.Visible = False
        btnActualizar_Orden_Trabajo.Visible = False
        btnCancelar_Orden_Trabajo.Visible = False
        Label17.Visible = False
        PrintForm1.Print()
    End Sub

    Private Sub btnGuardar_Orden_Trabajo_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar_Orden_Trabajo.Click

        'VALIDA QUE EL TIPO DE ORDEN NO ESTE VACIO
        If cboTipo_Orden.Text.Length = 0 Then
            MsgBox("Complete el campo Tipo de Orden")
            cboTipo_Orden.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL NUMERO DE ORDEN NO ESTE VACIO
        If txtNumero_Orden_Trabajo.Text.Length = 0 Then
            MsgBox("Complete el campo Número de Orden")
            txtNumero_Orden_Trabajo.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO VENDEDOR NO ESTE VACIO
        If txtNombre_vendedor.Text.Length = 0 Then
            MsgBox("Cargue el nombre Vendedor")
            btnBuscar_Vendedor.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO CLIENTE NO ESTE VACIO
        If txt_nombre_cliente.Text.Length = 0 Then
            MsgBox("Cargue el nombre Cliente")
            btnBuscar_cliente.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DIRECCION DE ENTREGA NO ESTE VACIO
        If txt_mejoras.Text.Length = 0 Then
            MsgBox("Cargue la Dirección de Entrega")
            txt_mejoras.Focus()
            Exit Sub
        End If

        'VALIDA QUE LA FECHA DE ENTREGA SEA CORRECTA
        If dtpFecha_Entrega.Value < Today Then
            MsgBox("Verifique la Fecha de Entrega")
            Exit Sub
        End If

        Dim buscaorden = (From odt In datacontext.ORDEN_TRABAJO
                      Select odt.ORT_fecha_ot, odt.ORT_tipo_ot, odt.ORT_numero_ot, odt.ORT_observaciones_ot, odt.VEN_id_vendedor, odt.CLI_id_cliente, odt.ORT_fecha_entrega
                      Where ORT_numero_ot = txtNumero_Orden_Trabajo.Text.ToUpper).Any

        If cargamasprod = "NO" Then
            If buscaorden = True Then
                MsgBox("La Orden ingresada ya existe")
                limpiarcontroles()
                Exit Sub
            End If
        End If
        'GUARDA ORDEN DE TRABAJO
        Try
            Dim clie = New ORDEN_TRABAJO
            If cargamasprod = "NO" Then

                clie.ORT_fecha_ot = dtpFecha_Orden_Trabajo.Text
                clie.ORT_tipo_ot = cboTipo_Orden.Text
                clie.ORT_numero_ot = StrConv(txtNumero_Orden_Trabajo.Text, VbStrConv.ProperCase)
                clie.ORT_observaciones_ot = StrConv(txt_observaciones.Text, VbStrConv.ProperCase)
                clie.ORT_mejoras_ot = StrConv(txt_mejoras.Text, VbStrConv.ProperCase)
                clie.VEN_id_vendedor = txtid_vendedor.Text
                clie.CLI_id_cliente = txt_id_cliente.Text
                clie.ORT_fecha_entrega = dtpFecha_Entrega.Text

                datacontext.ORDEN_TRABAJO.InsertOnSubmit(clie)
                datacontext.SubmitChanges()
            End If

            'GUARDA EL REGISTRO 1 DEL DETALLE DE LA ORDEN DE TRABAJO
            If txt_cantidad1_detalle1.Text.Length >= 1 Then
                If cboPiezas1_Detalle1.Text.Length = 0 Then
                    MsgBox("Seleccione una pieza")
                End If

                Dim detalle = New DETALLE_ORDEN_TRABAJO
                'id
                txt_id_detalle_orden_trabajo1.Text = detalle.id_detalle_orden_trabajo
                detalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text

                detalle.DOT_cantidad_producto = txt_cantidad1_detalle1.Text  'CANTIDAD PRODUCTO 1
                detalle.DOT_tamaño_producto = StrConv(txtTamaño1_Detalle1.Text, VbStrConv.ProperCase) 'TAMAÑO PRODUCTO 1
                detalle.DOT_tipo_impresion_dot = cboTipoImpresion1_Detalle1.SelectedItem 'TIPO IMPRESION PRODUCTO 1
                detalle.PIE_id_pieza = cboPiezas1_Detalle1.SelectedValue 'TIPO PIEZA PRODUCTO 1

                If cargamasprod = "NO" Then
                    txt_id_orden_trabajo.Text = clie.ORT_id_orden_trabajo
                End If
                detalle.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text 'ID ORDEN TRABAJO

                'PAPEL PRODUCTO 1
                detalle.DOT_papel_soporte_1 = StrConv(txt_Papel1_Soporte1.Text, VbStrConv.ProperCase)
                detalle.DOT_papel_soporte_2 = StrConv(txt_Papel2_Soporte1.Text, VbStrConv.ProperCase)
                detalle.DOT_papel_soporte_3 = StrConv(txt_Papel3_Soporte1.Text, VbStrConv.ProperCase)

                'GRAMAJE PRODUCTO 1
                detalle.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte1.Text
                detalle.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte1.Text
                detalle.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte1.Text

                'CANTIDAD PRODUCTO 1
                If txt_Cantidad1_Soporte1.TextLength <> 0 Then
                    detalle.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte1.Text
                End If
                If txt_Cantidad2_Soporte1.TextLength <> 0 Then
                    detalle.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte1.Text
                End If
                If txt_Cantidad3_Soporte1.TextLength <> 0 Then
                    detalle.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte1.Text
                End If
                'FORMATO PRODUCTO 1
                detalle.DOT_formato_soporte_1 = cboFormato1_Soporte1.SelectedItem
                detalle.DOT_formato_soporte_2 = cboFormato2_Soporte1.SelectedItem
                detalle.DOT_formato_soporte_3 = cboFormato3_Soporte1.SelectedItem

                datacontext.DETALLE_ORDEN_TRABAJO.InsertOnSubmit(detalle)
                datacontext.SubmitChanges()

                '-----------------------------------------------------------------------

                'GUARDA TABLA PROCESO PRODUCTO 1
                Dim proceso = New PROCESO

                txt_id_detalle_orden_trabajo1.Text = detalle.id_detalle_orden_trabajo
                proceso.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text

                If frm_Proceso1.txt_descripc_offset.TextLength <> 0 Then
                    proceso.PROC_descrip_offset = StrConv(frm_Proceso1.txt_descripc_offset.Text, VbStrConv.ProperCase)
                End If

                If frm_Proceso1.txt_descripc_digital.TextLength <> 0 Then
                    proceso.PROC_descrip_digital = StrConv(frm_Proceso1.txt_descripc_digital.Text, VbStrConv.ProperCase)
                End If

                If frm_Proceso1.txt_descripc_gran_formato.TextLength <> 0 Then
                    proceso.PROC_descrip_gran_formato = StrConv(frm_Proceso1.txt_descripc_gran_formato.Text, VbStrConv.ProperCase)
                End If

                If frm_Proceso1.txt_descripc_terminacion.TextLength <> 0 Then
                    proceso.PROC_descrip_terminacion = StrConv(frm_Proceso1.txt_descripc_terminacion.Text, VbStrConv.ProperCase)
                End If

                If frm_Proceso1.txt_descripc_logistica.TextLength <> 0 Then
                    proceso.PROC_descrip_logistica = StrConv(frm_Proceso1.txt_descripc_logistica.Text, VbStrConv.ProperCase)
                End If

                datacontext.PROCESO.InsertOnSubmit(proceso)
                datacontext.SubmitChanges()

            End If

            'GUARDA EL REGISTRO 2 DEL DETALLE DE LA ORDEN DE TRABAJO
            If txt_cantidad2_detalle2.Text.Length >= 1 Then
                If cboPiezas2_Detalle2.Text.Length = 0 Then
                    MsgBox("Seleccione una Pieza")
                End If
                Dim detalle2 = New DETALLE_ORDEN_TRABAJO
                'id
                txt_id_detalle_orden_trabajo2.Text = detalle2.id_detalle_orden_trabajo
                detalle2.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo2.Text
                'CANTIDAD REGISTRO 2
                detalle2.DOT_cantidad_producto = txt_cantidad2_detalle2.Text
                'TAMAÑO REGISTRO 1
                detalle2.DOT_tamaño_producto = txtTamaño2_Detalle2.Text
                'TIPO IMPRESION REGISTRO 2
                detalle2.DOT_tipo_impresion_dot = cboTipoImpresion2_Detalle2.SelectedItem
                'TIPO PIEZA REGISTRO 2
                detalle2.PIE_id_pieza = cboPiezas2_Detalle2.SelectedValue

                'ID ORDEN TRABAJO
                If cargamasprod = "NO" Then
                    txt_id_orden_trabajo.Text = clie.ORT_id_orden_trabajo
                End If
                detalle2.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text

                'PAPEL REGISTRO 2
                detalle2.DOT_papel_soporte_1 = StrConv(txt_Papel1_Soporte2.Text, VbStrConv.ProperCase)
                detalle2.DOT_papel_soporte_2 = StrConv(txt_Papel2_Soporte2.Text, VbStrConv.ProperCase)
                detalle2.DOT_papel_soporte_3 = StrConv(txt_Papel3_Soporte2.Text, VbStrConv.ProperCase)

                'GRAMAJE REGISTRO 2
                detalle2.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte2.Text
                detalle2.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte2.Text
                detalle2.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte2.Text

                'CANTIDAD REGISTRO 2
                If txt_Cantidad1_Soporte2.TextLength <> 0 Then
                    detalle2.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte2.Text
                End If

                If txt_Cantidad2_Soporte2.TextLength <> 0 Then
                    detalle2.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte2.Text
                End If

                If txt_Cantidad3_Soporte2.TextLength <> 0 Then
                    detalle2.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte2.Text
                End If

                'FORMATO REGISTRO 2
                detalle2.DOT_formato_soporte_1 = cboFormato1_Soporte2.SelectedItem
                detalle2.DOT_formato_soporte_2 = cboFormato2_Soporte2.SelectedItem
                detalle2.DOT_formato_soporte_3 = cboFormato3_Soporte2.SelectedItem

                datacontext.DETALLE_ORDEN_TRABAJO.InsertOnSubmit(detalle2)
                datacontext.SubmitChanges()

                'GUARDA TABLA PROCESO PRODUCTO 2
                Dim proceso = New PROCESO
                txt_id_detalle_orden_trabajo2.Text = detalle2.id_detalle_orden_trabajo
                proceso.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo2.Text

                If frm_Proceso2.txt_descripc_offset.TextLength <> 0 Then
                    proceso.PROC_descrip_offset = StrConv(frm_Proceso2.txt_descripc_offset.Text, VbStrConv.ProperCase)
                End If

                If frm_Proceso2.txt_descripc_digital.TextLength <> 0 Then
                    proceso.PROC_descrip_digital = StrConv(frm_Proceso2.txt_descripc_digital.Text, VbStrConv.ProperCase)
                End If

                If frm_Proceso2.txt_descripc_gran_formato.TextLength <> 0 Then
                    proceso.PROC_descrip_gran_formato = StrConv(frm_Proceso2.txt_descripc_gran_formato.Text, VbStrConv.ProperCase)
                End If

                If frm_Proceso2.txt_descripc_terminacion.TextLength <> 0 Then
                    proceso.PROC_descrip_terminacion = StrConv(frm_Proceso2.txt_descripc_terminacion.Text, VbStrConv.ProperCase)
                End If

                If frm_Proceso2.txt_descripc_logistica.TextLength <> 0 Then
                    proceso.PROC_descrip_logistica = StrConv(frm_Proceso2.txt_descripc_logistica.Text, VbStrConv.ProperCase)
                End If

                datacontext.PROCESO.InsertOnSubmit(proceso)
                datacontext.SubmitChanges()
            End If

            'GUARDA EL REGISTRO 3 DEL DETALLE DE LA ORDEN DE TRABAJO
            If txt_cantidad3_detalle3.Text.Length >= 1 Then
                If cboPiezas3_Detalle3.Text.Length = 0 Then
                    MsgBox("Seleccione una Pieza")
                End If
                Dim detalle3 = New DETALLE_ORDEN_TRABAJO
                'id
                txt_id_detalle_orden_trabajo3.Text = detalle3.id_detalle_orden_trabajo
                detalle3.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo3.Text
                'CANTIDAD REGISTRO 3
                detalle3.DOT_cantidad_producto = txt_cantidad3_detalle3.Text
                'TAMAÑO REGISTRO 3
                detalle3.DOT_tamaño_producto = txtTamaño3_Detalle3.Text
                'TIPO IMPRESION REGISTRO 3
                detalle3.DOT_tipo_impresion_dot = cboTipoImpresion3_Detalle3.SelectedItem
                'TIPO PIEZA REGISTRO 3
                detalle3.PIE_id_pieza = cboPiezas3_Detalle3.SelectedValue

                'ID ORDEN TRABAJO
                If cargamasprod = "NO" Then
                    txt_id_orden_trabajo.Text = clie.ORT_id_orden_trabajo
                End If
                detalle3.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
                'PAPEL REGISTRO 3
                detalle3.DOT_papel_soporte_1 = StrConv(txt_Papel1_Soporte3.Text, VbStrConv.ProperCase)
                detalle3.DOT_papel_soporte_2 = StrConv(txt_Papel2_Soporte3.Text, VbStrConv.ProperCase)
                detalle3.DOT_papel_soporte_3 = StrConv(txt_Papel3_Soporte3.Text, VbStrConv.ProperCase)

                'GRAMAJE REGISTRO 3
                detalle3.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte3.Text
                detalle3.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte3.Text
                detalle3.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte3.Text

                'CANTIDAD REGISTRO 3
                If txt_Cantidad1_Soporte3.TextLength <> 0 Then
                    detalle3.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte3.Text
                End If
                If txt_Cantidad2_Soporte3.TextLength <> 0 Then
                    detalle3.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte3.Text
                End If
                If txt_Cantidad3_Soporte3.TextLength <> 0 Then
                    detalle3.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte3.Text
                End If
                'FORMATO REGISTRO 3
                detalle3.DOT_formato_soporte_1 = cboFormato1_Soporte3.SelectedItem
                detalle3.DOT_formato_soporte_2 = cboFormato2_Soporte3.SelectedItem
                detalle3.DOT_formato_soporte_3 = cboFormato3_Soporte3.SelectedItem

                datacontext.DETALLE_ORDEN_TRABAJO.InsertOnSubmit(detalle3)
                datacontext.SubmitChanges()

                'GUARDA TABLA PROCESO PRODUCTO 3
                Dim proceso = New PROCESO
                txt_id_detalle_orden_trabajo3.Text = detalle3.id_detalle_orden_trabajo
                proceso.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo3.Text

                If frm_proceso3.txt_descripc_offset.TextLength <> 0 Then
                    proceso.PROC_descrip_offset = StrConv(frm_proceso3.txt_descripc_offset.Text, VbStrConv.ProperCase)
                End If

                If frm_proceso3.txt_descripc_digital.TextLength <> 0 Then
                    proceso.PROC_descrip_digital = StrConv(frm_proceso3.txt_descripc_digital.Text, VbStrConv.ProperCase)
                End If

                If frm_proceso3.txt_descripc_gran_formato.TextLength <> 0 Then
                    proceso.PROC_descrip_gran_formato = StrConv(frm_proceso3.txt_descripc_gran_formato.Text, VbStrConv.ProperCase)
                End If

                If frm_proceso3.txt_descripc_terminacion.TextLength <> 0 Then
                    proceso.PROC_descrip_terminacion = StrConv(frm_proceso3.txt_descripc_terminacion.Text, VbStrConv.ProperCase)
                End If

                If frm_proceso3.txt_descripc_logistica.TextLength <> 0 Then
                    proceso.PROC_descrip_logistica = StrConv(frm_proceso3.txt_descripc_logistica.Text, VbStrConv.ProperCase)
                End If

                datacontext.PROCESO.InsertOnSubmit(proceso)
                datacontext.SubmitChanges()
            End If

            If txt_cantidad1_detalle1.Text.Length >= 1 And txt_cantidad2_detalle2.Text.Length >= 1 And txt_cantidad3_detalle3.Text.Length >= 1 Then
                Select Case MsgBox("La orden se ha creado, agregar mas productos?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar orden")
                    Case MsgBoxResult.Yes
                        cargamasprod = "SI"
                        limpiardetalles()
                        Exit Sub
                    Case Else

                        limpiarcontroles()
                        Me.Close()
                End Select
            Else
                MsgBox("la Orden se ha creado correctamente", vbInformation)
                limpiarcontroles()
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Error al cargar la Orden")
        End Try
    End Sub

    Private Sub btnActualizar_Orden_Trabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar_Orden_Trabajo.Click

        'VALIDA CAMPOS OBLIGATORIOS
        If txtNumero_Orden_Trabajo.Text.Length = 0 _
                Or cboTipo_Orden.Text.Length = 0 _
                Or txtid_vendedor.Text.Length = 0 _
                Or txt_id_cliente.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            'ACTUALIZA LA ORDEN DE TRABAJO
            Dim ActualizarOrden = (From P In datacontext.ORDEN_TRABAJO Where P.ORT_id_orden_trabajo = (txt_id_orden_trabajo.Text.ToUpper)).ToList()(0)
            ActualizarOrden.ORT_fecha_ot = dtpFecha_Orden_Trabajo.Text
            ActualizarOrden.ORT_tipo_ot = cboTipo_Orden.SelectedItem
            ActualizarOrden.ORT_numero_ot = txtNumero_Orden_Trabajo.Text
            ActualizarOrden.ORT_observaciones_ot = txt_observaciones.Text
            ActualizarOrden.ORT_mejoras_ot = txt_mejoras.Text
            ActualizarOrden.VEN_id_vendedor = txtid_vendedor.Text
            ActualizarOrden.CLI_id_cliente = txt_id_cliente.Text
            ActualizarOrden.ORT_fecha_entrega = dtpFecha_Entrega.Text
            datacontext.SubmitChanges()

            Dim ActualizarDetalle1 = (From D In datacontext.DETALLE_ORDEN_TRABAJO
                                     Where D.id_detalle_orden_trabajo = CInt(txt_id_detalle_orden_trabajo1.Text)).ToList()(0)

            'ACTUALIZA EL PRIMER REGISTRO
            If txt_cantidad1_detalle1.Text.Length >= 1 Then

                If cboPiezas1_Detalle1.Text.Length = 0 Then
                    MsgBox("Seleccione una pieza")
                    Exit Sub
                End If
                txt_id_detalle_orden_trabajo1.Text = ActualizarDetalle1.id_detalle_orden_trabajo
                ActualizarDetalle1.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text
                ActualizarDetalle1.DOT_cantidad_producto = txt_cantidad1_detalle1.Text
                ActualizarDetalle1.PIE_id_pieza = cboPiezas1_Detalle1.SelectedValue
                ActualizarDetalle1.DOT_tamaño_producto = txtTamaño1_Detalle1.Text
                ActualizarDetalle1.DOT_tipo_impresion_dot = cboTipoImpresion1_Detalle1.Text

                ActualizarDetalle1.DOT_papel_soporte_1 = StrConv(txt_Papel1_Soporte1.Text, VbStrConv.ProperCase)
                ActualizarDetalle1.DOT_papel_soporte_2 = StrConv(txt_Papel2_Soporte1.Text, VbStrConv.ProperCase)
                ActualizarDetalle1.DOT_papel_soporte_3 = StrConv(txt_Papel3_Soporte1.Text, VbStrConv.ProperCase)

                ActualizarDetalle1.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte1.Text
                ActualizarDetalle1.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte1.Text
                ActualizarDetalle1.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte1.Text

                If txt_Cantidad1_Soporte1.TextLength <> 0 Then
                    ActualizarDetalle1.DOT_cantidad_soporte_1 = CInt(txt_Cantidad1_Soporte1.Text)
                End If
                If txt_Cantidad2_Soporte1.TextLength <> 0 Then
                    ActualizarDetalle1.DOT_cantidad_soporte_2 = CInt(txt_Cantidad2_Soporte1.Text)
                End If
                If txt_Cantidad3_Soporte1.TextLength <> 0 Then
                    ActualizarDetalle1.DOT_cantidad_soporte_3 = CInt(txt_Cantidad3_Soporte1.Text)
                End If

                ActualizarDetalle1.DOT_formato_soporte_1 = cboFormato1_Soporte1.SelectedItem
                ActualizarDetalle1.DOT_formato_soporte_2 = cboFormato2_Soporte1.SelectedItem
                ActualizarDetalle1.DOT_formato_soporte_3 = cboFormato3_Soporte1.SelectedItem

                datacontext.SubmitChanges()

                Dim ActualizarProceso = (From p In datacontext.PROCESO
                                       Where p.id_detalle_orden_trabajo = CInt(txt_id_detalle_orden_trabajo1.Text)).ToList()(0)
                txt_id_detalle_orden_trabajo1.Text = ActualizarDetalle1.id_detalle_orden_trabajo
                ActualizarProceso.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text
                ActualizarProceso.PROC_descrip_digital = StrConv(frm_Proceso1.txt_descripc_digital.Text, VbStrConv.ProperCase)
                ActualizarProceso.PROC_descrip_gran_formato = StrConv(frm_Proceso1.txt_descripc_gran_formato.Text, VbStrConv.ProperCase)
                ActualizarProceso.PROC_descrip_logistica = StrConv(frm_Proceso1.txt_descripc_logistica.Text, VbStrConv.ProperCase)
                ActualizarProceso.PROC_descrip_offset = StrConv(frm_Proceso1.txt_descripc_offset.Text, VbStrConv.ProperCase)
                ActualizarProceso.PROC_descrip_terminacion = StrConv(frm_Proceso1.txt_descripc_terminacion.Text, VbStrConv.ProperCase)

                ActualizarProceso.PROC_digital = StrConv(frm_Proceso1.groupDigital.Text, VbStrConv.ProperCase)
                ActualizarProceso.PROC_gran_formato = StrConv(frm_Proceso1.groupGranFormato.Text, VbStrConv.ProperCase)
                ActualizarProceso.PROC_logistica = StrConv(frm_Proceso1.groupLogistica.Text, VbStrConv.ProperCase)
                ActualizarProceso.PROC_offset = StrConv(frm_Proceso1.groupOffSet.Text, VbStrConv.ProperCase)
                ActualizarProceso.PROC_terminacion = StrConv(frm_Proceso1.groupTerminacion.Text, VbStrConv.ProperCase)

                datacontext.SubmitChanges()
            End If

            'ACTUALIZA EL SEGUNDO REGISTRO
            If txt_id_detalle_orden_trabajo2.Text.Length <> 0 Then
                Dim ActualizarDetalle2 = (From D In datacontext.DETALLE_ORDEN_TRABAJO
                                          Where D.id_detalle_orden_trabajo = CInt(txt_id_detalle_orden_trabajo2.Text)).ToList()(0)
                If txt_cantidad2_detalle2.Text.Length >= 1 Then

                    If cboPiezas2_Detalle2.Text.Length = 0 Then
                        MsgBox("Seleccione una Pieza")
                        Exit Sub
                    End If
                    txt_id_detalle_orden_trabajo2.Text = ActualizarDetalle2.id_detalle_orden_trabajo
                    ActualizarDetalle2.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo2.Text
                    ActualizarDetalle2.DOT_cantidad_producto = txt_cantidad2_detalle2.Text
                    ActualizarDetalle2.PIE_id_pieza = cboPiezas2_Detalle2.SelectedValue
                    ActualizarDetalle2.DOT_tamaño_producto = txtTamaño2_Detalle2.Text
                    ActualizarDetalle2.DOT_tipo_impresion_dot = cboTipoImpresion2_Detalle2.Text

                    ActualizarDetalle2.DOT_papel_soporte_1 = StrConv(txt_Papel1_Soporte2.Text, VbStrConv.ProperCase)
                    ActualizarDetalle2.DOT_papel_soporte_2 = StrConv(txt_Papel2_Soporte2.Text, VbStrConv.ProperCase)
                    ActualizarDetalle2.DOT_papel_soporte_3 = StrConv(txt_Papel3_Soporte2.Text, VbStrConv.ProperCase)

                    ActualizarDetalle2.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte2.Text
                    ActualizarDetalle2.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte2.Text
                    ActualizarDetalle2.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte2.Text

                    If txt_Cantidad1_Soporte2.TextLength <> 0 Then
                        ActualizarDetalle2.DOT_cantidad_soporte_1 = CInt(txt_Cantidad1_Soporte2.Text)
                    End If
                    If txt_Cantidad2_Soporte2.TextLength <> 0 Then
                        ActualizarDetalle2.DOT_cantidad_soporte_2 = CInt(txt_Cantidad2_Soporte2.Text)
                    End If
                    If txt_Cantidad3_Soporte2.TextLength <> 0 Then
                        ActualizarDetalle2.DOT_cantidad_soporte_3 = CInt(txt_Cantidad3_Soporte2.Text)
                    End If

                    ActualizarDetalle2.DOT_formato_soporte_1 = cboFormato1_Soporte2.SelectedItem
                    ActualizarDetalle2.DOT_formato_soporte_2 = cboFormato2_Soporte2.SelectedItem
                    ActualizarDetalle2.DOT_formato_soporte_3 = cboFormato3_Soporte2.SelectedItem

                    datacontext.SubmitChanges()

                    Dim ActualizarProceso2 = (From p In datacontext.PROCESO
                                    Where p.id_detalle_orden_trabajo = CInt(txt_id_detalle_orden_trabajo2.Text)).ToList()(0)

                    txt_id_detalle_orden_trabajo2.Text = ActualizarDetalle2.id_detalle_orden_trabajo
                    ActualizarProceso2.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo2.Text
                    ActualizarProceso2.PROC_descrip_digital = StrConv(frm_Proceso2.txt_descripc_digital.Text, VbStrConv.ProperCase)
                    ActualizarProceso2.PROC_descrip_gran_formato = StrConv(frm_Proceso2.txt_descripc_gran_formato.Text, VbStrConv.ProperCase)
                    ActualizarProceso2.PROC_descrip_logistica = StrConv(frm_Proceso2.txt_descripc_logistica.Text, VbStrConv.ProperCase)
                    ActualizarProceso2.PROC_descrip_offset = StrConv(frm_Proceso2.txt_descripc_offset.Text, VbStrConv.ProperCase)
                    ActualizarProceso2.PROC_descrip_terminacion = StrConv(frm_Proceso2.txt_descripc_terminacion.Text, VbStrConv.ProperCase)

                    ActualizarProceso2.PROC_digital = StrConv(frm_Proceso2.groupDigital.Text, VbStrConv.ProperCase)
                    ActualizarProceso2.PROC_gran_formato = StrConv(frm_Proceso2.groupGranFormato.Text, VbStrConv.ProperCase)
                    ActualizarProceso2.PROC_logistica = StrConv(frm_Proceso2.groupLogistica.Text, VbStrConv.ProperCase)
                    ActualizarProceso2.PROC_offset = StrConv(frm_Proceso2.groupOffSet.Text, VbStrConv.ProperCase)
                    ActualizarProceso2.PROC_terminacion = StrConv(frm_Proceso2.groupTerminacion.Text, VbStrConv.ProperCase)

                    datacontext.SubmitChanges()
                End If
            Else
                'GUARDA EL REGISTRO 2 DEL DETALLE DE LA ORDEN DE TRABAJO
                If txt_cantidad2_detalle2.Text.Length >= 1 Then

                    If cboPiezas2_Detalle2.Text.Length = 0 Then
                        MsgBox("Seleccione una Pieza")
                        Exit Sub
                    End If
                    Dim detalle = New DETALLE_ORDEN_TRABAJO
                    'id
                    txt_id_detalle_orden_trabajo2.Text = detalle.id_detalle_orden_trabajo
                    detalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo2.Text
                    detalle.DOT_cantidad_producto = txt_cantidad2_detalle2.Text
                    detalle.DOT_tamaño_producto = txtTamaño2_Detalle2.Text
                    detalle.DOT_tipo_impresion_dot = cboTipoImpresion2_Detalle2.Text
                    detalle.PIE_id_pieza = cboPiezas2_Detalle2.SelectedValue
                    detalle.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text

                    detalle.DOT_papel_soporte_1 = StrConv(txt_Papel1_Soporte2.Text, VbStrConv.ProperCase)
                    detalle.DOT_papel_soporte_2 = StrConv(txt_Papel2_Soporte2.Text, VbStrConv.ProperCase)
                    detalle.DOT_papel_soporte_3 = StrConv(txt_Papel3_Soporte2.Text, VbStrConv.ProperCase)

                    detalle.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte2.Text
                    detalle.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte2.Text
                    detalle.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte2.Text

                    detalle.DOT_cantidad_soporte_1 = CInt(txt_Cantidad1_Soporte2.Text)
                    detalle.DOT_cantidad_soporte_2 = CInt(txt_Cantidad2_Soporte2.Text)
                    detalle.DOT_cantidad_soporte_3 = CInt(txt_Cantidad3_Soporte2.Text)

                    detalle.DOT_formato_soporte_1 = cboFormato1_Soporte2.SelectedItem
                    detalle.DOT_formato_soporte_2 = cboFormato2_Soporte2.SelectedItem
                    detalle.DOT_formato_soporte_3 = cboFormato3_Soporte2.SelectedItem

                    datacontext.DETALLE_ORDEN_TRABAJO.InsertOnSubmit(detalle)
                    datacontext.SubmitChanges()
                End If
            End If
            ''ACTUALIZA EL TERCER REGISTRO
            If txt_id_detalle_orden_trabajo3.Text.Length <> 0 Then

                If txt_cantidad3_detalle3.Text.Length >= 1 Then

                    Dim ActualizarDetalle3 = (From D In datacontext.DETALLE_ORDEN_TRABAJO Where D.id_detalle_orden_trabajo = CInt(txt_id_detalle_orden_trabajo3.Text)).ToList()(0)

                    If cboPiezas3_Detalle3.Text.Length = 0 Then
                        MsgBox("Seleccione una Pieza")
                        Exit Sub
                    End If

                    txt_id_detalle_orden_trabajo3.Text = ActualizarDetalle3.id_detalle_orden_trabajo
                    ActualizarDetalle3.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo3.Text
                    ActualizarDetalle3.DOT_cantidad_producto = txt_cantidad3_detalle3.Text
                    ActualizarDetalle3.PIE_id_pieza = cboPiezas3_Detalle3.SelectedValue
                    ActualizarDetalle3.DOT_tamaño_producto = txtTamaño3_Detalle3.Text
                    ActualizarDetalle3.DOT_tipo_impresion_dot = cboTipoImpresion3_Detalle3.Text

                    ActualizarDetalle3.DOT_papel_soporte_1 = StrConv(txt_Papel1_Soporte3.Text, VbStrConv.ProperCase)
                    ActualizarDetalle3.DOT_papel_soporte_2 = StrConv(txt_Papel2_Soporte3.Text, VbStrConv.ProperCase)
                    ActualizarDetalle3.DOT_papel_soporte_3 = StrConv(txt_Papel3_Soporte3.Text, VbStrConv.ProperCase)

                    ActualizarDetalle3.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte3.Text
                    ActualizarDetalle3.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte3.Text
                    ActualizarDetalle3.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte3.Text

                    If txt_Cantidad1_Soporte3.TextLength <> 0 Then
                        ActualizarDetalle3.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte3.Text
                    End If
                    If txt_Cantidad2_Soporte3.TextLength <> 0 Then
                        ActualizarDetalle3.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte3.Text
                    End If
                    If txt_Cantidad3_Soporte3.TextLength <> 0 Then
                        ActualizarDetalle3.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte3.Text
                    End If

                    ActualizarDetalle3.DOT_formato_soporte_1 = cboFormato1_Soporte3.SelectedItem
                    ActualizarDetalle3.DOT_formato_soporte_2 = cboFormato2_Soporte3.SelectedItem
                    ActualizarDetalle3.DOT_formato_soporte_3 = cboFormato3_Soporte3.SelectedItem

                    datacontext.SubmitChanges()

                    Dim ActualizarProceso3 = (From p In datacontext.PROCESO
                                 Where p.id_detalle_orden_trabajo = CInt(txt_id_detalle_orden_trabajo3.Text)).ToList()(0)

                    txt_id_detalle_orden_trabajo3.Text = ActualizarDetalle3.id_detalle_orden_trabajo
                    ActualizarProceso3.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo3.Text
                    ActualizarProceso3.PROC_descrip_digital = StrConv(frm_proceso3.txt_descripc_digital.Text, VbStrConv.ProperCase)
                    ActualizarProceso3.PROC_descrip_gran_formato = StrConv(frm_proceso3.txt_descripc_gran_formato.Text, VbStrConv.ProperCase)
                    ActualizarProceso3.PROC_descrip_logistica = StrConv(frm_proceso3.txt_descripc_logistica.Text, VbStrConv.ProperCase)
                    ActualizarProceso3.PROC_descrip_offset = StrConv(frm_proceso3.txt_descripc_offset.Text, VbStrConv.ProperCase)
                    ActualizarProceso3.PROC_descrip_terminacion = StrConv(frm_proceso3.txt_descripc_terminacion.Text, VbStrConv.ProperCase)

                    ActualizarProceso3.PROC_digital = StrConv(frm_proceso3.groupDigital.Text, VbStrConv.ProperCase)
                    ActualizarProceso3.PROC_gran_formato = StrConv(frm_proceso3.groupGranFormato.Text, VbStrConv.ProperCase)
                    ActualizarProceso3.PROC_logistica = StrConv(frm_proceso3.groupLogistica.Text, VbStrConv.ProperCase)
                    ActualizarProceso3.PROC_offset = StrConv(frm_proceso3.groupOffSet.Text, VbStrConv.ProperCase)
                    ActualizarProceso3.PROC_terminacion = StrConv(frm_proceso3.groupTerminacion.Text, VbStrConv.ProperCase)

                    datacontext.SubmitChanges()
                End If
            Else
                'GUARDA EL REGISTRO 3 DEL DETALLE DE LA ORDEN DE TRABAJO
                If txt_cantidad3_detalle3.Text.Length >= 1 Then

                    If cboPiezas3_Detalle3.Text.Length = 0 Then
                        MsgBox("Seleccione una Pieza")
                        Exit Sub
                    End If
                    Dim detalle = New DETALLE_ORDEN_TRABAJO
                    txt_id_detalle_orden_trabajo3.Text = detalle.id_detalle_orden_trabajo
                    detalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo3.Text
                    detalle.DOT_cantidad_producto = txt_cantidad3_detalle3.Text
                    detalle.DOT_tamaño_producto = txtTamaño3_Detalle3.Text
                    detalle.DOT_tipo_impresion_dot = cboTipoImpresion3_Detalle3.Text
                    detalle.PIE_id_pieza = cboPiezas3_Detalle3.SelectedValue
                    detalle.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
                    detalle.DOT_papel_soporte_1 = StrConv(txt_Papel1_Soporte3.Text, VbStrConv.ProperCase)
                    detalle.DOT_papel_soporte_2 = StrConv(txt_Papel2_Soporte3.Text, VbStrConv.ProperCase)
                    detalle.DOT_papel_soporte_3 = StrConv(txt_Papel3_Soporte3.Text, VbStrConv.ProperCase)
                    detalle.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte3.Text
                    detalle.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte3.Text
                    detalle.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte3.Text
                    detalle.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte3.Text
                    detalle.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte3.Text
                    detalle.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte3.Text
                    detalle.DOT_formato_soporte_1 = cboFormato1_Soporte3.SelectedItem
                    detalle.DOT_formato_soporte_2 = cboFormato2_Soporte3.SelectedItem
                    detalle.DOT_formato_soporte_3 = cboFormato3_Soporte3.SelectedItem

                    datacontext.DETALLE_ORDEN_TRABAJO.InsertOnSubmit(detalle)
                    datacontext.SubmitChanges()
                End If
            End If
            MsgBox("Los datos se han modificado correctamente")

            Me.Close()
            frm_Listado_Orden_Trabajo.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar orden")
            '  Me.limpiarcontroles()
        End Try
    End Sub

    Private Sub frm_Orden_Trabajo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnProceso1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceso1.Click
        frm_Proceso1.btnActualizar.Enabled = False
        frm_Proceso1.txt_id_proceso.Visible = False
        If Me.Text = "Ver Orden" Then
            Dim TraerProcesos = (From c In datacontext.PROCESO
                                 Select c.PROC_descrip_digital,
                                 c.PROC_descrip_gran_formato,
                                 c.PROC_descrip_logistica,
                                 c.PROC_descrip_offset,
                                 c.PROC_descrip_terminacion,
                                 c.id_detalle_orden_trabajo
            Where CInt(id_detalle_orden_trabajo) = CInt(txt_id_detalle_orden_trabajo1.Text)).ToList()(0)

            frm_Proceso1.txt_descripc_digital.Text = TraerProcesos.PROC_descrip_digital
            frm_Proceso1.txt_descripc_gran_formato.Text = TraerProcesos.PROC_descrip_gran_formato
            frm_Proceso1.txt_descripc_logistica.Text = TraerProcesos.PROC_descrip_logistica
            frm_Proceso1.txt_descripc_offset.Text = TraerProcesos.PROC_descrip_offset
            frm_Proceso1.txt_descripc_terminacion.Text = TraerProcesos.PROC_descrip_terminacion

            frm_Proceso1.txt_descripc_digital.Enabled = False
            frm_Proceso1.txt_descripc_gran_formato.Enabled = False
            frm_Proceso1.txt_descripc_logistica.Enabled = False
            frm_Proceso1.txt_descripc_offset.Enabled = False
            frm_Proceso1.txt_descripc_terminacion.Enabled = False
            frm_Proceso1.btnAceptar.Enabled = False
            frm_Proceso1.ShowDialog()

        ElseIf Me.Text = "Modificar Orden" Then
            Dim TraerProcesos = (From c In datacontext.PROCESO
                                            Select c.PROC_descrip_digital,
                                            c.PROC_descrip_gran_formato,
                                            c.PROC_descrip_logistica,
                                            c.PROC_descrip_offset,
                                            c.PROC_descrip_terminacion,
                                            c.id_detalle_orden_trabajo
                       Where CInt(id_detalle_orden_trabajo) = CInt(txt_id_detalle_orden_trabajo1.Text)).ToList()(0)

            frm_Proceso1.txt_descripc_digital.Text = TraerProcesos.PROC_descrip_digital
            frm_Proceso1.txt_descripc_gran_formato.Text = TraerProcesos.PROC_descrip_gran_formato
            frm_Proceso1.txt_descripc_logistica.Text = TraerProcesos.PROC_descrip_logistica
            frm_Proceso1.txt_descripc_offset.Text = TraerProcesos.PROC_descrip_offset
            frm_Proceso1.txt_descripc_terminacion.Text = TraerProcesos.PROC_descrip_terminacion

            frm_Proceso1.txt_descripc_digital.Enabled = True
            frm_Proceso1.txt_descripc_gran_formato.Enabled = True
            frm_Proceso1.txt_descripc_logistica.Enabled = True
            frm_Proceso1.txt_descripc_offset.Enabled = True
            frm_Proceso1.txt_descripc_terminacion.Enabled = True
            frm_Proceso1.btnAceptar.Enabled = True

            frm_Proceso1.ShowDialog()
        Else
            frm_Proceso1.Text = "Proceso Primer Producto"
            frm_Proceso1.ShowDialog()
        End If
    End Sub

End Class