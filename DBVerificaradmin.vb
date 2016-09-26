Imports MySql.Data.MySqlClient

Public Class DBVerificaradmin

    Private procedurevar As Boolean
    Private procedurecodigo As Boolean





    Sub New(ByRef procedure As Boolean)

        procedurevar = procedure
        procedurecodigo = procedure

    End Sub

    Sub verificationpassword(ByRef pass As String)
       

        Dim sqlQ As String = "SELECT * FROM  administrador WHERE admonkey = '" + pass + "' "



        Dim cmd As New MySqlCommand(sqlQ, conectar)



        Dim reader As MySqlDataReader

        check_to_open()

        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            procedurevar = True

        Else
            procedurevar = False
        End If



        reader.Close()

    End Sub

    Public Function validarpassword()

        Return procedurevar

    End Function


    Sub updatepassword(ByRef npass As String)

        Dim sqlQ As String = "UPDATE administrador SET admonkey = '" + npass + "' WHERE IDadmon = '1' "

        Dim cmd As New MySqlCommand(sqlQ, conectar)

        check_to_open()

        cmd.ExecuteNonQuery()

    End Sub

    Sub validarcodigo(ByRef code As String)


        Dim sqlQ As String = "SELECT * FROM administrador WHERE leyenda_acceso = '" + code + "'"
        Dim cmd As New MySqlCommand(sqlQ, conectar)
        Dim reader As MySqlDataReader

        check_to_open()

        reader = cmd.ExecuteReader()

        If reader.HasRows() Then
            procedurecodigo = True

        Else
            procedurecodigo = False
        End If

        reader.Close()

    End Sub

    Function accesocodigo()
        Return procedurecodigo
    End Function

End Class
