Imports System.Windows.Forms
'Imports automatico

Public Class frm_Principal
    Dim buscartarea
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Public quienllamoatarea As Integer

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Application.ExitThread()
        Me.Dispose()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click

        For Each aform As Form In Me.MdiChildren
            aform.Close()
        Next
        frm_ingreso.txt_contraseña.Clear()
        frm_ingreso.txt_usuario.Clear()
        frm_ingreso.txt_usuario.Select()
        frm_ingreso.Show()

        'CAMBIE EL HIDE POR EL CLOSE..AHORA APARECEN LOS MENSAJES ENVIADOS, (NO ME GUSTA MUCHO COMO QUEDO, PORQUE CERRAR SESION Y SALIR CUMPLEN CASI LA MISMA FUNCION).
        Me.Hide()
        'Me.Close()
    End Sub

    Private Sub AltaUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaUsuariosToolStripMenuItem.Click

        frm_Usuario.Text = "Nuevo Usuario"
        frm_Usuario.txt_usuario.Clear()
        frm_Usuario.txt_contraseña.Clear()
        frm_Usuario.cbo_perfil.SelectedIndex = -1
        frm_Usuario.btnActualizar_Usuario.Enabled = False
        frm_Usuario.btnGuardar_Usuario.Enabled = True
        frm_Usuario.btnEliminar_Usuario.Enabled = False
        frm_Usuario.txt_usuario.Enabled = True
        frm_Usuario.txt_contraseña.Enabled = True
        frm_Usuario.cbo_perfil.Enabled = True
        frm_Usuario.btnBuscar_Colaborador.Enabled = True
        frm_Usuario.btnBuscar_Colaborador.Visible = True
        frm_Usuario.GroupListadoUsuarios.Enabled = False
        frm_Usuario.dgvLista_Usuarios.ClearSelection()

        'frm_Usuario.ShowDialog()
        frm_Usuario.MdiParent = Me
        frm_Usuario.Show()
    End Sub

    Private Sub CambiarContraeñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarContraeñaToolStripMenuItem.Click
        frm_Usuario.Text = "Modificar Usuario"
        frm_Usuario.btnGuardar_Usuario.Enabled = False
        frm_Usuario.btnActualizar_Usuario.Enabled = True
        frm_Usuario.btnEliminar_Usuario.Enabled = False
        frm_Usuario.btnNuevo_Usuario.Enabled = False
        frm_Usuario.btnBuscar_Colaborador.Enabled = True
        frm_Usuario.txt_usuario.Enabled = True
        frm_Usuario.txt_contraseña.Enabled = True
        frm_Usuario.cbo_perfil.Enabled = True
        frm_Usuario.dgvLista_Usuarios.ClearSelection()
        frm_Usuario.ShowDialog()
    End Sub

    Sub LimpiarDetalleTarea()
        frm_Tarea.txt_detalle_tarea1.Clear()
        frm_Tarea.txt_detalle_tarea2.Clear()
        frm_Tarea.txt_detalle_tarea3.Clear()
        frm_Tarea.txt_detalle_tarea4.Clear()
        frm_Tarea.txt_detalle_tarea5.Clear()
        frm_Tarea.txt_detalle_tarea6.Clear()
        frm_Tarea.txt_detalle_tarea7.Clear()
        frm_Tarea.txt_detalle_tarea8.Clear()
        frm_Tarea.txt_detalle_tarea9.Clear()
        frm_Tarea.txt_detalle_tarea10.Clear()
        frm_Tarea.txt_detalle_tarea11.Clear()
        frm_Tarea.txt_detalle_tarea12.Clear()
        frm_Tarea.txt_detalle_tarea13.Clear()
        frm_Tarea.txt_detalle_tarea14.Clear()
        frm_Tarea.txt_detalle_tarea15.Clear()
        frm_Tarea.txt_detalle_tarea16.Clear()
        frm_Tarea.txt_detalle_tarea17.Clear()
        frm_Tarea.txt_detalle_tarea18.Clear()
        frm_Tarea.txt_detalle_tarea19.Clear()
        frm_Tarea.txt_detalle_tarea20.Clear()
    End Sub

    Sub HabilitarDetalleTarea()
        frm_Tarea.txt_detalle_tarea1.Enabled = True
        frm_Tarea.txt_detalle_tarea2.Enabled = True
        frm_Tarea.txt_detalle_tarea3.Enabled = True
        frm_Tarea.txt_detalle_tarea4.Enabled = True
        frm_Tarea.txt_detalle_tarea5.Enabled = True
        frm_Tarea.txt_detalle_tarea6.Enabled = True
        frm_Tarea.txt_detalle_tarea7.Enabled = True
        frm_Tarea.txt_detalle_tarea8.Enabled = True
        frm_Tarea.txt_detalle_tarea9.Enabled = True
        frm_Tarea.txt_detalle_tarea10.Enabled = True
        frm_Tarea.txt_detalle_tarea11.Enabled = True
        frm_Tarea.txt_detalle_tarea12.Enabled = True
        frm_Tarea.txt_detalle_tarea13.Enabled = True
        frm_Tarea.txt_detalle_tarea14.Enabled = True
        frm_Tarea.txt_detalle_tarea15.Enabled = True
        frm_Tarea.txt_detalle_tarea16.Enabled = True
        frm_Tarea.txt_detalle_tarea17.Enabled = True
        frm_Tarea.txt_detalle_tarea18.Enabled = True
        frm_Tarea.txt_detalle_tarea19.Enabled = True
        frm_Tarea.txt_detalle_tarea20.Enabled = True
    End Sub

    Sub LimpiarTiempoEstimado()
        frm_Tarea.txtTiempo_Estimado1.Clear()
        frm_Tarea.txtTiempo_Estimado2.Clear()
        frm_Tarea.txtTiempo_Estimado3.Clear()
        frm_Tarea.txtTiempo_Estimado4.Clear()
        frm_Tarea.txtTiempo_Estimado5.Clear()
        frm_Tarea.txtTiempo_Estimado6.Clear()
        frm_Tarea.txtTiempo_Estimado7.Clear()
        frm_Tarea.txtTiempo_Estimado8.Clear()
        frm_Tarea.txtTiempo_Estimado9.Clear()
        frm_Tarea.txtTiempo_Estimado10.Clear()
        frm_Tarea.txtTiempo_Estimado11.Clear()
        frm_Tarea.txtTiempo_Estimado12.Clear()
        frm_Tarea.txtTiempo_Estimado13.Clear()
        frm_Tarea.txtTiempo_Estimado14.Clear()
        frm_Tarea.txtTiempo_Estimado15.Clear()
        frm_Tarea.txtTiempo_Estimado16.Clear()
        frm_Tarea.txtTiempo_Estimado17.Clear()
        frm_Tarea.txtTiempo_Estimado18.Clear()
        frm_Tarea.txtTiempo_Estimado19.Clear()
        frm_Tarea.txtTiempo_Estimado20.Clear()
    End Sub

    Sub HabilitarTiempoEstimado()
        frm_Tarea.txtTiempo_Estimado1.Enabled = True
        frm_Tarea.txtTiempo_Estimado2.Enabled = True
        frm_Tarea.txtTiempo_Estimado3.Enabled = True
        frm_Tarea.txtTiempo_Estimado4.Enabled = True
        frm_Tarea.txtTiempo_Estimado5.Enabled = True
        frm_Tarea.txtTiempo_Estimado6.Enabled = True
        frm_Tarea.txtTiempo_Estimado7.Enabled = True
        frm_Tarea.txtTiempo_Estimado8.Enabled = True
        frm_Tarea.txtTiempo_Estimado9.Enabled = True
        frm_Tarea.txtTiempo_Estimado10.Enabled = True
        frm_Tarea.txtTiempo_Estimado11.Enabled = True
        frm_Tarea.txtTiempo_Estimado12.Enabled = True
        frm_Tarea.txtTiempo_Estimado13.Enabled = True
        frm_Tarea.txtTiempo_Estimado14.Enabled = True
        frm_Tarea.txtTiempo_Estimado15.Enabled = True
        frm_Tarea.txtTiempo_Estimado16.Enabled = True
        frm_Tarea.txtTiempo_Estimado17.Enabled = True
        frm_Tarea.txtTiempo_Estimado18.Enabled = True
        frm_Tarea.txtTiempo_Estimado19.Enabled = True
        frm_Tarea.txtTiempo_Estimado20.Enabled = True
    End Sub

    Sub LimpiarTiempoReal()
        frm_Tarea.txtTiempo_Real1.Clear()
        frm_Tarea.txtTiempo_Real2.Clear()
        frm_Tarea.txtTiempo_Real3.Clear()
        frm_Tarea.txtTiempo_Real4.Clear()
        frm_Tarea.txtTiempo_Real5.Clear()
        frm_Tarea.txtTiempo_Real6.Clear()
        frm_Tarea.txtTiempo_Real7.Clear()
        frm_Tarea.txtTiempo_Real8.Clear()
        frm_Tarea.txtTiempo_Real9.Clear()
        frm_Tarea.txtTiempo_Real10.Clear()
        frm_Tarea.txtTiempo_Real11.Clear()
        frm_Tarea.txtTiempo_Real12.Clear()
        frm_Tarea.txtTiempo_Real13.Clear()
        frm_Tarea.txtTiempo_Real14.Clear()
        frm_Tarea.txtTiempo_Real15.Clear()
        frm_Tarea.txtTiempo_Real16.Clear()
        frm_Tarea.txtTiempo_Real17.Clear()
        frm_Tarea.txtTiempo_Real18.Clear()
        frm_Tarea.txtTiempo_Real19.Clear()
        frm_Tarea.txtTiempo_Real20.Clear()
    End Sub

    Sub HabilitarTiempoReal()
        frm_Tarea.txtTiempo_Real1.Enabled = True
        frm_Tarea.txtTiempo_Real2.Enabled = True
        frm_Tarea.txtTiempo_Real3.Enabled = True
        frm_Tarea.txtTiempo_Real4.Enabled = True
        frm_Tarea.txtTiempo_Real5.Enabled = True
        frm_Tarea.txtTiempo_Real6.Enabled = True
        frm_Tarea.txtTiempo_Real7.Enabled = True
        frm_Tarea.txtTiempo_Real8.Enabled = True
        frm_Tarea.txtTiempo_Real9.Enabled = True
        frm_Tarea.txtTiempo_Real10.Enabled = True
        frm_Tarea.txtTiempo_Real11.Enabled = True
        frm_Tarea.txtTiempo_Real12.Enabled = True
        frm_Tarea.txtTiempo_Real13.Enabled = True
        frm_Tarea.txtTiempo_Real14.Enabled = True
        frm_Tarea.txtTiempo_Real15.Enabled = True
        frm_Tarea.txtTiempo_Real16.Enabled = True
        frm_Tarea.txtTiempo_Real17.Enabled = True
        frm_Tarea.txtTiempo_Real18.Enabled = True
        frm_Tarea.txtTiempo_Real19.Enabled = True
        frm_Tarea.txtTiempo_Real20.Enabled = True
    End Sub

    Sub LimpiarHoraFinalizacion()
        frm_Tarea.txtHora_Finalizacion1.Clear()
        frm_Tarea.txtHora_Finalizacion2.Clear()
        frm_Tarea.txtHora_Finalizacion3.Clear()
        frm_Tarea.txtHora_Finalizacion4.Clear()
        frm_Tarea.txtHora_Finalizacion5.Clear()
        frm_Tarea.txtHora_Finalizacion6.Clear()
        frm_Tarea.txtHora_Finalizacion7.Clear()
        frm_Tarea.txtHora_Finalizacion8.Clear()
        frm_Tarea.txtHora_Finalizacion9.Clear()
        frm_Tarea.txtHora_Finalizacion10.Clear()
        frm_Tarea.txtHora_Finalizacion11.Clear()
        frm_Tarea.txtHora_Finalizacion12.Clear()
        frm_Tarea.txtHora_Finalizacion13.Clear()
        frm_Tarea.txtHora_Finalizacion14.Clear()
        frm_Tarea.txtHora_Finalizacion15.Clear()
        frm_Tarea.txtHora_Finalizacion16.Clear()
        frm_Tarea.txtHora_Finalizacion17.Clear()
        frm_Tarea.txtHora_Finalizacion18.Clear()
        frm_Tarea.txtHora_Finalizacion19.Clear()
        frm_Tarea.txtHora_Finalizacion20.Clear()
    End Sub

    Sub HabilitarHoraFinalizacion()
        frm_Tarea.txtHora_Finalizacion1.Enabled = True
        frm_Tarea.txtHora_Finalizacion2.Enabled = True
        frm_Tarea.txtHora_Finalizacion3.Enabled = True
        frm_Tarea.txtHora_Finalizacion4.Enabled = True
        frm_Tarea.txtHora_Finalizacion5.Enabled = True
        frm_Tarea.txtHora_Finalizacion6.Enabled = True
        frm_Tarea.txtHora_Finalizacion7.Enabled = True
        frm_Tarea.txtHora_Finalizacion8.Enabled = True
        frm_Tarea.txtHora_Finalizacion9.Enabled = True
        frm_Tarea.txtHora_Finalizacion10.Enabled = True
        frm_Tarea.txtHora_Finalizacion11.Enabled = True
        frm_Tarea.txtHora_Finalizacion12.Enabled = True
        frm_Tarea.txtHora_Finalizacion13.Enabled = True
        frm_Tarea.txtHora_Finalizacion14.Enabled = True
        frm_Tarea.txtHora_Finalizacion15.Enabled = True
        frm_Tarea.txtHora_Finalizacion16.Enabled = True
        frm_Tarea.txtHora_Finalizacion17.Enabled = True
        frm_Tarea.txtHora_Finalizacion18.Enabled = True
        frm_Tarea.txtHora_Finalizacion19.Enabled = True
        frm_Tarea.txtHora_Finalizacion20.Enabled = True
    End Sub

    Sub LimipiarObservaciones()
        frm_Tarea.txtObservaciones1.Clear()
        frm_Tarea.txtObservaciones2.Clear()
        frm_Tarea.txtObservaciones3.Clear()
        frm_Tarea.txtObservaciones4.Clear()
        frm_Tarea.txtObservaciones5.Clear()
        frm_Tarea.txtObservaciones6.Clear()
        frm_Tarea.txtObservaciones7.Clear()
        frm_Tarea.txtObservaciones8.Clear()
        frm_Tarea.txtObservaciones9.Clear()
        frm_Tarea.txtObservaciones10.Clear()
        frm_Tarea.txtObservaciones11.Clear()
        frm_Tarea.txtObservaciones12.Clear()
        frm_Tarea.txtObservaciones13.Clear()
        frm_Tarea.txtObservaciones14.Clear()
        frm_Tarea.txtObservaciones15.Clear()
        frm_Tarea.txtObservaciones16.Clear()
        frm_Tarea.txtObservaciones17.Clear()
        frm_Tarea.txtObservaciones18.Clear()
        frm_Tarea.txtObservaciones19.Clear()
        frm_Tarea.txtObservaciones20.Clear()
    End Sub

    Sub HabilitarObservaciones()
        frm_Tarea.txtObservaciones1.Enabled = True
        frm_Tarea.txtObservaciones2.Enabled = True
        frm_Tarea.txtObservaciones3.Enabled = True
        frm_Tarea.txtObservaciones4.Enabled = True
        frm_Tarea.txtObservaciones5.Enabled = True
        frm_Tarea.txtObservaciones6.Enabled = True
        frm_Tarea.txtObservaciones7.Enabled = True
        frm_Tarea.txtObservaciones8.Enabled = True
        frm_Tarea.txtObservaciones9.Enabled = True
        frm_Tarea.txtObservaciones10.Enabled = True
        frm_Tarea.txtObservaciones11.Enabled = True
        frm_Tarea.txtObservaciones12.Enabled = True
        frm_Tarea.txtObservaciones13.Enabled = True
        frm_Tarea.txtObservaciones14.Enabled = True
        frm_Tarea.txtObservaciones15.Enabled = True
        frm_Tarea.txtObservaciones16.Enabled = True
        frm_Tarea.txtObservaciones17.Enabled = True
        frm_Tarea.txtObservaciones18.Enabled = True
        frm_Tarea.txtObservaciones19.Enabled = True
        frm_Tarea.txtObservaciones20.Enabled = True
    End Sub

    Sub LimpiarNumeroOrden()
        frm_Tarea.txtNumero_Orden_Trabajo1.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo2.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo3.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo4.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo5.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo6.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo7.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo8.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo9.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo10.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo11.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo12.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo13.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo14.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo15.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo16.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo17.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo18.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo19.Clear()
        frm_Tarea.txtNumero_Orden_Trabajo20.Clear()
    End Sub

    Sub DeshabilitarNumeroOrden()
        frm_Tarea.txtNumero_Orden_Trabajo1.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo2.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo3.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo4.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo5.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo6.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo7.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo8.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo9.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo10.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo11.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo12.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo13.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo14.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo15.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo16.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo17.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo18.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo19.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo20.Enabled = False
    End Sub

    Sub OcultarIdOrden()
        frm_Tarea.txt_id_orden_trabajo1.Visible = False
        frm_Tarea.txt_id_orden_trabajo2.Visible = False
        frm_Tarea.txt_id_orden_trabajo3.Visible = False
        frm_Tarea.txt_id_orden_trabajo4.Visible = False
        frm_Tarea.txt_id_orden_trabajo5.Visible = False
        frm_Tarea.txt_id_orden_trabajo6.Visible = False
        frm_Tarea.txt_id_orden_trabajo7.Visible = False
        frm_Tarea.txt_id_orden_trabajo8.Visible = False
        frm_Tarea.txt_id_orden_trabajo9.Visible = False
        frm_Tarea.txt_id_orden_trabajo10.Visible = False
        frm_Tarea.txt_id_orden_trabajo11.Visible = False
        frm_Tarea.txt_id_orden_trabajo12.Visible = False
        frm_Tarea.txt_id_orden_trabajo13.Visible = False
        frm_Tarea.txt_id_orden_trabajo14.Visible = False
        frm_Tarea.txt_id_orden_trabajo15.Visible = False
        frm_Tarea.txt_id_orden_trabajo16.Visible = False
        frm_Tarea.txt_id_orden_trabajo17.Visible = False
        frm_Tarea.txt_id_orden_trabajo18.Visible = False
        frm_Tarea.txt_id_orden_trabajo19.Visible = False
        frm_Tarea.txt_id_orden_trabajo20.Visible = False
    End Sub

    Sub OcultarIdTarea()
        frm_Tarea.txt_Id_Tarea1.Visible = False
        frm_Tarea.txt_Id_Tarea2.Visible = False
        frm_Tarea.txt_Id_Tarea3.Visible = False
        frm_Tarea.txt_Id_Tarea4.Visible = False
        frm_Tarea.txt_Id_Tarea5.Visible = False
        frm_Tarea.txt_Id_Tarea6.Visible = False
        frm_Tarea.txt_Id_Tarea7.Visible = False
        frm_Tarea.txt_Id_Tarea8.Visible = False
        frm_Tarea.txt_Id_Tarea9.Visible = False
        frm_Tarea.txt_Id_Tarea10.Visible = False
        frm_Tarea.txt_Id_Tarea11.Visible = False
        frm_Tarea.txt_Id_Tarea12.Visible = False
        frm_Tarea.txt_Id_Tarea13.Visible = False
        frm_Tarea.txt_Id_Tarea14.Visible = False
        frm_Tarea.txt_Id_Tarea15.Visible = False
        frm_Tarea.txt_Id_Tarea16.Visible = False
        frm_Tarea.txt_Id_Tarea17.Visible = False
        frm_Tarea.txt_Id_Tarea18.Visible = False
        frm_Tarea.txt_Id_Tarea19.Visible = False
        frm_Tarea.txt_Id_Tarea20.Visible = False
    End Sub

    Sub HabilitarBotonNumeroOrden()
        frm_Tarea.btnBuscar_Numero_Orden1.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden2.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden3.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden4.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden5.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden6.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden7.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden8.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden9.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden10.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden11.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden12.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden13.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden14.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden15.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden16.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden17.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden18.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden19.Enabled = True
        frm_Tarea.btnBuscar_Numero_Orden20.Enabled = True
    End Sub

    Sub DemasCampos()
        frm_Tarea.txt_Carga_Horaria1.Enabled = False
        frm_Tarea.txt_id_colaborador.Visible = False
        frm_Tarea.Label1.Visible = False
        frm_Tarea.txt_nombre_colaborador.Enabled = False
        frm_Tarea.txt_id_tarea.Visible = False
        Label1.Visible = False
        frm_Tarea.dtpFecha.Text = Now
        frm_Tarea.btnBuscar_Colaborador.Focus()
        frm_Tarea.btnBuscar_Colaborador.Visible = True

        frm_Tarea.btnNueva_Tarea.Visible = False
        frm_Tarea.btnImprimirFormulario.Visible = False
        frm_Tarea.btnGuardar_Tarea.Visible = True
        frm_Tarea.btnCancelar_Tarea.Visible = True
        frm_Tarea.btnBuscar_Colaborador.Enabled = True
        frm_Tarea.btnActualizar.Enabled = False
    End Sub

    '-----------------------------------------------

    Sub LimpiarDetalleTarea1()
        frm_Tarea_1.txt_detalle_tarea1.Clear()
        frm_Tarea_1.txt_detalle_tarea2.Clear()
        frm_Tarea_1.txt_detalle_tarea3.Clear()
        frm_Tarea_1.txt_detalle_tarea4.Clear()
        frm_Tarea_1.txt_detalle_tarea5.Clear()
        frm_Tarea_1.txt_detalle_tarea6.Clear()
        frm_Tarea_1.txt_detalle_tarea7.Clear()
        frm_Tarea_1.txt_detalle_tarea8.Clear()
        frm_Tarea_1.txt_detalle_tarea9.Clear()
        frm_Tarea_1.txt_detalle_tarea10.Clear()
        frm_Tarea_1.txt_detalle_tarea11.Clear()
        frm_Tarea_1.txt_detalle_tarea12.Clear()
        frm_Tarea_1.txt_detalle_tarea13.Clear()
        frm_Tarea_1.txt_detalle_tarea14.Clear()
        frm_Tarea_1.txt_detalle_tarea15.Clear()
        frm_Tarea_1.txt_detalle_tarea16.Clear()
        frm_Tarea_1.txt_detalle_tarea17.Clear()
        frm_Tarea_1.txt_detalle_tarea18.Clear()
        frm_Tarea_1.txt_detalle_tarea19.Clear()
        frm_Tarea_1.txt_detalle_tarea20.Clear()
    End Sub

    Sub HabilitarDetalleTarea1()
        frm_Tarea_1.txt_detalle_tarea1.Enabled = True
        frm_Tarea_1.txt_detalle_tarea2.Enabled = True
        frm_Tarea_1.txt_detalle_tarea3.Enabled = True
        frm_Tarea_1.txt_detalle_tarea4.Enabled = True
        frm_Tarea_1.txt_detalle_tarea5.Enabled = True
        frm_Tarea_1.txt_detalle_tarea6.Enabled = True
        frm_Tarea_1.txt_detalle_tarea7.Enabled = True
        frm_Tarea_1.txt_detalle_tarea8.Enabled = True
        frm_Tarea_1.txt_detalle_tarea9.Enabled = True
        frm_Tarea_1.txt_detalle_tarea10.Enabled = True
        frm_Tarea_1.txt_detalle_tarea11.Enabled = True
        frm_Tarea_1.txt_detalle_tarea12.Enabled = True
        frm_Tarea_1.txt_detalle_tarea13.Enabled = True
        frm_Tarea_1.txt_detalle_tarea14.Enabled = True
        frm_Tarea_1.txt_detalle_tarea15.Enabled = True
        frm_Tarea_1.txt_detalle_tarea16.Enabled = True
        frm_Tarea_1.txt_detalle_tarea17.Enabled = True
        frm_Tarea_1.txt_detalle_tarea18.Enabled = True
        frm_Tarea_1.txt_detalle_tarea19.Enabled = True
        frm_Tarea_1.txt_detalle_tarea20.Enabled = True
    End Sub

    Sub LimpiarTiempoEstimado1()
        frm_Tarea_1.txtTiempo_Estimado1.Clear()
        frm_Tarea_1.txtTiempo_Estimado2.Clear()
        frm_Tarea_1.txtTiempo_Estimado3.Clear()
        frm_Tarea_1.txtTiempo_Estimado4.Clear()
        frm_Tarea_1.txtTiempo_Estimado5.Clear()
        frm_Tarea_1.txtTiempo_Estimado6.Clear()
        frm_Tarea_1.txtTiempo_Estimado7.Clear()
        frm_Tarea_1.txtTiempo_Estimado8.Clear()
        frm_Tarea_1.txtTiempo_Estimado9.Clear()
        frm_Tarea_1.txtTiempo_Estimado10.Clear()
        frm_Tarea_1.txtTiempo_Estimado11.Clear()
        frm_Tarea_1.txtTiempo_Estimado12.Clear()
        frm_Tarea_1.txtTiempo_Estimado13.Clear()
        frm_Tarea_1.txtTiempo_Estimado14.Clear()
        frm_Tarea_1.txtTiempo_Estimado15.Clear()
        frm_Tarea_1.txtTiempo_Estimado16.Clear()
        frm_Tarea_1.txtTiempo_Estimado17.Clear()
        frm_Tarea_1.txtTiempo_Estimado18.Clear()
        frm_Tarea_1.txtTiempo_Estimado19.Clear()
        frm_Tarea_1.txtTiempo_Estimado20.Clear()
    End Sub

    Sub HabilitarTiempoEstimado1()
        frm_Tarea_1.txtTiempo_Estimado1.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado2.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado3.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado4.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado5.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado6.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado7.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado8.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado9.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado10.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado11.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado12.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado13.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado14.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado15.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado16.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado17.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado18.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado19.Enabled = True
        frm_Tarea_1.txtTiempo_Estimado20.Enabled = True
    End Sub

    Sub LimpiarTiempoReal1()
        frm_Tarea_1.txtTiempo_Real1.Clear()
        frm_Tarea_1.txtTiempo_Real2.Clear()
        frm_Tarea_1.txtTiempo_Real3.Clear()
        frm_Tarea_1.txtTiempo_Real4.Clear()
        frm_Tarea_1.txtTiempo_Real5.Clear()
        frm_Tarea_1.txtTiempo_Real6.Clear()
        frm_Tarea_1.txtTiempo_Real7.Clear()
        frm_Tarea_1.txtTiempo_Real8.Clear()
        frm_Tarea_1.txtTiempo_Real9.Clear()
        frm_Tarea_1.txtTiempo_Real10.Clear()
        frm_Tarea_1.txtTiempo_Real11.Clear()
        frm_Tarea_1.txtTiempo_Real12.Clear()
        frm_Tarea_1.txtTiempo_Real13.Clear()
        frm_Tarea_1.txtTiempo_Real14.Clear()
        frm_Tarea_1.txtTiempo_Real15.Clear()
        frm_Tarea_1.txtTiempo_Real16.Clear()
        frm_Tarea_1.txtTiempo_Real17.Clear()
        frm_Tarea_1.txtTiempo_Real18.Clear()
        frm_Tarea_1.txtTiempo_Real19.Clear()
        frm_Tarea_1.txtTiempo_Real20.Clear()
    End Sub

    Sub HabilitarTiempoReal1()
        frm_Tarea_1.txtTiempo_Real1.Enabled = True
        frm_Tarea_1.txtTiempo_Real2.Enabled = True
        frm_Tarea_1.txtTiempo_Real3.Enabled = True
        frm_Tarea_1.txtTiempo_Real4.Enabled = True
        frm_Tarea_1.txtTiempo_Real5.Enabled = True
        frm_Tarea_1.txtTiempo_Real6.Enabled = True
        frm_Tarea_1.txtTiempo_Real7.Enabled = True
        frm_Tarea_1.txtTiempo_Real8.Enabled = True
        frm_Tarea_1.txtTiempo_Real9.Enabled = True
        frm_Tarea_1.txtTiempo_Real10.Enabled = True
        frm_Tarea_1.txtTiempo_Real11.Enabled = True
        frm_Tarea_1.txtTiempo_Real12.Enabled = True
        frm_Tarea_1.txtTiempo_Real13.Enabled = True
        frm_Tarea_1.txtTiempo_Real14.Enabled = True
        frm_Tarea_1.txtTiempo_Real15.Enabled = True
        frm_Tarea_1.txtTiempo_Real16.Enabled = True
        frm_Tarea_1.txtTiempo_Real17.Enabled = True
        frm_Tarea_1.txtTiempo_Real18.Enabled = True
        frm_Tarea_1.txtTiempo_Real19.Enabled = True
        frm_Tarea_1.txtTiempo_Real20.Enabled = True
    End Sub

    Sub LimpiarHoraFinalizacion1()
        frm_Tarea_1.txtHora_Finalizacion1.Clear()
        frm_Tarea_1.txtHora_Finalizacion2.Clear()
        frm_Tarea_1.txtHora_Finalizacion3.Clear()
        frm_Tarea_1.txtHora_Finalizacion4.Clear()
        frm_Tarea_1.txtHora_Finalizacion5.Clear()
        frm_Tarea_1.txtHora_Finalizacion6.Clear()
        frm_Tarea_1.txtHora_Finalizacion7.Clear()
        frm_Tarea_1.txtHora_Finalizacion8.Clear()
        frm_Tarea_1.txtHora_Finalizacion9.Clear()
        frm_Tarea_1.txtHora_Finalizacion10.Clear()
        frm_Tarea_1.txtHora_Finalizacion11.Clear()
        frm_Tarea_1.txtHora_Finalizacion12.Clear()
        frm_Tarea_1.txtHora_Finalizacion13.Clear()
        frm_Tarea_1.txtHora_Finalizacion14.Clear()
        frm_Tarea_1.txtHora_Finalizacion15.Clear()
        frm_Tarea_1.txtHora_Finalizacion16.Clear()
        frm_Tarea_1.txtHora_Finalizacion17.Clear()
        frm_Tarea_1.txtHora_Finalizacion18.Clear()
        frm_Tarea_1.txtHora_Finalizacion19.Clear()
        frm_Tarea_1.txtHora_Finalizacion20.Clear()
    End Sub

    Sub HabilitarHoraFinalizacion1()
        frm_Tarea_1.txtHora_Finalizacion1.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion2.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion3.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion4.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion5.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion6.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion7.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion8.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion9.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion10.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion11.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion12.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion13.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion14.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion15.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion16.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion17.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion18.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion19.Enabled = True
        frm_Tarea_1.txtHora_Finalizacion20.Enabled = True
    End Sub

    Sub LimipiarObservaciones1()
        frm_Tarea_1.txtObservaciones1.Clear()
        frm_Tarea_1.txtObservaciones2.Clear()
        frm_Tarea_1.txtObservaciones3.Clear()
        frm_Tarea_1.txtObservaciones4.Clear()
        frm_Tarea_1.txtObservaciones5.Clear()
        frm_Tarea_1.txtObservaciones6.Clear()
        frm_Tarea_1.txtObservaciones7.Clear()
        frm_Tarea_1.txtObservaciones8.Clear()
        frm_Tarea_1.txtObservaciones9.Clear()
        frm_Tarea_1.txtObservaciones10.Clear()
        frm_Tarea_1.txtObservaciones11.Clear()
        frm_Tarea_1.txtObservaciones12.Clear()
        frm_Tarea_1.txtObservaciones13.Clear()
        frm_Tarea_1.txtObservaciones14.Clear()
        frm_Tarea_1.txtObservaciones15.Clear()
        frm_Tarea_1.txtObservaciones16.Clear()
        frm_Tarea_1.txtObservaciones17.Clear()
        frm_Tarea_1.txtObservaciones18.Clear()
        frm_Tarea_1.txtObservaciones19.Clear()
        frm_Tarea_1.txtObservaciones20.Clear()
    End Sub

    Sub HabilitarObservaciones1()
        frm_Tarea_1.txtObservaciones1.Enabled = True
        frm_Tarea_1.txtObservaciones2.Enabled = True
        frm_Tarea_1.txtObservaciones3.Enabled = True
        frm_Tarea_1.txtObservaciones4.Enabled = True
        frm_Tarea_1.txtObservaciones5.Enabled = True
        frm_Tarea_1.txtObservaciones6.Enabled = True
        frm_Tarea_1.txtObservaciones7.Enabled = True
        frm_Tarea_1.txtObservaciones8.Enabled = True
        frm_Tarea_1.txtObservaciones9.Enabled = True
        frm_Tarea_1.txtObservaciones10.Enabled = True
        frm_Tarea_1.txtObservaciones11.Enabled = True
        frm_Tarea_1.txtObservaciones12.Enabled = True
        frm_Tarea_1.txtObservaciones13.Enabled = True
        frm_Tarea_1.txtObservaciones14.Enabled = True
        frm_Tarea_1.txtObservaciones15.Enabled = True
        frm_Tarea_1.txtObservaciones16.Enabled = True
        frm_Tarea_1.txtObservaciones17.Enabled = True
        frm_Tarea_1.txtObservaciones18.Enabled = True
        frm_Tarea_1.txtObservaciones19.Enabled = True
        frm_Tarea_1.txtObservaciones20.Enabled = True
    End Sub

    Sub LimpiarNumeroOrden1()
        frm_Tarea_1.txtNumero_Orden_Trabajo1.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo2.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo3.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo4.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo5.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo6.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo7.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo8.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo9.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo10.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo11.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo12.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo13.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo14.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo15.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo16.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo17.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo18.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo19.Clear()
        frm_Tarea_1.txtNumero_Orden_Trabajo20.Clear()
    End Sub

    Sub DeshabilitarNumeroOrden1()
        frm_Tarea_1.txtNumero_Orden_Trabajo1.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo2.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo3.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo4.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo5.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo6.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo7.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo8.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo9.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo10.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo11.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo12.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo13.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo14.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo15.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo16.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo17.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo18.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo19.Enabled = False
        frm_Tarea_1.txtNumero_Orden_Trabajo20.Enabled = False
    End Sub

    Sub OcultarIdOrden1()
        frm_Tarea_1.txt_id_orden_trabajo1.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo2.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo3.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo4.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo5.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo6.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo7.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo8.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo9.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo10.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo11.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo12.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo13.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo14.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo15.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo16.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo17.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo18.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo19.Visible = False
        frm_Tarea_1.txt_id_orden_trabajo20.Visible = False
    End Sub

    Sub OcultarIdTarea1()
        frm_Tarea_1.txt_Id_Tarea1.Visible = False
        frm_Tarea_1.txt_Id_Tarea2.Visible = False
        frm_Tarea_1.txt_Id_Tarea3.Visible = False
        frm_Tarea_1.txt_Id_Tarea4.Visible = False
        frm_Tarea_1.txt_Id_Tarea5.Visible = False
        frm_Tarea_1.txt_Id_Tarea6.Visible = False
        frm_Tarea_1.txt_Id_Tarea7.Visible = False
        frm_Tarea_1.txt_Id_Tarea8.Visible = False
        frm_Tarea_1.txt_Id_Tarea9.Visible = False
        frm_Tarea_1.txt_Id_Tarea10.Visible = False
        frm_Tarea_1.txt_Id_Tarea11.Visible = False
        frm_Tarea_1.txt_Id_Tarea12.Visible = False
        frm_Tarea_1.txt_Id_Tarea13.Visible = False
        frm_Tarea_1.txt_Id_Tarea14.Visible = False
        frm_Tarea_1.txt_Id_Tarea15.Visible = False
        frm_Tarea_1.txt_Id_Tarea16.Visible = False
        frm_Tarea_1.txt_Id_Tarea17.Visible = False
        frm_Tarea_1.txt_Id_Tarea18.Visible = False
        frm_Tarea_1.txt_Id_Tarea19.Visible = False
        frm_Tarea_1.txt_Id_Tarea20.Visible = False
    End Sub

    Sub HabilitarBotonNumeroOrden1()
        frm_Tarea_1.btnBuscar_Numero_Orden1.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden2.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden3.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden4.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden5.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden6.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden7.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden8.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden9.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden10.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden11.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden12.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden13.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden14.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden15.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden16.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden17.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden18.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden19.Enabled = True
        frm_Tarea_1.btnBuscar_Numero_Orden20.Enabled = True
    End Sub

    Sub DemasCampos1()
        frm_Tarea_1.txt_Carga_Horaria1.Enabled = False
        frm_Tarea_1.txt_id_colaborador.Visible = False
        frm_Tarea_1.Label1.Visible = False
        frm_Tarea_1.txt_nombre_colaborador.Enabled = False
        frm_Tarea_1.txt_id_tarea.Visible = False
        Label1.Visible = False
        frm_Tarea_1.dtpFecha.Text = Now
        frm_Tarea_1.btnBuscar_Colaborador.Focus()
        frm_Tarea_1.btnBuscar_Colaborador.Visible = True
        frm_Tarea_1.btnNueva_Tarea.Visible = False
        frm_Tarea_1.btnImprimirFormulario.Visible = False
        frm_Tarea_1.btnGuardar_Tarea.Visible = True
        frm_Tarea_1.btnCancelar_Tarea.Visible = True
        frm_Tarea_1.btnBuscar_Colaborador.Enabled = True
        frm_Tarea_1.btnActualizar.Enabled = False
    End Sub

    Private Sub AltaTareaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaTareaToolStripMenuItem.Click

        frm_Tarea.Text = "Nueva Tarea"
        LimpiarDetalleTarea()
        HabilitarDetalleTarea()
        LimpiarTiempoEstimado()
        LimpiarTiempoReal()
        HabilitarTiempoReal()
        LimpiarHoraFinalizacion()
        HabilitarHoraFinalizacion()
        LimipiarObservaciones()
        HabilitarObservaciones()
        LimpiarNumeroOrden()
        DeshabilitarNumeroOrden()
        OcultarIdOrden()
        OcultarIdTarea()
        HabilitarBotonNumeroOrden()
        DemasCampos()

        Dim CargaColaborador = (From sec In datacontext.SECTOR
                     Join col In datacontext.COLABORADOR
                     On col.SEC_id_sector Equals sec.SEC_id_sector
                     Join usu In datacontext.USUARIO
                     On usu.COL_id_colaborador Equals col.COL_id_colaborador
                     Select usu.USU_usuario,
                     usu.USU_id_usuario,
                     col.COL_nombre_col,
                     col.COL_id_colaborador,
                     sec.SEC_id_sector,
                     sec.SEC_nombre_sector
                     Where USU_usuario = Me.LBL_MENU_USU.Text).ToList()(0)

        If CargaColaborador.SEC_nombre_sector <> "Offset" Then
            frm_Tarea.MdiParent = Me
            frm_Tarea.Show()
            frm_Tarea.txt_id_colaborador.Text = CargaColaborador.COL_id_colaborador.ToString
            frm_Tarea.txt_nombre_colaborador.Text = CargaColaborador.COL_nombre_col.ToString
        Else
            frm_Tarea.MdiParent = Me
            frm_Tarea.Show()
            frm_Tarea.txt_id_colaborador.Text = CargaColaborador.COL_id_colaborador.ToString
            frm_Tarea.txt_nombre_colaborador.Text = CargaColaborador.COL_nombre_col.ToString
            frm_Tarea.MaximizeBox = False

            frm_Tarea_1.MdiParent = Me
            frm_Tarea_1.Show()
            frm_Tarea_1.MaximizeBox = False

            LimpiarDetalleTarea1()
            HabilitarDetalleTarea1()
            LimpiarTiempoEstimado1()
            LimpiarTiempoReal1()
            HabilitarTiempoReal1()
            LimpiarHoraFinalizacion1()
            HabilitarHoraFinalizacion1()
            LimipiarObservaciones1()
            HabilitarObservaciones1()
            LimpiarNumeroOrden1()
            DeshabilitarNumeroOrden1()
            OcultarIdOrden1()
            OcultarIdTarea1()
            HabilitarBotonNumeroOrden1()
            DemasCampos1()
        End If
    End Sub

    Private Sub ListaTareaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaTareaToolStripMenuItem.Click

        frm_Listado_Tareas.Text = "Modificar Tarea"
        frm_Listado_Tareas.btnEliminar_Tarea.Enabled = False
        ' frm_Tarea.btnImprimirFormulario.Enabled = False
        frm_Listado_Tareas.btnVer.Enabled = False
        '  If frm_Listado_Tareas.cbo_sector.SelectedIndex = 0 Then
        'MsgBox("Debe seleccionar un sector")
        '  Exit Sub
        ' Else
        frm_Listado_Tareas.btnAgregar.Enabled = False
        ' End If
        frm_Listado_Tareas.btnExportarListado.Enabled = False
        frm_Listado_Tareas.dtpFecha.Text = Now
        frm_Listado_Tareas.btnAgregar.Enabled = True
        frm_Listado_Tareas.ShowDialog()
    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoClienteToolStripMenuItem.Click

        frm_Cliente.Text = "Nuevo Cliente"
        frm_Cliente.txt_razonsocial_cliente.Clear()
        frm_Cliente.txt_mail_cliente.Clear()
        frm_Cliente.txt_Domicilio_Cliente.Clear()
        frm_Cliente.txt_Localidad_Cliente.Clear()
        frm_Cliente.txt_Codigo_Postal_Cliente.Clear()
        frm_Cliente.txtTelefono_Cliente.Clear()

        frm_Cliente.txt_razonsocial_cliente.Enabled = True
        frm_Cliente.txt_mail_cliente.Enabled = True
        frm_Cliente.txt_Domicilio_Cliente.Enabled = True
        frm_Cliente.txt_Localidad_Cliente.Enabled = True
        frm_Cliente.txt_Codigo_Postal_Cliente.Enabled = True
        frm_Cliente.txtTelefono_Cliente.Enabled = True

        frm_Cliente.txt_Buscar_Cliente.Enabled = False

        frm_Cliente.btnNuevo_Cliente.Visible = False
        frm_Cliente.btnGuardar_Cliente.Enabled = True
        frm_Cliente.btnActualizar_Cliente.Enabled = False
        frm_Cliente.btnCancelar_Cliente.Enabled = True
        frm_Cliente.btnEliminar_Cliente.Enabled = False

        frm_Cliente.GroupListadoClientes.Enabled = False

        frm_Cliente.dgvLista_Clientes.ClearSelection()
        frm_Cliente.dgvLista_Clientes.Enabled = False

        frm_Cliente.ShowDialog()
    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarClienteToolStripMenuItem.Click

        frm_Cliente.Text = "Modificar Cliente"
        frm_Cliente.txt_razonsocial_cliente.Clear()
        frm_Cliente.txt_mail_cliente.Clear()
        frm_Cliente.txt_Domicilio_Cliente.Clear()
        frm_Cliente.txt_Localidad_Cliente.Clear()
        frm_Cliente.txt_Codigo_Postal_Cliente.Clear()
        frm_Cliente.txtTelefono_Cliente.Clear()

        frm_Cliente.txt_razonsocial_cliente.Enabled = True
        frm_Cliente.txt_mail_cliente.Enabled = True
        frm_Cliente.txt_Domicilio_Cliente.Enabled = True
        frm_Cliente.txt_Localidad_Cliente.Enabled = True
        frm_Cliente.txt_Codigo_Postal_Cliente.Enabled = True
        frm_Cliente.txtTelefono_Cliente.Enabled = True

        frm_Cliente.txt_Buscar_Cliente.Enabled = True

        frm_Cliente.btnNuevo_Cliente.Visible = False
        frm_Cliente.btnGuardar_Cliente.Enabled = False
        frm_Cliente.btnActualizar_Cliente.Enabled = True
        frm_Cliente.btnCancelar_Cliente.Enabled = True
        frm_Cliente.btnEliminar_Cliente.Enabled = False

        frm_Cliente.dgvLista_Clientes.ClearSelection()
        frm_Cliente.dgvLista_Clientes.Enabled = False

        frm_Cliente.ShowDialog()
    End Sub

    Private Sub EliminarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarClienteToolStripMenuItem.Click

        frm_Cliente.Text = "Eliminar Cliente"
        frm_Cliente.txt_razonsocial_cliente.Clear()
        frm_Cliente.txt_mail_cliente.Clear()
        frm_Cliente.txt_Domicilio_Cliente.Clear()
        frm_Cliente.txt_Localidad_Cliente.Clear()
        frm_Cliente.txt_Codigo_Postal_Cliente.Clear()
        frm_Cliente.txtTelefono_Cliente.Clear()

        frm_Cliente.txt_razonsocial_cliente.Enabled = False
        frm_Cliente.txt_mail_cliente.Enabled = False
        frm_Cliente.txt_Domicilio_Cliente.Enabled = False
        frm_Cliente.txt_Localidad_Cliente.Enabled = False
        frm_Cliente.txt_Codigo_Postal_Cliente.Enabled = False
        frm_Cliente.txtTelefono_Cliente.Enabled = False

        frm_Cliente.txt_Buscar_Cliente.Enabled = True

        frm_Cliente.btnNuevo_Cliente.Visible = False
        frm_Cliente.btnGuardar_Cliente.Enabled = False
        frm_Cliente.btnActualizar_Cliente.Enabled = False
        frm_Cliente.btnCancelar_Cliente.Enabled = True
        frm_Cliente.btnEliminar_Cliente.Enabled = True

        frm_Cliente.dgvLista_Clientes.ClearSelection()
        frm_Cliente.dgvLista_Clientes.Enabled = False

        frm_Cliente.ShowDialog()
    End Sub

    Private Sub ConsultarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarClienteToolStripMenuItem.Click

        frm_Cliente.Text = "Consultar Cliente"
        frm_Cliente.txt_razonsocial_cliente.Clear()
        frm_Cliente.txt_mail_cliente.Clear()
        frm_Cliente.txt_Domicilio_Cliente.Clear()
        frm_Cliente.txt_Localidad_Cliente.Clear()
        frm_Cliente.txt_Codigo_Postal_Cliente.Clear()
        frm_Cliente.txtTelefono_Cliente.Clear()

        frm_Cliente.txt_razonsocial_cliente.Enabled = False
        frm_Cliente.txt_mail_cliente.Enabled = False
        frm_Cliente.txt_Domicilio_Cliente.Enabled = False
        frm_Cliente.txt_Localidad_Cliente.Enabled = False
        frm_Cliente.txt_Codigo_Postal_Cliente.Enabled = False
        frm_Cliente.txtTelefono_Cliente.Enabled = False

        frm_Cliente.txt_Buscar_Cliente.Enabled = True

        frm_Cliente.btnNuevo_Cliente.Visible = False
        frm_Cliente.btnGuardar_Cliente.Enabled = False
        frm_Cliente.btnActualizar_Cliente.Enabled = False
        frm_Cliente.btnCancelar_Cliente.Enabled = True
        frm_Cliente.btnEliminar_Cliente.Enabled = False

        frm_Cliente.dgvLista_Clientes.ClearSelection()
        frm_Cliente.dgvLista_Clientes.Enabled = False

        frm_Cliente.ShowDialog()

    End Sub

    Private Sub EliminarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarUsuarioToolStripMenuItem.Click
        frm_Usuario.Text = "Eliminar Usuario"
        frm_Usuario.GroupListadoUsuarios.Enabled = True
        frm_Usuario.btnActualizar_Usuario.Enabled = False
        frm_Usuario.btnGuardar_Usuario.Enabled = False
        frm_Usuario.btnCancelar_Usuario.Enabled = True
        frm_Usuario.txt_usuario.Enabled = False
        frm_Usuario.txt_contraseña.Enabled = False
        frm_Usuario.cbo_perfil.Enabled = False
        frm_Usuario.btnBuscar_Colaborador.Enabled = False
        frm_Usuario.ShowDialog()
    End Sub

    Private Sub ConsultarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarUsuarioToolStripMenuItem.Click

        frm_Usuario.Text = "Consultar Usuario"
        frm_Usuario.btnActualizar_Usuario.Enabled = False
        frm_Usuario.btnEliminar_Usuario.Enabled = False
        frm_Usuario.btnGuardar_Usuario.Enabled = False
        frm_Usuario.btnNuevo_Usuario.Enabled = False
        frm_Usuario.txt_usuario.Enabled = False
        frm_Usuario.txt_contraseña.Enabled = False
        frm_Usuario.cbo_perfil.Enabled = False
        frm_Usuario.txt_nombre_colaborador.Enabled = False
        frm_Usuario.btnBuscar_Colaborador.Enabled = False
        frm_Usuario.dgvLista_Usuarios.ClearSelection()
        frm_Usuario.ShowDialog()
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_gestion_usuarios.ShowDialog()
    End Sub

    Private Sub NuevoColaboradorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoColaboradorToolStripMenuItem.Click
        frm_Colaborador.Text = "Nuevo Colaborador"
        frm_Colaborador.txt_nombre_colaborador.Focus()
        frm_Colaborador.txt_nombre_colaborador.Clear()
        frm_Colaborador.txt_apellido_colaborador.Clear()
        frm_Colaborador.cbo_sector.SelectedIndex = -1
        frm_Colaborador.btnNuevo_Colaborador.Visible = False
        frm_Colaborador.btnGuardar_Colaborador.Enabled = True
        frm_Colaborador.btnActualizar_Colaborador.Enabled = False
        frm_Colaborador.btnCancelar_Colaborador.Enabled = True
        frm_Colaborador.btn_enviar_mensaje.Enabled = False
        ' frm_Colaborador.btnImprimir.Visible = False
        frm_Colaborador.txt_Buscar_Colaborador.Enabled = False
        frm_Colaborador.btnEliminar_Colaborador.Enabled = False
        '  frm_Colaborador.btnImprimir.Visible = False
        frm_Colaborador.dgvLista_Colaboradores.ClearSelection()
        frm_Colaborador.dgvLista_Colaboradores.Enabled = False
        frm_Colaborador.GroupListadoColaboradores.Enabled = False

        frm_Colaborador.btn_enviar_mensaje.Visible = False
        frm_Colaborador.btn_Respuesta_Fecha.Visible = False
        frm_Colaborador.btn_Ver_Respuesta.Visible = False

        frm_Colaborador.quienllamo_col = Me
        frm_Colaborador.ShowDialog()
    End Sub

    Private Sub ModificarColaboradorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarColaboradorToolStripMenuItem.Click
        frm_Colaborador.Text = "Modificar Colaborador"

        frm_Colaborador.txt_nombre_colaborador.Focus()
        frm_Colaborador.txt_nombre_colaborador.Clear()
        frm_Colaborador.txt_apellido_colaborador.Clear()
        frm_Colaborador.cbo_sector.SelectedIndex = -1
        frm_Colaborador.btnNuevo_Colaborador.Visible = False
        frm_Colaborador.btnGuardar_Colaborador.Enabled = False
        frm_Colaborador.btnActualizar_Colaborador.Enabled = True
        frm_Colaborador.btnCancelar_Colaborador.Enabled = True
        frm_Colaborador.txt_Buscar_Colaborador.Enabled = True
        frm_Colaborador.btnEliminar_Colaborador.Enabled = False
        frm_Colaborador.btn_enviar_mensaje.Enabled = False
        '   frm_Colaborador.btnImprimir.Visible = False
        frm_Colaborador.dgvLista_Colaboradores.Enabled = False
        '   frm_Colaborador.btnImprimir.Visible = False
        frm_Colaborador.dgvLista_Colaboradores.ClearSelection()

        frm_Colaborador.btn_enviar_mensaje.Visible = False
        frm_Colaborador.btn_Respuesta_Fecha.Visible = False
        frm_Colaborador.btn_Ver_Respuesta.Visible = False

        frm_Colaborador.quienllamo_col = Me
        frm_Colaborador.ShowDialog()
    End Sub

    Private Sub EliminarColaboradorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarColaboradorToolStripMenuItem.Click

        frm_Colaborador.Text = "Eliminar Colaborador"
        frm_Colaborador.txt_nombre_colaborador.Enabled = False
        frm_Colaborador.txt_nombre_colaborador.Enabled = False
        frm_Colaborador.txt_apellido_colaborador.Enabled = False
        frm_Colaborador.cbo_sector.Enabled = False
        frm_Colaborador.btnNuevo_Colaborador.Visible = False
        frm_Colaborador.btnGuardar_Colaborador.Enabled = False
        frm_Colaborador.btnActualizar_Colaborador.Enabled = False
        frm_Colaborador.btnCancelar_Colaborador.Enabled = True
        frm_Colaborador.txt_Buscar_Colaborador.Enabled = True
        frm_Colaborador.btnEliminar_Colaborador.Enabled = True
        frm_Colaborador.dgvLista_Colaboradores.Enabled = True
        frm_Colaborador.btn_enviar_mensaje.Enabled = False
        '   frm_Colaborador.btnImprimir.Visible = False
        frm_Colaborador.dgvLista_Colaboradores.ClearSelection()

        frm_Colaborador.btn_enviar_mensaje.Visible = False
        frm_Colaborador.btn_Respuesta_Fecha.Visible = False
        frm_Colaborador.btn_Ver_Respuesta.Visible = False
        frm_Colaborador.quienllamo_col = Me
        frm_Colaborador.ShowDialog()
    End Sub

    Private Sub ConsultarColaboradorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarColaboradorToolStripMenuItem.Click
        If LBL_MENU_PERFIL.Text <> "ADMINISTRADOR" Then
            frm_Colaborador.btn_enviar_mensaje.Enabled = False
            frm_Colaborador.btn_Respuesta_Fecha.Enabled = False
            frm_Colaborador.btn_Ver_Respuesta.Enabled = False

            frm_Colaborador.Text = "Consultar Colaborador"
            frm_Colaborador.txt_nombre_colaborador.Clear()
            frm_Colaborador.txt_apellido_colaborador.Clear()
            frm_Colaborador.cbo_sector.SelectedIndex = -1
            frm_Colaborador.btnActualizar_Colaborador.Enabled = False
            frm_Colaborador.btnEliminar_Colaborador.Enabled = False
            frm_Colaborador.btnGuardar_Colaborador.Enabled = False
            frm_Colaborador.btnNuevo_Colaborador.Visible = False
            '  frm_Colaborador.btnImprimir.Visible = False
            frm_Colaborador.txt_nombre_colaborador.Enabled = False
            frm_Colaborador.txt_apellido_colaborador.Enabled = False
            frm_Colaborador.cbo_sector.Enabled = False
            frm_Colaborador.txt_nombre_colaborador.Enabled = False
        Else
            frm_Colaborador.Text = "Consultar Colaborador"
            frm_Colaborador.txt_nombre_colaborador.Clear()
            frm_Colaborador.txt_apellido_colaborador.Clear()
            frm_Colaborador.cbo_sector.SelectedIndex = -1
            frm_Colaborador.btnActualizar_Colaborador.Enabled = False
            frm_Colaborador.btnEliminar_Colaborador.Enabled = False
            frm_Colaborador.btnGuardar_Colaborador.Enabled = False
            frm_Colaborador.btnNuevo_Colaborador.Visible = False
            '  frm_Colaborador.btnImprimir.Visible = False
            frm_Colaborador.txt_nombre_colaborador.Enabled = False
            frm_Colaborador.txt_apellido_colaborador.Enabled = False
            frm_Colaborador.cbo_sector.Enabled = False
            frm_Colaborador.txt_nombre_colaborador.Enabled = False
            ' frm_Colaborador.btnImprimir.Visible = True
        End If

        frm_Colaborador.quienllamo_col = Me
        frm_Colaborador.ShowDialog()
    End Sub

    Private Sub NuevoVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoVendedorToolStripMenuItem.Click
        frm_Vendedor.Text = "Nuevo Vendedor"
        frm_Vendedor.txt_nombre_vendedor.Focus()
        frm_Vendedor.txt_nombre_vendedor.Clear()
        frm_Vendedor.txt_apellido_vendedor.Clear()
        frm_Vendedor.txt_mail_vendedor.Clear()
        frm_Vendedor.txt_telefono_vendedor.Clear()
        frm_Vendedor.btnNuevo_Vendedor.Visible = False
        frm_Vendedor.btnGuardar_Vendedor.Enabled = True
        frm_Vendedor.btnActualizar_Vendedor.Enabled = False
        frm_Vendedor.btnCancelar_Vendedor.Enabled = True
        frm_Vendedor.GroupListadoVendedor.Enabled = False
        frm_Vendedor.txt_Buscar_vendedor.Enabled = False
        frm_Vendedor.btnEliminar_vendedor.Enabled = False
        frm_Vendedor.dgvLista_vendedores.ClearSelection()
        frm_Vendedor.dgvLista_vendedores.Enabled = False


        frm_Vendedor.ShowDialog()
    End Sub

    Private Sub ModificarVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarVendedorToolStripMenuItem.Click
        frm_Vendedor.Text = "Modificar Vendedor"
        frm_Vendedor.txt_nombre_vendedor.Clear()
        frm_Vendedor.txt_apellido_vendedor.Clear()
        frm_Vendedor.txt_mail_vendedor.Clear()
        frm_Vendedor.txt_telefono_vendedor.Clear()
        frm_Vendedor.btnNuevo_Vendedor.Visible = False
        frm_Vendedor.btnGuardar_Vendedor.Enabled = False
        frm_Vendedor.btnActualizar_Vendedor.Enabled = True
        frm_Vendedor.btnCancelar_Vendedor.Enabled = True

        frm_Vendedor.txt_Buscar_vendedor.Enabled = True
        frm_Vendedor.btnEliminar_vendedor.Enabled = False
        frm_Vendedor.dgvLista_vendedores.Enabled = True
        frm_Vendedor.dgvLista_vendedores.ClearSelection()
        frm_Vendedor.ShowDialog()
    End Sub

    Private Sub EliminarVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarVendedorToolStripMenuItem.Click
        frm_Vendedor.Text = "Eliminar Vendedor"
        frm_Vendedor.txt_nombre_vendedor.Clear()
        frm_Vendedor.txt_nombre_vendedor.Enabled = False
        frm_Vendedor.txt_apellido_vendedor.Clear()
        frm_Vendedor.txt_apellido_vendedor.Enabled = False
        frm_Vendedor.txt_mail_vendedor.Clear()
        frm_Vendedor.txt_mail_vendedor.Enabled = False
        frm_Vendedor.txt_telefono_vendedor.Clear()
        frm_Vendedor.txt_telefono_vendedor.Enabled = False
        frm_Vendedor.btnNuevo_Vendedor.Visible = False
        frm_Vendedor.btnGuardar_Vendedor.Enabled = False
        frm_Vendedor.btnActualizar_Vendedor.Enabled = False
        frm_Vendedor.btnCancelar_Vendedor.Enabled = True

        frm_Vendedor.txt_Buscar_vendedor.Enabled = True
        frm_Vendedor.btnEliminar_vendedor.Enabled = True
        frm_Vendedor.dgvLista_vendedores.Enabled = True
        frm_Vendedor.dgvLista_vendedores.ClearSelection()
        frm_Vendedor.ShowDialog()
    End Sub

    Private Sub ConsultarVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarVendedorToolStripMenuItem.Click
        frm_Vendedor.Text = "Consultar Vendedor"
        frm_Vendedor.txt_nombre_vendedor.Clear()
        frm_Vendedor.txt_nombre_vendedor.Enabled = False
        frm_Vendedor.txt_apellido_vendedor.Clear()
        frm_Vendedor.txt_apellido_vendedor.Enabled = False
        frm_Vendedor.txt_mail_vendedor.Clear()
        frm_Vendedor.txt_mail_vendedor.Enabled = False
        frm_Vendedor.txt_telefono_vendedor.Clear()
        frm_Vendedor.txt_telefono_vendedor.Enabled = False
        frm_Vendedor.btnNuevo_Vendedor.Visible = False
        frm_Vendedor.btnGuardar_Vendedor.Enabled = False
        frm_Vendedor.btnActualizar_Vendedor.Enabled = False
        frm_Vendedor.btnCancelar_Vendedor.Enabled = True

        frm_Vendedor.txt_Buscar_vendedor.Enabled = True
        frm_Vendedor.btnEliminar_vendedor.Enabled = False
        frm_Vendedor.dgvLista_vendedores.Enabled = True
        frm_Vendedor.dgvLista_vendedores.ClearSelection()
        frm_Vendedor.ShowDialog()
    End Sub

    Private Sub NuevaPiezaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaPiezaToolStripMenuItem.Click
        frm_Pieza.Text = "Nueva Pieza"
        frm_Pieza.txt_nombre_pieza.Focus()
        frm_Pieza.txt_nombre_pieza.Clear()

        frm_Pieza.txt_nombre_pieza.Enabled = True
        frm_Pieza.txt_Buscar_Pieza.Enabled = False

        frm_Pieza.btnNuevo_Pieza.Visible = False
        frm_Pieza.btnGuardar_Pieza.Enabled = True
        frm_Pieza.btnActualizar_Pieza.Enabled = False
        frm_Pieza.btnCancelar_Pieza.Enabled = True
        frm_Pieza.btnEliminar_Pieza.Enabled = False
        frm_Pieza.GroupListadoPiezas.Enabled = False

        frm_Pieza.dgvLista_Piezas.ClearSelection()
        frm_Pieza.dgvLista_Piezas.Enabled = False
        frm_Pieza.ShowDialog()
    End Sub

    Private Sub ModificarPiezaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarPiezaToolStripMenuItem.Click
        frm_Pieza.Text = "Modificar Pieza"
        frm_Pieza.txt_nombre_pieza.Clear()

        frm_Pieza.txt_nombre_pieza.Enabled = True
        frm_Pieza.txt_Buscar_Pieza.Enabled = False

        frm_Pieza.btnNuevo_Pieza.Visible = False
        frm_Pieza.btnGuardar_Pieza.Enabled = False
        frm_Pieza.btnActualizar_Pieza.Enabled = True
        frm_Pieza.btnCancelar_Pieza.Enabled = True
        frm_Pieza.btnEliminar_Pieza.Enabled = False

        frm_Pieza.dgvLista_Piezas.ClearSelection()
        frm_Pieza.dgvLista_Piezas.Enabled = False

        frm_Pieza.ShowDialog()
    End Sub

    Private Sub EliminarPiezaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarPiezaToolStripMenuItem.Click

        frm_Pieza.Text = "Eliminar Pieza"
        frm_Pieza.txt_nombre_pieza.Clear()

        frm_Pieza.txt_nombre_pieza.Enabled = False
        frm_Pieza.txt_Buscar_Pieza.Enabled = True

        frm_Pieza.btnNuevo_Pieza.Visible = False
        frm_Pieza.btnGuardar_Pieza.Enabled = False
        frm_Pieza.btnActualizar_Pieza.Enabled = False
        frm_Pieza.btnCancelar_Pieza.Enabled = True
        frm_Pieza.btnEliminar_Pieza.Enabled = True

        frm_Pieza.dgvLista_Piezas.ClearSelection()
        frm_Pieza.dgvLista_Piezas.Enabled = False

        frm_Pieza.ShowDialog()
    End Sub

    Private Sub ConsultarPiezaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarPiezaToolStripMenuItem.Click

        frm_Pieza.Text = "Consultar Pieza"
        frm_Pieza.txt_nombre_pieza.Clear()

        frm_Pieza.txt_nombre_pieza.Enabled = False
        frm_Pieza.txt_Buscar_Pieza.Enabled = True

        frm_Pieza.btnNuevo_Pieza.Visible = False
        frm_Pieza.btnGuardar_Pieza.Enabled = False
        frm_Pieza.btnActualizar_Pieza.Enabled = False
        frm_Pieza.btnCancelar_Pieza.Enabled = True
        frm_Pieza.btnEliminar_Pieza.Enabled = False

        frm_Pieza.dgvLista_Piezas.ClearSelection()
        frm_Pieza.dgvLista_Piezas.Enabled = False

        frm_Pieza.ShowDialog()
    End Sub

    Private Sub NuevoSectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoSectorToolStripMenuItem.Click
        frm_Sector.Text = "Nuevo Sector"
        frm_Sector.GroupListadoSectores.Enabled = False
        frm_Sector.txt_nombre_sector.Clear()
        frm_Sector.txt_nombre_sector.Focus()

        frm_Sector.txt_nombre_sector.Enabled = True
        frm_Sector.txt_Buscar_Sector.Enabled = False

        frm_Sector.btnNuevo_Sector.Visible = False
        frm_Sector.btnGuardar_Sector.Enabled = True
        frm_Sector.btnActualizar_Sector.Enabled = False
        frm_Sector.btnCancelar_Sector.Enabled = True
        frm_Sector.btnEliminar_Sector.Enabled = False

        frm_Sector.dgvLista_Sector.ClearSelection()
        frm_Sector.dgvLista_Sector.Enabled = False

        frm_Sector.ShowDialog()
    End Sub

    Private Sub ModificarSectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarSectorToolStripMenuItem.Click

        frm_Sector.Text = "Modificar Sector"
        frm_Sector.txt_nombre_sector.Clear()
        frm_Sector.txt_nombre_sector.Focus()

        frm_Sector.txt_nombre_sector.Enabled = True
        frm_Sector.txt_Buscar_Sector.Enabled = True

        frm_Sector.btnNuevo_Sector.Visible = False
        frm_Sector.btnGuardar_Sector.Enabled = False
        frm_Sector.btnActualizar_Sector.Enabled = True
        frm_Sector.btnCancelar_Sector.Enabled = True
        frm_Sector.btnEliminar_Sector.Enabled = False

        frm_Sector.dgvLista_Sector.ClearSelection()
        frm_Sector.dgvLista_Sector.Enabled = False

        frm_Sector.ShowDialog()
    End Sub

    Private Sub EliminarSectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarSectorToolStripMenuItem.Click

        frm_Sector.Text = "Eliminar Sector"
        frm_Sector.txt_nombre_sector.Clear()
        frm_Sector.txt_nombre_sector.Focus()

        frm_Sector.txt_nombre_sector.Enabled = False
        frm_Sector.txt_Buscar_Sector.Enabled = True

        frm_Sector.btnNuevo_Sector.Visible = False
        frm_Sector.btnGuardar_Sector.Enabled = False
        frm_Sector.btnActualizar_Sector.Enabled = False
        frm_Sector.btnCancelar_Sector.Enabled = True
        frm_Sector.btnEliminar_Sector.Enabled = True

        frm_Sector.dgvLista_Sector.ClearSelection()
        frm_Sector.dgvLista_Sector.Enabled = True

        frm_Sector.ShowDialog()
    End Sub

    Private Sub ConsultarSectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarSectorToolStripMenuItem.Click

        frm_Sector.Text = "Consultar Sector"
        frm_Sector.txt_nombre_sector.Clear()
        frm_Sector.txt_nombre_sector.Focus()

        frm_Sector.txt_nombre_sector.Enabled = False
        frm_Sector.txt_Buscar_Sector.Enabled = True

        frm_Sector.btnNuevo_Sector.Visible = False
        frm_Sector.btnGuardar_Sector.Enabled = False
        frm_Sector.btnActualizar_Sector.Enabled = False
        frm_Sector.btnCancelar_Sector.Enabled = True
        frm_Sector.btnEliminar_Sector.Enabled = False

        frm_Sector.dgvLista_Sector.ClearSelection()
        frm_Sector.Enabled = True

        frm_Sector.ShowDialog()
    End Sub

    Private Sub EliminarTareaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarTareaToolStripMenuItem.Click

        frm_Listado_Tareas.Text = "Eliminar Tarea"
        frm_Listado_Tareas.btnModificar_Una.Enabled = False
        frm_Listado_Tareas.btnAgregar.Enabled = False
        frm_Listado_Tareas.btnVer.Enabled = False
        frm_Listado_Tareas.btnExportarListado.Enabled = False
        frm_Listado_Tareas.btnModificarTodas.Enabled = False
        frm_Listado_Tareas.dtpFecha.Text = Now

        frm_Listado_Tareas.ShowDialog()
    End Sub

    Private Sub TareaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Listado_Tareas.ShowDialog()
        frm_Listado_Tareas.Text = "Modificar Tarea"
        frm_Listado_Tareas.btnEliminar_Tarea.Enabled = False

    End Sub

    Private Sub ConsultarTareaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarTareaToolStripMenuItem.Click

        frm_Listado_Tareas.Text = "Consultar Tarea"
        frm_Listado_Tareas.btnModificar_Una.Enabled = False
        frm_Listado_Tareas.btnEliminar_Tarea.Enabled = False
        frm_Listado_Tareas.btnAgregar.Enabled = False
        frm_Listado_Tareas.dtpFecha.Text = Now
        frm_Listado_Tareas.btnModificarTodas.Enabled = False
        frm_Listado_Tareas.ShowDialog()
    End Sub

    Public Sub DiaAnterior()
        'PROCEDIMIENTO QUE SE CREO PARA EL CORRECTO INGRESO DE LA FECHA DE ENTREGA, ESTE MUESTRA EL DIA ANTERIOR AL ABRIR EL FORMULARIO DE LA ORDEN
        frm_Orden_Trabajo.dtpFecha_Entrega.Value = Today
        frm_Orden_Trabajo.dtpFecha_Entrega.Value = frm_Orden_Trabajo.dtpFecha_Entrega.Value.Add(TimeSpan.FromDays(-1))
    End Sub

    Private Sub NuevaOrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaOrdenToolStripMenuItem.Click

        DiaAnterior()
        frm_Orden_Trabajo.quienllamo_listado_orden = Me
        frm_Orden_Trabajo.Text = "Nueva Orden"

        frm_Orden_Trabajo.txtid_vendedor.Visible = False
        frm_Orden_Trabajo.txt_id_cliente.Visible = False
        frm_Orden_Trabajo.dtpFecha_Orden_Trabajo.Enabled = False

        frm_Orden_Trabajo.Label45.Visible = False
        frm_Orden_Trabajo.txt_id_detalle_orden_trabajo1.Visible = False
        frm_Orden_Trabajo.Label52.Visible = False
        frm_Orden_Trabajo.txt_id_detalle_orden_trabajo2.Visible = False
        frm_Orden_Trabajo.Label53.Visible = False
        frm_Orden_Trabajo.txt_id_detalle_orden_trabajo3.Visible = False

        frm_Orden_Trabajo.cboTipo_Orden.SelectedIndex = -1

        frm_Orden_Trabajo.txtNumero_Orden_Trabajo.Clear()
        frm_Orden_Trabajo.txt_observaciones.Clear()
        frm_Orden_Trabajo.txt_mejoras.Clear()
        frm_Orden_Trabajo.txtNombre_vendedor.Clear()
        frm_Orden_Trabajo.txtid_vendedor.Clear()
        frm_Orden_Trabajo.txt_nombre_cliente.Clear()
        frm_Orden_Trabajo.txt_id_cliente.Clear()

        frm_Orden_Trabajo.txt_cantidad1_detalle1.Clear()
        frm_Orden_Trabajo.cboPiezas1_Detalle1.SelectedIndex = -1
        frm_Orden_Trabajo.txtTamaño1_Detalle1.Clear()
        frm_Orden_Trabajo.cboTipoImpresion1_Detalle1.SelectedIndex = -1

        frm_Orden_Trabajo.txt_Papel1_Soporte1.Clear()
        frm_Orden_Trabajo.txt_Papel2_Soporte1.Clear()
        frm_Orden_Trabajo.txt_Papel3_Soporte1.Clear()
        frm_Orden_Trabajo.txt_Gramaje1_Soporte1.Clear()
        frm_Orden_Trabajo.txt_Gramaje2_Soporte1.Clear()
        frm_Orden_Trabajo.txt_Gramaje3_Soporte1.Clear()
        frm_Orden_Trabajo.txt_Cantidad1_Soporte1.Clear()
        frm_Orden_Trabajo.txt_Cantidad2_Soporte1.Clear()
        frm_Orden_Trabajo.txt_Cantidad3_Soporte1.Clear()
        frm_Orden_Trabajo.cboFormato1_Soporte1.SelectedIndex = -1
        frm_Orden_Trabajo.cboFormato2_Soporte1.SelectedIndex = -1
        frm_Orden_Trabajo.cboFormato3_Soporte1.SelectedIndex = -1

        frm_Orden_Trabajo.txt_cantidad2_detalle2.Clear()
        frm_Orden_Trabajo.cboPiezas2_Detalle2.SelectedIndex = -1
        frm_Orden_Trabajo.txtTamaño2_Detalle2.Clear()
        frm_Orden_Trabajo.cboTipoImpresion2_Detalle2.SelectedIndex = -1

        frm_Orden_Trabajo.txt_Papel1_Soporte2.Clear()
        frm_Orden_Trabajo.txt_Papel2_Soporte2.Clear()
        frm_Orden_Trabajo.txt_Papel3_Soporte2.Clear()
        frm_Orden_Trabajo.txt_Gramaje1_Soporte2.Clear()
        frm_Orden_Trabajo.txt_Gramaje2_Soporte2.Clear()
        frm_Orden_Trabajo.txt_Gramaje3_Soporte2.Clear()
        frm_Orden_Trabajo.txt_Cantidad1_Soporte2.Clear()
        frm_Orden_Trabajo.txt_Cantidad2_Soporte2.Clear()
        frm_Orden_Trabajo.txt_Cantidad3_Soporte2.Clear()
        frm_Orden_Trabajo.cboFormato1_Soporte2.SelectedIndex = -1
        frm_Orden_Trabajo.cboFormato2_Soporte2.SelectedIndex = -1
        frm_Orden_Trabajo.cboFormato3_Soporte2.SelectedIndex = -1

        frm_Orden_Trabajo.txt_cantidad3_detalle3.Clear()
        frm_Orden_Trabajo.cboPiezas3_Detalle3.SelectedIndex = -1
        frm_Orden_Trabajo.txtTamaño3_Detalle3.Clear()
        frm_Orden_Trabajo.cboTipoImpresion3_Detalle3.SelectedIndex = -1

        frm_Orden_Trabajo.txt_Papel1_Soporte3.Clear()
        frm_Orden_Trabajo.txt_Papel2_Soporte3.Clear()
        frm_Orden_Trabajo.txt_Papel3_Soporte3.Clear()
        frm_Orden_Trabajo.txt_Gramaje1_Soporte3.Clear()
        frm_Orden_Trabajo.txt_Gramaje2_Soporte3.Clear()
        frm_Orden_Trabajo.txt_Gramaje3_Soporte3.Clear()
        frm_Orden_Trabajo.txt_Cantidad1_Soporte3.Clear()
        frm_Orden_Trabajo.txt_Cantidad2_Soporte3.Clear()
        frm_Orden_Trabajo.txt_Cantidad3_Soporte3.Clear()
        frm_Orden_Trabajo.cboFormato1_Soporte3.SelectedIndex = -1
        frm_Orden_Trabajo.cboFormato2_Soporte3.SelectedIndex = -1
        frm_Orden_Trabajo.cboFormato3_Soporte3.SelectedIndex = -1

        frm_Orden_Trabajo.txt_id_orden_trabajo.Enabled = False
        frm_Orden_Trabajo.txtNombre_vendedor.Enabled = False
        frm_Orden_Trabajo.txt_nombre_cliente.Enabled = False

        frm_Orden_Trabajo.btnBuscar_Vendedor.Enabled = True
        frm_Orden_Trabajo.btnBuscar_cliente.Enabled = True
        frm_Orden_Trabajo.btnProceso1.Enabled = True
        frm_Orden_Trabajo.btnProceso2.Enabled = True
        frm_Orden_Trabajo.btnProceso3.Enabled = True
        frm_Orden_Trabajo.btnNueva_Orden_Trabajo.Visible = False
        frm_Orden_Trabajo.btnImprimirFormulario.Enabled = False
        frm_Orden_Trabajo.btnGuardar_Orden_Trabajo.Enabled = True
        frm_Orden_Trabajo.btnActualizar_Orden_Trabajo.Enabled = False
        frm_Orden_Trabajo.btnCancelar_Orden_Trabajo.Enabled = True

        frm_Orden_Trabajo.MdiParent = Me
        frm_Orden_Trabajo.Show()
    End Sub

    Private Sub OrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Listado_Orden_Trabajo.ShowDialog()
    End Sub

    Private Sub DetalleDeOrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Listado_Orden_Trabajo.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click

        frm_Listado_Orden_Trabajo.Text = "Consultar Orden / Producto / Proceso"

        frm_Listado_Orden_Trabajo.btnModificar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnEliminar_Producto.Enabled = False
        frm_Listado_Orden_Trabajo.btnVer.Enabled = True
        frm_Listado_Orden_Trabajo.btnVer.Visible = True
        frm_Listado_Orden_Trabajo.btn_Cancelar.Enabled = True
        frm_Listado_Orden_Trabajo.txt_Buscar_orden_trabajo.Enabled = True
        frm_Listado_Orden_Trabajo.btnModificarProducto.Enabled = False
        frm_Listado_Orden_Trabajo.btnModificarProceso.Enabled = False
        frm_Listado_Orden_Trabajo.btnEliminarProceso.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.ClearSelection()

        frm_Listado_Orden_Trabajo.MdiParent = Me
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.dgvLista_Orden_Trabajo.ClearSelection()
        frm_Listado_Orden_Trabajo.txt_Buscar_orden_trabajo.Focus()
    End Sub

    Private Sub ModificarOrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarOrdenToolStripMenuItem.Click

        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me

        frm_Listado_Orden_Trabajo.Text = "Modificar Orden / Producto / Proceso"
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnEliminar_Producto.Enabled = False
        frm_Listado_Orden_Trabajo.btnVer.Enabled = False
        frm_Orden_Trabajo.btnActualizar_Orden_Trabajo.Enabled = True
        frm_Listado_Orden_Trabajo.txt_Buscar_orden_trabajo.Enabled = True
        frm_Listado_Orden_Trabajo.btnEliminarProceso.Enabled = False
        frm_Listado_Orden_Trabajo.btn_ODT_mostrar_listado_pdf.Enabled = False
        frm_Listado_Orden_Trabajo.btnModificar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnModificarProducto.Enabled = False
        frm_Listado_Orden_Trabajo.btnModificarProceso.Enabled = False
        frm_Listado_Orden_Trabajo.MdiParent = Me
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.dgvLista_Orden_Trabajo.ClearSelection()
        frm_Listado_Orden_Trabajo.txt_Buscar_orden_trabajo.Focus()
    End Sub

    Private Sub EliminarOrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarOrdenToolStripMenuItem.Click

        frm_Listado_Orden_Trabajo.Text = "Eliminar Orden / Producto / Proceso"
        frm_Listado_Orden_Trabajo.txt_Buscar_orden_trabajo.Enabled = True

        frm_Listado_Orden_Trabajo.btnModificar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnModificarProducto.Enabled = False
        frm_Listado_Orden_Trabajo.btnModificarProceso.Enabled = False
        frm_Listado_Orden_Trabajo.btnVer.Enabled = False
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnEliminar_Producto.Enabled = False
        frm_Listado_Orden_Trabajo.btnEliminarProceso.Enabled = False
        frm_Listado_Orden_Trabajo.btn_Cancelar.Enabled = True
        frm_Listado_Orden_Trabajo.btn_ODT_mostrar_listado_pdf.Enabled = False
        frm_Listado_Orden_Trabajo.dgvLista_Orden_Trabajo.ClearSelection()

        frm_Listado_Orden_Trabajo.ShowDialog()
        frm_Listado_Orden_Trabajo.dgvLista_Orden_Trabajo.ClearSelection()
        frm_Listado_Orden_Trabajo.txt_Buscar_orden_trabajo.Focus()


    End Sub

    Private Sub NuevoRetrabajoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_retrabajo.Text = "Nuevo Re-Trabajo"
        frm_retrabajo.btnImprimirFormulario.Enabled = False
        frm_retrabajo.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Listado_Retrabajo.Text = "Eliminar Re-Trabajo"
        frm_Listado_Retrabajo.btnExportarPDF.Enabled = False
        frm_Listado_Retrabajo.btnVer.Enabled = False
        frm_Listado_Retrabajo.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Listado_Retrabajo.Text = "Consultar Re-Trabajo"
        frm_Listado_Retrabajo.btnExportarPDF.Enabled = True
        frm_Listado_Retrabajo.btnEliminar_ReTrabajo.Enabled = False
        frm_Listado_Retrabajo.ShowDialog()
    End Sub

    Private Sub EtiquetasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtiquetasToolStripMenuItem.Click
        frm_Etiqueta_Modelo_1.ShowDialog()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click

        frm_Productos.Text = "Nuevo Producto"
        frm_Productos.dgvLista_Productos.ClearSelection()
        frm_Productos.GroupBox2.Enabled = False

        frm_Productos.tb_prod_id.Visible = False
        frm_Productos.Label1.Visible = False

        frm_Productos.tb_prod_codigo.Clear()
        frm_Productos.tb_prod_descripcion.Clear()
        frm_Productos.tb_prod_stock_minimo.Clear()
        frm_Productos.tb_prod_stock.Clear()
        frm_Productos.tb_prod_busqueda.Clear()

        frm_Productos.btn_prod_guardar.Enabled = True
        frm_Productos.btn_prod_actualizar.Enabled = False
        frm_Productos.btn_prod_cancelar.Enabled = True
        frm_Productos.btn_prod_eliminar.Enabled = False
        frm_Productos.btnExportarPDF.Enabled = False
        frm_Productos.btn_Exportar_Excel.Enabled = False
        frm_Productos.cboDeposito.SelectedIndex = 0
        frm_Productos.ShowDialog()

        frm_Productos.rbtProducto.Checked = False

    End Sub

    Private Sub ModificarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click

        frm_Productos.Text = "Modificar Producto"
        frm_Productos.GroupBox2.Enabled = True
        frm_Productos.tb_prod_id.Visible = False
        frm_Productos.Label1.Visible = False

        frm_Productos.tb_prod_codigo.Clear()
        frm_Productos.tb_prod_descripcion.Clear()
        frm_Productos.tb_prod_stock_minimo.Clear()
        frm_Productos.tb_prod_stock.Clear()
        frm_Productos.tb_prod_busqueda.Clear()
        frm_Productos.tb_cod_busqueda.Enabled = False
        frm_Productos.tb_prod_busqueda.Enabled = False

        frm_Productos.btn_prod_guardar.Enabled = False
        frm_Productos.btn_prod_actualizar.Enabled = True
        frm_Productos.btn_prod_cancelar.Enabled = True
        frm_Productos.btn_prod_eliminar.Enabled = False
        frm_Productos.btnExportarPDF.Enabled = False
        frm_Productos.btn_Exportar_Excel.Enabled = False

        frm_Productos.dgvLista_Productos.ClearSelection()
        frm_Productos.dgvLista_Productos.Enabled = True
        frm_Productos.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem1.Click

        frm_Productos.Text = "Eliminar Producto"
        frm_Productos.dgvLista_Productos.ClearSelection()
        frm_Productos.GroupBox2.Enabled = True
        frm_Productos.tb_prod_id.Visible = False
        frm_Productos.Label1.Visible = False

        frm_Productos.tb_prod_codigo.Clear()
        frm_Productos.tb_prod_descripcion.Clear()
        frm_Productos.tb_prod_stock_minimo.Clear()
        frm_Productos.tb_prod_stock.Clear()
        frm_Productos.tb_prod_busqueda.Clear()

        frm_Productos.tb_prod_codigo.Enabled = False
        frm_Productos.tb_prod_descripcion.Enabled = False
        frm_Productos.tb_prod_stock_minimo.Enabled = False
        frm_Productos.tb_prod_stock.Enabled = False
        frm_Productos.tb_prod_busqueda.Enabled = True

        frm_Productos.btn_prod_guardar.Enabled = False
        frm_Productos.btn_prod_actualizar.Enabled = False
        frm_Productos.btn_prod_cancelar.Enabled = True
        frm_Productos.btn_prod_eliminar.Enabled = True
        frm_Productos.btnExportarPDF.Enabled = False
        frm_Productos.btn_Exportar_Excel.Enabled = False

        frm_Productos.dgvLista_Productos.Enabled = True
        frm_Productos.cboDeposito.Enabled = False
        frm_Productos.ShowDialog()
    End Sub


    Private Sub AltaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem1.Click

        frm_Movimiento_Producto.Text = "Alta de Productos"
        frm_Movimiento_Producto.GroupListadoProductos.Enabled = True
        frm_Movimiento_Producto.txt_Codigo.Focus()
        frm_Movimiento_Producto.txt_Codigo.Clear()
        frm_Movimiento_Producto.txt_descripcion.Clear()
        frm_Movimiento_Producto.txt_numero_orden.Clear()
        frm_Movimiento_Producto.txt_Cantidad.Clear()
        frm_Movimiento_Producto.txt_Buscar_Producto.Clear()

        frm_Movimiento_Producto.cbo_Tipo_Producto.SelectedIndex = 0
        frm_Movimiento_Producto.cbo_Tipo_Producto.Enabled = False

        frm_Movimiento_Producto.txt_Codigo.Enabled = False
        frm_Movimiento_Producto.txt_descripcion.Enabled = False
        frm_Movimiento_Producto.txt_numero_orden.Enabled = True
        frm_Movimiento_Producto.txt_Cantidad.Enabled = True
        frm_Movimiento_Producto.txt_Buscar_Producto.Enabled = True

        frm_Movimiento_Producto.btnBuscar_cliente.Enabled = True
        frm_Movimiento_Producto.btnCancelar.Enabled = True
        frm_Movimiento_Producto.btnEliminar.Enabled = False
        frm_Movimiento_Producto.btnIngresar_Stock.Enabled = True

        frm_Movimiento_Producto.ShowDialog()
    End Sub

    Private Sub BajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem1.Click
        frm_Movimiento_Producto.Text = "Baja de Productos"
        frm_Movimiento_Producto.GroupListadoProductos.Enabled = True
        frm_Movimiento_Producto.txt_Codigo.Clear()
        frm_Movimiento_Producto.txt_descripcion.Clear()
        frm_Movimiento_Producto.txt_numero_orden.Clear()
        frm_Movimiento_Producto.txt_Cantidad.Clear()
        frm_Movimiento_Producto.txt_Buscar_Producto.Clear()

        frm_Movimiento_Producto.cbo_Tipo_Producto.SelectedIndex = 1
        frm_Movimiento_Producto.cbo_Tipo_Producto.Enabled = False

        frm_Movimiento_Producto.txt_Codigo.Enabled = False
        frm_Movimiento_Producto.txt_descripcion.Enabled = False
        frm_Movimiento_Producto.txt_numero_orden.Enabled = True
        frm_Movimiento_Producto.txt_Cantidad.Enabled = True
        frm_Movimiento_Producto.txt_Buscar_Producto.Enabled = True

        frm_Movimiento_Producto.btnBuscar_cliente.Enabled = True
        frm_Movimiento_Producto.btnCancelar.Enabled = True
        frm_Movimiento_Producto.btnEliminar.Enabled = False
        frm_Movimiento_Producto.btnIngresar_Stock.Enabled = True

        frm_Movimiento_Producto.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem4.Click

        frm_Productos.Text = "Consultar Producto"
        frm_Productos.GroupBox2.Enabled = True
        frm_Productos.tb_prod_id.Visible = False
        frm_Productos.Label1.Visible = False

        frm_Productos.tb_prod_codigo.Clear()
        frm_Productos.tb_prod_descripcion.Clear()
        frm_Productos.tb_prod_stock_minimo.Clear()
        frm_Productos.tb_prod_stock.Clear()
        frm_Productos.tb_prod_busqueda.Clear()

        frm_Productos.tb_prod_codigo.Enabled = False
        frm_Productos.tb_prod_descripcion.Enabled = False
        frm_Productos.tb_prod_stock_minimo.Enabled = False
        frm_Productos.tb_prod_stock.Enabled = False
        frm_Productos.tb_prod_busqueda.Enabled = True

        frm_Productos.btn_prod_guardar.Enabled = False
        frm_Productos.btn_prod_actualizar.Enabled = False
        frm_Productos.btn_prod_cancelar.Enabled = True
        frm_Productos.btn_prod_eliminar.Enabled = False

        frm_Productos.dgvLista_Productos.Enabled = True

        frm_Productos.cboDeposito.Enabled = False
        'frm_Productos.rbtCodigo.Enabled = True

        frm_Productos.MdiParent = Me
        frm_Productos.Show()
        For Each row As DataGridViewRow In frm_Productos.dgvLista_Productos.Rows
            If row.Cells(3).Value <= row.Cells(4).Value Then
                row.DefaultCellStyle.BackColor = Color.Red
            End If
        Next
        frm_Productos.dgvLista_Productos.ClearSelection()
    End Sub

    Private Sub frm_Principal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub frm_Principal_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub ConsultarMovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarMovimientosToolStripMenuItem.Click
        frm_Listado_Movimientos.Text = "Consultar Movimiento"
        frm_Listado_Movimientos.MdiParent = Me
        frm_Listado_Movimientos.Show()
        frm_Listado_Movimientos.dgv_movimientos.ClearSelection()
    End Sub

    Private Sub frm_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        EstadisticasToolStripMenuItem.Visible = False
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is MdiClient Then
                'c.BackColor = Color.White
                'c.BackgroundImage = My.Resources.solucionesgraficas1
                c.BackgroundImage = My.Resources.Fondo_aplicacion
                '                c.BackgroundImageLayout = ImageLayout.Tile

                'c.BackgroundImageLayout = ImageLayout.Zoom
            End If
        Next
        AltaTareaToolStripMenuItem.Visible = False
        ListaTareaToolStripMenuItem.Visible = False
        EliminarTareaToolStripMenuItem.Visible = False
        ConsultarTareaToolStripMenuItem.Visible = False
    End Sub

    Public Sub mostrar_mensaje()
        'Se ejecuta al final de todo del boton ingresar del frm_ingreso

        'CARGA EN EL FORMULARIO MENSAJE LOS CAMPOS
        Try
            Dim UltimoMensaje = (From m In datacontext.MENSAJE
        Join u In datacontext.USUARIO
        On m.USU_id_usuario Equals u.USU_id_usuario
        Select m.MEN_id_mensaje,
        u.USU_usuario,
        u.USU_id_usuario,
        m.MEN_fecha_mensaje,
        m.MEN_titulo,
        m.MEN_comentario,
        m.MEN_respuesta,
        m.MEN_campo_1
        Where USU_usuario = LBL_MENU_USU.Text And MEN_respuesta.Length = 0
        Order By MEN_id_mensaje Descending).ToList()(0)

            If UltimoMensaje.MEN_respuesta.Length = 0 Then
                frm_Mensaje.txt_Titulo.Text = UltimoMensaje.MEN_titulo
                frm_Mensaje.dtp_fecha_pedido.Text = UltimoMensaje.MEN_fecha_mensaje
                frm_Mensaje.txt_comentario.Text = UltimoMensaje.MEN_comentario
                frm_Mensaje.txt_id_mensaje.Text = UltimoMensaje.MEN_id_mensaje
                frm_Mensaje.txt_nombre_usuario.Text = UltimoMensaje.USU_usuario
                Select Case UltimoMensaje.MEN_campo_1
                    Case "Cumple"
                        'frm_Mensaje.PictureBox1.Image = My.re
                End Select

                'QUITA LOS BOTONES DEL FORMULARIO
                frm_Mensaje.FormBorderStyle = Windows.Forms.FormBorderStyle.None

                frm_Mensaje.GroupComentario.Enabled = False
                frm_Mensaje.txt_id_usuario.Visible = False
                frm_Mensaje.txt_id_mensaje.Visible = False
                frm_Mensaje.Label1.Visible = False
                frm_Mensaje.Label18.Visible = False

                frm_Mensaje.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub TareasMensulesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Generar_Informe.MdiParent = Me
        frm_Generar_Informe.Show()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercadeToolStripMenuItem.Click
        frm_Acerca_de.ShowDialog()
    End Sub

    Private Sub CorreoElectrónicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorreoElectrónicoToolStripMenuItem.Click
        frm_Enviar_Correo.ShowDialog()
    End Sub

    Dim hora As Integer
    Dim minuto As Integer
    Dim tempcadena As String

    Private Sub Timer_automatico_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_automatico.Tick
        'hora = DateTime.Now.Hour
        'minuto = DateTime.Now.Minute
        'tempcadena = hora & ":" & minuto
        'If tempcadena = "16:15" Then
        '    Dim lanzar_automatico As New Automatico
        '    lanzar_automatico.informe_diario_tareas()
        'End If
    End Sub

    Private Sub OrdenAmpliadaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OrdenAmpliadaToolStripMenuItem.Click

        frm_Orden_Trabajo_Ampliada.quienllamo_listado_orden_ampliada = Me
        frm_Orden_Trabajo_Ampliada.Text = ".:. Nueva Orden .:."
        Campos_Orden_ampliada()
        frm_Orden_Trabajo_Ampliada.MdiParent = Me
        frm_Orden_Trabajo_Ampliada.Show()
        'FOCO
        frm_Orden_Trabajo_Ampliada.txtNumero_Orden_Trabajo.Focus()

    End Sub

    Sub Campos_Orden_ampliada()

        'FECHA DE ENTREGA ANTERIOR AL DIA DE LA FECHA 
        frm_Orden_Trabajo_Ampliada.dtpFecha_Entrega_ODT.Value = Today
        frm_Orden_Trabajo_Ampliada.dtpFecha_Entrega_ODT.Value = frm_Orden_Trabajo_Ampliada.dtpFecha_Entrega_ODT.Value.Add(TimeSpan.FromDays(-1))
        'DESHABILITAR Y OCULTAR CAMPOS
        frm_Orden_Trabajo_Ampliada.GroupBox4.Enabled = True
        frm_Orden_Trabajo_Ampliada.txt_id_cliente.Visible = False
        frm_Orden_Trabajo_Ampliada.txtid_vendedor.Visible = False
        frm_Orden_Trabajo_Ampliada.Label45.Visible = False
        frm_Orden_Trabajo_Ampliada.txt_id_detalle_orden_trabajo1.Visible = False
        frm_Orden_Trabajo_Ampliada.Label1.Visible = False
        frm_Orden_Trabajo_Ampliada.txt_id_orden_trabajo.Visible = False
        frm_Orden_Trabajo_Ampliada.Label8.Visible = False
        frm_Orden_Trabajo_Ampliada.cboTipo_Orden.Visible = False
        frm_Orden_Trabajo_Ampliada.GroupDigital.Enabled = False
        frm_Orden_Trabajo_Ampliada.GroupGranFormato.Enabled = False
        frm_Orden_Trabajo_Ampliada.groupOffset.Enabled = False
        frm_Orden_Trabajo_Ampliada.GroupProducto_Soportes.Enabled = False
        frm_Orden_Trabajo_Ampliada.GroupTerminacion.Enabled = False
        frm_Orden_Trabajo_Ampliada.txt_nombre_cliente.Enabled = False
        frm_Orden_Trabajo_Ampliada.txtNombre_vendedor.Enabled = False
        'COMBOS
        frm_Orden_Trabajo_Ampliada.cboTipo_Impresion_Digital.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboTipo_Impresion_Offset.SelectedIndex = -1
        'LIMPIAR CAMPOS
        frm_Orden_Trabajo_Ampliada.txtNumero_Orden_Trabajo.Clear()
        frm_Orden_Trabajo_Ampliada.txtNombre_vendedor.Clear()
        frm_Orden_Trabajo_Ampliada.txt_nombre_cliente.Clear()
        frm_Orden_Trabajo_Ampliada.txtid_vendedor.Clear()
        frm_Orden_Trabajo_Ampliada.txt_id_cliente.Clear()
        frm_Orden_Trabajo_Ampliada.cboDireccion_Entrega.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.txt_observaciones.Clear()
        frm_Orden_Trabajo_Ampliada.cboTipo_Orden.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.chkOffset.Checked = False
        frm_Orden_Trabajo_Ampliada.chkDigital.Checked = False
        frm_Orden_Trabajo_Ampliada.chkGranFormato.Checked = False
        frm_Orden_Trabajo_Ampliada.chkTerminacion.Checked = False
        frm_Orden_Trabajo_Ampliada.txt_id_orden_trabajo.Clear()
        frm_Orden_Trabajo_Ampliada.txt_id_detalle_orden_trabajo1.Clear()
        'PRODUCTO
        frm_Orden_Trabajo_Ampliada.txt_cantidad_producto.Clear()
        frm_Orden_Trabajo_Ampliada.cboPiezas_Producto.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.txtTamaño_Producto.Clear()
        frm_Orden_Trabajo_Ampliada.cboPapel1.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboPapel2.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboPapel3.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboGramaje1.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboGramaje2.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboGramaje3.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.txt_Cantidad_1_Pliego_Entero.Clear()
        frm_Orden_Trabajo_Ampliada.txt_Cantidad_2_Pliego_Entero.Clear()
        frm_Orden_Trabajo_Ampliada.txt_Cantidad_3_Pliego_Entero.Clear()
        frm_Orden_Trabajo_Ampliada.cboFormato_1_Pliego_Entero.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboFormato_2_Pliego_Entero.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboFormato_3_Pliego_Entero.SelectedIndex = -1
        'OFFSET
        frm_Orden_Trabajo_Ampliada.cboTipo_Impresion_Offset.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboImpresora_Offset.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboModo_Impresion_Offset.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboMarca_Offset.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.txtCantidad_1_Pliego_Maquina_Offset.Clear()
        frm_Orden_Trabajo_Ampliada.txtCantidad_2_Pliego_Maquina_Offset.Clear()
        frm_Orden_Trabajo_Ampliada.txtCantidad_3_Pliego_Maquina_Offset.Clear()
        frm_Orden_Trabajo_Ampliada.cboFormato_1_Pliego_Maquina_Offset.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboFormato_2_Pliego_Maquina_Offset.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboFormato_3_Pliego_Maquina_Offset.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.txt_chapa_soporte_1.Clear()
        frm_Orden_Trabajo_Ampliada.txt_chapa_soporte_2.Clear()
        frm_Orden_Trabajo_Ampliada.txt_chapa_soporte_3.Clear()
        'DIGITAL
        frm_Orden_Trabajo_Ampliada.cboTipo_Impresion_Digital.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.txtCantidad_1_Pliego_Maquina_Digital.Clear()
        frm_Orden_Trabajo_Ampliada.txtCantidad_2_Pliego_Maquina_Digital.Clear()
        frm_Orden_Trabajo_Ampliada.txtCantidad_3_Pliego_Maquina_Digital.Clear()
        frm_Orden_Trabajo_Ampliada.cboFormato_1_Pliego_Maquina_Digital.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboFormato_2_Pliego_Maquina_Digital.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboFormato_3_Pliego_Maquina_Digital.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.txtDato_Variable.Clear()
        'GRAN FORMATO
        frm_Orden_Trabajo_Ampliada.txt_cantidad_producto_Gran_Formato.Clear()
        frm_Orden_Trabajo_Ampliada.cboPiezas_Producto_Gran_Formato.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.txtTamaño_Producto_Gran_Formato.Clear()
        frm_Orden_Trabajo_Ampliada.cboMaterial.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboCalidad_Gran_Formato.SelectedIndex = -1
        frm_Orden_Trabajo_Ampliada.cboSistema_Gran_Formato.SelectedIndex = -1
        'TERMINACION
        frm_Orden_Trabajo_Ampliada.chkAdhesivado.Checked = False
        frm_Orden_Trabajo_Ampliada.chkBarniz.Checked = False
        frm_Orden_Trabajo_Ampliada.chkCocido.Checked = False
        frm_Orden_Trabajo_Ampliada.chkCuño.Checked = False
        frm_Orden_Trabajo_Ampliada.chkDoblado.Checked = False
        frm_Orden_Trabajo_Ampliada.chkEncuadernacion.Checked = False
        frm_Orden_Trabajo_Ampliada.chkFresado.Checked = False
        frm_Orden_Trabajo_Ampliada.chkGuillotinado.Checked = False
        frm_Orden_Trabajo_Ampliada.chkLaca_UV.Checked = False
        frm_Orden_Trabajo_Ampliada.chkLacaUVSectorizada.Checked = False
        frm_Orden_Trabajo_Ampliada.chkMedio_Corte.Checked = False
        frm_Orden_Trabajo_Ampliada.chkMontado.Checked = False
        frm_Orden_Trabajo_Ampliada.chkOPPBrillante.Checked = False
        frm_Orden_Trabajo_Ampliada.chkOPPMate.Checked = False
        frm_Orden_Trabajo_Ampliada.chkOtros.Checked = False
        frm_Orden_Trabajo_Ampliada.chkPlastificado.Checked = False
        frm_Orden_Trabajo_Ampliada.chkPosicionado.Checked = False
        frm_Orden_Trabajo_Ampliada.chkRuedo.Checked = False
        frm_Orden_Trabajo_Ampliada.chkSoldado.Checked = False
        frm_Orden_Trabajo_Ampliada.chkStamping.Checked = False
        frm_Orden_Trabajo_Ampliada.chkTrazado.Checked = False
        frm_Orden_Trabajo_Ampliada.chkTroquelado.Checked = False
        'BOTONES
        frm_Orden_Trabajo_Ampliada.btnBuscar_cliente.Enabled = True
        frm_Orden_Trabajo_Ampliada.btnBuscar_cliente.Visible = True
        frm_Orden_Trabajo_Ampliada.btnBuscar_Vendedor.Enabled = True
        frm_Orden_Trabajo_Ampliada.btnBuscar_Vendedor.Visible = True
        frm_Orden_Trabajo_Ampliada.btnGuardar_Orden_Trabajo.Enabled = True
        frm_Orden_Trabajo_Ampliada.btnGuardar_Orden_Trabajo.Visible = True
        frm_Orden_Trabajo_Ampliada.btnCancelar_Orden_Trabajo.Enabled = True
        frm_Orden_Trabajo_Ampliada.btnCancelar_Orden_Trabajo.Visible = True
        frm_Orden_Trabajo_Ampliada.txt_descripcion_terminacion.Clear()
    End Sub

    Private Sub ListaOrdenAmpliadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaOrdenAmpliadaToolStripMenuItem.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.Text = ".:. Modificar Orden .:."
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Producto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnVer.Enabled = False
        frm_listado_orden_trabajo_ampliada.btn_ODT_mostrar_listado_pdf.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnVer.Visible = True
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = True
        frm_listado_orden_trabajo_ampliada.MdiParent = Me

        'frm_listado_orden_trabajo_ampliada.rbtNroOrden.Checked = True
        'frm_listado_orden_trabajo_ampliada.txt_Buscar_orden_trabajo.Enabled = True

        'frm_listado_orden_trabajo_ampliada.rbtCliente.Enabled = False
        'frm_listado_orden_trabajo_ampliada.txt_Buscar_Cliente.Enabled = False

        'frm_listado_orden_trabajo_ampliada.rbtFechaEntrega.Enabled = False
        'frm_listado_orden_trabajo_ampliada.dtp_Buscar_Fecha_Entrega.Enabled = False

        frm_listado_orden_trabajo_ampliada.Show()
        frm_listado_orden_trabajo_ampliada.dgvLista_Orden_Trabajo.ClearSelection()
    End Sub

    Private Sub ConsultarOrdenAmpliadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarOrdenAmpliadaToolStripMenuItem.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.Text = ".:. Consultar Orden .:."
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Producto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnVer.Visible = True
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btn_ODT_mostrar_listado_pdf.Enabled = True
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False

        frm_listado_orden_trabajo_ampliada.MdiParent = Me
        frm_listado_orden_trabajo_ampliada.Show()
        frm_listado_orden_trabajo_ampliada.dgvLista_Orden_Trabajo.ClearSelection()
    End Sub

    Private Sub EliminarOrdenAmpliadaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarOrdenAmpliadaToolStripMenuItem.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.Text = ".:.Eliminar Orden .:."
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = True
        frm_listado_orden_trabajo_ampliada.btnEliminar_Producto.Enabled = True
        frm_listado_orden_trabajo_ampliada.btnVer.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnVer.Visible = True
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btn_ODT_mostrar_listado_pdf.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False

        frm_listado_orden_trabajo_ampliada.MdiParent = Me
        frm_listado_orden_trabajo_ampliada.Show()
        frm_listado_orden_trabajo_ampliada.dgvLista_Orden_Trabajo.ClearSelection()
    End Sub

    Private Sub NuevoToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles NuevoToolStripMenuItem2.Click
        frm_Actualizar_Offset.Text = "Nueva Repetición"
        'OCULTA CAMPOS
        frm_Actualizar_Offset.txt_id_orden_trabajo.Visible = False
        frm_Actualizar_Offset.txt_id_detalle_orden_trabajo1.Visible = False
        frm_Actualizar_Offset.txt_id_re_trabajo.Visible = False
        frm_Actualizar_Offset.Label1.Visible = False
        frm_Actualizar_Offset.Label45.Visible = False

        'DESHABILITA CAMPOS
        frm_Actualizar_Offset.GroupBox3.Enabled = False
        frm_Actualizar_Offset.txtNumero_Orden_Trabajo.Enabled = False
        frm_Actualizar_Offset.txt_cantidad_original.Enabled = False
        frm_Actualizar_Offset.cboPiezas1_Detalle1.Enabled = False
        frm_Actualizar_Offset.txtTamaño1_Detalle1.Enabled = False
        frm_Actualizar_Offset.txt_chapa_soporte_1.Enabled = False
        frm_Actualizar_Offset.cboImpresora_Original.Enabled = False
        frm_Actualizar_Offset.cboMarca_Offset.Enabled = False
        frm_Actualizar_Offset.dtp_Fecha_Ingreso_Original.Enabled = False
        frm_Actualizar_Offset.btnEliminar_Repeticion.Enabled = False
        frm_Actualizar_Offset.Show()
        frm_Actualizar_Offset.btnBuscar_Numero_Orden1.Focus()
        frm_Actualizar_Offset.dgvRepeticion.ClearSelection()
    End Sub

    Private Sub EliminarToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem3.Click
        frm_Actualizar_Offset.Text = "Eliminar Repetición"
        'OCULTA CAMPOS
        frm_Actualizar_Offset.txt_id_orden_trabajo.Visible = False
        frm_Actualizar_Offset.txt_id_detalle_orden_trabajo1.Visible = False
        frm_Actualizar_Offset.txt_id_re_trabajo.Visible = False
        frm_Actualizar_Offset.Label1.Visible = False
        frm_Actualizar_Offset.Label45.Visible = False

        'DESHABILITA CAMPOS
        frm_Actualizar_Offset.txtNumero_Orden_Trabajo.Enabled = False
        frm_Actualizar_Offset.txt_cantidad_original.Enabled = False
        frm_Actualizar_Offset.cboPiezas1_Detalle1.Enabled = False
        frm_Actualizar_Offset.txtTamaño1_Detalle1.Enabled = False
        frm_Actualizar_Offset.txt_chapa_soporte_1.Enabled = False
        frm_Actualizar_Offset.cboImpresora_Original.Enabled = False
        frm_Actualizar_Offset.cboMarca_Offset.Enabled = False
        frm_Actualizar_Offset.dtp_Fecha_Ingreso_Original.Enabled = False
        frm_Actualizar_Offset.btnGuardar_ReTrabajo.Enabled = False
        frm_Actualizar_Offset.GroupBox1.Enabled = False
        frm_Actualizar_Offset.GroupBox2.Enabled = False
        frm_Actualizar_Offset.Show()
        frm_Actualizar_Offset.btnEliminar_Repeticion.Focus()
        frm_Actualizar_Offset.dgvRepeticion.ClearSelection()
    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles NuevoToolStripMenuItem1.Click
        frm_retrabajo.Text = "Nuevo Re-Trabajo"
        frm_retrabajo.txt_id_detalle.Visible = False
        frm_retrabajo.txt_id_orden_trabajo.Visible = False
        frm_retrabajo.txt_id_re_trabajo.Visible = False
        frm_retrabajo.btnImprimirFormulario.Enabled = False
        frm_retrabajo.groupOffset.Enabled = False
        frm_retrabajo.GroupDigital.Enabled = False
        frm_retrabajo.GroupProducto1.Enabled = False
        frm_retrabajo.btnEliminar.Enabled = False
        frm_retrabajo.GroupListado.Enabled = False
        frm_retrabajo.Show()
        frm_retrabajo.btnBuscar_Numero_Orden1.Focus()
    End Sub

    Private Sub RepeticiónDeChapasToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RepeticiónDeChapasToolStripMenuItem1.Click

        frm_Actualizar_Offset.Text = "Consultar Repetición"
        'OCULTA CAMPOS
        frm_Actualizar_Offset.txt_id_orden_trabajo.Visible = False
        frm_Actualizar_Offset.txt_id_detalle_orden_trabajo1.Visible = False
        frm_Actualizar_Offset.txt_id_re_trabajo.Visible = False
        frm_Actualizar_Offset.Label1.Visible = False
        frm_Actualizar_Offset.Label45.Visible = False
        'DESHABILITA CAMPOS
        frm_Actualizar_Offset.txtNumero_Orden_Trabajo.Enabled = False
        frm_Actualizar_Offset.txt_cantidad_original.Enabled = False
        frm_Actualizar_Offset.cboPiezas1_Detalle1.Enabled = False
        frm_Actualizar_Offset.txtTamaño1_Detalle1.Enabled = False
        frm_Actualizar_Offset.txt_chapa_soporte_1.Enabled = False
        frm_Actualizar_Offset.cboImpresora_Original.Enabled = False
        frm_Actualizar_Offset.cboMarca_Offset.Enabled = False
        frm_Actualizar_Offset.dtp_Fecha_Ingreso_Original.Enabled = False
        frm_Actualizar_Offset.GroupBox2.Enabled = False

        frm_Actualizar_Offset.btnEliminar_Repeticion.Enabled = False
        frm_Actualizar_Offset.btnGuardar_ReTrabajo.Enabled = False
        frm_Actualizar_Offset.btnBuscar_Numero_Orden1.Enabled = False
        frm_Actualizar_Offset.Show()
        frm_Actualizar_Offset.dgvRepeticion.ClearSelection()
    End Sub

    Private Sub EliminarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem2.Click
        frm_retrabajo.Text = "Nuevo Re-Trabajo"
        '  frm_retrabajo.txt_id_detalle.Visible = False
        frm_retrabajo.txt_id_orden_trabajo.Visible = False
        frm_retrabajo.txt_id_re_trabajo.Visible = False
        frm_retrabajo.btnImprimirFormulario.Enabled = False
        frm_retrabajo.groupOffset.Enabled = False
        frm_retrabajo.GroupDigital.Enabled = False
        frm_retrabajo.GroupReTrabajo.Enabled = False
        frm_retrabajo.GroupProducto1.Enabled = False
        frm_retrabajo.GroupDatosOriginales.Enabled = False
        frm_retrabajo.btnGuardar_ReTrabajo.Enabled = False
        frm_retrabajo.GroupTipoOrden.Enabled = False
        frm_retrabajo.Show()
        '  frm_retrabajo.txt_Buscar_Nro_Orden.Focus()
    End Sub

    Private Sub DigitalOffsetToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DigitalOffsetToolStripMenuItem1.Click
        frm_retrabajo.Text = "Consultar Re-Trabajo"
        '  frm_retrabajo.txt_id_detalle.Visible = False
        frm_retrabajo.txt_id_orden_trabajo.Visible = False
        frm_retrabajo.txt_id_re_trabajo.Visible = False
        frm_retrabajo.btnImprimirFormulario.Enabled = False
        frm_retrabajo.groupOffset.Enabled = False
        frm_retrabajo.GroupDigital.Enabled = False
        frm_retrabajo.GroupReTrabajo.Enabled = False
        frm_retrabajo.GroupProducto1.Enabled = False
        frm_retrabajo.GroupDatosOriginales.Enabled = False
        frm_retrabajo.btnGuardar_ReTrabajo.Enabled = False
        frm_retrabajo.btnEliminar.Enabled = False
        frm_retrabajo.GroupTipoOrden.Enabled = False
        frm_retrabajo.GroupPliegoEntero.Enabled = False
        frm_retrabajo.Show()
        frm_retrabajo.dgvListado_ReTrabajo.ClearSelection()
    End Sub

    Private Sub btnManualUsuario_Click(sender As System.Object, e As System.EventArgs) Handles btnManualUsuario.Click
        frm_VerMasDetalles.Show()
    End Sub

    Private Sub MovimientoOrdenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MovimientoOrdenToolStripMenuItem.Click
        frm_Movimiento_Orden.txt_Buscar_orden_trabajo.Clear()
        frm_Movimiento_Orden.ShowDialog()
        frm_Movimiento_Orden.dgvMovimiento_Orden.ClearSelection()
    End Sub

    Private Sub DiariasPorColaboradorToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DiariasPorColaboradorToolStripMenuItem1.Click
        frm_Generar_Informe.MdiParent = Me
        frm_Generar_Informe.Show()
        frm_Generar_Informe.btn_Totales_Mensuales_por_Colaborador.Enabled = False
    End Sub

    Private Sub MensualesPorSectorToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles MensualesPorSectorToolStripMenuItem1.Click
        frm_Generar_Informe.MdiParent = Me
        frm_Generar_Informe.Show()
        frm_Generar_Informe.btnTotales_por_Dia.Enabled = False
    End Sub



    Private Sub ModificarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem2.Click
        frm_Listado_Despacho.dgv_remitos.SelectionMode = DataGridViewSelectionMode.CellSelect
        frm_Listado_Despacho.dgv_orden_x_remito.SelectionMode = DataGridViewSelectionMode.CellSelect

        frm_Listado_Despacho.dgv_remitos.ReadOnly = False
        frm_Listado_Despacho.dgv_orden_x_remito.ReadOnly = False

        frm_Listado_Despacho.btn_eliminar.Visible = False
        frm_Listado_Despacho.btn_modificar.Visible = True
        frm_Listado_Despacho.btn_agregarodt.Visible = True
        frm_Listado_Despacho.Text = "Modificar ordenes por remito"
        frm_Listado_Despacho.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        frm_Listado_Despacho.dgv_remitos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        frm_Listado_Despacho.dgv_orden_x_remito.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        frm_Listado_Despacho.btn_eliminar.Visible = True
        frm_Listado_Despacho.btn_modificar.Visible = False
        frm_Listado_Despacho.btn_agregarodt.Visible = False
        frm_Listado_Despacho.Text = "Eliminar ordenes por remito"
        frm_Listado_Despacho.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem3.Click
        frm_Listado_Despacho.dgv_remitos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        frm_Listado_Despacho.dgv_orden_x_remito.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        frm_Listado_Despacho.btn_eliminar.Visible = False
        frm_Listado_Despacho.btn_modificar.Visible = False
        frm_Listado_Despacho.btn_agregarodt.Visible = False
        frm_Listado_Despacho.Text = "Consultar ordenes por remito"
        frm_Listado_Despacho.Show()
    End Sub

    Private Sub RemitoXOrdenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemitoXOrdenToolStripMenuItem.Click
        frm_Despacho.Text = "Nuevo remito por orden"
        frm_Despacho.tbp_logistica.Enabled = True
        frm_Despacho.tbp_empaque.Enabled = False
        frm_Despacho.tbc_despacho.SelectedIndex = 1
        frm_Despacho.quien_llamo_despacho = Me
        frm_Despacho.Show()
    End Sub

    Private Sub btn_ticket_Click(sender As System.Object, e As System.EventArgs) Handles btn_ticket.Click
        If LBL_MENU_PERFIL.Text = "ADMINISTRADOR" Or LBL_MENU_PERFIL.Text = "GERENCIA" Then
            frm_Ticket.Show()
            frm_Ticket.TabControl1.SelectedIndex = 1
        Else
            frm_Ticket.Show()
            frm_Ticket.TabControl1.SelectedIndex = 0
            frm_Ticket.btn_eliminar.Enabled = False
            frm_Ticket.chk_Nuevo.Checked = True
        End If
    End Sub

    Private Sub PlanificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlanificarToolStripMenuItem.Click
        frm_Despacho.dgv_emp_lista_ordenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        frm_Despacho.Text = "Nueva planificación diaria"
        frm_Despacho.tbp_logistica.Enabled = False
        frm_Despacho.tbp_empaque.Enabled = True
        frm_Despacho.tbc_despacho.SelectedIndex = 0
        frm_Despacho.Show()
    End Sub

    Private Sub ActualizarEstadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarEstadoToolStripMenuItem.Click
        frm_Listado_Empaque.dgv_planificacion.SelectionMode = DataGridViewSelectionMode.CellSelect
        frm_Listado_Empaque.dgv_planificacion.ReadOnly = False
        frm_Listado_Empaque.btn_eliminar.Visible = False
        frm_Listado_Empaque.btn_modificar.Visible = True
        frm_Listado_Empaque.Text = "Modificar ordenes por remito"

        frm_Listado_Empaque.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm_Sugerencia.Show()
    End Sub

    Private Sub DesplanificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesplanificarToolStripMenuItem.Click
        frm_Listado_Empaque.dgv_planificacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        frm_Listado_Empaque.btn_eliminar.Visible = True
        frm_Listado_Empaque.btn_modificar.Visible = False
        frm_Listado_Empaque.Text = "Eliminar planificación"
        frm_Listado_Empaque.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem2.Click
        frm_Listado_Empaque.dgv_planificacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        frm_Listado_Empaque.btn_eliminar.Visible = False
        frm_Listado_Empaque.btn_modificar.Visible = False
        frm_Listado_Empaque.Text = "Consultar planificacion"
        frm_Listado_Empaque.Show()
    End Sub

    Private Sub GuardarActualizarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarActualizarToolStripMenuItem.Click

        frm_Listado_GuardarActualizar.Text = "Modificar/Agregar Tarea"
        frm_Listado_GuardarActualizar.btnExportarListado.Enabled = False
        frm_Listado_GuardarActualizar.btnEliminar_Tarea.Enabled = False
        frm_Listado_GuardarActualizar.btnVer.Enabled = False
        frm_Listado_GuardarActualizar.btnAgregar.Enabled = False
        frm_Listado_GuardarActualizar.btnModificar_Una.Enabled = False
        frm_Listado_GuardarActualizar.Btn_informe_diario.Enabled = False
        frm_Listado_GuardarActualizar.dtpFecha.Text = Now
        frm_Listado_GuardarActualizar.ShowDialog()
    End Sub

    Sub LimpiarDetalleTarea2()
        frm_GuardarActualizar_tarea.txt_detalle_tarea1.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea2.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea3.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea4.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea5.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea6.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea7.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea8.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea9.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea10.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea11.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea12.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea13.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea14.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea15.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea16.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea17.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea18.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea19.Clear()
        frm_GuardarActualizar_tarea.txt_detalle_tarea20.Clear()
    End Sub

    Sub HabilitarDetalleTarea2()
        frm_GuardarActualizar_tarea.txt_detalle_tarea1.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea1.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea1.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea2.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea3.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea4.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea5.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea6.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea7.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea8.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea9.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea10.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea11.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea12.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea13.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea14.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea15.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea16.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea17.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea18.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea19.Enabled = True
        frm_GuardarActualizar_tarea.txt_detalle_tarea20.Enabled = True
    End Sub

    Sub LimpiarTiempoEstimado2()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado1.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado2.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado3.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado4.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado5.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado6.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado7.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado8.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado9.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado10.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado11.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado12.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado13.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado14.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado15.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado16.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado17.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado18.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado19.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado20.Clear()
    End Sub

    Sub HabilitarTiempoEstimado2()
        frm_GuardarActualizar_tarea.txtTiempo_Estimado1.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado2.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado3.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado4.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado5.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado6.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado7.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado8.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado9.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado10.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado11.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado12.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado13.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado14.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado15.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado16.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado17.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado18.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado19.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Estimado20.Enabled = True
    End Sub

    Sub LimpiarTiempoReal2()
        frm_GuardarActualizar_tarea.txtTiempo_Real1.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real2.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real3.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real4.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real5.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real6.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real7.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real8.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real9.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real10.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real11.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real12.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real13.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real14.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real15.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real16.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real17.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real18.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real19.Clear()
        frm_GuardarActualizar_tarea.txtTiempo_Real20.Clear()
    End Sub

    Sub HabilitarTiempoReal2()
        frm_GuardarActualizar_tarea.txtTiempo_Real1.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real2.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real3.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real4.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real5.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real6.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real7.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real8.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real9.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real10.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real11.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real12.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real13.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real14.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real15.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real16.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real17.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real18.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real19.Enabled = True
        frm_GuardarActualizar_tarea.txtTiempo_Real20.Enabled = True
    End Sub

    Sub LimpiarHoraFinalizacion2()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion1.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion2.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion3.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion4.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion5.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion6.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion7.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion8.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion9.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion10.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion11.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion12.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion13.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion14.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion15.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion16.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion17.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion18.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion19.Clear()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion20.Clear()
    End Sub

    Sub HabilitarHoraFinalizacion2()
        frm_GuardarActualizar_tarea.txtHora_Finalizacion1.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion2.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion3.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion4.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion5.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion6.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion7.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion8.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion9.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion10.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion11.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion12.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion13.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion14.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion15.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion16.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion17.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion18.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion19.Enabled = True
        frm_GuardarActualizar_tarea.txtHora_Finalizacion20.Enabled = True
    End Sub

    Sub LimipiarObservaciones2()
        frm_GuardarActualizar_tarea.txtObservaciones1.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones2.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones3.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones4.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones5.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones6.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones7.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones8.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones9.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones10.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones11.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones12.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones13.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones14.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones15.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones16.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones17.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones18.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones19.Clear()
        frm_GuardarActualizar_tarea.txtObservaciones20.Clear()
    End Sub

    Sub HabilitarObservaciones2()
        frm_GuardarActualizar_tarea.txtObservaciones1.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones2.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones3.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones4.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones5.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones6.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones7.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones8.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones9.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones10.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones11.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones12.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones13.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones14.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones15.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones16.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones17.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones18.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones19.Enabled = True
        frm_GuardarActualizar_tarea.txtObservaciones20.Enabled = True
    End Sub

    Sub LimpiarNumeroOrden2()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo13.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo14.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo15.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo16.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo17.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo18.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo19.Clear()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo20.Clear()
    End Sub

    Sub DeshabilitarNumeroOrden2()
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo13.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo14.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo15.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo16.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo17.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo18.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo19.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo20.Enabled = False
    End Sub

    Sub OcultarIdOrden2()
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo1.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo2.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo3.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo4.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo5.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo6.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo7.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo8.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo9.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo10.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo11.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo12.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo13.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo14.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo15.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo16.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo17.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo18.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo19.Visible = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo20.Visible = False
    End Sub

    Sub OcultarIdTarea2()
        frm_GuardarActualizar_tarea.txt_Id_Tarea1.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea2.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea3.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea4.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea5.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea6.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea7.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea8.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea9.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea10.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea11.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea12.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea13.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea14.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea15.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea16.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea17.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea18.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea19.Visible = False
        frm_GuardarActualizar_tarea.txt_Id_Tarea20.Visible = False
    End Sub

    Sub HabilitarBotonNumeroOrden2()
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden1.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden2.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden3.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden4.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden5.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden6.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden7.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden8.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden9.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden10.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden11.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden12.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden13.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden14.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden15.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden16.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden17.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden18.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden19.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden20.Enabled = True
    End Sub

    Sub DemasCampos2()
        frm_GuardarActualizar_tarea.txt_Carga_Horaria1.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_colaborador.Visible = False
        frm_GuardarActualizar_tarea.Label1.Visible = False
        frm_GuardarActualizar_tarea.txt_nombre_colaborador.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_tarea.Visible = False
        frm_GuardarActualizar_tarea.Label1.Visible = False
        frm_GuardarActualizar_tarea.dtpFecha.Text = Now
        frm_GuardarActualizar_tarea.btnBuscar_Colaborador.Focus()
        frm_GuardarActualizar_tarea.btnBuscar_Colaborador.Visible = True
        frm_GuardarActualizar_tarea.btnNueva_Tarea.Visible = False
        frm_GuardarActualizar_tarea.btnImprimirFormulario.Visible = False
        frm_GuardarActualizar_tarea.btnGuardar_Tarea.Visible = True
        frm_GuardarActualizar_tarea.btnCancelar_Tarea.Visible = True
        frm_GuardarActualizar_tarea.btnBuscar_Colaborador.Enabled = True
        frm_GuardarActualizar_tarea.btnActualizar.Enabled = False
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaToolStripMenuItem.Click

        frm_GuardarActualizar_tarea.Text = "Nueva Tarea"
        LimpiarDetalleTarea2()
        HabilitarDetalleTarea2()
        LimpiarTiempoEstimado2()
        LimpiarTiempoReal2()
        HabilitarTiempoReal2()
        LimpiarHoraFinalizacion2()
        HabilitarHoraFinalizacion2()
        LimipiarObservaciones2()
        HabilitarObservaciones2()
        LimpiarNumeroOrden2()
        DeshabilitarNumeroOrden2()
        OcultarIdOrden2()
        OcultarIdTarea2()
        HabilitarBotonNumeroOrden2()
        DemasCampos2()

        Dim CargaColaborador = (From sec In datacontext.SECTOR
                           Join col In datacontext.COLABORADOR
                           On col.SEC_id_sector Equals sec.SEC_id_sector
                           Join usu In datacontext.USUARIO
                           On usu.COL_id_colaborador Equals col.COL_id_colaborador
                           Select usu.USU_usuario,
                           usu.USU_id_usuario,
                           col.COL_nombre_col,
                           col.COL_id_colaborador,
                           sec.SEC_id_sector,
                           sec.SEC_nombre_sector
                           Where USU_usuario = Me.LBL_MENU_USU.Text).ToList()(0)

        If CargaColaborador.SEC_nombre_sector <> "Offset" Then
            frm_GuardarActualizar_tarea.MdiParent = Me
            frm_GuardarActualizar_tarea.Show()

            frm_GuardarActualizar_tarea.txt_id_colaborador.Text = CargaColaborador.COL_id_colaborador.ToString
            frm_GuardarActualizar_tarea.txt_nombre_colaborador.Text = CargaColaborador.COL_nombre_col.ToString
        Else
            frm_GuardarActualizar_tarea.MdiParent = Me
            frm_GuardarActualizar_tarea.Show()
            frm_GuardarActualizar_tarea.txt_id_colaborador.Text = CargaColaborador.COL_id_colaborador.ToString
            frm_GuardarActualizar_tarea.txt_nombre_colaborador.Text = CargaColaborador.COL_nombre_col.ToString
            frm_GuardarActualizar_tarea.MaximizeBox = False

            frm_GuardarActualizar_1.MdiParent = Me
            frm_GuardarActualizar_1.Show()
            frm_GuardarActualizar_1.MaximizeBox = False

            LimpiarDetalleTarea3()
            HabilitarDetalleTarea3()
            LimpiarTiempoEstimado3()
            LimpiarTiempoReal3()
            HabilitarTiempoReal3()
            LimpiarHoraFinalizacion3()
            HabilitarHoraFinalizacion3()
            LimipiarObservaciones3()
            HabilitarObservaciones3()
            LimpiarNumeroOrden3()
            DeshabilitarNumeroOrden3()
            OcultarIdOrden3()
            OcultarIdTarea3()
            HabilitarBotonNumeroOrden3()
            DemasCampos3()
        End If
    End Sub

    Private Sub ListadoGuardarActualizarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadoGuardarActualizarToolStripMenuItem.Click
        frm_Listado_GuardarActualizar.Text = "Eliminar Tarea"
        frm_Listado_GuardarActualizar.btnModificar_Una.Enabled = False
        frm_Listado_GuardarActualizar.btnAgregar.Enabled = False
        frm_Listado_GuardarActualizar.btnVer.Enabled = False
        frm_Listado_GuardarActualizar.btnExportarListado.Enabled = False
        frm_Listado_GuardarActualizar.btnModificarTodas.Enabled = False
        frm_Listado_GuardarActualizar.Btn_informe_diario.Enabled = False
        frm_Listado_GuardarActualizar.btnEliminar_Tarea.Enabled = True
        frm_Listado_GuardarActualizar.dtpFecha.Text = Now
        frm_Listado_GuardarActualizar.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem5.Click
        frm_Listado_GuardarActualizar.Text = "Consultar Tarea"
        frm_Listado_GuardarActualizar.btnModificar_Una.Enabled = False
        frm_Listado_GuardarActualizar.btnAgregar.Enabled = False
        frm_Listado_GuardarActualizar.btnVer.Enabled = True
        frm_Listado_GuardarActualizar.btnExportarListado.Enabled = True
        frm_Listado_GuardarActualizar.btnModificarTodas.Enabled = False
        frm_Listado_GuardarActualizar.Btn_informe_diario.Enabled = True
        frm_Listado_GuardarActualizar.btnEliminar_Tarea.Enabled = False
        frm_Listado_GuardarActualizar.dtpFecha.Text = Now
        frm_Listado_GuardarActualizar.ShowDialog()
    End Sub

    Sub LimpiarDetalleTarea3()
        frm_GuardarActualizar_1.txt_detalle_tarea1.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea2.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea3.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea4.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea5.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea6.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea7.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea8.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea9.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea10.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea11.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea12.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea13.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea14.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea15.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea16.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea17.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea18.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea19.Clear()
        frm_GuardarActualizar_1.txt_detalle_tarea20.Clear()
    End Sub

    Sub HabilitarDetalleTarea3()
        frm_GuardarActualizar_1.txt_detalle_tarea1.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea1.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea1.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea2.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea3.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea4.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea5.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea6.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea7.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea8.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea9.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea10.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea11.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea12.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea13.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea14.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea15.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea16.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea17.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea18.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea19.Enabled = True
        frm_GuardarActualizar_1.txt_detalle_tarea20.Enabled = True
    End Sub

    Sub LimpiarTiempoEstimado3()
        frm_GuardarActualizar_1.txtTiempo_Estimado1.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado2.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado3.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado4.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado5.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado6.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado7.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado8.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado9.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado10.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado11.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado12.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado13.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado14.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado15.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado16.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado17.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado18.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado19.Clear()
        frm_GuardarActualizar_1.txtTiempo_Estimado20.Clear()
    End Sub

    Sub HabilitarTiempoEstimado3()
        frm_GuardarActualizar_1.txtTiempo_Estimado1.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado2.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado3.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado4.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado5.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado6.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado7.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado8.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado9.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado10.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado11.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado12.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado13.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado14.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado15.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado16.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado17.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado18.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado19.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Estimado20.Enabled = True
    End Sub

    Sub LimpiarTiempoReal3()
        frm_GuardarActualizar_1.txtTiempo_Real1.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real2.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real3.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real4.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real5.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real6.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real7.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real8.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real9.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real10.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real11.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real12.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real13.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real14.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real15.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real16.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real17.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real18.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real19.Clear()
        frm_GuardarActualizar_1.txtTiempo_Real20.Clear()
    End Sub

    Sub HabilitarTiempoReal3()
        frm_GuardarActualizar_1.txtTiempo_Real1.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real2.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real3.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real4.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real5.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real6.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real7.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real8.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real9.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real10.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real11.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real12.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real13.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real14.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real15.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real16.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real17.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real18.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real19.Enabled = True
        frm_GuardarActualizar_1.txtTiempo_Real20.Enabled = True
    End Sub

    Sub LimpiarHoraFinalizacion3()
        frm_GuardarActualizar_1.txtHora_Finalizacion1.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion2.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion3.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion4.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion5.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion6.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion7.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion8.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion9.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion10.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion11.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion12.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion13.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion14.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion15.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion16.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion17.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion18.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion19.Clear()
        frm_GuardarActualizar_1.txtHora_Finalizacion20.Clear()
    End Sub

    Sub HabilitarHoraFinalizacion3()
        frm_GuardarActualizar_1.txtHora_Finalizacion1.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion2.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion3.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion4.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion5.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion6.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion7.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion8.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion9.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion10.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion11.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion12.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion13.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion14.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion15.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion16.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion17.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion18.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion19.Enabled = True
        frm_GuardarActualizar_1.txtHora_Finalizacion20.Enabled = True
    End Sub

    Sub LimipiarObservaciones3()
        frm_GuardarActualizar_1.txtObservaciones1.Clear()
        frm_GuardarActualizar_1.txtObservaciones2.Clear()
        frm_GuardarActualizar_1.txtObservaciones3.Clear()
        frm_GuardarActualizar_1.txtObservaciones4.Clear()
        frm_GuardarActualizar_1.txtObservaciones5.Clear()
        frm_GuardarActualizar_1.txtObservaciones6.Clear()
        frm_GuardarActualizar_1.txtObservaciones7.Clear()
        frm_GuardarActualizar_1.txtObservaciones8.Clear()
        frm_GuardarActualizar_1.txtObservaciones9.Clear()
        frm_GuardarActualizar_1.txtObservaciones10.Clear()
        frm_GuardarActualizar_1.txtObservaciones11.Clear()
        frm_GuardarActualizar_1.txtObservaciones12.Clear()
        frm_GuardarActualizar_1.txtObservaciones13.Clear()
        frm_GuardarActualizar_1.txtObservaciones14.Clear()
        frm_GuardarActualizar_1.txtObservaciones15.Clear()
        frm_GuardarActualizar_1.txtObservaciones16.Clear()
        frm_GuardarActualizar_1.txtObservaciones17.Clear()
        frm_GuardarActualizar_1.txtObservaciones18.Clear()
        frm_GuardarActualizar_1.txtObservaciones19.Clear()
        frm_GuardarActualizar_1.txtObservaciones20.Clear()
    End Sub

    Sub HabilitarObservaciones3()
        frm_GuardarActualizar_1.txtObservaciones1.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones2.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones3.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones4.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones5.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones6.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones7.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones8.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones9.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones10.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones11.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones12.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones13.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones14.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones15.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones16.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones17.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones18.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones19.Enabled = True
        frm_GuardarActualizar_1.txtObservaciones20.Enabled = True
    End Sub

    Sub LimpiarNumeroOrden3()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo1.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo2.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo3.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo4.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo5.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo6.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo7.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo8.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo9.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo10.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo11.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo12.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo13.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo14.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo15.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo16.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo17.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo18.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo19.Clear()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo20.Clear()
    End Sub

    Sub DeshabilitarNumeroOrden3()
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo1.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo2.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo3.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo4.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo5.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo6.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo7.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo8.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo9.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo10.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo11.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo12.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo13.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo14.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo15.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo16.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo17.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo18.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo19.Enabled = False
        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo20.Enabled = False
    End Sub

    Sub OcultarIdOrden3()
        frm_GuardarActualizar_1.txt_id_orden_trabajo1.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo2.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo3.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo4.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo5.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo6.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo7.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo8.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo9.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo10.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo11.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo12.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo13.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo14.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo15.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo16.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo17.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo18.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo19.Visible = False
        frm_GuardarActualizar_1.txt_id_orden_trabajo20.Visible = False
    End Sub

    Sub OcultarIdTarea3()
        frm_GuardarActualizar_1.txt_Id_Tarea1.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea2.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea3.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea4.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea5.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea6.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea7.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea8.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea9.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea10.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea11.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea12.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea13.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea14.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea15.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea16.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea17.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea18.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea19.Visible = False
        frm_GuardarActualizar_1.txt_Id_Tarea20.Visible = False
    End Sub

    Sub HabilitarBotonNumeroOrden3()
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden1.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden2.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden3.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden4.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden5.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden6.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden7.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden8.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden9.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden10.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden11.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden12.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden13.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden14.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden15.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden16.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden17.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden18.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden19.Enabled = True
        frm_GuardarActualizar_1.btnBuscar_Numero_Orden20.Enabled = True
    End Sub

    Sub DemasCampos3()
        frm_GuardarActualizar_1.txt_Carga_Horaria1.Enabled = False
        frm_GuardarActualizar_1.txt_id_colaborador.Visible = False
        frm_GuardarActualizar_1.Label1.Visible = False
        frm_GuardarActualizar_1.txt_nombre_colaborador.Enabled = False
        frm_GuardarActualizar_1.txt_id_tarea.Visible = False
        frm_GuardarActualizar_1.Label1.Visible = False
        frm_GuardarActualizar_1.dtpFecha.Text = Now
        frm_GuardarActualizar_1.btnBuscar_Colaborador.Focus()
        frm_GuardarActualizar_1.btnBuscar_Colaborador.Visible = True
        frm_GuardarActualizar_1.btnNueva_Tarea.Visible = False
        frm_GuardarActualizar_1.btnImprimirFormulario.Visible = False
        frm_GuardarActualizar_1.btnGuardar_Tarea.Visible = True
        frm_GuardarActualizar_1.btnCancelar_Tarea.Visible = True
        frm_GuardarActualizar_1.btnBuscar_Colaborador.Enabled = True
        frm_GuardarActualizar_1.btnActualizar.Enabled = False
    End Sub
End Class
