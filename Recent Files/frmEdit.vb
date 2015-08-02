Public Class frmEdit
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCPass.Clear()
        txtNPass.Clear()
        txtCPass.Focus()
    End Sub
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Statements of editPassword() method were transferred to modPWHelp
        editPassword()
    End Sub
    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCPass.Clear()
        txtNPass.Clear()
    End Sub
End Class