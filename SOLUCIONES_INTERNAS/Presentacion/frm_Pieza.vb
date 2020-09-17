Public Class frm_Pieza

    Dim datacontext As New DataS_Interno

    Private Sub frm_Pieza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_id_pieza.Visible = False
        Label1.Visible = False
        armargrilla()
        cargargrilla()
        dgvLista_Piezas.ClearSelection()
        Label6.Text = dgvLista_Piezas.Rows.Count
    End Sub

    Public Sub cargargrilla()
        Dim consultaCliente = From U In datacontext.PIEZA
                              Select U.PIE_id_pieza, U.PIE_nombre_pie
                              Order By PIE_nombre_pie Ascending
        dgvLista_Piezas.DataSource = consultaCliente
    End Sub

    Private Sub armargrilla()
        dgvLista_Piezas.Enabled = True
        dgvLista_Piezas.AutoGenerateColumns = False
        dgvLista_Piezas.Columns.Clear()

        dgvLista_Piezas.Columns.Add("PIE_id_pieza", "id_pieza")
        dgvLista_Piezas.Columns.Add("PIE_nombre_pie", "Nombre de Pieza")
   

        dgvLista_Piezas.Columns(0).DataPropertyName = "PIE_id_pieza"
        dgvLista_Piezas.Columns(0).Visible = False
        dgvLista_Piezas.Columns(1).DataPropertyName = "PIE_nombre_pie"
        dgvLista_Piezas.Columns(1).Width = 300
    End Sub

    Private Sub btnGuardar_Pieza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Pieza.Click
        Try
            Dim buscacliente = (From cli In datacontext.PIEZA Select cli.PIE_nombre_pie Where PIE_nombre_pie = txt_nombre_pieza.Text.ToUpper).Any
            If buscacliente = True Then
                MsgBox("La pieza ingresada ya existe")
                limpiarcontroles()
                Exit Sub
            End If

            If txt_nombre_pieza.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub

            End If
            Dim clie = New PIEZA
            clie.PIE_nombre_pie = StrConv(txt_nombre_pieza.Text, VbStrConv.ProperCase)

            datacontext.PIEZA.InsertOnSubmit(clie)
            datacontext.SubmitChanges()
            MsgBox("La pieza se ha creado correctamente", vbInformation)
            cargargrilla()
            limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("La pieza NO fue creada")
            limpiarcontroles()
            cargargrilla()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_id_pieza.Clear()
        txt_nombre_pieza.Clear()
    End Sub

    Private Sub btnActualizar_Pieza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar_Pieza.Click
        If txt_nombre_pieza.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarCliente = (From P In datacontext.PIEZA Where P.PIE_id_pieza = (txt_id_pieza.Text.ToUpper)).ToList()(0)
            ActualizarCliente.PIE_nombre_pie = StrConv(txt_nombre_pieza.Text, VbStrConv.ProperCase)

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            cargargrilla()
            Me.limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Pieza")
            Me.limpiarcontroles()
            Me.cargargrilla()
        End Try
    End Sub

    Private Sub dgvLista_Piezas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista_Piezas.Click
        If dgvLista_Piezas.SelectedRows.Count > 0 Then
            txt_id_pieza.Text = dgvLista_Piezas.Item("PIE_id_pieza", dgvLista_Piezas.SelectedRows(0).Index).Value
            txt_nombre_pieza.Text = dgvLista_Piezas.Item("PIE_nombre_pie", dgvLista_Piezas.SelectedRows(0).Index).Value
        Else
            MsgBox("Debe seleccionar una pieza")
        End If
    End Sub

    Private Sub btnEliminar_Pieza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Pieza.Click
        If dgvLista_Piezas.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.PIEZA Where C.PIE_id_pieza = CInt(dgvLista_Piezas.Item("PIE_id_pieza", dgvLista_Piezas.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará la pieza seleccionada, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar pieza")
                Case MsgBoxResult.Yes
                    datacontext.PIEZA.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("La pieza ha sido eliminada")
                    cargargrilla()
            End Select
        Else
            MsgBox("Debe seleccionar una pieza")
        End If
    End Sub

    Private Sub btnNuevo_Pieza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo_Pieza.Click
        limpiarcontroles()
    End Sub

    Private Sub btnCancelar_Pieza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar_Pieza.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_Buscar_Pieza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_Pieza.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = "*" & Me.txt_Buscar_Pieza.Text & "*"
        Dim consultaalu = From U In datacontext.PIEZA Select U.PIE_id_pieza, U.PIE_nombre_pie Where PIE_nombre_pie Like buscar.ToString
        dgvLista_Piezas.DataSource = consultaalu
    End Sub

    Private Sub txt_nombre_pieza_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nombre_pieza.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGuardar_Pieza.Focus()
        End If
    End Sub

    Private Sub frm_Pieza_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub dgvLista_Piezas_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Piezas.CellClick
        Try
        Catch ex As Exception
        End Try
    End Sub

End Class