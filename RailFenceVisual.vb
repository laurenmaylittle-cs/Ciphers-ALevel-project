Imports System.Text.RegularExpressions
Imports Cipher.Business

Public Class frmRailFenceVisual

    Private Property _RailFence As RailFence

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me._RailFence = New RailFence
    End Sub

    Private Sub frmRailFenceVisual_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmRailFenceEncryptDecrypt.txtRails.Text <> "" Then
            Dim plainText As String
            Me.txtRails.Text = frmRailFenceEncryptDecrypt.txtRails.Text
            Me.txtPlainText.Text = frmRailFenceEncryptDecrypt.txtPlainText.Text
            Dim Visual(Me.txtPlainText.Text.Length - 1, Me.txtRails.Text - 1)
            'Strip spaces out of plain text
            plainText = txtPlainText.Text.Replace(" ", "")
            'Set up "visual" character array
            Visual = _RailFence.PopulateVisualArray(Len(plainText), Me.txtRails.Text, plainText)
            'Encrypt array of elements
            Me.txtCipherText.Text = _RailFence.Encrypt(Len(plainText), Me.txtRails.Text, Visual)
            'Show RailFence
            rtxVisualRailFence.Text = _RailFence.ShowVisual(Len(plainText), txtRails.Text, Visual)
        End If
    End Sub

    Private Sub btnRails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRails.Click
        Dim valid As Boolean
        Dim plainText As String = txtPlainText.Text.Replace(" ", "")
        rtxVisualRailFence.Clear()
        txtCipherText.Clear()

        'Pass 0 to function to leave rails as they are
        valid = _RailFence.ValidateRails(txtRails.Text, plainText, 0)

        If valid Then
            'Set up array of elements
            Dim Visual(Text.Length - 1, txtRails.Text - 1)
            Visual = _RailFence.populateVisualArray(Len(plainText), txtRails.Text, plainText)
            'Encrypt array of elements
            txtCipherText.Text = _RailFence.Encrypt(Len(plainText), txtRails.Text, Visual)
            'Show RailFence
            rtxVisualRailFence.Text = _RailFence.ShowVisual(Len(plainText), txtRails.Text, Visual)
        End If
    End Sub

    Private Sub btnIncreaseRails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncreaseRails.Click
        Dim valid As Boolean
        Dim plainText As String = txtPlainText.Text.Replace(" ", "")
        rtxVisualRailFence.Clear()
        txtCipherText.Clear()

        'Pass 1 to function to check for increasing rail by 1
        valid = _RailFence.ValidateRails(txtRails.Text, txtPlainText.Text, 1)

        If valid Then
            'Increase rails by 1
            txtRails.Text += 1
            'Set up array of elements
            Dim Visual(Text.Length - 1, txtRails.Text - 1)
            Visual = _RailFence.populateVisualArray(Len(plainText), txtRails.Text, plainText)
            'Encrypt array of elements
            txtCipherText.Text = _RailFence.Encrypt(Len(plainText), txtRails.Text, Visual)
            'Show RailFence
            rtxVisualRailFence.Text = _RailFence.ShowVisual(Len(plainText), txtRails.Text, Visual)
        End If
    End Sub

    Private Sub btnDecreaseRails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecreaseRails.Click
        Dim valid As Boolean
        Dim plainText As String = txtPlainText.Text.Replace(" ", "")
        rtxVisualRailFence.Clear()
        txtCipherText.Clear()

        'Pass -1 to function to check for decreasing rail by 1
        valid = _RailFence.ValidateRails(txtRails.Text, txtPlainText.Text, -1)

        If valid Then
            'Decrease rails by 1
            txtRails.Text -= 1
            'Set up array of elements
            Dim Visual(Text.Length - 1, txtRails.Text - 1)
            Visual = _RailFence.populateVisualArray(Len(plainText), txtRails.Text, plainText)
            'Encrypt array of elements
            txtCipherText.Text = _RailFence.Encrypt(Len(plainText), txtRails.Text, Visual)
            'Show RailFence
            rtxVisualRailFence.Text = _RailFence.ShowVisual(Len(plainText), txtRails.Text, Visual)
        End If
    End Sub

    Private Sub btnRandRails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandRails.Click
        Dim valid As Boolean
        Dim plainText As String = txtPlainText.Text.Replace(" ", "")
        rtxVisualRailFence.Clear()
        txtCipherText.Clear()

        'Generate a random rail number
        txtRails.Text = Int(Rnd() * (Len(txtPlainText.Text.Replace(" ", "")) - 1)) + 1
        'Pass 0 to function to leave rails as they are (using random number)
        valid = _RailFence.ValidateRails(txtRails.Text, txtPlainText.Text, 0)

        If valid Then
            'Set up array of elements
            Dim Visual(Len(plainText) - 1, txtRails.Text - 1)
            Visual = _RailFence.populateVisualArray(Len(plainText), txtRails.Text, plainText)
            'Encrypt array of elements
            txtCipherText.Text = _RailFence.Encrypt(Len(plainText), txtRails.Text, Visual)
            'Show RailFence
            rtxVisualRailFence.Text = _RailFence.ShowVisual(Len(plainText), txtRails.Text, Visual)
        End If
    End Sub

    Private Sub btnStepByStep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStepByStep.Click
        Dim valid As Boolean
        Dim msgboxButtonPressed As Integer
        Dim plainText As String = txtPlainText.Text.Replace(" ", "")
        rtxVisualRailFence.Clear()
        txtCipherText.Clear()
        valid = _RailFence.ValidateRails(txtRails.Text, txtPlainText.Text, 0)

        If valid Then
            'Set up array of elements
            Dim Visual(Len(plainText) - 1, txtRails.Text - 1)
            Visual = _RailFence.populateVisualArray(Len(plainText), txtRails.Text, plainText)
            msgboxButtonPressed = MsgBox("Show plain text in railfence format", vbOKCancel, "Rail Fence")
            If msgboxButtonPressed = vbCancel Then
                Exit Sub
            End If

            'Show the "RailFence" text
            'Loop through visual array a character at a time
            rtxVisualRailFence.Text = _RailFence.ShowVisual(Len(plainText), txtRails.Text, Visual)
            msgboxButtonPressed = MsgBox("Rail Fence for " & txtRails.Text & " rails" & Chr(13) & _
                   Chr(13) & Chr(10) & "Now set up cipher text......", vbOKCancel, "Rail Fence")
            If msgboxButtonPressed = vbCancel Then
                Exit Sub
            End If

            'Loop through array (through each row), step by step
            For i As Integer = 0 To (txtRails.Text - 1)
                For j As Integer = 0 To (Len(plainText) - 1)
                    If Visual(j, i) <> " " Then
                        txtCipherText.Text &= Visual(j, i)
                        'Highlight character
                        rtxVisualRailFence.Select((Len(plainText) * i) + j + i, 1)
                        rtxVisualRailFence.SelectionColor = Color.Crimson

                        msgboxButtonPressed = MsgBox("Working along row " & i + 1 & Chr(13) & Chr(13) & Chr(10) & _
                                "Character " & Visual(j, i) & ", (Row " & i + 1 & ", Column " & j + 1 & _
                                ") added to cipher text", vbOKCancel, "Rail Fence")
                        'Reset to normal colour
                        rtxVisualRailFence.SelectionColor = Color.White

                        If msgboxButtonPressed = vbCancel Then
                            Exit Sub
                        End If
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub btnShowDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(721, 510))
        Me.btnHideDescription.Show()
        Me.btnShowDescription.Hide()
        'extend the form to show the description of how the form works
    End Sub

    Private Sub btnHideDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(721, 315))
        Me.btnHideDescription.Hide()
        Me.btnShowDescription.Show()
        'reverts the form back to original size to hide the description of how the form works
    End Sub
End Class