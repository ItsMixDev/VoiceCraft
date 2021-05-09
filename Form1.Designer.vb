<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.KeybindTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FilesFolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.MainPage = New System.Windows.Forms.TabPage()
        Me.StopButton = New Guna.UI.WinForms.GunaButton()
        Me.InspectButton = New Guna.UI.WinForms.GunaButton()
        Me.EditButton = New Guna.UI.WinForms.GunaButton()
        Me.ConfidencePercentLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConfidenceTrackBar = New Guna.UI.WinForms.GunaMetroTrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BrowseButton = New Guna.UI.WinForms.GunaButton()
        Me.DirectoryPath = New Guna.UI.WinForms.GunaTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddButton = New Guna.UI.WinForms.GunaButton()
        Me.FileComboBox = New Guna.UI.WinForms.GunaComboBox()
        Me.StartButton = New Guna.UI.WinForms.GunaButton()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.EditorPage = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CommandPhrases = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ActComboBox = New Guna.UI.WinForms.GunaComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LangComboBox = New Guna.UI.WinForms.GunaComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CreateNewButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveAsButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileNameLabel = New System.Windows.Forms.ToolStripLabel()
        Me.AdvancedPage = New System.Windows.Forms.TabPage()
        Me.ShowOutput = New Guna.UI.WinForms.GunaButton()
        Me.EnableNotifications = New Guna.UI.WinForms.GunaGoogleSwitch()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EnableProcessHook = New Guna.UI.WinForms.GunaGoogleSwitch()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MinimizationModes = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NIContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMButton1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMButton2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMButton3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMButton4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMButton5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainPage.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.EditorPage.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.AdvancedPage.SuspendLayout()
        Me.GunaGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NIContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'KeybindTimer
        '
        Me.KeybindTimer.Interval = 10
        '
        'OpenFileDialog1
        '
        resources.ApplyResources(Me.OpenFileDialog1, "OpenFileDialog1")
        Me.OpenFileDialog1.Multiselect = True
        '
        'FilesFolderBrowser
        '
        resources.ApplyResources(Me.FilesFolderBrowser, "FilesFolderBrowser")
        Me.FilesFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'MainPage
        '
        Me.MainPage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MainPage.Controls.Add(Me.StopButton)
        Me.MainPage.Controls.Add(Me.InspectButton)
        Me.MainPage.Controls.Add(Me.EditButton)
        Me.MainPage.Controls.Add(Me.ConfidencePercentLabel)
        Me.MainPage.Controls.Add(Me.Label3)
        Me.MainPage.Controls.Add(Me.ConfidenceTrackBar)
        Me.MainPage.Controls.Add(Me.Label2)
        Me.MainPage.Controls.Add(Me.BrowseButton)
        Me.MainPage.Controls.Add(Me.DirectoryPath)
        Me.MainPage.Controls.Add(Me.Label1)
        Me.MainPage.Controls.Add(Me.AddButton)
        Me.MainPage.Controls.Add(Me.FileComboBox)
        Me.MainPage.Controls.Add(Me.StartButton)
        resources.ApplyResources(Me.MainPage, "MainPage")
        Me.MainPage.Name = "MainPage"
        '
        'StopButton
        '
        Me.StopButton.AnimationHoverSpeed = 0.07!
        Me.StopButton.AnimationSpeed = 0.03!
        Me.StopButton.BackColor = System.Drawing.Color.Transparent
        Me.StopButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.StopButton.BorderColor = System.Drawing.Color.Silver
        Me.StopButton.BorderSize = 2
        Me.StopButton.DialogResult = System.Windows.Forms.DialogResult.None
        resources.ApplyResources(Me.StopButton, "StopButton")
        Me.StopButton.FocusedColor = System.Drawing.Color.Empty
        Me.StopButton.ForeColor = System.Drawing.Color.Black
        Me.StopButton.Image = Global.VoiceCraft.My.Resources.Resources.StopButton
        Me.StopButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.StopButton.ImageOffsetX = -4
        Me.StopButton.ImageSize = New System.Drawing.Size(20, 20)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.StopButton.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.StopButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.StopButton.OnHoverImage = Nothing
        Me.StopButton.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.StopButton.Radius = 2
        Me.StopButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.StopButton.TextOffsetX = -6
        Me.StopButton.UseTransfarantBackground = True
        '
        'InspectButton
        '
        Me.InspectButton.AnimationHoverSpeed = 0.07!
        Me.InspectButton.AnimationSpeed = 0.03!
        Me.InspectButton.BackColor = System.Drawing.Color.Transparent
        Me.InspectButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.InspectButton.BorderColor = System.Drawing.Color.Silver
        Me.InspectButton.BorderSize = 2
        Me.InspectButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.InspectButton.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.InspectButton, "InspectButton")
        Me.InspectButton.ForeColor = System.Drawing.Color.Black
        Me.InspectButton.Image = Nothing
        Me.InspectButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InspectButton.ImageOffsetX = -4
        Me.InspectButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.InspectButton.Name = "InspectButton"
        Me.InspectButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.InspectButton.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.InspectButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.InspectButton.OnHoverImage = Nothing
        Me.InspectButton.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.InspectButton.Radius = 2
        Me.InspectButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InspectButton.TextOffsetX = -6
        Me.InspectButton.UseTransfarantBackground = True
        '
        'EditButton
        '
        Me.EditButton.AnimationHoverSpeed = 0.07!
        Me.EditButton.AnimationSpeed = 0.03!
        Me.EditButton.BackColor = System.Drawing.Color.Transparent
        Me.EditButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.EditButton.BorderColor = System.Drawing.Color.Silver
        Me.EditButton.BorderSize = 2
        Me.EditButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.EditButton.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.EditButton, "EditButton")
        Me.EditButton.ForeColor = System.Drawing.Color.Black
        Me.EditButton.Image = Nothing
        Me.EditButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EditButton.ImageOffsetX = -4
        Me.EditButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.EditButton.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.EditButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.EditButton.OnHoverImage = Nothing
        Me.EditButton.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.EditButton.Radius = 2
        Me.EditButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EditButton.TextOffsetX = -6
        Me.EditButton.UseTransfarantBackground = True
        '
        'ConfidencePercentLabel
        '
        resources.ApplyResources(Me.ConfidencePercentLabel, "ConfidencePercentLabel")
        Me.ConfidencePercentLabel.ForeColor = System.Drawing.Color.Black
        Me.ConfidencePercentLabel.Name = "ConfidencePercentLabel"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'ConfidenceTrackBar
        '
        resources.ApplyResources(Me.ConfidenceTrackBar, "ConfidenceTrackBar")
        Me.ConfidenceTrackBar.Name = "ConfidenceTrackBar"
        Me.ConfidenceTrackBar.SmallChange = 0
        Me.ConfidenceTrackBar.TrackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ConfidenceTrackBar.TrackHoverColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ConfidenceTrackBar.TrackIdleColor = System.Drawing.Color.Silver
        Me.ConfidenceTrackBar.TrackPressedColor = System.Drawing.Color.Cyan
        Me.ConfidenceTrackBar.Value = 30
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'BrowseButton
        '
        Me.BrowseButton.AnimationHoverSpeed = 0.07!
        Me.BrowseButton.AnimationSpeed = 0.03!
        Me.BrowseButton.BackColor = System.Drawing.Color.Transparent
        Me.BrowseButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BrowseButton.BorderColor = System.Drawing.Color.Silver
        Me.BrowseButton.BorderSize = 2
        Me.BrowseButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BrowseButton.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.BrowseButton, "BrowseButton")
        Me.BrowseButton.ForeColor = System.Drawing.Color.Black
        Me.BrowseButton.Image = Nothing
        Me.BrowseButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BrowseButton.ImageOffsetX = -4
        Me.BrowseButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.BrowseButton.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.BrowseButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.BrowseButton.OnHoverImage = Nothing
        Me.BrowseButton.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.BrowseButton.Radius = 2
        Me.BrowseButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BrowseButton.TextOffsetX = -6
        Me.BrowseButton.UseTransfarantBackground = True
        '
        'DirectoryPath
        '
        Me.DirectoryPath.BackColor = System.Drawing.Color.Transparent
        Me.DirectoryPath.BaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.DirectoryPath.BorderColor = System.Drawing.Color.Silver
        Me.DirectoryPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DirectoryPath.FocusedBaseColor = System.Drawing.Color.White
        Me.DirectoryPath.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DirectoryPath.FocusedForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.DirectoryPath, "DirectoryPath")
        Me.DirectoryPath.Name = "DirectoryPath"
        Me.DirectoryPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DirectoryPath.Radius = 2
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'AddButton
        '
        Me.AddButton.AnimationHoverSpeed = 0.07!
        Me.AddButton.AnimationSpeed = 0.03!
        Me.AddButton.BackColor = System.Drawing.Color.Transparent
        Me.AddButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.AddButton.BorderColor = System.Drawing.Color.Silver
        Me.AddButton.BorderSize = 2
        Me.AddButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.AddButton.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.AddButton, "AddButton")
        Me.AddButton.ForeColor = System.Drawing.Color.Black
        Me.AddButton.Image = Nothing
        Me.AddButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AddButton.ImageOffsetX = -4
        Me.AddButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.AddButton.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.AddButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.AddButton.OnHoverImage = Nothing
        Me.AddButton.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.AddButton.Radius = 2
        Me.AddButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AddButton.TextOffsetX = -6
        Me.AddButton.UseTransfarantBackground = True
        '
        'FileComboBox
        '
        Me.FileComboBox.BackColor = System.Drawing.Color.Transparent
        Me.FileComboBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.FileComboBox.BorderColor = System.Drawing.Color.Silver
        Me.FileComboBox.DisplayMember = "0"
        Me.FileComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.FileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FileComboBox.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.FileComboBox, "FileComboBox")
        Me.FileComboBox.ForeColor = System.Drawing.Color.Black
        Me.FileComboBox.FormattingEnabled = True
        Me.FileComboBox.Items.AddRange(New Object() {resources.GetString("FileComboBox.Items")})
        Me.FileComboBox.Name = "FileComboBox"
        Me.FileComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FileComboBox.OnHoverItemForeColor = System.Drawing.Color.White
        Me.FileComboBox.Radius = 2
        Me.FileComboBox.StartIndex = 0
        '
        'StartButton
        '
        Me.StartButton.AnimationHoverSpeed = 0.07!
        Me.StartButton.AnimationSpeed = 0.03!
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.StartButton.BorderColor = System.Drawing.Color.Silver
        Me.StartButton.BorderSize = 2
        Me.StartButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.StartButton.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.StartButton, "StartButton")
        Me.StartButton.ForeColor = System.Drawing.Color.Black
        Me.StartButton.Image = Global.VoiceCraft.My.Resources.Resources.StartButton
        Me.StartButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.StartButton.ImageOffsetX = -4
        Me.StartButton.ImageSize = New System.Drawing.Size(20, 20)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.StartButton.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.StartButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.StartButton.OnHoverImage = Nothing
        Me.StartButton.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.StartButton.Radius = 2
        Me.StartButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.StartButton.TextOffsetX = -6
        Me.StartButton.UseTransfarantBackground = True
        '
        'MainTabControl
        '
        resources.ApplyResources(Me.MainTabControl, "MainTabControl")
        Me.MainTabControl.Controls.Add(Me.MainPage)
        Me.MainTabControl.Controls.Add(Me.EditorPage)
        Me.MainTabControl.Controls.Add(Me.AdvancedPage)
        Me.MainTabControl.HotTrack = True
        Me.MainTabControl.Multiline = True
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        '
        'EditorPage
        '
        Me.EditorPage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EditorPage.Controls.Add(Me.Label5)
        Me.EditorPage.Controls.Add(Me.CommandPhrases)
        Me.EditorPage.Controls.Add(Me.Label6)
        Me.EditorPage.Controls.Add(Me.ActComboBox)
        Me.EditorPage.Controls.Add(Me.Label7)
        Me.EditorPage.Controls.Add(Me.LangComboBox)
        Me.EditorPage.Controls.Add(Me.ToolStrip1)
        resources.ApplyResources(Me.EditorPage, "EditorPage")
        Me.EditorPage.Name = "EditorPage"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Name = "Label5"
        '
        'CommandPhrases
        '
        Me.CommandPhrases.BackColor = System.Drawing.Color.Transparent
        Me.CommandPhrases.BaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.CommandPhrases.BorderColor = System.Drawing.Color.Silver
        Me.CommandPhrases.Cursor = System.Windows.Forms.Cursors.IBeam
        resources.ApplyResources(Me.CommandPhrases, "CommandPhrases")
        Me.CommandPhrases.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.CommandPhrases.FocusedBorderColor = System.Drawing.Color.Silver
        Me.CommandPhrases.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.CommandPhrases.ForeColor = System.Drawing.Color.Black
        Me.CommandPhrases.MultiLine = True
        Me.CommandPhrases.Name = "CommandPhrases"
        Me.CommandPhrases.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CommandPhrases.Radius = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Name = "Label6"
        '
        'ActComboBox
        '
        Me.ActComboBox.BackColor = System.Drawing.Color.Transparent
        Me.ActComboBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ActComboBox.BorderColor = System.Drawing.Color.Silver
        Me.ActComboBox.DisplayMember = "0"
        Me.ActComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ActComboBox.DropDownHeight = 250
        Me.ActComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.ActComboBox, "ActComboBox")
        Me.ActComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.ActComboBox.ForeColor = System.Drawing.Color.Black
        Me.ActComboBox.FormattingEnabled = True
        Me.ActComboBox.Items.AddRange(New Object() {resources.GetString("ActComboBox.Items"), resources.GetString("ActComboBox.Items1"), resources.GetString("ActComboBox.Items2"), resources.GetString("ActComboBox.Items3"), resources.GetString("ActComboBox.Items4"), resources.GetString("ActComboBox.Items5"), resources.GetString("ActComboBox.Items6"), resources.GetString("ActComboBox.Items7"), resources.GetString("ActComboBox.Items8"), resources.GetString("ActComboBox.Items9"), resources.GetString("ActComboBox.Items10"), resources.GetString("ActComboBox.Items11"), resources.GetString("ActComboBox.Items12"), resources.GetString("ActComboBox.Items13"), resources.GetString("ActComboBox.Items14"), resources.GetString("ActComboBox.Items15"), resources.GetString("ActComboBox.Items16"), resources.GetString("ActComboBox.Items17"), resources.GetString("ActComboBox.Items18"), resources.GetString("ActComboBox.Items19"), resources.GetString("ActComboBox.Items20"), resources.GetString("ActComboBox.Items21"), resources.GetString("ActComboBox.Items22"), resources.GetString("ActComboBox.Items23"), resources.GetString("ActComboBox.Items24"), resources.GetString("ActComboBox.Items25"), resources.GetString("ActComboBox.Items26"), resources.GetString("ActComboBox.Items27"), resources.GetString("ActComboBox.Items28"), resources.GetString("ActComboBox.Items29")})
        Me.ActComboBox.Name = "ActComboBox"
        Me.ActComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ActComboBox.OnHoverItemForeColor = System.Drawing.Color.White
        Me.ActComboBox.Radius = 2
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Name = "Label7"
        '
        'LangComboBox
        '
        Me.LangComboBox.BackColor = System.Drawing.Color.Transparent
        Me.LangComboBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.LangComboBox.BorderColor = System.Drawing.Color.Silver
        Me.LangComboBox.DisplayMember = "0"
        Me.LangComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.LangComboBox.DropDownHeight = 225
        Me.LangComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LangComboBox.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.LangComboBox, "LangComboBox")
        Me.LangComboBox.ForeColor = System.Drawing.Color.Black
        Me.LangComboBox.FormattingEnabled = True
        Me.LangComboBox.Name = "LangComboBox"
        Me.LangComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LangComboBox.OnHoverItemForeColor = System.Drawing.Color.White
        Me.LangComboBox.Radius = 2
        '
        'ToolStrip1
        '
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewButton, Me.OpenButton, Me.SaveButton, Me.SaveAsButton, Me.ToolStripSeparator1, Me.FileNameLabel})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        '
        'CreateNewButton
        '
        Me.CreateNewButton.Image = Global.VoiceCraft.My.Resources.Resources.FileIcon
        resources.ApplyResources(Me.CreateNewButton, "CreateNewButton")
        Me.CreateNewButton.Name = "CreateNewButton"
        '
        'OpenButton
        '
        Me.OpenButton.Image = Global.VoiceCraft.My.Resources.Resources.FolderIcon
        resources.ApplyResources(Me.OpenButton, "OpenButton")
        Me.OpenButton.Name = "OpenButton"
        '
        'SaveButton
        '
        Me.SaveButton.AutoToolTip = False
        Me.SaveButton.Image = Global.VoiceCraft.My.Resources.Resources.SaveIcon
        resources.ApplyResources(Me.SaveButton, "SaveButton")
        Me.SaveButton.Name = "SaveButton"
        '
        'SaveAsButton
        '
        Me.SaveAsButton.AutoToolTip = False
        Me.SaveAsButton.Image = Global.VoiceCraft.My.Resources.Resources.SaveAsIcon
        resources.ApplyResources(Me.SaveAsButton, "SaveAsButton")
        Me.SaveAsButton.Name = "SaveAsButton"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'FileNameLabel
        '
        resources.ApplyResources(Me.FileNameLabel, "FileNameLabel")
        Me.FileNameLabel.AutoToolTip = True
        Me.FileNameLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FileNameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FileNameLabel.Name = "FileNameLabel"
        '
        'AdvancedPage
        '
        Me.AdvancedPage.Controls.Add(Me.ShowOutput)
        Me.AdvancedPage.Controls.Add(Me.EnableNotifications)
        Me.AdvancedPage.Controls.Add(Me.Label10)
        Me.AdvancedPage.Controls.Add(Me.EnableProcessHook)
        Me.AdvancedPage.Controls.Add(Me.Label9)
        Me.AdvancedPage.Controls.Add(Me.Label8)
        Me.AdvancedPage.Controls.Add(Me.MinimizationModes)
        resources.ApplyResources(Me.AdvancedPage, "AdvancedPage")
        Me.AdvancedPage.Name = "AdvancedPage"
        Me.AdvancedPage.UseVisualStyleBackColor = True
        '
        'ShowOutput
        '
        Me.ShowOutput.AnimationHoverSpeed = 0.07!
        Me.ShowOutput.AnimationSpeed = 0.03!
        Me.ShowOutput.BackColor = System.Drawing.Color.Transparent
        Me.ShowOutput.BaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ShowOutput.BorderColor = System.Drawing.Color.Silver
        Me.ShowOutput.BorderSize = 2
        Me.ShowOutput.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ShowOutput.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.ShowOutput, "ShowOutput")
        Me.ShowOutput.ForeColor = System.Drawing.Color.Black
        Me.ShowOutput.Image = Nothing
        Me.ShowOutput.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ShowOutput.ImageOffsetX = -4
        Me.ShowOutput.ImageSize = New System.Drawing.Size(22, 22)
        Me.ShowOutput.Name = "ShowOutput"
        Me.ShowOutput.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.ShowOutput.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.ShowOutput.OnHoverForeColor = System.Drawing.Color.Black
        Me.ShowOutput.OnHoverImage = Nothing
        Me.ShowOutput.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ShowOutput.Radius = 2
        Me.ShowOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ShowOutput.TextOffsetX = -6
        Me.ShowOutput.UseTransfarantBackground = True
        '
        'EnableNotifications
        '
        Me.EnableNotifications.BaseColor = System.Drawing.SystemColors.Control
        Me.EnableNotifications.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.EnableNotifications.CheckedOnColor = System.Drawing.Color.LimeGreen
        Me.EnableNotifications.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        resources.ApplyResources(Me.EnableNotifications, "EnableNotifications")
        Me.EnableNotifications.Name = "EnableNotifications"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Name = "Label10"
        '
        'EnableProcessHook
        '
        Me.EnableProcessHook.BaseColor = System.Drawing.SystemColors.Control
        Me.EnableProcessHook.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.EnableProcessHook.CheckedOnColor = System.Drawing.Color.LimeGreen
        Me.EnableProcessHook.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        resources.ApplyResources(Me.EnableProcessHook, "EnableProcessHook")
        Me.EnableProcessHook.Name = "EnableProcessHook"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Name = "Label9"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Name = "Label8"
        '
        'MinimizationModes
        '
        Me.MinimizationModes.BackColor = System.Drawing.Color.Transparent
        Me.MinimizationModes.BaseColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MinimizationModes.BorderColor = System.Drawing.Color.Silver
        Me.MinimizationModes.DisplayMember = "0"
        Me.MinimizationModes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MinimizationModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MinimizationModes.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.MinimizationModes, "MinimizationModes")
        Me.MinimizationModes.ForeColor = System.Drawing.Color.Black
        Me.MinimizationModes.FormattingEnabled = True
        Me.MinimizationModes.Items.AddRange(New Object() {resources.GetString("MinimizationModes.Items"), resources.GetString("MinimizationModes.Items1"), resources.GetString("MinimizationModes.Items2"), resources.GetString("MinimizationModes.Items3"), resources.GetString("MinimizationModes.Items4")})
        Me.MinimizationModes.Name = "MinimizationModes"
        Me.MinimizationModes.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MinimizationModes.OnHoverItemForeColor = System.Drawing.Color.White
        Me.MinimizationModes.Radius = 2
        Me.MinimizationModes.StartIndex = 1
        '
        'GunaGradientPanel1
        '
        resources.ApplyResources(Me.GunaGradientPanel1, "GunaGradientPanel1")
        Me.GunaGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.SaddleBrown
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.SaddleBrown
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.Chartreuse
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.SaddleBrown
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.VoiceCraft.My.Resources.Resources.Logo
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "vcc"
        resources.ApplyResources(Me.SaveFileDialog1, "SaveFileDialog1")
        Me.SaveFileDialog1.InitialDirectory = "C:\"
        '
        'OpenFileDialog2
        '
        resources.ApplyResources(Me.OpenFileDialog2, "OpenFileDialog2")
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.Filter = "*.vcc"
        Me.FileSystemWatcher1.IncludeSubdirectories = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.ContextMenuStrip = Me.NIContextMenuStrip
        resources.ApplyResources(Me.NotifyIcon1, "NotifyIcon1")
        '
        'NIContextMenuStrip
        '
        Me.NIContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMButton1, Me.ToolStripSeparator2, Me.TSMButton2, Me.TSMButton3, Me.TSMButton4, Me.TSMButton5})
        Me.NIContextMenuStrip.Name = "NIContextMenuStrip"
        resources.ApplyResources(Me.NIContextMenuStrip, "NIContextMenuStrip")
        '
        'TSMButton1
        '
        Me.TSMButton1.Image = Global.VoiceCraft.My.Resources.Resources.StartButton
        Me.TSMButton1.Name = "TSMButton1"
        resources.ApplyResources(Me.TSMButton1, "TSMButton1")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'TSMButton2
        '
        Me.TSMButton2.Name = "TSMButton2"
        resources.ApplyResources(Me.TSMButton2, "TSMButton2")
        '
        'TSMButton3
        '
        Me.TSMButton3.Name = "TSMButton3"
        resources.ApplyResources(Me.TSMButton3, "TSMButton3")
        '
        'TSMButton4
        '
        Me.TSMButton4.Name = "TSMButton4"
        resources.ApplyResources(Me.TSMButton4, "TSMButton4")
        '
        'TSMButton5
        '
        Me.TSMButton5.Name = "TSMButton5"
        resources.ApplyResources(Me.TSMButton5, "TSMButton5")
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Controls.Add(Me.MainTabControl)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.MainPage.ResumeLayout(False)
        Me.MainTabControl.ResumeLayout(False)
        Me.EditorPage.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.AdvancedPage.ResumeLayout(False)
        Me.GunaGradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NIContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KeybindTimer As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FilesFolderBrowser As FolderBrowserDialog
    Friend WithEvents MainPage As TabPage
    Friend WithEvents StopButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents InspectButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents EditButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents ConfidencePercentLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ConfidenceTrackBar As Guna.UI.WinForms.GunaMetroTrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents BrowseButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents DirectoryPath As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents FileComboBox As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents StartButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents MainTabControl As TabControl
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EditorPage As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents FileNameLabel As ToolStripLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents CommandPhrases As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ActComboBox As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LangComboBox As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents CreateNewButton As ToolStripButton
    Friend WithEvents OpenButton As ToolStripButton
    Friend WithEvents SaveButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents NIContextMenuStrip As ContextMenuStrip
    Friend WithEvents TSMButton1 As ToolStripMenuItem
    Friend WithEvents TSMButton2 As ToolStripMenuItem
    Friend WithEvents TSMButton5 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AdvancedPage As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents MinimizationModes As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents EnableNotifications As Guna.UI.WinForms.GunaGoogleSwitch
    Friend WithEvents Label10 As Label
    Friend WithEvents EnableProcessHook As Guna.UI.WinForms.GunaGoogleSwitch
    Friend WithEvents Label9 As Label
    Friend WithEvents ShowOutput As Guna.UI.WinForms.GunaButton
    Friend WithEvents TSMButton3 As ToolStripMenuItem
    Friend WithEvents SaveAsButton As ToolStripButton
    Friend WithEvents TSMButton4 As ToolStripMenuItem
End Class
