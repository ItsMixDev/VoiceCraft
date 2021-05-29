Imports System.IO
Imports System.Net

Public Class FileManager

    Public Function ReadFile(pth As String) As ArrayList
        Try
            Dim fileData As String
            If pth Is Nothing Then
                fileData = My.Resources.SampleEmpty
                Console.WriteLine("Loaded empty file: " & fileData)
            Else
                fileData = File.ReadAllText(pth)
                Console.WriteLine("Loaded " & Path.GetFileName(pth) & " data: " & fileData)
            End If
            Dim firstArray As String() = Split(fileData, "/")
            Dim secondArray As String() = Split(firstArray.Last, ";")
            Dim cmds As New ArrayList
            For Each cmd As String In secondArray
                If Not cmd = "" Then
                    Dim thirdArray As String() = Split(cmd, ":")
                    'thirdArray.SetValue(Split(thirdArray.Last, "}").First, thirdArray.Length - 1)
                    Dim CommandInfo As New ArrayList
                    CommandInfo.Add(thirdArray.First)
                    CommandInfo.Add(Split(thirdArray.Last, ","))
                    cmds.Add(CommandInfo)
                End If
            Next
            Dim toReturn As New ArrayList
            toReturn.Add(firstArray.First)
            toReturn.Add(cmds)
            If pth IsNot Nothing Then
                AppOutput.Log(String.Format(AppOutput.resources.GetString("Output_6"), pth))
            End If
            Return toReturn
        Catch ex As Exception
            'MsgBox(ex.ToString, vbCritical)
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function WriteFile(Path As String, Input As ArrayList) As Boolean
        Try
            Dim culture As String = Input.Item(0)
            Dim cmds As ArrayList = Input.Item(1)
            Dim output As String = culture + "/"
            For Each cmdInfo As ArrayList In cmds
                output &= cmdInfo.Item(0) & ":"
                Dim cmdPhrases As String() = cmdInfo.Item(1)
                For Each phrase As String In cmdPhrases
                    If cmdPhrases.Length = 1 Or phrase = cmdPhrases.Last Then
                        output &= phrase
                    Else
                        output &= phrase & ","
                    End If
                Next
                output &= ";"
            Next
            File.WriteAllText(Path, output)
            Console.WriteLine(Path)
            AppOutput.Log(String.Format(AppOutput.resources.GetString("Output_7"), Path))
            Return True
        Catch ex As Exception
            'MsgBox(ex.ToString, vbCritical)
            Return False
        End Try
        Return False
    End Function

    Public RuntimeLink As String = "https://github.com/ItsMixDev/VoiceCraft/raw/master/Microsoft%20Speech%20Recognition/Microsoft%20Speech%20Platform%20-%20Server%20Runtime%20(x86).msi"
    Public PackagesLink = "https://github.com/ItsMixDev/VoiceCraft/raw/master/Microsoft%20Speech%20Recognition/Microsoft%20Speech%20Platform%20-%20Server%20Runtime%20Languages/"

    Public Sub Download(fileName As String)
        AppOutput.Log(String.Format(AppOutput.resources.GetString("Output_8"), fileName))
        Try
            Dim filePath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, fileName.GetHashCode & ".msi")
            Dim wClient As New WebClient
            wClient.DownloadFile(New Uri(fileName), filePath)
            Process.Start(filePath).WaitForExit()
            File.Delete(filePath)
        Catch ex As Exception
            AppOutput.Log(AppOutput.resources.GetString("Output_9"))
        End Try
    End Sub

End Class
