Public Class MainForm

    Private Const s As Integer = 2000

    Private ini As New AccessIni
    Private n(10) As Integer
    Private sum As Integer = 0
    Private a As Integer
    Private flag As Boolean = False
    Private vis(1000) As Boolean
    Private r As Integer
    Private i As Integer
    Private av(10) As Integer
    Private str As String
    Private endt As Date
    Private start As Date
    Private c As Integer = 0

    Private Sub AnalyzeIndex(
                ByRef r As Integer,
                ByRef i As Integer)

        For i = 1 To 7 Step 1
            If r > n(i) Then
                r -= n(i)
            Else
                Exit For
            End If
        Next

    End Sub

    Private Function GetRnd() As Integer
        Randomize()
        r = Fix(Rnd() * sum + 1)
        Do While vis(r) = False
            Randomize()
            r = Fix(Rnd() * sum + 1)
        Loop
        a += 1
        vis(r) = False
        Return r
    End Function

    Private Sub Count()
        Dim a1 As TimeSpan
        Dim f As New Form
        Dim a2 As Long
        Timer1.Stop()
        Timer1.Interval = s
        endt = Now()
        a1 = endt - start
        a2 = a1.TotalMilliseconds
        If flag Then
            av(i) += a2
            ini.WriteConfig(LoginForm.index, str, "Result.ini", a2)
        End If
        f = LoginForm
        If a = sum Then
            Timer1.Enabled = False
            For i = 1 To 7 Step 1
                av(i) /= n(i)
                ini.WriteConfig(LoginForm.index, i, "Result.ini", av(i))
            Next
            MsgBox("感谢您的参与，测试结束！", vbOKOnly, "实验指导")
            f.Show()
            Close()
            Exit Sub
        End If
        If flag Then
            r = GetRnd()
        Else
            Randomize()
            r = Fix(Rnd() * sum + 1)
        End If
        AnalyzeIndex(r, i)
        If flag Then
            str = ini.GetConfig(i, r, "Test.ini")
        Else
            str = ini.GetConfig(i, r, "Practise.ini")
        End If
        ShowTip.Text = str
        start = Now()
        Timer1.Start()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ini As New AccessIni
        sum = 0
        a = 0
        For i = 1 To 7 Step 1
            If flag Then
                n(i) = ini.GetConfig("Sum", i, "Test.ini")
            Else
                n(i) = ini.GetConfig("Sum", i, "Practise.ini")
            End If
            sum += n(i)
            av(i) = 0
        Next
        If flag Then
            r = GetRnd()
        Else
            Randomize()
            r = Fix(Rnd() * sum + 1)
        End If
        AnalyzeIndex(r, i)
        If flag Then
            str = ini.GetConfig(i, r, "Test.ini")
        Else
            str = ini.GetConfig(i, r, "Practise.ini")
        End If
        ShowTip.Text = str
        Timer1.Interval = s
        start = Now()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ShowTip.Text = vbNullString
    End Sub

    Private Sub Positive_Click(sender As Object, e As EventArgs) Handles Positive.Click
        If Timer2.Enabled = False Then
            Count()
        End If
    End Sub

    Private Sub Neuter_Click(sender As Object, e As EventArgs) Handles Neuter.Click
        If Timer2.Enabled = False Then
            Count()
        End If
    End Sub

    Private Sub Negative_Click(sender As Object, e As EventArgs) Handles Negative.Click
        If Timer2.Enabled = False Then
            Count()
        End If
    End Sub

    Private Sub Test_Click(sender As Object, e As EventArgs) Handles Test.Click
        Dim msg As MsgBoxResult
        msg = MsgBox("您是否已经完全熟悉测试？" + Chr(10) + "一秒后开始测试", vbInformation + vbYesNo, "熟悉环境")
        If msg = vbYes Then
            flag = True
            Test.Enabled = False
            Test.Visible = False
            Timer1.Stop()
            ShowTip.Text = "请注意！"
            Timer2.Interval = 1000
            Timer2.Enabled = True
            sum = 0
            a = 0
            For i = 1 To 7 Step 1
                n(i) = ini.GetConfig("Sum", i, "Test.ini")
                sum += n(i)
                av(i) = 0
            Next
            For i = 1 To sum Step 1
                vis(i) = True
            Next
            Timer2.Start()
        End If
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.K Then
            Call Positive.PerformClick()
        ElseIf e.KeyValue = Keys.J Then
            Call Neuter.PerformClick()
        ElseIf e.KeyValue = Keys.F Then
            Call Negative.PerformClick()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If c = 0 Then
            ShowTip.Text = "+"
            c += 1
        ElseIf c = 2 Then
            Randomize()
            r = Fix(Rnd() * sum + 1)
            AnalyzeIndex(r, i)
            If flag Then
                str = ini.GetConfig(i, r, "Test.ini")
            Else
                str = ini.GetConfig(i, r, "Practise.ini")
            End If
            ShowTip.Text = str
            Timer1.Stop()
            Timer1.Interval = s
            start = Now()
            Timer2.Stop()
            Timer2.Enabled = False
            Timer1.Start()
        Else
            ShowTip.Text = vbNullString
            c += 1
        End If

    End Sub
End Class
