Imports System.Text
Imports System.Globalization

Public Class frm_Sugerencia
    Dim datacontext As New DataS_Interno

    Private Sub frm_Sugerencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        txt_id_sugerencia.Visible = False
    End Sub

    Private Sub btnEnviar_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviar.Click
        Try
            If txt_titulo.Text.Length = 0 Then
                MsgBox("Debe completar el Título")
                txt_titulo.Focus()
                Exit Sub
            End If
            Dim sug = New SUGERENCIA
            sug.SUG_fecha = StrConv(dtpFecha.Text, VbStrConv.ProperCase)
            sug.SUG_titulo = StrConv(txt_titulo.Text, VbStrConv.ProperCase)
            sug.SUG_sugerencia = txt_sugerencia.Text

            datacontext.SUGERENCIA.InsertOnSubmit(sug)
            datacontext.SubmitChanges()

            MsgBox("La Sugerencia se ha enviado correctamente!!!")
            Me.Close()
        Catch ex As Exception
            MsgBox("La Sugerencia no pudo ser enviada, comunicarse con el administrador")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    ''--------------------------------------------------------------------------------------------
    ''Función para quitar acentos de una cadena de texto
    ''--------------------------------------------------------------------------------------------
    'Public Function fncQuitarAcentos(ByVal strNombre As String) As String
    '    Const conAcentos = "áàäâÁÀÄÂéèëêÉÈËÊíìïîÍÌÏÎóòöôÓÒÖÔúùüûÚÙÜÛýÿÝ"
    '    Const sinAcentos = "aaaaAAAAeeeeEEEEiiiiIIIIooooOOOOuuuuUUUUyyY"
    '    Dim i As Integer
    '    For i = Len(conAcentos) To 1 Step -1
    '        strNombre = Replace(strNombre, Mid(conAcentos, i, 1), Mid(sinAcentos, i, 1))
    '    Next
    '    fncQuitarAcentos = strNombre
    'End Function
    '----------------------------------------------------------------------------------------------


    'LEANDRO TUTINI
    'Private Shared Function RemoveDiacritics(stIn As String) As String
    '    Dim stFormD As String = stIn.Normalize(NormalizationForm.FormD)
    '    Dim sb As New StringBuilder()

    '    For ich As Integer = 0 To stFormD.Length - 1
    '        Dim uc As UnicodeCategory = CharUnicodeInfo.GetUnicodeCategory(stFormD(ich))
    '        If uc <> UnicodeCategory.NonSpacingMark Then
    '            sb.Append(stFormD(ich))
    '        End If
    '    Next
    '    Return (sb.ToString().Normalize(NormalizationForm.FormC))
    'End Function
    '----------------------------------------------------------------------------------------------



    'Public Function remplaceCharacter(ByVal _text As String) As String

    '    Dim ConAcento() As String = {"á", "é", "í", "ó", "ú", "Á", "É", "Í", "Ó", "Ú"}
    '    Dim SinAcento() As String = {"a", "e", "i", "o", "u", "A", "E", "I", "O", "U"}
    '    Dim text As String = _text

    '    For i As Integer = 0 To ConAcento.Length - 1
    '        text = Replace(text, ConAcento(i), SinAcento(i))
    '    Next
    '    Return text
    'End Function
    '---------------------------------------------------------------------------------------------
End Class