<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Proceso2
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.groupLogistica = New System.Windows.Forms.GroupBox()
        Me.txt_descripc_logistica = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.groupTerminacion = New System.Windows.Forms.GroupBox()
        Me.txt_descripc_terminacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.groupGranFormato = New System.Windows.Forms.GroupBox()
        Me.txt_descripc_gran_formato = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.groupDigital = New System.Windows.Forms.GroupBox()
        Me.txt_descripc_digital = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.groupOffSet = New System.Windows.Forms.GroupBox()
        Me.txt_descripc_offset = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id_detalle_orden = New System.Windows.Forms.TextBox()
        Me.groupLogistica.SuspendLayout()
        Me.groupTerminacion.SuspendLayout()
        Me.groupGranFormato.SuspendLayout()
        Me.groupDigital.SuspendLayout()
        Me.groupOffSet.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(232, 471)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(313, 471)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'groupLogistica
        '
        Me.groupLogistica.Controls.Add(Me.txt_descripc_logistica)
        Me.groupLogistica.Controls.Add(Me.Label5)
        Me.groupLogistica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupLogistica.Location = New System.Drawing.Point(12, 377)
        Me.groupLogistica.Name = "groupLogistica"
        Me.groupLogistica.Size = New System.Drawing.Size(376, 88)
        Me.groupLogistica.TabIndex = 11
        Me.groupLogistica.TabStop = False
        Me.groupLogistica.Text = "Logística"
        '
        'txt_descripc_logistica
        '
        Me.txt_descripc_logistica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripc_logistica.Location = New System.Drawing.Point(79, 19)
        Me.txt_descripc_logistica.MaxLength = 250
        Me.txt_descripc_logistica.Multiline = True
        Me.txt_descripc_logistica.Name = "txt_descripc_logistica"
        Me.txt_descripc_logistica.Size = New System.Drawing.Size(281, 54)
        Me.txt_descripc_logistica.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Descripción"
        '
        'groupTerminacion
        '
        Me.groupTerminacion.Controls.Add(Me.txt_descripc_terminacion)
        Me.groupTerminacion.Controls.Add(Me.Label4)
        Me.groupTerminacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupTerminacion.Location = New System.Drawing.Point(12, 285)
        Me.groupTerminacion.Name = "groupTerminacion"
        Me.groupTerminacion.Size = New System.Drawing.Size(376, 86)
        Me.groupTerminacion.TabIndex = 10
        Me.groupTerminacion.TabStop = False
        Me.groupTerminacion.Text = "Terminación"
        '
        'txt_descripc_terminacion
        '
        Me.txt_descripc_terminacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripc_terminacion.Location = New System.Drawing.Point(79, 19)
        Me.txt_descripc_terminacion.MaxLength = 250
        Me.txt_descripc_terminacion.Multiline = True
        Me.txt_descripc_terminacion.Name = "txt_descripc_terminacion"
        Me.txt_descripc_terminacion.Size = New System.Drawing.Size(281, 54)
        Me.txt_descripc_terminacion.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Descripción"
        '
        'groupGranFormato
        '
        Me.groupGranFormato.Controls.Add(Me.txt_descripc_gran_formato)
        Me.groupGranFormato.Controls.Add(Me.Label3)
        Me.groupGranFormato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupGranFormato.Location = New System.Drawing.Point(12, 193)
        Me.groupGranFormato.Name = "groupGranFormato"
        Me.groupGranFormato.Size = New System.Drawing.Size(376, 86)
        Me.groupGranFormato.TabIndex = 9
        Me.groupGranFormato.TabStop = False
        Me.groupGranFormato.Text = "Gran Formato"
        '
        'txt_descripc_gran_formato
        '
        Me.txt_descripc_gran_formato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripc_gran_formato.Location = New System.Drawing.Point(79, 19)
        Me.txt_descripc_gran_formato.MaxLength = 250
        Me.txt_descripc_gran_formato.Multiline = True
        Me.txt_descripc_gran_formato.Name = "txt_descripc_gran_formato"
        Me.txt_descripc_gran_formato.Size = New System.Drawing.Size(281, 54)
        Me.txt_descripc_gran_formato.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Descripción"
        '
        'groupDigital
        '
        Me.groupDigital.Controls.Add(Me.txt_descripc_digital)
        Me.groupDigital.Controls.Add(Me.Label2)
        Me.groupDigital.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupDigital.Location = New System.Drawing.Point(12, 103)
        Me.groupDigital.Name = "groupDigital"
        Me.groupDigital.Size = New System.Drawing.Size(376, 84)
        Me.groupDigital.TabIndex = 8
        Me.groupDigital.TabStop = False
        Me.groupDigital.Text = "Digital"
        '
        'txt_descripc_digital
        '
        Me.txt_descripc_digital.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripc_digital.Location = New System.Drawing.Point(79, 19)
        Me.txt_descripc_digital.MaxLength = 250
        Me.txt_descripc_digital.Multiline = True
        Me.txt_descripc_digital.Name = "txt_descripc_digital"
        Me.txt_descripc_digital.Size = New System.Drawing.Size(281, 54)
        Me.txt_descripc_digital.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripción"
        '
        'groupOffSet
        '
        Me.groupOffSet.Controls.Add(Me.txt_descripc_offset)
        Me.groupOffSet.Controls.Add(Me.Label1)
        Me.groupOffSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupOffSet.Location = New System.Drawing.Point(12, 12)
        Me.groupOffSet.Name = "groupOffSet"
        Me.groupOffSet.Size = New System.Drawing.Size(376, 85)
        Me.groupOffSet.TabIndex = 7
        Me.groupOffSet.TabStop = False
        Me.groupOffSet.Text = "OffSet"
        '
        'txt_descripc_offset
        '
        Me.txt_descripc_offset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripc_offset.Location = New System.Drawing.Point(79, 19)
        Me.txt_descripc_offset.MaxLength = 250
        Me.txt_descripc_offset.Multiline = True
        Me.txt_descripc_offset.Name = "txt_descripc_offset"
        Me.txt_descripc_offset.Size = New System.Drawing.Size(281, 54)
        Me.txt_descripc_offset.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripción"
        '
        'txt_id_detalle_orden
        '
        Me.txt_id_detalle_orden.Location = New System.Drawing.Point(126, 473)
        Me.txt_id_detalle_orden.Name = "txt_id_detalle_orden"
        Me.txt_id_detalle_orden.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_detalle_orden.TabIndex = 14
        '
        'frm_Proceso2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 501)
        Me.Controls.Add(Me.txt_id_detalle_orden)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.groupLogistica)
        Me.Controls.Add(Me.groupTerminacion)
        Me.Controls.Add(Me.groupGranFormato)
        Me.Controls.Add(Me.groupDigital)
        Me.Controls.Add(Me.groupOffSet)
        Me.Name = "frm_Proceso2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Proceso2"
        Me.groupLogistica.ResumeLayout(False)
        Me.groupLogistica.PerformLayout()
        Me.groupTerminacion.ResumeLayout(False)
        Me.groupTerminacion.PerformLayout()
        Me.groupGranFormato.ResumeLayout(False)
        Me.groupGranFormato.PerformLayout()
        Me.groupDigital.ResumeLayout(False)
        Me.groupDigital.PerformLayout()
        Me.groupOffSet.ResumeLayout(False)
        Me.groupOffSet.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents groupLogistica As System.Windows.Forms.GroupBox
    Friend WithEvents txt_descripc_logistica As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents groupTerminacion As System.Windows.Forms.GroupBox
    Friend WithEvents txt_descripc_terminacion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents groupGranFormato As System.Windows.Forms.GroupBox
    Friend WithEvents txt_descripc_gran_formato As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents groupDigital As System.Windows.Forms.GroupBox
    Friend WithEvents txt_descripc_digital As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents groupOffSet As System.Windows.Forms.GroupBox
    Friend WithEvents txt_descripc_offset As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_id_detalle_orden As System.Windows.Forms.TextBox
End Class
