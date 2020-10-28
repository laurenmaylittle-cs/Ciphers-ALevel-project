# Ciphers-ALevel-project
Public Class RailFence
    Implements Cipher.Business.ICipherRailsKey

    Function ValidateRails(ByVal numberOfRails As String, ByVal plainText As String, ByVal changeRails As Integer) As Boolean
        Dim valid As Boolean = False
        Dim noOfRails As Integer

        'Check if rails field is set to a numeric value
        If Integer.TryParse(numberOfRails, noOfRails) Then

            'Increase or decrease rails  
            noOfRails = noOfRails + changeRails

            ' Make sure that the no of rails is less than the characters in the string (remove blanks)
            If noOfRails >= Len(plainText) And Not plainText = "" Then
                MsgBox("The number of rails should be smaller than the number of characters in the plain text", MsgBoxStyle.Exclamation, "Rail Fence Error")
            ElseIf noOfRails <= 0 Then
                MsgBox("The number of rails should be greater than zero", MsgBoxStyle.Exclamation, "Rail Fence Error")
            Else
                valid = True
            End If
        Else
            MsgBox("The number of rails should be a number!", MsgBoxStyle.Exclamation, "Rail Fence Error")
        End If

        Return valid
    End Function

    Function PopulateVisualArray(ByVal textLength As Integer, ByVal rails As Integer, ByVal text As String)
        Dim visual(textLength - 1, rails - 1)
        Dim pos As Integer = 0 'Position
        Dim posDirUp As Boolean 'PositionDirectionUp

        'Clear array
        visual = InitialiseArray(textLength, rails)

        'Populate relevant array elements with characters
        For i As Integer = 0 To text.Length - 1
            visual(i, pos) = text.Substring(i, 1)

            'Set rail number
            If Not posDirUp Then
                pos += 1
            Else
                pos -= 1
            End If

            If pos > (rails - 1) Then
                pos = (rails - 1)
            End If

            'Set direction
            If pos = 0 Then
                posDirUp = False
            ElseIf pos = rails - 1 Then
                posDirUp = True
            End If
        Next

        Return visual
    End Function

    Function ShowVisual(ByVal lengthPlainText As Integer, ByVal noOfRails As Integer, ByVal visual As Array) As String
        Dim displayText As String = ""

        'Show the "RailFence" text
        'Loop through visual array a character at a time
        For j As Integer = 0 To (noOfRails - 1)
            For i As Integer = 0 To (lengthPlainText - 1)
                displayText &= visual(i, j)
            Next
            displayText &= Environment.NewLine
        Next

        Return displayText
    End Function

    Public Function PopulateRailsArray(ByVal textLength As Integer, ByVal rails As Integer, ByVal text As String)
        Dim railsArray(textLength - 1, rails - 1)
        Dim rail As Integer
        Dim direction As Boolean
        Dim charIndex As Integer = 0

        'Clear array
        railsArray = InitialiseArray(textLength, rails)

        'Populate the RailFence array using the ciphertext
        'Do this by following a similar process to the encrypt to work out where to put the characters
        'Loop through the rails
        For railIndex As Integer = 0 To rails - 1
            rail = 0
            direction = False

            'Loop through each element to end of the rails
            For textIndex As Integer = 0 To (textLength - 1)

                'If the rail that we're on matches the rail that we're looping through, then save the letter
                If railIndex = rail Then
                    railsArray(textIndex, railIndex) = text.Substring(charIndex, 1)
                    charIndex += 1
                End If

                'Change rail according to the direction we're going
                If direction Then
                    rail -= 1
                Else
                    rail += 1
                End If

                'Set the direction
                If rail = (rails - 1) Then    'We've reached the bottom rail and need to start back up
                    direction = True
                ElseIf rail = 0 Then          'We've reached the top rail and need to start back down
                    direction = False
                End If
            Next
        Next

        Return railsArray
    End Function

    Function Encrypt(ByVal length As String, ByVal rails As Integer, ByVal railsArray As Array) As String Implements ICipherRailsKey.Encrypt
        Dim converted As String = ""

        'Loop through the rails one at a time to get the encrypted text
        For i As Integer = 0 To (rails - 1)
            For j As Integer = 0 To (length - 1)
                If railsArray(j, i) <> " " Then
                    converted = converted + railsArray(j, i)
                End If
            Next
        Next

        Return converted
    End Function

    Function Decrypt(ByVal length As String, ByVal rails As Integer, ByVal railsArray As Array) As String Implements ICipherRailsKey.Decrypt
        Dim converted As String = ""

        'Read through array from left to right to get original text
        For textIndex As Integer = 0 To (length - 1)
            For railIndex As Integer = 0 To rails - 1
                If railsArray(textIndex, railIndex) <> " " Then
                    converted += railsArray(textIndex, railIndex)
                End If
            Next
        Next

        Return converted
    End Function

    Function InitialiseArray(ByVal textLength As Integer, ByVal rails As Integer) As Array
        Dim visual(textLength - 1, rails - 1)

        'Clear array
        For x As Integer = 0 To textLength - 1
            For y As Integer = 0 To (rails - 1)
                visual(x, y) = " "
            Next
        Next

        Return visual
    End Function

End Class
