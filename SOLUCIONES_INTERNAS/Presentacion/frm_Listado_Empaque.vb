Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frm_Listado_Empaque
    Dim datacontext As New DataS_Interno
    Dim datacontextvistas As New DataS_Interno_Vistas

    Dim fuente As iTextSharp.text.pdf.BaseFont = FontFactory.GetFont(FontFactory.HELVETICA).BaseFont
    Public quien_llamo_listado_empaque As Form = Me
    Dim flag_controlar_filas As Integer = 0
    Dim flag_load As Integer = 0

    Public Sub frm_Listado_Despacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        armargrilla_planificacion()

        If quien_llamo_listado_empaque.Name = frm_Despacho.Name Then
            rbt_rango_sinenviar.Checked = True
        Else
            rbt_rango_todas.Checked = True
        End If

        rbt_entrega.Checked = True
        dtp_fecha_salida_ValueChanged(Nothing, Nothing)
    End Sub

    Sub armargrilla_planificacion()
        dgv_planificacion.AutoGenerateColumns = False
        dgv_planificacion.Columns.Clear()

        Dim estados As New DataGridViewComboBoxColumn
        estados.HeaderText = "Estado"
        estados.Name = "DES_EMB_estado"

        ''LISTA DE CHOFERES. OJO! TIENE QUE COINCIDIR CON LA LISTA DEL COMBOBOX DEL FRM_DESPACHO
        ''Y CON EL COMBOBOX DE BUSQUEDA DEL FORM LISTADO EMPAQUE
        estados.Items.Add("PLANIFICADO")
        estados.Items.Add("IMPRESION")
        estados.Items.Add("TERMINACION")
        estados.Items.Add("TERCERO")
        estados.Items.Add("ENTREGADO")


        dgv_planificacion.Columns.Add("DES_Id", "DES_Id")
        dgv_planificacion.Columns("DES_Id").Visible = False
        dgv_planificacion.Columns.Add("ORT_id_orden_trabajo", "Id_Odt")
        dgv_planificacion.Columns("ORT_id_orden_trabajo").Visible = False
        dgv_planificacion.Columns.Add("ORT_numero_ot", "Odt")
        dgv_planificacion.Columns.Add("DES_EMB_bultos", "Bultos")
        dgv_planificacion.Columns.Add(estados)
        dgv_planificacion.Columns.Add("DES_EMB_fecha_estado", "Fecha estado")
        dgv_planificacion.Columns.Add("DES_EMB_observaciones", "Observaciones de empaque")
        dgv_planificacion.Columns.Add("CLI_razon_social", "Cliente")
        dgv_planificacion.Columns.Add("ORT_observaciones_ot", "Observaciones Odt")


        dgv_planificacion.Columns("DES_Id").DataPropertyName = "des_id"
        dgv_planificacion.Columns("ORT_id_orden_trabajo").DataPropertyName = "ORT_id_orden_trabajo"
        dgv_planificacion.Columns("ORT_numero_ot").DataPropertyName = "ORT_numero_ot"
        dgv_planificacion.Columns("DES_EMB_bultos").DataPropertyName = "DES_EMB_bultos"
        dgv_planificacion.Columns("DES_EMB_estado").DataPropertyName = "DES_EMB_estado"
        dgv_planificacion.Columns("DES_EMB_fecha_estado").DataPropertyName = "DES_EMB_fecha_estado"
        dgv_planificacion.Columns("DES_EMB_observaciones").DataPropertyName = "DES_EMB_observaciones"
        dgv_planificacion.Columns("CLI_razon_social").DataPropertyName = "CLI_razon_social"
        dgv_planificacion.Columns("ORT_observaciones_ot").DataPropertyName = "ORT_observaciones_ot"


        dgv_planificacion.Columns("ORT_numero_ot").ReadOnly = True
        dgv_planificacion.Columns("CLI_razon_social").ReadOnly = True
        dgv_planificacion.Columns("ORT_observaciones_ot").ReadOnly = True

        'original

        If btn_modificar.Visible = True Then
            dgv_planificacion.Columns("DES_EMB_bultos").ReadOnly = False
            dgv_planificacion.Columns("DES_EMB_estado").ReadOnly = False
            dgv_planificacion.Columns("DES_EMB_fecha_estado").ReadOnly = False
            dgv_planificacion.Columns("DES_EMB_observaciones").ReadOnly = False
        Else
            dgv_planificacion.Columns("DES_EMB_bultos").ReadOnly = True
            dgv_planificacion.Columns("DES_EMB_estado").ReadOnly = True
            dgv_planificacion.Columns("DES_EMB_fecha_estado").ReadOnly = True
            dgv_planificacion.Columns("DES_EMB_observaciones").ReadOnly = True
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Try
            If dgv_planificacion.SelectedRows.Count > 0 Then
                Dim eliminar = (From C In datacontext.DESPACHO Where C.DES_id = CInt(dgv_planificacion.Item("DES_id", dgv_planificacion.SelectedRows(0).Index).Value)).ToList()(0)
                Select Case MsgBox("Se quitará la órden de la planificación, continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Desplanificar órden")
                    Case MsgBoxResult.Yes
                        datacontext.DESPACHO.DeleteOnSubmit(eliminar)
                        datacontext.SubmitChanges()
                        MsgBox("La orden ha sido desplanificada")
                        armargrilla_planificacion()
                End Select
            Else
                MsgBox("Debe seleccionar una orden")
            End If
        Catch ex As Exception
            MsgBox("La orden no fue desplanificada")
        End Try
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        Try
            Dim cont_filas = dgv_planificacion.RowCount
            For i = 0 To cont_filas - 1
                Dim fila As Integer = i
                Dim actualizarplanif = (From P In datacontext.DESPACHO
                                        Where P.DES_id = CInt(dgv_planificacion.Item("DES_Id", fila).Value)).ToList()(0)

                actualizarplanif.DES_EMB_bultos = dgv_planificacion.Item("DES_EMB_bultos", i).Value
                actualizarplanif.DES_EMB_estado = dgv_planificacion.Item("DES_EMB_estado", i).Value
                actualizarplanif.DES_EMB_fecha_estado = CDate(dgv_planificacion.Item("DES_EMB_fecha_estado", i).Value)
                actualizarplanif.DES_EMB_observaciones = dgv_planificacion.Item("DES_EMB_observaciones", i).Value

                datacontext.SubmitChanges()
            Next

            MsgBox("Los datos se han modificado correctamente")
            armargrilla_planificacion()

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Empaque")
        End Try
    End Sub

    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        If rbt_orden.Checked = True Then
            If rbt_rango_enviadas.Checked = True Then
                dgv_planificacion.DataSource = query("orden", "enviadas")
            ElseIf rbt_rango_sinenviar.Checked = True Then
                dgv_planificacion.DataSource = query("orden", "sinenviar")
            Else
                dgv_planificacion.DataSource = query("orden", "todas")
            End If
        End If
    End Sub

    Private Sub dtp_fecha_salida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fecha_estado.ValueChanged
        If rbt_rango_enviadas.Checked = True Then
            dgv_planificacion.DataSource = query("fecha", "enviadas")
        ElseIf rbt_rango_sinenviar.Checked = True Then
            dgv_planificacion.DataSource = query("fecha", "sinenviar")
        Else
            dgv_planificacion.DataSource = query("fecha", "todas")
        End If
    End Sub

    Private Sub rbt_remito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_orden.CheckedChanged
        If rbt_orden.Checked = True Then
            radiobutton(True, False, False)
        Else
            radiobutton(False, False, False)
        End If
    End Sub

    Private Sub rbt_despacho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_estado.CheckedChanged
        If rbt_estado.Checked = True Then
            radiobutton(False, True, False)
        Else
            radiobutton(False, False, False)
        End If
    End Sub

    Private Sub rbt_entrega_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_entrega.CheckedChanged
        If rbt_entrega.Checked = True Then
            radiobutton(False, False, True)

            If rbt_rango_enviadas.Checked = True Then
                dgv_planificacion.DataSource = query("fecha", "enviadas")
            ElseIf rbt_rango_sinenviar.Checked = True Then
                dgv_planificacion.DataSource = query("fecha", "sinenviar")
            Else
                dgv_planificacion.DataSource = query("fecha", "todas")
            End If
        Else
            radiobutton(False, False, False)
        End If

    End Sub

    Sub radiobutton(ByVal buscar As Boolean, ByVal estado As Boolean, ByVal fecha As Boolean)
        txt_buscar.Enabled = buscar
        cmb_estado.Enabled = estado
        dtp_fecha_estado.Enabled = fecha

        txt_buscar.Clear()
        cmb_estado.Text = ""

        If rbt_entrega.Checked <> True Then
            dgv_planificacion.Rows.Clear()
            dtp_fecha_estado.Visible = False
        Else
            dtp_fecha_estado.Visible = True
        End If
    End Sub

    Private Sub btn_generar_informe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_informe.Click
        Try
            'intentar generar el documento
            Dim doc As New Document(PageSize.A4.Rotate, 5, 5, 5, 5)
            'path que guarda el reporte en el escritorio de windows (desktop)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Planificacion_diaria.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()

            'se crea un objeto PDFTable con el numero de columnas  del datagridview
            Dim datatableencabezado As New PdfPTable(6)
            Dim datatablecuerpo As New PdfPTable(6)

            datatableencabezado.WidthPercentage = 100
            datatableencabezado.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
            datatableencabezado.HeaderRows = 0
            datatableencabezado.DefaultCell.BorderWidth = 1

            datatablecuerpo.WidthPercentage = 100
            datatablecuerpo.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
            datatablecuerpo.HeaderRows = 1
            datatablecuerpo.DefaultCell.BorderWidth = 1

            'se capturan los nombres de las columnas del datagridview de las ordenes por remito
            For Y As Integer = 0 To dgv_planificacion.ColumnCount - 1
                If dgv_planificacion.Columns(Y).Visible = True And dgv_planificacion.Columns(Y).DataPropertyName <> "ORT_observaciones_ot" Then
                    datatableencabezado.AddCell(dgv_planificacion.Columns(Y).HeaderText)
                End If
            Next

            'SE ARMA EL ENCABEZADO COMO TABLA
            'For i = 0 To dgv_planificacion.Rows.Count - 1
            'dgv_planificacion.Rows(i).Selected = True
            'dgv_remitos_CellClick(0, Nothing)

            'For Z As Integer = 0 To dgv_planificacion.ColumnCount - 1
            '    If dgv_planificacion.Columns(Z).Visible = True Then
            '        Try
            '            datatableencabezado.AddCell(dgv_planificacion.Columns(Z).HeaderText + ": " + dgv_planificacion(Z, 0).Value.ToString())
            '        Catch ex As Exception
            '            datatableencabezado.AddCell(" ")
            '        End Try
            '    End If
            'Next
            datatableencabezado.CompleteRow()
            doc.Add(datatableencabezado)
            'datatableencabezado.DeleteBodyRows()

            'se generan las columnas del datagridview de las ordenes por remito

            For Y As Integer = 0 To dgv_planificacion.RowCount - 1
                For Z As Integer = 0 To dgv_planificacion.ColumnCount - 1
                    If dgv_planificacion.Columns(Z).Visible = True And dgv_planificacion.Columns(Z).DataPropertyName <> "ORT_observaciones_ot" Then
                        Try
                            datatablecuerpo.AddCell(dgv_planificacion(Z, Y).Value.ToString())
                        Catch ex As Exception
                            datatablecuerpo.AddCell(" ")
                        End Try
                    End If
                Next
                datatablecuerpo.CompleteRow()
            Next

            doc.Add(datatablecuerpo)
            datatablecuerpo.DeleteBodyRows()

            'Next
            doc.Close()
            Process.Start(filename)

        Catch ex As Exception
            'si el mensaje es fallido mostrar msgbox
            MessageBox.Show("No se puede generar el pdf, cierre el pdf anterior y vuleva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmb_estado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_estado.SelectedIndexChanged
        If rbt_rango_enviadas.Checked = True Then
            dgv_planificacion.DataSource = query("estado", "enviadas")
        ElseIf rbt_rango_sinenviar.Checked = True Then
            dgv_planificacion.DataSource = query("estado", "sinenviar")
        Else
            dgv_planificacion.DataSource = query("estado", "todas")
        End If
    End Sub

    Private Sub dgv_planificacion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_planificacion.CellDoubleClick
        If quien_llamo_listado_empaque.Name = frm_Despacho.Name Then

            For i = 0 To frm_Despacho.dgv_lista_ordenes.RowCount - 2
                If dgv_planificacion.SelectedCells(1).Value = frm_Despacho.dgv_lista_ordenes.Item("Id_Odt", i).Value Then
                    MsgBox("La orden seleccionada ya está agregada")
                    Exit Sub
                End If
            Next

            Dim buscarorden = (From bo In datacontext.DESPACHO Select bo.ORT_id_orden_trabajo, bo.DES_nro_despacho, bo.DES_nro_remito
                                    Where ORT_id_orden_trabajo = CInt(dgv_planificacion.SelectedCells(1).Value) And
                                    DES_nro_despacho.Length <> 0).Any
            If buscarorden = True Then
                Dim buscardespacho = (From bo In datacontext.DESPACHO Select bo.ORT_id_orden_trabajo, bo.DES_nro_despacho, bo.DES_nro_remito
                              Where ORT_id_orden_trabajo = CInt(dgv_planificacion.SelectedCells(1).Value)).ToList()(0)
                Select Case MsgBox("Atención, la orden seleccionada ya está asociada a un despacho:" & Chr(13) &
                       "Despacho N°: " & buscardespacho.DES_nro_despacho & Chr(13) &
                       "Remito N°: " & buscardespacho.DES_nro_remito & Chr(13) &
                       "CONTINUAR?",
                       MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Advertencia")
                    Case MsgBoxResult.No
                        Exit Sub
                End Select
            End If

            If frm_Despacho.temp_cant_filas_despacho > 1 And flag_controlar_filas = 0 Then ' el flag es para que valide el if solo la primera vez
                frm_Despacho.Nro_linea_grid = frm_Despacho.temp_cant_filas_despacho - 1 ' se le resta 1 xq hay una fila vacia
                flag_controlar_filas = 1
            End If

            frm_Despacho.dgv_lista_ordenes.Rows.Add()
            frm_Despacho.dgv_lista_ordenes.Item("DES_Id", frm_Despacho.Nro_linea_grid).Value = dgv_planificacion.SelectedCells(0).Value
            frm_Despacho.dgv_lista_ordenes.Item("Id_Odt", frm_Despacho.Nro_linea_grid).Value = dgv_planificacion.SelectedCells(1).Value
            frm_Despacho.dgv_lista_ordenes.Item("Orden", frm_Despacho.Nro_linea_grid).Value = dgv_planificacion.SelectedCells(2).Value
            frm_Despacho.dgv_lista_ordenes.Item("Fecha", frm_Despacho.Nro_linea_grid).Value = DateTime.Now.ToShortDateString
            frm_Despacho.dgv_lista_ordenes.Item("Hora", frm_Despacho.Nro_linea_grid).Value = CDate("00:01").ToLongTimeString

            frm_Despacho.Nro_linea_grid = frm_Despacho.Nro_linea_grid + 1
           End If
    End Sub

    Function query(ByVal filtro As String, ByVal rango As String)
        Dim consulta
        Select Case filtro
            Case "fecha"
                If rango = "sinenviar" Then
                    consulta = (From p In datacontextvistas.Vista_Despacho_Orden_Trabajo
                                Where p.DES_EMB_fecha_estado.Value.Date = dtp_fecha_estado.Text And p.DES_nro_despacho Is Nothing
                                Select New clase_emb_planif(p.DES_id, p.ORT_id_orden_trabajo,
                                p.ORT_numero_ot, p.DES_EMB_bultos, p.DES_EMB_estado,
                                p.DES_EMB_observaciones, p.DES_EMB_fecha_estado,
                                p.CLI_razon_social, p.ORT_observaciones_ot))
                ElseIf rango = "enviadas" Then
                    consulta = (From p In datacontextvistas.Vista_Despacho_Orden_Trabajo
                                Where p.DES_EMB_fecha_estado.Value.Date = dtp_fecha_estado.Text And p.DES_nro_despacho <> ""
                                Select New clase_emb_planif(p.DES_id, p.ORT_id_orden_trabajo,
                                p.ORT_numero_ot, p.DES_EMB_bultos, p.DES_EMB_estado,
                                p.DES_EMB_observaciones, p.DES_EMB_fecha_estado,
                                p.CLI_razon_social, p.ORT_observaciones_ot))
                Else
                    consulta = (From p In datacontextvistas.Vista_Despacho_Orden_Trabajo
                                Where p.DES_EMB_fecha_estado.Value.Date = dtp_fecha_estado.Text
                                Select New clase_emb_planif(p.DES_id, p.ORT_id_orden_trabajo,
                                p.ORT_numero_ot, p.DES_EMB_bultos, p.DES_EMB_estado,
                                p.DES_EMB_observaciones, p.DES_EMB_fecha_estado,
                                p.CLI_razon_social, p.ORT_observaciones_ot))
                End If
            Case "estado"
                If rango = "sinenviar" Then
                    consulta = (From p In datacontextvistas.Vista_Despacho_Orden_Trabajo
                                Where p.DES_EMB_estado = cmb_estado.Text And p.DES_nro_despacho Is Nothing
                                Select New clase_emb_planif(p.DES_id, p.ORT_id_orden_trabajo,
                                p.ORT_numero_ot, p.DES_EMB_bultos, p.DES_EMB_estado,
                                p.DES_EMB_observaciones, p.DES_EMB_fecha_estado,
                                p.CLI_razon_social, p.ORT_observaciones_ot))
                ElseIf rango = "enviadas" Then
                    consulta = (From p In datacontextvistas.Vista_Despacho_Orden_Trabajo
                                Where p.DES_EMB_estado = cmb_estado.Text And p.DES_nro_despacho <> ""
                                Select New clase_emb_planif(p.DES_id, p.ORT_id_orden_trabajo,
                                p.ORT_numero_ot, p.DES_EMB_bultos, p.DES_EMB_estado,
                                p.DES_EMB_observaciones, p.DES_EMB_fecha_estado,
                                p.CLI_razon_social, p.ORT_observaciones_ot))
                Else
                    consulta = (From p In datacontextvistas.Vista_Despacho_Orden_Trabajo
                                Where p.DES_EMB_estado = cmb_estado.Text
                                Select New clase_emb_planif(p.DES_id, p.ORT_id_orden_trabajo,
                                p.ORT_numero_ot, p.DES_EMB_bultos, p.DES_EMB_estado,
                                p.DES_EMB_observaciones, p.DES_EMB_fecha_estado,
                                p.CLI_razon_social, p.ORT_observaciones_ot))
                End If
            Case "orden"
                If rango = "sinenviar" Then
                    Dim buscar As String
                    buscar = "*" & txt_buscar.Text & "*"
                    consulta = (From p In datacontextvistas.Vista_Despacho_Orden_Trabajo
                                 Where p.ORT_numero_ot Like buscar.ToString And p.DES_nro_despacho Is Nothing
                                 Select New clase_emb_planif(p.DES_id, p.ORT_id_orden_trabajo,
                                 p.ORT_numero_ot, p.DES_EMB_bultos, p.DES_EMB_estado,
                                 p.DES_EMB_observaciones, CStr(p.DES_EMB_fecha_estado),
                                 p.CLI_razon_social, p.ORT_observaciones_ot))
                ElseIf rango = "enviadas" Then
                    Dim buscar As String
                    buscar = "*" & txt_buscar.Text & "*"
                    consulta = (From p In datacontextvistas.Vista_Despacho_Orden_Trabajo
                                 Where p.ORT_numero_ot Like buscar.ToString And p.DES_nro_despacho <> ""
                                 Select New clase_emb_planif(p.DES_id, p.ORT_id_orden_trabajo,
                                 p.ORT_numero_ot, p.DES_EMB_bultos, p.DES_EMB_estado,
                                 p.DES_EMB_observaciones, CStr(p.DES_EMB_fecha_estado),
                                 p.CLI_razon_social, p.ORT_observaciones_ot))
                Else
                    Dim buscar As String
                    buscar = "*" & txt_buscar.Text & "*"
                    consulta = (From p In datacontextvistas.Vista_Despacho_Orden_Trabajo
                                 Where p.ORT_numero_ot Like buscar.ToString
                                 Select New clase_emb_planif(p.DES_id, p.ORT_id_orden_trabajo,
                                 p.ORT_numero_ot, p.DES_EMB_bultos, p.DES_EMB_estado,
                                 p.DES_EMB_observaciones, CStr(p.DES_EMB_fecha_estado),
                                 p.CLI_razon_social, p.ORT_observaciones_ot))
                End If
            Case Else
                consulta = ""
        End Select

        Return consulta
    End Function

    Private Sub rbt_rango_enviadas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt_rango_enviadas.CheckedChanged
        If flag_load <> 0 Then
            If rbt_rango_enviadas.Checked = True Then
                If rbt_orden.Checked = True Then
                    dgv_planificacion.DataSource = query("orden", "enviadas")
                ElseIf rbt_estado.Checked = True Then
                    dgv_planificacion.DataSource = query("estado", "enviadas")
                Else
                    dgv_planificacion.DataSource = query("fecha", "enviadas")
                End If
            End If
        Else
            flag_load = 1
        End If
    End Sub

    Private Sub rbt_rango_sinenviar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt_rango_sinenviar.CheckedChanged
        If flag_load <> 0 Then
            If rbt_rango_sinenviar.Checked = True Then
                If rbt_orden.Checked = True Then
                    dgv_planificacion.DataSource = query("orden", "sinenviar")
                ElseIf rbt_estado.Checked = True Then
                    dgv_planificacion.DataSource = query("estado", "sinenviar")
                Else
                    dgv_planificacion.DataSource = query("fecha", "sinenviar")
                End If
            End If
        Else
            flag_load = 1
        End If
    End Sub

    Private Sub rbt_rango_todas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt_rango_todas.CheckedChanged
        If flag_load <> 0 Then
            If rbt_rango_todas.Checked = True Then
                If rbt_orden.Checked = True Then
                    dgv_planificacion.DataSource = query("orden", "todas")
                ElseIf rbt_estado.Checked = True Then
                    dgv_planificacion.DataSource = query("estado", "todas")
                Else
                    dgv_planificacion.DataSource = query("fecha", "todas")
                End If
            End If
        Else
            flag_load = 1
        End If
    End Sub
End Class

'CLASE PARA PODER MODIFICAR DATOS DESDE LA GRILLA CARGADA CON LINQ
Public Class clase_emb_planif

    Public _DES_id
    Public _ORT_id_orden_trabajo
    Public _ORT_numero_ot
    Public _DES_EMB_bultos
    Public _DES_EMB_estado
    Public _DES_EMB_observaciones
    Public _DES_EMB_fecha_estado
    Public _CLI_razon_social
    Public _ORT_observaciones_ot



    Sub New(ByVal des_id As Integer, ByVal ot_id As Integer, ByVal ot_nro As String, ByVal bultos As String,
            ByVal estado As String, ByVal obs As String, ByVal fecha_estado As Date,
            ByVal cliente As String, ByVal ot_obs As String)

        _DES_id = des_id
        _ORT_id_orden_trabajo = ot_id
        _ORT_numero_ot = ot_nro
        _DES_EMB_bultos = bultos
        _DES_EMB_estado = estado
        _DES_EMB_observaciones = obs
        _DES_EMB_fecha_estado = fecha_estado
        _CLI_razon_social = cliente
        _ORT_observaciones_ot = ot_obs

    End Sub
    Property des_id() As String
        Get
            Return _DES_id
        End Get
        Set(ByVal value As String)
            Me._DES_id = value
        End Set
    End Property
    Property ORT_id_orden_trabajo() As String
        Get
            Return _ORT_id_orden_trabajo
        End Get
        Set(ByVal value As String)
            Me._ORT_id_orden_trabajo = value
        End Set
    End Property
    Property ORT_numero_ot() As String
        Get
            Return _ORT_numero_ot
        End Get
        Set(ByVal value As String)
            Me._ORT_numero_ot = value
        End Set
    End Property
    Property DES_EMB_bultos() As String
        Get
            Return _DES_EMB_bultos
        End Get
        Set(ByVal value As String)
            Me._DES_EMB_bultos = value
        End Set
    End Property
    Property DES_EMB_estado() As String
        Get
            Return _DES_EMB_estado
        End Get
        Set(ByVal value As String)
            Me._DES_EMB_estado = value
        End Set
    End Property
    Property DES_EMB_observaciones() As String
        Get
            Return _DES_EMB_observaciones
        End Get
        Set(ByVal value As String)
            Me._DES_EMB_observaciones = value
        End Set
    End Property
    Property DES_EMB_fecha_estado() As String
        Get
            Return _DES_EMB_fecha_estado
        End Get
        Set(ByVal value As String)
            Me._DES_EMB_fecha_estado = value
        End Set
    End Property
    Property CLI_razon_social() As String
        Get
            Return _CLI_razon_social
        End Get
        Set(ByVal value As String)
            Me._CLI_razon_social = value
        End Set
    End Property
    Property ORT_observaciones_ot() As String
        Get
            Return _ORT_observaciones_ot
        End Get
        Set(ByVal value As String)
            Me._ORT_observaciones_ot = value
        End Set
    End Property
End Class