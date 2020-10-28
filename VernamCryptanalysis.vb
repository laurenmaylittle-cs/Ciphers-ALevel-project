Imports System.Text.RegularExpressions
Imports Cipher.Business
Imports System.Text

Public Class frmVernamCryptanalysis

    Private Property _Vigenere As Vigenere

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._Vigenere = New Vigenere
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim alphabet() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()
        Dim key As String
        Dim dictWords As New Dictionary(Of String, Integer)
        Dim decryptedWord As String
        Dim englishWordCount As Long = 0
        Dim WordCount As Long = 0
        Dim timeTaken As Long
        Dim watch As Stopwatch = Stopwatch.StartNew()
        txtListWords.Clear()

        'Load "dictionary" from file of English words
        dictWords = LoadDictionary("Resources - EnglishWords.txt")

        'Validate length of string
        If Len(txtWord.Text) <> 4 And Regex.IsMatch(Text, "[^A-Z]+") Then
            MsgBox("Please enter any 4 character string (letters A to Z only)", MsgBoxStyle.Exclamation, "Vernam Error")
        Else
            'Valid string entered, now run process (use Caesar Cipher for ease)
            '1) Process through all possible variations of key, e.g. AAAA, AAAB, AAAC, etc to ZZZZ
            '2) For each variation, check against the dictionary.
            '3) Display any words that match dictionary
            '4) Count variations, Count English Words & provide summary at the end

            For Each char1 In alphabet
                For Each char2 In alphabet
                    For Each char3 In alphabet
                        For Each char4 In alphabet
                            'Set key
                            key = char1 & char2 & char3 & char4
                            'Decrypt input word with current key
                            decryptedWord = _Vigenere.Decrypt((txtWord.Text), key)
                            'Check against dictionary, increment and display if in dictionary
                            If dictWords.ContainsKey(decryptedWord) Then
                                englishWordCount += 1
                                txtListWords.AppendText("Possible word: " + decryptedWord + _
                                                        "  Using key: " + key + Environment.NewLine)
                            End If
                            'Add 1 to attempts
                            WordCount += 1
                        Next
                    Next
                Next
            Next
            watch.Stop()
            timeTaken = watch.Elapsed.TotalMilliseconds
            'Display totals
            txtListWords.AppendText("Dictionary matches:" + CStr(englishWordCount) + Environment.NewLine)
            txtListWords.AppendText("Variations checked:" + CStr(WordCount) + Environment.NewLine)
            txtListWords.AppendText("Time taken        :" + CStr(timeTaken / 1000) + " seconds" + Environment.NewLine)
        End If


    End Sub

    Private Sub btnShowDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(1071, 561))
        Me.btnShowDescription.Hide()
        Me.btnHideDescription.Show()
        'extend the form to show the description of how the form works
    End Sub

    Private Sub btnHideDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(570, 561))
        Me.btnShowDescription.Show()
        Me.btnHideDescription.Hide()
        'reverts the form back to original size to hide the description of how the form works
    End Sub
End Class
