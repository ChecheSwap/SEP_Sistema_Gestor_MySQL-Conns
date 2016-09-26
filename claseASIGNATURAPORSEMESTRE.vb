Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class claseASIGNATURAPORSEMESTRE

    Private sqlQ As String
    Private reader As MySqlDataReader
    Private cmd As MySqlCommand
    Private datos_semestre(8) As String


    Public Sub selectsSemestre(ByVal curp As String, ByVal identificador_semestre As Integer)

        Select Case identificador_semestre

            Case Is = 1

                sqlQ = "SELECT asignatura11,num_grupos_atendidos11,num_alumnos_grupo11,asignatura21,num_grupos_atendidos21,num_alumnos_grupo21,asignatura31,num_grupos_atendidos31,num_alumnos_grupo31 FROM asignatura_semestre WHERE curp = '" + curp + "'  "

                cmd = New MySqlCommand(sqlQ, conectar)

                Try
                    check_to_open()

                    reader = cmd.ExecuteReader()

                    While reader.Read()

                        For z = 0 To 8 Step +1
                            datos_semestre(z) = reader(z).ToString
                        Next

                    End While

                    reader.Close()

                Catch ex As Exception

                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia Advisor")
                End Try


            Case Is = 2

                sqlQ = "SELECT asignatura12,num_grupos_atendidos12,num_alumnos_grupo12,asignatura22,num_grupos_atendidos22,num_alumnos_grupo22,asignatura32,num_grupos_atendidos32,num_alumnos_grupo32 FROM asignatura_semestre WHERE curp = '" + curp + "'  "

                cmd = New MySqlCommand(sqlQ, conectar)

                Try
                    check_to_open()

                    reader = cmd.ExecuteReader()

                    While reader.Read()

                        For z = 0 To 8 Step +1
                            datos_semestre(z) = reader(z).ToString
                        Next

                    End While

                    reader.Close()
                Catch ex As Exception

                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia Advisor")
                End Try

            Case Is = 3
                sqlQ = "SELECT asignatura13,num_grupos_atendidos13,num_alumnos_grupo13,asignatura23,num_grupos_atendidos23,num_alumnos_grupo23,asignatura33,num_grupos_atendidos33,num_alumnos_grupo33 FROM asignatura_semestre WHERE curp = '" + curp + "'  "

                cmd = New MySqlCommand(sqlQ, conectar)

                Try
                    check_to_open()

                    reader = cmd.ExecuteReader()

                    While reader.Read()

                        For z = 0 To 8 Step +1
                            datos_semestre(z) = reader(z).ToString
                        Next



                    End While

                    reader.Close()

                Catch ex As Exception

                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia Advisor")
                End Try

            Case Is = 4
                sqlQ = "SELECT asignatura14,num_grupos_atendidos14,num_alumnos_grupo14,asignatura24,num_grupos_atendidos24,num_alumnos_grupo24,asignatura34,num_grupos_atendidos34,num_alumnos_grupo34 FROM asignatura_semestre WHERE curp = '" + curp + "'  "

                cmd = New MySqlCommand(sqlQ, conectar)

                Try
                    check_to_open()

                    reader = cmd.ExecuteReader()

                    While reader.Read()

                        For z = 0 To 8 Step +1
                            datos_semestre(z) = reader(z).ToString
                        Next

                    End While

                    reader.Close()

                Catch ex As Exception

                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia Advisor")
                End Try

            Case Is = 5

                sqlQ = "SELECT asignatura15,num_grupos_atendidos15,num_alumnos_grupo15,asignatura25,num_grupos_atendidos25,num_alumnos_grupo25,asignatura35,num_grupos_atendidos35,num_alumnos_grupo35 FROM asignatura_semestre WHERE curp = '" + curp + "'  "

                cmd = New MySqlCommand(sqlQ, conectar)

                Try
                    check_to_open()

                    reader = cmd.ExecuteReader()

                    While reader.Read()

                        For z = 0 To 8 Step +1
                            datos_semestre(z) = reader(z).ToString
                        Next



                    End While

                    reader.Close()

                Catch ex As Exception

                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia Advisor")
                End Try

            Case Is = 6

                check_to_open()

                sqlQ = "SELECT asignatura16,num_grupos_atendidos16,num_alumnos_grupo16,asignatura26,num_grupos_atendidos26,num_alumnos_grupo26,asignatura36,num_grupos_atendidos36,num_alumnos_grupo36 FROM asignatura_semestre WHERE curp = '" + curp + "'  "

                cmd = New MySqlCommand(sqlQ, conectar)

                Try
                    check_to_open()

                    reader = cmd.ExecuteReader()

                    While reader.Read()

                        For z = 0 To 8 Step +1

                            datos_semestre(z) = reader(z).ToString

                        Next



                    End While

                    reader.Close()

                Catch ex As Exception

                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia Advisor")
                End Try



        End Select



    End Sub


    Public Function retornardatossemestre() As String()

        retornardatossemestre = datos_semestre

    End Function


    Public Sub updateasignaturaporsemestre(ByVal curp As String, ByVal datos() As String, ByVal identificador_semestre As Integer)

        Select Case identificador_semestre


            Case Is = 1
                sqlQ = "UPDATE asignatura_semestre SET asignatura11 = '" + datos(0) + "',num_grupos_atendidos11= '" + datos(1) + "',num_alumnos_grupo11= '" + datos(2) + "',asignatura21= '" + datos(3) + "',num_grupos_atendidos21= '" + datos(4) + "',num_alumnos_grupo21= '" + datos(5) + "',asignatura31= '" + datos(6) + "',num_grupos_atendidos31= '" + datos(7) + "',num_alumnos_grupo31= '" + datos(8) + "'  WHERE curp = '" + curp + "'"


            Case Is = 2
                sqlQ = "UPDATE asignatura_semestre SET asignatura12='" + datos(0) + "',num_grupos_atendidos12='" + datos(1) + "',num_alumnos_grupo12='" + datos(2) + "',asignatura22='" + datos(3) + "',num_grupos_atendidos22='" + datos(4) + "',num_alumnos_grupo22='" + datos(5) + "',asignatura32='" + datos(6) + "',num_grupos_atendidos32='" + datos(7) + "',num_alumnos_grupo32='" + datos(8) + "'  WHERE curp = '" + curp + "'  "


            Case Is = 3

                sqlQ = "UPDATE asignatura_semestre SET asignatura13='" + datos(0) + "',num_grupos_atendidos13='" + datos(1) + "',num_alumnos_grupo13='" + datos(2) + "',asignatura23='" + datos(3) + "',num_grupos_atendidos23='" + datos(4) + "',num_alumnos_grupo23='" + datos(5) + "',asignatura33='" + datos(6) + "',num_grupos_atendidos33='" + datos(7) + "',num_alumnos_grupo33='" + datos(8) + "'  WHERE curp = '" + curp + "'  "


            Case Is = 4

                sqlQ = "UPDATE asignatura_semestre SET asignatura14='" + datos(0) + "',num_grupos_atendidos14='" + datos(1) + "',num_alumnos_grupo14='" + datos(2) + "',asignatura24='" + datos(3) + "',num_grupos_atendidos24='" + datos(4) + "',num_alumnos_grupo24='" + datos(5) + "',asignatura34='" + datos(6) + "',num_grupos_atendidos34='" + datos(7) + "',num_alumnos_grupo34='" + datos(8) + "'  WHERE curp = '" + curp + "'  "


            Case Is = 5
                sqlQ = "UPDATE asignatura_semestre SET asignatura15='" + datos(0) + "',num_grupos_atendidos15='" + datos(1) + "',num_alumnos_grupo15='" + datos(2) + "',asignatura25='" + datos(3) + "',num_grupos_atendidos25='" + datos(4) + "',num_alumnos_grupo25='" + datos(5) + "',asignatura35='" + datos(6) + "',num_grupos_atendidos35='" + datos(7) + "',num_alumnos_grupo35='" + datos(8) + "'  WHERE curp = '" + curp + "'  "


            Case Is = 6

                sqlQ = "UPDATE asignatura_semestre SET asignatura16='" + datos(0) + "',num_grupos_atendidos16='" + datos(1) + "',num_alumnos_grupo16='" + datos(2) + "',asignatura26='" + datos(3) + "',num_grupos_atendidos26='" + datos(4) + "',num_alumnos_grupo26='" + datos(5) + "',asignatura36='" + datos(6) + "',num_grupos_atendidos36='" + datos(7) + "',num_alumnos_grupo36='" + datos(8) + "'  WHERE curp = '" + curp + "'  "

        End Select

        cmd = New MySqlCommand(sqlQ, conectar)

        Try
            check_to_open()
            cmd.ExecuteNonQuery()
            MsgBox("LA CURP '" + curp.ToString + "' EN SEMESTRE '" + identificador_semestre.ToString + "' SE HA ACTUALIZADO SATISFACTORIAMENTE", MsgBoxStyle.Information, "Vidalia Advisor")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia Advisor")
        End Try


    End Sub


End Class
