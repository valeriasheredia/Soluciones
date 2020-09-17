Public Class Automatico

    Public tempcadena As String

    Public Sub informe_diario_tareas()
        frm_Listado_Tareas.frm_Listado_Tareas_Load(0, Nothing)
        Dim restar_dias As Integer
        Dim nueva_fechas As Date
        If Date.Today.DayOfWeek = 1 Then
            restar_dias = -3
        Else
            restar_dias = -1
        End If
        nueva_fechas = Date.Today.AddDays(restar_dias)
        frm_Listado_Tareas.dtpFecha.Value = nueva_fechas
        'For i = 1 To frm_Listado_Tareas.cbo_sector.Items.Count
        frm_Listado_Tareas.cbo_sector.SelectedIndex = 2 'i - 1
        frm_Listado_Tareas.Btn_informe_diario_Click(1, Nothing)
        'Next
    End Sub
End Class
