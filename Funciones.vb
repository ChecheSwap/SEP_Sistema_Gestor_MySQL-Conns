Module Funciones

    Public Sub denegarcierre(ByRef e As System.Windows.Forms.FormClosingEventArgs)
        e.Cancel = True
    End Sub

    Public Sub ayudaform()
        mensageayuda.Show()

    End Sub

    Public Function comboboxestexto(ByRef morph As KeyPressEventArgs)

        MsgBox("Seleccione Una Opción", MsgBoxStyle.Information, "Vidalia Advisor")
        morph.KeyChar = ""
        Return morph

    End Function

    Public Sub help_general()
        MsgBox("CONTACTO: Vidaliasupportcenter_Mysql@live.com", MsgBoxStyle.Information, "Help Contact")
    End Sub


    Public Sub exTRY_cast(ByVal ex As Exception)

        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Vidalia")

    End Sub

End Module
