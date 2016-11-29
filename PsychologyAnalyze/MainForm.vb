Public Class MainForm

    Private Const s As Integer = 2000

    Private ini As New AccessIni
    Private n(7) As Integer
    Private sum As Integer = 0
    Private a As Integer = 1
    Private vis(1000) As Boolean
    Private r As Integer
    Private i As Integer
    Private endt As Date
    Private start As Date

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
        r = Rnd() * sum + 1
        Do While vis(r) = False
            Randomize()
            r = Rnd() * sum + 1
        Loop
        vis(r) = False
        Return r
    End Function

    Private Sub Count()
        Dim a1 As TimeSpan
        Dim f As New Form
        Dim a2 As Long
        Timer1.Stop()
        Timer1.Interval = s
        a += 1
        endt = Now()
        a1 = endt - start
        a2 = a1.TotalMilliseconds
        ini.WriteConfig(LoginForm.index, ShowTip.Text, "Result.ini", a2)
        f = LoginForm
        If a = sum Then
            f.Activate()
            Close()
        End If
        r = GetRnd()
        AnalyzeIndex(r, i)
        ShowTip.Text = ini.GetConfig(i, r, "Config.ini")
        start = Now()
        Timer1.Start()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ini As New AccessIni
        For i = 1 To 7 Step 1
            n(i) = ini.GetConfig("Sum", i, "Config.ini")
            sum += n(i)
        Next
        For i = 1 To sum Step 1
            vis(i) = True
        Next
        r = GetRnd()
        AnalyzeIndex(r, i)
        vis(r) = False
        a += 1
        ShowTip.Text = ini.GetConfig(i, r, "Config.ini")
        Timer1.Interval = s
        start = Now()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim f As New Form
        f = LoginForm
        Timer1.Stop()
        ini.WriteConfig(LoginForm.index, ShowTip.Text, "Result.ini", s)
        If a = sum Then
            f.Activate()
            Close()
        End If
        r = GetRnd()
        a += 1
        AnalyzeIndex(r, i)
        ShowTip.Text = ini.GetConfig(i, r, "Config.ini")
        start = Now()
        Timer1.Start()
    End Sub

    Private Sub Positive_Click(sender As Object, e As EventArgs) Handles Positive.Click
        Count()
    End Sub

    Private Sub Neuter_Click(sender As Object, e As EventArgs) Handles Neuter.Click
        Count()
    End Sub

    Private Sub Negative_Click(sender As Object, e As EventArgs) Handles Negative.Click
        Count()
    End Sub

End Class
