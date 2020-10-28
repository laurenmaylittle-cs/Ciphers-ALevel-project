<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRailFenceCryptanalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRailFenceCryptanalysis))
        Me.txtCipherText = New System.Windows.Forms.TextBox()
        Me.LblCipherText = New System.Windows.Forms.Label()
        Me.btnBruteForce = New System.Windows.Forms.Button()
        Me.txtPlainText = New System.Windows.Forms.TextBox()
        Me.txtShowDescription = New System.Windows.Forms.TextBox()
        Me.btnShowDescription = New System.Windows.Forms.Button()
        Me.btnHideDescription = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCipherText
        '
        Me.txtCipherText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtCipherText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCipherText.Location = New System.Drawing.Point(70, 12)
        Me.txtCipherText.Multiline = True
        Me.txtCipherText.Name = "txtCipherText"
        Me.txtCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCipherText.Size = New System.Drawing.Size(332, 102)
        Me.txtCipherText.TabIndex = 0
        '
        'LblCipherText
        '
        Me.LblCipherText.AutoSize = True
        Me.LblCipherText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblCipherText.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LblCipherText.Location = New System.Drawing.Point(6, 48)
        Me.LblCipherText.Name = "LblCipherText"
        Me.LblCipherText.Size = New System.Drawing.Size(58, 13)
        Me.LblCipherText.TabIndex = 1
        Me.LblCipherText.Text = "CipherText"
        '
        'btnBruteForce
        '
        Me.btnBruteForce.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBruteForce.Location = New System.Drawing.Point(70, 120)
        Me.btnBruteForce.Name = "btnBruteForce"
        Me.btnBruteForce.Size = New System.Drawing.Size(109, 50)
        Me.btnBruteForce.TabIndex = 1
        Me.btnBruteForce.Text = "Crack Cipher With Brute Force"
        Me.btnBruteForce.UseVisualStyleBackColor = True
        '
        'txtPlainText
        '
        Me.txtPlainText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtPlainText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPlainText.Location = New System.Drawing.Point(70, 176)
        Me.txtPlainText.Multiline = True
        Me.txtPlainText.Name = "txtPlainText"
        Me.txtPlainText.ReadOnly = True
        Me.txtPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPlainText.Size = New System.Drawing.Size(332, 254)
        Me.txtPlainText.TabIndex = 3
        Me.txtPlainText.TabStop = False
        '
        'txtShowDescription
        '
        Me.txtShowDescription.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtShowDescription.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtShowDescription.Location = New System.Drawing.Point(427, 12)
        Me.txtShowDescription.Multiline = True
        Me.txtShowDescription.Name = "txtShowDescription"
        Me.txtShowDescription.ReadOnly = True
        Me.txtShowDescription.Size = New System.Drawing.Size(246, 418)
        Me.txtShowDescription.TabIndex = 4
        Me.txtShowDescription.Text = resources.GetString("txtShowDescription.Text")
        '
        'btnShowDescription
        '
        Me.btnShowDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDescription.Location = New System.Drawing.Point(304, 120)
        Me.btnShowDescription.Name = "btnShowDescription"
        Me.btnShowDescription.Size = New System.Drawing.Size(98, 50)
        Me.btnShowDescription.TabIndex = 2
        Me.btnShowDescription.Text = "Show Description"
        Me.btnShowDescription.UseVisualStyleBackColor = True
        '
        'btnHideDescription
        '
        Me.btnHideDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideDescription.Location = New System.Drawing.Point(304, 120)
        Me.btnHideDescription.Name = "btnHideDescription"
        Me.btnHideDescription.Size = New System.Drawing.Size(98, 50)
        Me.btnHideDescription.TabIndex = 5
        Me.btnHideDescription.Text = "Hide Description"
        Me.btnHideDescription.UseVisualStyleBackColor = True
        '
        'frmRailFenceCryptanalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(419, 451)
        Me.Controls.Add(Me.btnShowDescription)
        Me.Controls.Add(Me.txtShowDescription)
        Me.Controls.Add(Me.txtPlainText)
        Me.Controls.Add(Me.btnBruteForce)
        Me.Controls.Add(Me.LblCipherText)
        Me.Controls.Add(Me.txtCipherText)
        Me.Controls.Add(Me.btnHideDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRailFenceCryptanalysis"
        Me.Text = "Rail Fence Cipher Cryptanalysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCipherText As System.Windows.Forms.TextBox
    Friend WithEvents LblCipherText As System.Windows.Forms.Label
    Friend WithEvents btnBruteForce As System.Windows.Forms.Button
    Friend WithEvents txtPlainText As System.Windows.Forms.TextBox
    Friend WithEvents txtShowDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnShowDescription As System.Windows.Forms.Button
    Friend WithEvents btnHideDescription As System.Windows.Forms.Button
End Class
