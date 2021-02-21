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
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.ComLabel = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(16, 16)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(72, 28)
        Me.CopyButton.TabIndex = 0
        Me.CopyButton.Text = "コピー"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'ComLabel
        '
        Me.ComLabel.Image = CType(resources.GetObject("ComLabel.Image"), System.Drawing.Image)
        Me.ComLabel.Location = New System.Drawing.Point(112, 16)
        Me.ComLabel.Name = "ComLabel"
        Me.ComLabel.Size = New System.Drawing.Size(32, 32)
        Me.ComLabel.TabIndex = 1
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(16, 50)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 2
        Me.ResetButton.Text = "リセット"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(170, 169)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ComLabel)
        Me.Controls.Add(Me.CopyButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "マイコンピューター2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CopyButton As Button
    Friend WithEvents ComLabel As Label
    Friend WithEvents ResetButton As Button
End Class
