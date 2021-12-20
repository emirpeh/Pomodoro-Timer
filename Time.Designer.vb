<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Time
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaCircleProgressBar1 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Pause2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.Start2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleProgressBar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(81, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 54)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "25:00"
        '
        'Timer1
        '
        '
        'GunaCircleProgressBar1
        '
        Me.GunaCircleProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaCircleProgressBar1.AnimationSpeed = 0.6!
        Me.GunaCircleProgressBar1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleProgressBar1.Controls.Add(Me.Label1)
        Me.GunaCircleProgressBar1.Font = New System.Drawing.Font("Segoe UI", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaCircleProgressBar1.IdleColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaCircleProgressBar1.IdleOffset = 21
        Me.GunaCircleProgressBar1.IdleThickness = 10
        Me.GunaCircleProgressBar1.Image = Nothing
        Me.GunaCircleProgressBar1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleProgressBar1.LineEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.GunaCircleProgressBar1.LineStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.GunaCircleProgressBar1.Location = New System.Drawing.Point(290, 59)
        Me.GunaCircleProgressBar1.Maximum = 15000
        Me.GunaCircleProgressBar1.Name = "GunaCircleProgressBar1"
        Me.GunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.Cyan
        Me.GunaCircleProgressBar1.ProgressOffset = 20
        Me.GunaCircleProgressBar1.ProgressThickness = 40
        Me.GunaCircleProgressBar1.Size = New System.Drawing.Size(300, 300)
        Me.GunaCircleProgressBar1.TabIndex = 5
        Me.GunaCircleProgressBar1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        Me.GunaCircleProgressBar1.Value = 100
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaAdvenceButton1.Animated = True
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = Global.pomodoro.My.Resources.Resources.icons8_xbox_x_48
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Global.pomodoro.My.Resources.Resources.icons8_xbox_x_481
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(768, 476)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 15
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(100, 52)
        Me.GunaAdvenceButton1.TabIndex = 8
        Me.GunaAdvenceButton1.Text = "Clear"
        '
        'Pause2
        '
        Me.Pause2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Pause2.Animated = True
        Me.Pause2.AnimationHoverSpeed = 1.0!
        Me.Pause2.AnimationSpeed = 2.0!
        Me.Pause2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pause2.BorderColor = System.Drawing.Color.Black
        Me.Pause2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pause2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Pause2.FocusedColor = System.Drawing.Color.Empty
        Me.Pause2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Pause2.ForeColor = System.Drawing.Color.White
        Me.Pause2.Image = Global.pomodoro.My.Resources.Resources.icons8_pause_64
        Me.Pause2.ImageSize = New System.Drawing.Size(50, 50)
        Me.Pause2.Location = New System.Drawing.Point(396, 365)
        Me.Pause2.Name = "Pause2"
        Me.Pause2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pause2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Pause2.OnHoverForeColor = System.Drawing.Color.White
        Me.Pause2.OnHoverImage = Nothing
        Me.Pause2.OnPressedColor = System.Drawing.Color.Black
        Me.Pause2.Size = New System.Drawing.Size(90, 90)
        Me.Pause2.TabIndex = 7
        '
        'Start2
        '
        Me.Start2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Start2.Animated = True
        Me.Start2.AnimationHoverSpeed = 1.0!
        Me.Start2.AnimationSpeed = 2.0!
        Me.Start2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Start2.BorderColor = System.Drawing.Color.Black
        Me.Start2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Start2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Start2.FocusedColor = System.Drawing.Color.Empty
        Me.Start2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Start2.ForeColor = System.Drawing.Color.White
        Me.Start2.Image = Global.pomodoro.My.Resources.Resources.icons8_play_64
        Me.Start2.ImageSize = New System.Drawing.Size(50, 50)
        Me.Start2.Location = New System.Drawing.Point(396, 365)
        Me.Start2.Name = "Start2"
        Me.Start2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Start2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Start2.OnHoverForeColor = System.Drawing.Color.White
        Me.Start2.OnHoverImage = Nothing
        Me.Start2.OnPressedColor = System.Drawing.Color.Black
        Me.Start2.Size = New System.Drawing.Size(90, 90)
        Me.Start2.TabIndex = 6
        '
        'Time
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 540)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.Pause2)
        Me.Controls.Add(Me.Start2)
        Me.Controls.Add(Me.GunaCircleProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Time"
        Me.Text = "Time"
        Me.GunaCircleProgressBar1.ResumeLayout(False)
        Me.GunaCircleProgressBar1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaCircleProgressBar1 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents Start2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Pause2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
