<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRailFenceVisual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRailFenceVisual))
        Me.txtRails = New System.Windows.Forms.TextBox()
        Me.btnRails = New System.Windows.Forms.Button()
        Me.btnRandRails = New System.Windows.Forms.Button()
        Me.btnIncreaseRails = New System.Windows.Forms.Button()
        Me.btnDecreaseRails = New System.Windows.Forms.Button()
        Me.txtPlainText = New System.Windows.Forms.TextBox()
        Me.txtCipherText = New System.Windows.Forms.TextBox()
        Me.lblPlainText = New System.Windows.Forms.Label()
        Me.lblCipherText = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnShowDescription = New System.Windows.Forms.Button()
        Me.btnHideDescription = New System.Windows.Forms.Button()
        Me.rtxVisualRailFence = New System.Windows.Forms.RichTextBox()
        Me.btnStepByStep = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRails
        '
        Me.txtRails.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtRails.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtRails.Location = New System.Drawing.Point(118, 245)
        Me.txtRails.Multiline = True
        Me.txtRails.Name = "txtRails"
        Me.txtRails.Size = New System.Drawing.Size(37, 25)
        Me.txtRails.TabIndex = 2
        '
        'btnRails
        '
        Me.btnRails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRails.Location = New System.Drawing.Point(24, 234)
        Me.btnRails.Name = "btnRails"
        Me.btnRails.Size = New System.Drawing.Size(88, 40)
        Me.btnRails.TabIndex = 3
        Me.btnRails.Text = "Set number of rails to...."
        Me.btnRails.UseVisualStyleBackColor = True
        '
        'btnRandRails
        '
        Me.btnRandRails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRandRails.Location = New System.Drawing.Point(173, 234)
        Me.btnRandRails.Name = "btnRandRails"
        Me.btnRandRails.Size = New System.Drawing.Size(88, 40)
        Me.btnRandRails.TabIndex = 4
        Me.btnRandRails.Text = "Random Rails"
        Me.btnRandRails.UseVisualStyleBackColor = True
        '
        'btnIncreaseRails
        '
        Me.btnIncreaseRails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncreaseRails.Location = New System.Drawing.Point(267, 234)
        Me.btnIncreaseRails.Name = "btnIncreaseRails"
        Me.btnIncreaseRails.Size = New System.Drawing.Size(88, 40)
        Me.btnIncreaseRails.TabIndex = 5
        Me.btnIncreaseRails.Text = "Increase Rails"
        Me.btnIncreaseRails.UseVisualStyleBackColor = True
        '
        'btnDecreaseRails
        '
        Me.btnDecreaseRails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDecreaseRails.Location = New System.Drawing.Point(361, 234)
        Me.btnDecreaseRails.Name = "btnDecreaseRails"
        Me.btnDecreaseRails.Size = New System.Drawing.Size(88, 40)
        Me.btnDecreaseRails.TabIndex = 6
        Me.btnDecreaseRails.Text = "Decrease Rails "
        Me.btnDecreaseRails.UseVisualStyleBackColor = True
        '
        'txtPlainText
        '
        Me.txtPlainText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtPlainText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPlainText.Location = New System.Drawing.Point(89, 12)
        Me.txtPlainText.Multiline = True
        Me.txtPlainText.Name = "txtPlainText"
        Me.txtPlainText.Size = New System.Drawing.Size(260, 42)
        Me.txtPlainText.TabIndex = 0
        '
        'txtCipherText
        '
        Me.txtCipherText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtCipherText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCipherText.Location = New System.Drawing.Point(434, 12)
        Me.txtCipherText.Multiline = True
        Me.txtCipherText.Name = "txtCipherText"
        Me.txtCipherText.ReadOnly = True
        Me.txtCipherText.Size = New System.Drawing.Size(261, 42)
        Me.txtCipherText.TabIndex = 1
        '
        'lblPlainText
        '
        Me.lblPlainText.AutoSize = True
        Me.lblPlainText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPlainText.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPlainText.Location = New System.Drawing.Point(32, 27)
        Me.lblPlainText.Name = "lblPlainText"
        Me.lblPlainText.Size = New System.Drawing.Size(51, 13)
        Me.lblPlainText.TabIndex = 8
        Me.lblPlainText.Text = "PlainText"
        '
        'lblCipherText
        '
        Me.lblCipherText.AutoSize = True
        Me.lblCipherText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCipherText.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCipherText.Location = New System.Drawing.Point(370, 27)
        Me.lblCipherText.Name = "lblCipherText"
        Me.lblCipherText.Size = New System.Drawing.Size(58, 13)
        Me.lblCipherText.TabIndex = 9
        Me.lblCipherText.Text = "CipherText"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDescription.Location = New System.Drawing.Point(24, 288)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(671, 181)
        Me.txtDescription.TabIndex = 10
        Me.txtDescription.Text = resources.GetString("txtDescription.Text")
        '
        'btnShowDescription
        '
        Me.btnShowDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDescription.Location = New System.Drawing.Point(607, 234)
        Me.btnShowDescription.Name = "btnShowDescription"
        Me.btnShowDescription.Size = New System.Drawing.Size(88, 40)
        Me.btnShowDescription.TabIndex = 8
        Me.btnShowDescription.Text = "Show Description"
        Me.btnShowDescription.UseVisualStyleBackColor = True
        '
        'btnHideDescription
        '
        Me.btnHideDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideDescription.Location = New System.Drawing.Point(607, 234)
        Me.btnHideDescription.Name = "btnHideDescription"
        Me.btnHideDescription.Size = New System.Drawing.Size(88, 40)
        Me.btnHideDescription.TabIndex = 12
        Me.btnHideDescription.Text = "Hide Description"
        Me.btnHideDescription.UseVisualStyleBackColor = True
        '
        'rtxVisualRailFence
        '
        Me.rtxVisualRailFence.BackColor = System.Drawing.SystemColors.ControlText
        Me.rtxVisualRailFence.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxVisualRailFence.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.rtxVisualRailFence.Location = New System.Drawing.Point(24, 69)
        Me.rtxVisualRailFence.Name = "rtxVisualRailFence"
        Me.rtxVisualRailFence.Size = New System.Drawing.Size(671, 150)
        Me.rtxVisualRailFence.TabIndex = 13
        Me.rtxVisualRailFence.TabStop = False
        Me.rtxVisualRailFence.Text = ""
        Me.rtxVisualRailFence.WordWrap = False
        '
        'btnStepByStep
        '
        Me.btnStepByStep.Location = New System.Drawing.Point(504, 234)
        Me.btnStepByStep.Name = "btnStepByStep"
        Me.btnStepByStep.Size = New System.Drawing.Size(91, 40)
        Me.btnStepByStep.TabIndex = 7
        Me.btnStepByStep.Text = "Step by Step"
        Me.btnStepByStep.UseVisualStyleBackColor = True
        '
        'frmRailFenceVisual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(715, 286)
        Me.Controls.Add(Me.btnStepByStep)
        Me.Controls.Add(Me.rtxVisualRailFence)
        Me.Controls.Add(Me.btnShowDescription)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblCipherText)
        Me.Controls.Add(Me.lblPlainText)
        Me.Controls.Add(Me.txtCipherText)
        Me.Controls.Add(Me.txtPlainText)
        Me.Controls.Add(Me.btnDecreaseRails)
        Me.Controls.Add(Me.btnIncreaseRails)
        Me.Controls.Add(Me.btnRandRails)
        Me.Controls.Add(Me.btnRails)
        Me.Controls.Add(Me.txtRails)
        Me.Controls.Add(Me.btnHideDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRailFenceVisual"
        Me.Text = "Rail Fence Cipher Visual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRails As System.Windows.Forms.TextBox
    Friend WithEvents btnRails As System.Windows.Forms.Button
    Friend WithEvents btnRandRails As System.Windows.Forms.Button
    Friend WithEvents btnIncreaseRails As System.Windows.Forms.Button
    Friend WithEvents btnDecreaseRails As System.Windows.Forms.Button
    Friend WithEvents txtPlainText As System.Windows.Forms.TextBox
    Friend WithEvents txtCipherText As System.Windows.Forms.TextBox
    Friend WithEvents lblPlainText As System.Windows.Forms.Label
    Friend WithEvents lblCipherText As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnShowDescription As System.Windows.Forms.Button
    Friend WithEvents btnHideDescription As System.Windows.Forms.Button
    Friend WithEvents rtxVisualRailFence As System.Windows.Forms.RichTextBox
    Friend WithEvents btnStepByStep As System.Windows.Forms.Button
End Class
