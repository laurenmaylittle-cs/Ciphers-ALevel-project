Imports Cipher.Business

Public Class frmVernamVisual

    Private Property _Vernam As Vernam

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._Vernam = New Vernam
    End Sub

    Private Sub frmVernamVisual_Load(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Load

        Me.txtPlainText.Text = frmVernamEncryptDecrypt.txtPlain.Text
        Me.txtOneTimePad.Text = frmVernamEncryptDecrypt.txtOneTimePad.Text

    End Sub

    Private Sub btnEncryptDemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncryptDemo.Click

        txtBinaryXorDemo.Clear()

        'Validate One Time Pad
        If txtOneTimePad.Text = "" Then
            MsgBox("Invalid one time pad - It cannot be null", MsgBoxStyle.Exclamation, "Vernam Error")
        ElseIf Len(txtOneTimePad.Text) < Len(txtPlainText.Text) Then
            MsgBox("Invalid one time pad - It must be at least as long as the input Text", MsgBoxStyle.Exclamation, "Vernam Error")
        Else
            'Valid - so show cipher text & demo box
            txtCipherText.Text = _Vernam.Encrypt(txtPlainText.Text, txtOneTimePad.Text)
            txtBinaryXorDemo.Text = _Vernam.VernamDisplayDetails(txtPlainText.Text, txtOneTimePad.Text)
        End If
    End Sub


    Private Sub btnViewXORTruthTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewXORTruthTable.Click
        txtXORTruthTable.Size = New System.Drawing.Size(New System.Drawing.Point(162, 150))

        txtXORTruthTable.Text = "  ------------------------------------------------" & Environment.NewLine & _
                                "  |  Input A  |  Input B  |  Output  |" & Environment.NewLine & _
                                "  ------------------------------------------------" & Environment.NewLine & _
                                "  |      0       |      0       |       0      |" & Environment.NewLine & _
                                "  ------------------------------------------------" & Environment.NewLine & _
                                "  |      0       |      1       |       1      |" & Environment.NewLine & _
                                "  ------------------------------------------------" & Environment.NewLine & _
                                "  |      1       |      0       |       1      |" & Environment.NewLine & _
                                "  ------------------------------------------------" & Environment.NewLine & _
                                "  |      1       |      1       |       0      |" & Environment.NewLine & _
                                "  ------------------------------------------------"
    End Sub

    Private Sub btnIndividualChars_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIndividualChars.Click
        Dim cipherText As String
        Dim cipherTextBin As String
        Dim plainTextBin As String
        Dim KeyBin As String
        txtCipherText.Clear()
        If txtOneTimePad.Text = "" Then
            MsgBox("Invalid one time pad - It cannot be null", MsgBoxStyle.Exclamation, "Vernam Error")
        ElseIf Len(txtOneTimePad.Text) < Len(txtPlainText.Text) Then
            MsgBox("Invalid one time pad - It must be at least as long as the input Text", MsgBoxStyle.Exclamation, "Vernam Error")
        ElseIf Not txtPlainText.Text = "" Then
            'Valid one time pad - so proceed
            txtCipherText.Text = _Vernam.Decrypt(txtPlainText.Text, txtOneTimePad.Text)
            cipherText = _Vernam.encryptDecryptVernamChar(txtPlainText.Text(0), txtOneTimePad.Text(0))

            txtIndividualChars.Text = "plaintext: " & txtPlainText.Text(0) & "     Key: " & txtOneTimePad.Text(0) & "     ciphertext: " & cipherText

            cipherTextBin = TextToBinary(Asc(cipherText))
            plainTextBin = TextToBinary(Asc(txtPlainText.Text(0)))
            KeyBin = TextToBinary(Asc(txtOneTimePad.Text(0)))

            For i = 0 To 7
                txtIndividualChars.Text &= Environment.NewLine & _
                    "     " & plainTextBin(i) & "              " & KeyBin(i) & "            " & cipherTextBin(i)
            Next
        End If

    End Sub

    Private Sub btnShowDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(1050, 463))
        Me.btnHideDescription.Show()
        Me.btnShowDescription.Hide()
        'extend the form to show the description of how the form works
    End Sub

    Private Sub btnHideDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(707, 463))
        Me.btnHideDescription.Hide()
        Me.btnShowDescription.Show()
        'reverts the form back to original size to hide the description of how the form works
    End Sub
End Class