Imports Cipher.Business

Public Class frmRailFenceEncryptDecrypt

    Private Property _RailFence As RailFence

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me._RailFence = New RailFence
    End Sub

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        Dim valid As Boolean
        Dim plainText As String = txtPlainText.Text.Replace(" ", "")

        txtCipherText.Clear()

        'Validate the number of rails entered
        valid = _RailFence.ValidateRails(txtRails.Text, plainText, 0)
        If valid Then
            'Set up array of elements
            Dim Visual(Len(plainText) - 1, txtRails.Text - 1)
            Visual = _RailFence.PopulateVisualArray(Len(plainText), txtRails.Text, plainText)

            'Encrypt array of elements
            txtCipherText.Text = _RailFence.Encrypt(Len(plainText), txtRails.Text, Visual)
        End If

    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        Dim valid As Boolean
        Dim cipherText As String = txtCipherText.Text.Replace(" ", "")    'Already has no spaces!

        txtPlainText.Clear()

        'Validate the number of rails entered
        valid = _RailFence.ValidateRails(txtRails.Text, cipherText, 0)
        If valid Then
            Dim RailsArray(Len(cipherText) - 1, txtRails.Text - 1)
            RailsArray = _RailFence.PopulateRailsArray(Len(cipherText), txtRails.Text, cipherText)

            'Decrypt array of elements
            txtPlainText.Text = _RailFence.Decrypt(Len(cipherText), txtRails.Text, RailsArray)
        End If

    End Sub

    Private Sub btnCryptanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCryptanalysis.Click
        frmRailFenceCryptanalysis.Show()
        'shows cryptanalysis form
    End Sub

    Private Sub btnViewVisual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewVisual.Click
        frmRailFenceVisual.Show()
        'shows visual form
    End Sub

    Private Sub btnShowDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(854, 410))
        Me.btnHideDescription.Show()
        Me.btnShowDescription.Hide()
        'extend the form to show the description of how the form works
    End Sub

    Private Sub btnHideDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(430, 360))
        Me.btnHideDescription.Hide()
        Me.btnShowDescription.Show()
        'reverts the form back to original size to hide the description of how the form works
    End Sub
End Class