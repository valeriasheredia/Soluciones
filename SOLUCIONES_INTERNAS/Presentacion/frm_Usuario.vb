Public Class frm_Usuario
    Dim datacontext As New DataS_Interno
    Public quienllamogrid As DataGridView

    Private Sub frm_Usuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_id_colaborador.Visible = False
        txt_id_usuario.Visible = False
        Label1.Visible = False
        armargrilla()
        cargargrilla()
        dgvLista_Usuarios.ClearSelection()
        txt_usuario.Focus()
        lblTotal_Usuarios.Text = dgvLista_Usuarios.Rows.Count
        txt_nombre_colaborador.Enabled = False
        btnNuevo_Usuario.Visible = False
    End Sub

    Public Sub cargargrilla()
        Dim carga = (From usu In datacontext.USUARIO
                                    Join col In datacontext.COLABORADOR
                                    On usu.COL_id_colaborador Equals col.COL_id_colaborador
                                    Select usu.USU_id_usuario, usu.USU_usuario, usu.USU_contraseña, usu.USU_perfil, col.COL_id_colaborador, col.COL_nombre_col
                                    Order By COL_nombre_col Ascending)
        dgvLista_Usuarios.DataSource = carga
    End Sub

    Private Sub armargrilla()
        dgvLista_Usuarios.Enabled = True
        dgvLista_Usuarios.AutoGenerateColumns = False
        dgvLista_Usuarios.Columns.Clear()

        dgvLista_Usuarios.Columns.Add("USU_id_usuario", "id_usuario")
        dgvLista_Usuarios.Columns.Add("USU_usuario", "Usuario")
        dgvLista_Usuarios.Columns.Add("USU_perfil", "Perfil")
        dgvLista_Usuarios.Columns.Add("COL_id_colaborador", "id_colaborador")
        dgvLista_Usuarios.Columns.Add("COL_nombre_col", "Colaborador")
        dgvLista_Usuarios.Columns.Add("USU_contraseña", "Contraseña")

        dgvLista_Usuarios.Columns(0).DataPropertyName = "USU_id_usuario"
        dgvLista_Usuarios.Columns(0).Visible = False
        dgvLista_Usuarios.Columns(1).DataPropertyName = "USU_usuario"
        dgvLista_Usuarios.Columns(2).DataPropertyName = "USU_perfil"
        dgvLista_Usuarios.Columns(3).DataPropertyName = "COL_id_colaborador"
        dgvLista_Usuarios.Columns(3).Visible = False
        dgvLista_Usuarios.Columns(4).DataPropertyName = "COL_nombre_col"
        dgvLista_Usuarios.Columns(5).DataPropertyName = "USU_contraseña"
    End Sub

    Private Sub btnGuardar_Usuario_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar_Usuario.Click
        Try
            Dim buscacliente = (From cli In datacontext.USUARIO
                                Select
                                cli.USU_usuario,
                                cli.USU_contraseña,
                                cli.USU_perfil,
                                cli.COL_id_colaborador
                                Where USU_usuario = txt_usuario.Text.ToUpper).Any
            If buscacliente = True Then
                MsgBox("El usuario ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If

            If txt_usuario.Text.Length = 0 Or txt_contraseña.Text.Length = 0 Or cbo_perfil.Text.Length = 0 Or txt_id_colaborador.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If

            Dim clie = New USUARIO
            clie.USU_usuario = txt_usuario.Text
            clie.USU_contraseña = txt_contraseña.Text
            clie.USU_perfil = cbo_perfil.SelectedItem
            clie.COL_id_colaborador = txt_id_colaborador.Text

            datacontext.USUARIO.InsertOnSubmit(clie)
            datacontext.SubmitChanges()
            MsgBox("El usuario se ha creado correctamente", vbInformation)
            cargargrilla()
            limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("El usuario NO fue creado")
            limpiarcontroles()
            cargargrilla()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_id_usuario.Clear()
        txt_usuario.Clear()
        txt_contraseña.Clear()
        cbo_perfil.SelectedIndex = -1
        txt_id_colaborador.Clear()
        txt_nombre_colaborador.Clear()
        btnActualizar_Usuario.Enabled = False
        btnGuardar_Usuario.Enabled = True
    End Sub

    Private Sub btnActualizar_Usuario_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar_Usuario.Click
        If txt_usuario.Text.Length = 0 Or txt_contraseña.Text.Length = 0 Or cbo_perfil.Text.Length = 0 Or txt_id_colaborador.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarCliente = (From P In datacontext.USUARIO Where P.USU_id_usuario = (txt_id_usuario.Text.ToUpper)).ToList()(0)
            ActualizarCliente.USU_usuario = txt_usuario.Text
            ActualizarCliente.USU_contraseña = txt_contraseña.Text
            ActualizarCliente.USU_perfil = cbo_perfil.SelectedItem
            ActualizarCliente.COL_id_colaborador = txt_id_colaborador.Text

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            cargargrilla()
            Me.limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar usuario")
            Me.limpiarcontroles()
            Me.cargargrilla()
        End Try
    End Sub

    Private Sub btnEliminar_Usuario_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar_Usuario.Click
        If dgvLista_Usuarios.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.USUARIO Where C.USU_id_usuario = CInt(dgvLista_Usuarios.Item("USU_id_usuario", dgvLista_Usuarios.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el usuario seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar usuario")
                Case MsgBoxResult.Yes
                    datacontext.USUARIO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El usuario ha sido eliminado")
                    Me.Close()
                    cargargrilla()
                    lblTotal_Usuarios.Text = dgvLista_Usuarios.Rows.Count
                Case MsgBoxResult.No
                    Me.Close()
            End Select
        Else
            MsgBox("Debe seleccionar un usuario")
        End If
    End Sub

    Private Sub btnNuevo_Usuario_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo_Usuario.Click
        Select Case MsgBox("Se limpiarán todos los campos, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Limpiar campos")
            Case MsgBoxResult.Yes
                limpiarcontroles()
        End Select
    End Sub

    Private Sub btnCancelar_Usuario_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar_Usuario.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_Buscar_Usuario_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Buscar_Usuario.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = "*" & Me.txt_Buscar_Usuario.Text & "*"
        Dim consultausuario = From U In datacontext.USUARIO
                              Join C In datacontext.COLABORADOR
                              On C.COL_id_colaborador Equals U.COL_id_colaborador
                              Select
                              U.USU_id_usuario,
                              U.USU_usuario,
                              U.USU_contraseña,
                              U.USU_perfil,
                              C.COL_nombre_col,
                              U.COL_id_colaborador Where USU_usuario Like buscar.ToString
        dgvLista_Usuarios.DataSource = consultausuario
        dgvLista_Usuarios.ClearSelection()
    End Sub

    Private Sub txt_usuario_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_contraseña.Focus()
        End If
    End Sub

    Private Sub txt_contraseña_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_contraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_perfil.Focus()
        End If
    End Sub

    Private Sub cbo_perfil_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cbo_perfil.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscar_Colaborador.Focus()
        End If
    End Sub

    Private Sub dgvLista_Usuarios_Click(sender As Object, e As System.EventArgs) Handles dgvLista_Usuarios.Click
        If dgvLista_Usuarios.SelectedRows.Count > 0 Then
            txt_id_usuario.Text = dgvLista_Usuarios.Item("USU_id_usuario", dgvLista_Usuarios.SelectedRows(0).Index).Value
            txt_usuario.Text = dgvLista_Usuarios.Item("USU_usuario", dgvLista_Usuarios.SelectedRows(0).Index).Value
            txt_contraseña.Text = dgvLista_Usuarios.Item("USU_contraseña", dgvLista_Usuarios.SelectedRows(0).Index).Value
            cbo_perfil.Text = dgvLista_Usuarios.Item("USU_perfil", dgvLista_Usuarios.SelectedRows(0).Index).Value
            txt_id_colaborador.Text = dgvLista_Usuarios.Item("COL_id_colaborador", dgvLista_Usuarios.SelectedRows(0).Index).Value
            txt_nombre_colaborador.Text = dgvLista_Usuarios.Item("COL_nombre_col", dgvLista_Usuarios.SelectedRows(0).Index).Value
            ' btnActualizar_Usuario.Enabled = True
        Else
            MsgBox("Debe seleccionar un usuario")
        End If
    End Sub

    Private Sub btnBuscar_Colaborador_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Colaborador.Click
        frm_Colaborador.quienllamo_col = Me
        frm_Colaborador.Text = "Seleccionar Colaborador"
        frm_Colaborador.GroupNuevoColaborador.Enabled = False
        frm_Colaborador.btnEliminar_Colaborador.Enabled = False
        '  frm_Colaborador.btnImprimir.Visible = False
        frm_Colaborador.dgvLista_Colaboradores.ClearSelection()
        frm_Colaborador.ShowDialog()
    End Sub

    Private Sub frm_Usuario_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub dgvLista_Usuarios_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Usuarios.CellClick
        Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt_usuario_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_usuario.TextChanged

    End Sub

    Private Sub txt_contraseña_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_contraseña.TextChanged

    End Sub
End Class