Imports System.ComponentModel
Imports System.IO
Public Class Form5
    Dim s As String
    Dim path As String
    Dim drag As Boolean = False
    Dim mousex As Integer, mousey As Integer

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        path = ".\avss\" + ComboBox1.SelectedItem.ToString() + ".avs"
        TextBox1.Text = System.IO.File.ReadAllText(".\avss\" + ComboBox1.SelectedItem.ToString() + ".avs")
        '  s = TextBox1.Text
        My.Settings.ComboAvs = ComboBox1.SelectedItem.ToString()
        If ComboBox1.SelectedItem <> "none" Then
            Label3.Enabled = True
            Label3.ForeColor = System.Drawing.SystemColors.ControlLight


        End If

        If ComboBox1.SelectedItem <> "stdin_pathass" Then
            Label3.Enabled = True
            Label3.ForeColor = System.Drawing.SystemColors.ControlLight


        End If

        If ComboBox1.SelectedItem = "none" Then
            Label3.Enabled = False
            Label3.ForeColor = Color.Black

        End If

        If ComboBox1.SelectedItem = "stdin_pathass" Then
            Label3.Enabled = False
            Label3.ForeColor = Color.Black
        End If





    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dir = ".\avss"
        For Each file As String In System.IO.Directory.GetFiles(dir)
            ComboBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next



        'ComboBox1.GetItemText(My.Settings.ComboAvs)
        ComboBox1.SelectedItem = My.Settings.ComboAvs
        path = ".\avss\" + ComboBox1.SelectedItem.ToString() + ".avs"
        TextBox1.Text = System.IO.File.ReadAllText(path)


    End Sub







    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        My.Settings.check_newScCm = "1"
        Form6.Show()
        Me.Close()
        Form1.ComboBox6.Refresh()
    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        System.IO.File.Delete(".\avss\" + ComboBox1.SelectedItem.ToString() + ".avs")
        Dim f3 As New Form5
        ComboBox1.SelectedItem = "none"
        Me.Close()
        f3.Show()
        Form1.ComboBox6.Refresh()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ' If ComboBox1.SelectedItem = vbNull Then
        File.WriteAllText(".\avss\" + ComboBox1.SelectedItem.ToString() + ".avs", TextBox1.Text)
            Form1.ComboBox6.Refresh()

        '    End
        '   My.Settings.ComboSav = ComboBox1.SelectedItem.ToString()
        ' MsgBox(My.Settings.ComboSav.ToString)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Form1.Refresh()
        Me.Close()
    End Sub

    Private Sub Form5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        'Dim ttxxxtt As String
        myFileDlog1.InitialDirectory = My.Settings.FileLog3
        myFileDlog1.Filter = "All Files (*.*)|*.*"
        myFileDlog1.FilterIndex = 2
        myFileDlog1.RestoreDirectory = True
        If myFileDlog1.ShowDialog() =
            DialogResult.OK Then
            If Dir(myFileDlog1.FileName) <> "" Then
            Else
            End If
        End If
        Clipboard.SetText(myFileDlog1.FileName)
        Paste()
    End Sub
    Private Sub Paste()
        If Clipboard.GetDataObject.GetDataPresent(DataFormats.Text) Then
            Me.TextBox1.Paste()
        End If
    End Sub
    Private Sub Form5_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Refresh()
    End Sub
End Class