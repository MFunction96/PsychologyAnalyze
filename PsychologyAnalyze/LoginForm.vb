Public Class LoginForm

    Public h As Double
    Public w As Double
    Public s As Integer
    Public a As Integer
    Public index As Integer = 0

    Private Sub StartTest_Click(sender As Object, e As EventArgs) Handles StartTest.Click
        Dim f As Form
        Dim ini As New AccessIni
        Const m As String = "我们将要进行一个分类实验，下面出现的词，如果你认为是消极的，请按"“F"”；如果你认为是中性的，请按"“H"”；如果你认为是积极的，请按"“J"”。" + Chr(10) _
            + "注意：" + Chr(10) + "第一，答案没有对错之分，仅指词对你自己的意义而言，包括词的象征含义在内。" + Chr(10) _
            + "第二刺激呈现的时间很短，请尽快做出反应。"
        Dim msg As MsgBoxResult = vbCancel
        f = MainForm
        If Height.Text <> vbNullString And Weight.Text <> vbNullString And Age.Text <> vbNullString And Sex.Text <> vbNullString Then
            Hide()
            index += 1
            CountTip.Text = "第" + Str(index + 1) + "组测试："
            ini.WriteConfig(index, "Height", "Result.ini", Height.Text)
            ini.WriteConfig(index, "Sex", "Result.ini", Sex.Text)
            ini.WriteConfig(index, "Age", "Result.ini", Age.Text)
            ini.WriteConfig(index, "Weight", "Result.ini", Weight.Text)
            Height.Text = vbNullString
            Sex.Text = vbNullString
            Age.Text = vbNullString
            Weight.Text = vbNullString
            Do While msg = vbCancel
                msg = MsgBox(m, vbOKCancel + vbInformation, "实验指导")
            Loop
            MsgBox("我们先练习一下", vbOKOnly + vbInformation, "实验指导")
            f.Show()
        Else
            MsgBox("请填写完整信息！", vbCritical + vbOKOnly, "错误")
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountTip.Text = "第" + Str(index + 1) + "组测试："
    End Sub
End Class