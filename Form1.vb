Imports System.IO
Imports System.Threading
Imports System.Globalization
Imports System.ComponentModel
Public Class Form1

    Private Declare Function GetKeyState Lib "user32.dll" (ByVal nVirtKey As Keys) As Integer
    Private FileManager As New FileManager
    Private SpeechRecognition

    Private CultureNames As String() = {"ca-ES", "da-DK", "de-DE", "en-AU", "en-CA", "en-GB", "en-IN", "en-US", "es-ES", "es-MX",
        "fi-FI", "fr-CA", "fr-FR", "it-IT", "ja-JP", "ko-KR", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ru-RU", "sv-SE", "zh-CN",
        "zh-HK", "zh-TW"}

    Private ActionNames As String() = {"Forward", "Back", "Sneak", "Jump", "Mine", "Eat", "Interact", "Attack", "StopAll", "Up", "BigUp",
        "Down", "BigDown", "Left", "BigLeft", "Right", "BigRight", "Drop", "DropAll", "OpenInventory", "Quit",
        "Hb1", "Hb2", "Hb3", "Hb4", "Hb5", "Hb6", "Hb7", "Hb8", "Hb9"}

    Public resources As ComponentResourceManager = New ComponentResourceManager(GetType(Form1))

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialize SRE
        Try
            SpeechRecognition = New SpeechRecognition
        Catch ex As Exception
            If MessageBox.Show(resources.GetString("Msg_11"), "VoiceCraft", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=16789")
            End If
            End
        End Try
        'Continue loading
        For Each n As String In CultureNames
            LangComboBox.Items.Add(New CultureInfo(n).DisplayName)
        Next
        'Recover files/folders
        If Not Directory.Exists(My.Settings.FilesDirectory) Then
            Dim dirPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VoiceCraft"
            My.Settings.FilesDirectory = dirPath
            Directory.CreateDirectory(dirPath)
        End If
        Try
            For Each dictEntry As DictionaryEntry In My.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, False, True)
                If dictEntry.Key.StartsWith("Default Commands -") And dictEntry.Key.EndsWith(".vcc") And Not File.Exists(Path.Combine(My.Settings.FilesDirectory, dictEntry.Key)) Then
                    File.WriteAllBytes(Path.Combine(My.Settings.FilesDirectory, dictEntry.Key), dictEntry.Value)
                End If
            Next
            SaveFileDialog1.InitialDirectory = My.Settings.FilesDirectory
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
        'Load settings
        MinimizationModes.SelectedIndex = My.Settings.MinimizationMode
        EnableProcessHook.Checked = My.Settings.ProcessHookEnabled
        EnableNotifications.Checked = My.Settings.SendNotifications
        ConfidenceTrackBar.Value = My.Settings.ConfidencePercent
        ConfidencePercentLabel.Text = My.Settings.ConfidencePercent & "%"
        'Load others
        FilesFolderBrowser.SelectedPath = My.Settings.FilesDirectory
        OpenFileDialog2.InitialDirectory = My.Settings.FilesDirectory
        RefreshPaths()
        LoadEditor(FileManager.ReadFile(Nothing))
        KeybindTimer.Start()
        AppOutput.Log(AppOutput.resources.GetString("Output_1"))
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged '--This made to fix the tab control offset bug!
        If Me.WindowState = 0 And Me.Visible Then
            Dim sIndex As Integer = MainTabControl.SelectedIndex
            If MainTabControl.SelectedIndex > 0 Then
                MainTabControl.SelectedIndex = 0
            Else
                MainTabControl.SelectedIndex = 1
            End If
            MainTabControl.SelectedIndex = sIndex
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        KeybindTimer.Stop()
        If SpeechRecognition.IsListening Then
            SpeechRecognition.StopRecognition()
        End If
    End Sub

    '//Main page work

    Private LastIndex As Integer = 0

    Public Sub RefreshPaths() Handles FileSystemWatcher1.Created, FileSystemWatcher1.Renamed, FileSystemWatcher1.Changed, FileSystemWatcher1.Deleted
        DirectoryPath.Text = My.Settings.FilesDirectory
        FileComboBox.Items.Clear()
        If Directory.Exists(My.Settings.FilesDirectory) Then
            FileSystemWatcher1.Path = My.Settings.FilesDirectory
            Dim Files As String() = Directory.GetFiles(My.Settings.FilesDirectory)
            Dim lastFileFound As Boolean = False
            For Each filePath As String In Files
                If Path.GetExtension(filePath) = ".vcc" Then
                    Dim fileName As String = Path.GetFileName(filePath)
                    FileComboBox.Items.Add(fileName)
                    If fileName = My.Settings.LastFile Then
                        lastFileFound = True
                        LastIndex = FileComboBox.Items.IndexOf(fileName)
                        FileComboBox.SelectedIndex = LastIndex
                    End If
                End If
            Next
            If Not lastFileFound Then
                MsgBox(String.Format(resources.GetString("Msg_1"), My.Settings.LastFile), vbCritical)
            End If
        Else
            MsgBox(String.Format(resources.GetString("Msg_2"), My.Settings.FilesDirectory), vbCritical)
        End If
    End Sub

    Private Sub ConfidenceTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles ConfidenceTrackBar.ValueChanged
        My.Settings.ConfidencePercent = ConfidenceTrackBar.Value
        ConfidencePercentLabel.Text = ConfidenceTrackBar.Value & "%"
        If ConfidenceTrackBar.Value >= 80 Or ConfidenceTrackBar.Value <= 15 Then
            ConfidencePercentLabel.ForeColor = Color.Red
        Else
            ConfidencePercentLabel.ForeColor = Color.Black
        End If
    End Sub

    Private Sub FileComboBox_DropDown(sender As Object, e As EventArgs) Handles FileComboBox.DropDown
        LastIndex = FileComboBox.SelectedIndex
    End Sub

    Private Sub FileComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles FileComboBox.SelectionChangeCommitted
        If SpeechRecognition.IsListening Then
            FileComboBox.SelectedIndex = LastIndex
            MsgBox(resources.GetString("Msg_3"), vbExclamation)
            Return
        End If
        If Not File.Exists(My.Settings.FilesDirectory & "\\" & FileComboBox.SelectedItem) Then
            RefreshPaths()
            If FileComboBox.SelectedItem IsNot Nothing Then
                MsgBox(String.Format(resources.GetString("Msg_1"), FileComboBox.SelectedItem), vbCritical)
            End If
            Return
        End If
        My.Settings.LastFile = FileComboBox.SelectedItem
    End Sub

    Private Sub FileComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileComboBox.SelectedIndexChanged
        If FileComboBox.SelectedItem IsNot Nothing Then
            InspectButton.Enabled = True
            EditButton.Enabled = True
        Else
            InspectButton.Enabled = False
            EditButton.Enabled = False
        End If
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        If FilesFolderBrowser.ShowDialog = DialogResult.OK Then
            DirectoryPath.Text = FilesFolderBrowser.SelectedPath
            InputDirPath()
        End If
    End Sub

    Private Sub InputDirPath() Handles DirectoryPath.LostFocus
        If Directory.Exists(DirectoryPath.Text) Then
            My.Settings.FilesDirectory = DirectoryPath.Text
            RefreshPaths()
        Else
            DirectoryPath.Text = My.Settings.FilesDirectory
            MsgBox(resources.GetString("Msg_4"), vbCritical)
        End If
    End Sub

    Private Sub DirectoryPath_KeyDown(sender As Object, e As KeyEventArgs) Handles DirectoryPath.KeyDown
        If e.KeyCode = Keys.Enter Then
            InputDirPath()
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If Directory.Exists(My.Settings.FilesDirectory) Then
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                For Each fileName As String In OpenFileDialog1.FileNames
                    Dim destFile As String = Path.Combine(My.Settings.FilesDirectory, Path.GetFileName(fileName))
                    If Path.GetExtension(fileName) = ".vcc" And Not destFile = fileName Then
                        My.Computer.FileSystem.CopyFile(fileName, destFile, FileIO.UIOption.AllDialogs)
                    End If
                Next
            End If
        Else
            MsgBox(String.Format(resources.GetString("Msg_2"), My.Settings.FilesDirectory), vbCritical)
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim targetDirectory As String = My.Settings.FilesDirectory
        Dim targetFile As String = My.Settings.LastFile
        If Directory.Exists(targetDirectory) Then
            If File.Exists(Path.Combine(targetDirectory, targetFile)) Then
                Dim FullPath As String = Path.Combine(targetDirectory, targetFile)
                Dim loadedInfo As ArrayList = FileManager.ReadFile(FullPath)
                If loadedInfo IsNot Nothing Then
                    LoadEditor(loadedInfo, FullPath)
                    MainTabControl.SelectedTab = EditorPage
                Else
                    MsgBox(String.Format(resources.GetString("Msg_5"), targetFile), vbCritical)
                End If
            Else
                MsgBox(String.Format(resources.GetString("Msg_1"), targetFile), vbCritical)
            End If
        Else
            MsgBox(String.Format(resources.GetString("Msg_2"), My.Settings.FilesDirectory), vbCritical)
            Return
        End If
    End Sub

    Private Sub InspectButton_Click(sender As Object, e As EventArgs) Handles InspectButton.Click
        Dim formName As String = String.Format(resources.GetString("InspectorTitle"), My.Settings.LastFile)
        Dim newForm As Form = Application.OpenForms(formName)
            If newForm Is Nothing Then
                newForm = New Form2 With {
                    .Name = formName,
                    .Text = formName
                }
                newForm.Show()
            End If
        newForm.WindowState = 0
        newForm.Select()
    End Sub
    Private Sub StartReco(sender As Object, e As EventArgs) Handles StartButton.Click
        If Not SpeechRecognition.IsListening And StartButton.Enabled Then
            Cursor.Current = Cursors.WaitCursor
            If SpeechRecognition.StartRecognition() Then
                StartButton.Enabled = False
                StopButton.Enabled = True
                NotifyIcon1.Icon = My.Resources.NotifyIconActive
                TSMButton1.Text = resources.GetString("Stop")
                TSMButton1.Image = My.Resources.StopButton
                NotifyIcon1.Text = resources.GetString("State_1")
                If My.Settings.SendNotifications Then
                    NotifyIcon1.ShowBalloonTip(2, resources.GetString("NotifiTitle_1"), resources.GetString("NotifiText_1"), ToolTipIcon.Info)
                End If
                If My.Settings.MinimizationMode >= 3 And TSMButton2.Text = resources.GetString("Minimize") Then
                    TSMButton2.PerformClick()
                ElseIf (My.Settings.MinimizationMode = 1 Or My.Settings.MinimizationMode = 2) And Me.WindowState = 0 Then
                    Me.WindowState = 1
                End If
            End If
            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub StopReco(sender As Object, e As EventArgs) Handles StopButton.Click
        If SpeechRecognition.IsListening And StopButton.Enabled Then
            Cursor.Current = Cursors.WaitCursor
            SpeechRecognition.StopRecognition()
            StartButton.Enabled = True
            StopButton.Enabled = False
            TSMButton1.Text = resources.GetString("Start")
            TSMButton1.Image = My.Resources.StartButton
            Cursor.Current = Cursors.Default
            NotifyIcon1.Text = resources.GetString("State_2")
            If My.Settings.SendNotifications Then
                NotifyIcon1.ShowBalloonTip(2, resources.GetString("NotifiTitle_2"), resources.GetString("NotifiText_2"), ToolTipIcon.Info)
            End If
            NotifyIcon1.Icon = My.Resources.NotifyIconNormal
            If My.Settings.MinimizationMode = 3 And TSMButton2.Text = resources.GetString("Normalize") Then
                TSMButton1.PerformClick()
            ElseIf My.Settings.MinimizationMode = 1 And Me.WindowState = 1 Then
                Me.WindowState = 0
            End If
            Me.Select()
        End If
    End Sub

    Const KEY_DOWN As Integer = &H8000

    Private Sub KeybindTimer_Tick(sender As Object, e As EventArgs) Handles KeybindTimer.Tick
        Dim StartKeyPressed = (GetKeyState(Keys.F8) And KEY_DOWN)
        Dim StopKeyPressed = (GetKeyState(Keys.F9) And KEY_DOWN)
        If StartKeyPressed Then
            StartButton.PerformClick()
        End If
        If StopKeyPressed Then
            StopButton.PerformClick()
        End If
    End Sub

    '//Editor page work
    Private EditorData As ArrayList
    Private LastFilePath As String
    Private FileSaved As Boolean = True

    Private Sub LoadEditor(startData As ArrayList, Optional sourcePath As String = Nothing)
        If PromptSave() Then Return  'Cancelled loading new
        LangComboBox.SelectedIndex = -1
        ActComboBox.SelectedIndex = -1
        If sourcePath IsNot Nothing Then
            FileNameLabel.Text = Path.GetFileName(sourcePath)
        Else
            Dim saveDir = SaveFileDialog1.InitialDirectory
            FileNameLabel.Text = "Untitled.vcc"
            Dim num As Integer = 1
            While Directory.GetFileSystemEntries(saveDir).Contains(saveDir & FileNameLabel.Text) Or Directory.GetFileSystemEntries(saveDir).Contains(saveDir & "\" & FileNameLabel.Text)
                FileNameLabel.Text = "Untitled(" & num & ").vcc"
                num += 1
                Thread.Sleep(100)
            End While
        End If
        EditorData = startData
        LangComboBox.SelectedIndex = CultureNames.ToList.IndexOf(EditorData.Item(0))
        ActComboBox.SelectedIndex = 0
        LastFilePath = sourcePath
        FileSaved = True
    End Sub

    Private Function PromptSave() As Boolean
        If Not FileSaved And EditorData IsNot Nothing Then
            Dim result As DialogResult = MessageBox.Show(String.Format(resources.GetString("Msg_6"), FileNameLabel.Text), "VoiceCraft", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                SaveButton.PerformClick()
            ElseIf result = DialogResult.Cancel Then
                Return True
            Else
                FileSaved = True
            End If
        End If
    End Function

    Private Sub LangComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles LangComboBox.SelectionChangeCommitted
        EditorData.Item(0) = CultureNames.ElementAt(LangComboBox.SelectedIndex)
        FileSaved = False
    End Sub

    Private Sub LangComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LangComboBox.SelectedIndexChanged
        If LangComboBox.SelectedItem IsNot Nothing Then
            ActComboBox.Enabled = True
            'CommandPhrases.ReadOnly = False
            'FileSaved = False
        Else
            ActComboBox.Enabled = False
            CommandPhrases.Text = ""
            'CommandPhrases.ReadOnly = True
        End If
    End Sub

    Private Sub ActComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ActComboBox.SelectionChangeCommitted
        FileSaved = False
    End Sub

    Private Sub ActComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ActComboBox.SelectedIndexChanged
        If ActComboBox.SelectedItem IsNot Nothing Then
            For Each cmdInfo As ArrayList In EditorData.Item(1)
                If cmdInfo.Item(0) = ActionNames.ElementAt(ActComboBox.SelectedIndex) Then
                    Dim cmdPhrases As String() = cmdInfo.Item(1)
                    Dim fillText As String = ""
                    For Each phrase As String In cmdPhrases
                        If Not phrase = " " Then
                            If Not phrase = cmdPhrases.Last Then
                                If phrase = cmdPhrases.First Then
                                    phrase = StrConv(Split(phrase).First, vbProperCase) & phrase.Substring(Split(phrase).First.Length)
                                End If
                                fillText = fillText & phrase & ", "
                            Else
                                If phrase = cmdPhrases.First Then
                                    phrase = StrConv(Split(phrase).First, vbProperCase) & phrase.Substring(Split(phrase).First.Length)
                                End If
                                fillText &= phrase
                            End If
                        End If
                    Next
                    CommandPhrases.Text = fillText
                End If
            Next
            CommandPhrases.Enabled = True
        Else
            CommandPhrases.Text = ""
            CommandPhrases.Enabled = False
        End If
    End Sub

    Private LastText As String = ""

    Private Sub CommandPhrases_TextChanged(sender As Object, e As EventArgs) Handles CommandPhrases.TextChanged
        Dim text As String = CommandPhrases.Text
        If text.Contains("/") Or text.Contains(":") Or text.Contains(";") Or text.Contains(".") Then
            MsgBox(resources.GetString("Msg_7"), vbCritical)
            CommandPhrases.Text = LastText
        End If
        If text = "" Then
            text = " "
        End If
        For Each cmdInfo As ArrayList In EditorData.Item(1)
            If cmdInfo.Item(0) = ActionNames.ElementAt(ActComboBox.SelectedIndex) Then
                While text.StartsWith(" ") And text.Length > 1
                    text = text.Remove(0, 1)
                End While
                While text.EndsWith(" ") And text.Length > 1
                    text = text.Remove(text.Length - 2)
                End While
                While text.Contains(", ")
                    text = text.Replace(", ", ",")
                End While
                While text.Contains(" ,")
                    text = text.Replace(" ,", ",")
                End While
                LastText = text
                cmdInfo.Insert(1, text.ToLower().Split(","))
                FileSaved = False
            End If
        Next
    End Sub
    Private Sub CommandPhrases_KeyDown(sender As Object, e As KeyEventArgs) Handles CommandPhrases.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            CommandPhrases.SetOnLostFocus()
        End If
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            If e.Shift Then
                SaveAsButton.PerformClick()
            Else
                SaveButton.PerformClick()
            End If
        End If
    End Sub

    Private Sub SaveButton_Click() Handles SaveButton.Click
        If LastFilePath IsNot Nothing Then
            If FileManager.WriteFile(LastFilePath, EditorData) Then
                FileSaved = True
            Else
                MsgBox(resources.GetString("Msg_8"), vbCritical)
            End If
        Else
            SaveAsButton.PerformClick()
        End If
    End Sub

    Private Sub SaveAsButton_Click() Handles SaveAsButton.Click
        SaveFileDialog1.FileName = FileNameLabel.Text
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            If FileManager.WriteFile(SaveFileDialog1.FileName, EditorData) Then
                SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(SaveFileDialog1.FileName)
                FileNameLabel.Text = Path.GetFileName(SaveFileDialog1.FileName)
                LastFilePath = SaveFileDialog1.FileName
                FileSaved = True
            Else
                MsgBox(resources.GetString("Msg_8"), vbCritical)
            End If
        End If
    End Sub

    Private Sub CreateNewButton_Click(sender As Object, e As EventArgs) Handles CreateNewButton.Click
        LoadEditor(FileManager.ReadFile(Nothing))
    End Sub

    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        If PromptSave() Then Return
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            Dim loadedData As ArrayList = FileManager.ReadFile(OpenFileDialog2.FileName)
            If loadedData IsNot Nothing Then
                LoadEditor(loadedData, OpenFileDialog2.FileName)
            Else
                MsgBox(resources.GetString("Msg_9"), vbCritical)
            End If
        End If
    End Sub

    'Notifi Icon menu work

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If Not Me.Visible And e.Button = MouseButtons.Left Then
            TSMButton2.PerformClick()
        End If
    End Sub

    Private Sub TSMButton1_Click(sender As Object, e As EventArgs) Handles TSMButton1.Click
        If SpeechRecognition.IsListening Then
            StopButton.PerformClick()
        Else
            StartButton.PerformClick()
        End If
    End Sub

    Private Sub TSMButton2_Click(sender As Object, e As EventArgs) Handles TSMButton2.Click
        If Me.Visible Then
            Me.WindowState = 1
            Me.Visible = False
            TSMButton2.Text = resources.GetString("Normalize")
        ElseIf Not Me.Visible Then
            Me.Visible = True
            Me.WindowState = 0
            TSMButton2.Text = resources.GetString("Minimize")
        End If
    End Sub

    Private Sub TSMButton3_Click(sender As Object, e As EventArgs) Handles TSMButton3.Click
        ShowOutput.PerformClick()
    End Sub

    Private Sub TSMButton4_Click(sender As Object, e As EventArgs) Handles TSMButton4.Click
        Process.Start("https://github.com/ItsMixDev/VoiceCraft")
    End Sub

    Private Sub TSMButton5_Click(sender As Object, e As EventArgs) Handles TSMButton5.Click
        Me.Close()
    End Sub

    '//Advanced settings page work

    Private Sub MinimizationModes_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MinimizationModes.SelectionChangeCommitted
        My.Settings.MinimizationMode = MinimizationModes.SelectedIndex
    End Sub

    Private Sub EnableProcessHook_CheckedChanged(sender As Object, e As EventArgs) Handles EnableProcessHook.CheckedChanged
        My.Settings.ProcessHookEnabled = EnableProcessHook.Checked
    End Sub

    Private Sub EnableNotifications_CheckedChanged(sender As Object, e As EventArgs) Handles EnableNotifications.CheckedChanged
        My.Settings.SendNotifications = EnableNotifications.Checked
    End Sub

    Private Sub ShowOutput_Click(sender As Object, e As EventArgs) Handles ShowOutput.Click
        AppOutput.Show()
        AppOutput.WindowState = FormWindowState.Normal
        AppOutput.Select()
    End Sub


End Class
