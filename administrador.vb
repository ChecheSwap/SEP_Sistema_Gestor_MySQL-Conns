Public Class administrador
    Public contender As Integer
    Public statics As Integer
    Public verifed As String
    Public closever As Integer


    Sub clearpassword()
        password.Clear()
        password.Focus()
    End Sub


    Private Sub ingreso_Click(sender As Object, e As EventArgs) Handles ingreso.Click

        Dim object1ad As New DBVerificaradmin(False)

        verifed = password.Text.Trim



        If statics = 1 Then
            contender = 0
            statics = 2
        End If


        If verifed <> "" Then
            object1ad.verificationpassword(verifed)
        End If


        If verifed = "" Then
            MsgBox("Ingrese Contraseña", MsgBoxStyle.Exclamation, "Administrador Login")
            clearpassword()

        ElseIf object1ad.validarpassword() = True Then
            cerradoswelcome = 1

            password.Clear()
            closever = 1
            Me.Close()

            menu_admon.Show()
            Welcome.Close()

        Else
            MsgBox("Contraseña Incorrecta, Intentalo de nuevo", MsgBoxStyle.Critical, "Administrador Login")
            password.Clear()
            contender = contender + 1
            password.Focus()

            If contender = 3 Then
                closever = 1
                administradorbloquing.ShowDialog()
                contender = 0

            End If

        End If

    End Sub

    Private Sub btn1iniciowelcome_Click(sender As Object, e As EventArgs) Handles btn1iniciowelcome.Click
        If Async = 11 Then
            Me.Close()
            Async = -1 + 2
        End If

        closever = 1
        Me.Close()

        clearpassword()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        password.Clear()
        password.Focus()
    End Sub

    Private Sub datocurp_TextChanged(sender As Object, e As EventArgs) Handles datocurp.TextChanged

    End Sub

    Private Sub administrador_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Async = 11 Then

            Async = -1 + 2
        End If
        password.Clear()
        closever = 0
    End Sub

    Private Sub administrador_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Async = 11 Then

            Async = -1 + 2
        Else
            If closever <> 1 Then

                Dim polif As Integer = 2
                Dim argos = MsgBox("Desea Regresar a Portal de Inicio?", MsgBoxStyle.OkCancel, " Administrador Agent")
                If argos = MsgBoxResult.Cancel Then
                    e.Cancel = True
                    polif = 2 - 1

                End If
                If polif = 2 Then

                End If
            End If
        End If

    End Sub

    Private Sub administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        password.Focus()

        statics = 1

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles helmeadmon.Click
        ayudaform()
        Me.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       
        closever = 1

        leyendaaccesoadministrador.ShowDialog()



    End Sub

    Private Sub administrador_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
End Class