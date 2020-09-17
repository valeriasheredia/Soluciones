Imports iTextSharp.text
'Imports iTextSharp.text.Image
Imports System.IO
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Printing
'Imports System.Drawing

Public Class frm_graficos_tareas_mensuales
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Dim totalgrafico As Integer

    Private Sub Frm_Graficos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TipoGrafico()
        Label1.Text = frm_Generar_Informe.cboMes.Text 'cbomes
        Label2.Text = frm_Generar_Informe.cbo_sector.Text

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
         Where (SEC_id_sector = CInt(frm_Generar_Informe.cbo_sector.SelectedValue) And TAR_fecha.Value.Month = frm_Generar_Informe.cboMes.SelectedIndex + 1 And COL_id_colaborador = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(indexfila).Cells(0).Value))) 'PABLO
        Return consultaporsector


         '  Where (SEC_id_sector = CInt(cbo_sector.SelectedValue) And TAR_fecha.Value.Month = cboMes.SelectedIndex + 1))


    End Function

    Sub TipoGrafico()

        totalgrafico = frm_Generar_Informe.dgvTotalesMensuales.Rows.Count

        '************************inicio grafico 1*********************************
        If 1 <= totalgrafico Then
            cargar_chart(Chart1, 0)
        Else
            Chart1.DataSource = Nothing
        End If
        '************************inicio grafico 2*********************************
        If 2 <= totalgrafico Then
            cargar_chart(Chart2, 1)
        Else
            Chart2.DataSource = Nothing
        End If
        '************************inicio grafico 3*********************************
        If 3 <= totalgrafico Then
            cargar_chart(Chart3, 2)
        Else
            Chart3.DataSource = Nothing
        End If
        '************************inicio grafico 4*********************************
        If 4 <= totalgrafico Then
            cargar_chart(Chart4, 3)
        Else
            Chart4.DataSource = Nothing
        End If
        '************************inicio grafico 5*********************************
        If 5 <= totalgrafico Then
            cargar_chart(Chart5, 4)
        Else
            Chart5.DataSource = Nothing
        End If
        '************************inicio grafico 6*********************************
        If 6 <= totalgrafico Then
            cargar_chart(Chart6, 5)
        Else
            Chart6.DataSource = Nothing
        End If
        '***************************inicio grafico 7*********************************
        If 7 <= totalgrafico Then
            cargar_chart(Chart7, 6)
        Else
            Chart7.DataSource = Nothing
        End If
        '***************************inicio grafico 8*********************************
        If 8 <= totalgrafico Then
            cargar_chart(Chart8, 7)
        Else
            Chart8.DataSource = Nothing
        End If
        '***************************inicio grafico 9*********************************
        If 9 <= totalgrafico Then
            cargar_chart(Chart9, 8)
        Else
            Chart9.DataSource = Nothing
        End If
        '***************************inicio grafico 10*********************************
        If 10 <= totalgrafico Then
            cargar_chart(Chart10, 9)
        Else
            Chart10.DataSource = Nothing
        End If
        '***************************inicio grafico 11*********************************
        If 11 <= totalgrafico Then
            cargar_chart(Chart11, 10)
        Else
            Chart11.DataSource = Nothing
        End If
        '***************************inicio grafico 12*********************************
        If 12 <= totalgrafico Then
            cargar_chart(Chart12, 11)
        Else
            Chart12.DataSource = Nothing
        End If
        '***************************inicio grafico 13*********************************
        If 13 <= totalgrafico Then
            cargar_chart(Chart13, 12)
        Else
            Chart13.DataSource = Nothing
        End If
        '***************************inicio grafico 14*********************************
        If 14 <= totalgrafico Then
            cargar_chart(Chart14, 13)
        Else
            Chart14.DataSource = Nothing
        End If
        '***************************inicio grafico 15*********************************
        If 15 <= totalgrafico Then
            cargar_chart(Chart15, 14)
        Else
            Chart15.DataSource = Nothing
        End If
        '***************************inicio grafico 16*********************************
        If 16 <= totalgrafico Then
            cargar_chart(Chart16, 15)
        Else
            Chart16.DataSource = Nothing
        End If
        '***************************inicio grafico 17*********************************
        If 17 <= totalgrafico Then
            cargar_chart(Chart17, 16)
        Else
            Chart17.DataSource = Nothing
        End If
        '***************************inicio grafico 18*********************************
        If 18 <= totalgrafico Then
            cargar_chart(Chart18, 17)
        Else
            Chart18.DataSource = Nothing
        End If
        '***************************inicio grafico 19*********************************
        If 19 <= totalgrafico Then
            cargar_chart(Chart19, 18)
        Else
            Chart19.DataSource = Nothing
        End If

    End Sub

    Private Sub Frm_Graficos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'Me.Dispose()
    End Sub

    Sub cargar_chart(ByVal grafico As Object, ByVal fila As Integer)
        grafico.Series(0).Points.Clear()
        grafico.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column 'tipo de grafico
        grafico.Series(0).YValueMembers = "Total_estimado"
        grafico.Series(0).IsValueShownAsLabel = True 'muestra los valores de cada serie
        grafico.Series(1).YValueMembers = "Total_real"
        grafico.Series(2).YValueMembers = "Asignacion"
        grafico.Titles(0).Text = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(fila).Cells(1).Value)
        grafico.Series(0).XValueMember = "CADENA"
        grafico.Series(1).XValueMember = "CADENA"
        grafico.Series(2).XValueMember = "CADENA"
        grafico.DataSource = llenargrafico(fila)
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnSubir_Click(sender As System.Object, e As System.EventArgs) Handles btnSubir.Click
        btnExportarPDF.Focus()
    End Sub

    Private Sub btnExportarPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarPDF.Click

        'intentar generar el documento
        Dim file1 As String = (Environ("TEMP") + "\grafico1.jpg")
        Dim grafico1 As Bitmap
        Dim imagen1 As Image
        Dim ancho, alto As Single
        ancho = 800.0F
        alto = 150.0F
        Dim doc As New Document(PageSize.A3, 25, 25, 10, 10)
        'path que guarda el reporte en el escritorio de windows (desktop)
        Dim ruta_reporte_grafico As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Graficos_tiempos_asignados.pdf"
        Dim reporte As New FileStream(ruta_reporte_grafico, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
        PdfWriter.GetInstance(doc, reporte)
        doc.Open()
        Dim encabezado As New Paragraph("Tiempos asignados")
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
        '************************inicio grafico 2*********************************
        If 2 <= totalgrafico Then
            grafico1 = New Bitmap(Chart2.Width, Chart2.Height)
            Chart2.DrawToBitmap(grafico1, Chart2.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        '************************inicio grafico 3*********************************
        If 3 <= totalgrafico Then
            grafico1 = New Bitmap(Chart3.Width, Chart3.Height)
            Chart3.DrawToBitmap(grafico1, Chart3.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''************************inicio grafico 4*********************************
        If 4 <= totalgrafico Then
            grafico1 = New Bitmap(Chart4.Width, Chart4.Height)
            Chart4.DrawToBitmap(grafico1, Chart4.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''************************inicio grafico 5*********************************
        If 5 <= totalgrafico Then
            grafico1 = New Bitmap(Chart5.Width, Chart5.Height)
            Chart5.DrawToBitmap(grafico1, Chart5.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''************************inicio grafico 6*********************************
        If 6 <= totalgrafico Then
            grafico1 = New Bitmap(Chart6.Width, Chart6.Height)
            Chart6.DrawToBitmap(grafico1, Chart6.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''***************************inicio grafico 7*********************************
        If 7 <= totalgrafico Then
            grafico1 = New Bitmap(Chart7.Width, Chart7.Height)
            Chart7.DrawToBitmap(grafico1, Chart7.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''***************************inicio grafico 8*********************************
        If 8 <= totalgrafico Then
            grafico1 = New Bitmap(Chart8.Width, Chart8.Height)
            Chart8.DrawToBitmap(grafico1, Chart8.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''***************************inicio grafico 9*********************************
        If 9 <= totalgrafico Then
            grafico1 = New Bitmap(Chart9.Width, Chart9.Height)
            Chart9.DrawToBitmap(grafico1, Chart9.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''***************************inicio grafico 10*********************************
        If 10 <= totalgrafico Then
            grafico1 = New Bitmap(Chart10.Width, Chart10.Height)
            Chart10.DrawToBitmap(grafico1, Chart10.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''***************************inicio grafico 11*********************************
        If 11 <= totalgrafico Then
            grafico1 = New Bitmap(Chart11.Width, Chart11.Height)
            Chart11.DrawToBitmap(grafico1, Chart11.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''***************************inicio grafico 12*********************************
        If 12 <= totalgrafico Then
            grafico1 = New Bitmap(Chart12.Width, Chart12.Height)
            Chart12.DrawToBitmap(grafico1, Chart12.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''***************************inicio grafico 13*********************************
        If 13 <= totalgrafico Then
            grafico1 = New Bitmap(Chart13.Width, Chart13.Height)
            Chart13.DrawToBitmap(grafico1, Chart13.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''***************************inicio grafico 14*********************************
        If 14 <= totalgrafico Then
            grafico1 = New Bitmap(Chart14.Width, Chart14.Height)
            Chart14.DrawToBitmap(grafico1, Chart14.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''***************************inicio grafico 15*********************************
        If 15 <= totalgrafico Then
            grafico1 = New Bitmap(Chart15.Width, Chart15.Height)
            Chart15.DrawToBitmap(grafico1, Chart15.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''***************************inicio grafico 16*********************************
        If 16 <= totalgrafico Then
            grafico1 = New Bitmap(Chart16.Width, Chart16.Height)
            Chart16.DrawToBitmap(grafico1, Chart16.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''***************************inicio grafico 17*********************************
        If 17 <= totalgrafico Then
            grafico1 = New Bitmap(Chart17.Width, Chart17.Height)
            Chart17.DrawToBitmap(grafico1, Chart17.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''***************************inicio grafico 18*********************************
        If 18 <= totalgrafico Then
            grafico1 = New Bitmap(Chart18.Width, Chart18.Height)
            Chart18.DrawToBitmap(grafico1, Chart18.DisplayRectangle)
            grafico1.Save(file1)
            imagen1 = Image.GetInstance(file1)
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        ''***************************inicio grafico 19*********************************
        If 19 <= totalgrafico Then
            grafico1 = New Bitmap(Chart19.Width, Chart19.Height)
            Chart19.DrawToBitmap(grafico1, Chart19.DisplayRectangle)
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