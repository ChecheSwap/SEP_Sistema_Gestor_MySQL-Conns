Imports System.Threading
Imports System.UriComponents

Public Class ExportarBasededatos_FILE


    Private advisor As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        help_general()
    End Sub

    Public Sub to_load_values()

        advisor = Nothing
        txt_pathView.Text = ""

    End Sub


    Private Sub ExportarBasededatos_FILE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        to_load_values()
    End Sub




    Private Sub obtain_path_to_send_EXECUTEMINING()

        Dim path_x As String

        If txt_pathView.Text <> "" Then
            path_x = (txt_pathView.Text.Trim + "\SEP.Sql")

            Dim objeto_functions As New ClaseExportarBD(path_x)

            Dim thread_db As New Thread(AddressOf objeto_functions.initialize_process)

            Try


                thread_db.Start()

                to_load_values()

            Catch ex As Exception
                exTRY_cast(ex)
            End Try
        Else

            MsgBox("Seleccione un directorio a exportar", MsgBoxStyle.Critical, "Vidalia")

        End If






    End Sub

    Private Sub fbdialog_HelpRequest(sender As Object, e As EventArgs) Handles fbdialog.HelpRequest

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        obtain_path_to_send_EXECUTEMINING()
    End Sub

    Private Sub timeInspace_Tick(sender As Object, e As EventArgs) Handles timeInspace.Tick
        If (Not advisor = Nothing) Then

            If (Not fbdialog.SelectedPath Is Nothing) Then

                txt_pathView.Text = fbdialog.SelectedPath()

                fbdialog.SelectedPath = Nothing
                advisor = Nothing
                Me.timeInspace.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        advisor = 1
        fbdialog.ShowDialog()
        timeInspace.Enabled = True
    End Sub

    Private Sub regresarhome_Click(sender As Object, e As EventArgs) Handles regresarhome.Click
        Me.Close()
    End Sub

    Private Sub borrardatos_Click(sender As Object, e As EventArgs) Handles borrardatos.Click
        to_load_values()
    End Sub
End Class