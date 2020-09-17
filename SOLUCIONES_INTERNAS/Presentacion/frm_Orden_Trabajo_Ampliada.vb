Public Class frm_Orden_Trabajo_Ampliada

    Dim datacontext As New DataS_Interno
    '  Public quienllamoordenampliada As Form
    Public quienllamo_listado_orden_ampliada As Form
    Public cargamasprod As String = "NO"

    Private Sub frm_Orden_Trabajo_Ampliada_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'CARGA COMBOBOX PIEZA PRODUCTO
        Dim combopieza1 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie, sec.PIE_ubicacion
                           Where PIE_ubicacion = "D"
                           Order By PIE_nombre_pie Ascending)
        cboPiezas_Producto.DataSource = combopieza1
        cboPiezas_Producto.DisplayMember = "PIE_nombre_pie"
        cboPiezas_Producto.ValueMember = "PIE_id_pieza"

        'CARGA COMBOBOX PIEZA OFFSET
        Dim combopieza2 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie, sec.PIE_ubicacion
                           Where PIE_ubicacion = "G"
                           Order By PIE_nombre_pie Ascending)
        cboPiezas_Producto_Gran_Formato.DataSource = combopieza2
        cboPiezas_Producto_Gran_Formato.DisplayMember = "PIE_nombre_pie"
        cboPiezas_Producto_Gran_Formato.ValueMember = "PIE_id_pieza"

        'CARGA COMBOBOX MATERIAL GRAN FORMATO
        Dim combomaterial = (From sop In datacontext.SOPORTE
                         Select sop.SOP_id_soporte, sop.SOP_nombre_soporte, sop.SOP_ubicacion
                         Where SOP_ubicacion = "G"
                         Order By SOP_nombre_soporte Ascending)
        cboMaterial.DataSource = combomaterial
        cboMaterial.DisplayMember = "SOP_nombre_soporte"
        cboMaterial.ValueMember = "SOP_id_soporte"

        'CARGA COMBOBOX PAPEL 1
        Dim combopapel1 = (From papelsop1 In datacontext.SOPORTE
                 Select papelsop1.SOP_id_soporte, papelsop1.SOP_nombre_soporte, papelsop1.SOP_ubicacion
                 Where SOP_ubicacion = "D"
                 Order By SOP_nombre_soporte Ascending)
        cboPapel1.DataSource = combopapel1
        cboPapel1.DisplayMember = "SOP_nombre_soporte"
        cboPapel1.ValueMember = "SOP_id_soporte"

        'CARGA COMBOBOX PAPEL 2
        Dim combopapel2 = (From papelsop2 In datacontext.SOPORTE
                 Select papelsop2.SOP_id_soporte, papelsop2.SOP_nombre_soporte, papelsop2.SOP_ubicacion
                 Where SOP_ubicacion = "D"
                 Order By SOP_nombre_soporte Ascending)
        cboPapel2.DataSource = combopapel2
        cboPapel2.DisplayMember = "SOP_nombre_soporte"
        cboPapel2.ValueMember = "SOP_id_soporte"

        'CARGA COMBOBOX PAPEL 3
        Dim combopapel3 = (From papelsop2 In datacontext.SOPORTE
                 Select papelsop2.SOP_id_soporte, papelsop2.SOP_nombre_soporte, papelsop2.SOP_ubicacion
                 Where SOP_ubicacion = "D"
                 Order By SOP_nombre_soporte Ascending)
        cboPapel3.DataSource = combopapel3
        cboPapel3.DisplayMember = "SOP_nombre_soporte"
        cboPapel3.ValueMember = "SOP_id_soporte"

        If quienllamo_listado_orden_ampliada.Name <> frm_listado_orden_trabajo_ampliada.Name Then
            cboPiezas_Producto.SelectedIndex = -1
            cboPiezas_Producto_Gran_Formato.SelectedIndex = -1
            cboMaterial.SelectedIndex = -1
            cboPapel1.SelectedIndex = -1
            cboPapel2.SelectedIndex = -1
            cboPapel3.SelectedIndex = -1
        Else
            cboPiezas_Producto.SelectedValue = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("PIE_id_pieza", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.CurrentRow.Index).Value
            cboPiezas_Producto_Gran_Formato.SelectedValue = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("PIE_id_pieza_offset", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.CurrentRow.Index).Value
            cboMaterial.Text = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("sustrato_gran_formato", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.SelectedRows(0).Index).Value 'sustrato gran formato
            cboPapel1.Text = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("DOT_papel_soporte_1", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.SelectedRows(0).Index).Value 'sustrato gran formato
            cboPapel2.Text = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("DOT_papel_soporte_2", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.SelectedRows(0).Index).Value 'sustrato gran formato
            cboPapel3.Text = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("DOT_papel_soporte_3", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.SelectedRows(0).Index).Value 'sustrato gran formato

        End If
    End Sub

    Private Sub btnBuscar_cliente_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_cliente.Click
        frm_Cliente.quienllamocliente = Me
        frm_Cliente.Text = "Seleccionar Cliente"
        frm_Cliente.btnEliminar_Cliente.Enabled = False
        frm_Cliente.GroupNuevoCliente.Enabled = False
        frm_Cliente.Show()
    End Sub

    Private Sub chkOffset_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOffset.CheckedChanged
        If chkOffset.Checked = True Then
            GroupProducto_Soportes.Enabled = True
            groupOffset.Enabled = True
        Else
            groupOffset.Enabled = False
            GroupProducto_Soportes.Enabled = False
            LimpiarProducto_Soportes()
            LimpiarOffset()
        End If
    End Sub

    Private Sub chkDigital_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDigital.CheckedChanged
        If chkDigital.Checked = True Then
            GroupDigital.Enabled = True
            GroupProducto_Soportes.Enabled = True
        Else
            GroupDigital.Enabled = False
            GroupProducto_Soportes.Enabled = False
            LimpiarProducto_Soportes()
            LimpiarDigital()
        End If
    End Sub

    Private Sub chkGranFormato_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGranFormato.CheckedChanged
        If chkGranFormato.Checked = True Then
            GroupGranFormato.Enabled = True
        Else
            GroupGranFormato.Enabled = False
            LimpiarGranFormato()
        End If
    End Sub

    Private Sub chkTerminacion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTerminacion.CheckedChanged
        If chkTerminacion.Checked = True Then
            GroupTerminacion.Enabled = True
        Else
            GroupTerminacion.Enabled = False
            LimpiarTerminacion()
        End If
    End Sub

    Public Sub LimpiarDigital()
        cboTipo_Impresion_Digital.SelectedIndex = -1
        txtCantidad_1_Pliego_Maquina_Digital.Clear()
        cboFormato_1_Pliego_Maquina_Digital.SelectedIndex = -1
        txtCantidad_2_Pliego_Maquina_Digital.Clear()
        cboFormato_2_Pliego_Maquina_Digital.SelectedIndex = -1
        txtCantidad_3_Pliego_Maquina_Digital.Clear()
        cboFormato_3_Pliego_Maquina_Digital.SelectedIndex = -1
        txtDato_Variable.Clear()
    End Sub

    Sub LimpiarTerminacion()
        chkLaca_UV.Checked = False
        chkPosicionado.Checked = False
        chkDoblado.Checked = False
        chkTroquelado.Checked = False
        chkGuillotinado.Checked = False
        chkMedio_Corte.Checked = False
        chkBarniz.Checked = False
        chkMontado.Checked = False
        chkEncuadernacion.Checked = False
        chkStamping.Checked = False
        chkAdhesivado.Checked = False
        chkTrazado.Checked = False
        chkSoldado.Checked = False
        chkCocido.Checked = False
        chkRuedo.Checked = False
        chkPlastificado.Checked = False
        chkOtros.Checked = False
        txt_descripcion_terminacion.Clear()
    End Sub

    Sub LimpiarProducto_Soportes()
        txt_cantidad_producto.Clear()
        cboPiezas_Producto.SelectedIndex = -1
        txtTamaño_Producto.Clear()
        cboPapel1.SelectedIndex = -1
        cboGramaje1.SelectedIndex = -1
        txt_Cantidad_1_Pliego_Entero.Clear()
        cboFormato_1_Pliego_Entero.SelectedIndex = -1
        cboPapel2.SelectedIndex = -1
        txt_Cantidad_2_Pliego_Entero.Clear()
        cboGramaje2.SelectedIndex = -1
        txt_Cantidad_2_Pliego_Entero.Clear()
        cboFormato_2_Pliego_Entero.SelectedIndex = -1
        cboPapel3.SelectedIndex = -1
        cboGramaje3.SelectedIndex = -1
        txt_Cantidad_3_Pliego_Entero.Clear()
        cboFormato_3_Pliego_Entero.SelectedIndex = -1
    End Sub

    Sub LimpiarOffset()
        cboTipo_Impresion_Offset.SelectedIndex = -1
        cboModo_Impresion_Offset.SelectedIndex = -1
        cboImpresora_Offset.SelectedIndex = -1
        cboMarca_Offset.SelectedIndex = -1
        txtCantidad_1_Pliego_Maquina_Offset.Clear()
        txtCantidad_2_Pliego_Maquina_Offset.Clear()
        txtCantidad_3_Pliego_Maquina_Offset.Clear()
        txt_chapa_soporte_1.Clear()
        txt_chapa_soporte_2.Clear()
        txt_chapa_soporte_3.Clear()
        cboFormato_1_Pliego_Maquina_Offset.SelectedIndex = -1
        cboFormato_2_Pliego_Maquina_Offset.SelectedIndex = -1
        cboFormato_3_Pliego_Maquina_Offset.SelectedIndex = -1
    End Sub

    Sub LimpiarGranFormato()
        txt_cantidad_producto_Gran_Formato.Clear()
        cboPiezas_Producto_Gran_Formato.SelectedIndex = -1
        txtTamaño_Producto_Gran_Formato.Clear()
        cboMaterial.SelectedIndex = -1
        cboCalidad_Gran_Formato.SelectedIndex = -1
        cboSistema_Gran_Formato.SelectedIndex = -1
    End Sub

    Private Sub btnGuardar_Orden_Trabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Orden_Trabajo.Click

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
        If cboDireccion_Entrega.Text.Length = 0 Then
            MsgBox("Cargue la Dirección de Entrega")
            cboDireccion_Entrega.Focus()
            Exit Sub
        End If
        'VALIDA QUE LA FECHA DE ENTREGA SEA CORRECTA
        If dtpFecha_Entrega_ODT.Value < Today Then
            MsgBox("Verifique la Fecha de Entrega")
            Exit Sub
        End If

        If chkOffset.Checked = True Or chkDigital.Checked = True Or chkGranFormato.Checked = True Or chkTerminacion.Checked = True Then

            If chkOffset.Checked = True Or chkDigital.Checked = True Then
                If txt_cantidad_producto.Text.Length >= 1 Then
                    If cboPiezas_Producto.Text.Length = 0 Then
                        MsgBox("Seleccione una pieza")
                        cboPiezas_Producto.Focus()
                        Exit Sub
                    End If
                Else
                    MsgBox("Ingrese Cantidad Producto")
                    txt_cantidad_producto.Focus()
                    Exit Sub
                End If
            End If
            If chkGranFormato.Checked = True Then
                If txt_cantidad_producto_Gran_Formato.Text.Length >= 1 Then
                    If cboPiezas_Producto_Gran_Formato.Text.Length = 0 Then
                        MsgBox("Seleccione una pieza")
                        Exit Sub
                    End If
                Else
                    MsgBox("Ingrese Cantidad Producto")
                    txt_cantidad_producto_Gran_Formato.Focus()
                    Exit Sub
                End If
            End If

            If chkTerminacion.Checked = True Then
                If txt_descripcion_terminacion.TextLength = 0 Then
                    MsgBox("Describa la terminación seleccionada")
                    Exit Sub
                End If
            End If
        Else
            MsgBox("Seleccione un tipo de Orden")
            Exit Sub
        End If

        Dim buscaorden = (From odt1 In datacontext.ORDEN_TRABAJO
                      Select odt1.ORT_fecha_ot, odt1.ORT_tipo_ot, odt1.ORT_numero_ot, odt1.ORT_observaciones_ot, odt1.VEN_id_vendedor, odt1.CLI_id_cliente, odt1.ORT_fecha_entrega
                      Where ORT_numero_ot = txtNumero_Orden_Trabajo.Text.ToUpper).Any

        If cargamasprod = "NO" Then
            If buscaorden = True Then
                MsgBox("La Orden ingresada ya existe")
                Exit Sub
            End If
        End If
        Try
            '---------------------------GUARDA ORDEN------------------------------

            Dim ODT = New ORDEN_TRABAJO
            If cargamasprod = "NO" Then

                ODT.ORT_numero_ot = StrConv(txtNumero_Orden_Trabajo.Text, VbStrConv.ProperCase)
                ODT.ORT_fecha_ot = dtpFecha_Ingreso_ODT.Text
                ODT.ORT_fecha_entrega = dtpFecha_Entrega_ODT.Text
                ODT.ORT_tipo_ot = cboTipo_Orden.Text

                ODT.ORT_observaciones_ot = StrConv(txt_observaciones.Text, VbStrConv.ProperCase)
                ODT.ORT_mejoras_ot = StrConv(cboDireccion_Entrega.Text, VbStrConv.ProperCase)
                ODT.VEN_id_vendedor = txtid_vendedor.Text
                ODT.CLI_id_cliente = txt_id_cliente.Text

                datacontext.ORDEN_TRABAJO.InsertOnSubmit(ODT)
                datacontext.SubmitChanges()
            End If
            'GUARDA DETALLE DE LA ORDEN DE TRABAJO
            '--------------------------------------------------------------------------------------

            Dim detalle = New DETALLE_ORDEN_TRABAJO

            txt_id_detalle_orden_trabajo1.Text = detalle.id_detalle_orden_trabajo  'id
            detalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text

            If txt_cantidad_producto.TextLength <> 0 Then
                detalle.DOT_cantidad_producto = txt_cantidad_producto.Text  'CANTIDAD PRODUCTO 1
            End If
            detalle.DOT_tamaño_producto = StrConv(txtTamaño_Producto.Text, VbStrConv.ProperCase) 'TAMAÑO PRODUCTO 1
            detalle.DOT_tipo_impresion_dot = cboTipo_Orden.SelectedItem 'TIPO IMPRESION PRODUCTO 1

            If cboPiezas_Producto.Text.Length <> 0 Then
                detalle.PIE_id_pieza = cboPiezas_Producto.SelectedValue 'TIPO PIEZA PRODUCTO 1
            Else
                detalle.PIE_id_pieza = 54
            End If

            If cargamasprod = "NO" Then
                txt_id_orden_trabajo.Text = ODT.ORT_id_orden_trabajo
            End If
            detalle.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text 'ID ORDEN TRABAJO

            'PAPEL PRODUCTO 1
            detalle.DOT_papel_soporte_1 = StrConv(cboPapel1.Text, VbStrConv.ProperCase)
            detalle.DOT_papel_soporte_2 = StrConv(cboPapel2.Text, VbStrConv.ProperCase)
            detalle.DOT_papel_soporte_3 = StrConv(cboPapel3.Text, VbStrConv.ProperCase)

            'GRAMAJE PRODUCTO 1
            detalle.DOT_gramaje_soporte_1 = cboGramaje1.Text
            detalle.DOT_gramaje_soporte_2 = cboGramaje2.Text
            detalle.DOT_gramaje_soporte_3 = cboGramaje3.Text

            'CANTIDAD PRODUCTO 1
            If txt_Cantidad_1_Pliego_Entero.TextLength <> 0 Then
                detalle.DOT_cantidad_soporte_1 = txt_Cantidad_1_Pliego_Entero.Text
            End If
            If txt_Cantidad_2_Pliego_Entero.TextLength <> 0 Then
                detalle.DOT_cantidad_soporte_2 = txt_Cantidad_2_Pliego_Entero.Text
            End If
            If txt_Cantidad_3_Pliego_Entero.TextLength <> 0 Then
                detalle.DOT_cantidad_soporte_3 = txt_Cantidad_3_Pliego_Entero.Text
            End If
            'FORMATO PRODUCTO 1
            detalle.DOT_formato_soporte_1 = cboFormato_1_Pliego_Entero.SelectedItem
            detalle.DOT_formato_soporte_2 = cboFormato_2_Pliego_Entero.SelectedItem
            detalle.DOT_formato_soporte_3 = cboFormato_3_Pliego_Entero.SelectedItem

            '--------------------------------DIGITAL---------------------------------------------

            detalle.tipo_impresion_digital = cboTipo_Impresion_Digital.Text

            If txtCantidad_1_Pliego_Maquina_Digital.TextLength <> 0 Then
                detalle.cantidad_1_PM_digital = txtCantidad_1_Pliego_Maquina_Digital.Text
            End If
            If txtCantidad_2_Pliego_Maquina_Digital.TextLength <> 0 Then
                detalle.cantidad_2_PM_digital = txtCantidad_2_Pliego_Maquina_Digital.Text
            End If
            If txtCantidad_3_Pliego_Maquina_Digital.TextLength <> 0 Then
                detalle.cantidad_3_PM_digital = txtCantidad_3_Pliego_Maquina_Digital.Text
            End If

            detalle.formato_1_PM_digital = cboFormato_1_Pliego_Maquina_Digital.SelectedItem
            detalle.formato_2_PM_digital = cboFormato_2_Pliego_Maquina_Digital.SelectedItem
            detalle.formato_3_PM_digital = cboFormato_3_Pliego_Maquina_Digital.SelectedItem

            detalle.dato_variable = txtDato_Variable.Text
            '------------------------------------------------------------------------------------

            '---------------------------OFFSET---------------------------------------------------
            detalle.tipo_impresion_offset = cboTipo_Impresion_Offset.Text
            detalle.impresora_offset = cboImpresora_Offset.SelectedItem
            detalle.modo_impresion_offset = cboModo_Impresion_Offset.SelectedItem
            detalle.marca_offset = cboMarca_Offset.SelectedItem
            If txtCantidad_1_Pliego_Maquina_Offset.TextLength <> 0 Then
                detalle.cantidad_1_PM_offset = txtCantidad_1_Pliego_Maquina_Offset.Text
            End If
            If txtCantidad_2_Pliego_Maquina_Offset.TextLength <> 0 Then
                detalle.cantidad_2_PM_offset = txtCantidad_2_Pliego_Maquina_Offset.Text
            End If
            If txtCantidad_3_Pliego_Maquina_Offset.TextLength <> 0 Then
                detalle.cantidad_3_PM_offset = txtCantidad_3_Pliego_Maquina_Offset.Text
            End If
            detalle.formato_1_PM_offset = cboFormato_1_Pliego_Maquina_Offset.SelectedItem
            detalle.formato_2_PM_offset = cboFormato_2_Pliego_Maquina_Offset.SelectedItem
            detalle.formato_3_PM_offset = cboFormato_3_Pliego_Maquina_Offset.SelectedItem
            If txt_chapa_soporte_1.TextLength <> 0 Then
                detalle.chapas_soporte1_offset = txt_chapa_soporte_1.Text
            End If
            If txt_chapa_soporte_2.TextLength <> 0 Then
                detalle.chapas_soporte2_offset = txt_chapa_soporte_2.Text
            End If
            If txt_chapa_soporte_3.TextLength <> 0 Then
                detalle.chapas_soporte3_offset = txt_chapa_soporte_3.Text
            End If
            '------------------------------------------------------------------------------------

            '-------------------------------GRAN FORMATO----------------------------------------
            If txt_cantidad_producto_Gran_Formato.TextLength <> 0 Then
                detalle.cantidad_gran_formato = txt_cantidad_producto_Gran_Formato.Text
            End If
            If cboPiezas_Producto_Gran_Formato.Text.Length <> 0 Then
                detalle.PIE_id_pieza_offset = cboPiezas_Producto_Gran_Formato.SelectedValue
            Else
                '54 es un id de pieza que funciona de parche en la base
                detalle.PIE_id_pieza_offset = 54
            End If

            detalle.tamaño_gran_formato = txtTamaño_Producto_Gran_Formato.Text
            detalle.sustrato_gran_formato = cboMaterial.Text
            detalle.calidad_gran_formato = cboCalidad_Gran_Formato.SelectedItem
            detalle.sistema_gran_formato = cboSistema_Gran_Formato.SelectedItem
            '------------------------------------------------------------------------------------

            '-------------------------------- TERMINACION----------------------------------------
            Dim temtermosellado, tempegadomanual, temestampado, temarmadorevistas, temlaca, temposicionado, temdoblado, temtroquelado, temguillotinado, temmediocorte, tembarniz, temmontado, temencuadernacion, temstamping, _
                temadhesivado, temtrazado, temsoldado, temcocido, temruedo, templastificado, temotros, temcuño, temfresado, temLacaUVSect, _
                temOPPBrillante, temOPPMate As String
            'ADHESIVADO
            If chkAdhesivado.Checked = True Then
                temadhesivado = "T01"
            Else
                temadhesivado = ""
            End If
            'ARMADO REVISTAS
            If chkArmadoRevistas.Checked = True Then
                temarmadorevistas = "T02"
            Else
                temarmadorevistas = ""
            End If
            'BARNIZ
            If chkBarniz.Checked = True Then
                tembarniz = "T03"
            Else
                tembarniz = ""
            End If
            'COCIDO
            If chkCocido.Checked = True Then
                temcocido = "T04"
            Else
                temcocido = ""
            End If
            'CUÑO
            If chkCuño.Checked = True Then
                temcuño = "T05"
            Else
                temcuño = ""
            End If
            'DOBLADO
            If chkDoblado.Checked = True Then
                temdoblado = "T06"
            Else
                temdoblado = ""
            End If
            'ENCUADERNACION
            If chkEncuadernacion.Checked = True Then
                temencuadernacion = "T07"
            Else
                temencuadernacion = ""
            End If
            'ESTAMPADO
            If chkEstampado.Checked = True Then
                temestampado = "T08"
            Else
                temestampado = ""
            End If
            'FRESADO
            If chkFresado.Checked = True Then
                temfresado = "T09"
            Else
                temfresado = ""
            End If
            'GUILLOTINADO
            If chkGuillotinado.Checked = True Then
                temguillotinado = "T10"
            Else
                temguillotinado = ""
            End If
            'LACA UV
            If chkLaca_UV.Checked = True Then
                temlaca = "T11"
            Else
                temlaca = ""
            End If
            'LACA UV SECTORIZADA
            If chkLacaUVSectorizada.Checked = True Then
                temLacaUVSect = "T12"
            Else
                temLacaUVSect = ""
            End If
            'MEDIO CORTE
            If chkMedio_Corte.Checked = True Then
                temmediocorte = "T13"
            Else
                temmediocorte = ""
            End If
            'MONTADO
            If chkMontado.Checked = True Then
                temmontado = "T14"
            Else
                temmontado = ""
            End If
            'OPP BRILLANTE
            If chkOPPBrillante.Checked = True Then
                temOPPBrillante = "T15"
            Else
                temOPPBrillante = ""
            End If
            'OPP MATE
            If chkOPPMate.Checked = True Then
                temOPPMate = "T16"
            Else
                temOPPMate = ""
            End If
            'OTROS
            If chkOtros.Checked = True Then
                temotros = "T17"
            Else
                temotros = ""
            End If
            'PEGADO MANUAL
            If chkPegadoManual.Checked = True Then
                tempegadomanual = "T18"
            Else
                tempegadomanual = ""
            End If
            'PLASTIFICADO
            If chkPlastificado.Checked = True Then
                templastificado = "T19"
            Else
                templastificado = ""
            End If
            'POSICIONADO
            If chkPosicionado.Checked = True Then
                temposicionado = "T20"
            Else
                temposicionado = ""
            End If
            'RUEDO
            If chkRuedo.Checked = True Then
                temruedo = "T21"
            Else
                temruedo = ""
            End If
            'SOLDADO
            If chkSoldado.Checked = True Then
                temsoldado = "T22"
            Else
                temsoldado = ""
            End If
            'STAMPING
            If chkStamping.Checked = True Then
                temstamping = "T23"
            Else
                temstamping = ""
            End If
            'TERMOSELLADO
            If chkTermosellado.Checked = True Then
                temtermosellado = "T24"
            Else
                temtermosellado = ""
            End If
            'TRAZADO
            If chkTrazado.Checked = True Then
                temtrazado = "T25"
            Else
                temtrazado = ""
            End If
            'TROQUELADO
            If chkTroquelado.Checked = True Then
                temtroquelado = "T26"
            Else
                temtroquelado = ""
            End If

            detalle.tipo_terminacion = temlaca & temposicionado & temdoblado & temtroquelado & temguillotinado & temmediocorte & tembarniz & temmontado _
                & temencuadernacion & temstamping & temadhesivado & temtrazado & temsoldado & temcocido & temruedo & temotros & temcuño & temfresado & _
                temLacaUVSect & temOPPBrillante & temOPPMate & temarmadorevistas & temestampado & tempegadomanual & templastificado & temtermosellado

            detalle.descripcion_terminacion = txt_descripcion_terminacion.Text
            '-----------------------------------------------------------------------
            'GUARDA EL USUARIO REGISTRADO AL SISTEMA
            detalle.modo_impresion_digital = frm_Principal.LBL_MENU_USU.Text
            '-----------------------------------------------------------------------

            datacontext.DETALLE_ORDEN_TRABAJO.InsertOnSubmit(detalle)
            datacontext.SubmitChanges()

            Select Case MsgBox("Agregar mas productos?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar orden")
                Case MsgBoxResult.Yes
                    cargamasprod = "SI"
                    chkDigital.Checked = False
                    chkOffset.Checked = False
                    chkTerminacion.Checked = False
                    chkGranFormato.Checked = False
                    'LimpiarDigital()
                    'LimpiarGranFormato()
                    'LimpiarOffset()
                    'LimpiarProducto_Soportes()
                    'LimpiarTerminacion()
                    Exit Sub
                Case Else
                    MsgBox("la Orden se ha creado correctamente", vbInformation)
                    Me.Close()
                    '  frm_listado_orden_trabajo_ampliada.frm_listado_orden_trabajo_ampliada_Load(0, Nothing)
                    frm_listado_orden_trabajo_ampliada.CargarGrillaDetalle()
            End Select
        Catch ex As Exception
            MsgBox("Error al cargar la Orden")
        End Try
    End Sub

    Private Sub btnBuscar_Vendedor_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Vendedor.Click
        frm_Vendedor.quienllamovendedor = Me
        frm_Vendedor.Text = "Seleccionar Vendedor"
        frm_Vendedor.btnEliminar_vendedor.Enabled = False
        frm_Vendedor.GroupNuevoVendedor.Enabled = False
        frm_Vendedor.Show()
    End Sub

    Private Sub btnCancelar_Orden_Trabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar_Orden_Trabajo.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_cantidad_producto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad_producto.KeyPress
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

    Private Sub txt_Gramaje_1_Soporte_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Gramaje_2_Soporte_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Gramaje_3_Soporte_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad_1_Pliego_Entero_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad_1_Pliego_Entero.KeyPress
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

    Private Sub txt_Cantidad_2_Pliego_Entero_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad_2_Pliego_Entero.KeyPress
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

    Private Sub txt_Cantidad_3_Pliego_Entero_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad_3_Pliego_Entero.KeyPress
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

    Private Sub txtCantidad_1_Pliego_Maquina_Offset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_1_Pliego_Maquina_Offset.KeyPress
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

    Private Sub txtCantidad_2_Pliego_Maquina_Offset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_2_Pliego_Maquina_Offset.KeyPress
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

    Private Sub txtCantidad_3_Pliego_Maquina_Offset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_3_Pliego_Maquina_Offset.KeyPress
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

    Private Sub txtCantidad_1_Pliego_Maquina_Digital_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_1_Pliego_Maquina_Digital.KeyPress
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

    Private Sub txtCantidad_2_Pliego_Maquina_Digital_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_2_Pliego_Maquina_Digital.KeyPress
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

    Private Sub txtCantidad_3_Pliego_Maquina_Digital_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_3_Pliego_Maquina_Digital.KeyPress
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

    Private Sub txt_cantidad_producto_Gran_Formato_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad_producto_Gran_Formato.KeyPress
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

    Private Sub txt_chapa_soporte_1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_chapa_soporte_1.KeyPress
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

    Private Sub txt_chapa_soporte_2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_chapa_soporte_2.KeyPress
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

    Private Sub txt_chapa_soporte_3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_chapa_soporte_3.KeyPress
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

End Class
