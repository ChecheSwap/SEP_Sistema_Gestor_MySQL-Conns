Public Class docente2curp

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mensageayuda.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim accesolocal2 As Boolean = False
        Dim newcurp As String = datocurp.Text.Trim

        Dim objeto1_1 As New DBVerificacioncurp(accesolocal2)

        objeto1_1.verificarcurp(newcurp)

        If objeto1_1.obtainacces = True Then
            closingdocente = 1
            menu_docente_sistema_curpasynq = newcurp
            menudocentesistema.Close()
            taskbarprocess.ShowDialog()
            cerrar.Enabled = True

        Else

            MsgBox("No existe curp, intentelo de nuevo", MsgBoxStyle.Exclamation, "Vidalia")

            datocurp.Clear()

            datocurp.Focus()

        End If





    End Sub

    Private Sub cerrar_Tick(sender As Object, e As EventArgs) Handles cerrar.Tick
        Me.Close()
        menudocentesistema.Show()
    End Sub

    Private Sub docente2curp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datocurp.Clear()
        datocurp.Focus()

    End Sub

    Private Sub docente2curp_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub btn1iniciowelcome_Click(sender As Object, e As EventArgs) Handles btn1iniciowelcome.Click
        Me.Close()
    End Sub
End Class