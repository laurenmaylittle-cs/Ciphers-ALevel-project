Imports System.Text.RegularExpressions
Imports System.Configuration
Imports Cipher.Business

Public Class frmVigenereVisual

    Private Property _Vigenere As Vigenere

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me._Vigenere = New Vigenere
    End Sub

    Private Sub frmVigenereVisual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtPlainText.Text = frmVigenereEncryptDecrypt.txtPlainText.Text
        Me.txtKey.Text = frmVigenereEncryptDecrypt.txtKey.Text
        'Create the alphabet Vigenere table, as a single string of characters to be displayed in a rich text box
        'Show capital letters (ascii range 65 to 90).
        'Each line starts with the next character and "loops" round to A again after Z.
        'This is achieved by using MOD 26
        'Loop through the rows

        For j = 0 To 25
            'Add each character to the string
            'Add space after every character to make the table look better
            For i = 0 To 25
                rtxVisual.Text = rtxVisual.Text + Chr((j + i) Mod 26 + 65) + " "
            Next
            rtxVisual.Text += Environment.NewLine
        Next
    End Sub

    Private Sub btnDemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDemo.Click
        Dim Intersections As New List(Of Intersection)()
        Dim msg As String
        Dim dayChar As String
        Dim msgboxButtonPressed As Integer
        Dim key As String = ""
        Dim text As String = Regex.Replace(txtPlainText.Text, "[^A-Za-z]+", String.Empty).ToUpper
        txtCipherText.Clear()
        txtKey.Text = Regex.Replace(txtKey.Text, "[^A-Za-z]+", String.Empty).ToUpper

        'Validate key - it must have a value and must be just letters
        Dim valid As Boolean = _Vigenere.ValidateKey(txtKey.Text)
        If text = "" Or text = " " Then
            MsgBox("The plain text should be upper case letters only", MsgBoxStyle.Exclamation, "Vigenere Error")
        End If
        If valid Then
            'If key is shorter than the length of the text repeat the key to make it the same size
            txtKey.Text = _Vigenere.SetKey(text, txtKey.Text)

            'Get list of all of the cipher characters as "intersections", even though the display is actually one long string
            Intersections = _Vigenere.SetDisplayArray(text, txtKey.Text)

            For Each Intersection In Intersections
                'Set up the st, nd, th for the number of the element
                dayChar = SetEndings(Intersection.Index)

                'Encrypt the character and add to the cipher text
                txtCipherText.Text += _Vigenere.Encrypt(CStr(text(Intersection.Index)).ToUpper, CStr(txtKey.Text(Intersection.Index)).ToUpper)

                'Set the applicable row/column to different colour (to highlight required character)
                SetDisplayAttributes(Intersection.Index, Intersection.ColPos, Intersection.RowPos, False)

                'Set message for msgbox
                msg = CStr(Intersection.Index + 1) + dayChar + " character" + Chr(10) + Chr(10) + Chr(13) + _
                        "Plain Text = " + text(Intersection.Index) + Chr(10) + Chr(13) + _
                        "Key = " + txtKey.Text(Intersection.Index) + Chr(10) + Chr(13) + _
                        "Cipher Text = " + txtCipherText.Text(Intersection.Index) + Chr(10) + Chr(10) + Chr(13) + _
                        "Move to next character?"

                msgboxButtonPressed = MsgBox(msg, vbOKCancel, "Vigenere Encryption Demonstration")

                'Set the characters back to default colour
                SetDisplayAttributes(Intersection.Index, Intersection.ColPos, Intersection.RowPos, True)

                'Cancel pressed?
                If msgboxButtonPressed = vbCancel Then
                    Exit For
                End If
            Next

            For i = 0 To txtPlainText.Text.Length - 1
                If txtKey.Text.Length > txtPlainText.Text.Length - 1 Then
                    key &= txtKey.Text.Substring(i, 1)
                ElseIf txtKey.Text.Length < txtPlainText.Text.Length - 1 Then
                    While Len(txtKey.Text) < Len(txtPlainText.Text)
                        txtKey.Text &= txtKey.Text
                        key += txtKey.Text.Substring(i, 1)
                    End While
                End If
            Next

            txtDemo.Text = "Plain Text  : " & text.ToUpper & Environment.NewLine & _
                           "Key         : " & key & Environment.NewLine & _
                           "Cipher Text : " & txtCipherText.Text
        End If
    End Sub

    Sub SetDisplayAttributes(ByVal index As Integer, ByVal colPos As Integer, ByVal rowPos As Integer, ByVal clearValues As Boolean)
        Dim colour As Color
        Dim backColour As Color

        'Set relevant colours for highlighting the rows / columns
        'And to reset the values back to default colours depending on parameter passed to routine
        If clearValues = True Then
            colour = Color.White
            backColour = Color.Black
        Else
            colour = Color.Blue
            backColour = Color.LightBlue
        End If

        For i = 0 To rowPos
            If i = rowPos Then
                'Highlight the whole row up to the relevant character (at colPos)
                'Starting position is the number of rows (prior to current row) multiplied by the number of characters in each line,
                ' Plus the position of the character on the current line.
                'The numbers take into account the number of characters in the alphabet (26), the number of spaces (26).
                rtxVisual.Select(i * 53, (colPos * 2) + 1)
                rtxVisual.SelectionColor = colour

                'Set the background colour of the character at the intersection
                rtxVisual.Select(((i * 53) + (colPos * 2)), 1)
                rtxVisual.SelectionBackColor = backColour
            Else
                'Highlight the character in the current "row" in the applicable column (colPos)
                rtxVisual.Select((i * 53) + (colPos * 2), 1)
                rtxVisual.SelectionColor = colour
            End If
        Next

    End Sub

    Private Sub btnHideDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(826, 523))
        Me.btnShowDescription.Show()
        Me.btnHideDescription.Hide()
        'reverts the form back to original size to hide the description of how the form works
    End Sub

    Private Sub btnShowDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(1081, 523))
        Me.btnShowDescription.Hide()
        Me.btnHideDescription.Show()
        'extend the form to show the description of how the form works
    End Sub
End Class

