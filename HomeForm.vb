Imports Cipher.Business.Utilities

Public Class HomeForm

    Private Sub HomeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtInfo.Text = LoadFile("Home.txt")
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtInfo.Text = LoadFile("Home.txt")
        'resets the page to show the cryptography description 
    End Sub

    Private Sub mnuCaesarDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCaesarDescription.Click
        txtInfo.Text = LoadFile("Caesar.txt")
        'shows the general caesar cipher description
    End Sub

    Private Sub mnuCaesarEncryptDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCaesarEncryptDecrypt.Click
        frmCaesarEncryptDecrypt.Show()
        'opens the caesar encrypt & decrypt form
    End Sub

    Private Sub mnuCaesarCryptanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCaesarCryptanalysis.Click
        frmCaesarCryptanalysis.Show()
        'opens the caesar cryptanalysis form
    End Sub

    Private Sub mnuCaesarVisual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCaesarVisual.Click
        frmCaesarVisual.Show()
        'opens the caesar visual form
    End Sub

    Private Sub mnuVigenereDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVigenereDescription.Click
        txtInfo.Text = LoadFile("Vigenere.txt")
        'shows the general vigenere cipher description
    End Sub

    Private Sub mnuVigenereEncryptDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVigenereEncryptDecrypt.Click
        frmVigenereEncryptDecrypt.Show()
        'opens the vigenere encrypt & decrypt form
    End Sub

    Private Sub mnuVigenereCryptanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVigenereCryptanalysis.Click
        frmVigenereCryptanalysis.Show()
        'opens the vigenere cryptanalysis form
    End Sub

    Private Sub mnuVigenereVisual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVigenereVisual.Click
        frmVigenereVisual.Show()
        'opens the vigenere visual form
    End Sub

    Private Sub mnuRailFenceDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRailFenceDescription.Click
        txtInfo.Text = LoadFile("RailFence.txt")
        'shows the general rail fence cipher description
    End Sub

    Private Sub mnuRailFenceEncryptDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRailFenceEncryptDecrypt.Click
        frmRailFenceEncryptDecrypt.Show()
        'opens the rail fence encrypt & decrypt form
    End Sub

    Private Sub mnuRailFenceCryptanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRailFenceCryptanalysis.Click
        frmRailFenceCryptanalysis.Show()
        'opens the rail fence cryptanalysis form
    End Sub

    Private Sub mnuRailFenceVisual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRailFenceVisual.Click
        frmRailFenceVisual.Show()
        'opens the rail fence visual form
    End Sub

    Private Sub mnuVernamDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVernamDescription.Click
        txtInfo.Text = LoadFile("Vernam.txt")
        'shows the general vernam cipher description
    End Sub

    Private Sub mnuVernamEncryptDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVernamEncryptDecrypt.Click
        frmVernamEncryptDecrypt.Show()
        'opens the vernam encrypt & decrypt form
    End Sub

    Private Sub mnuVernamCryptanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVernamCryptanalysis.Click
        frmVernamCryptanalysis.Show()
        'opens the vernam cryptanalysis form
    End Sub

    Private Sub mnuVernamVisual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVernamVisual.Click
        frmVernamVisual.Show()
        'opens the vernam visual form
    End Sub

End Class
