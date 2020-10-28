# Ciphers-ALevel-project
Imports System.Text.RegularExpressions

Public Class Vigenere
    Implements Cipher.Business.ICipherStrKey

    Private Property _Caesar As Caesar

    Sub New()
        _Caesar = New Caesar
    End Sub

    Function Encrypt(ByVal plainText As String, ByVal key As String) As String Implements ICipherStrKey.Encrypt
        Dim cipherTextNo As Integer = 0
        Dim plainTextNo As Integer = 0
        Dim keyNo As Integer = 0
        Dim cipherText As String = ""
        Dim Text As String = Regex.Replace(plainText, "[^A-Za-z]+", String.Empty).ToUpper

        For i = 0 To Len(Text) - 1
            'get ascii value of next plain text character & subtract 65
            plainTextNo = Asc(Text(i)) - 65
            'get ascii value of next key character & subtract 65 (use keyIndex as 
            keyNo = Asc(key(i)) - 65

            'Add the 2 numbers found above, then make sure it's within the range (mod 26)
            cipherTextNo = (plainTextNo + keyNo) Mod 26
            'Add 65 to get the value into the upper case letter range and convert to char 
            cipherText += Chr(65 + cipherTextNo)
        Next

        Return cipherText
    End Function

    Function Decrypt(ByVal cipherText As String, ByVal keyText As String) As String Implements ICipherStrKey.Decrypt
        Dim cipherTextNo As Integer = 0
        Dim keyNo As Integer = 0
        Dim plainTextNo As Integer = 0
        Dim plainText As String = ""
        Dim Text As String = Regex.Replace(cipherText, "[^A-Za-z]+", String.Empty).ToUpper

        For i = 0 To Len(Text) - 1
            'Only convert characters that are in the relevant range (upper case characters)
            'If Not Regex.IsMatch(Text(i), "[^A-Z]+") Then
            'get ascii value of next cipher text character & subtract 65
            cipherTextNo = (Asc(Text(i)) - 65)
            'get ascii value of next key character & subtract 65
            keyNo = Asc(keyText(i)) - 65

            'Subtract the 2 numbers found above, then make sure it's within the range (mod 26)
            plainTextNo = (cipherTextNo - keyNo) Mod 26
            If plainTextNo < 0 Then
                plainTextNo += 26
            End If
            'Add 65 to get the value into the upper case letter range and convert to char 
            plainText += Chr(65 + plainTextNo)
            'Else
            'plainText += Text(i)
            'End If
        Next

        Return plainText
    End Function

    Function SetKey(ByVal text As String, ByVal key As String) As String
        Dim keyText As String = key

        While Len(keyText) < Len(text)
            keyText += key
        End While

        Return keyText
    End Function

    Function GetIndexOfCoincidence(ByVal InputText As String) As Decimal
        Dim alphabetIndex As Integer
        Dim ICValue As Decimal
        Dim count(25) As Integer
        Dim sumLetterCalc As Integer = 0
        Dim lengthOfText As Integer = Len(InputText)

        'Get counts of letters in text
        Dim alphabetLetters() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()

        For Each character In InputText
            'Find array index of the letter
            alphabetIndex = Array.IndexOf(alphabetLetters, character)
            'Add 1 to count array for that index/letter
            count(alphabetIndex) += 1
        Next

        'Calculate Index of Coincidence (IC)
        For i = 0 To 25
            sumLetterCalc += (count(i) * (count(i) - 1))
        Next

        If lengthOfText = 1 Then
            ICValue = 0
        Else
            ICValue = sumLetterCalc / (lengthOfText * (lengthOfText - 1))
        End If

        Return ICValue
    End Function

    Function ArrangeCosets(ByVal inputText As String, ByVal rowCount As Integer) As Array
        Dim arrCosets(rowCount - 1) As String
        Dim row As Integer = 0

        For Each character In inputText
            arrCosets(row) += character
            row += 1
            If row > rowCount - 1 Then
                row = 0
            End If
        Next

        Return arrCosets
    End Function

    Function FindKeyLength(ByVal InputText As String) As Integer
        Dim keyLength As Integer = 0
        Dim arrAverageIC As Decimal = 0
        Dim arrCosets() As String
        Dim sumICValue As Decimal = 0
        Dim maxAverageIC As Decimal = Decimal.MinValue
        Dim cosetLimit As Integer = My.Settings.CosetLimit 'From project settings

        'Make sure that the string is longer than the cosetlimit, otherwise
        'set the limit to the same as the length of the text to avoid crash
        If cosetLimit > Len(Regex.Replace(InputText, "[^A-Z]+", String.Empty)) Then
            cosetLimit = Len(Regex.Replace(InputText, "[^A-Z]+", String.Empty))
        End If

        Dim arrICAverages(cosetLimit - 1) As Decimal

        ' 1) Start with 1 coset - Decide on a limit for the key (default to value in settings)
        ' 2) Get the index of co-incidence for just 1 line (value already calculated)
        ' 3) Store the average - For 1 coset, it will be the value obtained
        ' 4) Organise text into 2 cosets
        ' 5) Get index of coincidence for each coset
        ' 6) Get the average IC of the 2 cosets and store
        ' 7) Repeat up to cosets limit
        ' 8) The highest average is likely to be the key length

        For cosetCount = 1 To cosetLimit
            'Arrange text into cosets, according to the number that we're processing
            arrCosets = ArrangeCosets(InputText, cosetCount)

            'For each coset, work out the IC
            For i = 0 To cosetCount - 1
                'For this set of cosets, work out the average and store it
                sumICValue += GetIndexOfCoincidence(arrCosets(i))
            Next

            'Work out average & reset the sum for the next loop
            arrICAverages(cosetCount - 1) = sumICValue / (cosetCount)
            sumICValue = 0
        Next

        'The highest average value indicates the probable key length
        For i = 1 To cosetLimit
            If arrICAverages(i - 1) > maxAverageIC Then
                maxAverageIC = arrICAverages(i - 1)
                keyLength = i
            End If
        Next

        Return keyLength
    End Function

    Function FindKey(ByVal cipherText As String, ByVal keyLength As Integer) As String
        Dim shiftedText As String = ""
        Dim rows(keyLength - 1) As String
        Dim x2Index As Integer
        Dim letter(25) As Integer
        Dim count(25) As Integer
        Dim percArray(25) As Decimal
        Dim x2Value(25) As Decimal
        Dim alphabetIndex As Integer
        Dim letterCount As Integer
        Dim smallestX2Value As Decimal
        Dim key As String = ""
        Dim letterFrequencies() As Decimal
        Dim alphabetLetters() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()

        'Set up "cosets" for this key length
        rows = ArrangeCosets(cipherText, keyLength)

        letterFrequencies = Frequency.LoadFrequencies()

        'loop through cosets one at a time 
        ' For each coset......
        ' 1) Set first shift and get associated decrypted text
        ' 2) Set up an array of 26 letters
        ' 3) Get counts of each letter from decrypted text and place in array.
        ' 4) Calculate up percentage of each letter in array (no. of letters against each element / total letters in string) & store in array
        ' 5) Calculate the x2 value looping through the arrays (including the English frequency table)
        ' 6) Store x2 value in array of x2 values (26 elements, one for each letter shift)
        ' 7) Repeat above for next shift, until all 26 shifts done
        ' 8) Get lowest x2 value from array (either by using a bespoke search algorithm, or sort the array (if multi-dimensional array or linked list))
        ' 9) Store letter for the lowest x2 value in an array for the number of cosets (i.e. set element 1 for 1st coset, 2 for 2nd coset, etc)
        ' 10) Repeat above for each coset
        ' 11) Array of x2 values for each coset should then equal the key used

        'http://pages.mtu.edu/~shene/NSF-4/Tutorial/VIG/Vig-Recover.html
        'http://www.freevbcode.com/ShowCode.asp?ID=8745

        For coset = 0 To keyLength - 1
            letterCount = rows(coset).Length

            For shift = 0 To 25
                ' Get decrypted text for current shift
                shiftedText = _Caesar.Decrypt(rows(coset), shift)
                ' Clear count array
                For j = 0 To 25
                    count(j) = 0
                    percArray(j) = 0
                Next

                For Each character In shiftedText
                    'Find array index of the letter
                    alphabetIndex = Array.IndexOf(alphabetLetters, character)
                    'Add 1 to count array for that index/letter
                    count(alphabetIndex) += 1
                Next

                For j = 0 To 25
                    percArray(j) = Math.Round(count(j) / letterCount, 4)
                Next

                x2Value(shift) = 0
                For j = 0 To 25
                    'loop through all letters, creating the x2 value for the current shift
                    x2Value(shift) += ((percArray(j) - letterFrequencies(j)) ^ 2) / letterFrequencies(j)
                Next
            Next

            'Now get the lowest x2 value from the x2value array
            smallestX2Value = Integer.MaxValue
            For j = 0 To 25
                If x2Value(j) < smallestX2Value Then
                    smallestX2Value = x2Value(j)
                    x2Index = j
                End If
            Next

            key += alphabetLetters(x2Index)
        Next

        Return key
    End Function

    Function SetDisplayArray(ByVal plainText As String, ByVal key As String) As List(Of Intersection)
        Dim alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim intersections As New List(Of Intersection)
        Dim intersection As New Intersection
        Dim plainChar As String
        Dim keyChar As String

        For i = 0 To Len(plainText) - 1
            plainChar = plainText(i)
            keyChar = key(i)

            'Add to list of intersections
            intersections.Add(New Intersection() With {.Index = i, .ColPos = alphabet.IndexOf(plainChar.ToUpper), .RowPos = alphabet.IndexOf(keyChar.ToUpper)})
        Next

        Return intersections
    End Function

    Function ValidateKey(ByVal text As String) As Boolean
        Dim valid As Boolean = False

        'Validate key - it must have a value and must be just letters

        If text = "" Then
            MsgBox("Invalid key - It cannot be null", MsgBoxStyle.Exclamation, "Vigenere Error")
        ElseIf Regex.IsMatch(text, "[^A-Z]+") Then
            MsgBox("Invalid key - It must just be upper case letters", MsgBoxStyle.Exclamation, "Vigenere Error")
        Else
            valid = True
        End If

        Return valid
    End Function

End Class
