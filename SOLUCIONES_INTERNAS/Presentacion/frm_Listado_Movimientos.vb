Imports System.Drawing.Printing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frm_Listado_Movimientos

    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas

    Dim contadorcolumnasvisibles As Integer

    Public Sub CargarGrillaMovimiento()
        Dim buscar As String

        buscar = "*" & Me.txt_Buscar_Producto.Text & "*"
        Dim carga = (From p In datavistas.Vista_Lista_Movimientos
                       Select p.PROD_id,
                                   p.PROD_codigo,
                                   p.PROD_descripcion,
                                   p.PROD_stock,
                                   p.PROD_stock_minimo,
                                   p.PROD_MOV_id,
                                   p.PROD_MOV_fecha,
                                   p.PROD_MOV_tipo,
                                   p.PROD_MOV_cantidad,
                                   p.ORT_id_orden_trabajo
                 Where PROD_descripcion Like buscar.ToString And PROD_MOV_fecha.Value.Month = cboMes.SelectedIndex + 1
                 Order By PROD_MOV_fecha Ascending)

        dgv_movimientos.DataSource = carga
    End Sub

    Private Sub frm_Listado_Movimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ArmaGrillaProductoMovimiento()

        Dim carga = (From p In datavistas.Vista_Lista_Movimientos
                      Select p.PROD_id,
                                  p.PROD_codigo,
                                  p.PROD_descripcion,
                                  p.PROD_stock,
                                  p.PROD_stock_minimo,
                                  p.PROD_MOV_id,
                                  p.PROD_MOV_fecha,
                                  p.PROD_MOV_tipo,
                                  p.PROD_MOV_cantidad,
                                  p.ORT_id_orden_trabajo)
        dgv_movimientos.DataSource = carga
        dgv_movimientos.ClearSelection()
    End Sub

    Private Sub ArmaGrillaProductoMovimiento()
        dgv_movimientos.Enabled = True
        dgv_movimientos.AutoGenerateColumns = False
        dgv_movimientos.Columns.Clear()

        dgv_movimientos.Columns.Add("PROD_id", "id_producto")
        dgv_movimientos.Columns.Add("PROD_codigo", "Código")
        dgv_movimientos.Columns.Add("PROD_descripcion", "Descripción")
        dgv_movimientos.Columns.Add("PROD_stock_minimo", "Mínimo")
        dgv_movimientos.Columns.Add("PROD_stock", "Stock")

        dgv_movimientos.Columns.Add("PROD_MOV_id", "id_prod_movimiento")

        dgv_movimientos.Columns.Add("PROD_MOV_tipo", "Tipo")
        dgv_movimientos.Columns.Add("PROD_MOV_cantidad", "Cantidad")
        dgv_movimientos.Columns.Add("ORT_id_orden_trabajo", "ODT")
        dgv_movimientos.Columns.Add("PROD_MOV_fecha", "Fecha")

        dgv_movimientos.Columns(0).DataPropertyName = "PROD_id"
        dgv_movimientos.Columns(0).Visible = False
        dgv_movimientos.Columns(1).DataPropertyName = "PROD_codigo"
        dgv_movimientos.Columns(1).Width = 50
        dgv_movimientos.Columns(1).Visible = True
        dgv_movimientos.Columns(2).DataPropertyName = "PROD_descripcion"
        dgv_movimientos.Columns(2).Width = 150
        dgv_movimientos.Columns(3).DataPropertyName = "PROD_stock_minimo"
        dgv_movimientos.Columns(3).Width = 50
        dgv_movimientos.Columns(3).Visible = False
        dgv_movimientos.Columns(4).DataPropertyName = "PROD_stock"
        dgv_movimientos.Columns(4).Width = 50
        dgv_movimientos.Columns(4).Visible = False
        dgv_movimientos.Columns(5).DataPropertyName = "PROD_MOV_id"
        dgv_movimientos.Columns(5).Visible = False
        dgv_movimientos.Columns(6).DataPropertyName = "PROD_MOV_tipo"
        dgv_movimientos.Columns(6).Width = 50
        dgv_movimientos.Columns(7).DataPropertyName = "PROD_MOV_cantidad"
        dgv_movimientos.Columns(8).DataPropertyName = "ORT_id_orden_trabajo"
        dgv_movimientos.Columns(9).DataPropertyName = "PROD_MOV_fecha"
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frm_Listado_Movimientos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        CargarGrillaMovimiento()
    End Sub

    Private Sub txt_Buscar_Producto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_Producto.TextChanged
        CargarGrillaMovimiento()
    End Sub

    Public Function GetColumnsSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de las columnas del datagridview

        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            If dgv_movimientos.Columns(i).Visible = True Then
                values(i) = CSng(dg.Columns(i).Width)
            End If
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)

        For c = 0 To dgv_movimientos.ColumnCount - 1
            If dgv_movimientos.Columns(c).Visible = True Then
                contadorcolumnasvisibles = contadorcolumnasvisibles + 1
            End If
        Next
        'se crea un objeto PDFTable con el numero de columnas  del datagridview
        Dim datatable As New PdfPTable(contadorcolumnasvisibles)

        'se asignan algunas propiedades para el diseño del PDF
        datatable.DefaultCell.Padding = 3

        'Dim headerwidths As Single() = GetColumnsSize(dgv_movimientos)
        'datatable.SetWidths(headerwidths)

        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        'se crea el encabezado en el PDF
        Dim encabezado As New Paragraph("Reporte de Movimientos", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        'se crea el texto abajo del encabezado
        Dim texto As New Phrase("Los movimientos de productos realizados hasta la fecha " + Now.Date() + " son los siguientes:", New Font(Font.Name = "Tahoma", 14, Font.Bold))

        'se capturan los nombres de las columnas del datagridview
        For i As Integer = 0 To dgv_movimientos.ColumnCount - 1
            If dgv_movimientos.Columns(i).Visible = True Then
                datatable.AddCell(dgv_movimientos.Columns(i).HeaderText)
            End If
        Next

        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        'se generan las columnas del datagridview

        For i As Integer = 0 To dgv_movimientos.RowCount - 1

            For j As Integer = 0 To dgv_movimientos.ColumnCount - 1
                If dgv_movimientos.Columns(j).Visible = True Then
                    Try
                        datatable.AddCell(dgv_movimientos(j, i).Value.ToString())
                    Catch ex As Exception
                        datatable.AddCell(" ")
                    End Try
                End If
            Next
            datatable.CompleteRow()
        Next
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportaraPDF.Click
        Try
            'intentar generar el documento
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'path que guarda el reporte en el escritorio de windows (desktop)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Movimiento de Productos.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
            Me.Close()
        Catch ex As Exception
            'si el mensaje es fallido mostrar msgbox
            MessageBox.Show("No se puede generar el pdf.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class