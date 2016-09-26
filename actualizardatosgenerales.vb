Public Class actualizardatosgenerales

    Private datostabla() As String

    Private edos(31) As String

    Private arraytoUPDATE(24) As String

    

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



    Private Sub selectcurpintegridadreferencial() 'CARGA DATOS DE ARRANQUE EN CONTROLES DE LA CURP GENERAL

        Dim objetoselectsActualizadatosgeneales As New selectsActualizarDatos()

        objetoselectsActualizadatosgeneales.obtenercampos(curpactualizardatos)
        datostabla = objetoselectsActualizadatosgeneales.arreglolleno()

        curps.Text = datostabla(0)
        estatuss.Text = datostabla(1)
        apellidopaternos.Text = datostabla(2)
        apellidomaternos.Text = datostabla(3)
        nombre1s.Text = datostabla(4)
        nombre2s.Text = datostabla(5)
        sexos.Text = datostabla(6)
        fechanacimientos.Text = datostabla(7)
        rfcs.Text = datostabla(8)
        telefonolocals.Text = datostabla(9)
        telefonocelulars.Text = datostabla(10)
        edonacimientos.Text = datostabla(11)
        emails.Text = datostabla(12)
        nacionalidads.Text = datostabla(13)
        estadocivils.Text = datostabla(14)
        tienecomputadoras.Text = datostabla(15)
        tieneinternets.Text = datostabla(16)
        calles.Text = datostabla(17)
        numeroexteriors.Text = datostabla(18)
        numerointeriors.Text = datostabla(19)
        localidads.Text = datostabla(20)
        codigopostals.Text = datostabla(21)
        municipioresidencias.Text = datostabla(22)
        edoresidencia.Text = datostabla(23)
        comentariosdomicilios.Text = datostabla(24)


    End Sub


    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click


    End Sub

    Private Sub actualizardatosgenerales_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        asignacionbotonpanelDESASIGNAR()
        cerrarvariablesycontroles()
        borradoinformacionbtonactualizar()
    End Sub

    Private Sub actualizardatosgenerales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        asignacionbotonpanelASIGNAR()
        iniciocontrolesyvariablesemuladas()
        selectcurpintegridadreferencial()


    End Sub

    Private Sub asignacionbotonpanelASIGNAR()
        Dim colosium = modificar

        colosium.bdatosgenerales.BackColor = Color.Gray

    End Sub
    Private Sub asignacionbotonpanelDESASIGNAR()
        Dim colosium = modificar
        colosium.bdatosgenerales.BackColor = Color.White

    End Sub

    Private Sub iniciocontrolesyvariablesemuladas() 'INICIO DE VALORES INTEGROS DE LOS CONTROLES EN FORMA Y VARIABLES DE CONTROL EXTERNOS EN MODULO REFERENCIAL'

        nombreestados()
        activoActualizardatosgenerales = True

        estatuss.Items.Add("Activo")
        estatuss.Items.Add("Baja")

        sexos.Items.Add("Masculino")
        sexos.Items.Add("Femenino")

        For q = 0 To 31 Step +1
            edonacimientos.Items.Add(edos(q))
        Next q

        estadocivils.Items.Add("Soltero")
        estadocivils.Items.Add("Casado")

        tienecomputadoras.Items.Add("Si")
        tienecomputadoras.Items.Add("No")

        tieneinternets.Items.Add("Si")
        tieneinternets.Items.Add("No")

        For w = 0 To 31 Step +1

            edoresidencia.Items.Add(edos(w))
        Next w


    End Sub







    Private Sub cerrarvariablesycontroles() 'CLOSING DE ATRIBUTOS INTEGROS DE CONTROLES
        activoActualizardatosgenerales = False

        estatuss.Items.Clear()
        sexos.Items.Clear()
        edonacimientos.Items.Clear()
        estadocivils.Items.Clear()
        tienecomputadoras.Items.Clear()
        tieneinternets.Items.Clear()
        edoresidencia.Items.Clear()
    End Sub


    Private Sub proceduredelegadoActualizardatos()

        arraytoUPDATE(0) = curpactualizardatos
        arraytoUPDATE(1) = estatuss.Text
        arraytoUPDATE(2) = apellidopaternos.Text
        arraytoUPDATE(3) = apellidomaternos.Text
        arraytoUPDATE(4) = nombre1s.Text
        arraytoUPDATE(5) = nombre2s.Text
        arraytoUPDATE(6) = sexos.Text
        arraytoUPDATE(7) = fechanacimientos.Value.Date
        arraytoUPDATE(8) = rfcs.Text
        arraytoUPDATE(9) = telefonolocals.Text
        arraytoUPDATE(10) = telefonocelulars.Text
        arraytoUPDATE(11) = edonacimientos.Text
        arraytoUPDATE(12) = emails.Text
        arraytoUPDATE(13) = nacionalidads.Text
        arraytoUPDATE(14) = estadocivils.Text
        arraytoUPDATE(15) = tienecomputadoras.Text
        arraytoUPDATE(16) = tieneinternets.Text
        arraytoUPDATE(17) = calles.Text
        arraytoUPDATE(18) = numeroexteriors.Text
        arraytoUPDATE(19) = numerointeriors.Text
        arraytoUPDATE(20) = localidads.Text
        arraytoUPDATE(21) = codigopostals.Text
        arraytoUPDATE(22) = municipioresidencias.Text
        arraytoUPDATE(23) = edoresidencia.Text
        arraytoUPDATE(24) = comentariosdomicilios.Text


        Dim objetoupdate As New selectsActualizarDatos()

        objetoupdate.updateelementos(arraytoUPDATE)


    End Sub

    Private Sub guardardatos_Click(sender As Object, e As EventArgs) Handles guardardatos.Click
        proceduredelegadoActualizardatos()
    End Sub

    Private Sub borrardatos_Click(sender As Object, e As EventArgs) Handles borrardatos.Click
        Dim petraeus = MsgBox("¿Reiniciar Campos?", MsgBoxStyle.YesNo, "Vidalia Advisor")

        Select Case petraeus
            Case Is = MsgBoxResult.Yes
                borradoinformacionbtonactualizar()

            Case Else
                estatuss.Focus()
        End Select

    End Sub

    Private Sub borradoinformacionbtonactualizar()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("CONTACTO: Vidaliasupportcenter_Mysql@live.com", MsgBoxStyle.Information, "Help Contact")
    End Sub

    Private Sub estatuss_KeyPress(sender As Object, e As KeyPressEventArgs) Handles estatuss.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub estatuss_SelectedIndexChanged(sender As Object, e As EventArgs) Handles estatuss.SelectedIndexChanged

    End Sub

    Private Sub sexos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sexos.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub sexos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sexos.SelectedIndexChanged

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
End Class