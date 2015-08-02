<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMessage))
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(50, 30)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(92, 21)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Sample Text"
        '
        'btnOkay
        '
        Me.btnOkay.BackColor = System.Drawing.Color.White
        Me.btnOkay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOkay.FlatAppearance.BorderSize = 0
        Me.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOkay.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnOkay.Location = New System.Drawing.Point(361, 30)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(115, 40)
        Me.btnOkay.TabIndex = 1
        Me.btnOkay.Text = "OK"
        Me.btnOkay.UseVisualStyleBackColor = False
        '
        'frmMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(502, 100)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMessage"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents btnOkay As Button
End Class
