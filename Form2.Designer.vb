<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSMTP
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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnSmtpCancel = New System.Windows.Forms.Button()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.LblEmailAdress = New System.Windows.Forms.Label()
        Me.LblSMTPServPort = New System.Windows.Forms.Label()
        Me.LblSMTPServ = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnTest = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.ChbDebug = New System.Windows.Forms.CheckBox()
        Me.ChbUseSSL = New System.Windows.Forms.CheckBox()
        Me.ChbEncrypt = New System.Windows.Forms.CheckBox()
        Me.ChbAuth = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ChBEmailCable = New System.Windows.Forms.CheckBox()
        Me.ChBEmail50 = New System.Windows.Forms.CheckBox()
        Me.ChBEmail80 = New System.Windows.Forms.CheckBox()
        Me.TxbPass = New System.Windows.Forms.TextBox()
        Me.TxBUserEmail = New System.Windows.Forms.TextBox()
        Me.TxbSMTPPort = New System.Windows.Forms.TextBox()
        Me.TxbSMTPServ = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(20, 455)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 28)
        Me.BtnSave.TabIndex = 14
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnSmtpCancel
        '
        Me.BtnSmtpCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSmtpCancel.Location = New System.Drawing.Point(300, 455)
        Me.BtnSmtpCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSmtpCancel.Name = "BtnSmtpCancel"
        Me.BtnSmtpCancel.Size = New System.Drawing.Size(100, 28)
        Me.BtnSmtpCancel.TabIndex = 16
        Me.BtnSmtpCancel.Text = "Cancel"
        Me.BtnSmtpCancel.UseVisualStyleBackColor = True
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Location = New System.Drawing.Point(47, 87)
        Me.LblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(69, 17)
        Me.LblPass.TabIndex = 22
        Me.LblPass.Text = "Password"
        '
        'LblEmailAdress
        '
        Me.LblEmailAdress.AutoSize = True
        Me.LblEmailAdress.Location = New System.Drawing.Point(47, 30)
        Me.LblEmailAdress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEmailAdress.Name = "LblEmailAdress"
        Me.LblEmailAdress.Size = New System.Drawing.Size(83, 17)
        Me.LblEmailAdress.TabIndex = 21
        Me.LblEmailAdress.Text = "E-mail From"
        '
        'LblSMTPServPort
        '
        Me.LblSMTPServPort.AutoSize = True
        Me.LblSMTPServPort.Location = New System.Drawing.Point(47, 178)
        Me.LblSMTPServPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSMTPServPort.Name = "LblSMTPServPort"
        Me.LblSMTPServPort.Size = New System.Drawing.Size(122, 17)
        Me.LblSMTPServPort.TabIndex = 18
        Me.LblSMTPServPort.Text = "SMTP Server Port"
        '
        'LblSMTPServ
        '
        Me.LblSMTPServ.AutoSize = True
        Me.LblSMTPServ.Location = New System.Drawing.Point(47, 149)
        Me.LblSMTPServ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSMTPServ.Name = "LblSMTPServ"
        Me.LblSMTPServ.Size = New System.Drawing.Size(92, 17)
        Me.LblSMTPServ.TabIndex = 16
        Me.LblSMTPServ.Text = "SMTP Server"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Copyright ©Avdor-Helet 2016"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 227)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(368, 34)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "If You use Gmail,disable some security settings on page " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://www.google.com/" & _
    "settings/security/lesssecureapps."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 119)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "E-mail to"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = """Text files (*.txt)|*.txt"""
        '
        'BtnTest
        '
        Me.BtnTest.Location = New System.Drawing.Point(13, 306)
        Me.BtnTest.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTest.Name = "BtnTest"
        Me.BtnTest.Size = New System.Drawing.Size(100, 36)
        Me.BtnTest.TabIndex = 10
        Me.BtnTest.Text = "Test"
        Me.BtnTest.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(131, 455)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(161, 28)
        Me.BtnReset.TabIndex = 15
        Me.BtnReset.Text = "Reset Settings"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(137, 316)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(48, 17)
        Me.LblStatus.TabIndex = 45
        Me.LblStatus.Text = "Status"
        '
        'ChbDebug
        '
        Me.ChbDebug.AutoSize = True
        Me.ChbDebug.Checked = Global.wellerZS.My.MySettings.Default.ChbDebug
        Me.ChbDebug.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "ChbDebug", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChbDebug.Location = New System.Drawing.Point(13, 278)
        Me.ChbDebug.Name = "ChbDebug"
        Me.ChbDebug.Size = New System.Drawing.Size(201, 21)
        Me.ChbDebug.TabIndex = 9
        Me.ChbDebug.Text = "Test Debug Message Error"
        Me.ChbDebug.UseVisualStyleBackColor = True
        '
        'ChbUseSSL
        '
        Me.ChbUseSSL.AutoSize = True
        Me.ChbUseSSL.Checked = Global.wellerZS.My.MySettings.Default.ChbUseSSL
        Me.ChbUseSSL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChbUseSSL.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "ChbUseSSL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChbUseSSL.Location = New System.Drawing.Point(13, 203)
        Me.ChbUseSSL.Name = "ChbUseSSL"
        Me.ChbUseSSL.Size = New System.Drawing.Size(85, 21)
        Me.ChbUseSSL.TabIndex = 8
        Me.ChbUseSSL.Text = "Use SSL"
        Me.ChbUseSSL.UseVisualStyleBackColor = True
        '
        'ChbEncrypt
        '
        Me.ChbEncrypt.AutoSize = True
        Me.ChbEncrypt.Checked = Global.wellerZS.My.MySettings.Default.ChbEncrypt
        Me.ChbEncrypt.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "ChbEncrypt", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChbEncrypt.Location = New System.Drawing.Point(333, 85)
        Me.ChbEncrypt.Name = "ChbEncrypt"
        Me.ChbEncrypt.Size = New System.Drawing.Size(78, 21)
        Me.ChbEncrypt.TabIndex = 4
        Me.ChbEncrypt.Text = "Encrypt"
        Me.ChbEncrypt.UseVisualStyleBackColor = True
        '
        'ChbAuth
        '
        Me.ChbAuth.AutoSize = True
        Me.ChbAuth.Checked = Global.wellerZS.My.MySettings.Default.UseAuth
        Me.ChbAuth.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChbAuth.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "UseAuth", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChbAuth.Location = New System.Drawing.Point(13, 50)
        Me.ChbAuth.Name = "ChbAuth"
        Me.ChbAuth.Size = New System.Drawing.Size(149, 21)
        Me.ChbAuth.TabIndex = 2
        Me.ChbAuth.Text = "Use Authentication"
        Me.ChbAuth.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.AcceptsTab = True
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "RecipientEml", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(191, 114)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.MaxLength = 150
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 22)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = Global.wellerZS.My.MySettings.Default.RecipientEml
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChBEmailCable
        '
        Me.ChBEmailCable.AutoSize = True
        Me.ChBEmailCable.Checked = Global.wellerZS.My.MySettings.Default.ChBEmailCable
        Me.ChBEmailCable.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "ChBEmailCable", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChBEmailCable.Location = New System.Drawing.Point(13, 415)
        Me.ChBEmailCable.Margin = New System.Windows.Forms.Padding(4)
        Me.ChBEmailCable.Name = "ChBEmailCable"
        Me.ChBEmailCable.Size = New System.Drawing.Size(238, 21)
        Me.ChBEmailCable.TabIndex = 13
        Me.ChBEmailCable.Text = "Send E-mail if problem with cable"
        Me.ChBEmailCable.UseVisualStyleBackColor = True
        '
        'ChBEmail50
        '
        Me.ChBEmail50.AutoSize = True
        Me.ChBEmail50.Checked = Global.wellerZS.My.MySettings.Default.ChBEmail50
        Me.ChBEmail50.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChBEmail50.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "ChBEmail50", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChBEmail50.Location = New System.Drawing.Point(13, 386)
        Me.ChBEmail50.Margin = New System.Windows.Forms.Padding(4)
        Me.ChBEmail50.Name = "ChBEmail50"
        Me.ChBEmail50.Size = New System.Drawing.Size(199, 21)
        Me.ChBEmail50.TabIndex = 12
        Me.ChBEmail50.Text = "Send E-mail if red led is on"
        Me.ChBEmail50.UseVisualStyleBackColor = True
        '
        'ChBEmail80
        '
        Me.ChBEmail80.AutoSize = True
        Me.ChBEmail80.Checked = Global.wellerZS.My.MySettings.Default.ChBEmail80
        Me.ChBEmail80.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChBEmail80.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "ChBEmail80", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChBEmail80.Location = New System.Drawing.Point(13, 357)
        Me.ChBEmail80.Margin = New System.Windows.Forms.Padding(4)
        Me.ChBEmail80.Name = "ChBEmail80"
        Me.ChBEmail80.Size = New System.Drawing.Size(216, 21)
        Me.ChBEmail80.TabIndex = 11
        Me.ChBEmail80.Text = "Send E-mail if yellow led is on"
        Me.ChBEmail80.UseVisualStyleBackColor = True
        '
        'TxbPass
        '
        Me.TxbPass.AcceptsReturn = True
        Me.TxbPass.AcceptsTab = True
        Me.TxbPass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "SmtpPass", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbPass.Location = New System.Drawing.Point(191, 84)
        Me.TxbPass.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbPass.MaxLength = 150
        Me.TxbPass.Name = "TxbPass"
        Me.TxbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxbPass.Size = New System.Drawing.Size(135, 22)
        Me.TxbPass.TabIndex = 3
        Me.TxbPass.Text = Global.wellerZS.My.MySettings.Default.SmtpPass
        Me.TxbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxBUserEmail
        '
        Me.TxBUserEmail.AcceptsReturn = True
        Me.TxBUserEmail.AcceptsTab = True
        Me.TxBUserEmail.AllowDrop = True
        Me.TxBUserEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "SmtpUser", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxBUserEmail.Location = New System.Drawing.Point(191, 27)
        Me.TxBUserEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxBUserEmail.MaxLength = 150
        Me.TxBUserEmail.Name = "TxBUserEmail"
        Me.TxBUserEmail.Size = New System.Drawing.Size(209, 22)
        Me.TxBUserEmail.TabIndex = 1
        Me.TxBUserEmail.Text = Global.wellerZS.My.MySettings.Default.SmtpUser
        Me.TxBUserEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxbSMTPPort
        '
        Me.TxbSMTPPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "SMTPServerPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbSMTPPort.Location = New System.Drawing.Point(191, 175)
        Me.TxbSMTPPort.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbSMTPPort.MaxLength = 5
        Me.TxbSMTPPort.Name = "TxbSMTPPort"
        Me.TxbSMTPPort.Size = New System.Drawing.Size(209, 22)
        Me.TxbSMTPPort.TabIndex = 7
        Me.TxbSMTPPort.Text = Global.wellerZS.My.MySettings.Default.SMTPServerPort
        Me.TxbSMTPPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxbSMTPServ
        '
        Me.TxbSMTPServ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.wellerZS.My.MySettings.Default, "SMTPServer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxbSMTPServ.Location = New System.Drawing.Point(191, 146)
        Me.TxbSMTPServ.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbSMTPServ.MaxLength = 150
        Me.TxbSMTPServ.Name = "TxbSMTPServ"
        Me.TxbSMTPServ.Size = New System.Drawing.Size(209, 22)
        Me.TxbSMTPServ.TabIndex = 6
        Me.TxbSMTPServ.Text = Global.wellerZS.My.MySettings.Default.SMTPServer
        Me.TxbSMTPServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormSMTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnSmtpCancel
        Me.ClientSize = New System.Drawing.Size(432, 491)
        Me.Controls.Add(Me.ChbDebug)
        Me.Controls.Add(Me.ChbUseSSL)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.ChbEncrypt)
        Me.Controls.Add(Me.ChbAuth)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnTest)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChBEmailCable)
        Me.Controls.Add(Me.ChBEmail50)
        Me.Controls.Add(Me.ChBEmail80)
        Me.Controls.Add(Me.TxbPass)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.LblEmailAdress)
        Me.Controls.Add(Me.TxBUserEmail)
        Me.Controls.Add(Me.TxbSMTPPort)
        Me.Controls.Add(Me.LblSMTPServPort)
        Me.Controls.Add(Me.TxbSMTPServ)
        Me.Controls.Add(Me.LblSMTPServ)
        Me.Controls.Add(Me.BtnSmtpCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormSMTP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Email Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnSmtpCancel As System.Windows.Forms.Button
    Friend WithEvents TxbPass As System.Windows.Forms.TextBox
    Friend WithEvents LblPass As System.Windows.Forms.Label
    Friend WithEvents LblEmailAdress As System.Windows.Forms.Label
    Friend WithEvents TxBUserEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxbSMTPPort As System.Windows.Forms.TextBox
    Friend WithEvents LblSMTPServPort As System.Windows.Forms.Label
    Friend WithEvents TxbSMTPServ As System.Windows.Forms.TextBox
    Friend WithEvents LblSMTPServ As System.Windows.Forms.Label
    Friend WithEvents ChBEmail80 As System.Windows.Forms.CheckBox
    Friend WithEvents ChBEmail50 As System.Windows.Forms.CheckBox
    Friend WithEvents ChBEmailCable As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnTest As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents ChbAuth As System.Windows.Forms.CheckBox
    Friend WithEvents ChbEncrypt As System.Windows.Forms.CheckBox
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents ChbUseSSL As System.Windows.Forms.CheckBox
    Friend WithEvents ChbDebug As System.Windows.Forms.CheckBox
End Class
