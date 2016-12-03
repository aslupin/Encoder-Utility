Imports System.IO

Public Class Form7
    Dim drag As Boolean = False
    Dim mousex As Integer, mousey As Integer
    Dim myFileDlog1 As New OpenFileDialog()
    Private Sub Form5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub Form5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




        Dim sub_dir As String() = TextBox2.Text.Split("\")

            If (Not System.IO.Directory.Exists(".\tools\" + TextBox1.Text)) Then
                System.IO.Directory.CreateDirectory(".\tools\" + TextBox1.Text)
            End If

            My.Computer.FileSystem.CopyFile(
               TextBox2.Text,
               ".\tools\" + TextBox1.Text + "\" + sub_dir.Last,
               Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
               Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

            If TextBox2.Text <> vbNullString Then
                File.WriteAllText(".\path_tools\" + TextBox1.Text + ".txt", ".\tools\" + TextBox1.Text + "\" + sub_dir.Last)
                Me.Close()
            End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        TextBox2.Text = myFileDlog1.FileName
        My.Settings.FileLog3 = TextBox2.Text
    End Sub

    Private Sub Form5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub Form7_Closed(sender As Object, e As EventArgs) Handles Me.Closed


        Form2.Show()

        '  Form2.Show()


        ' Form5.Show()
    End Sub

End Class