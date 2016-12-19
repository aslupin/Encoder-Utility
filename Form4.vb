Public Class Form4
    Dim drag As Boolean = False
    Dim mousex As Integer, mousey As Integer
    Dim Second As Integer = 0
    Private Sub Form4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub Form4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.SaDe = 1 Then
            Label1.Text = "Has been saved."
        End If
        If My.Settings.SaDe = 2 Then
            Label1.Text = "Has been deleted."
        End If
        If My.Settings.SaDe = 3 Then
            Label1.Text = "Has been encoded."
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

End Class