Imports System.Drawing.Printing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frm_listado_orden_trabajo_ampliada
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Public quienllamolistado_ot As Form
    Public quienllamobotonorden As Button

    Public vble_id_orden As Integer
    Public vble_id_detalle As Integer
    Dim vble_id_proceso As Integer
    Dim vble_colaborador, vble_fecha As String

    'campos y vbles para generar pdf
    'Public contadorcolumnasvisibles As Integer
    Dim fuente As iTextSharp.text.pdf.BaseFont = FontFactory.GetFont(FontFactory.HELVETICA).BaseFont

    Public Sub frm_listado_orden_trabajo_ampliada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ArmarGrillaOrden()
        CargarGrillaOrden()

        Label3.Text = dgvLista_Orden_Trabajo.RowCount
        dgv_detalle_orden.Rows.Clear()

        '***************Para ver con vale link label en este form****************
        'Dim tempruta As String
        'tempruta = Configuration.ConfigurationManager.AppSettings("ruta_archivos")
        'LinkLabel1.Text = "Click here to get more info."
        'LinkLabel1.Links.Add(6, 4, tempruta & "\trabajos\TRABAJOS\DV\Op 30502\")
        '************************************************************************
    End Sub
    
    Private Sub ArmarGrillaDetalle(ByVal datasource As System.Linq.IQueryable)
        dgv_detalle_orden.Enabled = True
        dgv_detalle_orden.AutoGenerateColumns = False
        dgv_detalle_orden.Columns.Clear()

        dgv_detalle_orden.Columns.Add("ORT_id_orden_trabajo", "ORT_id_orden_trabajo")
        dgv_detalle_orden.Columns.Add("ORT_tipo_ot", "Tipo")
        dgv_detalle_orden.Columns.Add("ORT_numero_ot", "Número")
        dgv_detalle_orden.Columns.Add("ORT_observaciones_ot", "Observaciones")
        dgv_detalle_orden.Columns.Add("ORT_mejoras_ot", "Mejoras")
        dgv_detalle_orden.Columns.Add("VEN_id_vendedor", "id_vendedor")
        dgv_detalle_orden.Columns.Add("VEN_nombre_ven", "Vendedor")
        dgv_detalle_orden.Columns.Add("VEN_apellido_ven", "Apellido")
        dgv_detalle_orden.Columns.Add("ORT_fecha_ot", "Fecha")
        dgv_detalle_orden.Columns.Add("ORT_fecha_entrega", "Fecha de Entrega")
        dgv_detalle_orden.Columns.Add("CLI_id_cliente", "id_cliente")
        dgv_detalle_orden.Columns.Add("CLI_razon_social", "Razón Social")
        dgv_detalle_orden.Columns.Add("CLI_domicilio", "Domicilio")
        dgv_detalle_orden.Columns.Add("PIE_id_pieza", "PIE_id_pieza")
        dgv_detalle_orden.Columns.Add("PIE_id_pieza_offset", "PIE_id_pieza_offset")
        dgv_detalle_orden.Columns.Add("PIE_nombre_pie", "Pieza")
        dgv_detalle_orden.Columns.Add("PIE_ubicacion", "PIE_ubicacion")
        dgv_detalle_orden.Columns.Add("id_detalle_orden_trabajo", "id_detalle_orden_trabajo")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_producto", "Cantidad Producto")
        dgv_detalle_orden.Columns.Add("DOT_tamaño_producto", "Tamaño Producto")
        dgv_detalle_orden.Columns.Add("DOT_tipo_impresion_dot", "Tipo de Impresión")
        dgv_detalle_orden.Columns.Add("DOT_papel_soporte_1", "Papel Soporte 1")
        dgv_detalle_orden.Columns.Add("DOT_papel_soporte_2", "Papel soporte 2")
        dgv_detalle_orden.Columns.Add("DOT_papel_soporte_3", "Papel Soporte 3")
        dgv_detalle_orden.Columns.Add("DOT_gramaje_soporte_1", "Gramaje Soporte 1")
        dgv_detalle_orden.Columns.Add("DOT_gramaje_soporte_2", "Gramaje Soporte 2")
        dgv_detalle_orden.Columns.Add("DOT_gramaje_soporte_3", "Gramaje Soporte 3")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_soporte_1", "Cantidad Soporte 1")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_soporte_2", "Cantidad Soporte_2")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_soporte_3", "Cantidad Soporte_3")
        dgv_detalle_orden.Columns.Add("DOT_formato_soporte_1", "Formato Soporte 1")
        dgv_detalle_orden.Columns.Add("DOT_formato_soporte_2", "Formato Soporte 2")
        dgv_detalle_orden.Columns.Add("DOT_formato_soporte_3", "Formato Soporte 3")
        dgv_detalle_orden.Columns.Add("cantidad_1_PM_offset", "Cantidad 1 PM Offset")
        dgv_detalle_orden.Columns.Add("cantidad_2_PM_offset", "Cantidad 2 PM Offset")
        dgv_detalle_orden.Columns.Add("cantidad_3_PM_offset", "Cantidad 3 PM Offset")
        dgv_detalle_orden.Columns.Add("formato_1_PM_offset", "Formato 1 PM Offset")
        dgv_detalle_orden.Columns.Add("formato_2_PM_offset", "Formato 2 PM Offset")
        dgv_detalle_orden.Columns.Add("formato_3_PM_offset", "Formato 3 PM Offset")
        dgv_detalle_orden.Columns.Add("modo_impresion_offset", "Modo Impresión Offset")
        dgv_detalle_orden.Columns.Add("tipo_impresion_offset", "Tipo Impresión Offset")
        dgv_detalle_orden.Columns.Add("chapas_soporte1_offset", "Chapas soporte 1")
        dgv_detalle_orden.Columns.Add("chapas_soporte2_offset", "Chapas Soporte 2")
        dgv_detalle_orden.Columns.Add("chapas_soporte3_offset", "Chapas Soporte 3")
        dgv_detalle_orden.Columns.Add("impresora_offset", "Impresora Offset")
        dgv_detalle_orden.Columns.Add("marca_offset", "Marca Offset")
        dgv_detalle_orden.Columns.Add("cantidad_1_PM_digital", "Cantidad 1 PM Digital")
        dgv_detalle_orden.Columns.Add("cantidad_2_PM_digital", "Cantidad 2 PM Digital")
        dgv_detalle_orden.Columns.Add("cantidad_3_PM_digital", "Cantidad 3 PM Digital")
        dgv_detalle_orden.Columns.Add("formato_1_PM_digital", "Formato 1 PM Digital")
        dgv_detalle_orden.Columns.Add("formato_2_PM_digital", "Formato 2 PM Digital")
        dgv_detalle_orden.Columns.Add("formato_3_PM_digital", "Formato 3 PM Digital")
        dgv_detalle_orden.Columns.Add("modo_impresion_digital", "Usuario")
        dgv_detalle_orden.Columns.Add("tipo_impresion_digital", "Tipo Impresión Digital")
        dgv_detalle_orden.Columns.Add("dato_variable", "Dato Variable")
        dgv_detalle_orden.Columns.Add("Expr1", "Pieza Gran Formato")
        dgv_detalle_orden.Columns.Add("cantidad_gran_formato", "Cantidad Gran Formato")
        dgv_detalle_orden.Columns.Add("tamaño_gran_formato", "Tamaño Gran Formato")
        dgv_detalle_orden.Columns.Add("sustrato_gran_formato", "Sustrato Gran Formato")
        dgv_detalle_orden.Columns.Add("calidad_gran_formato", "Calidad Gran Formato")
        dgv_detalle_orden.Columns.Add("sistema_gran_formato", "Sistema Gran Formato")
        dgv_detalle_orden.Columns.Add("tipo_terminacion", "Tipo Terminación")
        dgv_detalle_orden.Columns.Add("descripcion_terminacion", "Descripcion Terminación")


        dgv_detalle_orden.Columns(0).DataPropertyName = "ORT_id_orden_trabajo"
        dgv_detalle_orden.Columns(0).Visible = False
        dgv_detalle_orden.Columns(1).DataPropertyName = "ORT_tipo_ot"
        dgv_detalle_orden.Columns(1).Visible = False
        dgv_detalle_orden.Columns(2).DataPropertyName = "ORT_numero_ot"
        dgv_detalle_orden.Columns(2).Visible = False
        dgv_detalle_orden.Columns(3).DataPropertyName = "ORT_observaciones_ot"
        dgv_detalle_orden.Columns(3).Visible = False
        dgv_detalle_orden.Columns(4).DataPropertyName = "ORT_mejoras_ot"
        dgv_detalle_orden.Columns(4).Visible = False
        dgv_detalle_orden.Columns(5).DataPropertyName = "VEN_id_vendedor"
        dgv_detalle_orden.Columns(5).Visible = False
        dgv_detalle_orden.Columns(6).DataPropertyName = "VEN_nombre_ven"
        dgv_detalle_orden.Columns(6).Visible = False
        dgv_detalle_orden.Columns(7).DataPropertyName = "VEN_apellido_ven"
        dgv_detalle_orden.Columns(7).Visible = False
        dgv_detalle_orden.Columns(8).DataPropertyName = "ORT_fecha_ot"
        dgv_detalle_orden.Columns(8).Visible = False
        dgv_detalle_orden.Columns(9).DataPropertyName = "ORT_fecha_entrega"
        dgv_detalle_orden.Columns(9).Visible = False
        dgv_detalle_orden.Columns(10).DataPropertyName = "CLI_id_cliente"
        dgv_detalle_orden.Columns(10).Visible = False
        dgv_detalle_orden.Columns(11).DataPropertyName = "CLI_razon_social"
        dgv_detalle_orden.Columns(11).Visible = False
        dgv_detalle_orden.Columns(12).DataPropertyName = "CLI_domicilio"
        dgv_detalle_orden.Columns(12).Visible = False
        dgv_detalle_orden.Columns(13).DataPropertyName = "PIE_id_pieza"
        dgv_detalle_orden.Columns(13).Visible = False
        dgv_detalle_orden.Columns(14).DataPropertyName = "PIE_id_pieza_offset"
        dgv_detalle_orden.Columns(14).Visible = False
        dgv_detalle_orden.Columns(15).DataPropertyName = "PIE_nombre_pie"
        dgv_detalle_orden.Columns(16).DataPropertyName = "PIE_ubicacion"
        dgv_detalle_orden.Columns(16).Visible = False
        dgv_detalle_orden.Columns(17).DataPropertyName = "id_detalle_orden_trabajo"
        dgv_detalle_orden.Columns(17).Visible = False
        dgv_detalle_orden.Columns(18).DataPropertyName = "DOT_cantidad_producto"
        dgv_detalle_orden.Columns(19).DataPropertyName = "DOT_tamaño_producto"
        dgv_detalle_orden.Columns(20).DataPropertyName = "DOT_tipo_impresion_dot"
        dgv_detalle_orden.Columns(20).Visible = False
        dgv_detalle_orden.Columns(21).DataPropertyName = "DOT_papel_soporte_1"
        dgv_detalle_orden.Columns(21).Visible = False
        dgv_detalle_orden.Columns(22).DataPropertyName = "DOT_papel_soporte_2"
        dgv_detalle_orden.Columns(22).Visible = False
        dgv_detalle_orden.Columns(23).DataPropertyName = "DOT_papel_soporte_3"
        dgv_detalle_orden.Columns(23).Visible = False
        dgv_detalle_orden.Columns(24).DataPropertyName = "DOT_gramaje_soporte_1"
        dgv_detalle_orden.Columns(24).Visible = False
        dgv_detalle_orden.Columns(25).DataPropertyName = "DOT_gramaje_soporte_2"
        dgv_detalle_orden.Columns(25).Visible = False
        dgv_detalle_orden.Columns(26).DataPropertyName = "DOT_gramaje_soporte_3"
        dgv_detalle_orden.Columns(26).Visible = False
        dgv_detalle_orden.Columns(27).DataPropertyName = "DOT_cantidad_soporte_1"
        dgv_detalle_orden.Columns(27).Visible = False
        dgv_detalle_orden.Columns(28).DataPropertyName = "DOT_cantidad_soporte_2"
        dgv_detalle_orden.Columns(28).Visible = False
        dgv_detalle_orden.Columns(29).DataPropertyName = "DOT_cantidad_soporte_3"
        dgv_detalle_orden.Columns(29).Visible = False
        dgv_detalle_orden.Columns(30).DataPropertyName = "DOT_formato_soporte_1"
        dgv_detalle_orden.Columns(30).Visible = False
        dgv_detalle_orden.Columns(31).DataPropertyName = "DOT_formato_soporte_2"
        dgv_detalle_orden.Columns(31).Visible = False
        dgv_detalle_orden.Columns(32).DataPropertyName = "DOT_formato_soporte_3"
        dgv_detalle_orden.Columns(32).Visible = False
        dgv_detalle_orden.Columns(33).DataPropertyName = "cantidad_1_PM_offset"
        dgv_detalle_orden.Columns(33).Visible = False
        dgv_detalle_orden.Columns(34).DataPropertyName = "cantidad_2_PM_offset"
        dgv_detalle_orden.Columns(34).Visible = False
        dgv_detalle_orden.Columns(35).DataPropertyName = "cantidad_3_PM_offset"
        dgv_detalle_orden.Columns(35).Visible = False
        dgv_detalle_orden.Columns(36).DataPropertyName = "formato_1_PM_offset"
        dgv_detalle_orden.Columns(36).Visible = False
        dgv_detalle_orden.Columns(37).DataPropertyName = "formato_2_PM_offset"
        dgv_detalle_orden.Columns(37).Visible = False
        dgv_detalle_orden.Columns(38).DataPropertyName = "formato_3_PM_offset"
        dgv_detalle_orden.Columns(38).Visible = False
        dgv_detalle_orden.Columns(39).DataPropertyName = "modo_impresion_offset"
        dgv_detalle_orden.Columns(39).Visible = False
        dgv_detalle_orden.Columns(40).DataPropertyName = "tipo_impresion_offset"
        dgv_detalle_orden.Columns(40).Visible = False
        dgv_detalle_orden.Columns(41).DataPropertyName = "chapas_soporte1_offset"
        dgv_detalle_orden.Columns(41).Visible = False
        dgv_detalle_orden.Columns(42).DataPropertyName = "chapas_soporte2_offset"
        dgv_detalle_orden.Columns(42).Visible = False
        dgv_detalle_orden.Columns(43).DataPropertyName = "chapas_soporte3_offset"
        dgv_detalle_orden.Columns(43).Visible = False
        dgv_detalle_orden.Columns(44).DataPropertyName = "impresora_offset"
        dgv_detalle_orden.Columns(44).Visible = False
        dgv_detalle_orden.Columns(45).DataPropertyName = "marca_offset"
        dgv_detalle_orden.Columns(45).Visible = False
        dgv_detalle_orden.Columns(46).DataPropertyName = "cantidad_1_PM_digital"
        dgv_detalle_orden.Columns(46).Visible = False
        dgv_detalle_orden.Columns(47).DataPropertyName = "cantidad_2_PM_digital"
        dgv_detalle_orden.Columns(47).Visible = False
        dgv_detalle_orden.Columns(48).DataPropertyName = "cantidad_3_PM_digital"
        dgv_detalle_orden.Columns(48).Visible = False
        dgv_detalle_orden.Columns(49).DataPropertyName = "formato_1_PM_digital"
        dgv_detalle_orden.Columns(49).Visible = False
        dgv_detalle_orden.Columns(50).DataPropertyName = "formato_2_PM_digital"
        dgv_detalle_orden.Columns(50).Visible = False
        dgv_detalle_orden.Columns(51).DataPropertyName = "formato_3_PM_digital"
        dgv_detalle_orden.Columns(51).Visible = False
        dgv_detalle_orden.Columns(52).DataPropertyName = "modo_impresion_digital"
        dgv_detalle_orden.Columns(52).Visible = False
        dgv_detalle_orden.Columns(53).DataPropertyName = "tipo_impresion_digital"
        dgv_detalle_orden.Columns(53).Visible = False
        dgv_detalle_orden.Columns(54).DataPropertyName = "dato_variable"
        dgv_detalle_orden.Columns(54).Visible = False
        dgv_detalle_orden.Columns(55).DataPropertyName = "Expr1"
        dgv_detalle_orden.Columns(56).DataPropertyName = "cantidad_gran_formato"
        dgv_detalle_orden.Columns(57).DataPropertyName = "tamaño_gran_formato"
        dgv_detalle_orden.Columns(58).DataPropertyName = "sustrato_gran_formato"
        dgv_detalle_orden.Columns(59).DataPropertyName = "calidad_gran_formato"
        dgv_detalle_orden.Columns(59).Visible = False
        dgv_detalle_orden.Columns(60).DataPropertyName = "sistema_gran_formato"
        dgv_detalle_orden.Columns(60).Visible = False
        dgv_detalle_orden.Columns(61).DataPropertyName = "tipo_terminacion"
        dgv_detalle_orden.Columns(61).Visible = False
        dgv_detalle_orden.Columns(62).DataPropertyName = "descripcion_terminacion"
        ' dgv_detalle_orden.Columns(62).Visible = False

        dgv_detalle_orden.DataSource = datasource

        '    OcultarColumnas()

        dgv_detalle_orden.ClearSelection()
    End Sub

    Sub OcultarColumnas()
        '    For i = 0 To dgv_detalle_orden.Columns.Count - 1
        '        dgv_detalle_orden.Columns(i).Visible = False
        '    Next

        '    For i = 0 To dgv_detalle_orden.Columns.Count - 1 'recorre columnas
        '        For j = 0 To dgv_detalle_orden.Rows.Count - 1 'recorre filas
        '            If dgv_detalle_orden.Item(i, j).Value.ToString.Length <> 0 Then
        '                dgv_detalle_orden.Columns(i).Visible = True
        '                ' Exit For
        '            End If
        '        Next
        '    Next
        '    dgv_detalle_orden.Columns(0).Visible = False
        '    dgv_detalle_orden.Columns(1).Visible = False
        '    dgv_detalle_orden.Columns(5).Visible = False
        '    dgv_detalle_orden.Columns(10).Visible = False
        '    dgv_detalle_orden.Columns(13).Visible = False
        '    dgv_detalle_orden.Columns(16).Visible = False
        '    dgv_detalle_orden.Columns(17).Visible = False
        '    dgv_detalle_orden.Columns(20).Visible = False
        '    dgv_detalle_orden.Columns(60).Visible = False
    End Sub

    Private Sub dgv_detalle_orden_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_detalle_orden.CellDoubleClick
        Try
            If quienllamolistado_ot.Name = frm_retrabajo.Name Then

                frm_retrabajo.txt_id_orden_trabajo.Text = dgv_detalle_orden.SelectedCells(0).Value
                frm_retrabajo.txtNumero_Orden_Trabajo.Text = dgv_detalle_orden.SelectedCells(2).Value
                frm_retrabajo.dtp_Fecha_Ingreso_Original.Text = dgv_detalle_orden.SelectedCells(8).Value
                frm_retrabajo.dtpFecha_Entrega_Original.Text = dgv_detalle_orden.SelectedCells(9).Value
                frm_retrabajo.cboPieza_Original.Text = dgv_detalle_orden.SelectedCells(15).Value
                frm_retrabajo.txt_id_detalle.Text = dgv_detalle_orden.SelectedCells(17).Value
                frm_retrabajo.txt_Cantidad_Original.Text = dgv_detalle_orden.SelectedCells(18).Value
                frm_retrabajo.txtTamaño_Original.Text = dgv_detalle_orden.SelectedCells(19).Value
                '    frm_retrabajo.cboTipoImpresion.Text = dgv_detalle_orden.SelectedCells(40).Value

            ElseIf quienllamolistado_ot.Name = frm_Actualizar_Offset.Name Then
                frm_Actualizar_Offset.txt_id_orden_trabajo.Text = dgv_detalle_orden.SelectedCells(0).Value
                frm_Actualizar_Offset.txtNumero_Orden_Trabajo.Text = dgv_detalle_orden.SelectedCells(2).Value
                frm_Actualizar_Offset.dtp_Fecha_Ingreso_Original.Text = dgv_detalle_orden.SelectedCells(8).Value
                frm_Actualizar_Offset.cboPiezas1_Detalle1.Text = dgv_detalle_orden.SelectedCells(15).Value
                frm_Actualizar_Offset.txt_id_detalle_orden_trabajo1.Text = dgv_detalle_orden.SelectedCells(17).Value
                frm_Actualizar_Offset.txt_cantidad_original.Text = dgv_detalle_orden.SelectedCells(18).Value
                frm_Actualizar_Offset.txtTamaño1_Detalle1.Text = dgv_detalle_orden.SelectedCells(19).Value
                frm_Actualizar_Offset.txt_chapa_soporte_1.Text = dgv_detalle_orden.SelectedCells(41).Value
                frm_Actualizar_Offset.cboImpresora_Original.Text = dgv_detalle_orden.SelectedCells(44).Value
                frm_Actualizar_Offset.cboMarca_Offset.Text = dgv_detalle_orden.SelectedCells(45).Value
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    'CARGA GRILLA ORDEN TRABAJO
    Public Sub CargarGrillaOrden()
        Dim consultaOrden = (From U In datacontext.ORDEN_TRABAJO
                               Join ort In datacontext.VENDEDOR
                               On U.VEN_id_vendedor Equals ort.VEN_id_vendedor
                               Join col In datacontext.CLIENTE
                               On col.CLI_id_cliente Equals U.CLI_id_cliente
                              Select U.ORT_id_orden_trabajo, U.ORT_fecha_ot, U.ORT_fecha_entrega, U.ORT_tipo_ot, U.ORT_numero_ot,
                              U.ORT_observaciones_ot, U.ORT_mejoras_ot, U.VEN_id_vendedor, ort.VEN_nombre_ven, U.CLI_id_cliente, col.CLI_razon_social
Where ORT_fecha_entrega >= System.DateTime.Now.ToShortDateString
Order By ORT_id_orden_trabajo Descending)
        dgvLista_Orden_Trabajo.DataSource = consultaOrden
        dgvLista_Orden_Trabajo.ClearSelection()
    End Sub

    'ARMA GRILLA ORDEN
    Private Sub ArmarGrillaOrden()
        dgvLista_Orden_Trabajo.Enabled = True
        dgvLista_Orden_Trabajo.AutoGenerateColumns = False
        dgvLista_Orden_Trabajo.Columns.Clear()

        dgvLista_Orden_Trabajo.Columns.Add("ORT_id_orden_trabajo", "TN")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_tipo_ot", "Tipo")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_numero_ot", "Número Orden")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_fecha_ot", "Fecha de Ingreso")
        dgvLista_Orden_Trabajo.Columns.Add("CLI_id_cliente", "id_cliente")
        dgvLista_Orden_Trabajo.Columns.Add("CLI_razon_social", "Razón Social")
        dgvLista_Orden_Trabajo.Columns.Add("VEN_id_vendedor", "id_vendedor")
        dgvLista_Orden_Trabajo.Columns.Add("VEN_nombre_ven", "Vendedor")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_observaciones_ot", "Observaciones")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_mejoras_ot", "Mejoras")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_fecha_entrega", "Fecha de Entrega")

        dgvLista_Orden_Trabajo.Columns(0).DataPropertyName = "ORT_id_orden_trabajo"
        dgvLista_Orden_Trabajo.Columns(0).Visible = False
        dgvLista_Orden_Trabajo.Columns(1).DataPropertyName = "ORT_tipo_ot"
        dgvLista_Orden_Trabajo.Columns(1).Visible = False
        dgvLista_Orden_Trabajo.Columns(2).DataPropertyName = "ORT_numero_ot"
        dgvLista_Orden_Trabajo.Columns(3).DataPropertyName = "ORT_fecha_ot"
        dgvLista_Orden_Trabajo.Columns(4).DataPropertyName = "CLI_id_cliente"
        dgvLista_Orden_Trabajo.Columns(4).Visible = False
        dgvLista_Orden_Trabajo.Columns(5).DataPropertyName = "CLI_razon_social"
        dgvLista_Orden_Trabajo.Columns(5).Width = 160
        dgvLista_Orden_Trabajo.Columns(6).DataPropertyName = "VEN_id_vendedor"
        dgvLista_Orden_Trabajo.Columns(6).Visible = False
        dgvLista_Orden_Trabajo.Columns(7).DataPropertyName = "VEN_nombre_ven"
        dgvLista_Orden_Trabajo.Columns(8).DataPropertyName = "ORT_observaciones_ot"
        dgvLista_Orden_Trabajo.Columns(8).Width = 450
        dgvLista_Orden_Trabajo.Columns(9).DataPropertyName = "ORT_mejoras_ot"
        dgvLista_Orden_Trabajo.Columns(9).Visible = False
        dgvLista_Orden_Trabajo.Columns(10).DataPropertyName = "ORT_fecha_entrega"
    End Sub

    Private Sub dgvLista_Orden_Trabajo_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Orden_Trabajo.CellDoubleClick
        Try
            If quienllamolistado_ot.Name = frm_Etiqueta_Modelo_1.Name Then
                frm_Etiqueta_Modelo_1.txt_id_orden.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                frm_Etiqueta_Modelo_1.txt_orden.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value
                frm_Etiqueta_Modelo_1.txtDirigidoA.Text = dgvLista_Orden_Trabajo.SelectedCells(5).Value
                frm_Etiqueta_Modelo_1.txtDomicilio.Text = dgvLista_Orden_Trabajo.SelectedCells(9).Value

                Dim traercliente = (From c In datacontext.CLIENTE Select c.CLI_id_cliente, c.CLI_codigo_postal, c.CLI_localidad
                                 Where CLI_id_cliente = CInt(dgvLista_Orden_Trabajo.SelectedCells(4).Value)).ToList()(0)

                frm_Etiqueta_Modelo_1.txtCodigoPostal.Text = traercliente.CLI_codigo_postal
                frm_Etiqueta_Modelo_1.txtLocalidad.Text = traercliente.CLI_localidad

                Dim traerdetalle = (From c In datacontext.DETALLE_ORDEN_TRABAJO Select c.ORT_id_orden_trabajo, c.PIEZA, c.PIEZA1
                                  Where ORT_id_orden_trabajo = CInt(dgvLista_Orden_Trabajo.SelectedCells(0).Value)).ToList
                Dim temdetalle As String = ""
                For i = 0 To traerdetalle.Count - 1
                    If i <> 0 Then
                        temdetalle = temdetalle & " - "
                    End If
                    If traerdetalle.Item(i).PIEZA.PIE_nombre_pie.Length > 1 Then
                        temdetalle = temdetalle & traerdetalle.Item(i).PIEZA.PIE_nombre_pie
                    End If
                    If traerdetalle.Item(i).PIEZA1.PIE_nombre_pie.Length > 1 Then
                        temdetalle = temdetalle & traerdetalle.Item(i).PIEZA1.PIE_nombre_pie
                    End If
                Next
                frm_Etiqueta_Modelo_1.txtDescripcionEntrega.Text = temdetalle

            ElseIf quienllamolistado_ot.Name = frm_Movimiento_Producto.Name Then
                frm_Movimiento_Producto.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                frm_Movimiento_Producto.txt_numero_orden.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

            ElseIf quienllamolistado_ot.Name = frm_Actualizar_Tarea.Name Then
                frm_Actualizar_Tarea.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                frm_Actualizar_Tarea.txt_numero_orden.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                ' Form(DESPACHO)
            ElseIf quienllamolistado_ot.Name = frm_Despacho.Name Then

                If dgvLista_Orden_Trabajo.SelectedCells(2).Value <> "00" And dgvLista_Orden_Trabajo.SelectedCells(2).Value <> "Sf" Then
                    For i = 0 To frm_Despacho.dgv_emp_lista_ordenes.RowCount - 2
                        If dgvLista_Orden_Trabajo.SelectedCells(0).Value = frm_Despacho.dgv_emp_lista_ordenes.Item("ORT_id_orden_trabajo", i).Value Then
                            MsgBox("La orden seleccionada ya está agregada")
                            Exit Sub
                        End If
                    Next

                    Dim buscarorden = (From bo In datacontext.DESPACHO Select bo.ORT_id_orden_trabajo, bo.DES_nro_despacho, bo.DES_nro_remito
                      Where ORT_id_orden_trabajo = CInt(dgvLista_Orden_Trabajo.SelectedCells(0).Value)).Any
                    If buscarorden = True Then
                        Dim buscardespacho = (From bo In datacontext.DESPACHO Select bo.ORT_id_orden_trabajo, bo.DES_nro_despacho, bo.DES_nro_remito
                                      Where ORT_id_orden_trabajo = CInt(dgvLista_Orden_Trabajo.SelectedCells(0).Value)).ToList()(0)
                        Select Case MsgBox("Atención, la orden seleccionada ya está planificada: CONTINUAR?" & Chr(13),
                               MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Advertencia")
                            Case MsgBoxResult.No
                                Exit Sub
                        End Select
                    End If
                End If

                Dim nueva_fila As DataRow
                With frm_Despacho.dt_empaque
                    nueva_fila = frm_Despacho.dt_empaque.NewRow
                    nueva_fila("ORT_id_orden_trabajo") = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    nueva_fila("ORT_numero_ot") = dgvLista_Orden_Trabajo.SelectedCells(2).Value
                    nueva_fila("CLI_razon_social") = dgvLista_Orden_Trabajo.SelectedCells(5).Value
                    nueva_fila("ORT_observaciones_ot") = dgvLista_Orden_Trabajo.SelectedCells(8).Value
                    .Rows.Add(nueva_fila)
                End With

                '**FIN FORM DESPACHO

                ElseIf quienllamolistado_ot.Name = frm_Tarea.Name Then
                    Select Case quienllamobotonorden.Name
                        Case frm_Tarea.btnBuscar_Numero_Orden1.Name
                            frm_Tarea.txt_id_orden_trabajo1.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo1.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden2.Name
                            frm_Tarea.txt_id_orden_trabajo2.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo2.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden3.Name
                            frm_Tarea.txt_id_orden_trabajo3.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo3.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden4.Name
                            frm_Tarea.txt_id_orden_trabajo4.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo4.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden5.Name
                            frm_Tarea.txt_id_orden_trabajo5.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo5.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden6.Name
                            frm_Tarea.txt_id_orden_trabajo6.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo6.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden7.Name
                            frm_Tarea.txt_id_orden_trabajo7.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo7.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden8.Name
                            frm_Tarea.txt_id_orden_trabajo8.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo8.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden9.Name
                            frm_Tarea.txt_id_orden_trabajo9.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo9.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden10.Name
                            frm_Tarea.txt_id_orden_trabajo10.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo10.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden11.Name
                            frm_Tarea.txt_id_orden_trabajo11.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo11.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden12.Name
                            frm_Tarea.txt_id_orden_trabajo12.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo12.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden13.Name
                            frm_Tarea.txt_id_orden_trabajo13.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo13.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden14.Name
                            frm_Tarea.txt_id_orden_trabajo14.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo14.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden15.Name
                            frm_Tarea.txt_id_orden_trabajo15.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo15.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden16.Name
                            frm_Tarea.txt_id_orden_trabajo16.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo16.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden17.Name
                            frm_Tarea.txt_id_orden_trabajo17.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo17.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden18.Name
                            frm_Tarea.txt_id_orden_trabajo18.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo18.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden19.Name
                            frm_Tarea.txt_id_orden_trabajo19.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo19.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea.btnBuscar_Numero_Orden20.Name
                            frm_Tarea.txt_id_orden_trabajo20.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea.txtNumero_Orden_Trabajo20.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value
                    End Select

                ElseIf quienllamolistado_ot.Name = frm_Tarea_1.Name Then
                    Select Case quienllamobotonorden.Name
                        Case frm_Tarea_1.btnBuscar_Numero_Orden1.Name
                            frm_Tarea_1.txt_id_orden_trabajo1.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo1.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden2.Name
                            frm_Tarea_1.txt_id_orden_trabajo2.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo2.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden3.Name
                            frm_Tarea_1.txt_id_orden_trabajo3.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo3.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden4.Name
                            frm_Tarea_1.txt_id_orden_trabajo4.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo4.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden5.Name
                            frm_Tarea_1.txt_id_orden_trabajo5.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo5.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden6.Name
                            frm_Tarea_1.txt_id_orden_trabajo6.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo6.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden7.Name
                            frm_Tarea_1.txt_id_orden_trabajo7.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo7.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden8.Name
                            frm_Tarea_1.txt_id_orden_trabajo8.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo8.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden9.Name
                            frm_Tarea_1.txt_id_orden_trabajo9.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo9.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden10.Name
                            frm_Tarea_1.txt_id_orden_trabajo10.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo10.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden11.Name
                            frm_Tarea_1.txt_id_orden_trabajo11.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo11.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden12.Name
                            frm_Tarea_1.txt_id_orden_trabajo12.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo12.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden13.Name
                            frm_Tarea_1.txt_id_orden_trabajo13.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo13.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden14.Name
                            frm_Tarea_1.txt_id_orden_trabajo14.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo14.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden15.Name
                            frm_Tarea_1.txt_id_orden_trabajo15.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo15.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden16.Name
                            frm_Tarea_1.txt_id_orden_trabajo16.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo16.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden17.Name
                            frm_Tarea_1.txt_id_orden_trabajo17.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo17.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden18.Name
                            frm_Tarea_1.txt_id_orden_trabajo18.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo18.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden19.Name
                            frm_Tarea_1.txt_id_orden_trabajo19.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo19.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                        Case frm_Tarea_1.btnBuscar_Numero_Orden20.Name
                            frm_Tarea_1.txt_id_orden_trabajo20.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                            frm_Tarea_1.txtNumero_Orden_Trabajo20.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value
                End Select

            ElseIf quienllamolistado_ot.Name = frm_GuardarActualizar_tarea.Name Then

                Select Case quienllamobotonorden.Name
                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden1.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo1.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden2.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo2.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden3.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo3.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden4.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo4.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden5.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo5.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden6.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo6.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden7.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo7.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden8.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo8.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden9.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo9.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden10.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo10.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden11.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo11.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden12.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo12.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden13.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo13.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo13.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden14.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo14.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo14.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden15.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo15.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo15.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden16.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo16.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo16.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden17.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo17.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo17.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden18.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo18.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo18.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden19.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo19.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo19.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden20.Name
                        frm_GuardarActualizar_tarea.txt_id_orden_trabajo20.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo20.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value
                End Select

            ElseIf quienllamolistado_ot.Name = frm_GuardarActualizar_1.Name Then

                Select Case quienllamobotonorden.Name
                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden1.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo1.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo1.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden2.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo2.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo2.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden3.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo3.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo3.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden4.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo4.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo4.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden5.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo5.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo5.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden6.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo6.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo6.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden7.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo7.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo7.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden8.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo8.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo8.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden9.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo9.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo9.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden10.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo10.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo10.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden11.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo11.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo11.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden12.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo12.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo12.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden13.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo13.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo13.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden14.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo14.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo14.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden15.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo15.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo15.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden16.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo16.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo16.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden17.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo17.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo17.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden18.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo18.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo18.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden19.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo19.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo19.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                    Case frm_GuardarActualizar_1.btnBuscar_Numero_Orden20.Name
                        frm_GuardarActualizar_1.txt_id_orden_trabajo20.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                        frm_GuardarActualizar_1.txtNumero_Orden_Trabajo20.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value
                End Select
            End If
        Catch ex As Exception
        End Try
        If quienllamolistado_ot.Name <> frm_Despacho.Name Then
            Me.Close()
        End If
    End Sub

    Private Sub dgvLista_Orden_Trabajo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Orden_Trabajo.CellClick

        dgv_detalle_orden.ClearSelection()
        'VALIDA QUE SE HAYA SELECCONADO UN SECTOR Y UNA FECHA
        If dgvLista_Orden_Trabajo.Rows.Count = 0 Then
            MsgBox("No hay órdenes", MsgBoxStyle.Information + MsgBoxStyle.Information, "Seleccionar")
            Exit Sub
        End If
        Try
            vble_id_orden = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            CargarGrillaDetalle()
        Catch ex As Exception
        End Try

        Label1.Text = dgv_detalle_orden.RowCount
    End Sub

    Public Sub CargarGrillaDetalle()
        Dim dgDetalleOrden = (From det_ord In datavistas.Vista_Detalle_Orden_Trabajo_Ampliada
Select
det_ord.ORT_id_orden_trabajo,
det_ord.ORT_tipo_ot,
det_ord.ORT_numero_ot,
det_ord.ORT_observaciones_ot,
det_ord.ORT_mejoras_ot,
det_ord.VEN_id_vendedor,
det_ord.VEN_nombre_ven,
det_ord.VEN_apellido_ven,
det_ord.ORT_fecha_ot,
det_ord.ORT_fecha_entrega,
det_ord.CLI_id_cliente,
det_ord.CLI_razon_social,
det_ord.CLI_domicilio,
det_ord.PIE_id_pieza,
det_ord.PIE_id_pieza_offset,
det_ord.PIE_nombre_pie,
det_ord.PIE_ubicacion,
det_ord.id_detalle_orden_trabajo,
det_ord.DOT_cantidad_producto,
det_ord.DOT_tamaño_producto,
det_ord.DOT_tipo_impresion_dot,
det_ord.DOT_papel_soporte_1,
det_ord.DOT_papel_soporte_2,
det_ord.DOT_papel_soporte_3,
det_ord.DOT_gramaje_soporte_1,
det_ord.DOT_gramaje_soporte_2,
det_ord.DOT_gramaje_soporte_3,
det_ord.DOT_cantidad_soporte_1,
det_ord.DOT_cantidad_soporte_2,
det_ord.DOT_cantidad_soporte_3,
det_ord.DOT_formato_soporte_1,
det_ord.DOT_formato_soporte_2,
det_ord.DOT_formato_soporte_3,
det_ord.cantidad_1_PM_offset,
det_ord.cantidad_2_PM_offset,
det_ord.cantidad_3_PM_offset,
det_ord.formato_1_PM_offset,
det_ord.formato_2_PM_offset,
det_ord.formato_3_PM_offset,
det_ord.modo_impresion_offset,
det_ord.tipo_impresion_offset,
det_ord.chapas_soporte1_offset,
det_ord.chapas_soporte2_offset,
det_ord.chapas_soporte3_offset,
det_ord.impresora_offset,
det_ord.marca_offset,
det_ord.cantidad_1_PM_digital,
det_ord.cantidad_2_PM_digital,
det_ord.cantidad_3_PM_digital,
det_ord.formato_1_PM_digital,
det_ord.formato_2_PM_digital,
det_ord.formato_3_PM_digital,
det_ord.modo_impresion_digital,
det_ord.tipo_impresion_digital,
det_ord.dato_variable,
det_ord.cantidad_gran_formato,
det_ord.tamaño_gran_formato,
det_ord.sustrato_gran_formato,
det_ord.calidad_gran_formato,
det_ord.sistema_gran_formato,
det_ord.tipo_terminacion,
det_ord.descripcion_terminacion,
det_ord.Expr1
Where ORT_id_orden_trabajo = vble_id_orden)
        ArmarGrillaDetalle(dgDetalleOrden)
    End Sub

    Private Sub txt_Buscar_orden_trabajo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_orden_trabajo.TextChanged
        Dim buscar As String
        ArmarGrillaOrden()
        buscar = "*" & Me.txt_Buscar_orden_trabajo.Text & "*"
        Dim consultaCliente = (From U In datacontext.ORDEN_TRABAJO
                              Join ort In datacontext.VENDEDOR
                              On U.VEN_id_vendedor Equals ort.VEN_id_vendedor
                              Join col In datacontext.CLIENTE
                              On col.CLI_id_cliente Equals U.CLI_id_cliente
                             Select
                             U.ORT_id_orden_trabajo,
                             U.ORT_fecha_ot,
                             U.ORT_fecha_entrega,
                             U.ORT_tipo_ot,
                             U.ORT_numero_ot,
                             U.ORT_observaciones_ot,
                             U.ORT_mejoras_ot,
                             U.VEN_id_vendedor,
                             ort.VEN_nombre_ven,
                             U.CLI_id_cliente,
                             col.CLI_razon_social
                             Where ORT_numero_ot Like buscar.ToString
                             Order By ORT_numero_ot Ascending)
        dgvLista_Orden_Trabajo.DataSource = consultaCliente
        dgvLista_Orden_Trabajo.ClearSelection()
        dgv_detalle_orden.DataSource = ""
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub txt_Buscar_Cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_Cliente.TextChanged
        Dim buscar As String
        ArmarGrillaOrden()
        buscar = "*" & Me.txt_Buscar_Cliente.Text & "*"
        Dim BuscaCliente = (From U In datacontext.ORDEN_TRABAJO
                              Join ort In datacontext.VENDEDOR
                              On U.VEN_id_vendedor Equals ort.VEN_id_vendedor
                              Join col In datacontext.CLIENTE
                              On col.CLI_id_cliente Equals U.CLI_id_cliente
                             Select U.ORT_id_orden_trabajo,
                             U.ORT_fecha_ot,
                             U.ORT_fecha_entrega,
                             U.ORT_tipo_ot,
                             U.ORT_numero_ot,
                             U.ORT_observaciones_ot,
                             U.ORT_mejoras_ot,
                             U.VEN_id_vendedor,
                             ort.VEN_nombre_ven,
                             U.CLI_id_cliente,
                             col.CLI_razon_social
                              Where CLI_razon_social Like buscar.ToString)
        ' Order By ORT_numero_ot Ascending)
        dgvLista_Orden_Trabajo.DataSource = BuscaCliente
        dgvLista_Orden_Trabajo.ClearSelection()
        dgv_detalle_orden.DataSource = ""
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub dtp_Buscar_Fecha_Entrega_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Buscar_Fecha_Entrega.ValueChanged
        Dim buscar As String
        ArmarGrillaOrden()
        buscar = Me.dtp_Buscar_Fecha_Entrega.Text & "*"
        Try
            Dim BuscaFecha = (From U In datacontext.ORDEN_TRABAJO
                                        Join ort In datacontext.VENDEDOR
                                        On U.VEN_id_vendedor Equals ort.VEN_id_vendedor
                                        Join col In datacontext.CLIENTE
                                        On col.CLI_id_cliente Equals U.CLI_id_cliente
                                       Select U.ORT_id_orden_trabajo,
                                       U.ORT_fecha_ot,
                                       U.ORT_fecha_entrega,
                                       U.ORT_tipo_ot,
                                       U.ORT_numero_ot,
                                       U.ORT_observaciones_ot,
                                       U.ORT_mejoras_ot,
                                       U.VEN_id_vendedor,
                                       ort.VEN_nombre_ven,
                                       U.CLI_id_cliente,
                                       col.CLI_razon_social
                                        Where ORT_fecha_entrega.Value.Date = dtp_Buscar_Fecha_Entrega.Text)
            ' Order By ORT_numero_ot Ascending)
            dgvLista_Orden_Trabajo.DataSource = BuscaFecha
            dgvLista_Orden_Trabajo.ClearSelection()
            dgv_detalle_orden.DataSource = ""
            Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub btnEliminar_Orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Orden.Click
        If dgvLista_Orden_Trabajo.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.ORDEN_TRABAJO Where C.ORT_id_orden_trabajo = CInt(dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará la orden y su detalle correspondiente, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar orden y detalle")
                Case MsgBoxResult.Yes
                    datacontext.ORDEN_TRABAJO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("La orden y su detalle han sido eliminados")
                    CargarGrillaOrden()
                    Me.Close()
            End Select
        Else
            MsgBox("Debe seleccionar un orden")
        End If
    End Sub

    Private Sub btnEliminar_Producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Producto.Click
        If dgv_detalle_orden.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.DETALLE_ORDEN_TRABAJO Where C.id_detalle_orden_trabajo = CInt(dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgv_detalle_orden.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el detalle y proceso relacionado a él, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar detalle de la orden")
                Case MsgBoxResult.Yes
                    datacontext.DETALLE_ORDEN_TRABAJO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El detalle de la orden ha sido eliminada")
                    ' CargarDetalle()
                    Me.Close()
            End Select
        Else
            MsgBox("Debe seleccionar un detalle")
        End If
    End Sub

    Private Sub btnModificarProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnModificarProducto.Click

        'LIMPIA CAMPOS CUANDO SE ABRE EL FORMULARIO
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarDigital()
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarGranFormato()
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarOffset()
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarProducto_Soportes()
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarTerminacion()
        Try
            'LLENA EL FORMULARIO CON LOS DATOS DEL GRID
            If dgv_detalle_orden.SelectedRows.Count > 0 Then
                frm_Actualizar_Producto_Orden_Ampliada.txt_id_orden_trabajo.Text = dgv_detalle_orden.Item("ORT_id_orden_trabajo", dgv_detalle_orden.SelectedRows(0).Index).Value 'id_orden_trabajo
                frm_Actualizar_Producto_Orden_Ampliada.txtNumero_Orden_Trabajo.Text = dgv_detalle_orden.Item("ORT_numero_ot", dgv_detalle_orden.SelectedRows(0).Index).Value 'numero orden
                frm_Actualizar_Producto_Orden_Ampliada.txt_cantidad_producto.Text = dgv_detalle_orden.Item("DOT_cantidad_producto", dgv_detalle_orden.SelectedRows(0).Index).Value 'cantidad producto
                frm_Actualizar_Producto_Orden_Ampliada.txt_id_detalle_orden_trabajo1.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgv_detalle_orden.SelectedRows(0).Index).Value 'id detalle orden trabajo
                frm_Actualizar_Producto_Orden_Ampliada.txtTamaño_Producto.Text = dgv_detalle_orden.Item("DOT_tamaño_producto", dgv_detalle_orden.SelectedRows(0).Index).Value ' tamaño producto
                frm_Actualizar_Producto_Orden_Ampliada.cboPapel1.Text = dgv_detalle_orden.Item("DOT_papel_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value ' papel soporte 1
                frm_Actualizar_Producto_Orden_Ampliada.cboPapel2.Text = dgv_detalle_orden.Item("DOT_papel_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value 'papel soporte 2
                frm_Actualizar_Producto_Orden_Ampliada.cboPapel3.Text = dgv_detalle_orden.Item("DOT_papel_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value 'papel soporte 3
                frm_Actualizar_Producto_Orden_Ampliada.cboGramaje1.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value 'gramaje soporte 1
                frm_Actualizar_Producto_Orden_Ampliada.cboGramaje2.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value 'gramaje soporte 2
                frm_Actualizar_Producto_Orden_Ampliada.cboGramaje3.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value 'gramaje soporte 3
                frm_Actualizar_Producto_Orden_Ampliada.txt_Cantidad_1_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value 'cantidad soporte 1
                frm_Actualizar_Producto_Orden_Ampliada.txt_Cantidad_2_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value 'cantidad soporte 2
                frm_Actualizar_Producto_Orden_Ampliada.txt_Cantidad_3_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value 'cantidad soporte 3
                frm_Actualizar_Producto_Orden_Ampliada.cboFormato_1_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value 'formato soporte 1
                frm_Actualizar_Producto_Orden_Ampliada.cboFormato_2_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value 'formato soporte 2
                frm_Actualizar_Producto_Orden_Ampliada.cboFormato_3_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value 'formato soporte 3
                frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_1_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value 'cantidad 1 PM offset
                frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_2_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_2_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value 'cantidad 2 PM offset
                frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_3_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_3_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value 'cantidad 3 PM offset
                frm_Actualizar_Producto_Orden_Ampliada.cboFormato_1_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_1_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value 'formato 1 PM offset
                frm_Actualizar_Producto_Orden_Ampliada.cboFormato_2_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_2_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value 'formato 2 PM offset
                frm_Actualizar_Producto_Orden_Ampliada.cboFormato_3_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_3_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value 'formato 3 PM offset
                frm_Actualizar_Producto_Orden_Ampliada.cboModo_Impresion_Offset.Text = dgv_detalle_orden.Item("modo_impresion_offset", dgv_detalle_orden.SelectedRows(0).Index).Value 'modo impresion offset
                frm_Actualizar_Producto_Orden_Ampliada.cboTipo_Impresion_Offset.Text = dgv_detalle_orden.Item("tipo_impresion_offset", dgv_detalle_orden.SelectedRows(0).Index).Value 'tipo impresion offset
                frm_Actualizar_Producto_Orden_Ampliada.txt_chapa_soporte_1.Text = dgv_detalle_orden.Item("chapas_soporte1_offset", dgv_detalle_orden.SelectedRows(0).Index).Value 'chapas soporte 1
                frm_Actualizar_Producto_Orden_Ampliada.txt_chapa_soporte_2.Text = dgv_detalle_orden.Item("chapas_soporte2_offset", dgv_detalle_orden.SelectedRows(0).Index).Value 'chapas soporte 2
                frm_Actualizar_Producto_Orden_Ampliada.txt_chapa_soporte_3.Text = dgv_detalle_orden.Item("chapas_soporte3_offset", dgv_detalle_orden.SelectedRows(0).Index).Value 'chapas soporte 3
                frm_Actualizar_Producto_Orden_Ampliada.cboImpresora_Offset.Text = dgv_detalle_orden.Item("impresora_offset", dgv_detalle_orden.SelectedRows(0).Index).Value 'impresora offset
                frm_Actualizar_Producto_Orden_Ampliada.cboMarca_Offset.Text = dgv_detalle_orden.Item("marca_offset", dgv_detalle_orden.SelectedRows(0).Index).Value 'marca offset
                frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_1_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value 'cantidad 1 PM digital
                frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_2_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_2_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value 'cantidad 2 PM digital
                frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_3_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_3_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value 'cantidad 3 PM digital
                frm_Actualizar_Producto_Orden_Ampliada.cboFormato_1_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_1_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value 'formato 1 PM digital
                frm_Actualizar_Producto_Orden_Ampliada.cboFormato_2_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_2_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value 'formato 2 PM digital
                frm_Actualizar_Producto_Orden_Ampliada.cboFormato_3_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_3_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value 'formato 3 PM digital
                frm_Actualizar_Producto_Orden_Ampliada.cboTipo_Impresion_Digital.Text = dgv_detalle_orden.Item("tipo_impresion_digital", dgv_detalle_orden.SelectedRows(0).Index).Value 'tipo impresion digital
                frm_Actualizar_Producto_Orden_Ampliada.txtDato_Variable.Text = dgv_detalle_orden.Item("dato_variable", dgv_detalle_orden.SelectedRows(0).Index).Value 'dato variable
                frm_Actualizar_Producto_Orden_Ampliada.txt_cantidad_producto_Gran_Formato.Text = dgv_detalle_orden.Item("cantidad_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value 'cantidad gran formato
                frm_Actualizar_Producto_Orden_Ampliada.txtTamaño_Producto_Gran_Formato.Text = dgv_detalle_orden.Item("tamaño_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value 'tamaño gran formato
                frm_Actualizar_Producto_Orden_Ampliada.cboMaterial.Text = dgv_detalle_orden.Item("sustrato_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value 'sustrato gran formato
                frm_Actualizar_Producto_Orden_Ampliada.cboCalidad_Gran_Formato.Text = dgv_detalle_orden.Item("calidad_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value 'calidad gran formato
                frm_Actualizar_Producto_Orden_Ampliada.cboSistema_Gran_Formato.Text = dgv_detalle_orden.Item("sistema_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value ' sistema gran formato
                frm_Actualizar_Producto_Orden_Ampliada.txt_descripcion_terminacion.Text = dgv_detalle_orden.Item("descripcion_terminacion", dgv_detalle_orden.SelectedRows(0).Index).Value 'descripcion terminacion

                Dim tempterminacion As String
                tempterminacion = dgv_detalle_orden.Item("tipo_terminacion", dgv_detalle_orden.SelectedRows(0).Index).Value

                If tempterminacion.Contains("T01") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkAdhesivado.Checked = True
                End If
                If tempterminacion.Contains("T02") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkArmadoRevistas.Checked = True
                End If
                If tempterminacion.Contains("T03") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkBarniz.Checked = True
                End If
                If tempterminacion.Contains("T04") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkCocido.Checked = True
                End If
                If tempterminacion.Contains("T05") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkCuño.Checked = True
                End If
                If tempterminacion.Contains("T06") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkDoblado.Checked = True
                End If
                If tempterminacion.Contains("T07") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkEncuadernacion.Checked = True
                End If
                If tempterminacion.Contains("T08") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkEstampado.Checked = True
                End If
                If tempterminacion.Contains("T09") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkFresado.Checked = True
                End If
                If tempterminacion.Contains("T10") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkGuillotinado.Checked = True
                End If
                If tempterminacion.Contains("T11") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkLaca_UV.Checked = True
                End If
                If tempterminacion.Contains("T12") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkLacaUVSectorizada.Checked = True
                End If
                If tempterminacion.Contains("T13") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkMedio_Corte.Checked = True
                End If
                If tempterminacion.Contains("T14") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkMontado.Checked = True
                End If
                If tempterminacion.Contains("T15") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkOPPBrillante.Checked = True
                End If
                If tempterminacion.Contains("T16") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkOPPMate.Checked = True
                End If
                If tempterminacion.Contains("T17") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkOtros.Checked = True
                End If
                If tempterminacion.Contains("T18") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkPegadoManual.Checked = True
                End If
                If tempterminacion.Contains("T19") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkPlastificado.Checked = True
                End If
                If tempterminacion.Contains("T20") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkPosicionado.Checked = True
                End If
                If tempterminacion.Contains("T21") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkRuedo.Checked = True
                End If
                If tempterminacion.Contains("T22") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkSoldado.Checked = True
                End If
                If tempterminacion.Contains("T23") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkStamping.Checked = True
                End If
                If tempterminacion.Contains("T24") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkTermosellado.Checked = True
                End If
                If tempterminacion.Contains("T25") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkTrazado.Checked = True
                End If
                If tempterminacion.Contains("T26") Then
                    frm_Actualizar_Producto_Orden_Ampliada.chkTroquelado.Checked = True
                End If
            Else
                MsgBox("Seleccione un Producto a modificar del segundo listado")
                Exit Sub
            End If
            Dim flagsoporte As Integer = 0

            If frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Offset.TextLength <> 0 Then
                frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = True
                frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = True
                frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = True
                flagsoporte = 1
            Else
                frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = False
                frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = False
                If flagsoporte = 0 Then
                    frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = False
                End If
            End If
            If frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Digital.TextLength <> 0 Then
                frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = True
                frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = True
                frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = True
                flagsoporte = 1
            Else
                frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = False
                frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = False
                If flagsoporte = 0 Then
                    frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = False
                End If
            End If
            If frm_Actualizar_Producto_Orden_Ampliada.txt_cantidad_producto_Gran_Formato.TextLength <> 0 Then
                frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = True
                frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = True
            Else
                frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = False
                frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = False
            End If
            If dgv_detalle_orden.Item("tipo_terminacion", dgv_detalle_orden.SelectedRows(0).Index).Value.ToString.Length <> 0 Then
                frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = True
                frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = True
            Else
                frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = False
                frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = False
            End If
            frm_Actualizar_Producto_Orden_Ampliada.txtNumero_Orden_Trabajo.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.Label1.Visible = False
            frm_Actualizar_Producto_Orden_Ampliada.txt_id_orden_trabajo.Visible = False
            frm_Actualizar_Producto_Orden_Ampliada.cboTipo_Orden.Visible = False
            frm_Actualizar_Producto_Orden_Ampliada.Label5.Visible = False
            frm_Actualizar_Producto_Orden_Ampliada.Label45.Visible = False
            frm_Actualizar_Producto_Orden_Ampliada.txt_id_detalle_orden_trabajo1.Visible = False
            frm_Actualizar_Producto_Orden_Ampliada.Label8.Visible = False
            frm_Actualizar_Producto_Orden_Ampliada.ShowDialog()
            'Try
            '    frm_Actualizar_Producto_Orden_Ampliada.cboPiezas_Producto.SelectedValue = dgv_detalle_orden.Item("PIE_id_pieza", dgv_detalle_orden.SelectedRows(0).Index).Value
            '    frm_Actualizar_Producto_Orden_Ampliada.cboPiezas_Producto_Gran_Formato.SelectedValue = dgv_detalle_orden.Item("PIE_id_pieza_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_Orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_Orden.Click
        Try
            If dgvLista_Orden_Trabajo.SelectedRows.Count > 0 Then
                frm_Actualizar_Orden.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Actualizar_Orden.txtNumero_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_numero_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Actualizar_Orden.dtpFecha_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Actualizar_Orden.cboTipo_Orden.Text = dgvLista_Orden_Trabajo.Item("ORT_tipo_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Actualizar_Orden.dtpFecha_Entrega.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_entrega", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Actualizar_Orden.txt_id_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_id_cliente", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Actualizar_Orden.txt_nombre_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_razon_social", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Actualizar_Orden.txtid_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_id_vendedor", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Actualizar_Orden.txtNombre_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_nombre_ven", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Actualizar_Orden.txt_observaciones.Text = dgvLista_Orden_Trabajo.Item("ORT_observaciones_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Actualizar_Orden.cboDireccion_Entrega.Text = dgvLista_Orden_Trabajo.Item("ORT_mejoras_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            End If
            frm_Actualizar_Orden.txtNumero_Orden_Trabajo.Enabled = True
            frm_Actualizar_Orden.Label1.Visible = False
            frm_Actualizar_Orden.txt_id_orden_trabajo.Visible = False
            frm_Actualizar_Orden.txt_id_cliente.Visible = False
            frm_Actualizar_Orden.txtid_vendedor.Visible = False
            frm_Actualizar_Orden.txtNombre_vendedor.Enabled = False
            frm_Actualizar_Orden.txt_nombre_cliente.Enabled = False
            frm_Actualizar_Orden.cboTipo_Orden.Visible = False
            frm_Actualizar_Orden.Label5.Visible = False

            frm_Actualizar_Orden.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Try
            frm_Orden_Trabajo_Ampliada.Text = ".:. Ver Orden .:."
            If dgv_detalle_orden.SelectedRows.Count > 0 Then

                frm_Orden_Trabajo_Ampliada.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtNumero_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_numero_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.dtpFecha_Ingreso_ODT.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboTipo_Orden.Text = dgvLista_Orden_Trabajo.Item("ORT_tipo_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.dtpFecha_Entrega_ODT.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_entrega", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_id_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_id_cliente", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_nombre_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_razon_social", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtid_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_id_vendedor", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtNombre_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_nombre_ven", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_observaciones.Text = dgvLista_Orden_Trabajo.Item("ORT_observaciones_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboDireccion_Entrega.Text = dgvLista_Orden_Trabajo.Item("ORT_mejoras_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value

                frm_Orden_Trabajo_Ampliada.txt_cantidad_producto.Text = dgv_detalle_orden.Item("DOT_cantidad_producto", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_id_detalle_orden_trabajo1.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtTamaño_Producto.Text = dgv_detalle_orden.Item("DOT_tamaño_producto", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboPapel1.Text = dgv_detalle_orden.Item("DOT_papel_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboPapel2.Text = dgv_detalle_orden.Item("DOT_papel_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboPapel3.Text = dgv_detalle_orden.Item("DOT_papel_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboGramaje1.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboGramaje2.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboGramaje3.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_Cantidad_1_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_Cantidad_2_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_Cantidad_3_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_1_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_2_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_3_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtCantidad_1_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_1_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtCantidad_2_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_2_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtCantidad_3_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_3_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_1_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_1_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_2_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_2_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_3_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_3_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboModo_Impresion_Offset.Text = dgv_detalle_orden.Item("modo_impresion_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboTipo_Impresion_Offset.Text = dgv_detalle_orden.Item("tipo_impresion_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_chapa_soporte_1.Text = dgv_detalle_orden.Item("chapas_soporte1_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_chapa_soporte_2.Text = dgv_detalle_orden.Item("chapas_soporte2_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_chapa_soporte_3.Text = dgv_detalle_orden.Item("chapas_soporte3_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboImpresora_Offset.Text = dgv_detalle_orden.Item("impresora_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboMarca_Offset.Text = dgv_detalle_orden.Item("marca_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtCantidad_1_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_1_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtCantidad_2_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_2_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtCantidad_3_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_3_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_1_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_1_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_2_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_2_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_3_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_3_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboTipo_Impresion_Digital.Text = dgv_detalle_orden.Item("tipo_impresion_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtDato_Variable.Text = dgv_detalle_orden.Item("dato_variable", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_cantidad_producto_Gran_Formato.Text = dgv_detalle_orden.Item("cantidad_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtTamaño_Producto_Gran_Formato.Text = dgv_detalle_orden.Item("tamaño_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboMaterial.Text = dgv_detalle_orden.Item("sustrato_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboCalidad_Gran_Formato.Text = dgv_detalle_orden.Item("calidad_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboSistema_Gran_Formato.Text = dgv_detalle_orden.Item("sistema_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_descripcion_terminacion.Text = dgv_detalle_orden.Item("descripcion_terminacion", dgv_detalle_orden.SelectedRows(0).Index).Value

                Dim tempterminacion As String
                tempterminacion = dgv_detalle_orden.Item("tipo_terminacion", dgv_detalle_orden.SelectedRows(0).Index).Value

                If tempterminacion.Contains("T01") Then
                    frm_Orden_Trabajo_Ampliada.chkAdhesivado.Checked = True
                End If
                If tempterminacion.Contains("T02") Then
                    frm_Orden_Trabajo_Ampliada.chkArmadoRevistas.Checked = True
                End If
                If tempterminacion.Contains("T03") Then
                    frm_Orden_Trabajo_Ampliada.chkBarniz.Checked = True
                End If
                If tempterminacion.Contains("T04") Then
                    frm_Orden_Trabajo_Ampliada.chkCocido.Checked = True
                End If
                If tempterminacion.Contains("T05") Then
                    frm_Orden_Trabajo_Ampliada.chkCuño.Checked = True
                End If
                If tempterminacion.Contains("T06") Then
                    frm_Orden_Trabajo_Ampliada.chkDoblado.Checked = True
                End If
                If tempterminacion.Contains("T07") Then
                    frm_Orden_Trabajo_Ampliada.chkEncuadernacion.Checked = True
                End If
                If tempterminacion.Contains("T08") Then
                    frm_Orden_Trabajo_Ampliada.chkEstampado.Checked = True
                End If
                If tempterminacion.Contains("T09") Then
                    frm_Orden_Trabajo_Ampliada.chkFresado.Checked = True
                End If
                If tempterminacion.Contains("T10") Then
                    frm_Orden_Trabajo_Ampliada.chkGuillotinado.Checked = True
                End If
                If tempterminacion.Contains("T11") Then
                    frm_Orden_Trabajo_Ampliada.chkLaca_UV.Checked = True
                End If
                If tempterminacion.Contains("T12") Then
                    frm_Orden_Trabajo_Ampliada.chkLacaUVSectorizada.Checked = True
                End If
                If tempterminacion.Contains("T13") Then
                    frm_Orden_Trabajo_Ampliada.chkMedio_Corte.Checked = True
                End If
                If tempterminacion.Contains("T14") Then
                    frm_Orden_Trabajo_Ampliada.chkMontado.Checked = True
                End If
                If tempterminacion.Contains("T15") Then
                    frm_Orden_Trabajo_Ampliada.chkOPPBrillante.Checked = True
                End If
                If tempterminacion.Contains("T16") Then
                    frm_Orden_Trabajo_Ampliada.chkOPPMate.Checked = True
                End If
                If tempterminacion.Contains("T17") Then
                    frm_Orden_Trabajo_Ampliada.chkOtros.Checked = True
                End If
                If tempterminacion.Contains("T18") Then
                    frm_Orden_Trabajo_Ampliada.chkPegadoManual.Checked = True
                End If
                If tempterminacion.Contains("T19") Then
                    frm_Orden_Trabajo_Ampliada.chkPlastificado.Checked = True
                End If

                If tempterminacion.Contains("T20") Then
                    frm_Orden_Trabajo_Ampliada.chkPosicionado.Checked = True
                End If
                If tempterminacion.Contains("T21") Then
                    frm_Orden_Trabajo_Ampliada.chkRuedo.Checked = True
                End If
                If tempterminacion.Contains("T22") Then
                    frm_Orden_Trabajo_Ampliada.chkSoldado.Checked = True
                End If
                If tempterminacion.Contains("T23") Then
                    frm_Orden_Trabajo_Ampliada.chkStamping.Checked = True
                End If
                If tempterminacion.Contains("T24") Then
                    frm_Orden_Trabajo_Ampliada.chkTermosellado.Checked = True
                End If
                If tempterminacion.Contains("T25") Then
                    frm_Orden_Trabajo_Ampliada.chkTrazado.Checked = True
                End If
                If tempterminacion.Contains("T26") Then
                    frm_Orden_Trabajo_Ampliada.chkTroquelado.Checked = True
                End If

            Else
                MsgBox("Seleccione un Producto del segundo listado")
                Exit Sub
            End If

            Dim flagsoporte As Integer = 0

            'CONTROLES OFFSET
            If frm_Orden_Trabajo_Ampliada.txtCantidad_1_Pliego_Maquina_Offset.TextLength <> 0 Then
                frm_Orden_Trabajo_Ampliada.chkOffset.Checked = True
                frm_Orden_Trabajo_Ampliada.chkOffset.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkDigital.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkGranFormato.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkTerminacion.Enabled = False
                frm_Orden_Trabajo_Ampliada.groupOffset.Enabled = False
                frm_Orden_Trabajo_Ampliada.GroupProducto_Soportes.Enabled = False
                flagsoporte = 1
            Else
                frm_Orden_Trabajo_Ampliada.chkOffset.Checked = False
                frm_Orden_Trabajo_Ampliada.groupOffset.Enabled = False
                If flagsoporte = 0 Then
                    frm_Orden_Trabajo_Ampliada.GroupProducto_Soportes.Enabled = False
                End If
            End If
            'CONTROLES DIGITAL
            If frm_Orden_Trabajo_Ampliada.txtCantidad_1_Pliego_Maquina_Digital.TextLength <> 0 Then
                frm_Orden_Trabajo_Ampliada.chkDigital.Checked = True
                frm_Orden_Trabajo_Ampliada.chkDigital.Enabled = False

                frm_Orden_Trabajo_Ampliada.GroupDigital.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkOffset.Enabled = False

                frm_Orden_Trabajo_Ampliada.chkGranFormato.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkTerminacion.Enabled = False
                frm_Orden_Trabajo_Ampliada.GroupProducto_Soportes.Enabled = False
                flagsoporte = 1
            Else
                frm_Orden_Trabajo_Ampliada.chkDigital.Checked = False
                frm_Orden_Trabajo_Ampliada.GroupDigital.Enabled = False
                If flagsoporte = 0 Then
                    frm_Orden_Trabajo_Ampliada.GroupProducto_Soportes.Enabled = False
                End If
            End If
            'CONTROLES GRAN FORMATO
            If frm_Orden_Trabajo_Ampliada.txt_cantidad_producto_Gran_Formato.TextLength <> 0 Then
                frm_Orden_Trabajo_Ampliada.chkGranFormato.Checked = True
                frm_Orden_Trabajo_Ampliada.chkGranFormato.Enabled = False
                frm_Orden_Trabajo_Ampliada.GroupGranFormato.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkOffset.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkDigital.Enabled = False

                frm_Orden_Trabajo_Ampliada.chkTerminacion.Enabled = False
            Else
                frm_Orden_Trabajo_Ampliada.chkGranFormato.Checked = False
                frm_Orden_Trabajo_Ampliada.GroupGranFormato.Enabled = False
            End If
            'CONTROLES TERMINACION
            If dgv_detalle_orden.Item("tipo_terminacion", dgv_detalle_orden.SelectedRows(0).Index).Value.ToString.Length <> 0 Then
                frm_Orden_Trabajo_Ampliada.chkTerminacion.Checked = True
                frm_Orden_Trabajo_Ampliada.chkTerminacion.Enabled = False
                frm_Orden_Trabajo_Ampliada.GroupTerminacion.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkOffset.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkDigital.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkGranFormato.Enabled = False

            Else
                frm_Orden_Trabajo_Ampliada.chkTerminacion.Checked = False
                frm_Orden_Trabajo_Ampliada.GroupTerminacion.Enabled = False
            End If

            ' frm_Orden_Trabajo_Ampliada.GroupBox4.Enabled = False
            frm_Orden_Trabajo_Ampliada.txtNumero_Orden_Trabajo.Enabled = False
            frm_Orden_Trabajo_Ampliada.dtpFecha_Entrega_ODT.Enabled = False
            frm_Orden_Trabajo_Ampliada.dtpFecha_Ingreso_ODT.Enabled = False
            frm_Orden_Trabajo_Ampliada.txtNombre_vendedor.Enabled = False
            frm_Orden_Trabajo_Ampliada.btnBuscar_Vendedor.Enabled = False
            frm_Orden_Trabajo_Ampliada.txt_nombre_cliente.Enabled = False
            frm_Orden_Trabajo_Ampliada.btnBuscar_cliente.Enabled = False
            frm_Orden_Trabajo_Ampliada.cboDireccion_Entrega.Enabled = False
            'frm_Orden_Trabajo_Ampliada.txt_observaciones.ReadOnly = True
            'frm_Orden_Trabajo_Ampliada.txt_observaciones.ScrollBars = True

            frm_Orden_Trabajo_Ampliada.Label1.Visible = False
            frm_Orden_Trabajo_Ampliada.txt_id_orden_trabajo.Visible = False
            frm_Orden_Trabajo_Ampliada.cboTipo_Orden.Visible = False
            frm_Orden_Trabajo_Ampliada.Label5.Visible = False
            frm_Orden_Trabajo_Ampliada.Label45.Visible = False
            frm_Orden_Trabajo_Ampliada.txt_id_detalle_orden_trabajo1.Visible = False
            frm_Orden_Trabajo_Ampliada.txtid_vendedor.Visible = False
            frm_Orden_Trabajo_Ampliada.txt_id_cliente.Visible = False
            frm_Orden_Trabajo_Ampliada.btnGuardar_Orden_Trabajo.Enabled = False
            frm_Orden_Trabajo_Ampliada.Label8.Visible = False

            frm_Orden_Trabajo_Ampliada.quienllamo_listado_orden_ampliada = Me
            frm_Orden_Trabajo_Ampliada.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rbtNroOrden_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtNroOrden.CheckedChanged
        If rbtNroOrden.Checked = True Then
            txt_Buscar_Cliente.Enabled = False
            dtp_Buscar_Fecha_Entrega.Enabled = False
            txt_Buscar_orden_trabajo.Enabled = True
            txt_Buscar_orden_trabajo.Focus()
            txt_Buscar_Cliente.Clear()
            dtp_Buscar_Fecha_Entrega.Text = Now
        End If
        CargarGrillaOrden()
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub rbtCliente_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtCliente.CheckedChanged
        If rbtCliente.Checked = True Then
            txt_Buscar_orden_trabajo.Enabled = False
            dtp_Buscar_Fecha_Entrega.Enabled = False
            txt_Buscar_Cliente.Enabled = True
            txt_Buscar_Cliente.Focus()
            txt_Buscar_orden_trabajo.Clear()
            dtp_Buscar_Fecha_Entrega.Text = Now
        End If
        CargarGrillaOrden()
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub rbtFechaEntrega_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtFechaEntrega.CheckedChanged
        If rbtFechaEntrega.Checked = True Then
            Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
            txt_Buscar_orden_trabajo.Enabled = False
            txt_Buscar_Cliente.Enabled = False
            dtp_Buscar_Fecha_Entrega.Enabled = True
            dtp_Buscar_Fecha_Entrega.Focus()
            txt_Buscar_orden_trabajo.Clear()
            txt_Buscar_Cliente.Clear()
            dtp_Buscar_Fecha_Entrega.Text = Now
            If dtp_Buscar_Fecha_Entrega.Text = Now Then
                CargarGrillaOrden()
            End If
        End If
        CargarGrillaOrden()
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub btn_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frm_listado_orden_trabajo_ampliada_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btn_ODT_mostrar_listado_pdf_Click(sender As System.Object, e As System.EventArgs) Handles btn_ODT_mostrar_listado_pdf.Click
        Try
            'intentar generar el documento
            Dim doc As New Document(PageSize.A4, 20, 20, 20, 20)

            'path que guarda el reporte en el escritorio de windows (desktop)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Orden_" _
                                     + dgvLista_Orden_Trabajo.Item("ORT_numero_ot", dgvLista_Orden_Trabajo.CurrentRow.Index).Value _
                                     + ".pdf"
            'no se usa xq ya no hay tipo de odt
            '+ dgvLista_Orden_Trabajo.Item("ORT_tipo_ot", dgv_detalle_orden.CurrentRow.Index).Value + "_" _


            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            ' PARA LAS LINEAS DE FONDO
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, file)
            doc.Open()
            Dim cb As PdfContentByte = writer.DirectContent
            Dibujar_Lineas(cb, doc)
            Escribir_Pdf(cb)

            'Vbles formato
            Dim medialinea As New Paragraph("                                       " _
            & "--------------------------------------------------------------------------------------")

            Dim linea As New Paragraph("---------------------------------------------------------------------" _
                                      & "---------------------------------------------------------------------")
            Dim orden As New Phrase("   " & dgvLista_Orden_Trabajo.Item("ORT_tipo_ot", dgvLista_Orden_Trabajo.CurrentRow.Index).Value _
                                             & " " _
                                             & dgvLista_Orden_Trabajo.Item("ORT_numero_ot", dgvLista_Orden_Trabajo.CurrentRow.Index).Value _
                                             & "                   " _
                                            , New Font(fuente, 22, Font.Bold))

            Dim ingreso_vendedor As New Paragraph("Fecha ingreso: " & dgvLista_Orden_Trabajo.SelectedRows(0).Cells("ORT_fecha_ot").Value _
                                             & "  " _
                                             & "                          " _
                                             & "Vendedor: " & dgvLista_Orden_Trabajo.Item("VEN_nombre_ven", dgvLista_Orden_Trabajo.CurrentRow.Index).Value _
                                             , New Font(fuente, 12, Font.Bold))

            Dim cliente As New Paragraph("Cliente: " & dgvLista_Orden_Trabajo.Item("CLI_razon_social", dgvLista_Orden_Trabajo.CurrentRow.Index).Value _
                                             , New Font(fuente, 12))

            Dim entrega As New Paragraph("Entregar en: " & dgvLista_Orden_Trabajo.Item("ORT_mejoras_ot", dgvLista_Orden_Trabajo.CurrentRow.Index).Value _
                                             , New Font(fuente, 12))

            Dim prod_desc As New Paragraph("Descripción: " _
                                           & dgvLista_Orden_Trabajo.Item("ORT_observaciones_ot", dgvLista_Orden_Trabajo.CurrentRow.Index).Value _
                                           , New Font(fuente, 10, Font.Bold))

            Dim encabezado As New Paragraph
            encabezado.Add(orden)
            'Encabezado
            doc.Add(encabezado)
            'Info
            doc.Add(ingreso_vendedor)
            doc.Add(cliente)
            doc.Add(entrega)
            'Descripción
            doc.Add(prod_desc)
            doc.Add(linea)
            'Productos
            For i = 0 To dgv_detalle_orden.RowCount - 1
                dgv_detalle_orden.Rows(i).Selected = True
                'dgv_detalle_orden_CellClick(0, Nothing)
                pdf_informe_diario_sin_tablas(doc, i)
                doc.Add(linea)
            Next
            doc.Close()
            writer.Close()
            Process.Start(filename)

            'Me.Close()
        Catch ex As Exception
            'si el mensaje es fallido mostrar msgbox
            MessageBox.Show("No se puede generar el pdf, cierre el pdf anterior y vuleva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Dibujar_Lineas(ByVal cb As PdfContentByte, ByVal doc As Document)
        'LINEAS DE FONDO
        'H1
        cb.MoveTo(0, 800)
        cb.LineTo(doc.PageSize.Width, 800)
        cb.Stroke()
        'H2
        cb.MoveTo(0, 747)
        cb.LineTo(doc.PageSize.Width, 747)
        cb.Stroke()
        'V1
        cb.MoveTo(400, doc.PageSize.Height)
        cb.LineTo(400, 800)
        cb.Stroke()
    End Sub

    Sub Escribir_Pdf(ByVal cb As PdfContentByte)
        'ESCRIBIR EN EL PDF
        'PARA LA FUENTE
        cb.SetFontAndSize(fuente, 16)
        cb.BeginText()
        Dim text As String = "Entrega: " & dgvLista_Orden_Trabajo.Item("ORT_fecha_entrega", dgvLista_Orden_Trabajo.CurrentRow.Index).Value

        ' Set the alignment and coordinates here
        cb.ShowTextAligned(1, text, 480, 820, 0)
        cb.EndText()
    End Sub

    Sub pdf_informe_diario_sin_tablas(ByVal doc As Document, ByVal fila_actual As Integer)

        'Agregado de item 1
        Dim prod_tit As New Paragraph("ITEM " & (fila_actual + 1))
        Dim prod_det As New Paragraph(dgv_detalle_orden.Item("DOT_cantidad_producto", dgv_detalle_orden.Rows(fila_actual).Index).Value _
                                      & "  " _
                                      & dgv_detalle_orden.Item("PIE_nombre_pie", dgv_detalle_orden.Rows(fila_actual).Index).Value _
                                      & "   " _
                                      & dgv_detalle_orden.Item("DOT_tamaño_producto", dgv_detalle_orden.Rows(fila_actual).Index).Value _
                                      & "   " _
                                      & dgv_detalle_orden.Item("DOT_tipo_impresion_dot", dgv_detalle_orden.Rows(fila_actual).Index).Value _
                                      , New Font(fuente, 16, Font.Bold))
        doc.Add(prod_tit)
        doc.Add(prod_det)

        'Agregado de soportes
        Dim soporte As New Paragraph
        Dim temp_cadena_cant, temp_cadena_papel, temp_cadena_gram, temp_cadena_formato As String
        For j = 0 To 2 'dgv_detalle_orden.RowCount
            temp_cadena_cant = "DOT_cantidad_soporte_" & j + 1
            temp_cadena_papel = "DOT_papel_soporte_" & j + 1
            temp_cadena_gram = "DOT_gramaje_soporte_" & j + 1
            temp_cadena_formato = "DOT_formato_soporte_" & j + 1
            If Len(dgv_detalle_orden.Item(temp_cadena_cant, dgv_detalle_orden.Rows(fila_actual).Index).Value) <> 0 Then
                soporte = New Paragraph("           Soporte " & j + 1 & " : " _
                                         & dgv_detalle_orden.Item(temp_cadena_cant, dgv_detalle_orden.Rows(fila_actual).Index).Value & "   " _
                                         & dgv_detalle_orden.Item(temp_cadena_papel, dgv_detalle_orden.Rows(fila_actual).Index).Value & " " _
                                         & dgv_detalle_orden.Item(temp_cadena_gram, dgv_detalle_orden.Rows(fila_actual).Index).Value & "   " _
                                         & dgv_detalle_orden.Item(temp_cadena_formato, dgv_detalle_orden.Rows(fila_actual).Index).Value & "    " _
                                         , New Font(fuente, 8))
            Else
                soporte = New Paragraph("")
            End If
            doc.Add(soporte)
        Next
        'Dim pro_offset As New Paragraph("  Offset: " & dgvProcesos.Item("PROC_descrip_offset", dgvProcesos.Rows(0).Index).Value, New Font(fuente, 10, Font.Bold))
        'Dim pro_digital As New Paragraph("  Digital: " & dgvProcesos.Item("PROC_descrip_digital", dgvProcesos.Rows(0).Index).Value, New Font(fuente, 10, Font.Bold))
        'Dim pro_g_form As New Paragraph("  Gran formato: " & dgvProcesos.Item("PROC_descrip_gran_formato", dgvProcesos.Rows(0).Index).Value, New Font(fuente, 10, Font.Bold))
        'Dim pro_term As New Paragraph("  Terminación: " & dgvProcesos.Item("PROC_descrip_terminacion", dgvProcesos.Rows(0).Index).Value, New Font(fuente, 10, Font.Bold))
        'Dim pro_logi As New Paragraph("  Logística: " & dgvProcesos.Item("PROC_descrip_logistica", dgvProcesos.Rows(0).Index).Value, New Font(fuente, 10, Font.Bold))

        'doc.Add(pro_offset)
        'doc.Add(pro_digital)
        'doc.Add(pro_g_form)
        'doc.Add(pro_term)
        'doc.Add(pro_logi)
    End Sub

    Private Sub btnAgregarProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarProducto.Click
        Try
            'como seguro,se indica al form orden_ampliada q el que llama no es el listado de orden_ampliada sino cualq (se le miente!!!!!!!)

            frm_Orden_Trabajo_Ampliada.quienllamo_listado_orden_ampliada = frm_Principal
            '------------------------------------------------------------------------------------------------------------------------------------
            If dgvLista_Orden_Trabajo.SelectedRows.Count > 0 Then
                frm_Orden_Trabajo_Ampliada.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtNumero_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_numero_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.dtpFecha_Ingreso_ODT.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboTipo_Orden.Text = dgvLista_Orden_Trabajo.Item("ORT_tipo_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.dtpFecha_Entrega_ODT.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_entrega", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_id_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_id_cliente", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_nombre_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_razon_social", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtid_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_id_vendedor", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtNombre_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_nombre_ven", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_observaciones.Text = dgvLista_Orden_Trabajo.Item("ORT_observaciones_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboDireccion_Entrega.Text = dgvLista_Orden_Trabajo.Item("ORT_mejoras_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            End If
            frm_Orden_Trabajo_Ampliada.Text = ".:. Agregar Producto .:."
            'DESHABILITA EL ENCABEZADO DE LA ORDEN
            frm_Orden_Trabajo_Ampliada.GroupBox4.Enabled = False
            'OCULTA LABELS E ID 
            frm_Orden_Trabajo_Ampliada.Label1.Visible = False
            frm_Orden_Trabajo_Ampliada.txt_id_orden_trabajo.Visible = False
            frm_Orden_Trabajo_Ampliada.Label5.Visible = False
            frm_Orden_Trabajo_Ampliada.txt_id_detalle_orden_trabajo1.Visible = False
            frm_Orden_Trabajo_Ampliada.Label45.Visible = False
            frm_Orden_Trabajo_Ampliada.txt_id_cliente.Visible = False
            frm_Orden_Trabajo_Ampliada.txtid_vendedor.Visible = False

            frm_Orden_Trabajo_Ampliada.GroupProducto_Soportes.Enabled = False
            frm_Orden_Trabajo_Ampliada.GroupDigital.Enabled = False
            frm_Orden_Trabajo_Ampliada.GroupGranFormato.Enabled = False
            frm_Orden_Trabajo_Ampliada.groupOffset.Enabled = False
            frm_Orden_Trabajo_Ampliada.GroupTerminacion.Enabled = False
            frm_Orden_Trabajo_Ampliada.Label8.Visible = False
            frm_Orden_Trabajo_Ampliada.cboTipo_Orden.Visible = False

            'PARA QUE TIRE ERROR DE QUE YA EXISTE LA ORDEN
            frm_Orden_Trabajo_Ampliada.cargamasprod = "SI"

            frm_Orden_Trabajo_Ampliada.Show()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'VER CON VALE!!! hay mas codigo en el load de este form

        'Try
        '    System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
        'Catch ex As Exception
        '    MsgBox("No se encuentra la ruta")
        'End Try

    End Sub

    Private Sub btn_Generar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Imprimir_Orden.Click
        'Dim dt As New DataS_Reportes
        'For Each dr As DataGridViewRow In dgv_detalle_orden.Rows
        '    dt.DT_Orden.AddDT_OrdenRow(dr.Cells("ORT_id_orden_trabajo").Value,
        '                               dr.Cells("ORT_tipo_ot").Value,
        '                               dr.Cells("ORT_numero_ot").Value,
        '                               dr.Cells("ORT_observaciones_ot").Value,
        '                               dr.Cells("ORT_mejoras_ot").Value,
        '                               dr.Cells("VEN_id_vendedor").Value,
        '                               dr.Cells("VEN_nombre_ven").Value,
        '                               dr.Cells("VEN_apellido_ven").Value,
        '                               dr.Cells("ORT_fecha_ot").Value,
        '                               dr.Cells("ORT_fecha_entrega").Value,
        '                               dr.Cells("CLI_id_cliente").Value,
        '                               dr.Cells("CLI_razon_social").Value,
        '                               dr.Cells("CLI_domicilio").Value,
        '                               dr.Cells("PIE_id_pieza").Value,
        '                               dr.Cells("PIE_id_pieza_offset").Value,
        '                               dr.Cells("PIE_nombre_pie").Value,
        '                               dr.Cells("PIE_ubicacion").Value,
        '                               dr.Cells("id_detalle_orden_trabajo").Value,
        '                               dr.Cells("DOT_cantidad_producto").Value,
        '                               dr.Cells("DOT_tamaño_producto").Value,
        '                               dr.Cells("DOT_tipo_impresion_dot").Value,
        '                               dr.Cells("DOT_papel_soporte_1").Value,
        '                               dr.Cells("DOT_papel_soporte_2").Value,
        '                               dr.Cells("DOT_papel_soporte_3").Value,
        '                               dr.Cells("DOT_gramaje_soporte_1").Value,
        '                               dr.Cells("DOT_gramaje_soporte_2").Value,
        '                               dr.Cells("DOT_gramaje_soporte_3").Value,
        '                               dr.Cells("DOT_cantidad_soporte_1").Value,
        '                               dr.Cells("DOT_cantidad_soporte_2").Value,
        '                               dr.Cells("DOT_cantidad_soporte_3").Value,
        '                               dr.Cells("DOT_formato_soporte_1").Value,
        '                               dr.Cells("DOT_formato_soporte_2").Value,
        '                               dr.Cells("DOT_formato_soporte_3").Value,
        '                               dr.Cells("cantidad_1_PM_offset").Value,
        '                               dr.Cells("cantidad_2_PM_offset").Value,
        '                               dr.Cells("cantidad_3_PM_offset").Value,
        '                               dr.Cells("formato_1_PM_offset").Value,
        '                               dr.Cells("formato_2_PM_offset").Value,
        '                               dr.Cells("formato_3_PM_offset").Value,
        '                               dr.Cells("modo_impresion_offset").Value,
        '                               dr.Cells("tipo_impresion_offset").Value,
        '                               dr.Cells("chapas_soporte1_offset").Value,
        '                               dr.Cells("chapas_soporte2_offset").Value,
        '                               dr.Cells("chapas_soporte3_offset").Value,
        '                               dr.Cells("impresora_offset").Value,
        '                               dr.Cells("marca_offset").Value,
        '                               dr.Cells("cantidad_1_PM_digital").Value,
        '                               dr.Cells("cantidad_2_PM_digital").Value,
        '                               dr.Cells("cantidad_3_PM_digital").Value,
        '                               dr.Cells("formato_1_PM_digital").Value,
        '                               dr.Cells("formato_2_PM_digital").Value,
        '                               dr.Cells("formato_3_PM_digital").Value,
        '                               dr.Cells("modo_impresion_digital").Value,
        '                               dr.Cells("tipo_impresion_digital").Value,
        '                               dr.Cells("dato_variable").Value,
        '                               dr.Cells("Expr1").Value,
        '                               dr.Cells("cantidad_gran_formato").Value,
        '                               dr.Cells("tamaño_gran_formato").Value,
        '                               dr.Cells("sustrato_gran_formato").Value,
        '                               dr.Cells("calidad_gran_formato").Value,
        '                               dr.Cells("sistema_gran_formato").Value,
        '                               dr.Cells("tipo_terminacion").Value,
        '                               dr.Cells("descripcion_terminacion").Value)
        'Next
        'Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        'rptdoc = New rpt_orden
        'rptdoc.SetDataSource(dt)
        'frm_reporte_orden.CrystalReportViewer1.ReportSource = rptdoc
        frm_reporte_orden.Show()
    End Sub


    'CONTROLAR LA HABILITACION Y DESHABILITACION DE CAMPOS
    Private Sub btnDuplicar_Orden_Click(sender As System.Object, e As System.EventArgs) Handles btnDuplicar_Orden.Click
        Try
            frm_Orden_Trabajo_Ampliada.Text = ".:. Duplicar Orden .:."
            If dgv_detalle_orden.SelectedRows.Count > 0 Then

                '   frm_Orden_Trabajo_Ampliada.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtNumero_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_numero_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.dtpFecha_Ingreso_ODT.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboTipo_Orden.Text = dgvLista_Orden_Trabajo.Item("ORT_tipo_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.dtpFecha_Entrega_ODT.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_entrega", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_id_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_id_cliente", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_nombre_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_razon_social", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtid_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_id_vendedor", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtNombre_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_nombre_ven", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_observaciones.Text = dgvLista_Orden_Trabajo.Item("ORT_observaciones_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboDireccion_Entrega.Text = dgvLista_Orden_Trabajo.Item("ORT_mejoras_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value

                frm_Orden_Trabajo_Ampliada.txt_cantidad_producto.Text = dgv_detalle_orden.Item("DOT_cantidad_producto", dgv_detalle_orden.SelectedRows(0).Index).Value
                ' frm_Orden_Trabajo_Ampliada.txt_id_detalle_orden_trabajo1.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtTamaño_Producto.Text = dgv_detalle_orden.Item("DOT_tamaño_producto", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboPapel1.Text = dgv_detalle_orden.Item("DOT_papel_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboPapel2.Text = dgv_detalle_orden.Item("DOT_papel_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboPapel3.Text = dgv_detalle_orden.Item("DOT_papel_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboGramaje1.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboGramaje2.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboGramaje3.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_Cantidad_1_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_Cantidad_2_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_Cantidad_3_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_1_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_2_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_3_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtCantidad_1_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_1_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtCantidad_2_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_2_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtCantidad_3_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_3_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_1_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_1_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_2_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_2_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_3_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_3_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboModo_Impresion_Offset.Text = dgv_detalle_orden.Item("modo_impresion_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboTipo_Impresion_Offset.Text = dgv_detalle_orden.Item("tipo_impresion_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_chapa_soporte_1.Text = dgv_detalle_orden.Item("chapas_soporte1_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_chapa_soporte_2.Text = dgv_detalle_orden.Item("chapas_soporte2_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_chapa_soporte_3.Text = dgv_detalle_orden.Item("chapas_soporte3_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboImpresora_Offset.Text = dgv_detalle_orden.Item("impresora_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboMarca_Offset.Text = dgv_detalle_orden.Item("marca_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtCantidad_1_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_1_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtCantidad_2_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_2_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtCantidad_3_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_3_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_1_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_1_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_2_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_2_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboFormato_3_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_3_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboTipo_Impresion_Digital.Text = dgv_detalle_orden.Item("tipo_impresion_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtDato_Variable.Text = dgv_detalle_orden.Item("dato_variable", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_cantidad_producto_Gran_Formato.Text = dgv_detalle_orden.Item("cantidad_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txtTamaño_Producto_Gran_Formato.Text = dgv_detalle_orden.Item("tamaño_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboMaterial.Text = dgv_detalle_orden.Item("sustrato_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboCalidad_Gran_Formato.Text = dgv_detalle_orden.Item("calidad_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.cboSistema_Gran_Formato.Text = dgv_detalle_orden.Item("sistema_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
                frm_Orden_Trabajo_Ampliada.txt_descripcion_terminacion.Text = dgv_detalle_orden.Item("descripcion_terminacion", dgv_detalle_orden.SelectedRows(0).Index).Value

                Dim tempterminacion As String
                tempterminacion = dgv_detalle_orden.Item("tipo_terminacion", dgv_detalle_orden.SelectedRows(0).Index).Value

                If tempterminacion.Contains("T01") Then
                    frm_Orden_Trabajo_Ampliada.chkAdhesivado.Checked = True
                End If
                If tempterminacion.Contains("T02") Then
                    frm_Orden_Trabajo_Ampliada.chkArmadoRevistas.Checked = True
                End If
                If tempterminacion.Contains("T03") Then
                    frm_Orden_Trabajo_Ampliada.chkBarniz.Checked = True
                End If
                If tempterminacion.Contains("T04") Then
                    frm_Orden_Trabajo_Ampliada.chkCocido.Checked = True
                End If
                If tempterminacion.Contains("T05") Then
                    frm_Orden_Trabajo_Ampliada.chkCuño.Checked = True
                End If
                If tempterminacion.Contains("T06") Then
                    frm_Orden_Trabajo_Ampliada.chkDoblado.Checked = True
                End If
                If tempterminacion.Contains("T07") Then
                    frm_Orden_Trabajo_Ampliada.chkEncuadernacion.Checked = True
                End If
                If tempterminacion.Contains("T08") Then
                    frm_Orden_Trabajo_Ampliada.chkEstampado.Checked = True
                End If
                If tempterminacion.Contains("T09") Then
                    frm_Orden_Trabajo_Ampliada.chkFresado.Checked = True
                End If
                If tempterminacion.Contains("T10") Then
                    frm_Orden_Trabajo_Ampliada.chkGuillotinado.Checked = True
                End If
                If tempterminacion.Contains("T11") Then
                    frm_Orden_Trabajo_Ampliada.chkLaca_UV.Checked = True
                End If
                If tempterminacion.Contains("T12") Then
                    frm_Orden_Trabajo_Ampliada.chkLacaUVSectorizada.Checked = True
                End If
                If tempterminacion.Contains("T13") Then
                    frm_Orden_Trabajo_Ampliada.chkMedio_Corte.Checked = True
                End If
                If tempterminacion.Contains("T14") Then
                    frm_Orden_Trabajo_Ampliada.chkMontado.Checked = True
                End If
                If tempterminacion.Contains("T15") Then
                    frm_Orden_Trabajo_Ampliada.chkOPPBrillante.Checked = True
                End If
                If tempterminacion.Contains("T16") Then
                    frm_Orden_Trabajo_Ampliada.chkOPPMate.Checked = True
                End If
                If tempterminacion.Contains("T17") Then
                    frm_Orden_Trabajo_Ampliada.chkOtros.Checked = True
                End If
                If tempterminacion.Contains("T18") Then
                    frm_Orden_Trabajo_Ampliada.chkPegadoManual.Checked = True
                End If
                If tempterminacion.Contains("T19") Then
                    frm_Orden_Trabajo_Ampliada.chkPlastificado.Checked = True
                End If
                If tempterminacion.Contains("T20") Then
                    frm_Orden_Trabajo_Ampliada.chkPosicionado.Checked = True
                End If
                If tempterminacion.Contains("T21") Then
                    frm_Orden_Trabajo_Ampliada.chkRuedo.Checked = True
                End If
                If tempterminacion.Contains("T22") Then
                    frm_Orden_Trabajo_Ampliada.chkSoldado.Checked = True
                End If
                If tempterminacion.Contains("T23") Then
                    frm_Orden_Trabajo_Ampliada.chkStamping.Checked = True
                End If
                If tempterminacion.Contains("T24") Then
                    frm_Orden_Trabajo_Ampliada.chkTermosellado.Checked = True
                End If
                If tempterminacion.Contains("T25") Then
                    frm_Orden_Trabajo_Ampliada.chkTrazado.Checked = True
                End If
                If tempterminacion.Contains("T26") Then
                    frm_Orden_Trabajo_Ampliada.chkTroquelado.Checked = True
                End If

            Else
                MsgBox("Seleccione un Producto del segundo listado")
                Exit Sub
            End If

            Dim flagsoporte As Integer = 0

            'CONTROLES OFFSET
            If frm_Orden_Trabajo_Ampliada.txtCantidad_1_Pliego_Maquina_Offset.TextLength <> 0 Then
                frm_Orden_Trabajo_Ampliada.chkOffset.Checked = True
                frm_Orden_Trabajo_Ampliada.chkOffset.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkDigital.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkGranFormato.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkTerminacion.Enabled = False
                frm_Orden_Trabajo_Ampliada.groupOffset.Enabled = False
                frm_Orden_Trabajo_Ampliada.GroupProducto_Soportes.Enabled = False
                flagsoporte = 1
            Else
                frm_Orden_Trabajo_Ampliada.chkOffset.Checked = False
                frm_Orden_Trabajo_Ampliada.groupOffset.Enabled = False
                If flagsoporte = 0 Then
                    frm_Orden_Trabajo_Ampliada.GroupProducto_Soportes.Enabled = False
                End If
            End If

            'CONTROLES DIGITAL
            If frm_Orden_Trabajo_Ampliada.txtCantidad_1_Pliego_Maquina_Digital.TextLength <> 0 Then
                frm_Orden_Trabajo_Ampliada.chkDigital.Checked = True
                frm_Orden_Trabajo_Ampliada.chkDigital.Enabled = False

                frm_Orden_Trabajo_Ampliada.GroupDigital.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkOffset.Enabled = False

                frm_Orden_Trabajo_Ampliada.chkGranFormato.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkTerminacion.Enabled = False
                frm_Orden_Trabajo_Ampliada.GroupProducto_Soportes.Enabled = False
                flagsoporte = 1
            Else
                frm_Orden_Trabajo_Ampliada.chkDigital.Checked = False
                frm_Orden_Trabajo_Ampliada.GroupDigital.Enabled = False
                If flagsoporte = 0 Then
                    frm_Orden_Trabajo_Ampliada.GroupProducto_Soportes.Enabled = False
                End If
            End If

            'CONTROLES GRAN FORMATO
            If frm_Orden_Trabajo_Ampliada.txt_cantidad_producto_Gran_Formato.TextLength <> 0 Then
                frm_Orden_Trabajo_Ampliada.chkGranFormato.Checked = True
                frm_Orden_Trabajo_Ampliada.chkGranFormato.Enabled = False
                frm_Orden_Trabajo_Ampliada.GroupGranFormato.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkOffset.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkDigital.Enabled = False

                frm_Orden_Trabajo_Ampliada.chkTerminacion.Enabled = False
            Else
                frm_Orden_Trabajo_Ampliada.chkGranFormato.Checked = False
                frm_Orden_Trabajo_Ampliada.GroupGranFormato.Enabled = False
            End If
            'CONTROLES TERMINACION
            If dgv_detalle_orden.Item("tipo_terminacion", dgv_detalle_orden.SelectedRows(0).Index).Value.ToString.Length <> 0 Then
                frm_Orden_Trabajo_Ampliada.chkTerminacion.Checked = True
                frm_Orden_Trabajo_Ampliada.chkTerminacion.Enabled = False
                frm_Orden_Trabajo_Ampliada.GroupTerminacion.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkOffset.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkDigital.Enabled = False
                frm_Orden_Trabajo_Ampliada.chkGranFormato.Enabled = False

            Else
                frm_Orden_Trabajo_Ampliada.chkTerminacion.Checked = False
                frm_Orden_Trabajo_Ampliada.GroupTerminacion.Enabled = False
            End If

            ' frm_Orden_Trabajo_Ampliada.GroupBox4.Enabled = False
            frm_Orden_Trabajo_Ampliada.txtNumero_Orden_Trabajo.Enabled = True
            frm_Orden_Trabajo_Ampliada.dtpFecha_Entrega_ODT.Enabled = True
            frm_Orden_Trabajo_Ampliada.dtpFecha_Ingreso_ODT.Enabled = True
            frm_Orden_Trabajo_Ampliada.txtNombre_vendedor.Enabled = True
            frm_Orden_Trabajo_Ampliada.btnBuscar_Vendedor.Enabled = True
            frm_Orden_Trabajo_Ampliada.txt_nombre_cliente.Enabled = True
            frm_Orden_Trabajo_Ampliada.btnBuscar_cliente.Enabled = True
            frm_Orden_Trabajo_Ampliada.cboDireccion_Entrega.Enabled = True
            'frm_Orden_Trabajo_Ampliada.txt_observaciones.ReadOnly = True
            'frm_Orden_Trabajo_Ampliada.txt_observaciones.ScrollBars = True

            frm_Orden_Trabajo_Ampliada.Label1.Visible = False
            frm_Orden_Trabajo_Ampliada.txt_id_orden_trabajo.Visible = False
            frm_Orden_Trabajo_Ampliada.cboTipo_Orden.Visible = False
            frm_Orden_Trabajo_Ampliada.Label5.Visible = False
            frm_Orden_Trabajo_Ampliada.Label45.Visible = False
            frm_Orden_Trabajo_Ampliada.txt_id_detalle_orden_trabajo1.Visible = False
            frm_Orden_Trabajo_Ampliada.txtid_vendedor.Visible = False
            frm_Orden_Trabajo_Ampliada.txt_id_cliente.Visible = False
            frm_Orden_Trabajo_Ampliada.btnGuardar_Orden_Trabajo.Enabled = False
            frm_Orden_Trabajo_Ampliada.Label8.Visible = False

            frm_Orden_Trabajo_Ampliada.quienllamo_listado_orden_ampliada = Me
            frm_Orden_Trabajo_Ampliada.Show()
        Catch ex As Exception
        End Try
    End Sub
End Class

