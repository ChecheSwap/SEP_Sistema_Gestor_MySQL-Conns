<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class actualizarEstudiosrealizados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(actualizarEstudiosrealizados))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbtipodiplomado = New System.Windows.Forms.ComboBox()
        Me.grupodatos = New System.Windows.Forms.GroupBox()
        Me.grupoDIRECTOR = New System.Windows.Forms.GroupBox()
        Me.institucion = New System.Windows.Forms.TextBox()
        Me.campodiciplinar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gradoobtenido = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.estudiosrealizados = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.guardardatos = New System.Windows.Forms.Button()
        Me.borrardatos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grupodatos.SuspendLayout()
        Me.grupoDIRECTOR.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TabControl1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.ItemSize = New System.Drawing.Size(190, 35)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(640, 615)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(597, 607)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estudios"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.grupodatos)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 467)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estudios Realizados"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbtipodiplomado)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 112)
        Me.GroupBox2.TabIndex = 95
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 17)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Nivel de Estudios:"
        '
        'cbtipodiplomado
        '
        Me.cbtipodiplomado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbtipodiplomado.FormattingEnabled = True
        Me.cbtipodiplomado.Location = New System.Drawing.Point(205, 48)
        Me.cbtipodiplomado.Name = "cbtipodiplomado"
        Me.cbtipodiplomado.Size = New System.Drawing.Size(282, 25)
        Me.cbtipodiplomado.TabIndex = 95
        '
        'grupodatos
        '
        Me.grupodatos.Controls.Add(Me.grupoDIRECTOR)
        Me.grupodatos.Enabled = False
        Me.grupodatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grupodatos.Location = New System.Drawing.Point(10, 187)
        Me.grupodatos.Name = "grupodatos"
        Me.grupodatos.Size = New System.Drawing.Size(550, 258)
        Me.grupodatos.TabIndex = 80
        Me.grupodatos.TabStop = False
        Me.grupodatos.Text = "Datos de Estudios"
        '
        'grupoDIRECTOR
        '
        Me.grupoDIRECTOR.Controls.Add(Me.institucion)
        Me.grupoDIRECTOR.Controls.Add(Me.campodiciplinar)
        Me.grupoDIRECTOR.Controls.Add(Me.Label1)
        Me.grupoDIRECTOR.Controls.Add(Me.gradoobtenido)
        Me.grupoDIRECTOR.Controls.Add(Me.Label10)
        Me.grupoDIRECTOR.Controls.Add(Me.Label6)
        Me.grupoDIRECTOR.Controls.Add(Me.Label7)
        Me.grupoDIRECTOR.Controls.Add(Me.estudiosrealizados)
        Me.grupoDIRECTOR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grupoDIRECTOR.Location = New System.Drawing.Point(16, 24)
        Me.grupoDIRECTOR.Name = "grupoDIRECTOR"
        Me.grupoDIRECTOR.Size = New System.Drawing.Size(518, 223)
        Me.grupoDIRECTOR.TabIndex = 84
        Me.grupoDIRECTOR.TabStop = False
        '
        'institucion
        '
        Me.institucion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.institucion.Location = New System.Drawing.Point(275, 163)
        Me.institucion.Name = "institucion"
        Me.institucion.Size = New System.Drawing.Size(189, 25)
        Me.institucion.TabIndex = 93
        '
        'campodiciplinar
        '
        Me.campodiciplinar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.campodiciplinar.Location = New System.Drawing.Point(275, 125)
        Me.campodiciplinar.Name = "campodiciplinar"
        Me.campodiciplinar.Size = New System.Drawing.Size(189, 25)
        Me.campodiciplinar.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(153, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Institución:"
        '
        'gradoobtenido
        '
        Me.gradoobtenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gradoobtenido.Location = New System.Drawing.Point(275, 40)
        Me.gradoobtenido.Name = "gradoobtenido"
        Me.gradoobtenido.Size = New System.Drawing.Size(189, 25)
        Me.gradoobtenido.TabIndex = 90
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(126, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 17)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Grado Obtenido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(108, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 17)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Campo Diciplinar:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(81, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 17)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Estudios Realizados:"
        '
        'estudiosrealizados
        '
        Me.estudiosrealizados.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.estudiosrealizados.Location = New System.Drawing.Point(275, 80)
        Me.estudiosrealizados.Name = "estudiosrealizados"
        Me.estudiosrealizados.Size = New System.Drawing.Size(189, 25)
        Me.estudiosrealizados.TabIndex = 86
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(244, 555)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 77)
        Me.Panel1.TabIndex = 68
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(91, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(413, 60)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'guardardatos
        '
        Me.guardardatos.BackColor = System.Drawing.Color.Transparent
        Me.guardardatos.BackgroundImage = CType(resources.GetObject("guardardatos.BackgroundImage"), System.Drawing.Image)
        Me.guardardatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.guardardatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardardatos.Font = New System.Drawing.Font("Consolas", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.guardardatos.ForeColor = System.Drawing.Color.Transparent
        Me.guardardatos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.guardardatos.Location = New System.Drawing.Point(646, 50)
        Me.guardardatos.Name = "guardardatos"
        Me.guardardatos.Size = New System.Drawing.Size(40, 35)
        Me.guardardatos.TabIndex = 82
        Me.guardardatos.UseVisualStyleBackColor = False
        '
        'borrardatos
        '
        Me.borrardatos.BackColor = System.Drawing.Color.Transparent
        Me.borrardatos.BackgroundImage = CType(resources.GetObject("borrardatos.BackgroundImage"), System.Drawing.Image)
        Me.borrardatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.borrardatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.borrardatos.Font = New System.Drawing.Font("Consolas", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.borrardatos.ForeColor = System.Drawing.Color.Transparent
        Me.borrardatos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.borrardatos.Location = New System.Drawing.Point(646, 4)
        Me.borrardatos.Name = "borrardatos"
        Me.borrardatos.Size = New System.Drawing.Size(40, 35)
        Me.borrardatos.TabIndex = 83
        Me.borrardatos.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Location = New System.Drawing.Point(692, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(77, 613)
        Me.Panel2.TabIndex = 85
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Consolas", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(646, 575)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 35)
        Me.Button1.TabIndex = 87
        Me.Button1.UseVisualStyleBackColor = False
        '
        'actualizarEstudiosrealizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(766, 615)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.guardardatos)
        Me.Controls.Add(Me.borrardatos)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "actualizarEstudiosrealizados"
        Me.Text = "actualizarEstudiosrealizados"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grupodatos.ResumeLayout(False)
        Me.grupoDIRECTOR.ResumeLayout(False)
        Me.grupoDIRECTOR.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbtipodiplomado As System.Windows.Forms.ComboBox
    Friend WithEvents grupodatos As System.Windows.Forms.GroupBox
    Friend WithEvents grupoDIRECTOR As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gradoobtenido As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents estudiosrealizados As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents guardardatos As System.Windows.Forms.Button
    Friend WithEvents borrardatos As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents institucion As System.Windows.Forms.TextBox
    Friend WithEvents campodiciplinar As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
