<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuery
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.chxSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbxItems = New System.Windows.Forms.ComboBox()
        Me.chkCompleted = New System.Windows.Forms.CheckBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(463, 10)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 0
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(316, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(141, 20)
        Me.txtSearch.TabIndex = 1
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chxSelect})
        Me.dgvData.Location = New System.Drawing.Point(9, 77)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(525, 319)
        Me.dgvData.TabIndex = 2
        '
        'chxSelect
        '
        Me.chxSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.chxSelect.HeaderText = ""
        Me.chxSelect.MinimumWidth = 20
        Me.chxSelect.Name = "chxSelect"
        Me.chxSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chxSelect.Width = 20
        '
        'cbxItems
        '
        Me.cbxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxItems.FormattingEnabled = True
        Me.cbxItems.Location = New System.Drawing.Point(9, 12)
        Me.cbxItems.Name = "cbxItems"
        Me.cbxItems.Size = New System.Drawing.Size(161, 21)
        Me.cbxItems.TabIndex = 3
        '
        'chkCompleted
        '
        Me.chkCompleted.AutoSize = True
        Me.chkCompleted.Location = New System.Drawing.Point(9, 54)
        Me.chkCompleted.Name = "chkCompleted"
        Me.chkCompleted.Size = New System.Drawing.Size(110, 17)
        Me.chkCompleted.TabIndex = 4
        Me.chkCompleted.Text = "Check Completed"
        Me.chkCompleted.UseVisualStyleBackColor = True
        '
        'frmQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(546, 408)
        Me.Controls.Add(Me.chkCompleted)
        Me.Controls.Add(Me.cbxItems)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(200, 200)
        Me.Name = "frmQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Query Form"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents cbxItems As ComboBox
    Friend WithEvents chxSelect As DataGridViewCheckBoxColumn
    Friend WithEvents chkCompleted As CheckBox
End Class
