Imports Cipher.Business
Imports System.Text.RegularExpressions
Imports System.Configuration

Public Class frmCaesarEncryptDecrypt
    Private Property _Caesar As Caesar

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me._Caesar = New Caesar
    End Sub

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        'Checking for errors using tryparse (tries converting to int and returns true if it can)
        Dim outShift As Integer

        If Integer.TryParse(txtShift.Text, outShift) Then
            If outShift > 25 Or outShift < 0 Then
                txtShift.Text = 0
                MsgBox("Shift must be a number between 0 and 25", MsgBoxStyle.Exclamation, "Caesar Shift Error")
            Else
                txtCipherText.Text = _Caesar.Encrypt(txtPlainText.Text.ToUpper, txtShift.Text)
            End If
        Else
            txtShift.Text = 0
            MsgBox("Shift must be numeric (and between 0 & 25)", MsgBoxStyle.Exclamation, "Caesar Shift Error")
        End If
    End Sub


    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        'Checking for errors using tryparse
        Dim outShift As Integer

        If Integer.TryParse(txtShift.Text, outShift) Then
            If outShift > 25 Or outShift < 0 Then
                txtShift.Text = 0
                MsgBox("Shift must be a number between 0 and 25", MsgBoxStyle.Exclamation, "Caesar Shift Error")
            Else
                txtPlainText.Text = _Caesar.Decrypt(txtCipherText.Text.ToUpper, txtShift.Text)
            End If
        Else
            txtShift.Text = 0
            MsgBox("Shift must be numeric (and between 0 & 25)", MsgBoxStyle.Exclamation, "Caesar Shift Error")
        End If
    End Sub

    Private Sub btnRandomShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandomShift.Click
        Dim shift As Integer = 0
        shift = Rnd() * 25
        txtShift.Text = shift
        'outputs a random number between 0 and 25 to the shift box
    End Sub

    Private Sub btnCaesarCryptanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaesarCryptanalysis.Click
        frmCaesarCryptanalysis.Show()
        'opens the caesar cryptanalysis form
    End Sub

    Private Sub btnCaesarVisual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaesarVisual.Click
        frmCaesarVisual.Show()
        'opens the caesar visual form
    End Sub

    Private Sub btnShowDescription_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(902, 444))
        Me.btnShowDescription.Hide()
        Me.btnHideDescription.Show()
        'extend the form to show the description of how the form works
    End Sub

    Private Sub btnHideDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(417, 365))
        Me.btnHideDescription.Hide()
        Me.btnShowDescription.Show()
        'reverts the form back to original size to hide the description of how the form works
    End Sub

End Class