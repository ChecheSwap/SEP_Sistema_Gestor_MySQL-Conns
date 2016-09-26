Public Class actualizarIDIOMAS


    Private valoresofcomboboxesincenter(9) As String
    Private indexOf As Integer

    Private Sub llenarDataofarray()

        For p = 0 To 9 Step +1

            valoresofcomboboxesincenter(p) = Convert.ToString((p + 1) * (10)) + "%"
        Next p

    End Sub

    Private Sub vaciardataofarray()

        Erase valoresofcomboboxesincenter

    End Sub

    Private Sub deleteallcontain()
        vaciardataofarray()
        cboxlectura.Items.Clear()
        cboxescritura.Items.Clear()
        cboxhablado.Items.Clear()
        cbttipoidioma.Items.Clear()
    End Sub


    Private Sub llenarcomboboxestextandtextbox()

        llenarDataofarray()

        'ADDING ON cboxlectura

        For x = 0 To 9 Step +1

            cboxlectura.Items.Add(valoresofcomboboxesincenter(x))

        Next x

        'ADDING ON cboxescritura

        For y = 0 To 9 Step +1

            cboxescritura.Items.Add(valoresofcomboboxesincenter(y))
        Next y

        'ADDING ON cboxhablado

        For z = 0 To 9 Step +1

            cboxhablado.Items.Add(valoresofcomboboxesincenter(z))

        Next z


        Dim orp As Integer = 1

        While (orp <= 2)

            cbttipoidioma.Items.Add(orp.ToString)
            orp = orp + 1
        End While



    End Sub
    Public Sub cargagrid()



        Dim objetoclase As New claseActualizarIDIOMAS(curpactualizardatos)


        Dim dataset_local As New DataSet()

        dataset_local = objetoclase.datasetobtain()

        datagridcentral.DataSource = dataset_local.Tables(0).DefaultView



    End Sub

    Private Sub select_IndexOf()

        Select Case cbttipoidioma.SelectedItem()

            Case Is = "1"

                indexOf = 1

            Case Is = "2"

                indexOf = 2

            Case Else
                indexOf = 0

        End Select


    End Sub

    Private Sub fill_incharge()

        Dim local_data() As String
        Dim objetofill_withnonIndexOf As New claseActualizarIDIOMAS(curpactualizardatos)


        objetofill_withnonIndexOf.chargeArraytosend(indexOf)

        local_data = objetofill_withnonIndexOf.return_dataofcharge()

        nombreidioma.Text = local_data(0)
        cboxlectura.Text = local_data(1)
        cboxescritura.Text = local_data(2)
        cboxhablado.Text = local_data(3)

    End Sub

    Private Sub charge_lenguamaterna()

        Dim objeto_charge As New claseActualizarIDIOMAS(curpactualizardatos)

        l_materna.Text = objeto_charge.return_lengua_materna()


    End Sub


    Private Sub actualizarIDIOMAS_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        activoActualizarIdiomas = False
        btnonfatherCLOSE()
        deleteallcontain()
    End Sub

    Private Sub actualizarIDIOMAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activoActualizarIdiomas = True
        btnonfatherCARGAR()
        llenarcomboboxestextandtextbox()
        cargagrid()
        charge_lenguamaterna()

    End Sub

    Private Sub btnonfatherCARGAR()

        Dim padre = modificar

        padre.btnidiomas.BackColor = Color.Gray

    End Sub


    Private Sub btnonfatherCLOSE()
        Dim padre = modificar

        padre.btnidiomas.BackColor = Color.White
    End Sub

    Private Sub cbttipoidioma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbttipoidioma.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub cbttipoidioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbttipoidioma.SelectedIndexChanged
        detallespanel.Enabled = True
        select_IndexOf()
        fill_incharge()
    End Sub

    Private Sub cboxlectura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboxlectura.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub cboxlectura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxlectura.SelectedIndexChanged

    End Sub

    Private Sub cboxescritura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboxescritura.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub cboxescritura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxescritura.SelectedIndexChanged

    End Sub

    Private Sub cboxhablado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboxhablado.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub cboxhablado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxhablado.SelectedIndexChanged

    End Sub

    Private Sub update_data()

        If indexOf = 0 Then

            MsgBox("Seleccione Idioma", MsgBoxStyle.Exclamation, "Vidalia")

        ElseIf (indexOf = 1 Or indexOf = 2) Then

            Dim objeto_update As New claseActualizarIDIOMAS(curpactualizardatos)

            Dim data_local(3) As String

            data_local(0) = nombreidioma.Text.Trim

            data_local(1) = cboxlectura.Text.Trim
            data_local(2) = cboxescritura.Text.Trim
            data_local(3) = cboxhablado.Text.Trim

            objeto_update.update_data_all(indexOf, data_local)


        End If



    End Sub

    Private Sub guardardatos_Click(sender As Object, e As EventArgs) Handles guardardatos.Click
        update_data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Me.l_materna.Text <> "" Then

            Dim objetoUPDATE As New claseActualizarIDIOMAS(curpactualizardatos)

            objetoUPDATE.update_lenguamaterna(Me.l_materna.Text.Trim)

        Else
            MsgBox("Ingresa lengua", MsgBoxStyle.Exclamation, "Vidalia")
            Me.l_materna.Focus()
        End If

    End Sub


    Public Sub erasetext()
        cbttipoidioma.Text = ""
        nombreidioma.Clear()
        cboxlectura.Text = ""
        cboxescritura.Text = ""
        cboxhablado.Text = ""
        indexOf = 0


    End Sub

    Private Sub borrardatos_Click(sender As Object, e As EventArgs) Handles borrardatos.Click
        erasetext()
        detallespanel.Enabled = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("CONTACTO: Vidaliasupportcenter_Mysql@live.com", MsgBoxStyle.Information, "Help Contact")
    End Sub
End Class