Public Class frmUserPass
    Private Sub frmUserPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\index.txt") Then ' checks if a password is not set
            MessageBox.Show("Set your password!", "JAM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        passwordCompare()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPass.Clear()
        txtPass.Focus()
    End Sub
    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            passwordCompare()
        End If
    End Sub
End Class