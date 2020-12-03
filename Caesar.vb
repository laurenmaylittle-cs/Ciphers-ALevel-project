Public Class Caesar
    Implements Cipher.Business.ICipherIntKey

    Function Encrypt(ByVal text As String, ByVal shift As Integer) As String Implements ICipherIntKey.Encrypt
        Dim cipher As Integer
        Dim cipherText As String = ""

        For i = 0 To Len(text) - 1
            If Asc(text.Substring(i, 1)) > 64 And Asc(text.Substring(i, 1)) < 91 Then
                cipher = ((Asc(text.Substring(i, 1)) - 65 + shift) Mod 26) + 65
                cipherText = cipherText + Chr(cipher)
            ElseIf Asc(text.Substring(i, 1)) < 64 Or Asc(text.Substring(i, 1)) > 91 Then
                cipherText = cipherText + text.Substring(i, 1)
            End If
        Next

        Return ciphertext
    End Function

    Function Decrypt(ByVal text As String, ByVal shift As Integer) As String Implements ICipherIntKey.Decrypt
        Dim ascii As Integer
        Dim plainText As String = ""

        For i = 0 To Len(text) - 1
            If Asc(text.Substring(i, 1)) > 64 And Asc(text.Substring(i, 1)) < 91 Then
                ascii = Asc(text.Substring(i, 1))
                plainText = plainText + Chr(((ascii - shift) + 65) Mod 26 + 65)
            ElseIf Asc(text.Substring(i, 1)) < 64 Or Asc(text.Substring(i, 1)) > 91 Then
                plainText = plainText + text.Substring(i, 1)
            End If
        Next

        Return plainText
    End Function

    Function BruteForceText(ByVal text As String, ByVal shift As Integer) As String
        Dim plainText As String = ""

        plainText = plainText + String.Format("shift: {0}    plaintext: {1}", shift, Decrypt(text, shift)) + vbCrLf
        'displays every possible plaintext and shift 
        Return (plainText)
    End Function

End Class
