Public Class comentarios_admon

    Private My_data_set As DataSet

   


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        help_general()
    End Sub

    Private Sub comentarios_admon_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        erase_items()

    End Sub

    Private Sub comentarios_admon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        charge_items()
        charge_grill_Load()

    End Sub

    Private Sub charge_items()

        cbestado.Items.Add("Pendiente")
        cbestado.Items.Add("Atendido")

       

    End Sub

    Public Sub erasetext_controls()
        cbestado.Text = ""
        txtcurp.Clear()
        txtid.Clear()

    End Sub

    Private Sub erase_items()
        cbestado.Items.Clear()
        
        txtcurp.Clear()
        txtid.Clear()

        cbestado.Text = ""


    End Sub

    Public Sub charge_grill_Load()

        Dim objeto As New Clasecomentarios_pendientes(0)

        My_data_set = New DataSet()

        My_data_set = objeto.executing()

        grilla_central.DataSource = My_data_set.Tables(0).DefaultView()



    End Sub


    Private Sub charge_grill_stateFilter(ByVal index As Integer)

        Dim objeto As New Clasecomentarios_pendientes(index)

        My_data_set = New DataSet()

        My_data_set = objeto.executing()

        grilla_central.DataSource = My_data_set.Tables(0).DefaultView()

    End Sub

    Private Sub charge_grill_dateFilter(ByVal index As Integer)
        Dim objeto As New Clasecomentarios_pendientes(index)

        My_data_set = New DataSet()

        My_data_set = objeto.executing()

        grilla_central.DataSource = My_data_set.Tables(0).DefaultView()


    End Sub

    Private Sub cbestado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbestado.KeyPress
        comboboxestexto(e)
    End Sub

    Private Sub cbestado_Leave(sender As Object, e As EventArgs) Handles cbestado.Leave

    End Sub


    Private Sub cbestado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbestado.SelectedIndexChanged

        txtcurp.Text = ""
        txtid.Text = ""
        Select Case cbestado.SelectedItem()

            Case Is = "Pendiente"

                charge_grill_stateFilter(1)

            Case Is = "Atendido"

                charge_grill_stateFilter(2)

        End Select

    End Sub

    Private Sub cbfecha_KeyPress(sender As Object, e As KeyPressEventArgs)
        comboboxestexto(e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        prepared_statment_curp()

    End Sub

    Public Sub prepared_statment_curp()

        Dim curp = txtcurp.Text.Trim()

        If curp.Length = 18 Then

            Dim objeto As New Clasecomentarios_pendientes(-1)

            If objeto.Validate_curp(curp) = True Then
                My_data_set = objeto.search_byCurp(curp)

                grilla_central.DataSource = My_data_set.Tables(0).DefaultView()

                Me.txtcurp.Clear()
            End If

        Else

            MsgBox("Ingrese curp valida (18 digitos)", MsgBoxStyle.Exclamation, "Vidalia")
            txtcurp.Clear()
            txtcurp.Focus()
        End If


    End Sub

    Private Sub send_id_sear(ByVal id As String)

        Dim objeto = New Clasecomentarios_pendientes(-1)

        If objeto.validate_id(id) = True Then

            My_data_set = objeto.Set_ByID(id)

            grilla_central.DataSource = My_data_set.Tables(0).DefaultView()
        Else
            MsgBox("No existe id, intentelo de nuevo", MsgBoxStyle.Exclamation, "Vidalia")
            txtid.Clear()
            txtid.Focus()
        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        send_id_sear(Me.txtid.Text.Trim())

    End Sub

    Private Sub txtcurp_TextChanged(sender As Object, e As EventArgs) Handles txtcurp.TextChanged
        cbestado.Text = ""
        txtid.Clear()


    End Sub

    Private Sub grilla_central_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla_central.CellContentClick

    End Sub

    Private Sub grilla_central_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla_central.CellContentDoubleClick
        obtain_Data_cell_ViewComentario()
    End Sub

    Private Sub obtain_Data_cell_ViewComentario()
        Dim comentario As String = Me.grilla_central.CurrentRow.Cells(4).Value.ToString()
        Dim estado As String = Me.grilla_central.CurrentRow.Cells(1).Value.ToString()
        Dim id As String = Me.grilla_central.CurrentRow.Cells(0).Value.ToString()
        Dim curp As String = Me.grilla_central.CurrentRow.Cells(3).Value.ToString()
        Dim forma As New Ver_Comentario_admon(comentario, id, estado, curp)

        forma.Show()



    End Sub

    Private Sub borrardatos_Click(sender As Object, e As EventArgs) Handles borrardatos.Click
        btnborrar()
    End Sub

    Private Sub btnborrar()
        erasetext_controls()
        charge_grill_Load()

    End Sub

    Private Sub regresarhome_Click(sender As Object, e As EventArgs) Handles regresarhome.Click
        Me.Close()
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub
End Class