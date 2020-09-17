<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Sector
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
        Me.GroupListadoSectores = New System.Windows.Forms.GroupBox()
        Me.btn_informe_sector = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar_Sector = New System.Windows.Forms.Button()
        Me.txt_Buscar_Sector = New System.Windows.Forms.TextBox()
        Me.dgvLista_Sector = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupNuevoSector = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelar_Sector = New System.Windows.Forms.Button()
        Me.btnActualizar_Sector = New System.Windows.Forms.Button()
        Me.btnGuardar_Sector = New System.Windows.Forms.Button()
        Me.btnNuevo_Sector = New System.Windows.Forms.Button()
        Me.txt_nombre_sector = New System.Windows.Forms.TextBox()
        Me.txt_id_sector = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupListadoSectores.SuspendLayout()
        CType(Me.dgvLista_Sector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupNuevoSector.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupListadoSectores
        '
        Me.GroupListadoSectores.Controls.Add(Me.btn_informe_sector)
        Me.GroupListadoSectores.Controls.Add(Me.Label6)
        Me.GroupListadoSectores.Controls.Add(Me.Label8)
        Me.GroupListadoSectores.Controls.Add(Me.Label5)
        Me.GroupListadoSectores.Controls.Add(Me.btnEliminar_Sector)
        Me.GroupListadoSectores.Controls.Add(Me.txt_Buscar_Sector)
        Me.GroupListadoSectores.Controls.Add(Me.dgvLista_Sector)
        Me.GroupListadoSectores.Controls.Add(Me.Label4)
        Me.GroupListadoSectores.Location = New System.Drawing.Point(11, 121)
        Me.GroupListadoSectores.Name = "GroupListadoSectores"
        Me.GroupListadoSectores.Size = New System.Drawing.Size(359, 253)
        Me.GroupListadoSectores.TabIndex = 5
        Me.GroupListadoSectores.TabStop = False
        Me.GroupListadoSectores.Text = "Listado de Sectores"
        '
        'btn_informe_sector
        '
        Me.btn_informe_sector.Location = New System.Drawing.Point(143, 224)
        Me.btn_informe_sector.Name = "btn_informe_sector"
        Me.btn_informe_sector.Size = New System.Drawing.Size(68, 22)
        Me.btn_informe_sector.TabIndex = 8
        Me.btn_informe_sector.Text = "Eliminar"
        Me.btn_informe_sector.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(327, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(2, 15)
        Me.Label6.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(18, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "(Campo Requerido)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total de Sectores"
        '
        'btnEliminar_Sector
        '
        Me.btnEliminar_Sector.Location = New System.Drawing.Point(273, 19)
        Me.btnEliminar_Sector.Name = "btnEliminar_Sector"
        Me.btnEliminar_Sector.Size = New System.Drawing.Size(75, 33)
        Me.btnEliminar_Sector.TabIndex = 6
        Me.btnEliminar_Sector.Text = "Eliminar"
        Me.btnEliminar_Sector.UseVisualStyleBackColor = True
        '
        'txt_Buscar_Sector
        '
        Me.txt_Buscar_Sector.Location = New System.Drawing.Point(92, 26)
        Me.txt_Buscar_Sector.Name = "txt_Buscar_Sector"
        Me.txt_Buscar_Sector.Size = New System.Drawing.Size(167, 20)
        Me.txt_Buscar_Sector.TabIndex = 5
        '
        'dgvLista_Sector
        '
        Me.dgvLista_Sector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Sector.Location = New System.Drawing.Point(11, 58)
        Me.dgvLista_Sector.Name = "dgvLista_Sector"
        Me.dgvLista_Sector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Sector.Size = New System.Drawing.Size(337, 166)
        Me.dgvLista_Sector.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ingrese sector"
        '
        'GroupNuevoSector
        '
        Me.GroupNuevoSector.Controls.Add(Me.Label3)
        Me.GroupNuevoSector.Controls.Add(Me.btnCancelar_Sector)
        Me.GroupNuevoSector.Controls.Add(Me.btnActualizar_Sector)
        Me.GroupNuevoSector.Controls.Add(Me.btnGuardar_Sector)
        Me.GroupNuevoSector.Controls.Add(Me.btnNuevo_Sector)
        Me.GroupNuevoSector.Controls.Add(Me.txt_nombre_sector)
        Me.GroupNuevoSector.Controls.Add(Me.txt_id_sector)
        Me.GroupNuevoSector.Controls.Add(Me.Label2)
        Me.GroupNuevoSector.Controls.Add(Me.Label1)
        Me.GroupNuevoSector.Location = New System.Drawing.Point(12, 12)
        Me.GroupNuevoSector.Name = "GroupNuevoSector"
        Me.GroupNuevoSector.Size = New System.Drawing.Size(359, 103)
        Me.GroupNuevoSector.TabIndex = 4
        Me.GroupNuevoSector.TabStop = False
        Me.GroupNuevoSector.Text = "Nueva Sector"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(66, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "*"
        '
        'btnCancelar_Sector
        '
        Me.btnCancelar_Sector.Location = New System.Drawing.Point(272, 64)
        Me.btnCancelar_Sector.Name = "btnCancelar_Sector"
        Me.btnCancelar_Sector.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar_Sector.TabIndex = 3
        Me.btnCancelar_Sector.Text = "Cancelar"
        Me.btnCancelar_Sector.UseVisualStyleBackColor = True
        '
        'btnActualizar_Sector
        '
        Me.btnActualizar_Sector.Location = New System.Drawing.Point(191, 64)
        Me.btnActualizar_Sector.Name = "btnActualizar_Sector"
        Me.btnActualizar_Sector.Size = New System.Drawing.Size(75, 33)
        Me.btnActualizar_Sector.TabIndex = 8
        Me.btnActualizar_Sector.Text = "Actualizar"
        Me.btnActualizar_Sector.UseVisualStyleBackColor = True
        '
        'btnGuardar_Sector
        '
        Me.btnGuardar_Sector.Location = New System.Drawing.Point(110, 64)
        Me.btnGuardar_Sector.Name = "btnGuardar_Sector"
        Me.btnGuardar_Sector.Size = New System.Drawing.Size(75, 33)
        Me.btnGuardar_Sector.TabIndex = 2
        Me.btnGuardar_Sector.Text = "Guardar"
        Me.btnGuardar_Sector.UseVisualStyleBackColor = True
        '
        'btnNuevo_Sector
        '
        Me.btnNuevo_Sector.Location = New System.Drawing.Point(29, 64)
        Me.btnNuevo_Sector.Name = "btnNuevo_Sector"
        Me.btnNuevo_Sector.Size = New System.Drawing.Size(75, 33)
        Me.btnNuevo_Sector.TabIndex = 4
        Me.btnNuevo_Sector.Text = "Nuevo"
        Me.btnNuevo_Sector.UseVisualStyleBackColor = True
        '
        'txt_nombre_sector
        '
        Me.txt_nombre_sector.Location = New System.Drawing.Point(83, 25)
        Me.txt_nombre_sector.Name = "txt_nombre_sector"
        Me.txt_nombre_sector.Size = New System.Drawing.Size(264, 20)
        Me.txt_nombre_sector.TabIndex = 1
        '
        'txt_id_sector
        '
        Me.txt_id_sector.Location = New System.Drawing.Point(3, 56)
        Me.txt_id_sector.Name = "txt_id_sector"
        Me.txt_id_sector.Size = New System.Drawing.Size(10, 20)
        Me.txt_id_sector.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_sector"
        '
        'frm_Sector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 383)
        Me.Controls.Add(Me.GroupListadoSectores)
        Me.Controls.Add(Me.GroupNuevoSector)
        Me.Name = "frm_Sector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sector"
        Me.GroupListadoSectores.ResumeLayout(False)
        Me.GroupListadoSectores.PerformLayout()
        CType(Me.dgvLista_Sector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupNuevoSector.ResumeLayout(False)
        Me.GroupNuevoSector.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupListadoSectores As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Sector As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_Sector As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Sector As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupNuevoSector As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar_Sector As System.Windows.Forms.Button
    Friend WithEvents btnActualizar_Sector As System.Windows.Forms.Button
    Friend WithEvents btnGuardar_Sector As System.Windows.Forms.Button
    Friend WithEvents btnNuevo_Sector As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_sector As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_sector As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_informe_sector As System.Windows.Forms.Button
End Class
