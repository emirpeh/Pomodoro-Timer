<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wPomodo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wPomodo))
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox2 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox3 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox4 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.GunaTransfarantPictureBox4)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaTransfarantPictureBox3)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaTransfarantPictureBox2)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(24, 25)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 50
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(831, 421)
        Me.GunaElipsePanel1.TabIndex = 0
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(30, 303)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(769, 90)
        Me.GunaLabel4.TabIndex = 3
        Me.GunaLabel4.Text = resources.GetString("GunaLabel4.Text")
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(16, 217)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(755, 60)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.Text = "Hangi iş yaparsanız yapın. Hangi sektörde olursanız olun, pomodoro tekniğini" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "uyg" &
    "ularken dikkat etmeniz gereken bazı hususlar vardır. Bunlar;"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(30, 66)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(801, 135)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = resources.GetString("GunaLabel2.Text")
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(16, 20)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(257, 30)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Pomodoro Tekniği Nedir?"
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.pomodoro.My.Resources.Resources.icons8_double_right_64
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(4, 66)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 4
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'GunaTransfarantPictureBox2
        '
        Me.GunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox2.Image = Global.pomodoro.My.Resources.Resources.icons8_double_right_64
        Me.GunaTransfarantPictureBox2.Location = New System.Drawing.Point(9, 303)
        Me.GunaTransfarantPictureBox2.Name = "GunaTransfarantPictureBox2"
        Me.GunaTransfarantPictureBox2.Size = New System.Drawing.Size(15, 15)
        Me.GunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox2.TabIndex = 5
        Me.GunaTransfarantPictureBox2.TabStop = False
        '
        'GunaTransfarantPictureBox3
        '
        Me.GunaTransfarantPictureBox3.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox3.Image = Global.pomodoro.My.Resources.Resources.icons8_double_right_64
        Me.GunaTransfarantPictureBox3.Location = New System.Drawing.Point(9, 334)
        Me.GunaTransfarantPictureBox3.Name = "GunaTransfarantPictureBox3"
        Me.GunaTransfarantPictureBox3.Size = New System.Drawing.Size(15, 15)
        Me.GunaTransfarantPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox3.TabIndex = 6
        Me.GunaTransfarantPictureBox3.TabStop = False
        '
        'GunaTransfarantPictureBox4
        '
        Me.GunaTransfarantPictureBox4.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox4.Image = Global.pomodoro.My.Resources.Resources.icons8_double_right_64
        Me.GunaTransfarantPictureBox4.Location = New System.Drawing.Point(9, 365)
        Me.GunaTransfarantPictureBox4.Name = "GunaTransfarantPictureBox4"
        Me.GunaTransfarantPictureBox4.Size = New System.Drawing.Size(15, 15)
        Me.GunaTransfarantPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox4.TabIndex = 7
        Me.GunaTransfarantPictureBox4.TabStop = False
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel5)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(28, 464)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 25
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(827, 64)
        Me.GunaElipsePanel2.TabIndex = 1
        '
        'GunaLabel5
        '
        Me.GunaLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.DarkGray
        Me.GunaLabel5.Location = New System.Drawing.Point(49, 19)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(718, 25)
        Me.GunaLabel5.TabIndex = 0
        Me.GunaLabel5.Text = "Unutmayın; ““ne yaparsanız yapın, en iyi şekilde yaptığınız zaman başarılı olursun" &
    "uz.””"
        '
        'wPomodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 540)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "wPomodo"
        Me.Text = "wPomodo"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox4 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox3 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox2 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
End Class
