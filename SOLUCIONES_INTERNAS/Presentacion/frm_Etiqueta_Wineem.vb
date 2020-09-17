Imports System.Data.OleDb

Public Class frm_Etiqueta_Wineem

    Private Sub btnImportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnImportarExcel.Click
        importarExcel(dgv_Etiquetas)

        If dgv_Etiquetas.Rows.Count > 0 Then
            For i = 0 To dgv_Etiquetas.RowCount - 1
                dgv_Etiquetas.Rows(i).Cells("CANTIDAD DE CAJAS").Value = 0
                dgv_Etiquetas.Rows(i).Cells("CANTIDAD POR CAJAS").Value = 0
            Next
        End If
        dgv_Etiquetas.ClearSelection()

        Try
            dgv_Etiquetas.Columns(0).ReadOnly = True
            dgv_Etiquetas.Columns(1).ReadOnly = True
            dgv_Etiquetas.Columns(2).ReadOnly = True
            dgv_Etiquetas.Columns(3).ReadOnly = True
            dgv_Etiquetas.Columns(4).ReadOnly = True
            dgv_Etiquetas.Columns(5).ReadOnly = True
            dgv_Etiquetas.Columns(6).ReadOnly = True
            dgv_Etiquetas.Columns(7).Visible = False
            dgv_Etiquetas.Columns(8).ReadOnly = True

            dgv_Etiquetas.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgv_Etiquetas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgv_Etiquetas.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgv_Etiquetas.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgv_Etiquetas.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgv_Etiquetas.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Catch ex As Exception
        End Try
        'calcular()
    End Sub

    Sub calcular()
        Dim celda As String = dgv_Etiquetas.CurrentCell.Value.ToString
        Dim row As DataGridViewRow = dgv_Etiquetas.CurrentRow
        Try
            If celda > 0 Then
                row.Cells("CANTIDAD DE CAJAS").Value = CDbl(row.Cells("CANTIDAD DE CATALOGOS 09/10").Value) / CDbl(row.Cells("CANTIDAD POR CAJAS").Value)
            Else
                MsgBox("Ingrese un número mayor que cero")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv_Etiquetas_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Etiquetas.CellEndEdit
        calcular()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

        If dgv_Etiquetas.Rows.Count > 0 Then

            Try
                For i As Integer = 0 To dgv_Etiquetas.Rows.Count
                    '  If Not dgv_Etiquetas.Rows.Item(i) Is Nothing Then
                    '//Puedes hacer una validación con el nombre de la columna
                    If dgv_Etiquetas.Rows.Item(i).Cells("CANTIDAD DE CAJAS").Value > 1 Then
                        MsgBox(dgv_Etiquetas.Rows.Item(i).Cells("CANTIDAD DE CAJAS").Value)
                    Else
                        MsgBox("sale por el else")
                    End If
                Next
            Catch ex As Exception

            End Try

        End If
    End Sub

    'Public Sub CargaEtiqueta()
    '    'Dim temp_total_bultos As Integer = 0
    '    Dim temp_bulto_parcial As Integer = 0

    '    Dim temp_unidad_x_bulto As Integer = 0

    '    'temp_total_bultos = CInt(txtCantidadBultos.Text) / CInt(txtUnidadxBulto.Text)
    '    For i = 1 To CInt(txtTotalBultos.Text)
    '        temp_bulto_parcial = temp_bulto_parcial + 1
    '        If i = CInt(txtTotalBultos.Text) Then
    '            temp_unidad_x_bulto = CInt(txtCantidadBultos.Text) - (CInt(txtUnidadxBulto.Text) * (CInt(txtTotalBultos.Text) - 1))
    '        Else
    '            temp_unidad_x_bulto = CInt(txtUnidadxBulto.Text)
    '        End If

    '        Dim row As String() = New String() {sacar_tildes(txt_orden.Text),
    '                                             sacar_tildes(txtDescripcionEntrega.Text),
    '                                            sacar_tildes(txtId_Cliente.Text),
    '                                            sacar_tildes(txtDirigidoA.Text),
    '                                            sacar_tildes(txtSolicitante.Text),
    '                                            sacar_tildes("sinuso"),
    '                                            sacar_tildes(txtDomicilio.Text),
    '                                            sacar_tildes(txtLocalidad.Text),
    '                                            sacar_tildes(txtCodigoPostal.Text),
    '                                            sacar_tildes(txtDespachado.Text),
    '                                            sacar_tildes(txtSeccion.Text),
    '                                            sacar_tildes(txtCantidadBultos.Text),
    '                                            sacar_tildes(CStr(temp_bulto_parcial)), _
    '                                            sacar_tildes(temp_unidad_x_bulto),
    '                                            sacar_tildes(txtTotalBultos.Text),
    '                                            sacar_tildes(txtPeso.Text),
    '                                            sacar_tildes(cboLogo.Text)}
    '        dgv_Etiquetas.Rows.Add(row)
    '    Next
    '    dgv_Etiquetas.ClearSelection()
    'End Sub
End Class