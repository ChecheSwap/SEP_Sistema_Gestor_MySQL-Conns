Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports MySql.Data.Types

Public Class clase_Menu_Docente_GENERAL_ALL

    Private reader As MySqlDataReader
    Private x_adapter As MySqlDataAdapter
    Private x_data_Set As DataSet
    Private x_command As MySqlCommand
    Private curp_general As String
    Private sqlQ As String

    Public Sub New(ByVal line As String)

        curp_general = line

    End Sub

    Public Function return_name()

        Dim name As String = "User"

        If (Not curp_general Is Nothing) Then

            sqlQ = "SELECT nombre1, apellido_p FROM datos_generales WHERE curp = '" + curp_general + "'"

            x_command = New MySqlCommand(sqlQ, conectar)


            check_to_open()

            Try

                reader = x_command.ExecuteReader()

                While reader.Read()

                    If reader.HasRows() Then

                        name = reader(0).ToString + " " + reader(1).ToString

                    End If


                End While

                reader.Close()

                x_command.Dispose()


            Catch ex As Exception

                exTRY_cast(ex)

            End Try


        End If


        Return name

    End Function



    Public Function charge_data_set_Byreference(ByVal type As String)

        sqlQ = "NULL"
        x_data_Set = New DataSet()

        Select Case type

            Case Is = "datos_generales"

                sqlQ = ("SELECT estatus AS ESTATUS, nombre1 as NOMBRE_1, nombre2 AS NOMBRE_2, sexo AS SEXO, fecha_nacimiento as FECHA_DE_NACIMIENTO, rfc as RFC, telefono_local AS TELEFONO_LOCAL, telefono_cel AS TELEFONO_CELULAR, edo_nacimiento as ESTADO_DE_NACIMIENTO, e_mail AS EMAIL, nacionalidad AS NACIONALIDAD, edo_civil as ESTADO_CIVIL, tiene_computadora as TIENE_COMPUTADORA,tiene_internet as TIENE_INTERNET, calle as CALLE , num_ext as NUMERO_EXTERIOR, num_int as NUMERO_INTERIOR, localidad AS LOCALIDAD ,cp as CODIGO_POSTAL, municipio_residencia as MUNICIPIO_DE_RESIDENCIA, estado_residencia as ESTADO_DE_RESIDENCIA FROM datos_generales WHERE curp = '" + curp_general + "'")

            Case Is = "plantel_adscripcion"

                sqlQ = ("SELECT subsistema AS SUBSISTEMA, tipo_sostenimiento AS SOSTENIMIENTO, nombre_plantel AS NOMBRE_DEL_PLANTEL, clave_plantel AS CLAVE_DEL_PLANTEL, cargo_ocupacion AS OCUPACION, fecha_captura AS FECHA_DE_CAPTURA, antiguedad_años AS ANIOS_DE_ANTIGUEDAD, antiguedad_meses AS MESES_DE_ANTIGUEDAD, hrs_frente_grupo AS HORAS_FRENTE_GRUPO, tipo_contratacion AS TIPO_DE_CONTRATACION, calle_plantel AS CALLE_DEL_PLANTEL, num_plantel AS NUMERO_DEL_PLANTEL, colonia_plantel AS COLONIA_PLANTEL, municipio_plantel AS MUNICIPIO_PLANTEL, cp_plantel AS CODIGO_POSTAL FROM plantel_adscripcion WHERE curp = '" + curp_general + "'")


            Case Is = "diplomado_prof"

                sqlQ = ("SELECT institucion_diplomado_dir AS INSTITUCION_DIPLOMADO_DIRECTOR, generacion_diplomado_dir AS GENERACION_DIPLOMADO_DIRECTOR, diplomado_acreditado_dir AS DIPLOMADO_ACREDITADO_DIRECTOR, certificado_diplomado_dir AS CERTIFICADO_DIPLOMADO_DIRECTOR, institucion_diplomado_docente AS INSTITUCION_DIPLOMADO_DOCENTE , generacion_diplomado_docente AS GENERACION_DIPLOMADO_DOCENTE, diplomado_acreditado_docente AS DIPLOMADO_ACREDITADO_DOCENTE, certificado_diplomado_docente AS CERTIFICADO_DIPLOMADO_DOCENTE, institucion_diplomado_carrera_concluida AS INSTITUCION_DIPLOMADO_CC, generacion_diplomado_carrera_concluida AS GENERACION_DIPLOMADO_CARRERA_CC, diplomado_acreditado_carrera_concluida AS DIPLOMADO_ACREDITADO_CARRERA_CC, certificado_diplomado_carrera_concluida AS CERTIFICADO_CARRERA_CC , institucion_diplomado_carrera_trunca AS INSTITUCION_DIPLOMADO_CARRERA_TRUNCA, generacion_diplomado_carrera_trunca AS GENERACION_DIPLOMADO_CARRERA_TRUNCA, diplomado_acreditado_carrera_trunca AS DIPLOMADO_ACREDITADO_CARRERA_TRUNCA, certificado_diplomado_carrera_trunca AS CERTIFICADO_DIPLOMADO_CARRERA_TRUNCA, institucion_diplomado_bachillerato AS INSTITUCION_DIPLOMADO_BACHILLERATO, generacion_diplomado_bachillerato AS GENERACION_DIPLOMADO_BACHILLERATO, diplomado_acreditado_bachillerato AS DIPLOMADO_ACREDITADO_BACHILLERATO, certificadio_diplomado_bachillerato AS CERTIFICADO_DIPLOMADO_BACHILLERATO FROM diplomado_profordems WHERE curp = '" + curp_general + "'")

            Case Is = "estudios_realizados"

                sqlQ = "SELECT grado_obtenido_bachillerato AS GRADO_OBTENIDO_BACHILLERATO , estudios_realizados_bachillerato AS ESTUDIOS_REALIZADOS_BACHILLERATO, campo_disciplinar_bachillerato AS CAMPO_DICIPLINAR_BACHILLERATO, institucion_bachillerato AS INSTITUCION_BACHILLERATO, grado_obtenido_licenciatura AS GRADO_OBTENIDO_LICENCIATURA, estudios_realizados_licenciatura AS ESTUDIOS_REALIZADOS_LICENCIATURA, campo_disciplinar_licenciatura AS CAMPO_DICIPLINAR_LICENCIATURA, institucion_licenciatura AS INSTITUCION_LICENCIATURA, grado_obtenido_maestria AS GRADO_OBTENIDO_MAESTRIA, estudios_realizados_maestria AS ESTUDIOS_REALIZADOS_MAESTRIA, institucion_maestria AS INSTITUCION_MAESTRIA, campo_disciplinar_maestria AS CAMPO_DICIPLINAR_MAESTRIA, grado_obtenido_doctorado AS GRADO_OBTENIDO_DOCTORADO, estudios_realizados_doctorado AS ESTUDIOS_REALIZADOS_DOCTORADO, campo_disciplinar_doctorado AS CAMPO_DICIPLINAR_DOCTORADO, institucion_doctorado AS INSTITUCION_DOCTORADO, comisionado_sabatino_de AS COMISIONADO_SABATICO_DE, comisionado_sabatino_a AS COMISIONADO_SABATICO_A FROM estudios_realizados WHERE curp = '" + curp_general + "'"

            Case Is = "idiomas"

                sqlQ = "SELECT lengua_materna AS LENGUA_MATERNA, idioma1 AS IDIOMA_1, lectura1 AS PORCENTAJE_LECTURA_IDIOMA1 , escritura1 AS PORCENTAJE_ESCRITURA_LENGUAJE_1, hablado1 AS PORCENTAJE_HALADO_LENGUAJE_1, idioma2 AS IDIOMA_2, lectura2 AS PORCENTAJE_LECTURA_LENGUAJE_2, escritura2 AS PORCENTAJE_ESCRITURA_LENGUAJE_2, hablado2 AS PORNCETAJE_HABLADO_LENGUAJE_2 FROM idiomas WHERE curp = '" + curp_general + "'"

            Case Is = "otra_institucion"

                sqlQ = "SELECT  institucion_otra_ins AS INSTITUCION, nivel_educativo_otra_ins AS NIVEL_EDUCATIVO, subsistema_otra_ins AS SUBSISTEMA, tipo_sostenimiento_otra_ins AS TIPO_DE_SOSTENIMIENTO, asignatura_otra_ins AS ASIGNATURA, horas_impartidas_otra_ins AS HORAS_IMPARTIDAS FROM otra_institucion WHERE curp = '" + curp_general + "'"

            Case Is = "exp_lab"

                sqlQ = "SELECT nom_institucion_laboral AS INSTITUCION, puesto_laboral AS PUESTO_LABORAL, años_laboral AS AÑOS_LABORANDO FROM experiencia_laboral WHERE curp = '" + curp_general + "'"

            Case Is = "asign_semestre"

                sqlQ = "SELECT asignatura11 AS ASIGNATURA_1,num_grupos_atendidos11 AS GRUPOS_ATENDIDOS_ASIGNATURA_1,num_alumnos_grupo11 AS NUMERO_ALUMNOS_GRUPO_1,asignatura21 AS ASIGNATURA_2 ,num_grupos_atendidos21 AS GRUPOS_ATENDIDOS_ASIGNATURA_2,num_alumnos_grupo21 AS NUMERO_ALUMNOS_GRUPO_2,asignatura31 AS ASIGNATURA_3 ,num_grupos_atendidos31 AS GRUPOS_ATENDIDOS_ASIGNATURA_3 ,num_alumnos_grupo31 AS NUMERO_ALUMNOS_GRUPO_3 , asignatura12 AS ASIGNATURA_1 , num_grupos_atendidos12 AS GRUPOS_ATENDIDOS_ASIGNATURA_1 ,num_alumnos_grupo12 AS NUMERO_ALUMNOS_GRUPO_1,asignatura22 AS ASIGNATURA_2 ,num_grupos_atendidos22 AS GRUPOS_ATENDIDOS_ASIGNATURA_2,num_alumnos_grupo22 AS NUMERO_ALUMNOS_GRUPO_2 ,asignatura32  AS ASIGNATURA_3 ,num_grupos_atendidos32 AS GRUPOS_ATENDIDOS_ASIGNATURA_3 ,num_alumnos_grupo32 AS NUMERO_ALUMNOS_GRUPO_3 ,asignatura13 AS ASIGNATURA_1 ,num_grupos_atendidos13 AS GRUPOS_ATENDIDOS_ASIGNATURA_1,num_alumnos_grupo13 AS NUMERO_ALUMNOS_GRUPO_1 ,asignatura23 AS ASIGNATURA_2 ,num_grupos_atendidos23 AS GRUPOS_ATENDIDOS_ASIGNATURA_2,num_alumnos_grupo23 AS NUMERO_ALUMNOS_GRUPO_2,asignatura33 AS ASIGNATURA_3 ,num_grupos_atendidos33 AS GRUPOS_ATENDIDOS_ASIGNATURA_3 ,num_alumnos_grupo33 AS NUMERO_ALUMNOS_GRUPO_3 ,asignatura14 AS ASIGNATURA_1,num_grupos_atendidos14 AS GRUPOS_ATENDIDOS_ASIGNATURA_1,num_alumnos_grupo14 AS NUMERO_ALUMNOS_GRUPO_1,asignatura24 AS ASIGNATURA_2,num_grupos_atendidos24 AS GRUPOS_ATENDIDOS_ASIGNATURA_2,num_alumnos_grupo24 AS NUMERO_ALUMNOS_GRUPO_2,asignatura34 AS ASIGNATURA_3,num_grupos_atendidos34 AS GRUPOS_ATENDIDOS_ASIGNATURA_3 ,num_alumnos_grupo34 AS NUMERO_ALUMNOS_GRUPO_3 ,asignatura15 AS ASIGNATURA_1,num_grupos_atendidos15 AS GRUPOS_ATENDIDOS_ASIGNATURA_1,num_alumnos_grupo15 AS NUMERO_ALUMNOS_GRUPO_1,asignatura25 AS ASIGNATURA_2,num_grupos_atendidos25 AS GRUPOS_ATENDIDOS_ASIGNATURA_2,num_alumnos_grupo25 AS NUMERO_ALUMNOS_GRUPO_2,asignatura35 AS ASIGNATURA_3,num_grupos_atendidos35 AS GRUPOS_ATENDIDOS_ASIGNATURA_3,num_alumnos_grupo35 AS NUMERO_ALUMNOS_GRUPO_3,asignatura16 AS ASIGNATURA_1,num_grupos_atendidos16 AS GRUPOS_ATENDIDOS_ASIGNATURA_1,num_alumnos_grupo16 AS NUMERO_ALUMNOS_GRUPO_1,asignatura26 AS ASIGNATURA_2,num_grupos_atendidos26 AS GRUPOS_ATENDIDOS_ASIGNATURA_2,num_alumnos_grupo26 AS NUMERO_ALUMNOS_GRUPO_2,asignatura36 AS ASIGNATURA_3,num_grupos_atendidos36 AS GRUPOS_ATENDIDOS_ASIGNATURA_3,num_alumnos_grupo36 AS NUMERO_ALUMNOS_GRUPO_3 FROM asignatura_semestre WHERE curp = '" + curp_general + "'"
        End Select


        If (Not sqlQ Is Nothing And sqlQ <> "") Then

            x_command = New MySqlCommand(sqlQ, conectar)

            x_adapter = New MySqlDataAdapter(x_command)



            Try
                check_to_open()

                x_adapter.Fill(x_data_Set)

                x_command.Dispose()

                x_adapter.Dispose()

            Catch ex As Exception

            End Try

        Else

            MsgBox("ERROR TO LOAD DATA BASE DATA", MsgBoxStyle.Critical, "VIDALIA")



        End If


        Return x_data_Set

    End Function

    Public Function charge_data_asignatura_semestre(ByVal index_semestre As Integer) 'REFERENCIA A DATOS ASIGNATURASEMESTRELLENADO LLENADO SET

        sqlQ = "NULL"
        x_data_Set = New DataSet()

        Select Case index_semestre

            Case Is = 1

                sqlQ = "SELECT asignatura11 AS ASIGNATURA_1,num_grupos_atendidos11 AS GRUPOS_ATENDIDOS_ASIGNATURA_1,num_alumnos_grupo11 AS NUMERO_ALUMNOS_GRUPO_1,asignatura21 AS ASIGNATURA_2 ,num_grupos_atendidos21 AS GRUPOS_ATENDIDOS_ASIGNATURA_2,num_alumnos_grupo21 AS NUMERO_ALUMNOS_GRUPO_2,asignatura31 AS ASIGNATURA_3 ,num_grupos_atendidos31 AS GRUPOS_ATENDIDOS_ASIGNATURA_3 ,num_alumnos_grupo31 AS NUMERO_ALUMNOS_GRUPO_3 FROM asignatura_semestre WHERE curp = '" + curp_general + "'  "
            Case Is = 2
                sqlQ = "SELECT asignatura12 AS ASIGNATURA_1 , num_grupos_atendidos12 AS GRUPOS_ATENDIDOS_ASIGNATURA_1 ,num_alumnos_grupo12 AS NUMERO_ALUMNOS_GRUPO_1,asignatura22 AS ASIGNATURA_2 ,num_grupos_atendidos22 AS GRUPOS_ATENDIDOS_ASIGNATURA_2,num_alumnos_grupo22 AS NUMERO_ALUMNOS_GRUPO_2 ,asignatura32  AS ASIGNATURA_3 ,num_grupos_atendidos32 AS GRUPOS_ATENDIDOS_ASIGNATURA_3 ,num_alumnos_grupo32 AS NUMERO_ALUMNOS_GRUPO_3 FROM asignatura_semestre WHERE curp = '" + curp_general + "'  "
            Case Is = 3
                sqlQ = "SELECT asignatura13 AS ASIGNATURA_1 ,num_grupos_atendidos13 AS GRUPOS_ATENDIDOS_ASIGNATURA_1,num_alumnos_grupo13 AS NUMERO_ALUMNOS_GRUPO_1 ,asignatura23 AS ASIGNATURA_2 ,num_grupos_atendidos23 AS GRUPOS_ATENDIDOS_ASIGNATURA_2,num_alumnos_grupo23 AS NUMERO_ALUMNOS_GRUPO_2,asignatura33 AS ASIGNATURA_3 ,num_grupos_atendidos33 AS GRUPOS_ATENDIDOS_ASIGNATURA_3 ,num_alumnos_grupo33 AS NUMERO_ALUMNOS_GRUPO_3 FROM asignatura_semestre WHERE curp = '" + curp_general + "'  "
            Case Is = 4
                sqlQ = "SELECT asignatura14 AS ASIGNATURA_1,num_grupos_atendidos14 AS GRUPOS_ATENDIDOS_ASIGNATURA_1,num_alumnos_grupo14 AS NUMERO_ALUMNOS_GRUPO_1,asignatura24 AS ASIGNATURA_2,num_grupos_atendidos24 AS GRUPOS_ATENDIDOS_ASIGNATURA_2,num_alumnos_grupo24 AS NUMERO_ALUMNOS_GRUPO_2,asignatura34 AS ASIGNATURA_3,num_grupos_atendidos34 AS GRUPOS_ATENDIDOS_ASIGNATURA_3 ,num_alumnos_grupo34 AS NUMERO_ALUMNOS_GRUPO_3 FROM asignatura_semestre WHERE curp = '" + curp_general + "'  "
            Case Is = 5
                sqlQ = "SELECT asignatura15 AS ASIGNATURA_1,num_grupos_atendidos15 AS GRUPOS_ATENDIDOS_ASIGNATURA_1,num_alumnos_grupo15 AS NUMERO_ALUMNOS_GRUPO_1,asignatura25 AS ASIGNATURA_2,num_grupos_atendidos25 AS GRUPOS_ATENDIDOS_ASIGNATURA_2,num_alumnos_grupo25 AS NUMERO_ALUMNOS_GRUPO_2,asignatura35 AS ASIGNATURA_3,num_grupos_atendidos35 AS GRUPOS_ATENDIDOS_ASIGNATURA_3,num_alumnos_grupo35 AS NUMERO_ALUMNOS_GRUPO_3 FROM asignatura_semestre WHERE curp = '" + curp_general + "'  "
            Case Is = 6
                sqlQ = "SELECT asignatura16 AS ASIGNATURA_1,num_grupos_atendidos16 AS GRUPOS_ATENDIDOS_ASIGNATURA_1,num_alumnos_grupo16 AS NUMERO_ALUMNOS_GRUPO_1,asignatura26 AS ASIGNATURA_2,num_grupos_atendidos26 AS GRUPOS_ATENDIDOS_ASIGNATURA_2,num_alumnos_grupo26 AS NUMERO_ALUMNOS_GRUPO_2,asignatura36 AS ASIGNATURA_3,num_grupos_atendidos36 AS GRUPOS_ATENDIDOS_ASIGNATURA_3,num_alumnos_grupo36 AS NUMERO_ALUMNOS_GRUPO_3 FROM asignatura_semestre WHERE curp = '" + curp_general + "'  "


        End Select

        If (Not sqlQ Is Nothing And sqlQ <> "NULL") Then

            x_command = New MySqlCommand(sqlQ, conectar)

            x_adapter = New MySqlDataAdapter(x_command)



            Try

                check_to_open()

                x_adapter.Fill(x_data_Set)

                x_adapter.Dispose()

                x_command.Dispose()

            Catch ex As Exception

                exTRY_cast(ex)

            End Try

        Else

            MsgBox("ERROR TO LOAD DATA BASE DATA", MsgBoxStyle.Critical, "VIDALIA")
        End If


        Return x_data_Set


    End Function

    

End Class
