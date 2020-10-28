<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVigenereVisual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVigenereVisual))
        Me.btnDemo = New System.Windows.Forms.Button()
        Me.rtxVisual = New System.Windows.Forms.RichTextBox()
        Me.txtPlainText = New System.Windows.Forms.TextBox()
        Me.txtCipherText = New System.Windows.Forms.TextBox()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.lblPlainText = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.lblCipherText = New System.Windows.Forms.Label()
        Me.txtDemo = New System.Windows.Forms.TextBox()
        Me.btnShowDescription = New System.Windows.Forms.Button()
        Me.btnHideDescription = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDemo
        '
        Me.btnDemo.Location = New System.Drawing.Point(576, 255)
        Me.btnDemo.Name = "btnDemo"
        Me.btnDemo.Size = New System.Drawing.Size(230, 50)
        Me.btnDemo.TabIndex = 2
        Me.btnDemo.Text = "Demonstrate Encryption Process - Step by Step"
        Me.btnDemo.UseVisualStyleBackColor = True
        '
        'rtxVisual
        '
        Me.rtxVisual.BackColor = System.Drawing.Color.Black
        Me.rtxVisual.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxVisual.ForeColor = System.Drawing.Color.White
        Me.rtxVisual.Location = New System.Drawing.Point(22, 16)
        Me.rtxVisual.Name = "rtxVisual"
        Me.rtxVisual.ReadOnly = True
        Me.rtxVisual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtxVisual.Size = New System.Drawing.Size(481, 458)
        Me.rtxVisual.TabIndex = 40
        Me.rtxVisual.Text = ""
        '
        'txtPlainText
        '
        Me.txtPlainText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtPlainText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlainText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPlainText.Location = New System.Drawing.Point(576, 42)
        Me.txtPlainText.Multiline = True
        Me.txtPlainText.Name = "txtPlainText"
        Me.txtPlainText.Size = New System.Drawing.Size(230, 76)
        Me.txtPlainText.TabIndex = 0
        '
        'txtCipherText
        '
        Me.txtCipherText.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtCipherText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCipherText.Location = New System.Drawing.Point(576, 176)
        Me.txtCipherText.Multiline = True
        Me.txtCipherText.Name = "txtCipherText"
        Me.txtCipherText.ReadOnly = True
        Me.txtCipherText.Size = New System.Drawing.Size(230, 73)
        Me.txtCipherText.TabIndex = 3
        Me.txtCipherText.TabStop = False
        '
        'txtKey
        '
        Me.txtKey.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKey.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtKey.Location = New System.Drawing.Point(576, 124)
        Me.txtKey.Multiline = True
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(230, 46)
        Me.txtKey.TabIndex = 1
        '
        'lblPlainText
        '
        Me.lblPlainText.AutoSize = True
        Me.lblPlainText.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblPlainText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblPlainText.Location = New System.Drawing.Point(516, 42)
        Me.lblPlainText.Name = "lblPlainText"
        Me.lblPlainText.Size = New System.Drawing.Size(54, 13)
        Me.lblPlainText.TabIndex = 44
        Me.lblPlainText.Text = "Plain Text"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblKey.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblKey.Location = New System.Drawing.Point(516, 124)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(25, 13)
        Me.lblKey.TabIndex = 45
        Me.lblKey.Text = "Key"
        '
        'lblCipherText
        '
        Me.lblCipherText.AutoSize = True
        Me.lblCipherText.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblCipherText.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblCipherText.Location = New System.Drawing.Point(509, 176)
        Me.lblCipherText.Name = "lblCipherText"
        Me.lblCipherText.Size = New System.Drawing.Size(61, 13)
        Me.lblCipherText.TabIndex = 46
        Me.lblCipherText.Text = "Cipher Text"
        '
        'txtDemo
        '
        Me.txtDemo.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtDemo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDemo.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDemo.Location = New System.Drawing.Point(576, 311)
        Me.txtDemo.Multiline = True
        Me.txtDemo.Name = "txtDemo"
        Me.txtDemo.ReadOnly = True
        Me.txtDemo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDemo.Size = New System.Drawing.Size(230, 73)
        Me.txtDemo.TabIndex = 4
        Me.txtDemo.TabStop = False
        Me.txtDemo.WordWrap = False
        '
        'btnShowDescription
        '
        Me.btnShowDescription.Location = New System.Drawing.Point(719, 390)
        Me.btnShowDescription.Name = "btnShowDescription"
        Me.btnShowDescription.Size = New System.Drawing.Size(87, 51)
        Me.btnShowDescription.TabIndex = 3
        Me.btnShowDescription.Text = "Show Description"
        Me.btnShowDescription.UseVisualStyleBackColor = True
        '
        'btnHideDescription
        '
        Me.btnHideDescription.Location = New System.Drawing.Point(719, 390)
        Me.btnHideDescription.Name = "btnHideDescription"
        Me.btnHideDescription.Size = New System.Drawing.Size(87, 51)
        Me.btnHideDescription.TabIndex = 5
        Me.btnHideDescription.Text = "Hide Description"
        Me.btnHideDescription.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDescription.Location = New System.Drawing.Point(821, 42)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(242, 342)
        Me.txtDescription.TabIndex = 6
        Me.txtDescription.Text = resources.GetString("txtDescription.Text")
        '
        'frmVigenereVisual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(820, 494)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.btnShowDescription)
        Me.Controls.Add(Me.txtDemo)
        Me.Controls.Add(Me.lblCipherText)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.lblPlainText)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.txtCipherText)
        Me.Controls.Add(Me.txtPlainText)
        Me.Controls.Add(Me.rtxVisual)
        Me.Controls.Add(Me.btnDemo)
        Me.Controls.Add(Me.btnHideDescription)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmVigenereVisual"
        Me.Text = "Vigenere Cipher Visual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDemo As System.Windows.Forms.Button
    Friend WithEvents rtxVisual As System.Windows.Forms.RichTextBox
    Friend WithEvents txtPlainText As System.Windows.Forms.TextBox
    Friend WithEvents txtCipherText As System.Windows.Forms.TextBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents lblPlainText As System.Windows.Forms.Label
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents lblCipherText As System.Windows.Forms.Label
    Friend WithEvents txtDemo As System.Windows.Forms.TextBox
    Friend WithEvents btnShowDescription As System.Windows.Forms.Button
    Friend WithEvents btnHideDescription As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
End Class
