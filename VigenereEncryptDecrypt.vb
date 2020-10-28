Imports Cipher.Business
Imports System.Text.RegularExpressions
Imports System.Configuration

Public Class frmVigenereEncryptDecrypt

    Private Property _Vigenere As Vigenere

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me._Vigenere = New Vigenere
    End Sub

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        Dim valid As Boolean = _Vigenere.validateKey(txtKey.Text)

        'Validate key - it must have a value and must be just letters
        If valid Then
            'If key is shorter than the length of the text repeat the key to make it the same size
            txtKey.Text = _Vigenere.setKey(txtPlainText.Text, txtKey.Text)
            txtCipherText.Text = _Vigenere.Encrypt(txtPlainText.Text, txtKey.Text)
        End If

    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        Dim valid As Boolean = _Vigenere.ValidateKey(txtKey.Text)

        'Validate key - it must have a value and must be just letters
        If valid Then
            'If key is shorter than the length of the text repeat the key to make it the same size
            txtKey.Text = _Vigenere.setKey(txtPlainText.Text, txtKey.Text)
            txtPlainText.Text = _Vigenere.Decrypt((txtCipherText.Text).ToUpper, txtKey.Text)
        End If

    End Sub

    Private Sub btnCryptanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCryptanalysis.Click
        frmVigenereCryptanalysis.Show()
        'opens the cryptanalysis form 
    End Sub

    Private Sub btnViewVisual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewVisual.Click
        frmVigenereVisual.Show()
        'opens the visual form
    End Sub

    Private Sub btnHideDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideDescription.Click

        Me.Size = New System.Drawing.Size(New System.Drawing.Point(418, 325))
        Me.btnShowDescription.Show()
        Me.btnHideDescription.Hide()
        'reverts the form back to original size to hide the description of how the form works
    End Sub

    Private Sub btnShowDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDescription.Click

        Me.Size = New System.Drawing.Size(New System.Drawing.Point(815, 395))
        Me.btnShowDescription.Hide()
        Me.btnHideDescription.Show()
        'extend the form to show the description of how the form works
    End Sub

End Class