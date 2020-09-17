Imports System.IO
Imports System.Text
Imports System.Globalization

Public Class frm_Etiqueta_Modelo_1
    Private Sub frm_Etiqueta_Modelo_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ArmarEtiqueta()
        txtId_Cliente.Visible = False
        txt_id_orden.Visible = False
        btnBuscarCliente.Visible = False
        btnBuscar_Orden.Focus()
        dgv_Etiquetas.ClearSelection()
        cboLogo.SelectedIndex = 2

        '***************Para ver con Vale link label a el out de etiquetas****************
        Dim tempruta As String
        tempruta = Configuration.ConfigurationManager.AppSettings("ruta_salida_etiquetas")
        LinkLabel1.Text = "VER ETIQUETAS GENERADAS"
        LinkLabel1.Links.Add(0, 23, tempruta)
        '************************************************************************
    End Sub

    Private Sub btnBuscarCliente_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarCliente.Click
        frm_Cliente.quienllamocliente = Me
        frm_Cliente.Text = "Seleccionar Cliente"
        frm_Cliente.Show()
    End Sub

    Private Sub btnNuevaEtiqueta_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiarEtiqueta.Click
        Select Case MsgBox("Se limpiarán todos los campos, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Limpiar Campos")
            Case MsgBoxResult.Yes
                Limpiar()
        End Select
    End Sub

    Sub Limpiar()
        txtDescripcionEntrega.Clear()
        txtDirigidoA.Clear()
        txtId_Cliente.Clear()
        txt_id_orden.Clear()
        txt_orden.Clear()
        txtSolicitante.Clear()
        txtDomicilio.Clear()
        txtLocalidad.Clear()
        txtCodigoPostal.Clear()
        txtSeccion.Clear()
        txtCantidadBultos.Clear()
        txtUnidadxBulto.Clear()
        txtTotalBultos.Clear()
        txtPeso.Clear()
        cboLogo.SelectedIndex = -1
    End Sub

    Private Sub ArmarEtiqueta()
        dgv_Etiquetas.Enabled = True
        dgv_Etiquetas.AutoGenerateColumns = False
        dgv_Etiquetas.Columns.Clear()

        dgv_Etiquetas.Columns.Add(txt_orden.Text, "Orden")
        'dgv_Etiquetas.Columns(0).Width = 50
        dgv_Etiquetas.Columns.Add(txtDescripcionEntrega.Text, "Descripción")
        dgv_Etiquetas.Columns.Add("CLI_id_cliente", "id_cliente")
        dgv_Etiquetas.Columns(2).Visible = False
        dgv_Etiquetas.Columns.Add("CLI_razon_social", "Dirigido a")
        dgv_Etiquetas.Columns.Add(txtSolicitante.Text, "Solicitante")
        dgv_Etiquetas.Columns(4).Visible = False
        dgv_Etiquetas.Columns.Add(txtSolicitante.Text, "Sector")
        dgv_Etiquetas.Columns(5).Visible = False
        dgv_Etiquetas.Columns.Add("CLI_domicilio", "Domicilio")
        dgv_Etiquetas.Columns.Add("CLI_localidad", "Localidad")
        dgv_Etiquetas.Columns.Add("CLI_codigo_postal", "CP")
        'dgv_Etiquetas.Columns(8).Width = 50
        dgv_Etiquetas.Columns.Add(txtDespachado.Text, "Sección")
        dgv_Etiquetas.Columns.Add(txtDespachado.Text, "Despachado")
        dgv_Etiquetas.Columns.Add(txtCantidadBultos.Text, "Cantidad")
        'dgv_Etiquetas.Columns(11).Width = 50
        dgv_Etiquetas.Columns.Add("", "Nro Bultos")
        'dgv_Etiquetas.Columns(12).Width = 50
        dgv_Etiquetas.Columns.Add(txtUnidadxBulto.Text, "Unid x Bulto")
        'dgv_Etiquetas.Columns(13).Width = 50
        dgv_Etiquetas.Columns.Add(txtTotalBultos.Text, "Total Bultos")
        'dgv_Etiquetas.Columns(14).Width = 50
        dgv_Etiquetas.Columns.Add(txtPeso.Text, "Peso")
        'dgv_Etiquetas.Columns(15).Width = 50
        dgv_Etiquetas.Columns.Add(cboLogo.Text, "Logo")
    End Sub

    Public Sub CargaEtiqueta()
        'Dim temp_total_bultos As Integer = 0
        Dim temp_bulto_parcial As Integer = 0

        Dim temp_unidad_x_bulto As Integer = 0

        'temp_total_bultos = CInt(txtCantidadBultos.Text) / CInt(txtUnidadxBulto.Text)
        For i = 1 To CInt(txtTotalBultos.Text)
            temp_bulto_parcial = temp_bulto_parcial + 1
            If i = CInt(txtTotalBultos.Text) Then
                temp_unidad_x_bulto = CInt(txtCantidadBultos.Text) - (CInt(txtUnidadxBulto.Text) * (CInt(txtTotalBultos.Text) - 1))
            Else
                temp_unidad_x_bulto = CInt(txtUnidadxBulto.Text)
            End If

            Dim row As String() = New String() {sacar_tildes(txt_orden.Text),
                                                 sacar_tildes(txtDescripcionEntrega.Text),
                                                sacar_tildes(txtId_Cliente.Text),
                                                sacar_tildes(txtDirigidoA.Text),
                                                sacar_tildes(txtSolicitante.Text),
                                                sacar_tildes("sinuso"),
                                                sacar_tildes(txtDomicilio.Text),
                                                sacar_tildes(txtLocalidad.Text),
                                                sacar_tildes(txtCodigoPostal.Text),
                                                sacar_tildes(txtDespachado.Text),
                                                sacar_tildes(txtSeccion.Text),
                                                sacar_tildes(txtCantidadBultos.Text),
                                                sacar_tildes(CStr(temp_bulto_parcial)), _
                                                sacar_tildes(temp_unidad_x_bulto),
                                                sacar_tildes(txtTotalBultos.Text),
                                                sacar_tildes(txtPeso.Text),
                                                sacar_tildes(cboLogo.Text)}
            dgv_Etiquetas.Rows.Add(row)
        Next
        dgv_Etiquetas.ClearSelection()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        If txtDescripcionEntrega.Text.Length = 0 Then
            MsgBox("La descripción del producto a entregar no puede estar vacío")
            txtDescripcionEntrega.Focus()
            Exit Sub
        End If
        If txtDirigidoA.Text.Length = 0 Then
            MsgBox("El nombre del cliente no puede quedar vacío")
            btnBuscarCliente.Focus()
            Exit Sub
        End If
        If txtDomicilio.Text.Length = 0 Then
            MsgBox("La dirección no puede quedar vacío")
            txtDomicilio.Focus()
            Exit Sub
        End If
        If txtCantidadBultos.Text.Length = 0 Then
            MsgBox("La cantidad de bultos no puede quedar vacío")
            txtCantidadBultos.Focus()
            Exit Sub
        End If
        If txtUnidadxBulto.Text.Length = 0 Then
            MsgBox("La unidad por bulto no puede quedar vacío")
            txtUnidadxBulto.Focus()
            Exit Sub
        End If
        If txtTotalBultos.Text.Length = 0 Then
            MsgBox("El total de bultos no puede quedar vacío")
            txtTotalBultos.Focus()
            Exit Sub
        End If

        If cboLogo.SelectedIndex = -1 Then
            MsgBox("Seleccione un logo")
            txtTotalBultos.Focus()
            Exit Sub
        End If
        CargaEtiqueta()
        txtCantidadBultos.Clear()
        txtUnidadxBulto.Clear()
        txtTotalBultos.Clear()
        txtPeso.Clear()
        cboLogo.SelectedIndex = 2

        dgv_Etiquetas.ClearSelection()
    End Sub

    Private Sub btnGenerarEtiquetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarEtiquetas.Click

        'System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-ES")


        If dgv_Etiquetas.RowCount > 0 Then
            Dim consulta As String = "ETIQUETA_GENERICA_DIARIA_" + Date.Now.Millisecond.ToString + ".csv"

            Dim tempruta As String = Configuration.ConfigurationManager.AppSettings("ruta_entrada_etiquetas")
            Dim filePath As String = tempruta + consulta

            'Dim filePath As String = "C:\Users\pbaldo\Downloads\Baldo-Compartida\" + consulta
            'Dim filePath As String = "E:\trabajos\Trabajo Vale\Modelo de etiquetas\" + consulta

            Dim delimeter As String = ";"
            Dim sb As New StringBuilder
            Try
                For i As Integer = 0 To dgv_Etiquetas.Rows.Count - 1
                    Dim array As String() = New String(dgv_Etiquetas.Columns.Count - 1) {}
                    If i.Equals(0) Then
                        For j As Integer = 0 To dgv_Etiquetas.Columns.Count - 1
                            array(j) = dgv_Etiquetas.Columns(j).HeaderText
                        Next
                        sb.AppendLine(String.Join(delimeter, array))
                    End If
                    For j As Integer = 0 To dgv_Etiquetas.Columns.Count - 1
                        array(j) = dgv_Etiquetas(j, i).Value.ToString
                    Next
                    If Not dgv_Etiquetas.Rows(i).IsNewRow Then
                        sb.AppendLine(String.Join(delimeter, array))
                    End If
                Next
                File.WriteAllText(filePath, sb.ToString)
                MsgBox("La consulta se ha generado correctamente")
                '  Process.Start(filePath)
                txtCantidadBultos.Clear()
                'txtNumeroBultos.Clear()
                txtUnidadxBulto.Clear()
                txtTotalBultos.Clear()
                txtPeso.Clear()
                cboLogo.SelectedIndex = 2
                dgv_Etiquetas.Rows.Clear()
            Catch ex As Exception
                MsgBox("Hubo un error al generar la consulta")
            End Try
        Else
            MsgBox("Debe cargar al menos una etiqueta", MsgBoxStyle.Information, "Etiquetas")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Select Case MsgBox("Se eliminará la fila seleccionada, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar Fila")
            Case MsgBoxResult.Yes
                For Each r As DataGridViewRow In dgv_Etiquetas.SelectedRows
                    dgv_Etiquetas.Rows.Remove(r)
                Next
        End Select
        dgv_Etiquetas.ClearSelection()
    End Sub

    Private Sub btnBuscar_Orden_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Orden.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub frm_Etiqueta_Modelo_1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub txtCantidadBultos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadBultos.TextChanged
        calcula_cantidad_bultos()
    End Sub

    Private Sub txtUnidadxBulto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnidadxBulto.TextChanged
        calcula_cantidad_bultos()
    End Sub

    Sub calcula_cantidad_bultos()
        If txtCantidadBultos.TextLength <> 0 And txtUnidadxBulto.TextLength <> 0 Then
            txtTotalBultos.Text = Math.Ceiling(CInt(txtCantidadBultos.Text) / CInt(txtUnidadxBulto.Text))
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'VER CON VALE!!! hay mas codigo en el load de este form

        Try
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
        Catch ex As Exception
            MsgBox("No se encuentra la ruta")
        End Try
    End Sub

    Private Sub txtCantidadBultos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadBultos.KeyPress
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

    Private Sub txtUnidadxBulto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidadxBulto.KeyPress
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

    '--------------------------------------------------------------------------------------------
    'Función para quitar acentos de una cadena de texto
    '--------------------------------------------------------------------------------------------
    Public Function sacar_tildes(ByVal strNombre As String) As String
        Const conAcentos = "ÁÀÉÈÍÌÓÒÚÙÑ"  '"áàäâÁÀÄÂéèëêÉÈËÊíìïîÍÌÏÎóòöôÓÒÖÔúùüûÚÙÜÛýÿÝ"
        Const sinAcentos = "AAEEIIOOUUN"  '"aaaaAAAAeeeeEEEEiiiiIIIIooooOOOOuuuuUUUUyyY"
        Dim i As Integer
        strNombre = strNombre.ToUpper()
        For i = Len(conAcentos) To 1 Step -1
            strNombre = Replace(strNombre, Mid(conAcentos, i, 1), Mid(sinAcentos, i, 1))
        Next
        If strNombre = Nothing Then
            strNombre = " "
        End If
        sacar_tildes = strNombre
    End Function

   
End Class

