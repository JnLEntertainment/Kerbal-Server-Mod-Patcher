<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wiki
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
        Me.WikiBrowser = New System.Windows.Forms.WebBrowser()
        Me.DownloadButton = New MetroFramework.Controls.MetroButton()
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.HomeButton = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'WikiBrowser
        '
        Me.WikiBrowser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WikiBrowser.Location = New System.Drawing.Point(23, 63)
        Me.WikiBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WikiBrowser.Name = "WikiBrowser"
        Me.WikiBrowser.Size = New System.Drawing.Size(794, 438)
        Me.WikiBrowser.TabIndex = 0
        Me.WikiBrowser.Url = New System.Uri("http://cafe.naver.com/kerbal/42724", System.UriKind.Absolute)
        '
        'DownloadButton
        '
        Me.DownloadButton.Location = New System.Drawing.Point(693, 507)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(124, 30)
        Me.DownloadButton.TabIndex = 1
        Me.DownloadButton.Text = "다운로드 및 설치"
        Me.DownloadButton.UseSelectable = True
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Location = New System.Drawing.Point(23, 507)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.Size = New System.Drawing.Size(664, 30)
        Me.MetroProgressBar1.TabIndex = 2
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(757, 37)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(60, 20)
        Me.HomeButton.TabIndex = 3
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseCustomBackColor = True
        Me.HomeButton.UseSelectable = True
        '
        'Wiki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 560)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.MetroProgressBar1)
        Me.Controls.Add(Me.DownloadButton)
        Me.Controls.Add(Me.WikiBrowser)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Wiki"
        Me.Resizable = False
        Me.Text = "Wiki Server"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WikiBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents DownloadButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroProgressBar1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents HomeButton As MetroFramework.Controls.MetroButton
End Class
