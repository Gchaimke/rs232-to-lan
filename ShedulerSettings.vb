Public Class SchedulerSettings

    Private Sub ShedulerSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ChbShedule1.Checked = True Then
            NudShr1.Enabled = True
            NudShl1.Enabled = True
        Else
            NudShr1.Enabled = False
            NudShl1.Enabled = False
        End If
        If ChbShedule2.Checked = True Then
            NudShr2.Enabled = True
            NudShl2.Enabled = True
        Else
            NudShr2.Enabled = False
            NudShl2.Enabled = False
        End If
        If ChbShedule3.Checked = True Then
            NudShr3.Enabled = True
            NudShl3.Enabled = True
        Else
            NudShr3.Enabled = False
            NudShl3.Enabled = False
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub BtnSmtpCancel_Click(sender As Object, e As EventArgs) Handles BtnSmtpCancel.Click
        My.Settings.Reload()
    End Sub

    Private Sub ChbShedule1_CheckedChanged(sender As Object, e As EventArgs) Handles ChbShedule1.CheckedChanged
        If ChbShedule1.Checked = True Then
            NudShr1.Enabled = True
            NudShl1.Enabled = True
        Else
            NudShr1.Enabled = False
            NudShl1.Enabled = False
        End If
    End Sub
    Private Sub ChbShedule2_CheckedChanged(sender As Object, e As EventArgs) Handles ChbShedule2.CheckedChanged
        If ChbShedule2.Checked = True Then
            NudShr2.Enabled = True
            NudShl2.Enabled = True
        Else
            NudShr2.Enabled = False
            NudShl2.Enabled = False
        End If
    End Sub
    Private Sub ChbShedule3_CheckedChanged(sender As Object, e As EventArgs) Handles ChbShedule3.CheckedChanged
        If ChbShedule3.Checked = True Then
            NudShr3.Enabled = True
            NudShl3.Enabled = True
        Else
            NudShr3.Enabled = False
            NudShl3.Enabled = False
        End If
    End Sub

End Class