
Imports System.ComponentModel
Imports System.IO


Public Class Form1

    Friend ReadOnly AppliTitle As String = My.Application.Info.Title

    Private ListHeight As Integer = 122
    Private WindowSplitMenuItem As ToolStripMenuItem
    Private ViewSizeMenuItem As ToolStripMenuItem

    Private Sub FileExitMenuItem_Click(sender As Object, e As EventArgs) Handles FileExitMenuItem.Click

        Me.Close()
    End Sub

    Private Sub FileListView_MouseUp(sender As Object, e As MouseEventArgs) Handles FileListView.MouseUp

        With FileListView
            If .FocusedItem IsNot Nothing Then
                .FocusedItem.Selected = True
            End If
        End With
    End Sub

    Private Function LoadImage(ByVal imagePath As String) As Boolean

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim pathExtension As String = Path.GetExtension(imagePath).ToLower

            Dim readImage As Image

            If pathExtension = ".gif" OrElse pathExtension = ".ico" Then
                readImage = Image.FromFile(imagePath)
            Else

                Using readFileStream As FileStream =
                    New FileStream(imagePath, FileMode.Open, FileAccess.Read)
                    readImage = Image.FromStream(readFileStream)
                End Using

            End If

            With ViewPictureBox
                If .Image IsNot Nothing Then
                    .Image.Dispose()
                    .Image = Nothing

                End If
                .Image = readImage
            End With
            Return True
        Catch ex As Exception
            MessageBox.Show("ファイル""" & imagePath & """ はロードできません。", AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False
        Finally
            Cursor.Current = Cursors.Arrow
        End Try
    End Function

    Private Sub FileListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileListView.SelectedIndexChanged

        Static currentListItem As ListViewItem

        With FileListView

            If .SelectedItems.Count = 0 Then
                Exit Sub
            End If

            If .SelectedItems(0) Is currentListItem Then
                Exit Sub
            End If

            If Not LoadImage(.SelectedItems(0).SubItems(4).Text) Then
                Exit Sub
            End If

            ViewSizeMenuItem.PerformClick()
            .SelectedItems(0).EnsureVisible()
            Me.Text = .SelectedItems(0).SubItems(0).Text & " - " & AppliTitle

            currentListItem = .SelectedItems(0)

        End With
    End Sub

    Private Sub FileMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles FileMenuItem.DropDownItemClicked

        FileListView.Focus()
    End Sub

    Private Sub FileOpenMenuItem_Click(sender As Object, e As EventArgs) Handles FileOpenMenuItem.Click

        With OpenFileDialog1
            .FileName = ""

            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
        End With

        Dim listCount As Integer = FileListView.Items.Count

        ViewPictureBox.Hide()
        FileListView.BeginUpdate()

        For Each openFileName As String In OpenFileDialog1.FileNames

            If SearchFileList(openFileName) < 0 AndAlso LoadImage(openFileName) Then

                AddListItem(openFileName)

            End If

        Next

        ViewPictureBox.Show()
        FileListView.EndUpdate()

        With FileListView
            If .Items.Count = listCount Then

                For Each openFileName As String In OpenFileDialog1.FileNames

                    Dim itemIndex As Integer = SearchFileList(openFileName)

                    If itemIndex >= 0 Then
                        .Items(itemIndex).Selected = True
                        .SelectedItems(0).Focused = True
                        Exit For
                    End If
                Next

                MessageBox.Show("ファイルリストに登録した追加ファイルはありません。",
                                AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)

                Exit Sub

            End If

            .Items(listCount).Selected = True
            .SelectedItems(0).Focused = True

            If .Items.Count > listCount + 1 Then

                MessageBox.Show((.Items.Count - listCount).ToString & "ファイルをファイルリストに登録しました。",
                                AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        With FileListView
            If .FocusedItem IsNot Nothing Then
                .FocusedItem.Focused = True
            End If
        End With

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = AppliTitle

        With My.Computer.Screen.Bounds.Size
            Me.Size = New Size(.Width * 3 \ 4, .Height * 4 \ 5)
        End With

        WindowTopMenuItem.Checked = True
        WindowSplitMenuItem = WindowTopMenuItem
        ViewRegularMenuItem.Checked = True
        ViewSizeMenuItem = ViewRegularMenuItem
        SplitContainer1.SplitterIncrement = 122
        ViewPictureBox.SetBounds(-1, -1, 0, 0) '''''''''''''''''''''''''''''''''''''''

        With OpenFileDialog1
            .Filter =
                "ビットマップファイル(*.bmp)|*.bmp|JPEGファイル(*.jpg; *.jpeg)|*.jpg; *.jpeg| GIFファイル(*.gif)| *.gif|" &
                    "PNGファイル(*.png)|*.png|TIFFファイル(*.tif; *.tiff)|*.tif; *.tiff | メタファイル(*.wmf)| *.wmf|" &
                        "すべてのイメージファイル(*.bmp; *.jpg; *.jpeg; *.gif; *.png; *.tif; *.tiff; .wmf;)| *.bmp; *.jpg; *.jpeg; *.gif; *.png; *.tif; *.tiff; .wmf; |" &
                        "すべてのファイル(*.*)|*.*"
            .FilterIndex = 7

            .Multiselect = True
        End With

        With FolderBrowserDialog1
            .Description =
                "フォルダを選択してください。" & ControlChars.NewLine &
                "選択したフォルダ内の画像ファイルを検索します。"

            .ShowNewFolderButton = False
        End With
    End Sub

    Private Sub MenuStrip1_MenuActivate(sender As Object, e As EventArgs) Handles MenuStrip1.MenuActivate

        FileListView.Focus()
    End Sub

    Private Sub ViewMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles ViewMenuItem.DropDownOpening

        With FileListView
            If .Items.Count <= 1 Then
                ViewPrevMenuItem1.Enabled = False
                ViewNextMenuItem.Enabled = False
            Else
                ViewPrevMenuItem1.Enabled = .SelectedIndices(0) > 0
                ViewNextMenuItem.Enabled = .SelectedIndices(0) < .Items.Count - 1
            End If
        End With
    End Sub

    Private Sub ViewMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles ViewMenuItem.DropDownClosed

        ViewPrevMenuItem1.Enabled = True
        ViewNextMenuItem.Enabled = True
    End Sub

    Private Sub ViewMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ViewMenuItem.DropDownItemClicked

        FileListView.Focus()

        If Not TypeOf e.ClickedItem Is ToolStripMenuItem Then
            Exit Sub
        End If

        Dim clickedMenuItem As ToolStripMenuItem = CType(e.ClickedItem, ToolStripMenuItem)

        If ViewMenuItem.DropDownItems.IndexOf(clickedMenuItem) < 3 Then

            Exit Sub
        End If

        If clickedMenuItem.Checked Then
            Exit Sub
        End If

        ViewSizeMenuItem.Checked = False
        clickedMenuItem.Checked = True

        ViewSizeMenuItem = clickedMenuItem

    End Sub

    Private Sub ViewPrevMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewPrevMenuItem1.Click, ContextPrevMenuItem.Click

        With FileListView
            If .Items.Count <= 1 OrElse .SelectedIndices(0) = 0 Then
                Exit Sub
            End If

            .Items(.SelectedIndices(0) - 1).Selected = True
            .SelectedItems(0).Focused = True

        End With
    End Sub

    Private Sub ViewNextMenuItem_Click(sender As Object, e As EventArgs) Handles ViewNextMenuItem.Click, ContextNextMenuItem.Click

        With FileListView

            If .Items.Count <= 1 OrElse .SelectedIndices(0) = .Items.Count - 1 Then
                Exit Sub
            End If

            .Items(.SelectedIndices(0) + 1).Selected = True
            .SelectedItems(0).Focused = True

        End With
    End Sub

    Private Sub WindowMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles WindowMenuItem.DropDownItemClicked

        FileListView.Focus()

        Dim clickedMenuItem As ToolStripMenuItem = CType(e.ClickedItem, ToolStripMenuItem)

        If clickedMenuItem.Checked Then
            Exit Sub
        End If

        WindowSplitMenuItem.Checked = False
        clickedMenuItem.Checked = True

        WindowSplitMenuItem = clickedMenuItem
    End Sub

    Private Sub WindowTopMenuItem_Click(sender As Object, e As EventArgs) Handles WindowTopMenuItem.Click

        With SplitContainer1

            .SplitterDistance = ListHeight
            .Orientation = Orientation.Horizontal
            .Panel1Collapsed = False

        End With

        With FileListView

            .Enabled = True
            .Focus()

            If .Items.Count > 1 Then
                .SelectedItems(0).EnsureVisible()
            End If
        End With
    End Sub

    Private Sub WindowLeftMenuItem_Click(sender As Object, e As EventArgs) Handles WindowLeftMenuItem.Click

        With SplitContainer1

            .SplitterDistance = FileListView.Columns(0).Width
            .Orientation = Orientation.Vertical
            .Panel1Collapsed = False

        End With

        With FileListView

            .Enabled = True
            .Focus()

            If .Items.Count > 11 Then
                .SelectedItems(0).EnsureVisible()
            End If
        End With
    End Sub

    Private Sub WindowHideMenuItem_Click(sender As Object, e As EventArgs) Handles WindowHideMenuItem.Click

        SplitContainer1.Panel1Collapsed = True
        FileListView.Enabled = False

    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

        If Not WindowTopMenuItem.Checked Then
            Exit Sub
        End If

        ListHeight = SplitContainer1.SplitterDistance

        With FileListView

            If .SelectedItems.Count = 0 Then
                Exit Sub
            End If

            .SelectedItems(0).EnsureVisible()

        End With
    End Sub

    Private Sub FileListView_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles FileListView.ColumnClick

        If e.Column <> 0 Then
            Exit Sub
        End If

        With FileListView

            If .Items.Count <= 1 Then
                Exit Sub
            End If

            Static ascendingOrder As SortOrder
            ascendingOrder = Not ascendingOrder

            If ascendingOrder Then
                .Sorting = SortOrder.Ascending
            Else
                .Sorting = SortOrder.Descending
            End If

            .Sorting = SortOrder.None
            .SelectedItems(0).Focused = True
            .SelectedItems(0).EnsureVisible()

        End With
    End Sub

    Private Sub FileMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles FileMenuItem.DropDownOpening

        With FileListView
            FileDeleteMenuItem.Enabled = .SelectedItems.Count = 1
            FileClearMenuItem1.Enabled = FileListView.Items.Count > 0

        End With
    End Sub

    Private Sub FileClearMenuItem1_Click(sender As Object, e As EventArgs) Handles FileClearMenuItem1.Click

        If MessageBox.Show _
            ("ファイルリストに登録したファイルをすべて削除します。",
             AppliTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Cancel Then

            Exit Sub

        End If

        FileListView.Items.Clear()

        With ViewPictureBox

            .Image.Dispose()
            .Image = Nothing
            .Size = New Size(0, 0)

        End With

        Me.Text = AppliTitle
    End Sub

    Private Sub ViewRegularMenuItem_EnabledChanged(sender As Object, e As EventArgs) Handles ViewRegularMenuItem.EnabledChanged

        With SplitContainer1.Panel1

            .AutoScroll = False
            .AutoScroll = True

        End With

        With ViewPictureBox

            If .Image IsNot Nothing Then
                .ClientSize = .Image.Size
            End If

        End With
    End Sub

    Private Sub ViewSmallMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSmallMenuItem.Click

        With SplitContainer1.Panel2

            .AutoScroll = False
            .AutoScroll = True

        End With

        With ViewPictureBox

            If .Image IsNot Nothing Then

                .ClientSize = New Size(.Image.Width \ 2, .Image.Height \ 2)

            End If

        End With
    End Sub

    Private Sub ViewLargeMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLargeMenuItem.Click

        With SplitContainer1.Panel2

            .AutoScroll = False
            .AutoScroll = True
        End With

        With ViewPictureBox

            If .Image IsNot Nothing Then

                .ClientSize = New Size(.Image.Width * 2, .Image.Height * 2)
            End If
        End With
    End Sub

    Private Sub ViewFitMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFitMenuItem.Click

        SplitContainer1.Panel2.AutoScroll = False

        With ViewPictureBox

            If .Image Is Nothing Then
                Exit Sub
            End If

            Dim imageRatio As Single = .Image.Width / .Image.Height
            Dim panelArea As Size = SplitContainer1.Panel2.ClientSize

            Select Case panelArea.Width / panelArea.Height
                Case Is < imageRatio
                    .ClientSize = New Size(panelArea.Width, CInt(panelArea.Width / imageRatio)) '''''''''''''''''''''''''''''''''''
                Case Is > imageRatio
                    .ClientSize = New Size(CInt(panelArea.Height * imageRatio), panelArea.Height)
                Case Else
                    .ClientSize = panelArea
            End Select
        End With
    End Sub

    Private Sub SplitContainer1_Panel2_SizeChanged(sender As Object, e As EventArgs) Handles SplitContainer1.Panel2.SizeChanged

        With ViewFitMenuItem

            If .Checked Then
                .PerformClick()
            End If
        End With
    End Sub

    Private Function SearchFileList(ByVal imagePath As String) As Integer

        For Each fileItem As ListViewItem In FileListView.Items

            With fileItem

                If .SubItems(4).Text = imagePath Then ''''''''''''''''''''''''''''''''''''''
                    SearchFileList = .Index
                    Exit Function

                End If
            End With

        Next

        SearchFileList = -1
    End Function

    Private Sub ViewRegularMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRegularMenuItem.Click

        With SplitContainer1.Panel2

            .AutoScroll = False
            .AutoScroll = True

        End With

        With ViewPictureBox

            If .Image IsNot Nothing Then
                .ClientSize = .Image.Size
            End If
        End With
    End Sub

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            e.Effect = DragDropEffects.Copy

        End If
    End Sub

    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop

        Me.Activate()

        Dim listCount As Integer = FileListView.Items.Count

        ViewPictureBox.Hide()

        FileListView.BeginUpdate()

        For Each dropFileName As String _
                In CType(e.Data.GetData(DataFormats.FileDrop), String())

            If SearchFileList(dropFileName) < 0 AndAlso LoadImage(dropFileName) Then ''''''''''''''''''''''''''''''''''''''''''
                AddListItem(dropFileName)
            End If
        Next

        ViewPictureBox.Show()
        FileListView.EndUpdate()

        With FileListView
            If .Items.Count = listCount Then
                For Each dropFileName As String _
                        In CType(e.Data.GetData(DataFormats.FileDrop), String())

                    Dim itemIndex As Integer = SearchFileList(dropFileName)

                    If itemIndex >= 0 Then
                        .Items(itemIndex).Selected = True
                        .SelectedItems(0).Focused = True
                        Exit For
                    End If
                Next

                MessageBox.Show("ファイルリストに登録した追加ファイルはありません。",
                                AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            .Items(listCount).Selected = True
            .SelectedItems(0).Focused = True

            If .Items.Count > listCount + 1 Then
                MessageBox.Show((.Items.Count - listCount).ToString & "ファイルをファイルリストに登録しました。",
                                AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStrip1.Opening

        With FileListView

            If .Items.Count <= 1 Then
                e.Cancel = True
                Exit Sub
            End If

            ContextPrevMenuItem.Enabled = .SelectedIndices(0) > 0 '''''''''''''''''''''''''''''''''''''''''''''
            ContextNextMenuItem.Enabled = .SelectedIndices(0) < .Items.Count - 1

            .Focus()
        End With
    End Sub

    Private Sub FileMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles FileMenuItem.DropDownClosed

        FileDeleteMenuItem.Enabled = True
    End Sub

    Private Sub AddListItem(ByVal imagePath As String)

        Dim openFileInfo As FileInfo = New FileInfo(imagePath)
        Dim makingListItem As ListViewItem = New ListViewItem(openFileInfo.Name)

        FileListView.Items.Add(makingListItem)

        With makingListItem.SubItems

            .Add(openFileInfo.Length.ToString("N0"))
            .Add(ViewPictureBox.Image.Width.ToString & " x " & ViewPictureBox.Image.Height.ToString)
            .Add(openFileInfo.LastWriteTime.ToString)
            .Add(openFileInfo.FullName)

        End With
    End Sub

    Private Sub FileFolderMenuItem_Click(sender As Object, e As EventArgs) Handles FileFolderMenuItem.Click

        If FolderBrowserDialog1.ShowDialog = DialogResult.Cancel Then

            Exit Sub

        End If

        Dim folderGetFiles As ArrayList = New ArrayList

        With folderGetFiles

            Dim searchPatterns As String() =
                {"*.bmp", "*.jpg", "*.jpeg", "*.gif", "*.png", "*.tif", "*.tiff", "*.wmf"}

            .AddRange(My.Computer.FileSystem.GetFiles(FolderBrowserDialog1.SelectedPath,
                                                      FileIO.SearchOption.SearchTopLevelOnly, searchPatterns)) '''''''''''''''''''''''''''''''


            If .Count = 0 Then

                MessageBox.Show("フォルダ""" & FolderBrowserDialog1.SelectedPath &
                                """ には、画像ファイルがありません。",
                                AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Exit Sub

            End If

            .Sort()

        End With

        Dim listCount As Integer = FileListView.Items.Count

        ViewPictureBox.Hide()
        FileListView.BeginUpdate()

        For Each getFileName As String In folderGetFiles

            If SearchFileList(getFileName) < 0 AndAlso LoadImage(getFileName) Then
                AddListItem(getFileName)
            End If
        Next

        ViewPictureBox.Show()
        FileListView.EndUpdate()

        With FileListView

            If .Items.Count = listCount Then

                For Each getFileName As String In folderGetFiles

                    Dim itemIndex As Integer = SearchFileList(getFileName)

                    If itemIndex >= 0 Then
                        .Items(itemIndex).Selected = True
                        .SelectedItems(0).Focused = True
                        Exit For
                    End If
                Next

                MessageBox.Show("ファイルリストに登録した追加ファイルはありません。",
                                AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub

            End If

            .Items(listCount).Selected = True
            .SelectedItems(0).Focused = True

            MessageBox.Show _
                ("フォルダ""" & FolderBrowserDialog1.SelectedPath & """ から、" &
                (.Items.Count - listCount).ToString & "ファイルをファイルリストに登録しました。",
                                AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End With
    End Sub

    Private Sub FileDeleteMenuItem_Click(sender As Object, e As EventArgs) Handles FileDeleteMenuItem.Click

        With FileListView

            If .SelectedItems.Count = 0 Then
                Exit Sub
            End If

            Dim itemIndex As Integer = .SelectedIndices(0) '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            .SelectedItems(0).Remove()

            If itemIndex >= .Items.Count Then
                itemIndex -= 1
            End If

            If .Items.Count > 0 Then
                .Items(itemIndex).Selected = True
                .SelectedItems(0).Focused = True
                Exit Sub
            End If

        End With

        With ViewPictureBox

            .Image.Dispose()
            .Image = Nothing

            .Size = New Size(0, 0)
        End With

        Me.Text = AppliTitle

    End Sub
End Class
