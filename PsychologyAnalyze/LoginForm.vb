Public Class LoginForm

    Public h As Double
    Public w As Double
    Public s As Integer
    Public a As Integer
    Public index As Integer = 1

    Private Sub StartTest_Click(sender As Object, e As EventArgs) Handles StartTest.Click
        Dim f As New Form
        Dim ini As New AccessIni
        f = MainForm
        If Height.Text <> vbNullString And Weight.Text <> vbNullString And Age.Text <> vbNullString And Sex.Text <> vbNullString Then
            Hide()
            ini.WriteConfig(index, "Height", "Result.ini", Height.Text)
            ini.WriteConfig(index, "Sex", "Result.ini", Sex.Text)
            ini.WriteConfig(index, "Age", "Result.ini", Age.Text)
            ini.WriteConfig(index, "Weight", "Result.ini", Weight.Text)
            Height.Text = vbNullString
            Sex.Text = vbNullString
            Age.Text = vbNullString
            Weight.Text = vbNullString
            f.Show()
        Else
            MsgBox("请填写完整信息！", vbCritical + vbOKOnly, "错误")
        End If
    End Sub
End Class