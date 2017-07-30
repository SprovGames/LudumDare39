Public Class MainMenu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.PlayGame, AudioPlayMode.WaitToComplete)

        Form1.Show()

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.Black
        Label1.Show()



        My.Computer.Audio.Play(My.Resources.Buttonselect, AudioPlayMode.Background)

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.WhiteSmoke
        Label1.Hide()
        My.Computer.Audio.Play(My.Resources.LD39muziek, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.LD39muziek, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.ForeColor = Color.Black
        My.Computer.Audio.Play(My.Resources.Buttonselect, AudioPlayMode.Background)

    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.WhiteSmoke
        My.Computer.Audio.Play(My.Resources.LD39muziek, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Top -= 1
        If Label2.Location = New Point(24, 173) And Label1.Visible = False Then
            Label2.Top -= 1
        ElseIf Label2.Location = New Point(24, 173) And Label1.Visible = True Then
            Timer1.Stop()
            Timer2.Start()
        ElseIf Label2.Location = New Point(24, 27) Then
            Timer1.Stop()
            Timer2.Start()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Top += 1
        If Label2.Location = New Point(24, 311) Then
            Timer2.Stop()
            Timer1.Start()
        End If


    End Sub
End Class