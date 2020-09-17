Public Class frm_retrabajo
    Dim datacontext As New DataS_Interno

    Private Sub btnBuscar_Numero_Orden1_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden1.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden y Detalle"
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Producto.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub frm_retrabajo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnBuscar_Numero_Orden1.Focus()
        txtNumero_Orden_Trabajo.Enabled = False
        'txt_id_orden_trabajo.Visible = False
        cboPieza_Original.Enabled = False
        txtTamaño_Original.Enabled = False
        ' cboTipoImpresion.Enabled = False
        'txt_id_detalle_orden_trabajo1.Visible = False
        txt_Cantidad_Original.Enabled = False
        dtp_Fecha_Ingreso_Original.Enabled = False
        dtpFecha_Entrega_Original.Enabled = False
        Label45.Visible = False
        Label1.Visible = False
        'txt_id_re_trabajo.Visible = False
        'btnImprimir.Enabled = False

        'CARGA COMBO
        Dim combopieza1 = (From sec In datacontext.PIEZA
                             Select sec.PIE_id_pieza, sec.PIE_nombre_pie, sec.PIE_ubicacion
                             Where PIE_ubicacion = "D"
                             Order By PIE_nombre_pie Ascending)

        cboPieza_Original.DataSource = combopieza1
        cboPieza_Original.DisplayMember = "PIE_nombre_pie"
        cboPieza_Original.ValueMember = "PIE_id_pieza"
        cboPieza_Original.SelectedIndex = -1

        Try
            'ASIGNA PIEZA SEGUN LO QUE CONTIENE EL GRID
            cboPieza_Original.SelectedValue = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("PIE_id_pieza", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.CurrentRow.Index).Value
        Catch ex As Exception
        End Try

        'CARGA COMBOBOX PAPEL 1
        Dim combopapel1 = (From papelsop1 In datacontext.SOPORTE
                 Select papelsop1.SOP_id_soporte, papelsop1.SOP_nombre_soporte, papelsop1.SOP_ubicacion
                 Where SOP_ubicacion = "D"
                 Order By SOP_nombre_soporte Ascending)
        cboPapel1.DataSource = combopapel1
        cboPapel1.DisplayMember = "SOP_nombre_soporte"
        cboPapel1.ValueMember = "SOP_id_soporte"
        cboPapel1.SelectedIndex = -1

        Try
            'ASIGNA PIEZA SEGUN LO QUE CONTIENE EL GRID
            cboPapel1.SelectedValue = Me.dgvListado_ReTrabajo.Item("SOP_nombre_soporte", Me.dgvListado_ReTrabajo.CurrentRow.Index).Value
        Catch ex As Exception
        End Try

        'CARGA COMBOBOX PAPEL 2
        Dim combopapel2 = (From papelsop2 In datacontext.SOPORTE
                 Select papelsop2.SOP_id_soporte, papelsop2.SOP_nombre_soporte, papelsop2.SOP_ubicacion
                 Where SOP_ubicacion = "D"
                 Order By SOP_nombre_soporte Ascending)
        cboPapel2.DataSource = combopapel2
        cboPapel2.DisplayMember = "SOP_nombre_soporte"
        cboPapel2.ValueMember = "SOP_id_soporte"
        cboPapel2.SelectedIndex = -1

        Try
            'ASIGNA PIEZA SEGUN LO QUE CONTIENE EL GRID
            cboPapel2.SelectedValue = Me.dgvListado_ReTrabajo.Item("SOP_nombre_soporte", Me.dgvListado_ReTrabajo.CurrentRow.Index).Value
        Catch ex As Exception
        End Try
        'CARGA COMBOBOX PAPEL 3
        Dim combopapel3 = (From papelsop2 In datacontext.SOPORTE
                 Select papelsop2.SOP_id_soporte, papelsop2.SOP_nombre_soporte, papelsop2.SOP_ubicacion
                 Where SOP_ubicacion = "D"
                 Order By SOP_nombre_soporte Ascending)
        cboPapel3.DataSource = combopapel3
        cboPapel3.DisplayMember = "SOP_nombre_soporte"
        cboPapel3.ValueMember = "SOP_id_soporte"
        cboPapel3.SelectedIndex = -1

        Try
            'ASIGNA PIEZA SEGUN LO QUE CONTIENE EL GRID
            cboPapel3.SelectedValue = Me.dgvListado_ReTrabajo.Item("SOP_nombre_soporte", Me.dgvListado_ReTrabajo.CurrentRow.Index).Value
        Catch ex As Exception
        End Try

        ArmaGrillaRetrabajo()
        CargarGrillaRetrabajo()
    End Sub

    Private Sub btnCancelar_Orden_Trabajo_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Orden_Trabajo_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancelar_ReTrabajo.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_cantidad_retrabajo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad_Retrabajo.KeyPress
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

    Private Sub txt_Gramaje1_Soporte1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Gramaje2_Soporte1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Gramaje3_Soporte1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad1_Soporte1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad2_Soporte1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad3_Soporte1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirFormulario.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True

        'PrintForm1.PrinterSettings.DefaultPageSettings.PaperSize.PaperName = "A4"

        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 30
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 30
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 30
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 30

        btnImprimirFormulario.Visible = False
        btnGuardar_ReTrabajo.Visible = False
        btnCancelar_ReTrabajo.Visible = False
        Label17.Visible = False
        PrintForm1.Print() 'imprimir
    End Sub

    Private Sub frm_retrabajo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_ReTrabajo_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar_ReTrabajo.Click

        If txtNumero_Orden_Trabajo.Text.Length = 0 Then
            MsgBox("Debe seleccionar una Orden")
            btnBuscar_Numero_Orden1.Focus()
            Exit Sub
        End If

        If txt_Cantidad_Retrabajo.Text.Length = 0 Then
            MsgBox("Ingrese la nueva Cantidad")
            txt_Cantidad_Retrabajo.Focus()
            Exit Sub
        End If
        Try
            'GUARDA RETRABAJO
            Dim ret = New RE_TRABAJO

            ' GUARDA GroupReTrabajo
            If txt_Cantidad_Retrabajo.TextLength <> 0 Then
                ret.RET_cantidad_producto_retrabajo = txt_Cantidad_Retrabajo.Text
            End If
            ret.RET_origen_area_motivo = StrConv(txt_Origen_Causa.Text, VbStrConv.ProperCase)
            ret.RET_procedimiento_observaciones = StrConv(txt_Procedimiento.Text, VbStrConv.ProperCase)
            ret.RET_fecha_comienzo_retrabajo = StrConv(dtpFecha_Re_Trabajo.Text, VbStrConv.ProperCase)
            ret.RET_fecha_entrega_retrabajo = StrConv(dtp_Nueva_Fecha_Entrega.Text, VbStrConv.ProperCase)
            '-----------------------------------------------------------------------------------------------------------
            ret.id_detalle_orden_trabajo = txt_id_detalle.Text
            '-----------------------------------------------------------------------------------------------------------

            'PRODUCTO
            ret.RET_papel_soporte_1_retrabajo = cboPapel1.SelectedValue
            ret.RET_papel_soporte_2_retrabajo = cboPapel2.SelectedValue
            ret.RET_papel_soporte_3_retrabajo = cboPapel3.SelectedValue

            ret.RET_gramaje_soporte_1_retrabajo = cboGramaje1.SelectedItem
            ret.RET_gramaje_soporte_2_retrabajo = cboGramaje2.SelectedItem
            ret.RET_gramaje_soporte_3_retrabajo = cboGramaje3.SelectedItem
            '-----------------------------------------------------------------------

            'PLIEGO ENTERO DIGITAL/OFFSET
            If txt_Cantidad_1_PE_DigitalOffset.TextLength <> 0 Then
                ret.RET_cantidad_soporte_1_retrabajo = txt_Cantidad_1_PE_DigitalOffset.Text
            End If
            If txt_Cantidad_2_PE_DigitalOffset.TextLength <> 0 Then
                ret.RET_cantidad_soporte_2_retrabajo = txt_Cantidad_2_PE_DigitalOffset.Text
            End If
            If txt_Cantidad_3_PE_DigitalOffset.TextLength <> 0 Then
                ret.RET_cantidad_soporte_3_retrabajo = txt_Cantidad_3_PE_DigitalOffset.Text
            End If

            ret.RET_formato_soporte_1_retrabajo = cboFormato_1_PE_DigitalOffset.SelectedItem
            ret.RET_formato_soporte_2_retrabajo = cboFormato_2_PE_DigitalOffset.SelectedItem
            ret.RET_formato_soporte_3_retrabajo = cboFormato_3_PE_DigitalOffset.SelectedItem
            '----------------------------------------------------------------------------

            'PLIEGO MAQUINA OFFSET
            If txtCantidad_1_PM_Offset.TextLength <> 0 Then
                ret.cantidad_1_PM_offset_retrabajo = txtCantidad_1_PM_Offset.Text
            End If
            If txtCantidad_2_PM_Offset.TextLength <> 0 Then
                ret.cantidad_2_PM_offset_retrabajo = txtCantidad_2_PM_Offset.Text
            End If
            If txtCantidad_3_PM_Offset.TextLength <> 0 Then
                ret.cantidad_3_PM_offset_retrabajo = txtCantidad_3_PM_Offset.Text
            End If
            ret.formato_1_PM_offset_retrabajo = cboFormato_1_PM_Offset.SelectedItem
            ret.formato_2_PM_offset_retrabajo = cboFormato_2_PM_Offset.SelectedItem
            ret.formato_3_PM_offset_retrabajo = cboFormato_3_PM_Offset.SelectedItem

            ret.tipo_impresion_offset_retrabajo = cboTipo_Impresion_Offset.SelectedItem
            ret.impresora_offset_retrabajo = cboImpresora_Offset.SelectedItem
            ret.modo_impresion_offset_retrabajo = cboModo_Impresion_Offset.SelectedItem
            '--------------------------------------------------------------------------------

            'PLIEGO MAQUINA DIGITAL
            If txtCantidad_1_PM_Digital.TextLength <> 0 Then
                ret.cantidad_1_PM_digital_retrabajo = txtCantidad_1_PM_Digital.Text
            End If
            If txtCantidad_2_PM_Digital.TextLength <> 0 Then
                ret.cantidad_2_PM_digital_retrabajo = txtCantidad_2_PM_Digital.Text
            End If
            If txtCantidad_3_PM_Digital.TextLength <> 0 Then
                ret.cantidad_3_PM_digital_retrabajo = txtCantidad_3_PM_Digital.Text
            End If

            ret.formato_1_PM_digital_retrabajo = cboFormato_1_PM_Digital.SelectedItem
            ret.formato_2_PM_digital_retrabajo = cboFormato_2_PM_Digital.SelectedItem
            ret.formato_3_PM_digital_retrabajo = cboFormato_3_PM_Digital.SelectedItem

            ret.tipo_impresion_digital_retrabajo = cboTipo_Impresion_Digital.SelectedItem

            ret.dato_variable_retrabajo = txtDato_Variable.Text

            datacontext.RE_TRABAJO.InsertOnSubmit(ret)
            datacontext.SubmitChanges()

            MsgBox("El re_trabajo se ha guardado correctamente", vbInformation)
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al cargar el Re-Trabajo")
        End Try
    End Sub

    Private Sub chkOffset_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOffset.CheckedChanged
        If chkOffset.Checked = True Then
            GroupProducto1.Enabled = True
            groupOffset.Enabled = True
        Else
            groupOffset.Enabled = False
            GroupProducto1.Enabled = False
            'LimpiarProducto_Soportes()
            'LimpiarOffset()
        End If
    End Sub

    Private Sub chkDigital_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDigital.CheckedChanged
        If chkDigital.Checked = True Then
            GroupDigital.Enabled = True
            GroupProducto1.Enabled = True
        Else
            GroupDigital.Enabled = False
            GroupProducto1.Enabled = False
            'LimpiarProducto_Soportes()
            'LimpiarDigital()
        End If
    End Sub

    Private Sub txt_Cantidad_1_PE_DigitalOffset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad_1_PE_DigitalOffset.KeyPress
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

    Private Sub txt_Cantidad_2_PE_DigitalOffset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad_2_PE_DigitalOffset.KeyPress
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

    Private Sub txt_Cantidad_3_PE_DigitalOffset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad_3_PE_DigitalOffset.KeyPress
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

    Private Sub txtCantidad_1_PM_Offset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_1_PM_Offset.KeyPress
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

    Private Sub txtCantidad_2_PM_Offset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_2_PM_Offset.KeyPress
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

    Private Sub txtCantidad_3_PM_Offset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_3_PM_Offset.KeyPress
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

    Private Sub txtCantidad_1_PM_Digital_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_1_PM_Digital.KeyPress
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

    Private Sub txtCantidad_2_PM_Digital_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_2_PM_Digital.KeyPress
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

    Private Sub txtCantidad_3_PM_Digital_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_3_PM_Digital.KeyPress
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

    Private Sub rbtNumeroOrden_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtNumeroOrden.CheckedChanged
        cboBuscar_Mes.Enabled = False
        cboBuscar_Mes.SelectedIndex = -1
        txt_Buscar_ReTrabajo.Enabled = True
    End Sub

    Private Sub rbtMes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtMes.CheckedChanged
        cboBuscar_Mes.Enabled = True
        txt_Buscar_ReTrabajo.Enabled = False
        txt_Buscar_ReTrabajo.Clear()
    End Sub


    Private Sub ArmaGrillaRetrabajo()
        dgvListado_ReTrabajo.Enabled = True
        dgvListado_ReTrabajo.AutoGenerateColumns = False
        dgvListado_ReTrabajo.Columns.Clear()

        'DATOS RETRABAJOS
        dgvListado_ReTrabajo.Columns.Add("RET_id_retrabajo", "RET_id_retrabajo")
        dgvListado_ReTrabajo.Columns.Add("ORT_id_orden_trabajo", "id_orden_trabajo")
        dgvListado_ReTrabajo.Columns.Add("ORT_numero_ot", "Número de Orden")
        dgvListado_ReTrabajo.Columns.Add("ORT_fecha_ot", "Fecha Original")
        dgvListado_ReTrabajo.Columns.Add("ORT_fecha_entrega", "Fecha Entrega Original")
        dgvListado_ReTrabajo.Columns.Add("DOT_cantidad_producto", "DOT_cantidad_producto")
        dgvListado_ReTrabajo.Columns.Add("PIE_id_pieza", "id_pieza")
        dgvListado_ReTrabajo.Columns.Add("PIE_nombre_pie", "PIE_nombre_pie")
        dgvListado_ReTrabajo.Columns.Add("DOT_tamaño_producto", "DOT_tamaño_producto")
        '----------------------------------------------------------------------------------------
        dgvListado_ReTrabajo.Columns.Add("RET_cantidad_producto_retrabajo", "Cantidad")
        dgvListado_ReTrabajo.Columns.Add("RET_fecha_comienzo_retrabajo", "Fecha Comienzo")
        dgvListado_ReTrabajo.Columns.Add("RET_fecha_entrega_retrabajo", "Fecha Entrega")
        dgvListado_ReTrabajo.Columns.Add("RET_origen_area_motivo", "Causa/Origen")
        dgvListado_ReTrabajo.Columns.Add("RET_procedimiento_observaciones", "Procedimiento")
        '----------------------------------------------------------------------------------------
        dgvListado_ReTrabajo.Columns.Add("RET_papel_soporte_1_retrabajo", "Papel Soporte 1")
        dgvListado_ReTrabajo.Columns.Add("RET_papel_soporte_2_retrabajo", "Papel Soporte 2")
        dgvListado_ReTrabajo.Columns.Add("RET_papel_soporte_3_retrabajo", "Papel Soporte 3")

        dgvListado_ReTrabajo.Columns.Add("RET_gramaje_soporte_1_retrabajo", "Gramaje Soporte 1")
        dgvListado_ReTrabajo.Columns.Add("RET_gramaje_soporte_2_retrabajo", "Gramaje Soporte 2")
        dgvListado_ReTrabajo.Columns.Add("RET_gramaje_soporte_3_retrabajo", "Gramaje Soporte 3")
        '-----------------------------------------------------------------------------------------
        dgvListado_ReTrabajo.Columns.Add("RET_cantidad_soporte_1_retrabajo", "Cantidad Soporte 1")
        dgvListado_ReTrabajo.Columns.Add("RET_cantidad_soporte_2_retrabajo", "Cantidad Soporte 2")
        dgvListado_ReTrabajo.Columns.Add("RET_cantidad_soporte_3_retrabajo", "Cantidad Soporte 3")
        dgvListado_ReTrabajo.Columns.Add("RET_formato_soporte_1_retrabajo", "Formato Soporte 1")
        dgvListado_ReTrabajo.Columns.Add("RET_formato_soporte_2_retrabajo", "Formato Soporte 2")
        dgvListado_ReTrabajo.Columns.Add("RET_formato_soporte_3_retrabajo", "Formato Soporte 3")
        '-----------------------------------------------------------------------------------------
        dgvListado_ReTrabajo.Columns.Add("cantidad_1_PM_offset_retrabajo", "Cantidad 1 PM Off")
        dgvListado_ReTrabajo.Columns.Add("cantidad_2_PM_offset_retrabajo", "Cantidad 2 PM Off")
        dgvListado_ReTrabajo.Columns.Add("cantidad_3_PM_offset_retrabajo", "Cantidad 3 PM Off")
        dgvListado_ReTrabajo.Columns.Add("formato_1_PM_offset_retrabajo", "Formato 1 PM off")
        dgvListado_ReTrabajo.Columns.Add("formato_2_PM_offset_retrabajo", "Formato 2 PM off")
        dgvListado_ReTrabajo.Columns.Add("formato_3_PM_offset_retrabajo", "Formato 3 PM off")
        dgvListado_ReTrabajo.Columns.Add("tipo_impresion_offset_retrabajo", "Tipo Impresión off")
        dgvListado_ReTrabajo.Columns.Add("impresora_offset_retrabajo", "Impresora off")
        dgvListado_ReTrabajo.Columns.Add("modo_impresion_offset_retrabajo", "Modo Impresión off")
        '------------------------------------------------------------------------------------------
        dgvListado_ReTrabajo.Columns.Add("cantidad_1_PM_digital_retrabajo", "Cantidad 1 PM dig")
        dgvListado_ReTrabajo.Columns.Add("cantidad_2_PM_digital_retrabajo", "Cantidad 2 PM dig")
        dgvListado_ReTrabajo.Columns.Add("cantidad_3_PM_digital_retrabajo", "Cantidad 3 PM dig")
        dgvListado_ReTrabajo.Columns.Add("formato_1_PM_digital_retrabajo", "Formato 1 PM dig")
        dgvListado_ReTrabajo.Columns.Add("formato_2_PM_digital_retrabajo", "Formato 2 PM dig")
        dgvListado_ReTrabajo.Columns.Add("formato_3_PM_digital_retrabajo", "Formato 3 PM dig")
        dgvListado_ReTrabajo.Columns.Add("tipo_impresion_digital_retrabajo", "Tipo Impresión dig")
        dgvListado_ReTrabajo.Columns.Add("dato_variable_retrabajo", "Dato Variable")

        dgvListado_ReTrabajo.Columns(0).DataPropertyName = "RET_id_retrabajo"
        dgvListado_ReTrabajo.Columns(0).Visible = False
        dgvListado_ReTrabajo.Columns(1).DataPropertyName = "ORT_id_orden_trabajo"
        dgvListado_ReTrabajo.Columns(1).Visible = False
        dgvListado_ReTrabajo.Columns(2).DataPropertyName = "ORT_numero_ot"
        dgvListado_ReTrabajo.Columns(3).DataPropertyName = "ORT_fecha_ot"
        dgvListado_ReTrabajo.Columns(3).Visible = False
        dgvListado_ReTrabajo.Columns(4).DataPropertyName = "ORT_fecha_entrega"
        dgvListado_ReTrabajo.Columns(4).Visible = False
        dgvListado_ReTrabajo.Columns(5).DataPropertyName = "DOT_cantidad_producto"
        dgvListado_ReTrabajo.Columns(5).Visible = False
        dgvListado_ReTrabajo.Columns(6).DataPropertyName = "PIE_id_pieza"
        dgvListado_ReTrabajo.Columns(6).Visible = False
        dgvListado_ReTrabajo.Columns(7).DataPropertyName = "PIE_nombre_pie"
        dgvListado_ReTrabajo.Columns(8).DataPropertyName = "DOT_tamaño_producto"
        dgvListado_ReTrabajo.Columns(8).Visible = False
        dgvListado_ReTrabajo.Columns(9).DataPropertyName = "RET_cantidad_producto_retrabajo"
        dgvListado_ReTrabajo.Columns(10).DataPropertyName = "RET_fecha_comienzo_retrabajo"
        dgvListado_ReTrabajo.Columns(11).DataPropertyName = "RET_fecha_entrega_retrabajo"
        dgvListado_ReTrabajo.Columns(12).DataPropertyName = "RET_origen_area_motivo"
        dgvListado_ReTrabajo.Columns(12).Width = 250
        dgvListado_ReTrabajo.Columns(13).DataPropertyName = "RET_procedimiento_observaciones"
        dgvListado_ReTrabajo.Columns(13).Width = 250
        dgvListado_ReTrabajo.Columns(14).DataPropertyName = "RET_papel_soporte_1_retrabajo"
        'dgvListado_ReTrabajo.Columns(14).Visible = False
        dgvListado_ReTrabajo.Columns(15).DataPropertyName = "RET_papel_soporte_2_retrabajo"
        dgvListado_ReTrabajo.Columns(15).Visible = False
        dgvListado_ReTrabajo.Columns(16).DataPropertyName = "RET_papel_soporte_3_retrabajo"
        dgvListado_ReTrabajo.Columns(16).Visible = False
        dgvListado_ReTrabajo.Columns(17).DataPropertyName = "RET_gramaje_soporte_1_retrabajo"
        dgvListado_ReTrabajo.Columns(17).Visible = False
        dgvListado_ReTrabajo.Columns(18).DataPropertyName = "RET_gramaje_soporte_2_retrabajo"
        dgvListado_ReTrabajo.Columns(18).Visible = False
        dgvListado_ReTrabajo.Columns(19).DataPropertyName = "RET_gramaje_soporte_3_retrabajo"
        dgvListado_ReTrabajo.Columns(19).Visible = False
        dgvListado_ReTrabajo.Columns(20).DataPropertyName = "RET_cantidad_soporte_1_retrabajo"
        dgvListado_ReTrabajo.Columns(20).Visible = False
        dgvListado_ReTrabajo.Columns(21).DataPropertyName = "RET_cantidad_soporte_2_retrabajo"
        dgvListado_ReTrabajo.Columns(21).Visible = False
        dgvListado_ReTrabajo.Columns(22).DataPropertyName = "RET_cantidad_soporte_3_retrabajo"
        dgvListado_ReTrabajo.Columns(22).Visible = False
        dgvListado_ReTrabajo.Columns(23).DataPropertyName = "RET_formato_soporte_1_retrabajo"
        dgvListado_ReTrabajo.Columns(23).Visible = False
        dgvListado_ReTrabajo.Columns(24).DataPropertyName = "RET_formato_soporte_2_retrabajo"
        dgvListado_ReTrabajo.Columns(24).Visible = False
        dgvListado_ReTrabajo.Columns(25).DataPropertyName = "RET_formato_soporte_3_retrabajo"
        dgvListado_ReTrabajo.Columns(25).Visible = False
        dgvListado_ReTrabajo.Columns(26).DataPropertyName = "cantidad_1_PM_offset_retrabajo"
        dgvListado_ReTrabajo.Columns(26).Visible = False
        dgvListado_ReTrabajo.Columns(27).DataPropertyName = "cantidad_2_PM_offset_retrabajo"
        dgvListado_ReTrabajo.Columns(27).Visible = False
        dgvListado_ReTrabajo.Columns(28).DataPropertyName = "cantidad_3_PM_offset_retrabajo"
        dgvListado_ReTrabajo.Columns(28).Visible = False
        dgvListado_ReTrabajo.Columns(29).DataPropertyName = "formato_1_PM_offset_retrabajo"
        dgvListado_ReTrabajo.Columns(29).Visible = False
        dgvListado_ReTrabajo.Columns(30).DataPropertyName = "formato_2_PM_offset_retrabajo"
        dgvListado_ReTrabajo.Columns(30).Visible = False
        dgvListado_ReTrabajo.Columns(31).DataPropertyName = "formato_3_PM_offset_retrabajo"
        dgvListado_ReTrabajo.Columns(31).Visible = False
        dgvListado_ReTrabajo.Columns(32).DataPropertyName = "tipo_impresion_offset_retrabajo"
        dgvListado_ReTrabajo.Columns(32).Visible = False
        dgvListado_ReTrabajo.Columns(33).DataPropertyName = "impresora_offset_retrabajo"
        dgvListado_ReTrabajo.Columns(33).Visible = False
        dgvListado_ReTrabajo.Columns(34).DataPropertyName = "modo_impresion_offset_retrabajo"
        dgvListado_ReTrabajo.Columns(34).Visible = False
        dgvListado_ReTrabajo.Columns(35).DataPropertyName = "cantidad_1_PM_digital_retrabajo"
        dgvListado_ReTrabajo.Columns(35).Visible = False
        dgvListado_ReTrabajo.Columns(36).DataPropertyName = "cantidad_2_PM_digital_retrabajo"
        dgvListado_ReTrabajo.Columns(36).Visible = False
        dgvListado_ReTrabajo.Columns(37).DataPropertyName = "cantidad_3_PM_digital_retrabajo"
        dgvListado_ReTrabajo.Columns(37).Visible = False
        dgvListado_ReTrabajo.Columns(38).DataPropertyName = "formato_1_PM_digital_retrabajo"
        dgvListado_ReTrabajo.Columns(38).Visible = False
        dgvListado_ReTrabajo.Columns(39).DataPropertyName = "formato_2_PM_digital_retrabajo"
        dgvListado_ReTrabajo.Columns(39).Visible = False
        dgvListado_ReTrabajo.Columns(40).DataPropertyName = "formato_3_PM_digital_retrabajo"
        dgvListado_ReTrabajo.Columns(40).Visible = False
        dgvListado_ReTrabajo.Columns(41).DataPropertyName = "tipo_impresion_digital_retrabajo"
        dgvListado_ReTrabajo.Columns(41).Visible = False
        dgvListado_ReTrabajo.Columns(42).DataPropertyName = "dato_variable_retrabajo"
        dgvListado_ReTrabajo.Columns(42).Visible = False
    End Sub

    Public Sub CargarGrillaRetrabajo()
        Dim carga = (From dot In datacontext.DETALLE_ORDEN_TRABAJO
                                    Join ot In datacontext.ORDEN_TRABAJO
                                    On ot.ORT_id_orden_trabajo Equals dot.ORT_id_orden_trabajo
                                      Join pie In datacontext.PIEZA
                                    On pie.PIE_id_pieza Equals dot.PIE_id_pieza
                                    Join ret In datacontext.RE_TRABAJO
                                    On dot.id_detalle_orden_trabajo Equals ret.id_detalle_orden_trabajo
                                    Select dot.ORT_id_orden_trabajo,
                                    ot.ORT_numero_ot, ot.ORT_fecha_ot,
                                    ot.ORT_fecha_entrega,
                                    dot.id_detalle_orden_trabajo,
                                    dot.DOT_cantidad_producto,
                                    ret.RET_cantidad_producto_retrabajo,
                                    dot.PIE_id_pieza,
                                    pie.PIE_nombre_pie,
                                    dot.DOT_tamaño_producto,
                                    ret.RET_id_retrabajo,
                                    ret.RET_papel_soporte_1_retrabajo,
                                    ret.RET_papel_soporte_2_retrabajo,
                                    ret.RET_papel_soporte_3_retrabajo,
                                    ret.RET_gramaje_soporte_1_retrabajo,
                                    ret.RET_gramaje_soporte_2_retrabajo,
                                    ret.RET_gramaje_soporte_3_retrabajo,
                                    ret.RET_cantidad_soporte_1_retrabajo,
                                    ret.RET_cantidad_soporte_2_retrabajo,
                                    ret.RET_cantidad_soporte_3_retrabajo,
                                    ret.RET_formato_soporte_1_retrabajo,
                                    ret.RET_formato_soporte_2_retrabajo,
                                    ret.RET_formato_soporte_3_retrabajo,
                                    ret.cantidad_1_PM_offset_retrabajo,
                                    ret.cantidad_2_PM_offset_retrabajo,
                                    ret.cantidad_3_PM_offset_retrabajo,
                                    ret.formato_1_PM_offset_retrabajo,
                                    ret.formato_2_PM_offset_retrabajo,
                                    ret.formato_3_PM_offset_retrabajo,
                                    ret.tipo_impresion_offset_retrabajo,
                                    ret.impresora_offset_retrabajo,
                                    ret.modo_impresion_offset_retrabajo,
                                    ret.cantidad_1_PM_digital_retrabajo,
                                    ret.cantidad_2_PM_digital_retrabajo,
                                    ret.cantidad_3_PM_digital_retrabajo,
                                    ret.formato_1_PM_digital_retrabajo,
                                    ret.formato_2_PM_digital_retrabajo,
                                    ret.formato_3_PM_digital_retrabajo,
                                    ret.tipo_impresion_digital_retrabajo,
                                    ret.dato_variable_retrabajo,
                                    ret.cantidad_chapas_retrabajo,
                                    ret.RET_fecha_comienzo_retrabajo,
                                    ret.RET_fecha_entrega_retrabajo,
                                    ret.RET_origen_area_motivo,
                                    ret.RET_procedimiento_observaciones
                                     Where RET_cantidad_producto_retrabajo.ToString.Length <> 0)
        dgvListado_ReTrabajo.DataSource = carga
        ' Where RET_cantidad_producto_retrabajo = txt_Cantidad_Retrabajo.Text)

    End Sub

    Private Sub dgvListado_ReTrabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvListado_ReTrabajo.Click

        Dim combopieza1 = (From sec In datacontext.PIEZA
                      Select sec.PIE_id_pieza, sec.PIE_nombre_pie, sec.PIE_ubicacion
                      Where PIE_ubicacion = "D"
                      Order By PIE_nombre_pie Ascending)
        cboPieza_Original.DataSource = combopieza1
        cboPieza_Original.DisplayMember = "PIE_nombre_pie"
        cboPieza_Original.ValueMember = "PIE_id_pieza"
        cboPieza_Original.SelectedIndex = -1
        'ASIGNA PIEZA SEGUN LO QUE CONTIENE EL GRID
        cboPieza_Original.SelectedValue = dgvListado_ReTrabajo.Item("PIE_id_pieza", dgvListado_ReTrabajo.SelectedRows(0).Index).Value

        Try
            If dgvListado_ReTrabajo.SelectedRows.Count > 0 Then
                'CARGA GROUPBOX DATOS ORIGINALES
                txtNumero_Orden_Trabajo.Text = dgvListado_ReTrabajo.Item("ORT_numero_ot", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                dtp_Fecha_Ingreso_Original.Text = dgvListado_ReTrabajo.Item("ORT_fecha_ot", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                dtp_Nueva_Fecha_Entrega.Text = dgvListado_ReTrabajo.Item("ORT_fecha_entrega", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                txt_Cantidad_Original.Text = dgvListado_ReTrabajo.Item("DOT_cantidad_producto", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                txtTamaño_Original.Text = dgvListado_ReTrabajo.Item("DOT_tamaño_producto", dgvListado_ReTrabajo.SelectedRows(0).Index).Value

                'CARGA GROUPBOX RETRABAJO
                txt_Cantidad_Retrabajo.Text = dgvListado_ReTrabajo.Item("RET_cantidad_producto_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                dtpFecha_Re_Trabajo.Text = dgvListado_ReTrabajo.Item("RET_fecha_comienzo_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                dtp_Nueva_Fecha_Entrega.Text = dgvListado_ReTrabajo.Item("RET_fecha_entrega_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                txt_Origen_Causa.Text = dgvListado_ReTrabajo.Item("RET_origen_area_motivo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                txt_Procedimiento.Text = dgvListado_ReTrabajo.Item("RET_procedimiento_observaciones", dgvListado_ReTrabajo.SelectedRows(0).Index).Value

                'CARGA GROUPBOX PRODUCTO
                cboPapel1.Text = dgvListado_ReTrabajo.Item("PIE_nombre_pie", dgvListado_ReTrabajo.SelectedRows(0).Index).Value 'RET_papel_soporte_1_retrabajo
                cboPapel2.Text = dgvListado_ReTrabajo.Item("PIE_nombre_pie", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboPapel3.Text = dgvListado_ReTrabajo.Item("PIE_nombre_pie", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboGramaje1.Text = dgvListado_ReTrabajo.Item("RET_gramaje_soporte_1_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboGramaje2.Text = dgvListado_ReTrabajo.Item("RET_gramaje_soporte_2_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboGramaje3.Text = dgvListado_ReTrabajo.Item("RET_gramaje_soporte_3_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                txt_Cantidad_1_PE_DigitalOffset.Text = dgvListado_ReTrabajo.Item("RET_cantidad_soporte_1_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                txt_Cantidad_2_PE_DigitalOffset.Text = dgvListado_ReTrabajo.Item("RET_cantidad_soporte_2_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                txt_Cantidad_3_PE_DigitalOffset.Text = dgvListado_ReTrabajo.Item("RET_cantidad_soporte_3_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboFormato_1_PE_DigitalOffset.Text = dgvListado_ReTrabajo.Item("RET_formato_soporte_1_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboFormato_2_PE_DigitalOffset.Text = dgvListado_ReTrabajo.Item("RET_formato_soporte_2_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboFormato_3_PE_DigitalOffset.Text = dgvListado_ReTrabajo.Item("RET_formato_soporte_3_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value

                'PLIEGO MAQUINA OFFSET
                txtCantidad_1_PM_Offset.Text = dgvListado_ReTrabajo.Item("cantidad_1_PM_offset_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                txtCantidad_2_PM_Offset.Text = dgvListado_ReTrabajo.Item("cantidad_2_PM_offset_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                txtCantidad_3_PM_Offset.Text = dgvListado_ReTrabajo.Item("cantidad_3_PM_offset_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboFormato_1_PM_Offset.Text = dgvListado_ReTrabajo.Item("formato_1_PM_offset_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboFormato_2_PM_Offset.Text = dgvListado_ReTrabajo.Item("formato_2_PM_offset_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboFormato_3_PM_Offset.Text = dgvListado_ReTrabajo.Item("formato_3_PM_offset_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboTipo_Impresion_Offset.Text = dgvListado_ReTrabajo.Item("tipo_impresion_offset_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboImpresora_Offset.Text = dgvListado_ReTrabajo.Item("impresora_offset_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboModo_Impresion_Offset.Text = dgvListado_ReTrabajo.Item("modo_impresion_offset_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value

                'PLIEGO MAQUINA DIGITAL
                txtCantidad_1_PM_Digital.Text = dgvListado_ReTrabajo.Item("cantidad_1_PM_digital_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                txtCantidad_2_PM_Digital.Text = dgvListado_ReTrabajo.Item("cantidad_2_PM_digital_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                txtCantidad_3_PM_Digital.Text = dgvListado_ReTrabajo.Item("cantidad_3_PM_digital_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboFormato_1_PM_Digital.Text = dgvListado_ReTrabajo.Item("formato_1_PM_digital_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboFormato_2_PM_Digital.Text = dgvListado_ReTrabajo.Item("formato_2_PM_digital_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboFormato_3_PM_Digital.Text = dgvListado_ReTrabajo.Item("formato_3_PM_digital_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                cboTipo_Impresion_Digital.Text = dgvListado_ReTrabajo.Item("tipo_impresion_digital_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
                txtDato_Variable.Text = dgvListado_ReTrabajo.Item("dato_variable_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value
            Else
                MsgBox("Debe seleccionar un Re-Trabajo del listado")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If dgvListado_ReTrabajo.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.RE_TRABAJO Where C.RET_id_retrabajo = CInt(dgvListado_ReTrabajo.Item("RET_id_retrabajo", dgvListado_ReTrabajo.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el Re-Trabajo seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar Re-Trabajo")
                Case MsgBoxResult.Yes
                    datacontext.RE_TRABAJO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El Re-Trabajo ha sido eliminado correctamente")
                    CargarGrillaRetrabajo()
                    Me.Close()
                Case MsgBoxResult.No
                    Me.Close()
            End Select
        Else
            MsgBox("Debe seleccionar un Re-Trabajo")
        End If
    End Sub
End Class