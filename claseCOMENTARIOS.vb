Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class claseCOMENTARIOS


    Dim command As MySqlCommand
    Dim sqlQ As String
    Dim reader As MySqlDataReader


    Private Xcurp, Xcomentario As String

    Public Sub New(ByVal comentario As String, ByVal curp As String)

        Xcurp = curp

        Xcomentario = comentario

    End Sub


    Private Sub execute_procedure()

        Dim data_order_X(5) As String

        sqlQ = "SELECT nombre1 , apellido_p , apellido_m , e_mail FROM datos_generales WHERE curp = '" + Xcurp + "'"

        command = New MySqlCommand(sqlQ, conectar)

        check_to_open()

        Try
            reader = command.ExecuteReader()

            While reader.Read()

                If reader.HasRows() Then

                    For m = 0 To 3

                        data_order_X(m) = reader(m).ToString()

                    Next m

                End If


            End While

            reader.Close()

            reader.Dispose()

            command.Dispose()

        Catch ex As Exception

            exTRY_cast(ex)

        End Try

        sqlQ = "SELECT subsistema , nombre_plantel FROM plantel_adscripcion WHERE curp = '" + Xcurp + "'"

        command.CommandText = sqlQ
        command.Connection = conectar

        Try
            reader = command.ExecuteReader()

            While reader.Read()

                If reader.HasRows() Then

                    data_order_X(4) = reader(0).ToString
                    data_order_X(5) = reader(1).ToString


                End If

            End While

            reader.Close()

            reader.Dispose()

            command.Dispose()
        Catch ex As Exception
            exTRY_cast(ex)
        End Try
        Dim fecha As String = Today.Date.ToString("yyyy-MM-dd")

        sqlQ = "INSERT INTO comentarios(fecha, nombre, ap_paterno, ap_materno,curp,e_mail,subsistema,nombre_plantel,comentario,estado) VALUES ('" + fecha + "','" + data_order_X(0) + "',  '" + data_order_X(1) + "',  '" + data_order_X(2) + "','" + Xcurp + "','" + data_order_X(3) + "','" + data_order_X(4) + "','" + data_order_X(5) + "','" + Xcomentario + "','Pendiente')"

        Try
            command.CommandText = sqlQ
            command.Connection = conectar

            command.ExecuteNonQuery()

            MsgBox("Comentario Enviado", MsgBoxStyle.Information, "Vidalia")

            command.Dispose()
        Catch ex As Exception
            exTRY_cast(ex)
        End Try



    End Sub

    Public Sub execute()
        execute_procedure()
    End Sub





End Class
