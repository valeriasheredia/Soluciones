<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Movimiento_Orden
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupListadoPiezas = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExportarPDF = New System.Windows.Forms.Button()
        Me.txt_Buscar_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.dgvMovimiento_Orden = New System.Windows.Forms.DataGridView()
        Me.GroupListadoPiezas.SuspendLayout()
        CType(Me.dgvMovimiento_Orden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupListadoPiezas
        '
        Me.GroupListadoPiezas.Controls.Add(Me.Label2)
        Me.GroupListadoPiezas.Controls.Add(Me.Label1)
        Me.GroupListadoPiezas.Controls.Add(Me.btnBuscar)
        Me.GroupListadoPiezas.Controls.Add(Me.Label4)
        Me.GroupListadoPiezas.Controls.Add(Me.btnCancelar)
        Me.GroupListadoPiezas.Controls.Add(Me.btnExportarPDF)
        Me.GroupListadoPiezas.Controls.Add(Me.txt_Buscar_orden_trabajo)
        Me.GroupListadoPiezas.Controls.Add(Me.dgvMovimiento_Orden)
        Me.GroupListadoPiezas.Location = New System.Drawing.Point(12, 12)
        Me.GroupListadoPiezas.Name = "GroupListadoPiezas"
        Me.GroupListadoPiezas.Size = New System.Drawing.Size(959, 532)
        Me.GroupListadoPiezas.TabIndex = 30
        Me.GroupListadoPiezas.TabStop = False
        Me.GroupListadoPiezas.Text = "Movimiento de Ordenes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(430, 499)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(2, 15)
        Me.Label2.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 501)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Total consumido"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(611, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 26)
        Me.btnBuscar.TabIndex = 39
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(295, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Ingrese Número de Orden"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(830, 489)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(113, 33)
        Me.btnCancelar.TabIndex = 28
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExportarPDF
        '
        Me.btnExportarPDF.Location = New System.Drawing.Point(705, 489)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Size = New System.Drawing.Size(119, 33)
        Me.btnExportarPDF.TabIndex = 29
        Me.btnExportarPDF.Text = "Exportar Orden a PDF"
        Me.btnExportarPDF.UseVisualStyleBackColor = True
        '
        'txt_Buscar_orden_trabajo
        '
        Me.txt_Buscar_orden_trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Buscar_orden_trabajo.Location = New System.Drawing.Point(430, 21)
        Me.txt_Buscar_orden_trabajo.Name = "txt_Buscar_orden_trabajo"
        Me.txt_Buscar_orden_trabajo.Size = New System.Drawing.Size(175, 26)
        Me.txt_Buscar_orden_trabajo.TabIndex = 2
        '
        'dgvMovimiento_Orden
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovimiento_Orden.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMovimiento_Orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMovimiento_Orden.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMovimiento_Orden.Location = New System.Drawing.Point(18, 57)
        Me.dgvMovimiento_Orden.Name = "dgvMovimiento_Orden"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovimiento_Orden.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMovimiento_Orden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovimiento_Orden.Size = New System.Drawing.Size(925, 426)
        Me.dgvMovimiento_Orden.TabIndex = 0
        '
        'frm_Movimiento_Orden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 556)
        Me.Controls.Add(Me.GroupListadoPiezas)
        Me.Name = "frm_Movimiento_Orden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento de Ordenes"
        Me.GroupListadoPiezas.ResumeLayout(False)
        Me.GroupListadoPiezas.PerformLayout()
        CType(Me.dgvMovimiento_Orden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupListadoPiezas As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnExportarPDF As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents dgvMovimiento_Orden As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
