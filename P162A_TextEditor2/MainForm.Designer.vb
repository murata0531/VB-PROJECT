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
        Me.FileExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHomeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEndMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewWrapMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFontMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFontSetupMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFontResetMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Meiryo UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ViewMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileNewMenuItem, Me.FileOpenMenuItem, Me.FileSaveMenuItem, Me.FileSaveAsMenuItem, Me.ToolStripSeparator1, Me.FileExitMenuItem})
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
        'FileExitMenuItem
        '
        Me.FileExitMenuItem.Name = "FileExitMenuItem"
        Me.FileExitMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.FileExitMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.FileExitMenuItem.Text = "終了(&X)"
        '
        'ViewMenuItem
        '
        Me.ViewMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHomeMenuItem, Me.ViewEndMenuItem, Me.ToolStripSeparator2, Me.ViewWrapMenuItem, Me.ViewFontMenuItem})
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
        Me.ViewFontMenuItem.Text = "フォント(%F)"
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
        'MainTextBox
        '
        Me.MainTextBox.AcceptsReturn = True
        Me.MainTextBox.AcceptsTab = True
        Me.MainTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTextBox.Location = New System.Drawing.Point(0, 24)
        Me.MainTextBox.MaxLength = 0
        Me.MainTextBox.Multiline = True
        Me.MainTextBox.Name = "MainTextBox"
        Me.MainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.MainTextBox.Size = New System.Drawing.Size(284, 237)
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MainTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(200, 150)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
End Class
