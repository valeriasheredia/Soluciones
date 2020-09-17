Public Class frm_gestion_usuarios

    Dim datacontext As New DataS_Interno

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim buscausu = (From usu In datacontext.USUARIO Select usu.USU_usuario Where USU_usuario = txt_usuario.Text).Any
            If buscausu = True Then
                MsgBox("El usuario ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If
            If txt_usuario.Text.Length = 0 Or txt_nueva_contraseña.Text.Length = 0 Or txt_repetir_contraseña.Text.Length = 0 Or cbo_perfil.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If
            If txt_nueva_contraseña.Text <> txt_repetir_contraseña.Text Then
                MsgBox("Las contraseñas no coinciden")
                txt_nueva_contraseña.Clear()
                txt_repetir_contraseña.Clear()
                Exit Sub
            Else
                Dim usu = New USUARIO
                usu.USU_usuario = txt_usuario.Text
                usu.USU_contraseña = txt_nueva_contraseña.Text
                usu.USU_perfil = cbo_perfil.Text

                datacontext.USUARIO.InsertOnSubmit(usu)
                datacontext.SubmitChanges()
                MsgBox("El usuario se ha creado correctamente", vbInformation)
                limpiarcontroles()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("El usuario NO fue creado")
            limpiarcontroles()
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        If txt_nueva_contraseña.Text.Length = 0 Or txt_repetir_contraseña.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        If txt_nueva_contraseña.Text = txt_repetir_contraseña.Text Then
            Try
                Dim Actualizarcontraseña = (From P In datacontext.USUARIO Where P.USU_usuario = (txt_usuario.Text)).ToList()(0)

                Actualizarcontraseña.USU_contraseña = txt_nueva_contraseña.Text
                Actualizarcontraseña.USU_perfil = cbo_perfil.Text
                datacontext.SubmitChanges()
                MsgBox("Los datos se han modificado correctamente")
                frm_ingreso.limpiarcontroles()
                Me.Close()
            Catch ex As Exception
                MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar usuario")
                frm_ingreso.limpiarcontroles()
                Me.Close()
            End Try
        Else
            MsgBox("Las contraseñas no coinciden")
            txt_nueva_contraseña.Clear()
            txt_repetir_contraseña.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        frm_ingreso.limpiarcontroles()
        Me.Close()
        Me.Dispose()
    End Sub

    Sub limpiarcontroles()
        txt_nueva_contraseña.Clear()
        txt_usuario.Clear()
        cbo_perfil.SelectedIndex = -1
        txt_repetir_contraseña.Clear()
    End Sub

    Private Sub frm_gestion_usuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_usuario.Focus()
    End Sub

    Private Sub frm_gestion_usuarios_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class