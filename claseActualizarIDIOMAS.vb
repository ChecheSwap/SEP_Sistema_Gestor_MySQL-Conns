Imports MySql.Data.MySqlClient
Imports MySql.Data


Public Class claseActualizarIDIOMAS

    Private dataset As DataSet
    Private dataadapter As MySqlDataAdapter
    Private reader As MySqlDataReader
    Private cmd As MySqlCommand
    Private sqlQ As String
    Private curpasgo As String
    Private arraytosend(3) As String


    Sub New(ByVal curpcentral As String)

        curpasgo = curpcentral

    End Sub

    Public Function datasetobtain() As DataSet

        sqlQ = "SELECT lengua_materna AS LENGUA_MATERNA , idioma1 as IDIOMA_UNO , lectura1 as LECTURA_UNO ,hablado1 as HABLADO_UNO ,idioma2 as IDIOMA_DOS , lectura2 as LECTURA_DOS ,hablado2 as HABLADO_DOS FROM idiomas WHERE curp ='" + curpasgo + "'"

        If sqlQ <> "NULL" Then

            cmd = New MySqlCommand(sqlQ, conectar)

            dataset = New DataSet()

            dataadapter = New MySqlDataAdapter(cmd)

            Try
                check_to_open()
                dataadapter.Fill(dataset)

                cmd.Dispose()

                sqlQ = "NULL"
            Catch ex As Exception

                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia")
            End Try

           

        End If

        datasetobtain = dataset

    End Function


    Public Sub chargeArraytosend(ByVal identificador_index As Integer)


        Select Case identificador_index

            Case Is = 1

                sqlQ = "SELECT idioma1, lectura1, escritura1, hablado1 FROM idiomas WHERE curp = '" + curpasgo + "'"

                If sqlQ <> "NULL" Then

                    cmd = New MySqlCommand(sqlQ, conectar)

                    Try
                        check_to_open()
                        reader = cmd.ExecuteReader()

                        While reader.Read()

                            If reader.HasRows() Then

                                For x = 0 To (arraytosend.Length - 1) Step +1

                                    arraytosend(x) = reader(x).ToString

                                Next x


                            End If

                        End While

                        cmd.Dispose()

                        sqlQ = "NULL"

                        reader.Close()

                    Catch ex As Exception

                        exTRY_cast(ex)

                    End Try


                End If

            Case Is = 2

                sqlQ = "SELECT idioma2, lectura2, escritura2, hablado2 FROM idiomas WHERE curp = '" + curpasgo + "'"

                If sqlQ <> "NULL" Then

                    cmd = New MySqlCommand(sqlQ, conectar)

                    Try
                        check_to_open()
                        reader = cmd.ExecuteReader()

                        While reader.Read()

                            If reader.HasRows() Then

                                For x = 0 To (arraytosend.Length - 1) Step +1

                                    arraytosend(x) = reader(x).ToString

                                Next x


                            End If

                        End While

                        cmd.Dispose()

                        sqlQ = "NULL"

                        reader.Close()

                    Catch ex As Exception

                        exTRY_cast(ex)

                    End Try


                End If


        End Select

    End Sub


    Public Function return_dataofcharge() As String()

        return_dataofcharge = arraytosend

    End Function

    Public Function return_lengua_materna()

        Dim lenguamaterna As String = "NULL.64"


        sqlQ = "SELECT lengua_materna FROM idiomas WHERE curp = '" + curpasgo + "'"

        cmd = New MySqlCommand(sqlQ, conectar)

        Try
            check_to_open()

            reader = cmd.ExecuteReader()

            While reader.Read()

                If reader.HasRows() Then
                    lenguamaterna = Convert.ToString(reader(0))
                End If

            End While

            cmd.Dispose()

            sqlQ = "NULL"
        Catch ex As Exception
            exTRY_cast(ex)
        End Try

        reader.Close()

        If lenguamaterna <> "NULL.64" Then
            Return lenguamaterna
        Else
            Return 0.ToString
        End If

    End Function

    Public Sub update_lenguamaterna(ByVal datofill As String)

        sqlQ = "UPDATE idiomas SET lengua_materna='" + datofill + "' WHERE curp = '" + curpasgo + "'"

        If sqlQ <> "NULL" Then

            cmd = New MySqlCommand(sqlQ, conectar)

            Try
                check_to_open()
                cmd.ExecuteNonQuery()
                MsgBox("Se ha actualizado la Lengua Materna", MsgBoxStyle.Information, "Vidalia")
                cmd.Dispose()
                sqlQ = "NULL"

                Dim actualizargridoon_formIDIOMAS = actualizarIDIOMAS

                actualizargridoon_formIDIOMAS.cargagrid()

            Catch ex As Exception

                exTRY_cast(ex)

            End Try

        End If

    End Sub

    Public Sub update_data_all(ByVal indexOf As Integer, ByVal datos() As String)

        Dim objeto_grilla_0 = actualizarIDIOMAS


        Select Case indexOf

            Case Is = 1


                sqlQ = "UPDATE idiomas SET idioma1 = '" + datos(0) + "', lectura1 = '" + datos(1) + "',escritura1 = '" + datos(2) + "', hablado1 = '" + datos(3) + "' WHERE curp = '" + curpasgo + "'"

                If sqlQ <> "NULL" Then

                    cmd = New MySqlCommand(sqlQ, conectar)

                    Try
                        check_to_open()
                        cmd.ExecuteNonQuery()
                        MsgBox("Los datos se han guardado satisfactoriamente", MsgBoxStyle.Information, "Vidalia")
                        cmd.Dispose()
                        sqlQ = "NULL"


                        objeto_grilla_0.erasetext()
                        objeto_grilla_0.detallespanel.Enabled = False

                        objeto_grilla_0.cargagrid()

                    Catch ex As Exception
                        exTRY_cast(ex)
                    End Try



                End If


            Case Is = 2

                sqlQ = "UPDATE idiomas SET idioma2 = '" + datos(0) + "', lectura2 = '" + datos(1) + "',escritura2 = '" + datos(2) + "', hablado2 = '" + datos(3) + "' WHERE curp = '" + curpasgo + "'"

                If sqlQ <> "NULL" Then

                    cmd = New MySqlCommand(sqlQ, conectar)

                    Try
                        check_to_open()
                        cmd.ExecuteNonQuery()
                        MsgBox("Los datos se han guardado satisfactoriamente", MsgBoxStyle.Information, "Vidalia")
                        cmd.Dispose()
                        sqlQ = "NULL"

                        objeto_grilla_0.erasetext()
                        objeto_grilla_0.detallespanel.Enabled = False

                        objeto_grilla_0.cargagrid()

                    Catch ex As Exception
                        exTRY_cast(ex)
                    End Try


                End If

        End Select



    End Sub




End Class
