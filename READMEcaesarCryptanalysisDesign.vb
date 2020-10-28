# Ciphers-ALevel-project
A cipher and decipher project I coded for my A-Level coursework. It was created with the idea of being a teaching tool, where students could learn about Caesar, Rail Fence, Vernam and Vigenere Ciphers
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaesarCryptanalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaesarCryptanalysis))
        Me.txtBruteForce = New System.Windows.Forms.TextBox()
        Me.txtCipherText = New System.Windows.Forms.TextBox()
        Me.lblTextToDecrypt = New System.Windows.Forms.Label()
        Me.btnBruteForceAttack = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnSelectDictionaryFile = New System.Windows.Forms.Button()
        Me.dlgSelectDictionaryFile = New System.Windows.Forms.OpenFileDialog()
        Me.lblOutputWindow = New System.Windows.Forms.Label()
        Me.chkDictionary = New System.Windows.Forms.CheckBox()
        Me.txtShowDescription = New System.Windows.Forms.TextBox()
        Me.btnShowDescription = New System.Windows.Forms.Button()
        Me.btnHideDescription = New System.Windows.Forms.Button()
        Me.lblDictionaryFile = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBruteForce
        '
        Me.txtBruteForce.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtBruteForce.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtBruteForce.Location = New System.Drawing.Point(99, 257)
        Me.txtBruteForce.Multiline = True
        Me.txtBruteForce.Name = "txtBruteForce"
        Me.txtBruteForce.ReadOnly = True
        Me.txtBruteForce.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBruteForce.Size = New System.Drawing.Size(292, 371)
        Me.txtBruteForce.TabIndex = 5
        '
        'txtCipherText
        '
        Me.txtCipherText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtCipherText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCipherText.Location = New System.Drawing.Point(98, 12)
        Me.txtCipherText.Multiline = True
        Me.txtCipherText.Name = "txtCipherText"
        Me.txtCipherText.Size = New System.Drawing.Size(292, 62)
        Me.txtCipherText.TabIndex = 0
        '
        'lblTextToDecrypt
        '
        Me.lblTextToDecrypt.AutoSize = True
        Me.lblTextToDecrypt.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTextToDecrypt.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTextToDecrypt.Location = New System.Drawing.Point(12, 15)
        Me.lblTextToDecrypt.Name = "lblTextToDecrypt"
        Me.lblTextToDecrypt.Size = New System.Drawing.Size(80, 13)
        Me.lblTextToDecrypt.TabIndex = 7
        Me.lblTextToDecrypt.Text = "Text to Decrypt"
        '
        'btnBruteForceAttack
        '
        Me.btnBruteForceAttack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBruteForceAttack.Location = New System.Drawing.Point(98, 209)
        Me.btnBruteForceAttack.Name = "btnBruteForceAttack"
        Me.btnBruteForceAttack.Size = New System.Drawing.Size(160, 42)
        Me.btnBruteForceAttack.TabIndex = 3
        Me.btnBruteForceAttack.Text = "Crack Cipher with Brute Force"
        Me.btnBruteForceAttack.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtFileName.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtFileName.Location = New System.Drawing.Point(98, 131)
        Me.txtFileName.Multiline = True
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(292, 72)
        Me.txtFileName.TabIndex = 2
        Me.txtFileName.Text = "Resources - EnglishWords.txt"
        '
        'btnSelectDictionaryFile
        '
        Me.btnSelectDictionaryFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectDictionaryFile.Location = New System.Drawing.Point(98, 80)
        Me.btnSelectDictionaryFile.Name = "btnSelectDictionaryFile"
        Me.btnSelectDictionaryFile.Size = New System.Drawing.Size(292, 45)
        Me.btnSelectDictionaryFile.TabIndex = 1
        Me.btnSelectDictionaryFile.Text = "Change / Select Dictionary File to use"
        Me.btnSelectDictionaryFile.UseVisualStyleBackColor = True
        '
        'dlgSelectDictionaryFile
        '
        Me.dlgSelectDictionaryFile.FileName = "OpenFileDialog1"
        '
        'lblOutputWindow
        '
        Me.lblOutputWindow.AutoSize = True
        Me.lblOutputWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOutputWindow.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblOutputWindow.Location = New System.Drawing.Point(12, 260)
        Me.lblOutputWindow.Name = "lblOutputWindow"
        Me.lblOutputWindow.Size = New System.Drawing.Size(81, 13)
        Me.lblOutputWindow.TabIndex = 9
        Me.lblOutputWindow.Text = "Output Window"
        '
        'chkDictionary
        '
        Me.chkDictionary.AutoSize = True
        Me.chkDictionary.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkDictionary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkDictionary.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.chkDictionary.Location = New System.Drawing.Point(289, 223)
        Me.chkDictionary.Name = "chkDictionary"
        Me.chkDictionary.Size = New System.Drawing.Size(101, 17)
        Me.chkDictionary.TabIndex = 4
        Me.chkDictionary.Text = "Use Dictionary?"
        Me.chkDictionary.UseVisualStyleBackColor = False
        '
        'txtShowDescription
        '
        Me.txtShowDescription.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtShowDescription.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtShowDescription.Location = New System.Drawing.Point(415, 15)
        Me.txtShowDescription.Multiline = True
        Me.txtShowDescription.Name = "txtShowDescription"
        Me.txtShowDescription.ReadOnly = True
        Me.txtShowDescription.Size = New System.Drawing.Size(292, 613)
        Me.txtShowDescription.TabIndex = 10
        Me.txtShowDescription.Text = resources.GetString("txtShowDescription.Text")
        '
        'btnShowDescription
        '
        Me.btnShowDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDescription.Location = New System.Drawing.Point(6, 586)
        Me.btnShowDescription.Name = "btnShowDescription"
        Me.btnShowDescription.Size = New System.Drawing.Size(87, 42)
        Me.btnShowDescription.TabIndex = 6
        Me.btnShowDescription.Text = "Show Description"
        Me.btnShowDescription.UseVisualStyleBackColor = True
        '
        'btnHideDescription
        '
        Me.btnHideDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideDescription.Location = New System.Drawing.Point(5, 586)
        Me.btnHideDescription.Name = "btnHideDescription"
        Me.btnHideDescription.Size = New System.Drawing.Size(87, 42)
        Me.btnHideDescription.TabIndex = 7
        Me.btnHideDescription.Text = "Hide Description"
        Me.btnHideDescription.UseVisualStyleBackColor = True
        '
        'lblDictionaryFile
        '
        Me.lblDictionaryFile.AutoSize = True
        Me.lblDictionaryFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDictionaryFile.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblDictionaryFile.Location = New System.Drawing.Point(11, 134)
        Me.lblDictionaryFile.Name = "lblDictionaryFile"
        Me.lblDictionaryFile.Size = New System.Drawing.Size(73, 13)
        Me.lblDictionaryFile.TabIndex = 11
        Me.lblDictionaryFile.Text = "Dictionary File"
        '
        'frmCaesarCryptanalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(412, 647)
        Me.Controls.Add(Me.lblDictionaryFile)
        Me.Controls.Add(Me.btnShowDescription)
        Me.Controls.Add(Me.txtShowDescription)
        Me.Controls.Add(Me.chkDictionary)
        Me.Controls.Add(Me.lblOutputWindow)
        Me.Controls.Add(Me.btnSelectDictionaryFile)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnBruteForceAttack)
        Me.Controls.Add(Me.lblTextToDecrypt)
        Me.Controls.Add(Me.txtCipherText)
        Me.Controls.Add(Me.txtBruteForce)
        Me.Controls.Add(Me.btnHideDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCaesarCryptanalysis"
        Me.Text = "Caesar Cipher Cryptanalysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBruteForce As System.Windows.Forms.TextBox
    Friend WithEvents txtCipherText As System.Windows.Forms.TextBox
    Friend WithEvents lblTextToDecrypt As System.Windows.Forms.Label
    Friend WithEvents btnBruteForceAttack As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectDictionaryFile As System.Windows.Forms.Button
    Friend WithEvents dlgSelectDictionaryFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblOutputWindow As System.Windows.Forms.Label
    Friend WithEvents chkDictionary As System.Windows.Forms.CheckBox
    Friend WithEvents txtShowDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnShowDescription As System.Windows.Forms.Button
    Friend WithEvents btnHideDescription As System.Windows.Forms.Button
    Friend WithEvents lblDictionaryFile As System.Windows.Forms.Label
End Class
