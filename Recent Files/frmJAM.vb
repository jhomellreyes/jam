Imports System
Imports System.IO
Public Class frmJAM
    Private Sub frmJAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        loadRecentFiles()
    End Sub
    Private Sub frmJAM_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmUserPass.Close() ' frmUserPass is the startup form, it is the one that must be closed
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        browseForFolder()
    End Sub
    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        lockFolder(txtPath.Text) ' helper method for locking folder
    End Sub
    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        unlockFolder(txtPath.Text) ' helper method for unlocking folder
    End Sub
    Private Sub lbRecentFiles_Click(sender As Object, e As EventArgs) Handles lbRecentFiles.Click
        txtPath.Text = lbRecentFiles.GetItemText(lbRecentFiles.SelectedItem) ' load the text from listbox into the textbox for folder to be blocked
    End Sub
    
    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        lbRecentFiles.Items.Clear()
        File.Delete(Directory.GetCurrentDirectory & "\recent.txt")
    End Sub

    Private Sub txtPath_Click(sender As Object, e As EventArgs) Handles txtPath.Click
        browseForFolder()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            hideAllMenu()
            frmHelp.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MessageBox.Show("JAM Folder Protector was developed by Abien Fred Agarap")
    End Sub

    Private Sub btnRemovePassword_Click(sender As Object, e As EventArgs) Handles btnRemovePassword.Click
        removePassword()
    End Sub

    Private Sub btnAddPassword_Click(sender As Object, e As EventArgs) Handles btnAddPassword.Click
        addPassword()
    End Sub

    Private Sub btnEditPassword_Click(sender As Object, e As EventArgs) Handles btnEditPassword.Click
        hideAllMenu()
        frmEdit.Show() ' frmEdit is the form for changing password
    End Sub

    Private Sub btnApp_Click(sender As Object, e As EventArgs) Handles btnApp.Click
        If btnPassword.Visible Then
            triggerMenu(True)
            triggerSubMenu(True)
        ElseIf Not btnPassword.Visible Then
            triggerMenu(False)
        End If
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        If btnEditPassword.Visible Then
            triggerSubMenu(True)
        ElseIf Not btnEditPassword.Visible Then
            triggerSubMenu(False)
        End If
    End Sub

    Private Sub frmJAM_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        hideAllMenu()
    End Sub

    Private Sub grpLockUnlock_MouseHover(sender As Object, e As EventArgs) Handles grpLockUnlock.MouseHover
        hideAllMenu()
    End Sub

    Private Sub lblJAM_MouseHover(sender As Object, e As EventArgs) Handles lblJAM.MouseHover
        hideAllMenu()
    End Sub

    Private Sub panelJAM_MouseHover(sender As Object, e As EventArgs) Handles panelJAM.MouseHover
        hideAllMenu()
    End Sub

    Private Sub grpRecentFolder_MouseHover(sender As Object, e As EventArgs) Handles grpRecentFolder.MouseHover
        hideAllMenu()
    End Sub

    Private Sub lbRecentFiles_MouseHover(sender As Object, e As EventArgs) Handles lbRecentFiles.MouseHover
        hideAllMenu()
    End Sub
End Class