Public Class frmHelp
    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        AxAcroPDF1.src = System.IO.Directory.GetCurrentDirectory & "\help.pdf"
    End Sub
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Close()
    End Sub
End Class