Imports Cipher.Business

Public Class frmRailFenceCryptanalysis

    Private Property _RailFence As RailFence

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me._RailFence = New RailFence
    End Sub

    Private Sub FrmRailFenceCryptanalysis_Load(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCipherText.Text = frmRailFenceEncryptDecrypt.txtCipherText.Text
    End Sub

    Private Sub btnBruteForce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBruteForce.Click
        Dim plainText As String = ""
        Dim cipherText As String = txtCipherText.Text.Replace(" ", "")
        txtPlainText.Clear()

        'Loop through each number of rails, and list them all out
        'Continue until the number of rails is the 1 less than the number of characters
        For i = 2 To Len(txtCipherText.Text) - 1
            txtPlainText.Text &= "key: " & i & ", "
            'txtPlainText.Text &= Environment.NewLine
            Dim RailsArray(Len(cipherText) - 1, i - 1)
            RailsArray = _RailFence.populateRailsArray(Len(cipherText), i, cipherText)
            txtPlainText.Text &= "plaintext: " & _RailFence.Decrypt(Len(cipherText), i, RailsArray)
            txtPlainText.Text &= Environment.NewLine
        Next
    End Sub

    Private Sub btnShowDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(701, 480))
        Me.btnHideDescription.Show()
        Me.btnShowDescription.Hide()
        'extend the form to show the description of how the form works
    End Sub

    Private Sub btnHideDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(425, 480))
        Me.btnHideDescription.Hide()
        Me.btnShowDescription.Show()
        'reverts the form back to original size to hide the description of how the form works
    End Sub

End Class