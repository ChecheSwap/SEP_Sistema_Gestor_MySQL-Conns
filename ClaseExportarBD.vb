Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports System.Threading
Imports System
Imports System.Runtime

Public Class ClaseExportarBD

    Private x_command As MySqlCommand
    Private x_connection As MySqlConnection
    Private x_bacKupObject As MySqlBackup
    Private path_dir As String


    Public Sub New(ByVal dir As String)
        path_dir = dir
    End Sub

    Public Sub initialize_process()

        x_connection = New MySqlConnection("server=localhost;user=root;password=master;database=sep;port=3306; Convert Zero Datetime=True;")
        x_command = New MySqlCommand()
        x_command.Connection = x_connection
        x_bacKupObject = New MySqlBackup(x_command)

        If ((Not x_bacKupObject Is Nothing) And (Not path_dir Is Nothing)) Then

            Try
                x_connection.Open()

                x_bacKupObject.ExportToFile(path_dir)

                MsgBox("Se ha Exportado satisfactoriamente la base de datos", MsgBoxStyle.Information, "Vidalia")

                x_connection.Close()

                x_command.Dispose()

                x_bacKupObject.Dispose()

                path_dir = "NONE"


            Catch ex As Exception

                exTRY_cast(ex)

            End Try

           

        End If

    End Sub


End Class
