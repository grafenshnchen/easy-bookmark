<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonsBearbeiten
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ButtonsBearbeiten))
        Me.AusgewählterButton_lbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.hintergrund_grün = New System.Windows.Forms.Button()
        Me.hintergrund_rot = New System.Windows.Forms.Button()
        Me.hintergrund_schwarz = New System.Windows.Forms.Button()
        Me.hintergrund_weiß = New System.Windows.Forms.Button()
        Me.hintergrund_blau = New System.Windows.Forms.Button()
        Me.hintergrund_lila = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.vordergrund_weiß = New System.Windows.Forms.Button()
        Me.vordergrund_blau = New System.Windows.Forms.Button()
        Me.vordergrund_lila = New System.Windows.Forms.Button()
        Me.vordergrund_schwarz = New System.Windows.Forms.Button()
        Me.vordergrund_rot = New System.Windows.Forms.Button()
        Me.vordergrund_grün = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.link_txt = New System.Windows.Forms.TextBox()
        Me.speichern_btn = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.text_txt = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'AusgewählterButton_lbl
        '
        Me.AusgewählterButton_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AusgewählterButton_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AusgewählterButton_lbl.Location = New System.Drawing.Point(12, 9)
        Me.AusgewählterButton_lbl.Name = "AusgewählterButton_lbl"
        Me.AusgewählterButton_lbl.Size = New System.Drawing.Size(263, 24)
        Me.AusgewählterButton_lbl.TabIndex = 0
        Me.AusgewählterButton_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.hintergrund_weiß)
        Me.GroupBox1.Controls.Add(Me.hintergrund_blau)
        Me.GroupBox1.Controls.Add(Me.hintergrund_lila)
        Me.GroupBox1.Controls.Add(Me.hintergrund_schwarz)
        Me.GroupBox1.Controls.Add(Me.hintergrund_rot)
        Me.GroupBox1.Controls.Add(Me.hintergrund_grün)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 85)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hintergrundfarbe"
        '
        'hintergrund_grün
        '
        Me.hintergrund_grün.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hintergrund_grün.FlatAppearance.BorderSize = 0
        Me.hintergrund_grün.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hintergrund_grün.Location = New System.Drawing.Point(6, 19)
        Me.hintergrund_grün.Name = "hintergrund_grün"
        Me.hintergrund_grün.Size = New System.Drawing.Size(75, 23)
        Me.hintergrund_grün.TabIndex = 0
        Me.hintergrund_grün.TabStop = False
        Me.hintergrund_grün.UseVisualStyleBackColor = False
        '
        'hintergrund_rot
        '
        Me.hintergrund_rot.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hintergrund_rot.FlatAppearance.BorderSize = 0
        Me.hintergrund_rot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hintergrund_rot.Location = New System.Drawing.Point(87, 19)
        Me.hintergrund_rot.Name = "hintergrund_rot"
        Me.hintergrund_rot.Size = New System.Drawing.Size(75, 23)
        Me.hintergrund_rot.TabIndex = 1
        Me.hintergrund_rot.TabStop = False
        Me.hintergrund_rot.UseVisualStyleBackColor = False
        '
        'hintergrund_schwarz
        '
        Me.hintergrund_schwarz.BackColor = System.Drawing.Color.Black
        Me.hintergrund_schwarz.FlatAppearance.BorderSize = 0
        Me.hintergrund_schwarz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hintergrund_schwarz.Location = New System.Drawing.Point(168, 19)
        Me.hintergrund_schwarz.Name = "hintergrund_schwarz"
        Me.hintergrund_schwarz.Size = New System.Drawing.Size(75, 23)
        Me.hintergrund_schwarz.TabIndex = 2
        Me.hintergrund_schwarz.TabStop = False
        Me.hintergrund_schwarz.UseVisualStyleBackColor = False
        '
        'hintergrund_weiß
        '
        Me.hintergrund_weiß.BackColor = System.Drawing.Color.White
        Me.hintergrund_weiß.FlatAppearance.BorderSize = 0
        Me.hintergrund_weiß.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hintergrund_weiß.Location = New System.Drawing.Point(168, 48)
        Me.hintergrund_weiß.Name = "hintergrund_weiß"
        Me.hintergrund_weiß.Size = New System.Drawing.Size(75, 23)
        Me.hintergrund_weiß.TabIndex = 5
        Me.hintergrund_weiß.TabStop = False
        Me.hintergrund_weiß.UseVisualStyleBackColor = False
        '
        'hintergrund_blau
        '
        Me.hintergrund_blau.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.hintergrund_blau.FlatAppearance.BorderSize = 0
        Me.hintergrund_blau.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hintergrund_blau.Location = New System.Drawing.Point(87, 48)
        Me.hintergrund_blau.Name = "hintergrund_blau"
        Me.hintergrund_blau.Size = New System.Drawing.Size(75, 23)
        Me.hintergrund_blau.TabIndex = 4
        Me.hintergrund_blau.TabStop = False
        Me.hintergrund_blau.UseVisualStyleBackColor = False
        '
        'hintergrund_lila
        '
        Me.hintergrund_lila.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.hintergrund_lila.FlatAppearance.BorderSize = 0
        Me.hintergrund_lila.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hintergrund_lila.Location = New System.Drawing.Point(6, 48)
        Me.hintergrund_lila.Name = "hintergrund_lila"
        Me.hintergrund_lila.Size = New System.Drawing.Size(75, 23)
        Me.hintergrund_lila.TabIndex = 3
        Me.hintergrund_lila.TabStop = False
        Me.hintergrund_lila.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.vordergrund_weiß)
        Me.GroupBox2.Controls.Add(Me.vordergrund_blau)
        Me.GroupBox2.Controls.Add(Me.vordergrund_lila)
        Me.GroupBox2.Controls.Add(Me.vordergrund_schwarz)
        Me.GroupBox2.Controls.Add(Me.vordergrund_rot)
        Me.GroupBox2.Controls.Add(Me.vordergrund_grün)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 85)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vordergrundfarbe"
        '
        'vordergrund_weiß
        '
        Me.vordergrund_weiß.BackColor = System.Drawing.Color.White
        Me.vordergrund_weiß.FlatAppearance.BorderSize = 0
        Me.vordergrund_weiß.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.vordergrund_weiß.Location = New System.Drawing.Point(168, 48)
        Me.vordergrund_weiß.Name = "vordergrund_weiß"
        Me.vordergrund_weiß.Size = New System.Drawing.Size(75, 23)
        Me.vordergrund_weiß.TabIndex = 5
        Me.vordergrund_weiß.TabStop = False
        Me.vordergrund_weiß.UseVisualStyleBackColor = False
        '
        'vordergrund_blau
        '
        Me.vordergrund_blau.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.vordergrund_blau.FlatAppearance.BorderSize = 0
        Me.vordergrund_blau.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.vordergrund_blau.Location = New System.Drawing.Point(87, 48)
        Me.vordergrund_blau.Name = "vordergrund_blau"
        Me.vordergrund_blau.Size = New System.Drawing.Size(75, 23)
        Me.vordergrund_blau.TabIndex = 4
        Me.vordergrund_blau.TabStop = False
        Me.vordergrund_blau.UseVisualStyleBackColor = False
        '
        'vordergrund_lila
        '
        Me.vordergrund_lila.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.vordergrund_lila.FlatAppearance.BorderSize = 0
        Me.vordergrund_lila.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.vordergrund_lila.Location = New System.Drawing.Point(6, 48)
        Me.vordergrund_lila.Name = "vordergrund_lila"
        Me.vordergrund_lila.Size = New System.Drawing.Size(75, 23)
        Me.vordergrund_lila.TabIndex = 3
        Me.vordergrund_lila.TabStop = False
        Me.vordergrund_lila.UseVisualStyleBackColor = False
        '
        'vordergrund_schwarz
        '
        Me.vordergrund_schwarz.BackColor = System.Drawing.Color.Black
        Me.vordergrund_schwarz.FlatAppearance.BorderSize = 0
        Me.vordergrund_schwarz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.vordergrund_schwarz.Location = New System.Drawing.Point(168, 19)
        Me.vordergrund_schwarz.Name = "vordergrund_schwarz"
        Me.vordergrund_schwarz.Size = New System.Drawing.Size(75, 23)
        Me.vordergrund_schwarz.TabIndex = 2
        Me.vordergrund_schwarz.TabStop = False
        Me.vordergrund_schwarz.UseVisualStyleBackColor = False
        '
        'vordergrund_rot
        '
        Me.vordergrund_rot.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.vordergrund_rot.FlatAppearance.BorderSize = 0
        Me.vordergrund_rot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.vordergrund_rot.Location = New System.Drawing.Point(87, 19)
        Me.vordergrund_rot.Name = "vordergrund_rot"
        Me.vordergrund_rot.Size = New System.Drawing.Size(75, 23)
        Me.vordergrund_rot.TabIndex = 1
        Me.vordergrund_rot.TabStop = False
        Me.vordergrund_rot.UseVisualStyleBackColor = False
        '
        'vordergrund_grün
        '
        Me.vordergrund_grün.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.vordergrund_grün.FlatAppearance.BorderSize = 0
        Me.vordergrund_grün.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.vordergrund_grün.Location = New System.Drawing.Point(6, 19)
        Me.vordergrund_grün.Name = "vordergrund_grün"
        Me.vordergrund_grün.Size = New System.Drawing.Size(75, 23)
        Me.vordergrund_grün.TabIndex = 0
        Me.vordergrund_grün.TabStop = False
        Me.vordergrund_grün.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.link_txt)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 218)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 54)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Link"
        '
        'link_txt
        '
        Me.link_txt.Location = New System.Drawing.Point(6, 19)
        Me.link_txt.Name = "link_txt"
        Me.link_txt.Size = New System.Drawing.Size(244, 20)
        Me.link_txt.TabIndex = 0
        Me.link_txt.TabStop = False
        '
        'speichern_btn
        '
        Me.speichern_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.speichern_btn.Location = New System.Drawing.Point(200, 336)
        Me.speichern_btn.Name = "speichern_btn"
        Me.speichern_btn.Size = New System.Drawing.Size(75, 23)
        Me.speichern_btn.TabIndex = 8
        Me.speichern_btn.TabStop = False
        Me.speichern_btn.Text = "speichern"
        Me.speichern_btn.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.text_txt)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 278)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 54)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Text"
        '
        'text_txt
        '
        Me.text_txt.Location = New System.Drawing.Point(6, 19)
        Me.text_txt.Name = "text_txt"
        Me.text_txt.Size = New System.Drawing.Size(244, 20)
        Me.text_txt.TabIndex = 0
        Me.text_txt.TabStop = False
        '
        'ButtonsBearbeiten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 371)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.speichern_btn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AusgewählterButton_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ButtonsBearbeiten"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bearbeiten"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AusgewählterButton_lbl As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents hintergrund_weiß As Button
    Friend WithEvents hintergrund_blau As Button
    Friend WithEvents hintergrund_lila As Button
    Friend WithEvents hintergrund_schwarz As Button
    Friend WithEvents hintergrund_rot As Button
    Friend WithEvents hintergrund_grün As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents vordergrund_weiß As Button
    Friend WithEvents vordergrund_blau As Button
    Friend WithEvents vordergrund_lila As Button
    Friend WithEvents vordergrund_schwarz As Button
    Friend WithEvents vordergrund_rot As Button
    Friend WithEvents vordergrund_grün As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents link_txt As TextBox
    Friend WithEvents speichern_btn As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents text_txt As TextBox
End Class
