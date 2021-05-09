Imports System.ComponentModel
Public Class AppOutput

    Public resources As ComponentResourceManager = New ComponentResourceManager(GetType(AppOutput))

    Public Sub Log(message As String)
        Dim fullString = Format(Now.ToLongTimeString, "[{0}] ") & message & vbCrLf
        OutputBox.AppendText(fullString)
    End Sub

    Private Sub AppOutput_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub OutputBox_TextChanged(sender As Object, e As EventArgs) Handles OutputBox.TextChanged
        OutputBox.ScrollToCaret()
    End Sub

    Private Sub AppOutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = My.Settings.AlwaysOnTop
        ToolStripMenuItem1.Checked = My.Settings.AlwaysOnTop
    End Sub

    Private Sub ToolStripMenuItem1_CheckedChanged(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.CheckedChanged
        Me.TopMost = ToolStripMenuItem1.Checked
        My.Settings.AlwaysOnTop = ToolStripMenuItem1.Checked
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        OutputBox.Clear()
    End Sub

End Class