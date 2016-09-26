Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class claseActualizarPlantelADSCRIPCION


    Private tipodiplomado As Integer = 0
    Private sqlQ As String = "NULL"
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader
    Private variabledatoscarga(14) As String
    Private curp_general As String


    Sub New(ByVal curp As String)


        curp_general = curp


    End Sub

    Private Sub data_firtscharge()

        sqlQ = "SELECT subsistema, tipo_sostenimiento, nombre_plantel, clave_plantel, cargo_ocupacion, fecha_captura, antiguedad_años, antiguedad_meses, hrs_frente_grupo, tipo_contratacion, calle_plantel, num_plantel, colonia_plantel, municipio_plantel, cp_plantel FROM plantel_adscripcion WHERE curp = '" + curp_general + "'"

        If sqlQ <> "NULL" Then

            cmd = New MySqlCommand(sqlQ, conectar)

            Try
                check_to_open()

                reader = cmd.ExecuteReader()

                While reader.Read()

                    If reader.HasRows() Then

                        For y = 0 To (variabledatoscarga.Length - 1) Step +1

                            variabledatoscarga(y) = reader(y).ToString

                        Next y


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


    Public Function obtaindatatofirstcharge() As String()

        data_firtscharge()
        obtaindatatofirstcharge = variabledatoscarga

    End Function



    Public Sub updateOnset(ByVal dates() As String)

        sqlQ = "UPDATE plantel_adscripcion SET subsistema='" + dates(0) + "', tipo_sostenimiento='" + dates(1) + "', nombre_plantel='" + dates(2) + "', clave_plantel='" + dates(3) + "', cargo_ocupacion='" + dates(4) + "', fecha_captura='" + dates(5) + "', antiguedad_años='" + dates(6) + "', antiguedad_meses='" + dates(7) + "', hrs_frente_grupo='" + dates(8) + "', tipo_contratacion='" + dates(9) + "', calle_plantel='" + dates(10) + "', num_plantel='" + dates(11) + "', colonia_plantel='" + dates(12) + "', municipio_plantel='" + dates(13) + "', cp_plantel='" + dates(14) + "' WHERE curp = '" + curp_general + "'"

        If sqlQ <> "" Then

            cmd = New MySqlCommand(sqlQ, conectar)

            Try
                check_to_open()
                cmd.ExecuteNonQuery()
                MsgBox("Datos guardados Satisfactoriamente", MsgBoxStyle.Information, "Vidalia")
                sqlQ = "NULL"

            Catch ex As Exception
                exTRY_cast(ex)
            End Try


            cmd.Dispose()

        End If
    End Sub


End Class
