Imports Cipher.Business

Public Class frmCaesarVisual

    Private Property _Caesar As Caesar

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._Caesar = New Caesar
    End Sub

    Private Sub frmCaesarVisual_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmCaesarEncryptDecrypt.txtShift.Text <> "" Then
            Me.txtShift.Text = frmCaesarEncryptDecrypt.txtShift.Text
            ShiftVisual(Me.txtShift.Text)
        End If
        'transfers the shift from the encrypt & decrypt page and applies it in the visual page
    End Sub

    Private Sub btnShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShift.Click
        Dim outShift As Integer

        'Checking for errors using tryparse (tries converting to int and returns true if it can)
        If Integer.TryParse(txtShift.Text, outShift) Then
            If CInt(outShift) > 25 Or CInt(outShift) < 0 Then
                txtShift.Text = 0
                MsgBox("Shift must be a number between 0 and 25", MsgBoxStyle.Exclamation, "Caesar Shift Error")
            Else
                ShiftVisual(outShift)
            End If
        Else
            txtShift.Text = 0
            MsgBox("Shift must be numeric (and betwen 0 & 25)", MsgBoxStyle.Exclamation, "Caesar Shift Error")
        End If

    End Sub

    Private Sub btnRandomShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandomShift.Click
        Dim shift As Integer = 0

        shift = Rnd() * 25
        txtShift.Text = shift
        ShiftVisual(shift)

    End Sub

    Private Sub btnDecreaseShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecreaseShift.Click
        Dim outShift As Integer

        'Checking for errors using try catch for non numeric characters
        If Integer.TryParse(txtShift.Text, outShift) Then
            If outShift > 25 Or outShift < 0 Then
                txtShift.Text = 0
                MsgBox("Shift must be a number between 0 and 25", MsgBoxStyle.Exclamation, "Caesar Shift Error")
            Else
                If outShift = 0 Then
                    txtShift.Text = 25
                Else
                    txtShift.Text = txtShift.Text - 1
                End If
                ShiftVisual(txtShift.Text)
            End If
        Else
            txtShift.Text = 0
            MsgBox("Shift must be numeric (and between 0 & 25)", MsgBoxStyle.Exclamation, "Caesar Shift Error")
        End If

    End Sub

    Private Sub btnIncreaseShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncreaseShift.Click
        Dim outShift As Integer
        'Checking for errors using try catch for non numeric characters
        If Integer.TryParse(txtShift.Text, outShift) Then
            If outShift > 25 Or outShift < 0 Then
                txtShift.Text = 0
                MsgBox("Shift must be a number between 0 and 25", MsgBoxStyle.Exclamation, "Caesar Shift Error")
            Else
                If outShift = 25 Then
                    txtShift.Text = 0
                Else
                    txtShift.Text = txtShift.Text + 1
                End If
                ShiftVisual(txtShift.Text)
            End If
        Else
            txtShift.Text = 0
            MsgBox("Shift must be numeric (and between 0 & 25)", MsgBoxStyle.Exclamation, "Caesar Shift Error")
        End If
    End Sub

    Private Sub btnShowDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(906, 340))
        Me.btnHideDescription.Show()
        Me.btnShowDescription.Hide()
        'extend the form to show the description of how the form works
    End Sub

    Private Sub btnHideDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideDescription.Click
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(906, 182))
        Me.btnHideDescription.Hide()
        Me.btnShowDescription.Show()
        'reverts the form back to original size to hide the description of how the form works
    End Sub

    Sub ShiftVisual(ByVal shift As Integer)
        txtCipher1.Text = _Caesar.Encrypt("A", shift)
        txtCipher2.Text = _Caesar.Encrypt("B", shift)
        txtCipher3.Text = _Caesar.Encrypt("C", shift)
        txtCipher4.Text = _Caesar.Encrypt("D", shift)
        txtCipher5.Text = _Caesar.Encrypt("E", shift)
        txtCipher6.Text = _Caesar.Encrypt("F", shift)
        txtCipher7.Text = _Caesar.Encrypt("G", shift)
        txtCipher8.Text = _Caesar.Encrypt("H", shift)
        txtCipher9.Text = _Caesar.Encrypt("I", shift)
        txtCipher10.Text = _Caesar.Encrypt("J", shift)
        txtCipher11.Text = _Caesar.Encrypt("K", shift)
        txtCipher12.Text = _Caesar.Encrypt("L", shift)
        txtCipher13.Text = _Caesar.Encrypt("M", shift)
        txtCipher14.Text = _Caesar.Encrypt("N", shift)
        txtCipher15.Text = _Caesar.Encrypt("O", shift)
        txtCipher16.Text = _Caesar.Encrypt("P", shift)
        txtCipher17.Text = _Caesar.Encrypt("Q", shift)
        txtCipher18.Text = _Caesar.Encrypt("R", shift)
        txtCipher19.Text = _Caesar.Encrypt("S", shift)
        txtCipher20.Text = _Caesar.Encrypt("T", shift)
        txtCipher21.Text = _Caesar.Encrypt("U", shift)
        txtCipher22.Text = _Caesar.Encrypt("V", shift)
        txtCipher23.Text = _Caesar.Encrypt("W", shift)
        txtCipher24.Text = _Caesar.Encrypt("X", shift)
        txtCipher25.Text = _Caesar.Encrypt("Y", shift)
        txtCipher26.Text = _Caesar.Encrypt("Z", shift)
        'encrypts each letter box separately
    End Sub
End Class