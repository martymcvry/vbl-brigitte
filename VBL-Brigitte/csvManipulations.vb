Module csvManipulations

    Public Function transformLine(ByRef text As String) As String
        Dim record() As String = text.Split(";")

        ' 0: VBL-nummer
        ' 1: Volledige naam
        ' 2: (leeg)
        ' 3: Clubnummer
        ' 4: Clubnaam
        ' 5: Achternaam
        ' 6: Voornaam
        ' 7: Lidcode
        ' 8: Masterpoints

        Dim tmpNaam As String
        tmpNaam = record(5).ToUpper & " " & record(6).PadRight(21)
        text = record(0).PadLeft(6) & " " & tmpNaam.Substring(0, 21)

        Return text

    End Function

End Module
