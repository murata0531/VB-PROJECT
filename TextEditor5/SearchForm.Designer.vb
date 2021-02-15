<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
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
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.FindLabel = New System.Windows.Forms.Label()
        Me.UpwardButton = New System.Windows.Forms.Button()
        Me.DownWardButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FindTextBox
        '
        Me.FindTextBox.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.5!)
        Me.FindTextBox.Location = New System.Drawing.Point(12, 70)
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(386, 21)
        Me.FindTextBox.TabIndex = 1
        '
        'FindLabel
        '
        Me.FindLabel.AutoSize = True
        Me.FindLabel.Location = New System.Drawing.Point(22, 36)
        Me.FindLabel.Name = "FindLabel"
        Me.FindLabel.Size = New System.Drawing.Size(110, 12)
        Me.FindLabel.TabIndex = 0
        Me.FindLabel.Text = "検索する文字列(&N) : "
        '
        'UpwardButton
        '
        Me.UpwardButton.Location = New System.Drawing.Point(129, 118)
        Me.UpwardButton.Name = "UpwardButton"
        Me.UpwardButton.Size = New System.Drawing.Size(75, 23)
        Me.UpwardButton.TabIndex = 2
        Me.UpwardButton.Text = "上へ検索(&U)"
        Me.UpwardButton.UseVisualStyleBackColor = True
        '
        'DownWardButton
        '
        Me.DownWardButton.Location = New System.Drawing.Point(222, 118)
        Me.DownWardButton.Name = "DownWardButton"
        Me.DownWardButton.Size = New System.Drawing.Size(75, 23)
        Me.DownWardButton.TabIndex = 3
        Me.DownWardButton.Text = "下へ検索(&D)"
        Me.DownWardButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(323, 118)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "閉じる"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SearchForm
        '
        Me.AcceptButton = Me.DownWardButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(436, 188)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.DownWardButton)
        Me.Controls.Add(Me.UpwardButton)
        Me.Controls.Add(Me.FindLabel)
        Me.Controls.Add(Me.FindTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SearchForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FindTextBox As TextBox
    Friend WithEvents FindLabel As Label
    Friend WithEvents UpwardButton As Button
    Friend WithEvents DownWardButton As Button
    Friend WithEvents CloseButton As Button
End Class
