Imports System.Text
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_Grafico_1
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Private Sub btnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles btnSiguiente.Click
        frm_Grafico_2.Show()
    End Sub

    Private Sub frm_Grafico_1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TipoGrafico()
    End Sub

    Function llenargrafico(ByVal indexfila As Integer)
        Dim consultaporsector = (From A In datavistas.Tiempos_Totales
                                 Select A.COL_id_colaborador,
                                 A.COL_nombre_col,
                                 A.TAR_fecha,
                                A.Total_estimado,
                                 A.Total_real,
                                 A.SEC_id_sector,
                                 A.SEC_nombre_sector,
                                 A.Asignacion,
                                 A.CADENA
         Where (SEC_id_sector = frm_Generar_Informe.cbo_sector.SelectedIndex + 1 And TAR_fecha.Value.Month = frm_Generar_Informe.cboMes.SelectedIndex + 1 And COL_id_colaborador = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(indexfila).Cells(0).Value))) 'PABLO
        Return consultaporsector
    End Function


    Sub TipoGrafico()
        Dim totalgrafico As Integer
        totalgrafico = frm_Generar_Informe.dgvTotalesMensuales.Rows.Count

        If 4 <= totalgrafico Then
            Chart1.Series(0).Points.Clear()
            Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column ' tipo de grafico
            Chart1.Series(0).YValueMembers = "Total_estimado"
            Chart1.Series(0).IsValueShownAsLabel = True ' muestra los valores de cada serie
            Chart1.Series(1).YValueMembers = "Total_real"
            Chart1.Series(2).YValueMembers = "Asignacion"
            Chart1.Titles(0).Text = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(3).Cells(1).Value)
            Chart1.Series(0).XValueMember = "CADENA"
            Chart1.Series(1).XValueMember = "CADENA"
            Chart1.Series(2).XValueMember = "CADENA"
            Chart1.DataSource = llenargrafico(3)
        End If
        ' ''***************************fin grafico 4*********************************

        ' ''************************inicio grafico 5*********************************
        If 5 <= totalgrafico Then
            Chart2.Series(0).Points.Clear()
            Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column ' tipo de grafico
            Chart2.Series(0).YValueMembers = "Total_estimado"
            Chart2.Series(0).IsValueShownAsLabel = True ' muestra los valores de cada serie
            Chart2.Series(1).YValueMembers = "Total_real"
            Chart2.Series(2).YValueMembers = "Asignacion"
            Chart2.Titles(0).Text = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(4).Cells(1).Value)
            Chart2.Series(0).XValueMember = "CADENA"
            Chart2.Series(1).XValueMember = "CADENA"
            Chart2.Series(2).XValueMember = "CADENA"
            Chart2.DataSource = llenargrafico(4)
        End If
        ' ''***************************fin grafico 5*********************************

        ' ''************************inicio grafico 6*********************************
        If 6 <= totalgrafico Then
            Chart3.Series(0).Points.Clear()
            Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column 'tipo de grafico
            Chart3.Series(0).Color = Color.Blue
            Chart3.Series(0).YValueMembers = "Total_estimado"
            Chart3.Series(0).IsValueShownAsLabel = True 'muestra los valores de cada serie
            Chart3.Series(1).Color = Color.Red
            Chart3.Series(1).YValueMembers = "Total_real"
            Chart3.Series(1).IsValueShownAsLabel = True
            Chart3.Series(2).Color = Color.Yellow
            Chart3.Series(2).YValueMembers = "Asignacion"
            Chart3.Series(2).IsValueShownAsLabel = True
            Chart3.Titles(0).Text = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(5).Cells(1).Value)
            Chart3.DataSource = llenargrafico(5)
        End If
        ' ''***************************fin grafico 6*********************************
    End Sub

    Private Sub frm_Grafico_1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class