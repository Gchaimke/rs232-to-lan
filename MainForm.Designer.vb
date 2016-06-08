<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.LblHostIp = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TxbLog = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblError = New System.Windows.Forms.Label()
        Me.BtnCHeckNow = New System.Windows.Forms.Button()
        Me.ChbShowLog = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LvMashines = New System.Windows.Forms.ListView()
        Me.ChIp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LblEmlStatus = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GlobalSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchedulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageMashineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvdorhltcomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuRightClick.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnStart
        '
        Me.BtnStart.BackColor = System.Drawing.Color.LightGreen
        Me.BtnStart.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.Location = New System.Drawing.Point(10, 46)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(90, 28)
        Me.BtnStart.TabIndex = 0
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'LblHostIp
        '
        Me.LblHostIp.AutoSize = True
        Me.LblHostIp.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHostIp.Location = New System.Drawing.Point(7, 318)
        Me.LblHostIp.Name = "LblHostIp"
        Me.LblHostIp.Size = New System.Drawing.Size(90, 16)
        Me.LblHostIp.TabIndex = 4
        Me.LblHostIp.Text = "Local Host IP"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TxbLog
        '
        Me.TxbLog.AcceptsReturn = True
        Me.TxbLog.AcceptsTab = True
        Me.TxbLog.AllowDrop = True
        Me.TxbLog.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TxbLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TxbLog.Location = New System.Drawing.Point(10, 82)
        Me.TxbLog.MaxLength = 10000
        Me.TxbLog.Multiline = True
        Me.TxbLog.Name = "TxbLog"
        Me.TxbLog.ReadOnly = True
        Me.TxbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbLog.Size = New System.Drawing.Size(548, 234)
        Me.TxbLog.TabIndex = 100
        Me.TxbLog.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.MenuRightClick
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Weller Zero-Smog"
        Me.NotifyIcon1.Visible = True
        '
        'MenuRightClick
        '
        Me.MenuRightClick.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.RestoreToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuRightClick.Name = "Menu"
        Me.MenuRightClick.Size = New System.Drawing.Size(114, 70)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.ForeColor = System.Drawing.Color.DarkGreen
        Me.LblError.Location = New System.Drawing.Point(216, 43)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(48, 16)
        Me.LblError.TabIndex = 47
        Me.LblError.Text = "Status"
        '
        'BtnCHeckNow
        '
        Me.BtnCHeckNow.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnCHeckNow.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCHeckNow.Location = New System.Drawing.Point(106, 46)
        Me.BtnCHeckNow.Name = "BtnCHeckNow"
        Me.BtnCHeckNow.Size = New System.Drawing.Size(87, 28)
        Me.BtnCHeckNow.TabIndex = 1
        Me.BtnCHeckNow.Text = "Check Now"
        Me.BtnCHeckNow.UseVisualStyleBackColor = True
        '
        'ChbShowLog
        '
        Me.ChbShowLog.AutoSize = True
        Me.ChbShowLog.Location = New System.Drawing.Point(488, 62)
        Me.ChbShowLog.Name = "ChbShowLog"
        Me.ChbShowLog.Size = New System.Drawing.Size(74, 17)
        Me.ChbShowLog.TabIndex = 5
        Me.ChbShowLog.Text = "Show Log"
        Me.ChbShowLog.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(378, 318)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(180, 21)
        Me.ProgressBar1.TabIndex = 52
        '
        'LvMashines
        '
        Me.LvMashines.AllowColumnReorder = True
        Me.LvMashines.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIp, Me.ChStatus, Me.ChTime})
        Me.LvMashines.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvMashines.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvMashines.Location = New System.Drawing.Point(10, 80)
        Me.LvMashines.MultiSelect = False
        Me.LvMashines.Name = "LvMashines"
        Me.LvMashines.Size = New System.Drawing.Size(548, 234)
        Me.LvMashines.TabIndex = 11
        Me.LvMashines.UseCompatibleStateImageBehavior = False
        Me.LvMashines.View = System.Windows.Forms.View.Details
        '
        'ChIp
        '
        Me.ChIp.Text = "Machine ip"
        Me.ChIp.Width = 150
        '
        'ChStatus
        '
        Me.ChStatus.Text = "Last Status"
        Me.ChStatus.Width = 150
        '
        'ChTime
        '
        Me.ChTime.Text = "Last time checked"
        Me.ChTime.Width = 197
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'LblEmlStatus
        '
        Me.LblEmlStatus.AutoSize = True
        Me.LblEmlStatus.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmlStatus.ForeColor = System.Drawing.Color.DarkGreen
        Me.LblEmlStatus.Location = New System.Drawing.Point(216, 62)
        Me.LblEmlStatus.Name = "LblEmlStatus"
        Me.LblEmlStatus.Size = New System.Drawing.Size(48, 16)
        Me.LblEmlStatus.TabIndex = 47
        Me.LblEmlStatus.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(572, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearLogToolStripMenuItem, Me.ExportLogToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ClearLogToolStripMenuItem
        '
        Me.ClearLogToolStripMenuItem.Name = "ClearLogToolStripMenuItem"
        Me.ClearLogToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ClearLogToolStripMenuItem.Text = "Clear Log window"
        '
        'ExportLogToolStripMenuItem
        '
        Me.ExportLogToolStripMenuItem.Name = "ExportLogToolStripMenuItem"
        Me.ExportLogToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ExportLogToolStripMenuItem.Text = "Export Log"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GlobalSettingsToolStripMenuItem, Me.EmailOptionsToolStripMenuItem, Me.SchedulerToolStripMenuItem, Me.ManageMashineToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Settings"
        '
        'GlobalSettingsToolStripMenuItem
        '
        Me.GlobalSettingsToolStripMenuItem.Name = "GlobalSettingsToolStripMenuItem"
        Me.GlobalSettingsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.GlobalSettingsToolStripMenuItem.Text = "Global Settings"
        '
        'EmailOptionsToolStripMenuItem
        '
        Me.EmailOptionsToolStripMenuItem.Name = "EmailOptionsToolStripMenuItem"
        Me.EmailOptionsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.EmailOptionsToolStripMenuItem.Text = "Email Settings"
        '
        'SchedulerToolStripMenuItem
        '
        Me.SchedulerToolStripMenuItem.Name = "SchedulerToolStripMenuItem"
        Me.SchedulerToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SchedulerToolStripMenuItem.Text = "Scheduler"
        '
        'ManageMashineToolStripMenuItem
        '
        Me.ManageMashineToolStripMenuItem.Name = "ManageMashineToolStripMenuItem"
        Me.ManageMashineToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ManageMashineToolStripMenuItem.Text = "Manage Machine"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutProgramToolStripMenuItem, Me.AvdorhltcomToolStripMenuItem})
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'AboutProgramToolStripMenuItem
        '
        Me.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem"
        Me.AboutProgramToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AboutProgramToolStripMenuItem.Text = "About program"
        '
        'AvdorhltcomToolStripMenuItem
        '
        Me.AvdorhltcomToolStripMenuItem.Name = "AvdorhltcomToolStripMenuItem"
        Me.AvdorhltcomToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AvdorhltcomToolStripMenuItem.Text = "Avdor-hlt.com"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(410, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Copyright ©Avdor-Helet 2016"
        '
        'FormMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(572, 349)
        Me.ContextMenuStrip = Me.MenuRightClick
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ChbShowLog)
        Me.Controls.Add(Me.BtnCHeckNow)
        Me.Controls.Add(Me.LblEmlStatus)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.LblHostIp)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.TxbLog)
        Me.Controls.Add(Me.LvMashines)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(586, 392)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weller Zero-Smog"
        Me.MenuRightClick.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents LblHostIp As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TxbLog As System.Windows.Forms.TextBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents MenuRightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblError As System.Windows.Forms.Label
    Friend WithEvents BtnCHeckNow As System.Windows.Forms.Button
    Friend WithEvents ChbShowLog As CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LvMashines As ListView
    Friend WithEvents ChIp As ColumnHeader
    Friend WithEvents ChStatus As ColumnHeader
    Friend WithEvents ChTime As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LblEmlStatus As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchedulerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GlobalSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageMashineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AvdorhltcomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
