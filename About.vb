Imports System.Deployment.Application


Public Class About

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
            Dim ad = System.Deployment.Application.ApplicationDeployment.CurrentDeployment
            LblVersion.Text = ad.CurrentVersion.ToString
        Else
            LblVersion.Text = Application.ProductVersion.ToString
        End If
    End Sub

End Class