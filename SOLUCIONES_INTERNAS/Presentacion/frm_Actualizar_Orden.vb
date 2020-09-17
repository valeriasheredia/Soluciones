Public Class frm_Actualizar_Orden
    Dim datacontext As New DataS_Interno

    Private Sub btnBuscar_Vendedor_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Vendedor.Click
        frm_Vendedor.quienllamovendedor = Me
        frm_Vendedor.Text = "Seleccionar Vendedor"
        frm_Vendedor.btnEliminar_vendedor.Enabled = False
        frm_Vendedor.GroupNuevoVendedor.Enabled = False
        frm_Vendedor.Show()
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        'VALIDA CAMPOS OBLIGATORIOS
        'If cboTipo_Orden.Text.Length = 0 Then
        '    MsgBox("Seleccione un Tipo de Orden")
        '    cboTipo_Orden.Focus()
        '    Exit Sub
        'End If

        If txtNombre_vendedor.Text.Length = 0 Then
            MsgBox("Seleccione un Vendedor")
            btnBuscar_Vendedor.Focus()
            Exit Sub
        End If

        If txt_nombre_cliente.Text.Length = 0 Then
            MsgBox("Seleccione un Cliente")
            btnBuscar_cliente.Focus()
            Exit Sub
        End If
        Try
            'ACTUALIZA LA ORDEN DE TRABAJO
            Dim ActualizarOrden = (From P In datacontext.ORDEN_TRABAJO Where P.ORT_id_orden_trabajo = (txt_id_orden_trabajo.Text.ToUpper)).ToList()(0)
            ActualizarOrden.ORT_fecha_ot = dtpFecha_Orden_Trabajo.Text
            ActualizarOrden.ORT_tipo_ot = cboTipo_Orden.Text
            ActualizarOrden.ORT_numero_ot = txtNumero_Orden_Trabajo.Text
            ActualizarOrden.ORT_observaciones_ot = txt_observaciones.Text
            ActualizarOrden.ORT_mejoras_ot = cboDireccion_Entrega.Text
            ActualizarOrden.VEN_id_vendedor = txtid_vendedor.Text
            ActualizarOrden.CLI_id_cliente = txt_id_cliente.Text
            ActualizarOrden.ORT_fecha_entrega = dtpFecha_Entrega.Text
            datacontext.SubmitChanges()

            MsgBox("Los datos se han modificado correctamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Orden")
            Me.Close()
            frm_Listado_Orden_Trabajo.Close()
            frm_listado_orden_trabajo_ampliada.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Orden")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnBuscar_cliente_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_cliente.Click
        frm_Cliente.quienllamocliente = Me
        frm_Cliente.Text = "Seleccionar Cliente"
        frm_Cliente.btnEliminar_Cliente.Enabled = False
        frm_Cliente.GroupNuevoCliente.Enabled = False
        frm_Cliente.Show()
    End Sub

End Class