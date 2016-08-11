<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tudy
    Inherits MetroFramework.Forms.MetroForm

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.HomeButton = New MetroFramework.Controls.MetroButton()
        Me.TudyProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.DownloadButton = New MetroFramework.Controls.MetroButton()
        Me.TudyBrowser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(757, 30)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(60, 20)
        Me.HomeButton.TabIndex = 7
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseCustomBackColor = True
        Me.HomeButton.UseSelectable = True
        '
        'TudyProgressBar
        '
        Me.TudyProgressBar.Location = New System.Drawing.Point(23, 500)
        Me.TudyProgressBar.Name = "TudyProgressBar"
        Me.TudyProgressBar.Size = New System.Drawing.Size(664, 30)
        Me.TudyProgressBar.TabIndex = 6
        '
        'DownloadButton
        '
        Me.DownloadButton.Location = New System.Drawing.Point(693, 500)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(124, 30)
        Me.DownloadButton.TabIndex = 5
        Me.DownloadButton.Text = "다운로드 및 설치"
        Me.DownloadButton.UseSelectable = True
        '
        'TudyBrowser
        '
        Me.TudyBrowser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TudyBrowser.Location = New System.Drawing.Point(23, 56)
        Me.TudyBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.TudyBrowser.Name = "TudyBrowser"
        Me.TudyBrowser.Size = New System.Drawing.Size(794, 438)
        Me.TudyBrowser.TabIndex = 4
        Me.TudyBrowser.Url = New System.Uri("http://cafe.naver.com/kerbal/42477", System.UriKind.Absolute)
        '
        'Tudy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 560)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.TudyProgressBar)
        Me.Controls.Add(Me.DownloadButton)
        Me.Controls.Add(Me.TudyBrowser)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tudy"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "Tudy Server"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HomeButton As MetroFramework.Controls.MetroButton
    Friend WithEvents TudyProgressBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents DownloadButton As MetroFramework.Controls.MetroButton
    Friend WithEvents TudyBrowser As System.Windows.Forms.WebBrowser
End Class
