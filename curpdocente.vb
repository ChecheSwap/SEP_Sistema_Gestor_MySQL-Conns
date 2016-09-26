Public Class curpdocente


    Private Sub clearcurp()
        datocurp.Clear()
        datocurp.Focus()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        clearcurp()


    End Sub

    Private Sub curpdocente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Welcome.Enabled = True
    End Sub

    Private Sub curpdocente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub curpdocente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearcurp()


    End Sub

    Private Sub btn1iniciowelcome_Click(sender As Object, e As EventArgs) Handles btn1iniciowelcome.Click
        Me.Close()
        Welcome.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Enabled = False
        mensageayuda.Show()



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub



   

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cerradoswelcome = 1
        Dim curplocal As String = datocurp.Text.Trim
        Dim acceslocal As Boolean = False

        Dim objeto1 As New DBVerificacioncurp(acceslocal)

        If curplocal <> "" Then

            objeto1.verificarcurp(curplocal)

            If objeto1.obtainacces() = True Then
                menu_docente_sistema_curpasynq = curplocal
                menudocentesistema.Show()
                Me.Close()
                Welcome.Close()

            ElseIf objeto1.obtainacces = False Then
                MsgBox("CURP Invalida", MsgBoxStyle.Critical, "Vidalia Advisor")

            End If

        Else

            MsgBox("Ingrese Curp", MsgBoxStyle.Information, "Vidalia")




        End If




        clearcurp()

    End Sub

    Private Sub curpdocente_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub datocurp_TextChanged(sender As Object, e As EventArgs) Handles datocurp.TextChanged

    End Sub
End Class