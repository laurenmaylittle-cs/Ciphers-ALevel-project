<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVernamEncryptDecrypt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVernamEncryptDecrypt))
        Me.txtPlain = New System.Windows.Forms.TextBox()
        Me.txtOneTimePad = New System.Windows.Forms.TextBox()
        Me.txtCipher = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.btnRandomOneTimePad = New System.Windows.Forms.Button()
        Me.lblPlain = New System.Windows.Forms.Label()
        Me.lblOneTimePad = New System.Windows.Forms.Label()
        Me.lblCipher = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.BtnShowCryptanalysis = New System.Windows.Forms.Button()
        Me.btnShowDescription = New System.Windows.Forms.Button()
        Me.btnShowVisual = New System.Windows.Forms.Button()
        Me.btnHideDescription = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPlain
        '
        Me.txtPlain.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtPlain.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPlain.Location = New System.Drawing.Point(85, 12)
        Me.txtPlain.Multiline = True
        Me.txtPlain.Name = "txtPlain"
        Me.txtPlain.Size = New System.Drawing.Size(325, 77)
        Me.txtPlain.TabIndex = 0
        '
        'txtOneTimePad
        '
        Me.txtOneTimePad.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtOneTimePad.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtOneTimePad.Location = New System.Drawing.Point(85, 95)
        Me.txtOneTimePad.Multiline = True
        Me.txtOneTimePad.Name = "txtOneTimePad"
        Me.txtOneTimePad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOneTimePad.Size = New System.Drawing.Size(325, 48)
        Me.txtOneTimePad.TabIndex = 1
        Me.txtOneTimePad.WordWrap = False
        '
        'txtCipher
        '
        Me.txtCipher.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtCipher.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCipher.Location = New System.Drawing.Point(85, 193)
        Me.txtCipher.Multiline = True
        Me.txtCipher.Name = "txtCipher"
        Me.txtCipher.Size = New System.Drawing.Size(325, 76)
        Me.txtCipher.TabIndex = 5
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEncrypt.Location = New System.Drawing.Point(252, 149)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(74, 38)
        Me.btnEncrypt.TabIndex = 3
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDecrypt.Location = New System.Drawing.Point(332, 149)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(78, 38)
        Me.btnDecrypt.TabIndex = 4
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'btnRandomOneTimePad
        '
        Me.btnRandomOneTimePad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRandomOneTimePad.Location = New System.Drawing.Point(85, 149)
        Me.btnRandomOneTimePad.Name = "btnRandomOneTimePad"
        Me.btnRandomOneTimePad.Size = New System.Drawing.Size(91, 38)
        Me.btnRandomOneTimePad.TabIndex = 2
        Me.btnRandomOneTimePad.Text = "Random One-Time Pad"
        Me.btnRandomOneTimePad.UseVisualStyleBackColor = True
        '
        'lblPlain
        '
        Me.lblPlain.AutoSize = True
        Me.lblPlain.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPlain.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPlain.Location = New System.Drawing.Point(4, 15)
        Me.lblPlain.Name = "lblPlain"
        Me.lblPlain.Size = New System.Drawing.Size(54, 13)
        Me.lblPlain.TabIndex = 10
        Me.lblPlain.Text = "Plain Text"
        '
        'lblOneTimePad
        '
        Me.lblOneTimePad.AutoSize = True
        Me.lblOneTimePad.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOneTimePad.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblOneTimePad.Location = New System.Drawing.Point(4, 98)
        Me.lblOneTimePad.Name = "lblOneTimePad"
        Me.lblOneTimePad.Size = New System.Drawing.Size(75, 13)
        Me.lblOneTimePad.TabIndex = 11
        Me.lblOneTimePad.Text = "One-Time Pad"
        '
        'lblCipher
        '
        Me.lblCipher.AutoSize = True
        Me.lblCipher.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCipher.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCipher.Location = New System.Drawing.Point(4, 196)
        Me.lblCipher.Name = "lblCipher"
        Me.lblCipher.Size = New System.Drawing.Size(61, 13)
        Me.lblCipher.TabIndex = 12
        Me.lblCipher.Text = "Cipher Text"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtDescription.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDescription.Location = New System.Drawing.Point(436, 12)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(562, 369)
        Me.txtDescription.TabIndex = 15
        Me.txtDescription.Text = resources.GetString("txtDescription.Text")
        '
        'BtnShowCryptanalysis
        '
        Me.BtnShowCryptanalysis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShowCryptanalysis.Location = New System.Drawing.Point(85, 275)
        Me.BtnShowCryptanalysis.Name = "BtnShowCryptanalysis"
        Me.BtnShowCryptanalysis.Size = New System.Drawing.Size(101, 38)
        Me.BtnShowCryptanalysis.TabIndex = 6
        Me.BtnShowCryptanalysis.Text = "Show Cryptanalysis"
        Me.BtnShowCryptanalysis.UseVisualStyleBackColor = True
        '
        'btnShowDescription
        '
        Me.btnShowDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDescription.Location = New System.Drawing.Point(301, 275)
        Me.btnShowDescription.Name = "btnShowDescription"
        Me.btnShowDescription.Size = New System.Drawing.Size(109, 38)
        Me.btnShowDescription.TabIndex = 8
        Me.btnShowDescription.Text = "Show Description"
        Me.btnShowDescription.UseVisualStyleBackColor = True
        '
        'btnShowVisual
        '
        Me.btnShowVisual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowVisual.Location = New System.Drawing.Point(192, 275)
        Me.btnShowVisual.Name = "btnShowVisual"
        Me.btnShowVisual.Size = New System.Drawing.Size(103, 38)
        Me.btnShowVisual.TabIndex = 7
        Me.btnShowVisual.Text = "Show Visual Aid"
        Me.btnShowVisual.UseVisualStyleBackColor = True
        '
        'btnHideDescription
        '
        Me.btnHideDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideDescription.Location = New System.Drawing.Point(329, 275)
        Me.btnHideDescription.Name = "btnHideDescription"
        Me.btnHideDescription.Size = New System.Drawing.Size(81, 38)
        Me.btnHideDescription.TabIndex = 8
        Me.btnHideDescription.Text = "Hide Description"
        Me.btnHideDescription.UseVisualStyleBackColor = True
        '
        'frmVernamEncryptDecrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(430, 338)
        Me.Controls.Add(Me.btnShowVisual)
        Me.Controls.Add(Me.btnShowDescription)
        Me.Controls.Add(Me.BtnShowCryptanalysis)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblCipher)
        Me.Controls.Add(Me.lblOneTimePad)
        Me.Controls.Add(Me.lblPlain)
        Me.Controls.Add(Me.btnRandomOneTimePad)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.txtCipher)
        Me.Controls.Add(Me.txtOneTimePad)
        Me.Controls.Add(Me.txtPlain)
        Me.Controls.Add(Me.btnHideDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmVernamEncryptDecrypt"
        Me.Text = "Vernam Cipher Encrypt & Decrypt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPlain As System.Windows.Forms.TextBox
    Friend WithEvents txtOneTimePad As System.Windows.Forms.TextBox
    Friend WithEvents txtCipher As System.Windows.Forms.TextBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents btnRandomOneTimePad As System.Windows.Forms.Button
    Friend WithEvents lblPlain As System.Windows.Forms.Label
    Friend WithEvents lblOneTimePad As System.Windows.Forms.Label
    Friend WithEvents lblCipher As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents BtnShowCryptanalysis As System.Windows.Forms.Button
    Friend WithEvents btnShowDescription As System.Windows.Forms.Button
    Friend WithEvents btnShowVisual As System.Windows.Forms.Button
    Friend WithEvents btnHideDescription As System.Windows.Forms.Button
End Class
