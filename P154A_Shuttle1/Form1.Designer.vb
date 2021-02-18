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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PlayMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayResetMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShuttleLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlayMenuItem
        '
        Me.PlayMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayResetMenuItem, Me.PlayExitMenuItem})
        Me.PlayMenuItem.Name = "PlayMenuItem"
        Me.PlayMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PlayMenuItem.Text = "プレイ(&P)"
        '
        'PlayResetMenuItem
        '
        Me.PlayResetMenuItem.Name = "PlayResetMenuItem"
        Me.PlayResetMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.PlayResetMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PlayResetMenuItem.Text = "リセット(&R) Ctl+R"
        '
        'PlayExitMenuItem
        '
        Me.PlayExitMenuItem.Name = "PlayExitMenuItem"
        Me.PlayExitMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PlayExitMenuItem.Text = "終了(&X)"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.ShuttleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 237)
        Me.Panel1.TabIndex = 1
        '
        'ShuttleLabel
        '
        Me.ShuttleLabel.BackColor = System.Drawing.Color.Transparent
        Me.ShuttleLabel.Image = CType(resources.GetObject("ShuttleLabel.Image"), System.Drawing.Image)
        Me.ShuttleLabel.Location = New System.Drawing.Point(0, 0)
        Me.ShuttleLabel.Name = "ShuttleLabel"
        Me.ShuttleLabel.Size = New System.Drawing.Size(64, 64)
        Me.ShuttleLabel.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "シャトル　１"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PlayMenuItem As ToolStripMenuItem
    Friend WithEvents PlayResetMenuItem As ToolStripMenuItem
    Friend WithEvents PlayExitMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShuttleLabel As Label
End Class
