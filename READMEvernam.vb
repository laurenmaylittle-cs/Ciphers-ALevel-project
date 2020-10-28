# Ciphers-ALevel-project
Public Class Vernam
    Implements Cipher.Business.ICipherStrKey

    Function Encrypt(ByVal plainText As String, ByVal KeyText As String) As String Implements ICipherStrKey.Encrypt
        Dim cipherText As Char() = ""
        Dim cipherChar As Char

        For i = 0 To plainText.Length - 1
            cipherChar = encryptDecryptVernamChar(plainText(i), KeyText(i))
            'Ascii code 0 is a "Null" and this "ends" the string.
            'Replace it with text of "[Null]", just so we can see the full cipher text
            If Asc(cipherChar) = 0 Then
                cipherText += "[Null]"
            Else
                cipherText += cipherChar
            End If
        Next

        Return cipherText
    End Function

    Function Decrypt(ByVal cipherText As String, ByVal keyText As String) As String Implements ICipherStrKey.Decrypt
        Dim plainText As Char() = ""
        Dim cipherTextLength As Integer
        Dim trueCipherText As String

        'If we've had to deal with a "Null", we need to deal with it here
        'Get the proper string length by replacing [Null] with any character
        cipherTextLength = Len(cipherText.Replace("[Null]", "0"))

        'Get the proper cipher text by reverting to the Null character
        trueCipherText = cipherText.Replace("[Null]", Chr(0))

        For i = 0 To cipherTextLength - 1
            plainText += EncryptDecryptVernamChar(trueCipherText(i), keyText(i))
        Next

        Return plainText
    End Function

    Function EncryptDecryptVernamChar(ByRef inputTextChar As Char, ByVal keyChar As Char) As String
        Dim outputTextChar As Char

        outputTextChar = Chr(Asc(inputTextChar) Xor Asc(keyChar))

        Return outputTextChar
    End Function

    Function VernamDisplayDetails(ByVal plainText As String, ByVal oneTimePad As String) As String
        Dim i As Integer = 0
        Dim outputChar As Char
        Dim demoText As String = ""

        For Each item As Char In plainText

            'Input text
            demoText += TextToBinary(Asc(item)) + " " + item

            'One time pad
            demoText += "    " + TextToBinary(Asc(oneTimePad(i))) + "  "
            demoText += oneTimePad(i)

            'Output text
            outputChar = EncryptDecryptVernamChar(item, oneTimePad(i))
            demoText += "    " + TextToBinary(Asc(outputChar)) + "  "

            'demoText += outputChar
            If Asc(outputChar) = 0 Then
                demoText += "[Null]"
            Else
                demoText += outputChar
            End If

            'Next item
            demoText &= Environment.NewLine

            If i < Len(plainText) Then
                i += 1
            End If
        Next

        Return demoText
    End Function

End Class
