Imports System.Windows.Forms.TextBox

Public Class frm_Cliente
    Dim datacontext As New DataS_Interno
    Public quienllamocliente As Form

    Private Sub frm_Cliente_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_id_cliente.Visible = False
        Label1.Visible = False
        armargrilla()
        cargargrilla()
        Label6.Text = dgvLista_Clientes.Rows.Count
        btnNuevo_Cliente.Visible = False
        ' abrir()
        ' autoCompletarTexbox(txt_razonsocial_cliente)
    End Sub

    Private Sub btnGuardar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Cliente.Click
        Try
            Dim buscacliente = (From cli In datacontext.CLIENTE Select cli.CLI_razon_social, cli.CLI_mail_cli, cli.CLI_telefono_cli, cli.CLI_domicilio, cli.CLI_localidad, cli.CLI_codigo_postal
                                Where CLI_razon_social = StrConv(txt_razonsocial_cliente.Text, VbStrConv.ProperCase)).Any
            If buscacliente = True Then
                MsgBox("El cliente ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If
            If txt_razonsocial_cliente.Text.Length = 0 Then
                MsgBox("Debe completar Nombre o Razón Social del Cliente")
                txt_razonsocial_cliente.Focus()
                Exit Sub
            End If
            Dim clie = New CLIENTE
            clie.CLI_razon_social = StrConv(txt_razonsocial_cliente.Text, VbStrConv.ProperCase)
            clie.CLI_mail_cli = txt_mail_cliente.Text
            clie.CLI_telefono_cli = StrConv(txtTelefono_Cliente.Text, VbStrConv.ProperCase)
            clie.CLI_domicilio = StrConv(txt_Domicilio_Cliente.Text, VbStrConv.ProperCase)
            clie.CLI_localidad = StrConv(txt_Localidad_Cliente.Text, VbStrConv.ProperCase)
            clie.CLI_codigo_postal = StrConv(txt_Codigo_Postal_Cliente.Text, VbStrConv.ProperCase)

            datacontext.CLIENTE.InsertOnSubmit(clie)
            datacontext.SubmitChanges()

            Select Case MsgBox("El Cliente fue cargado exitosamente, cargar otro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Nuevo Cliente")
                Case MsgBoxResult.No
                    Me.Close()
                Case MsgBoxResult.Yes
                    cargargrilla()
                    limpiarcontroles()
            End Select
        Catch ex As Exception
            MsgBox("El Cliente no puedo ser cargado")
            limpiarcontroles()
            cargargrilla()
        End Try

    End Sub

    Sub limpiarcontroles()
        txt_id_cliente.Clear()
        txt_razonsocial_cliente.Clear()
        txt_mail_cliente.Clear()
        txt_Domicilio_Cliente.Clear()
        txt_Localidad_Cliente.Clear()
        txt_Codigo_Postal_Cliente.Clear()
        txtTelefono_Cliente.Clear()
    End Sub

    Private Sub btnActualizar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar_Cliente.Click

        If txt_razonsocial_cliente.Text.Length = 0 Then
            MsgBox("Debe completar Nombre o Razón Social del Cliente")
            Exit Sub
        End If
        Try
            Dim ActualizarCliente = (From P In datacontext.CLIENTE Where P.CLI_id_cliente = (txt_id_cliente.Text.ToUpper)).ToList()(0)
            ActualizarCliente.CLI_razon_social = StrConv(txt_razonsocial_cliente.Text, VbStrConv.ProperCase)
            ActualizarCliente.CLI_mail_cli = txt_mail_cliente.Text
            ActualizarCliente.CLI_telefono_cli = StrConv(txtTelefono_Cliente.Text, VbStrConv.ProperCase)
            ActualizarCliente.CLI_domicilio = StrConv(txt_Domicilio_Cliente.Text, VbStrConv.ProperCase)
            ActualizarCliente.CLI_localidad = StrConv(txt_Localidad_Cliente.Text, VbStrConv.ProperCase)
            ActualizarCliente.CLI_codigo_postal = StrConv(txt_Codigo_Postal_Cliente.Text, VbStrConv.ProperCase)

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            cargargrilla()
            Me.limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar cliente")
            Me.limpiarcontroles()
            Me.cargargrilla()
        End Try
    End Sub

    Public Sub cargargrilla()
        Dim consultaCliente = From U In datacontext.CLIENTE
                              Select U.CLI_id_cliente, U.CLI_razon_social, U.CLI_mail_cli, U.CLI_telefono_cli, U.CLI_domicilio, U.CLI_localidad, U.CLI_codigo_postal
        'Order By CLI_razon_social Ascending
        dgvLista_Clientes.DataSource = consultaCliente
    End Sub

    Private Sub armargrilla()
        dgvLista_Clientes.Enabled = True
        dgvLista_Clientes.AutoGenerateColumns = False
        dgvLista_Clientes.Columns.Clear()

        dgvLista_Clientes.Columns.Add("CLI_id_cliente", "id_cliente")
        dgvLista_Clientes.Columns.Add("CLI_razon_social", "Razón Social")
        dgvLista_Clientes.Columns.Add("CLI_mail_cli", "Mail")
        dgvLista_Clientes.Columns.Add("CLI_telefono_cli", "Teléfono")
        dgvLista_Clientes.Columns.Add("CLI_domicilio", "Domicilio")
        dgvLista_Clientes.Columns.Add("CLI_localidad", "Localidad")
        dgvLista_Clientes.Columns.Add("CLI_codigo_postal", "CP")

        dgvLista_Clientes.Columns(0).DataPropertyName = "CLI_id_cliente"
        dgvLista_Clientes.Columns(0).Visible = False
        dgvLista_Clientes.Columns(1).DataPropertyName = "CLI_razon_social"
        dgvLista_Clientes.Columns(1).Width = 200
        dgvLista_Clientes.Columns(2).DataPropertyName = "CLI_mail_cli"
        ' dgvLista_Clientes.Columns(2).Width = 150
        dgvLista_Clientes.Columns(3).DataPropertyName = "CLI_telefono_cli"
        dgvLista_Clientes.Columns(4).DataPropertyName = "CLI_domicilio"
        dgvLista_Clientes.Columns(5).DataPropertyName = "CLI_localidad"
        dgvLista_Clientes.Columns(6).DataPropertyName = "CLI_codigo_postal"

    End Sub


    Private Sub dgvLista_Clientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvLista_Clientes.Click
        Try
            If dgvLista_Clientes.SelectedRows.Count > 0 Then
                txt_id_cliente.Text = dgvLista_Clientes.Item("CLI_id_cliente", dgvLista_Clientes.SelectedRows(0).Index).Value
                txt_razonsocial_cliente.Text = dgvLista_Clientes.Item("CLI_razon_social", dgvLista_Clientes.SelectedRows(0).Index).Value
                txt_mail_cliente.Text = dgvLista_Clientes.Item("CLI_mail_cli", dgvLista_Clientes.SelectedRows(0).Index).Value
                txtTelefono_Cliente.Text = dgvLista_Clientes.Item("CLI_telefono_cli", dgvLista_Clientes.SelectedRows(0).Index).Value
                txt_Domicilio_Cliente.Text = dgvLista_Clientes.Item("CLI_domicilio", dgvLista_Clientes.SelectedRows(0).Index).Value
                txt_Localidad_Cliente.Text = dgvLista_Clientes.Item("CLI_localidad", dgvLista_Clientes.SelectedRows(0).Index).Value
                txt_Codigo_Postal_Cliente.Text = dgvLista_Clientes.Item("CLI_codigo_postal", dgvLista_Clientes.SelectedRows(0).Index).Value
            Else
                MsgBox("Debe seleccionar un Cliente")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Cliente.Click
        If dgvLista_Clientes.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.CLIENTE Where C.CLI_id_cliente = CInt(dgvLista_Clientes.Item("CLI_id_cliente", dgvLista_Clientes.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el Cliente seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar Cliente")
                Case MsgBoxResult.Yes
                    datacontext.CLIENTE.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El Cliente ha sido eliminado correctamente")
                    cargargrilla()
                    Me.Close()
                Case MsgBoxResult.No
                    Me.Close()
            End Select
        Else
            MsgBox("Debe seleccionar un Cliente")
        End If
    End Sub

    Private Sub btnNuevo_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo_Cliente.Click
        Select Case MsgBox("Se limpiarán todos los campos, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Limpiar campos")
            Case MsgBoxResult.Yes
                limpiarcontroles()
        End Select
    End Sub

    Private Sub btnCancelar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar_Cliente.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_Cliente.TextChanged

        Dim buscar As String
        armargrilla()
        buscar = "*" & Me.txt_Buscar_Cliente.Text & "*"
        Dim consultaalu = From U In datacontext.CLIENTE
                          Select U.CLI_id_cliente, U.CLI_razon_social, U.CLI_mail_cli, U.CLI_telefono_cli, U.CLI_domicilio, U.CLI_localidad, U.CLI_codigo_postal
                          Where CLI_razon_social Like buscar.ToString
        dgvLista_Clientes.DataSource = consultaalu
    End Sub

    Private Sub txt_razonsocial_cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_razonsocial_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_mail_cliente.Focus()
        End If
    End Sub

    Private Sub txt_mail_cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_mail_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Codigo_Postal_Cliente.Focus()
        End If
    End Sub

    Private Sub txt_telefono_cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo_Postal_Cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGuardar_Cliente.Focus()
        End If
    End Sub

    Private Sub dgvLista_Clientes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Clientes.CellDoubleClick
        Try
            If quienllamocliente.Name = frm_Etiqueta_Modelo_1.Name Then
                frm_Etiqueta_Modelo_1.txtId_Cliente.Text = dgvLista_Clientes.SelectedCells(0).Value
                frm_Etiqueta_Modelo_1.txtDirigidoA.Text = dgvLista_Clientes.SelectedCells(1).Value
                frm_Etiqueta_Modelo_1.txtDomicilio.Text = dgvLista_Clientes.SelectedCells(4).Value
                frm_Etiqueta_Modelo_1.txtLocalidad.Text = dgvLista_Clientes.SelectedCells(5).Value
                frm_Etiqueta_Modelo_1.txtCodigoPostal.Text = dgvLista_Clientes.SelectedCells(6).Value

            ElseIf quienllamocliente.Name = frm_Orden_Trabajo.Name Then
                frm_Orden_Trabajo.txt_id_cliente.Text = dgvLista_Clientes.SelectedCells(0).Value
                frm_Orden_Trabajo.txt_nombre_cliente.Text = dgvLista_Clientes.SelectedCells(1).Value
                frm_Orden_Trabajo.txt_mejoras.Text = dgvLista_Clientes.SelectedCells(4).Value

            ElseIf quienllamocliente.Name = frm_Actualizar_Orden.Name Then
                frm_Actualizar_Orden.txt_id_cliente.Text = dgvLista_Clientes.SelectedCells(0).Value
                frm_Actualizar_Orden.txt_nombre_cliente.Text = dgvLista_Clientes.SelectedCells(1).Value
                frm_Actualizar_Orden.cboDireccion_Entrega.Text = dgvLista_Clientes.SelectedCells(4).Value

            ElseIf quienllamocliente.Name = frm_Orden_Trabajo_Ampliada.Name Then
                frm_Orden_Trabajo_Ampliada.txt_id_cliente.Text = dgvLista_Clientes.SelectedCells(0).Value
                frm_Orden_Trabajo_Ampliada.txt_nombre_cliente.Text = dgvLista_Clientes.SelectedCells(1).Value
                frm_Orden_Trabajo_Ampliada.cboDireccion_Entrega.Text = dgvLista_Clientes.SelectedCells(4).Value
            End If
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

    Private Sub txt_razonsocial_cliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_razonsocial_cliente.Leave

        'Dim completar = (From C In datacontext.CLIENTE Where C.CLI_razon_social = txt_razonsocial_cliente.Text)

        ''Si el texto no está vacío y no está en la lista
        'If Not String.IsNullOrEmpty(txt_razonsocial_cliente.Text) _
        'AndAlso Not txt_razonsocial_cliente.AutoCompleteCustomSource.Contains(completar) Then
        '    'Obtengo control actual
        '    Dim ctrl As Control = Me.ActiveControl

        '    'Inserto texto en la lista de autocompletar
        '    txt_razonsocial_cliente.AutoCompleteCustomSource.Add(txt_razonsocial_cliente.Text)

        '    'Selecciono control actual
        '    ctrl.Select()
        'End If

    End Sub

    'Sub autoCompletarTexbox(ByVal campoTexto As TextBox)
    '    Try
    '        Dim autocompletar = (From auto In datacontext.CLIENTE
    '                            Select auto.CLI_razon_social).ToList()(0)
    '        While respuesta.Read
    '            campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("CLI_razon_social"))
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    'End Sub

    Private Sub txt_razonsocial_cliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_razonsocial_cliente.TextChanged
        Dim tempstring As String
        tempstring = txt_razonsocial_cliente.Text & "*"
        Dim autocompletar = (From auto In datacontext.CLIENTE
                                            Select auto.CLI_id_cliente, auto.CLI_razon_social, auto.CLI_mail_cli, auto.CLI_telefono_cli, auto.CLI_domicilio, auto.CLI_localidad, auto.CLI_codigo_postal
                                            Where CLI_razon_social Like tempstring)
        dgvLista_Clientes.DataSource = autocompletar
    End Sub
End Class
