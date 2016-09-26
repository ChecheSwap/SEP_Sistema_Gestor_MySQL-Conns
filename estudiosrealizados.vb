Public Class estudiosrealizados

    Private Sub estudiosrealizados_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub estudiosrealizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Me.StartPosition = FormStartPosition.CenterScreen

        carga_grill()
    End Sub

    Private Sub estudiosrealizados_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub btn1iniciowelcome_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub carga_grill()
        Dim objetocargas As New clase_Menu_Docente_GENERAL_ALL(menu_docente_sistema_curpasynq)
        Dim myset As New DataSet()
        myset = objetocargas.charge_data_set_Byreference("estudios_realizados")
        grilla_me.DataSource = myset.Tables(0).DefaultView()

    End Sub

    Private Sub btn1iniciowelcome_Click_1(sender As Object, e As EventArgs) Handles btn1iniciowelcome.Click
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