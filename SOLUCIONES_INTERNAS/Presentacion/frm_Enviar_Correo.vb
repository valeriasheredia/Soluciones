Public Class frm_Enviar_Correo

    Private Sub BtnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnviar.Click
        enviarCorreo(txtEmisor.Text, txtPassword.Text, rtbMensaje.Text, txtAsunto.Text, txtReceptor.Text, txtRutaArchivo.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                txtRutaArchivo.Text = Me.OpenFileDialog1.FileName
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class