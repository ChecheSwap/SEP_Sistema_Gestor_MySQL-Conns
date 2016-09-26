Public Class asignaturasporsemestre

    Private mydataset As DataSet

    Private Sub asignaturasporsemestre_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        cboxSemestre.Items.Clear()
        cboxSemestre.Text = ""

    End Sub

    Private Sub asignaturasporsemestre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Me.StartPosition = FormStartPosition.CenterScreen

        charge_dataofcombobox()

        set_Load()

    End Sub

    Private Sub asignaturasporsemestre_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub btn1iniciowelcome_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub charge_dataofcombobox()
        cboxSemestre.Items.Add("PRIMERO")
        cboxSemestre.Items.Add("SEGUNDO")
        cboxSemestre.Items.Add("TERCERO")
        cboxSemestre.Items.Add("CUARTO")
        cboxSemestre.Items.Add("QUINTO")
        cboxSemestre.Items.Add("SEXTO")
    End Sub


    Private Sub set_Load()

        mydataset = New DataSet()

        Dim object_Me As New clase_Menu_Docente_GENERAL_ALL(menu_docente_sistema_curpasynq)

        mydataset = object_Me.charge_data_set_Byreference("asign_semestre")

        Me.grilla_me.DataSource = mydataset.Tables(0).DefaultView()

    End Sub


    Private Sub set_byIndex()

        Dim index As Integer

        Select Case cboxSemestre.SelectedItem()

            Case Is = "PRIMERO"
                index = 1
            Case Is = "SEGUNDO"
                index = 2
            Case Is = "TERCERO"
                index = 3
            Case Is = "CUARTO"
                index = 4
            Case Is = "QUINTO"
                index = 5
            Case Is = "SEXTO"
                index = 6

            Case Else
                index = Nothing


        End Select

        If (Not index = Nothing And index > 0 And index < 7) Then

            Dim obj As New clase_Menu_Docente_GENERAL_ALL(menu_docente_sistema_curpasynq)

            mydataset = New DataSet()

            mydataset = obj.charge_data_asignatura_semestre(index)

            grilla_me.DataSource = mydataset.Tables(0).DefaultView()

        End If






    End Sub

    Private Sub cboxSemestre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboxSemestre.KeyPress
        comboboxestexto(e)
    End Sub





    Private Sub cboxSemestre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxSemestre.SelectedIndexChanged

        set_byIndex()
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