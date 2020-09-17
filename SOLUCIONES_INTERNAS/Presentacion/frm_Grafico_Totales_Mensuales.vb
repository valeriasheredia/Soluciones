Imports iTextSharp.text
Imports System.IO
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Printing

Public Class frm_Grafico_Totales_Mensuales
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Dim totalgrafico As Integer

    Private Sub frm_Grafico_Totales_Mensuales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TipoGrafico()
        Label1.Text = frm_Generar_Informe.cboMes.Text 'cbomes
        Label2.Text = frm_Generar_Informe.cbo_sector.Text
    End Sub

    Sub cargar_chart(ByVal grafico As Object, ByVal fila As Integer)
        grafico.Series(0).Points.Clear()
        grafico.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column 'tipo de grafico
        grafico.Series(0).YValueMembers = "Total_estimado_mensual"
        grafico.Series(0).IsValueShownAsLabel = True 'muestra los valores de cada serie
        grafico.Series(1).YValueMembers = "Total_real_mensual"
        grafico.Series(2).YValueMembers = "Asignacion"

        grafico.Series(0).XValueMember = "COL_nombre_col"
        grafico.Series(1).XValueMember = "COL_nombre_col"
        grafico.Series(2).XValueMember = "COL_nombre_col"
        grafico.DataSource = llenargrafico(fila)
    End Sub

    Function llenargrafico(ByVal indexfila As Integer)
        Dim total_x_colaborador = (From A In datavistas.Totales_mensuales
                                 Select A.COL_id_colaborador,
                                 A.COL_nombre_col,
                                 A.Mes,
                                 A.SEC_id_sector,
                                 A.SEC_nombre_sector,
                                 A.Total_estimado_mensual,
                                 A.Total_real_mensual,
                                 A.Asignacion
         Where (SEC_id_sector = CInt(frm_Generar_Informe.cbo_sector.SelectedValue) And Mes.Value = frm_Generar_Informe.cboMes.SelectedIndex + 1))

        Return total_x_colaborador
    End Function

    Sub TipoGrafico()
        totalgrafico = frm_Generar_Informe.dgvTotalesMensuales.Rows.Count

        '************************inicio grafico 1*********************************
        If 1 <= totalgrafico Then
            cargar_chart(Chart1, 0)
        Else
            Chart1.DataSource = Nothing
        End If
    End Sub

    Private Sub btnExportarPDF_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarPDF.Click

        'intentar generar el documento
        Dim file1 As String = (Environ("TEMP") + "\grafico1.jpg")
        Dim grafico1 As Bitmap
        Dim imagen1 As Image
        Dim ancho, alto As Single
        ancho = 800.0F
        alto = 150.0F
        Dim doc As New Document(PageSize.A4.Rotate, 25, 25, 10, 10)
        'path que guarda el reporte en el escritorio de windows (desktop)
        Dim ruta_reporte_grafico As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Graficos_totales_mensuales.pdf"
        Dim reporte As New FileStream(ruta_reporte_grafico, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
        PdfWriter.GetInstance(doc, reporte)
        doc.Open()
        Dim encabezado As New Paragraph("Tiempos Totales Mensuales")
        Dim interlineado As New Paragraph("")
        doc.Add(encabezado)
        '************************inicio grafico 1*********************************
        If 1 <= totalgrafico Then
            grafico1 = New Bitmap(Chart1.Width, Chart1.Height)
            Chart1.DrawToBitmap(grafico1, Chart1.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        'cierra la edicion y abre el archivo
        doc.Close()
        My.Computer.FileSystem.DeleteFile(file1)
        Process.Start(ruta_reporte_grafico)
    End Sub
End Class