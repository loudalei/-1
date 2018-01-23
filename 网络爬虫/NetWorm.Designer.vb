<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetWorm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnGetRegex = New System.Windows.Forms.Button()
        Me.btnSaveRegex = New System.Windows.Forms.Button()
        Me.btnMatches = New System.Windows.Forms.Button()
        Me.btnSplit = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnRegex = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.txtRegex = New System.Windows.Forms.TextBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnGetHtml = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkECMAScript = New System.Windows.Forms.CheckBox()
        Me.chkExplicitCapture = New System.Windows.Forms.CheckBox()
        Me.chkIgnoreCase = New System.Windows.Forms.CheckBox()
        Me.chkIngorePatternWhiteSpace = New System.Windows.Forms.CheckBox()
        Me.chkRightToLeft = New System.Windows.Forms.CheckBox()
        Me.chkMultiLine = New System.Windows.Forms.CheckBox()
        Me.chkSingleLine = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtXptah = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.txtHtml = New System.Windows.Forms.TextBox()
        Me.btnXpathFilter = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbLevel = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRegexFiliter = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOriginalURL = New System.Windows.Forms.TextBox()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.lvURL = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(745, 460)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnGetRegex)
        Me.TabPage1.Controls.Add(Me.btnSaveRegex)
        Me.TabPage1.Controls.Add(Me.btnMatches)
        Me.TabPage1.Controls.Add(Me.btnSplit)
        Me.TabPage1.Controls.Add(Me.btnReplace)
        Me.TabPage1.Controls.Add(Me.btnRegex)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtResult)
        Me.TabPage1.Controls.Add(Me.txtReplace)
        Me.TabPage1.Controls.Add(Me.txtRegex)
        Me.TabPage1.Controls.Add(Me.txtInput)
        Me.TabPage1.Controls.Add(Me.btnGetHtml)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(737, 434)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "测试正则式"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnGetRegex
        '
        Me.btnGetRegex.Location = New System.Drawing.Point(589, 70)
        Me.btnGetRegex.Name = "btnGetRegex"
        Me.btnGetRegex.Size = New System.Drawing.Size(126, 24)
        Me.btnGetRegex.TabIndex = 27
        Me.btnGetRegex.Text = "管理正则式库"
        Me.btnGetRegex.UseVisualStyleBackColor = True
        '
        'btnSaveRegex
        '
        Me.btnSaveRegex.Location = New System.Drawing.Point(589, 41)
        Me.btnSaveRegex.Name = "btnSaveRegex"
        Me.btnSaveRegex.Size = New System.Drawing.Size(126, 24)
        Me.btnSaveRegex.TabIndex = 26
        Me.btnSaveRegex.Text = "正则式入库"
        Me.btnSaveRegex.UseVisualStyleBackColor = True
        '
        'btnMatches
        '
        Me.btnMatches.Location = New System.Drawing.Point(589, 386)
        Me.btnMatches.Name = "btnMatches"
        Me.btnMatches.Size = New System.Drawing.Size(126, 24)
        Me.btnMatches.TabIndex = 25
        Me.btnMatches.Text = "Matches()"
        Me.btnMatches.UseVisualStyleBackColor = True
        '
        'btnSplit
        '
        Me.btnSplit.Location = New System.Drawing.Point(589, 357)
        Me.btnSplit.Name = "btnSplit"
        Me.btnSplit.Size = New System.Drawing.Size(126, 24)
        Me.btnSplit.TabIndex = 24
        Me.btnSplit.Text = "Split()"
        Me.btnSplit.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(589, 328)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(126, 24)
        Me.btnReplace.TabIndex = 23
        Me.btnReplace.Text = "Replace()"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnRegex
        '
        Me.btnRegex.Location = New System.Drawing.Point(589, 299)
        Me.btnRegex.Name = "btnRegex"
        Me.btnRegex.Size = New System.Drawing.Size(126, 24)
        Me.btnRegex.TabIndex = 22
        Me.btnRegex.Text = "ISMatch()"
        Me.btnRegex.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "匹配结果："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "替换的文字："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "正则表达式："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "字符串输入："
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtResult.Location = New System.Drawing.Point(8, 250)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResult.Size = New System.Drawing.Size(565, 170)
        Me.txtResult.TabIndex = 17
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(91, 204)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReplace.Size = New System.Drawing.Size(480, 21)
        Me.txtReplace.TabIndex = 16
        '
        'txtRegex
        '
        Me.txtRegex.Location = New System.Drawing.Point(8, 160)
        Me.txtRegex.Multiline = True
        Me.txtRegex.Name = "txtRegex"
        Me.txtRegex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRegex.Size = New System.Drawing.Size(564, 38)
        Me.txtRegex.TabIndex = 15
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(8, 21)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(564, 121)
        Me.txtInput.TabIndex = 14
        '
        'btnGetHtml
        '
        Me.btnGetHtml.Location = New System.Drawing.Point(589, 12)
        Me.btnGetHtml.Name = "btnGetHtml"
        Me.btnGetHtml.Size = New System.Drawing.Size(126, 24)
        Me.btnGetHtml.TabIndex = 13
        Me.btnGetHtml.Text = "获取网页"
        Me.btnGetHtml.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkECMAScript)
        Me.GroupBox1.Controls.Add(Me.chkExplicitCapture)
        Me.GroupBox1.Controls.Add(Me.chkIgnoreCase)
        Me.GroupBox1.Controls.Add(Me.chkIngorePatternWhiteSpace)
        Me.GroupBox1.Controls.Add(Me.chkRightToLeft)
        Me.GroupBox1.Controls.Add(Me.chkMultiLine)
        Me.GroupBox1.Controls.Add(Me.chkSingleLine)
        Me.GroupBox1.Location = New System.Drawing.Point(589, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 195)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "选项："
        '
        'chkECMAScript
        '
        Me.chkECMAScript.AutoSize = True
        Me.chkECMAScript.Location = New System.Drawing.Point(6, 168)
        Me.chkECMAScript.Name = "chkECMAScript"
        Me.chkECMAScript.Size = New System.Drawing.Size(84, 16)
        Me.chkECMAScript.TabIndex = 6
        Me.chkECMAScript.Text = "ECMAScript"
        Me.chkECMAScript.UseVisualStyleBackColor = True
        '
        'chkExplicitCapture
        '
        Me.chkExplicitCapture.AutoSize = True
        Me.chkExplicitCapture.Location = New System.Drawing.Point(6, 146)
        Me.chkExplicitCapture.Name = "chkExplicitCapture"
        Me.chkExplicitCapture.Size = New System.Drawing.Size(114, 16)
        Me.chkExplicitCapture.TabIndex = 5
        Me.chkExplicitCapture.Text = "ExplicitCapture"
        Me.chkExplicitCapture.UseVisualStyleBackColor = True
        '
        'chkIgnoreCase
        '
        Me.chkIgnoreCase.AutoSize = True
        Me.chkIgnoreCase.Location = New System.Drawing.Point(6, 124)
        Me.chkIgnoreCase.Name = "chkIgnoreCase"
        Me.chkIgnoreCase.Size = New System.Drawing.Size(84, 16)
        Me.chkIgnoreCase.TabIndex = 4
        Me.chkIgnoreCase.Text = "IgnoreCase"
        Me.chkIgnoreCase.UseVisualStyleBackColor = True
        '
        'chkIngorePatternWhiteSpace
        '
        Me.chkIngorePatternWhiteSpace.Location = New System.Drawing.Point(6, 86)
        Me.chkIngorePatternWhiteSpace.Name = "chkIngorePatternWhiteSpace"
        Me.chkIngorePatternWhiteSpace.Size = New System.Drawing.Size(103, 32)
        Me.chkIngorePatternWhiteSpace.TabIndex = 3
        Me.chkIngorePatternWhiteSpace.Text = "IngorePatternWhiteSpace"
        Me.chkIngorePatternWhiteSpace.UseVisualStyleBackColor = True
        '
        'chkRightToLeft
        '
        Me.chkRightToLeft.AutoSize = True
        Me.chkRightToLeft.Location = New System.Drawing.Point(6, 64)
        Me.chkRightToLeft.Name = "chkRightToLeft"
        Me.chkRightToLeft.Size = New System.Drawing.Size(90, 16)
        Me.chkRightToLeft.TabIndex = 2
        Me.chkRightToLeft.Text = "RightToLeft"
        Me.chkRightToLeft.UseVisualStyleBackColor = True
        '
        'chkMultiLine
        '
        Me.chkMultiLine.AutoSize = True
        Me.chkMultiLine.Location = New System.Drawing.Point(6, 42)
        Me.chkMultiLine.Name = "chkMultiLine"
        Me.chkMultiLine.Size = New System.Drawing.Size(78, 16)
        Me.chkMultiLine.TabIndex = 1
        Me.chkMultiLine.Text = "MultiLine"
        Me.chkMultiLine.UseVisualStyleBackColor = True
        '
        'chkSingleLine
        '
        Me.chkSingleLine.AutoSize = True
        Me.chkSingleLine.Location = New System.Drawing.Point(6, 20)
        Me.chkSingleLine.Name = "chkSingleLine"
        Me.chkSingleLine.Size = New System.Drawing.Size(84, 16)
        Me.chkSingleLine.TabIndex = 0
        Me.chkSingleLine.Text = "SingleLine"
        Me.chkSingleLine.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtUrl)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtXptah)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtOutput)
        Me.TabPage2.Controls.Add(Me.txtHtml)
        Me.TabPage2.Controls.Add(Me.btnXpathFilter)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(737, 434)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "HtmlAgilityPack"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(79, 151)
        Me.txtUrl.Multiline = True
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUrl.Size = New System.Drawing.Size(516, 21)
        Me.txtUrl.TabIndex = 8
        Me.txtUrl.Text = "https://www.baidu.com/s?wd=%E5%AE%A1%E6%9F%A5%E5%85%83%E7%B4%A0+Xpath&ie=UTF-8"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 12)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "网页地址："
        '
        'txtXptah
        '
        Me.txtXptah.Location = New System.Drawing.Point(79, 178)
        Me.txtXptah.Multiline = True
        Me.txtXptah.Name = "txtXptah"
        Me.txtXptah.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtXptah.Size = New System.Drawing.Size(516, 21)
        Me.txtXptah.TabIndex = 6
        Me.txtXptah.Text = "//*[@id=""con-ar""]/div[2]/div/div/table/tbody[1]/tr[4]/td[1]/span/span"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "网页节点："
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(8, 205)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(721, 226)
        Me.txtOutput.TabIndex = 2
        '
        'txtHtml
        '
        Me.txtHtml.Location = New System.Drawing.Point(8, 6)
        Me.txtHtml.Multiline = True
        Me.txtHtml.Name = "txtHtml"
        Me.txtHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHtml.Size = New System.Drawing.Size(721, 139)
        Me.txtHtml.TabIndex = 1
        '
        'btnXpathFilter
        '
        Me.btnXpathFilter.Location = New System.Drawing.Point(601, 151)
        Me.btnXpathFilter.Name = "btnXpathFilter"
        Me.btnXpathFilter.Size = New System.Drawing.Size(128, 48)
        Me.btnXpathFilter.TabIndex = 0
        Me.btnXpathFilter.Text = "节点筛选"
        Me.btnXpathFilter.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.cbLevel)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.txtRegexFiliter)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.txtOriginalURL)
        Me.TabPage3.Controls.Add(Me.btnCapture)
        Me.TabPage3.Controls.Add(Me.lvURL)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(737, 434)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "多线程链接收集"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(468, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 12)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "追踪层级："
        '
        'cbLevel
        '
        Me.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLevel.FormattingEnabled = True
        Me.cbLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbLevel.Location = New System.Drawing.Point(539, 12)
        Me.cbLevel.Name = "cbLevel"
        Me.cbLevel.Size = New System.Drawing.Size(104, 20)
        Me.cbLevel.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 12)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "正则式过滤："
        '
        'txtRegexFiliter
        '
        Me.txtRegexFiliter.Location = New System.Drawing.Point(86, 42)
        Me.txtRegexFiliter.Name = "txtRegexFiliter"
        Me.txtRegexFiliter.Size = New System.Drawing.Size(557, 21)
        Me.txtRegexFiliter.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "初始链接："
        '
        'txtOriginalURL
        '
        Me.txtOriginalURL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOriginalURL.Location = New System.Drawing.Point(74, 12)
        Me.txtOriginalURL.Name = "txtOriginalURL"
        Me.txtOriginalURL.Size = New System.Drawing.Size(383, 21)
        Me.txtOriginalURL.TabIndex = 2
        Me.txtOriginalURL.Text = "http://www.99mm.me/"
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(649, 12)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(80, 51)
        Me.btnCapture.TabIndex = 1
        Me.btnCapture.Text = "链接捕获"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'lvURL
        '
        Me.lvURL.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvURL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvURL.FullRowSelect = True
        Me.lvURL.Location = New System.Drawing.Point(0, 76)
        Me.lvURL.Name = "lvURL"
        Me.lvURL.Size = New System.Drawing.Size(737, 358)
        Me.lvURL.TabIndex = 0
        Me.lvURL.UseCompatibleStateImageBehavior = False
        Me.lvURL.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "序号"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "层级"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "URL"
        Me.ColumnHeader3.Width = 310
        '
        'NetWorm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 460)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NetWorm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "网络爬虫"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnGetHtml As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkECMAScript As CheckBox
    Friend WithEvents chkExplicitCapture As CheckBox
    Friend WithEvents chkIgnoreCase As CheckBox
    Friend WithEvents chkIngorePatternWhiteSpace As CheckBox
    Friend WithEvents chkRightToLeft As CheckBox
    Friend WithEvents chkMultiLine As CheckBox
    Friend WithEvents chkSingleLine As CheckBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtReplace As TextBox
    Friend WithEvents txtRegex As TextBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnMatches As Button
    Friend WithEvents btnSplit As Button
    Friend WithEvents btnReplace As Button
    Friend WithEvents btnRegex As Button
    Friend WithEvents btnGetRegex As Button
    Friend WithEvents btnSaveRegex As Button
    Friend WithEvents btnXpathFilter As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents txtHtml As TextBox
    Friend WithEvents txtXptah As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents cbLevel As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRegexFiliter As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOriginalURL As TextBox
    Friend WithEvents btnCapture As Button
    Friend WithEvents lvURL As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents Label11 As Label
End Class
