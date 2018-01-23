Imports 网络爬虫.NetWorm

Public Class mgr
    Private lstZ As List(Of ZZBDS)
    Private strXmlPath As String

    Public Sub New(ByVal strPath As String)
        InitializeComponent()
        lstZ = NetWorm.GetXmlZZBDS(strPath)
        loadZZBDS(lstZ)
        strXmlPath = strPath
    End Sub

    Public Function GetZZBDS() As ZZBDS
        If lvZZBDS.SelectedItems.Count > 0 Then
            Dim lvItem As ListViewItem = lvZZBDS.SelectedItems(0)
            Dim z As New ZZBDS(lvItem.Text, lvItem.Tag)
            z.strDiscribe = lvItem.SubItems(1).Text
            z.strUrl = lvItem.SubItems(2).Text
            Return z
        Else
            Return Nothing
        End If
    End Function

    Private Sub loadZZBDS(ByVal lst As List(Of ZZBDS))
        lvZZBDS.Items.Clear()
        If lst.Count > 0 Then
            For Each z As ZZBDS In lst
                Dim lvItem As New ListViewItem
                lvItem.Text = z.strRegex
                lvItem.SubItems.Add(New ListViewItem.ListViewSubItem(lvItem, z.strDiscribe))
                lvItem.SubItems.Add(New ListViewItem.ListViewSubItem(lvItem, z.strUrl))
                lvItem.Tag = z.roOptions
                lvZZBDS.Items.Add(lvItem)
            Next
        End If
    End Sub

    Private Sub ButtonClose(sender As Object, e As EventArgs) Handles btnOk.Click, btnCancel.Click
        Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lvZZBDS.SelectedItems.Count > 0 Then
            Dim lvItem As ListViewItem = lvZZBDS.SelectedItems(0)
            lstZ.RemoveAll(Function(a) a.strRegex = lvItem.Text)
            loadZZBDS(lstZ)
            NetWorm.SaveZZBDS2Xml(lstZ, strXmlPath)
        End If
    End Sub

    Private Sub lvZZBDS_DoubleClick(sender As Object, e As EventArgs) Handles lvZZBDS.DoubleClick
        Me.DialogResult = DialogResult.OK
        Close()
    End Sub
End Class