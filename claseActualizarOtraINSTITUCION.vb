Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class claseActualizarOtraINSTITUCION

    Private sqlQ As String
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader
    Private curp_central As String
    Private obtener_datos_carga_array(5) As String

    Sub New(ByVal curp As String)

        curp_central = curp

    End Sub


    Public Function validarSiexisteinstitucion()

        sqlQ = "SELECT institucion_otra_ins FROM otra_institucion WHERE curp = '" + curp_central + "'"

        Dim existe_institucion As Boolean = False
        Dim valor_estatico As String = False


        If sqlQ <> "Null" Then

            cmd = New MySqlCommand(sqlQ, conectar)

            Try
                check_to_open()
                reader = cmd.ExecuteReader()

                While reader.Read()

                    If reader.HasRows() Then

                        valor_estatico = reader(0).ToString
                    End If


                End While



                reader.Close()
            Catch ex As Exception

                exTRY_cast(ex)
            End Try


            Select Case valor_estatico

                Case Is <> ""

                    existe_institucion = True


                Case Else

                    existe_institucion = False


            End Select


        End If

        Return existe_institucion


    End Function

    Public Sub update_data(ByVal dataQ() As String)

        sqlQ = "UPDATE otra_institucion SET  institucion_otra_ins  ='" + dataQ(0) + "', nivel_educativo_otra_ins ='" + dataQ(1) + "', subsistema_otra_ins ='" + dataQ(2) + "', tipo_sostenimiento_otra_ins ='" + dataQ(3) + "', asignatura_otra_ins ='" + dataQ(4) + "', horas_impartidas_otra_ins = '" + dataQ(5) + "' WHERE curp = '" + curp_central + "'"

        If sqlQ <> "NULL" Then


            Try
                check_to_open()

                cmd = New MySqlCommand(sqlQ, conectar)

                cmd.ExecuteNonQuery()

                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information, "Vidalia")

                cmd.Dispose()

                sqlQ = "NULL"


            Catch ex As Exception
                exTRY_cast(ex)
            End Try

        End If



    End Sub


    Private Sub obtener_datos_carga()

        sqlQ = "SELECT institucion_otra_ins, nivel_educativo_otra_ins, subsistema_otra_ins, tipo_sostenimiento_otra_ins, asignatura_otra_ins, horas_impartidas_otra_ins FROM otra_institucion WHERE curp = '" + curp_central + "'"



        If sqlQ <> "NULL" Then


            cmd = New MySqlCommand(sqlQ, conectar)

            Try
                check_to_open()

                reader = cmd.ExecuteReader()

                While reader.Read()

                    If reader.HasRows() Then
                        For x = 0 To (obtener_datos_carga_array.Length - 1) Step +1

                            obtener_datos_carga_array(x) = reader(x).ToString

                        Next x

                    End If


                End While

                reader.Close()
                cmd.Dispose()

                sqlQ = "NULL"

            Catch ex As Exception
                exTRY_cast(ex)
            End Try


        End If


    End Sub

    Public Function obtenerarray_datosiniciales() As String()

        obtener_datos_carga()

        obtenerarray_datosiniciales = obtener_datos_carga_array
    End Function














End Class
