Imports System.Runtime.InteropServices

Public Class Form1
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nextForm(New first)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        'btnMaximize.Visible = False
        ' btnRes.Visible = True
        ' Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRes_Click(sender As Object, e As EventArgs) Handles btnRes.Click
        btnRes.Visible = False
        btnMaximize.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tmHideMenu_Tick(sender As Object, e As EventArgs) Handles tmHideMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmHideMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 5
        End If
    End Sub

    Private Sub tmShowMenu_Tick(sender As Object, e As EventArgs) Handles tmShowMenu.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmShowMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 5
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 220 Then
            tmHideMenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmShowMenu.Enabled = True
        End If
    End Sub

    Private Sub nextForm(ByVal Formhijo As Object)

        If Me.PanelCon.Controls.Count > 0 Then
            Me.PanelCon.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelCon.Controls.Add(fh)
        Me.PanelCon.Tag = fh
        fh.Show()

    End Sub

    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        nextForm(New Dashboard)
    End Sub

    Private Sub Time_Click(sender As Object, e As EventArgs) Handles Time.Click
        nextForm(New Time)
    End Sub

    Private Sub What_Click(sender As Object, e As EventArgs) Handles What.Click
        nextForm(New wPomodo)
    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click
        nextForm(New first)
    End Sub

    Private Sub GunaTransfarantPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox1.Click
        nextForm(New first)
    End Sub
End Class
