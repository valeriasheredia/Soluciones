Public Class frm_Sector
    Dim datacontext As New DataS_Interno

    Private Sub frm_Sector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_id_sector.Visible = False
        Label1.Visible = False
        armargrilla()
        cargargrilla()
         Label6.Text = dgvLista_Sector.Rows.Count
    End Sub

    Public Sub cargargrilla()
        Dim consultaCliente = From U In datacontext.SECTOR
                              Select U.SEC_id_sector, U.SEC_nombre_sector
                              Order By SEC_nombre_sector Ascending
        dgvLista_Sector.DataSource = consultaCliente
    End Sub

    Private Sub armargrilla()
        dgvLista_Sector.Enabled = True
        dgvLista_Sector.AutoGenerateColumns = False
        dgvLista_Sector.Columns.Clear()

        dgvLista_Sector.Columns.Add("SEC_id_sector", "id_sector")
        dgvLista_Sector.Columns.Add("SEC_nombre_sector", "Nombre del Sector")

        dgvLista_Sector.Columns(0).DataPropertyName = "SEC_id_sector"
        dgvLista_Sector.Columns(0).Visible = False
        dgvLista_Sector.Columns(1).DataPropertyName = "SEC_nombre_sector"
        dgvLista_Sector.Columns(1).Width = 350
    End Sub

    Sub limpiarcontroles()
        txt_id_sector.Clear()
        txt_nombre_sector.Clear()
    End Sub

    Private Sub btnGuardar_Sector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Sector.Click
        Try
            Dim buscasector = (From sec In datacontext.SECTOR Select sec.SEC_nombre_sector Where SEC_nombre_sector = txt_nombre_sector.Text.ToUpper).Any
            If buscasector = True Then
                MsgBox("El sector ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If

            If txt_nombre_sector.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub

            End If
            Dim clie = New SECTOR
            clie.SEC_nombre_sector = StrConv(txt_nombre_sector.Text, VbStrConv.ProperCase)

            datacontext.SECTOR.InsertOnSubmit(clie)
            datacontext.SubmitChanges()
            MsgBox("El sector se ha creado correctamente", vbInformation)
            cargargrilla()
            limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("El sector NO fue creado")
            limpiarcontroles()
            cargargrilla()
        End Try
    End Sub

    Private Sub btnActualizar_Sector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar_Sector.Click
        If txt_nombre_sector.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarCliente = (From P In datacontext.SECTOR Where P.SEC_id_sector = (txt_id_sector.Text.ToUpper)).ToList()(0)
            ActualizarCliente.SEC_nombre_sector = StrConv(txt_nombre_sector.Text, VbStrConv.ProperCase)

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            cargargrilla()
            Me.limpiarcontroles()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Sector")
            Me.limpiarcontroles()
            Me.cargargrilla()
        End Try
    End Sub

    Private Sub dgvLista_Sector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista_Sector.Click
        If dgvLista_Sector.SelectedRows.Count > 0 Then
            txt_id_sector.Text = dgvLista_Sector.Item("SEC_id_sector", dgvLista_Sector.SelectedRows(0).Index).Value
            txt_nombre_sector.Text = dgvLista_Sector.Item("SEC_nombre_sector", dgvLista_Sector.SelectedRows(0).Index).Value
        Else
            MsgBox("Debe seleccionar un sector")
        End If
    End Sub

    Private Sub btnEliminar_Sector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Sector.Click
        If dgvLista_Sector.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.SECTOR Where C.SEC_id_sector = CInt(dgvLista_Sector.Item("SEC_id_sector", dgvLista_Sector.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el sector seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar sector")
                Case MsgBoxResult.Yes
                    datacontext.SECTOR.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El sector ha sido eliminado")
                    cargargrilla()
            End Select
        Else
            MsgBox("Debe seleccionar un sector")
        End If
    End Sub

    Private Sub btnNuevo_Sector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo_Sector.Click
        limpiarcontroles()
    End Sub

    Private Sub btnCancelar_Sector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar_Sector.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_Buscar_Sector_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_Sector.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = "*" & Me.txt_Buscar_Sector.Text & "*"
        Dim consultaalu = From U In datacontext.SECTOR Select U.SEC_id_sector, U.SEC_nombre_sector Where SEC_nombre_sector Like buscar.ToString
        dgvLista_Sector.DataSource = consultaalu
    End Sub

    Private Sub txt_nombre_sector_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nombre_sector.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGuardar_Sector.Focus()
        End If
    End Sub

    Private Sub frm_Sector_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub dgvLista_Sector_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Sector.CellClick
        Try
        Catch ex As Exception
        End Try
    End Sub

  
    'Private Sub btn_informe_sector_Click(sender As System.Object, e As System.EventArgs) Handles btn_informe_sector.Click
    '    Dim dt As New DataS_Reportes
    '    For Each dr As DataGridViewRow In dgvLista_Sector.Rows
    '        dt.DT_Sector.AddDT_SectorRow(dr.Cells("SEC_nombre_sector").Value)
    '    Next
    '    Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    rptdoc = New rpt_sector
    '    rptdoc.SetDataSource(dt)
    '    frm_rpt_sector.CrystalReportViewer1.ReportSource = rptdoc
    '    frm_rpt_sector.Show()
    'End Sub
End Class