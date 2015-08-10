Imports System.Security.AccessControl
Module modJAMHelper
    Friend Sub showMessage(message As String)
        hideAllMenu()
        ' Re-organized code using With...End With construct
        With frmMessage
            .lblMessage.Text = message
            .Show()
        End With
    End Sub

    Friend Sub triggerMenu(isVisible As Boolean)
        ' Shortened code using conditional expression
        ' Re-organized code using With...End With construct
        With frmJAM
            .btnPassword.Visible = If(isVisible, False, True)
            .btnHelp.Visible = If(isVisible, False, True)
            .btnAbout.Visible = If(isVisible, False, True)
            .btnExit.Visible = If(isVisible, False, True)
        End With
        ' Long code using If-Else statements
        'If isVisible Then
        '    frmJAM.btnPassword.Visible = False
        '    frmJAM.btnHelp.Visible = False
        '    frmJAM.btnAbout.Visible = False
        '    frmJAM.btnExit.Visible = False
        'ElseIf Not isVisible Then
        '    frmJAM.btnPassword.Visible = True
        '    frmJAM.btnHelp.Visible = True
        '    frmJAM.btnAbout.Visible = True
        '    frmJAM.btnExit.Visible = True
        'End If
    End Sub

    Friend Sub triggerSubMenu(isVisible As Boolean)
        ' Shortened code using conditional expression
        ' Re-organized code using With...End With construct
        With frmJAM
            .btnEditPassword.Visible = If(isVisible, False, True)
            .btnAddPassword.Visible = If(isVisible, False, True)
            .btnRemovePassword.Visible = If(isVisible, False, True)
        End With
        ' Long code using If-Else statements
        'If isVisible Then
        '    frmJAM.btnEditPassword.Visible = False
        '    frmJAM.btnAddPassword.Visible = False
        '    frmJAM.btnRemovePassword.Visible = False
        'ElseIf Not isVisible Then
        '    frmJAM.btnEditPassword.Visible = True
        '    frmJAM.btnAddPassword.Visible = True
        '    frmJAM.btnRemovePassword.Visible = True
        'End If
    End Sub

    Friend Sub hideAllMenu()
        triggerMenu(True)
        triggerSubMenu(True)
    End Sub

    Friend Sub addPassword()
        hideAllMenu()
        If Not System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\index.txt") Then ' check if password file does not exist
            ' Re-organized code using With...End With construct
            With frmSet
                .txtPass.Clear()
                .Show() ' frmSet is the form for setting password
            End With
        Else
            showMessage("You already have a password!")
        End If
    End Sub

    Friend Sub removePassword()
        hideAllMenu()
        If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\index.txt") Then
            System.IO.File.Delete(System.IO.Directory.GetCurrentDirectory & "\index.txt") ' index.txt contains the password
            showMessage("Password deleted!")
        Else
            showMessage("There is no password to delete!")
        End If
    End Sub

    Friend Sub browseForFolder()
        If frmJAM.fbdJAM.ShowDialog = Windows.Forms.DialogResult.OK Then
            frmJAM.txtPath.Text = frmJAM.fbdJAM.SelectedPath
            If Not frmJAM.lbRecentFiles.Items.ToString = frmJAM.fbdJAM.SelectedPath Then
                frmJAM.lbRecentFiles.Items.Add(frmJAM.fbdJAM.SelectedPath)
            End If
            If Not System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\recent.txt") Then
                CreateWrite() ' helper method for creating list of recent files
            Else
                ExistWrite() ' helper method for creating list of recent files
            End If
        End If
    End Sub

    Friend Sub loadRecentFiles()
        If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\recent.txt") Then ' checks if there is a list of recent folders
            For Each line As String In System.IO.File.ReadAllLines(System.IO.Directory.GetCurrentDirectory & "\recent.txt")
                frmJAM.lbRecentFiles.Items.Add(line)
            Next
        End If
    End Sub

    Friend Sub lockFolder(path As String)
        Try
            System.IO.File.SetAttributes(path, System.IO.FileAttributes.Hidden) ' set the file attribute of selected folder to hidden
            Dim fs = System.IO.File.GetAccessControl(path)
            fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            System.IO.File.SetAccessControl(path, fs)
            showMessage(path + vbCrLf + "is now locked!")
        Catch ex As Exception
            showMessage("An unexpected error occurred.")
        End Try
    End Sub

    Friend Sub unlockFolder(path As String)
        Try
            Dim fs As FileSystemSecurity = System.IO.File.GetAccessControl(path)
            fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            System.IO.File.SetAccessControl(path, fs)
            System.IO.File.SetAttributes(path, System.IO.FileAttributes.Normal)
            showMessage(path + vbCrLf + "is now unlocked!")
        Catch ex As Exception
            showMessage("An unexpected error occurred.")
        End Try
    End Sub

    Friend Sub CreateWrite()
        Using sw As System.IO.StreamWriter = System.IO.File.CreateText(System.IO.Directory.GetCurrentDirectory & "\recent.txt") ' sw: local variable
            sw.WriteLine(frmJAM.fbdJAM.SelectedPath)
            sw.Flush()
            sw.Close()
        End Using
    End Sub

    Friend Sub ExistWrite()
        For Each line As String In System.IO.File.ReadAllLines(System.IO.Directory.GetCurrentDirectory & "\recent.txt")
            If Not line = frmJAM.fbdJAM.SelectedPath Then
                Using sw As System.IO.StreamWriter = System.IO.File.AppendText(System.IO.Directory.GetCurrentDirectory & "\recent.txt") ' sw: local variable
                    sw.WriteLine(frmJAM.fbdJAM.SelectedPath)
                    sw.Flush()
                    sw.Close()
                End Using
            End If
        Next
    End Sub
End Module