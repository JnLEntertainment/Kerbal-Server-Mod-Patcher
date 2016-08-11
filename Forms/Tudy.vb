Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.ComponentModel

Public Class Tudy

    Dim WithEvents WebC As New WebClient
    Dim Temp As String = Path.GetTempPath + "KSMP"
    Dim Tudy_Pack As String = "https://kerbalkorea.cf/server/tudy/GameData.zip"

    Private Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        DownloadButton.Enabled = False

        WebC.DownloadFileAsync(New Uri(Tudy_Pack), Temp)
    End Sub

    Private Sub DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WebC.DownloadProgressChanged
        TudyProgressBar.Value = e.ProgressPercentage
    End Sub

    Private Sub DownloadFinished(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs) Handles WebC.DownloadFileCompleted
        MsgBox("모드팩 다운로드가 완료되었습니다" + Environment.NewLine + "설치를 진행합니다" + Environment.NewLine + "다음 팝업이 뜰때 까지 잠시만 기다려 주세요")
        ZIP.unzip(True)
        ZIP.backup(True)
        ZIP.install(True)
        If ZIP.clean(True) = 1 Then MsgBox("설치가 완료되었습니다" + Environment.NewLine + "즐거운 게임 하시길 바랍니다")
        DownloadButton.Enabled = True
    End Sub
End Class