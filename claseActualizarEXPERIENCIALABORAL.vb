Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO.BufferedStream

Public Class claseActualizarEXPERIENCIALABORAL
    Private curpasgo As String
    Private sqlQ As String
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader
    Private dataset As DataSet
    Private dataadapter As MySqlDataAdapter
    Private nombreinstitucion As String
    Private datosTotalCHARGE(2) As String

    Sub New(ByVal curp As String)
        curpasgo = curp
    End Sub


    Public Sub UPDATE(ByVal arr() As String, ByVal indexof As String)

        sqlQ = "UPDATE experiencia_laboral SET nom_institucion_laboral = '" + arr(0) + "', puesto_laboral = '" + arr(1) + "' , años_laboral = '" + arr(2) + "' WHERE curp = '" + curpasgo + "' AND id_experiencia_laboral = '" + indexof + "'"

        If sqlQ <> "NULL" Then

            cmd = New MySqlCommand(sqlQ, conectar)

            Try
                check_to_open()
                cmd.ExecuteNonQuery()

                cmd.Dispose()

                sqlQ = "NULL"

                MsgBox("Actualizacion Correcta", MsgBoxStyle.Information, "Vidalia")
            Catch ex As Exception

                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia")

            End Try

        End If

    End Sub











    Public Sub obtenertrescamposinicialesparaUPDATE(ByVal indexOf As String)

        sqlQ = "SELECT  nom_institucion_laboral , puesto_laboral , años_laboral FROM experiencia_laboral WHERE id_experiencia_laboral = '" + indexOf + "' AND curp = '" + curpasgo + "'"

        If sqlQ <> "NULL" Then

            cmd = New MySqlCommand(sqlQ, conectar)

            Try
                check_to_open()

                reader = cmd.ExecuteReader()

                While reader.Read()


                    For x = 0 To 2 Step +1

                        datosTotalCHARGE(x) = reader(x).ToString

                    Next x


                End While

                reader.Close()

                cmd.Dispose()

                sqlQ = "NULL"

            Catch ex As Exception

                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia")

            End Try

        End If


    End Sub

    Public Function obtaindataofcharge() As String()

        obtaindataofcharge = datosTotalCHARGE

    End Function





    Public Sub deleteinstitution(ByVal id_void As String)

        sqlQ = "DELETE FROM experiencia_laboral WHERE id_experiencia_laboral = '" + id_void + "' AND curp = '" + curpasgo + "'"

        cmd = New MySqlCommand(sqlQ, conectar)

        Try
            check_to_open()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            sqlQ = ""
            MsgBox("Se ha eliminado satisfactoriamente el ID: " + id_void + "", MsgBoxStyle.Information, "Vidalia")

            Dim faderbladeonline = actualizarExperiencialaboral

            faderbladeonline.idELIMINAR.Clear()
            faderbladeonline.nombreregistradoELIMINAR.Clear()
            faderbladeonline.cargagrid()

            sqlQ = "NULL"
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia")
        End Try

    End Sub


    Public Function obtenernombreInstitucionById(ByVal id As String)

        Dim nombreofinstitution As String = ""

        sqlQ = "SELECT nom_institucion_laboral FROM experiencia_laboral WHERE curp = '" + curpasgo + "' AND id_experiencia_laboral = '" + id + "'"


        cmd = New MySqlCommand(sqlQ, conectar)

        Try
            check_to_open()
            reader = cmd.ExecuteReader()

            While reader.Read()

                nombreofinstitution = reader(0).ToString


            End While

            reader.Close()
            sqlQ = "NULL"
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia")
        End Try



        Return nombreofinstitution
    End Function





    Public Function validarID_EXPERIENCIA(ByVal idexperiencia As String)
        Dim volcado_onstring As String = ""
        Dim orca As Boolean = False



        sqlQ = "SELECT nom_institucion_laboral FROM experiencia_laboral WHERE curp = '" + curpasgo + "' AND id_experiencia_laboral = '" + idexperiencia + "'"

        If sqlQ <> "" Then

            cmd = New MySqlCommand(sqlQ, conectar)

            Try
                check_to_open()
                reader = cmd.ExecuteReader()

                While reader.Read()

                    volcado_onstring = reader(0).ToString

                End While

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia")
            End Try

            reader.Close()

            sqlQ = "NULL"

            Select Case volcado_onstring


                Case Is <> ""
                    orca = True

                Case Is = ""
                    orca = False
            End Select

        End If

        Return orca

    End Function





    Public Sub agregarInstitucionLaboral(ByVal datos() As String)

        sqlQ = "INSERT INTO experiencia_laboral(curp,nom_institucion_laboral,puesto_laboral,años_laboral) VALUES  ('" + curpasgo + "','" + datos(0) + "','" + datos(1) + "','" + datos(2) + "')"

        cmd = New MySqlCommand(sqlQ, conectar)

        Try
            check_to_open()
            cmd.ExecuteNonQuery()
            MsgBox("Se ha dado de alta satisfactoriamente la institución", MsgBoxStyle.Information, "Vidalia")

            sqlQ = "NULL"
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia Advisor")
        End Try

    End Sub





    Public Sub cargartablainicialonDATASET()

        sqlQ = "SELECT id_experiencia_laboral AS ID_EXPERIENCIA , nom_institucion_laboral as NOMBRE , puesto_laboral as PUESTO , años_laboral as AÑOS_EXPERIENCIA FROM experiencia_laboral WHERE curp = '" + curpasgo + "'"

        check_to_open()

        cmd = New MySqlCommand(sqlQ, conectar)

        dataadapter = New MySqlDataAdapter(cmd)

        dataset = New DataSet()

        dataadapter.Fill(dataset)

        dataadapter.Dispose()


    End Sub

    Public Function datasetenvio() As DataSet

        datasetenvio = dataset

    End Function






End Class
