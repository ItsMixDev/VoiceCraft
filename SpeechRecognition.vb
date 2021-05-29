Imports Microsoft.Speech.Recognition
Imports System.Threading
Imports System.Globalization
Imports System.IO


Public Class SpeechRecognition
    Private Emulator As New Emulator
    Private FileManager As New FileManager
    Public IsListening As Boolean = False

    Private sre As New SpeechRecognitionEngine
    Private Commands As ArrayList

    Private Sub RecognizeCmd(text As String)
        For Each CommandInfo As ArrayList In Commands
            For Each cmd As String In CommandInfo.Item(1)
                If cmd.ToLower = text.ToLower Then
                    Try
                        CallByName(Emulator, CommandInfo.Item(0), CallType.Method)
                    Catch ex As Exception
                        MsgBox(String.Format(Form1.resources.GetString("Msg_13"), CommandInfo.Item(0)), vbCritical)
                        'MsgBox(ex.ToString, vbCritical)
                    End Try
                    Return
                End If
            Next
        Next
    End Sub

    Private Function CheckForProcess() As Boolean
        If My.Settings.ProcessHookEnabled Then
            For Each p As Process In Process.GetProcessesByName("javaw")
                If p IsNot Nothing And Not p.HasExited And p.MainWindowTitle.Contains("Minecraft") Then
                    Return True
                End If
            Next
            Emulator.StopAll()
            Return False
        End If
        Return True
    End Function

    Private Sub SpeechRecognized(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)
        If IsListening Then
            If e.Result.Confidence >= (My.Settings.ConfidencePercent / 100) And CheckForProcess() Then
                Dim thrd As New Thread(AddressOf RecognizeCmd)
                thrd.Priority = ThreadPriority.Highest
                thrd.Start(e.Result.Text)
                AppOutput.Log(String.Format(AppOutput.resources.GetString("Output_2"), e.Result.Text))
            End If
        End If
    End Sub

    Public Function StartRecognition() As Boolean
        Dim loadedInfo As ArrayList = Nothing
        Dim targetDirectory As String = My.Settings.FilesDirectory
        Dim targetFile As String = My.Settings.LastFile

        If Directory.Exists(targetDirectory) Then
            If File.Exists(Path.Combine(targetDirectory, targetFile)) Then
                loadedInfo = FileManager.ReadFile(Path.Combine(targetDirectory, targetFile))
            Else
                MsgBox(String.Format(Form1.resources.GetString("Msg_1"), targetFile), vbCritical)
                AppOutput.Log(AppOutput.resources.GetString("Output_3"))
                Return False
            End If
        Else
            MsgBox(String.Format(Form1.resources.GetString("Msg_2"), My.Settings.FilesDirectory), vbCritical)
            AppOutput.Log(AppOutput.resources.GetString("Output_3"))
            Return False
        End If
        If loadedInfo IsNot Nothing Then
            Commands = loadedInfo.Item(1)
        Else
            MsgBox(String.Format(Form1.resources.GetString("Msg_5"), targetFile), vbCritical)
            AppOutput.Log(AppOutput.resources.GetString("Output_3"))
            Return False
        End If

        Dim ci As CultureInfo
        Dim gb As New GrammarBuilder
        Dim choices As New Choices
        Try
            Dim culture As String = loadedInfo.Item(0)
            ci = New CultureInfo(culture)
            gb.Culture = ci
            For Each cmdInfo As ArrayList In Commands
                choices.Add(cmdInfo.Item(1))
            Next
            gb.Append(choices)
        Catch ex As Exception
            MsgBox(String.Format(Form1.resources.GetString("Msg_5"), targetFile), vbCritical)
            'MsgBox(ex.ToString, vbCritical)
            AppOutput.Log(AppOutput.resources.GetString("Output_3"))
            Return False
        End Try
        Dim g As New Grammar(gb)
        Try
            sre = New SpeechRecognitionEngine(ci)
            sre.LoadGrammar(g)
        Catch ex As Exception
            Try
                If MessageBox.Show(String.Format(Form1.resources.GetString("Msg_10"), ci.Name), "VoiceCraft", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                    Form1.Enabled = False
                    FileManager.Download(FileManager.PackagesLink & "MSSpeech_SR_" & ci.Name & "_TELE.msi")
                    sre = New SpeechRecognitionEngine(ci)
                    sre.LoadGrammar(g)
                    Form1.Enabled = True
                    Form1.Select()
                Else
                    Throw New Exception("Canceled")
                End If
            Catch exeption As Exception
                If Not exeption.Message = "Canceled" Then
                    MsgBox(Form1.resources.GetString("Msg_14"), vbCritical)
                    'MsgBox(exeption.ToString, vbCritical)
                    Form1.Enabled = True
                    Form1.Select()
                End If
                AppOutput.Log(AppOutput.resources.GetString("Output_3"))
                Return False
            End Try
        End Try
        Try
            sre.SetInputToDefaultAudioDevice()
        Catch ex As Exception
            MsgBox(Form1.resources.GetString("Msg_12"), vbCritical)
            'MsgBox(ex.ToString, vbCritical)
            AppOutput.Log(AppOutput.resources.GetString("Output_3"))
            Return False
        End Try
        sre.RecognizeAsync(RecognizeMode.Multiple)
        AddHandler sre.SpeechRecognized, New EventHandler(Of SpeechRecognizedEventArgs)(AddressOf SpeechRecognized)
        IsListening = True
        AppOutput.Log(AppOutput.resources.GetString("Output_4"))
        Return True
    End Function

    Public Sub StopRecognition()
        If sre IsNot Nothing Then
            sre.Dispose()
            sre = Nothing
        End If
        IsListening = False
        Emulator.StopAll()
        AppOutput.Log(AppOutput.resources.GetString("Output_5"))
    End Sub

End Class

