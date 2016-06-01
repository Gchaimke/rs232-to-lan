Option Strict Off
Option Infer On

Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System
Imports System.IO
Imports System.Threading
Imports System.Net.NetworkInformation
Imports System.ComponentModel

Public Class FormMain
    'Declare a Delegate without Parameters
    Delegate Sub PingServers()
    'Define a Scheduler
    Dim sch As New Scheduler.Scheduler
    Dim smtp As New FormSMTP
    Dim Aboutmenu As New About
    Dim setSchd As New SchedulerSettings
    Dim setMsh As New NetwokSettings
    Dim setPower As New PowerSettings


    Public addSch1 As String
    Public addSch2 As String
    Public addSch3 As String
    Private ip As String
    Private port As String
    Public path As String
    Public FileNum As Integer
    Public fs As FileStream
    Public timerTick As Integer = 0
    Dim progressStatus As Integer = 0
    Dim fileDateTime As String

    'Private Subs
    'Load Main
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblEmlStatus.Text = ""
        'Pass a Delegate without Parameters
        Dim png As PingServers = AddressOf BackgroundWorker1.RunWorkerAsync
        sch.AddEvent(png)
        TxbLog.Show()
        If ChbShowLog.Checked = True Then
            TxbLog.Show()
        Else
            TxbLog.Hide()
        End If
        My.Settings.EmlError = "Nothing"
        Dim strAppDir As String = AppDomain.CurrentDomain.BaseDirectory.ToString
        strAppDir = strAppDir & "logs"
        
        If (Not System.IO.Directory.Exists(strAppDir)) Then
            System.IO.Directory.CreateDirectory(strAppDir)
        End If
        fileDateTime = DateTime.Now.ToString("MMddyyyy") & "_" & DateTime.Now.ToString("HHmmss")
        path = strAppDir & "\" & fileDateTime & "_log.txt"
        FileNum = FreeFile()
        CheckForIllegalCrossThreadCalls = False
        fs = File.Create(path)
        fs.Close()
        Dim strHostName As String
        Dim addr() As IPAddress
        strHostName = Dns.GetHostName()
        Dim ipEntry As IPHostEntry = Dns.GetHostEntry(strHostName)
        addr = ipEntry.AddressList
        Dim i As Integer
        For i = 0 To addr.Length - 1
            If addr(i).AddressFamily = AddressFamily.InterNetwork Then
                LblHostIp.Text = " Host Name : " & strHostName & String.Format(" IP: {0}", addr(i).ToString)
                Exit For
            End If
        Next

        'Add a Schedule to Do the Events On a Particular Date/Time
        'sch.AddSchedule(Now)
        'Add a Schedule to do the Events, after every Time Span
        'sch.AddSchedule(New TimeSpan(0, 0, 30))
        'Add a Schedule to do the Events, after every Time Span starting from Date/Time
        'sch.AddSchedule(#5/28/2008 4:00:00 AM#, New TimeSpan(0, 5, 0))
        'Add a Schedule to do the Events, EveryDay at the Said Times in 24Hrs Clock
        'sch.AddSchedule("14:42", "11:25", "15:3")

        If My.Settings.AutostartChb = True Then
            BtnStart.Text = "Stop"
            OptionsToolStripMenuItem.Enabled = False
            StartToolStripMenuItem.Enabled = False
            BtnCHeckNow.Enabled = False
            startAdd()
            sch.Start()
            Timer1.Start()
        End If
        'Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If setSchd.ChbShedule1.Checked = True Then
            addSch1 = My.Settings.NudShr1 & ":" & My.Settings.NudShl1
        Else : addSch1 = ""
        End If
        If setSchd.ChbShedule2.Checked = True Then
            addSch2 = " | " & My.Settings.NudShr2 & ":" & My.Settings.NudShl2
        Else : addSch2 = ""
        End If
        If setSchd.ChbShedule3.Checked = True Then
            addSch3 = " | " & My.Settings.NudShr3 & ":" & My.Settings.NudShl3
        Else : addSch3 = ""
        End If
        timerTick += 1

    End Sub ' Timer-tick do functions by tick

    Private Sub pingServer()
        LvMashines.Items.Clear()
        Dim clients As Integer = CInt(setMsh.TxbCount.Text)  'ob'yavlenie clients collichestvo IP
        setMsh.CheckIP()
        ip = CType(setMsh.TxbIP4.Text, Integer)
        port = CType(setMsh.TxbPort.Text, Integer)
        progressStatus = 100 / clients
        Do
            Dim server As String = setMsh.TxbIP1.Text & "." & setMsh.TxbIP2.Text & "." & setMsh.TxbIP3.Text & "." & ip 'obedinenie ip
            ' nachalo loop Do
            clients -= 1
            BackgroundWorker1.ReportProgress(progressStatus)
            Try
                Dim countPing = 0
                Dim ping As New Ping
Start:
                Dim pingRe As PingReply = ping.Send(server)
                Dim mStatus As String = "Offline"
                If Not pingRe.Status = IPStatus.Success Then ' if no ping ...
                    countPing += 1
                    If countPing < 3 Then GoTo Start
                    SaveLog(time() & "  :  " & "No Response from " & server & " : " & port & Environment.NewLine)
                    addToList(server, mStatus)
                Else    ' if ping are ok ...
                    Dim serial As String = TcpConnecthex(server, port, {&H23, &H30, &H30, &H30, &HB3}) 'send hex data
                    Dim status As String = TcpConnect(server, port, "L") 'send asci data
                    Dim serialSubHex As String = serial.Substring(7, 3) 'correct answare with substring 
                    Dim statusSub As String = status.Substring(1, 3) 'correct answare with substring 
                    Dim EmlText As String

                    'serialSubHex = "031"
                    'statusSub = "100"
                    If serialSubHex = "nne" And statusSub = "rro" Then 'if answer after correction is "nne" & "rro" then
                        EmlText = "Can't send the data to " & server & ":" & port & ", check cable connection between wi-fi module and Zero-Smog"
                        mStatus = "Port or cable error"
                        If My.Settings.ChBEmailCable = True Then
                            SendEmail("Weller Zero-Smog Cable problem", EmlText)
                        End If
                    ElseIf serialSubHex = "nne" And statusSub = "abl" Then 'if answer after correction is "nne" & "abl" then
                        EmlText = "Can't send the data to " & server & ":" & port & ", check cable connection between wi-fi module and Zero-Smog"
                        mStatus = "Cable problem"
                        If My.Settings.ChBEmailCable = True Then
                            SendEmail("Weller Zero-Smog Cable problem", EmlText)
                        End If
                    ElseIf statusSub = "001" Then
                        EmlText = "Weller Zero-Smog  SN: " & serialSubHex & " Status filter ОК"
                        mStatus = "Filter ОК"
                    ElseIf statusSub = "010" Then
                        EmlText = "Weller Zero-Smog with ip:" & server & ":" & port & " SN: " & serialSubHex & " Alert - Change Big Filter !"
                        mStatus = "Change Big Filter"
                        If My.Settings.ChBEmail80 = True Then
                            SendEmail("Weller Zero-Smog Change Big Filter !", EmlText)
                        End If
                    ElseIf statusSub = "100" Then
                        EmlText = "Weller Zero-Smog with ip:" & server & ":" & port & " SN: " & serialSubHex & " Alert - Change PRE-Filter !"
                        mStatus = "Change PRE-Filter"
                        If My.Settings.ChBEmail50 = True Then
                            SendEmail("Weller Zero-Smog Change PRE-Filter !", EmlText)
                        End If
                    Else
                        EmlText = "Weller Zero-Smog SN: " & serialSubHex & " Status = " & statusSub
                    End If
                    'Send text to log & listview
                    SaveLog(time() & "  :  " & "Connected to " & server & " : " & port & "  " & EmlText & Environment.NewLine)
                    addToList(server, mStatus)

                End If
            Catch ex As Exception
            End Try
            If My.Settings.ChbExternal = True Then
                port += 1
            Else
                ip += 1
            End If
            If progressStatus + progressStatus > 100 Then
                progressStatus = 99
            Else
                progressStatus += progressStatus
            End If

        Loop Until clients = 0
        progressStatus = 0
        BackgroundWorker1.ReportProgress(progressStatus)
        If BtnCHeckNow.Text = "Stop" Then
            OptionsToolStripMenuItem.Enabled = True
            StartToolStripMenuItem.Enabled = True
            BtnStart.Enabled = True
            BtnCHeckNow.Text = "Check Now"
        End If
        SaveLog("-------------------------------------------------------------------------------------" & Environment.NewLine)
        If My.Settings.EmlError = "True" Then
            LblEmlStatus.ForeColor = Color.Red
            LblEmlStatus.Text = "Email settings Error"
        ElseIf My.Settings.EmlError = "False" Then
            LblEmlStatus.ForeColor = Color.DarkGreen
            LblEmlStatus.Text = "Email settings OK"
        End If
    End Sub

    'Start sub pingServer in background
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If BackgroundWorker1.CancellationPending = True Then
            e.Cancel = True
        Else
            pingServer()
        End If
    End Sub

    Sub addToList(ByVal MashineIp As String, ByVal MashineStatus As String)
        Dim iView As New ListViewItem
        iView.Text = MashineIp
        iView.SubItems.Add(MashineStatus)
        iView.SubItems.Add(Now)
        'you can ad more
        LvMashines.Items.Add(iView)
    End Sub

    ' Functions
    'Add a schedul to list
    Public Sub startAdd()
        sch.SetSchedule.Rows.Clear()
        If setSchd.ChbShedule1.Checked = True Then
            addSch1 = My.Settings.NudShr1 & ":" & My.Settings.NudShl1
            sch.AddSchedule(addSch1)
        End If
        If setSchd.ChbShedule2.Checked = True Then
            addSch2 = My.Settings.NudShr2 & ":" & My.Settings.NudShl2
            sch.AddSchedule(addSch2)
        End If
        If setSchd.ChbShedule3.Checked = True Then
            addSch3 = My.Settings.NudShr3 & ":" & My.Settings.NudShl3
            sch.AddSchedule(addSch3)
        End If
        LblError.Text = "Scheduled start in: " & addSch1 & " | " & addSch2 & " | " & addSch3
    End Sub
    'save log to file
    Public Sub SaveLog(msg)
        TxbLog.AppendText(msg)
        If My.Settings.checkLog = True Then
            FileOpen(FileNum, path, OpenMode.Append) ' zapis' v file log
            PrintLine(FileNum, msg)
            FileClose(FileNum)
        End If
    End Sub
    'Get curent time
    Private Function time()
        Dim n As Date = Now
        Dim s As String = Nothing
        s = n.Day.ToString() & "/" & n.Month.ToString() & "/" & n.Year.ToString() & " - " & n.ToLongTimeString.ToString() & " :"
        Return s
    End Function 'Get current time to string in format dd/mm/yyyy - HH:mm:ss
    ' Form Status
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Dim min As Boolean = False
        'if minimized button was pressed
        If Me.WindowState = FormWindowState.Minimized = True Then
            min = True
            'undo minimize
            Me.WindowState = FormWindowState.Normal
        End If
        If min Then
            Me.Hide()
        End If
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub
    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub
    ' Buttons events
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click, StartToolStripMenuItem.Click
        If progressStatus > 0 Or BtnStart.Text = "Stop" Then
            OptionsToolStripMenuItem.Enabled = False
            StartToolStripMenuItem.Enabled = False
            BtnCHeckNow.Enabled = False
        Else
            OptionsToolStripMenuItem.Enabled = True
            StartToolStripMenuItem.Enabled = True
            BtnStart.Enabled = True
            BtnCHeckNow.Enabled = True
        End If

        If BtnStart.Text = "Start" Then
            OptionsToolStripMenuItem.Enabled = False
            StartToolStripMenuItem.Enabled = False
            BtnCHeckNow.Enabled = False
            startAdd()
            sch.Start()
            BtnStart.Text = "Stop"
            Timer1.Start()
        ElseIf BtnStart.Text = "Stop" Then
            OptionsToolStripMenuItem.Enabled = True
            StartToolStripMenuItem.Enabled = True
            BtnCHeckNow.Enabled = True
            stopAll()
        End If
    End Sub
    Private Sub BtnCHeckNow_Click(sender As Object, e As EventArgs) Handles BtnCHeckNow.Click
        If BtnCHeckNow.Text = "Check Now" Then
            OptionsToolStripMenuItem.Enabled = False
            StartToolStripMenuItem.Enabled = False
            BtnStart.Enabled = False
            BtnCHeckNow.Text = "Stop"
            If BackgroundWorker1.IsBusy = True Then
                MsgBox("Please wait to and of the work")
            Else
                BackgroundWorker1.RunWorkerAsync()
            End If
            Timer1.Start()
        ElseIf BtnCHeckNow.Text = "Stop" Then
            OptionsToolStripMenuItem.Enabled = True
            StartToolStripMenuItem.Enabled = True
            BtnStart.Enabled = True
            BtnCHeckNow.Text = "Check Now"
        End If

    End Sub
    Private Sub stopAll()
        LblError.Text = "Waiting To Start"
        sch.Stop()
        BtnStart.Text = "Start"
        Timer1.Stop()
    End Sub ' Stop all functions

    Private Sub ChbShowLog_CheckedChanged(sender As Object, e As EventArgs) Handles ChbShowLog.CheckedChanged
        If ChbShowLog.Checked = True Then
            TxbLog.Show()
        Else
            TxbLog.Hide()
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    '------------------------------ Menu Items ------------------------------
    Private Sub ClearLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearLogToolStripMenuItem.Click
        TxbLog.Text = ""
    End Sub

    Private Sub ManageMashineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageMashineToolStripMenuItem.Click
        setPower.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://avdor-hlt.com")
    End Sub

    Private Sub IpSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IpSettingsToolStripMenuItem.Click
        setMsh.ShowDialog()
    End Sub

    Private Sub EmailOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailOptionsToolStripMenuItem.Click
        smtp.ShowDialog()
    End Sub

    Private Sub SchedulerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchedulerToolStripMenuItem.Click
        setSchd.ShowDialog()
    End Sub

    Private Sub AvdorhltcomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvdorhltcomToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://avdor-hlt.com")
    End Sub

    Private Sub ExportLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportLogToolStripMenuItem.Click
        If System.IO.File.Exists(path) = True Then
            Process.Start(path)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutProgramToolStripMenuItem.Click
        Aboutmenu.ShowDialog()
    End Sub
End Class
