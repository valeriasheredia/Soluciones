<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Listado_Retrabajo
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
        Me.GroupListadoReTrabajos = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtMes = New System.Windows.Forms.RadioButton()
        Me.rbtNumeroOrden = New System.Windows.Forms.RadioButton()
        Me.cboBuscar_Mes = New System.Windows.Forms.ComboBox()
        Me.txt_Buscar_ReTrabajo = New System.Windows.Forms.TextBox()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnExportarPDF = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblTotal_Retrabajo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar_ReTrabajo = New System.Windows.Forms.Button()
        Me.dgvLista_ReTrabajos = New System.Windows.Forms.DataGridView()
        Me.GroupListadoReTrabajos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvLista_ReTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupListadoReTrabajos
        '
        Me.GroupListadoReTrabajos.Controls.Add(Me.GroupBox1)
        Me.GroupListadoReTrabajos.Controls.Add(Me.btnVer)
        Me.GroupListadoReTrabajos.Controls.Add(Me.btnExportarPDF)
        Me.GroupListadoReTrabajos.Controls.Add(Me.btnCancelar)
        Me.GroupListadoReTrabajos.Controls.Add(Me.lblTotal_Retrabajo)
        Me.GroupListadoReTrabajos.Controls.Add(Me.Label5)
        Me.GroupListadoReTrabajos.Controls.Add(Me.btnEliminar_ReTrabajo)
        Me.GroupListadoReTrabajos.Controls.Add(Me.dgvLista_ReTrabajos)
        Me.GroupListadoReTrabajos.Location = New System.Drawing.Point(12, 12)
        Me.GroupListadoReTrabajos.Name = "GroupListadoReTrabajos"
        Me.GroupListadoReTrabajos.Size = New System.Drawing.Size(901, 352)
        Me.GroupListadoReTrabajos.TabIndex = 6
        Me.GroupListadoReTrabajos.TabStop = False
        Me.GroupListadoReTrabajos.Text = "Listado de ReTrabajos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtMes)
        Me.GroupBox1.Controls.Add(Me.rbtNumeroOrden)
        Me.GroupBox1.Controls.Add(Me.cboBuscar_Mes)
        Me.GroupBox1.Controls.Add(Me.txt_Buscar_ReTrabajo)
        Me.GroupBox1.Location = New System.Drawing.Point(222, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 54)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'rbtMes
        '
        Me.rbtMes.AutoSize = True
        Me.rbtMes.Location = New System.Drawing.Point(274, 26)
        Me.rbtMes.Name = "rbtMes"
        Me.rbtMes.Size = New System.Drawing.Size(45, 17)
        Me.rbtMes.TabIndex = 11
        Me.rbtMes.TabStop = True
        Me.rbtMes.Text = "Mes"
        Me.rbtMes.UseVisualStyleBackColor = True
        '
        'rbtNumeroOrden
        '
        Me.rbtNumeroOrden.AutoSize = True
        Me.rbtNumeroOrden.Location = New System.Drawing.Point(12, 26)
        Me.rbtNumeroOrden.Name = "rbtNumeroOrden"
        Me.rbtNumeroOrden.Size = New System.Drawing.Size(94, 17)
        Me.rbtNumeroOrden.TabIndex = 10
        Me.rbtNumeroOrden.TabStop = True
        Me.rbtNumeroOrden.Text = "Número Orden"
        Me.rbtNumeroOrden.UseVisualStyleBackColor = True
        '
        'cboBuscar_Mes
        '
        Me.cboBuscar_Mes.FormattingEnabled = True
        Me.cboBuscar_Mes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboBuscar_Mes.Location = New System.Drawing.Point(325, 25)
        Me.cboBuscar_Mes.Name = "cboBuscar_Mes"
        Me.cboBuscar_Mes.Size = New System.Drawing.Size(139, 21)
        Me.cboBuscar_Mes.TabIndex = 7
        '
        'txt_Buscar_ReTrabajo
        '
        Me.txt_Buscar_ReTrabajo.Location = New System.Drawing.Point(112, 25)
        Me.txt_Buscar_ReTrabajo.Name = "txt_Buscar_ReTrabajo"
        Me.txt_Buscar_ReTrabajo.Size = New System.Drawing.Size(139, 20)
        Me.txt_Buscar_ReTrabajo.TabIndex = 2
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(650, 320)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(75, 23)
        Me.btnVer.TabIndex = 8
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'btnExportarPDF
        '
        Me.btnExportarPDF.Location = New System.Drawing.Point(543, 320)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Size = New System.Drawing.Size(101, 23)
        Me.btnExportarPDF.TabIndex = 7
        Me.btnExportarPDF.Text = "Exportar a PDF"
        Me.btnExportarPDF.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(812, 320)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblTotal_Retrabajo
        '
        Me.lblTotal_Retrabajo.AutoSize = True
        Me.lblTotal_Retrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal_Retrabajo.Location = New System.Drawing.Point(116, 323)
        Me.lblTotal_Retrabajo.Name = "lblTotal_Retrabajo"
        Me.lblTotal_Retrabajo.Size = New System.Drawing.Size(2, 15)
        Me.lblTotal_Retrabajo.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total de ReTrabajos"
        '
        'btnEliminar_ReTrabajo
        '
        Me.btnEliminar_ReTrabajo.Location = New System.Drawing.Point(731, 320)
        Me.btnEliminar_ReTrabajo.Name = "btnEliminar_ReTrabajo"
        Me.btnEliminar_ReTrabajo.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar_ReTrabajo.TabIndex = 3
        Me.btnEliminar_ReTrabajo.Text = "Eliminar"
        Me.btnEliminar_ReTrabajo.UseVisualStyleBackColor = True
        '
        'dgvLista_ReTrabajos
        '
        Me.dgvLista_ReTrabajos.AllowUserToAddRows = False
        Me.dgvLista_ReTrabajos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvLista_ReTrabajos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvLista_ReTrabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_ReTrabajos.Location = New System.Drawing.Point(11, 79)
        Me.dgvLista_ReTrabajos.Name = "dgvLista_ReTrabajos"
        Me.dgvLista_ReTrabajos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_ReTrabajos.Size = New System.Drawing.Size(874, 233)
        Me.dgvLista_ReTrabajos.TabIndex = 0
        '
        'frm_Listado_Retrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 376)
        Me.Controls.Add(Me.GroupListadoReTrabajos)
        Me.Name = "frm_Listado_Retrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Retrabajos"
        Me.GroupListadoReTrabajos.ResumeLayout(False)
        Me.GroupListadoReTrabajos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvLista_ReTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupListadoReTrabajos As System.Windows.Forms.GroupBox
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents btnExportarPDF As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblTotal_Retrabajo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_ReTrabajo As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_ReTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_ReTrabajos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtMes As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNumeroOrden As System.Windows.Forms.RadioButton
    Friend WithEvents cboBuscar_Mes As System.Windows.Forms.ComboBox
End Class
