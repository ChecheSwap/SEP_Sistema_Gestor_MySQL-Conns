Public Class actualizarOtraINSTITUCION

    Private validate_tosend As Boolean = False

    Private Sub actualizarOtraINSTITUCION_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ActivoActualizarotraINSTITUCION = False
        btnDISCHARGE()
        CLEARcboxNIVELEDUCATIVO()

    End Sub


    Private Sub update_dataSQLQ()

        Dim data_to_send(5) As String

        data_to_send(0) = txtnombre.Text.Trim()
        data_to_send(1) = cboxniveleducativo.Text.Trim()
        data_to_send(2) = txtsubsistema.Text.Trim()
        data_to_send(3) = txttipodesostenimiento.Text.Trim()
        data_to_send(4) = txtasignatura.Text.Trim()
        data_to_send(5) = txthorasimpartidas.Text.Trim()


        Dim objtoupd As New claseActualizarOtraINSTITUCION(curpactualizardatos)

        objtoupd.update_data(data_to_send)

        Erase data_to_send

    End Sub



    Private Sub actualizarOtraINSTITUCION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActivoActualizarotraINSTITUCION = True
        btnCHARGE()
        controlador_inicio_existe()
        llenadocboxNIVELEDUCATIVO()
    End Sub

    Private Sub btnCHARGE()
        Dim padre = modificar

        padre.btnotrainstitucion.BackColor = Color.Gray()


    End Sub

    Private Sub btnDISCHARGE()
        Dim padre = modificar

        padre.btnotrainstitucion.BackColor = Color.White()

    End Sub



    Private Sub controlador_inicio_existe() 'DETERMINA SI ESTA DADO DE ALTA UNA INSTITUCION EN LA CURP CURRENT

        Dim objeto As New claseActualizarOtraINSTITUCION(curpactualizardatos)

        validate_tosend = objeto.validarSiexisteinstitucion()

        Select Case validate_tosend

            Case Is = True


                cksi.Checked = True
                ckno.Checked = False

                Dim datos_iniciales(5) As String

                Dim objetoclase As New claseActualizarOtraINSTITUCION(curpactualizardatos)

                datos_iniciales = objetoclase.obtenerarray_datosiniciales()

                txtnombre.Text = datos_iniciales(0)
                cboxniveleducativo.Text = datos_iniciales(1)
                txtsubsistema.Text = datos_iniciales(2)
                txttipodesostenimiento.Text = datos_iniciales(3)
                txtasignatura.Text = datos_iniciales(4)
                txthorasimpartidas.Text = datos_iniciales(5)


            Case Is = False

                cksi.Checked = False
                ckno.Checked = True


        End Select




    End Sub



    Private Sub dataofchargeinitial()

        Dim initial_data(5) As String




    End Sub




    Private Sub ckSi_verificador()

        If cksi.Checked = True Then
            validate_tosend = True

            ckno.Checked = False

            grupodatos.Enabled = True

        ElseIf cksi.Checked = False Then

            validate_tosend = False
            ckno.Checked = True

            grupodatos.Enabled = False

        End If
    End Sub

    Private Sub ckno_verificador()
        If ckno.Checked = True Then
            validate_tosend = False

            cksi.Checked = False

        ElseIf ckno.Checked = False Then

            validate_tosend = True
            cksi.Checked = True

        End If
    End Sub



    Private Sub cksi_CheckedChanged(sender As Object, e As EventArgs) Handles cksi.CheckedChanged
        ckSi_verificador()
    End Sub

    Private Sub ckno_CheckedChanged(sender As Object, e As EventArgs) Handles ckno.CheckedChanged
        ckno_verificador()
        verificador_NO_LIMPIEZAPANEL()
    End Sub

    Private Sub cboxniveleducativo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboxniveleducativo.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub cboxniveleducativo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxniveleducativo.SelectedIndexChanged

    End Sub


    Private Sub llenadocboxNIVELEDUCATIVO()

        cboxniveleducativo.Items.Add("BASICO")
        cboxniveleducativo.Items.Add("MEDIO")
        cboxniveleducativo.Items.Add("MEDIO SUPERIOR")
        cboxniveleducativo.Items.Add("SUPERIOR")

    End Sub

    Private Sub CLEARcboxNIVELEDUCATIVO()
        cboxniveleducativo.Items.Clear()
    End Sub


    Private Sub verificador_NO_LIMPIEZAPANEL()

        If Me.ckno.Checked = True Then

            txtnombre.Text = ""
            cboxniveleducativo.Text = ""
            txtsubsistema.Text = ""
            txttipodesostenimiento.Text = ""
            txtasignatura.Text = ""
            txthorasimpartidas.Text = ""



        End If


    End Sub

    Private Sub guardardatos_Click(sender As Object, e As EventArgs) Handles guardardatos.Click
        update_dataSQLQ()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("CONTACTO: Vidaliasupportcenter_Mysql@live.com", MsgBoxStyle.Information, "Help Contact")
    End Sub
End Class