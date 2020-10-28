Imports Cipher.Business

Public Class frmVernamEncryptDecrypt

    Private Property _Vernam As Vernam

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._Vernam = New Vernam
    End Sub

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        'One time pad must not be null and must be at least as long as the plain text
        If txtOneTimePad.Text = "" Then
            MsgBox("Invalid one time pad - It cannot be null", MsgBoxStyle.Exclamation, "Vernam Error")
        ElseIf Len(txtOneTimePad.Text) < Len(txtPlain.Text) Then
            MsgBox("Invalid one time pad - It must be at least as long as the input Text", MsgBoxStyle.Exclamation, "Vernam Error")
        Else
            txtCipher.Text = _Vernam.Encrypt(txtPlain.Text, txtOneTimePad.Text)
        End If

    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click

        'Replace with anything to get length
        Dim cipherTextLength As Integer = Len(txtCipher.Text.Replace("[Null]", "0"))

        'One time pad must not be null and must be at least as long as the plain text
        If txtOneTimePad.Text = "" Then
            MsgBox("Invalid one time pad - It cannot be null", MsgBoxStyle.Exclamation, "Vernam Error")
        ElseIf Len(txtOneTimePad.Text) < cipherTextLength Then
            MsgBox("Invalid one time pad - It must be at least as long as the cipher text", MsgBoxStyle.Exclamation, "Vernam Error")
        Else
            txtPlain.Text = _Vernam.Decrypt(txtCipher.Text, txtOneTimePad.Text)
        End If

    End Sub

    Private Sub btnRandomOTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandomOneTimePad.Click
        Dim OTP As String = ""
        Dim RandAsc As Integer = 0

        For i = 0 To Len(txtPlain.Text) - 1
            RandAsc = 128 * Rnd()
            'can use 128 but would be more than 8 bits
            OTP += Chr(RandAsc)
        Next
        txtOneTimePad.Text = OTP

    End Sub

    Private Sub btnHideDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(436, 367))
        Me.btnShowDescription.Show()
        Me.btnHideDescription.Hide()
        'reverts the form back to original size to hide the description of how the form works
    End Sub

    Private Sub btnShowDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(1017, 427))
        Me.btnShowDescription.Hide()
        Me.btnHideDescription.Show()
        'extend the form to show the description of how the form works
    End Sub

    Private Sub btnShowVisual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowVisual.Click
        frmVernamVisual.Show()
        'opens the visual form
    End Sub

    Private Sub BtnShowCryptanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowCryptanalysis.Click
        frmVernamCryptanalysis.Show()
        'opens the cryptanalysis form
    End Sub
End Class
