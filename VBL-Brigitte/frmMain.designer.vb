<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblCSV = New System.Windows.Forms.Label()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.cmdFile = New System.Windows.Forms.Button()
        Me.ofdMembersFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdMembersFile = New System.Windows.Forms.SaveFileDialog()
        Me.cmdSaveMembersList = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblLink = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblCSV
        '
        Me.lblCSV.AutoSize = True
        Me.lblCSV.Location = New System.Drawing.Point(12, 9)
        Me.lblCSV.Name = "lblCSV"
        Me.lblCSV.Size = New System.Drawing.Size(95, 13)
        Me.lblCSV.TabIndex = 0
        Me.lblCSV.Text = "Kies CSV-bestand:"
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(12, 25)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.ReadOnly = True
        Me.txtFilename.Size = New System.Drawing.Size(409, 20)
        Me.txtFilename.TabIndex = 1
        '
        'cmdFile
        '
        Me.cmdFile.Location = New System.Drawing.Point(427, 23)
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(75, 23)
        Me.cmdFile.TabIndex = 2
        Me.cmdFile.Text = "&Bladeren..."
        Me.cmdFile.UseVisualStyleBackColor = True
        '
        'ofdMembersFile
        '
        Me.ofdMembersFile.DefaultExt = "csv"
        Me.ofdMembersFile.Filter = "CSV-bestand|*.csv"
        '
        'sfdMembersFile
        '
        Me.sfdMembersFile.DefaultExt = "LYS"
        Me.sfdMembersFile.FileName = "VBLLEDEN.LYS"
        Me.sfdMembersFile.Filter = "Brigitte-ledenbestand|*.LYS"
        '
        'cmdSaveMembersList
        '
        Me.cmdSaveMembersList.Location = New System.Drawing.Point(12, 51)
        Me.cmdSaveMembersList.Name = "cmdSaveMembersList"
        Me.cmdSaveMembersList.Size = New System.Drawing.Size(75, 23)
        Me.cmdSaveMembersList.TabIndex = 3
        Me.cmdSaveMembersList.Text = "&Zet om"
        Me.cmdSaveMembersList.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(427, 80)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Sluiten"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lblLink
        '
        Me.lblLink.AutoSize = True
        Me.lblLink.LinkArea = New System.Windows.Forms.LinkArea(31, 52)
        Me.lblLink.Location = New System.Drawing.Point(12, 88)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(268, 17)
        Me.lblLink.TabIndex = 7
        Me.lblLink.TabStop = True
        Me.lblLink.Text = "© 2013 - Martijn Verstraelen - Retiese BC Hartenvier"
        Me.lblLink.UseCompatibleTextRendering = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 114)
        Me.Controls.Add(Me.lblLink)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSaveMembersList)
        Me.Controls.Add(Me.cmdFile)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.lblCSV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(520, 142)
        Me.MinimumSize = New System.Drawing.Size(520, 142)
        Me.Name = "frmMain"
        Me.Text = "Omzetten VBL-ledenbestand voor Brigitte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCSV As System.Windows.Forms.Label
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents cmdFile As System.Windows.Forms.Button
    Friend WithEvents ofdMembersFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdMembersFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdSaveMembersList As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents lblLink As System.Windows.Forms.LinkLabel

End Class
