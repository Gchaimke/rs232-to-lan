Imports System.Globalization
Public Class PowerSettings


    Private Sub pwrOn_Click(sender As Object, e As EventArgs) Handles pwrOn.Click
        Dim server As String = TxbIP1.Text & "." & TxbIP2.Text & "." & TxbIP3.Text & "." & TxbIP4.Text 'obedinenie ip
        Dim port = CType(TxbPort.Text, Integer)
        TcpConnect(server, port, "N") 'send asci data
    End Sub

    Private Sub pwrOff_Click(sender As Object, e As EventArgs) Handles pwrOff.Click
        Dim server As String = TxbIP1.Text & "." & TxbIP2.Text & "." & TxbIP3.Text & "." & TxbIP4.Text 'obedinenie ip
        Dim port = CType(TxbPort.Text, Integer)
        TcpConnect(server, port, "M") 'send asci data

    End Sub

    Private Sub BtnCheckSpeed_Click(sender As Object, e As EventArgs) Handles BtnCheckSpeed.Click
        Dim server As String = TxbIP1.Text & "." & TxbIP2.Text & "." & TxbIP3.Text & "." & TxbIP4.Text 'obedinenie ip
        Dim port = CType(TxbPort.Text, Integer)
        SetLbl()
    End Sub

    Private Sub Btn30_Click(sender As Object, e As EventArgs) Handles Btn30.Click
        Dim server As String = TxbIP1.Text & "." & TxbIP2.Text & "." & TxbIP3.Text & "." & TxbIP4.Text 'obedinenie ip
        Dim port = CType(TxbPort.Text, Integer)
        TcpConnecthex(server, port, {&H64, &H30, &H33, &H30, &HF7}) 'send hex data
        SetLbl()
    End Sub

    Private Sub Btn50_Click(sender As Object, e As EventArgs) Handles Btn50.Click
        Dim server As String = TxbIP1.Text & "." & TxbIP2.Text & "." & TxbIP3.Text & "." & TxbIP4.Text 'obedinenie ip
        Dim port = CType(TxbPort.Text, Integer)
        TcpConnecthex(server, port, {&H64, &H30, &H35, &H30, &HF9}) 'send hex data
        SetLbl()
    End Sub

    Private Sub Btn75_Click(sender As Object, e As EventArgs) Handles Btn75.Click
        Dim server As String = TxbIP1.Text & "." & TxbIP2.Text & "." & TxbIP3.Text & "." & TxbIP4.Text 'obedinenie ip
        Dim port = CType(TxbPort.Text, Integer)
        TcpConnecthex(server, port, {&H64, &H30, &H37, &H35, &H0}) 'send hex data
        SetLbl()
    End Sub

    Private Sub Btn100_Click(sender As Object, e As EventArgs) Handles Btn100.Click
        Dim server As String = TxbIP1.Text & "." & TxbIP2.Text & "." & TxbIP3.Text & "." & TxbIP4.Text 'obedinenie ip
        Dim port = CType(TxbPort.Text, Integer)
        TcpConnecthex(server, port, {&H64, &H31, &H30, &H30, &HF5}) 'send hex data
        SetLbl()
    End Sub
    Public Sub SetLbl()
        Dim server As String = TxbIP1.Text & "." & TxbIP2.Text & "." & TxbIP3.Text & "." & TxbIP4.Text 'obedinenie ip
        Dim port = CType(TxbPort.Text, Integer)
        Dim status As String = TcpConnect(server, port, "S") 'send asci data
        LblCurentSpeed.Text = status.Substring(1, 3) & "%"
    End Sub

End Class