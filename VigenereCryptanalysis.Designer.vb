<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVigenereCryptanalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVigenereCryptanalysis))
        Me.txtCipherText = New System.Windows.Forms.TextBox()
        Me.lblTextToDecrypt = New System.Windows.Forms.Label()
        Me.txtKeyLength = New System.Windows.Forms.TextBox()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.lblKeyLength = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.txtPlainText = New System.Windows.Forms.TextBox()
        Me.btnFreidman = New System.Windows.Forms.Button()
        Me.lblDecryptedText = New System.Windows.Forms.Label()
        Me.btnShowDescription = New System.Windows.Forms.Button()
        Me.btnHideDescription = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtCipherText
        '
        Me.txtCipherText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtCipherText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCipherText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCipherText.Location = New System.Drawing.Point(100, 12)
        Me.txtCipherText.Multiline = True
        Me.txtCipherText.Name = "txtCipherText"
        Me.txtCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCipherText.Size = New System.Drawing.Size(288, 320)
        Me.txtCipherText.TabIndex = 0
        '
        'lblTextToDecrypt
        '
        Me.lblTextToDecrypt.AutoSize = True
        Me.lblTextToDecrypt.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTextToDecrypt.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTextToDecrypt.Location = New System.Drawing.Point(5, 154)
        Me.lblTextToDecrypt.Name = "lblTextToDecrypt"
        Me.lblTextToDecrypt.Size = New System.Drawing.Size(84, 13)
        Me.lblTextToDecrypt.TabIndex = 1
        Me.lblTextToDecrypt.Text = "Text To Decrypt"
        '
        'txtKeyLength
        '
        Me.txtKeyLength.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtKeyLength.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtKeyLength.Location = New System.Drawing.Point(100, 727)
        Me.txtKeyLength.Name = "txtKeyLength"
        Me.txtKeyLength.ReadOnly = True
        Me.txtKeyLength.Size = New System.Drawing.Size(54, 20)
        Me.txtKeyLength.TabIndex = 3
        Me.txtKeyLength.TabStop = False
        '
        'txtKey
        '
        Me.txtKey.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtKey.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtKey.Location = New System.Drawing.Point(213, 727)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.ReadOnly = True
        Me.txtKey.Size = New System.Drawing.Size(175, 20)
        Me.txtKey.TabIndex = 4
        Me.txtKey.TabStop = False
        '
        'lblKeyLength
        '
        Me.lblKeyLength.AutoSize = True
        Me.lblKeyLength.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblKeyLength.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblKeyLength.Location = New System.Drawing.Point(24, 730)
        Me.lblKeyLength.Name = "lblKeyLength"
        Me.lblKeyLength.Size = New System.Drawing.Size(61, 13)
        Me.lblKeyLength.TabIndex = 4
        Me.lblKeyLength.Text = "Key Length"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblKey.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblKey.Location = New System.Drawing.Point(170, 730)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(25, 13)
        Me.lblKey.TabIndex = 5
        Me.lblKey.Text = "Key"
        '
        'txtPlainText
        '
        Me.txtPlainText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtPlainText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlainText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPlainText.Location = New System.Drawing.Point(100, 384)
        Me.txtPlainText.Multiline = True
        Me.txtPlainText.Name = "txtPlainText"
        Me.txtPlainText.ReadOnly = True
        Me.txtPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPlainText.Size = New System.Drawing.Size(288, 337)
        Me.txtPlainText.TabIndex = 2
        Me.txtPlainText.TabStop = False
        '
        'btnFreidman
        '
        Me.btnFreidman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFreidman.Location = New System.Drawing.Point(100, 338)
        Me.btnFreidman.Name = "btnFreidman"
        Me.btnFreidman.Size = New System.Drawing.Size(110, 40)
        Me.btnFreidman.TabIndex = 1
        Me.btnFreidman.Text = "Decrypt With Friedman Test"
        Me.btnFreidman.UseVisualStyleBackColor = True
        '
        'lblDecryptedText
        '
        Me.lblDecryptedText.AutoSize = True
        Me.lblDecryptedText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDecryptedText.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblDecryptedText.Location = New System.Drawing.Point(5, 537)
        Me.lblDecryptedText.Name = "lblDecryptedText"
        Me.lblDecryptedText.Size = New System.Drawing.Size(80, 13)
        Me.lblDecryptedText.TabIndex = 8
        Me.lblDecryptedText.Text = "Decrypted Text"
        '
        'btnShowDescription
        '
        Me.btnShowDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDescription.Location = New System.Drawing.Point(278, 338)
        Me.btnShowDescription.Name = "btnShowDescription"
        Me.btnShowDescription.Size = New System.Drawing.Size(110, 40)
        Me.btnShowDescription.TabIndex = 2
        Me.btnShowDescription.Text = "Show Description"
        Me.btnShowDescription.UseVisualStyleBackColor = True
        '
        'btnHideDescription
        '
        Me.btnHideDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideDescription.Location = New System.Drawing.Point(278, 338)
        Me.btnHideDescription.Name = "btnHideDescription"
        Me.btnHideDescription.Size = New System.Drawing.Size(110, 40)
        Me.btnHideDescription.TabIndex = 10
        Me.btnHideDescription.Text = "Hide Description"
        Me.btnHideDescription.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(427, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(402, 709)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'frmVigenereCryptanalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(407, 762)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnShowDescription)
        Me.Controls.Add(Me.lblDecryptedText)
        Me.Controls.Add(Me.btnFreidman)
        Me.Controls.Add(Me.txtPlainText)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.lblKeyLength)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.txtKeyLength)
        Me.Controls.Add(Me.lblTextToDecrypt)
        Me.Controls.Add(Me.txtCipherText)
        Me.Controls.Add(Me.btnHideDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmVigenereCryptanalysis"
        Me.Text = "Vigenere Cipher Cryptanalysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCipherText As System.Windows.Forms.TextBox
    Friend WithEvents lblTextToDecrypt As System.Windows.Forms.Label
    Friend WithEvents txtKeyLength As System.Windows.Forms.TextBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents lblKeyLength As System.Windows.Forms.Label
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents txtPlainText As System.Windows.Forms.TextBox
    Friend WithEvents btnFreidman As System.Windows.Forms.Button
    Friend WithEvents lblDecryptedText As System.Windows.Forms.Label
    Friend WithEvents btnShowDescription As System.Windows.Forms.Button
    Friend WithEvents btnHideDescription As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
