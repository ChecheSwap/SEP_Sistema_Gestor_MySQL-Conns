Public Class actualizarAsignaturasPorsemestre

    Private datoscargasemestre(8) As String
    Private semestreindex As Integer = 0

    Private Sub actualizarAsignaturasPorsemestre_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        activoActualizarasignaturaporsemestre = False
        reiniciarcamposall()
        cbsemestre.Items.Clear()
        botoncorrespondienteenpanelopcionesDESASIGNAR()
        semestreindex = 0
    End Sub

    Private Sub botoncorrespondienteenpanelopcionesDESASIGNAR()
        Dim octulus = modificar

        octulus.btasignaturas.BackColor = Color.White
    End Sub

    Private Sub botoncorrespondienteenpanelopcionesASIGNAR()
        Dim octulus = modificar
        octulus.btasignaturas.BackColor = Color.Gray
    End Sub

    Private Sub actualizarAsignaturasPorsemestre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        botoncorrespondienteenpanelopcionesASIGNAR()
        llenadocombocoxsemestre()
        activoActualizarasignaturaporsemestre = True
        semestreindex = 0

    End Sub

    Private Sub reiniciarcamposall()
        cbsemestre.Text = ""
        asignaturaASIGNATURA1.Clear()
        asignaturaASIGNATURA2.Clear()
        asignaturaASIGNATURA3.Clear()
        numerogruposASIGNATURA1.Clear()
        numerogruposASIGNATURA2.Clear()
        numerogruposASIGNATURA3.Clear()
        numerodealumnosporgrupoASIGNATURA1.Clear()
        numerodealumnosporgrupoASIGNATURA2.Clear()
        numerodealumnosporgrupoASIGNATURA3.Clear()
    End Sub

    Private Sub llenadocombocoxsemestre()
        cbsemestre.Items.Add("PRIMERO")
        cbsemestre.Items.Add("SEGUNDO")
        cbsemestre.Items.Add("TERCERO")
        cbsemestre.Items.Add("CUARTO")
        cbsemestre.Items.Add("QUINTO")
        cbsemestre.Items.Add("SEXTO")

    End Sub

    Private Sub borrardatos_Click(sender As Object, e As EventArgs) Handles borrardatos.Click
        reiniciarcamposall()
        semestreindex = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("CONTACTO: Vidaliasupportcenter_Mysql@live.com", MsgBoxStyle.Information, "Help Contact")
    End Sub

    Private Sub guardardatos_Click(sender As Object, e As EventArgs) Handles guardardatos.Click
        If semestreindex <> 0 Then
            llenadodatosyenvioUPDATE()
        Else
            MsgBox("SELECCIONE UN SEMESTRE VALIDO", MsgBoxStyle.Exclamation, "Vidalia Advisor")
        End If
    End Sub



    Private Sub selectorsemestre() 'SELECCIONA EL INDICE ENTERO DEL SEMESTRE PARA ESTABLECERLO EN LA VARIABLE DE PARAMETRO A FUNCION SUB (1 DE 2)

        Select Case cbsemestre.SelectedItem()

            Case Is = "PRIMERO"

                semestreindex = 1

            Case Is = "SEGUNDO"
                semestreindex = 2

            Case Is = "TERCERO"
                semestreindex = 3

            Case Is = "CUARTO"

                semestreindex = 4

            Case Is = "QUINTO"

                semestreindex = 5

            Case Is = "SEXTO"
                semestreindex = 6

            Case Else
                semestreindex = 0

        End Select
    End Sub

    Private Sub datoscargainicial() 'CREA OBJETO DE CONSULTA Y ASIGNA VALORES A MATRIZ LOCAL (2 DE 2)
        Dim objetoselectinicial As New claseASIGNATURAPORSEMESTRE()

        objetoselectinicial.selectsSemestre(curpactualizardatos, semestreindex)
        datoscargasemestre = objetoselectinicial.retornardatossemestre()



        asignaturaASIGNATURA1.Text = datoscargasemestre(0)
        numerogruposASIGNATURA1.Text = datoscargasemestre(1)
        numerodealumnosporgrupoASIGNATURA1.Text = datoscargasemestre(2)


        asignaturaASIGNATURA2.Text = datoscargasemestre(3)
        numerogruposASIGNATURA2.Text = datoscargasemestre(4)
        numerodealumnosporgrupoASIGNATURA2.Text = datoscargasemestre(5)


        asignaturaASIGNATURA3.Text = datoscargasemestre(6)
        numerogruposASIGNATURA3.Text = datoscargasemestre(7)
        numerodealumnosporgrupoASIGNATURA3.Text = datoscargasemestre(8)


    End Sub

    Private Sub cbsemestre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbsemestre.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub cbsemestre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsemestre.SelectedIndexChanged
        selectorsemestre()
        datoscargainicial()

    End Sub


    Private Sub llenadodatosyenvioUPDATE()
        datoscargasemestre(0) = asignaturaASIGNATURA1.Text.Trim
        datoscargasemestre(1) = numerogruposASIGNATURA1.Text.Trim
        datoscargasemestre(2) = numerodealumnosporgrupoASIGNATURA1.Text.Trim
        datoscargasemestre(3) = asignaturaASIGNATURA2.Text.Trim
        datoscargasemestre(4) = numerogruposASIGNATURA2.Text.Trim
        datoscargasemestre(5) = numerodealumnosporgrupoASIGNATURA2.Text.Trim
        datoscargasemestre(6) = asignaturaASIGNATURA3.Text.Trim
        datoscargasemestre(7) = numerogruposASIGNATURA3.Text.Trim
        datoscargasemestre(8) = numerodealumnosporgrupoASIGNATURA3.Text.Trim

        Dim objetoupdate As New claseASIGNATURAPORSEMESTRE()

        objetoupdate.updateasignaturaporsemestre(curpactualizardatos, datoscargasemestre, semestreindex)

    End Sub
End Class