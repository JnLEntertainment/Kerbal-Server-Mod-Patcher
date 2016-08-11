Public Class Debugging

    Private Sub EncryptButton_Click(sender As Object, e As EventArgs) Handles EncryptButton.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Choose a File to get SHA256 Encrypted Code"
        fd.InitialDirectory = Environment.SpecialFolder.Desktop
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            EncryptTextBox.Text = ""
            EncryptTextBox.Text = sha256_hash(strFileName)
        Else
            MsgBox("파일을 불러올 수 없습니다")
        End If
    End Sub
End Class