Public Class adduser

    Private ncurp, nestatus, napellidopaterno, napellidomaterno, nnombre1, nnombre2, nsexo, nrfc, nfechanacimiento, ntelefonolocal, ntelefonocelular, nedonacimiento, nemail, nnacionalidad, nestadocivil, ntienecomputadora, ntieneinternet, ncalle, nnumeroexterior,
        nnumerointerior, nlocalidad, ncodigopostal, nmunicipioresidencia, nestadoresidencia, ncomentariosdomicilio As String

    Private marcopolovalidador As Integer = 0





    Private edos(31) As String

    Private Sub nombreestados()

        edos(0) = "Aguascalientes"
        edos(1) = "Baja California"
        edos(2) = "Baja California Sur"
        edos(3) = "Campeche"
        edos(4) = "Coahuila de Zaragoza"
        edos(5) = "Colima"
        edos(6) = "Chiapas"
        edos(7) = "Chihuahua"
        edos(8) = "Distrito Federal"
        edos(9) = "Durango"
        edos(10) = "Guanajuato"
        edos(11) = "Guerrero"
        edos(12) = "Hidalgo"
        edos(13) = "Jalisco"
        edos(14) = "México"
        edos(15) = "Michoacán de Ocampo"
        edos(16) = "Morelos"
        edos(17) = "Nayarit"
        edos(18) = "Nuevo León"
        edos(19) = "Oaxaca"
        edos(20) = "Puebla"
        edos(21) = "Querétaro"
        edos(22) = "Quintana Roo"
        edos(23) = "San Luis Potosí"
        edos(24) = "Sinaloa"
        edos(25) = "Sonora"
        edos(26) = "Tabasco"
        edos(27) = "Tamaulipas"
        edos(28) = "Tlaxcala"
        edos(29) = "Veracruz de Ignacio de la Llave"
        edos(30) = "Yucatán"
        edos(31) = "Zacatecas"

    End Sub


    Private Sub initialsexos()

        sexos.Items.Add("Masculino")
        sexos.Items.Add("Femenino")
    End Sub



    Private Sub initialedonacimientos()


        For x = 0 To 31 Step +1


            edonacimientos.Items.Add(edos(x))

        Next x

    End Sub


    Private Sub initialestadocivils()

        estadocivils.Items.Add("Soltero")
        estadocivils.Items.Add("Casado")


    End Sub

    Private Sub initialtienecomputadoras()

        tienecomputadoras.Items.Add("Si")
        tienecomputadoras.Items.Add("No")

    End Sub

    Private Sub initialtieneinternets()

        tieneinternets.Items.Add("Si")
        tieneinternets.Items.Add("No")

    End Sub





    Private Sub initialedoresidencia()

        For m = 0 To 31 Step +1
            edoresidencia.Items.Add(edos(m))
        Next m

    End Sub



    Private Sub initialestatus()

        estatuss.Items.Add("Activo")
        estatuss.Items.Add("Baja")

    End Sub




    Private Sub initial()
        nombreestados()
        initialsexos()
        initialedonacimientos()
        initialedoresidencia()
        initialestadocivils()
        initialtienecomputadoras()
        initialtieneinternets()
        initialestatus()
        curps.MaxLength = 18

    End Sub


    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub sexos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sexos.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub sexos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sexos.SelectedIndexChanged

    End Sub

    Private Sub adduser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        eraseall()
        curps.Focus()
    End Sub

    Private Sub eraseall()
        curps.Clear()
        edonacimientos.Items.Clear()
        estatuss.Items.Clear()
        edoresidencia.Items.Clear()
        sexos.Items.Clear()
        edonacimientos.Items.Clear()
        edoresidencia.Items.Clear()
        estadocivils.Items.Clear()
        tienecomputadoras.Items.Clear()
        tieneinternets.Items.Clear()
        apellidomaternos.Clear()
        apellidopaternos.Clear()
        nombre1s.Clear()
        nombre2s.Clear()
        fechanacimientos.Update()
        rfcs.Clear()
        telefonolocals.Clear()
        telefonocelulars.Clear()
        emails.Clear()
        nacionalidads.Clear()
        calles.Clear()
        numeroexteriors.Clear()
        numerointeriors.Clear()
        localidads.Clear()
        codigopostals.Clear()
        municipioresidencias.Clear()
        edonacimientos.Text = ""
        sexos.Text = ""
        comentariosdomicilios.Text = ""
        estatuss.Text = ""
        estadocivils.Text = ""
        tienecomputadoras.Text = ""
        tieneinternets.Text = ""
        edoresidencia.Text = ""




    End Sub

    Private Sub adduser_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        curps.Focus()

    End Sub



    Private Sub adduser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        initial()
        curps.Focus()


    End Sub

    Private Sub estatuss_KeyPress(sender As Object, e As KeyPressEventArgs) Handles estatuss.KeyPress

        comboboxestexto(e)


    End Sub

    Private Sub estatuss_SelectedIndexChanged(sender As Object, e As EventArgs) Handles estatuss.SelectedIndexChanged

    End Sub

    Private Sub estatuss_TextChanged(sender As Object, e As EventArgs) Handles estatuss.TextChanged


    End Sub

   

    Private Sub edonacimientos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edonacimientos.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub edonacimientos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles edonacimientos.SelectedIndexChanged

    End Sub

    Private Sub estadocivils_KeyPress(sender As Object, e As KeyPressEventArgs) Handles estadocivils.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub estadocivils_SelectedIndexChanged(sender As Object, e As EventArgs) Handles estadocivils.SelectedIndexChanged

    End Sub

    Private Sub tienecomputadoras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tienecomputadoras.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub tienecomputadoras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tienecomputadoras.SelectedIndexChanged

    End Sub

    Private Sub tieneinternets_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tieneinternets.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub tieneinternets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tieneinternets.SelectedIndexChanged

    End Sub

    Private Sub edoresidencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edoresidencia.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub edoresidencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles edoresidencia.SelectedIndexChanged

    End Sub

    Private Sub curps_TextChanged(sender As Object, e As EventArgs) Handles curps.TextChanged

        
        





    End Sub

    Private Sub llenadoSEXOCIVILTIENECOMPUTADORATIENEINTERNETESTATUS()

        Select Case sexos.SelectedItem

            Case "Masculino"
                nsexo = "Masculino"

            Case "Femenino"
                nsexo = "Femenino"

            Case Else
                nsexo = "NO ESPECIFICO"


        End Select


        Select Case estatuss.SelectedItem
            Case "Activo"
                nestatus = "Activo"

            Case "Baja"
                nestatus = "Baja"

            Case Else
                nestatus = "NO ESPECIFICO"
        End Select

        Select Case estadocivils.SelectedItem

            Case "Casado"
                nestadocivil = "Casado"

            Case "Soltero"
                nestadocivil = "Soltero"

            Case Else
                nestadocivil = "NO ESPECIFICO "

        End Select

        Select Case tieneinternets.SelectedItem
            Case "Si"
                ntieneinternet = "Si"
            Case "No"
                ntieneinternet = "No"
        End Select

        Select Case tienecomputadoras.SelectedItem
            Case "Si"
                ntienecomputadora = "Si"

            Case "No"
                ntienecomputadora = "No"

            Case Else
                ntienecomputadora = "NO ESPECIFICO"
        End Select




    End Sub



    Private Sub selectovalcomboboxes() 'AGRUPACION DE LAS FUNCIONES PARA ASIGNAR VALOR A COMBOBOXES
        llenadoSEXOCIVILTIENECOMPUTADORATIENEINTERNETESTATUS()
        selectoredoNACIMIENTO()
        selectoredoRESIDENCIA()
    End Sub




    Private Sub selectoredoNACIMIENTO()

        Dim locvad = 0

        For z = 0 To 31 Step +1

            If edonacimientos.SelectedItem = edos(z) Then
                nedonacimiento = edos(z)
                locvad = 1


            End If

        Next z

        If locvad = 0 Then
            nedonacimiento = "NO ESPECIFICO"
        End If

    End Sub

    Private Sub selectoredoRESIDENCIA()

        Dim locvad = 0

        For z = 0 To 31 Step +1

            If edoresidencia.SelectedItem = edos(z) Then
                nestadoresidencia = edos(z)
                locvad = 1


            End If

        Next z

        If locvad = 0 Then
            nestadoresidencia = "NO ESPECIFICO"
        End If




    End Sub


    Private objetoinsertarsql As New insertdatosgenerales()


    Private Sub guardardatos_Click(sender As Object, e As EventArgs) Handles guardardatos.Click

        If curps.Text.Trim.Length = 18 Then
            ncurp = curps.Text
            lumacurp()


            If (accesoinsert = True) Then
                MsgBox("La CURP que ha ingresado ya existe en el sistema", MsgBoxStyle.Information, "Vidalia Advisor")
                curps.Clear()
                curps.Focus()

            ElseIf accesoinsert = False Then

                llenadocampostotal()
                selectovalcomboboxes()

                objetoinsertarsql.insertardatos(ncurp, nestatus, napellidopaterno, napellidomaterno, nnombre1, nnombre2, nsexo, nfechanacimiento, nrfc, ntelefonolocal, ntelefonocelular, nedonacimiento, nemail, nnacionalidad, nestadocivil, ntienecomputadora, ntieneinternet, ncalle, nnumeroexterior,
        nnumerointerior, nlocalidad, ncodigopostal, nmunicipioresidencia, nestadoresidencia, ncomentariosdomicilio)
                
                eraseall()
                initial()
                curps.Focus()







            End If
        Else


            MsgBox("Ingrese Curp Valida (18 Digitos)", MsgBoxStyle.Information, "Vidalia Advisor")
            curps.Clear()
            curps.Focus()


        End If

    End Sub

    Private accesoinsert As Boolean = False

    Private Sub lumacurp()
        accesoinsert = False
        Dim objetocurp As New DBVerificacioncurp(False)

        objetocurp.verificarcurp(ncurp)

        accesoinsert = objetocurp.obtainacces()



    End Sub

    Private Sub llenadocampostotal()




        napellidopaterno = apellidopaternos.Text

        napellidomaterno = apellidomaternos.Text

        nnombre1 = nombre1s.Text

        nnombre2 = nombre2s.Text

        nrfc = rfcs.Text

        nfechanacimiento = fechanacimientos.Value.Date

        ntelefonolocal = telefonolocals.Text

        ntelefonocelular = telefonocelulars.Text

        nemail = emails.Text

        nnacionalidad = nacionalidads.Text

        nestadocivil = estadocivils.Text
        ntienecomputadora = tienecomputadoras.Text

        ntieneinternet = tieneinternets.Text

        ncalle = calles.Text

        nnumeroexterior = numeroexteriors.Text

        nnumerointerior = numerointeriors.Text

        nlocalidad = localidads.Text

        ncodigopostal = codigopostals.Text

        nmunicipioresidencia = municipioresidencias.Text

        nestadoresidencia = edoresidencia.Text

        ncomentariosdomicilio = comentariosdomicilios.Text

    End Sub

    Private Sub eraserestart()
        curps.Clear()
        apellidomaternos.Clear()
        apellidopaternos.Clear()
        nombre1s.Clear()
        nombre2s.Clear()
        fechanacimientos.Update()
        rfcs.Clear()
        telefonolocals.Clear()
        telefonocelulars.Clear()
        emails.Clear()
        nacionalidads.Clear()
        calles.Clear()
        numeroexteriors.Clear()
        numerointeriors.Clear()
        localidads.Clear()
        codigopostals.Clear()
        municipioresidencias.Clear()
        edonacimientos.Text = ""
        sexos.Text = ""
        comentariosdomicilios.Text = ""
        estatuss.Text = ""
        estadocivils.Text = ""
        tienecomputadoras.Text = ""
        tieneinternets.Text = ""
        edoresidencia.Text = ""










    End Sub

    Private Sub borrardatos_Click(sender As Object, e As EventArgs) Handles borrardatos.Click
        Dim upd = MsgBox("¿Desea Reiniciar los Campos?", MsgBoxStyle.OkCancel, "Vidalia Advisor")
        If upd = MsgBoxResult.Ok Then
            eraserestart()
            curps.Focus()
        Else
            curps.Focus()
        End If

    End Sub

    Private Sub regresarhome_Click(sender As Object, e As EventArgs) Handles regresarhome.Click
        Dim orfs = MsgBox("¿Desea regresar a Menu?", MsgBoxStyle.OkCancel, "Vidalia")
        If orfs = MsgBoxResult.Ok Then
            Me.Close()
        ElseIf MsgBoxResult.Cancel Then
            curps.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("CONTACTO: Vidaliasupportcenter_Mysql@live.com", MsgBoxStyle.Information, "Help Contact")

    End Sub
End Class