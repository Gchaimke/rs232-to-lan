Module email
    Function PassDecoding()
        Dim plainText As String
        Dim wrapper As New EncryptDecryptVB("QopRmjknyigyu3knj32")
        ' DecryptData throws if the wrong password is used.
        If My.Settings.ChbEncrypt = True Then
            plainText = wrapper.DecryptData(My.Settings.SmtpPass)
        Else
            plainText = My.Settings.SmtpPass
        End If
        Return plainText.ToString()
    End Function

    Sub SendEmail(ByVal emailSubj As String, ByVal TextBody As String)
        'Usage:		cscript sendemail.vbs <email_recipient@example.com> "<subject_line>" "<email_body>" "<optional:email_attachment_path>"
        'Ex. No attach:	cscript sendemail.vbs example@gmail.com "test subject line" "test email body"
        'Ex. W/ attach:	cscript sendemail.vbs example@gmail.com "test subject line" "test email body" "c:\scripts\log.txt"
        Try
            Dim emailObj, emailConfig
            emailObj = CreateObject("CDO.Message")
            emailObj.From = My.Settings.SmtpUser.ToString()
            emailObj.To = My.Settings.RecipientEml.ToString()
            emailObj.Subject = emailSubj
            emailObj.TextBody = TextBody

            emailConfig = emailObj.Configuration
            emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2
            emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/smtpserver") = My.Settings.SMTPServer
            emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = My.Settings.SMTPServerPort
            emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/smtpconnectiontimeout") = 60
            If My.Settings.ChbUseSSL = True Then
                emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = True
            Else
                emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = False
            End If


            If My.Settings.UseAuth = True Then
                emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate") = 1
                emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/sendusername") = My.Settings.SmtpUser
                emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/sendpassword") = PassDecoding()
            End If

            emailConfig.Fields.Update()

            emailObj.Send()

            emailObj = Nothing
            emailConfig = Nothing
            My.Settings.EmlError = False
        Catch ex As Exception
            My.Settings.EmlError = True
            If My.Settings.ChbDebug = True Then
                MsgBox(ex.Message)
            End If
        End Try
    End Sub
End Module
