<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVigenereEncryptDecrypt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVigenereEncryptDecrypt))
        Me.txtPlainText = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.txtCipherText = New System.Windows.Forms.TextBox()
        Me.btnCryptanalysis = New System.Windows.Forms.Button()
        Me.lblCipherText = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.lblPlainText = New System.Windows.Forms.Label()
        Me.btnViewVisual = New System.Windows.Forms.Button()
        Me.btnShowDescription = New System.Windows.Forms.Button()
        Me.btnHideDescription = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtPlainText
        '
        Me.txtPlainText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtPlainText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlainText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPlainText.Location = New System.Drawing.Point(75, 12)
        Me.txtPlainText.Multiline = True
        Me.txtPlainText.Name = "txtPlainText"
        Me.txtPlainText.Size = New System.Drawing.Size(318, 83)
        Me.txtPlainText.TabIndex = 0
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEncrypt.Location = New System.Drawing.Point(247, 101)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(70, 42)
        Me.btnEncrypt.TabIndex = 2
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDecrypt.Location = New System.Drawing.Point(323, 101)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(70, 42)
        Me.btnDecrypt.TabIndex = 3
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'txtKey
        '
        Me.txtKey.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKey.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtKey.Location = New System.Drawing.Point(75, 101)
        Me.txtKey.Multiline = True
        Me.txtKey.Name = "txtKey"
        Me.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtKey.Size = New System.Drawing.Size(145, 42)
        Me.txtKey.TabIndex = 1
        '
        'txtCipherText
        '
        Me.txtCipherText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtCipherText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCipherText.Location = New System.Drawing.Point(75, 149)
        Me.txtCipherText.Multiline = True
        Me.txtCipherText.Name = "txtCipherText"
        Me.txtCipherText.Size = New System.Drawing.Size(318, 83)
        Me.txtCipherText.TabIndex = 4
        '
        'btnCryptanalysis
        '
        Me.btnCryptanalysis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCryptanalysis.Location = New System.Drawing.Point(75, 238)
        Me.btnCryptanalysis.Name = "btnCryptanalysis"
        Me.btnCryptanalysis.Size = New System.Drawing.Size(108, 42)
        Me.btnCryptanalysis.TabIndex = 6
        Me.btnCryptanalysis.Text = "Show Cryptanalysis"
        Me.btnCryptanalysis.UseVisualStyleBackColor = True
        '
        'lblCipherText
        '
        Me.lblCipherText.AutoSize = True
        Me.lblCipherText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCipherText.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCipherText.Location = New System.Drawing.Point(8, 155)
        Me.lblCipherText.Name = "lblCipherText"
        Me.lblCipherText.Size = New System.Drawing.Size(61, 13)
        Me.lblCipherText.TabIndex = 12
        Me.lblCipherText.Text = "Cipher Text"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblKey.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblKey.Location = New System.Drawing.Point(8, 104)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(51, 13)
        Me.lblKey.TabIndex = 13
        Me.lblKey.Text = "Key (A-Z)"
        '
        'lblPlainText
        '
        Me.lblPlainText.AutoSize = True
        Me.lblPlainText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPlainText.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPlainText.Location = New System.Drawing.Point(5, 15)
        Me.lblPlainText.Name = "lblPlainText"
        Me.lblPlainText.Size = New System.Drawing.Size(54, 13)
        Me.lblPlainText.TabIndex = 14
        Me.lblPlainText.Text = "Plain Text"
        '
        'btnViewVisual
        '
        Me.btnViewVisual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewVisual.Location = New System.Drawing.Point(189, 238)
        Me.btnViewVisual.Name = "btnViewVisual"
        Me.btnViewVisual.Size = New System.Drawing.Size(100, 42)
        Me.btnViewVisual.TabIndex = 15
        Me.btnViewVisual.Text = "Show Visual Aid"
        Me.btnViewVisual.UseVisualStyleBackColor = True
        '
        'btnShowDescription
        '
        Me.btnShowDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDescription.Location = New System.Drawing.Point(295, 238)
        Me.btnShowDescription.Name = "btnShowDescription"
        Me.btnShowDescription.Size = New System.Drawing.Size(98, 42)
        Me.btnShowDescription.TabIndex = 16
        Me.btnShowDescription.Text = "Show Description"
        Me.btnShowDescription.UseVisualStyleBackColor = True
        '
        'btnHideDescription
        '
        Me.btnHideDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideDescription.Location = New System.Drawing.Point(314, 238)
        Me.btnHideDescription.Name = "btnHideDescription"
        Me.btnHideDescription.Size = New System.Drawing.Size(79, 42)
        Me.btnHideDescription.TabIndex = 17
        Me.btnHideDescription.Text = "Hide Description"
        Me.btnHideDescription.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(424, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(373, 341)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'frmVigenereEncryptDecrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(412, 296)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnShowDescription)
        Me.Controls.Add(Me.btnViewVisual)
        Me.Controls.Add(Me.lblPlainText)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.lblCipherText)
        Me.Controls.Add(Me.btnCryptanalysis)
        Me.Controls.Add(Me.txtCipherText)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.txtPlainText)
        Me.Controls.Add(Me.btnHideDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmVigenereEncryptDecrypt"
        Me.Text = "Vigenere Cipher Encrypt & Decrypt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPlainText As System.Windows.Forms.TextBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents txtCipherText As System.Windows.Forms.TextBox
    Friend WithEvents btnCryptanalysis As System.Windows.Forms.Button
    Friend WithEvents lblCipherText As System.Windows.Forms.Label
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents lblPlainText As System.Windows.Forms.Label
    Friend WithEvents btnViewVisual As System.Windows.Forms.Button
    Friend WithEvents btnShowDescription As System.Windows.Forms.Button
    Friend WithEvents btnHideDescription As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
