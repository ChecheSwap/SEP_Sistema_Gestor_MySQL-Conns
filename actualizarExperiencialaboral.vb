Public Class actualizarExperiencialaboral
    Private dataset As DataSet
    Private arrayaddinstitucion(2) As String
    Private arrayupdateinstitucion(2) As String


    Private Sub clearAgregarinstitucion()
        nombreinstitucionAGREGARUSUARIO.Clear()
        puestolaboralAGREGARUSUARIO.Clear()
        añoslaborandoAGREGARUSUARIO.Clear()

    End Sub

    Private Sub clearEliminarinstitucion()
        idELIMINAR.Clear()
        nombreregistradoELIMINAR.Clear()


    End Sub

    Private Sub clearModificarinstitucion()
        idexperienciaUPDATE.Clear()
        charge1UPDATE.Clear()
        charge2UPDATE.Clear()
        charge3UPDATE.Clear()



    End Sub


    


    Private Sub actualizarExperiencialaboral_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        activoactualizarExperiencialaboral = False
        btnpanelmodificarNO()
    End Sub

    Private Sub actualizarExperiencialaboral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activoactualizarExperiencialaboral = True
        btnpanelmodificarOK()
        cargagrid()

    End Sub

    Private Sub btnpanelmodificarOK()

        Dim padre = modificar

        padre.btnexperiencia_laboral.BackColor = Color.Gray


    End Sub


    Private Sub btnpanelmodificarNO()
        Dim padre = modificar

        padre.btnexperiencia_laboral.BackColor = Color.White

    End Sub


    Public Sub cargagrid()

        Dim objetotogrid As New claseActualizarEXPERIENCIALABORAL(curpactualizardatos)

        objetotogrid.cargartablainicialonDATASET()

        dataset = objetotogrid.datasetenvio()

        datagridviewexplaboral.DataSource = dataset.Tables(0).DefaultView


    End Sub

    Private Sub borrardatos_Click(sender As Object, e As EventArgs) Handles borrardatos.Click
        clearAgregarinstitucion()
        clearEliminarinstitucion()
        clearModificarinstitucion()
        lockcampstoUPDATE()
        btnUPDATE.Enabled = False

    End Sub

    Private Sub chargeandvalidatedataofAGREGARINSTITUCION()

        'arrayaddinstitucion
        'nombreinstitucionAGREGARUSUARIO.Clear()
        'puestolaboralAGREGARUSUARIO.Clear()
        'añoslaborandoAGREGARUSUARIO.Clear()

        If (nombreinstitucionAGREGARUSUARIO.Text.Trim <> "" And puestolaboralAGREGARUSUARIO.Text.Trim <> "" And añoslaborandoAGREGARUSUARIO.Text.Trim <> "") Then

            arrayaddinstitucion(0) = nombreinstitucionAGREGARUSUARIO.Text.TrimEnd()
            arrayaddinstitucion(1) = puestolaboralAGREGARUSUARIO.Text.TrimEnd()
            arrayaddinstitucion(2) = añoslaborandoAGREGARUSUARIO.Text.TrimEnd()


            Dim objetoAGREGARINSTITUCION As New claseActualizarEXPERIENCIALABORAL(curpactualizardatos)

            objetoAGREGARINSTITUCION.agregarInstitucionLaboral(arrayaddinstitucion)

            cargagrid()
            clearAgregarinstitucion()

        Else

            MsgBox("Ingrese almenos un caracter en los campos solicitados", MsgBoxStyle.Exclamation, "Vidalia")
        End If



    End Sub


    







    Private Sub guardardatos_Click(sender As Object, e As EventArgs) Handles guardardatos.Click
        chargeandvalidatedataofAGREGARINSTITUCION()
    End Sub


    Private Function validarID(ByVal idacomparar As String)
        Dim objetoacceso As New claseActualizarEXPERIENCIALABORAL(curpactualizardatos)
        Dim acceso As Boolean = False

        If objetoacceso.validarID_EXPERIENCIA(idacomparar) = True Then

            acceso = True


        Else
            acceso = False

        End If


        Return acceso

    End Function

   


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If validarID(idELIMINAR.Text.Trim) = True Then

            Dim objetonameofintt As New claseActualizarEXPERIENCIALABORAL(curpactualizardatos)

            nombreregistradoELIMINAR.Text = objetonameofintt.obtenernombreInstitucionById(idELIMINAR.Text.Trim)

        Else

            MsgBox("Ingrese ID valido", MsgBoxStyle.Exclamation, "Vidalia")
            idELIMINAR.Clear()
            idELIMINAR.Focus()




        End If

       


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If validarID(idELIMINAR.Text.Trim) = True Then

            Dim objetodelete As New claseActualizarEXPERIENCIALABORAL(curpactualizardatos)

            objetodelete.deleteinstitution(idELIMINAR.Text.Trim)

        Else

            MsgBox("Ingrese ID valido", MsgBoxStyle.Exclamation, "Vidalia")
            idELIMINAR.Clear()
            idELIMINAR.Focus()




        End If
    End Sub

    Private Sub idELIMINAR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idELIMINAR.KeyPress
        validarkeypressonID(e)
    End Sub

    Private Sub idELIMINAR_TextChanged(sender As Object, e As EventArgs) Handles idELIMINAR.TextChanged

    End Sub

    Private Sub validarkeypressonID(ByRef e As KeyPressEventArgs)
        Dim nano = Convert.ToInt32(e.KeyChar)
        If e.KeyChar = "0" Or e.KeyChar = "1" Or e.KeyChar = "2" Or e.KeyChar = "3" Or e.KeyChar = "4" Or e.KeyChar = "5" Or e.KeyChar = "6" Or e.KeyChar = "7" Or e.KeyChar = "8" Or e.KeyChar = "9" Or nano = 8 Then
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub idexperienciaUPDATE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idexperienciaUPDATE.KeyPress
        validarkeypressonID(e)
    End Sub

    Private Sub idexperienciaUPDATE_TextChanged(sender As Object, e As EventArgs) Handles idexperienciaUPDATE.TextChanged

    End Sub

    ''  new array for charge data and update

    Private arrTREEONDATATOCHARGE(2) As String
    Private arrTREEONUPDATE(2) As String


    Private Sub unlockCamptoUPDATE()
        charge1UPDATE.Enabled = True
        charge2UPDATE.Enabled = True
        charge3UPDATE.Enabled = True
    End Sub

    Private Sub lockcampstoUPDATE()
        charge1UPDATE.Enabled = False
        charge2UPDATE.Enabled = False
        charge3UPDATE.Enabled = False

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If validarID(idexperienciaUPDATE.Text.Trim) = True Then

            Dim objetonUPDATE As New claseActualizarEXPERIENCIALABORAL(curpactualizardatos)

            objetonUPDATE.obtenertrescamposinicialesparaUPDATE(idexperienciaUPDATE.Text.Trim)

            arrTREEONDATATOCHARGE = objetonUPDATE.obtaindataofcharge

            charge1UPDATE.Text = arrTREEONDATATOCHARGE(0)
            charge2UPDATE.Text = arrTREEONDATATOCHARGE(1)
            charge3UPDATE.Text = arrTREEONDATATOCHARGE(2)

            unlockCamptoUPDATE()
            btnUPDATE.Enabled = True

        Else

            MsgBox("Ingrese ID valido", MsgBoxStyle.Exclamation, "Vidalia")
            idexperienciaUPDATE.Clear()
            idexperienciaUPDATE.Focus()




        End If
    End Sub

    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        updateByobjectcommand()
    End Sub

    Private Sub updateByobjectcommand()

        arrTREEONUPDATE(0) = charge1UPDATE.Text.Trim
        arrTREEONUPDATE(1) = charge2UPDATE.Text.Trim
        arrTREEONUPDATE(2) = charge3UPDATE.Text.Trim

        Dim objectUPDATE As New claseActualizarEXPERIENCIALABORAL(curpactualizardatos)

        objectUPDATE.UPDATE(arrTREEONUPDATE, idexperienciaUPDATE.Text.Trim)

        Me.btnUPDATE.Enabled = False
        clearModificarinstitucion()
        lockcampstoUPDATE()
        cargagrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("CONTACTO: Vidaliasupportcenter_Mysql@live.com", MsgBoxStyle.Information, "Help Contact")
    End Sub
End Class