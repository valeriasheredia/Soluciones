Imports System.Drawing.Printing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frm_Productos

    Dim datacontext As New DataS_Interno
    Dim contadorcolumnasvisibles As Integer

    Private Sub btn_prod_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prod_guardar.Click
        Try
            'consulta si el codigo de prod ya existe
            Dim buscaproducto = (From P In datacontext.PRODUCTO
                                 Select P.PROD_codigo, P.PROD_descripcion, P.PROD_id, P.PROD_stock, P.PROD_stock_minimo, P.PROD_deposito
                                 Where PROD_codigo = tb_prod_codigo.Text).Any
            If buscaproducto = True Then
                MsgBox("El código de producto ya existe")
                Exit Sub
            End If

            'VALIDA QUE EL CODIGO NO ESTE VACIO
            If tb_prod_codigo.TextLength = 0 Then
                MsgBox("Complete el campo Código del producto")
                tb_prod_codigo.Focus()
                Exit Sub
            End If

            'VALIDA QUE LA DESCRIPCION NO ESTE VACIA
            If tb_prod_descripcion.TextLength = 0 Then
                MsgBox("Complete el campo Descripción del producto")
                tb_prod_descripcion.Focus()
                Exit Sub
            End If

            'VALIDA QUE EL STOCK MINIMO NO ESTE VACIO
            If tb_prod_stock_minimo.TextLength = 0 Then
                MsgBox("Complete el campo Stock Mínimo del producto")
                tb_prod_stock_minimo.Focus()
                Exit Sub
            End If

            'VALIDA QUE LA CANTIDAD EN STOCK NO ESTE VACIO
            If tb_prod_stock.TextLength = 0 Then
                MsgBox("Complete el campo Cantidad en Stock del producto")
                tb_prod_stock.Focus()
                Exit Sub
            End If

            If cboDeposito.Text = "Seleccionar" Then
                MsgBox("Seleccione un depósito para el producto")
                cboDeposito.Focus()
                Exit Sub
            End If
         
            'instancia y guarda en nuevo producto
            Dim prod = New PRODUCTO
            prod.PROD_codigo = StrConv(tb_prod_codigo.Text, VbStrConv.ProperCase)
            prod.PROD_descripcion = StrConv(tb_prod_descripcion.Text, VbStrConv.ProperCase)
            prod.PROD_stock = tb_prod_stock.Text
            prod.PROD_stock_minimo = tb_prod_stock_minimo.Text
            prod.PROD_deposito = cboDeposito.Text

            datacontext.PRODUCTO.InsertOnSubmit(prod)
            datacontext.SubmitChanges()

            'consulta si quiere cargar otro cliente
            Select Case MsgBox("El producto fue ingresado, cargar otro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Nuevo producto")
                Case MsgBoxResult.No
                    Me.Close()
                Case MsgBoxResult.Yes
                    limpiarcampos()
            End Select
            cargargrilla()
        Catch ex As Exception
            MsgBox("El Producto no fue cargado")
            limpiarcampos()

        End Try
    End Sub

    Sub limpiarcampos()
        'limpia los textbox
        tb_prod_id.Clear()
        tb_prod_codigo.Clear()
        tb_prod_descripcion.Clear()
        tb_prod_stock.Clear()
        tb_prod_stock_minimo.Clear()
        tb_prod_id.Visible = False
        Label1.Visible = False
        cboDeposito.Text = "Seleccionar"
    End Sub

    'arma el datagrid
    Sub armargrilla()
        dgvLista_Productos.Enabled = True
        dgvLista_Productos.AutoGenerateColumns = False
        dgvLista_Productos.Columns.Clear()

        dgvLista_Productos.Columns.Add("PROD_id", "ID_producto")
        dgvLista_Productos.Columns.Add("PROD_codigo", "Código")
        dgvLista_Productos.Columns.Add("PROD_descripcion", "Descripción")
        dgvLista_Productos.Columns.Add("PROD_stock", "Stock")
        dgvLista_Productos.Columns.Add("PROD_stock_minimo", "Mínimo")
        dgvLista_Productos.Columns.Add("PROD_deposito", "Depósito")

        dgvLista_Productos.Columns(0).DataPropertyName = "PROD_id"
        dgvLista_Productos.Columns(0).Visible = False
        dgvLista_Productos.Columns(1).DataPropertyName = "PROD_codigo"
        dgvLista_Productos.Columns(2).DataPropertyName = "PROD_descripcion"
        dgvLista_Productos.Columns(2).Width = 250
        dgvLista_Productos.Columns(3).DataPropertyName = "PROD_stock"
        dgvLista_Productos.Columns(4).DataPropertyName = "PROD_stock_minimo"
        dgvLista_Productos.Columns(5).DataPropertyName = "PROD_deposito"
    End Sub

    Sub cargargrilla()
        ' carga el datagrid
        Dim consultaprod = From p In datacontext.PRODUCTO
                           Select p.PROD_id, p.PROD_codigo, p.PROD_descripcion, p.PROD_stock, p.PROD_stock_minimo, p.PROD_deposito
                           Order By PROD_descripcion Ascending
        dgvLista_Productos.DataSource = consultaprod
        Label9.Text = dgvLista_Productos.Rows.Count
        ColorStock()
    End Sub

    Private Sub frm_Productos_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '  Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frm_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        armargrilla()

        'CARGA SECTOR DEL USUARIO REGISTRADO
        Dim sector = (From c In datacontext.USUARIO
                       Join col In datacontext.COLABORADOR
                       On c.COL_id_colaborador Equals col.COL_id_colaborador
                       Join sec In datacontext.SECTOR
                       On col.SEC_id_sector Equals sec.SEC_id_sector
                       Select sec.SEC_id_sector, sec.SEC_nombre_sector, c.USU_usuario
                       Where USU_usuario = frm_Principal.LBL_MENU_USU.Text).ToList()(0)

        'SECTOR = LIBRERIA
        If sector.SEC_nombre_sector = "Librería" Then
            cbo_busqueda_deposito.SelectedIndex = 1
            rbtDeposito.Enabled = False
        Else
            'SECTOR <> LIBRERIA
            cbo_busqueda_deposito.SelectedIndex = 0
            rbtDeposito.Enabled = True
        End If

        dgvLista_Productos.ClearSelection()
        Label9.Text = dgvLista_Productos.Rows.Count
        rbtProducto.Checked = True
        rbtCodigo.Enabled = True

        ' dgvLista_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub dgvLista_Productos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvLista_Productos.Click
        If dgvLista_Productos.SelectedRows.Count > 0 Then
            tb_prod_id.Text = dgvLista_Productos.Item("PROD_id", dgvLista_Productos.SelectedRows(0).Index).Value
            tb_prod_codigo.Text = dgvLista_Productos.Item("PROD_codigo", dgvLista_Productos.SelectedRows(0).Index).Value
            tb_prod_descripcion.Text = dgvLista_Productos.Item("PROD_descripcion", dgvLista_Productos.SelectedRows(0).Index).Value
            tb_prod_stock.Text = dgvLista_Productos.Item("PROD_stock", dgvLista_Productos.SelectedRows(0).Index).Value
            tb_prod_stock_minimo.Text = dgvLista_Productos.Item("PROD_stock_minimo", dgvLista_Productos.SelectedRows(0).Index).Value
            cboDeposito.Text = dgvLista_Productos.Item("PROD_deposito", dgvLista_Productos.SelectedRows(0).Index).Value
        Else
            MsgBox("Debe seleccionar un producto")
        End If
    End Sub

    Private Sub btn_prod_actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prod_actualizar.Click
        'VALIDA QUE EL CODIGO NO ESTE VACIO
        If tb_prod_codigo.TextLength = 0 Then
            MsgBox("Complete el campo Código del producto")
            tb_prod_codigo.Focus()
            Exit Sub
        End If

        'VALIDA QUE LA DESCRIPCION NO ESTE VACIA
        If tb_prod_descripcion.TextLength = 0 Then
            MsgBox("Complete el campo Descripción del producto")
            tb_prod_descripcion.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL STOCK MINIMO NO ESTE VACIO
        If tb_prod_stock_minimo.TextLength = 0 Then
            MsgBox("Complete el campo Stock Mínimo del producto")
            tb_prod_stock_minimo.Focus()
            Exit Sub
        End If

        'VALIDA QUE LA CANTIDAD EN STOCK NO ESTE VACIO
        If tb_prod_stock.TextLength = 0 Then
            MsgBox("Complete el campo Cantidad en Stock del producto")
            tb_prod_stock.Focus()
            Exit Sub
        End If

        If cboDeposito.Text = "Seleccionar" Then
            MsgBox("Seleccione un depósito para el producto")
            cboDeposito.Focus()
            Exit Sub
        End If
        Try
            Dim ActualizarProducto = (From p In datacontext.PRODUCTO Where p.PROD_id = tb_prod_id.Text).ToList()(0)
            ActualizarProducto.PROD_codigo = StrConv(tb_prod_codigo.Text, VbStrConv.ProperCase)
            ActualizarProducto.PROD_descripcion = StrConv(tb_prod_descripcion.Text, VbStrConv.ProperCase)
            ActualizarProducto.PROD_stock = tb_prod_stock.Text
            ActualizarProducto.PROD_stock_minimo = tb_prod_stock_minimo.Text
            ActualizarProducto.PROD_deposito = cboDeposito.Text

            datacontext.SubmitChanges()
            MsgBox("Los datos han sido actualizados")
            cargargrilla()
            Me.Close()

        Catch ex As Exception
            MsgBox("Los datos no se modificaron", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar producto")
            limpiarcampos()

        End Try
    End Sub

    Private Sub frm_Productos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Public Sub ExportarDatosPDF(ByVal document As Document)

        'Cuenta la cantidad de columnas visibles del dgv para armar la tabla
        For c = 0 To dgvLista_Productos.ColumnCount - 1
            If dgvLista_Productos.Columns(c).Visible = True Then
                contadorcolumnasvisibles = contadorcolumnasvisibles + 1
            End If
        Next

        'se crea un objeto PDFTable con el numero de columnas  del datagridview
        Dim datatable As New PdfPTable(contadorcolumnasvisibles)

        'se asignan algunas propiedades para el diseño del PDF
        datatable.DefaultCell.Padding = 3

        Dim headerwidths As Single() = GetColumnsSize(dgvLista_Productos)
        datatable.SetWidths(headerwidths)

        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        'datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        'se crea el encabezado en el PDF
        Dim encabezado As New Paragraph("Consulta de Productos", New Font(Font.Name = "Arial", 20, Font.Bold))

        'se crea el texto abajo del encabezado
        Dim texto As New Phrase("Los productos cargados hasta la fecha " + Now.Date() + " son los siguientes:", New Font(Font.Name = "Arial", 14, Font.Bold))

        'se capturan los nombres de las columnas del datagridview
        For i As Integer = 0 To dgvLista_Productos.ColumnCount - 1
            If dgvLista_Productos.Columns(i).Visible = True Then
                datatable.AddCell(dgvLista_Productos.Columns(i).HeaderText)
            End If
        Next

        'se generan las columnas del datagridview

        For i As Integer = 0 To dgvLista_Productos.RowCount - 1
            For j As Integer = 0 To dgvLista_Productos.ColumnCount - 1
                If dgvLista_Productos.Columns(j).Visible = True Then
                    Try
                        datatable.AddCell(dgvLista_Productos(j, i).Value.ToString())
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

    Public Function GetColumnsSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de las columnas del datagridview

        Dim indice_array As Integer = 0
        Dim values As Single() = New Single(contadorcolumnasvisibles - 1) {}

        For i As Integer = 0 To dg.ColumnCount - 1
            If dgvLista_Productos.Columns(i).Visible = True Then
                values(indice_array) = CSng(dg.Columns(i).Width)
                indice_array = indice_array + 1
            End If
        Next
        Return values
    End Function

    Private Sub rbtProducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtProducto.CheckedChanged
        If rbtProducto.Checked = True Then
            tb_prod_busqueda.Enabled = True
            tb_prod_busqueda.Focus()

            rbtCodigo.Checked = False
            tb_cod_busqueda.Enabled = False
            tb_cod_busqueda.Clear()

            rbtDeposito.Checked = False
            cbo_busqueda_deposito.Enabled = False
        End If
    End Sub

    Private Sub rbtCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCodigo.CheckedChanged
        If rbtCodigo.Checked = True Then
            tb_prod_busqueda.Enabled = False
            tb_prod_busqueda.Clear()
            tb_cod_busqueda.Enabled = True
            tb_cod_busqueda.Clear()
            rbtDeposito.Checked = False
            cbo_busqueda_deposito.Enabled = False
        End If
    End Sub

    Private Sub tb_prod_busqueda_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_prod_busqueda.TextChanged

        Dim buscarprod As String
        armargrilla()
        buscarprod = "*" & Me.tb_prod_busqueda.Text & "*"

        If cbo_busqueda_deposito.Text = "Todos" Then
            Dim consultaprod = From p In datacontext.PRODUCTO
                              Select p.PROD_id,
                              p.PROD_codigo,
                              p.PROD_descripcion,
                              p.PROD_stock,
                              p.PROD_stock_minimo,
                              p.PROD_deposito
                              Where PROD_descripcion Like buscarprod.ToString
            dgvLista_Productos.DataSource = consultaprod
        Else
            Dim consultaprod = From p In datacontext.PRODUCTO
                               Select p.PROD_id,
                               p.PROD_codigo,
                               p.PROD_descripcion,
                               p.PROD_stock,
                               p.PROD_stock_minimo,
                               p.PROD_deposito
                               Where PROD_descripcion Like buscarprod.ToString And PROD_deposito = cbo_busqueda_deposito.Text
            dgvLista_Productos.DataSource = consultaprod
        End If
        dgvLista_Productos.ClearSelection()
        ColorStock()
    End Sub

    Private Sub tb_cod_busqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_cod_busqueda.TextChanged
        Dim buscarcod As String
        armargrilla()
        buscarcod = "*" & Me.tb_cod_busqueda.Text & "*"
        If cbo_busqueda_deposito.Text = "Todos" Then
            Dim consultacod = From p In datacontext.PRODUCTO
                              Select p.PROD_id, p.PROD_codigo, p.PROD_descripcion, p.PROD_stock, p.PROD_stock_minimo, p.PROD_deposito
                              Where PROD_codigo Like buscarcod.ToString
            dgvLista_Productos.DataSource = consultacod
        Else

            Dim consultacod = From p In datacontext.PRODUCTO
                               Select p.PROD_id, p.PROD_codigo, p.PROD_descripcion, p.PROD_stock, p.PROD_stock_minimo, p.PROD_deposito
                               Where PROD_codigo Like buscarcod.ToString And PROD_deposito = cbo_busqueda_deposito.Text
            dgvLista_Productos.DataSource = consultacod
        End If

            dgvLista_Productos.ClearSelection()
            ColorStock()
    End Sub

    Private Sub cbo_busqueda_deposito_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_busqueda_deposito.SelectedIndexChanged
        If cbo_busqueda_deposito.Text = "Todos" Then
            Dim consultaprod = From p In datacontext.PRODUCTO
                         Select p.PROD_id, p.PROD_codigo, p.PROD_descripcion, p.PROD_stock, p.PROD_stock_minimo, p.PROD_deposito
                         Order By PROD_descripcion Ascending
            dgvLista_Productos.DataSource = consultaprod
            
        Else
            Dim consultaprod = From p In datacontext.PRODUCTO
                                  Select p.PROD_id, p.PROD_codigo, p.PROD_descripcion, p.PROD_stock, p.PROD_stock_minimo, p.PROD_deposito
                                  Where PROD_deposito = cbo_busqueda_deposito.Text
                                  Order By PROD_descripcion Ascending
            dgvLista_Productos.DataSource = consultaprod
            
        End If
        Label9.Text = dgvLista_Productos.Rows.Count
        ColorStock()
    End Sub

    Private Sub dgvLista_Productos_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Productos.CellClick
        Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExportarPDF_Click_1(sender As System.Object, e As System.EventArgs) Handles btnExportarPDF.Click
        Try
            'intentar generar el documento
            Dim doc As New Document(PageSize.A4, 5, 5, 1, 5)

            'path que guarda el reporte en el escritorio de windows (desktop)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Consulta de Productos.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
            Me.Close()
        Catch ex As Exception
            'si el mensaje es fallido mostrar msgbox
            MessageBox.Show("No se puede generar. Cierre el pdf anterior y vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_prod_eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prod_eliminar.Click

        If dgvLista_Productos.SelectedRows.Count > 0 Then
            Dim eliminar = (From p In datacontext.PRODUCTO Where p.PROD_id = CInt(dgvLista_Productos.Item("PROD_id", dgvLista_Productos.SelectedRows(0).Index).Value)).ToList()(0)
            Select Case MsgBox("Se eliminará el producto seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar producto")
                Case MsgBoxResult.Yes
                    datacontext.PRODUCTO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El producto fue eliminado")
                    cargargrilla()
                    Label9.Text = dgvLista_Productos.Rows.Count
                    Me.Close()
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        End If
    End Sub

    Private Sub btn_prod_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_prod_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub ColorStock()
        For Each row As DataGridViewRow In dgvLista_Productos.Rows
            If row.Cells(3).Value <= row.Cells(4).Value Then
                row.DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub btn_Exportar_Excel_Click(sender As System.Object, e As System.EventArgs) Handles btn_Exportar_Excel.Click
        llenarExcel(dgvLista_Productos)
    End Sub

    Function llenarExcel(ByVal ElGrid As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            'Aqui recorremos todas las filas, y por cada fila todas las columnas
            'y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Item(Col, Fila).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna
            'se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'Aplicación visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function

    Private Sub rbtDeposito_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtDeposito.CheckedChanged
        If rbtDeposito.Checked = True Then
            tb_prod_busqueda.Enabled = False
            rbtCodigo.Checked = False
            tb_cod_busqueda.Enabled = False
            tb_cod_busqueda.Clear()
            tb_prod_busqueda.Clear()
            cbo_busqueda_deposito.Enabled = True
            'cbo_busqueda_deposito.SelectedIndex = 0
        End If
    End Sub

  
End Class