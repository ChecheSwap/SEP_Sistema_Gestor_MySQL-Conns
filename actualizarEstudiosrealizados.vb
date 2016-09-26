Public Class actualizarEstudiosrealizados

    Private indicetipoestudio As Integer = 0

    Private arraytoupdate(3) As String

    

    Private Sub actualizarEstudiosrealizados_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        activoActualizarestudiosrealizados = False
        botoncorrespondienteCERRAR()
        deleteitemscbindice()
        indicetipoestudio = 0
    End Sub

    Private Sub actualizarEstudiosrealizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activoActualizarestudiosrealizados = True
        botoncorrespondienteACTIVAR()
        llenartipodiplomado()

    End Sub

    Private Sub botoncorrespondienteACTIVAR()
        Dim objeto1 = modificar

        objeto1.btnestudiosrealizados.BackColor = Color.Gray

    End Sub

    Private Sub botoncorrespondienteCERRAR()
        Dim objeto1 = modificar

        objeto1.btnestudiosrealizados.BackColor = Color.White
    End Sub

    Private Sub llenartipodiplomado()

        cbtipodiplomado.Items.Add("Bachillerato")
        cbtipodiplomado.Items.Add("Licenciatura")
        cbtipodiplomado.Items.Add("Maestria")
        cbtipodiplomado.Items.Add("Doctorado")

    End Sub

    Private Sub deleteitemscbindice()
        cbtipodiplomado.Items.Clear()
    End Sub

    Private Sub erasetextofallobjectsofpresentform()
        cbtipodiplomado.Text = ""
        gradoobtenido.Text = ""
        estudiosrealizados.Text = ""
        campodiciplinar.Text = ""
        institucion.Text = ""

    End Sub


    Private Sub selectorindex_abstracto()

        Select Case cbtipodiplomado.SelectedItem

            Case Is = "Bachillerato"

                indicetipoestudio = 1


            Case Is = "Licenciatura"
                indicetipoestudio = 2

            Case Is = "Maestria"
                indicetipoestudio = 3

            Case Is = "Doctorado"
                indicetipoestudio = 4

            Case Else

                indicetipoestudio = 0



        End Select

    End Sub

    Private Sub cbtipodiplomado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbtipodiplomado.KeyPress
        comboboxestexto(e)

    End Sub



    Private Sub cbtipodiplomado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtipodiplomado.SelectedIndexChanged
        grupodatos.Enabled = True
        selectorindex_abstracto()
        obtenerdatos_cargaselect()

    End Sub

    Private Sub borrardatos_Click(sender As Object, e As EventArgs) Handles borrardatos.Click
        erasetextofallobjectsofpresentform()
        indicetipoestudio = 0

    End Sub

    Private Sub obtenerdatos_cargaselect()


        Dim objetoselect As New claseActualizaestudiosrealizados()

        objetoselect.selectsinicio(indicetipoestudio, curpactualizardatos)

        Dim localdata_volcado() As String

        localdata_volcado = objetoselect.obtaindataofcharge()

        gradoobtenido.Text = localdata_volcado(0)

        estudiosrealizados.Text = localdata_volcado(1)

        campodiciplinar.Text = localdata_volcado(2)

        institucion.Text = localdata_volcado(3)

    End Sub

    Private Sub llenadoarrayforupdatetransact()

        arraytoupdate(0) = gradoobtenido.Text()
        arraytoupdate(1) = estudiosrealizados.Text
        arraytoupdate(2) = campodiciplinar.Text
        arraytoupdate(3) = institucion.Text

    End Sub

    Private Sub guardardatos_Click(sender As Object, e As EventArgs) Handles guardardatos.Click
        If indicetipoestudio = 1 Or indicetipoestudio = 2 Or indicetipoestudio = 3 Or indicetipoestudio = 4 Then

            llenadoarrayforupdatetransact()

            Dim objetotoupdate As New claseActualizaestudiosrealizados()

            objetotoupdate.updateinformation(indicetipoestudio, curpactualizardatos, arraytoupdate)

            erasetextofallobjectsofpresentform()

            indicetipoestudio = 0


        Else
            MsgBox("Seleccione Nivel de estudios", MsgBoxStyle.Exclamation, "Vidalia Advisor")

        End If
    End Sub


    
   

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("CONTACTO: Vidaliasupportcenter_Mysql@live.com", MsgBoxStyle.Information, "Help Contact")
    End Sub
End Class