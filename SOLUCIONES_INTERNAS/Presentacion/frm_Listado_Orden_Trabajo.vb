Imports System.Drawing.Printing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
'Imports SOLUCIONES_INTERNAS.Class_Generar_pdf
'creo la fuente

Public Class frm_Listado_Orden_Trabajo

    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Public quienllamolistado_ot As Form
    Public quienllamoboton As Button

    Public vble_id_orden As Integer
    Public vble_id_detalle As Integer
    Dim vble_id_proceso As Integer
    Dim vble_colaborador, vble_fecha As String

    'campos y vbles para generar pdf
    'Public contadorcolumnasvisibles As Integer
    Dim fuente As iTextSharp.text.pdf.BaseFont = FontFactory.GetFont(FontFactory.HELVETICA).BaseFont

    Private Sub frm_Detalle_Orden_Trabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        armargrilla()
        cargargrilla()
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
        dgvLista_Orden_Trabajo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_detalle_orden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvProcesos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        txt_Buscar_Cliente.Enabled = False
        dtp_Buscar_Fecha_Entrega.Enabled = False
        rbtNroOrden.Checked = True
        txt_Buscar_orden_trabajo.Enabled = True
    End Sub

    'CARGA GRILLA ORDEN TRABAJO
    Public Sub cargargrilla()
        Dim consultaOrden = (From U In datacontext.ORDEN_TRABAJO
                               Join ort In datacontext.VENDEDOR
                               On U.VEN_id_vendedor Equals ort.VEN_id_vendedor
                               Join col In datacontext.CLIENTE
                               On col.CLI_id_cliente Equals U.CLI_id_cliente
                              Select U.ORT_id_orden_trabajo, U.ORT_fecha_ot, U.ORT_fecha_entrega, U.ORT_tipo_ot, U.ORT_numero_ot,
                              U.ORT_observaciones_ot, U.ORT_mejoras_ot, U.VEN_id_vendedor, ort.VEN_nombre_ven, U.CLI_id_cliente, col.CLI_razon_social
                              Order By ORT_id_orden_trabajo Descending)
        dgvLista_Orden_Trabajo.DataSource = consultaOrden
        dgvLista_Orden_Trabajo.ClearSelection()
    End Sub

    'ARMA GRILLA ORDEN
    Private Sub armargrilla()
        dgvLista_Orden_Trabajo.Enabled = True
        dgvLista_Orden_Trabajo.AutoGenerateColumns = False
        dgvLista_Orden_Trabajo.Columns.Clear()

        dgvLista_Orden_Trabajo.Columns.Add("ORT_id_orden_trabajo", "TN")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_tipo_ot", "Tipo")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_numero_ot", "Número")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_fecha_ot", "Fecha")
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
        '  dgvLista_Orden_Trabajo.Columns(1).Width = 50
        dgvLista_Orden_Trabajo.Columns(2).DataPropertyName = "ORT_numero_ot"
        dgvLista_Orden_Trabajo.Columns(3).DataPropertyName = "ORT_fecha_ot"
        dgvLista_Orden_Trabajo.Columns(4).DataPropertyName = "CLI_id_cliente"
        dgvLista_Orden_Trabajo.Columns(4).Visible = False
        dgvLista_Orden_Trabajo.Columns(5).DataPropertyName = "CLI_razon_social"
        dgvLista_Orden_Trabajo.Columns(6).DataPropertyName = "VEN_id_vendedor"
        dgvLista_Orden_Trabajo.Columns(6).Visible = False
        dgvLista_Orden_Trabajo.Columns(7).DataPropertyName = "VEN_nombre_ven"
        dgvLista_Orden_Trabajo.Columns(8).DataPropertyName = "ORT_observaciones_ot"
        dgvLista_Orden_Trabajo.Columns(9).DataPropertyName = "ORT_mejoras_ot"
        dgvLista_Orden_Trabajo.Columns(9).Visible = False
        dgvLista_Orden_Trabajo.Columns(10).DataPropertyName = "ORT_fecha_entrega"
    End Sub

    Private Sub dgvLista_Orden_Trabajo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Orden_Trabajo.CellClick
        'VALIDA QUE SE HAYA SELECCONADO UN SECTOR Y UNA FECHA
        If dgvLista_Orden_Trabajo.Rows.Count = 0 Then
            MsgBox("No hay órdenes", MsgBoxStyle.Information + MsgBoxStyle.Information, "Seleccionar")
            Exit Sub
        End If
        Try
            vble_id_orden = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            CargarDetalle()
            'LIMPIA EL GRID DE PROCESOS
            dgvProcesos.DataSource = ""

            'SE FIJA QUIEN LLAMO PARA HABILITAR BOTONES
            If Me.Text = "Modificar Orden / Producto / Proceso" Then
                btnModificar_Orden.Enabled = True
                btnEliminar_Orden.Enabled = False
            ElseIf Me.Text = "Eliminar Orden / Producto / Proceso" Then
                btnModificar_Orden.Enabled = False
                btnEliminar_Orden.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    'CARGA DETALLES DE LA ORDEN
    Public Sub CargarDetalle()
        'datavistas.Vista_Detalle_Orden_Trabajo_1
        Dim datagriddetalleorden =
                (From o In datavistas.Vista_Detalle_Orden_Trabajo_1
         Select o.ORT_id_orden_trabajo,
                          o.ORT_tipo_ot,
                          o.ORT_numero_ot,
                          o.ORT_observaciones_ot,
                          o.VEN_id_vendedor,
                          o.VEN_nombre_ven,
                          o.CLI_id_cliente,
                          o.CLI_razon_social, _
                          o.PIE_id_pieza,
                          o.PIE_nombre_pie,
                          o.id_detalle_orden_trabajo,
                          o.DOT_cantidad_producto,
                          o.DOT_tamaño_producto,
                          o.DOT_tipo_impresion_dot,
                          o.DOT_papel_soporte_1,
                          o.DOT_papel_soporte_2,
                          o.DOT_papel_soporte_3,
                          o.DOT_gramaje_soporte_1,
                          o.DOT_gramaje_soporte_2,
                          o.DOT_gramaje_soporte_3,
                          o.DOT_cantidad_soporte_1,
                          o.DOT_cantidad_soporte_2,
                          o.DOT_cantidad_soporte_3, _
                          o.DOT_formato_soporte_1,
                          o.DOT_formato_soporte_2,
                          o.DOT_formato_soporte_3
                          Where ORT_id_orden_trabajo = vble_id_orden)
        mostrargrillaobligaciones(datagriddetalleorden)
        Label1.Text = dgv_detalle_orden.Rows.Count
    End Sub

    Private Sub dgv_detalle_orden_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_detalle_orden.CellClick
        Try
            If dgvLista_Orden_Trabajo.Rows.Count = 0 Then
                MsgBox("No hay procesos por mostrar", MsgBoxStyle.Information + MsgBoxStyle.Information, "Seleccionar")
                Exit Sub
            End If
            'CARGA PROCESOS DEL PRODUCTO
            vble_id_proceso = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgv_detalle_orden.SelectedRows(0).Index).Value
            CargarProceso()

            If Me.Text = "Modificar Orden / Producto / Proceso" Then
                btnModificarProducto.Enabled = True
                btnEliminar_Producto.Enabled = False
            ElseIf Me.Text = "Eliminar Orden / Producto / Proceso" Then
                btnModificarProducto.Enabled = False
                btnEliminar_Producto.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub CargarProceso()
        Dim datagridproceso = (From p In datacontext.PROCESO
                               Select p.PROC_id_proceso,
                               p.PROC_descrip_digital,
                               p.PROC_descrip_gran_formato,
                               p.PROC_descrip_logistica,
                               p.PROC_descrip_offset,
                               p.PROC_descrip_terminacion,
                               p.id_detalle_orden_trabajo
                               Where id_detalle_orden_trabajo = vble_id_proceso)
        CargaProcesoProducto(datagridproceso)
        'dgvProcesos.ClearSelection()
    End Sub

    Public Sub CargaProcesoProducto(ByVal dataproceso As System.Linq.IQueryable)
        dgvProcesos.AutoGenerateColumns = False
        dgvProcesos.Columns.Clear()

        dgvProcesos.Columns.Add("PROC_id_proceso", "PROC_id_proceso")
        dgvProcesos.Columns.Add("id_detalle_orden_trabajo", "id_detalle_orden_trabajo")
        dgvProcesos.Columns.Add("PROC_descrip_offset", "OffSet")
        dgvProcesos.Columns.Add("PROC_descrip_digital", "Digital")
        dgvProcesos.Columns.Add("PROC_descrip_gran_formato", "Gran Formato")
        dgvProcesos.Columns.Add("PROC_descrip_terminacion", "Terminación")
        dgvProcesos.Columns.Add("PROC_descrip_logistica", "Logística")

        dgvProcesos.Columns(0).DataPropertyName = "PROC_id_proceso"
        dgvProcesos.Columns(0).Visible = False
        dgvProcesos.Columns(1).DataPropertyName = "id_detalle_orden_trabajo"
        dgvProcesos.Columns(1).Visible = False
        dgvProcesos.Columns(2).DataPropertyName = "PROC_descrip_offset"
        dgvProcesos.Columns(3).DataPropertyName = "PROC_descrip_digital"
        dgvProcesos.Columns(4).DataPropertyName = "PROC_descrip_gran_formato"
        dgvProcesos.Columns(5).DataPropertyName = "PROC_descrip_terminacion"
        dgvProcesos.Columns(6).DataPropertyName = "PROC_descrip_logistica"

        dgvProcesos.DataSource = dataproceso
    End Sub

    Private Sub btnModificarProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProceso.Click
        frm_Proceso1.btnAceptar.Enabled = False
        frm_Proceso1.txt_descripc_digital.Text = dgvProcesos.Item("PROC_descrip_digital", dgvProcesos.CurrentRow.Index).Value
        frm_Proceso1.txt_descripc_offset.Text = dgvProcesos.Item("PROC_descrip_offset", dgvProcesos.CurrentRow.Index).Value
        frm_Proceso1.txt_descripc_gran_formato.Text = dgvProcesos.Item("PROC_descrip_gran_formato", dgvProcesos.CurrentRow.Index).Value
        frm_Proceso1.txt_descripc_logistica.Text = dgvProcesos.Item("PROC_descrip_logistica", dgvProcesos.CurrentRow.Index).Value
        frm_Proceso1.txt_descripc_terminacion.Text = dgvProcesos.Item("PROC_descrip_terminacion", dgvProcesos.CurrentRow.Index).Value

        frm_Proceso1.txt_id_proceso.Visible = False
        frm_Proceso1.ShowDialog()
    End Sub

    Public Sub mostrargrillaobligaciones(ByVal datasource As System.Linq.IQueryable)
        dgv_detalle_orden.AutoGenerateColumns = False
        dgv_detalle_orden.Columns.Clear()

        dgv_detalle_orden.Columns.Add("ORT_id_orden_trabajo", "id_orden_trabajo")
        dgv_detalle_orden.Columns.Add("ORT_tipo_ot", "Tipo de orden")
        dgv_detalle_orden.Columns.Add("ORT_numero_ot", "Número de orden")
        dgv_detalle_orden.Columns.Add("ORT_observaciones_ot", "Observaciones")
        dgv_detalle_orden.Columns.Add("VEN_id_vendedor", "id_vendedor")
        dgv_detalle_orden.Columns.Add("VEN_nombre_ven", "Vendedor")
        dgv_detalle_orden.Columns.Add("CLI_id_cliente", "id_cliente")
        dgv_detalle_orden.Columns.Add("CLI_razon_social", "Razón social")
        dgv_detalle_orden.Columns.Add("PIE_id_pieza", "id_pieza")
        dgv_detalle_orden.Columns.Add("PIE_nombre_pie", "Pieza")
        dgv_detalle_orden.Columns.Add("id_detalle_orden_trabajo", "id_detalle_orden_trabajo")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_producto", "Cantidad")
        dgv_detalle_orden.Columns.Add("DOT_tamaño_producto", "Tamaño")
        dgv_detalle_orden.Columns.Add("DOT_tipo_impresion_dot", "Tipo de impresión")

        dgv_detalle_orden.Columns.Add("DOT_papel_soporte_1", "Soporte 1")
        dgv_detalle_orden.Columns.Add("DOT_gramaje_soporte_1", "Gramaje 1")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_soporte_1", "Cantidad 1")
        dgv_detalle_orden.Columns.Add("DOT_formato_soporte_1", "Formato 1")

        dgv_detalle_orden.Columns.Add("DOT_papel_soporte_2", "Soporte 2")
        dgv_detalle_orden.Columns.Add("DOT_gramaje_soporte_2", "Gramaje 2")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_soporte_2", "Cantidad 2")
        dgv_detalle_orden.Columns.Add("DOT_formato_soporte_2", "Formato 2")

        dgv_detalle_orden.Columns.Add("DOT_papel_soporte_3", "Soporte 3")
        dgv_detalle_orden.Columns.Add("DOT_gramaje_soporte_3", "Gramaje 3")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_soporte_3", "Cantidad 3")
        dgv_detalle_orden.Columns.Add("DOT_formato_soporte_3", "Formato soporte 3")

        dgv_detalle_orden.Columns(0).DataPropertyName = "ORT_id_orden_trabajo"
        dgv_detalle_orden.Columns(0).Visible = False
        dgv_detalle_orden.Columns(1).DataPropertyName = "ORT_tipo_ot"
        dgv_detalle_orden.Columns(1).Visible = False
        dgv_detalle_orden.Columns(2).DataPropertyName = "ORT_numero_ot"
        dgv_detalle_orden.Columns(2).Visible = False
        dgv_detalle_orden.Columns(3).DataPropertyName = "ORT_observaciones_ot"
        dgv_detalle_orden.Columns(3).Width = 200
        dgv_detalle_orden.Columns(3).Visible = False
        dgv_detalle_orden.Columns(4).DataPropertyName = "VEN_id_vendedor"
        dgv_detalle_orden.Columns(4).Visible = False
        dgv_detalle_orden.Columns(5).DataPropertyName = "VEN_nombre_ven"
        dgv_detalle_orden.Columns(5).Visible = False
        dgv_detalle_orden.Columns(6).DataPropertyName = "CLI_id_cliente"
        dgv_detalle_orden.Columns(6).Visible = False
        dgv_detalle_orden.Columns(7).DataPropertyName = "CLI_razon_social"
        dgv_detalle_orden.Columns(7).Visible = False
        dgv_detalle_orden.Columns(8).DataPropertyName = "PIE_id_pieza"
        dgv_detalle_orden.Columns(8).Visible = False
        dgv_detalle_orden.Columns(9).DataPropertyName = "PIE_nombre_pie"
        dgv_detalle_orden.Columns(10).DataPropertyName = "id_detalle_orden_trabajo"
        dgv_detalle_orden.Columns(10).Visible = False
        dgv_detalle_orden.Columns(11).DataPropertyName = "DOT_cantidad_dot"
        dgv_detalle_orden.Columns(12).DataPropertyName = "DOT_tamaño_dot"
        dgv_detalle_orden.Columns(13).DataPropertyName = "DOT_tipo_impresion_dot"
        dgv_detalle_orden.Columns(14).DataPropertyName = "DOT_papel_soporte_1"
        ' dgv_detalle_orden.Columns(14).Visible = False
        dgv_detalle_orden.Columns(15).DataPropertyName = "DOT_gramaje_soporte_1"
        '  dgv_detalle_orden.Columns(15).Visible = False
        dgv_detalle_orden.Columns(16).DataPropertyName = "DOT_cantidad_soporte_1"
        ' dgv_detalle_orden.Columns(16).Visible = False
        dgv_detalle_orden.Columns(17).DataPropertyName = "DOT_formato_soporte_1"
        ' dgv_detalle_orden.Columns(17).Visible = False
        dgv_detalle_orden.Columns(18).DataPropertyName = "DOT_papel_soporte_2"
        ' dgv_detalle_orden.Columns(18).Visible = False
        dgv_detalle_orden.Columns(19).DataPropertyName = "DOT_gramaje_soporte_2"
        '  dgv_detalle_orden.Columns(19).Visible = False
        dgv_detalle_orden.Columns(20).DataPropertyName = "DOT_cantidad_soporte_2"
        ' dgv_detalle_orden.Columns(20).Visible = False
        dgv_detalle_orden.Columns(21).DataPropertyName = "DOT_formato_soporte_2"
        '  dgv_detalle_orden.Columns(21).Visible = False
        dgv_detalle_orden.Columns(22).DataPropertyName = "DOT_papel_soporte_3"
        ' dgv_detalle_orden.Columns(22).Visible = False
        dgv_detalle_orden.Columns(23).DataPropertyName = "DOT_gramaje_soporte_3"
        ' dgv_detalle_orden.Columns(23).Visible = False
        dgv_detalle_orden.Columns(24).DataPropertyName = "DOT_cantidad_soporte_3"
        ' dgv_detalle_orden.Columns(24).Visible = False
        dgv_detalle_orden.Columns(25).DataPropertyName = "DOT_formato_soporte_3"
        '  dgv_detalle_orden.Columns(25).Visible = False
        dgv_detalle_orden.DataSource = datasource
        dgv_detalle_orden.ClearSelection()
    End Sub

    'MODIFICA ORDEN
    Private Sub btnModificar_Orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_Orden.Click

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
        frm_Actualizar_Orden.txtNumero_Orden_Trabajo.Enabled = False
        frm_Actualizar_Orden.Label1.Visible = False
        frm_Actualizar_Orden.txt_id_orden_trabajo.Visible = False
        frm_Actualizar_Orden.txt_id_cliente.Visible = False
        frm_Actualizar_Orden.txtid_vendedor.Visible = False
        frm_Actualizar_Orden.txtNombre_vendedor.Enabled = False
        frm_Actualizar_Orden.txt_nombre_cliente.Enabled = False
        frm_Actualizar_Orden.ShowDialog()


    End Sub

    Private Sub txt_Buscar_orden_trabajo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_orden_trabajo.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = "*" & Me.txt_Buscar_orden_trabajo.Text & "*"
        Dim consultaCliente = (From U In datacontext.ORDEN_TRABAJO
                              Join ort In datacontext.VENDEDOR
                              On U.VEN_id_vendedor Equals ort.VEN_id_vendedor
                              Join col In datacontext.CLIENTE
                              On col.CLI_id_cliente Equals U.CLI_id_cliente
                             Select U.ORT_id_orden_trabajo, U.ORT_fecha_ot, U.ORT_fecha_entrega, U.ORT_tipo_ot, U.ORT_numero_ot,
                             U.ORT_observaciones_ot, U.ORT_mejoras_ot, U.VEN_id_vendedor, ort.VEN_nombre_ven, U.CLI_id_cliente, col.CLI_razon_social
                              Where ORT_numero_ot Like buscar.ToString
                             Order By ORT_numero_ot Ascending)
        dgvLista_Orden_Trabajo.DataSource = consultaCliente
        dgvLista_Orden_Trabajo.ClearSelection()
        dgv_detalle_orden.DataSource = ""
        dgvProcesos.DataSource = ""
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub btn_cargar_detalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Orden_Trabajo.Show()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Orden.Click
        If dgvLista_Orden_Trabajo.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.ORDEN_TRABAJO Where C.ORT_id_orden_trabajo = CInt(dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará la orden y su detalle correspondiente, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar orden y detalle")
                Case MsgBoxResult.Yes
                    datacontext.ORDEN_TRABAJO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("La Orden y su Detalle han sido eliminados")
                    cargargrilla()
                    Me.Close()
            End Select
        Else
            MsgBox("Debe seleccionar un orden")
        End If
    End Sub

    Private Sub dgvLista_Orden_Trabajo_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Orden_Trabajo.CellDoubleClick
        Try
            'LLAMA AL FORMULARIO ACTUALIZAR TAREA
            If quienllamolistado_ot.Name = frm_Actualizar_Tarea.Name Then
                frm_Actualizar_Tarea.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                frm_Actualizar_Tarea.txt_numero_orden.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

            ElseIf quienllamolistado_ot.Name = frm_retrabajo.Name Then
                frm_retrabajo.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                frm_retrabajo.txtNumero_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value
                'frm_retrabajo.dtp_Fecha_Ingreso_Original.Text = dgvLista_Orden_Trabajo.SelectedCells(3).Value
                'frm_retrabajo.dtpFecha_Entrega_Original.Text = dgvLista_Orden_Trabajo.SelectedCells(10).Value

            ElseIf quienllamolistado_ot.Name = frm_Etiqueta_Modelo_1.Name Then
                frm_Etiqueta_Modelo_1.txt_id_orden.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                frm_Etiqueta_Modelo_1.txt_orden.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value
                frm_Etiqueta_Modelo_1.txtId_Cliente.Text = dgvLista_Orden_Trabajo.SelectedCells(4).Value
                frm_Etiqueta_Modelo_1.txtDirigidoA.Text = dgvLista_Orden_Trabajo.SelectedCells(5).Value


                Dim traercliente = (From c In datacontext.CLIENTE Select c.CLI_id_cliente, c.CLI_codigo_postal, c.CLI_domicilio, c.CLI_localidad
                                   Where CLI_id_cliente = CInt(dgvLista_Orden_Trabajo.SelectedCells(4).Value)).ToList()(0)

                frm_Etiqueta_Modelo_1.txtDomicilio.Text = traercliente.CLI_domicilio
                frm_Etiqueta_Modelo_1.txtCodigoPostal.Text = traercliente.CLI_codigo_postal
                frm_Etiqueta_Modelo_1.txtLocalidad.Text = traercliente.CLI_localidad

                Dim traerdetalle = (From c In datacontext.DETALLE_ORDEN_TRABAJO Select c.ORT_id_orden_trabajo, c.PIEZA
                                  Where ORT_id_orden_trabajo = CInt(dgvLista_Orden_Trabajo.SelectedCells(0).Value)).ToList

                Select Case traerdetalle.Count
                    Case 1
                        frm_Etiqueta_Modelo_1.txtDescripcionEntrega.Text = traerdetalle.Item(0).PIEZA.PIE_nombre_pie
                    Case 2
                        frm_Etiqueta_Modelo_1.txtDescripcionEntrega.Text = traerdetalle.Item(0).PIEZA.PIE_nombre_pie & " - " & traerdetalle.Item(1).PIEZA.PIE_nombre_pie
                    Case 3
                        frm_Etiqueta_Modelo_1.txtDescripcionEntrega.Text = traerdetalle.Item(0).PIEZA.PIE_nombre_pie & " - " & traerdetalle.Item(1).PIEZA.PIE_nombre_pie & " - " & traerdetalle.Item(2).PIEZA.PIE_nombre_pie
                End Select

            ElseIf quienllamolistado_ot.Name = frm_Movimiento_Producto.Name Then
                frm_Movimiento_Producto.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                frm_Movimiento_Producto.txt_numero_orden.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                'LLAMA AL FORMULARIO TAREA
            ElseIf quienllamolistado_ot.Name = frm_Tarea.Name Then

                Select Case quienllamoboton.Name
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
            Else
                Exit Sub
            End If
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEliminar_Detalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Producto.Click
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

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click

        'CARGA COMBOBOX PIEZA DETALLE 1
        Dim combopieza1 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                           Order By PIE_nombre_pie Ascending)
        frm_Orden_Trabajo.cboPiezas1_Detalle1.DataSource = combopieza1
        frm_Orden_Trabajo.cboPiezas1_Detalle1.DisplayMember = "PIE_nombre_pie"
        frm_Orden_Trabajo.cboPiezas1_Detalle1.ValueMember = "PIE_id_pieza"

        'CARGA COMBOBOX PIEZA DETALLE 2
        Dim combopieza2 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                           Order By PIE_nombre_pie Ascending)
        frm_Orden_Trabajo.cboPiezas2_Detalle2.DataSource = combopieza2
        frm_Orden_Trabajo.cboPiezas2_Detalle2.DisplayMember = "PIE_nombre_pie"
        frm_Orden_Trabajo.cboPiezas2_Detalle2.ValueMember = "PIE_id_pieza"

        'CARGA COMBOBOX PIEZA DETALLE 3
        Dim combopieza3 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                           Order By PIE_nombre_pie Ascending)
        frm_Orden_Trabajo.cboPiezas3_Detalle3.DataSource = combopieza3
        frm_Orden_Trabajo.cboPiezas3_Detalle3.DisplayMember = "PIE_nombre_pie"
        frm_Orden_Trabajo.cboPiezas3_Detalle3.ValueMember = "PIE_id_pieza"

        Try
            If dgv_detalle_orden.Rows.Count > 0 Then
                vble_id_orden = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            Else
                MsgBox("Seleccione una Orden del listado")
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        'LLENA LOS CAMPOS DE LA ORDEN
        If dgvLista_Orden_Trabajo.SelectedRows.Count <> 0 Then
            frm_Orden_Trabajo.txt_id_orden_trabajo.Text = vble_id_orden
            frm_Orden_Trabajo.cboTipo_Orden.SelectedItem = dgvLista_Orden_Trabajo.Item("ORT_tipo_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txtNumero_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_numero_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.dtpFecha_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.dtpFecha_Entrega.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_entrega", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txt_id_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_id_cliente", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txt_nombre_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_razon_social", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txtid_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_id_vendedor", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txtNombre_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_nombre_ven", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txt_observaciones.Text = dgvLista_Orden_Trabajo.Item("ORT_observaciones_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txt_mejoras.Text = dgvLista_Orden_Trabajo.Item("ORT_mejoras_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            Dim flag1, flag2, flag3 As Integer
            If dgv_detalle_orden.RowCount = 1 Then
                flag1 = 1
                flag2 = 0
                flag3 = 0
            ElseIf dgv_detalle_orden.RowCount = 2 Then
                flag1 = 1
                flag2 = 1
                flag3 = 0
            ElseIf dgv_detalle_orden.RowCount = 3 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
            End If

            If dgv_detalle_orden.RowCount > 3 Then
                MsgBox("Para ver total de Productos exporte el listado")
                btn_ODT_mostrar_listado_pdf.Focus()
                Exit Sub
            End If
            If flag1 = 1 Then
                frm_Orden_Trabajo.txt_id_detalle_orden_trabajo1.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgvLista_Orden_Trabajo.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_cantidad1_detalle1.Text = dgv_detalle_orden.Item("DOT_cantidad_dot", dgvLista_Orden_Trabajo.Rows(0).Index).Value
                frm_Orden_Trabajo.cboPiezas1_Detalle1.SelectedValue = dgv_detalle_orden.Item("PIE_id_pieza", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txtTamaño1_Detalle1.Text = dgv_detalle_orden.Item("DOT_tamaño_dot", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.cboTipoImpresion1_Detalle1.SelectedItem = dgv_detalle_orden.Item("DOT_tipo_impresion_dot", dgv_detalle_orden.Rows(0).Index).Value

                frm_Orden_Trabajo.txt_Papel1_Soporte1.Text = dgv_detalle_orden.Item("DOT_papel_soporte_1", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_Papel2_Soporte1.Text = dgv_detalle_orden.Item("DOT_papel_soporte_2", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_Papel3_Soporte1.Text = dgv_detalle_orden.Item("DOT_papel_soporte_3", dgv_detalle_orden.Rows(0).Index).Value

                frm_Orden_Trabajo.txt_Gramaje1_Soporte1.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_1", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_Gramaje2_Soporte1.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_2", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_Gramaje3_Soporte1.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_3", dgv_detalle_orden.Rows(0).Index).Value

                frm_Orden_Trabajo.txt_Cantidad1_Soporte1.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_1", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_Cantidad2_Soporte1.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_2", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_Cantidad3_Soporte1.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_3", dgv_detalle_orden.Rows(0).Index).Value

                frm_Orden_Trabajo.cboFormato1_Soporte1.SelectedItem = dgv_detalle_orden.Item("DOT_formato_soporte_1", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.cboFormato2_Soporte1.SelectedItem = dgv_detalle_orden.Item("DOT_formato_soporte_2", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.cboFormato3_Soporte1.SelectedItem = dgv_detalle_orden.Item("DOT_formato_soporte_3", dgv_detalle_orden.Rows(0).Index).Value

                frm_Orden_Trabajo.cboPiezas2_Detalle2.SelectedIndex = -1
                frm_Orden_Trabajo.cboPiezas3_Detalle3.SelectedIndex = -1
            End If

            If flag2 = 1 Then
                frm_Orden_Trabajo.txt_id_detalle_orden_trabajo2.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgvLista_Orden_Trabajo.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_cantidad2_detalle2.Text = dgv_detalle_orden.Item("DOT_cantidad_dot", dgvLista_Orden_Trabajo.Rows(1).Index).Value
                frm_Orden_Trabajo.cboPiezas2_Detalle2.SelectedValue = dgv_detalle_orden.Item("PIE_id_pieza", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txtTamaño2_Detalle2.Text = dgv_detalle_orden.Item("DOT_tamaño_dot", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.cboTipoImpresion2_Detalle2.SelectedItem = dgv_detalle_orden.Item("DOT_tipo_impresion_dot", dgv_detalle_orden.Rows(1).Index).Value

                frm_Orden_Trabajo.txt_Papel1_Soporte2.Text = dgv_detalle_orden.Item("DOT_papel_soporte_1", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_Papel2_Soporte2.Text = dgv_detalle_orden.Item("DOT_papel_soporte_2", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_Papel3_Soporte2.Text = dgv_detalle_orden.Item("DOT_papel_soporte_3", dgv_detalle_orden.Rows(1).Index).Value

                frm_Orden_Trabajo.txt_Gramaje1_Soporte2.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_1", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_Gramaje2_Soporte2.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_2", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_Gramaje3_Soporte2.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_3", dgv_detalle_orden.Rows(1).Index).Value

                frm_Orden_Trabajo.txt_Cantidad1_Soporte2.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_1", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_Cantidad2_Soporte2.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_2", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_Cantidad3_Soporte2.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_3", dgv_detalle_orden.Rows(1).Index).Value

                frm_Orden_Trabajo.cboFormato1_Soporte2.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_1", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.cboFormato2_Soporte2.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_2", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.cboFormato3_Soporte2.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_3", dgv_detalle_orden.Rows(1).Index).Value

                frm_Orden_Trabajo.cboPiezas3_Detalle3.SelectedIndex = -1
            End If

            If flag3 = 1 Then
                frm_Orden_Trabajo.txt_id_detalle_orden_trabajo3.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgvLista_Orden_Trabajo.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_cantidad3_detalle3.Text = dgv_detalle_orden.Item("DOT_cantidad_dot", dgvLista_Orden_Trabajo.Rows(2).Index).Value
                frm_Orden_Trabajo.cboPiezas3_Detalle3.SelectedValue = dgv_detalle_orden.Item("PIE_id_pieza", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txtTamaño3_Detalle3.Text = dgv_detalle_orden.Item("DOT_tamaño_dot", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.cboTipoImpresion3_Detalle3.SelectedItem = dgv_detalle_orden.Item("DOT_tipo_impresion_dot", dgv_detalle_orden.Rows(2).Index).Value

                frm_Orden_Trabajo.txt_Papel1_Soporte3.Text = dgv_detalle_orden.Item("DOT_papel_soporte_1", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_Papel2_Soporte3.Text = dgv_detalle_orden.Item("DOT_papel_soporte_2", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_Papel3_Soporte3.Text = dgv_detalle_orden.Item("DOT_papel_soporte_3", dgv_detalle_orden.Rows(2).Index).Value

                frm_Orden_Trabajo.txt_Gramaje1_Soporte3.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_1", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_Gramaje2_Soporte3.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_2", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_Gramaje3_Soporte3.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_3", dgv_detalle_orden.Rows(2).Index).Value

                frm_Orden_Trabajo.txt_Cantidad1_Soporte3.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_1", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_Cantidad2_Soporte3.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_2", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_Cantidad3_Soporte3.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_3", dgv_detalle_orden.Rows(2).Index).Value

                frm_Orden_Trabajo.cboFormato1_Soporte3.SelectedItem = dgv_detalle_orden.Item("DOT_formato_soporte_1", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.cboFormato2_Soporte3.SelectedItem = dgv_detalle_orden.Item("DOT_formato_soporte_2", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.cboFormato3_Soporte3.SelectedItem = dgv_detalle_orden.Item("DOT_formato_soporte_3", dgv_detalle_orden.Rows(2).Index).Value
            End If

        End If

        frm_Orden_Trabajo.Text = "Ver Orden"

        frm_Orden_Trabajo.btnProceso1.Text = "Ver Proceso"
        frm_Orden_Trabajo.btnProceso2.Text = "Ver Proceso"
        frm_Orden_Trabajo.btnProceso3.Text = "Ver Proceso"
        frm_Orden_Trabajo.Label45.Visible = False
        frm_Orden_Trabajo.txt_id_detalle_orden_trabajo1.Visible = False
        frm_Orden_Trabajo.Label52.Visible = False
        frm_Orden_Trabajo.txt_id_detalle_orden_trabajo2.Visible = False
        frm_Orden_Trabajo.Label53.Visible = False
        frm_Orden_Trabajo.txt_id_detalle_orden_trabajo3.Visible = False
        frm_Orden_Trabajo.dtpFecha_Entrega.Enabled = False
        frm_Orden_Trabajo.dtpFecha_Orden_Trabajo.Enabled = False

        frm_Orden_Trabajo.btnNueva_Orden_Trabajo.Enabled = False
        frm_Orden_Trabajo.txt_observaciones.Enabled = False
        frm_Orden_Trabajo.txt_mejoras.Enabled = False
        frm_Orden_Trabajo.txtNumero_Orden_Trabajo.Enabled = False
        frm_Orden_Trabajo.cboTipo_Orden.Enabled = False
        frm_Orden_Trabajo.btnGuardar_Orden_Trabajo.Enabled = False
        frm_Orden_Trabajo.btnBuscar_cliente.Enabled = False
        frm_Orden_Trabajo.btnBuscar_Vendedor.Enabled = False
        frm_Orden_Trabajo.txt_id_cliente.Visible = False
        frm_Orden_Trabajo.txtid_vendedor.Visible = False

        frm_Orden_Trabajo.txt_cantidad1_detalle1.Enabled = False
        frm_Orden_Trabajo.cboPiezas1_Detalle1.Enabled = False
        frm_Orden_Trabajo.txtTamaño1_Detalle1.Enabled = False
        frm_Orden_Trabajo.cboTipoImpresion1_Detalle1.Enabled = False

        frm_Orden_Trabajo.txt_Papel1_Soporte1.Enabled = False
        frm_Orden_Trabajo.txt_Papel2_Soporte1.Enabled = False
        frm_Orden_Trabajo.txt_Papel3_Soporte1.Enabled = False
        frm_Orden_Trabajo.txt_Gramaje1_Soporte1.Enabled = False
        frm_Orden_Trabajo.txt_Gramaje2_Soporte1.Enabled = False
        frm_Orden_Trabajo.txt_Gramaje3_Soporte1.Enabled = False
        frm_Orden_Trabajo.txt_Cantidad1_Soporte1.Enabled = False
        frm_Orden_Trabajo.txt_Cantidad2_Soporte1.Enabled = False
        frm_Orden_Trabajo.txt_Cantidad3_Soporte1.Enabled = False
        frm_Orden_Trabajo.cboFormato1_Soporte1.Enabled = False
        frm_Orden_Trabajo.cboFormato2_Soporte1.Enabled = False
        frm_Orden_Trabajo.cboFormato3_Soporte1.Enabled = False

        frm_Orden_Trabajo.txt_cantidad2_detalle2.Enabled = False
        frm_Orden_Trabajo.cboPiezas2_Detalle2.Enabled = False
        frm_Orden_Trabajo.txtTamaño2_Detalle2.Enabled = False
        frm_Orden_Trabajo.cboTipoImpresion2_Detalle2.Enabled = False

        frm_Orden_Trabajo.txt_Papel1_Soporte2.Enabled = False
        frm_Orden_Trabajo.txt_Papel2_Soporte2.Enabled = False
        frm_Orden_Trabajo.txt_Papel3_Soporte2.Enabled = False
        frm_Orden_Trabajo.txt_Gramaje1_Soporte2.Enabled = False
        frm_Orden_Trabajo.txt_Gramaje2_Soporte2.Enabled = False
        frm_Orden_Trabajo.txt_Gramaje3_Soporte2.Enabled = False
        frm_Orden_Trabajo.txt_Cantidad1_Soporte2.Enabled = False
        frm_Orden_Trabajo.txt_Cantidad2_Soporte2.Enabled = False
        frm_Orden_Trabajo.txt_Cantidad3_Soporte2.Enabled = False
        frm_Orden_Trabajo.cboFormato1_Soporte2.Enabled = False
        frm_Orden_Trabajo.cboFormato2_Soporte2.Enabled = False
        frm_Orden_Trabajo.cboFormato3_Soporte2.Enabled = False

        frm_Orden_Trabajo.txt_cantidad3_detalle3.Enabled = False
        frm_Orden_Trabajo.cboPiezas3_Detalle3.Enabled = False
        frm_Orden_Trabajo.txtTamaño3_Detalle3.Enabled = False
        frm_Orden_Trabajo.cboTipoImpresion3_Detalle3.Enabled = False

        frm_Orden_Trabajo.txt_Papel1_Soporte3.Enabled = False
        frm_Orden_Trabajo.txt_Papel2_Soporte3.Enabled = False
        frm_Orden_Trabajo.txt_Papel3_Soporte3.Enabled = False
        frm_Orden_Trabajo.txt_Gramaje1_Soporte3.Enabled = False
        frm_Orden_Trabajo.txt_Gramaje2_Soporte3.Enabled = False
        frm_Orden_Trabajo.txt_Gramaje3_Soporte3.Enabled = False
        frm_Orden_Trabajo.txt_Cantidad1_Soporte3.Enabled = False
        frm_Orden_Trabajo.txt_Cantidad2_Soporte3.Enabled = False
        frm_Orden_Trabajo.txt_Cantidad3_Soporte3.Enabled = False
        frm_Orden_Trabajo.cboFormato1_Soporte3.Enabled = False
        frm_Orden_Trabajo.cboFormato2_Soporte3.Enabled = False
        frm_Orden_Trabajo.cboFormato3_Soporte3.Enabled = False

        frm_Orden_Trabajo.txt_id_orden_trabajo.Enabled = False
        frm_Orden_Trabajo.txtNombre_vendedor.Enabled = False
        frm_Orden_Trabajo.txt_nombre_cliente.Enabled = False

        frm_Orden_Trabajo.btnProceso1.Enabled = True
        frm_Orden_Trabajo.btnProceso2.Enabled = True
        frm_Orden_Trabajo.btnProceso3.Enabled = True
        frm_Orden_Trabajo.btnNueva_Orden_Trabajo.Visible = False
        frm_Orden_Trabajo.btnImprimirFormulario.Enabled = True
        frm_Orden_Trabajo.btnActualizar_Orden_Trabajo.Enabled = False
        frm_Orden_Trabajo.btnCancelar_Orden_Trabajo.Enabled = True

        frm_Orden_Trabajo.ShowDialog()
    End Sub

    Private Sub dgv_detalle_orden_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_detalle_orden.CellDoubleClick
        Try
            quienllamolistado_ot.Name = frm_retrabajo.Name
            frm_retrabajo.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
            frm_retrabajo.txtNumero_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value
            frm_retrabajo.txt_Cantidad_Original.Text = dgv_detalle_orden.SelectedCells(11).Value
            frm_retrabajo.cboPieza_Original.Text = dgv_detalle_orden.SelectedCells(9).Value
            frm_retrabajo.txtTamaño_Original.Text = dgv_detalle_orden.SelectedCells(12).Value
            ' frm_retrabajo.cboTipoImpresion.Text = dgv_detalle_orden.SelectedCells(13).Value
            frm_retrabajo.txt_id_detalle.Text = dgv_detalle_orden.SelectedCells(10).Value
            frm_retrabajo.dtp_Fecha_Ingreso_Original.Text = dgvLista_Orden_Trabajo.SelectedCells(3).Value
            frm_retrabajo.dtpFecha_Entrega_Original.Text = dgvLista_Orden_Trabajo.SelectedCells(10).Value

            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frm_Listado_Orden_Trabajo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnModificarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProducto.Click

        If dgv_detalle_orden.Rows.Count > 0 Then
            frm_Actualizar_Producto_Orden.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden.txtNumero_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_numero_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden.txt_id_detalle_orden_trabajo1.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgv_detalle_orden.CurrentRow.Index).Value
            frm_Actualizar_Producto_Orden.txt_cantidad.Text = dgv_detalle_orden.Item("DOT_cantidad_dot", dgv_detalle_orden.CurrentRow.Index).Value

            frm_Actualizar_Producto_Orden.cboPiezas.SelectedValue = dgv_detalle_orden.Item("PIE_id_pieza", dgv_detalle_orden.CurrentRow.Index).Value

            frm_Actualizar_Producto_Orden.txtTamaño.Text = dgv_detalle_orden.Item("DOT_tamaño_dot", dgv_detalle_orden.CurrentRow.Index).Value
            frm_Actualizar_Producto_Orden.cboTipoImpresion.Text = dgv_detalle_orden.Item("DOT_tipo_impresion_dot", dgv_detalle_orden.CurrentRow.Index).Value

            frm_Actualizar_Producto_Orden.cboPapel1.Text = dgv_detalle_orden.Item("DOT_papel_soporte_1", dgv_detalle_orden.CurrentRow.Index).Value
            frm_Actualizar_Producto_Orden.cboPapel2.Text = dgv_detalle_orden.Item("DOT_papel_soporte_2", dgv_detalle_orden.CurrentRow.Index).Value
            frm_Actualizar_Producto_Orden.cboPapel3.Text = dgv_detalle_orden.Item("DOT_papel_soporte_3", dgv_detalle_orden.CurrentRow.Index).Value

            frm_Actualizar_Producto_Orden.cboGramaje1.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_1", dgv_detalle_orden.CurrentRow.Index).Value
            frm_Actualizar_Producto_Orden.cboGramaje2.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_2", dgv_detalle_orden.CurrentRow.Index).Value
            frm_Actualizar_Producto_Orden.cboGramaje3.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_3", dgv_detalle_orden.CurrentRow.Index).Value

            frm_Actualizar_Producto_Orden.txt_Cantidad1_Soporte.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_1", dgv_detalle_orden.CurrentRow.Index).Value
            frm_Actualizar_Producto_Orden.txt_Cantidad2_Soporte.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_2", dgv_detalle_orden.CurrentRow.Index).Value
            frm_Actualizar_Producto_Orden.txt_Cantidad3_Soporte.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_3", dgv_detalle_orden.CurrentRow.Index).Value

            frm_Actualizar_Producto_Orden.cboFormato1_Soporte.SelectedItem = dgv_detalle_orden.Item("DOT_formato_soporte_1", dgv_detalle_orden.CurrentRow.Index).Value
            frm_Actualizar_Producto_Orden.cboFormato2_Soporte.SelectedItem = dgv_detalle_orden.Item("DOT_formato_soporte_2", dgv_detalle_orden.CurrentRow.Index).Value
            frm_Actualizar_Producto_Orden.cboFormato3_Soporte.SelectedItem = dgv_detalle_orden.Item("DOT_formato_soporte_3", dgv_detalle_orden.CurrentRow.Index).Value
        Else
            MsgBox("No hay productos por modificar")
        End If
        frm_Actualizar_Producto_Orden.Label1.Visible = False
        frm_Actualizar_Producto_Orden.Label45.Visible = False
        frm_Actualizar_Producto_Orden.txt_id_detalle_orden_trabajo1.Visible = False
        frm_Actualizar_Producto_Orden.txt_id_orden_trabajo.Visible = False
        frm_Actualizar_Producto_Orden.txtNumero_Orden_Trabajo.Enabled = False
        frm_Actualizar_Producto_Orden.Show()
    End Sub

    Private Sub dgvProcesos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProcesos.CellClick
        If Me.Text = "Modificar Orden / Producto / Proceso" Then
            btnModificarProceso.Enabled = True
            btnEliminarProceso.Enabled = False
        ElseIf Me.Text = "Eliminar Orden / Producto / Proceso" Then
            btnModificarProceso.Enabled = False
            btnEliminarProceso.Enabled = True
        End If
    End Sub

    Private Sub btnEliminarProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProceso.Click

        If dgvProcesos.SelectedRows.Count > 0 Then
            Dim eliminar = (From C In datacontext.PROCESO Where C.PROC_id_proceso = CInt(dgvProcesos.Item("PROC_id_proceso", dgvProcesos.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el Proceso seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar Proceso")
                Case MsgBoxResult.Yes
                    datacontext.PROCESO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El Proceso ha sido eliminado")
                    Me.Close()
            End Select
        Else
            MsgBox("Debe seleccionar un Proceso")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_Cliente.TextChanged
        Dim buscar As String
        armargrilla()
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
        dgvProcesos.DataSource = ""
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub dtp_Buscar_Fecha_Entrega_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Buscar_Fecha_Entrega.ValueChanged
        Dim buscar As String
        armargrilla()
        buscar = Me.dtp_Buscar_Fecha_Entrega.Text & "*"

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
        dgvProcesos.DataSource = ""
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub rbtNroOrden_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNroOrden.CheckedChanged
        If rbtNroOrden.Checked = True Then
            txt_Buscar_Cliente.Enabled = False
            dtp_Buscar_Fecha_Entrega.Enabled = False
            txt_Buscar_orden_trabajo.Enabled = True
            txt_Buscar_orden_trabajo.Focus()
            txt_Buscar_Cliente.Clear()
            dtp_Buscar_Fecha_Entrega.Text = Now
        End If
        cargargrilla()
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub rbtCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCliente.CheckedChanged
        If rbtCliente.Checked = True Then
            txt_Buscar_orden_trabajo.Enabled = False
            dtp_Buscar_Fecha_Entrega.Enabled = False
            txt_Buscar_Cliente.Enabled = True
            txt_Buscar_Cliente.Focus()
            txt_Buscar_orden_trabajo.Clear()
            dtp_Buscar_Fecha_Entrega.Text = Now
        End If
        cargargrilla()
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub rbtFechaEntrega_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFechaEntrega.CheckedChanged
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
                cargargrilla()
            End If
        End If
        cargargrilla()
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Public Sub btn_ODT_mostrar_pdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ODT_mostrar_listado_pdf.Click
        Try
            'intentar generar el documento
            Dim doc As New Document(PageSize.A4, 20, 20, 20, 20)

            'path que guarda el reporte en el escritorio de windows (desktop)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Orden_" _
                                     + dgvLista_Orden_Trabajo.Item("ORT_tipo_ot", dgv_detalle_orden.CurrentRow.Index).Value + "_" _
                                     + dgvLista_Orden_Trabajo.Item("ORT_numero_ot", dgvLista_Orden_Trabajo.CurrentRow.Index).Value _
                                     + ".pdf"
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
                dgv_detalle_orden_CellClick(0, Nothing)
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

    Sub pdf_informe_diario(ByVal document As Document, ByVal fila_actual As Integer)

        'Dim Pdf_odt As New Class_Generar_pdf

        ''PRODUCTO
        ''**********************************************
        'Pdf_odt.contadorcolumnasvisibles1 = 0
        'Pdf_odt.contadorcolumnasvisibles1 = Pdf_odt.Contar_Columnas_Visibles(dgv_detalle_orden)

        'Dim datatable As New PdfPTable(Pdf_odt.contadorcolumnasvisibles1)

        'datatable.DefaultCell.Padding = 3

        'Dim headerwidths As Single() = Pdf_odt.GetColumnsSize(dgv_detalle_orden, Pdf_odt.contadorcolumnasvisibles1)

        'datatable.SetWidths(headerwidths)

        'datatable.WidthPercentage = 100
        'datatable.DefaultCell.BorderWidth = 1

        'Pdf_odt.obtener_encabezados(dgv_detalle_orden, datatable)

        'datatable.HeaderRows = 1
        'datatable.DefaultCell.BorderWidth = 1

        'Pdf_odt.exportar_filas_una(dgv_detalle_orden, datatable, fila_actual)

        'document.Add(datatable)

        ''PROCESO
        ''***************************************************
        'Pdf_odt.contadorcolumnasvisibles1 = 0
        'Pdf_odt.contadorcolumnasvisibles1 = Pdf_odt.Contar_Columnas_Visibles(dgvProcesos)

        'Dim datatableProcesos As New PdfPTable(Pdf_odt.contadorcolumnasvisibles1)

        'datatableProcesos.DefaultCell.Padding = 3

        'Dim headerwidthsProcesos As Single() = Pdf_odt.GetColumnsSize(dgvProcesos, Pdf_odt.contadorcolumnasvisibles1)
        'datatableProcesos.SetWidths(headerwidthsProcesos)

        'datatable.WidthPercentage = 100
        'datatable.DefaultCell.BorderWidth = 1

        'Pdf_odt.obtener_encabezados(dgvProcesos, datatableProcesos)

        'datatableProcesos.HeaderRows = 1
        'datatableProcesos.DefaultCell.BorderWidth = 1

        'Pdf_odt.exportar_filas_una(dgvProcesos, datatableProcesos, 0)
        'document.Add(datatableProcesos)
    End Sub

    Sub pdf_informe_diario_sin_tablas(ByVal doc As Document, ByVal fila_actual As Integer)
        'Agregado de productos
        Dim prod_tit As New Paragraph("ITEM " & (fila_actual + 1))
        Dim prod_det As New Paragraph(dgv_detalle_orden.Item("DOT_cantidad_dot", dgv_detalle_orden.Rows(fila_actual).Index).Value _
                                      & "  " _
                                      & dgv_detalle_orden.Item("PIE_nombre_pie", dgv_detalle_orden.Rows(fila_actual).Index).Value _
                                      & "   " _
                                      & dgv_detalle_orden.Item("DOT_tamaño_dot", dgv_detalle_orden.Rows(fila_actual).Index).Value _
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
                                         & dgv_detalle_orden.Item(temp_cadena_formato, dgv_detalle_orden.Rows(fila_actual).Index).Value & " " _
                                         & dgv_detalle_orden.Item(temp_cadena_papel, dgv_detalle_orden.Rows(fila_actual).Index).Value & "   " _
                                         & dgv_detalle_orden.Item(temp_cadena_gram, dgv_detalle_orden.Rows(fila_actual).Index).Value & "    " _
                                         , New Font(fuente, 8))
            Else
                soporte = New Paragraph("")
            End If
            doc.Add(soporte)
        Next
        Dim pro_offset As New Paragraph("  Offset: " & dgvProcesos.Item("PROC_descrip_offset", dgvProcesos.Rows(0).Index).Value, New Font(fuente, 10, Font.Bold))
        Dim pro_digital As New Paragraph("  Digital: " & dgvProcesos.Item("PROC_descrip_digital", dgvProcesos.Rows(0).Index).Value, New Font(fuente, 10, Font.Bold))
        Dim pro_g_form As New Paragraph("  Gran formato: " & dgvProcesos.Item("PROC_descrip_gran_formato", dgvProcesos.Rows(0).Index).Value, New Font(fuente, 10, Font.Bold))
        Dim pro_term As New Paragraph("  Terminación: " & dgvProcesos.Item("PROC_descrip_terminacion", dgvProcesos.Rows(0).Index).Value, New Font(fuente, 10, Font.Bold))
        Dim pro_logi As New Paragraph("  Logística: " & dgvProcesos.Item("PROC_descrip_logistica", dgvProcesos.Rows(0).Index).Value, New Font(fuente, 10, Font.Bold))

        doc.Add(pro_offset)
        doc.Add(pro_digital)
        doc.Add(pro_g_form)
        doc.Add(pro_term)
        doc.Add(pro_logi)
    End Sub

End Class

