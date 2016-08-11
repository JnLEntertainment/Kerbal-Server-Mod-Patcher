<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modern
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modern))
        Me.Wiki = New MetroFramework.Controls.MetroButton()
        Me.Tudy = New MetroFramework.Controls.MetroButton()
        Me.CW = New MetroFramework.Controls.MetroButton()
        Me.Result = New MetroFramework.Controls.MetroListView()
        Me.MainPictureBox = New System.Windows.Forms.PictureBox()
        Me.ConfirmButton = New MetroFramework.Controls.MetroButton()
        Me.BGM = New MetroFramework.Controls.MetroToggle()
        CType(Me.MainPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Wiki
        '
        Me.Wiki.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Wiki.Enabled = False
        Me.Wiki.ForeColor = System.Drawing.Color.White
        Me.Wiki.Location = New System.Drawing.Point(23, 247)
        Me.Wiki.Name = "Wiki"
        Me.Wiki.Size = New System.Drawing.Size(120, 30)
        Me.Wiki.TabIndex = 1
        Me.Wiki.Text = "Wiki Server"
        Me.Wiki.UseCustomBackColor = True
        Me.Wiki.UseCustomForeColor = True
        Me.Wiki.UseSelectable = True
        '
        'Tudy
        '
        Me.Tudy.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Tudy.Enabled = False
        Me.Tudy.ForeColor = System.Drawing.Color.White
        Me.Tudy.Location = New System.Drawing.Point(190, 247)
        Me.Tudy.Name = "Tudy"
        Me.Tudy.Size = New System.Drawing.Size(120, 30)
        Me.Tudy.TabIndex = 2
        Me.Tudy.Text = "Tudy Server"
        Me.Tudy.UseCustomBackColor = True
        Me.Tudy.UseCustomForeColor = True
        Me.Tudy.UseSelectable = True
        '
        'CW
        '
        Me.CW.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.CW.Enabled = False
        Me.CW.ForeColor = System.Drawing.Color.White
        Me.CW.Location = New System.Drawing.Point(357, 247)
        Me.CW.Name = "CW"
        Me.CW.Size = New System.Drawing.Size(120, 30)
        Me.CW.TabIndex = 3
        Me.CW.Text = "CW Server"
        Me.CW.UseCustomBackColor = True
        Me.CW.UseCustomForeColor = True
        Me.CW.UseSelectable = True
        '
        'Result
        '
        Me.Result.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Result.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Result.FullRowSelect = True
        Me.Result.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.Result.Location = New System.Drawing.Point(303, 84)
        Me.Result.Name = "Result"
        Me.Result.OwnerDraw = True
        Me.Result.Scrollable = False
        Me.Result.Size = New System.Drawing.Size(174, 157)
        Me.Result.TabIndex = 8
        Me.Result.UseCompatibleStateImageBehavior = False
        Me.Result.UseSelectable = True
        Me.Result.View = System.Windows.Forms.View.List
        '
        'MainPictureBox
        '
        Me.MainPictureBox.Image = Global.KSMP_Modern.My.Resources.Resources.kerbals_1920x1080
        Me.MainPictureBox.Location = New System.Drawing.Point(24, 63)
        Me.MainPictureBox.Name = "MainPictureBox"
        Me.MainPictureBox.Size = New System.Drawing.Size(273, 156)
        Me.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MainPictureBox.TabIndex = 1
        Me.MainPictureBox.TabStop = False
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(411, 63)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(66, 15)
        Me.ConfirmButton.TabIndex = 9
        Me.ConfirmButton.Text = "설치 확인"
        Me.ConfirmButton.UseSelectable = True
        '
        'BGM
        '
        Me.BGM.AutoSize = True
        Me.BGM.Location = New System.Drawing.Point(24, 225)
        Me.BGM.Name = "BGM"
        Me.BGM.Size = New System.Drawing.Size(80, 16)
        Me.BGM.Style = MetroFramework.MetroColorStyle.Lime
        Me.BGM.TabIndex = 10
        Me.BGM.Text = "Off"
        Me.BGM.UseSelectable = True
        '
        'Modern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.Controls.Add(Me.BGM)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.MainPictureBox)
        Me.Controls.Add(Me.CW)
        Me.Controls.Add(Me.Tudy)
        Me.Controls.Add(Me.Wiki)
        Me.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Modern"
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Kerbal Space Program Naver Café"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.MainPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Wiki As MetroFramework.Controls.MetroButton
    Friend WithEvents Tudy As MetroFramework.Controls.MetroButton
    Friend WithEvents CW As MetroFramework.Controls.MetroButton
    Friend WithEvents MainPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Result As MetroFramework.Controls.MetroListView
    Friend WithEvents ConfirmButton As MetroFramework.Controls.MetroButton
    Friend WithEvents BGM As MetroFramework.Controls.MetroToggle
End Class
