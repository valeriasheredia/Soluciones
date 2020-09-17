<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Sugerencia
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
        Me.GroupNuevoColaborador = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_sugerencia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.txt_id_sugerencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupNuevoColaborador.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupNuevoColaborador
        '
        Me.GroupNuevoColaborador.Controls.Add(Me.Label5)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label4)
        Me.GroupNuevoColaborador.Controls.Add(Me.dtpFecha)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label62)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label3)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label6)
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_sugerencia)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label9)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnCancelar)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnEnviar)
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_titulo)
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_id_sugerencia)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label2)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label1)
        Me.GroupNuevoColaborador.Location = New System.Drawing.Point(12, 12)
        Me.GroupNuevoColaborador.Name = "GroupNuevoColaborador"
        Me.GroupNuevoColaborador.Size = New System.Drawing.Size(498, 445)
        Me.GroupNuevoColaborador.TabIndex = 5
        Me.GroupNuevoColaborador.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(9, 423)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "La sugerencia es anónima"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 452)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 50
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(405, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpFecha.TabIndex = 48
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(362, 22)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(37, 13)
        Me.Label62.TabIndex = 49
        Me.Label62.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(260, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(242, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "*"
        '
        'txt_sugerencia
        '
        Me.txt_sugerencia.Location = New System.Drawing.Point(12, 113)
        Me.txt_sugerencia.MaxLength = 500
        Me.txt_sugerencia.Multiline = True
        Me.txt_sugerencia.Name = "txt_sugerencia"
        Me.txt_sugerencia.Size = New System.Drawing.Size(475, 281)
        Me.txt_sugerencia.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(201, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Sugerencia"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(409, 403)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(328, 403)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 33)
        Me.btnEnviar.TabIndex = 10
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'txt_titulo
        '
        Me.txt_titulo.Location = New System.Drawing.Point(12, 62)
        Me.txt_titulo.MaxLength = 50
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(475, 20)
        Me.txt_titulo.TabIndex = 1
        '
        'txt_id_sugerencia
        '
        Me.txt_id_sugerencia.Location = New System.Drawing.Point(129, 23)
        Me.txt_id_sugerencia.Name = "txt_id_sugerencia"
        Me.txt_id_sugerencia.Size = New System.Drawing.Size(23, 20)
        Me.txt_id_sugerencia.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Título"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_sugerencia"
        '
        'frm_Sugerencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 469)
        Me.Controls.Add(Me.GroupNuevoColaborador)
        Me.Name = "frm_Sugerencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sugerencias"
        Me.GroupNuevoColaborador.ResumeLayout(False)
        Me.GroupNuevoColaborador.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupNuevoColaborador As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_sugerencia As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents txt_titulo As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_sugerencia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
