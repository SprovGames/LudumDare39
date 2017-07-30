Public Class Form1
    Private Sub TimBattery1_Tick(sender As Object, e As EventArgs) Handles TimBattery1.Tick
        Battery1.Increment(1)
        Label4.Text = Battery1.Value
        If Battery1.Value = 100 Then
            TimBattery1.Stop()
            Label3.Show()
            TimBattery1Destroy.Start()
        End If
    End Sub

    Private Sub TimBattery1Destroy_Tick(sender As Object, e As EventArgs) Handles TimBattery1Destroy.Tick
        Label3.Text -= 1
        If Label3.Text = 0 Then
            TimBattery1Destroy.Stop()
            Battery1.Dispose()
            Label3.Dispose()
            Label2.Dispose()
            My.Computer.Audio.Play(My.Resources.Dead, AudioPlayMode.Background)
            MessageBox.Show("game over, too much power in battery!", "Game Over")


            Me.Close()
            MainMenu.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.Battery, AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(My.Resources.charge, AudioPlayMode.Background)

        TimBattery1Destroy.Stop()
        Label3.Text = 5
        If Battery1.Value + MachinePower.Value > 100 Then
            My.Computer.Audio.Play(My.Resources.Dead, AudioPlayMode.Background)
            MessageBox.Show("Game over, too much power in battery!", "Game Over")
            Me.Close()
            MainMenu.Show()
        Else
            MachinePower.Value += Battery1.Value
            Battery1.Value = 0
        End If
        TimBattery1.Interval += 100
    End Sub

    Private Sub TimMachinePower_Tick(sender As Object, e As EventArgs) Handles TimMachinePower.Tick
        MachinePower.Increment(-1)
        Label5.Text = MachinePower.Value
        If MachinePower.Value < 40 Then
            TimMachinePower.Interval = 400
        Else
            TimMachinePower.Interval = 500
        End If
        If MachinePower.Value = 0 Then
            TimMachinePower.Stop()
            My.Computer.Audio.Play(My.Resources.Dead, AudioPlayMode.Background)
            MessageBox.Show("game over, no power left!", "Game Over")
            Me.Close()
            MainMenu.Show()
        End If
    End Sub

    Private Sub TimBattery2_Tick(sender As Object, e As EventArgs) Handles TimBattery2.Tick
        Battery2.Increment(1)
        Label6.Text = Battery2.Value
        If Battery2.Value = 100 Then
            TimBattery2.Stop()
            Label7.Show()
            TimBattery2Destroy.Start()
        End If
    End Sub

    Private Sub TimBattery2Destroy_Tick(sender As Object, e As EventArgs) Handles TimBattery2Destroy.Tick
        Label7.Text -= 1
        If Label7.Text = 0 Then
            TimBattery2Destroy.Stop()
            Battery2.Dispose()
            Label7.Dispose()
            Label6.Dispose()
            My.Computer.Audio.Play(My.Resources.Dead, AudioPlayMode.Background)
            MessageBox.Show("Game over, too much power in battery!", "Game Over")
            Me.Close()
            MainMenu.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.Battery, AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(My.Resources.charge, AudioPlayMode.Background)

        TimBattery2Destroy.Stop()
        Label7.Text = 5
        If Battery2.Value + MachinePower.Value > 100 Then
            My.Computer.Audio.Play(My.Resources.Dead, AudioPlayMode.Background)
            MessageBox.Show("Game over, too much power", "Game Over")
            Me.Close()
            MainMenu.Show()
        Else
            MachinePower.Value += Battery2.Value
            Battery2.Value = 0
        End If
        TimBattery2.Interval += 100
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text += 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.bonusclick, AudioPlayMode.Background)

        Label11.Text += 1
        If Label11.Text = 20 Then
            My.Computer.Audio.Play(My.Resources.Bonus7, AudioPlayMode.Background)

            Label11.Text = 0
            Label12.Text = "10% battery added to machine!"
            If MachinePower.Value > 90 Then
                MachinePower.Value = 100
            Else
                MachinePower.Value += 10

            End If
            Button3.Enabled = False
            Timwait.Start()
        End If
    End Sub

    Private Sub Timwait_Tick(sender As Object, e As EventArgs) Handles Timwait.Tick
        ProgressBar1.Increment(-1)
        If ProgressBar1.Value = 0 Then
            Timwait.Stop()
            Button3.Enabled = True
            ProgressBar1.Value = 100
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Audio.Play(My.Resources._exit, AudioPlayMode.Background)

        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = "Pause" Then
            My.Computer.Audio.Play(My.Resources.pause, AudioPlayMode.Background)
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False

            TimBattery1.Stop()
            TimBattery1Destroy.Stop()
            TimBattery2.Stop()
            TimBattery2Destroy.Stop()
            TimMachinePower.Stop()
            Timwait.Stop()
            Timer1.Stop()
            Button5.Text = "Play"
        Else
            My.Computer.Audio.Play(My.Resources.playpause, AudioPlayMode.WaitToComplete)
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            TimBattery1.Start()
            TimBattery1Destroy.Start()
            TimBattery2.Start()
            TimBattery2Destroy.Start()
            TimMachinePower.Start()
            Timwait.Start()
            Timer1.Start()
            Button5.Text = "Pause"

        End If
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter, Button4.MouseEnter, Button3.MouseEnter, Button2.MouseEnter, Button1.MouseEnter
        My.Computer.Audio.Play(My.Resources.Buttonselect, AudioPlayMode.Background)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class
