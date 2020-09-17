Public Class frm_Vendedor

    Dim datacontext As New DataS_Interno
    Public quienllamovendedor As Form

    Private Sub Vendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_id_vendedor.Visible = False
        btnNuevo_Vendedor.Visible = False
        Label1.Visible = False
        armargrilla()
        cargargrilla()
        lblTotal_Vendedores.Text = dgvLista_vendedores.Rows.Count
    End Sub

    Private Sub btnGuardar_Vendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Vendedor.Click
        Try
            Dim buscacliente = (From cli In datacontext.VENDEDOR Select cli.VEN_nombre_ven, cli.VEN_apellido_ven, cli.VEN_mail_ven, cli.VEN_telefono_ven Where VEN_nombre_ven = txt_nombre_vendedor.Text.ToUpper).Any
            If buscacliente = True Then
                MsgBox("El Vendedor ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If
            If txt_nombre_vendedor.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If
            Dim clie = New VENDEDOR
            clie.VEN_nombre_ven = StrConv(txt_nombre_vendedor.Text, VbStrConv.ProperCase)
            clie.VEN_apellido_ven = StrConv(txt_apellido_vendedor.Text, VbStrConv.ProperCase)
            clie.VEN_mail_ven = StrConv(txt_mail_vendedor.Text, VbStrConv.ProperCase)
            clie.VEN_telefono_ven = StrConv(txt_telefono_vendedor.Text, VbStrConv.ProperCase)


            datacontext.VENDEDOR.InsertOnSubmit(clie)
            datacontext.SubmitChanges()
            MsgBox("El Vendedor se ha creado correctamente", vbInformation)
            cargargrilla()
            limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("El Vendedor NO fue creado")
            limpiarcontroles()
            cargargrilla()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_nombre_vendedor.Clear()
        txt_apellido_vendedor.Clear()
        txt_mail_vendedor.Clear()
        txt_telefono_vendedor.Clear()
        txt_id_vendedor.Clear()

    End Sub

    Private Sub btnActualizar_Vendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar_Vendedor.Click
        If txt_nombre_vendedor.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarCliente = (From P In datacontext.VENDEDOR Where P.VEN_id_vendedor = (txt_id_vendedor.Text.ToUpper)).ToList()(0)
            ActualizarCliente.VEN_nombre_ven = StrConv(txt_nombre_vendedor.Text, VbStrConv.ProperCase)
            ActualizarCliente.VEN_apellido_ven = StrConv(txt_apellido_vendedor.Text, VbStrConv.ProperCase)
            ActualizarCliente.VEN_mail_ven = StrConv(txt_mail_vendedor.Text, VbStrConv.ProperCase)
            ActualizarCliente.VEN_telefono_ven = StrConv(txt_telefono_vendedor.Text, VbStrConv.ProperCase)

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            cargargrilla()
            Me.limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar vendedor")
            Me.limpiarcontroles()
            Me.cargargrilla()
        End Try
    End Sub

    Public Sub cargargrilla()
        Dim consultaCliente = From U In datacontext.VENDEDOR
                              Select U.VEN_id_vendedor, U.VEN_nombre_ven, U.VEN_apellido_ven, U.VEN_mail_ven, U.VEN_telefono_ven
                              Order By VEN_nombre_ven Ascending
        dgvLista_vendedores.DataSource = consultaCliente
    End Sub

    Private Sub armargrilla()
        dgvLista_vendedores.Enabled = True
        dgvLista_vendedores.AutoGenerateColumns = False
        dgvLista_vendedores.Columns.Clear()

        dgvLista_vendedores.Columns.Add("VEN_id_vendedor", "id_vendedor")
        dgvLista_vendedores.Columns.Add("VEN_nombre_ven", "Nombre")
        dgvLista_vendedores.Columns.Add("VEN_apellido_ven", "Apellido")
        dgvLista_vendedores.Columns.Add("VEN_mail_ven", "Mail")
        dgvLista_vendedores.Columns.Add("VEN_telefono_ven", "Teléfono")

        dgvLista_vendedores.Columns(0).DataPropertyName = "VEN_id_vendedor"
        dgvLista_vendedores.Columns(0).Visible = False
        dgvLista_vendedores.Columns(1).DataPropertyName = "VEN_nombre_ven"
        dgvLista_vendedores.Columns(2).DataPropertyName = "VEN_apellido_ven"
        dgvLista_vendedores.Columns(3).DataPropertyName = "VEN_mail_ven"
        dgvLista_vendedores.Columns(3).Width = 150
        dgvLista_vendedores.Columns(4).DataPropertyName = "VEN_telefono_ven"
    End Sub

    Private Sub dgvLista_Vendedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista_vendedores.Click
        If dgvLista_vendedores.SelectedRows.Count > 0 Then
            txt_id_vendedor.Text = dgvLista_vendedores.Item("VEN_id_vendedor", dgvLista_vendedores.SelectedRows(0).Index).Value
            txt_nombre_vendedor.Text = dgvLista_vendedores.Item("VEN_nombre_ven", dgvLista_vendedores.SelectedRows(0).Index).Value
            txt_apellido_vendedor.Text = dgvLista_vendedores.Item("VEN_apellido_ven", dgvLista_vendedores.SelectedRows(0).Index).Value
            txt_mail_vendedor.Text = dgvLista_vendedores.Item("VEN_mail_ven", dgvLista_vendedores.SelectedRows(0).Index).Value
            txt_telefono_vendedor.Text = dgvLista_Vendedores.Item("VEN_telefono_ven", dgvLista_Vendedores.SelectedRows(0).Index).Value
        Else
            MsgBox("Debe seleccionar un Vendedor")
        End If
    End Sub

    Private Sub btnEliminar_Vendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_vendedor.Click
        If dgvLista_vendedores.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.VENDEDOR Where C.VEN_id_vendedor = CInt(dgvLista_vendedores.Item("VEN_id_vendedor", dgvLista_vendedores.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el vendedor seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar vendedor")
                Case MsgBoxResult.Yes
                    datacontext.VENDEDOR.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El vendedor ha sido eliminado")
                    cargargrilla()
                    Me.Close()
            End Select
        Else
            MsgBox("Debe seleccionar un vendedor")
        End If
    End Sub

    Private Sub btnNuevo_Vendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo_Vendedor.Click
        Select Case MsgBox("Se limpiarán todos los campos, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Limpiar campos")
            Case MsgBoxResult.Yes
                limpiarcontroles()
        End Select
    End Sub

    Private Sub btnCancelar_Vendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar_Vendedor.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_Buscar_Vendedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_vendedor.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = "*" & Me.txt_Buscar_vendedor.Text & "*"
        Dim consultaalu = From U In datacontext.VENDEDOR Select U.VEN_id_vendedor, U.VEN_nombre_ven, U.VEN_apellido_ven, U.VEN_mail_ven, U.VEN_telefono_ven Where VEN_nombre_ven Like buscar.ToString
        dgvLista_vendedores.DataSource = consultaalu
    End Sub

    Private Sub txt_nombre_vendedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nombre_vendedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_apellido_vendedor.Focus()
        End If
    End Sub

    Private Sub txt_apellido_vendedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_apellido_vendedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_mail_vendedor.Focus()
        End If
    End Sub

    Private Sub txt_mail_vendedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_telefono_vendedor.Focus()
        End If
    End Sub

    Private Sub txt_telefono_vendedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnGuardar_Vendedor.Focus()
        End If
    End Sub

    Private Sub dgvLista_vendedores_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_vendedores.CellDoubleClick

        If quienllamovendedor.Name = frm_Orden_Trabajo.Name Then
            frm_Orden_Trabajo.txtid_vendedor.Text = dgvLista_vendedores.SelectedCells(0).Value
            frm_Orden_Trabajo.txtNombre_vendedor.Text = dgvLista_vendedores.SelectedCells(1).Value

        ElseIf quienllamovendedor.Name = frm_Actualizar_Orden.Name Then
            frm_Actualizar_Orden.txtid_vendedor.Text = dgvLista_vendedores.SelectedCells(0).Value
            frm_Actualizar_Orden.txtNombre_vendedor.Text = dgvLista_vendedores.SelectedCells(1).Value

        ElseIf quienllamovendedor.Name = frm_Orden_Trabajo_Ampliada.Name Then
            frm_Orden_Trabajo_Ampliada.txtid_vendedor.Text = dgvLista_vendedores.SelectedCells(0).Value
            frm_Orden_Trabajo_Ampliada.txtNombre_vendedor.Text = dgvLista_vendedores.SelectedCells(1).Value

        End If
        Me.Close()

    End Sub

    Private Sub frm_Vendedor_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub dgvLista_vendedores_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_vendedores.CellClick
        Try
        Catch ex As Exception
        End Try
    End Sub
End Class