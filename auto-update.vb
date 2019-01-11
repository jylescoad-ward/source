'HOW TO USE
'1. Change address (location where latest version is) e.g http://updates.strafecode.com/dllinjector-latest.txt
' [v2.0.3]
'2. Change Latest Version Executable Location (Latest Version)
'3. Add to your load function 
UpdateSoftware() 


Public CurrentVersion As String = CurrentProgramVersion
Public LatestVersionLocation As String = HTTP Location for Executable
Public LatestVersion As String = HTTP Location to Text File (Contents is latest version)
Sub UpdateSoftware()
  Dim address As String = LatestVersion
  Dim client As WebClient = New WebClient()
  Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
  Dim LatestVersion As String = reader.ReadToEnd
  If (LatestVersion = CurrentVersion) Then
    MsgBox("No Updates Availble")
  ElseIf (LatestVersion IsNot CurrentVersion) Then
    MsgBox("New Update for Quick Launcher." + Environment.NewLine + Environment.NewLine + "Download Link:" + Environment.NewLine + LatestVersionLocation)
    Process.Start(LatestVersionLocation)
  End If
End Sub
