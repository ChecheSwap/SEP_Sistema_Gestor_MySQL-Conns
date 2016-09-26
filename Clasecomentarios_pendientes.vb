Imports MySql
Imports MySql.Data.MySqlClient


Public Class Clasecomentarios_pendientes

    Private x_set As DataSet
    Private x_adapter As MySqlDataAdapter
    Private x_reader As MySqlDataReader
    Private x_command As MySqlCommand
    Private sqlQ As String

    Private whats_index As Integer


    Public Sub New(ByVal index As Integer) '-1 libre,  5 fecha > , 4 fecha < x, 3 Avanzados _ 2 revisado _ 1 pendiente _ 0 todo


        If index >= 0 And index <= 2 Then

            whats_index = index

        End If


    End Sub


    Public Function executing()

        sqlQ = Nothing

        Select Case whats_index
            Case Is = 0
                sqlQ = "SELECT id_comentarios AS ID, estado AS ESTADO, fecha AS FECHA,curp AS CURP, comentario AS COMENTARIO FROM comentarios"

            Case Is = 1

                sqlQ = "SELECT id_comentarios AS ID, estado AS ESTADO, fecha AS FECHA,curp AS CURP, comentario AS COMENTARIO FROM comentarios WHERE estado = 'Pendiente'"

            Case Is = 2

                sqlQ = "SELECT id_comentarios AS ID, estado AS ESTADO, fecha AS FECHA,curp AS CURP, comentario AS COMENTARIO FROM comentarios WHERE estado = 'Atendido'"

            Case Is = 3

                sqlQ = "SELECT * FROM comentarios"


        End Select

        If sqlQ <> Nothing Then

            x_command = New MySqlCommand(sqlQ, conectar)

            x_set = New DataSet()

            x_adapter = New MySqlDataAdapter(x_command)


            Try
                check_to_open()

                x_adapter.Fill(x_set)

                x_command.Dispose()

                x_adapter.Dispose()

            Catch ex As Exception
                exTRY_cast(ex)
            End Try

        End If


        Return x_set

    End Function



    Public Sub update_state(ByVal curp As String, ByVal id_comentario As String, ByVal state As String)

        sqlQ = "UPDATE comentarios SET estado = '" + state + "' WHERE curp = '" + curp + "' AND id_comentarios = '" + id_comentario + "'"

        x_command = New MySqlCommand(sqlQ, conectar)

        Try
            x_command.Prepare()
            x_command.ExecuteNonQuery()

            MsgBox("Se ha actualizado el comentario", MsgBoxStyle.Information, "Vidalia")


            x_command.Dispose()



        Catch ex As Exception
            exTRY_cast(ex)
        End Try

    End Sub


    Public Function Validate_curp(ByVal curp As String)
        Dim val As Boolean = False

        sqlQ = "SELECT * FROM sep.comentarios WHERE curp = '" + curp + "' "

        x_command = New MySqlCommand(sqlQ, conectar)

        check_to_open()

        Try
            x_reader = x_command.ExecuteReader()

            While x_reader.Read()

                If (x_reader.HasRows() And x_reader(10).ToString <> "") Then
                    val = True


                Else
                    val = False
                End If

            End While

            x_reader.Close()

            x_reader.Dispose()

            x_command.Dispose()

        Catch ex As Exception
            exTRY_cast(ex)
        End Try


        If val = False Then
            MsgBox("No existen comentarios que cumplan criterio de busqueda", MsgBoxStyle.Information, "Vidalia")
            Dim visor = comentarios_admon

            visor.txtcurp.Clear()

        End If


        Return val

        

    End Function


    Public Function search_byCurp(ByVal curp As String)

        sqlQ = "SELECT id_comentarios AS ID, estado AS ESTADO, fecha AS FECHA,curp AS CURP, comentario AS COMENTARIO FROM comentarios WHERE curp = '" + curp + "'"

        x_command = New MySqlCommand(sqlQ, conectar)

        x_set = New DataSet()

        x_adapter = New MySqlDataAdapter(x_command)

        Try
            x_adapter.Fill(x_set)

            x_command.Dispose()

            x_adapter.Dispose()

        Catch ex As Exception
            exTRY_cast(ex)
        End Try

        Return x_set

    End Function


    Public Sub change_estado(ByVal id As String, ByVal estado As Integer)

        Select Case estado

            Case Is = 0
                sqlQ = "UPDATE comentarios SET estado = 'Pendiente' WHERE id_comentarios = '" + id + "'"

            Case Is = 1

                sqlQ = "UPDATE comentarios SET estado = 'Atendido' WHERE id_comentarios = '" + id + "'"

            Case Else
                sqlQ = Nothing

        End Select



                If sqlQ <> Nothing Then

                    x_command = New MySqlCommand(sqlQ, conectar)

                    x_command.Prepare()

                    check_to_open()
                    Try

                        x_command.ExecuteNonQuery()

                        x_command.Dispose()

                        MsgBox("Comentario Actualizado")

                    Catch ex As Exception
                        exTRY_cast(ex)
                    End Try

                End If


    End Sub


    Public Function validate_id(ByVal id As String)

        Dim acceso As Boolean = False

        sqlQ = "SELECT * FROM comentarios WHERE id_comentarios = '" + id + "'"

        x_command = New MySqlCommand(sqlQ, conectar)

        Try
            check_to_open()
            x_command.Prepare()

            x_reader = x_command.ExecuteReader()

            While x_reader.Read()

                If (x_reader.HasRows() And x_reader(5) <> "") Then
                    acceso = True
                Else
                    acceso = False
                End If

            End While

            x_reader.Close()

            x_reader.Dispose()

            x_command.Dispose()
        Catch ex As Exception
            exTRY_cast(ex)
        End Try

        Return acceso

    End Function

    Public Function Set_ByID(ByVal id As String)

        sqlQ = "SELECT id_comentarios AS ID, estado AS ESTADO, fecha AS FECHA,curp AS CURP, comentario AS COMENTARIO FROM comentarios WHERE id_comentarios = '" + id + "'"

        x_set = New DataSet()

        x_command = New MySqlCommand(sqlQ, conectar)

        x_adapter = New MySqlDataAdapter(x_command)

        check_to_open()
        Try
            x_adapter.Fill(x_set)
            x_command.Dispose()
            x_adapter.Dispose()
            sqlQ = Nothing
        Catch ex As Exception
            exTRY_cast(ex)
        End Try

        Return x_set

    End Function


    Public Function count_NewMessages()

        Dim numberofNewmessages As String = 0

        sqlQ = "SELECT COUNT(id_comentarios) FROM comentarios WHERE estado = 'Pendiente'"

        x_command = New MySqlCommand(sqlQ, conectar)

        check_to_open()

        Try
            x_command.Prepare()

            x_reader = x_command.ExecuteReader()

            While x_reader.Read()

                If x_reader.HasRows() Then
                    numberofNewmessages = x_reader(0).ToString()
                Else
                    numberofNewmessages = 0
                End If

            End While

            x_reader.Close()

            x_command.Dispose()

        Catch ex As Exception
            exTRY_cast(ex)
        End Try

        Return numberofNewmessages
    End Function




End Class
