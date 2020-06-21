Public Class frmMain

    ' Maak een alias voor gebruik in subroutines
    Private Sub OpenFileDialog()
        ofdMembersFile.ShowDialog()
    End Sub

    ' Knop bladeren
    Private Sub cmdFile_Click(sender As System.Object, e As System.EventArgs) Handles cmdFile.Click
        ' Dialoogvenster openen
        OpenFileDialog()
    End Sub

    ' Op tekstvak CSV-bestand klikken
    Private Sub txtFilename_Click(sender As Object, e As System.EventArgs) Handles txtFilename.Click
        If txtFilename.Text = "" Then ' Nog geen bestand gekozen
            OpenFileDialog()
        End If
    End Sub

    ' Dialoogvenster bestandskeuze - bevestigd
    Private Sub ofdMembersFile_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ofdMembersFile.FileOk

        Dim intFreeFileNumber As Integer
        Dim strEersteRegel As String

        ' Nummer voor File handler
        intFreeFileNumber = FreeFile()

        ' Eerste regel inlezen
        FileOpen(intFreeFileNumber, ofdMembersFile.FileName, OpenMode.Input)
        strEersteRegel = LineInput(intFreeFileNumber)
        FileClose()

        ' Controleer of eerste regel overeenkomt met wat verwacht wordt
        If strEersteRegel <> "Lidnummer;Naam;;Clubnummer;Club;Achternm;Voornm;Lidcode;Masterpoints" Then

            ' Zoniet, toon berichtvenster
            MsgBox("Het gekozen bestand is geen geldig VBL-ledenbestand." & vbCrLf & vbCrLf & _
                   "Kies een ander bestand, of download een nieuw" & vbCrLf & _
                   "ledenbestand van de VBL-website.", MsgBoxStyle.Critical, "Geen VBL-ledenbestand")

            ' en laat dialoogvenster staan
            e.Cancel = True

        End If

        ' Alles ok? --> Bestandsnaam overnemen in tekstveld
        txtFilename.Text = ofdMembersFile.FileName

    End Sub

    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSaveMembersList_Click(sender As System.Object, e As System.EventArgs) Handles cmdSaveMembersList.Click

        If txtFilename.Text <> "" Then
            If sfdMembersFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                SaveMembersFile(sfdMembersFile.FileName)
            End If
        Else
            MsgBox("Kies eerst een geldig ledenbestand.", MsgBoxStyle.Critical, "Geen VBL-ledenbestand gekozen")
        End If

    End Sub

    Private Sub lblLink_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLink.LinkClicked
        System.Diagnostics.Process.Start("http://www.hartenvier.be")
    End Sub

    Private Sub SaveMembersFile(ByVal filename As String)

        Dim intFileNumberOpen, intFileNumberSave As Integer
        Dim strTekstregel As String

        ' Haal filehandlers op
        ' Open bestanden voor lezen en schrijven
        intFileNumberOpen = FreeFile()
        FileOpen(intFileNumberOpen, txtFilename.Text, OpenMode.Input)
        intFileNumberSave = FreeFile()
        FileOpen(intFileNumberSave, filename, OpenMode.Output)

        ' Lezen van oorspronkelijk bestand
        strTekstregel = LineInput(intFileNumberOpen) ' eerste regel negeren!

        Do While Not EOF(intFileNumberOpen)
            strTekstregel = LineInput(intFileNumberOpen)
            PrintLine(intFileNumberSave, csvManipulations.transformLine(strTekstregel))
        Loop

        FileClose(intFileNumberOpen)
        FileClose(intFileNumberSave)

        MsgBox("Bestand succesvol opgeslagen!" & vbCrLf & vbCrLf & _
               "Locatie: " & filename, MsgBoxStyle.Information, "Brigitte-ledenbestand opgeslagen")

    End Sub

End Class
