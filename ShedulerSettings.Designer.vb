<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchedulerSettings
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
        Me.BtnSmtpCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.NudShl3 = New System.Windows.Forms.NumericUpDown()
        Me.NudShl2 = New System.Windows.Forms.NumericUpDown()
        Me.NudShl1 = New System.Windows.Forms.NumericUpDown()
        Me.NudShr3 = New System.Windows.Forms.NumericUpDown()
        Me.NudShr2 = New System.Windows.Forms.NumericUpDown()
        Me.NudShr1 = New System.Windows.Forms.NumericUpDown()
        Me.ChbShedule3 = New System.Windows.Forms.CheckBox()
        Me.ChbShedule2 = New System.Windows.Forms.CheckBox()
        Me.ChbShedule1 = New System.Windows.Forms.CheckBox()
        CType(Me.NudShl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudShl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudShl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudShr3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudShr2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudShr1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSmtpCancel
        '
        Me.BtnSmtpCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSmtpCancel.Location = New System.Drawing.Point(165, 153)
        Me.BtnSmtpCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSmtpCancel.Name = "BtnSmtpCancel"
        Me.BtnSmtpCancel.Size = New System.Drawing.Size(100, 28)
        Me.BtnSmtpCancel.TabIndex = 11
        Me.BtnSmtpCancel.Text = "Cancel"
        Me.BtnSmtpCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(23, 153)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 28)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'NudShl3
        '
        Me.NudShl3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.wellerZS.My.MySettings.Default, "NudShl3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NudShl3.Location = New System.Drawing.Point(177, 105)
        Me.NudShl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NudShl3.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NudShl3.Name = "NudShl3"
        Me.NudShl3.Size = New System.Drawing.Size(88, 22)
        Me.NudShl3.TabIndex = 9
        Me.NudShl3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NudShl3.Value = Global.wellerZS.My.MySettings.Default.NudShl3
        '
        'NudShl2
        '
        Me.NudShl2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.wellerZS.My.MySettings.Default, "NudShl2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NudShl2.Location = New System.Drawing.Point(177, 64)
        Me.NudShl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NudShl2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NudShl2.Name = "NudShl2"
        Me.NudShl2.Size = New System.Drawing.Size(88, 22)
        Me.NudShl2.TabIndex = 6
        Me.NudShl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NudShl2.Value = Global.wellerZS.My.MySettings.Default.NudShl2
        '
        'NudShl1
        '
        Me.NudShl1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.wellerZS.My.MySettings.Default, "NudShl1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NudShl1.Location = New System.Drawing.Point(177, 26)
        Me.NudShl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NudShl1.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NudShl1.Name = "NudShl1"
        Me.NudShl1.Size = New System.Drawing.Size(88, 22)
        Me.NudShl1.TabIndex = 3
        Me.NudShl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NudShl1.Value = Global.wellerZS.My.MySettings.Default.NudShl1
        '
        'NudShr3
        '
        Me.NudShr3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.wellerZS.My.MySettings.Default, "NudShr3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NudShr3.Location = New System.Drawing.Point(73, 105)
        Me.NudShr3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NudShr3.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NudShr3.Name = "NudShr3"
        Me.NudShr3.Size = New System.Drawing.Size(88, 22)
        Me.NudShr3.TabIndex = 8
        Me.NudShr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NudShr3.Value = Global.wellerZS.My.MySettings.Default.NudShr3
        '
        'NudShr2
        '
        Me.NudShr2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.wellerZS.My.MySettings.Default, "NudShr2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NudShr2.Location = New System.Drawing.Point(73, 64)
        Me.NudShr2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NudShr2.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NudShr2.Name = "NudShr2"
        Me.NudShr2.Size = New System.Drawing.Size(88, 22)
        Me.NudShr2.TabIndex = 5
        Me.NudShr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NudShr2.Value = Global.wellerZS.My.MySettings.Default.NudShr2
        '
        'NudShr1
        '
        Me.NudShr1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.wellerZS.My.MySettings.Default, "NudShr1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NudShr1.Location = New System.Drawing.Point(73, 26)
        Me.NudShr1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NudShr1.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NudShr1.Name = "NudShr1"
        Me.NudShr1.Size = New System.Drawing.Size(88, 22)
        Me.NudShr1.TabIndex = 2
        Me.NudShr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NudShr1.Value = Global.wellerZS.My.MySettings.Default.NudShr1
        '
        'ChbShedule3
        '
        Me.ChbShedule3.AutoSize = True
        Me.ChbShedule3.Checked = Global.wellerZS.My.MySettings.Default.SchedChk3
        Me.ChbShedule3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChbShedule3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "SchedChk3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChbShedule3.Location = New System.Drawing.Point(23, 110)
        Me.ChbShedule3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChbShedule3.Name = "ChbShedule3"
        Me.ChbShedule3.Size = New System.Drawing.Size(18, 17)
        Me.ChbShedule3.TabIndex = 7
        Me.ChbShedule3.UseVisualStyleBackColor = True
        '
        'ChbShedule2
        '
        Me.ChbShedule2.AutoSize = True
        Me.ChbShedule2.Checked = Global.wellerZS.My.MySettings.Default.SchedChk2
        Me.ChbShedule2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChbShedule2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "SchedChk2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChbShedule2.Location = New System.Drawing.Point(23, 69)
        Me.ChbShedule2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChbShedule2.Name = "ChbShedule2"
        Me.ChbShedule2.Size = New System.Drawing.Size(18, 17)
        Me.ChbShedule2.TabIndex = 4
        Me.ChbShedule2.UseVisualStyleBackColor = True
        '
        'ChbShedule1
        '
        Me.ChbShedule1.AutoSize = True
        Me.ChbShedule1.Checked = Global.wellerZS.My.MySettings.Default.SchedChk1
        Me.ChbShedule1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChbShedule1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.wellerZS.My.MySettings.Default, "SchedChk1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChbShedule1.Location = New System.Drawing.Point(23, 30)
        Me.ChbShedule1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChbShedule1.Name = "ChbShedule1"
        Me.ChbShedule1.Size = New System.Drawing.Size(18, 17)
        Me.ChbShedule1.TabIndex = 1
        Me.ChbShedule1.UseVisualStyleBackColor = True
        '
        'SchedulerSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 192)
        Me.Controls.Add(Me.NudShl3)
        Me.Controls.Add(Me.NudShl2)
        Me.Controls.Add(Me.NudShl1)
        Me.Controls.Add(Me.NudShr3)
        Me.Controls.Add(Me.NudShr2)
        Me.Controls.Add(Me.NudShr1)
        Me.Controls.Add(Me.BtnSmtpCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.ChbShedule3)
        Me.Controls.Add(Me.ChbShedule2)
        Me.Controls.Add(Me.ChbShedule1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SchedulerSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Scheduler Settings"
        CType(Me.NudShl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudShl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudShl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudShr3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudShr2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudShr1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChbShedule1 As System.Windows.Forms.CheckBox
    Friend WithEvents ChbShedule2 As System.Windows.Forms.CheckBox
    Friend WithEvents ChbShedule3 As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSmtpCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents NudShr1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NudShl1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NudShr2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NudShr3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NudShl2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NudShl3 As System.Windows.Forms.NumericUpDown
End Class
