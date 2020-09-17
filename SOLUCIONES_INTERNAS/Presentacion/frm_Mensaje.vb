Public Class frm_Mensaje

    Dim datacontext As New DataS_Interno


    Private Sub btn_Envio_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_Envio.Click
        If txt_Titulo.Text.Length = 0 Then
            MsgBox("Debe completar el campo 'Título'")
            Exit Sub
        End If
        If txt_comentario.Text.Length = 0 Then
            MsgBox("Debe completar el campo 'Comentario'")
            Exit Sub
        End If
        Try
            'GUARDA SOLICITANTE
            Dim men = New MENSAJE
            men.USU_id_usuario = StrConv(txt_id_usuario.Text, VbStrConv.ProperCase)
            men.MEN_fecha_mensaje = dtp_fecha_pedido.Text
            men.MEN_titulo = StrConv(txt_Titulo.Text, VbStrConv.ProperCase)
            men.MEN_comentario = StrConv(txt_comentario.Text, VbStrConv.ProperCase)
            men.MEN_respuesta = StrConv(txt_respuesta.Text, VbStrConv.ProperCase)

            datacontext.MENSAJE.InsertOnSubmit(men)
            datacontext.SubmitChanges()
            'Dim ultimoticket = (From ut In datacontext.TICKET
            '                    Select ut.TIC_id_ticket
            '                    Order By TIC_id_ticket Descending).ToList()(0)
            MsgBox("El Mensaje fue enviado exitosamente")
            Me.Close()
        Catch ex As Exception
            MsgBox("El Mensaje no puedo ser enviado")
        End Try
    End Sub

    Private Sub btn_respuesta_Click(sender As System.Object, e As System.EventArgs) Handles btn_respuesta.Click
        If txt_respuesta.Text.Length = 0 Then
            MsgBox("Debe completar el campo 'Respuesta'")
            Exit Sub
        End If
        Try
            Dim ActualizarMensaje = (From P In datacontext.MENSAJE
                                     Where P.MEN_id_mensaje = (txt_id_mensaje.Text.ToUpper)).ToList()(0)
            ActualizarMensaje.MEN_respuesta = StrConv(txt_respuesta.Text, VbStrConv.ProperCase)

            datacontext.SubmitChanges()
            MsgBox("La Respuesta ha sido enviada correctamente")
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Enviar Respuesta")
        End Try
    End Sub

    Private Sub frm_Mensaje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CARGA EN EL FORMULARIO LOS MENSAJES, EL USUARIO Y SU ID QUE LO SACA DEL GRID DE COLABORADORES
        armargrilla()
        Try
            If frm_Colaborador.dgvLista_Colaboradores.Rows.Count > 0 Then
                Dim consulta = (From c In datacontext.COLABORADOR
                               Join u In datacontext.USUARIO
                               On c.COL_id_colaborador Equals u.COL_id_colaborador
                               Join m In datacontext.MENSAJE
                               On m.USU_id_usuario Equals u.USU_id_usuario
                               Select m.USU_id_usuario, m.MEN_fecha_mensaje, m.MEN_titulo, m.MEN_comentario, m.MEN_respuesta
                               Where USU_id_usuario = (frm_Colaborador.dgvLista_Colaboradores.Item("USU_id_usuario", frm_Colaborador.dgvLista_Colaboradores.CurrentRow.Index).Value).ToString
                               Order By MEN_fecha_mensaje Descending)
                dgv_Listado_Mensajes.DataSource = consulta
            End If
        Catch ex As Exception
            MsgBox("Seleccione un Colaborador del listado")
        End Try
    End Sub

    Private Sub armargrilla()
        dgv_Listado_Mensajes.Enabled = True
        dgv_Listado_Mensajes.AutoGenerateColumns = False
        dgv_Listado_Mensajes.Columns.Clear()

        dgv_Listado_Mensajes.Columns.Add("USU_id_usuario", "USU_id_usuario")
        ' dgv_Listado_Mensajes.Columns.Add("MEN_fecha_mensaje", "Fecha")
        dgv_Listado_Mensajes.Columns.Add("MEN_titulo", "Título")
        dgv_Listado_Mensajes.Columns.Add("MEN_comentario", "Comentario")
        dgv_Listado_Mensajes.Columns.Add("MEN_respuesta", "Respuesta")
        dgv_Listado_Mensajes.Columns.Add("USU_usuario", "Usuario")
     
        dgv_Listado_Mensajes.Columns(0).DataPropertyName = "USU_id_usuario"
        dgv_Listado_Mensajes.Columns(0).Visible = False
        '  dgv_Listado_Mensajes.Columns(1).DataPropertyName = "MEN_fecha_mensaje"
        dgv_Listado_Mensajes.Columns(1).DataPropertyName = "MEN_titulo"
        dgv_Listado_Mensajes.Columns(2).DataPropertyName = "MEN_comentario"
        dgv_Listado_Mensajes.Columns(2).Width = 150
        dgv_Listado_Mensajes.Columns(3).DataPropertyName = "MEN_respuesta"
        dgv_Listado_Mensajes.Columns(3).Width = 300
        dgv_Listado_Mensajes.Columns(4).DataPropertyName = "USU_usuario"
    End Sub

    Public Sub cargargrilla()
        Dim consultaMensaje = (From M In datacontext.MENSAJE
                              Join U In datacontext.USUARIO
                              On M.USU_id_usuario Equals U.USU_id_usuario
                              Select M.MEN_id_mensaje, U.USU_id_usuario, M.MEN_fecha_mensaje, M.MEN_titulo, M.MEN_comentario, M.MEN_respuesta
                              Order By MEN_fecha_mensaje Descending)
        dgv_Listado_Mensajes.DataSource = consultaMensaje
    End Sub

    Private Sub cbo_busqueda_estado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        armargrilla()
        cargargrilla()
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        armargrilla()
        Try
            Dim consulta = (From c In datacontext.COLABORADOR
                            Join u In datacontext.USUARIO
                            On c.COL_id_colaborador Equals u.COL_id_colaborador
                            Join m In datacontext.MENSAJE
                            On m.USU_id_usuario Equals u.USU_id_usuario
      Select m.MEN_fecha_mensaje, m.MEN_titulo, m.MEN_comentario, m.MEN_respuesta, u.USU_usuario
      Where MEN_fecha_mensaje = DateTimePicker1.Text
                            Order By MEN_fecha_mensaje Descending)
            dgv_Listado_Mensajes.DataSource = consulta
        Catch ex As Exception
            MsgBox("Seleccione un Colaborador del listado")
        End Try
    End Sub
End Class


