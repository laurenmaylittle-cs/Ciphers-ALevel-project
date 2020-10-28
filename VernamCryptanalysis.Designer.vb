<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVernamCryptanalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVernamCryptanalysis))
        Me.txtCryptanalysis = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtListWords = New System.Windows.Forms.TextBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.btnShowDescription = New System.Windows.Forms.Button()
        Me.btnHideDescription = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCryptanalysis
        '
        Me.txtCryptanalysis.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtCryptanalysis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCryptanalysis.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCryptanalysis.Location = New System.Drawing.Point(566, 12)
        Me.txtCryptanalysis.Multiline = True
        Me.txtCryptanalysis.Name = "txtCryptanalysis"
        Me.txtCryptanalysis.ReadOnly = True
        Me.txtCryptanalysis.Size = New System.Drawing.Size(477, 495)
        Me.txtCryptanalysis.TabIndex = 3
        Me.txtCryptanalysis.Text = resources.GetString("txtCryptanalysis.Text")
        '
        'btnCheck
        '
        Me.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheck.Location = New System.Drawing.Point(413, 116)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(100, 39)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "Run Process"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtListWords
        '
        Me.txtListWords.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtListWords.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtListWords.HideSelection = False
        Me.txtListWords.Location = New System.Drawing.Point(12, 12)
        Me.txtListWords.Multiline = True
        Me.txtListWords.Name = "txtListWords"
        Me.txtListWords.ReadOnly = True
        Me.txtListWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtListWords.Size = New System.Drawing.Size(338, 495)
        Me.txtListWords.TabIndex = 3
        '
        'txtWord
        '
        Me.txtWord.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtWord.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtWord.Location = New System.Drawing.Point(478, 76)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(71, 20)
        Me.txtWord.TabIndex = 0
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblTest.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblTest.Location = New System.Drawing.Point(353, 79)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(119, 13)
        Me.lblTest.TabIndex = 4
        Me.lblTest.Text = "Enter 4 letter cipher text"
        '
        'btnShowDescription
        '
        Me.btnShowDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDescription.Location = New System.Drawing.Point(356, 468)
        Me.btnShowDescription.Name = "btnShowDescription"
        Me.btnShowDescription.Size = New System.Drawing.Size(100, 39)
        Me.btnShowDescription.TabIndex = 2
        Me.btnShowDescription.Text = "Show Description"
        Me.btnShowDescription.UseVisualStyleBackColor = True
        '
        'btnHideDescription
        '
        Me.btnHideDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideDescription.Location = New System.Drawing.Point(356, 468)
        Me.btnHideDescription.Name = "btnHideDescription"
        Me.btnHideDescription.Size = New System.Drawing.Size(100, 39)
        Me.btnHideDescription.TabIndex = 6
        Me.btnHideDescription.Text = "Hide Description"
        Me.btnHideDescription.UseVisualStyleBackColor = True
        '
        'frmVernamCryptanalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(564, 532)
        Me.Controls.Add(Me.btnShowDescription)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.txtListWords)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtCryptanalysis)
        Me.Controls.Add(Me.btnHideDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmVernamCryptanalysis"
        Me.Text = "Vernam Cipher Cryptanalysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCryptanalysis As System.Windows.Forms.TextBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents txtListWords As System.Windows.Forms.TextBox
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents lblTest As System.Windows.Forms.Label
    Friend WithEvents btnShowDescription As System.Windows.Forms.Button
    Friend WithEvents btnHideDescription As System.Windows.Forms.Button
End Class
