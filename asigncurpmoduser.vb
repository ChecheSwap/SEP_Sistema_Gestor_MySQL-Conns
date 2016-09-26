Public Class asigncurpmoduser

    Public curpByref As String

    



    Private Sub asigncurpmoduser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        curps.Clear()
        curps.Focus()
        accesocerradocurp = False
    End Sub




    Private Sub asigncurpmoduser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If accesocerradocurp = False Then
            e.Cancel = True
        End If

    End Sub

    Private Sub asigncurpmoduser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        curps.Focus()

    End Sub

    Private Sub baceptar_Click(sender As Object, e As EventArgs) Handles baceptar.Click
        consultarcurp()


    End Sub



    Private Sub consultarcurp()

        Dim curplocal As String = curps.Text.Trim


        Select Case curplocal.Length


            Case Is = 18

                Dim objetoverificarcurp As New DBVerificacioncurp(False)
                Dim objetomodificarformapadre = modificar

                objetoverificarcurp.verificarcurp(curplocal)

                Select Case objetoverificarcurp.obtainacces()

                    Case Is = True 'SI ESXISTE LA CURP, PROCESO OK'


                        curpactualizardatos = curplocal

                        objetomodificarformapadre.habilitarpanelopcionesactualizar(curplocal)
                        accesocerradocurp = True
                        Me.Close()

                    Case Is = False

                        MsgBox("NO EXISTE LA CURP '" + curplocal + "'", MsgBoxStyle.Critical, "Vidalia Advisor")
                        curps.Clear()
                        curps.Focus()

                End Select


            Case Else

                MsgBox("Ingrese Curp Valida (18 Digitos)", MsgBoxStyle.Exclamation, "Vidalia Advisor")
                curps.Clear()
                curps.Focus()

        End Select




    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        curps.Clear()
        curps.Focus()
    End Sub
End Class