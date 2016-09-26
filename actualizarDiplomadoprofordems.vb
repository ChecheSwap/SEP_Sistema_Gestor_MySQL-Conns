Public Class actualizarDiplomadoprofordems

    Private indexdiplomado As Integer = 0
    Private datosselectinicio(3) As String
    Private datosupdate(3) As String

    Private Sub llenadocomboboxestotal()

        cbtipodiplomado.Items.Add("Director")
        cbtipodiplomado.Items.Add("Docente")
        cbtipodiplomado.Items.Add("Carrera Concluida")
        cbtipodiplomado.Items.Add("Carrera Trunca")
        cbtipodiplomado.Items.Add("Bachillerato")

        diplomadoacreditado.Items.Add("Si")
        diplomadoacreditado.Items.Add("No")

        certificadodiplomado.Items.Add("Si")
        certificadodiplomado.Items.Add("No")
        certificadodiplomado.Items.Add("En Proceso")
    End Sub

    Private Sub eraseallform()
        cbtipodiplomado.Items.Clear()
        cbtipodiplomado.Items.Clear()
        cbtipodiplomado.Items.Clear()
        cbtipodiplomado.Items.Clear()
        cbtipodiplomado.Items.Clear()

        diplomadoacreditado.Items.Clear()
        diplomadoacreditado.Items.Clear()

        certificadodiplomado.Items.Clear()
        certificadodiplomado.Items.Clear()
        certificadodiplomado.Items.Clear()

        instituciondiplomado.Clear()
        generaciondiplomado.Clear()

    End Sub

    Private Sub actualizarDiplomadoprofordems_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        activoActualizardiplomadoprofordems = False
        botonNOHEREDADOpanelmodificarCLOSE()
        indexdiplomado = 0
        eraseallform()

    End Sub


    Private Sub actualizarDiplomadoprofordems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        activoActualizardiplomadoprofordems = True
        botonNOHEREDADOpanelmodificarOPEN()
        llenadocomboboxestotal()
    End Sub

    Private Sub cleartextofobjects()
        cbtipodiplomado.Text = ""
        instituciondiplomado.Clear()
        generaciondiplomado.Clear()
        diplomadoacreditado.Text = ""
        certificadodiplomado.Text = ""
    End Sub

    Private Sub borrardatos_Click(sender As Object, e As EventArgs) Handles borrardatos.Click
        cleartextofobjects()
        grupodatos.Enabled = False
        indexdiplomado = 0
        cbtipodiplomado.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("CONTACTO: Vidaliasupportcenter_Mysql@live.com", MsgBoxStyle.Information, "Help Contact")
    End Sub

    Private Sub cbtipodiplomado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbtipodiplomado.KeyPress
        comboboxestexto(e)
    End Sub




    Private Sub datoscarga()
        Dim objetoselectinicio As New claseDIPLOMADOPROFORDEMS(0)

        objetoselectinicio.SelectsInicio(indexdiplomado, curpactualizardatos)
        datosselectinicio = objetoselectinicio.esreturnselectinicio()

        instituciondiplomado.Text = datosselectinicio(0)
        generaciondiplomado.Text = datosselectinicio(1)
        diplomadoacreditado.Text = datosselectinicio(2)
        certificadodiplomado.Text = datosselectinicio(3)


    End Sub


    Private Sub seleccionindexdiplomado()
        Select Case Me.cbtipodiplomado.SelectedItem

            Case Is = "Director"
                indexdiplomado = 1
            Case Is = "Docente"
                indexdiplomado = 2
            Case Is = "Carrera Concluida"
                indexdiplomado = 3
            Case Is = "Carrera Trunca"
                indexdiplomado = 4
            Case Is = "Bachillerato"
                indexdiplomado = 5

            Case Else
                indexdiplomado = 0

        End Select
    End Sub

    Private Sub cbtipodiplomado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtipodiplomado.SelectedIndexChanged
        grupodatos.Enabled = True
        seleccionindexdiplomado()
        datoscarga()
       
    End Sub

    Private Sub diplomadoacreditado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles diplomadoacreditado.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub diplomadoacreditado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles diplomadoacreditado.SelectedIndexChanged

    End Sub

    Private Sub certificadodiplomado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles certificadodiplomado.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub certificadodiplomado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles certificadodiplomado.SelectedIndexChanged

    End Sub

    Private Sub guardardatos_Click(sender As Object, e As EventArgs) Handles guardardatos.Click
        If indexdiplomado = 0 Then
            MsgBox("Seleccione un tipo de diplomado")
            cbtipodiplomado.Focus()

        ElseIf (indexdiplomado = 1 Or indexdiplomado = 2 Or indexdiplomado = 3 Or indexdiplomado = 4 Or indexdiplomado = 5) Then

            llenadoarrayupdate()

            Dim objetoupdate As New claseDIPLOMADOPROFORDEMS(0)

            objetoupdate.updatediplomadoprofordems(curpactualizardatos, indexdiplomado, datosupdate)

            cbtipodiplomado.Text = ""
            indexdiplomado = 0
            cbtipodiplomado.Focus()
        End If
    End Sub


    Private Sub llenadoarrayupdate()

        datosupdate(0) = instituciondiplomado.Text

        datosupdate(1) = generaciondiplomado.Text
        datosupdate(2) = diplomadoacreditado.Text
        datosupdate(3) = certificadodiplomado.Text



    End Sub

    Private Sub botonNOHEREDADOpanelmodificarOPEN()
        Dim objetopadre = modificar

        objetopadre.btndiplomadopfds.BackColor = Color.Gray

    End Sub

    Private Sub botonNOHEREDADOpanelmodificarCLOSE()
        Dim objetopadre2 = modificar

        objetopadre2.btndiplomadopfds.BackColor = Color.White
    End Sub

End Class