Public Class Time
    Private TargetDT As DateTime
    Private started As Boolean = False
    Private CountDownFrom As TimeSpan = TimeSpan.FromMinutes(25)
    Private remainingTime As TimeSpan
    Private paused As Boolean
    Private Cvalue As Integer

    Private Sub Time_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pause2.Visible = False
        Timer1.Interval = 100
        GunaCircleProgressBar1.Value = 20

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        GunaCircleProgressBar1.Increment(1)
        If ts.TotalMilliseconds > 0 Then
            Label1.Text = ts.ToString("mm\:ss")
        Else
            Label1.Text = "00:00"
            Timer1.Stop()
            MessageBox.Show("Done")

        End If
    End Sub

    Private Sub Start2_Click(sender As Object, e As EventArgs) Handles Start2.Click
        Timer1.Start()
        Timer1.Enabled = True
        Start2.Visible = False
        Pause2.Visible = True
        If Not started Then
            GunaCircleProgressBar1.Value += 1
            TargetDT = DateTime.Now.Add(CountDownFrom)
            started = True
        End If
        If paused Then
            TargetDT = DateTime.Now.Add(remainingTime)
            paused = Not paused
        End If
    End Sub

    Private Sub Pause2_Click(sender As Object, e As EventArgs) Handles Pause2.Click
        Timer1.Stop()
        Timer1.Enabled = False
        Pause2.Visible = False
        Start2.Visible = True
        paused = True
        remainingTime = TargetDT.Subtract(DateTime.Now)
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Timer1.Stop()
        Label1.Text = "25:00"
        GunaCircleProgressBar1.Value = 0
        started = False
        paused = False
        Pause2.Visible = False
        Start2.Visible = True
    End Sub
End Class