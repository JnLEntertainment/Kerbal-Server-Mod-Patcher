<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debugging
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
        Me.EncryptTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.EncryptButton = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'EncryptTextBox
        '
        '
        '
        '
        Me.EncryptTextBox.CustomButton.Image = Nothing
        Me.EncryptTextBox.CustomButton.Location = New System.Drawing.Point(238, 1)
        Me.EncryptTextBox.CustomButton.Name = ""
        Me.EncryptTextBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.EncryptTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.EncryptTextBox.CustomButton.TabIndex = 1
        Me.EncryptTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.EncryptTextBox.CustomButton.UseSelectable = True
        Me.EncryptTextBox.CustomButton.Visible = False
        Me.EncryptTextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.EncryptTextBox.Lines = New String() {"SHA256 Encrypted Code"}
        Me.EncryptTextBox.Location = New System.Drawing.Point(20, 60)
        Me.EncryptTextBox.MaxLength = 32767
        Me.EncryptTextBox.Name = "EncryptTextBox"
        Me.EncryptTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EncryptTextBox.ReadOnly = True
        Me.EncryptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EncryptTextBox.SelectedText = ""
        Me.EncryptTextBox.SelectionLength = 0
        Me.EncryptTextBox.SelectionStart = 0
        Me.EncryptTextBox.ShortcutsEnabled = True
        Me.EncryptTextBox.Size = New System.Drawing.Size(260, 23)
        Me.EncryptTextBox.TabIndex = 1
        Me.EncryptTextBox.Text = "SHA256 Encrypted Code"
        Me.EncryptTextBox.UseSelectable = True
        Me.EncryptTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.EncryptTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'EncryptButton
        '
        Me.EncryptButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EncryptButton.Location = New System.Drawing.Point(20, 97)
        Me.EncryptButton.Name = "EncryptButton"
        Me.EncryptButton.Size = New System.Drawing.Size(260, 23)
        Me.EncryptButton.TabIndex = 0
        Me.EncryptButton.Text = "SHA256 Encrypt"
        Me.EncryptButton.UseSelectable = True
        '
        'Debugging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 140)
        Me.Controls.Add(Me.EncryptButton)
        Me.Controls.Add(Me.EncryptTextBox)
        Me.Name = "Debugging"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Debugging"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EncryptTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents EncryptButton As MetroFramework.Controls.MetroButton
End Class
