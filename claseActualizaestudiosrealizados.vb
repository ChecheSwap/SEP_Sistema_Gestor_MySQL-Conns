Imports MySql.Data.MySqlClient
Imports MySql.Data



Public Class claseActualizaestudiosrealizados

    Private datoscarga(3) As String
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader
    Private sqlQ As String


    Public Sub selectsinicio(ByVal indicetipoestudio As Integer, ByVal curp As String)

        Select Case indicetipoestudio


            Case Is = 1

                sqlQ = "SELECT grado_obtenido_bachillerato , estudios_realizados_bachillerato ,campo_disciplinar_bachillerato,institucion_bachillerato FROM estudios_realizados WHERE curp = '" + curp + "'"

            Case Is = 2
                sqlQ = "SELECT grado_obtenido_licenciatura , estudios_realizados_licenciatura ,campo_disciplinar_licenciatura,institucion_licenciatura FROM estudios_realizados WHERE curp = '" + curp + "'"

            Case Is = 3

                sqlQ = "SELECT grado_obtenido_maestria , estudios_realizados_maestria ,campo_disciplinar_maestria,institucion_maestria FROM estudios_realizados WHERE curp = '" + curp + "'"

            Case Is = 4

                sqlQ = "SELECT grado_obtenido_doctorado , estudios_realizados_doctorado,campo_disciplinar_doctorado,institucion_doctorado FROM estudios_realizados WHERE curp = '" + curp + "'"

            Case Else
                MsgBox("Verifique tipo de estudios", MsgBoxStyle.Critical, "Vidalia Advisor")
        End Select


        If sqlQ <> "" Then

            cmd = New MySqlCommand(sqlQ, conectar)

            Try
                check_to_open()
                reader = cmd.ExecuteReader()

                While reader.Read()

                    If reader.HasRows() Then

                        For p = 0 To (datoscarga.Length - 1) Step +1

                            datoscarga(p) = reader(p).ToString


                        Next
                    Else
                        MsgBox("CRITICAL ERROR 33", MsgBoxStyle.Critical, "Vidalia Advisor")
                    End If

                End While

                reader.Close()

            Catch ex As Exception

                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia Advisor")

            End Try


        End If



    End Sub

    Public Function obtaindataofcharge() As String()

        obtaindataofcharge = datoscarga

    End Function


    Public Sub updateinformation(ByVal index_estudios As Integer, ByVal curp As String, ByVal datos_update() As String)

        Select Case index_estudios


            Case Is = 1

                sqlQ = "UPDATE estudios_realizados SET grado_obtenido_bachillerato = '" + datos_update(0) + "' , estudios_realizados_bachillerato = '" + datos_update(1) + "', campo_disciplinar_bachillerato = '" + datos_update(2) + "' , institucion_bachillerato = '" + datos_update(3) + "' WHERE curp = '" + curp + "'"

            Case Is = 2

                sqlQ = "UPDATE estudios_realizados SET grado_obtenido_licenciatura = '" + datos_update(0) + "' , estudios_realizados_licenciatura = '" + datos_update(1) + "', campo_disciplinar_licenciatura = '" + datos_update(2) + "' , institucion_licenciatura = '" + datos_update(3) + "' WHERE curp = '" + curp + "'"

            Case Is = 3

                sqlQ = "UPDATE estudios_realizados SET grado_obtenido_maestria = '" + datos_update(0) + "' , estudios_realizados_maestria = '" + datos_update(1) + "', campo_disciplinar_maestria = '" + datos_update(2) + "' , institucion_maestria = '" + datos_update(3) + "' WHERE curp = '" + curp + "'"

            Case Is = 4

                sqlQ = "UPDATE estudios_realizados SET grado_obtenido_doctorado = '" + datos_update(0) + "' , estudios_realizados_doctorado = '" + datos_update(1) + "', campo_disciplinar_doctorado = '" + datos_update(2) + "' , institucion_doctorado = '" + datos_update(3) + "' WHERE curp = '" + curp + "'"

            Case Else

                MsgBox("Verifique Nivel de estudios", MsgBoxStyle.Critical, "Vidalia Advisor")

        End Select

        If sqlQ <> "" Then

            cmd = New MySqlCommand(sqlQ, conectar)

            Try
                check_to_open()
                cmd.ExecuteNonQuery()

                MsgBox("La curp: " + curp + " se ha actualizado satisfactoriamente", MsgBoxStyle.Information, "Vidalia Advisor")


            Catch ex As Exception


                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia Advisor")

            End Try


        End If




    End Sub


End Class
