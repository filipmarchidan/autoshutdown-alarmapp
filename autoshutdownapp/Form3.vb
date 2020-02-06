Public Class Form3

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        Timer1.Start()
        countersong.Text = countersong.Text - 1
        If countersong.Text = 0 Then
            My.Computer.Audio.Stop()
            Timer1.Stop()
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub shutdownoptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shutdownoptions.Click
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.fullsong.Enabled = False Then


            If Form1.songselector.SelectedItem = Nothing Then
                My.Computer.Audio.Play(Form1.OpenFileDialog1.FileName)

            Else
                If Form1.songselector.Text = "Ak47" Then
                    My.Computer.Audio.Play(My.Resources.ak47, AudioPlayMode.Background)
                ElseIf Form1.songselector.Text = "Barking Dog" Then
                    My.Computer.Audio.Play(My.Resources.dog, AudioPlayMode.Background)
                ElseIf Form1.songselector.Text = "Digital Insanity" Then
                    My.Computer.Audio.Play(My.Resources.digitalinsanity, AudioPlayMode.Background)
                ElseIf Form1.songselector.Text = "Small Trap" Then
                    My.Computer.Audio.Play(My.Resources.smalltrap, AudioPlayMode.Background)
                ElseIf Form1.songselector.Text = "Little Drums" Then
                    My.Computer.Audio.Play(My.Resources.littledrums, AudioPlayMode.Background)
                ElseIf Form1.songselector.Text = "Gunshot" Then
                    My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
                ElseIf Form1.songselector.Text = "Beep" Then
                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                ElseIf Form1.songselector.Text = "Loud Rocket" Then
                    My.Computer.Audio.Play(My.Resources.loud, AudioPlayMode.Background)
                End If
            End If
        ElseIf Form1.loopsong.Enabled = False Then

            If Form1.songselector.SelectedItem = Nothing Then
                My.Computer.Audio.Play(Form1.OpenFileDialog1.FileName)

            Else
                If Form1.songselector.Text = "Ak47" Then
                    My.Computer.Audio.Play(My.Resources.ak47, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Barking Dog" Then
                    My.Computer.Audio.Play(My.Resources.dog, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Digital Insanity" Then
                    My.Computer.Audio.Play(My.Resources.digitalinsanity, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Small Trap" Then
                    My.Computer.Audio.Play(My.Resources.smalltrap, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Little Drums" Then
                    My.Computer.Audio.Play(My.Resources.littledrums, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Gunshot" Then
                    My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Beep" Then
                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Loud Rocket" Then
                    My.Computer.Audio.Play(My.Resources.loud, AudioPlayMode.BackgroundLoop)
                End If
            End If
        ElseIf Form1.minsong.Enabled = False Then
            Timer1.Start()
            countersong.Visible = True
            If Form1.songselector.SelectedItem = Nothing Then
                My.Computer.Audio.Play(Form1.OpenFileDialog1.FileName)

            Else
                If Form1.songselector.Text = "Ak47" Then
                    My.Computer.Audio.Play(My.Resources.ak47, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Barking Dog" Then
                    My.Computer.Audio.Play(My.Resources.dog, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Digital Insanity" Then
                    My.Computer.Audio.Play(My.Resources.digitalinsanity, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Small Trap" Then
                    My.Computer.Audio.Play(My.Resources.smalltrap, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Little Drums" Then
                    My.Computer.Audio.Play(My.Resources.littledrums, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Gunshot" Then
                    My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Beep" Then
                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.BackgroundLoop)
                ElseIf Form1.songselector.Text = "Loud Rocket" Then
                    My.Computer.Audio.Play(My.Resources.loud, AudioPlayMode.BackgroundLoop)
                End If
            End If
        End If
    End Sub

    Private Sub countersong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countersong.Click

    End Sub
End Class