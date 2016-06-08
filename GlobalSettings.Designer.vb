<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GlobalSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblPort = New System.Windows.Forms.Label()
        Me.LblIP = New System.Windows.Forms.Label()
        Me.LblLogSet = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSmtpCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.WindowsStartChb = New System.Windows.Forms.CheckBox()
        Me.AutostartChb = New System.Windows.Forms.CheckBox()
        Me.ChbSaveyoLog = New System.Windows.Forms.CheckBox()
        Me.ChBExternal = New System.Windows.Forms.CheckBox()
        Me.TxbCount = New System.Windows.Forms.TextBox()
        Me.TxbIP4 = New System.Windows.Forms.MaskedTextBox()
        Me.TxbIP3 = New System.Windows.Forms.MaskedTextBox()
        Me.TxbIP2 = New System.Windows.Forms.MaskedTextBox()
        Me.TxbIP1 = New System.Windows.Forms.MaskedTextBox()
        Me.TxbPort = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'LblPort
        '
        Me.LblPort.AutoSize = True
        Me.LblPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LblPort.Location = New System.Drawing.Point(23, 228)
        Me.LblPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPort.Name = "LblPort"
        Me.LblPort.Size = New System.Drawing.Size(38, 17)
        Me.LblPort.TabIndex = 47
        Me.LblPort.Text = "Port"
        '
        'LblIP
        '
        Me.LblIP.AutoSize = True
        Me.LblIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LblIP.Location = New System.Drawing.Point(23, 188)
        Me.LblIP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIP.Name = "LblIP"
        Me.LblIP.Size = New System.Drawing.Size(62, 17)
        Me.LblIP.TabIndex = 46
        Me.LblIP.Text = "Start IP"
        '
        'LblLogSet
        '
        Me.LblLogSet.AutoSize = True
        Me.LblLogSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LblLogSet.Location = New System.Drawing.Point(23, 224)
        Me.LblLogSet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLogSet.Name = "LblLogSet"
        Me.LblLogSet.Size = New System.Drawing.Size(0, 17)
        Me.LblLogSet.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 270)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 17)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Number of Zero-Smogs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(23, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(359, 51)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "By default Network configuration is INTERNAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "if you use EXTERNAL network please " & _
    "check the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CheckBox" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnSmtpCancel
        '
        Me.BtnSmtpCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSmtpCancel.Location = New System.Drawing.Point(282, 315)
        Me.BtnSmtpCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSmtpCancel.Name = "BtnSmtpCancel"
        Me.BtnSmtpCancel.Size = New System.Drawing.Size(100, 28)
        Me.BtnSmtpCancel.TabIndex = 12
        Me.BtnSmtpCancel.Text = "Cancel"
        Me.BtnSmtpCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(27, 310)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 28)
        Me.BtnSave.TabIndex = 11
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'WindowsStartChb
        '
        Me.WindowsStartChb.AutoSize = True
        Me.WindowsStartChb.Checked = Global.wellerZS.My.MySettings.Default.StartWithWinCHb
        Me.WindowsStartChb.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "StartWithWinCHb", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.WindowsStartChb.Location = New System.Drawing.Point(25, 13)
        Me.WindowsStartChb.Margin = New System.Windows.Forms.Padding(4)
        Me.WindowsStartChb.Name = "WindowsStartChb"
        Me.WindowsStartChb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WindowsStartChb.Size = New System.Drawing.Size(208, 21)
        Me.WindowsStartChb.TabIndex = 1
        Me.WindowsStartChb.Text = "Start aplication with windows"
        Me.WindowsStartChb.UseVisualStyleBackColor = True
        '
        'AutostartChb
        '
        Me.AutostartChb.AutoSize = True
        Me.AutostartChb.Checked = Global.wellerZS.My.MySettings.Default.AutostartChb
        Me.AutostartChb.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "AutostartChb", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AutostartChb.Location = New System.Drawing.Point(25, 35)
        Me.AutostartChb.Margin = New System.Windows.Forms.Padding(4)
        Me.AutostartChb.Name = "AutostartChb"
        Me.AutostartChb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AutostartChb.Size = New System.Drawing.Size(218, 21)
        Me.AutostartChb.TabIndex = 2
        Me.AutostartChb.Text = "Start scheduler with aplication"
        Me.AutostartChb.UseVisualStyleBackColor = True
        '
        'ChbSaveyoLog
        '
        Me.ChbSaveyoLog.AutoSize = True
        Me.ChbSaveyoLog.Checked = Global.wellerZS.My.MySettings.Default.checkLog
        Me.ChbSaveyoLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChbSaveyoLog.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "checkLog", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChbSaveyoLog.Location = New System.Drawing.Point(25, 59)
        Me.ChbSaveyoLog.Margin = New System.Windows.Forms.Padding(4)
        Me.ChbSaveyoLog.Name = "ChbSaveyoLog"
        Me.ChbSaveyoLog.Size = New System.Drawing.Size(116, 21)
        Me.ChbSaveyoLog.TabIndex = 3
        Me.ChbSaveyoLog.Text = "Save Log File"
        Me.ChbSaveyoLog.UseVisualStyleBackColor = True
        '
        'ChBExternal
        '
        Me.ChBExternal.AutoSize = True
        Me.ChBExternal.Checked = Global.wellerZS.My.MySettings.Default.ChbExternal
        Me.ChBExternal.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "ChbExternal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChBExternal.Location = New System.Drawing.Point(25, 82)
        Me.ChBExternal.Margin = New System.Windows.Forms.Padding(4)
        Me.ChBExternal.Name = "ChBExternal"
        Me.ChBExternal.Size = New System.Drawing.Size(162, 21)
        Me.ChBExternal.TabIndex = 4
        Me.ChBExternal.Text = "Use external network"
        Me.ChBExternal.UseVisualStyleBackColor = True
        '
        'TxbCount
        '
        Me.TxbCount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "ZerroSmogCount", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TxbCount.Location = New System.Drawing.Point(211, 266)
        Me.TxbCount.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbCount.MaxLength = 2
        Me.TxbCount.Name = "TxbCount"
        Me.TxbCount.Size = New System.Drawing.Size(47, 23)
        Me.TxbCount.TabIndex = 10
        Me.TxbCount.Text = Global.wellerZS.My.MySettings.Default.ZerroSmogCount
        Me.TxbCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxbIP4
        '
        Me.TxbIP4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "ip4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbIP4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TxbIP4.Location = New System.Drawing.Point(259, 186)
        Me.TxbIP4.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbIP4.Mask = "000"
        Me.TxbIP4.Name = "TxbIP4"
        Me.TxbIP4.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxbIP4.Size = New System.Drawing.Size(47, 23)
        Me.TxbIP4.TabIndex = 8
        Me.TxbIP4.Text = Global.wellerZS.My.MySettings.Default.ip4
        Me.TxbIP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxbIP3
        '
        Me.TxbIP3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "ip3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbIP3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TxbIP3.Location = New System.Drawing.Point(203, 186)
        Me.TxbIP3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbIP3.Mask = "000"
        Me.TxbIP3.Name = "TxbIP3"
        Me.TxbIP3.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxbIP3.Size = New System.Drawing.Size(47, 23)
        Me.TxbIP3.TabIndex = 7
        Me.TxbIP3.Text = Global.wellerZS.My.MySettings.Default.ip3
        Me.TxbIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxbIP2
        '
        Me.TxbIP2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "ip2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbIP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TxbIP2.Location = New System.Drawing.Point(147, 186)
        Me.TxbIP2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbIP2.Mask = "000"
        Me.TxbIP2.Name = "TxbIP2"
        Me.TxbIP2.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxbIP2.Size = New System.Drawing.Size(47, 23)
        Me.TxbIP2.TabIndex = 6
        Me.TxbIP2.Text = Global.wellerZS.My.MySettings.Default.ip2
        Me.TxbIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxbIP1
        '
        Me.TxbIP1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "ip1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbIP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TxbIP1.Location = New System.Drawing.Point(92, 186)
        Me.TxbIP1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbIP1.Mask = "000"
        Me.TxbIP1.Name = "TxbIP1"
        Me.TxbIP1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxbIP1.Size = New System.Drawing.Size(47, 23)
        Me.TxbIP1.TabIndex = 5
        Me.TxbIP1.Text = Global.wellerZS.My.MySettings.Default.ip1
        Me.TxbIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxbPort
        '
        Me.TxbPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "Port", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TxbPort.Location = New System.Drawing.Point(92, 224)
        Me.TxbPort.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbPort.Mask = "000000"
        Me.TxbPort.Name = "TxbPort"
        Me.TxbPort.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxbPort.Size = New System.Drawing.Size(101, 23)
        Me.TxbPort.TabIndex = 9
        Me.TxbPort.Text = Global.wellerZS.My.MySettings.Default.Port
        Me.TxbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NetwokSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 356)
        Me.Controls.Add(Me.WindowsStartChb)
        Me.Controls.Add(Me.BtnSmtpCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.AutostartChb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChbSaveyoLog)
        Me.Controls.Add(Me.ChBExternal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxbCount)
        Me.Controls.Add(Me.TxbIP4)
        Me.Controls.Add(Me.TxbIP3)
        Me.Controls.Add(Me.TxbIP2)
        Me.Controls.Add(Me.TxbIP1)
        Me.Controls.Add(Me.TxbPort)
        Me.Controls.Add(Me.LblPort)
        Me.Controls.Add(Me.LblIP)
        Me.Controls.Add(Me.LblLogSet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "NetwokSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Global Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxbIP4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxbIP3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxbIP2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxbIP1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxbPort As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblPort As System.Windows.Forms.Label
    Friend WithEvents LblIP As System.Windows.Forms.Label
    Friend WithEvents LblLogSet As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxbCount As System.Windows.Forms.TextBox
    Friend WithEvents AutostartChb As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChbSaveyoLog As System.Windows.Forms.CheckBox
    Friend WithEvents ChBExternal As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSmtpCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents WindowsStartChb As System.Windows.Forms.CheckBox
End Class
