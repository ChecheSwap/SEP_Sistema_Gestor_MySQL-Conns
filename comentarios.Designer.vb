<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comentarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comentarios))
        Me.btn1iniciowelcome = New System.Windows.Forms.Button()
        Me.helmeadmon = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtbox = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn1iniciowelcome
        '
        Me.btn1iniciowelcome.BackColor = System.Drawing.Color.Transparent
        Me.btn1iniciowelcome.BackgroundImage = CType(resources.GetObject("btn1iniciowelcome.BackgroundImage"), System.Drawing.Image)
        Me.btn1iniciowelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn1iniciowelcome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1iniciowelcome.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn1iniciowelcome.FlatAppearance.BorderSize = 0
        Me.btn1iniciowelcome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn1iniciowelcome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn1iniciowelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1iniciowelcome.ForeColor = System.Drawing.Color.Transparent
        Me.btn1iniciowelcome.Location = New System.Drawing.Point(11, 301)
        Me.btn1iniciowelcome.Name = "btn1iniciowelcome"
        Me.btn1iniciowelcome.Size = New System.Drawing.Size(38, 38)
        Me.btn1iniciowelcome.TabIndex = 63
        Me.btn1iniciowelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn1iniciowelcome.UseVisualStyleBackColor = False
        '
        'helmeadmon
        '
        Me.helmeadmon.BackColor = System.Drawing.Color.Transparent
        Me.helmeadmon.BackgroundImage = CType(resources.GetObject("helmeadmon.BackgroundImage"), System.Drawing.Image)
        Me.helmeadmon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.helmeadmon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.helmeadmon.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.helmeadmon.FlatAppearance.BorderSize = 0
        Me.helmeadmon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.helmeadmon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.helmeadmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.helmeadmon.ForeColor = System.Drawing.Color.Transparent
        Me.helmeadmon.Location = New System.Drawing.Point(61, 301)
        Me.helmeadmon.Name = "helmeadmon"
        Me.helmeadmon.Size = New System.Drawing.Size(42, 38)
        Me.helmeadmon.TabIndex = 64
        Me.helmeadmon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.helmeadmon.UseVisualStyleBackColor = False
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
        Me.TabControl1.Size = New System.Drawing.Size(553, 354)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 107
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.rtbox)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.helmeadmon)
        Me.TabPage1.Controls.Add(Me.btn1iniciowelcome)
        Me.TabPage1.Controls.Add(Me.PictureBox6)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(510, 346)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Comentarios"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox6.Location = New System.Drawing.Point(417, 301)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(80, 35)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 108
        Me.PictureBox6.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 64)
        Me.Panel1.TabIndex = 68
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox7.Location = New System.Drawing.Point(118, -4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(274, 68)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(490, 22)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Ingrese Comentario al Administrador del sistema."
        '
        'rtbox
        '
        Me.rtbox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.rtbox.Location = New System.Drawing.Point(10, 133)
        Me.rtbox.Name = "rtbox"
        Me.rtbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal
        Me.rtbox.Size = New System.Drawing.Size(485, 109)
        Me.rtbox.TabIndex = 109
        Me.rtbox.Text = ""
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(199, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 57)
        Me.Button1.TabIndex = 110
        Me.ToolTip1.SetToolTip(Me.Button1, "Enviar Comentario.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'comentarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(553, 354)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "comentarios"
        Me.ShowInTaskbar = False
        Me.Text = "Comentarios"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn1iniciowelcome As System.Windows.Forms.Button
    Friend WithEvents helmeadmon As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents rtbox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
End Class
