Imports System
Imports System.IO
Public Class frmUserPass
    Private Sub frmUserPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        If Not File.Exists(Directory.GetCurrentDirectory & "\index.txt") Then ' checks if a password is not set
            MessageBox.Show("Set your password!", "JAM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        kpCompare()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPass.Clear()
        txtPass.Focus()
    End Sub
    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            kpCompare()
        End If
    End Sub
    Private Sub kpCompare()
        If Not File.Exists(Directory.GetCurrentDirectory & "\index.txt") Then ' checks if a password is not set
            Using sw As StreamWriter = File.CreateText(Directory.GetCurrentDirectory & "\index.txt") ' creates the password file
                sw.Write(txtPass.Text) ' writes the password from TextBox into the "index.txt" file
                sw.Flush()
                sw.Close()
                Me.Hide()
                frmJAM.Show() ' shows the main form of the program
            End Using
        ElseIf File.Exists(Directory.GetCurrentDirectory & "\index.txt") Then ' checks if a password is set
            If File.ReadAllText(Directory.GetCurrentDirectory & "\index.txt") = txtPass.Text Then ' checks if password entered by user matches password set
                Me.Hide()
                frmJAM.Show() ' shows the main form of the program
            Else
                MessageBox.Show("Incorrect password!", "JAM", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)
                txtPass.Clear()
                txtPass.Focus()
            End If
        End If
    End Sub
End Class