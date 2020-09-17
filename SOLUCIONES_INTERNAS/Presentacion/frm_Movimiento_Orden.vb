Imports System.Drawing.Printing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frm_Movimiento_Orden
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Dim contadorcolumnasvisibles As Integer
    Dim fuente As iTextSharp.text.pdf.BaseFont = FontFactory.GetFont(FontFactory.HELVETICA).BaseFont
    Dim linea As New Phrase("")


    Private Sub frm_Movimiento_Orden_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        armargrilla()
        CargaMovimientoOrden()
    End Sub

    'CARGA GRILLA ORDEN TRABAJO
    Public Sub CargaMovimientoOrden()
        Dim MovimientoOrden = (From mo In datavistas.Movimiento_Orden
                               Select
                               mo.ORT_id_orden_trabajo,
                               mo.ORT_numero_ot,
                               mo.TAR_id_tarea,
                               mo.TAR_detalle_tarea,
                               mo.TAR_tiempo_real,
                              mo.TAR_fecha,
                              mo.TAR_observaciones,
                              mo.COL_id_colaborador,
                              mo.COL_nombre_col,
                              mo.SEC_id_sector,
                              mo.SEC_nombre_sector
                              Where ORT_numero_ot <> "00"
                              Order By TAR_fecha Descending)
        dgvMovimiento_Orden.DataSource = MovimientoOrden
        dgvMovimiento_Orden.ClearSelection()
    End Sub

    'ARMA GRILLA ORDEN
    Private Sub armargrilla()
        dgvMovimiento_Orden.Enabled = True
        dgvMovimiento_Orden.AutoGenerateColumns = False
        dgvMovimiento_Orden.Columns.Clear()

        dgvMovimiento_Orden.Columns.Add("ORT_id_orden_trabajo", "id_orden_trabajo")
        dgvMovimiento_Orden.Columns.Add("ORT_numero_ot", "Número de Orden")
        dgvMovimiento_Orden.Columns.Add("TAR_id_tarea", "id_tarea")
        dgvMovimiento_Orden.Columns.Add("TAR_detalle_tarea", "Tarea")
        dgvMovimiento_Orden.Columns.Add("TAR_tiempo_real", "Tiempo Real")
        dgvMovimiento_Orden.Columns.Add("TAR_fecha", "Fecha Tarea")
        dgvMovimiento_Orden.Columns.Add("TAR_observaciones", "Observaciones")
        dgvMovimiento_Orden.Columns.Add("PIE_id_pieza", "id_pieza")
        dgvMovimiento_Orden.Columns.Add("PIE_nombre_pie", "Pieza")
        dgvMovimiento_Orden.Columns.Add("COL_id_colaborador", "id_colaborador")
        dgvMovimiento_Orden.Columns.Add("COL_nombre_col", "Colaborador")
        dgvMovimiento_Orden.Columns.Add("SEC_id_sector", "id_sector")
        dgvMovimiento_Orden.Columns.Add("SEC_nombre_sector", "Sector")

        dgvMovimiento_Orden.Columns(0).DataPropertyName = "ORT_id_orden_trabajo"
        dgvMovimiento_Orden.Columns(0).Visible = False
        dgvMovimiento_Orden.Columns(1).DataPropertyName = "ORT_numero_ot"
        dgvMovimiento_Orden.Columns(2).DataPropertyName = "TAR_id_tarea"
        dgvMovimiento_Orden.Columns(2).Visible = False
        dgvMovimiento_Orden.Columns(3).DataPropertyName = "TAR_detalle_tarea"
        dgvMovimiento_Orden.Columns(3).Width = 250
        dgvMovimiento_Orden.Columns(4).DataPropertyName = "TAR_tiempo_real"
        dgvMovimiento_Orden.Columns(5).DataPropertyName = "TAR_fecha"
        dgvMovimiento_Orden.Columns(6).DataPropertyName = "TAR_observaciones"
        dgvMovimiento_Orden.Columns(6).Width = 250
        dgvMovimiento_Orden.Columns(7).DataPropertyName = "PIE_id_pieza"
        dgvMovimiento_Orden.Columns(7).Visible = False
        dgvMovimiento_Orden.Columns(8).DataPropertyName = "PIE_nombre_pie"
        dgvMovimiento_Orden.Columns(8).Visible = False
        dgvMovimiento_Orden.Columns(9).DataPropertyName = "COL_id_colaborador"
        dgvMovimiento_Orden.Columns(9).Visible = False
        dgvMovimiento_Orden.Columns(10).DataPropertyName = "COL_nombre_col"
        ' dgvMovimiento_Orden.Columns(10).Visible = False
        dgvMovimiento_Orden.Columns(11).DataPropertyName = "SEC_id_sector"
        dgvMovimiento_Orden.Columns(11).Visible = False
        dgvMovimiento_Orden.Columns(12).DataPropertyName = "SEC_nombre_sector"
    End Sub

    Private Sub txt_Buscar_orden_trabajo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Buscar_orden_trabajo.TextChanged
        If txt_Buscar_orden_trabajo.TextLength = 0 Then
            CargaMovimientoOrden()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        buscar()
        'CALCULA LA SUMA DEL TIEMPO REAL DE CADA TAREA POR COLABORADOR
        Try
            'Declarar variable que acumulará la sumatoria de las celdas
            Dim Sumatoria As Integer = 0
            'Recorrer las filas del objeto de tipo DataGridView
            For Each row As DataGridViewRow In dgvMovimiento_Orden.Rows
                'Acumular valores
                Sumatoria += Convert.ToInt32(row.Cells("TAR_tiempo_real").Value)
            Next
            Label2.Text = Sumatoria
        Catch ex As Exception
        End Try
    End Sub

    Sub buscar()
        Dim buscar As String
        armargrilla()
        buscar = CStr(Me.txt_Buscar_orden_trabajo.Text)
        Dim MovimientoOrden = (From mo In datavistas.Movimiento_Orden
                               Select
                               mo.ORT_id_orden_trabajo,
                               mo.ORT_numero_ot,
                               mo.TAR_id_tarea,
                               mo.TAR_detalle_tarea,
                               mo.TAR_tiempo_real,
                              mo.TAR_fecha,
                              mo.COL_id_colaborador,
                              mo.COL_nombre_col,
                              mo.SEC_id_sector,
                              mo.SEC_nombre_sector
                             Where ORT_numero_ot = buscar And ORT_numero_ot <> "00"
                             Order By TAR_fecha Descending)
        dgvMovimiento_Orden.DataSource = MovimientoOrden
        dgvMovimiento_Orden.ClearSelection()
    End Sub



    Private Sub btnExportarPDF_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarPDF.Click
        Try
            If txt_Buscar_orden_trabajo.TextLength = 0 Then
                MsgBox("Seleccione una Orden del listado", MsgBoxStyle.Information, "Exportar Orden")
                Exit Sub
            End If
            'intentar generar el documento
            Dim doc As New Document(PageSize.A4.Rotate, 5, 5, 1, 5)
            'path que guarda el reporte en el escritorio de windows (desktop)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Movimiento de la Orden.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
            Me.Close()
        Catch ex As Exception
            'si el mensaje es fallido mostrar msgbox
            MessageBox.Show("No se puede generar el pdf, cierre el pdf anterior y vuleva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ExportarDatosPDF(ByVal document As Document)

        For c = 0 To dgvMovimiento_Orden.ColumnCount - 1
            If dgvMovimiento_Orden.Columns(c).Visible = True Then
                contadorcolumnasvisibles = contadorcolumnasvisibles + 1
            End If
        Next
        'se crea un objeto PDFTable con el numero de columnas  del datagridview
        Dim datatable As New PdfPTable(contadorcolumnasvisibles)

        'se asignan algunas propiedades para el diseño del PDF
        datatable.DefaultCell.Padding = 3

        Dim headerwidths As Single() = GetColumnsSize(dgvMovimiento_Orden)
        datatable.SetWidths(headerwidths)

        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        'datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim encabezado As New Paragraph("Movimiento de la Orden ", New Font(fuente, 16, Font.Bold))
        Dim fecha As New Phrase("Fecha de Impresión: " + Date.Now, New Font(fuente, 10, Font.Bold))
        ' doc.Add(encabezado)
        '  doc.Add(fecha)

        'se capturan los nombres de las columnas del datagridview
        For i As Integer = 0 To dgvMovimiento_Orden.ColumnCount - 1
            If dgvMovimiento_Orden.Columns(i).Visible = True Then
                datatable.AddCell(dgvMovimiento_Orden.Columns(i).HeaderText)
            End If
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        'se generan las columnas del datagridview
        For i As Integer = 0 To dgvMovimiento_Orden.RowCount - 1
            For j As Integer = 0 To dgvMovimiento_Orden.ColumnCount - 1
                If dgvMovimiento_Orden.Columns(j).Visible = True Then
                    Try
                        datatable.AddCell(dgvMovimiento_Orden(j, i).Value.ToString())
                    Catch ex As Exception
                        datatable.AddCell(" ")
                    End Try
                End If
            Next
            datatable.CompleteRow()
        Next

        Dim TotalTareas As New Phrase("Tiempo Consumido: " + Label2.Text, New Font(fuente, 10, Font.Bold))
        document.Add(encabezado)
        document.Add(fecha)
        document.Add(linea)
        document.Add(datatable)
        document.Add(TotalTareas)
    End Sub

    Public Function GetColumnsSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de las columnas del datagridview
        Dim indice_array As Integer = 0
        Dim values As Single() = New Single(contadorcolumnasvisibles - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            If dgvMovimiento_Orden.Columns(i).Visible = True Then
                values(indice_array) = CSng(dg.Columns(i).Width)
                indice_array = indice_array + 1
            End If
        Next
        Return values
    End Function

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class