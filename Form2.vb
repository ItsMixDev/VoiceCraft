Imports System.Globalization
Imports System.IO
Public Class Form2

    Public FileManager As New FileManager
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loadedInfo As ArrayList = Nothing
        Dim Commands As ArrayList = Nothing
        Dim targetDirectory As String = My.Settings.FilesDirectory
        Dim targetFile As String = My.Settings.LastFile

        If Directory.Exists(targetDirectory) Then
            If File.Exists(Path.Combine(targetDirectory, targetFile)) Then
                loadedInfo = FileManager.ReadFile(Path.Combine(targetDirectory, targetFile))
            Else
                MsgBox(String.Format(Form1.resources.GetString("Msg_1"), targetFile), vbCritical)
                Return
            End If
        Else
            MsgBox(String.Format(Form1.resources.GetString("Msg_2"), targetDirectory), vbCritical)
            Me.Close()
            Return
        End If
        If loadedInfo IsNot Nothing Then
            Commands = loadedInfo.Item(1)
        Else
            Console.WriteLine("this")
            MsgBox(String.Format(Form1.resources.GetString("Msg_5"), targetFile), vbCritical)
            Me.Close()
            Return
        End If
        Try
            Dim culture As String = loadedInfo.Item(0)
            Dim cultureInfo As New CultureInfo(culture)
            TablePanel.Controls("Culture").Text = cultureInfo.DisplayName
            For Each cmdInfo As ArrayList In Commands
                Dim Cell = TablePanel.Controls(cmdInfo.Item(0))
                If Cell IsNot Nothing Then
                    Dim cmdPhrases As String() = cmdInfo.Item(1)
                    Dim fillText As String = ""
                    For Each phrase As String In cmdPhrases
                        If Not phrase = cmdPhrases.Last Then
                            If phrase = cmdPhrases.First Then
                                phrase = StrConv(Split(phrase).First, vbProperCase) & phrase.Substring(Split(phrase).First.Length)
                            End If
                            fillText &= phrase & ", "
                        Else
                            If phrase = cmdPhrases.First Then
                                phrase = StrConv(Split(phrase).First, vbProperCase) & phrase.Substring(Split(phrase).First.Length)
                            End If
                            fillText &= phrase
                        End If
                    Next
                    If Not fillText = "" Then
                        Cell.Text = fillText
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(String.Format(Form1.resources.GetString("Msg_5"), targetFile), vbCritical)
            'MsgBox(ex.ToString, vbCritical)
            Me.Close()
        End Try

    End Sub

End Class