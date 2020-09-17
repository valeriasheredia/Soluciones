Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frm_Ticket
    Dim datacontext As New DataS_Interno
    Dim fuente As iTextSharp.text.pdf.BaseFont = FontFactory.GetFont(FontFactory.HELVETICA).BaseFont
    Dim linea As New Phrase("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")
    Dim interlineado As New Phrase(" ")

    Private Sub frm_Ticket_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'DESHABILITA Y OCULTA CAMPOS
        txt_id_usuario.Visible = False
        txt_nombre_usuario.Enabled = False
        txt_id_ticket.Visible = True
        txt_id_ticket.Enabled = False
        Label7.Visible = False
        dgv_lista_ticket.ClearSelection()
        '
        If frm_Principal.LBL_MENU_PERFIL.Text = "COLABORADOR" Or frm_Principal.LBL_MENU_PERFIL.Text = "SUPERVISOR" Then

            Dim CargaUsuarioColSup = (From sec In datacontext.SECTOR
                          Join col In datacontext.COLABORADOR
                          On col.SEC_id_sector Equals sec.SEC_id_sector
                          Join usu In datacontext.USUARIO
                          On usu.COL_id_colaborador Equals col.COL_id_colaborador
                          Select usu.USU_usuario, usu.USU_id_usuario
                          Where USU_usuario = frm_Principal.LBL_MENU_USU.Text).ToList()(0)

            txt_nombre_usuario.Text = CargaUsuarioColSup.USU_usuario
            txt_id_usuario.Text = CargaUsuarioColSup.USU_id_usuario

            cbo_estado.SelectedIndex = 0
            ' cbo_prioridad.SelectedIndex = 0
        End If
        cbo_busqueda_estado.SelectedIndex = 0
        armargrillaticket()
        cargargrillaticket()
    End Sub

    Private Sub armargrillaticket()

        dgv_lista_ticket.Enabled = True
        dgv_lista_ticket.AutoGenerateColumns = False
        dgv_lista_ticket.Columns.Clear()

        dgv_lista_ticket.Columns.Add("TIC_id_ticket", "id_ticket")
        dgv_lista_ticket.Columns.Add("TIC_id_usuario", "id_usuario")
        dgv_lista_ticket.Columns.Add("USU_usuario", "Usuario")
        dgv_lista_ticket.Columns.Add("TIC_fecha_pedido", "Fecha de Pedido")
        dgv_lista_ticket.Columns.Add("TIC_recurso", "Recurso")
        dgv_lista_ticket.Columns.Add("TIC_herramienta", "Herramienta")
        dgv_lista_ticket.Columns.Add("TIC_plazo_resolucion", "Plazo de Resolución")
        dgv_lista_ticket.Columns.Add("TIC_descripcion", "Descripción")
        dgv_lista_ticket.Columns.Add("TIC_prioridad", "Prioridad")
        dgv_lista_ticket.Columns.Add("TIC_estado", "Estado")
        dgv_lista_ticket.Columns.Add("TIC_fecha_real_cierre", "Fecha Real de Cierre")
        dgv_lista_ticket.Columns.Add("TIC_fecha_estimado_cierre", "Fecha Estimada de Cierre")
        dgv_lista_ticket.Columns.Add("TIC_sector", "Sector")
        dgv_lista_ticket.Columns.Add("TIC_comentarios", "Comentarios")

        dgv_lista_ticket.Columns(0).DataPropertyName = "TIC_id_ticket"
        dgv_lista_ticket.Columns(0).Visible = False
        dgv_lista_ticket.Columns(1).DataPropertyName = "TIC_id_usuario"
        dgv_lista_ticket.Columns(1).Visible = False
        dgv_lista_ticket.Columns(2).DataPropertyName = "USU_usuario"
        dgv_lista_ticket.Columns(2).Width = 80
        dgv_lista_ticket.Columns(3).DataPropertyName = "TIC_fecha_pedido"
        dgv_lista_ticket.Columns(3).Width = 80
        dgv_lista_ticket.Columns(4).DataPropertyName = "TIC_recurso"
        dgv_lista_ticket.Columns(4).Width = 120
        dgv_lista_ticket.Columns(5).DataPropertyName = "TIC_herramienta"
        dgv_lista_ticket.Columns(5).Width = 120
        dgv_lista_ticket.Columns(6).DataPropertyName = "TIC_plazo_resolucion"
        dgv_lista_ticket.Columns(6).Width = 60
        dgv_lista_ticket.Columns(7).DataPropertyName = "TIC_descripcion"
        dgv_lista_ticket.Columns(7).Width = 300
        dgv_lista_ticket.Columns(8).DataPropertyName = "TIC_prioridad"
        dgv_lista_ticket.Columns(9).DataPropertyName = "TIC_estado"
        dgv_lista_ticket.Columns(9).Visible = False
        dgv_lista_ticket.Columns(10).DataPropertyName = "TIC_fecha_real_cierre"
        dgv_lista_ticket.Columns(11).DataPropertyName = "TIC_fecha_estimado_cierre"
        dgv_lista_ticket.Columns(12).DataPropertyName = "TIC_sector"
        dgv_lista_ticket.Columns(13).DataPropertyName = "TIC_comentarios"
    End Sub

    Public Sub cargargrillaticket()
        If frm_Principal.LBL_MENU_PERFIL.Text = "ADMINISTRADOR" Or GroupReceptor.Enabled = True Then
            If cbo_busqueda_estado.Text <> "Todos" Then
                Dim consulta = (From ti In datacontext.TICKET
                                 Join us In datacontext.USUARIO
                                      On ti.TIC_id_usuario Equals us.USU_id_usuario
                                             Select ti.TIC_id_ticket,
                                             ti.TIC_id_usuario,
                                             us.USU_usuario,
                                             ti.TIC_fecha_pedido,
                                             ti.TIC_recurso,
                                             ti.TIC_herramienta,
                                             ti.TIC_plazo_resolucion,
                                             ti.TIC_descripcion,
                                             ti.TIC_prioridad,
                                             ti.TIC_estado,
                                             ti.TIC_fecha_real_cierre,
                                             ti.TIC_fecha_estimado_cierre,
                                             ti.TIC_sector,
                                             ti.TIC_comentarios
                                             Where TIC_estado = cbo_busqueda_estado.Text
                                            Order By TIC_fecha_pedido Descending)
                dgv_lista_ticket.DataSource = consulta
            Else
                Dim consulta = (From ti In datacontext.TICKET
                                               Join us In datacontext.USUARIO
                                                    On ti.TIC_id_usuario Equals us.USU_id_usuario
                                                           Select ti.TIC_id_ticket,
                                                           ti.TIC_id_usuario,
                                                           us.USU_usuario,
                                                           ti.TIC_fecha_pedido,
                                                           ti.TIC_recurso,
                                                           ti.TIC_herramienta,
                                                           ti.TIC_plazo_resolucion,
                                                           ti.TIC_descripcion,
                                                           ti.TIC_prioridad,
                                                           ti.TIC_estado,
                                                           ti.TIC_fecha_real_cierre,
                                                           ti.TIC_fecha_estimado_cierre,
                                                           ti.TIC_sector,
                                                           ti.TIC_comentarios
                                                          Order By TIC_fecha_pedido Descending)
                dgv_lista_ticket.DataSource = consulta
            End If
        Else
            If cbo_busqueda_estado.Text <> "Todos" Then
                Dim consultaTicket = (From ti In datacontext.TICKET
                                      Join us In datacontext.USUARIO
                                      On ti.TIC_id_usuario Equals us.USU_id_usuario
                                      Select ti.TIC_id_ticket,
                                      ti.TIC_id_usuario,
                                      us.USU_usuario,
                                      ti.TIC_fecha_pedido,
                                      ti.TIC_recurso,
                                      ti.TIC_herramienta,
                                      ti.TIC_plazo_resolucion,
                                      ti.TIC_descripcion,
                                      ti.TIC_prioridad,
                                      ti.TIC_estado,
                                      ti.TIC_fecha_real_cierre,
                                      ti.TIC_fecha_estimado_cierre,
                                      ti.TIC_sector,
                                      ti.TIC_comentarios
                            Where (USU_usuario = txt_nombre_usuario.Text And TIC_estado = cbo_busqueda_estado.Text)
                                      Order By TIC_fecha_pedido Descending)
                dgv_lista_ticket.DataSource = consultaTicket
                dgv_lista_ticket.Columns("USU_usuario").Visible = False
            Else
                Dim consultaTicket = (From ti In datacontext.TICKET
                                     Join us In datacontext.USUARIO
                                     On ti.TIC_id_usuario Equals us.USU_id_usuario
                                     Select ti.TIC_id_ticket,
                                     ti.TIC_id_usuario,
                                     us.USU_usuario,
                                     ti.TIC_fecha_pedido,
                                     ti.TIC_recurso,
                                     ti.TIC_herramienta,
                                     ti.TIC_plazo_resolucion,
                                     ti.TIC_descripcion,
                                     ti.TIC_prioridad,
                                     ti.TIC_estado,
                                     ti.TIC_fecha_real_cierre,
                                     ti.TIC_fecha_estimado_cierre,
                                     ti.TIC_sector,
                                     ti.TIC_comentarios
                           Where (USU_usuario = txt_nombre_usuario.Text)
                                     Order By TIC_fecha_pedido Descending)
                dgv_lista_ticket.DataSource = consultaTicket
                dgv_lista_ticket.Columns("USU_usuario").Visible = False
            End If
        End If
    End Sub

    Private Sub txt_plazo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dgv_lista_ticket_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_lista_ticket.CellDoubleClick

        If Me.dgv_lista_ticket.SelectedRows.Count > 0 Then
            Me.txt_id_ticket.Text = Me.dgv_lista_ticket.Item("TIC_id_ticket", dgv_lista_ticket.SelectedRows(0).Index).Value
            Me.dtp_fecha_pedido.Text = Me.dgv_lista_ticket.Item("TIC_fecha_pedido", dgv_lista_ticket.SelectedRows(0).Index).Value
            Me.txt_id_usuario.Text = Me.dgv_lista_ticket.Item("TIC_id_usuario", dgv_lista_ticket.SelectedRows(0).Index).Value
            Me.txt_nombre_usuario.Text = Me.dgv_lista_ticket.Item("USU_usuario", dgv_lista_ticket.SelectedRows(0).Index).Value
            Me.txt_recurso.Text = Me.dgv_lista_ticket.Item("TIC_recurso", dgv_lista_ticket.SelectedRows(0).Index).Value
            Me.txt_herramienta.Text = Me.dgv_lista_ticket.Item("TIC_herramienta", dgv_lista_ticket.SelectedRows(0).Index).Value
            Me.txt_plazo.Text = Me.dgv_lista_ticket.Item("TIC_plazo_resolucion", dgv_lista_ticket.SelectedRows(0).Index).Value
            Me.txt_descripcion.Text = Me.dgv_lista_ticket.Item("TIC_descripcion", dgv_lista_ticket.SelectedRows(0).Index).Value
            Me.cbo_prioridad.Text = Me.dgv_lista_ticket.Item("TIC_prioridad", dgv_lista_ticket.SelectedRows(0).Index).Value
            Me.cbo_estado.Text = Me.dgv_lista_ticket.Item("TIC_estado", dgv_lista_ticket.SelectedRows(0).Index).Value
            Me.dtp_fecha_estimada.Text = Me.dgv_lista_ticket.Item("TIC_fecha_real_cierre", dgv_lista_ticket.SelectedRows(0).Index).Value
            Me.dtp_fecha_real.Text = Me.dgv_lista_ticket.Item("TIC_fecha_estimado_cierre", dgv_lista_ticket.SelectedRows(0).Index).Value
            Me.txt_sector_dirigido.Text = Me.dgv_lista_ticket.Item("TIC_sector", dgv_lista_ticket.SelectedRows(0).Index).Value
            Me.txt_comentarios.Text = Me.dgv_lista_ticket.Item("TIC_comentarios", dgv_lista_ticket.SelectedRows(0).Index).Value

            TabControl1.SelectedIndex = 0

        Else
            MsgBox("Debe seleccionar un ticket del listado")
            Exit Sub
        End If
    End Sub

    Private Sub cbo_busqueda_estado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_busqueda_estado.SelectedIndexChanged
        cargargrillaticket()
    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click
        If dgv_lista_ticket.SelectedRows.Count > 0 Then
            Dim eliminar = (From t In datacontext.TICKET
                            Where t.TIC_id_ticket = CInt(dgv_lista_ticket.Item("TIC_id_ticket", dgv_lista_ticket.SelectedRows(0).Index).Value)).ToList()(0)
            Select Case MsgBox("Se eliminará el Ticket seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar Ticket")
                Case MsgBoxResult.Yes
                    datacontext.TICKET.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El Ticket ha sido eliminado")
                    cargargrillaticket()
                    Me.Close()
            End Select
            Me.Close()
        Else
            MsgBox("Debe seleccionar un Ticket")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Sub LimpiarReceptor()
        txt_id_ticket.Clear()
        cbo_prioridad.SelectedIndex = -1
        cbo_estado.SelectedIndex = 0
        dtp_fecha_estimada.Text = Now
        dtp_fecha_real.Text = Now
        txt_sector_dirigido.Clear()
        txt_comentarios.Clear()
        btn_respuesta.Enabled = True
        btn_Cancelar_Receptor.Enabled = True
    End Sub

    Sub CargarReceptor()
        txt_id_ticket.Clear()
        cbo_prioridad.SelectedIndex = -1
        cbo_estado.SelectedIndex = 0
        dtp_fecha_estimada.Text = Now
        dtp_fecha_real.Text = Now
        txt_sector_dirigido.Clear()
        txt_comentarios.Clear()
        btn_respuesta.Enabled = False
        btn_Cancelar_Receptor.Enabled = False
    End Sub

    Sub LimpiarSolicitante()
        txt_recurso.Clear()
        txt_herramienta.Clear()
        txt_plazo.Clear()
        txt_descripcion.Clear()
        dtp_fecha_pedido.Text = Now
    End Sub

    Private Sub chk_Nuevo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_Nuevo.CheckedChanged
        If frm_Principal.LBL_MENU_PERFIL.Text <> "ADMINISTRADOR" Then
            If chk_Nuevo.Checked = True Then
                LimpiarSolicitante()
                GroupSolicitante.Enabled = True
            Else
            End If
        Else
            LimpiarReceptor()
            CargarReceptor()
        End If
    End Sub

    Private Sub dgv_lista_ticket_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_lista_ticket.CellClick
        cargargrillaticket()
    End Sub

    Private Sub btn_Exportar_PDF_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_Exportar_EXCEL.Click

        llenarExcel(dgv_lista_ticket)


        'EL CODIGO EXPORTAR A PDF FUNCIONA, SOLO DE COMENTO PARA UTILIZAR EL BOTON EXPORTAR A PDF COMO EXPORTAR A EXCEL.

        'Try
        '    'intentar generar el documento
        '    Dim doc As New Document(PageSize.A3.Rotate, 5, 5, 5, 5)
        '    'path que guarda el reporte en el escritorio de windows (desktop)
        '    Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Ticket_" + cbo_busqueda_estado.Text + ".pdf"
        '    Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
        '    PdfWriter.GetInstance(doc, file)
        '    doc.Open()

        '    Dim encabezado As New Paragraph("Estado: " + cbo_busqueda_estado.Text)
        '    doc.Add(encabezado)
        '    doc.Add(interlineado)
        '    '  doc.Add(interlineado)

        '    'se crea un objeto PDFTable con el numero de columnas  del datagridview
        '    Dim datatableencabezado As New PdfPTable(11)
        '    Dim datatablecuerpo As New PdfPTable(11)

        '    datatableencabezado.WidthPercentage = 100
        '    datatableencabezado.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
        '    datatableencabezado.HeaderRows = 0
        '    datatableencabezado.DefaultCell.BorderWidth = 1

        '    datatablecuerpo.WidthPercentage = 100
        '    datatablecuerpo.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
        '    datatablecuerpo.HeaderRows = 1
        '    datatablecuerpo.DefaultCell.BorderWidth = 0

        '    'se capturan los nombres de las columnas del datagridview de las ordenes por remito

        '    For Z As Integer = 0 To dgv_lista_ticket.ColumnCount - 1
        '        If dgv_lista_ticket.Columns(Z).Visible = True Then
        '            Try
        '                datatableencabezado.AddCell(dgv_lista_ticket.Columns(Z).HeaderText)
        '            Catch ex As Exception
        '                datatableencabezado.AddCell(" ")
        '            End Try
        '        End If
        '    Next

        '    datatableencabezado.CompleteRow()
        '    doc.Add(datatableencabezado)
        '    datatableencabezado.DeleteBodyRows()
        '    doc.Add(interlineado)
        '    'se generan las columnas del datagridview 
        '    For Y As Integer = 0 To dgv_lista_ticket.RowCount - 1
        '        For Z As Integer = 0 To dgv_lista_ticket.ColumnCount - 1
        '            If dgv_lista_ticket.Columns(Z).Visible = True Then
        '                Try
        '                    datatablecuerpo.AddCell(dgv_lista_ticket(Z, Y).Value.ToString())
        '                Catch ex As Exception
        '                    datatablecuerpo.AddCell(" ")
        '                End Try
        '            End If
        '        Next
        '        datatablecuerpo.CompleteRow()
        '    Next
        '    doc.Add(datatablecuerpo)
        '    datatablecuerpo.DeleteBodyRows()
        '    'Next
        '    doc.Close()
        '    Process.Start(filename)
        '    ' Me.Close()
        'Catch ex As Exception
        '    'si el mensaje es fallido mostrar msgbox
        '    MessageBox.Show("No se puede generar el pdf, cierre el pdf anterior y vuleva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
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

    Private Sub btn_Solicitud_Click(sender As System.Object, e As System.EventArgs) Handles btn_Solicitud.Click
        Try
            If txt_recurso.Text.Length = 0 Then
                MsgBox("Debe completar el campo 'Recurso o Máquina'")
                txt_recurso.Focus()
                Exit Sub
            End If

            'GUARDA SOLICITANTE
            Dim ticket = New TICKET
            ticket.TIC_id_usuario = txt_id_usuario.Text
            ticket.TIC_fecha_pedido = StrConv(dtp_fecha_pedido.Text, VbStrConv.ProperCase)
            ticket.TIC_recurso = txt_recurso.Text
            ticket.TIC_herramienta = StrConv(txt_herramienta.Text, VbStrConv.ProperCase)
            ticket.TIC_plazo_resolucion = StrConv(txt_plazo.Text, VbStrConv.ProperCase)
            ticket.TIC_descripcion = StrConv(txt_descripcion.Text, VbStrConv.ProperCase)

            ticket.TIC_estado = StrConv(cbo_estado.Text, VbStrConv.ProperCase)

            datacontext.TICKET.InsertOnSubmit(ticket)
            datacontext.SubmitChanges()
            Dim ultimoticket = (From ut In datacontext.TICKET
                                Select ut.TIC_id_ticket
                                Order By TIC_id_ticket Descending).ToList()(0)
            MsgBox("El Ticket fue cargado exitosamente, N° " & ultimoticket)
            Me.Close()
            '  cargargrilla()
            ' limpiarcontroles()
        Catch ex As Exception
            MsgBox("El Ticket no puedo ser cargado")
            ' limpiarcontroles()
            ' cargargrilla()
        End Try
    End Sub

    Private Sub btn_respuesta_Click(sender As System.Object, e As System.EventArgs) Handles btn_respuesta.Click
        Try
            Dim ActualizarTicket = (From P In datacontext.TICKET Where P.TIC_id_ticket = (txt_id_ticket.Text.ToUpper)).ToList()(0)
            ActualizarTicket.TIC_prioridad = StrConv(cbo_prioridad.Text, VbStrConv.ProperCase)
            ActualizarTicket.TIC_estado = cbo_estado.Text
            ActualizarTicket.TIC_fecha_estimado_cierre = StrConv(dtp_fecha_estimada.Text, VbStrConv.ProperCase)
            ActualizarTicket.TIC_fecha_real_cierre = StrConv(dtp_fecha_real.Text, VbStrConv.ProperCase)
            ActualizarTicket.TIC_sector = StrConv(txt_sector_dirigido.Text, VbStrConv.ProperCase)
            ActualizarTicket.TIC_comentarios = StrConv(txt_comentarios.Text, VbStrConv.ProperCase)

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            LimpiarReceptor()
            LimpiarSolicitante()
            cargargrillaticket()
            TabControl1.SelectedIndex = 1
            '  cargargrilla()
            '  Me.limpiarcontroles()
            If frm_Principal.LBL_MENU_PERFIL.Text <> "ADMINISTRADOR" Then
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Ticket")
            '  Me.limpiarcontroles()
            '  Me.cargargrilla()
        End Try
    End Sub

    Private Sub btnCancelar_Solicitante_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar_Solicitante.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btn_Cancelar_Receptor_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancelar_Receptor.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class