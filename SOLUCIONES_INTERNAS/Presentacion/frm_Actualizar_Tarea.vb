Public Class frm_Actualizar_Tarea

    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Dim vble_colaborador, vble_fecha As String
    Dim buscartarea
    Public quienllamoatarea As Integer

    Private Sub btn_Actualizar_Tarea_Click(sender As System.Object, e As System.EventArgs) Handles btn_Actualizar_Tarea.Click

        If txt_tarea.Text.Length = 0 Then
            MsgBox("Complete la descripción de la Tarea")
            txt_tarea.Focus()
            Exit Sub
        End If

        If txt_numero_orden.Text.Length = 0 Then
            MsgBox("Seleccione una Orden del listado")
            btn_buscar_numero_orden.Focus()
            Exit Sub
        End If

        If txt_nombre_colaborador.Text.Length = 0 Then
            MsgBox("Seleccione un Colaborador del listado")
            btn_buscar_colaborador.Focus()
            Exit Sub
        End If
        Try
            Dim ActualizarTarea = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_id_tarea.Text.ToUpper)).ToList()(0)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txt_tiempo_estimado.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txt_tiempo_real.Text, VbStrConv.ProperCase)
            ActualizarTarea.COL_id_colaborador = txt_id_colaborador.Text
            ActualizarTarea.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            ActualizarTarea.TAR_hora_fin = StrConv(txt_hora_fin.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_tarea.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txt_observaciones.Text, VbStrConv.ProperCase)
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            Me.Close()
            frm_Listado_GuardarActualizar.Close()
            vble_colaborador = frm_Listado_Tareas.dgvColaboradores.Item("COL_nombre_col", frm_Listado_Tareas.dgvColaboradores.SelectedRows(0).Index).Value
            vble_fecha = frm_Listado_Tareas.dtpFecha.Text
            Dim datagridtarea = (From o In datavistas.Vista_Tarea_x_Colaborador
                               Select o.TAR_id_tarea, o.TAR_detalle_tarea, o.TAR_tiempo_estimado, o.TAR_tiempo_real,
                               o.TAR_observaciones, o.ORT_id_orden_trabajo, o.ORT_numero_ot, o.TAR_fecha, o.TAR_carga_horaria, o.TAR_hora_fin, o.Expr1, o.COL_nombre_col
                               Where COL_nombre_col = vble_colaborador And TAR_fecha = vble_fecha)
            frm_Listado_GuardarActualizar.mostrargrillaobligaciones(datagridtarea)
            Label1.Text = frm_Listado_Tareas.dgvTarea_x_Colaborador.Rows.Count

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar tarea")
            ' Me.limpiarcontroles()
            Label1.Text = frm_Listado_Tareas.dgvTarea_x_Colaborador.Rows.Count
        End Try
    End Sub

    Private Sub btn_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_hora_fin_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_tiempo_estimado.Focus()
        End If
    End Sub

    Private Sub txt_hora_fin_TextChanged(sender As System.Object, e As System.EventArgs)
        'VALIDA LA HORA INGRESADA
        Select Case Len(txt_hora_fin.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txt_hora_fin.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txt_hora_fin.Text = Microsoft.VisualBasic.Right(txt_hora_fin.Text, Len(txt_hora_fin.Text) - 2)
                Else
                    txt_hora_fin.Text = txt_hora_fin.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txt_hora_fin.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txt_hora_fin.Text = Microsoft.VisualBasic.Left(txt_hora_fin.Text, Len(txt_hora_fin.Text) - 2)
                Else
                    txt_hora_fin.Text = txt_hora_fin.Text & ":"
                    Me.txt_hora_fin.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub frm_Actualizar_Tarea_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_id_colaborador.Visible = False
        txt_id_orden_trabajo.Visible = False
        txt_id_tarea.Visible = False
    
        txt_numero_orden.Enabled = False
        txt_nombre_colaborador.Enabled = False
        txt_tarea.Focus()
        txt_Carga_Horaria.Visible = False

        txtEntrada.Enabled = False
        txtSalida.Enabled = False

        Label1.Visible = False
        Label13.Visible = False
    End Sub

    Private Sub txt_tarea_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_buscar_numero_orden.Focus()
        End If
    End Sub

    Private Sub btn_buscar_numero_orden_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_buscar_colaborador.Focus()
        End If
    End Sub

    Private Sub btn_buscar_colaborador_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_Carga_Horaria.Focus()
        End If
    End Sub

    Private Sub txt_tiempo_estimado_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_tiempo_real.Focus()
        End If
    End Sub

    Private Sub txt_tiempo_real_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_observaciones.Focus()
        End If
    End Sub

    Private Sub txt_observaciones_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_Actualizar_Tarea.Focus()
        End If
    End Sub

    Private Sub btn_buscar_colaborador_KeyDown_1(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_Carga_Horaria.Focus()
        End If
    End Sub

    Private Sub txt_Carga_Horaria_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_hora_fin.Focus()
        End If
    End Sub

    Private Sub btn_buscar_colaborador_Click(sender As System.Object, e As System.EventArgs)
        frm_Colaborador.quienllamo_col = Me
        frm_Colaborador.Text = "Seleccionar Colaborador"
        frm_Colaborador.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Try
            If txt_tarea.Text.Length = 0 Then
                MsgBox("Debe completar la descripción de la tarea")
                txt_tarea.Focus()
                Exit Sub
            End If
            If txt_id_orden_trabajo.Text.Length = 0 Then
                MsgBox("Debe seleccionar un Número de Orden")
                btn_buscar_numero_orden.Focus()
                Exit Sub
            End If
            If txt_nombre_colaborador.Text.Length = 0 Then
                MsgBox("Debe seleccionar un Colaborador")
                btn_buscar_colaborador.Focus()
                Exit Sub
            End If

            If txt_tiempo_real.Text.Length = 0 Then
                MsgBox("Complete el campo Tiempo Real")
                txt_tiempo_real.Focus()
                Exit Sub
            End If

            If txt_tarea.Text.Length <> 0 Then
                'REGISTRO 1 DE TAREA
                Dim tar1 = New TAREA

                tar1.COL_id_colaborador = txt_id_colaborador.Text

                tar1.TAR_tiempo_estimado = StrConv(txt_tiempo_estimado.Text, VbStrConv.ProperCase)
                tar1.TAR_tiempo_real = StrConv(txt_tiempo_real.Text, VbStrConv.ProperCase)

                tar1.TAR_detalle_tarea = StrConv(txt_tarea.Text, VbStrConv.ProperCase)
                tar1.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
                tar1.TAR_observaciones = StrConv(txt_observaciones.Text, VbStrConv.ProperCase)

                datacontext.TAREA.InsertOnSubmit(tar1)
                datacontext.SubmitChanges()
            End If
            Select Case MsgBox("La Tarea se ha guardado correctamente, desea agregar otra?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar Tarea")
                Case MsgBoxResult.Yes
                    limpiarcampos()
                    Exit Sub
                Case Else
                    Me.Close()
            End Select
            'MsgBox("La tarea se ha creado correctamente", vbInformation)
            'Me.Close()
            frm_Listado_Tareas.Close()
        Catch ex As Exception
            MsgBox("Error al guardar la Tarea" + MsgBoxStyle.Critical, "Guardando Tareas")
        End Try

    End Sub

    Private Sub frm_Actualizar_Tarea_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Sub limpiarcampos()
        txt_hora_fin.Clear()
        txt_id_orden_trabajo.Clear()
        txt_numero_orden.Clear()
        txt_observaciones.Clear()
        txt_tarea.Clear()
        txt_tiempo_estimado.Clear()
        txt_tiempo_real.Clear()
    End Sub

    Sub validatar()
        Try
            If txt_nombre_colaborador.TextLength <> 0 Then

                buscartarea = (From ta In datacontext.TAREA
                               Select ta.COL_id_colaborador, ta.TAR_fecha
                                   Where COL_id_colaborador = CInt(txt_id_colaborador.Text) And TAR_fecha = dtpFecha.Text).Any
                If buscartarea = True Then
                    Dim traetarea = (From ta In datacontext.TAREA
                              Select ta.TAR_entrada, ta.TAR_salida, ta.TAR_carga_horaria, ta.COL_id_colaborador, ta.TAR_fecha
                                              Where COL_id_colaborador = CInt(txt_id_colaborador.Text) And TAR_fecha = dtpFecha.Text).ToList(0)
                    txtEntrada.Text = traetarea.TAR_entrada
                    txtEntrada.Enabled = False
                    txtSalida.Text = traetarea.TAR_salida
                    txtSalida.Enabled = False
                    ' txt_Carga_Horaria1.Text = traetarea.TAR_carga_horaria
                    ' txt_Carga_Horaria1.Enabled = False
                Else
                    txtEntrada.Clear()
                    txtEntrada.Enabled = True
                    txtSalida.Clear()
                    txtSalida.Enabled = True
                    ' txt_Carga_Horaria1.Clear()
                    ' txt_Carga_Horaria1.Enabled = True
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txt_nombre_colaborador_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_nombre_colaborador.TextChanged
        If quienllamoatarea = 0 Then
            validatar()
        End If
    End Sub

    Private Sub txt_hora_fin_TextChanged_2(sender As System.Object, e As System.EventArgs) Handles txt_hora_fin.TextChanged
        Try
            'VALIDA LA HORA INGRESADA
            Select Case Len(txt_hora_fin.Text)
                Case 5
                    If Microsoft.VisualBasic.Right(txt_hora_fin.Text, 2) > 59 Then
                        MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                        txt_hora_fin.Text = Microsoft.VisualBasic.Right(txt_hora_fin.Text, Len(txt_hora_fin.Text) - 2)
                    Else
                        txt_hora_fin.Text = txt_hora_fin.Text & ""
                    End If
                Case 2
                    If Microsoft.VisualBasic.Left(txt_hora_fin.Text, 2) > 23 Then
                        MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                        txt_hora_fin.Text = Microsoft.VisualBasic.Left(txt_hora_fin.Text, Len(txt_hora_fin.Text) - 2)
                    Else
                        txt_hora_fin.Text = txt_hora_fin.Text & ":"
                        Me.txt_hora_fin.SelectionStart = 3
                    End If
            End Select
        Catch ex As Exception
            MsgBox("El formato de la hora de entrada es: '00:00'")
        End Try
    End Sub

    Private Sub txt_tiempo_estimado_KeyPress_1(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_tiempo_estimado.KeyPress
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

    Private Sub txt_tiempo_real_KeyPress_1(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_tiempo_real.KeyPress
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

    Private Sub btn_buscar_numero_orden_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_buscar_numero_orden.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub
End Class