Imports System
Imports System.IO
Public Class frmEdit
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCPass.Clear()
        txtNPass.Clear()
        txtCPass.Focus()
    End Sub
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Try
            If txtCPass.Text = File.ReadAllText(Directory.GetCurrentDirectory & "\index.txt") Then ' check if the entered current password matches the password on file
                File.Delete(Directory.GetCurrentDirectory & "\index.txt") ' if true then delete the old password file
                Using sw As StreamWriter = File.CreateText(Directory.GetCurrentDirectory & "\index.txt") ' use StreamWriter to create the password file and write the password in it
                    sw.Write(txtNPass.Text) ' writes the password entered in the textbox into the password file
                    sw.Flush() ' ends the writing
                    sw.Close() ' closes the file
                End Using
                MessageBox.Show("Successfully changed password!", "JAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                frmJAM.Show()
            Else
                MessageBox.Show("Incorrect current password!", "JAM", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            If Not File.Exists(Directory.GetCurrentDirectory & "\index.txt") Then
                MessageBox.Show("There is no password to be changed!", "JAM Folder Protector", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Error: " & ex.ToString, "JAM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Close()
        End Try
    End Sub
    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        txtCPass.Clear()
        txtNPass.Clear()
    End Sub
End Class