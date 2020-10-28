# Ciphers-ALevel-project
Imports System.Text.RegularExpressions
Imports System.IO

Public Module Utilities

    Function TextToBinary(ByVal num As Integer) As String
        Dim bin As String = ""
        Dim output As String = ""


        For i = 1 To 8
            If num Mod 2 = 0 Then
                bin = 0
            Else
                bin = 1
            End If
            num = num \ 2 'result rounded down
            output = Convert.ToString(bin) & output
        Next

        Return output
    End Function

    Function LoadDictionary(ByVal ResourceFile As String) As Dictionary(Of String, Integer)
        Dim dictWords As New Dictionary(Of String, Integer)
        Dim words() As String

        If ResourceFile = "Resources - EnglishWords.txt" Then
            words = My.Resources.EnglishWords.Replace(Chr(13), "").Split(Chr(10))
        Else
            words = IO.File.ReadAllLines(ResourceFile)
        End If

        For k = 0 To words.Length - 1
            words(k) = Regex.Replace(words(k), "[^A-Za-z]+", String.Empty).ToUpper
        Next

        For i = 0 To words.Length - 1
            ' Check if word already exists, as duplicate key will cause error
            If dictWords.ContainsKey(Trim(words(i))) = False Then
                dictWords.Add(Trim(words(i)), i)
            End If
        Next

        Return dictWords
    End Function

    Function SetEndings(ByVal textIndex) As String
        Dim endChar As String

        Select Case textIndex Mod 10
            Case 0
                endChar = "st"
            Case 1
                endChar = "nd"
            Case 2
                endChar = "rd"
            Case Else
                endChar = "th"
        End Select

        Return endChar
    End Function

    Function LoadFile(ByVal ResourceFile As String) As String
        Dim text As String

        text = IO.File.ReadAllText(ResourceFile)

        Return text
    End Function

End Module
