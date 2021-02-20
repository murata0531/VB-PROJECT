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
        Me.StartButton = New System.Windows.Forms.Button()
        Me.TrainLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(16, 16)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(72, 28)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "スタート"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'TrainLabel
        '
        Me.TrainLabel.Image = CType(resources.GetObject("TrainLabel.Image"), System.Drawing.Image)
        Me.TrainLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TrainLabel.Location = New System.Drawing.Point(110, 16)
        Me.TrainLabel.Name = "TrainLabel"
        Me.TrainLabel.Size = New System.Drawing.Size(40, 60)
        Me.TrainLabel.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(178, 127)
        Me.Controls.Add(Me.TrainLabel)
        Me.Controls.Add(Me.StartButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "電車レース　１"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents TrainLabel As Label
    Friend WithEvents Timer1 As Timer
End Class
