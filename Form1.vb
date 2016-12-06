Imports System.IO
Imports System.Security.Permissions
Imports System.Text.RegularExpressions
Imports System.Threading


Public Class Form1

    '
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
    Dim Abit As String
    Dim ab As String
    Dim abb As String
    Dim QMNero As String
    Dim MNero As String
    Dim Q1Nero As String
    Dim BitNero As String
    Dim AFt As String
    Dim useAf As String
    Dim Delay As String
    Dim Dlay As String
    Dim ArDlay As String
    Dim Fcan As Long
    Dim xerNum As Integer
    'Dim TextLabel16 As String



    '-------------------
    '-------------------
    '-------------------
    'AVS SET
    '-------------------  
    '-------------------
    '-------------------
    '-------------------


    'Check used Pic



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
        Dim PathFileAAS_TWO As String = ".\avss\" + My.Settings.ComboAvs + ".avs"
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

        Panel2.Size = New Size(0, 0)
        RichTextBox1.Text = "Status : - "
        RichTextBox1.BackColor = System.Drawing.SystemColors.ControlLight

        Dim oForm As Form3
        oForm = New Form3()
        oForm.Show()
        oForm = Nothing

        TabControl1.Hide()
        Panel1.Hide()
        Label29.Hide()
        Label9.Hide()
        Me.WindowState = FormWindowState.Minimized
        Me.Enabled = False
        Me.Opacity = 0

        ' RichTextBox1.Text = "[Status] : -"
        AFt = My.Settings.AF
        ComboBox5.SelectedItem = AFt
        QMNero = My.Settings.QNero
        ComboBox4.SelectedItem = QMNero
        Abit = My.Settings.Aubit
        ComboBox2.SelectedItem = Abit
        Encmode = My.Settings.Enc
        '  ComboBox1.SelectedItem = Encmode


        ' Form5.ComboBox1.SelectedItem = My.Settings.ComboAvs
        FPS = My.Settings.FPSSave
        BitNero = My.Settings.BitNr
        DomainUpDown2.Text = BitNero
        BitRx264 = My.Settings.Bitx264
        'DomainUpDown1.Text = BitRx264
        Me.CheckBox3.Checked = My.Settings.chk5
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
        '




    End Sub
    Private Sub myForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) _
 Handles MyBase.FormClosing
        My.Settings.FileLog = Logfile
    End Sub
    Private Sub EncodePluginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim URL As String = "http://www.zixmarplus.com/Encode%20Plugin.rar"
        DownloadFile(URL)
    End Sub
    Sub DownloadFile(ByVal URL As String)
        Dim SFD As New SaveFileDialog
        SFD.Filter = "All Files|*.*"
        SFD.FileName = "Encode Plugin.rar"
        If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Using w As New Net.WebClient
                w.DownloadFile(URL, SFD.FileName)
            End Using
        End If
    End Sub
    Private Sub ASEncodeVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim URL As String = "http://www.zixmarplus.com/AS%20Encode.rar"
        DownloadFile2(URL)
    End Sub
    Sub DownloadFile2(ByVal URL As String)
        Dim SFD As New SaveFileDialog
        SFD.Filter = "All Files|*.*"
        SFD.FileName = "AS Encode.rar"
        If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Using w As New Net.WebClient
                w.DownloadFile(URL, SFD.FileName)
            End Using
        End If
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
    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Asss As String

        If p1 = 1 Then
            Asss = "--pass 1 --bitrate " + BitRx264 + " --stats "".stats""" & " --output ""NUL"" " & """" + TSave & """" & Environment.NewLine &
                "--pass 2 --bitrate " + BitRx264 + " --stats "".stats""" & " --output """ + TextBox6.Text & """ " & """" + TSave & """"
        End If
        If p1 = 2 Then
            Asss = "--pass 1 --bitrate " + BitRx264 & " --stats "".stats""" & " --output """ + TextBox6.Text & """ " & """" + TSave & """"
        End If
        If p1 = 3 Then
            Asss = "--bitrate " + BitRx264 & " --output """ + TextBox6.Text & """ """ + TSave & """"

        End If
        ' MsgBox(Asss)
    End Sub
    Shared Function GetProcess(ByVal process As String, ByVal param As String) As String
        Dim p As Process = New Process
        p.StartInfo.FileName = process
        p.StartInfo.Arguments = param
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.Start()
        Dim output As String = p.StandardOutput.ReadToEnd
        p.WaitForExit()
        Return output
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' While Not oProcess.HasExited
        '  Label14.Text = oProcess.StandardOutput.ReadToEnd()
        Dim Thread_process As New Thread(AddressOf Enprocess1) 'Enprocess
        Thread_process.Start()
        ' End While
        'ProgressBar1.Increment(Incre)

    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        text_queue = System.IO.File.ReadAllText(".\scripts\" + ComboBox1.SelectedItem.ToString() + ".txt")

        Bgw1.RunWorkerAsync()
        'Dim T1 As New Thread(AddressOf Enprocess_2) 'Enprocess
        ' T1.Start()






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
                goto_arg = arguments_process(nofen).Replace("out_std", TextBox6.Text).Replace("input_std", S1pass(nofen))
            Else
                goto_arg = arguments_process(nofen).Replace("out_std", N1pass(nofen)).Replace("input_std", S1pass(nofen))
            End If
            S1pass(nofen + 1) = N1pass(nofen)

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
                RichTextBox1.Text = "Status : " + parts(nofen) + "  " + strFFOUT
            Loop Until oProcess_Q.HasExited And strFFOUT = Nothing Or strFFOUT = ""

        Next

        For nofen = 1 To nOfQueue - 1
            System.IO.File.Delete(N1pass(nofen))
        Next
        ' System.IO.File.Delete(N1pass)
        RichTextBox1.Text = "Status : Completed."
        Panel2.Size = New Size(872, 31)
        ' RichTextBox1.BackColor = Me.BackColor
        ' RichTextBox1.ForeColor = Color.Black


    End Sub
    Private Sub Enprocess1()

    End Sub

    Private Sub Bgw1_DoWork(ByVal sender As System.Object,
    ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Bgw1.DoWork
        Enprocess_2()   'run the function to convert
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
        Me.Close()
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
        ArDlay = iplog
        ArDlay = ArDlay.Replace(".mp4", "_De_audio.mp4")
        ArDlay = ArDlay.Replace(".mkv", "_De_audio.mkv")
        TextBox8.Text = myFileDlog1.FileName
        TextBox8.Text = TextBox8.Text.Replace(".mp4", "_audio.mp4")
        TextBox8.Text = TextBox8.Text.Replace(".mkv", "_audio.mp4")
        oplog = TextBox8.Text
        '  oplog = oplog.Replace("\", "/")
        oplog = oplog.Replace(".mp4", ".wav")
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click


        If Delay Mod 2 = 0 Then

            Dim oProcess As New Process()
            Dim oStartInfo As New ProcessStartInfo()
            oStartInfo.FileName = ".\tools\ffmpeg\ffmpeg.exe"
            oStartInfo.Arguments = "-i """ + iplog & """ -ab " + abb & " """ + oplog & """"
            '-i "iplog" -ab abb "oplog"
            oStartInfo.UseShellExecute = False
            oStartInfo.CreateNoWindow = False
            oStartInfo.RedirectStandardOutput = True
            Status2.Text = "[Status] : --FFMPEG | Encoding audio..."
            oProcess.StartInfo = oStartInfo
            oProcess.Start()
            oProcess.WaitForExit()

            oStartInfo.FileName = ".\tools\neroaac\neroAacEnc.exe"
            oStartInfo.Arguments = "-ignorelength " + Q1Nero & " " + BitNero & " " + useAf & " -if """ + oplog & """ -of """ + TextBox8.Text & """"
            '-ignorelength Q1Nero BitNero useAf -if "oplog" -of "TextBox8.Text"
            oStartInfo.UseShellExecute = False
            oStartInfo.CreateNoWindow = False
            oStartInfo.RedirectStandardOutput = True
            Status2.Text = "[Status] : --NeroAacEnc | Encoding audio..."
            oProcess.StartInfo = oStartInfo
            oProcess.Start()
            oProcess.WaitForExit()

            System.IO.File.Delete(oplog)
            Status2.Text = "[Status] : Encoded."

        End If


        If Delay Mod 2 = 1 Then
            Dim oProcess As New Process()
            Dim oStartInfo As New ProcessStartInfo()
            oStartInfo.FileName = ".\tools\mp4box\mp4box.exe"
            oStartInfo.Arguments = "-delay 2=" + Dlay & " -add """ + iplog & """ """ + ArDlay & """"
            oStartInfo.UseShellExecute = False
            oStartInfo.CreateNoWindow = False
            oStartInfo.RedirectStandardOutput = True
            Status2.Text = "[Status] : --MP4BOX | Encoding audio..."
            oProcess.StartInfo = oStartInfo
            oProcess.Start()
            oProcess.WaitForExit()


            oStartInfo.FileName = ".\tools\ffmpeg\ffmpeg.exe"
            oStartInfo.Arguments = "-i """ + ArDlay & """ -ab " + abb & " """ + oplog & """"
            oStartInfo.UseShellExecute = False
            oStartInfo.CreateNoWindow = False
            oStartInfo.RedirectStandardOutput = True
            Status2.Text = "[Status] : --FFMPEG | Encoding audio..."
            oProcess.StartInfo = oStartInfo
            oProcess.Start()
            oProcess.WaitForExit()

            oStartInfo.FileName = ".\tools\neroaac\neroAacEnc.exe"
            oStartInfo.Arguments = "-ignorelength " + Q1Nero & " " + BitNero & " " + useAf & " -if """ + oplog & """ -of """ + TextBox8.Text & """"
            oStartInfo.UseShellExecute = False
            oStartInfo.CreateNoWindow = False
            oStartInfo.RedirectStandardOutput = True
            Status2.Text = "[Status] : --NeroAacEnc | Encoding audio..."
            oProcess.StartInfo = oStartInfo
            oProcess.Start()
            oProcess.WaitForExit()

            System.IO.File.Delete(oplog)
            Status2.Text = "[Status] : Encoded."
        End If


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
        saveFileDialog2.Filter = "MP4 files (*.mp4)|*.mp4"
        saveFileDialog2.FilterIndex = 2
        saveFileDialog2.RestoreDirectory = True
        If saveFileDialog2.ShowDialog() = DialogResult.OK Then
        End If
        TextBox11.Text = saveFileDialog2.FileName
        Moplog = TextBox11.Text
        Moplog = Moplog.Replace("\", "/")
    End Sub
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo()


        oStartInfo.FileName = ".\tools\mp4box\mp4box.exe"
        oStartInfo.Arguments = "-add """ + Miplog & """ -add """ + M2iplog & """ """ + TextBox11.Text & """"
        oStartInfo.UseShellExecute = False
        oStartInfo.CreateNoWindow = False

        oStartInfo.RedirectStandardOutput = True
        Status3.Text = "[Status] : Mux..."
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
        oProcess.WaitForExit()
        Status3.Text = "[Status] : Muxed."
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        MsgBox("-add """ + Miplog & """ -add """ + M2iplog & """ """ + TextBox11.Text & """")
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        My.Settings.Enc = Encmode
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox2.SelectedItem.ToString()
        If ComboBox2.SelectedItem = "384 kbps" Then
            Abit = "384 kbps"
            abb = "384"
            ab = 1

        End If
        If ComboBox2.SelectedItem = "160 kbps" Then
            Abit = "160 kbps"
            abb = "160"
            ab = 2

        End If
        If ComboBox2.SelectedItem = "128 kbps" Then
            Abit = "128 kbps"
            abb = "128"
            ab = 3

        End If
        If ComboBox2.SelectedItem = "64 kbps" Then
            Abit = "64 kbps"
            abb = "64"
            ab = 4

        End If

        My.Settings.Aubit = Abit
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If Delay Mod 2 = 1 Then
            Dim Textau As String = "MP4BOX" & Environment.NewLine &
   "-delay 2=" + Dlay & " -add """ + iplog & """ """ + ArDlay & """" & Environment.NewLine &
 " " & Environment.NewLine &
"FFMPEG" & Environment.NewLine &
               "-i """ + ArDlay & """ -ab " + abb & " """ + oplog & """" & Environment.NewLine &
               " " & Environment.NewLine &
               "NeroAacEnc" & Environment.NewLine &
           "-ignorelength " + Q1Nero & " " + BitNero & " " + useAf & " -if """ + oplog & """ -of """ + TextBox8.Text & """"
            MsgBox(Textau)
        End If
        If Delay Mod 2 = 0 Then
            Dim Textau As String = "FFMPEG" & Environment.NewLine &
               "-i """ + iplog & """ -ab " + abb & " """ + oplog & """" & Environment.NewLine &
               " " & Environment.NewLine &
               "NeroAacEnc" & Environment.NewLine &
           "-ignorelength " + Q1Nero & " " + BitNero & " " + useAf & " -if """ + oplog & """ -of """ + TextBox8.Text & """"
            MsgBox(Textau)
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        ComboBox4.SelectedItem.ToString()
        If ComboBox4.SelectedItem = "VBR" Then
            QMNero = "VBR"
            Q1Nero = "-q"
            ' abb = "384"
            MNero = 1

        End If
        If ComboBox4.SelectedItem = "ABR" Then
            QMNero = "ABR"
            Q1Nero = "-br"
            ' abb = "160"
            MNero = 2

        End If
        If ComboBox4.SelectedItem = "CBR" Then
            QMNero = "CBR"
            Q1Nero = "-cbr"
            'abb = "128"
            MNero = 3

        End If

        My.Settings.QNero = QMNero
    End Sub

    Private Sub DomainUpDown2_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown2.SelectedItemChanged
        BitNero = DomainUpDown2.Text
        My.Settings.BitNr = BitNero
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        ComboBox5.SelectedItem.ToString()
        If ComboBox5.SelectedItem = "LC AAC" Then
            AFt = "LC AAC"
            useAf = "-lc"
            ' abb = "384"
            ' MNero = 1

        End If
        If ComboBox5.SelectedItem = "HE AAC" Then
            AFt = "HE AAC"
            useAf = "-he"
            ' abb = "160"
            ' MNero = 2

        End If
        If ComboBox5.SelectedItem = "HEv2 AAC" Then
            AFt = "HEv2 AAC"
            useAf = "-cbr"
            'abb = "128"
            'MNero = 3

        End If

        My.Settings.AF = AFt
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
#If Delay = 0 Then
        Delay = Delay + 1
#End If
        My.Settings.chk5 = Me.CheckBox3.CheckState
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        Dlay = TextBox12.Text
    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged

        My.Settings.ComboAvs = ComboBox6.SelectedItem.ToString()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim oForm As Form5
        oForm = New Form5()
        oForm.Show()
        oForm = Nothing
    End Sub



    Private Sub ComboBox6_Enter(sender As Object, e As EventArgs) Handles ComboBox6.Enter




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

    Private Sub ComboBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox1.MouseClick
        ComboBox1.Items.Clear()
        Dim dir = ".\scripts"
        For Each file As String In System.IO.Directory.GetFiles(dir)
            ComboBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next

    End Sub
End Class



