<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Grafico_2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series13 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series14 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series15 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title5 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series16 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series17 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series18 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series19 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series20 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series21 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title7 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series22 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series23 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series24 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title8 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.Chart11 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(1494, 152)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 27)
        Me.btnSiguiente.TabIndex = 107
        Me.btnSiguiente.Text = ">>"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(1398, 152)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(75, 27)
        Me.btnAnterior.TabIndex = 108
        Me.btnAnterior.Text = "<<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'Chart11
        '
        ChartArea5.Name = "ChartArea1"
        ChartArea5.Visible = False
        Me.Chart11.ChartAreas.Add(ChartArea5)
        Legend5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend5.IsTextAutoFit = False
        Legend5.Name = "Legend1"
        Legend5.Position.Auto = False
        Legend5.Position.Height = 43.39622!
        Legend5.Position.Width = 43.39622!
        Legend5.Position.X = 30.0!
        Legend5.Position.Y = 30.0!
        Me.Chart11.Legends.Add(Legend5)
        Me.Chart11.Location = New System.Drawing.Point(1320, 12)
        Me.Chart11.Name = "Chart11"
        Series13.BorderColor = System.Drawing.Color.LightCoral
        Series13.ChartArea = "ChartArea1"
        Series13.IsValueShownAsLabel = True
        Series13.Legend = "Legend1"
        Series13.LegendText = "Tiempo Estimado"
        Series13.Name = "Series1"
        Series13.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64
        Series14.ChartArea = "ChartArea1"
        Series14.Legend = "Legend1"
        Series14.LegendText = "Tiempo Real"
        Series14.Name = "Series2"
        Series15.ChartArea = "ChartArea1"
        Series15.Legend = "Legend1"
        Series15.LegendText = "Tiempo Asignado"
        Series15.Name = "Series3"
        Me.Chart11.Series.Add(Series13)
        Me.Chart11.Series.Add(Series14)
        Me.Chart11.Series.Add(Series15)
        Me.Chart11.Size = New System.Drawing.Size(311, 120)
        Me.Chart11.TabIndex = 106
        Me.Chart11.Text = "Chart11"
        Title5.Name = "Title1"
        Me.Chart11.Titles.Add(Title5)
        '
        'Chart3
        '
        Me.Chart3.BackColor = System.Drawing.SystemColors.ControlLight
        ChartArea6.AxisX.Interval = 1.0R
        ChartArea6.AxisX.IsLabelAutoFit = False
        ChartArea6.AxisX.LabelStyle.Angle = 90
        ChartArea6.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea6.AxisX2.IsLabelAutoFit = False
        ChartArea6.AxisY.IsLabelAutoFit = False
        ChartArea6.AxisY2.IsLabelAutoFit = False
        ChartArea6.Name = "ChartArea1"
        ChartArea6.Position.Auto = False
        ChartArea6.Position.Height = 90.0!
        ChartArea6.Position.Width = 95.0!
        ChartArea6.Position.Y = 5.0!
        Me.Chart3.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend6)
        Me.Chart3.Location = New System.Drawing.Point(12, 524)
        Me.Chart3.Name = "Chart3"
        Series16.ChartArea = "ChartArea1"
        Series16.IsValueShownAsLabel = True
        Series16.IsVisibleInLegend = False
        Series16.Legend = "Legend1"
        Series16.LegendText = "Tiempo Estimado"
        Series16.Name = "Series1"
        Series17.ChartArea = "ChartArea1"
        Series17.IsValueShownAsLabel = True
        Series17.IsVisibleInLegend = False
        Series17.Legend = "Legend1"
        Series17.LegendText = "Tiempo Real"
        Series17.Name = "Series2"
        Series18.ChartArea = "ChartArea1"
        Series18.IsValueShownAsLabel = True
        Series18.IsVisibleInLegend = False
        Series18.Legend = "Legend1"
        Series18.LegendText = "Tiempo Asignado"
        Series18.Name = "Series3"
        Me.Chart3.Series.Add(Series16)
        Me.Chart3.Series.Add(Series17)
        Me.Chart3.Series.Add(Series18)
        Me.Chart3.Size = New System.Drawing.Size(1296, 250)
        Me.Chart3.TabIndex = 105
        Me.Chart3.Text = "Chart3"
        Title6.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        Title6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title6.Name = "Title1"
        Title6.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart3.Titles.Add(Title6)
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Chart2.BorderlineColor = System.Drawing.SystemColors.Control
        ChartArea7.AxisX.Interval = 1.0R
        ChartArea7.AxisX.IsLabelAutoFit = False
        ChartArea7.AxisX.LabelStyle.Angle = 90
        ChartArea7.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea7.AxisX2.IsLabelAutoFit = False
        ChartArea7.AxisY.IsLabelAutoFit = False
        ChartArea7.AxisY2.IsLabelAutoFit = False
        ChartArea7.Name = "ChartArea1"
        ChartArea7.Position.Auto = False
        ChartArea7.Position.Height = 90.0!
        ChartArea7.Position.Width = 95.0!
        ChartArea7.Position.Y = 5.0!
        Me.Chart2.ChartAreas.Add(ChartArea7)
        Legend7.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend7)
        Me.Chart2.Location = New System.Drawing.Point(12, 268)
        Me.Chart2.Name = "Chart2"
        Series19.ChartArea = "ChartArea1"
        Series19.IsValueShownAsLabel = True
        Series19.IsVisibleInLegend = False
        Series19.Legend = "Legend1"
        Series19.LegendText = "Tiempo Estimado"
        Series19.Name = "Series1"
        Series20.ChartArea = "ChartArea1"
        Series20.IsValueShownAsLabel = True
        Series20.IsVisibleInLegend = False
        Series20.Legend = "Legend1"
        Series20.LegendText = "Tiempo Real"
        Series20.Name = "Series2"
        Series21.ChartArea = "ChartArea1"
        Series21.IsValueShownAsLabel = True
        Series21.IsVisibleInLegend = False
        Series21.Legend = "Legend1"
        Series21.LegendText = "Tiempo Asignado"
        Series21.Name = "Series3"
        Me.Chart2.Series.Add(Series19)
        Me.Chart2.Series.Add(Series20)
        Me.Chart2.Series.Add(Series21)
        Me.Chart2.Size = New System.Drawing.Size(1296, 250)
        Me.Chart2.TabIndex = 104
        Me.Chart2.Text = "Chart2"
        Title7.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        Title7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title7.Name = "Title1"
        Title7.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart2.Titles.Add(Title7)
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Chart1.BorderlineColor = System.Drawing.SystemColors.Control
        ChartArea8.AxisX.Interval = 1.0R
        ChartArea8.AxisX.IsLabelAutoFit = False
        ChartArea8.AxisX.LabelStyle.Angle = 90
        ChartArea8.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea8.AxisX2.IsLabelAutoFit = False
        ChartArea8.AxisY.IsLabelAutoFit = False
        ChartArea8.AxisY2.IsLabelAutoFit = False
        ChartArea8.Name = "ChartArea1"
        ChartArea8.Position.Auto = False
        ChartArea8.Position.Height = 90.0!
        ChartArea8.Position.Width = 95.0!
        ChartArea8.Position.Y = 5.0!
        Me.Chart1.ChartAreas.Add(ChartArea8)
        Legend8.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend8)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series22.ChartArea = "ChartArea1"
        Series22.IsValueShownAsLabel = True
        Series22.IsVisibleInLegend = False
        Series22.Legend = "Legend1"
        Series22.LegendText = "Tiempo Estimado"
        Series22.Name = "Series1"
        Series23.ChartArea = "ChartArea1"
        Series23.IsValueShownAsLabel = True
        Series23.IsVisibleInLegend = False
        Series23.Legend = "Legend1"
        Series23.LegendText = "Tiempo Real"
        Series23.Name = "Series2"
        Series24.ChartArea = "ChartArea1"
        Series24.IsValueShownAsLabel = True
        Series24.IsVisibleInLegend = False
        Series24.Legend = "Legend1"
        Series24.LegendText = "Tiempo Asignado"
        Series24.Name = "Series3"
        Me.Chart1.Series.Add(Series22)
        Me.Chart1.Series.Add(Series23)
        Me.Chart1.Series.Add(Series24)
        Me.Chart1.Size = New System.Drawing.Size(1296, 250)
        Me.Chart1.TabIndex = 103
        Me.Chart1.Text = "Chart1"
        Title8.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        Title8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title8.Name = "Title1"
        Title8.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart1.Titles.Add(Title8)
        '
        'frm_Grafico_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 737)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.Chart11)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "frm_Grafico_2"
        Me.Text = "frm_Grafico_2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Chart11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents Chart11 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
