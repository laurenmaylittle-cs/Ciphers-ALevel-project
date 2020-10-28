<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.mnuCaesar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCaesarDescription = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCaesarEncryptDecrypt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCaesarCryptanalysis = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCaesarVisual = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVernam = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVernamDescription = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVernamEncryptDecrypt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVernamCryptanalysis = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVernamVisual = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVigenere = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVigenereDescription = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVigenereEncryptDecrypt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVigenereCryptanalysis = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVigenereVisual = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRailFence = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRailFenceDescription = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRailFenceEncryptDecrypt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRailFenceCryptanalysis = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRailFenceVisual = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInfo
        '
        Me.txtInfo.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtInfo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtInfo.Location = New System.Drawing.Point(22, 41)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.Size = New System.Drawing.Size(599, 449)
        Me.txtInfo.TabIndex = 1
        '
        'mnuCaesar
        '
        Me.mnuCaesar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuCaesar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCaesarDescription, Me.mnuCaesarEncryptDecrypt, Me.mnuCaesarCryptanalysis, Me.mnuCaesarVisual})
        Me.mnuCaesar.Name = "mnuCaesar"
        Me.mnuCaesar.Size = New System.Drawing.Size(54, 20)
        Me.mnuCaesar.Text = "Caesar"
        Me.mnuCaesar.ToolTipText = "Simple Substitution Cipher"
        '
        'mnuCaesarDescription
        '
        Me.mnuCaesarDescription.Name = "mnuCaesarDescription"
        Me.mnuCaesarDescription.Size = New System.Drawing.Size(166, 22)
        Me.mnuCaesarDescription.Text = "Description"
        '
        'mnuCaesarEncryptDecrypt
        '
        Me.mnuCaesarEncryptDecrypt.Name = "mnuCaesarEncryptDecrypt"
        Me.mnuCaesarEncryptDecrypt.Size = New System.Drawing.Size(166, 22)
        Me.mnuCaesarEncryptDecrypt.Text = "Encrypt / Decrypt"
        '
        'mnuCaesarCryptanalysis
        '
        Me.mnuCaesarCryptanalysis.Name = "mnuCaesarCryptanalysis"
        Me.mnuCaesarCryptanalysis.Size = New System.Drawing.Size(166, 22)
        Me.mnuCaesarCryptanalysis.Text = "Cryptanalysis"
        '
        'mnuCaesarVisual
        '
        Me.mnuCaesarVisual.Name = "mnuCaesarVisual"
        Me.mnuCaesarVisual.Size = New System.Drawing.Size(166, 22)
        Me.mnuCaesarVisual.Text = "Visual"
        '
        'mnuVernam
        '
        Me.mnuVernam.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuVernamDescription, Me.mnuVernamEncryptDecrypt, Me.mnuVernamCryptanalysis, Me.mnuVernamVisual})
        Me.mnuVernam.Name = "mnuVernam"
        Me.mnuVernam.Size = New System.Drawing.Size(59, 20)
        Me.mnuVernam.Text = "Vernam"
        Me.mnuVernam.ToolTipText = """One time pad"" version of Vigenere cipher"
        '
        'mnuVernamDescription
        '
        Me.mnuVernamDescription.Name = "mnuVernamDescription"
        Me.mnuVernamDescription.Size = New System.Drawing.Size(166, 22)
        Me.mnuVernamDescription.Text = "Description"
        '
        'mnuVernamEncryptDecrypt
        '
        Me.mnuVernamEncryptDecrypt.Name = "mnuVernamEncryptDecrypt"
        Me.mnuVernamEncryptDecrypt.Size = New System.Drawing.Size(166, 22)
        Me.mnuVernamEncryptDecrypt.Text = "Encrypt / Decrypt"
        '
        'mnuVernamCryptanalysis
        '
        Me.mnuVernamCryptanalysis.Name = "mnuVernamCryptanalysis"
        Me.mnuVernamCryptanalysis.Size = New System.Drawing.Size(166, 22)
        Me.mnuVernamCryptanalysis.Text = "Cryptanalysis"
        '
        'mnuVernamVisual
        '
        Me.mnuVernamVisual.Name = "mnuVernamVisual"
        Me.mnuVernamVisual.Size = New System.Drawing.Size(166, 22)
        Me.mnuVernamVisual.Text = "Visual"
        '
        'mnuVigenere
        '
        Me.mnuVigenere.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuVigenereDescription, Me.mnuVigenereEncryptDecrypt, Me.mnuVigenereCryptanalysis, Me.mnuVigenereVisual})
        Me.mnuVigenere.Name = "mnuVigenere"
        Me.mnuVigenere.Size = New System.Drawing.Size(65, 20)
        Me.mnuVigenere.Text = "Vigenere"
        Me.mnuVigenere.ToolTipText = "Polyalphabetic Cipher"
        '
        'mnuVigenereDescription
        '
        Me.mnuVigenereDescription.Name = "mnuVigenereDescription"
        Me.mnuVigenereDescription.Size = New System.Drawing.Size(166, 22)
        Me.mnuVigenereDescription.Text = "Description"
        '
        'mnuVigenereEncryptDecrypt
        '
        Me.mnuVigenereEncryptDecrypt.Name = "mnuVigenereEncryptDecrypt"
        Me.mnuVigenereEncryptDecrypt.Size = New System.Drawing.Size(166, 22)
        Me.mnuVigenereEncryptDecrypt.Text = "Encrypt / Decrypt"
        '
        'mnuVigenereCryptanalysis
        '
        Me.mnuVigenereCryptanalysis.Name = "mnuVigenereCryptanalysis"
        Me.mnuVigenereCryptanalysis.Size = New System.Drawing.Size(166, 22)
        Me.mnuVigenereCryptanalysis.Text = "Cryptanalysis"
        '
        'mnuVigenereVisual
        '
        Me.mnuVigenereVisual.Name = "mnuVigenereVisual"
        Me.mnuVigenereVisual.Size = New System.Drawing.Size(166, 22)
        Me.mnuVigenereVisual.Text = "Visual"
        '
        'mnuRailFence
        '
        Me.mnuRailFence.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRailFenceDescription, Me.mnuRailFenceEncryptDecrypt, Me.mnuRailFenceCryptanalysis, Me.mnuRailFenceVisual})
        Me.mnuRailFence.Name = "mnuRailFence"
        Me.mnuRailFence.Size = New System.Drawing.Size(72, 20)
        Me.mnuRailFence.Text = "Rail Fence"
        Me.mnuRailFence.ToolTipText = "Transposition cipher"
        '
        'mnuRailFenceDescription
        '
        Me.mnuRailFenceDescription.Name = "mnuRailFenceDescription"
        Me.mnuRailFenceDescription.Size = New System.Drawing.Size(166, 22)
        Me.mnuRailFenceDescription.Text = "Description"
        '
        'mnuRailFenceEncryptDecrypt
        '
        Me.mnuRailFenceEncryptDecrypt.Name = "mnuRailFenceEncryptDecrypt"
        Me.mnuRailFenceEncryptDecrypt.Size = New System.Drawing.Size(166, 22)
        Me.mnuRailFenceEncryptDecrypt.Text = "Encrypt / Decrypt"
        '
        'mnuRailFenceCryptanalysis
        '
        Me.mnuRailFenceCryptanalysis.Name = "mnuRailFenceCryptanalysis"
        Me.mnuRailFenceCryptanalysis.Size = New System.Drawing.Size(166, 22)
        Me.mnuRailFenceCryptanalysis.Text = "Cryptanalysis"
        '
        'mnuRailFenceVisual
        '
        Me.mnuRailFenceVisual.Name = "mnuRailFenceVisual"
        Me.mnuRailFenceVisual.Size = New System.Drawing.Size(166, 22)
        Me.mnuRailFenceVisual.Text = "Visual"
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCaesar, Me.mnuVigenere, Me.mnuRailFence, Me.mnuVernam})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.ShowItemToolTips = True
        Me.Menu.Size = New System.Drawing.Size(645, 24)
        Me.Menu.TabIndex = 0
        Me.Menu.TabStop = True
        Me.Menu.Text = "MenuStrip1"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(22, 496)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(87, 41)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Reset to HomePage"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(645, 550)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menu
        Me.MaximizeBox = False
        Me.Name = "HomeForm"
        Me.Text = "Cryptography / Cryptanalysis"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents mnuCaesar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCaesarEncryptDecrypt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCaesarCryptanalysis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVernam As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVernamEncryptDecrypt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVernamCryptanalysis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVigenere As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVigenereEncryptDecrypt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVigenereCryptanalysis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRailFence As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRailFenceEncryptDecrypt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRailFenceCryptanalysis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuVigenereVisual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCaesarVisual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRailFenceVisual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVernamVisual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCaesarDescription As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents mnuVigenereDescription As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVernamDescription As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRailFenceDescription As System.Windows.Forms.ToolStripMenuItem

End Class
