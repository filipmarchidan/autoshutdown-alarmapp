Public Class Form1
    Dim rest As New TextBox
    Dim intreg As New TextBox
    Private Declare Function InvalidateRect Lib "user32" (ByVal hwnd As IntPtr, ByVal lpRect As IntPtr, ByVal bErase As Boolean) As Boolean
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Dim SetTime As Integer
    Dim Loc As New Point(0, 0)
    Dim Cur As New Point(0, 0)
    Private Sub ConfigSize()
        Loc = Location
        Cur = Cursor.Position

    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Location = Loc - Cur + Cursor.Position
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        Timer1.Stop()
        ConfigSize()
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        Timer1.Start()
        Timer1.Enabled = True
        ConfigSize()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label6.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If (TextBox1.Visible = False) Then
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Timer2.Start()
            TextBox1.Visible = True
            ComboBox1.Visible = True
        Else
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            TextBox1.Visible = False
            ComboBox1.Visible = False
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fps1.Start()

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shutdownb.Click
        Dim fask As MsgBoxResult
        Dim cn As Integer
        s.Enabled = False
        If TextBox1.Visible = True And ComboBox1.Visible = True Then

        End If

        If TextBox1.Visible = False And TextBox1.Visible = False Then
            fask = MsgBox("Are you sure ? (No timer has been selected)", MsgBoxStyle.YesNo)
            If (fask = MsgBoxResult.Yes) Then
                Shell("shutdown -s")
            End If
        Else
            If TextBox1.Text = Nothing Then
                fask = MsgBox("Please introduce a value for the timer", MsgBoxStyle.Critical)
            End If
            If ComboBox1.Text = Nothing Then
                fask = MsgBox("You haven't selected any numeric instrument" + Environment.NewLine + "Please select something from the dropdown list", MsgBoxStyle.Critical, )
            End If
            If TextBox1.Text = Nothing Or ComboBox1.Text = Nothing Then
            Else
                fask = MsgBox("Are you sure ? The timer has been set to " + TextBox1.Text + " " + ComboBox1.Text, MsgBoxStyle.YesNo)
                If (fask = MsgBoxResult.Yes) Then
                    Canceltimer.Visible = True
                    Pause.Visible = True
                    Timer3.Start()
                    Timer3.Enabled = True
                    fortime.Visible = True
                    timeremaining.Visible = True
                    OptimizeSpeedToolStripMenuItem.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer3.Start()
        Timer3.Enabled = True
        TextBox1.Enabled = False
        ComboBox1.Enabled = False
       
        If ComboBox1.Text = "Seconds" Then
            TextBox1.Text = TextBox1.Text - 1
            timeremaining.Text = "00:00:" & TextBox1.Text
            If TextBox1.Text = 0 Then
                If Shutdownb.Visible = True Then
                    If s.Enabled = False Then
                        Shell("shutdown -s")
                    ElseIf r.Enabled = False Then
                        Shell("shutdown -r")
                    ElseIf l.Enabled = False Then
                        Shell("shutdown -l")
                    End If
                  
                End If
                If playing1min.Visible = True Then
                    If minsong.Enabled = False Then
                        Form3.Timer1.Start()
                        Form3.Timer1.Enabled = True
                        Form3.Show()
                    ElseIf fullsong.Enabled = False Then
                        Form3.Show()
                    ElseIf loopsong.Enabled = False Then
                        Form3.Show()
                    End If
                End If
                Timer3.Stop()
                TextBox1.Enabled = True
                ComboBox1.Enabled = True
            End If
        ElseIf ComboBox1.Text = "Minutes" Then
            Sec.Text = Sec.Text - 1
            timeremaining.Text = "00:" & TextBox1.Text & ":" & Sec.Text
            If Sec.Text = 0 Then
                TextBox1.Text = TextBox1.Text - 1
                Sec.Text = 60
                If TextBox1.Text = 0 Then
                    timeremaining.Text = "00:00:" & Sec.Text
                End If
                If timeremaining.Text = "00:00:00" Then
                    If Shutdownb.Visible = True Then
                        If s.Enabled = False Then
                            Shell("shutdown -s")
                        ElseIf r.Enabled = False Then
                            Shell("shutdown -r")
                        ElseIf l.Enabled = False Then
                            Shell("shutdown -l")
                        End If

                    End If
                    If playing1min.Visible = True Then
                        If minsong.Enabled = False Then
                            Form3.Timer1.Start()
                            Form3.Timer1.Enabled = True
                            Form3.Show()
                        ElseIf fullsong.Enabled = False Then
                            Form3.Show()
                        ElseIf loopsong.Enabled = False Then
                            Form3.Show()
                        End If
                    End If
                    Timer3.Stop()
                    TextBox1.Enabled = True
                    ComboBox1.Enabled = True
                    OptionsToolStripMenuItem.Enabled = False
                End If
            End If
          
        ElseIf ComboBox1.Text = "Hours" Then
            Sec.Text = Sec.Text - 1
            If Sec.Text = 0 Then
                Min.Text = Min.Text - 1
                Sec.Text = 60
                If Min.Text = 0 Then
                    Min.Text = 59
                    Sec.Text = 60
                    TextBox1.Text = TextBox1.Text - 1
                    timeremaining.Text = TextBox1.Text & ":" & Min.Text & ":" & Sec.Text
                    If timeremaining.Text = "00:00:00" Or timeremaining.Text = "0:00:00" Or timeremaining.Text = "0:0:00" Or timeremaining.Text = "00:0:00" Then
                        If Shutdownb.Visible = True Then
                            If s.Enabled = False Then
                                Shell("shutdown -s")
                            ElseIf r.Enabled = False Then
                                Shell("shutdown -r")
                            ElseIf l.Enabled = False Then
                                Shell("shutdown -l")
                            End If

                        End If
                        If playing1min.Visible = True Then
                            If minsong.Enabled = False Then
                                Form3.Timer1.Start()
                                Form3.Timer1.Enabled = True
                                Form3.Show()
                            ElseIf fullsong.Enabled = False Then
                                Form3.Show()
                            ElseIf loopsong.Enabled = False Then
                                Form3.Show()
                            End If
                        End If
                        Timer3.Stop()
                        TextBox1.Enabled = True
                        ComboBox1.Enabled = True
                    End If
                End If
            End If
            
        End If
    End Sub
    Private Sub timeremaining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeremaining.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Seconds" Then
            Label4.Text = "Set your timer (sec) :"
        ElseIf ComboBox1.Text = "Minutes" Then
            Label4.Text = "Set your timer (min) :"
        ElseIf ComboBox1.Text = "Hours" Then
            Label4.Text = "Set your timer (hours) :"
        End If

    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        
        '  If ComboBox1.Text = "Seconds" Then
        'If TextBox1.Text > 3600 Then
        'ComboBox1.Text = "Hours"
        ' TextBox1.Text = TextBox1.Text Mod 3600
        ' ElseIf TextBox1.Text > 60 Then
        ' intreg.Text = TextBox1.Text \ 60
        ' rest.Text = TextBox1.Text Mod 60
        'TextBox1.Text = intreg.Text
        ' extratime.Text = "and " & rest.Text & " sec"
        '  ComboBox1.Text = "Minutes"
        '  Else
        ' extratime.Text = ""
        '  End If
        ' ElseIf ComboBox1.Text = "Minutes" Then
        '     If TextBox1.Text > 60 Then
        'ComboBox1.Text = "Hours"
        '   intreg.Text = TextBox1.Text \ 60
        '  rest.Text = TextBox1.Text Mod 60
        '   TextBox1.Text = intreg.Text
        '  extratime.Text = "and " & rest.Text & " min"
        ' Else
        '  extratime.Text = ""
        'End If
        '

    End Sub

    Private Sub Canceltimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Canceltimer.Click
        Dim fask As New MsgBoxResult
        fask = MsgBox("Are you sure you want to cancel this timer ?", MsgBoxStyle.YesNo)
        If (fask = MsgBoxResult.Yes) Then
            resettimerval()
            OptimizeSpeedToolStripMenuItem.Enabled = False
        End If

    End Sub
    Public Sub resettimerval()
        TextBox1.Text = Nothing
        Timer3.Stop()
        Timer3.Enabled = False
        TextBox1.Enabled = True
        ComboBox1.Enabled = True
        timeremaining.Text = "00:00:00"
        ComboBox1.SelectedText = Nothing
    End Sub

    Private Sub Pause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pause.Click
        If Timer3.Enabled = True Then
            Pause.Text = "Resume"
            Timer3.Stop()
            Timer3.Enabled = False
        Else
            Pause.Text = "Pause"
            Timer3.Start()
            Timer3.Enabled = True
        End If
    End Sub

    Private Sub fps1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fps1.Tick
        If GetTickCount() - FPS_LastCheck >= 1000 Then
            FPS_Current = FPS_Count
            FPS_Count = 0 ' set the counter
            FPS_LastCheck = GetTickCount()

            ' highest FPS
            If FPS_Current > FPS_Highest Then
                FPS_Highest = FPS_Current
            End If
        End If

        FPS_Count = FPS_Count + 1
        fps.Text = FPS_Current
        Update()
    End Sub

    Private Sub ShowFPSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowFPSToolStripMenuItem.Click
        If (fps.Visible = False) Then
            fps1.Start()
            fps1.Enabled = True
            fps.Visible = True
        Else
            fps.Visible = False
        End If
    End Sub

    Private Sub X2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer3.Interval = Timer3.Interval / 1.5
    End Sub

    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer3.Interval = 1000
    End Sub

    Private Sub X40ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer3.Interval = Timer3.Interval / 4
    End Sub

    Private Sub X20ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer3.Interval = Timer3.Interval / 2
    End Sub

    Private Sub OptimizeSpeedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptimizeSpeedToolStripMenuItem.Click
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        MessageBox.Show("Some options may become available only when the timer is activated or within the process", "Why are some options locked", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Restartb.Click
        r.Enabled = False
        Dim fask As MsgBoxResult
        If TextBox1.Visible = True And ComboBox1.Visible = True Then

        End If

        If TextBox1.Visible = False And TextBox1.Visible = False Then
            fask = MsgBox("Are you sure ? (No timer has been selected)", MsgBoxStyle.YesNo)
            If (fask = MsgBoxResult.Yes) Then
                Shell("shutdown -r")
            End If
        Else
            If TextBox1.Text = Nothing Then
                fask = MsgBox("Please introduce a value for the timer", MsgBoxStyle.Critical)
            End If
            If ComboBox1.Text = Nothing Then
                fask = MsgBox("You haven't selected any numeric instrument" + Environment.NewLine + "Please select something from the dropdown list", MsgBoxStyle.Critical, )
            End If
            If TextBox1.Text = Nothing Or ComboBox1.Text = Nothing Then
            Else
                fask = MsgBox("Are you sure ? The timer has been set to " + TextBox1.Text + " " + ComboBox1.Text, MsgBoxStyle.YesNo)
                If (fask = MsgBoxResult.Yes) Then
                    Canceltimer.Visible = True
                    Pause.Visible = True
                    Timer3.Start()
                    Timer3.Enabled = True
                    fortime.Visible = True
                    timeremaining.Visible = True
                    OptimizeSpeedToolStripMenuItem.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffb.Click
        Dim fask As MsgBoxResult
        l.Enabled = False
        If TextBox1.Visible = True And ComboBox1.Visible = True Then

        End If

        If TextBox1.Visible = False And TextBox1.Visible = False Then
            fask = MsgBox("Are you sure ? (No timer has been selected)", MsgBoxStyle.YesNo)
            If (fask = MsgBoxResult.Yes) Then
                Shell("shutdown -l")
            End If
        Else
            If TextBox1.Text = Nothing Then
                fask = MsgBox("Please introduce a value for the timer", MsgBoxStyle.Critical)
            End If
            If ComboBox1.Text = Nothing Then
                fask = MsgBox("You haven't selected any numeric instrument" + Environment.NewLine + "Please select something from the dropdown list", MsgBoxStyle.Critical, )
            End If
            If TextBox1.Text = Nothing Or ComboBox1.Text = Nothing Then
            Else
                fask = MsgBox("Are you sure ? The timer has been set to " + TextBox1.Text + " " + ComboBox1.Text, MsgBoxStyle.YesNo)
                If (fask = MsgBoxResult.Yes) Then
                    Canceltimer.Visible = True
                    Pause.Visible = True
                    Timer3.Start()
                    Timer3.Enabled = True
                    fortime.Visible = True
                    timeremaining.Visible = True
                    OptimizeSpeedToolStripMenuItem.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub shutdownoptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shutdownoptions.Click
        Shutdownb.Visible = True
        Restartb.Visible = True
        LogOffb.Visible = True
        playing1min.Visible = False
        playingfull.Visible = False
        playingloop.Visible = False
        alarmtext.Visible = False
        songopener.Visible = False
        songselector.Visible = False
        songshower.Visible = False
        songtester.Visible = False
        songstopper.Visible = False
    End Sub

    Private Sub alarmoptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alarmoptions.Click
        Shutdownb.Visible = False
        Restartb.Visible = False
        LogOffb.Visible = False
        playing1min.Visible = True
        playingfull.Visible = True
        playingloop.Visible = True
        alarmtext.Visible = True
        songopener.Visible = True
        songselector.Visible = True
        songshower.Visible = True
        songtester.Visible = True
        songstopper.Visible = True
    End Sub

    Private Sub playing1min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playing1min.Click
        minsong.Enabled = False
        Dim fask As MsgBoxResult
        If TextBox1.Visible = True And ComboBox1.Visible = True Then

        End If

        If TextBox1.Visible = False And TextBox1.Visible = False Then
            fask = MsgBox("Are you sure ? (No timer has been selected)", MsgBoxStyle.YesNo)
            If (fask = MsgBoxResult.Yes) Then

            End If
        Else
            If TextBox1.Text = Nothing Then
                fask = MsgBox("Please introduce a value for the timer", MsgBoxStyle.Critical)
            End If
            If ComboBox1.Text = Nothing Then
                fask = MsgBox("You haven't selected any numeric instrument" + Environment.NewLine + "Please select something from the dropdown list", MsgBoxStyle.Critical, )
            End If
            If TextBox1.Text = Nothing Or ComboBox1.Text = Nothing Then
            Else
                fask = MsgBox("Are you sure ? The timer has been set to " + TextBox1.Text + " " + ComboBox1.Text, MsgBoxStyle.YesNo)
                If (fask = MsgBoxResult.Yes) Then
                    Canceltimer.Visible = True
                    Pause.Visible = True
                    Timer3.Start()
                    Timer3.Enabled = True
                    fortime.Visible = True
                    timeremaining.Visible = True
                    OptimizeSpeedToolStripMenuItem.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub alarmtext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alarmtext.Click

    End Sub

    Private Sub songselector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles songselector.SelectedIndexChanged
        songshower.Text = Nothing
       
    End Sub

    Private Sub songtester_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles songtester.Click
        If songselector.SelectedItem = Nothing Then
            My.Computer.Audio.Play(OpenFileDialog1.FileName)

        Else
            If songselector.Text = "Ak47" Then
                My.Computer.Audio.Play(My.Resources.ak47, AudioPlayMode.Background)
            ElseIf songselector.Text = "Barking Dog" Then
                My.Computer.Audio.Play(My.Resources.dog, AudioPlayMode.Background)
            ElseIf songselector.Text = "Digital Insanity" Then
                My.Computer.Audio.Play(My.Resources.digitalinsanity, AudioPlayMode.Background)
            ElseIf songselector.Text = "Small Trap" Then
                My.Computer.Audio.Play(My.Resources.smalltrap, AudioPlayMode.Background)
            ElseIf songselector.Text = "Little Drums" Then
                My.Computer.Audio.Play(My.Resources.littledrums, AudioPlayMode.Background)
            ElseIf songselector.Text = "Gunshot" Then
                My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
            ElseIf songselector.Text = "Beep" Then
                My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            ElseIf songselector.Text = "Loud Rocket" Then
                My.Computer.Audio.Play(My.Resources.loud, AudioPlayMode.Background)
            End If
        End If
    End Sub

    Private Sub songopener_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles songopener.Click
        songselector.Text = Nothing
        OpenFileDialog1.Filter = "Audio|*.wav"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim sr As New System.IO.StringReader(OpenFileDialog1.FileName)
            songshower.Text = sr.ReadToEnd()
            sr.Close()

        End If
    End Sub

    Private Sub songshower_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles songshower.TextChanged

    End Sub

    Private Sub songstopper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles songstopper.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub playingfull_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playingfull.Click
        fullsong.Enabled = False
        Dim fask As MsgBoxResult
        If TextBox1.Visible = True And ComboBox1.Visible = True Then

        End If

        If TextBox1.Visible = False And TextBox1.Visible = False Then
            fask = MsgBox("Are you sure ? (No timer has been selected)", MsgBoxStyle.YesNo)
            If (fask = MsgBoxResult.Yes) Then

            End If
        Else
            If TextBox1.Text = Nothing Then
                fask = MsgBox("Please introduce a value for the timer", MsgBoxStyle.Critical)
            End If
            If ComboBox1.Text = Nothing Then
                fask = MsgBox("You haven't selected any numeric instrument" + Environment.NewLine + "Please select something from the dropdown list", MsgBoxStyle.Critical, )
            End If
            If TextBox1.Text = Nothing Or ComboBox1.Text = Nothing Then
            Else
                fask = MsgBox("Are you sure ? The timer has been set to " + TextBox1.Text + " " + ComboBox1.Text, MsgBoxStyle.YesNo)
                If (fask = MsgBoxResult.Yes) Then
                    Canceltimer.Visible = True
                    Pause.Visible = True
                    Timer3.Start()
                    Timer3.Enabled = True
                    fortime.Visible = True
                    timeremaining.Visible = True
                    OptimizeSpeedToolStripMenuItem.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub playingloop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playingloop.Click
        loopsong.Enabled = False
        Dim fask As MsgBoxResult
        If TextBox1.Visible = True And ComboBox1.Visible = True Then

        End If

        If TextBox1.Visible = False And TextBox1.Visible = False Then
            fask = MsgBox("Are you sure ? (No timer has been selected)", MsgBoxStyle.YesNo)
            If (fask = MsgBoxResult.Yes) Then

            End If
        Else
            If TextBox1.Text = Nothing Then
                fask = MsgBox("Please introduce a value for the timer", MsgBoxStyle.Critical)
            End If
            If ComboBox1.Text = Nothing Then
                fask = MsgBox("You haven't selected any numeric instrument" + Environment.NewLine + "Please select something from the dropdown list", MsgBoxStyle.Critical, )
            End If
            If TextBox1.Text = Nothing Or ComboBox1.Text = Nothing Then
            Else
                fask = MsgBox("Are you sure ? The timer has been set to " + TextBox1.Text + " " + ComboBox1.Text, MsgBoxStyle.YesNo)
                If (fask = MsgBoxResult.Yes) Then
                    Canceltimer.Visible = True
                    Pause.Visible = True
                    Timer3.Start()
                    Timer3.Enabled = True
                    fortime.Visible = True
                    timeremaining.Visible = True
                    OptimizeSpeedToolStripMenuItem.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub X05ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X05ToolStripMenuItem.Click
        Timer3.Interval = 1000 * 0.5
    End Sub

    Private Sub X20ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X20ToolStripMenuItem.Click
        Timer3.Interval = 1000 / 2.0
    End Sub

    Private Sub X40ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X40ToolStripMenuItem.Click
        Timer3.Interval = 1000 / 4.0
    End Sub

    Private Sub X150ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X150ToolStripMenuItem.Click
        Timer3.Interval = 1000 / 15.0
    End Sub

    Private Sub X320ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X320ToolStripMenuItem.Click
        Timer3.Interval = 1000 / 32.0
    End Sub

    Private Sub NormalToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        Timer3.Interval = 1000
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
