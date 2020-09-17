Public Class frm_ingreso
    Dim datacontext As New DataS_Interno
    'Variables para marcar los ingresos
    '   Dim flag_usuario, flag_colaborador, flag_vendedor, flag_cliente, flag_pieza, _
    ' flag_sector, flag_tarea, flag_producto, flag_orden, flag_retrabajo As String

    Public flaga = 0, flagb = 0, flagm = 0, flagalta = 0, flagbaja = 0

    Private Sub frm_ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_usuario.Focus()

        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = False 'alta vieja orden
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = False 'modificar vieja orden
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = False 'eliminar vieja orden
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(3).Visible = False 'consultar vieja orden

    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        DeshabilitarGeneral()
        HabilitarGeneral()

        'HABILITA SEGUN PERFIL USUARIO
        Try
            Dim Buscausuario = (From I In datacontext.USUARIO Where I.USU_usuario = (txt_usuario.Text) And I.USU_contraseña = (txt_contraseña.Text)).ToList()(0)

            Select Case Buscausuario.USU_perfil

                Case "ADMINISTRADOR"
                    frm_Principal.UsuarioToolStripMenuItem.Visible = True
                    Usuario(True, True, True)
                    Colaborador(True, True, True)
                    Vendedor(True, True, True)
                    Cliente(True, True, True)
                    Pieza(True, True, True)
                    Sector(True, True, True)
                    Tarea(True, True, True)
                    Producto(True, True, True, True, True)
                    ' Orden(True, True, True)
                    NuevaOrden(True, True, True)
                    Retrabajo(True, True)
                    Etiquetas(True)
                    Estadistica(True, True, True, True, True)
                    CorreoElectronico(True)
                    Despacho(True, True, True)
                    Empaque(True, True, True)
                    Ticket(True, True, True)

                Case "GERENCIA"
                    Usuario(False, False, False)
                    Colaborador(True, False, True)
                    Vendedor(True, False, True)
                    Cliente(True, False, True)
                    Pieza(True, True, True)
                    Sector(True, True, True)
                    Tarea(True, True, True)
                    Producto(True, True, True, True, True)
                    ' Orden(True, True, True)
                    NuevaOrden(True, True, True)
                    Retrabajo(True, True)
                    Etiquetas(False)
                    Estadistica(True, True, True, True, True)
                    CorreoElectronico(False)
                    Despacho(True, True, True)
                    Empaque(True, True, True)
                    Ticket(True, False, False)

                Case "SUPERVISOR"
                    Tarea(True, True, True)
                    Producto(False, False, False, True, True)
                    ' Orden(True, True, False)
                    NuevaOrden(True, True, False)
                    Retrabajo(True, True)
                    Etiquetas(False)
                    Estadistica(True, True, True, True, True)
                    Despacho(True, True, True)
                    Empaque(True, True, True)
                    Ticket(True, False, False)

                Case "COLABORADOR"
                    'HabilitarGeneral()
            End Select

            'HABILITA SEGUN PERMISOS ESPECIALES
            Dim contadorpermisos As Integer
            Dim Permiso_anterior As String = ""

            Dim permisos = (From A In datacontext.PERMISO Select A.PER_permiso, A.PER_abm, A.USU_id_usuario Where USU_id_usuario = Buscausuario.USU_id_usuario Order By PER_permiso).ToList

            contadorpermisos = permisos.Count

            If contadorpermisos > 0 Then
                For i = 0 To contadorpermisos - 1
                    If permisos.Item(i).PER_permiso <> Permiso_anterior Then
                        Permiso_anterior = permisos.Item(i).PER_permiso
                        flaga = 0
                        flagb = 0
                        flagm = 0
                        flagalta = 0
                        flagbaja = 0
                    End If
                    '-------------------USUARIO-----------------------'
                    If permisos.Item(i).PER_permiso = "USUARIO" Then
                        If permisos.Item(i).PER_abm = "A" Then
                            Usuario(True, flagm, flagb)
                            flaga = 1
                        End If
                        If permisos.Item(i).PER_abm = "M" Then
                            Usuario(flaga, True, flagb)
                            flagm = 1
                        End If
                        If permisos.Item(i).PER_abm = "B" Then
                            Usuario(flaga, flagm, True)
                            flagb = 1
                        End If
                    End If
                    '-----------------COLABORADOR----------------------'
                    If permisos.Item(i).PER_permiso = "COLABORADOR" Then
                        If permisos.Item(i).PER_abm = "A" Then
                            Colaborador(True, flagm, flagb)
                            flaga = 1
                        End If
                        If permisos.Item(i).PER_abm = "M" Then
                            Colaborador(flaga, True, flagb)
                            flagm = 1
                        End If
                        If permisos.Item(i).PER_abm = "B" Then
                            Colaborador(flaga, flagm, True)
                            flagb = 1
                        End If
                    End If
                    '-----------------VENDEDOR----------------------'
                    If permisos.Item(i).PER_permiso = "VENDEDOR" Then
                        If permisos.Item(i).PER_abm = "A" Then
                            Vendedor(True, flagm, flagb)
                            flaga = 1
                        End If
                        If permisos.Item(i).PER_abm = "M" Then
                            Vendedor(flaga, True, flagb)
                            flagm = 1
                        End If
                        If permisos.Item(i).PER_abm = "B" Then
                            Vendedor(flaga, flagm, True)
                            flagb = 1
                        End If
                    End If
                    '-----------------CLIENTE----------------------'
                    If permisos.Item(i).PER_permiso = "CLIENTE" Then
                        If permisos.Item(i).PER_abm = "A" Then
                            Cliente(True, flagm, flagb)
                            flaga = 1
                        End If
                        If permisos.Item(i).PER_abm = "M" Then
                            Cliente(flaga, True, flagb)
                            flagm = 1
                        End If
                        If permisos.Item(i).PER_abm = "B" Then
                            Cliente(flaga, flagm, True)
                            flagb = 1
                        End If
                    End If
                    '-----------------PIEZA---------------------'
                    If permisos.Item(i).PER_permiso = "PIEZA" Then
                        If permisos.Item(i).PER_abm = "A" Then
                            Pieza(True, flagm, flagb)
                            flaga = 1
                        End If
                        If permisos.Item(i).PER_abm = "M" Then
                            Pieza(flaga, True, flagb)
                            flagm = 1
                        End If
                        If permisos.Item(i).PER_abm = "B" Then
                            Pieza(flaga, flagm, True)
                            flagb = 1
                        End If
                    End If
                    '----------------------SECTOR------------------'
                    If permisos.Item(i).PER_permiso = "SECTOR" Then
                        If permisos.Item(i).PER_abm = "A" Then
                            Sector(True, flagm, flagb)
                            flaga = 1
                        End If
                        If permisos.Item(i).PER_abm = "M" Then
                            Sector(flaga, True, flagb)
                            flagm = 1
                        End If
                        If permisos.Item(i).PER_abm = "B" Then
                            Sector(flaga, flagm, True)
                            flagb = 1
                        End If
                    End If
                    '--------------------TAREA-------------------'
                    If permisos.Item(i).PER_permiso = "TAREA" Then
                        If permisos.Item(i).PER_abm = "A" Then
                            Tarea(True, flagm, flagb)
                            flaga = 1
                        End If
                        If permisos.Item(i).PER_abm = "M" Then
                            Tarea(flaga, True, flagb)
                            flagm = 1
                        End If
                        If permisos.Item(i).PER_abm = "B" Then
                            Tarea(flaga, flagm, True)
                            flagb = 1
                        End If
                    End If
                    '--------------------PRODUCTO------------------'
                    If permisos.Item(i).PER_permiso = "PRODUCTO" Then
                        If permisos.Item(i).PER_abm = "A" Then
                            Producto(True, flagm, flagb, flagalta, flagbaja)
                            flaga = 1
                        End If
                        If permisos.Item(i).PER_abm = "M" Then
                            Producto(flaga, True, flagb, flagalta, flagbaja)
                            flagm = 1
                        End If
                        If permisos.Item(i).PER_abm = "B" Then
                            Producto(flaga, flagm, True, flagalta, flagbaja)
                            flagb = 1
                        End If
                        If permisos.Item(i).PER_abm = "ALTA" Then
                            Producto(flaga, flagm, flagb, True, flagbaja)
                            flagalta = 1
                        End If
                        If permisos.Item(i).PER_abm = "BAJA" Then
                            Producto(flaga, flagm, flagb, flagalta, True)
                            flagbaja = 1
                        End If
                    End If
                    '---------------------RETRABAJO-------------------'
                    If permisos.Item(i).PER_permiso = "RETRABAJO" Then
                        If permisos.Item(i).PER_abm = "REPE" Then
                            Retrabajo(True, flagb)
                            flaga = 1
                        End If
                        If permisos.Item(i).PER_abm = "DIOF" Then
                            Retrabajo(flaga, True)
                            flagb = 1
                        End If
                    End If
                    ''----------------------ODT-----------------'
                    'If permisos.Item(i).PER_permiso = "ODT" Then
                    '    If permisos.Item(i).PER_abm = "A" Then
                    '        Orden(True, flagm, flagb)
                    '        flaga = 1
                    '    End If
                    '    If permisos.Item(i).PER_abm = "M" Then
                    '        Orden(flaga, True, flagb)
                    '        flagm = 1
                    '    End If
                    '    If permisos.Item(i).PER_abm = "B" Then
                    '        Orden(flaga, flagm, True)
                    '        flagb = 1
                    '    End If
                    'End If
                    '--------------------ODTN---------------------'
                    If permisos.Item(i).PER_permiso = "ODTN" Then
                        If permisos.Item(i).PER_abm = "A" Then
                            NuevaOrden(True, flagm, flagb)
                            flaga = 1
                        End If
                        If permisos.Item(i).PER_abm = "M" Then
                            NuevaOrden(flaga, True, flagb)
                            flagm = 1
                        End If
                        If permisos.Item(i).PER_abm = "B" Then
                            NuevaOrden(flaga, flagm, True)
                            flagb = 1
                        End If
                    End If

                    '------------------ETIQUETA---------------------'
                    If permisos.Item(i).PER_permiso = "ETIQUETA" Then
                        If permisos.Item(i).PER_abm = "A" Then
                            Etiquetas(True)
                        End If
                    End If

                    '--------------------DESPACHO---------------------'
                    If permisos.Item(i).PER_permiso = "DESPACHO" Then
                        If permisos.Item(i).PER_abm = "A" Then
                            Despacho(True, flagm, flagb)
                            flaga = 1
                        End If
                        If permisos.Item(i).PER_abm = "M" Then
                            Despacho(flaga, True, flagb)
                            flagm = 1
                        End If
                        If permisos.Item(i).PER_abm = "B" Then
                            Despacho(flaga, flagm, True)
                            flagb = 1
                        End If
                    End If

                    '--------------------EMPAQUE---------------------'
                    If permisos.Item(i).PER_permiso = "EMPAQUE" Then
                        If permisos.Item(i).PER_abm = "A" Then
                            Empaque(True, flagm, flagb)
                            flaga = 1
                        End If
                        If permisos.Item(i).PER_abm = "M" Then
                            Empaque(flaga, True, flagb)
                            flagm = 1
                        End If
                        If permisos.Item(i).PER_abm = "B" Then
                            Empaque(flaga, flagm, True)
                            flagb = 1
                        End If
                    End If
                    '--------------------TICKET---------------------'
                    If permisos.Item(i).PER_permiso = "TICKET" Then
                        If permisos.Item(i).PER_abm = "S" Then
                            Ticket(True, flagm, flagb)
                            flaga = 1
                        End If
                        If permisos.Item(i).PER_abm = "R" Then
                            Ticket(flaga, True, flagb)
                            flagm = 1
                        End If
                        If permisos.Item(i).PER_abm = "O" Then
                            Ticket(flaga, flagm, True)
                            flagb = 1
                        End If
                    End If
                Next
            End If

            'PASAR USUARIO Y PERFIL A LOS LABEL DEL MENUUU!!!! PARA LUEGO TOMAR EL USUARIO PARA
            'ACTUALIZAR PASS DESDE ADENTRO
            frm_Principal.LBL_MENU_PERFIL.Text = Buscausuario.USU_perfil.ToString
            frm_Principal.LBL_MENU_USU.Text = Buscausuario.USU_usuario.ToString
            frm_Principal.Show()
            frm_Principal.mostrar_mensaje()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Verifique Usuario y contraseña!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            txt_usuario.Select()
            limpiarcontroles()
        End Try
    End Sub

    Sub HabilitarGeneral()
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(3).Enabled = True
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(3).Enabled = True 'consultar
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(3).Enabled = True 'consultar
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(3).Enabled = True 'consultar
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(2).Enabled = True 'consultar
        frm_Principal.SectorToolStripMenuItem.DropDownItems(3).Enabled = True 'consultar
        frm_Principal.TareasToolStripMenuItem.DropDownItems(3).Enabled = True 'consultar
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(2).Enabled = True 'consulta producto
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(3).Enabled = True 'consulta movimiento producto
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(6).Enabled = True 'consultar
        frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(2).Enabled = True 'consultar
        frm_Principal.LogísticaToolStripMenuItem.DropDownItems(3).Enabled = True 'consultar
        frm_Principal.EmpaqueToolStripMenuItem.DropDownItems(3).Enabled = True
        Ticket(True, False, False)
        Acercade()
    End Sub

    Sub DeshabilitarGeneral()
        frm_Principal.UsuarioToolStripMenuItem.Visible = False
        Usuario(False, False, False)
        Colaborador(False, False, False)
        Vendedor(False, False, False)
        Cliente(False, False, False)
        Pieza(False, False, False)
        Sector(False, False, False)
        Tarea(False, False, False)
        Producto(False, False, False, False, False)
        ' Orden(False, False, False)
        NuevaOrden(False, False, False)
        Retrabajo(False, False)
        Etiquetas(False)
        Estadistica(False, False, False, False, False)
        CorreoElectronico(False)
        Despacho(False, False, False)
        Empaque(False, False, False)
        Ticket(False, False, False)
        Acercade()
    End Sub

    Sub Archivo()
        frm_Principal.ArchivoToolStripMenuItem.Enabled = True
        frm_Principal.ArchivoToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.ArchivoToolStripMenuItem.DropDownItems(1).Enabled = True
    End Sub

    Sub Usuario(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(2).Visible = elim
        ' flag_usuario = nuevo & modif & elim
    End Sub

    Sub Colaborador(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.ColaboradorToolStripMenuItem.Enabled = True
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(2).Visible = elim
    End Sub

    Sub Vendedor(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.VendedorToolStripMenuItem.Enabled = True
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(2).Visible = elim
    End Sub

    Sub Cliente(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.ClienteToolStripMenuItem.Enabled = True
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(2).Visible = elim
    End Sub

    Sub Pieza(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.PiezaToolStripMenuItem.Enabled = True
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(2).Visible = elim
    End Sub

    Sub Sector(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.SectorToolStripMenuItem.Enabled = True
        frm_Principal.SectorToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.SectorToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.SectorToolStripMenuItem.DropDownItems(2).Visible = elim

    End Sub

    Sub Tarea(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.TareasToolStripMenuItem.Enabled = True
        frm_Principal.TareasToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.TareasToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.TareasToolStripMenuItem.DropDownItems(2).Visible = elim

    End Sub

    Sub Producto(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean, ByVal alta As Boolean, ByVal baja As Boolean)

        frm_Principal.ProductoToolStripMenuItem.Enabled = True

        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(2).Visible = elim

        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(0).Visible = alta
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(1).Visible = baja
    End Sub

    'Sub Orden(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
    '    frm_Principal.OrdenTrabajoToolStripMenuItem.Enabled = True
    '    frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = nuevo 'nueva
    '    frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = modif 'modificar
    '    frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = elim 'eliminar
    'End Sub

    Sub NuevaOrden(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.OrdenTrabajoToolStripMenuItem.Enabled = True
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(4).Visible = nuevo 'nueva
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(5).Visible = modif 'modificar
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(6).Visible = elim 'eliminar
    End Sub

    Sub Retrabajo(ByVal repe As Boolean, ByVal diof As Boolean)
        frm_Principal.ReTrabajoToolStripMenuItem1.Enabled = True
        frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(0).Visible = repe
        frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(1).Visible = diof

    End Sub

    Sub Estadistica(ByVal pestaña As Boolean, ByVal diaria As Boolean, ByVal mensual As Boolean, ByVal orden As Boolean, ByVal movim As Boolean)
        frm_Principal.EstadisticasToolStripMenuItem.Enabled = pestaña 'pestaña

        frm_Principal.TareasToolStripMenuItem1.Enabled = True 'tarea
        frm_Principal.TareasToolStripMenuItem1.DropDownItems(0).Visible = diaria 'diarias por colaborador
        frm_Principal.TareasToolStripMenuItem1.DropDownItems(1).Visible = mensual 'mensuales por sector

        frm_Principal.OrdenDeTrabajoToolStripMenuItem.Enabled = True 'orden
        frm_Principal.OrdenDeTrabajoToolStripMenuItem.DropDownItems(0).Visible = movim 'movimiento de orden
    End Sub

    Sub Etiquetas(ByVal flaga)
        frm_Principal.EtiquetasToolStripMenuItem.Visible = flaga
    End Sub

    Sub CorreoElectronico(ByVal ver As Boolean)
        frm_Principal.CorreoElectrónicoToolStripMenuItem.Visible = ver
    End Sub

    Sub Acercade()
        frm_Principal.AcercadeToolStripMenuItem.Visible = True
    End Sub
    Sub Despacho(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.DespachoToolStripMenuItem1.Enabled = True
        frm_Principal.LogísticaToolStripMenuItem.DropDownItems(0).Visible = nuevo 'nueva
        frm_Principal.LogísticaToolStripMenuItem.DropDownItems(1).Visible = modif 'modificar
        frm_Principal.LogísticaToolStripMenuItem.DropDownItems(2).Visible = elim 'eliminar
    End Sub
    Sub Empaque(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.DespachoToolStripMenuItem1.Enabled = True
        frm_Principal.EmpaqueToolStripMenuItem.DropDownItems(0).Visible = nuevo 'nueva
        frm_Principal.EmpaqueToolStripMenuItem.DropDownItems(1).Visible = modif 'modificar
        frm_Principal.EmpaqueToolStripMenuItem.DropDownItems(2).Visible = elim 'eliminar
    End Sub

    Sub Ticket(ByVal solicitante As Boolean, ByVal receptor As Boolean, ByVal otro As Boolean)
        frm_Ticket.GroupSolicitante.Enabled = solicitante
        frm_Ticket.GroupReceptor.Enabled = receptor
    End Sub

    Public Sub limpiarcontroles()
        txt_contraseña.Clear()
        txt_usuario.Clear()
    End Sub

    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarContraseña.Click
        Try
            Dim Buscausuario = (From I In datacontext.USUARIO Where I.USU_usuario = (txt_usuario.Text) And I.USU_contraseña = (txt_contraseña.Text)).ToList()(0)
            frm_gestion_usuarios.txt_usuario.Text = Buscausuario.USU_usuario
            frm_gestion_usuarios.cbo_perfil.Text = Buscausuario.USU_perfil
            frm_gestion_usuarios.cbo_perfil.Enabled = False
            frm_gestion_usuarios.txt_usuario.Enabled = False
            frm_gestion_usuarios.btnGuardar.Visible = False
            frm_gestion_usuarios.Show()
        Catch ex As Exception
            MsgBox("Verifique Usuario y contraseña!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            txt_usuario.Select()
            limpiarcontroles()
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Application.ExitThread()
        Me.Dispose()
    End Sub

    Private Sub frm_ingreso_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class

' para habilitar las nuevas pestañas de la orden de trabajo cree:

'  Sub NuevaOrden(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
'       frm_Principal.OrdenTrabajoToolStripMenuItem.Enabled = True
'       frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(4).Visible = nuevo 'nueva
'       frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(5).Visible = modif 'modificar
'       frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(6).Visible = elim 'eliminar
'   End Sub

'    Sub HabilitarGeneral()
'       '------------------------------------
'        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(6).Enabled = True 'consultar
'       '---------------------------------
'    End Sub

'Sub DeshabilitarGeneral()
'--------------------------------------------------
'    NuevaOrden(False, False, False)
' '----------------------------------------------


''--------------------ODTN---------------------'
'                    If permisos.Item(i).PER_permiso = "ODTN" Then
'                        If permisos.Item(i).PER_abm = "A" Then
'                            NuevaOrden(True, flagm, flagb)
'                            flaga = 1
'                        End If
'                        If permisos.Item(i).PER_abm = "M" Then
'                            NuevaOrden(flaga, True, flagb)
'                            flagm = 1
'                        End If
'                        If permisos.Item(i).PER_abm = "B" Then
'                            NuevaOrden(flaga, flagm, True)
'                            flagb = 1
'                        End If
'                    End If
'-----------------------------------------------------------





'  Case "ADMINISTRADOR"
'.........................................
'                    NuevaOrden(True, True, True)
'                  '..................................






'                Case "GERENCIA"
'                  '................................
'                    NuevaOrden(True, True, True)
'               '.......................................







'                Case "SUPERVISOR"
'                  '....................................
'                    NuevaOrden(True, True, False)
'                   '........................................
'---------------------------------------


'Private Sub frm_ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

'    frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = False 'alta vieja orden
'    frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = False 'modificar vieja orden
'    frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = False 'eliminar vieja orden
'    frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(3).Visible = False 'consultar vieja orden

'End Sub