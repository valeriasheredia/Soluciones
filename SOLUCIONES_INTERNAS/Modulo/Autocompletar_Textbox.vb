Imports System.Data.Sql
Imports System.Data.SqlClient


Module Autocompletar_Textbox
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter

    Dim datacontext As New DataS_Interno

    Sub abrir()
        Try
            'USAR SIEMPRE LA CONEXION DEL APPCONFIG, IGUAL QUE EN LOS DATACLASES
            conexiones = New SqlConnection(SOLUCIONES_INTERNAS.My.Settings.SOLUCIONES_INTERNASConnectionString)
            'conexiones = New SqlConnection("Data Source=SV-PLANET-01;Initial Catalog=SOLUCIONES_INTERNAS;Persist Security Info=True;User ID=vheredia;Password=heredia")

            conexiones.Open()
            ' MsgBox("Conexion exitosa", MsgBoxStyle.Information, "Se ha conectado correctamente") '
        Catch ex As Exception
            MsgBox("Error al realizar la conexion" & ex.Message, MsgBoxStyle.Critical, "Error de conexion")
            conexiones.Close() 'Cierra la conexion'
        End Try
    End Sub

    Sub autoCompletarTexbox(ByVal campoTexto As TextBox)
        Try
            enunciado = New SqlCommand("select CLI_razon_social from cliente", conexiones)
            'Dim enunciado = From c In datacontext.CLIENTE Select c.CLI_razon_social

            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("CLI_razon_social"))
            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
