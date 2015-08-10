Public Class frmSet
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Contents of writePassword() method were
        ' transferred to modPWHelp, and were modified
        ' for reusability
        writePassword(txtPass.Text)
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Re-organized code using With...End With construct
        With txtPass
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            writePassword(txtPass.Text)
            Me.Close()
        End If
    End Sub
End Class