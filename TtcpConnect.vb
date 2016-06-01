Option Strict Off
Option Infer On

Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System
Imports System.IO
Imports System.Threading
Imports System.Net.NetworkInformation
Module TtcpConnect
    Function TcpConnecthex(ByVal adress As String, ByVal port As Integer, ByVal mydata As Byte()) As String
        Dim returndata As StringBuilder = New StringBuilder()
        Try
            Dim client As New TcpClient()
            client.ReceiveTimeout = 10000
            client.ReceiveBufferSize = 1024
            client.Connect(adress, port)
            Dim dataStream As NetworkStream = client.GetStream()
            If dataStream.CanWrite And dataStream.CanRead Then
                dataStream.Write(mydata, 0, mydata.Length)
                ' Read the NetworkStream into a byte buffer.
                Dim bytes(client.ReceiveBufferSize) As Byte
                Dim b As Integer = 0
                Thread.Sleep(1000)
                'dataStream.ReadTimeout = 2000
                b = dataStream.Read(bytes, 0, client.ReceiveBufferSize)
                If b.ToString() = "" Then
                    client.Close()
                    Return "cableerror"
                Else
                    returndata.AppendFormat("{0}", Encoding.ASCII.GetString(bytes, 0, b))
                End If
                client.Close()
            Else
                If Not dataStream.CanRead Then
                    client.Close()
                Else
                    If Not dataStream.CanWrite Then
                        client.Close()
                    End If
                End If
            End If
            Return returndata.ToString()

        Catch ex As Exception

            Dim msge As String = "errorconnection"
            Return msge
        End Try
    End Function
    Function TcpConnect(ByVal adress As String, ByVal port As Integer, ByVal mydata As String) As String
        Dim returndata As StringBuilder = New StringBuilder()
        Try
            Dim client As New TcpClient()
            client.ReceiveTimeout = 10000
            client.Connect(adress, port)
            client.ReceiveBufferSize = 1024
            Dim dataStream As NetworkStream = client.GetStream()
            If dataStream.CanWrite And dataStream.CanRead Then
                Dim dhex As Byte()
                dhex = System.Text.Encoding.Unicode.GetBytes(mydata.ToString())
                dataStream.Write(dhex, 0, dhex.Length)
                ' Read the NetworkStream into a byte buffer.
                Dim bytes(client.ReceiveBufferSize) As Byte
                Dim b As Integer = 0
                Thread.Sleep(1000)
                ' dataStream.ReadTimeout = 2000
                b = dataStream.Read(bytes, 0, client.ReceiveBufferSize)
                If b.ToString() = 0 Then
                    Return "cableerror"
                Else
                    returndata.AppendFormat("{0}", Encoding.ASCII.GetString(bytes, 0, b))
                End If
                client.Close()
            Else
                If Not dataStream.CanRead Then
                    client.Close()
                Else
                    If Not dataStream.CanWrite Then
                        client.Close()
                    End If
                End If
            End If
            Return returndata.ToString()

        Catch ex As Exception
            Dim msge As String = "errorconnection"
            Return msge
        End Try
    End Function
End Module
