<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PowerSettings
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
        Me.TxbIP4 = New System.Windows.Forms.MaskedTextBox()
        Me.TxbIP3 = New System.Windows.Forms.MaskedTextBox()
        Me.TxbIP2 = New System.Windows.Forms.MaskedTextBox()
        Me.TxbIP1 = New System.Windows.Forms.MaskedTextBox()
        Me.TxbPort = New System.Windows.Forms.MaskedTextBox()
        Me.LblPort = New System.Windows.Forms.Label()
        Me.LblIP = New System.Windows.Forms.Label()
        Me.LblLogSet = New System.Windows.Forms.Label()
        Me.pwrOn = New System.Windows.Forms.Button()
        Me.pwrOff = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn30 = New System.Windows.Forms.Button()
        Me.Btn50 = New System.Windows.Forms.Button()
        Me.BtnCheckSpeed = New System.Windows.Forms.Button()
        Me.LblCurentSpeed = New System.Windows.Forms.Label()
        Me.Btn75 = New System.Windows.Forms.Button()
        Me.Btn100 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxbIP4
        '
        Me.TxbIP4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "ip4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbIP4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TxbIP4.Location = New System.Drawing.Point(277, 9)
        Me.TxbIP4.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbIP4.Mask = "000"
        Me.TxbIP4.Name = "TxbIP4"
        Me.TxbIP4.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxbIP4.Size = New System.Drawing.Size(47, 23)
        Me.TxbIP4.TabIndex = 4
        Me.TxbIP4.Text = Global.wellerZS.My.MySettings.Default.ip4
        Me.TxbIP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxbIP3
        '
        Me.TxbIP3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "ip3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbIP3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TxbIP3.Location = New System.Drawing.Point(221, 9)
        Me.TxbIP3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbIP3.Mask = "000"
        Me.TxbIP3.Name = "TxbIP3"
        Me.TxbIP3.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxbIP3.Size = New System.Drawing.Size(47, 23)
        Me.TxbIP3.TabIndex = 3
        Me.TxbIP3.Text = Global.wellerZS.My.MySettings.Default.ip3
        Me.TxbIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxbIP2
        '
        Me.TxbIP2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "ip2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbIP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TxbIP2.Location = New System.Drawing.Point(165, 9)
        Me.TxbIP2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbIP2.Mask = "000"
        Me.TxbIP2.Name = "TxbIP2"
        Me.TxbIP2.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxbIP2.Size = New System.Drawing.Size(47, 23)
        Me.TxbIP2.TabIndex = 2
        Me.TxbIP2.Text = Global.wellerZS.My.MySettings.Default.ip2
        Me.TxbIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxbIP1
        '
        Me.TxbIP1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "ip1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbIP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TxbIP1.Location = New System.Drawing.Point(110, 9)
        Me.TxbIP1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbIP1.Mask = "000"
        Me.TxbIP1.Name = "TxbIP1"
        Me.TxbIP1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxbIP1.Size = New System.Drawing.Size(47, 23)
        Me.TxbIP1.TabIndex = 1
        Me.TxbIP1.Text = Global.wellerZS.My.MySettings.Default.ip1
        Me.TxbIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxbPort
        '
        Me.TxbPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "Port", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TxbPort.Location = New System.Drawing.Point(384, 9)
        Me.TxbPort.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbPort.Mask = "00000"
        Me.TxbPort.Name = "TxbPort"
        Me.TxbPort.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxbPort.Size = New System.Drawing.Size(101, 23)
        Me.TxbPort.TabIndex = 5
        Me.TxbPort.Text = Global.wellerZS.My.MySettings.Default.Port
        Me.TxbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblPort
        '
        Me.LblPort.AutoSize = True
        Me.LblPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LblPort.Location = New System.Drawing.Point(333, 13)
        Me.LblPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPort.Name = "LblPort"
        Me.LblPort.Size = New System.Drawing.Size(38, 17)
        Me.LblPort.TabIndex = 55
        Me.LblPort.Text = "Port"
        '
        'LblIP
        '
        Me.LblIP.AutoSize = True
        Me.LblIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LblIP.Location = New System.Drawing.Point(13, 15)
        Me.LblIP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIP.Name = "LblIP"
        Me.LblIP.Size = New System.Drawing.Size(87, 17)
        Me.LblIP.TabIndex = 54
        Me.LblIP.Text = "Machine IP"
        '
        'LblLogSet
        '
        Me.LblLogSet.AutoSize = True
        Me.LblLogSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LblLogSet.Location = New System.Drawing.Point(315, 9)
        Me.LblLogSet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLogSet.Name = "LblLogSet"
        Me.LblLogSet.Size = New System.Drawing.Size(0, 17)
        Me.LblLogSet.TabIndex = 53
        '
        'pwrOn
        '
        Me.pwrOn.BackColor = System.Drawing.Color.LightGreen
        Me.pwrOn.Location = New System.Drawing.Point(12, 96)
        Me.pwrOn.Name = "pwrOn"
        Me.pwrOn.Size = New System.Drawing.Size(84, 36)
        Me.pwrOn.TabIndex = 7
        Me.pwrOn.Text = "Power On"
        Me.pwrOn.UseVisualStyleBackColor = False
        '
        'pwrOff
        '
        Me.pwrOff.BackColor = System.Drawing.Color.Pink
        Me.pwrOff.Location = New System.Drawing.Point(12, 54)
        Me.pwrOff.Name = "pwrOff"
        Me.pwrOff.Size = New System.Drawing.Size(84, 36)
        Me.pwrOff.TabIndex = 6
        Me.pwrOff.Text = "Power Off"
        Me.pwrOff.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Current speed"
        '
        'Btn30
        '
        Me.Btn30.Location = New System.Drawing.Point(277, 54)
        Me.Btn30.Name = "Btn30"
        Me.Btn30.Size = New System.Drawing.Size(67, 36)
        Me.Btn30.TabIndex = 8
        Me.Btn30.Text = "30%"
        Me.Btn30.UseVisualStyleBackColor = True
        '
        'Btn50
        '
        Me.Btn50.Location = New System.Drawing.Point(350, 54)
        Me.Btn50.Name = "Btn50"
        Me.Btn50.Size = New System.Drawing.Size(67, 36)
        Me.Btn50.TabIndex = 9
        Me.Btn50.Text = "50%"
        Me.Btn50.UseVisualStyleBackColor = True
        '
        'BtnCheckSpeed
        '
        Me.BtnCheckSpeed.Location = New System.Drawing.Point(423, 113)
        Me.BtnCheckSpeed.Name = "BtnCheckSpeed"
        Me.BtnCheckSpeed.Size = New System.Drawing.Size(140, 36)
        Me.BtnCheckSpeed.TabIndex = 12
        Me.BtnCheckSpeed.Text = "Check"
        Me.BtnCheckSpeed.UseVisualStyleBackColor = True
        '
        'LblCurentSpeed
        '
        Me.LblCurentSpeed.AutoSize = True
        Me.LblCurentSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurentSpeed.Location = New System.Drawing.Point(331, 116)
        Me.LblCurentSpeed.Name = "LblCurentSpeed"
        Me.LblCurentSpeed.Size = New System.Drawing.Size(63, 25)
        Me.LblCurentSpeed.TabIndex = 60
        Me.LblCurentSpeed.Text = "100%"
        '
        'Btn75
        '
        Me.Btn75.Location = New System.Drawing.Point(423, 54)
        Me.Btn75.Name = "Btn75"
        Me.Btn75.Size = New System.Drawing.Size(67, 36)
        Me.Btn75.TabIndex = 10
        Me.Btn75.Text = "75%"
        Me.Btn75.UseVisualStyleBackColor = True
        '
        'Btn100
        '
        Me.Btn100.Location = New System.Drawing.Point(496, 54)
        Me.Btn100.Name = "Btn100"
        Me.Btn100.Size = New System.Drawing.Size(67, 36)
        Me.Btn100.TabIndex = 11
        Me.Btn100.Text = "100%"
        Me.Btn100.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Set Fan"
        '
        'PowerSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 182)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn100)
        Me.Controls.Add(Me.Btn75)
        Me.Controls.Add(Me.LblCurentSpeed)
        Me.Controls.Add(Me.BtnCheckSpeed)
        Me.Controls.Add(Me.Btn50)
        Me.Controls.Add(Me.Btn30)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pwrOff)
        Me.Controls.Add(Me.pwrOn)
        Me.Controls.Add(Me.TxbIP4)
        Me.Controls.Add(Me.TxbIP3)
        Me.Controls.Add(Me.TxbIP2)
        Me.Controls.Add(Me.TxbIP1)
        Me.Controls.Add(Me.TxbPort)
        Me.Controls.Add(Me.LblPort)
        Me.Controls.Add(Me.LblIP)
        Me.Controls.Add(Me.LblLogSet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "PowerSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configure Machine"
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
    Friend WithEvents pwrOn As System.Windows.Forms.Button
    Friend WithEvents pwrOff As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn30 As System.Windows.Forms.Button
    Friend WithEvents Btn50 As System.Windows.Forms.Button
    Friend WithEvents BtnCheckSpeed As System.Windows.Forms.Button
    Friend WithEvents LblCurentSpeed As System.Windows.Forms.Label
    Friend WithEvents Btn75 As System.Windows.Forms.Button
    Friend WithEvents Btn100 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
