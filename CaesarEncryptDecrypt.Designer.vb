<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaesarEncryptDecrypt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaesarEncryptDecrypt))
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.txtPlainText = New System.Windows.Forms.TextBox()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.txtCipherText = New System.Windows.Forms.TextBox()
        Me.txtShift = New System.Windows.Forms.TextBox()
        Me.btnCaesarCryptanalysis = New System.Windows.Forms.Button()
        Me.btnCaesarVisual = New System.Windows.Forms.Button()
        Me.btnRandomShift = New System.Windows.Forms.Button()
        Me.lblPlainText = New System.Windows.Forms.Label()
        Me.lblCipherText = New System.Windows.Forms.Label()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnShowDescription = New System.Windows.Forms.Button()
        Me.btnHideDescription = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEncrypt.Location = New System.Drawing.Point(265, 120)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(61, 38)
        Me.btnEncrypt.TabIndex = 3
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'txtPlainText
        '
        Me.txtPlainText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtPlainText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPlainText.Location = New System.Drawing.Point(82, 12)
        Me.txtPlainText.Multiline = True
        Me.txtPlainText.Name = "txtPlainText"
        Me.txtPlainText.Size = New System.Drawing.Size(311, 99)
        Me.txtPlainText.TabIndex = 0
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDecrypt.Location = New System.Drawing.Point(332, 120)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(61, 38)
        Me.btnDecrypt.TabIndex = 4
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'txtCipherText
        '
        Me.txtCipherText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtCipherText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCipherText.Location = New System.Drawing.Point(82, 165)
        Me.txtCipherText.Multiline = True
        Me.txtCipherText.Name = "txtCipherText"
        Me.txtCipherText.Size = New System.Drawing.Size(311, 99)
        Me.txtCipherText.TabIndex = 5
        '
        'txtShift
        '
        Me.txtShift.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtShift.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtShift.Location = New System.Drawing.Point(126, 130)
        Me.txtShift.Multiline = True
        Me.txtShift.Name = "txtShift"
        Me.txtShift.Size = New System.Drawing.Size(32, 24)
        Me.txtShift.TabIndex = 1
        '
        'btnCaesarCryptanalysis
        '
        Me.btnCaesarCryptanalysis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCaesarCryptanalysis.Location = New System.Drawing.Point(82, 285)
        Me.btnCaesarCryptanalysis.Name = "btnCaesarCryptanalysis"
        Me.btnCaesarCryptanalysis.Size = New System.Drawing.Size(96, 37)
        Me.btnCaesarCryptanalysis.TabIndex = 6
        Me.btnCaesarCryptanalysis.Text = "Show Cryptanalysis"
        Me.btnCaesarCryptanalysis.UseVisualStyleBackColor = True
        '
        'btnCaesarVisual
        '
        Me.btnCaesarVisual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCaesarVisual.Location = New System.Drawing.Point(184, 285)
        Me.btnCaesarVisual.Name = "btnCaesarVisual"
        Me.btnCaesarVisual.Size = New System.Drawing.Size(103, 37)
        Me.btnCaesarVisual.TabIndex = 7
        Me.btnCaesarVisual.Text = "Show Visual Aid"
        Me.btnCaesarVisual.UseVisualStyleBackColor = True
        '
        'btnRandomShift
        '
        Me.btnRandomShift.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRandomShift.Location = New System.Drawing.Point(164, 120)
        Me.btnRandomShift.Name = "btnRandomShift"
        Me.btnRandomShift.Size = New System.Drawing.Size(95, 38)
        Me.btnRandomShift.TabIndex = 2
        Me.btnRandomShift.Text = "Generate Random Shift"
        Me.btnRandomShift.UseVisualStyleBackColor = True
        '
        'lblPlainText
        '
        Me.lblPlainText.AutoSize = True
        Me.lblPlainText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPlainText.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPlainText.Location = New System.Drawing.Point(19, 15)
        Me.lblPlainText.Name = "lblPlainText"
        Me.lblPlainText.Size = New System.Drawing.Size(54, 13)
        Me.lblPlainText.TabIndex = 12
        Me.lblPlainText.Text = "Plain Text"
        '
        'lblCipherText
        '
        Me.lblCipherText.AutoSize = True
        Me.lblCipherText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCipherText.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCipherText.Location = New System.Drawing.Point(12, 168)
        Me.lblCipherText.Name = "lblCipherText"
        Me.lblCipherText.Size = New System.Drawing.Size(61, 13)
        Me.lblCipherText.TabIndex = 13
        Me.lblCipherText.Text = "Cipher Text"
        '
        'lblShift
        '
        Me.lblShift.AutoSize = True
        Me.lblShift.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblShift.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblShift.Location = New System.Drawing.Point(12, 133)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(98, 13)
        Me.lblShift.TabIndex = 14
        Me.lblShift.Text = "Enter Shift (0 to 25)"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtDescription.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDescription.Location = New System.Drawing.Point(417, 12)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(462, 391)
        Me.txtDescription.TabIndex = 10
        Me.txtDescription.Text = resources.GetString("txtDescription.Text")
        '
        'btnShowDescription
        '
        Me.btnShowDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDescription.Location = New System.Drawing.Point(293, 285)
        Me.btnShowDescription.Name = "btnShowDescription"
        Me.btnShowDescription.Size = New System.Drawing.Size(100, 37)
        Me.btnShowDescription.TabIndex = 8
        Me.btnShowDescription.Text = "Show Description"
        Me.btnShowDescription.UseVisualStyleBackColor = True
        '
        'btnHideDescription
        '
        Me.btnHideDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideDescription.Location = New System.Drawing.Point(293, 285)
        Me.btnHideDescription.Name = "btnHideDescription"
        Me.btnHideDescription.Size = New System.Drawing.Size(100, 37)
        Me.btnHideDescription.TabIndex = 17
        Me.btnHideDescription.Text = "Hide Description"
        Me.btnHideDescription.UseVisualStyleBackColor = True
        '
        'frmCaesarEncryptDecrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(411, 336)
        Me.Controls.Add(Me.btnShowDescription)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblShift)
        Me.Controls.Add(Me.lblCipherText)
        Me.Controls.Add(Me.lblPlainText)
        Me.Controls.Add(Me.btnRandomShift)
        Me.Controls.Add(Me.btnCaesarVisual)
        Me.Controls.Add(Me.btnCaesarCryptanalysis)
        Me.Controls.Add(Me.txtShift)
        Me.Controls.Add(Me.txtCipherText)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.txtPlainText)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.btnHideDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCaesarEncryptDecrypt"
        Me.Text = "Caesar Cipher Encrypt & Decrypt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents txtPlainText As System.Windows.Forms.TextBox
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents txtCipherText As System.Windows.Forms.TextBox
    Friend WithEvents txtShift As System.Windows.Forms.TextBox
    Friend WithEvents ABox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCaesarCryptanalysis As System.Windows.Forms.Button
    Friend WithEvents btnCaesarVisual As System.Windows.Forms.Button
    Friend WithEvents btnRandomShift As System.Windows.Forms.Button
    Friend WithEvents lblPlainText As System.Windows.Forms.Label
    Friend WithEvents lblCipherText As System.Windows.Forms.Label
    Friend WithEvents lblShift As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnShowDescription As System.Windows.Forms.Button
    Friend WithEvents btnHideDescription As System.Windows.Forms.Button
End Class
