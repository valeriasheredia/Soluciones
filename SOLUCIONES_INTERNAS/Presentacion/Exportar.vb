﻿Module Exportar

    Function llenarExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables

        frm_Generar_Informe.dgvColaboradores.Columns(0).Name = "id_colaborador"
        frm_Generar_Informe.dgvColaboradores.Columns(1).Name = "Colaborador"
        frm_Generar_Informe.dgvColaboradores.Columns(2).Name = "Tiempo estimado"
        frm_Generar_Informe.dgvColaboradores.Columns(3).Name = "Tiempo real"
        frm_Generar_Informe.dgvColaboradores.Columns(4).Name = "Carga horaria"
        frm_Generar_Informe.dgvColaboradores.Columns(5).Name = "SEC_id_sector"
        frm_Generar_Informe.dgvColaboradores.Columns(6).Name = "Fecha"

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

            'exLibro.SaveAs("\\wsmaldig3\PlanetPress\Interno\IN\consultatareas.csv")
            'exLibro.Close()

            exLibro.SaveAs("E:\trabajos\Trabajo Vale\test.csv")
            exLibro.Close()

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function
End Module

