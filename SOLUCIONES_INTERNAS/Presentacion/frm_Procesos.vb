Public Class frm_Proceso1
    Dim datacontext As New DataS_Interno
    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Me.Hide()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub frm_Proceso1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frm_Proceso1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_id_detalle_orden.Visible = False
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            Dim ActualizarProceso = (From p In datacontext.PROCESO
                                   Where p.PROC_id_proceso = CInt(frm_Listado_Orden_Trabajo.dgvProcesos.Item("PROC_id_proceso", frm_Listado_Orden_Trabajo.dgvProcesos.SelectedRows(0).Index).Value)).ToList()(0)
            ActualizarProceso.id_detalle_orden_trabajo = frm_Listado_Orden_Trabajo.dgvProcesos.Item("id_detalle_orden_trabajo", frm_Listado_Orden_Trabajo.dgvProcesos.SelectedRows(0).Index).Value
            ActualizarProceso.PROC_descrip_digital = StrConv(Me.txt_descripc_digital.Text, VbStrConv.ProperCase)
            ActualizarProceso.PROC_descrip_gran_formato = StrConv(Me.txt_descripc_gran_formato.Text, VbStrConv.ProperCase)
            ActualizarProceso.PROC_descrip_logistica = StrConv(Me.txt_descripc_logistica.Text, VbStrConv.ProperCase)
            ActualizarProceso.PROC_descrip_offset = StrConv(Me.txt_descripc_offset.Text, VbStrConv.ProperCase)
            ActualizarProceso.PROC_descrip_terminacion = StrConv(Me.txt_descripc_terminacion.Text, VbStrConv.ProperCase)

            ActualizarProceso.PROC_digital = StrConv(Me.groupDigital.Text, VbStrConv.ProperCase)
            ActualizarProceso.PROC_gran_formato = StrConv(Me.groupGranFormato.Text, VbStrConv.ProperCase)
            ActualizarProceso.PROC_logistica = StrConv(Me.groupLogistica.Text, VbStrConv.ProperCase)
            ActualizarProceso.PROC_offset = StrConv(Me.groupOffSet.Text, VbStrConv.ProperCase)
            ActualizarProceso.PROC_terminacion = StrConv(Me.groupTerminacion.Text, VbStrConv.ProperCase)

            datacontext.SubmitChanges()
            MsgBox("El proceso se ha modificado correctamente")
            Me.Close()
            frm_Listado_Orden_Trabajo.Close()
        Catch ex As Exception
            MsgBox("Error al modificar el Proceso")
        End Try
    End Sub
End Class