﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.miFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miGroups = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiNewGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiDeleteGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiViewGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.miConnectLabel = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtConnected = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConnect.Location = New System.Drawing.Point(32, 95)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 3
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.AcceptsTab = True
        Me.txtPassword.Location = New System.Drawing.Point(104, 46)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(114, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Location = New System.Drawing.Point(132, 95)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.AcceptsTab = True
        Me.txtUsername.Location = New System.Drawing.Point(104, 19)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(114, 20)
        Me.txtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkShowPass)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(316, 188)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 125)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.Location = New System.Drawing.Point(104, 72)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPass.TabIndex = 6
        Me.chkShowPass.Text = "Show Password"
        Me.chkShowPass.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFile, Me.miGroups, Me.miTextBox, Me.miConnectLabel})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(872, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "msMain"
        '
        'miFile
        '
        Me.miFile.Name = "miFile"
        Me.miFile.Size = New System.Drawing.Size(37, 20)
        Me.miFile.Text = "File"
        Me.miFile.Visible = False
        '
        'miGroups
        '
        Me.miGroups.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiNewGroup, Me.msiDeleteGroup, Me.msiViewGroup})
        Me.miGroups.Name = "miGroups"
        Me.miGroups.Size = New System.Drawing.Size(57, 20)
        Me.miGroups.Text = "Groups"
        Me.miGroups.Visible = False
        '
        'msiNewGroup
        '
        Me.msiNewGroup.Name = "msiNewGroup"
        Me.msiNewGroup.Size = New System.Drawing.Size(180, 22)
        Me.msiNewGroup.Text = "New Group"
        '
        'msiDeleteGroup
        '
        Me.msiDeleteGroup.Name = "msiDeleteGroup"
        Me.msiDeleteGroup.Size = New System.Drawing.Size(180, 22)
        Me.msiDeleteGroup.Text = "Delete Group"
        '
        'msiViewGroup
        '
        Me.msiViewGroup.Name = "msiViewGroup"
        Me.msiViewGroup.Size = New System.Drawing.Size(180, 22)
        Me.msiViewGroup.Text = "View Group"
        '
        'miTextBox
        '
        Me.miTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.miTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.miTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.miTextBox.Name = "miTextBox"
        Me.miTextBox.ReadOnly = True
        Me.miTextBox.Size = New System.Drawing.Size(100, 20)
        '
        'miConnectLabel
        '
        Me.miConnectLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.miConnectLabel.Name = "miConnectLabel"
        Me.miConnectLabel.Size = New System.Drawing.Size(96, 20)
        Me.miConnectLabel.Text = "Connected As:"
        Me.miConnectLabel.Visible = False
        '
        'txtConnected
        '
        Me.txtConnected.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConnected.Location = New System.Drawing.Point(714, 8)
        Me.txtConnected.Name = "txtConnected"
        Me.txtConnected.Size = New System.Drawing.Size(146, 13)
        Me.txtConnected.TabIndex = 0
        '
        'LoginForm
        '
        Me.AcceptButton = Me.btnConnect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(872, 539)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtConnected)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LoginForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Training Tool"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnect As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents miFile As ToolStripMenuItem
    Friend WithEvents miGroups As ToolStripMenuItem
    Friend WithEvents msiNewGroup As ToolStripMenuItem
    Friend WithEvents msiDeleteGroup As ToolStripMenuItem
    Friend WithEvents msiViewGroup As ToolStripMenuItem
    Friend WithEvents txtConnected As TextBox
    Friend WithEvents miTextBox As ToolStripTextBox
    Friend WithEvents miConnectLabel As ToolStripMenuItem
End Class
