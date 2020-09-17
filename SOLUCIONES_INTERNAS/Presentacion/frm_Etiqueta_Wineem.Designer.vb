<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Etiqueta_Wineem
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiarEtiqueta = New System.Windows.Forms.Button()
        Me.btnGenerarEtiquetas = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnImportarExcel = New System.Windows.Forms.Button()
        Me.dgv_Etiquetas = New System.Windows.Forms.DataGridView()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_Etiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(15, 731)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "* (Campo Requerido)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(257, 731)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 15)
        Me.Label3.TabIndex = 37
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 731)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Cantidad de Etiquetas:"
        Me.Label2.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(642, 731)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(108, 33)
        Me.btnEliminar.TabIndex = 35
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnLimpiarEtiqueta
        '
        Me.btnLimpiarEtiqueta.Location = New System.Drawing.Point(756, 731)
        Me.btnLimpiarEtiqueta.Name = "btnLimpiarEtiqueta"
        Me.btnLimpiarEtiqueta.Size = New System.Drawing.Size(108, 33)
        Me.btnLimpiarEtiqueta.TabIndex = 34
        Me.btnLimpiarEtiqueta.Text = "Limpiar Campos"
        Me.btnLimpiarEtiqueta.UseVisualStyleBackColor = True
        '
        'btnGenerarEtiquetas
        '
        Me.btnGenerarEtiquetas.Location = New System.Drawing.Point(528, 731)
        Me.btnGenerarEtiquetas.Name = "btnGenerarEtiquetas"
        Me.btnGenerarEtiquetas.Size = New System.Drawing.Size(108, 33)
        Me.btnGenerarEtiquetas.TabIndex = 33
        Me.btnGenerarEtiquetas.Text = "Generar Etiquetas"
        Me.btnGenerarEtiquetas.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(870, 731)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 33)
        Me.btnCancelar.TabIndex = 32
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnImportarExcel)
        Me.GroupBox3.Controls.Add(Me.dgv_Etiquetas)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1142, 710)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        '
        'btnImportarExcel
        '
        Me.btnImportarExcel.Location = New System.Drawing.Point(421, 14)
        Me.btnImportarExcel.Name = "btnImportarExcel"
        Me.btnImportarExcel.Size = New System.Drawing.Size(273, 33)
        Me.btnImportarExcel.TabIndex = 25
        Me.btnImportarExcel.Text = "Importar Excel"
        Me.btnImportarExcel.UseVisualStyleBackColor = True
        '
        'dgv_Etiquetas
        '
        Me.dgv_Etiquetas.AllowUserToAddRows = False
        Me.dgv_Etiquetas.AllowUserToOrderColumns = True
        Me.dgv_Etiquetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_Etiquetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Etiquetas.Location = New System.Drawing.Point(5, 53)
        Me.dgv_Etiquetas.Name = "dgv_Etiquetas"
        Me.dgv_Etiquetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Etiquetas.Size = New System.Drawing.Size(1131, 642)
        Me.dgv_Etiquetas.TabIndex = 23
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(317, 741)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 39
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(1040, 731)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(108, 33)
        Me.btnAgregar.TabIndex = 40
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frm_Etiqueta_Wineem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 775)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiarEtiqueta)
        Me.Controls.Add(Me.btnGenerarEtiquetas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frm_Etiqueta_Wineem"
        Me.Text = "frm_Etiqueta_Wineem"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_Etiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiarEtiqueta As System.Windows.Forms.Button
    Friend WithEvents btnGenerarEtiquetas As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImportarExcel As System.Windows.Forms.Button
    Friend WithEvents dgv_Etiquetas As System.Windows.Forms.DataGridView
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class
