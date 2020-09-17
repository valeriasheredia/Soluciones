<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Graficos
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
        Dim ChartArea17 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend17 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series49 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series50 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series51 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title17 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea18 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend18 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series52 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series53 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series54 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title18 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea19 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend19 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series55 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series56 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series57 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title19 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea20 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend20 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series58 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series59 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series60 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title20 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart11 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnExportarPDF = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart3
        '
        Me.Chart3.BackColor = System.Drawing.SystemColors.ControlLight
        ChartArea17.AxisX.Interval = 1.0R
        ChartArea17.AxisX.IsLabelAutoFit = False
        ChartArea17.AxisX.LabelStyle.Angle = 90
        ChartArea17.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea17.AxisX2.IsLabelAutoFit = False
        ChartArea17.AxisY.IsLabelAutoFit = False
        ChartArea17.AxisY2.IsLabelAutoFit = False
        ChartArea17.Name = "ChartArea1"
        ChartArea17.Position.Auto = False
        ChartArea17.Position.Height = 90.0!
        ChartArea17.Position.Width = 95.0!
        ChartArea17.Position.Y = 5.0!
        Me.Chart3.ChartAreas.Add(ChartArea17)
        Legend17.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend17)
        Me.Chart3.Location = New System.Drawing.Point(12, 468)
        Me.Chart3.Name = "Chart3"
        Series49.ChartArea = "ChartArea1"
        Series49.IsValueShownAsLabel = True
        Series49.IsVisibleInLegend = False
        Series49.Legend = "Legend1"
        Series49.LegendText = "Tiempo Estimado"
        Series49.Name = "Series1"
        Series50.ChartArea = "ChartArea1"
        Series50.IsValueShownAsLabel = True
        Series50.IsVisibleInLegend = False
        Series50.Legend = "Legend1"
        Series50.LegendText = "Tiempo Real"
        Series50.Name = "Series2"
        Series51.ChartArea = "ChartArea1"
        Series51.IsValueShownAsLabel = True
        Series51.IsVisibleInLegend = False
        Series51.Legend = "Legend1"
        Series51.LegendText = "Tiempo Asignado"
        Series51.Name = "Series3"
        Me.Chart3.Series.Add(Series49)
        Me.Chart3.Series.Add(Series50)
        Me.Chart3.Series.Add(Series51)
        Me.Chart3.Size = New System.Drawing.Size(1335, 222)
        Me.Chart3.TabIndex = 98
        Me.Chart3.Text = "Chart3"
        Title17.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title17.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        Title17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title17.Name = "Title1"
        Title17.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart3.Titles.Add(Title17)
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Chart2.BorderlineColor = System.Drawing.SystemColors.Control
        ChartArea18.AxisX.Interval = 1.0R
        ChartArea18.AxisX.IsLabelAutoFit = False
        ChartArea18.AxisX.LabelStyle.Angle = 90
        ChartArea18.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea18.AxisX2.IsLabelAutoFit = False
        ChartArea18.AxisY.IsLabelAutoFit = False
        ChartArea18.AxisY2.IsLabelAutoFit = False
        ChartArea18.Name = "ChartArea1"
        ChartArea18.Position.Auto = False
        ChartArea18.Position.Height = 90.0!
        ChartArea18.Position.Width = 95.0!
        ChartArea18.Position.Y = 5.0!
        Me.Chart2.ChartAreas.Add(ChartArea18)
        Legend18.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend18)
        Me.Chart2.Location = New System.Drawing.Point(12, 240)
        Me.Chart2.Name = "Chart2"
        Series52.ChartArea = "ChartArea1"
        Series52.IsValueShownAsLabel = True
        Series52.IsVisibleInLegend = False
        Series52.Legend = "Legend1"
        Series52.LegendText = "Tiempo Estimado"
        Series52.Name = "Series1"
        Series53.ChartArea = "ChartArea1"
        Series53.IsValueShownAsLabel = True
        Series53.IsVisibleInLegend = False
        Series53.Legend = "Legend1"
        Series53.LegendText = "Tiempo Real"
        Series53.Name = "Series2"
        Series54.ChartArea = "ChartArea1"
        Series54.IsValueShownAsLabel = True
        Series54.IsVisibleInLegend = False
        Series54.Legend = "Legend1"
        Series54.LegendText = "Tiempo Asignado"
        Series54.Name = "Series3"
        Me.Chart2.Series.Add(Series52)
        Me.Chart2.Series.Add(Series53)
        Me.Chart2.Series.Add(Series54)
        Me.Chart2.Size = New System.Drawing.Size(1335, 222)
        Me.Chart2.TabIndex = 97
        Me.Chart2.Text = "Chart2"
        Title18.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title18.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        Title18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title18.Name = "Title1"
        Title18.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart2.Titles.Add(Title18)
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Chart1.BorderlineColor = System.Drawing.SystemColors.Control
        ChartArea19.AxisX.Interval = 1.0R
        ChartArea19.AxisX.IsLabelAutoFit = False
        ChartArea19.AxisX.LabelStyle.Angle = 90
        ChartArea19.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea19.AxisX2.IsLabelAutoFit = False
        ChartArea19.AxisY.IsLabelAutoFit = False
        ChartArea19.AxisY2.IsLabelAutoFit = False
        ChartArea19.Name = "ChartArea1"
        ChartArea19.Position.Auto = False
        ChartArea19.Position.Height = 90.0!
        ChartArea19.Position.Width = 95.0!
        ChartArea19.Position.Y = 5.0!
        Me.Chart1.ChartAreas.Add(ChartArea19)
        Legend19.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend19)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series55.ChartArea = "ChartArea1"
        Series55.IsValueShownAsLabel = True
        Series55.IsVisibleInLegend = False
        Series55.Legend = "Legend1"
        Series55.LegendText = "Tiempo Estimado"
        Series55.Name = "Series1"
        Series56.ChartArea = "ChartArea1"
        Series56.IsValueShownAsLabel = True
        Series56.IsVisibleInLegend = False
        Series56.Legend = "Legend1"
        Series56.LegendText = "Tiempo Real"
        Series56.Name = "Series2"
        Series57.ChartArea = "ChartArea1"
        Series57.IsValueShownAsLabel = True
        Series57.IsVisibleInLegend = False
        Series57.Legend = "Legend1"
        Series57.LegendText = "Tiempo Asignado"
        Series57.Name = "Series3"
        Me.Chart1.Series.Add(Series55)
        Me.Chart1.Series.Add(Series56)
        Me.Chart1.Series.Add(Series57)
        Me.Chart1.Size = New System.Drawing.Size(1335, 222)
        Me.Chart1.TabIndex = 96
        Me.Chart1.Text = "Chart1"
        Title19.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title19.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        Title19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title19.Name = "Title1"
        Title19.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart1.Titles.Add(Title19)
        '
        'Chart11
        '
        ChartArea20.Name = "ChartArea1"
        ChartArea20.Visible = False
        Me.Chart11.ChartAreas.Add(ChartArea20)
        Legend20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend20.IsTextAutoFit = False
        Legend20.Name = "Legend1"
        Legend20.Position.Auto = False
        Legend20.Position.Height = 43.39622!
        Legend20.Position.Width = 43.39622!
        Legend20.Position.X = 30.0!
        Legend20.Position.Y = 30.0!
        Me.Chart11.Legends.Add(Legend20)
        Me.Chart11.Location = New System.Drawing.Point(515, 696)
        Me.Chart11.Name = "Chart11"
        Series58.BorderColor = System.Drawing.Color.LightCoral
        Series58.ChartArea = "ChartArea1"
        Series58.IsValueShownAsLabel = True
        Series58.Legend = "Legend1"
        Series58.LegendText = "Tiempo Estimado"
        Series58.Name = "Series1"
        Series58.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64
        Series59.ChartArea = "ChartArea1"
        Series59.Legend = "Legend1"
        Series59.LegendText = "Tiempo Real"
        Series59.Name = "Series2"
        Series60.ChartArea = "ChartArea1"
        Series60.Legend = "Legend1"
        Series60.LegendText = "Tiempo Asignado"
        Series60.Name = "Series3"
        Me.Chart11.Series.Add(Series58)
        Me.Chart11.Series.Add(Series59)
        Me.Chart11.Series.Add(Series60)
        Me.Chart11.Size = New System.Drawing.Size(50, 30)
        Me.Chart11.TabIndex = 101
        Me.Chart11.Text = "Chart11"
        Title20.Name = "Title1"
        Me.Chart11.Titles.Add(Title20)
        Me.Chart11.Visible = False
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(895, 699)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(75, 27)
        Me.btnAnterior.TabIndex = 102
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(988, 699)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 27)
        Me.btnSiguiente.TabIndex = 102
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnExportarPDF
        '
        Me.btnExportarPDF.Location = New System.Drawing.Point(1080, 699)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Size = New System.Drawing.Size(97, 27)
        Me.btnExportarPDF.TabIndex = 103
        Me.btnExportarPDF.Text = "Exportar a PDF"
        Me.btnExportarPDF.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(1193, 699)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 27)
        Me.btnCancelar.TabIndex = 104
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 706)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(303, 706)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 706)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Mes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(221, 706)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 24)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Sector:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Frm_Graficos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1359, 738)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnExportarPDF)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.Chart11)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Frm_Graficos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gráficos Tareas"
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart3 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart11 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnExportarPDF As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
