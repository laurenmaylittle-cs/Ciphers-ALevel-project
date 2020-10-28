# Ciphers-ALevel-project
Public Module Frequency

    Public Function LoadFrequencies() As Decimal()

        Dim letterFrequencies(26) As Decimal
        Dim frequencies As String = My.Settings.frequencies
        Dim Frequency() As String = frequencies.Split(","c)

        For index = 0 To 25
            letterFrequencies(index) = Decimal.Parse(Frequency(index))
        Next

        Return letterFrequencies
    End Function

End Module
