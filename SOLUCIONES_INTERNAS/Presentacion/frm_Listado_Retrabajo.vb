Imports System.IO
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frm_Listado_Retrabajo

    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas

    Dim contadorcolumnasvisibles As Integer

    Private Sub frm_Listado_Retrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ArmaGrillaRetrabajo()
        '  CargarGrillaRetrabajo()

        txt_Buscar_ReTrabajo.Enabled = False
        cboBuscar_Mes.Enabled = False
        lblTotal_Retrabajo.Text = dgvLista_ReTrabajos.Rows.Count
        dgvLista_ReTrabajos.ClearSelection()
    End Sub

    'Public Sub CargarGrillaRetrabajo()
    '    Dim carga = (From dot In datacontext.DETALLE_ORDEN_TRABAJO
    '                                Join ret In datacontext.RE_TRABAJO
    '                                On dot.id_detalle_orden_trabajo Equals ret.id_detalle_orden_trabajo
    '                                Join ot In datacontext.ORDEN_TRABAJO
    '                                On ot.ORT_id_orden_trabajo Equals dot.ORT_id_orden_trabajo
    '                                Join pie In datacontext.PIEZA
    '                                On pie.PIE_id_pieza Equals dot.PIE_id_pieza
    '                                Select
    '                                ret.RET_id_retrabajo,
    '                                ot.ORT_id_orden_trabajo,
    '                                ot.ORT_numero_ot,
    '                                ret.RET_cantidad_dort,
    '                                pie.PIE_id_pieza,
    '                                pie.PIE_nombre_pie,
    '                                ret.RET_fecha,
    '                                ret.RET_fecha_entrega,
    '                                dot.DOT_cantidad_producto,
    '                                 dot.DOT_tamaño_producto,
    '                                ret.RET_tipo_impresion_dort,
    '                                  ret.RET_papel_soporte_1,
    '                                ret.RET_papel_soporte_2,
    '                                ret.RET_papel_soporte_3,
    '                                ret.RET_gramaje_soporte_1,
    '                                ret.RET_gramaje_soporte_2,
    '                                ret.RET_gramaje_soporte_3,
    '                                ret.RET_cantidad_soporte_1,
    '                                ret.RET_cantidad_soporte_2,
    '                                ret.RET_cantidad_soporte_3,
    '                                ret.RET_formato_soporte_1,
    '                                ret.RET_formato_soporte_2,
    '                                ret.RET_formato_soporte_3,
    '                                ret.RET_origen_area,
    '                                ret.RET_procedimiento,
    '                                ot.ORT_fecha_ot,
    '                                ot.ORT_fecha_entrega
    'Order By ORT_numero_ot Ascending)
    '    dgvLista_ReTrabajos.DataSource = carga
    'End Sub

    Private Sub ArmaGrillaRetrabajo()
        dgvLista_ReTrabajos.Enabled = True
        dgvLista_ReTrabajos.AutoGenerateColumns = False
        dgvLista_ReTrabajos.Columns.Clear()

        'DATOS RETRABAJOS
        dgvLista_ReTrabajos.Columns.Add("RET_id_retrabajo", "id_retrabajo") '0
        dgvLista_ReTrabajos.Columns.Add("ORT_id_orden_trabajo", "id_orden_trabajo") '1
        dgvLista_ReTrabajos.Columns.Add("ORT_numero_ot", "Número de Orden") '2
        dgvLista_ReTrabajos.Columns.Add("RET_cantidad_dort", "Cantidad Re-Trabajo") '3
        dgvLista_ReTrabajos.Columns.Add("PIE_id_pieza", "id_pieza") '4
        dgvLista_ReTrabajos.Columns.Add("PIE_nombre_pie", "Pieza") '5
        dgvLista_ReTrabajos.Columns.Add("RET_fecha", "Fecha Re-Trabajo") '6
        dgvLista_ReTrabajos.Columns.Add("RET_fecha_entrega", "Fecha de Entrega Re-Trabajo") '7
        dgvLista_ReTrabajos.Columns.Add("DOT_cantidad_dot", "Cantidad Original") '8
        dgvLista_ReTrabajos.Columns.Add("DOT_tamaño_dot", "Tamaño") '9
        dgvLista_ReTrabajos.Columns.Add("RET_tipo_impresion_dort", "Tipo Impresión") '10
        dgvLista_ReTrabajos.Columns.Add("RET_papel_soporte_1", "Papel") '11
        dgvLista_ReTrabajos.Columns.Add("RET_gramaje_soporte_1", "Gramaje") '12
        dgvLista_ReTrabajos.Columns.Add("RET_cantidad_soporte_1", "Cantidad") '13
        dgvLista_ReTrabajos.Columns.Add("RET_formato_soporte_1", "Formato") '14
        dgvLista_ReTrabajos.Columns.Add("RET_papel_soporte_2", "Papel") '15
        dgvLista_ReTrabajos.Columns.Add("RET_gramaje_soporte_2", "Gramaje") '16
        dgvLista_ReTrabajos.Columns.Add("RET_cantidad_soporte_2", "Cantidad") '17
        dgvLista_ReTrabajos.Columns.Add("RET_formato_soporte_2", "Formato") '18
        dgvLista_ReTrabajos.Columns.Add("RET_papel_soporte_3", "Papel") '19
        dgvLista_ReTrabajos.Columns.Add("RET_gramaje_soporte_3", "Gramaje") '20
        dgvLista_ReTrabajos.Columns.Add("RET_cantidad_soporte_3", "Cantidad") '21
        dgvLista_ReTrabajos.Columns.Add("RET_formato_soporte_3", "Formato") '22
        dgvLista_ReTrabajos.Columns.Add("RET_origen_area", "Origen") '23
        dgvLista_ReTrabajos.Columns.Add("RET_procedimiento", "Procedimiento") '24
        dgvLista_ReTrabajos.Columns.Add("ORT_fecha_ot", "Fecha Original") '25
        dgvLista_ReTrabajos.Columns.Add("ORT_fecha_entrega", "Fecha Entrega Original") '26

        dgvLista_ReTrabajos.Columns(0).DataPropertyName = "RET_id_retrabajo"
        dgvLista_ReTrabajos.Columns(0).Visible = False
        dgvLista_ReTrabajos.Columns(1).DataPropertyName = "ORT_id_orden_trabajo"
        dgvLista_ReTrabajos.Columns(1).Visible = False
        dgvLista_ReTrabajos.Columns(2).DataPropertyName = "ORT_numero_ot"
        dgvLista_ReTrabajos.Columns(3).DataPropertyName = "RET_cantidad_dort"
        dgvLista_ReTrabajos.Columns(4).DataPropertyName = "PIE_id_pieza"
        dgvLista_ReTrabajos.Columns(4).Visible = False
        dgvLista_ReTrabajos.Columns(5).DataPropertyName = "PIE_nombre_pie"
        dgvLista_ReTrabajos.Columns(6).DataPropertyName = "RET_fecha"
        dgvLista_ReTrabajos.Columns(7).DataPropertyName = "RET_fecha_entrega"
        dgvLista_ReTrabajos.Columns(8).DataPropertyName = "DOT_cantidad_dot"
        dgvLista_ReTrabajos.Columns(8).Visible = False
        dgvLista_ReTrabajos.Columns(9).DataPropertyName = "DOT_tamaño_dot"
        dgvLista_ReTrabajos.Columns(9).Visible = False
        dgvLista_ReTrabajos.Columns(10).DataPropertyName = "RET_tipo_impresion_dort"
        dgvLista_ReTrabajos.Columns(10).Visible = False
        dgvLista_ReTrabajos.Columns(11).DataPropertyName = "RET_papel_soporte_1"
        dgvLista_ReTrabajos.Columns(12).DataPropertyName = "RET_gramaje_soporte_1"
        dgvLista_ReTrabajos.Columns(13).DataPropertyName = "RET_cantidad_soporte_1"
        dgvLista_ReTrabajos.Columns(14).DataPropertyName = "RET_formato_soporte_1"
        dgvLista_ReTrabajos.Columns(15).DataPropertyName = "RET_papel_soporte_2"
        dgvLista_ReTrabajos.Columns(15).Visible = False
        dgvLista_ReTrabajos.Columns(16).DataPropertyName = "RET_gramaje_soporte_2"
        dgvLista_ReTrabajos.Columns(16).Visible = False
        dgvLista_ReTrabajos.Columns(17).DataPropertyName = "RET_cantidad_soporte_2"
        dgvLista_ReTrabajos.Columns(17).Visible = False
        dgvLista_ReTrabajos.Columns(18).DataPropertyName = "RET_formato_soporte_2"
        dgvLista_ReTrabajos.Columns(18).Visible = False
        dgvLista_ReTrabajos.Columns(19).DataPropertyName = "RET_papel_soporte_3"
        dgvLista_ReTrabajos.Columns(19).Visible = False
        dgvLista_ReTrabajos.Columns(20).DataPropertyName = "RET_gramaje_soporte_3"
        dgvLista_ReTrabajos.Columns(20).Visible = False
        dgvLista_ReTrabajos.Columns(21).DataPropertyName = "RET_cantidad_soporte_3"
        dgvLista_ReTrabajos.Columns(21).Visible = False
        dgvLista_ReTrabajos.Columns(22).DataPropertyName = "RET_formato_soporte_3"
        dgvLista_ReTrabajos.Columns(22).Visible = False
        dgvLista_ReTrabajos.Columns(23).DataPropertyName = "RET_origen_area"
        dgvLista_ReTrabajos.Columns(24).DataPropertyName = "RET_procedimiento"
        dgvLista_ReTrabajos.Columns(25).DataPropertyName = "ORT_fecha_ot"
        dgvLista_ReTrabajos.Columns(25).Visible = False
        dgvLista_ReTrabajos.Columns(26).DataPropertyName = "ORT_fecha_entrega"
        dgvLista_ReTrabajos.Columns(26).Visible = False
    End Sub

    Private Sub btnEliminar_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_ReTrabajo.Click

        If dgvLista_ReTrabajos.SelectedRows.Count > 0 Then
            Dim eliminar = (From C In datacontext.RE_TRABAJO Where C.RET_id_retrabajo = CInt(dgvLista_ReTrabajos.Item("RET_id_retrabajo", dgvLista_ReTrabajos.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el ReTrabajo seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar ReTrabajo")
                Case MsgBoxResult.Yes
                    datacontext.RE_TRABAJO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El ReTrabajo ha sido eliminado")
                    ' CargarGrillaRetrabajo()
                    lblTotal_Retrabajo.Text = dgvLista_ReTrabajos.Rows.Count
                    Me.Close()
            End Select
        Else
            MsgBox("Debe seleccionar un ReTrabajo")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'CONTROLAR BOTON VER

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        'LLENA LOS CAMPOS DE LA ORDEN
        If dgvLista_ReTrabajos.SelectedRows.Count > 0 Then

            frm_retrabajo.txt_id_re_trabajo.Text = dgvLista_ReTrabajos.Item("RET_id_retrabajo", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.txt_id_orden_trabajo.Text = dgvLista_ReTrabajos.Item("ORT_id_orden_trabajo", dgvLista_ReTrabajos.Rows(0).Index).Value
            frm_retrabajo.txtNumero_Orden_Trabajo.Text = dgvLista_ReTrabajos.Item("ORT_numero_ot", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.txt_Cantidad_Retrabajo.Text = dgvLista_ReTrabajos.Item("RET_cantidad_dort", dgvLista_ReTrabajos.Rows(0).Index).Value
            frm_retrabajo.txt_Cantidad_Retrabajo.Text = dgvLista_ReTrabajos.Item("RET_cantidad_dort", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.cboPieza_Original.SelectedText = dgvLista_ReTrabajos.Item("PIE_nombre_pie", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.dtpFecha_Re_Trabajo.Text = dgvLista_ReTrabajos.Item("RET_fecha", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.dtp_Nueva_Fecha_Entrega.Text = dgvLista_ReTrabajos.Item("RET_fecha_entrega", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.txt_Cantidad_Original.Text = dgvLista_ReTrabajos.Item("DOT_cantidad_dot", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.txtTamaño_Original.Text = dgvLista_ReTrabajos.Item("DOT_tamaño_dot", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            ' frm_retrabajo.cboTipoImpresion.Text = dgvLista_ReTrabajos.Item("RET_tipo_impresion_dort", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            'frm_retrabajo.txt_Papel1_Soporte1.Text = dgvLista_ReTrabajos.Item("RET_papel_soporte_1", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            'frm_retrabajo.txt_Gramaje1_Soporte1.Text = dgvLista_ReTrabajos("RET_gramaje_soporte_1", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            'frm_retrabajo.txt_Cantidad1_Soporte1.Text = dgvLista_ReTrabajos("RET_cantidad_soporte_1", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            'frm_retrabajo.cboFormato1_Soporte1.Text = dgvLista_ReTrabajos("RET_formato_soporte_1", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            'frm_retrabajo.txt_Papel2_Soporte1.Text = dgvLista_ReTrabajos.Item("RET_papel_soporte_2", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            'frm_retrabajo.txt_Gramaje2_Soporte1.Text = dgvLista_ReTrabajos("RET_gramaje_soporte_2", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            'frm_retrabajo.txt_Cantidad2_Soporte1.Text = dgvLista_ReTrabajos("RET_cantidad_soporte_2", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            'frm_retrabajo.cboFormato2_Soporte1.Text = dgvLista_ReTrabajos("RET_formato_soporte_2", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            'frm_retrabajo.txt_Papel3_Soporte1.Text = dgvLista_ReTrabajos.Item("RET_papel_soporte_3", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            'frm_retrabajo.txt_Gramaje3_Soporte1.Text = dgvLista_ReTrabajos("RET_gramaje_soporte_3", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            'frm_retrabajo.txt_Cantidad3_Soporte1.Text = dgvLista_ReTrabajos("RET_cantidad_soporte_3", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            'frm_retrabajo.cboFormato3_Soporte1.Text = dgvLista_ReTrabajos("RET_formato_soporte_3", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            'frm_retrabajo.txt_origen.Text = dgvLista_ReTrabajos.Item("RET_origen_area", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.txt_Procedimiento.Text = dgvLista_ReTrabajos.Item("RET_procedimiento", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.dtp_Fecha_Ingreso_Original.Text = dgvLista_ReTrabajos.Item("ORT_fecha_ot", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.dtpFecha_Entrega_Original.Text = dgvLista_ReTrabajos.Item("ORT_fecha_entrega", dgvLista_ReTrabajos.SelectedRows(0).Index).Value

        Else
            MsgBox("Debe seleccionar un ReTrabajo")
            Exit Sub
        End If
        frm_retrabajo.btnGuardar_ReTrabajo.Enabled = False
        frm_retrabajo.btnImprimirFormulario.Enabled = True
        frm_retrabajo.btnBuscar_Numero_Orden1.Enabled = False
        frm_retrabajo.txt_Cantidad_Original.Enabled = False
        frm_retrabajo.txtNumero_Orden_Trabajo.Enabled = False
        frm_retrabajo.txt_Origen_Causa.Enabled = False
        frm_retrabajo.txt_Procedimiento.Enabled = False
        frm_retrabajo.dtp_Fecha_Ingreso_Original.Enabled = False
        frm_retrabajo.Label1.Visible = False
        frm_retrabajo.GroupProducto1.Enabled = False
        frm_retrabajo.txt_id_re_trabajo.Visible = False
        lblTotal_Retrabajo.Text = dgvLista_ReTrabajos.Rows.Count
        frm_retrabajo.Show()
    End Sub

    Private Sub rbtNumeroOrden_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNumeroOrden.CheckedChanged
        cboBuscar_Mes.Enabled = False
        cboBuscar_Mes.SelectedIndex = -1
        txt_Buscar_ReTrabajo.Enabled = True
    End Sub

    Private Sub rbtMes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMes.CheckedChanged
        cboBuscar_Mes.Enabled = True
        txt_Buscar_ReTrabajo.Enabled = False
        txt_Buscar_ReTrabajo.Clear()
    End Sub

    'Private Sub txt_Buscar_ReTrabajo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_ReTrabajo.TextChanged
    '    Dim buscar As String
    '    If rbtNumeroOrden.Checked = True Then
    '        ArmaGrillaRetrabajo()
    '        buscar = "*" & Me.txt_Buscar_ReTrabajo.Text & "*"
    '        Dim consultaalu =
    '             (From dot In datacontext.DETALLE_ORDEN_TRABAJO
    '                                    Join ret In datacontext.RE_TRABAJO
    '                                    On dot.id_detalle_orden_trabajo Equals ret.id_detalle_orden_trabajo
    '                                    Join ort In datacontext.ORDEN_TRABAJO
    '                                    On ort.ORT_id_orden_trabajo Equals dot.ORT_id_orden_trabajo
    '                                    Join pie In datacontext.PIEZA
    '                                    On pie.PIE_id_pieza Equals dot.PIE_id_pieza
    '                                            Select ret.RET_id_retrabajo,
    '                                    dot.PIE_id_pieza,
    '                                    pie.PIE_nombre_pie,
    '                                    ort.ORT_numero_ot,
    '                                    ret.RET_cantidad_dort,
    '                                    ret.RET_tamaño_dort,
    '                                    ret.RET_tipo_impresion_dort,
    '                                    ret.RET_origen_area,
    '                                    ret.RET_procedimiento,
    '                                    ret.RET_fecha,
    '                                    ret.RET_papel_soporte_1,
    '                                    ret.RET_papel_soporte_2,
    '                                    ret.RET_papel_soporte_3,
    '                                    ret.RET_gramaje_soporte_1,
    '                                    ret.RET_gramaje_soporte_2,
    '                                    ret.RET_gramaje_soporte_3,
    '                                    ret.RET_cantidad_soporte_1,
    '                                    ret.RET_cantidad_soporte_2,
    '                                    ret.RET_cantidad_soporte_3,
    '                                    ret.RET_formato_soporte_1,
    '                                    ret.RET_formato_soporte_2,
    '                                    ret.RET_formato_soporte_3,
    '                                    ort.ORT_id_orden_trabajo,
    '                                    dot.id_detalle_orden_trabajo
    '                                    Where ORT_numero_ot Like buscar.ToString
    '                                    Order By ORT_numero_ot Ascending)
    '        dgvLista_ReTrabajos.DataSource = consultaalu
    '        lblTotal_Retrabajo.Text = dgvLista_ReTrabajos.Rows.Count
    '    End If
    'End Sub

    'Private Sub cboBuscar_Mes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuscar_Mes.SelectedIndexChanged
    '    If rbtMes.Checked = True Then
    '        Dim buscar As String
    '        ArmaGrillaRetrabajo()
    '        buscar = Me.cboBuscar_Mes.SelectedItem & "*"
    '        Dim consultaalu =
    '             (From dot In datacontext.DETALLE_ORDEN_TRABAJO
    '                                    Join ret In datacontext.RE_TRABAJO
    '                                    On dot.id_detalle_orden_trabajo Equals ret.id_detalle_orden_trabajo
    '                                    Join ort In datacontext.ORDEN_TRABAJO
    '                                    On ort.ORT_id_orden_trabajo Equals dot.ORT_id_orden_trabajo
    '                                    Join pie In datacontext.PIEZA
    '                                    On pie.PIE_id_pieza Equals dot.PIE_id_pieza
    '                                    Select ret.RET_id_retrabajo,
    '                                    dot.PIE_id_pieza,
    '                                    pie.PIE_nombre_pie,
    '                                    ort.ORT_numero_ot,
    '                                    ret.RET_cantidad_dort,
    '                                    ret.RET_tamaño_dort,
    '                                    ret.RET_tipo_impresion_dort,
    '                                    ret.RET_origen_area,
    '                                    ret.RET_procedimiento,
    '                                    ret.RET_fecha,
    '                                    ret.RET_papel_soporte_1,
    '                                    ret.RET_papel_soporte_2,
    '                                    ret.RET_papel_soporte_3,
    '                                    ret.RET_gramaje_soporte_1,
    '                                    ret.RET_gramaje_soporte_2,
    '                                    ret.RET_gramaje_soporte_3,
    '                                    ret.RET_cantidad_soporte_1,
    '                                    ret.RET_cantidad_soporte_2,
    '                                    ret.RET_cantidad_soporte_3,
    '                                    ret.RET_formato_soporte_1,
    '                                    ret.RET_formato_soporte_2,
    '                                    ret.RET_formato_soporte_3,
    '                                    ort.ORT_id_orden_trabajo,
    '                                    dot.id_detalle_orden_trabajo
    '                                    Where (RET_fecha.Value.Month = cboBuscar_Mes.SelectedIndex + 1))
    '        dgvLista_ReTrabajos.DataSource = consultaalu
    '        lblTotal_Retrabajo.Text = dgvLista_ReTrabajos.Rows.Count
    '    End If
    'End Sub

    Private Sub btnGenerarInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarPDF.Click


        Try
            'intentar generar el documento
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'path que guarda el reporte en el escritorio de windows (desktop)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Listado de Re-Trabajos.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
            Me.Close()
        Catch ex As Exception
            'si el mensaje es fallido mostrar msgbox
            MessageBox.Show("No se puede generar el pdf, cierre el pdf anterior y vuleva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ExportarDatosPDF(ByVal document As Document)

        For c = 0 To dgvLista_ReTrabajos.ColumnCount - 1
            If dgvLista_ReTrabajos.Columns(c).Visible = True Then
                contadorcolumnasvisibles = contadorcolumnasvisibles + 1
            End If
        Next
        'se crea un objeto PDFTable con el numero de columnas  del datagridview
        Dim datatable As New PdfPTable(contadorcolumnasvisibles)

        'se asignan algunas propiedades para el diseño del PDF
        datatable.DefaultCell.Padding = 3

        'Dim headerwidths As Single() = GetColumnsSize(dgvLista_ReTrabajos)
        'datatable.SetWidths(headerwidths)

        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        'se crea el encabezado en el PDF
        '  Dim encabezado As New Paragraph("Tareas de: " + dgvLista_ReTrabajos.Item("COL_nombre_col", dgvLista_ReTrabajos.SelectedRows(0).Index).Value, New Font(Font.Name = "Tahoma", 16, Font.Bold))

        'se crea el texto abajo del encabezado
        Dim texto As New Phrase("Los re-trabajos realizados hasta la fecha " + Now.Date() + " son los siguientes:", New Font(Font.Name = "Tahoma", 14, Font.Bold))
        '  Dim texto As New Phrase("Fecha: " + dtpFecha.Text, New Font(Font.Name = "Tahoma", 12, Font.Bold))
        'se capturan los nombres de las columnas del datagridview
        For i As Integer = 0 To dgvLista_ReTrabajos.ColumnCount - 1
            If dgvLista_ReTrabajos.Columns(i).Visible = True Then
                datatable.AddCell(dgvLista_ReTrabajos.Columns(i).HeaderText)
            End If
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        'se generan las columnas del datagridview

        For i As Integer = 0 To dgvLista_ReTrabajos.RowCount - 1

            For j As Integer = 0 To dgvLista_ReTrabajos.ColumnCount - 1
                If dgvLista_ReTrabajos.Columns(j).Visible = True Then
                    Try
                        datatable.AddCell(dgvLista_ReTrabajos(j, i).Value.ToString())
                    Catch ex As Exception
                        datatable.AddCell(" ")
                    End Try
                End If
            Next
            datatable.CompleteRow()
        Next
        '  document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub

    Public Function GetColumnsSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de las columnas del datagridview
        Dim indice_array As Integer = 0
        Dim values As Single() = New Single(contadorcolumnasvisibles - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            If dgvLista_ReTrabajos.Columns(i).Visible = True Then
                values(indice_array) = CSng(dg.Columns(i).Width)
                indice_array = indice_array + 1
            End If
        Next
        Return values
    End Function

    Private Sub frm_Listado_Retrabajo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class
