Public Class BuscarUsuario_base

    Private My_close As Boolean = False



    Private Sub BuscarUsuario_base_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        cerrados()

        If My_close = False Then
            e.Cancel = True
        End If
    End Sub
    Private Sub BuscarUsuario_base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My_close = True Then


            My_close = False

        End If

        carga_grid()
    End Sub


    Private Sub cerrados()
        Dim close_up = MsgBox("¿Desea salir a Menu?", MsgBoxStyle.YesNo, "Vidalia")

        If close_up = MsgBoxResult.Yes Then
            My_close = True

        End If
    End Sub

    Private Sub regresarhome_Click(sender As Object, e As EventArgs) Handles regresarhome.Click
        Me.Close()
    End Sub


    Public Sub carga_grid()

        Dim toClase As New claseBuscarUSUARIO()

        Dim local_set As DataSet

        local_set = toClase.obtainSet_charge()

        datagrillauno.DataSource = local_set.Tables(0)

    End Sub


    Private Sub chargeOn_KeyPressEvents_args_CURP()

        

        Dim data As String

        data = curps.Text.Trim

        Dim object_rar As New claseBuscarUSUARIO()

        object_rar.query_central_search(data, 1)

        Dim set_center As DataSet

        set_center = object_rar.data_withQuery()

        datagrillauno.DataSource = set_center.Tables(0)

    End Sub

    Private Sub chargeOn_KeyPressEvents_args_NAME1()
       


        Dim data As String

        data = name_1.Text.Trim

        Dim object_rar As New claseBuscarUSUARIO()

        object_rar.query_central_search(data, 2)

        Dim set_center As DataSet

        set_center = object_rar.data_withQuery()

        datagrillauno.DataSource = set_center.Tables(0)
    End Sub

    Private Sub chargeOn_KeyPressEvents_args_NAME2()
        



        Dim data As String

        data = name_2.Text.Trim

        Dim object_rar As New claseBuscarUSUARIO()

        object_rar.query_central_search(data, 3)

        Dim set_center As DataSet

        set_center = object_rar.data_withQuery()

        datagrillauno.DataSource = set_center.Tables(0)
    End Sub
    Private Sub chargeOn_KeyPressEvents_args_AP1()

      




        Dim data As String

        data = ap_1.Text.Trim

        Dim object_rar As New claseBuscarUSUARIO()

        object_rar.query_central_search(data, 4)

        Dim set_center As DataSet

        set_center = object_rar.data_withQuery()

        datagrillauno.DataSource = set_center.Tables(0)
    End Sub

    Private Sub chargeOn_KeyPressEvents_args_AP2()
       
        Dim data As String

        data = ap_2.Text.Trim

        Dim object_rar As New claseBuscarUSUARIO()

        object_rar.query_central_search(data, 5)

        Dim set_center As DataSet

        set_center = object_rar.data_withQuery()

        datagrillauno.DataSource = set_center.Tables(0)
    End Sub





    Private Sub curps_KeyPress(sender As Object, e As KeyPressEventArgs) Handles curps.KeyPress
        name_1.Clear()
        name_2.Clear()
        ap_1.Clear()
        ap_2.Clear()
    End Sub

    Private Sub curps_LostFocus(sender As Object, e As EventArgs) Handles curps.LostFocus
       
    End Sub

    Private Sub curps_TextChanged(sender As Object, e As EventArgs) Handles curps.TextChanged
        chargeOn_KeyPressEvents_args_CURP()
    End Sub

    Private Sub name_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles name_1.KeyPress
        curps.Clear()
        name_2.Clear()
        ap_1.Clear()
        ap_2.Clear()
    End Sub

    Private Sub name_1_LostFocus(sender As Object, e As EventArgs) Handles name_1.LostFocus
      
    End Sub

    Private Sub name_1_TextChanged(sender As Object, e As EventArgs) Handles name_1.TextChanged
        chargeOn_KeyPressEvents_args_NAME1()
    End Sub

    Private Sub name_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles name_2.KeyPress
        curps.Clear()
        name_1.Clear()
        ap_1.Clear()
        ap_2.Clear()
    End Sub

    Private Sub name_2_LostFocus(sender As Object, e As EventArgs) Handles name_2.LostFocus
       
    End Sub

    Private Sub name_2_TextChanged(sender As Object, e As EventArgs) Handles name_2.TextChanged
        chargeOn_KeyPressEvents_args_NAME2()
    End Sub

    Private Sub ap_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ap_1.KeyPress
        curps.Clear()
        name_1.Clear()
        name_2.Clear()
        ap_2.Clear()
    End Sub

    Private Sub ap_1_LostFocus(sender As Object, e As EventArgs) Handles ap_1.LostFocus
       
    End Sub

    Private Sub ap_1_TextChanged(sender As Object, e As EventArgs) Handles ap_1.TextChanged
        chargeOn_KeyPressEvents_args_AP1()
    End Sub

    Private Sub ap_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ap_2.KeyPress
        curps.Clear()
        name_1.Clear()
        name_2.Clear()
        ap_1.Clear()
    End Sub

    Private Sub ap_2_LostFocus(sender As Object, e As EventArgs) Handles ap_2.LostFocus
        

    End Sub

    Private Sub ap_2_TextChanged(sender As Object, e As EventArgs) Handles ap_2.TextChanged
        chargeOn_KeyPressEvents_args_AP2()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        help_general()
    End Sub

    Private Sub borrardatos_Click(sender As Object, e As EventArgs) Handles borrardatos.Click
        eraseText_property()
        carga_grid()
    End Sub

    Private Sub eraseText_property()
        curps.Clear()
        name_1.Clear()
        name_2.Clear()
        ap_1.Clear()
        ap_2.Clear()

    End Sub
End Class