Public Class MainForm

    Private po As Integer
    Private pu As Integer
    Private ne As Integer
    Private sum As Integer
    Private a As Integer
    Private vis(1000) As Boolean
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 3000
        Timer1.Start()
        Dim i As Integer
        Dim ini As New AccessIni
        po = ini.GetConfig("Sum", "Positive", "Config.ini")
        pu = ini.GetConfig("Sum", "Neuter", "Config.ini")
        ne = ini.GetConfig("Sum", "Negative", "Config.ini")
        sum = po + pu + ne
        For i = 0 To sum - 1 Step 1
            vis(i) = True
        Next
    End Sub

    Private Sub EndPro_Click(sender As Object, e As EventArgs) Handles EndPro.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Randomize()
        Dim r As Integer = Rnd()
        Do While vis(r) = False
            r = Rnd()
        Loop

    End Sub

    Private Sub Positive_Click(sender As Object, e As EventArgs) Handles Positive.Click
        Timer1.Stop()
        Timer1.Interval = 3000
        Timer1.Start()
    End Sub

    Private Sub Neuter_Click(sender As Object, e As EventArgs) Handles Neuter.Click
        Timer1.Stop()
        Timer1.Interval = 3000
        Timer1.Start()
    End Sub

    Private Sub Negative_Click(sender As Object, e As EventArgs) Handles Negative.Click
        Timer1.Stop()
        Timer1.Interval = 3000
        Timer1.Start()
    End Sub
End Class
