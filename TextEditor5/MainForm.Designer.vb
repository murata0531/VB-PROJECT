<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileNewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileOpenMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileSaveMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileSaveAsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FilePageSetupMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilePrintPreviewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilePrintMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUndoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditCutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCopyMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPasteMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditDeleteMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSelectAllMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditFindMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHomeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEndMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewWrapMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFontMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFontSetupMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFontResetMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewToolbarMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolbarStyleMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FileNewButton = New System.Windows.Forms.ToolStripButton()
        Me.FileOpenButton = New System.Windows.Forms.ToolStripButton()
        Me.FileSaveButton = New System.Windows.Forms.ToolStripButton()
        Me.FilePrintButton = New System.Windows.Forms.ToolStripButton()
        Me.FilePrintPreviewButton = New System.Windows.Forms.ToolStripButton()
        Me.EditCutButton = New System.Windows.Forms.ToolStripButton()
        Me.EditCopyButton = New System.Windows.Forms.ToolStripButton()
        Me.EditPasteButton = New System.Windows.Forms.ToolStripButton()
        Me.EditUndoButton = New System.Windows.Forms.ToolStripButton()
        Me.EditDeleteButton = New System.Windows.Forms.ToolStripButton()
        Me.EditFindButton = New System.Windows.Forms.ToolStripButton()
        Me.ViewHomeButton = New System.Windows.Forms.ToolStripButton()
        Me.ViewEndButton = New System.Windows.Forms.ToolStripButton()
        Me.ViewWrapButton = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Meiryo UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EditMenuItem, Me.ViewMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(364, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileNewMenuItem, Me.FileOpenMenuItem, Me.FileSaveMenuItem, Me.FileSaveAsMenuItem, Me.ToolStripSeparator1, Me.FilePageSetupMenuItem, Me.FilePrintPreviewMenuItem, Me.FilePrintMenuItem, Me.ToolStripSeparator6, Me.FileExitMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(70, 20)
        Me.ToolStripMenuItem1.Text = "ファイル(&F)"
        '
        'FileNewMenuItem
        '
        Me.FileNewMenuItem.Image = CType(resources.GetObject("FileNewMenuItem.Image"), System.Drawing.Image)
        Me.FileNewMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileNewMenuItem.Name = "FileNewMenuItem"
        Me.FileNewMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.FileNewMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.FileNewMenuItem.Text = "新規作成(&N)"
        '
        'FileOpenMenuItem
        '
        Me.FileOpenMenuItem.Image = CType(resources.GetObject("FileOpenMenuItem.Image"), System.Drawing.Image)
        Me.FileOpenMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileOpenMenuItem.Name = "FileOpenMenuItem"
        Me.FileOpenMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.FileOpenMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.FileOpenMenuItem.Text = "開く(&O)"
        '
        'FileSaveMenuItem
        '
        Me.FileSaveMenuItem.Image = CType(resources.GetObject("FileSaveMenuItem.Image"), System.Drawing.Image)
        Me.FileSaveMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileSaveMenuItem.Name = "FileSaveMenuItem"
        Me.FileSaveMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.FileSaveMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.FileSaveMenuItem.Text = "上書き保存(&S)"
        '
        'FileSaveAsMenuItem
        '
        Me.FileSaveAsMenuItem.Name = "FileSaveAsMenuItem"
        Me.FileSaveAsMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.FileSaveAsMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.FileSaveAsMenuItem.Text = "名前を付けて保存(&A)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(223, 6)
        '
        'FilePageSetupMenuItem
        '
        Me.FilePageSetupMenuItem.Image = CType(resources.GetObject("FilePageSetupMenuItem.Image"), System.Drawing.Image)
        Me.FilePageSetupMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FilePageSetupMenuItem.Name = "FilePageSetupMenuItem"
        Me.FilePageSetupMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.FilePageSetupMenuItem.Text = "ページ設定(&U)"
        '
        'FilePrintPreviewMenuItem
        '
        Me.FilePrintPreviewMenuItem.Image = CType(resources.GetObject("FilePrintPreviewMenuItem.Image"), System.Drawing.Image)
        Me.FilePrintPreviewMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FilePrintPreviewMenuItem.Name = "FilePrintPreviewMenuItem"
        Me.FilePrintPreviewMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.FilePrintPreviewMenuItem.Text = "印刷プレビュー(&V)"
        '
        'FilePrintMenuItem
        '
        Me.FilePrintMenuItem.Image = CType(resources.GetObject("FilePrintMenuItem.Image"), System.Drawing.Image)
        Me.FilePrintMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FilePrintMenuItem.Name = "FilePrintMenuItem"
        Me.FilePrintMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.FilePrintMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.FilePrintMenuItem.Text = "印刷(&P)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(223, 6)
        '
        'FileExitMenuItem
        '
        Me.FileExitMenuItem.Name = "FileExitMenuItem"
        Me.FileExitMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.FileExitMenuItem.Text = "終了(&X)"
        '
        'EditMenuItem
        '
        Me.EditMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditUndoMenuItem, Me.ToolStripSeparator3, Me.EditCutMenuItem, Me.EditCopyMenuItem, Me.EditPasteMenuItem, Me.ToolStripSeparator4, Me.EditDeleteMenuItem, Me.EditSelectAllMenuItem, Me.ToolStripSeparator5, Me.EditFindMenuItem})
        Me.EditMenuItem.Name = "EditMenuItem"
        Me.EditMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.EditMenuItem.Text = "編集(&E)"
        '
        'EditUndoMenuItem
        '
        Me.EditUndoMenuItem.Image = CType(resources.GetObject("EditUndoMenuItem.Image"), System.Drawing.Image)
        Me.EditUndoMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditUndoMenuItem.Name = "EditUndoMenuItem"
        Me.EditUndoMenuItem.ShortcutKeyDisplayString = "Ctrl+Z"
        Me.EditUndoMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EditUndoMenuItem.Text = "元に戻す(&U)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(188, 6)
        '
        'EditCutMenuItem
        '
        Me.EditCutMenuItem.Image = CType(resources.GetObject("EditCutMenuItem.Image"), System.Drawing.Image)
        Me.EditCutMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditCutMenuItem.Name = "EditCutMenuItem"
        Me.EditCutMenuItem.ShortcutKeyDisplayString = "Ctrl+X"
        Me.EditCutMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EditCutMenuItem.Text = "切り取り(&T)"
        '
        'EditCopyMenuItem
        '
        Me.EditCopyMenuItem.Image = CType(resources.GetObject("EditCopyMenuItem.Image"), System.Drawing.Image)
        Me.EditCopyMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditCopyMenuItem.Name = "EditCopyMenuItem"
        Me.EditCopyMenuItem.ShortcutKeyDisplayString = "Ctrl+C"
        Me.EditCopyMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EditCopyMenuItem.Text = "コピー(&C)"
        '
        'EditPasteMenuItem
        '
        Me.EditPasteMenuItem.Image = CType(resources.GetObject("EditPasteMenuItem.Image"), System.Drawing.Image)
        Me.EditPasteMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditPasteMenuItem.Name = "EditPasteMenuItem"
        Me.EditPasteMenuItem.ShortcutKeyDisplayString = "Ctrl+V"
        Me.EditPasteMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EditPasteMenuItem.Text = "貼り付け(&P)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(188, 6)
        '
        'EditDeleteMenuItem
        '
        Me.EditDeleteMenuItem.Image = CType(resources.GetObject("EditDeleteMenuItem.Image"), System.Drawing.Image)
        Me.EditDeleteMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditDeleteMenuItem.Name = "EditDeleteMenuItem"
        Me.EditDeleteMenuItem.ShortcutKeyDisplayString = "Ctrl+Del"
        Me.EditDeleteMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EditDeleteMenuItem.Text = "削除(&D)"
        '
        'EditSelectAllMenuItem
        '
        Me.EditSelectAllMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditSelectAllMenuItem.Name = "EditSelectAllMenuItem"
        Me.EditSelectAllMenuItem.ShortcutKeyDisplayString = "Ctrl+A"
        Me.EditSelectAllMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.EditSelectAllMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EditSelectAllMenuItem.Text = "すべて選択(&A)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(188, 6)
        '
        'EditFindMenuItem
        '
        Me.EditFindMenuItem.Image = CType(resources.GetObject("EditFindMenuItem.Image"), System.Drawing.Image)
        Me.EditFindMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditFindMenuItem.Name = "EditFindMenuItem"
        Me.EditFindMenuItem.ShortcutKeyDisplayString = "Ctrl+F"
        Me.EditFindMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.EditFindMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EditFindMenuItem.Text = "検索(&F)"
        '
        'ViewMenuItem
        '
        Me.ViewMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHomeMenuItem, Me.ViewEndMenuItem, Me.ToolStripSeparator2, Me.ViewWrapMenuItem, Me.ViewFontMenuItem, Me.ToolStripSeparator7, Me.ViewToolbarMenuItem, Me.ViewToolbarStyleMenuItem})
        Me.ViewMenuItem.Name = "ViewMenuItem"
        Me.ViewMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ViewMenuItem.Text = "表示(&V)"
        '
        'ViewHomeMenuItem
        '
        Me.ViewHomeMenuItem.Image = CType(resources.GetObject("ViewHomeMenuItem.Image"), System.Drawing.Image)
        Me.ViewHomeMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewHomeMenuItem.Name = "ViewHomeMenuItem"
        Me.ViewHomeMenuItem.ShortcutKeyDisplayString = "Ctrl+Home"
        Me.ViewHomeMenuItem.Size = New System.Drawing.Size(309, 22)
        Me.ViewHomeMenuItem.Text = "ドキュメントの開始位置へ移動(&H)"
        '
        'ViewEndMenuItem
        '
        Me.ViewEndMenuItem.Image = CType(resources.GetObject("ViewEndMenuItem.Image"), System.Drawing.Image)
        Me.ViewEndMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewEndMenuItem.Name = "ViewEndMenuItem"
        Me.ViewEndMenuItem.ShortcutKeyDisplayString = "Ctrl+End"
        Me.ViewEndMenuItem.Size = New System.Drawing.Size(309, 22)
        Me.ViewEndMenuItem.Text = "ドキュメントの終了位置へ移動(&E)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(306, 6)
        '
        'ViewWrapMenuItem
        '
        Me.ViewWrapMenuItem.CheckOnClick = True
        Me.ViewWrapMenuItem.Image = CType(resources.GetObject("ViewWrapMenuItem.Image"), System.Drawing.Image)
        Me.ViewWrapMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewWrapMenuItem.Name = "ViewWrapMenuItem"
        Me.ViewWrapMenuItem.Size = New System.Drawing.Size(309, 22)
        Me.ViewWrapMenuItem.Text = "右端で折り返し(&W)"
        '
        'ViewFontMenuItem
        '
        Me.ViewFontMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewFontSetupMenuItem, Me.ViewFontResetMenuItem})
        Me.ViewFontMenuItem.Image = CType(resources.GetObject("ViewFontMenuItem.Image"), System.Drawing.Image)
        Me.ViewFontMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewFontMenuItem.Name = "ViewFontMenuItem"
        Me.ViewFontMenuItem.Size = New System.Drawing.Size(309, 22)
        Me.ViewFontMenuItem.Text = "フォント(&F)"
        '
        'ViewFontSetupMenuItem
        '
        Me.ViewFontSetupMenuItem.Image = CType(resources.GetObject("ViewFontSetupMenuItem.Image"), System.Drawing.Image)
        Me.ViewFontSetupMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewFontSetupMenuItem.Name = "ViewFontSetupMenuItem"
        Me.ViewFontSetupMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ViewFontSetupMenuItem.Text = "設定(&S)..."
        '
        'ViewFontResetMenuItem
        '
        Me.ViewFontResetMenuItem.Name = "ViewFontResetMenuItem"
        Me.ViewFontResetMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ViewFontResetMenuItem.Text = "リセット(&R)"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(306, 6)
        '
        'ViewToolbarMenuItem
        '
        Me.ViewToolbarMenuItem.AutoToolTip = True
        Me.ViewToolbarMenuItem.CheckOnClick = True
        Me.ViewToolbarMenuItem.Image = CType(resources.GetObject("ViewToolbarMenuItem.Image"), System.Drawing.Image)
        Me.ViewToolbarMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewToolbarMenuItem.Name = "ViewToolbarMenuItem"
        Me.ViewToolbarMenuItem.Size = New System.Drawing.Size(309, 22)
        Me.ViewToolbarMenuItem.Text = "ツールバー(&T)"
        '
        'ViewToolbarStyleMenuItem
        '
        Me.ViewToolbarStyleMenuItem.CheckOnClick = True
        Me.ViewToolbarStyleMenuItem.Image = CType(resources.GetObject("ViewToolbarStyleMenuItem.Image"), System.Drawing.Image)
        Me.ViewToolbarStyleMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewToolbarStyleMenuItem.Name = "ViewToolbarStyleMenuItem"
        Me.ViewToolbarStyleMenuItem.Size = New System.Drawing.Size(309, 22)
        Me.ViewToolbarStyleMenuItem.Text = "ツールバーのボタン名(&B)"
        '
        'MainTextBox
        '
        Me.MainTextBox.AcceptsReturn = True
        Me.MainTextBox.AcceptsTab = True
        Me.MainTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTextBox.HideSelection = False
        Me.MainTextBox.Location = New System.Drawing.Point(0, 0)
        Me.MainTextBox.MaxLength = 0
        Me.MainTextBox.Multiline = True
        Me.MainTextBox.Name = "MainTextBox"
        Me.MainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.MainTextBox.Size = New System.Drawing.Size(364, 207)
        Me.MainTextBox.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.AutoUpgradeEnabled = False
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.ShowReadOnly = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.AutoUpgradeEnabled = False
        '
        'FontDialog1
        '
        Me.FontDialog1.AllowVerticalFonts = False
        Me.FontDialog1.FontMustExist = True
        Me.FontDialog1.ShowEffects = False
        '
        'PrintDocument1
        '
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        Me.PageSetupDialog1.EnableMetric = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.MainTextBox)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(364, 207)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(364, 232)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Meiryo UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileNewButton, Me.FileOpenButton, Me.FileSaveButton, Me.FilePrintButton, Me.FilePrintPreviewButton, Me.EditCutButton, Me.EditCopyButton, Me.EditPasteButton, Me.EditUndoButton, Me.EditDeleteButton, Me.EditFindButton, Me.ViewHomeButton, Me.ViewEndButton, Me.ViewWrapButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(334, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'FileNewButton
        '
        Me.FileNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FileNewButton.Image = CType(resources.GetObject("FileNewButton.Image"), System.Drawing.Image)
        Me.FileNewButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileNewButton.Name = "FileNewButton"
        Me.FileNewButton.Size = New System.Drawing.Size(23, 22)
        Me.FileNewButton.Text = "新規作成"
        '
        'FileOpenButton
        '
        Me.FileOpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FileOpenButton.Image = CType(resources.GetObject("FileOpenButton.Image"), System.Drawing.Image)
        Me.FileOpenButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileOpenButton.Name = "FileOpenButton"
        Me.FileOpenButton.Size = New System.Drawing.Size(23, 22)
        Me.FileOpenButton.Text = "開く"
        '
        'FileSaveButton
        '
        Me.FileSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FileSaveButton.Image = CType(resources.GetObject("FileSaveButton.Image"), System.Drawing.Image)
        Me.FileSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileSaveButton.Name = "FileSaveButton"
        Me.FileSaveButton.Size = New System.Drawing.Size(23, 22)
        Me.FileSaveButton.Text = "上書き保存"
        '
        'FilePrintButton
        '
        Me.FilePrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FilePrintButton.Image = CType(resources.GetObject("FilePrintButton.Image"), System.Drawing.Image)
        Me.FilePrintButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FilePrintButton.Name = "FilePrintButton"
        Me.FilePrintButton.Size = New System.Drawing.Size(23, 22)
        Me.FilePrintButton.Text = "印刷"
        '
        'FilePrintPreviewButton
        '
        Me.FilePrintPreviewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FilePrintPreviewButton.Image = CType(resources.GetObject("FilePrintPreviewButton.Image"), System.Drawing.Image)
        Me.FilePrintPreviewButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FilePrintPreviewButton.Name = "FilePrintPreviewButton"
        Me.FilePrintPreviewButton.Size = New System.Drawing.Size(23, 22)
        Me.FilePrintPreviewButton.Text = "印刷プレビュー"
        '
        'EditCutButton
        '
        Me.EditCutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditCutButton.Image = CType(resources.GetObject("EditCutButton.Image"), System.Drawing.Image)
        Me.EditCutButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditCutButton.Name = "EditCutButton"
        Me.EditCutButton.Size = New System.Drawing.Size(23, 22)
        Me.EditCutButton.ToolTipText = "切り取り"
        '
        'EditCopyButton
        '
        Me.EditCopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditCopyButton.Image = CType(resources.GetObject("EditCopyButton.Image"), System.Drawing.Image)
        Me.EditCopyButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditCopyButton.Name = "EditCopyButton"
        Me.EditCopyButton.Size = New System.Drawing.Size(23, 22)
        Me.EditCopyButton.ToolTipText = "コピー"
        '
        'EditPasteButton
        '
        Me.EditPasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditPasteButton.Image = CType(resources.GetObject("EditPasteButton.Image"), System.Drawing.Image)
        Me.EditPasteButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditPasteButton.Name = "EditPasteButton"
        Me.EditPasteButton.Size = New System.Drawing.Size(23, 22)
        Me.EditPasteButton.ToolTipText = "貼り付け"
        '
        'EditUndoButton
        '
        Me.EditUndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditUndoButton.Image = CType(resources.GetObject("EditUndoButton.Image"), System.Drawing.Image)
        Me.EditUndoButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditUndoButton.Name = "EditUndoButton"
        Me.EditUndoButton.Size = New System.Drawing.Size(23, 22)
        Me.EditUndoButton.ToolTipText = "元に戻す"
        '
        'EditDeleteButton
        '
        Me.EditDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditDeleteButton.Image = CType(resources.GetObject("EditDeleteButton.Image"), System.Drawing.Image)
        Me.EditDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditDeleteButton.Name = "EditDeleteButton"
        Me.EditDeleteButton.Size = New System.Drawing.Size(23, 22)
        Me.EditDeleteButton.ToolTipText = "削除"
        '
        'EditFindButton
        '
        Me.EditFindButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditFindButton.Image = CType(resources.GetObject("EditFindButton.Image"), System.Drawing.Image)
        Me.EditFindButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditFindButton.Name = "EditFindButton"
        Me.EditFindButton.Size = New System.Drawing.Size(23, 22)
        Me.EditFindButton.ToolTipText = "検索"
        '
        'ViewHomeButton
        '
        Me.ViewHomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ViewHomeButton.Image = CType(resources.GetObject("ViewHomeButton.Image"), System.Drawing.Image)
        Me.ViewHomeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewHomeButton.Name = "ViewHomeButton"
        Me.ViewHomeButton.Size = New System.Drawing.Size(23, 22)
        Me.ViewHomeButton.ToolTipText = "ドキュメントの開始位置に移動"
        '
        'ViewEndButton
        '
        Me.ViewEndButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ViewEndButton.Image = CType(resources.GetObject("ViewEndButton.Image"), System.Drawing.Image)
        Me.ViewEndButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewEndButton.Name = "ViewEndButton"
        Me.ViewEndButton.Size = New System.Drawing.Size(23, 22)
        Me.ViewEndButton.ToolTipText = "ドキュメントの終了位置に移動"
        '
        'ViewWrapButton
        '
        Me.ViewWrapButton.CheckOnClick = True
        Me.ViewWrapButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ViewWrapButton.Image = CType(resources.GetObject("ViewWrapButton.Image"), System.Drawing.Image)
        Me.ViewWrapButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewWrapButton.Name = "ViewWrapButton"
        Me.ViewWrapButton.Size = New System.Drawing.Size(23, 22)
        Me.ViewWrapButton.ToolTipText = "右端で折り返し"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 256)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(200, 150)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FileNewMenuItem As ToolStripMenuItem
    Friend WithEvents FileOpenMenuItem As ToolStripMenuItem
    Friend WithEvents FileSaveMenuItem As ToolStripMenuItem
    Friend WithEvents MainTextBox As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FileSaveAsMenuItem As ToolStripMenuItem
    Friend WithEvents FileExitMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ViewMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHomeMenuItem As ToolStripMenuItem
    Friend WithEvents ViewEndMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ViewWrapMenuItem As ToolStripMenuItem
    Friend WithEvents ViewFontMenuItem As ToolStripMenuItem
    Friend WithEvents ViewFontSetupMenuItem As ToolStripMenuItem
    Friend WithEvents ViewFontResetMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents EditMenuItem As ToolStripMenuItem
    Friend WithEvents EditUndoMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents EditCutMenuItem As ToolStripMenuItem
    Friend WithEvents EditCopyMenuItem As ToolStripMenuItem
    Friend WithEvents EditPasteMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents EditDeleteMenuItem As ToolStripMenuItem
    Friend WithEvents EditSelectAllMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents EditFindMenuItem As ToolStripMenuItem
    Friend WithEvents FilePageSetupMenuItem As ToolStripMenuItem
    Friend WithEvents FilePrintPreviewMenuItem As ToolStripMenuItem
    Friend WithEvents FilePrintMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ViewToolbarMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolbarStyleMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents FileNewButton As ToolStripButton
    Friend WithEvents FileOpenButton As ToolStripButton
    Friend WithEvents FileSaveButton As ToolStripButton
    Friend WithEvents FilePrintButton As ToolStripButton
    Friend WithEvents FilePrintPreviewButton As ToolStripButton
    Friend WithEvents EditCutButton As ToolStripButton
    Friend WithEvents EditCopyButton As ToolStripButton
    Friend WithEvents EditPasteButton As ToolStripButton
    Friend WithEvents EditUndoButton As ToolStripButton
    Friend WithEvents EditDeleteButton As ToolStripButton
    Friend WithEvents EditFindButton As ToolStripButton
    Friend WithEvents ViewHomeButton As ToolStripButton
    Friend WithEvents ViewEndButton As ToolStripButton
    Friend WithEvents ViewWrapButton As ToolStripButton
End Class
