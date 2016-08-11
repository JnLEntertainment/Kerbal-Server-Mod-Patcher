Imports System.IO
Imports System.Net
Imports System.ComponentModel
Public Class Modern

    Dim WithEvents WebC As New WebClient
    Dim Temp As String = Path.GetTempPath + "KSMP"

    Private Sub Wiki_Click(sender As Object, e As EventArgs) Handles Wiki.Click
        Dim Form_Wiki = New Wiki
        Form_Wiki.Show()
        Button_Disable(True)
        Result.Items.Clear()
    End Sub
    Private Sub Tudy_Click(sender As Object, e As EventArgs) Handles Tudy.Click
        Dim Form_Tudy = New Tudy
        Form_Tudy.Show()
        Button_Disable(True)
        Result.Items.Clear()
    End Sub
    Private Sub CW_Click(sender As Object, e As EventArgs) Handles CW.Click
        Dim Form_CW = New CW
        Form_CW.Show()
        Button_Disable(True)
        Result.Items.Clear()
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        confirm(True)
    End Sub

    Private Sub BGM_Click(sender As Object, e As EventArgs) Handles BGM.Click
        BGM.Enabled = False
        If BGM.Checked = True Then
            Dim File As String = Temp + "\Audio.wav"
            Dim sha256_file As String = "0bd9fb643e3d06b17d9a92eaba6355bdaa39b5c6786c5cf74485a969b2484c90"

            If My.Computer.FileSystem.DirectoryExists(Temp) = False Then My.Computer.FileSystem.CreateDirectory(Temp)

            If My.Computer.FileSystem.FileExists(File) = True Then
                If sha256_hash(File) = sha256_file Then
                    GlobalVariables.count = 1
                    My.Computer.Audio.Play(File, AudioPlayMode.BackgroundLoop)
                    BGM.Enabled = True
                Else
                    My.Computer.FileSystem.DeleteFile(File)

                End If
            Else
                My.Computer.Network.DownloadFile(New Uri("https://kerbalkorea.cf/server/music/Let%20Me%20Hear.wav"), File, "", "", True, 900000, True, FileIO.UICancelOption.DoNothing)
                If sha256_hash(File) = sha256_file Then
                    GlobalVariables.count = 1
                    My.Computer.Audio.Play(File, AudioPlayMode.BackgroundLoop)
                    BGM.Enabled = True
                Else
                    BGM.CheckState = CheckState.Unchecked
                    BGM.Enabled = True
                End If
            End If
        ElseIf BGM.Checked = False Then
            My.Computer.Audio.Stop()
            BGM.Enabled = True
        End If
    End Sub

    Private Sub Modern_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim Temp As String = Path.GetTempPath + "KSMP"
        Select Case MsgBox("캐시를 삭제하시겠습니까?", MsgBoxStyle.YesNo, "Cache")
            Case MsgBoxResult.Yes
                If My.Computer.FileSystem.DirectoryExists(Temp) = True Then My.Computer.FileSystem.DeleteDirectory(Temp, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End Select
    End Sub

    Private Sub Modern_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F12 Then
            If InputBox("Password", "Security") = "겨레" Then
                Dim Form_Debugging = New Debugging
                Form_Debugging.Show()
            End If
        End If
    End Sub
End Class
Public Class GlobalVariables
    Public Shared count As Integer = 0
End Class
Module Modern_Module
    Function Button_Enable(b As Boolean) As Integer
        Modern.Wiki.Enabled = True
        Modern.Tudy.Enabled = True
        Modern.CW.Enabled = True
        Return 0
    End Function
    Function Button_Disable(b As Boolean) As Integer
        Modern.Wiki.Enabled = False
        Modern.Tudy.Enabled = False
        Modern.CW.Enabled = False
        Return 0
    End Function
    Function Download_File(d As Boolean) As Integer
        Dim Temp As String = Path.GetTempPath + "KSMP"
        Dim File As String = Temp + "\Audio.wav"
        Dim sha256_file As String = "0bd9fb643e3d06b17d9a92eaba6355bdaa39b5c6786c5cf74485a969b2484c90"
        My.Computer.Network.DownloadFile(New Uri("https://kerbalkorea.cf/server/music/Let%20Me%20Hear.wav"), File, "", "", True, 900000, True, FileIO.UICancelOption.DoNothing)
        If sha256_hash(File) = sha256_file Then
            GlobalVariables.count = 1
            My.Computer.Audio.Play(File, AudioPlayMode.BackgroundLoop)
            Modern.BGM.Enabled = True
            Return 1
        Else
            Modern.BGM.CheckState = CheckState.Unchecked
            Modern.BGM.Enabled = True
            Return 0
        End If
        Return 0
    End Function
End Module