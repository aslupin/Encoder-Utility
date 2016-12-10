Public Class Form3
    Dim drag As Boolean = False
    Dim mousex As Integer, mousey As Integer
    Dim use As Long
    Dim ck As Long
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False
    End Sub
    Private Sub PictureBox2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub PictureBox2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseUp
        drag = False
    End Sub
    Private Sub Panel3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Panel3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub Panel3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseUp
        drag = False
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ck = 0
        If use Mod 2 = 0 Then
            ' My.Settings.User = TextBox1.Text
            ' My.Settings.Pass = TextBox2.Text
        End If
        If use Mod 2 = 1 Then
            My.Settings.User = TextBox1.Text
            My.Settings.Pass = TextBox2.Text
        End If

        If TextBox1.Text = "rootzix" And TextBox2.Text = "rootzix" Then
            Form1.Label31.Text = "ZIXMAR+Fs"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "AsLupin" And TextBox2.Text = "Zixmar01" Then
            Form1.Label31.Text = "AsLupin"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "Mr.PokiLoLi" And TextBox2.Text = "Zixmar02" Then
            Form1.Label31.Text = "Mr.PokiLoLi"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "Setsu" And TextBox2.Text = "Zixmar03" Then
            Form1.Label31.Text = "Setsu"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "Ai.suu" And TextBox2.Text = "Zixmar04" Then
            Form1.Label31.Text = "Ai.suu"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "NayamA" And TextBox2.Text = "Zixmar05" Then
            Form1.Label31.Text = "NayamA"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "MasK" And TextBox2.Text = "Zixmar06" Then
            Form1.Label31.Text = "MasK"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "FirstStalkerZ" And TextBox2.Text = "Zixmar07" Then
            Form1.Label31.Text = "FirstStalkerZ"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "HunTNosT" And TextBox2.Text = "Zixmar08" Then
            Form1.Label31.Text = "HunTNosT"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "iaf" And TextBox2.Text = "Zixmar09" Then
            Form1.Label31.Text = "iaf"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "Shouji" And TextBox2.Text = "Zixmar10" Then
            Form1.Label31.Text = "Shouji"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "Shiro" And TextBox2.Text = "Zixmar11" Then
            Form1.Label31.Text = "Shiro"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "Kingyo" And TextBox2.Text = "Zixmar12" Then
            Form1.Label31.Text = "Kingyo"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "Zoronoa" And TextBox2.Text = "Zixmar13" Then
            Form1.Label31.Text = "Zoronoa"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "SebastianAs" And TextBox2.Text = "Zixmar14" Then
            Form1.Label31.Text = "SebastianAs"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "Taiki" And TextBox2.Text = "Zixmar15" Then
            Form1.Label31.Text = "Taiki"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "snDiesy" And TextBox2.Text = "Zixmar16" Then
            Form1.Label31.Text = "snDiesy"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "kress" And TextBox2.Text = "Zixmar17" Then
            Form1.Label31.Text = "kress"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If
        If TextBox1.Text = "iNep" And TextBox2.Text = "Zixmar18" Then
            Form1.Label31.Text = "iNep"
            Me.Close()
            Form1.TabControl1.Show()
            Form1.Panel1.Show()
            Form1.Label29.Show()
            Form1.Label9.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.Enabled = True
            Form1.Opacity = 100
            ck = 1
        End If

        If TextBox1.Text = vbNullString Or TextBox2.Text = vbNullString Then
            ck = 1
            Label3.Text = "You have not specified a valid username or password ..."
        End If
        If Not ck = 1 Then
            Label3.Text = "your username or password can't sign ..."

        End If

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PictureBox3.Hide()
        ck = 0

        Me.CheckBox1.Checked = My.Settings.chk6

        If use Mod 2 = 0 Then
            ' My.Settings.User = TextBox1.Text
            ' My.Settings.Pass = TextBox2.Text
        End If
        If use Mod 2 = 1 Then
            TextBox1.Text = My.Settings.User
            TextBox2.Text = My.Settings.Pass
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
#If use = 0 Then
        use = use + 1
#End If
        My.Settings.chk6 = Me.CheckBox1.CheckState
    End Sub

    Private Sub TextBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseDown
        Label3.Text = "Input your username ..."
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        If TextBox1.Text = "" Then
            Label3.Text = "Input your username ..."
        End If
    End Sub
    Private Sub TextBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles TextBox2.MouseDown
        Label3.Text = "Input your password ..."
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        If TextBox2.Text = "" Then
            Label3.Text = "Input your password ..."
        End If
    End Sub

    Private Sub TextBox2_MouseLeave(sender As Object, e As EventArgs) Handles TextBox2.MouseLeave
        Label3.Text = ""
    End Sub
    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave
        Label3.Text = ""
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Label3.Text = "Exit ..."
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Label3.Text = ""
    End Sub

End Class