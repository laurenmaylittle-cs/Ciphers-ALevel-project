Imports System.Configuration
Imports Cipher.Business
Imports System.Text.RegularExpressions

Public Class frmCaesarCryptanalysis

    Private Property _Caesar As Caesar

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._Caesar = New Caesar
    End Sub

    Private Sub frmCaesarCryptanalysis_Load(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCipherText.Text = frmCaesarEncryptDecrypt.txtCipherText.Text
    End Sub

    Private Sub btnBruteForceAttack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBruteForceAttack.Click
        Dim dictionaryWordCount As Integer
        Dim highestWordCountShift As Integer = 0
        Dim highestWordCount As Integer = 0
        Dim eachWord() As String
        Dim dictWords As New Dictionary(Of String, Integer)

        txtBruteForce.Clear()

        'Use dictionary to get actual shift value
        'Select decryption with highest number of dictionary word matches
        If chkDictionary.Checked = True Then

            'Load "dictionary" from file of English words
            dictWords = LoadDictionary(txtFileName.Text)

            'Loop through each possible shift
            For i = 0 To 25
                'Get decrypted text for this shift and split into words

                eachWord = (_Caesar.Decrypt(txtCipherText.Text, i)).Split(" ")

                'Check each word against the dictionary - count matches
                dictionaryWordCount = 0
                For j = 0 To (eachWord.Length) - 1
                    eachWord(j) = Regex.Replace(eachWord(j), "[^A-Za-z]+", String.Empty).ToUpper
                    If dictWords.ContainsKey(eachWord(j)) Then
                        dictionaryWordCount += 1
                    End If
                Next

                'Store value of highest number of matched words and associated shift value
                If dictionaryWordCount > highestWordCount Then
                    highestWordCount = dictionaryWordCount
                    highestWordCountShift = i
                End If
            Next

            'Display the most likely decrypted text and associated shift value
            txtBruteForce.Text = txtBruteForce.Text & _
               "Likely Plain text: " & _Caesar.Decrypt(txtCipherText.Text, highestWordCountShift) & vbCrLf & _
               "Shift: " & highestWordCountShift & vbCrLf & _
               "Number of matched words: " & highestWordCount
        Else
            'List out all (26) possibles - user can then see which one is applicable
            For i = 0 To 25
                txtBruteForce.Text = txtBruteForce.Text & _Caesar.BruteForceText(txtCipherText.Text.ToUpper, i)
            Next
        End If

    End Sub

    Private Sub btnSelectDictionaryFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectDictionaryFile.Click
        dlgSelectDictionaryFile.Title = "Please select a valid Dictionary file"
        dlgSelectDictionaryFile.InitialDirectory = "C:\"
        dlgSelectDictionaryFile.Filter = "txt files|*.txt"
        dlgSelectDictionaryFile.FileName = ""

        If dlgSelectDictionaryFile.ShowDialog() = DialogResult.OK Then
            If dlgSelectDictionaryFile.FileName <> "" Then
                txtFileName.Text = dlgSelectDictionaryFile.FileName
            End If
        End If
        'allows the user to change dictionary file and validates it to check that it isn't empty
    End Sub

    Private Sub btnShowDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(731, 676))
        Me.btnHideDescription.Show()
        Me.btnShowDescription.Hide()
        'extend the form to show the description of how the form works
    End Sub

    Private Sub btnHideDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(418, 676))
        Me.btnShowDescription.Show()
        Me.btnHideDescription.Hide()
        'reverts the form back to original size to hide the description of how the form works
    End Sub

End Class





