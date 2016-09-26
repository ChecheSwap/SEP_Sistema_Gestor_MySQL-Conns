Imports MySql.Data.MySqlClient
Imports MySql.Data


Public Class claseBuscarUSUARIO

    Private dataAdapter As MySqlDataAdapter
    Private dataset As DataSet
    Private cmd As MySqlCommand
    Private sqlQ As String = "NULL"


    Private Sub charge_inLOADS()

        sqlQ = "SELECT curp AS CURP, estatus AS ESTATUS, apellido_p AS APELLIDO_1, apellido_m AS APELLIDO_2, nombre1 AS NOMBRE_1, nombre2 AS NOMBRE_2, sexo AS SEXO, fecha_nacimiento AS FECHA_NACIMIENTO, rfc AS RFC, telefono_local AS TELEFONO_LOCAL, telefono_cel AS TELEFONO_CELULAR, edo_nacimiento AS ESTADO_NACIMIENTO, e_mail AS CORREO_ELECTRONICO, nacionalidad AS NACIONALIDAD, edo_civil AS ESTADO_CIVIL, tiene_computadora AS TIENE_COMPUTADORA, tiene_internet AS TIENE_INTERNET, calle AS CALLE, num_ext AS NUMERO_EXTERIOR, num_int AS NUMERO_INTERIOR, localidad AS LOCALIDAD, cp AS CODIGO_POSTAL, municipio_residencia AS MUNICIPIO_RESIDENCIA, estado_residencia AS ESTADO_RESIDENCIA, comentario_domicilio AS COMENTARIO_DE_DOMICILIO FROM datos_generales"

        If sqlQ <> "NULL" Then

            Try
                check_to_open()

                cmd = New MySqlCommand(sqlQ, conectar)

                dataset = New DataSet()

                dataAdapter = New MySqlDataAdapter(cmd)

                dataAdapter.Fill(dataset)

                cmd.Dispose()
            Catch ex As Exception
                exTRY_cast(ex)
            End Try

        End If

    End Sub


    Public Function obtainSet_charge() As DataSet
        charge_inLOADS()

        obtainSet_charge = dataset

    End Function


    Public Sub query_central_search(ByVal data As String, ByVal index_of_query As Integer)

        Select Case index_of_query

            Case Is = 1
                sqlQ = "SELECT curp AS CURP, estatus AS ESTATUS, apellido_p AS APELLIDO_1, apellido_m AS APELLIDO_2, nombre1 AS NOMBRE_1, nombre2 AS NOMBRE_2, sexo AS SEXO, fecha_nacimiento AS FECHA_NACIMIENTO, rfc AS RFC, telefono_local AS TELEFONO_LOCAL, telefono_cel AS TELEFONO_CELULAR, edo_nacimiento AS ESTADO_NACIMIENTO, e_mail AS CORREO_ELECTRONICO, nacionalidad AS NACIONALIDAD, edo_civil AS ESTADO_CIVIL, tiene_computadora AS TIENE_COMPUTADORA, tiene_internet AS TIENE_INTERNET, calle AS CALLE, num_ext AS NUMERO_EXTERIOR, num_int AS NUMERO_INTERIOR, localidad AS LOCALIDAD, cp AS CODIGO_POSTAL, municipio_residencia AS MUNICIPIO_RESIDENCIA, estado_residencia AS ESTADO_RESIDENCIA, comentario_domicilio AS COMENTARIO_DE_DOMICILIO FROM datos_generales WHERE curp LIKE '" + data + "%' "
            Case Is = 2
                sqlQ = "SELECT curp AS CURP, estatus AS ESTATUS, apellido_p AS APELLIDO_1, apellido_m AS APELLIDO_2, nombre1 AS NOMBRE_1, nombre2 AS NOMBRE_2, sexo AS SEXO, fecha_nacimiento AS FECHA_NACIMIENTO, rfc AS RFC, telefono_local AS TELEFONO_LOCAL, telefono_cel AS TELEFONO_CELULAR, edo_nacimiento AS ESTADO_NACIMIENTO, e_mail AS CORREO_ELECTRONICO, nacionalidad AS NACIONALIDAD, edo_civil AS ESTADO_CIVIL, tiene_computadora AS TIENE_COMPUTADORA, tiene_internet AS TIENE_INTERNET, calle AS CALLE, num_ext AS NUMERO_EXTERIOR, num_int AS NUMERO_INTERIOR, localidad AS LOCALIDAD, cp AS CODIGO_POSTAL, municipio_residencia AS MUNICIPIO_RESIDENCIA, estado_residencia AS ESTADO_RESIDENCIA, comentario_domicilio AS COMENTARIO_DE_DOMICILIO FROM datos_generales WHERE nombre1 LIKE '" + data + "%' "
            Case Is = 3
                sqlQ = "SELECT curp AS CURP, estatus AS ESTATUS, apellido_p AS APELLIDO_1, apellido_m AS APELLIDO_2, nombre1 AS NOMBRE_1, nombre2 AS NOMBRE_2, sexo AS SEXO, fecha_nacimiento AS FECHA_NACIMIENTO, rfc AS RFC, telefono_local AS TELEFONO_LOCAL, telefono_cel AS TELEFONO_CELULAR, edo_nacimiento AS ESTADO_NACIMIENTO, e_mail AS CORREO_ELECTRONICO, nacionalidad AS NACIONALIDAD, edo_civil AS ESTADO_CIVIL, tiene_computadora AS TIENE_COMPUTADORA, tiene_internet AS TIENE_INTERNET, calle AS CALLE, num_ext AS NUMERO_EXTERIOR, num_int AS NUMERO_INTERIOR, localidad AS LOCALIDAD, cp AS CODIGO_POSTAL, municipio_residencia AS MUNICIPIO_RESIDENCIA, estado_residencia AS ESTADO_RESIDENCIA, comentario_domicilio AS COMENTARIO_DE_DOMICILIO FROM datos_generales WHERE nombre2 LIKE '" + data + "%' "
            Case Is = 4
                sqlQ = "SELECT curp AS CURP, estatus AS ESTATUS, apellido_p AS APELLIDO_1, apellido_m AS APELLIDO_2, nombre1 AS NOMBRE_1, nombre2 AS NOMBRE_2, sexo AS SEXO, fecha_nacimiento AS FECHA_NACIMIENTO, rfc AS RFC, telefono_local AS TELEFONO_LOCAL, telefono_cel AS TELEFONO_CELULAR, edo_nacimiento AS ESTADO_NACIMIENTO, e_mail AS CORREO_ELECTRONICO, nacionalidad AS NACIONALIDAD, edo_civil AS ESTADO_CIVIL, tiene_computadora AS TIENE_COMPUTADORA, tiene_internet AS TIENE_INTERNET, calle AS CALLE, num_ext AS NUMERO_EXTERIOR, num_int AS NUMERO_INTERIOR, localidad AS LOCALIDAD, cp AS CODIGO_POSTAL, municipio_residencia AS MUNICIPIO_RESIDENCIA, estado_residencia AS ESTADO_RESIDENCIA, comentario_domicilio AS COMENTARIO_DE_DOMICILIO FROM datos_generales WHERE apellido_p LIKE '" + data + "%' "
            Case Is = 5
                sqlQ = "SELECT curp AS CURP, estatus AS ESTATUS, apellido_p AS APELLIDO_1, apellido_m AS APELLIDO_2, nombre1 AS NOMBRE_1, nombre2 AS NOMBRE_2, sexo AS SEXO, fecha_nacimiento AS FECHA_NACIMIENTO, rfc AS RFC, telefono_local AS TELEFONO_LOCAL, telefono_cel AS TELEFONO_CELULAR, edo_nacimiento AS ESTADO_NACIMIENTO, e_mail AS CORREO_ELECTRONICO, nacionalidad AS NACIONALIDAD, edo_civil AS ESTADO_CIVIL, tiene_computadora AS TIENE_COMPUTADORA, tiene_internet AS TIENE_INTERNET, calle AS CALLE, num_ext AS NUMERO_EXTERIOR, num_int AS NUMERO_INTERIOR, localidad AS LOCALIDAD, cp AS CODIGO_POSTAL, municipio_residencia AS MUNICIPIO_RESIDENCIA, estado_residencia AS ESTADO_RESIDENCIA, comentario_domicilio AS COMENTARIO_DE_DOMICILIO FROM datos_generales WHERE apellido_m LIKE '" + data + "%' "
        End Select




        If sqlQ <> "" Then

            cmd = New MySqlCommand(sqlQ, conectar)

            dataset = New DataSet

            Try
                check_to_open()

                dataAdapter = New MySqlDataAdapter(cmd)

                dataAdapter.Fill(dataset)

                cmd.Dispose()

                sqlQ = "NULL"
            Catch ex As Exception
                exTRY_cast(ex)
            End Try

        End If

    End Sub

    Public Function data_withQuery() As DataSet

        Return dataset

    End Function


















End Class
