<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.shutdownoptions = New System.Windows.Forms.Button()
        Me.countersong = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'shutdownoptions
        '
        Me.shutdownoptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shutdownoptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.shutdownoptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shutdownoptions.ForeColor = System.Drawing.Color.Navy
        Me.shutdownoptions.Location = New System.Drawing.Point(0, 0)
        Me.shutdownoptions.Name = "shutdownoptions"
        Me.shutdownoptions.Size = New System.Drawing.Size(743, 437)
        Me.shutdownoptions.TabIndex = 57
        Me.shutdownoptions.Text = "Close the alarm"
        Me.shutdownoptions.UseVisualStyleBackColor = True
        '
        'countersong
        '
        Me.countersong.AutoSize = True
        Me.countersong.BackColor = System.Drawing.Color.Transparent
        Me.countersong.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countersong.ForeColor = System.Drawing.Color.Navy
        Me.countersong.Location = New System.Drawing.Point(687, 176)
        Me.countersong.Name = "countersong"
        Me.countersong.Size = New System.Drawing.Size(44, 62)
        Me.countersong.TabIndex = 58
        Me.countersong.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "60"
        Me.countersong.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(743, 437)
        Me.Controls.Add(Me.countersong)
        Me.Controls.Add(Me.shutdownoptions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Alarm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents shutdownoptions As System.Windows.Forms.Button
    Friend WithEvents countersong As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
