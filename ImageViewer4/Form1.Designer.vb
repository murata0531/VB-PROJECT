<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileOpenMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileFolderMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileDeleteMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileClearMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPrevMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewNextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRegularSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewRegularMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSmallMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLargeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowLeftMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowHideMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FileListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextPrevMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextNextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPictureBox = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ViewPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Meiryo UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenuItem, Me.ViewMenuItem, Me.WindowMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "ファイル(&F)"
        '
        'FileMenuItem
        '
        Me.FileMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileOpenMenuItem, Me.FileFolderMenuItem, Me.ToolStripSeparator1, Me.FileDeleteMenuItem, Me.FileClearMenuItem1, Me.ToolStripSeparator2, Me.FileExitMenuItem})
        Me.FileMenuItem.Name = "FileMenuItem"
        Me.FileMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.FileMenuItem.Text = "ファイル(&F)"
        '
        'FileOpenMenuItem
        '
        Me.FileOpenMenuItem.Image = CType(resources.GetObject("FileOpenMenuItem.Image"), System.Drawing.Image)
        Me.FileOpenMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileOpenMenuItem.Name = "FileOpenMenuItem"
        Me.FileOpenMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.FileOpenMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.FileOpenMenuItem.Text = "ファイルを開く&O)"
        '
        'FileFolderMenuItem
        '
        Me.FileFolderMenuItem.Image = CType(resources.GetObject("FileFolderMenuItem.Image"), System.Drawing.Image)
        Me.FileFolderMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileFolderMenuItem.Name = "FileFolderMenuItem"
        Me.FileFolderMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileFolderMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.FileFolderMenuItem.Text = "フォルダの参照(&F)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(216, 6)
        '
        'FileDeleteMenuItem
        '
        Me.FileDeleteMenuItem.Image = CType(resources.GetObject("FileDeleteMenuItem.Image"), System.Drawing.Image)
        Me.FileDeleteMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileDeleteMenuItem.Name = "FileDeleteMenuItem"
        Me.FileDeleteMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.FileDeleteMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.FileDeleteMenuItem.Text = "ファイルリストから削除(&D)"
        '
        'FileClearMenuItem1
        '
        Me.FileClearMenuItem1.Name = "FileClearMenuItem1"
        Me.FileClearMenuItem1.Size = New System.Drawing.Size(219, 22)
        Me.FileClearMenuItem1.Text = "ファイルリストのクリア(&C)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(216, 6)
        '
        'FileExitMenuItem
        '
        Me.FileExitMenuItem.Name = "FileExitMenuItem"
        Me.FileExitMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.FileExitMenuItem.Text = "終了(&X)"
        '
        'ViewMenuItem
        '
        Me.ViewMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPrevMenuItem1, Me.ViewNextMenuItem, Me.ViewRegularSeparator2, Me.ViewRegularMenuItem, Me.ViewSmallMenuItem, Me.ViewLargeMenuItem, Me.ViewFitMenuItem})
        Me.ViewMenuItem.Name = "ViewMenuItem"
        Me.ViewMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ViewMenuItem.Text = "表示(&V)"
        '
        'ViewPrevMenuItem1
        '
        Me.ViewPrevMenuItem1.Image = CType(resources.GetObject("ViewPrevMenuItem1.Image"), System.Drawing.Image)
        Me.ViewPrevMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewPrevMenuItem1.Name = "ViewPrevMenuItem1"
        Me.ViewPrevMenuItem1.ShortcutKeyDisplayString = "Ctrl+↑"
        Me.ViewPrevMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.ViewPrevMenuItem1.Size = New System.Drawing.Size(228, 22)
        Me.ViewPrevMenuItem1.Text = "前のファイル(&P)"
        '
        'ViewNextMenuItem
        '
        Me.ViewNextMenuItem.Image = CType(resources.GetObject("ViewNextMenuItem.Image"), System.Drawing.Image)
        Me.ViewNextMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewNextMenuItem.Name = "ViewNextMenuItem"
        Me.ViewNextMenuItem.ShortcutKeyDisplayString = "Ctrl+↓"
        Me.ViewNextMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.ViewNextMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.ViewNextMenuItem.Text = "次のファイル(&N)"
        '
        'ViewRegularSeparator2
        '
        Me.ViewRegularSeparator2.Name = "ViewRegularSeparator2"
        Me.ViewRegularSeparator2.Size = New System.Drawing.Size(225, 6)
        '
        'ViewRegularMenuItem
        '
        Me.ViewRegularMenuItem.Name = "ViewRegularMenuItem"
        Me.ViewRegularMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ViewRegularMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.ViewRegularMenuItem.Text = "等倍表示(&R)"
        '
        'ViewSmallMenuItem
        '
        Me.ViewSmallMenuItem.Name = "ViewSmallMenuItem"
        Me.ViewSmallMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.ViewSmallMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.ViewSmallMenuItem.Text = "縮小表示 1/2x(&S)"
        '
        'ViewLargeMenuItem
        '
        Me.ViewLargeMenuItem.Name = "ViewLargeMenuItem"
        Me.ViewLargeMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.ViewLargeMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.ViewLargeMenuItem.Text = "拡大表示 2x(&L)"
        '
        'ViewFitMenuItem
        '
        Me.ViewFitMenuItem.Name = "ViewFitMenuItem"
        Me.ViewFitMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.ViewFitMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.ViewFitMenuItem.Text = "ウィンドウに合わせて表示(&F)"
        '
        'WindowMenuItem
        '
        Me.WindowMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowTopMenuItem, Me.WindowLeftMenuItem, Me.WindowHideMenuItem})
        Me.WindowMenuItem.Name = "WindowMenuItem"
        Me.WindowMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.WindowMenuItem.Text = "ウィンドウ(&W)"
        '
        'WindowTopMenuItem
        '
        Me.WindowTopMenuItem.Checked = True
        Me.WindowTopMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WindowTopMenuItem.Image = CType(resources.GetObject("WindowTopMenuItem.Image"), System.Drawing.Image)
        Me.WindowTopMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.WindowTopMenuItem.Name = "WindowTopMenuItem"
        Me.WindowTopMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.WindowTopMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.WindowTopMenuItem.Text = "上下表示(&T)"
        '
        'WindowLeftMenuItem
        '
        Me.WindowLeftMenuItem.Image = CType(resources.GetObject("WindowLeftMenuItem.Image"), System.Drawing.Image)
        Me.WindowLeftMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.WindowLeftMenuItem.Name = "WindowLeftMenuItem"
        Me.WindowLeftMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.WindowLeftMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.WindowLeftMenuItem.Text = "左右表示(&L)"
        '
        'WindowHideMenuItem
        '
        Me.WindowHideMenuItem.Image = CType(resources.GetObject("WindowHideMenuItem.Image"), System.Drawing.Image)
        Me.WindowHideMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.WindowHideMenuItem.Name = "WindowHideMenuItem"
        Me.WindowHideMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.WindowHideMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.WindowHideMenuItem.Text = "リスト非表示(&H)"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FileListView)
        Me.SplitContainer1.Panel1MinSize = 66
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.SplitContainer1.Panel2.Controls.Add(Me.ViewPictureBox)
        Me.SplitContainer1.Panel2MinSize = 80
        Me.SplitContainer1.Size = New System.Drawing.Size(384, 237)
        Me.SplitContainer1.SplitterDistance = 128
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 1
        '
        'FileListView
        '
        Me.FileListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FileListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.FileListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FileListView.FullRowSelect = True
        Me.FileListView.HideSelection = False
        Me.FileListView.Location = New System.Drawing.Point(0, 0)
        Me.FileListView.MultiSelect = False
        Me.FileListView.Name = "FileListView"
        Me.FileListView.Size = New System.Drawing.Size(382, 126)
        Me.FileListView.TabIndex = 0
        Me.FileListView.UseCompatibleStateImageBehavior = False
        Me.FileListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ファイル名"
        Me.ColumnHeader1.Width = 160
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "サイズ"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "イメージサイズ"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 95
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "更新日時"
        Me.ColumnHeader4.Width = 135
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "フルパス名"
        Me.ColumnHeader5.Width = 455
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextPrevMenuItem, Me.ContextNextMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(131, 48)
        '
        'ContextPrevMenuItem
        '
        Me.ContextPrevMenuItem.Image = CType(resources.GetObject("ContextPrevMenuItem.Image"), System.Drawing.Image)
        Me.ContextPrevMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ContextPrevMenuItem.Name = "ContextPrevMenuItem"
        Me.ContextPrevMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ContextPrevMenuItem.Text = "前のファイル"
        '
        'ContextNextMenuItem
        '
        Me.ContextNextMenuItem.Image = CType(resources.GetObject("ContextNextMenuItem.Image"), System.Drawing.Image)
        Me.ContextNextMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ContextNextMenuItem.Name = "ContextNextMenuItem"
        Me.ContextNextMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ContextNextMenuItem.Text = "次のファイル"
        '
        'ViewPictureBox
        '
        Me.ViewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ViewPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.ViewPictureBox.Name = "ViewPictureBox"
        Me.ViewPictureBox.Size = New System.Drawing.Size(382, 105)
        Me.ViewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ViewPictureBox.TabIndex = 1
        Me.ViewPictureBox.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.AutoUpgradeEnabled = False
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ViewPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileMenuItem As ToolStripMenuItem
    Friend WithEvents FileOpenMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FileExitMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ViewPictureBox As PictureBox
    Friend WithEvents FileListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ViewMenuItem As ToolStripMenuItem
    Friend WithEvents ViewPrevMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewNextMenuItem As ToolStripMenuItem
    Friend WithEvents WindowMenuItem As ToolStripMenuItem
    Friend WithEvents WindowTopMenuItem As ToolStripMenuItem
    Friend WithEvents WindowLeftMenuItem As ToolStripMenuItem
    Friend WithEvents WindowHideMenuItem As ToolStripMenuItem
    Friend WithEvents FileClearMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewRegularSeparator2 As ToolStripSeparator
    Friend WithEvents ViewRegularMenuItem As ToolStripMenuItem
    Friend WithEvents ViewSmallMenuItem As ToolStripMenuItem
    Friend WithEvents ViewLargeMenuItem As ToolStripMenuItem
    Friend WithEvents ViewFitMenuItem As ToolStripMenuItem
    Friend WithEvents FileFolderMenuItem As ToolStripMenuItem
    Friend WithEvents FileDeleteMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextPrevMenuItem As ToolStripMenuItem
    Friend WithEvents ContextNextMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
