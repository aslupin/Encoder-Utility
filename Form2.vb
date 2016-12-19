Imports System.IO
Imports System.Security.Permissions
Imports System.Text.RegularExpressions
Imports System.Threading
Public Class Form2
    Dim path As String
    Dim drag As Boolean = False
    Dim mousex As Integer, mousey As Integer
    Dim path_sc As String
    Dim path_cm As String
    Private Sub Form5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub Form5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Hide()
        Label14.Hide()

        If My.Settings.opened = 1 Then
            Video_sc()
        End If
        If My.Settings.opened = 2 Then
            Audio_sc()
        End If
        If My.Settings.opened = 3 Then
            Queue_sc()
        End If



        ' My.Settings.check_newScCm = "2"
        For Each file As String In System.IO.Directory.GetFiles(path_sc)
            ComboBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
        For Each file As String In System.IO.Directory.GetFiles(path_cm)
            ComboBox2.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
        ComboBox2.SelectedItem = My.Settings.ComboCm
        ComboBox1.SelectedItem = My.Settings.ComboSc
        ' TextBox1.Text = File.ReadAllText(path_sc + ComboBox1.SelectedItem.ToString() + ".txt")


    End Sub
    Public Sub Queue_sc()
        Label7.Text = "Video_settings"
        Label8.Text = "Audio_settings"
        Label5.Text = "Other_settings    >>"
        path_cm = ".\cmdline_etc\"
        path_sc = ".\scripts_etc\"
        ' Label9.Text = "Queue_scripts >>"
        My.Settings.opened = 3
        My.Settings.check_newScCm = "2"
    End Sub
    Public Sub Video_sc()
        Label7.Text = "Video_settings    >>"
        Label8.Text = "Audio_settings"
        Label5.Text = "Other_settings"
        path_cm = ".\cmdline_vdo\"
        path_sc = ".\scripts_vdo\"
        ' Label9.Text = "Video_cmdline >>"
        My.Settings.opened = 1
        My.Settings.check_newScCm = "3"
    End Sub
    Public Sub Audio_sc()
        Label7.Text = "Video_settings"
        Label8.Text = "Audio_settings    >>"
        Label5.Text = "Other_settings"
        path_cm = ".\cmdline_aud\"
        path_sc = ".\scripts_aud\"
        '  Label9.Text = "Audio_cmdline >>"
        My.Settings.opened = 2
        My.Settings.check_newScCm = "4"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


        TextBox1.Text = System.IO.File.ReadAllText(path_sc + ComboBox1.SelectedItem.ToString() + ".txt")
        My.Settings.ComboSc = ComboBox1.SelectedItem.ToString()
        My.Settings.Chcom_CmSc = 1
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged


        TextBox1.Text = System.IO.File.ReadAllText(path_cm + ComboBox2.SelectedItem.ToString() + ".txt")
        My.Settings.ComboCm = ComboBox2.SelectedItem.ToString()
        My.Settings.Chcom_CmSc = 2
    End Sub
    ' Queue 
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        TextBox1.Text = ""
        TextBox1.Refresh()
        ComboBox1.Refresh()
        ComboBox2.Refresh()
        Queue_sc()

        ComboBox1.ResetText()
        ComboBox1.Items.Clear()
        ComboBox2.ResetText()
        ComboBox2.Items.Clear()
        For Each file As String In System.IO.Directory.GetFiles(path_sc)
            ComboBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))

        Next
        For Each file As String In System.IO.Directory.GetFiles(path_cm)
            ComboBox2.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

        TextBox1.Text = ""
        TextBox1.Refresh()
        ComboBox1.Refresh()
        ComboBox2.Refresh()
        Video_sc()
        ComboBox1.ResetText()
        ComboBox1.Items.Clear()
        ComboBox2.ResetText()
        ComboBox2.Items.Clear()
        For Each file As String In System.IO.Directory.GetFiles(path_sc)
            ComboBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
        For Each file As String In System.IO.Directory.GetFiles(path_cm)
            ComboBox2.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

        TextBox1.Text = ""
        TextBox1.Refresh()
        ComboBox1.Refresh()
        ComboBox2.Refresh()
        Audio_sc()
        ComboBox1.ResetText()
        ComboBox1.Items.Clear()
        ComboBox2.ResetText()
        ComboBox2.Items.Clear()

        For Each file As String In System.IO.Directory.GetFiles(path_sc)
            ComboBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
        For Each file As String In System.IO.Directory.GetFiles(path_cm)
            ComboBox2.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        My.Settings.SaDe = 2
        If My.Settings.Chcom_CmSc = 1 Then
            System.IO.File.Delete(path_sc + ComboBox1.SelectedItem.ToString() + ".txt")
        End If
        If My.Settings.Chcom_CmSc = 2 Then
            System.IO.File.Delete(path_cm + ComboBox2.SelectedItem.ToString() + ".txt")
        End If

        Dim f4 As New Form4
        Dim f3 As New Form2
        Me.Close()
        f3.Show()
        f4.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        My.Settings.SaDe = 1
        If My.Settings.Chcom_CmSc = 1 Then
            If ComboBox1.Text <> "" Then
                File.WriteAllText(path_sc + ComboBox1.SelectedItem.ToString() + ".txt", TextBox1.Text)
            End If
        End If

        If My.Settings.Chcom_CmSc = 2 Then
            If ComboBox2.Text <> "" Then
                File.WriteAllText(path_cm + ComboBox2.SelectedItem.ToString() + ".txt", TextBox1.Text)
            End If
        End If

        Form4.Show()


        '  File.WriteAllText(path_sc + ComboBox2.SelectedItem.ToString() + ".txt", TextBox1.Text)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        'My.Settings.check_newScCm = "2"
        Form6.Show()
        Me.Close()
        ' Form1.ComboBox6.Refresh()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        'My.Settings.check_ScCm2 = "2"
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        ComboBox2.Text = ""
        TextBox1.Text = "ID  >>   PATH" + vbNewLine
        Dim fileEntries As String() = Directory.GetFiles(".\path_tools\", "*.txt")
        ' Process the list of .txt files found in the directory. '
        Dim fileName As String
        Dim sub_fl As String()
        For Each fileName In fileEntries
            sub_fl = fileName.Split("\")
            sub_fl = sub_fl.Last.Split(".")
            ' MsgBox(fileName)
            TextBox1.Text += sub_fl(0) + "  >>   " + System.IO.File.ReadAllText(fileName) + vbNewLine
        Next
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Label13.Show()
        Label14.Hide()
        My.Settings.Chcom_CmSc = 1
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Label13.Hide()
        Label14.Show()
        My.Settings.Chcom_CmSc = 2
    End Sub
    Private Sub ComboBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox1.MouseClick
        If ComboBox1.SelectedItem <> vbNullString Then
            My.Settings.ComboSc = ComboBox1.SelectedItem.ToString()
            TextBox1.Text = System.IO.File.ReadAllText(path_sc + ComboBox1.SelectedItem.ToString() + ".txt")


        End If

        Label13.Show()
        Label14.Hide()
        My.Settings.Chcom_CmSc = 1
    End Sub
    Private Sub ComboBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox2.MouseClick
        If ComboBox2.SelectedItem <> vbNullString Then
            My.Settings.ComboCm = ComboBox2.SelectedItem.ToString()
            TextBox1.Text = System.IO.File.ReadAllText(path_cm + ComboBox2.SelectedItem.ToString() + ".txt")


        End If

        Label13.Hide()
        Label14.Show()
        My.Settings.Chcom_CmSc = 2
    End Sub


    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click

    End Sub
End Class