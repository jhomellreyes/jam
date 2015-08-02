Imports System
Imports System.IO
Public Class frmSet
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Using sw As StreamWriter = File.CreateText(Directory.GetCurrentDirectory & "\index.txt") ' creates the password file
            sw.Write(txtPass.Text)
            sw.Flush()
            sw.Close()
        End Using
        Me.Close()
        frmUserPass.txtPass.Clear()
        frmUserPass.Show()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPass.Clear()
        txtPass.Focus()
    End Sub
    Private Sub frmSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class