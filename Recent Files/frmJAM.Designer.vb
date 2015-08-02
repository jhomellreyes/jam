<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJAM
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJAM))
        Me.fbdJAM = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnUnlock = New System.Windows.Forms.Button()
        Me.grpLockUnlock = New System.Windows.Forms.GroupBox()
        Me.btnRemovePassword = New System.Windows.Forms.Button()
        Me.grpRecentFolder = New System.Windows.Forms.GroupBox()
        Me.lbRecentFiles = New System.Windows.Forms.ListBox()
        Me.cmsJAM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelJAM = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.lblJAM = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnApp = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.btnEditPassword = New System.Windows.Forms.Button()
        Me.btnAddPassword = New System.Windows.Forms.Button()
        Me.grpLockUnlock.SuspendLayout()
        Me.grpRecentFolder.SuspendLayout()
        Me.cmsJAM.SuspendLayout()
        Me.panelJAM.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPath.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtPath.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(6, 28)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(247, 26)
        Me.txtPath.TabIndex = 0
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnLock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLock.FlatAppearance.BorderSize = 0
        Me.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLock.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLock.ForeColor = System.Drawing.Color.Black
        Me.btnLock.Location = New System.Drawing.Point(70, 112)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(118, 39)
        Me.btnLock.TabIndex = 2
        Me.btnLock.Text = "Lock"
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Location = New System.Drawing.Point(70, 67)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(118, 39)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnUnlock
        '
        Me.btnUnlock.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnUnlock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnlock.FlatAppearance.BorderSize = 0
        Me.btnUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnlock.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnlock.ForeColor = System.Drawing.Color.Black
        Me.btnUnlock.Location = New System.Drawing.Point(70, 157)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(118, 39)
        Me.btnUnlock.TabIndex = 3
        Me.btnUnlock.Text = "Unlock"
        Me.btnUnlock.UseVisualStyleBackColor = False
        '
        'grpLockUnlock
        '
        Me.grpLockUnlock.Controls.Add(Me.btnRemovePassword)
        Me.grpLockUnlock.Controls.Add(Me.btnUnlock)
        Me.grpLockUnlock.Controls.Add(Me.btnLock)
        Me.grpLockUnlock.Controls.Add(Me.btnBrowse)
        Me.grpLockUnlock.Controls.Add(Me.txtPath)
        Me.grpLockUnlock.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.grpLockUnlock.Location = New System.Drawing.Point(12, 61)
        Me.grpLockUnlock.Name = "grpLockUnlock"
        Me.grpLockUnlock.Size = New System.Drawing.Size(259, 202)
        Me.grpLockUnlock.TabIndex = 10
        Me.grpLockUnlock.TabStop = False
        Me.grpLockUnlock.Text = "Lock/Unlock Folder"
        '
        'btnRemovePassword
        '
        Me.btnRemovePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnRemovePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemovePassword.FlatAppearance.BorderSize = 0
        Me.btnRemovePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemovePassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRemovePassword.Location = New System.Drawing.Point(103, 40)
        Me.btnRemovePassword.Name = "btnRemovePassword"
        Me.btnRemovePassword.Size = New System.Drawing.Size(115, 28)
        Me.btnRemovePassword.TabIndex = 25
        Me.btnRemovePassword.Text = "&Remove Password"
        Me.btnRemovePassword.UseVisualStyleBackColor = False
        Me.btnRemovePassword.Visible = False
        '
        'grpRecentFolder
        '
        Me.grpRecentFolder.Controls.Add(Me.lbRecentFiles)
        Me.grpRecentFolder.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.grpRecentFolder.Location = New System.Drawing.Point(277, 61)
        Me.grpRecentFolder.Name = "grpRecentFolder"
        Me.grpRecentFolder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpRecentFolder.Size = New System.Drawing.Size(213, 202)
        Me.grpRecentFolder.TabIndex = 11
        Me.grpRecentFolder.TabStop = False
        Me.grpRecentFolder.Text = "Recent Folders"
        '
        'lbRecentFiles
        '
        Me.lbRecentFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbRecentFiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbRecentFiles.ContextMenuStrip = Me.cmsJAM
        Me.lbRecentFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbRecentFiles.FormattingEnabled = True
        Me.lbRecentFiles.HorizontalScrollbar = True
        Me.lbRecentFiles.ItemHeight = 20
        Me.lbRecentFiles.Location = New System.Drawing.Point(6, 28)
        Me.lbRecentFiles.Name = "lbRecentFiles"
        Me.lbRecentFiles.Size = New System.Drawing.Size(201, 160)
        Me.lbRecentFiles.TabIndex = 4
        '
        'cmsJAM
        '
        Me.cmsJAM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem})
        Me.cmsJAM.Name = "ContextMenuStrip1"
        Me.cmsJAM.Size = New System.Drawing.Size(103, 26)
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ResetToolStripMenuItem.Text = "&Reset"
        '
        'panelJAM
        '
        Me.panelJAM.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.panelJAM.Controls.Add(Me.btnMinimize)
        Me.panelJAM.Controls.Add(Me.lblJAM)
        Me.panelJAM.Controls.Add(Me.btnClose)
        Me.panelJAM.Controls.Add(Me.btnApp)
        Me.panelJAM.Location = New System.Drawing.Point(0, 0)
        Me.panelJAM.Name = "panelJAM"
        Me.panelJAM.Size = New System.Drawing.Size(502, 45)
        Me.panelJAM.TabIndex = 12
        '
        'btnMinimize
        '
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.LightGray
        Me.btnMinimize.Location = New System.Drawing.Point(438, 6)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(25, 30)
        Me.btnMinimize.TabIndex = 23
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'lblJAM
        '
        Me.lblJAM.AutoSize = True
        Me.lblJAM.Font = New System.Drawing.Font("Helvetica World", 20.0!)
        Me.lblJAM.ForeColor = System.Drawing.Color.Black
        Me.lblJAM.Location = New System.Drawing.Point(50, 2)
        Me.lblJAM.Name = "lblJAM"
        Me.lblJAM.Size = New System.Drawing.Size(271, 48)
        Me.lblJAM.TabIndex = 1
        Me.lblJAM.Text = "JAM Folder Protector"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.LightGray
        Me.btnClose.Location = New System.Drawing.Point(465, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 30)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnApp
        '
        Me.btnApp.BackColor = System.Drawing.Color.White
        Me.btnApp.BackgroundImage = CType(resources.GetObject("btnApp.BackgroundImage"), System.Drawing.Image)
        Me.btnApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApp.FlatAppearance.BorderSize = 0
        Me.btnApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApp.Location = New System.Drawing.Point(0, 0)
        Me.btnApp.Name = "btnApp"
        Me.btnApp.Size = New System.Drawing.Size(45, 45)
        Me.btnApp.TabIndex = 0
        Me.btnApp.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(0, 129)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 28)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(0, 101)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(115, 28)
        Me.btnAbout.TabIndex = 20
        Me.btnAbout.Text = "A&bout"
        Me.btnAbout.UseVisualStyleBackColor = False
        Me.btnAbout.Visible = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(0, 73)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(115, 28)
        Me.btnHelp.TabIndex = 19
        Me.btnHelp.Text = "&Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        Me.btnHelp.Visible = False
        '
        'btnPassword
        '
        Me.btnPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPassword.FlatAppearance.BorderSize = 0
        Me.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnPassword.Location = New System.Drawing.Point(0, 45)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(115, 28)
        Me.btnPassword.TabIndex = 18
        Me.btnPassword.Text = "&Password >"
        Me.btnPassword.UseVisualStyleBackColor = False
        Me.btnPassword.Visible = False
        '
        'btnEditPassword
        '
        Me.btnEditPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnEditPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditPassword.FlatAppearance.BorderSize = 0
        Me.btnEditPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnEditPassword.Location = New System.Drawing.Point(115, 45)
        Me.btnEditPassword.Name = "btnEditPassword"
        Me.btnEditPassword.Size = New System.Drawing.Size(115, 28)
        Me.btnEditPassword.TabIndex = 23
        Me.btnEditPassword.Text = "&Edit Password"
        Me.btnEditPassword.UseVisualStyleBackColor = False
        Me.btnEditPassword.Visible = False
        '
        'btnAddPassword
        '
        Me.btnAddPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAddPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddPassword.FlatAppearance.BorderSize = 0
        Me.btnAddPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnAddPassword.Location = New System.Drawing.Point(115, 73)
        Me.btnAddPassword.Name = "btnAddPassword"
        Me.btnAddPassword.Size = New System.Drawing.Size(115, 28)
        Me.btnAddPassword.TabIndex = 24
        Me.btnAddPassword.Text = "&Add Password"
        Me.btnAddPassword.UseVisualStyleBackColor = False
        Me.btnAddPassword.Visible = False
        '
        'frmJAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(502, 275)
        Me.Controls.Add(Me.btnAddPassword)
        Me.Controls.Add(Me.btnEditPassword)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnPassword)
        Me.Controls.Add(Me.panelJAM)
        Me.Controls.Add(Me.grpRecentFolder)
        Me.Controls.Add(Me.grpLockUnlock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmJAM"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JAM Folder Protector"
        Me.grpLockUnlock.ResumeLayout(False)
        Me.grpLockUnlock.PerformLayout()
        Me.grpRecentFolder.ResumeLayout(False)
        Me.cmsJAM.ResumeLayout(False)
        Me.panelJAM.ResumeLayout(False)
        Me.panelJAM.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnUnlock As System.Windows.Forms.Button
    Friend WithEvents grpLockUnlock As System.Windows.Forms.GroupBox
    Friend WithEvents grpRecentFolder As System.Windows.Forms.GroupBox
    Friend WithEvents lbRecentFiles As System.Windows.Forms.ListBox
    Public WithEvents fbdJAM As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents panelJAM As System.Windows.Forms.Panel
    Friend WithEvents btnApp As System.Windows.Forms.Button
    Friend WithEvents lblJAM As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnPassword As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnEditPassword As System.Windows.Forms.Button
    Friend WithEvents btnAddPassword As System.Windows.Forms.Button
    Friend WithEvents btnRemovePassword As System.Windows.Forms.Button
    Friend WithEvents cmsJAM As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
