Public Class dgenerales

    Private Sub dgenerales_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        menudocentesistema.Show()
    End Sub

    Private Sub dgenerales_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub dgenerales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Me.StartPosition = FormStartPosition.CenterScreen

        load_grill()
    End Sub

    Private Sub dgenerales_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub btn1iniciowelcome_Click(sender As Object, e As EventArgs) Handles btn1iniciowelcome.Click
        Me.Close()

    End Sub



    Private Sub load_grill()

        Dim Mycurp = menu_docente_sistema_curpasynq
        Dim my_set As New DataSet()

        Dim objeto As New clase_Menu_Docente_GENERAL_ALL(Mycurp)

        my_set = objeto.charge_data_set_Byreference("datos_generales")

        grilla_me.DataSource = my_set.Tables(0).DefaultView()

    End Sub

    Private Sub grilla_me_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla_me.CellContentClick

    End Sub

    Private Sub helmeadmon_Click(sender As Object, e As EventArgs) Handles helmeadmon.Click
        help_general()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comentarios As New comentarios

        comentarios.ShowDialog()
    End Sub
End Class