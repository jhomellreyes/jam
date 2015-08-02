Imports System
Imports System.IO
Imports System.Security.AccessControl
Module modJAMHelper
    Friend Sub triggerMenu(isVisible As Boolean)
        If isVisible Then
            frmJAM.btnPassword.Visible = False
            frmJAM.btnHelp.Visible = False
            frmJAM.btnAbout.Visible = False
            frmJAM.btnExit.Visible = False
        ElseIf Not isVisible Then
            frmJAM.btnPassword.Visible = True
            frmJAM.btnHelp.Visible = True
            frmJAM.btnAbout.Visible = True
            frmJAM.btnExit.Visible = True
        End If
    End Sub
    Friend Sub triggerSubMenu(isVisible As Boolean)
        If isVisible Then
            frmJAM.btnEditPassword.Visible = False
            frmJAM.btnAddPassword.Visible = False
            frmJAM.btnRemovePassword.Visible = False
        ElseIf Not isVisible Then
            frmJAM.btnEditPassword.Visible = True
            frmJAM.btnAddPassword.Visible = True
            frmJAM.btnRemovePassword.Visible = True
        End If
    End Sub

    Friend Sub hideAllMenu()
        triggerMenu(True)
        triggerSubMenu(True)
    End Sub
    
    Friend Sub addPassword()
        hideAllMenu()
        If Not File.Exists(Directory.GetCurrentDirectory & "\index.txt") Then ' check if password file does not exist
            frmJAM.Hide()
            frmSet.txtPass.Clear()
            frmSet.Show() ' frmSet is the form for setting password
        Else
            MessageBox.Show("You already have a password!", "JAM Folder Protector", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Friend Sub removePassword()
        If File.Exists(Directory.GetCurrentDirectory & "\index.txt") Then
            File.Delete(Directory.GetCurrentDirectory & "\index.txt") ' index.txt contains the password
            MessageBox.Show("Password deleted!", "JAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("There is no password to delete!", "JAM Folder Protector", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Friend Sub browseForFolder()
        If frmJAM.fbdJAM.ShowDialog = Windows.Forms.DialogResult.OK Then
            frmJAM.txtPath.Text = frmJAM.fbdJAM.SelectedPath
            If Not frmJAM.lbRecentFiles.Items.ToString = frmJAM.fbdJAM.SelectedPath Then
                frmJAM.lbRecentFiles.Items.Add(frmJAM.fbdJAM.SelectedPath)
            End If
            If Not File.Exists(Directory.GetCurrentDirectory & "\recent.txt") Then
                CreateWrite() ' helper method for creating list of recent files
            Else
                ExistWrite() ' helper method for creating list of recent files
            End If
        End If
    End Sub
    Friend Sub loadRecentFiles()
        If File.Exists(Directory.GetCurrentDirectory & "\recent.txt") Then ' checks if there is a list of recent folders
            For Each line As String In File.ReadAllLines(Directory.GetCurrentDirectory & "\recent.txt")
                frmJAM.lbRecentFiles.Items.Add(line)
            Next
        End If
    End Sub
    Friend Sub lockFolder(path As String)
        Try
            File.SetAttributes(path, FileAttributes.Hidden) ' set the file attribute of selected folder to hidden
            Dim fs = System.IO.File.GetAccessControl(path)
            fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            File.SetAccessControl(path, fs)
            MessageBox.Show(path + " is now locked!", "JAM Folder Protector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Friend Sub unlockFolder(path As String)
        Try
            Dim fs As FileSystemSecurity = File.GetAccessControl(path)
            fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            File.SetAccessControl(path, fs)
            File.SetAttributes(path, FileAttributes.Normal)
            MessageBox.Show(path + " is now unlocked!", "JAM Folder Protector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Friend Sub CreateWrite()
        Using sw As StreamWriter = File.CreateText(Directory.GetCurrentDirectory & "\recent.txt") ' sw: local variable
            sw.WriteLine(frmJAM.fbdJAM.SelectedPath)
            sw.Flush()
            sw.Close()
        End Using
    End Sub
    Friend Sub ExistWrite()
        For Each line As String In File.ReadAllLines(Directory.GetCurrentDirectory & "\recent.txt")
            If Not line = frmJAM.fbdJAM.SelectedPath Then
                Using sw As StreamWriter = File.AppendText(Directory.GetCurrentDirectory & "\recent.txt") ' sw: local variable
                    sw.WriteLine(frmJAM.fbdJAM.SelectedPath)
                    sw.Flush()
                    sw.Close()
                End Using
            End If
        Next
    End Sub
End Module