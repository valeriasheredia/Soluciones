Imports System.Text
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_Generar_Informe
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas

    Private Sub frm_Generar_Informe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CARGA COMBOBOX SECTOR
        cboMes.Focus()
        Dim combosector = (From sec In datacontext.SECTOR
                           Select sec.SEC_id_sector, sec.SEC_nombre_sector)
        cbo_sector.DataSource = combosector
        cbo_sector.DisplayMember = "SEC_nombre_sector"
        cbo_sector.ValueMember = "SEC_id_sector"
        cbo_sector.SelectedIndex = -1
        btnGenerar_Informe.Visible = False

    End Sub

    'ARMA LA GRILLA DEL COLABORADOR
    Private Sub armargrillacolaborador()
        dgvColaboradores.Enabled = True
        dgvColaboradores.AutoGenerateColumns = False
        dgvColaboradores.Columns.Clear()
        ' dgvColaboradores.Columns.Add("COL_id_colaborador", "id_colaborador")
        dgvColaboradores.Columns.Add("Total_estimado", "Total estimado")
        dgvColaboradores.Columns.Add("Total_real", "Total real")
        dgvColaboradores.Columns.Add("Asignacion", "Asignación")
        dgvColaboradores.Columns.Add("TAR_fecha", "Fecha")
        dgvColaboradores.Columns.Add("COL_nombre_col", "Colaborador")

        ' dgvColaboradores.Columns.Add("SEC_id_sector", "id_sector")
        ' dgvColaboradores.Columns.Add("SEC_nombre_sector", "Sector")
        ' dgvColaboradores.Columns(0).DataPropertyName = "COL_id_colaborador"
        ' dgvColaboradores.Columns(0).Visible = False
        dgvColaboradores.Columns(0).DataPropertyName = "Total_estimado"
        dgvColaboradores.Columns(1).DataPropertyName = "Total_real"
        dgvColaboradores.Columns(2).DataPropertyName = "Asignacion"
        dgvColaboradores.Columns(3).DataPropertyName = "TAR_fecha"
        dgvColaboradores.Columns(4).DataPropertyName = "COL_nombre_col"
        ' dgvColaboradores.Columns(4).DataPropertyName = "SEC_id_sector"
        '  dgvColaboradores.Columns(4).Visible = False
        '  dgvColaboradores.Columns(5).DataPropertyName = "SEC_nombre_sector"
    End Sub

    Private Sub cbo_sector_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_sector.SelectedIndexChanged
        Filtrar_Mes_Sector()
        Totales_Mensuales()
        TipoGrafico()
    End Sub

    Private Sub Filtrar_Mes_Sector()
        armargrillacolaborador()
        Try
            Dim consultaporsector = (From A In datavistas.Tiempos_Totales
                               Select A.COL_id_colaborador,
                               A.COL_nombre_col,
                               A.TAR_fecha,
                              A.Total_estimado,
                               A.Total_real,
                               A.SEC_id_sector,
                               A.SEC_nombre_sector,
                               A.Asignacion
       Where (SEC_id_sector = CInt(cbo_sector.SelectedValue) And TAR_fecha.Value.Month = cboMes.SelectedIndex + 1))
            dgvColaboradores.DataSource = consultaporsector
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Totales_Mensuales()
        armargrillamensual()
        Try
            Dim totales_mensuales = (From t In datavistas.Totales_mensuales
                               Select t.COL_id_colaborador,
                               t.COL_nombre_col,
                               t.Mes,
                               t.SEC_id_sector,
                               t.SEC_nombre_sector,
                               t.Total_estimado_mensual,
                               t.Total_real_mensual,
                               t.Asignacion
         Where (SEC_id_sector = CInt(cbo_sector.SelectedValue) And Mes = cboMes.SelectedIndex + 1))
            dgvTotalesMensuales.DataSource = totales_mensuales
            dgvTotalesMensuales.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    'ARMA LA GRILLA MENSUAL
    Private Sub armargrillamensual()
        dgvTotalesMensuales.Enabled = True
        dgvTotalesMensuales.AutoGenerateColumns = False
        dgvTotalesMensuales.Columns.Clear()

        dgvTotalesMensuales.Columns.Add("COL_id_colaborador", "id_colaborador")
        dgvTotalesMensuales.Columns.Add("COL_nombre_col", "Colaborador")
        dgvTotalesMensuales.Columns.Add("Mes", "Mes")
        dgvTotalesMensuales.Columns.Add("SEC_id_sector", "id_sector")
        dgvTotalesMensuales.Columns.Add("SEC_nombre_sector", "Sector")
        dgvTotalesMensuales.Columns.Add("Total_estimado_mensual", "Total estimado")
        dgvTotalesMensuales.Columns.Add("Total_real_mensual", "Total real")
        dgvTotalesMensuales.Columns.Add("Asignacion", "Asignacion")

        dgvTotalesMensuales.Columns(0).DataPropertyName = "COL_id_colaborador"
        dgvTotalesMensuales.Columns(0).Visible = False
        dgvTotalesMensuales.Columns(1).DataPropertyName = "COL_nombre_col"
        dgvTotalesMensuales.Columns(2).DataPropertyName = "Mes"
        dgvTotalesMensuales.Columns(3).DataPropertyName = "SEC_id_sector"
        dgvTotalesMensuales.Columns(3).Visible = False
        dgvTotalesMensuales.Columns(4).DataPropertyName = "SEC_nombre_sector"
        dgvTotalesMensuales.Columns(5).DataPropertyName = "Total_estimado_mensual"
        dgvTotalesMensuales.Columns(6).DataPropertyName = "Total_real_mensual"
        dgvTotalesMensuales.Columns(7).DataPropertyName = "Asignacion"

    End Sub

    Private Sub cboMes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        Filtrar_Mes_Sector()
        Totales_Mensuales()
        TipoGrafico()
    End Sub

    Private Sub btnExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar_Informe.Click

        Dim consulta As String = "consulta_total_x_dia_" + Date.Now.Millisecond.ToString + ".csv"
        Dim consulta1 As String = "consulta_total_mensual_" + Date.Now.Millisecond.ToString + ".csv"
        Dim filePath As String = "\\wsmaldig3\PlanetPress\INTERNO\IN\" + consulta
        Dim filePath1 As String = "\\wsmaldig3\PlanetPress\INTERNO\IN\" + consulta1
        Dim delimeter As String = ","
        Dim sb As New StringBuilder
        Dim sb1 As New StringBuilder
        Try
            For i As Integer = 0 To dgvColaboradores.Rows.Count - 1
                Dim array As String() = New String(dgvColaboradores.Columns.Count - 1) {}
                If i.Equals(0) Then
                    For j As Integer = 0 To dgvColaboradores.Columns.Count - 1
                        array(j) = dgvColaboradores.Columns(j).HeaderText
                    Next
                    sb.AppendLine(String.Join(delimeter, array))
                End If
                For j As Integer = 0 To dgvColaboradores.Columns.Count - 1

                    If Not dgvColaboradores.Rows(i).IsNewRow Then

                        If dgvColaboradores.Columns(j).HeaderText = "Fecha" Or dgvColaboradores.Columns(j).HeaderText = "Colaborador" Then
                            array(j) = dgvColaboradores(j, i).Value.ToString
                        Else
                            array(j) = Microsoft.VisualBasic.Right("   " + dgvColaboradores(j, i).Value.ToString, 3)
                        End If
                    End If
                Next
                If Not dgvColaboradores.Rows(i).IsNewRow Then
                    sb.AppendLine(String.Join(delimeter, array))
                End If
            Next
            For i As Integer = 0 To dgvTotalesMensuales.Rows.Count - 1
                Dim array1 As String() = New String(dgvTotalesMensuales.Columns.Count - 1) {}
                If i.Equals(0) Then
                    For j As Integer = 0 To dgvTotalesMensuales.Columns.Count - 1
                        array1(j) = dgvTotalesMensuales.Columns(j).HeaderText
                    Next
                    sb1.AppendLine(String.Join(delimeter, array1))
                End If
                For j As Integer = 0 To dgvTotalesMensuales.Columns.Count - 1
                    If Not dgvTotalesMensuales.Rows(i).IsNewRow Then
                        array1(j) = dgvTotalesMensuales(j, i).Value.ToString
                    End If
                Next
                If Not dgvTotalesMensuales.Rows(i).IsNewRow Then
                    sb1.AppendLine(String.Join(delimeter, array1))
                End If
            Next
            File.WriteAllText(filePath, sb.ToString)
            File.WriteAllText(filePath1, sb1.ToString)
            ' File.AppendAllText(filePath, sb1.ToString)
            MsgBox("La consulta se ha generado correctamente")
            ' Process.Start(filePath)
            Me.Close()
        Catch ex As Exception
            MsgBox("Hubo un error al generar la consulta")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnGenerarGrafico_Click(sender As System.Object, e As System.EventArgs)
        'Select Case cbotipo.SelectedIndex
        '    Case 0
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Pie)
        '    Case 1
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Column)
        '    Case 2
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Point)
        '    Case 3
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Bar)
        '    Case 4
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Polar)
        '    Case 5
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Range)
        '    Case Else
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Pyramid)

        'End Select
    End Sub

    'BOTON CARGAR
    Sub TipoGrafico()
        Dim totalgrafico As Integer
        totalgrafico = dgvTotalesMensuales.Rows.Count
    End Sub

    Private Sub btnVerGraficos_Click(sender As System.Object, e As System.EventArgs) Handles btnTotales_por_Dia.Click
        If dgvColaboradores.Rows.Count = 0 Then
            MsgBox("Seleccione Mes Y Sector para ver el gráfico")
            cboMes.Focus()
            Exit Sub
        Else
            frm_graficos_tareas_mensuales.Show()
        End If
        'frm_graficos_tareas_mensuales.MdiParent = frm_Principal
        'frm_graficos_tareas_mensuales.Show()
    End Sub

    Private Sub frm_Generar_Informe_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub dgvColaboradores_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvColaboradores.CellClick
        Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvTotalesMensuales_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTotalesMensuales.CellClick
        Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn_Totales_Mensuales_por_Colaborador.Click
        If dgvTotalesMensuales.Rows.Count = 0 Then
            MsgBox("No hay registros de tareas mensuales")
            Exit Sub
        Else
            frm_Grafico_Totales_Mensuales.Show()
        End If
    End Sub
End Class
