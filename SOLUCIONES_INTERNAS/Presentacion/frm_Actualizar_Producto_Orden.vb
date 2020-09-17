Public Class frm_Actualizar_Producto_Orden
    Dim datacontext As New DataS_Interno

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        If txt_cantidad.Text.Length = 0 Then
            MsgBox("Complete la Cantidad")
            txt_cantidad.Focus()
            Exit Sub
        End If

        If cboPiezas.Text.Length = 0 Then
            MsgBox("Seleccione un Pieza")
            cboPiezas.Focus()
            Exit Sub
        End If

        If txtTamaño.Text.Length = 0 Then
            MsgBox("Complete el Tamaño")
            txtTamaño.Focus()
            Exit Sub
        End If

        If cboTipoImpresion.Text.Length = 0 Then
            MsgBox("Seleccione un Tipo de Impresión")
            cboTipoImpresion.Focus()
            Exit Sub
        End If

        Dim ActualizarDetalle = (From D In datacontext.DETALLE_ORDEN_TRABAJO
                                  Where D.id_detalle_orden_trabajo = CInt(txt_id_detalle_orden_trabajo1.Text)).ToList()(0)
        If cboPiezas.Text.Length = 0 Then
            MsgBox("Seleccione una pieza")
            Exit Sub
        End If
        Try
            txt_id_detalle_orden_trabajo1.Text = ActualizarDetalle.id_detalle_orden_trabajo
            ActualizarDetalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text
            ActualizarDetalle.DOT_cantidad_producto = txt_cantidad.Text
            ActualizarDetalle.PIE_id_pieza = cboPiezas.SelectedValue
            ActualizarDetalle.DOT_tamaño_producto = txtTamaño.Text
            ActualizarDetalle.DOT_tipo_impresion_dot = cboTipoImpresion.Text

            ActualizarDetalle.DOT_papel_soporte_1 = StrConv(cboPapel1.Text, VbStrConv.ProperCase)
            ActualizarDetalle.DOT_papel_soporte_2 = StrConv(cboPapel2.Text, VbStrConv.ProperCase)
            ActualizarDetalle.DOT_papel_soporte_3 = StrConv(cboPapel3.Text, VbStrConv.ProperCase)

            ActualizarDetalle.DOT_gramaje_soporte_1 = cboGramaje1.Text
            ActualizarDetalle.DOT_gramaje_soporte_2 = cboGramaje2.Text
            ActualizarDetalle.DOT_gramaje_soporte_3 = cboGramaje3.Text

            If txt_Cantidad1_Soporte.TextLength <> 0 Then
                ActualizarDetalle.DOT_cantidad_soporte_1 = CInt(txt_Cantidad1_Soporte.Text)
            End If
            If txt_Cantidad2_Soporte.TextLength <> 0 Then
                ActualizarDetalle.DOT_cantidad_soporte_2 = CInt(txt_Cantidad2_Soporte.Text)
            End If
            If txt_Cantidad3_Soporte.TextLength <> 0 Then
                ActualizarDetalle.DOT_cantidad_soporte_3 = CInt(txt_Cantidad3_Soporte.Text)
            End If

            ActualizarDetalle.DOT_formato_soporte_1 = cboFormato1_Soporte.SelectedItem
            ActualizarDetalle.DOT_formato_soporte_2 = cboFormato2_Soporte.SelectedItem
            ActualizarDetalle.DOT_formato_soporte_3 = cboFormato3_Soporte.SelectedItem

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Producto")
            Me.Close()
            frm_Listado_Orden_Trabajo.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Producto")
        End Try
    End Sub

    Private Sub frm_Actualizar_Producto_Orden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CARGA COMBO
        Dim combopieza1 = (From sec In datacontext.PIEZA
                             Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                             Order By PIE_nombre_pie Ascending)
        cboPiezas.DataSource = combopieza1
        cboPiezas.DisplayMember = "PIE_nombre_pie"
        cboPiezas.ValueMember = "PIE_id_pieza"

        'ASIGNA PIEZA SEGUN LO QUE CONTIENE EL GRID
        cboPiezas.SelectedValue = frm_Listado_Orden_Trabajo.dgv_detalle_orden.Item("PIE_id_pieza", frm_Listado_Orden_Trabajo.dgv_detalle_orden.CurrentRow.Index).Value
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txtTamaño_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTamaño.TextChanged

    End Sub
End Class