Public Class Comprobar_2_

    Public barra As Double = 0.0
    Public barrapercent As String = " %"

    Private Sub Comprobar_2__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If exterminio = 0 Then
            denegarcierre(e)
        End If

    End Sub

    Private Sub Comprobar_2__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lector.Text = barra.ToString + " %"

        If barra < 100 Then
            barra = barra + 1
            ProgressBar1.Value = barra
        ElseIf barra = 100 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Timer4.Enabled = False
            Aviso.Text = "¡Equipo Compatible!"
            barra = 0
            razon_3_.Show()
            Me.Enabled = False
        End If

        If ProgressBar1.Value = 35 Then

            If My.Computer.Network.IsAvailable Then


            Else
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = False
                Timer4.Enabled = False
                Timer1.Enabled = False
                Aviso.Text = "Comprobando Network"
                MsgBox("ERROR CON CONEXION A INTERNET", MsgBoxStyle.Critical, "-Error 33")
                Dim seguir = MsgBox("¿Desea Continuar?", MsgBoxStyle.OkCancel, "SEP NOTIFICACIONES")

                If seguir = MsgBoxResult.Ok Then
                    Timer1.Enabled = True
                    Timer2.Enabled = True
                    Timer3.Enabled = True
                    Timer4.Enabled = True
                    Timer1.Enabled = True
                ElseIf seguir = MsgBoxResult.Cancel Then
                    MsgBox("SALIENDO")
                    Me.Close()
                End If
            End If
        End If
        

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100


    End Sub

    Private Sub lector_Click(sender As Object, e As EventArgs) Handles lector.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Aviso.Text = "Comprobando Equipo"

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Aviso.Text = "Leyendo Certificados"
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Aviso.Text = "Obteniendo Metadatos"
    End Sub

    Private Sub Comprobar_2__Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
End Class