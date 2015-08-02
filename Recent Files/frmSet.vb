Public Class frmSet
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Contents of writePassword() method were
        ' transferred to modPWHelp, and were modified
        ' for reusability
        writePassword(txtPass.Text)
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPass.Clear()
        txtPass.Focus()
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            writePassword(txtPass.Text)
            Me.Close()
        End If
    End Sub
End Class