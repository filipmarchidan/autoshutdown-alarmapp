Public Class Form2
    Dim Loc As New Point(0, 0)
    Dim Cur As New Point(0, 0)
    Private Sub ConfigSize()
        Loc = Location
        Cur = Cursor.Position

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
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim valoare As Double
        If TrackBar1.Value = TrackBar1.Value - 1 Then
            Form1.Timer3.Interval = Form1.Timer3.Interval * 0.2
        End If
        If TrackBar1.Value = TrackBar1.Value + 1 Then

            Form1.Timer3.Interval = Form1.Timer3.Interval / 0.2
        End If
        SPEED.Text = "x" & TrackBar1.Value
        If TrackBar1.Value = 15 Then
            SPEED.Text = "Normal"
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Start()
    End Sub
End Class