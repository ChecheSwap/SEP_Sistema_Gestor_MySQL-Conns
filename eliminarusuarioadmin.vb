Public Class eliminarusuarioadmin

    Private objetovalidatecurp As New DBVerificacioncurp(False)
    Private querycurp As String = ""






    Private Sub nombredocente()


        Dim objetonombrefull As New selectsinnod
        Dim nombre As String = objetonombrefull.selectNombrefull(querycurp)
        nombrestotals.Text = nombre


    End Sub






    Private Function validarcurp()

        Dim ok As Boolean = False

        querycurp = curps.Text.Trim

        Select Case querycurp.Length

            Case Is = 18

                objetovalidatecurp.verificarcurp(querycurp)

                If objetovalidatecurp.obtainacces() = False Then
                    MsgBox("LA CURP NO EXISTE EN EL SISTEMA", MsgBoxStyle.Exclamation, "Vidalia Advisor")
                    ok = False
                    curps.Clear()
                    curps.Focus()
                ElseIf objetovalidatecurp.obtainacces() = True Then

                    ok = True
                    nombredocente()
                End If


            Case Else
                MsgBox("Inserte Curp Valida (18 Digitos)", MsgBoxStyle.Exclamation, "Vidalia Advisor")
                curps.Clear()
                curps.Focus()

        End Select

        Return ok


    End Function


    Private Sub cleardataofform()

        curps.Clear()
        nombrestotals.Clear()
        curps.Focus()


    End Sub

    Private Sub eliminarusuarioadmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        cleardataofform()
        curps.Focus()
    End Sub

    Private Sub eliminarusuarioadmin_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        cleardataofform()
    End Sub




    Private Sub eliminarusuarioadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        curps.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("CONTACTO: Vidaliasupportcenter_Mysql@live.com", MsgBoxStyle.Information, "Help Contact")
    End Sub

    Private Sub regresarhome_Click(sender As Object, e As EventArgs) Handles regresarhome.Click
        Dim tiamat = MsgBox("¿Desea regresar a Menú?", MsgBoxStyle.YesNo, "Vidalia Advisor")
        If tiamat = MsgBoxResult.Yes Then
            Me.Close()
        Else
            curps.Focus()

        End If
    End Sub

    Private Sub borrardatos_Click(sender As Object, e As EventArgs) Handles borrardatos.Click
        cleardataofform()
    End Sub

    Private Sub guardardatos_Click(sender As Object, e As EventArgs) Handles guardardatos.Click


        Select Case validarcurp()
            Case Is = True
                objetovalidatecurp.deletecurp(querycurp)
                cleardataofform()

        End Select



    End Sub

    Private Sub cargarcurps_Click(sender As Object, e As EventArgs) Handles cargarcurps.Click
        validarcurp()


    End Sub
End Class