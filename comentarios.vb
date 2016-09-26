Public Class comentarios

    Private comentario As String



    Private Sub comentarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        menudocentesistema.Show()
    End Sub

    Private Sub comentarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Me.StartPosition = FormStartPosition.CenterScreen

        clear_richtext()
    End Sub

    Private Sub comentarios_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub btn1iniciowelcome_Click(sender As Object, e As EventArgs) Handles btn1iniciowelcome.Click
        Me.Close()

    End Sub

    Private Sub to_Send(ByVal comentario_ME As String)

        Dim myobject As New claseCOMENTARIOS(comentario_ME, menu_docente_sistema_curpasynq)

        myobject.execute()


    End Sub

    Private Sub clear_richtext()
        If (rtbox.Text <> Nothing) Then


            rtbox.Text = Nothing


        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (rtbox.Text <> Nothing) Then
            comentario = rtbox.Text.TrimStart
            to_Send(comentario)
            clear_richtext()
        Else

            MsgBox("Ingrese comentario", MsgBoxStyle.Information, "Vidalia")
            rtbox.Focus()

        End If


    End Sub

    Private Sub helmeadmon_Click(sender As Object, e As EventArgs) Handles helmeadmon.Click
        help_general()
    End Sub
End Class