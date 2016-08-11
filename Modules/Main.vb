Imports System.IO

Module Main
    Sub confirm(c As Boolean)
        Dim se As Integer = steam_existence(True)
        Dim sl As String = library(True)
        Dim ke As Integer = ksp_existence(True)
        Dim kd As String = ksp_directory(True)
        Dim de As Integer = dmp_existence(True)
        Dim msg_confirm As String = "Kerbal Space Program Multi Server Mod Patcher (이하 KSPMSMP) 에 사용된 소스코드는 JL Entertainment (이하 제이앤엘) 의 저작물이며, 본 프로그램을 KSP 네이버 카페 이외의 사이트나 P2P 에 올리는 것을 금합니다." + Environment.NewLine + Environment.NewLine + "단, 본 패치기에서 다운로드하는 모드의 저작권은 해당 저작자의 소유이며, 제이엔엘 엔터테인먼트는 절대적으로 관여하지 않습니다." + Environment.NewLine + Environment.NewLine + "설치를 진행하시겠습니까?"
        Dim msg_confirm_title As String = "Declaration"
        Dim list_se As String = "스팀이 설치되어 있습니다"
        Dim list_ke As String = "KSP 가 설치되어 있습니다"
        Dim list_de As String = "DMP 가 설치되어 있습니다"
        Dim list_se_no As String = "스팀이 설치되어 있지 않습니다"
        Dim list_ke_no As String = "KSP 가 설치되어 있지 않습니다"
        Dim list_de_no As String = "DMP 가 설치되어 있지 않습니다"
        Dim list_bar As String = "=============================="
        Dim list_able As String = "설치를 진행할 수 있습니다"
        Dim list_unable As String = "설치를 진행할 수 없습니다"
        Dim list_dmp As String = "DMP 를 추가적으로 설치합니다"

        Modern.Result.Items.Clear()

        Select Case MsgBox(msg_confirm, MsgBoxStyle.YesNo, msg_confirm_title)
            Case MsgBoxResult.Yes
                If se = 1 And ke = 1 And de = 1 Then
                    Modern.Result.Items.Add(list_se)
                    Modern.Result.Items.Add(list_ke)
                    Modern.Result.Items.Add(list_de)
                    Modern.Result.Items.Add(list_bar)
                    Modern.Result.Items.Add(list_able)
                    Button_Enable(True)
                ElseIf se = 1 And ke = 1 And de = 0 Then
                    Modern.Result.Items.Add(list_se)
                    Modern.Result.Items.Add(list_ke)
                    Modern.Result.Items.Add(list_de_no)
                    Modern.Result.Items.Add(list_bar)
                    Modern.Result.Items.Add(list_able)
                    Modern.Result.Items.Add(list_dmp)
                    Button_Enable(True)
                ElseIf se = 1 And ke = 0 Then
                    Modern.Result.Items.Add(list_se)
                    Modern.Result.Items.Add(list_ke_no)
                    Modern.Result.Items.Add(list_bar)
                    Modern.Result.Items.Add(list_unable)
                ElseIf se = 0 Then
                    Modern.Result.Items.Add(list_se_no)
                    Modern.Result.Items.Add(list_bar)
                    Modern.Result.Items.Add(list_unable)
                End If
            Case MsgBoxResult.No Or MsgBoxResult.Cancel
                Button_Disable(True)
        End Select
    End Sub
End Module
