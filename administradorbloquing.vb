Public Class administradorbloquing
    Public controladorlumaemu As Integer = 0
    Public mein As Integer
    Public processtask As Integer


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles acceptbtn.Click

        If chkboxintentar.Checked = True Then
            processtask = 1
            Me.Close()
            administrador.Enabled = True

        ElseIf chkboxchange.Checked = True Then
            processtask = 1


            leyendaaccesoadministrador.ShowDialog()

            Me.Close()
        Else
            MsgBox("Debes Seleccionar Una Opcion Para Poder Continuar", MsgBoxStyle.Critical, "Vidalia Security Loging")
        End If
    End Sub

    Private Sub chkboxintentar_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxintentar.CheckedChanged
        If Me.chkboxintentar.Checked = True Then
            chkboxchange.Checked = False
        End If
    End Sub

    Private Sub chkboxchange_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxchange.CheckedChanged
        If Me.chkboxchange.Checked = True Then
            chkboxintentar.Checked = False
        End If
    End Sub

    Private Sub administradorbloquing_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        administrador.Enabled = True
    End Sub

    Private Sub administradorbloquing_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If chkboxintentar.Checked = True Then
           
        ElseIf chkboxchange.Checked = True Then
            
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub administradorbloquing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        acceptbtn.Enabled = False
        tiniciar.Enabled = True
        gruposelect.Enabled = False
        uno.Text = 0
        dos.Text = 0
        chkboxchange.Checked = False
        chkboxintentar.Checked = False
        
    End Sub

    Private Sub tiniciar_Disposed(sender As Object, e As EventArgs) Handles tiniciar.Disposed
        
    End Sub

    Private Sub tiniciar_Tick(sender As Object, e As EventArgs) Handles tiniciar.Tick
        controladorlumaemu = controladorlumaemu + 1

        If controladorlumaemu = 2 Then
            Me.cuenta.Enabled = True
            controladorlumaemu = 1
        End If

    End Sub

    Private Sub cuenta_Tick(sender As Object, e As EventArgs) Handles cuenta.Tick
        Dim endmy As Integer
        If mein = 10 Then
            mein = 0
            endmy = 50
            uno.Text = 0
            dos.Text = 1
            Me.cuenta.Enabled = False
            Me.gruposelect.Enabled = True
            Me.acceptbtn.Enabled = True
            tiniciar.Enabled = False
        End If
        If endmy <> 50 Then
            uno.Text = mein
            mein = mein + 1
        End If

    End Sub
End Class