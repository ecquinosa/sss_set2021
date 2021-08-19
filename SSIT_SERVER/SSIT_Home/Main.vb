
#Region " Imports "

Imports System
Imports Sagem.MorphoKit
Imports System.Runtime.InteropServices

#End Region

Public Class Main
    'Dim xs As New MySettings

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'DisableWindowsFunction(False)
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Public Sub Init()
        Try
            editSettings(xml_Filename, xml_path, "CRN", "")

            '********* UNCOMMENT FOR OLD SSCARD NEW CONFIGURATION
            'If SharedFunction.IsProgramRunning("old_sss_decrypt.exe") = 0 Then
            '    SharedFunction.OpenOldSSSDecrypt()
            'End If

            '*********END OF UNCOMMENT FOR OLD SSCARD NEW CONFIGURATION

            SharedFunction.ShowMainNewUserForm(New usrfrmIdle)
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If Me.FormBorderStyle = FormBorderStyle.None Then
            Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
            Me.WindowState = FormWindowState.Normal
        Else
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        _frmMainMenu.AddRemoveIEVersion(True)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        _frmMainMenu.AddRemoveIEVersion(False)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) 
        Dim printF As New printModule
        Dim s = printF.GetCoverageStatusv3(System.IO.File.ReadAllText("D:\ss_test.txt"))
        Console.Write(s)
    End Sub
End Class
