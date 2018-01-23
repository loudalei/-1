Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Xml
Imports System.Xml.Serialization
Imports HtmlAgilityPack

Public Class NetWorm
    Private strCurrentURL As String
    Private Delegate Function dlgtGetWebURL(ByVal strUrl As String, ByVal strRegex As String) As Dictionary(Of String, String)

#Region "配套类和函数"
    '正则表达式示例
    Public Class ZZBDS
        Public strRegex As String
        Public strDiscribe As String
        Public roOptions As RegexOptions
        Public strUrl As String

        Public Sub New()
        End Sub

        Public Sub New(ByVal zzs As String, ByVal op As RegexOptions)
            strRegex = zzs
            roOptions = op
        End Sub
    End Class

    '获取网页代码
    Public Function GetWebCode(ByVal URL As String) As String
        Try
            Dim webRq As HttpWebRequest = WebRequest.Create(URL)
            Dim lstB As New List(Of Byte)()
            Dim csRp As String
            Using wedRp As HttpWebResponse = webRq.GetResponse
                csRp = wedRp.CharacterSet
                If Strings.Left(wedRp.ContentType, 4).ToUpper = "TEXT" Then
                    Dim intP As Integer
                    If wedRp.ContentEncoding.ToUpper = "GZIP" Then '判断网页是否经过压缩
                        Using wedStm As Stream = New Compression.GZipStream(wedRp.GetResponseStream, Compression.CompressionMode.Decompress)
                            '保存流到字节数组
                            intP = wedStm.ReadByte
                            Do While intP <> -1
                                lstB.Add(CByte(intP))
                                intP = wedStm.ReadByte()
                            Loop
                        End Using
                    Else
                        Using wedStm As Stream = wedRp.GetResponseStream
                            '保存流到字节数组
                            intP = wedStm.ReadByte
                            Do While intP <> -1
                                lstB.Add(CByte(intP))
                                intP = wedStm.ReadByte()
                            Loop
                        End Using
                    End If
                End If
                wedRp.Close()
            End Using
            webRq = Nothing

            If lstB.Count = 0 Then Return ""
            Dim b() As Byte = lstB.ToArray()
            '判断文字集，gb2312 UTF-8
            Dim HtmlStr As String = Encoding.ASCII.GetString(b)
            Dim regStr As String = "(?is)\s*charset\s?=\s?([""'])?(?<charset>[^'""]+)([""'])?\b"
            Dim CS As String = Regex.Match(HtmlStr, regStr, RegexOptions.IgnoreCase).Groups("charset").Value.ToUpper
            If CS = "" Then
                If IsUTF8(b) Then   'csRp = "ISO-8859-1" Then
                    Return Encoding.UTF8.GetString(b)
                Else
                    Return Encoding.Default.GetString(b)
                End If
            Else
                Return Encoding.GetEncoding(CS).GetString(b)
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    '判断字节组编码是否为UTF-8
    Public Function IsUTF8(ByVal B() As Byte) As Boolean
        Try
            Dim i As Long, AscN As Long, Length As Long
            Length = B.Length
            If Length < 3 Then
                Return False
            ElseIf B(0) = &HEF And B(1) = &HBB And B(2) = &HBF Then
                Return True
            End If

            Do While i <= Length - 1
                If B(i) < 128 Then
                    i = i + 1
                    AscN = AscN + 1
                ElseIf (B(i) And &HE0) = &HC0 And (B(i + 1) And &HC0) = &H80 Then
                    i = i + 2
                ElseIf i + 2 < Length Then
                    If (B(i) And &HF0) = &HE0 And (B(i + 1) And &HC0) = &H80 And (B(i + 2) And &HC0) = &H80 Then
                        i = i + 3
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Loop

            If AscN = Length Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return True
        End Try
    End Function

    '获取当前程序实在的目录
    Public Function GetCurrentPath() As String
        Dim strPath As String
        strPath = Reflection.Assembly.GetExecutingAssembly().Location
        strPath = Path.GetDirectoryName(strPath)
        If strPath.Length > 3 And Not strPath.EndsWith("\"c) Then strPath = strPath & "\"
        Return strPath
    End Function

    '从xml文件读取正则表达式示例
    Public Function GetXmlZZBDS(ByVal strPath As String) As List(Of ZZBDS)
        Dim lstZ As New List(Of ZZBDS)
        Try
            Dim xmlSL As XmlSerializer = New XmlSerializer(GetType(List(Of ZZBDS))) '指定序列化类型  
            Using fsRead As New FileStream(strPath, FileMode.OpenOrCreate)
                Using xmlRead As XmlReader = XmlReader.Create(fsRead)
                    lstZ = xmlSL.Deserialize(xmlRead)
                End Using
            End Using
            Return lstZ
        Catch ex As Exception
            Return lstZ
        End Try
    End Function

    '正则表达式示例列表保存到xml文件
    Public Function SaveZZBDS2Xml(ByVal lstZ As List(Of ZZBDS), ByVal strPath As String) As Boolean
        Try
            Dim xmlSL As XmlSerializer = New XmlSerializer(GetType(List(Of ZZBDS)))
            Using fsWrite As New FileStream(strPath, FileMode.Truncate)
                Using xmlWrite As XmlWriter = XmlWriter.Create(fsWrite, New XmlWriterSettings With {.Encoding = Encoding.UTF8, .Indent = True})
                    xmlSL.Serialize(xmlWrite, lstZ)
                    xmlWrite.Flush()
                End Using
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '合并两个字典，A优先
    Public Function MergeDic(Of T, V)(ByVal d1 As Dictionary(Of T, V), ByVal d2 As Dictionary(Of T, V)) As Dictionary(Of T, V)
        If d1 Is Nothing AndAlso d2 Is Nothing Then Return Nothing
        If d1 Is Nothing Then Return d2
        If d2 Is Nothing Then Return d1
        Dim dTemp As Dictionary(Of T, V) = d1
        For Each k As KeyValuePair(Of T, V) In d2
            If Not dTemp.ContainsKey(k.Key) Then dTemp.Add(k.Key, k.Value)
        Next
        Return dTemp
    End Function
#End Region

    Private Function GetSelectRegexOptions() As RegexOptions
        Dim ro As RegexOptions = RegexOptions.None
        If Me.chkECMAScript.Checked Then ro += RegexOptions.ECMAScript
        If Me.chkExplicitCapture.Checked Then ro += RegexOptions.ExplicitCapture
        If Me.chkIgnoreCase.Checked Then ro += RegexOptions.IgnoreCase
        If Me.chkIngorePatternWhiteSpace.Checked Then ro += RegexOptions.IgnorePatternWhitespace
        If Me.chkMultiLine.Checked Then ro += RegexOptions.Multiline
        If Me.chkRightToLeft.Checked Then ro += RegexOptions.RightToLeft
        If Me.chkSingleLine.Checked Then ro += RegexOptions.Singleline
        Return ro
    End Function

    Private Sub btnGetHtml_Click(sender As Object, e As EventArgs) Handles btnGetHtml.Click
        strCurrentURL = InputBox("输入网页地址：", "输入", "http://www.xgyw.cc/LEGBABY/")
        txtInput.Text = GetWebCode(strCurrentURL)
        If txtInput.Text = "" Then strCurrentURL = ""
    End Sub

    Private Sub btnRegex_Click(sender As Object, e As EventArgs) Handles btnRegex.Click
        Try
            Dim ro As RegexOptions = GetSelectRegexOptions()
            Dim rgx As New Regex(Me.txtRegex.Text, ro)
            If rgx.IsMatch(Me.txtInput.Text) Then
                Me.txtResult.Text = "发现匹配项"
                Me.txtResult.ForeColor = Color.Blue
            Else
                Me.txtResult.Text = "没有匹配项"
                Me.txtResult.ForeColor = Color.Red
            End If
        Catch ex As Exception
            Me.txtResult.Text = "你的正则式有错误，具体信息如下：" & ex.Message
            Me.txtResult.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        Try
            Dim ro As RegexOptions = GetSelectRegexOptions()
            Dim rgx As New Regex(Me.txtRegex.Text, ro)
            Me.txtResult.Text = rgx.Replace(Me.txtInput.Text, Me.txtReplace.Text)
            Me.txtResult.ForeColor = Color.Blue
        Catch ex As Exception
            Me.txtResult.Text = "你的正则式有错误，具体信息如下：" & ex.Message
            Me.txtResult.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub btnSplit_Click(sender As Object, e As EventArgs) Handles btnSplit.Click
        Try
            Dim ro As RegexOptions = GetSelectRegexOptions()
            Dim rgx As New Regex(Me.txtRegex.Text, ro)
            Dim strResult() As String = rgx.Split(Me.txtInput.Text)
            Dim strTemp As String
            Dim sbResult As New StringBuilder(Me.txtInput.Text.Length)
            For Each strTemp In strResult
                sbResult.AppendLine(strTemp)
            Next
            Me.txtResult.Text = sbResult.ToString
            Me.txtResult.ForeColor = Color.Blue
        Catch ex As Exception
            Me.txtResult.Text = "你的正则式有错误，具体信息如下：" & ex.Message
            Me.txtResult.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub btnMatches_Click(sender As Object, e As EventArgs) Handles btnMatches.Click
        Me.txtResult.Text = ""
        Try
            Dim ro As RegexOptions = GetSelectRegexOptions()
            Dim rgx As New Regex(Me.txtRegex.Text, ro)
            Dim sbResult As New StringBuilder()
            Dim mcFound As MatchCollection = rgx.Matches(Me.txtInput.Text)
            If mcFound.Count < 1 Then
                Me.txtResult.Text = "没有找到匹配项"
                Me.txtResult.ForeColor = Color.Red
                Return
            Else
                sbResult.AppendLine("共找到" & mcFound.Count.ToString & "个匹配项！")
            End If
            Dim strNext As String = "——————————————————————————————"
            Dim i As Integer
            For Each m As Match In mcFound
                sbResult.AppendLine()
                sbResult.AppendLine(strNext)
                sbResult.AppendLine()
                sbResult.AppendLine(m.Value)
                If m.Groups.Count > 1 Then
                    i = 0
                    For Each mg As Group In m.Groups
                        If i > 0 Then sbResult.AppendLine(vbTab & "Group" & i.ToString("00") & "：" & mg.Value)
                        i += 1
                    Next
                End If
            Next
            Me.txtResult.Text = sbResult.ToString
            Me.txtResult.ForeColor = Color.Blue
        Catch ex As Exception
            Me.txtResult.Text = "你的正则式有错误，具体信息如下：" & ex.Message
            Me.txtResult.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub btnXpathFilter_Click(sender As Object, e As EventArgs) Handles btnXpathFilter.Click
        Dim strUrl As String = txtUrl.Text
        Dim rootUrl As String = Regex.Match(strUrl, "(http[s]?://[^/]*)/").Groups(1).Value
        Dim docText = GetWebCode(strUrl)
        txtHtml.Text = docText
        Dim hd As New HtmlDocument()
        hd.LoadHtml(docText)
        Dim sb As New StringBuilder
        Dim hn As HtmlNode = hd.DocumentNode.SelectSingleNode(txtXptah.Text)
        If hn IsNot Nothing Then
            'txtOutput.Text = hn.InnerHtml
            Dim hnc As HtmlNodeCollection = hn.SelectNodes("div") '选择标签数组
            If hnc Is Nothing OrElse hnc.Count < 1 Then Return
            For Each hnTemp As HtmlNode In hnc
                Dim hncTemp As HtmlNodeCollection = hnTemp.SelectNodes("a")
                For Each node In hncTemp
                    If node.HasAttributes Then
                        Dim strInner As String = node.InnerText.Trim()
                        Dim strHerf As String = node.Attributes("href").Value
                        sb.AppendFormat("{0} ：{1}{2}", strInner, strHerf, vbCrLf)
                    End If
                Next
            Next
            txtOutput.Text = sb.ToString
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = CInt(GetSetting("网络爬虫", "窗口位置", "x", "40"))
        Me.Top = CInt(GetSetting("网络爬虫", "窗口位置", "y", "40"))
        Me.chkECMAScript.Checked = CBool(GetSetting("网络爬虫", "正则式选项", "ECMAScript", "0"))
        Me.chkExplicitCapture.Checked = CBool(GetSetting("网络爬虫", "正则式选项", "ExplicitCapture", "0"))
        Me.chkIgnoreCase.Checked = CBool(GetSetting("网络爬虫", "正则式选项", "IgnoreCase", "0"))
        Me.chkIngorePatternWhiteSpace.Checked = CBool(GetSetting("网络爬虫", "正则式选项", "IngorePatternWhiteSpace", "0"))
        Me.chkMultiLine.Checked = CBool(GetSetting("网络爬虫", "正则式选项", "MultiLine", "0"))
        Me.chkRightToLeft.Checked = CBool(GetSetting("网络爬虫", "正则式选项", "RightToLeft", "0"))
        Me.chkSingleLine.Checked = CBool(GetSetting("网络爬虫", "正则式选项", "SingleLine", "0"))
        cbLevel.SelectedIndex = 0
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveSetting("网络爬虫", "窗口位置", "x", Me.Left.ToString)
        SaveSetting("网络爬虫", "窗口位置", "y", Me.Top.ToString)
        SaveSetting("网络爬虫", "正则式选项", "ECMAScript", Me.chkECMAScript.Checked.ToString)
        SaveSetting("网络爬虫", "正则式选项", "ExplicitCapture", Me.chkExplicitCapture.Checked.ToString)
        SaveSetting("网络爬虫", "正则式选项", "IgnoreCase", Me.chkIgnoreCase.Checked.ToString)
        SaveSetting("网络爬虫", "正则式选项", "IngorePatternWhiteSpace", Me.chkIngorePatternWhiteSpace.Checked.ToString)
        SaveSetting("网络爬虫", "正则式选项", "MultiLine", Me.chkMultiLine.Checked.ToString)
        SaveSetting("网络爬虫", "正则式选项", "RightToLeft", Me.chkRightToLeft.Checked.ToString)
        SaveSetting("网络爬虫", "正则式选项", "SingleLine", Me.chkSingleLine.Checked.ToString)
    End Sub

    Private Sub btnSaveRegex_Click(sender As Object, e As EventArgs) Handles btnSaveRegex.Click
        If txtRegex.Text = "" Then
            MsgBox("没有正则表达式！", vbCritical, "不能保存")
            Return
        End If
        Dim strXmlPath As String = GetCurrentPath() & "Regex.xml"

        Dim lstZ As List(Of ZZBDS) = GetXmlZZBDS(strXmlPath)
        If lstZ.Count > 0 Then
            For Each zTemp As ZZBDS In lstZ
                If zTemp.strRegex = txtRegex.Text Then
                    If MsgBox("库中已存在同样的正则表达式！选【是】替换备注，选【否】取消保存", vbYesNo, "项目重复：") = vbNo Then
                        Return
                    Else
                        lstZ.Remove(zTemp)
                        Exit For
                    End If
                End If
            Next
        End If
        Dim z As New ZZBDS(txtRegex.Text, GetSelectRegexOptions)
        Dim strDiscribe As String = InputBox("输入备注：", "输入：")
        z.strDiscribe = strDiscribe
        z.strUrl = strCurrentURL
        lstZ.Add(z)
        SaveZZBDS2Xml(lstZ, strXmlPath)
    End Sub

    Private Sub btnGetRegex_Click(sender As Object, e As EventArgs) Handles btnGetRegex.Click
        Dim strXmlPath As String = GetCurrentPath() & "Regex.xml"
        Dim lst As List(Of ZZBDS) = GetXmlZZBDS(strXmlPath)
        Dim frmMgr As New mgr(strXmlPath)
        If frmMgr.ShowDialog = DialogResult.OK Then
            Dim z As ZZBDS = frmMgr.GetZZBDS
            If z Is Nothing Then Return
            txtRegex.Text = z.strRegex
            txtResult.Text = z.strDiscribe
            txtInput.Text = GetWebCode(z.strUrl)
            Dim i As Integer = z.roOptions
            Me.chkECMAScript.Checked = False
            Me.chkExplicitCapture.Checked = False
            Me.chkIgnoreCase.Checked = False
            Me.chkIngorePatternWhiteSpace.Checked = False
            Me.chkMultiLine.Checked = False
            Me.chkRightToLeft.Checked = False
            Me.chkSingleLine.Checked = False
            Do Until i < 1
                Select Case i
                    Case >= RegexOptions.CultureInvariant
                        i -= RegexOptions.CultureInvariant
                    Case >= RegexOptions.ECMAScript
                        i -= RegexOptions.ECMAScript
                        chkECMAScript.Checked = True
                    Case >= RegexOptions.RightToLeft
                        i -= RegexOptions.RightToLeft
                        chkRightToLeft.Checked = True
                    Case >= RegexOptions.IgnorePatternWhitespace
                        i -= RegexOptions.IgnorePatternWhitespace
                        chkIngorePatternWhiteSpace.Checked = True
                    Case >= RegexOptions.Singleline
                        i -= RegexOptions.Singleline
                        chkSingleLine.Checked = True
                    Case >= RegexOptions.Compiled
                        i -= RegexOptions.Compiled
                    Case >= RegexOptions.ExplicitCapture
                        i -= RegexOptions.ExplicitCapture
                        chkExplicitCapture.Checked = True
                    Case >= RegexOptions.Multiline
                        i -= RegexOptions.Multiline
                        chkMultiLine.Checked = True
                    Case >= RegexOptions.IgnoreCase
                        i -= RegexOptions.IgnoreCase
                        chkIgnoreCase.Checked = True
                End Select
            Loop
        Else
            Return
        End If
    End Sub

    Private Sub txtInput_ModifiedChanged(sender As Object, e As EventArgs) Handles txtInput.ModifiedChanged
        strCurrentURL = ""
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        lvURL.Items.Clear()
        Dim dicWebUrl As New Dictionary(Of String, Integer)
        Dim strOriginalUrl As String = txtOriginalURL.Text
        Dim strUrlRegex As String = txtRegexFiliter.Text
        Dim intLevel As Integer = CInt(cbLevel.Text)
        Dim intLevelCurrent As Integer

        dicWebUrl.Add(strOriginalUrl, 0)
        Dim dicTemp As Dictionary(Of String, Integer) = dicWebUrl
        Do Until intLevelCurrent >= intLevel
            intLevelCurrent += 1
            dicTemp = CaptureWebUrl(dicTemp, strUrlRegex, intLevelCurrent)
            dicWebUrl = MergeDic(dicWebUrl, dicTemp)
        Loop
        Dim i As Integer
        Dim strFormat As New String("0"c, dicWebUrl.Count.ToString.Length)
        For Each k As KeyValuePair(Of String, Integer) In dicWebUrl
            Dim lvItem As New ListViewItem
            i += 1
            lvItem.Text = i.ToString(strFormat)
            lvItem.SubItems.Add(New ListViewItem.ListViewSubItem(lvItem, k.Value))
            lvItem.SubItems.Add(New ListViewItem.ListViewSubItem(lvItem, GetFullUrl(strOriginalUrl, k.Key)))
            lvURL.Items.Add(lvItem)
        Next
    End Sub

    Private Function CaptureWebUrl(ByVal dicUrl As Dictionary(Of String, Integer), ByVal strRegex As String, ByVal intLevel As Integer) As Dictionary(Of String, Integer)
        Try
            Dim dicWebUrl As New Dictionary(Of String, Integer)
            Dim strUrlRegx As String = strRegex
            If strUrlRegx = "" Then strUrlRegx = "(?is)<a[^>]+href\s?=\s?([""']?)(?<href>[^'"" ]+\b?)\1?\s?[^>]*>.?(?:<img.*?>)+[^<]*<"
            Dim rgx As New Regex(strUrlRegx)
            For Each k As KeyValuePair(Of String, Integer) In dicUrl
                Dim strWebCode As String = GetWebCode(k.Key)
                Dim mcFound As MatchCollection = rgx.Matches(strWebCode)
                If mcFound.Count < 1 Then Return Nothing
                For Each m As Match In mcFound
                    Dim urlTemp As String = GetFullUrl(k.Key, m.Groups("href").Value)
                    If Not dicWebUrl.ContainsKey(urlTemp) Then dicWebUrl.Add(urlTemp, intLevel)
                Next
            Next
            Return dicWebUrl
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function GetFullUrl(ByVal urlCur As String, ByVal urlRef As String) As String
        If Regex.IsMatch(urlRef, "://") Then Return urlRef
        Dim m1 As Match = Regex.Match(urlCur, "(?<url>.*://.*?)/")
        Dim pathRoot As String = m1.Groups("url").Value
        Dim m2 As Match = Regex.Match(urlCur, "(?<url>.*)/")
        Dim pathCur As String = m2.Groups("url").Value
        If urlRef.StartsWith("/") Then Return pathRoot & urlRef
        Dim str1 As String = pathCur
        Dim str2 As String = urlRef
        Do While str2.Length > 4 AndAlso str2.StartsWith("../")
            Dim m3 As Match = Regex.Match(str1, "(?<url>.*)/")
            str1 = m3.Groups("url").Value
            str2 = Mid(str2, 4)
        Loop
        Return str1 & "/" & str2
    End Function

    Private Sub lvURL_DoubleClick(sender As Object, e As EventArgs) Handles lvURL.DoubleClick
        If lvURL.SelectedItems.Count > 0 Then
            Dim lvItem As ListViewItem = lvURL.SelectedItems(0)
            Clipboard.Clear()
            Clipboard.SetText(lvItem.SubItems(2).Text)
        End If
    End Sub
End Class
