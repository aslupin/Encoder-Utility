<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.DomainUpDown2 = New System.Windows.Forms.DomainUpDown()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Status2 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Status3 = New System.Windows.Forms.Label()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Process1 = New System.Diagnostics.Process()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Bgw1 = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button4.Location = New System.Drawing.Point(700, 136)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(79, 24)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Save as.."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label2.Location = New System.Drawing.Point(51, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Subtitle File"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label3.Location = New System.Drawing.Point(51, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Raw File"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.TextBox2.Location = New System.Drawing.Point(133, 91)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(528, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.TextBox1.Location = New System.Drawing.Point(133, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(528, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button2.Location = New System.Drawing.Point(700, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button1.Location = New System.Drawing.Point(700, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TabControl1.Location = New System.Drawing.Point(-6, -8)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(882, 269)
        Me.TabControl1.TabIndex = 2
        Me.TabControl1.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage1.CausesValidation = False
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.ComboBox6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(874, 243)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "AVS SET"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label13.Location = New System.Drawing.Point(349, 142)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 12)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "AviSynth scripts"
        '
        'ComboBox6
        '
        Me.ComboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.05!)
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(436, 139)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(225, 20)
        Me.ComboBox6.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label5.Location = New System.Drawing.Point(579, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 12)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "AviSynth Editor ..."
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.ZixF2
        Me.PictureBox1.Location = New System.Drawing.Point(16, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 70)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.TextBox6)
        Me.TabPage2.Controls.Add(Me.Button10)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Button11)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(874, 243)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Encode"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.DimGray
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.55!)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Location = New System.Drawing.Point(30, 212)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(814, 23)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Location = New System.Drawing.Point(-4, 205)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(872, 31)
        Me.Panel2.TabIndex = 49
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.ZixF2
        Me.PictureBox2.Location = New System.Drawing.Point(25, 131)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(215, 60)
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label21.Location = New System.Drawing.Point(467, 134)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 12)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Encoding Mode"
        '
        'ComboBox1
        '
        Me.ComboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.DisplayMember = "Automated 2pass"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComboBox1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ComboBox1.Location = New System.Drawing.Point(550, 131)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox1.TabIndex = 28
        Me.ComboBox1.ValueMember = "Automated 2pass"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label7.Location = New System.Drawing.Point(51, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 12)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Avs input"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.TextBox6.Location = New System.Drawing.Point(134, 93)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(528, 20)
        Me.TextBox6.TabIndex = 19
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button10.Location = New System.Drawing.Point(696, 54)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(78, 24)
        Me.Button10.TabIndex = 25
        Me.Button10.Text = "Browse"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label1.Location = New System.Drawing.Point(51, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Out put"
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button11.Location = New System.Drawing.Point(696, 90)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(78, 24)
        Me.Button11.TabIndex = 21
        Me.Button11.Text = "Save as"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.TextBox3.Location = New System.Drawing.Point(134, 57)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(528, 20)
        Me.TextBox3.TabIndex = 23
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button8.Location = New System.Drawing.Point(696, 128)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(78, 24)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "Queue"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.Status2)
        Me.TabPage3.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(874, 243)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Enc2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox12)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.DomainUpDown2)
        Me.GroupBox3.Controls.Add(Me.ComboBox5)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.ComboBox4)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Button15)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Button12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.Button13)
        Me.GroupBox3.Controls.Add(Me.Button14)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(15, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(620, 151)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Audio Encoding | FFMPEG _ NeroAacEnc"
        '
        'TextBox12
        '
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.5!)
        Me.TextBox12.Location = New System.Drawing.Point(412, 8)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(61, 14)
        Me.TextBox12.TabIndex = 41
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label28.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label28.Location = New System.Drawing.Point(479, 10)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(18, 12)
        Me.Label28.TabIndex = 40
        Me.Label28.Text = "ms"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label27.Location = New System.Drawing.Point(475, 130)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(25, 12)
        Me.Label27.TabIndex = 38
        Me.Label27.Text = "kbps"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.5!)
        Me.CheckBox3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.CheckBox3.Location = New System.Drawing.Point(363, 10)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(43, 13)
        Me.CheckBox3.TabIndex = 39
        Me.CheckBox3.Text = " Delay"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'DomainUpDown2
        '
        Me.DomainUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DomainUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DomainUpDown2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.DomainUpDown2.Items.Add("0.15")
        Me.DomainUpDown2.Items.Add("0.35")
        Me.DomainUpDown2.Items.Add("0.5")
        Me.DomainUpDown2.Items.Add("0.55")
        Me.DomainUpDown2.Items.Add("0.75")
        Me.DomainUpDown2.Items.Add("0.95")
        Me.DomainUpDown2.Items.Add("8000")
        Me.DomainUpDown2.Items.Add("9000")
        Me.DomainUpDown2.Items.Add("100000")
        Me.DomainUpDown2.Items.Add("128000")
        Me.DomainUpDown2.Items.Add("260000")
        Me.DomainUpDown2.Items.Add("300000")
        Me.DomainUpDown2.Items.Add("320000")
        Me.DomainUpDown2.Items.Add("400000")
        Me.DomainUpDown2.Items.Add("")
        Me.DomainUpDown2.Location = New System.Drawing.Point(383, 125)
        Me.DomainUpDown2.Name = "DomainUpDown2"
        Me.DomainUpDown2.Size = New System.Drawing.Size(86, 20)
        Me.DomainUpDown2.TabIndex = 37
        '
        'ComboBox5
        '
        Me.ComboBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ComboBox5.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox5.DisplayMember = "Automated 2pass"
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.ComboBox5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComboBox5.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ComboBox5.Items.AddRange(New Object() {"LC AAC", "HE AAC", "HEv2 AAC"})
        Me.ComboBox5.Location = New System.Drawing.Point(383, 92)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(70, 20)
        Me.ComboBox5.TabIndex = 36
        Me.ComboBox5.ValueMember = "Automated 2pass"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label26.Location = New System.Drawing.Point(234, 95)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(143, 12)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "| NeroAacEnc Advanced features"
        '
        'ComboBox4
        '
        Me.ComboBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ComboBox4.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox4.DisplayMember = "Automated 2pass"
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.ComboBox4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComboBox4.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ComboBox4.Items.AddRange(New Object() {"VBR", "ABR", "CBR"})
        Me.ComboBox4.Location = New System.Drawing.Point(120, 122)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(84, 20)
        Me.ComboBox4.TabIndex = 34
        Me.ComboBox4.ValueMember = "Automated 2pass"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label25.Location = New System.Drawing.Point(9, 125)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 12)
        Me.Label25.TabIndex = 33
        Me.Label25.Text = "| NeroAacEnc Quality"
        '
        'Button15
        '
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button15.Location = New System.Drawing.Point(519, 89)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(78, 24)
        Me.Button15.TabIndex = 30
        Me.Button15.Text = "Show LogFlie"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label24.Location = New System.Drawing.Point(258, 128)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(119, 12)
        Me.Label24.TabIndex = 31
        Me.Label24.Text = "| NeroAacEnc Audio Bitrate "
        '
        'ComboBox2
        '
        Me.ComboBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox2.DisplayMember = "Automated 2pass"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.ComboBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComboBox2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ComboBox2.Items.AddRange(New Object() {"384 kbps", "160 kbps", "128 kbps", "64 kbps"})
        Me.ComboBox2.Location = New System.Drawing.Point(120, 92)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(84, 20)
        Me.ComboBox2.TabIndex = 29
        Me.ComboBox2.ValueMember = "Automated 2pass"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label22.Location = New System.Drawing.Point(9, 95)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(106, 12)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "| FFMPEG Audio Bitrate "
        '
        'Button12
        '
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button12.Location = New System.Drawing.Point(519, 23)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(78, 24)
        Me.Button12.TabIndex = 25
        Me.Button12.Text = "Browse"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label11.Location = New System.Drawing.Point(9, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 12)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Audio input"
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Location = New System.Drawing.Point(67, 26)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(433, 20)
        Me.TextBox7.TabIndex = 23
        '
        'Button13
        '
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button13.Location = New System.Drawing.Point(519, 122)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(78, 24)
        Me.Button13.TabIndex = 13
        Me.Button13.Text = "Queue"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button14.Location = New System.Drawing.Point(519, 59)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(78, 24)
        Me.Button14.TabIndex = 21
        Me.Button14.Text = "Save as"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label12.Location = New System.Drawing.Point(9, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 12)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Audio output"
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Location = New System.Drawing.Point(67, 62)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(433, 20)
        Me.TextBox8.TabIndex = 19
        '
        'Status2
        '
        Me.Status2.AutoSize = True
        Me.Status2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Status2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Status2.Location = New System.Drawing.Point(24, 179)
        Me.Status2.Name = "Status2"
        Me.Status2.Size = New System.Drawing.Size(48, 12)
        Me.Status2.TabIndex = 26
        Me.Status2.Text = "[Status] : -"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(874, 243)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Mux"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button20)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TextBox11)
        Me.GroupBox4.Controls.Add(Me.Status3)
        Me.GroupBox4.Controls.Add(Me.Button16)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.TextBox9)
        Me.GroupBox4.Controls.Add(Me.Button17)
        Me.GroupBox4.Controls.Add(Me.Button18)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Button19)
        Me.GroupBox4.Controls.Add(Me.TextBox10)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(13, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(620, 170)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Muxer File | MP4BOX"
        '
        'Button20
        '
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button20.Location = New System.Drawing.Point(519, 95)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(78, 24)
        Me.Button20.TabIndex = 29
        Me.Button20.Text = "Save as"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label10.Location = New System.Drawing.Point(5, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 12)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Muxed output"
        '
        'TextBox11
        '
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Location = New System.Drawing.Point(73, 98)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(427, 20)
        Me.TextBox11.TabIndex = 27
        '
        'Status3
        '
        Me.Status3.AutoSize = True
        Me.Status3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Status3.Location = New System.Drawing.Point(257, 135)
        Me.Status3.Name = "Status3"
        Me.Status3.Size = New System.Drawing.Size(48, 12)
        Me.Status3.TabIndex = 26
        Me.Status3.Text = "[Status] : -"
        '
        'Button16
        '
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button16.Location = New System.Drawing.Point(519, 23)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(78, 24)
        Me.Button16.TabIndex = 25
        Me.Button16.Text = "Browse"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label17.Location = New System.Drawing.Point(9, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 12)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Video File"
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Location = New System.Drawing.Point(73, 26)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(427, 20)
        Me.TextBox9.TabIndex = 23
        '
        'Button17
        '
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button17.Location = New System.Drawing.Point(519, 129)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(78, 24)
        Me.Button17.TabIndex = 13
        Me.Button17.Text = "Queue"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button18.Location = New System.Drawing.Point(519, 59)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(78, 24)
        Me.Button18.TabIndex = 21
        Me.Button18.Text = "Browse"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label18.Location = New System.Drawing.Point(9, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 12)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Audio File"
        '
        'Button19
        '
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Button19.Location = New System.Drawing.Point(394, 129)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(106, 24)
        Me.Button19.TabIndex = 17
        Me.Button19.Text = "Show LogFlie"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Location = New System.Drawing.Point(73, 62)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(427, 20)
        Me.TextBox10.TabIndex = 19
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Panel1.Location = New System.Drawing.Point(-13, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(870, 27)
        Me.Panel1.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(370, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "AviSynth Editor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(301, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Script Editor"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label31.ForeColor = System.Drawing.SystemColors.Window
        Me.Label31.Location = New System.Drawing.Point(751, 3)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(59, 12)
        Me.Label31.TabIndex = 32
        Me.Label31.Text = "ZIXMAR+Fs"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.Location = New System.Drawing.Point(258, 4)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Muxer"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label30.ForeColor = System.Drawing.SystemColors.Window
        Me.Label30.Location = New System.Drawing.Point(694, 3)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(48, 12)
        Me.Label30.TabIndex = 31
        Me.Label30.Text = "Encoder  : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(175, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Audio Encode "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(92, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Video Encode "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(18, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "AVS Setting"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(841, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(9, 7)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "X"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!)
        Me.Label29.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label29.Location = New System.Drawing.Point(827, 3)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(8, 7)
        Me.Label29.TabIndex = 17
        Me.Label29.Text = "_"
        '
        'Timer1
        '
        '
        'Bgw1
        '
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(854, 248)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zixmar+Fansub Encode Utility Version 0.4"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Status3 As System.Windows.Forms.Label
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents DomainUpDown2 As System.Windows.Forms.DomainUpDown
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Bgw1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Status2 As Label
    Friend WithEvents Label14 As Label
End Class
