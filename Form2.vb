Imports System.IO

Public Class Form2
    Dim path As String
    Dim drag As Boolean = False
    Dim mousex As Integer, mousey As Integer
    Dim path_sc As String
    Private Sub Form5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub Form5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        path_sc = ".\scripts\"
        My.Settings.check_newScCm = "2"
        For Each file As String In System.IO.Directory.GetFiles(path_sc)
            ComboBox2.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next

        ComboBox2.SelectedItem = My.Settings.ComboSc
        TextBox1.Text = System.IO.File.ReadAllText(path_sc + ComboBox2.SelectedItem.ToString() + ".txt")


    End Sub
    Public Sub Queue_sc()
        path_sc = ".\scripts\"
        Label9.Text = "Queue_scripts >>"
        My.Settings.check_newScCm = "2"
    End Sub
    Public Sub Video_sc()
        path_sc = ".\cmdline_vdo\"
        Label9.Text = "Video_cmdline >>"
        My.Settings.check_newScCm = "3"
    End Sub
    Public Sub Audio_sc()
        path_sc = ".\cmdline_aud\"
        Label9.Text = "Audio_cmdline >>"
        My.Settings.check_newScCm = "4"
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged


        TextBox1.Text = System.IO.File.ReadAllText(path_sc + ComboBox2.SelectedItem.ToString() + ".txt")
        My.Settings.ComboSc = ComboBox2.SelectedItem.ToString()

    End Sub
    ' Queue 
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        TextBox1.Text = ""
        TextBox1.Refresh()
        ComboBox2.Refresh()
        Queue_sc()

        ComboBox2.ResetText()
        ComboBox2.Items.Clear()
        For Each file As String In System.IO.Directory.GetFiles(path_sc)
            ComboBox2.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        TextBox1.Text = ""
        TextBox1.Refresh()
        ComboBox2.Refresh()
        Video_sc()
        ComboBox2.ResetText()
        ComboBox2.Items.Clear()
        For Each file As String In System.IO.Directory.GetFiles(path_sc)
            ComboBox2.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        TextBox1.Text = ""
        TextBox1.Refresh()
        ComboBox2.Refresh()
        Audio_sc()
        ComboBox2.ResetText()
        ComboBox2.Items.Clear()

        For Each file As String In System.IO.Directory.GetFiles(path_sc)
            ComboBox2.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
    End Sub

    Private Sub Form5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        System.IO.File.Delete(path_sc + ComboBox2.SelectedItem.ToString() + ".txt")

        Dim f3 As New Form2

        Me.Close()
        f3.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If ComboBox2.Text <> "" Then
            File.WriteAllText(path_sc + ComboBox2.SelectedItem.ToString() + ".txt", TextBox1.Text)
        End If
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

    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click

    End Sub
End Class