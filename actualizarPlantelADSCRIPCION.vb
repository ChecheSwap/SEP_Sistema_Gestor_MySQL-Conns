Public Class actualizarPlantelADSCRIPCION

    Private Sub actualizarPlantelADSCRIPCION_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        activoActualizarPLANTELADSCRIPCION = False
        btnCLOSE_PADRE()
        limpiado_cboxes()
    End Sub

    Private Sub actualizarPlantelADSCRIPCION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activoActualizarPLANTELADSCRIPCION = True
        btnOPEN_PADRE()
        llenado_cboxes_onlocal()
        dataoncharge()
    End Sub







    Private Sub dataoncharge()

        Dim objetoMyclase As New claseActualizarPlantelADSCRIPCION(curpactualizardatos)

        Dim contenedor(14) As String

        contenedor = objetoMyclase.obtaindatatofirstcharge()

        cbox_subsistema.Text = contenedor(0)
        uno.Text = contenedor(1)
        dos.Text = contenedor(2)
        tres.Text = contenedor(3)
        cuatro.Text = contenedor(4)
        cinco_fecha.Text = contenedor(5)
        seis.Text = contenedor(6)
        siete.Text = contenedor(7)
        ocho.Text = contenedor(8)
        nueve_contratacion.Text = contenedor(9)
        diez.Text = contenedor(10)
        once.Text = contenedor(11)
        doce.Text = contenedor(12)
        trece.Text = contenedor(13)
        catorce.Text = contenedor(14)



    End Sub


    Private Sub data_toSEND()

        Dim arraySEND(14) As String

        arraySEND(0) = cbox_subsistema.Text.Trim()
        arraySEND(1) = uno.Text.Trim()
        arraySEND(2) = dos.Text.Trim()
        arraySEND(3) = tres.Text.Trim()
        arraySEND(4) = cuatro.Text.Trim()
        arraySEND(5) = cinco_fecha.Value.Date
        arraySEND(6) = seis.Text.Trim()
        arraySEND(7) = siete.Text.Trim()
        arraySEND(8) = ocho.Text.Trim()
        arraySEND(9) = nueve_contratacion.Text.Trim()
        arraySEND(10) = diez.Text.Trim()
        arraySEND(11) = once.Text.Trim()
        arraySEND(12) = doce.Text.Trim()
        arraySEND(13) = trece.Text.Trim()
        arraySEND(14) = catorce.Text.Trim()

        Dim objetoUPDATE As New claseActualizarPlantelADSCRIPCION(curpactualizardatos)

        objetoUPDATE.updateOnset(arraySEND)
        cbox_subsistema.Focus()
    End Sub


    Private Sub cleardata_controlsonform()

        cbox_subsistema.Text = ""
        uno.Text = ""
        dos.Text = ""
        tres.Text = ""
        cuatro.Text = ""
        cinco_fecha.Update()
        seis.Text = ""
        siete.Text = ""
        ocho.Text = ""
        nueve_contratacion.Text = ""
        diez.Text = ""
        once.Text = ""
        doce.Text = ""
        trece.Text = ""
        catorce.Text = ""
        cbox_subsistema.Focus()


    End Sub


    Private Sub btnOPEN_PADRE()

        Dim padre = modificar

        padre.btnPlantelADSCRIPCION.BackColor = Color.Gray



    End Sub

    Private Sub btnCLOSE_PADRE()

        Dim padre = modificar

        padre.btnPlantelADSCRIPCION.BackColor = Color.White



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("CONTACTO: Vidaliasupportcenter_Mysql@live.com", MsgBoxStyle.Information, "Help Contact")
    End Sub


    Private Sub llenado_cboxes_onlocal()

        cbox_subsistema.Items.Add("CONALEP")
        cbox_subsistema.Items.Add("DGECyTM")
        cbox_subsistema.Items.Add("COBAFED")
        cbox_subsistema.Items.Add("DGETA")
        cbox_subsistema.Items.Add("DGETI")
        cbox_subsistema.Items.Add("DGB")

        uno.Items.Add("Estatal")
        uno.Items.Add("Federal")
        uno.Items.Add("Particular")

        nueve_contratacion.Items.Add("Base")
        nueve_contratacion.Items.Add("Contrato")

    End Sub

    Private Sub limpiado_cboxes()
        cbox_subsistema.Items.Clear()
        uno.Items.Clear()
        nueve_contratacion.Items.Clear()
    End Sub

    Private Sub cbox_subsistema_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbox_subsistema.KeyPress
        comboboxestexto(e)
    End Sub





    Private Sub cbox_subsistema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_subsistema.SelectedIndexChanged

    End Sub

    Private Sub uno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uno.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub uno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles uno.SelectedIndexChanged

    End Sub

    Private Sub nueve_contratacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nueve_contratacion.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub nueve_contratacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nueve_contratacion.SelectedIndexChanged

    End Sub

    Private Sub borrardatos_Click(sender As Object, e As EventArgs) Handles borrardatos.Click
        cleardata_controlsonform()
    End Sub

    Private Sub guardardatos_Click(sender As Object, e As EventArgs) Handles guardardatos.Click
        data_toSEND()
    End Sub
End Class