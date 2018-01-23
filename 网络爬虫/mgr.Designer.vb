<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mgr
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lvZZBDS = New System.Windows.Forms.ListView()
        Me.chRegex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDiscribe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chURL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvZZBDS
        '
        Me.lvZZBDS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chRegex, Me.chDiscribe, Me.chURL})
        Me.lvZZBDS.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvZZBDS.FullRowSelect = True
        Me.lvZZBDS.GridLines = True
        Me.lvZZBDS.Location = New System.Drawing.Point(0, 0)
        Me.lvZZBDS.MultiSelect = False
        Me.lvZZBDS.Name = "lvZZBDS"
        Me.lvZZBDS.Size = New System.Drawing.Size(542, 214)
        Me.lvZZBDS.TabIndex = 0
        Me.lvZZBDS.UseCompatibleStateImageBehavior = False
        Me.lvZZBDS.View = System.Windows.Forms.View.Details
        '
        'chRegex
        '
        Me.chRegex.Text = "正则表达式"
        Me.chRegex.Width = 240
        '
        'chDiscribe
        '
        Me.chDiscribe.Text = "备注"
        Me.chDiscribe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chDiscribe.Width = 100
        '
        'chURL
        '
        Me.chURL.Text = "演示URL"
        Me.chURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chURL.Width = 200
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(15, 220)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(126, 34)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "删除选择项"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(205, 220)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(126, 34)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "选择并返回"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(395, 220)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(126, 34)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "关闭窗口"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'mgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 261)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lvZZBDS)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mgr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "管理正则式"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvZZBDS As ListView
    Friend WithEvents chRegex As ColumnHeader
    Friend WithEvents chDiscribe As ColumnHeader
    Friend WithEvents chURL As ColumnHeader
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
End Class
