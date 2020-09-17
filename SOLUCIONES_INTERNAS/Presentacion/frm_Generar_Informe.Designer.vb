<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Generar_Informe
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupListadoTareas = New System.Windows.Forms.GroupBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbo_sector = New System.Windows.Forms.ComboBox()
        Me.dgvColaboradores = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGenerar_Informe = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvTotalesMensuales = New System.Windows.Forms.DataGridView()
        Me.btnTotales_por_Dia = New System.Windows.Forms.Button()
        Me.btn_Totales_Mensuales_por_Colaborador = New System.Windows.Forms.Button()
        Me.GroupListadoTareas.SuspendLayout()
        CType(Me.dgvColaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTotalesMensuales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(681, 459)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(79, 33)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupListadoTareas
        '
        Me.GroupListadoTareas.Controls.Add(Me.cboMes)
        Me.GroupListadoTareas.Controls.Add(Me.Label31)
        Me.GroupListadoTareas.Controls.Add(Me.cbo_sector)
        Me.GroupListadoTareas.Controls.Add(Me.dgvColaboradores)
        Me.GroupListadoTareas.Controls.Add(Me.Label4)
        Me.GroupListadoTareas.Location = New System.Drawing.Point(12, 12)
        Me.GroupListadoTareas.Name = "GroupListadoTareas"
        Me.GroupListadoTareas.Size = New System.Drawing.Size(748, 231)
        Me.GroupListadoTareas.TabIndex = 36
        Me.GroupListadoTareas.TabStop = False
        Me.GroupListadoTareas.Text = "Tiempos totales por día"
        '
        'cboMes
        '
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMes.Location = New System.Drawing.Point(45, 19)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(114, 21)
        Me.cboMes.TabIndex = 1
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(12, 22)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(27, 13)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "Mes"
        '
        'cbo_sector
        '
        Me.cbo_sector.FormattingEnabled = True
        Me.cbo_sector.Location = New System.Drawing.Point(216, 19)
        Me.cbo_sector.Name = "cbo_sector"
        Me.cbo_sector.Size = New System.Drawing.Size(130, 21)
        Me.cbo_sector.TabIndex = 2
        '
        'dgvColaboradores
        '
        Me.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColaboradores.Location = New System.Drawing.Point(8, 46)
        Me.dgvColaboradores.Name = "dgvColaboradores"
        Me.dgvColaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvColaboradores.Size = New System.Drawing.Size(734, 174)
        Me.dgvColaboradores.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sector"
        '
        'btnGenerar_Informe
        '
        Me.btnGenerar_Informe.Location = New System.Drawing.Point(184, 459)
        Me.btnGenerar_Informe.Name = "btnGenerar_Informe"
        Me.btnGenerar_Informe.Size = New System.Drawing.Size(108, 33)
        Me.btnGenerar_Informe.TabIndex = 35
        Me.btnGenerar_Informe.Text = "Generar Informe"
        Me.btnGenerar_Informe.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvTotalesMensuales)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(748, 204)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tiempos totales por mes"
        '
        'dgvTotalesMensuales
        '
        Me.dgvTotalesMensuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotalesMensuales.Location = New System.Drawing.Point(8, 19)
        Me.dgvTotalesMensuales.Name = "dgvTotalesMensuales"
        Me.dgvTotalesMensuales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTotalesMensuales.Size = New System.Drawing.Size(734, 174)
        Me.dgvTotalesMensuales.TabIndex = 6
        '
        'btnTotales_por_Dia
        '
        Me.btnTotales_por_Dia.Location = New System.Drawing.Point(496, 459)
        Me.btnTotales_por_Dia.Name = "btnTotales_por_Dia"
        Me.btnTotales_por_Dia.Size = New System.Drawing.Size(179, 33)
        Me.btnTotales_por_Dia.TabIndex = 3
        Me.btnTotales_por_Dia.Text = "Totales por Día por Colaborador"
        Me.btnTotales_por_Dia.UseVisualStyleBackColor = True
        '
        'btn_Totales_Mensuales_por_Colaborador
        '
        Me.btn_Totales_Mensuales_por_Colaborador.Location = New System.Drawing.Point(298, 459)
        Me.btn_Totales_Mensuales_por_Colaborador.Name = "btn_Totales_Mensuales_por_Colaborador"
        Me.btn_Totales_Mensuales_por_Colaborador.Size = New System.Drawing.Size(192, 33)
        Me.btn_Totales_Mensuales_por_Colaborador.TabIndex = 41
        Me.btn_Totales_Mensuales_por_Colaborador.Text = "Totales Mensuales por Colaborador"
        Me.btn_Totales_Mensuales_por_Colaborador.UseVisualStyleBackColor = True
        '
        'frm_Generar_Informe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(772, 504)
        Me.Controls.Add(Me.btn_Totales_Mensuales_por_Colaborador)
        Me.Controls.Add(Me.btnTotales_por_Dia)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupListadoTareas)
        Me.Controls.Add(Me.btnGenerar_Informe)
        Me.Name = "frm_Generar_Informe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Informe"
        Me.GroupListadoTareas.ResumeLayout(False)
        Me.GroupListadoTareas.PerformLayout()
        CType(Me.dgvColaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvTotalesMensuales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupListadoTareas As System.Windows.Forms.GroupBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cbo_sector As System.Windows.Forms.ComboBox
    Friend WithEvents dgvColaboradores As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGenerar_Informe As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTotalesMensuales As System.Windows.Forms.DataGridView
    Friend WithEvents btnTotales_por_Dia As System.Windows.Forms.Button
    Friend WithEvents btn_Totales_Mensuales_por_Colaborador As System.Windows.Forms.Button
End Class
