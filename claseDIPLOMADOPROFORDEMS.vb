Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class claseDIPLOMADOPROFORDEMS

    Private tipodiplomado As Integer = 0
    Private sqlQ As String
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader
    Private variabledatoscarga(3) As String
    Private arraysdatosenvio(3) As String

    Sub New(inicioceroVarinstancia As Integer)

        tipodiplomado = inicioceroVarinstancia

    End Sub


    Public Sub SelectsInicio(ByVal indexdiplomado As Integer, ByVal curp As String)

        If indexdiplomado = 0 Then
            MsgBox("Error, consulte tipo diplomado", MsgBoxStyle.Critical, "Vidalia Advisor")
        Else

            Select Case indexdiplomado


                Case Is = 1

                    sqlQ = "SELECT institucion_diplomado_dir,generacion_diplomado_dir,diplomado_acreditado_dir,certificado_diplomado_dir FROM diplomado_profordems WHERE curp = '" + curp + "'"

                Case Is = 2

                    sqlQ = "SELECT institucion_diplomado_docente,generacion_diplomado_docente,diplomado_acreditado_docente,certificado_diplomado_docente FROM diplomado_profordems WHERE curp ='" + curp + "'"

                Case Is = 3

                    sqlQ = "SELECT institucion_diplomado_carrera_concluida,  generacion_diplomado_carrera_concluida,    diplomado_acreditado_carrera_concluida  ,certificado_diplomado_carrera_concluida FROM diplomado_profordems WHERE curp = '" + curp + "'"

                Case Is = 4

                    sqlQ = "SELECT institucion_diplomado_carrera_trunca,  generacion_diplomado_carrera_trunca,    diplomado_acreditado_carrera_trunca  ,certificado_diplomado_carrera_trunca FROM diplomado_profordems WHERE curp = '" + curp + "'"

                Case Is = 5

                    sqlQ = "SELECT institucion_diplomado_bachillerato,  generacion_diplomado_bachillerato,    diplomado_acreditado_bachillerato  ,certificadio_diplomado_bachillerato FROM diplomado_profordems WHERE curp = '" + curp + "'"

            End Select
        End If



        If sqlQ <> "" Then

            cmd = New MySqlCommand(sqlQ, conectar)



            Try
                check_to_open()
                reader = cmd.ExecuteReader()

                While reader.Read()


                    If reader.HasRows() Then

                        For f = 0 To (variabledatoscarga.Length - 1) Step +1

                            variabledatoscarga(f) = reader(f).ToString

                        Next f



                    End If

                End While

                reader.Close()

            Catch ex As Exception

                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia Advisor")

            End Try


        End If

    End Sub

    Public Function esreturnselectinicio() As String()

        esreturnselectinicio = variabledatoscarga

    End Function

    Public Sub updatediplomadoprofordems(ByVal curp As String, ByVal indexdiplomado As Integer, ByVal datos() As String)

        If indexdiplomado <> 0 Then



            Select Case indexdiplomado

                Case Is = 1

                    sqlQ = "UPDATE diplomado_profordems SET institucion_diplomado_dir = '" + datos(0) + "',generacion_diplomado_dir= '" + datos(1) + "',diplomado_acreditado_dir= '" + datos(2) + "',certificado_diplomado_dir= '" + datos(3) + "'  WHERE curp = '" + curp + "'"

                Case Is = 2

                    sqlQ = "UPDATE diplomado_profordems SET institucion_diplomado_docente = '" + datos(0) + "',generacion_diplomado_docente= '" + datos(1) + "',diplomado_acreditado_docente= '" + datos(2) + "',certificado_diplomado_docente= '" + datos(3) + "' WHERE curp = '" + curp + "'"

                Case Is = 3

                    sqlQ = "UPDATE diplomado_profordems SET institucion_diplomado_carrera_concluida= '" + datos(0) + "',generacion_diplomado_carrera_concluida = '" + datos(1) + "',diplomado_acreditado_carrera_concluida= '" + datos(2) + "',certificado_diplomado_carrera_concluida= '" + datos(3) + "' WHERE curp = '" + curp + "'"
                Case Is = 4

                    sqlQ = "UPDATE diplomado_profordems SET institucion_diplomado_carrera_trunca= '" + datos(0) + "',generacion_diplomado_carrera_trunca = '" + datos(1) + "',diplomado_acreditado_carrera_trunca= '" + datos(2) + "',certificado_diplomado_carrera_trunca= '" + datos(3) + "' WHERE curp = '" + curp + "'"

                Case Is = 5


                    sqlQ = "UPDATE diplomado_profordems SET institucion_diplomado_bachillerato= '" + datos(0) + "',generacion_diplomado_bachillerato = '" + datos(1) + "',diplomado_acreditado_bachillerato= '" + datos(2) + "',certificadio_diplomado_bachillerato= '" + datos(3) + "' WHERE curp = '" + curp + "'"

            End Select



            If sqlQ <> "" Then


                cmd = New MySqlCommand(sqlQ, conectar)

                Try
                    check_to_open()
                    cmd.ExecuteNonQuery()
                    MsgBox("La CURP = " + curp + " se ha actualizado satisfactoriamente", MsgBoxStyle.Information, "Vidalia Advisor")
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia Advisor")
                End Try

            End If



        Else

            MsgBox("Error, consulte tipo diplomado", MsgBoxStyle.Critical, "Vidalia Advisor")



        End If
    End Sub




End Class
