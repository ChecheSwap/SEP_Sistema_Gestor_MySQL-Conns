Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports Microsoft.Win32.RegistryKey
Imports System.UriTypeConverter


Public Class DBVerificacioncurp
    Private acceso As Boolean

    Sub New(ByVal s As Boolean)
        acceso = s
    End Sub

    Public Sub verificarcurp(ByRef curp As String)



        Dim sqlQ As String = "SELECT * FROM  datos_generales WHERE curp = '" + curp + "' "
        Dim cmd As New MySqlCommand(sqlQ, conectar)

        Dim reader As MySqlDataReader

        check_to_open()
        reader = cmd.ExecuteReader()

        If reader.HasRows() Then
            acceso = True

        Else
            acceso = False
        End If


        reader.Close()

    End Sub


    Public Function obtainacces()
        Return acceso
    End Function


    Public Sub deletecurp(ByVal curp As String)

        Dim sqlQ As String = "DELETE FROM datos_generales WHERE curp = '" + curp + "'"
        Dim cmd As New MySqlCommand(sqlQ, conectar)


        Try
            cmd.ExecuteNonQuery()
            MsgBox("LA CURP '" + curp + "' SE HA ELIMINADO", MsgBoxStyle.Information, "Vidalia Advisor")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia Advisor")
        End Try



    End Sub



End Class
