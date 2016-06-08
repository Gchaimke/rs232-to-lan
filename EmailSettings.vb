Imports System.IO
Public Class EmailSettings
    Dim password As String = "QopRmjknyigyu3knj32"
    Sub TestEncoding()
        Dim plainText As String = TxbPass.Text
        Dim wrapper As New EncryptDecryptVB(password)
        Dim cipherText As String = wrapper.EncryptData(plainText)
        My.Settings.SmtpPass = cipherText
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub BtnSmtpCancel_Click(sender As Object, e As EventArgs) Handles BtnSmtpCancel.Click
        My.Settings.Reload()
    End Sub

    Private Sub BtnTest_Click(sender As Object, e As EventArgs) Handles BtnTest.Click
        LblStatus.Text = "Starting test"
        My.Settings.Save()
        SendEmail("Weller Zero-Smog Test Email", "Email setting are OK!")
        If My.Settings.EmlError = "True" Then
            LblStatus.ForeColor = Color.Red
            LblStatus.Text = "Can't send email, check the settings"
        End If
        If My.Settings.EmlError = "False" Then
            LblStatus.ForeColor = Color.DarkGreen
            LblStatus.Text = "email sent successfully"
        End If

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        My.Settings.Reset()
    End Sub

    Private Sub ChbEncrypt_Click(sender As Object, e As EventArgs) Handles ChbEncrypt.Click
        If ChbEncrypt.Checked = True Then
            TestEncoding()
            My.Settings.Save()
            MsgBox("Password encrypted and saved")
            'ChbEncrypt.Checked = True
        End If
    End Sub

    Private Sub TxbPass_MouseClick(sender As Object, e As MouseEventArgs) Handles TxbPass.MouseClick
        ChbEncrypt.CheckState = CheckState.Unchecked
        TxbPass.Text = ""
    End Sub

End Class