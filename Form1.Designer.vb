<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRes = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.What = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Time = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Dashboard = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.PanelCon = New System.Windows.Forms.Panel()
        Me.tmHideMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmShowMenu = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRes)
        Me.Panel1.Controls.Add(Me.btnMaximize)
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 40)
        Me.Panel1.TabIndex = 0
        '
        'btnRes
        '
        Me.btnRes.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRes.FlatAppearance.BorderSize = 0
        Me.btnRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRes.Image = Global.pomodoro.My.Resources.Resources.Icono_Restaurar
        Me.btnRes.Location = New System.Drawing.Point(1023, 0)
        Me.btnRes.Name = "btnRes"
        Me.btnRes.Size = New System.Drawing.Size(40, 40)
        Me.btnRes.TabIndex = 3
        Me.btnRes.UseVisualStyleBackColor = True
        Me.btnRes.Visible = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Image = Global.pomodoro.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximize.Location = New System.Drawing.Point(1023, 0)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximize.TabIndex = 1
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.pomodoro.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimize.Location = New System.Drawing.Point(986, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.pomodoro.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.Location = New System.Drawing.Point(1060, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.GunaLabel2)
        Me.PanelMenu.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Controls.Add(Me.What)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.Time)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.Dashboard)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 540)
        Me.PanelMenu.TabIndex = 1
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaLabel2.Font = New System.Drawing.Font("Harlow Solid Italic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GunaLabel2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.GunaLabel2.Location = New System.Drawing.Point(79, 55)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GunaLabel2.Size = New System.Drawing.Size(119, 60)
        Me.GunaLabel2.TabIndex = 6
        Me.GunaLabel2.Text = "Pomodoro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Time"
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaTransfarantPictureBox1.Image = Global.pomodoro.My.Resources.Resources.icons8_tomato_641
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(0, 51)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.GunaTransfarantPictureBox1.TabIndex = 0
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel4.Location = New System.Drawing.Point(0, 253)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 4
        '
        'What
        '
        Me.What.Cursor = System.Windows.Forms.Cursors.Hand
        Me.What.FlatAppearance.BorderSize = 0
        Me.What.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.What.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.What.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.What.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.What.ForeColor = System.Drawing.Color.White
        Me.What.Image = Global.pomodoro.My.Resources.Resources.producto
        Me.What.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.What.Location = New System.Drawing.Point(0, 253)
        Me.What.Name = "What"
        Me.What.Size = New System.Drawing.Size(220, 50)
        Me.What.TabIndex = 5
        Me.What.Text = "         What is Pomodoro?"
        Me.What.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(0, 197)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 2
        '
        'Time
        '
        Me.Time.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Time.FlatAppearance.BorderSize = 0
        Me.Time.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Time.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Time.ForeColor = System.Drawing.Color.White
        Me.Time.Image = Global.pomodoro.My.Resources.Resources.relo3
        Me.Time.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Time.Location = New System.Drawing.Point(0, 197)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(220, 50)
        Me.Time.TabIndex = 3
        Me.Time.Text = "Time"
        Me.Time.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(0, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 0
        '
        'Dashboard
        '
        Me.Dashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dashboard.FlatAppearance.BorderSize = 0
        Me.Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Dashboard.ForeColor = System.Drawing.Color.White
        Me.Dashboard.Image = Global.pomodoro.My.Resources.Resources.reportes
        Me.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dashboard.Location = New System.Drawing.Point(0, 141)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Size = New System.Drawing.Size(220, 50)
        Me.Dashboard.TabIndex = 0
        Me.Dashboard.Text = "Dashboard"
        Me.Dashboard.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = Global.pomodoro.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnMenu.Location = New System.Drawing.Point(177, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(43, 29)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'PanelCon
        '
        Me.PanelCon.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.PanelCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelCon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCon.Location = New System.Drawing.Point(220, 40)
        Me.PanelCon.Name = "PanelCon"
        Me.PanelCon.Size = New System.Drawing.Size(880, 540)
        Me.PanelCon.TabIndex = 2
        '
        'tmHideMenu
        '
        Me.tmHideMenu.Interval = 10
        '
        'tmShowMenu
        '
        Me.tmShowMenu.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 580)
        Me.Controls.Add(Me.PanelCon)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelCon As Panel
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnRes As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents tmHideMenu As Timer
    Friend WithEvents tmShowMenu As Timer
    Friend WithEvents Dashboard As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents What As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Time As Button
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
