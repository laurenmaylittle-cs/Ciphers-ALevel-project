Imports System.Text.RegularExpressions
Imports System.Configuration
Imports Cipher.Business

Public Class frmVigenereCryptanalysis

    Private Property _Vigenere As Vigenere

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me._Vigenere = New Vigenere
    End Sub

    Private Sub frmVigenereCryptanalysis_Load(ByVal sender As Object, _
     ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCipherText.Text = frmVigenereEncryptDecrypt.txtCipherText.Text
    End Sub

    Private Sub btnFreidman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreidman.Click
        Dim keyLength As Integer
        Dim key As String
        Dim cipherText As String = Regex.Replace(txtCipherText.Text, "[^A-Za-z]+", String.Empty).ToUpper

        'Work out key length
        keyLength = _Vigenere.FindKeyLength(cipherText)
        txtKeyLength.Text = keyLength

        'Work out key and show it
        txtKey.Text = _Vigenere.FindKey(cipherText, keyLength)

        ' set the repeated / full key
        key = _Vigenere.SetKey(cipherText, txtKey.Text)

        'Set the plain text, now that we have the "probable" key
        txtPlainText.Text = _Vigenere.Decrypt(cipherText, key)

    End Sub

    Private Sub btnShowDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(862, 791))
        Me.btnHideDescription.Show()
        Me.btnShowDescription.Hide()
        'extend the form to show the description of how the form works
    End Sub

    Private Sub btnHideDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(413, 791))
        Me.btnHideDescription.Hide()
        Me.btnShowDescription.Show()
        'reverts the form back to original size to hide the description of how the form works
    End Sub
End Class