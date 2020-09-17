Option Explicit On ''''''''''''''''''''''''''''''''''''''''''''''''''  

Imports System.Text
Imports System.IO
Imports System.Drawing.Printing

Public Class frm_Colaborador
    Dim datacontext As New DataS_Interno
    Public quienllamo_col As Form

    Private Sub frm_Colaborador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txt_id_colaborador.Visible = False
        Label1.Visible = False
        armargrilla()
        cargargrilla()
        lblTotal_Colaboradores.Text = dgvLista_Colaboradores.Rows.Count

        'CARGA COMBOBOX SECTOR
        Dim combosector = (From sec In datacontext.SECTOR
                           Select sec.SEC_id_sector, sec.SEC_nombre_sector)
        cbo_sector.DataSource = combosector
        cbo_sector.DisplayMember = "SEC_nombre_sector"
        cbo_sector.ValueMember = "SEC_id_sector"
        cbo_sector.SelectedIndex = -1

        dgvLista_Colaboradores.ClearSelection()
    End Sub

    Public Sub cargargrilla()
        If quienllamo_col.Name = frm_Usuario.Name Then
            Dim carga = (From col In datacontext.COLABORADOR
                                         Select
                                           col.COL_id_colaborador,
                                           col.COL_nombre_col,
                                           col.COL_apellido_col,
                                           col.SEC_id_sector
                                           Order By COL_nombre_col Ascending)
            dgvLista_Colaboradores.DataSource = carga

        ElseIf quienllamo_col.Name = frm_Tarea_1.Name Then
            Dim cualq = (From c In datacontext.USUARIO
                           Join col In datacontext.COLABORADOR
                           On c.COL_id_colaborador Equals col.COL_id_colaborador
                           Join sec In datacontext.SECTOR
                           On col.SEC_id_sector Equals sec.SEC_id_sector
                           Select sec.SEC_id_sector, sec.SEC_nombre_sector, c.USU_usuario
                           Where USU_usuario = frm_Principal.LBL_MENU_USU.Text).ToList()(0)

            Dim cargasupervisor = (From sec In datacontext.SECTOR
                         Join col In datacontext.COLABORADOR
                         On col.SEC_id_sector Equals sec.SEC_id_sector
                         Join usu In datacontext.USUARIO
                         On usu.COL_id_colaborador Equals col.COL_id_colaborador
                         Select usu.USU_usuario, sec.SEC_id_sector, sec.SEC_nombre_sector, col.COL_id_colaborador, col.COL_nombre_col, col.COL_apellido_col
                         Where SEC_id_sector = cualq.SEC_id_sector And COL_id_colaborador <> CInt(frm_Tarea.txt_id_colaborador.Text))
            dgvLista_Colaboradores.DataSource = cargasupervisor

        ElseIf quienllamo_col.Name = frm_GuardarActualizar_1.Name Then
            Dim cualq = (From c In datacontext.USUARIO
                           Join col In datacontext.COLABORADOR
                           On c.COL_id_colaborador Equals col.COL_id_colaborador
                           Join sec In datacontext.SECTOR
                           On col.SEC_id_sector Equals sec.SEC_id_sector
                           Select sec.SEC_id_sector, sec.SEC_nombre_sector, c.USU_usuario
                           Where USU_usuario = frm_Principal.LBL_MENU_USU.Text).ToList()(0)

            Dim cargasupervisor = (From sec In datacontext.SECTOR
                         Join col In datacontext.COLABORADOR
                         On col.SEC_id_sector Equals sec.SEC_id_sector
                         Join usu In datacontext.USUARIO
                         On usu.COL_id_colaborador Equals col.COL_id_colaborador
                         Select usu.USU_usuario, sec.SEC_id_sector, sec.SEC_nombre_sector, col.COL_id_colaborador, col.COL_nombre_col, col.COL_apellido_col
                         Where SEC_id_sector = cualq.SEC_id_sector And COL_id_colaborador <> CInt(frm_GuardarActualizar_tarea.txt_id_colaborador.Text))
            dgvLista_Colaboradores.DataSource = cargasupervisor
        Else

            If frm_Principal.LBL_MENU_PERFIL.Text = "COLABORADOR" Then
                'TRAE SECTOR DEL USUARIO REGISTRADO
                Dim cargacolaborador = (From sec In datacontext.SECTOR
                              Join col In datacontext.COLABORADOR
                              On col.SEC_id_sector Equals sec.SEC_id_sector
                              Join usu In datacontext.USUARIO
                              On usu.COL_id_colaborador Equals col.COL_id_colaborador
                              Select usu.USU_usuario, sec.SEC_id_sector, sec.SEC_nombre_sector, col.COL_id_colaborador, col.COL_nombre_col, col.COL_apellido_col
                              Where USU_usuario = frm_Principal.LBL_MENU_USU.Text)
                dgvLista_Colaboradores.DataSource = cargacolaborador

            ElseIf frm_Principal.LBL_MENU_PERFIL.Text = "SUPERVISOR" Then

                'TRAE SECTOR DEL USUARIO REGISTRADO
                Dim cualq = (From c In datacontext.USUARIO
                            Join col In datacontext.COLABORADOR
                            On c.COL_id_colaborador Equals col.COL_id_colaborador
                            Join sec In datacontext.SECTOR
                            On col.SEC_id_sector Equals sec.SEC_id_sector
                            Select sec.SEC_id_sector, sec.SEC_nombre_sector, c.USU_usuario
                            Where USU_usuario = frm_Principal.LBL_MENU_USU.Text).ToList()(0)

                'TODOS LOS USUARIOS DEL SECTOR DEL USUARIO REGISTRADO
                Dim cargasupervisor = (From sec In datacontext.SECTOR
                             Join col In datacontext.COLABORADOR
                             On col.SEC_id_sector Equals sec.SEC_id_sector
                             Join usu In datacontext.USUARIO
                             On usu.COL_id_colaborador Equals col.COL_id_colaborador
                             Select usu.USU_usuario, sec.SEC_id_sector, sec.SEC_nombre_sector, col.COL_id_colaborador, col.COL_nombre_col, col.COL_apellido_col
                             Where SEC_id_sector = cualq.SEC_id_sector)
                dgvLista_Colaboradores.DataSource = cargasupervisor

            Else
                Dim carga = (From col In datacontext.COLABORADOR
                                            Join sec In datacontext.SECTOR
                                            On col.SEC_id_sector Equals sec.SEC_id_sector
                                            Join usu In datacontext.USUARIO
                                            On col.COL_id_colaborador Equals usu.COL_id_colaborador
                                            Select
                                            col.COL_id_colaborador,
                                            col.COL_nombre_col,
                                            col.COL_apellido_col,
                                            col.SEC_id_sector,
                                            sec.SEC_nombre_sector,
                                            usu.USU_id_usuario,
                                            usu.USU_usuario
                                            Where SEC_nombre_sector <> "De baja"
                                            Order By SEC_nombre_sector Ascending)
                dgvLista_Colaboradores.DataSource = carga
            End If
        End If
    End Sub


    Private Sub btnGuardar_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Colaborador.Click
        Try
            Dim buscacliente = (From cli In datacontext.COLABORADOR
                                Select cli.COL_nombre_col, cli.COL_apellido_col, cli.SEC_id_sector
                                Where COL_nombre_col = txt_nombre_colaborador.Text.ToUpper And COL_apellido_col = txt_apellido_colaborador.Text.ToUpper).Any
            If buscacliente = True Then
                MsgBox("El colaborador ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If

            If txt_nombre_colaborador.Text.Length = 0 Then
                MsgBox("Ingrese el Nombre del Colaborador")
                txt_nombre_colaborador.Focus()
                Exit Sub
            End If

            If cbo_sector.Text.Length = 0 Then
                MsgBox("Debe seleccionar un Sector")
                cbo_sector.Focus()
                Exit Sub
            End If

            Dim col = New COLABORADOR
            col.COL_nombre_col = StrConv(txt_nombre_colaborador.Text, VbStrConv.ProperCase)
            col.COL_apellido_col = StrConv(txt_apellido_colaborador.Text, VbStrConv.ProperCase)
            col.SEC_id_sector = cbo_sector.SelectedValue

            datacontext.COLABORADOR.InsertOnSubmit(col)
            datacontext.SubmitChanges()
            MsgBox("El colaborador se ha creado correctamente", vbInformation)
            cargargrilla()
            limpiarcontroles()
            Me.Close()
            ' Me.Dispose()
        Catch ex As Exception
            MsgBox("Error al guardar al Colaborador")
            limpiarcontroles()
            cargargrilla()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_id_colaborador.Clear()
        txt_nombre_colaborador.Clear()
        txt_apellido_colaborador.Clear()
        cbo_sector.SelectedIndex = -1
    End Sub

    Private Sub btnActualizar_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar_Colaborador.Click
        If txt_nombre_colaborador.Text.Length = 0 Then
            MsgBox("Ingrese el Nombre del Colaborador")
            txt_nombre_colaborador.Focus()
            Exit Sub
        End If

        If cbo_sector.Text.Length = 0 Then
            MsgBox("Debe seleccionar un Sector")
            cbo_sector.Focus()
            Exit Sub
        End If
        Try
            Dim ActualizarCliente = (From P In datacontext.COLABORADOR Where P.COL_id_colaborador = (txt_id_colaborador.Text.ToUpper)).ToList()(0)
            ActualizarCliente.COL_nombre_col = StrConv(txt_nombre_colaborador.Text, VbStrConv.ProperCase)
            ActualizarCliente.COL_apellido_col = StrConv(txt_apellido_colaborador.Text, VbStrConv.ProperCase)
            ActualizarCliente.SEC_id_sector = cbo_sector.SelectedValue

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            cargargrilla()
            Me.limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Colaborador")
            Me.limpiarcontroles()
            Me.cargargrilla()
            Me.Close()
            ' Me.Dispose()
        End Try
    End Sub

    Private Sub armargrilla()
        dgvLista_Colaboradores.Enabled = True
        dgvLista_Colaboradores.AutoGenerateColumns = False
        dgvLista_Colaboradores.Columns.Clear()

        dgvLista_Colaboradores.Columns.Add("COL_id_colaborador", "id_colaborador")
        dgvLista_Colaboradores.Columns.Add("COL_nombre_col", "Nombre")
        dgvLista_Colaboradores.Columns.Add("COL_apellido_col", "Apellido")
        dgvLista_Colaboradores.Columns.Add("SEC_id_sector", "id_sector")
        dgvLista_Colaboradores.Columns.Add("SEC_nombre_sector", "Sector")
        dgvLista_Colaboradores.Columns.Add("USU_id_usuario", "id_usuario")
        dgvLista_Colaboradores.Columns.Add("USU_usuario", "Usuario")


        dgvLista_Colaboradores.Columns(0).DataPropertyName = "COL_id_colaborador"
        dgvLista_Colaboradores.Columns(0).Visible = False
        dgvLista_Colaboradores.Columns(1).DataPropertyName = "COL_nombre_col"
        dgvLista_Colaboradores.Columns(2).DataPropertyName = "COL_apellido_col"
        dgvLista_Colaboradores.Columns(3).DataPropertyName = "SEC_id_sector"
        dgvLista_Colaboradores.Columns(3).Visible = False
        dgvLista_Colaboradores.Columns(4).DataPropertyName = "SEC_nombre_sector"
        dgvLista_Colaboradores.Columns(5).DataPropertyName = "USU_id_usuario"
        dgvLista_Colaboradores.Columns(5).Visible = False
        dgvLista_Colaboradores.Columns(6).DataPropertyName = "USU_usuario"
        dgvLista_Colaboradores.Columns(6).Width = 150
    End Sub

    Private Sub dgvLista_Colaboradores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista_Colaboradores.Click
        Try
            If dgvLista_Colaboradores.SelectedRows.Count > 0 Then
                txt_id_colaborador.Text = dgvLista_Colaboradores.Item("COL_id_colaborador", dgvLista_Colaboradores.SelectedRows(0).Index).Value
                txt_nombre_colaborador.Text = dgvLista_Colaboradores.Item("COL_nombre_col", dgvLista_Colaboradores.SelectedRows(0).Index).Value
                txt_apellido_colaborador.Text = dgvLista_Colaboradores.Item("COL_apellido_col", dgvLista_Colaboradores.SelectedRows(0).Index).Value
                cbo_sector.Text = dgvLista_Colaboradores.Item("SEC_nombre_sector", dgvLista_Colaboradores.SelectedRows(0).Index).Value
            Else
                MsgBox("Debe seleccionar un colaborador")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEliminar_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Colaborador.Click

        If dgvLista_Colaboradores.SelectedRows.Count > 0 Then
            Dim eliminar = (From C In datacontext.COLABORADOR Where C.COL_id_colaborador = CInt(dgvLista_Colaboradores.Item("COL_id_colaborador", dgvLista_Colaboradores.SelectedRows(0).Index).Value)).ToList()(0)
            Select Case MsgBox("Se eliminará el colaborador seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar colaborador")
                Case MsgBoxResult.Yes
                    datacontext.COLABORADOR.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El Colaborador ha sido eliminado")
                    cargargrilla()
                    Me.Close()
            End Select
            Me.Close()
        Else
            MsgBox("Debe seleccionar un Colaborador")
        End If
    End Sub

    Private Sub btnNuevo_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case MsgBox("Se limpiarán todos los campos, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Limpiar campos")
            Case MsgBoxResult.Yes
                limpiarcontroles()
        End Select
    End Sub

    Private Sub btnCancelar_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar_Colaborador.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_Buscar_Colaborador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_Colaborador.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = "*" & Me.txt_Buscar_Colaborador.Text & "*"
        Dim consultaalu = From U In datacontext.COLABORADOR
                          Join S In datacontext.SECTOR
                          On S.SEC_id_sector Equals U.SEC_id_sector
                          Join C In datacontext.USUARIO
                          On C.COL_id_colaborador Equals U.COL_id_colaborador
                          Select U.COL_id_colaborador, U.COL_nombre_col, U.COL_apellido_col, U.SEC_id_sector, S.SEC_nombre_sector, C.USU_usuario, C.USU_id_usuario
                          Where COL_nombre_col Like buscar.ToString
        dgvLista_Colaboradores.DataSource = consultaalu
        dgvLista_Colaboradores.ClearSelection()

    End Sub

    Private Sub txt_nombre_colaborador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nombre_colaborador.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_apellido_colaborador.Focus()
        End If
    End Sub

    Private Sub txt_apellido_colaborador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_apellido_colaborador.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_sector.Focus()
        End If
    End Sub

    Private Sub cbo_sector_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_sector.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGuardar_Colaborador.Focus()
        End If
    End Sub

    Private Sub dgvLista_Colaboradores_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Colaboradores.CellDoubleClick
        Try
            If quienllamo_col.Name = frm_Actualizar_Tarea.Name Then
                frm_Actualizar_Tarea.txt_id_colaborador.Text = dgvLista_Colaboradores.SelectedCells(0).Value
                frm_Actualizar_Tarea.txt_nombre_colaborador.Text = dgvLista_Colaboradores.SelectedCells(1).Value

            ElseIf quienllamo_col.Name = frm_Tarea.Name Then
                frm_Tarea.txt_id_colaborador.Text = dgvLista_Colaboradores.SelectedCells(0).Value
                frm_Tarea.txt_nombre_colaborador.Text = dgvLista_Colaboradores.SelectedCells(1).Value

            ElseIf quienllamo_col.Name = frm_Tarea_1.Name Then
                frm_Tarea_1.txt_id_colaborador.Text = dgvLista_Colaboradores.SelectedCells(0).Value
                frm_Tarea_1.txt_nombre_colaborador.Text = dgvLista_Colaboradores.SelectedCells(1).Value

            ElseIf quienllamo_col.Name = frm_Usuario.Name Then
                frm_Usuario.txt_id_colaborador.Text = dgvLista_Colaboradores.SelectedCells(0).Value
                frm_Usuario.txt_nombre_colaborador.Text = dgvLista_Colaboradores.SelectedCells(1).Value

            ElseIf quienllamo_col.Name = frm_GuardarActualizar_tarea.Name Then
                frm_GuardarActualizar_tarea.txt_id_colaborador.Text = dgvLista_Colaboradores.SelectedCells(0).Value
                frm_GuardarActualizar_tarea.txt_nombre_colaborador.Text = dgvLista_Colaboradores.SelectedCells(1).Value

            ElseIf quienllamo_col.Name = frm_GuardarActualizar_1.Name Then
                frm_GuardarActualizar_1.txt_id_colaborador.Text = dgvLista_Colaboradores.SelectedCells(0).Value
                frm_GuardarActualizar_1.txt_nombre_colaborador.Text = dgvLista_Colaboradores.SelectedCells(1).Value
            End If
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frm_Colaborador_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.PrintDocument1.Print()
    End Sub
    Dim i As Integer = 0

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
      
        Dim i As Integer = 0

        Dim printFont As New Font("Arial", 8)
        Dim topMargin As Single = 500 'e.MarginBounds.Top
        Dim yPos As Single = 0
        Dim linesPerPage As Single = 0
        Dim count As Integer = 0
        Dim texto As String = ""
        Dim row As DataGridViewRow
        linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)
        While count < linesPerPage AndAlso i < Me.dgvLista_Colaboradores.Rows.Count
            row = dgvLista_Colaboradores.Rows(i)
            texto = ""
            For Each celda As DataGridViewCell In row.Cells
                texto += vbTab & celda.Value '.ToString()
            Next
            yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
            e.Graphics.DrawString(texto, printFont, Brushes.Black, 30, yPos)
            count += 1
            i += 1
        End While
        If i < Me.dgvLista_Colaboradores.Rows.Count Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            i = 0
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs)
        Me.PrintDocument1.Print()
    End Sub

    Private Sub btn_enviar_mensaje_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_enviar_mensaje.Click
        'CARGA EN EL FORMULARIO MENSAJE, EL USUARIO Y SU ID QUE LO SACA DEL GRID DE COLABORADORES
        Try
            If dgvLista_Colaboradores.Rows.Count > 0 Then
                Dim consulta = (From c In datacontext.COLABORADOR
                               Join u In datacontext.USUARIO
                               On c.COL_id_colaborador Equals u.COL_id_colaborador
                               Select u.USU_id_usuario, u.USU_usuario, u.USU_perfil, c.COL_id_colaborador, c.COL_apellido_col).ToList()(0)
                frm_Mensaje.txt_id_usuario.Text = (dgvLista_Colaboradores.SelectedCells(5).Value)
                frm_Mensaje.txt_nombre_usuario.Text = (dgvLista_Colaboradores.SelectedCells(6).Value)

                frm_Mensaje.Show()
                frm_Mensaje.TabPage2.Parent = Nothing

                frm_Mensaje.txt_Titulo.Focus()
                frm_Mensaje.Label1.Visible = False
                frm_Mensaje.Label18.Visible = False
                frm_Mensaje.txt_id_mensaje.Visible = False
                frm_Mensaje.txt_id_usuario.Visible = False
                frm_Mensaje.txt_nombre_usuario.Enabled = False
                frm_Mensaje.txt_respuesta.Enabled = False
                frm_Mensaje.btn_respuesta.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Seleccione un Colaborador del listado")
        End Try
    End Sub

    Private Sub btn_Ver_Mensaje_Click(sender As System.Object, e As System.EventArgs) Handles btn_Ver_Respuesta.Click
        Try
            If dgvLista_Colaboradores.Rows.Count > 0 Then
                frm_Mensaje.rbtFecha.Enabled = False
                frm_Mensaje.DateTimePicker1.Enabled = False
                frm_Mensaje.Show()
                frm_Mensaje.TabControl1.SelectedIndex = 1
                frm_Mensaje.TabPage1.Parent = Nothing
            Else
                MsgBox("Seleccione un colaborador del listado")
            End If
            Exit Sub
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Respuesta_Fecha_Click(sender As System.Object, e As System.EventArgs) Handles btn_Respuesta_Fecha.Click
        Try
            frm_Mensaje.TabPage1.Parent = Nothing
            frm_Mensaje.Show()
            Dim consulta = (From c In datacontext.COLABORADOR
                                 Join u In datacontext.USUARIO
                                 On c.COL_id_colaborador Equals u.COL_id_colaborador
                                 Join m In datacontext.MENSAJE
                                 On m.USU_id_usuario Equals u.USU_id_usuario
           Select m.MEN_fecha_mensaje,
           m.MEN_titulo,
           m.MEN_comentario,
           m.MEN_respuesta,
           u.USU_usuario
             Where MEN_fecha_mensaje = frm_Mensaje.DateTimePicker1.Text
             Order By MEN_fecha_mensaje Descending)
            frm_Mensaje.dgv_Listado_Mensajes.DataSource = consulta
        Catch ex As Exception
        End Try
    End Sub
End Class
