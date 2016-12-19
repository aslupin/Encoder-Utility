Imports System.ComponentModel
Imports System.IO
Imports System.Security.Permissions
Imports System.Text.RegularExpressions
Imports System.Threading


Public Class Form1
    Dim checkrunn As String = 0
    Dim PathFileAAS_TWO As String
    Dim FCount As Integer       '


    Private oProcess_Q As New Process
    Dim oStartInfoQ As New System.Diagnostics.ProcessStartInfo
    Dim strcmd_process As String
    Dim ffReader As StreamReader
    Dim strFFOUT As String




    Dim oProcess As New Process()
    Dim oStartInfo As New ProcessStartInfo()
    Dim Incre As Integer
    Dim i_c As Integer
    Dim stat_process As String
    Dim text_queue As String
    Dim nOfQueue As Integer
    'Dim Path2 As String
    Dim Aftxt_function As String
    Dim Betxt_function As String
    Dim FPS As String
    Dim TextBox2_5 As String
    Dim oForm2 As Form1
    Dim EncodeWithx264 As New ProcessStartInfo
    Dim myFileDlog1 As New OpenFileDialog()
    Dim drag As Boolean = False
    Dim mousex As Integer, mousey As Integer
    Dim Logfile As String
    Dim i As Long
    Dim Exp As Long
    Dim j As Long
    Dim PicC As Long
    Dim TimeX As String
    Dim TimeOne As String
    Dim TimeTwo As String
    Dim TimePic As String
    Dim Plugin1 As String
    Dim Plugin2 As String
    Dim Plugin3 As String
    Dim Plugin4 As String
    Dim Plugin5 As String
    Dim Form2 As Object
    Dim LoadTextSub2 As String
    Dim TSave As String
    Dim TTextBox3 As String
    Dim oplog As String
    Dim iplog As String
    Dim Moplog As String
    Dim Miplog As String
    Dim M2iplog As String
    Dim Cvs As Long
    Dim BitRx264 As String
    Dim pass As Long
    Dim p1 As Long
    Dim Encmode As String
    Private Sub PictureBox4_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub PictureBox4_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseUp
        drag = False
    End Sub
    Private Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseUp
        drag = False
    End Sub
    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        drag = False
    End Sub
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub
    Private Sub TabPage4_MouseDown(sender As Object, e As MouseEventArgs) Handles TabPage4.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub TabPage4_MouseMove(sender As Object, e As MouseEventArgs) Handles TabPage4.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub TabPage4_MouseUp(sender As Object, e As MouseEventArgs) Handles TabPage4.MouseUp
        drag = False
    End Sub
    Private Sub TabPage3_MouseDown(sender As Object, e As MouseEventArgs) Handles TabPage3.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub TabPage3_MouseMove(sender As Object, e As MouseEventArgs) Handles TabPage3.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub TabPage3_MouseUp(sender As Object, e As MouseEventArgs) Handles TabPage3.MouseUp
        drag = False
    End Sub
    Private Sub TabPage2_MouseDown(sender As Object, e As MouseEventArgs) Handles TabPage2.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub TabPage2_MouseMove(sender As Object, e As MouseEventArgs) Handles TabPage2.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub TabPage2_MouseUp(sender As Object, e As MouseEventArgs) Handles TabPage2.MouseUp
        drag = False
    End Sub
    Private Sub TabPage1_MouseDown(sender As Object, e As MouseEventArgs) Handles TabPage1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub TabPage1_MouseMove(sender As Object, e As MouseEventArgs) Handles TabPage1.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub
    Private Sub TabPage1_MouseUp(sender As Object, e As MouseEventArgs) Handles TabPage1.MouseUp
        drag = False
    End Sub
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
    'Open file MP4 || MKV
    'TextBox1.Text
    'Button 1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '  Dim myFileDlog1 As New OpenFileDialog()
        '  myFileDlog1.InitialDirectory = "
        myFileDlog1.InitialDirectory = Logfile
        myFileDlog1.Filter = "All Files (*.*)|*.*" &
            "|MP4 Files (*.mp4)|*.mp4" &
            "|MKV Files (*.mkv)|*.mkv"
        myFileDlog1.FilterIndex = 2
        myFileDlog1.RestoreDirectory = True
        If myFileDlog1.ShowDialog() =
            DialogResult.OK Then
            If Dir(myFileDlog1.FileName) <> "" Then
            Else
            End If
        End If
        TextBox1.Text = myFileDlog1.FileName
        Logfile = myFileDlog1.FileName
        '    TextBox1.Text = My.Settings.TextToSave
    End Sub
    'Open file ASS
    'TextBox2.Text
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox2_5 = ""
        Dim PathFileAAS As String = ".\avss\stdin_pathass.avs"
        Dim DataAvs_temp As String = System.IO.File.ReadAllText(PathFileAAS)

        Dim scp_AssInput As String = "<input:PathAss>"
        Dim x As Integer = InStr(DataAvs_temp, scp_AssInput)

        Betxt_function = DataAvs_temp.Substring(0, DataAvs_temp.IndexOf(scp_AssInput))
        Aftxt_function = DataAvs_temp.Substring(x + scp_AssInput.Length - 1)


        Dim RoungText As String = ""
        TextBox2.Text = ""

        OpenFileDialog1.InitialDirectory = Logfile
        OpenFileDialog1.Filter = "All Files (*.*)|*.*" & "|ASS Files (*.ass)|*.ass"

        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.Multiselect = True
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            For xerNum = 0 To OpenFileDialog1.FileNames.Count - 1

                TextBox2_5 += Betxt_function + OpenFileDialog1.FileNames(xerNum) + Aftxt_function & Environment.NewLine


                If xerNum = 0 Then
                    RoungText = Path.GetFileName(OpenFileDialog1.FileNames(xerNum))
                End If

                If xerNum <> 0 Then
                    RoungText = RoungText + "  ,  " + Path.GetFileName(OpenFileDialog1.FileNames(xerNum))
                End If

            Next

        End If
        TextBox2.Text = RoungText
        'TextBox2.Text = myFileDlog1.FileName
        myFileDlog1.FileName = OpenFileDialog1.FileName
        Logfile = myFileDlog1.FileName

        'TextBox2_5 = ""
    End Sub

    'Save as
    'Button 4
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PathFileAAS_TWO = ".\avss\" + My.Settings.ComboAvs + ".avs"
        TTextBox3 = System.IO.File.ReadAllText(PathFileAAS_TWO)
        TTextBox3 = TTextBox3.Replace("<input:Textsub>", TextBox2_5)
        TTextBox3 = TTextBox3.Replace("<input:InRaw>", TextBox1.Text)

        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "All files (*.*)|*.*|AVS files (*.avs)|*.avs"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sw As StreamWriter = New StreamWriter(saveFileDialog1.OpenFile())
            If (sw IsNot Nothing) Then
                sw.WriteLine(TTextBox3)
                sw.Close()
            End If
        End If
        TSave = saveFileDialog1.FileName
        '  TextBox6.Text = saveFileDialog1.FileName
        ' MsgBox(TSave)
    End Sub
    'Show Log Msg
    ' Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
    '    MsgBox(TextBox3.Text)
    '  End Sub
    '
    '----------------- Tab --------------
    '
    'Settings
    'Private Sub SettingsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem1.Click

    '
    '-----------------FC Aotomatic-------------
    '
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dir4 = ".\scripts_etc"
        For Each file As String In System.IO.Directory.GetFiles(dir4)
            ComboBox3.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
        Dim dir3 = ".\scripts_aud"
        For Each file As String In System.IO.Directory.GetFiles(dir3)
            ComboBox2.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
        Dim dir2 = ".\scripts_vdo"
        For Each file As String In System.IO.Directory.GetFiles(dir2)
            ComboBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
        Dim dir = ".\avss"
        For Each file As String In System.IO.Directory.GetFiles(dir)
            ComboBox6.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
        ComboBox3.SelectedItem = My.Settings.Enc3
        ComboBox2.SelectedItem = My.Settings.Enc2
        ComboBox1.SelectedItem = My.Settings.Enc
        ComboBox6.SelectedItem = My.Settings.ComboAvs
        Panel4.Size = New Size(0, 0)
        Panel3.Size = New Size(0, 0)
        Panel2.Size = New Size(0, 0)
        RichTextBox1.Text = "Status : - "
        RichTextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        RichTextBox2.Text = "Status : - "
        RichTextBox2.BackColor = System.Drawing.SystemColors.ControlLight
        RichTextBox3.Text = "Status : - "
        RichTextBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Dim oForm As Form3
        oForm = New Form3()
        oForm.Show()
        oForm = Nothing
        checkrunn = 0
        TabControl1.Hide()
        Panel1.Hide()
        Label29.Hide()
        Label9.Hide()

        Label22.Hide()
        Label23.Hide()
        Label24.Hide()

        Me.WindowState = FormWindowState.Minimized
        Me.Enabled = False
        Me.Opacity = 0

        ' RichTextBox1.Text = "[Status] : -"




        Encmode = My.Settings.Enc
        '  ComboBox1.SelectedItem = Encmode


        ' Form5.ComboBox1.SelectedItem = My.Settings.ComboAvs

        BitRx264 = My.Settings.Bitx264
        'DomainUpDown1.Text = BitRx264

        ' Me.CheckBox2.Checked = My.Settings.chk4
        'Me.CheckBox1.Checked = My.Settings.chk3
        Logfile = My.Settings.FileLog

        ' Dim dir = ".\avss"
        '  For Each file As String In System.IO.Directory.GetFiles(dir)
        ' ComboBox6.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        ' Next
        ' ComboBox1.SelectedItem = My.Settings.ComboAvs


        '  RichTextBox1.Visible = True   'hide the richtextbox
        'Me.Height = 441                 'make sure the form starts at it's normal height
        'Label11.Text = "0%"            'ignore this line
        '  ProgressBar1.Value = 0          'set the progressbar to 0
        ' Button5.Enabled = False      'cancel button




    End Sub
    Private Sub myForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) _
 Handles MyBase.FormClosing
        My.Settings.FileLog = Logfile
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click


        Dim saveFileDialog2 As New SaveFileDialog()

        saveFileDialog2.Filter = "MP4 files (*.mp4)|*.mp4"
        saveFileDialog2.FilterIndex = 2
        saveFileDialog2.RestoreDirectory = True

        If saveFileDialog2.ShowDialog() = DialogResult.OK Then

        End If
        TextBox6.Text = saveFileDialog2.FileName

    End Sub


    ' Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    ' While Not oProcess.HasExited
    '  Label14.Text = oProcess.StandardOutput.ReadToEnd()
    'Dim Thread_process As New Thread(AddressOf Enprocess1) 'Enprocess
    ' Thread_process.Start()
    ' End While
    'ProgressBar1.Increment(Incre)

    ' End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        checkrunn = 1
        RichTextBox1.Text = "Status : Loading.."
        Label22.Show()
        text_queue = System.IO.File.ReadAllText(".\scripts_vdo\" + ComboBox1.SelectedItem.ToString() + ".txt")

        Bgw1.RunWorkerAsync()

    End Sub
    Private Sub Enprocess_2()


        Control.CheckForIllegalCrossThreadCalls = False
        Dim strArr_queue(12) As String
        text_queue = text_queue.Replace("MODE ", "")
        ' strArr = text_queue.Split(" ")
        Dim parts As String() = text_queue.Split(New String() {Environment.NewLine},
                                       StringSplitOptions.None)
        nOfQueue = Integer.Parse(Regex.Replace(parts(0), "[^\d]", ""))
        'MsgBox(nOfQueue)
        Dim OutType(nOfQueue + 1) As String
        Dim path_process(nOfQueue + 1) As String
        Dim arguments_process(nOfQueue + 1) As String

        For value As Integer = 1 To nOfQueue
            strArr_queue(value) = System.IO.File.ReadAllText(".\cmdline_vdo\" + parts(value) + ".txt")
            Dim temp_strarr As String() = strArr_queue(value).Split(New String() {Environment.NewLine}, StringSplitOptions.None)
            ' MsgBox(temp_strarr(0) + vbNewLine + temp_strarr(1))

            path_process(value) = System.IO.File.ReadAllText(".\path_tools\" + temp_strarr(0) + ".txt")
            arguments_process(value) = temp_strarr(1)
            OutType(value) = temp_strarr(2)

        Next



        Panel2.Size = New Size(872, 31)
        RichTextBox1.BackColor = Color.DimGray
        RichTextBox1.ForeColor = Color.WhiteSmoke
        Dim goto_arg As String
        Dim nofen As Integer
        Dim N1pass(20) As String
        Dim S1pass(20) As String
        S1pass(1) = TextBox3.Text
        N1pass(1) = TextBox6.Text

        For nofen = 1 To nOfQueue

            If nOfQueue = 1 Then

            End If
            Dim std_typeEn As String() = OutType(nofen).Split(" ")
            If std_typeEn(0) <> "NULL" Then
                If nofen = 1 Then
                    N1pass(nofen) = N1pass(nofen).Replace(std_typeEn(0), std_typeEn(1))
                Else
                    N1pass(nofen) = N1pass(nofen - 1).Replace(std_typeEn(0), std_typeEn(1))
                End If



            End If


            '  goto_arg = arguments_process(nofen).Replace("out_std", TextBox6.Text).Replace("input_std", TextBox3.Text)
            If nofen = nOfQueue Then
                goto_arg = arguments_process(nofen).Replace("input_std", S1pass(nofen)).Replace("out_std", N1pass(nofen))
            Else
                goto_arg = arguments_process(nofen).Replace("input_std", S1pass(nofen)).Replace("out_std", N1pass(nofen))
            End If

            If std_typeEn(0) <> "NULL" Then
                S1pass(nofen + 1) = N1pass(nofen)

            Else
                S1pass(nofen + 1) = S1pass(nofen)
            End If
            ' MsgBox(goto_arg)
            oStartInfoQ.FileName = path_process(nofen)
            oStartInfoQ.Arguments = goto_arg
            oStartInfoQ.UseShellExecute = False
            oStartInfoQ.WindowStyle = ProcessWindowStyle.Hidden
            oStartInfoQ.RedirectStandardError = True
            oStartInfoQ.RedirectStandardOutput = True
            oStartInfoQ.CreateNoWindow = True
            oProcess_Q.StartInfo = oStartInfoQ
            oProcess_Q.Start() 'Start Process

            'ffmpeg uses StandardErrorOut instead of StandardOut
            ffReader = oProcess_Q.StandardError 'Enable Error Checking For FFMPEG.EXE

            Do
                If Bgw1.CancellationPending Then ' Have we pressed Cancel?
                    ' RichTextBox1.Text = "Status : " + ffReader.ReadLine
                    Exit Sub
                End If

                strFFOUT = ffReader.ReadLine         'read each line from ffreader
                RichTextBox1.Text = "Status : " + parts(nofen) + "  " + strFFOUT
            Loop Until oProcess_Q.HasExited And strFFOUT = Nothing Or strFFOUT = ""

        Next

        '    For nofen = 1 To nOfQueue - 1
        'System.IO.File.Delete(N1pass(nofen))
        '  Next
        ' System.IO.File.Delete(N1pass)

        RichTextBox1.Text = "Status : Completed."


        Panel2.Size = New Size(872, 31)
        ' RichTextBox1.BackColor = Me.BackColor
        ' RichTextBox1.ForeColor = Color.Black
        checkrunn = 0


    End Sub
    Private Sub Show4()
        Form4.Show()
    End Sub
    Private Sub Enprocess_3()

        Control.CheckForIllegalCrossThreadCalls = False
        Dim strArr_queue(12) As String
        text_queue = text_queue.Replace("MODE ", "")

        Dim parts As String() = text_queue.Split(New String() {Environment.NewLine},
                                       StringSplitOptions.None)
        nOfQueue = Integer.Parse(Regex.Replace(parts(0), "[^\d]", ""))
        'MsgBox(nOfQueue)
        Dim OutType(nOfQueue + 1) As String
        Dim path_process(nOfQueue + 1) As String
        Dim arguments_process(nOfQueue + 1) As String

        For value As Integer = 1 To nOfQueue
            strArr_queue(value) = System.IO.File.ReadAllText(".\cmdline_aud\" + parts(value) + ".txt")
            Dim temp_strarr As String() = strArr_queue(value).Split(New String() {Environment.NewLine}, StringSplitOptions.None)
            ' MsgBox(temp_strarr(0) + vbNewLine + temp_strarr(1))

            path_process(value) = System.IO.File.ReadAllText(".\path_tools\" + temp_strarr(0) + ".txt")
            arguments_process(value) = temp_strarr(1)
            OutType(value) = temp_strarr(2)

        Next



        Panel3.Size = New Size(872, 31)
        RichTextBox2.BackColor = Color.DimGray
        RichTextBox2.ForeColor = Color.WhiteSmoke
        Dim goto_arg As String
        Dim nofen As Integer
        Dim N1pass(20) As String
        Dim S1pass(20) As String
        S1pass(1) = TextBox7.Text
        N1pass(1) = TextBox8.Text

        For nofen = 1 To nOfQueue

            If nOfQueue = 1 Then

            End If
            Dim std_typeEn As String() = OutType(nofen).Split(" ")
            If std_typeEn(0) <> "NULL" Then
                If nofen = 1 Then
                    N1pass(nofen) = N1pass(nofen).Replace(std_typeEn(0), std_typeEn(1))
                Else
                    N1pass(nofen) = N1pass(nofen - 1).Replace(std_typeEn(0), std_typeEn(1))
                End If



            End If


            '  goto_arg = arguments_process(nofen).Replace("out_std", TextBox6.Text).Replace("input_std", TextBox3.Text)
            If nofen = nOfQueue Then
                goto_arg = arguments_process(nofen).Replace("input_std", S1pass(nofen)).Replace("out_std", N1pass(nofen))
            Else
                goto_arg = arguments_process(nofen).Replace("input_std", S1pass(nofen)).Replace("out_std", N1pass(nofen))
            End If

            If std_typeEn(0) <> "NULL" Then
                S1pass(nofen + 1) = N1pass(nofen)

            Else
                S1pass(nofen + 1) = S1pass(nofen)
            End If
            ' MsgBox(goto_arg)
            oStartInfoQ.FileName = path_process(nofen)
            oStartInfoQ.Arguments = goto_arg
            oStartInfoQ.UseShellExecute = False
            oStartInfoQ.WindowStyle = ProcessWindowStyle.Hidden
            oStartInfoQ.RedirectStandardError = True
            oStartInfoQ.RedirectStandardOutput = True
            oStartInfoQ.CreateNoWindow = True
            oProcess_Q.StartInfo = oStartInfoQ
            oProcess_Q.Start() 'Start Process

            'ffmpeg uses StandardErrorOut instead of StandardOut
            ffReader = oProcess_Q.StandardError 'Enable Error Checking For FFMPEG.EXE

            Do
                If Bgw1.CancellationPending Then ' Have we pressed Cancel?
                    Exit Sub
                End If

                strFFOUT = ffReader.ReadLine         'read each line from ffreader
                RichTextBox2.Text = "Status : " + parts(nofen) + "  " + strFFOUT
            Loop Until oProcess_Q.HasExited And strFFOUT = Nothing Or strFFOUT = ""

        Next

        For nofen = 1 To nOfQueue - 1
            System.IO.File.Delete(N1pass(nofen))
        Next
        ' System.IO.File.Delete(N1pass)
        RichTextBox2.Text = "Status : Completed."

        Panel3.Size = New Size(872, 31)
        checkrunn = 0
        ' RichTextBox1.BackColor = Me.BackColor
        ' RichTextBox1.ForeColor = Color.Black

    End Sub
    Private Sub Enprocess_4()

        Control.CheckForIllegalCrossThreadCalls = False
        Dim strArr_queue(12) As String
        text_queue = text_queue.Replace("MODE ", "")

        Dim parts As String() = text_queue.Split(New String() {Environment.NewLine},
                                       StringSplitOptions.None)
        nOfQueue = Integer.Parse(Regex.Replace(parts(0), "[^\d]", ""))
        'MsgBox(nOfQueue)
        Dim OutType(nOfQueue + 1) As String
        Dim path_process(nOfQueue + 1) As String
        Dim arguments_process(nOfQueue + 1) As String

        For value As Integer = 1 To nOfQueue
            strArr_queue(value) = System.IO.File.ReadAllText(".\cmdline_etc\" + parts(value) + ".txt")
            Dim temp_strarr As String() = strArr_queue(value).Split(New String() {Environment.NewLine}, StringSplitOptions.None)
            ' MsgBox(temp_strarr(0) + vbNewLine + temp_strarr(1))

            path_process(value) = System.IO.File.ReadAllText(".\path_tools\" + temp_strarr(0) + ".txt")
            arguments_process(value) = temp_strarr(1)
            OutType(value) = temp_strarr(2)

        Next



        Panel4.Size = New Size(872, 31)
        RichTextBox3.BackColor = Color.DimGray
        RichTextBox3.ForeColor = Color.WhiteSmoke
        Dim goto_arg As String
        Dim nofen As Integer
        Dim N1pass(20) As String
        Dim S1pass(20) As String
        Dim S2pass(20) As String
        S1pass(1) = TextBox9.Text 'VDO
        S2pass(1) = TextBox10.Text 'AUD
        N1pass(1) = TextBox11.Text 'OUT


        For nofen = 1 To nOfQueue

            If nOfQueue = 1 Then

            End If
            Dim std_typeEn As String() = OutType(nofen).Split(" ")
            If std_typeEn(0) <> "NULL" Then
                If nofen = 1 Then
                    N1pass(nofen) = N1pass(nofen).Replace(std_typeEn(0), std_typeEn(1))
                Else
                    N1pass(nofen) = N1pass(nofen - 1).Replace(std_typeEn(0), std_typeEn(1))
                End If



            End If


            '  goto_arg = arguments_process(nofen).Replace("out_std", TextBox6.Text).Replace("input_std", TextBox3.Text)

            goto_arg = arguments_process(nofen).Replace("input_vdo", S1pass(nofen)).Replace("input_aud", S2pass(nofen)).Replace("out_std", N1pass(nofen))


            If std_typeEn(0) <> "NULL" Then
                S1pass(nofen + 1) = N1pass(nofen)

            Else
                S1pass(nofen + 1) = S1pass(nofen)
            End If
            ' MsgBox(goto_arg)
            oStartInfoQ.FileName = path_process(nofen)
            oStartInfoQ.Arguments = goto_arg
            oStartInfoQ.UseShellExecute = False
            oStartInfoQ.WindowStyle = ProcessWindowStyle.Hidden
            oStartInfoQ.RedirectStandardError = True
            oStartInfoQ.RedirectStandardOutput = True
            oStartInfoQ.CreateNoWindow = True
            oProcess_Q.StartInfo = oStartInfoQ
            oProcess_Q.Start() 'Start Process

            'ffmpeg uses StandardErrorOut instead of StandardOut
            ffReader = oProcess_Q.StandardError 'Enable Error Checking For FFMPEG.EXE

            Do
                If Bgw1.CancellationPending Then ' Have we pressed Cancel?
                    Exit Sub
                End If

                strFFOUT = ffReader.ReadLine         'read each line from ffreader
                RichTextBox3.Text = "Status : " + parts(nofen) + "  " + strFFOUT
            Loop Until oProcess_Q.HasExited And strFFOUT = Nothing Or strFFOUT = ""

        Next

        ' For nofen = 1 To nOfQueue - 1
        'System.IO.File.Delete(N1pass(nofen))
        '  Next
        ' System.IO.File.Delete(N1pass)
        RichTextBox3.Text = "Status : Completed."

        Panel4.Size = New Size(872, 31)
        ' RichTextBox1.BackColor = Me.BackColor
        ' RichTextBox1.ForeColor = Color.Black
        checkrunn = 0
    End Sub
    Private Sub Enprocess1()

    End Sub
    Private Sub Bgw1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles Bgw1.RunWorkerCompleted
        My.Settings.SaDe = 3
        Form4.Show()
    End Sub
    Private Sub Bgw2_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles Bgw2.RunWorkerCompleted
        My.Settings.SaDe = 3
        Form4.Show()
    End Sub
    Private Sub Bgw3_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles Bgw3.RunWorkerCompleted
        My.Settings.SaDe = 3
        Form4.Show()
    End Sub

    Private Sub Bgw1_DoWork(ByVal sender As System.Object,
    ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Bgw1.DoWork
        Enprocess_2()

    End Sub
    Private Sub Bgw2_DoWork(ByVal sender As System.Object,
    ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Bgw2.DoWork
        Enprocess_3()
    End Sub
    Private Sub Bgw3_DoWork(ByVal sender As System.Object,
    ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Bgw3.DoWork
        Enprocess_4()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        myFileDlog1.InitialDirectory = Logfile
        myFileDlog1.Filter = "All Files (*.*)|*.*" &
            "|AVS Files (*.avs)|*.avs"
        myFileDlog1.FilterIndex = 2
        myFileDlog1.RestoreDirectory = True
        If myFileDlog1.ShowDialog() =
            DialogResult.OK Then
            If Dir(myFileDlog1.FileName) <> "" Then
            Else
            End If
        End If
        TextBox3.Text = myFileDlog1.FileName
        TSave = myFileDlog1.FileName
        Logfile = myFileDlog1.FileName

        TextBox6.Text = myFileDlog1.FileName
        TextBox6.Text = TextBox6.Text.Replace(".avs", "_addsub.mp4")
    End Sub


    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        If checkrunn = 1 Then


        End If
        If checkrunn = 0 Then
            Me.Close()
        End If

        ' Me.Close()


        ' oProcess_Q.Kill()



    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click


        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        TabControl1.SelectedTab = TabPage3
    End Sub
    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        TabControl1.SelectedTab = TabPage4
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click

        ' Dim myStream As Stream *************
        Dim saveFileDialog2 As New SaveFileDialog()

        saveFileDialog2.Filter = "MP4 AAC files (*.mp4)|*.mp4"
        saveFileDialog2.FilterIndex = 2
        saveFileDialog2.RestoreDirectory = True

        If saveFileDialog2.ShowDialog() = DialogResult.OK Then
            '   Dim sw As StreamWriter = New StreamWriter(saveFileDialog2.OpenFile())
            '   If (sw IsNot Nothing) Then
            'sw.WriteLine(TTextBox3)
            ' sw.Close()
            ' End If
        End If
        TextBox8.Text = saveFileDialog2.FileName
        oplog = TextBox8.Text
        oplog = oplog.Replace("\", "/")
        oplog = oplog.Replace(".mp4", ".wav")
        'TSave = saveFileDialog1.FileName
        '    MsgBox(TSave)
        'End Sub
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        myFileDlog1.InitialDirectory = Logfile
        myFileDlog1.Filter = "All Files (*.*)|*.*" &
            "|MP4 Files (*.mp4)|*.mp4" &
            "|MKV Files (*.mkv)|*.mkv"
        myFileDlog1.FilterIndex = 2
        myFileDlog1.RestoreDirectory = True
        If myFileDlog1.ShowDialog() =
            DialogResult.OK Then
            If Dir(myFileDlog1.FileName) <> "" Then
            Else
            End If
        End If
        TextBox7.Text = myFileDlog1.FileName

        iplog = TextBox7.Text
        '  iplog = iplog.Replace("\", "/")
        ' ArDlay = iplog
        '  ArDlay = ArDlay.Replace(".mp4", "_De_audio.mp4")
        '  ArDlay = ArDlay.Replace(".mkv", "_De_audio.mkv")
        TextBox8.Text = myFileDlog1.FileName
        TextBox8.Text = TextBox8.Text.Replace(".mp4", "_audio.mp4")
        TextBox8.Text = TextBox8.Text.Replace(".mkv", "_audio.mp4")
        oplog = TextBox8.Text
        '  oplog = oplog.Replace("\", "/")
        'oplog = oplog.Replace(".mp4", ".wav")
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        checkrunn = 1
        RichTextBox2.Text = "Status : Loading.."
        text_queue = System.IO.File.ReadAllText(".\scripts_aud\" + ComboBox2.SelectedItem.ToString() + ".txt")
        Bgw2.RunWorkerAsync()


    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        myFileDlog1.InitialDirectory = Logfile
        myFileDlog1.Filter = "All Files (*.*)|*.*" &
            "|MP4 Files (*.mp4)|*.mp4" &
            "|MKV Files (*.mkv)|*.mkv"
        myFileDlog1.FilterIndex = 2
        myFileDlog1.RestoreDirectory = True
        If myFileDlog1.ShowDialog() =
            DialogResult.OK Then
            If Dir(myFileDlog1.FileName) <> "" Then
            Else
            End If
        End If
        TextBox9.Text = myFileDlog1.FileName
        Miplog = TextBox9.Text
        Miplog = Miplog.Replace("\", "/")

        TextBox11.Text = TextBox9.Text
        TextBox11.Text = TextBox11.Text.Replace(".mp4", "_muxed [x264 AAC ZIXMAR+Fs].mp4")
        TextBox11.Text = TextBox11.Text.Replace("_addsub", "")
        TextBox11.Text = TextBox11.Text.Replace("_audio", "")
        Moplog = TextBox11.Text
        Moplog = Moplog.Replace("\", "/")


    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        myFileDlog1.InitialDirectory = Logfile
        myFileDlog1.Filter = "All Files (*.*)|*.*" &
            "|MP4 AAC Files (*.mp4)|*.mp4" &
            "|MP4 Audio Files (*.m4a)|*.m4a" &
            "|RAW AAC Files (*.aac)|*.aac" &
            "|MP3 File (*.mp3)|*.mp3" &
            "|MP2 File (*.mp2)|*.mp2"
        myFileDlog1.FilterIndex = 2
        myFileDlog1.RestoreDirectory = True
        If myFileDlog1.ShowDialog() =
            DialogResult.OK Then
            If Dir(myFileDlog1.FileName) <> "" Then
            Else
            End If
        End If
        TextBox10.Text = myFileDlog1.FileName
        M2iplog = TextBox10.Text
        M2iplog = M2iplog.Replace("\", "/")
    End Sub
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Dim saveFileDialog2 As New SaveFileDialog()
        saveFileDialog2.Filter = "MP4 files (*.mp4)|*.mp4" &
            "|MKV Files (*.mkv)|*.mkv"
        saveFileDialog2.FilterIndex = 2
        saveFileDialog2.RestoreDirectory = True
        If saveFileDialog2.ShowDialog() = DialogResult.OK Then
        End If
        TextBox11.Text = saveFileDialog2.FileName
        Moplog = TextBox11.Text
        Moplog = Moplog.Replace("\", "/")
    End Sub
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        checkrunn = 1
        RichTextBox3.Text = "Status : Loading.."
        text_queue = System.IO.File.ReadAllText(".\scripts_etc\" + ComboBox3.SelectedItem.ToString() + ".txt")
        Bgw3.RunWorkerAsync()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("-add """ + Miplog & """ -add """ + M2iplog & """ """ + TextBox11.Text & """")
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

        My.Settings.Enc3 = ComboBox3.SelectedItem.ToString()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        My.Settings.Enc2 = ComboBox2.SelectedItem.ToString()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        My.Settings.Enc = ComboBox1.SelectedItem.ToString()
    End Sub








    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        My.Settings.ComboAvs = ComboBox6.SelectedItem.ToString()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim oForm As Form2
        oForm = New Form2()
        oForm.Show()
    End Sub

    Private Sub ComboBox6_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox6.MouseClick
        ComboBox6.Items.Clear()
        Dim dir = ".\avss"
        For Each file As String In System.IO.Directory.GetFiles(dir)
            ComboBox6.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Dim oForm As Form5
        oForm = New Form5()
        oForm.Show()
        oForm = Nothing
    End Sub


    Private Sub ComboBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox3.MouseClick
        ComboBox3.Items.Clear()
        Dim dir = ".\scripts_etc"
        For Each file As String In System.IO.Directory.GetFiles(dir)
            ComboBox3.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next

    End Sub
    Private Sub ComboBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox2.MouseClick
        ComboBox2.Items.Clear()
        Dim dir = ".\scripts_aud"
        For Each file As String In System.IO.Directory.GetFiles(dir)
            ComboBox2.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        oProcess_Q.Kill()
    End Sub
    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        oProcess_Q.Kill()
    End Sub
    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        oProcess_Q.Kill()
    End Sub

    Private Sub ComboBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox1.MouseClick
        ComboBox1.Items.Clear()
        Dim dir = ".\scripts_vdo"
        For Each file As String In System.IO.Directory.GetFiles(dir)
            ComboBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next

    End Sub



End Class



