<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVernamVisual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVernamVisual))
        Me.btnViewXORTruthTable = New System.Windows.Forms.Button()
        Me.txtXORTruthTable = New System.Windows.Forms.TextBox()
        Me.btnEncryptDemo = New System.Windows.Forms.Button()
        Me.lblOneTimePad = New System.Windows.Forms.Label()
        Me.txtOneTimePad = New System.Windows.Forms.TextBox()
        Me.lblCiphertext = New System.Windows.Forms.Label()
        Me.txtCipherText = New System.Windows.Forms.TextBox()
        Me.lblPlainText = New System.Windows.Forms.Label()
        Me.txtPlainText = New System.Windows.Forms.TextBox()
        Me.txtDemoHeader = New System.Windows.Forms.TextBox()
        Me.txtBinaryXorDemo = New System.Windows.Forms.TextBox()
        Me.txtIndividualChars = New System.Windows.Forms.TextBox()
        Me.btnIndividualChars = New System.Windows.Forms.Button()
        Me.btnShowDescription = New System.Windows.Forms.Button()
        Me.btnHideDescription = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnViewXORTruthTable
        '
        Me.btnViewXORTruthTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewXORTruthTable.Location = New System.Drawing.Point(182, 179)
        Me.btnViewXORTruthTable.Name = "btnViewXORTruthTable"
        Me.btnViewXORTruthTable.Size = New System.Drawing.Size(79, 60)
        Me.btnViewXORTruthTable.TabIndex = 4
        Me.btnViewXORTruthTable.Text = "View XOR Truth Table"
        Me.btnViewXORTruthTable.UseVisualStyleBackColor = True
        '
        'txtXORTruthTable
        '
        Me.txtXORTruthTable.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtXORTruthTable.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtXORTruthTable.Location = New System.Drawing.Point(407, 255)
        Me.txtXORTruthTable.Multiline = True
        Me.txtXORTruthTable.Name = "txtXORTruthTable"
        Me.txtXORTruthTable.ReadOnly = True
        Me.txtXORTruthTable.Size = New System.Drawing.Size(162, 150)
        Me.txtXORTruthTable.TabIndex = 34
        Me.txtXORTruthTable.TabStop = False
        Me.txtXORTruthTable.WordWrap = False
        '
        'btnEncryptDemo
        '
        Me.btnEncryptDemo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEncryptDemo.Location = New System.Drawing.Point(89, 179)
        Me.btnEncryptDemo.Name = "btnEncryptDemo"
        Me.btnEncryptDemo.Size = New System.Drawing.Size(87, 60)
        Me.btnEncryptDemo.TabIndex = 3
        Me.btnEncryptDemo.Text = "Demonstrate Vernam Encryption"
        Me.btnEncryptDemo.UseVisualStyleBackColor = True
        '
        'lblOneTimePad
        '
        Me.lblOneTimePad.AutoSize = True
        Me.lblOneTimePad.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblOneTimePad.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblOneTimePad.Location = New System.Drawing.Point(8, 88)
        Me.lblOneTimePad.Name = "lblOneTimePad"
        Me.lblOneTimePad.Size = New System.Drawing.Size(75, 13)
        Me.lblOneTimePad.TabIndex = 32
        Me.lblOneTimePad.Text = "One Time Pad"
        '
        'txtOneTimePad
        '
        Me.txtOneTimePad.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtOneTimePad.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtOneTimePad.Location = New System.Drawing.Point(89, 85)
        Me.txtOneTimePad.Multiline = True
        Me.txtOneTimePad.Name = "txtOneTimePad"
        Me.txtOneTimePad.Size = New System.Drawing.Size(265, 28)
        Me.txtOneTimePad.TabIndex = 1
        '
        'lblCiphertext
        '
        Me.lblCiphertext.AutoSize = True
        Me.lblCiphertext.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblCiphertext.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblCiphertext.Location = New System.Drawing.Point(8, 122)
        Me.lblCiphertext.Name = "lblCiphertext"
        Me.lblCiphertext.Size = New System.Drawing.Size(61, 13)
        Me.lblCiphertext.TabIndex = 30
        Me.lblCiphertext.Text = "Cipher Text"
        '
        'txtCipherText
        '
        Me.txtCipherText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtCipherText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCipherText.Location = New System.Drawing.Point(89, 119)
        Me.txtCipherText.Multiline = True
        Me.txtCipherText.Name = "txtCipherText"
        Me.txtCipherText.ReadOnly = True
        Me.txtCipherText.Size = New System.Drawing.Size(265, 54)
        Me.txtCipherText.TabIndex = 2
        '
        'lblPlainText
        '
        Me.lblPlainText.AutoSize = True
        Me.lblPlainText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPlainText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblPlainText.Location = New System.Drawing.Point(8, 28)
        Me.lblPlainText.Name = "lblPlainText"
        Me.lblPlainText.Size = New System.Drawing.Size(54, 13)
        Me.lblPlainText.TabIndex = 28
        Me.lblPlainText.Text = "Plain Text"
        '
        'txtPlainText
        '
        Me.txtPlainText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtPlainText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPlainText.Location = New System.Drawing.Point(89, 25)
        Me.txtPlainText.Multiline = True
        Me.txtPlainText.Name = "txtPlainText"
        Me.txtPlainText.Size = New System.Drawing.Size(265, 54)
        Me.txtPlainText.TabIndex = 0
        '
        'txtDemoHeader
        '
        Me.txtDemoHeader.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtDemoHeader.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDemoHeader.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDemoHeader.Location = New System.Drawing.Point(360, 24)
        Me.txtDemoHeader.Name = "txtDemoHeader"
        Me.txtDemoHeader.ReadOnly = True
        Me.txtDemoHeader.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDemoHeader.Size = New System.Drawing.Size(325, 20)
        Me.txtDemoHeader.TabIndex = 26
        Me.txtDemoHeader.TabStop = False
        Me.txtDemoHeader.Text = "Input         OTP           Output"
        '
        'txtBinaryXorDemo
        '
        Me.txtBinaryXorDemo.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtBinaryXorDemo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBinaryXorDemo.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtBinaryXorDemo.Location = New System.Drawing.Point(360, 40)
        Me.txtBinaryXorDemo.Multiline = True
        Me.txtBinaryXorDemo.Name = "txtBinaryXorDemo"
        Me.txtBinaryXorDemo.ReadOnly = True
        Me.txtBinaryXorDemo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBinaryXorDemo.Size = New System.Drawing.Size(325, 199)
        Me.txtBinaryXorDemo.TabIndex = 25
        Me.txtBinaryXorDemo.TabStop = False
        Me.txtBinaryXorDemo.WordWrap = False
        '
        'txtIndividualChars
        '
        Me.txtIndividualChars.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtIndividualChars.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndividualChars.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtIndividualChars.Location = New System.Drawing.Point(89, 255)
        Me.txtIndividualChars.Multiline = True
        Me.txtIndividualChars.Name = "txtIndividualChars"
        Me.txtIndividualChars.ReadOnly = True
        Me.txtIndividualChars.Size = New System.Drawing.Size(312, 150)
        Me.txtIndividualChars.TabIndex = 36
        Me.txtIndividualChars.TabStop = False
        '
        'btnIndividualChars
        '
        Me.btnIndividualChars.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIndividualChars.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIndividualChars.Location = New System.Drawing.Point(267, 179)
        Me.btnIndividualChars.Name = "btnIndividualChars"
        Me.btnIndividualChars.Size = New System.Drawing.Size(87, 60)
        Me.btnIndividualChars.TabIndex = 5
        Me.btnIndividualChars.Text = "Demonstrate Vernam XOR with One Character"
        Me.btnIndividualChars.UseVisualStyleBackColor = True
        '
        'btnShowDescription
        '
        Me.btnShowDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowDescription.Location = New System.Drawing.Point(575, 255)
        Me.btnShowDescription.Name = "btnShowDescription"
        Me.btnShowDescription.Size = New System.Drawing.Size(110, 44)
        Me.btnShowDescription.TabIndex = 6
        Me.btnShowDescription.Text = "Show Description" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnShowDescription.UseVisualStyleBackColor = True
        '
        'btnHideDescription
        '
        Me.btnHideDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHideDescription.Location = New System.Drawing.Point(575, 255)
        Me.btnHideDescription.Name = "btnHideDescription"
        Me.btnHideDescription.Size = New System.Drawing.Size(110, 44)
        Me.btnHideDescription.TabIndex = 6
        Me.btnHideDescription.Text = "Hide Description" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnHideDescription.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDescription.Location = New System.Drawing.Point(717, 28)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(312, 322)
        Me.txtDescription.TabIndex = 40
        Me.txtDescription.Text = resources.GetString("txtDescription.Text")
        '
        'frmVernamVisual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(701, 434)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.btnShowDescription)
        Me.Controls.Add(Me.btnIndividualChars)
        Me.Controls.Add(Me.txtIndividualChars)
        Me.Controls.Add(Me.btnViewXORTruthTable)
        Me.Controls.Add(Me.txtXORTruthTable)
        Me.Controls.Add(Me.btnEncryptDemo)
        Me.Controls.Add(Me.lblOneTimePad)
        Me.Controls.Add(Me.txtOneTimePad)
        Me.Controls.Add(Me.lblCiphertext)
        Me.Controls.Add(Me.txtCipherText)
        Me.Controls.Add(Me.lblPlainText)
        Me.Controls.Add(Me.txtPlainText)
        Me.Controls.Add(Me.txtDemoHeader)
        Me.Controls.Add(Me.txtBinaryXorDemo)
        Me.Controls.Add(Me.btnHideDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVernamVisual"
        Me.Text = "Vernam Cipher Visual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnViewXORTruthTable As System.Windows.Forms.Button
    Friend WithEvents txtXORTruthTable As System.Windows.Forms.TextBox
    Friend WithEvents btnEncryptDemo As System.Windows.Forms.Button
    Friend WithEvents lblOneTimePad As System.Windows.Forms.Label
    Friend WithEvents txtOneTimePad As System.Windows.Forms.TextBox
    Friend WithEvents lblCiphertext As System.Windows.Forms.Label
    Friend WithEvents txtCipherText As System.Windows.Forms.TextBox
    Friend WithEvents lblPlainText As System.Windows.Forms.Label
    Friend WithEvents txtPlainText As System.Windows.Forms.TextBox
    Friend WithEvents txtDemoHeader As System.Windows.Forms.TextBox
    Friend WithEvents txtBinaryXorDemo As System.Windows.Forms.TextBox
    Friend WithEvents txtIndividualChars As System.Windows.Forms.TextBox
    Friend WithEvents btnIndividualChars As System.Windows.Forms.Button
    Friend WithEvents btnShowDescription As System.Windows.Forms.Button
    Friend WithEvents btnHideDescription As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
End Class
