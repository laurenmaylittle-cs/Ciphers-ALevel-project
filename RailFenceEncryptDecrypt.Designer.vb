<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRailFenceEncryptDecrypt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRailFenceEncryptDecrypt))
        Me.txtPlainText = New System.Windows.Forms.TextBox()
        Me.txtCipherText = New System.Windows.Forms.TextBox()
        Me.txtRails = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.lblPlainText = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.lblCipherText = New System.Windows.Forms.Label()
        Me.btnCryptanalysis = New System.Windows.Forms.Button()
        Me.btnViewVisual = New System.Windows.Forms.Button()
        Me.btnShowDescription = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnHideDescription = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPlainText
        '
        Me.txtPlainText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtPlainText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPlainText.Location = New System.Drawing.Point(72, 12)
        Me.txtPlainText.Multiline = True
        Me.txtPlainText.Name = "txtPlainText"
        Me.txtPlainText.Size = New System.Drawing.Size(332, 101)
        Me.txtPlainText.TabIndex = 0
        '
        'txtCipherText
        '
        Me.txtCipherText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtCipherText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCipherText.Location = New System.Drawing.Point(72, 166)
        Me.txtCipherText.Multiline = True
        Me.txtCipherText.Name = "txtCipherText"
        Me.txtCipherText.Size = New System.Drawing.Size(332, 100)
        Me.txtCipherText.TabIndex = 4
        '
        'txtRails
        '
        Me.txtRails.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtRails.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtRails.Location = New System.Drawing.Point(72, 123)
        Me.txtRails.Multiline = True
        Me.txtRails.Name = "txtRails"
        Me.txtRails.Size = New System.Drawing.Size(51, 32)
        Me.txtRails.TabIndex = 1
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEncrypt.Location = New System.Drawing.Point(211, 119)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(93, 41)
        Me.btnEncrypt.TabIndex = 2
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDecrypt.Location = New System.Drawing.Point(310, 119)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(94, 41)
        Me.btnDecrypt.TabIndex = 3
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'lblPlainText
        '
        Me.lblPlainText.AutoSize = True
        Me.lblPlainText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPlainText.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPlainText.Location = New System.Drawing.Point(12, 15)
        Me.lblPlainText.Name = "lblPlainText"
        Me.lblPlainText.Size = New System.Drawing.Size(54, 13)
        Me.lblPlainText.TabIndex = 10
        Me.lblPlainText.Text = "Plain Text"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblKey.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblKey.Location = New System.Drawing.Point(41, 126)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(25, 13)
        Me.lblKey.TabIndex = 11
        Me.lblKey.Text = "Key"
        '
        'lblCipherText
        '
        Me.lblCipherText.AutoSize = True
        Me.lblCipherText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCipherText.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCipherText.Location = New System.Drawing.Point(5, 169)
        Me.lblCipherText.Name = "lblCipherText"
        Me.lblCipherText.Size = New System.Drawing.Size(61, 13)
        Me.lblCipherText.TabIndex = 12
        Me.lblCipherText.Text = "Cipher Text"
        '
        'btnCryptanalysis
        '
        Me.btnCryptanalysis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCryptanalysis.Location = New System.Drawing.Point(72, 272)
        Me.btnCryptanalysis.Name = "btnCryptanalysis"
        Me.btnCryptanalysis.Size = New System.Drawing.Size(105, 41)
        Me.btnCryptanalysis.TabIndex = 6
        Me.btnCryptanalysis.Text = "View Cryptanalysis"
        Me.btnCryptanalysis.UseVisualStyleBackColor = True
        '
        'btnViewVisual
        '
        Me.btnViewVisual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewVisual.Location = New System.Drawing.Point(183, 272)
        Me.btnViewVisual.Name = "btnViewVisual"
        Me.btnViewVisual.Size = New System.Drawing.Size(110, 41)
        Me.btnViewVisual.TabIndex = 13
        Me.btnViewVisual.Text = "View Visual Demo"
        Me.btnViewVisual.UseVisualStyleBackColor = True
        '
        'btnShowDescription
        '
        Me.btnShowDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDescription.Location = New System.Drawing.Point(299, 272)
        Me.btnShowDescription.Name = "btnShowDescription"
        Me.btnShowDescription.Size = New System.Drawing.Size(105, 41)
        Me.btnShowDescription.TabIndex = 14
        Me.btnShowDescription.Text = "Show Description"
        Me.btnShowDescription.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtDescription.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDescription.Location = New System.Drawing.Point(425, 12)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(406, 345)
        Me.txtDescription.TabIndex = 15
        Me.txtDescription.Text = resources.GetString("txtDescription.Text")
        '
        'btnHideDescription
        '
        Me.btnHideDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideDescription.Location = New System.Drawing.Point(319, 272)
        Me.btnHideDescription.Name = "btnHideDescription"
        Me.btnHideDescription.Size = New System.Drawing.Size(85, 41)
        Me.btnHideDescription.TabIndex = 16
        Me.btnHideDescription.Text = "Hide Description"
        Me.btnHideDescription.UseVisualStyleBackColor = True
        '
        'frmRailFenceEncryptDecrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(424, 331)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.btnShowDescription)
        Me.Controls.Add(Me.btnViewVisual)
        Me.Controls.Add(Me.btnCryptanalysis)
        Me.Controls.Add(Me.lblCipherText)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.lblPlainText)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.txtRails)
        Me.Controls.Add(Me.txtCipherText)
        Me.Controls.Add(Me.txtPlainText)
        Me.Controls.Add(Me.btnHideDescription)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRailFenceEncryptDecrypt"
        Me.Text = "Rail Fence Cipher Encrypt & Decrypt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPlainText As System.Windows.Forms.TextBox
    Friend WithEvents txtCipherText As System.Windows.Forms.TextBox
    Friend WithEvents txtRails As System.Windows.Forms.TextBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents lblPlainText As System.Windows.Forms.Label
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents lblCipherText As System.Windows.Forms.Label
    Friend WithEvents btnCryptanalysis As System.Windows.Forms.Button
    Friend WithEvents btnViewVisual As System.Windows.Forms.Button
    Friend WithEvents btnShowDescription As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnHideDescription As System.Windows.Forms.Button
End Class
