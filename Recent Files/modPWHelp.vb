Module modPWHelp
    Friend Sub passwordCompare()
        If Not System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\index.txt") Then ' checks if a password is not set
            writePassword(frmUserPass.txtPass.Text)
            frmJAM.Show() ' shows the main form of the program
            frmUserPass.Close()
        ElseIf System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\index.txt") Then ' checks if a password is set
            If System.IO.File.ReadAllText(System.IO.Directory.GetCurrentDirectory & "\index.txt") = frmUserPass.txtPass.Text Then ' checks if password entered by user matches password set
                frmUserPass.Hide()
                frmJAM.Show() ' shows the main form of the program
            Else
                MessageBox.Show("Incorrect password!", "JAM Folder Protector", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)
                ' Re-organized code using With...End With construct
                With frmUserPass.txtPass
                    .Clear()
                    .Focus()
                End With
            End If
        End If
    End Sub

    Friend Sub writePassword(password As String)
        Using sw As System.IO.StreamWriter = System.IO.File.CreateText(System.IO.Directory.GetCurrentDirectory & "\index.txt") ' use StreamWriter to create the password file and write the password in it
            sw.Write(password) ' writes the password entered in the textbox into the password file
            sw.Flush() ' ends the writing
            sw.Close() ' closes the file
        End Using
    End Sub

    Friend Sub editPassword()
        Try
            If frmEdit.txtCPass.Text = System.IO.File.ReadAllText(System.IO.Directory.GetCurrentDirectory & "\index.txt") Then ' check if the entered current password matches the password on file
                System.IO.File.Delete(System.IO.Directory.GetCurrentDirectory & "\index.txt") ' if true then delete the old password file
                writePassword(frmEdit.txtNPass.Text)
                showMessage("JAM Folder Protector" + vbCrLf + "Successfully changed password!")
            Else
                showMessage("JAM Folder Protector" + vbCrLf + "Incorrect current password!")
            End If
        Catch ex As Exception
            If Not System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\index.txt") Then
                showMessage("No password to change!")
            Else
                showMessage("An unexpected error occurred.")
            End If
        Finally
            frmEdit.Close()
        End Try
    End Sub
End Module