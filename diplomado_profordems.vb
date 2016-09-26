Public Class diplomado_profordems



    Private Sub diplomado_profordems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grill()
    End Sub


    Private Sub load_grill()

        Dim myset As New DataSet()

        Dim class_me As New clase_Menu_Docente_GENERAL_ALL(menu_docente_sistema_curpasynq)

        myset = class_me.charge_data_set_Byreference("diplomado_prof")

        grilla_me.DataSource = myset.Tables(0).DefaultView()


    End Sub

    Private Sub btn1iniciowelcome_Click(sender As Object, e As EventArgs) Handles btn1iniciowelcome.Click
        Me.Close()
    End Sub

    Private Sub helmeadmon_Click(sender As Object, e As EventArgs) Handles helmeadmon.Click
        help_general()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comentarios As New comentarios

        comentarios.ShowDialog()
    End Sub
End Class