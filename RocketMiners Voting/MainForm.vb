Imports System.IO
Public Class MainForm
    Dim webAddress1 As String = "https://www.minecraft-serverlist.net/vote/44991"
    Dim webAddress2 As String = "https://minecraft-servers.de/server/rocketminers-eine-community-von-rocket-beans-tv/vote"
    Dim webAddress3 As String = "https://minecraft-server.eu/vote/index/20353"


    Private Sub CMDvote_Click(sender As Object, e As EventArgs) Handles CMDvote.Click
        Process.Start(webAddress1)
        Process.Start(webAddress2)
        Process.Start(webAddress3)
    End Sub

    Private Sub CMDExit_Click(sender As Object, e As EventArgs) Handles CMDExit.Click
        Me.Close()
    End Sub

    Private Sub LLServerlist_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLServerlist.LinkClicked
        Process.Start(webAddress1)
    End Sub

    Private Sub LLMS_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLMS.LinkClicked
        Process.Start(webAddress2)
    End Sub

    Private Sub LLMSEU_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLMSEU.LinkClicked
        Process.Start(webAddress3)
    End Sub
End Class
