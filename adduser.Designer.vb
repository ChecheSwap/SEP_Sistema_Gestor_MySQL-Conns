<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adduser
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adduser))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.guardardatos = New System.Windows.Forms.Button()
        Me.borrardatos = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.regresarhome = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.edoresidencia = New System.Windows.Forms.ComboBox()
        Me.estadocivils = New System.Windows.Forms.ComboBox()
        Me.tienecomputadoras = New System.Windows.Forms.ComboBox()
        Me.tieneinternets = New System.Windows.Forms.ComboBox()
        Me.calles = New System.Windows.Forms.TextBox()
        Me.numeroexteriors = New System.Windows.Forms.TextBox()
        Me.numerointeriors = New System.Windows.Forms.TextBox()
        Me.localidads = New System.Windows.Forms.TextBox()
        Me.codigopostals = New System.Windows.Forms.TextBox()
        Me.municipioresidencias = New System.Windows.Forms.TextBox()
        Me.comentariosdomicilios = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.sexos = New System.Windows.Forms.ComboBox()
        Me.fechanacimientos = New System.Windows.Forms.DateTimePicker()
        Me.edonacimientos = New System.Windows.Forms.ComboBox()
        Me.estatuss = New System.Windows.Forms.ComboBox()
        Me.curps = New System.Windows.Forms.TextBox()
        Me.apellidopaternos = New System.Windows.Forms.TextBox()
        Me.apellidomaternos = New System.Windows.Forms.TextBox()
        Me.nombre1s = New System.Windows.Forms.TextBox()
        Me.nombre2s = New System.Windows.Forms.TextBox()
        Me.rfcs = New System.Windows.Forms.TextBox()
        Me.telefonolocals = New System.Windows.Forms.TextBox()
        Me.telefonocelulars = New System.Windows.Forms.TextBox()
        Me.emails = New System.Windows.Forms.TextBox()
        Me.nacionalidads = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'guardardatos
        '
        Me.guardardatos.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.guardardatos, "guardardatos")
        Me.guardardatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardardatos.ForeColor = System.Drawing.Color.Transparent
        Me.guardardatos.Name = "guardardatos"
        Me.ToolTip1.SetToolTip(Me.guardardatos, resources.GetString("guardardatos.ToolTip"))
        Me.guardardatos.UseVisualStyleBackColor = False
        '
        'borrardatos
        '
        Me.borrardatos.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.borrardatos, "borrardatos")
        Me.borrardatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.borrardatos.ForeColor = System.Drawing.Color.Transparent
        Me.borrardatos.Name = "borrardatos"
        Me.ToolTip1.SetToolTip(Me.borrardatos, resources.GetString("borrardatos.ToolTip"))
        Me.borrardatos.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.ToolTip1.SetToolTip(Me.TabControl1, resources.GetString("TabControl1.ToolTip"))
        '
        'TabPage1
        '
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.comentariosdomicilios)
        Me.TabPage1.Controls.Add(Me.municipioresidencias)
        Me.TabPage1.Controls.Add(Me.codigopostals)
        Me.TabPage1.Controls.Add(Me.localidads)
        Me.TabPage1.Controls.Add(Me.numerointeriors)
        Me.TabPage1.Controls.Add(Me.numeroexteriors)
        Me.TabPage1.Controls.Add(Me.calles)
        Me.TabPage1.Controls.Add(Me.nacionalidads)
        Me.TabPage1.Controls.Add(Me.emails)
        Me.TabPage1.Controls.Add(Me.telefonocelulars)
        Me.TabPage1.Controls.Add(Me.telefonolocals)
        Me.TabPage1.Controls.Add(Me.rfcs)
        Me.TabPage1.Controls.Add(Me.nombre2s)
        Me.TabPage1.Controls.Add(Me.nombre1s)
        Me.TabPage1.Controls.Add(Me.apellidomaternos)
        Me.TabPage1.Controls.Add(Me.apellidopaternos)
        Me.TabPage1.Controls.Add(Me.curps)
        Me.TabPage1.Controls.Add(Me.tieneinternets)
        Me.TabPage1.Controls.Add(Me.tienecomputadoras)
        Me.TabPage1.Controls.Add(Me.estadocivils)
        Me.TabPage1.Controls.Add(Me.estatuss)
        Me.TabPage1.Controls.Add(Me.edoresidencia)
        Me.TabPage1.Controls.Add(Me.edonacimientos)
        Me.TabPage1.Controls.Add(Me.fechanacimientos)
        Me.TabPage1.Controls.Add(Me.sexos)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Name = "TabPage1"
        '
        'PictureBox2
        '
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Name = "Panel1"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'regresarhome
        '
        Me.regresarhome.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.regresarhome, "regresarhome")
        Me.regresarhome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.regresarhome.ForeColor = System.Drawing.Color.Transparent
        Me.regresarhome.Name = "regresarhome"
        Me.ToolTip1.SetToolTip(Me.regresarhome, resources.GetString("regresarhome.ToolTip"))
        Me.regresarhome.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Name = "Button1"
        Me.ToolTip1.SetToolTip(Me.Button1, resources.GetString("Button1.ToolTip"))
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label15.Name = "Label15"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label16.Name = "Label16"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label17.Name = "Label17"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label18.Name = "Label18"
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label19.Name = "Label19"
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label21.Name = "Label21"
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label22.Name = "Label22"
        '
        'Label23
        '
        resources.ApplyResources(Me.Label23, "Label23")
        Me.Label23.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label23.Name = "Label23"
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label24.Name = "Label24"
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label25.Name = "Label25"
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label26.Name = "Label26"
        '
        'edoresidencia
        '
        Me.edoresidencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.edoresidencia.FormattingEnabled = True
        resources.ApplyResources(Me.edoresidencia, "edoresidencia")
        Me.edoresidencia.Name = "edoresidencia"
        '
        'estadocivils
        '
        Me.estadocivils.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.estadocivils.FormattingEnabled = True
        resources.ApplyResources(Me.estadocivils, "estadocivils")
        Me.estadocivils.Name = "estadocivils"
        '
        'tienecomputadoras
        '
        Me.tienecomputadoras.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tienecomputadoras.FormattingEnabled = True
        resources.ApplyResources(Me.tienecomputadoras, "tienecomputadoras")
        Me.tienecomputadoras.Name = "tienecomputadoras"
        '
        'tieneinternets
        '
        Me.tieneinternets.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tieneinternets.FormattingEnabled = True
        resources.ApplyResources(Me.tieneinternets, "tieneinternets")
        Me.tieneinternets.Name = "tieneinternets"
        '
        'calles
        '
        Me.calles.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.calles, "calles")
        Me.calles.Name = "calles"
        '
        'numeroexteriors
        '
        Me.numeroexteriors.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.numeroexteriors, "numeroexteriors")
        Me.numeroexteriors.Name = "numeroexteriors"
        '
        'numerointeriors
        '
        Me.numerointeriors.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.numerointeriors, "numerointeriors")
        Me.numerointeriors.Name = "numerointeriors"
        '
        'localidads
        '
        Me.localidads.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.localidads, "localidads")
        Me.localidads.Name = "localidads"
        '
        'codigopostals
        '
        Me.codigopostals.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.codigopostals, "codigopostals")
        Me.codigopostals.Name = "codigopostals"
        '
        'municipioresidencias
        '
        Me.municipioresidencias.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.municipioresidencias, "municipioresidencias")
        Me.municipioresidencias.Name = "municipioresidencias"
        '
        'comentariosdomicilios
        '
        Me.comentariosdomicilios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.comentariosdomicilios, "comentariosdomicilios")
        Me.comentariosdomicilios.Name = "comentariosdomicilios"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label8.Name = "Label8"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label9.Name = "Label9"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label10.Name = "Label10"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label11.Name = "Label11"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label12.Name = "Label12"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label13.Name = "Label13"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label14.Name = "Label14"
        '
        'sexos
        '
        Me.sexos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sexos.FormattingEnabled = True
        resources.ApplyResources(Me.sexos, "sexos")
        Me.sexos.Name = "sexos"
        '
        'fechanacimientos
        '
        Me.fechanacimientos.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption
        Me.fechanacimientos.CalendarTrailingForeColor = System.Drawing.Color.Gray
        resources.ApplyResources(Me.fechanacimientos, "fechanacimientos")
        Me.fechanacimientos.Name = "fechanacimientos"
        Me.fechanacimientos.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'edonacimientos
        '
        Me.edonacimientos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.edonacimientos.FormattingEnabled = True
        resources.ApplyResources(Me.edonacimientos, "edonacimientos")
        Me.edonacimientos.Name = "edonacimientos"
        '
        'estatuss
        '
        Me.estatuss.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.estatuss.FormattingEnabled = True
        resources.ApplyResources(Me.estatuss, "estatuss")
        Me.estatuss.Name = "estatuss"
        '
        'curps
        '
        Me.curps.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.curps, "curps")
        Me.curps.Name = "curps"
        '
        'apellidopaternos
        '
        Me.apellidopaternos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.apellidopaternos, "apellidopaternos")
        Me.apellidopaternos.Name = "apellidopaternos"
        '
        'apellidomaternos
        '
        Me.apellidomaternos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.apellidomaternos, "apellidomaternos")
        Me.apellidomaternos.Name = "apellidomaternos"
        '
        'nombre1s
        '
        Me.nombre1s.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.nombre1s, "nombre1s")
        Me.nombre1s.Name = "nombre1s"
        '
        'nombre2s
        '
        Me.nombre2s.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.nombre2s, "nombre2s")
        Me.nombre2s.Name = "nombre2s"
        '
        'rfcs
        '
        Me.rfcs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.rfcs, "rfcs")
        Me.rfcs.Name = "rfcs"
        '
        'telefonolocals
        '
        Me.telefonolocals.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.telefonolocals, "telefonolocals")
        Me.telefonolocals.Name = "telefonolocals"
        '
        'telefonocelulars
        '
        Me.telefonocelulars.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.telefonocelulars, "telefonocelulars")
        Me.telefonocelulars.Name = "telefonocelulars"
        '
        'emails
        '
        Me.emails.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.emails, "emails")
        Me.emails.Name = "emails"
        '
        'nacionalidads
        '
        Me.nacionalidads.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.nacionalidads, "nacionalidads")
        Me.nacionalidads.Name = "nacionalidads"
        '
        'adduser
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.regresarhome)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.guardardatos)
        Me.Controls.Add(Me.borrardatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "adduser"
        Me.ShowInTaskbar = False
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents borrardatos As System.Windows.Forms.Button
    Friend WithEvents guardardatos As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents regresarhome As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents comentariosdomicilios As System.Windows.Forms.RichTextBox
    Friend WithEvents municipioresidencias As System.Windows.Forms.TextBox
    Friend WithEvents codigopostals As System.Windows.Forms.TextBox
    Friend WithEvents localidads As System.Windows.Forms.TextBox
    Friend WithEvents numerointeriors As System.Windows.Forms.TextBox
    Friend WithEvents numeroexteriors As System.Windows.Forms.TextBox
    Friend WithEvents calles As System.Windows.Forms.TextBox
    Friend WithEvents nacionalidads As System.Windows.Forms.TextBox
    Friend WithEvents emails As System.Windows.Forms.TextBox
    Friend WithEvents telefonocelulars As System.Windows.Forms.TextBox
    Friend WithEvents telefonolocals As System.Windows.Forms.TextBox
    Friend WithEvents rfcs As System.Windows.Forms.TextBox
    Friend WithEvents nombre2s As System.Windows.Forms.TextBox
    Friend WithEvents nombre1s As System.Windows.Forms.TextBox
    Friend WithEvents apellidomaternos As System.Windows.Forms.TextBox
    Friend WithEvents apellidopaternos As System.Windows.Forms.TextBox
    Friend WithEvents curps As System.Windows.Forms.TextBox
    Friend WithEvents tieneinternets As System.Windows.Forms.ComboBox
    Friend WithEvents tienecomputadoras As System.Windows.Forms.ComboBox
    Friend WithEvents estadocivils As System.Windows.Forms.ComboBox
    Friend WithEvents estatuss As System.Windows.Forms.ComboBox
    Friend WithEvents edoresidencia As System.Windows.Forms.ComboBox
    Friend WithEvents edonacimientos As System.Windows.Forms.ComboBox
    Friend WithEvents fechanacimientos As System.Windows.Forms.DateTimePicker
    Friend WithEvents sexos As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
