
Public Class Form1

    Dim ResetPoint As Point
    Dim DownPoint As Point
    Function ChangeIndex() As Integer

        Static n As Integer
        If n >= 0 And n <= 4 Then
            n += 1

        Else
            n = 0
        End If

        If n = 0 Or n = 1 Then
            Return 0

        ElseIf n = 2 Or n = 3 Then
            Return 1
        ElseIf n = 4 Or n = 5 Then
            Return 2
        End If

    End Function
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        With ShuttleLabel
            Select Case e.KeyCode
                Case Keys.Left
                    .Location = New Point(.Location.X - 5, .Location.Y)
                Case Keys.Right
                    .Location = New Point(.Location.X + 5, .Location.Y)
                Case Keys.Up
                    .Location = New Point(.Location.X, .Location.Y - 5)
                Case Keys.Down
                    .Location = New Point(.Location.X, .Location.Y + 5)
                Case Keys.Execute
                    If .Location.Equals(ResetPoint) = False Then
                        PlayResetMenuItem.PerformClick()

                    End If
                    Exit Sub

                Case Else
                    Exit Sub
            End Select

            Select Case e.KeyData
                Case (Keys.Shift Or Keys.Left)
                    ShuttleLabel.Location = New Point(.Location.X - 5, .Location.Y)
                Case (Keys.Shift Or Keys.Right)
                    ShuttleLabel.Location = New Point(.Location.X + 5, .Location.Y)
                Case (Keys.Shift Or Keys.Up)
                    ShuttleLabel.Location = New Point(.Location.X, .Location.Y - 5)
                Case (Keys.Shift Or Keys.Down)
                    ShuttleLabel.Location = New Point(.Location.X, .Location.Y + 5)
            End Select
        End With
        ShuttleLabel.ImageIndex = ChangeIndex()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.ClientSize = New Size(400, 400 + MenuStrip1.Size.Height)

        With ShuttleLabel
            .Location = New Point((Panel1.ClientSize.Width - .Size.Width) \ 2,
                                  (Panel1.Width - ShuttleLabel.Height) \ 2)
            ResetPoint = ShuttleLabel.Location
        End With
    End Sub

    Private Sub PlayExitMenuItem_Click(sender As Object, e As EventArgs) Handles PlayExitMenuItem.Click

        Me.Close()
    End Sub

    Private Sub PlayResetMenuItem_Click(sender As Object, e As EventArgs) Handles PlayResetMenuItem.Click

        If MessageBox.Show("シャトルを画面の中央に移動します。",
                           Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.Cancel Then
            Exit Sub
        End If

        ShuttleLabel.Location = ResetPoint

    End Sub

    Private Sub ShuttleLabel_LocationChanged(sender As Object, e As EventArgs) Handles ShuttleLabel.LocationChanged

        If ShuttleLabel.Location.Equals(ResetPoint) Then
            PlayResetMenuItem.Enabled = False
        Else
            PlayResetMenuItem.Enabled = True
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        ShuttleLabel.ImageIndex = 0
    End Sub

    Private Sub ShuttleLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles ShuttleLabel.MouseDown

        If e.Button <> MouseButtons.Left Then
            ShuttleLabel.Capture = False
            Exit Sub
        End If

        DownPoint = e.Location
        ShuttleLabel.Cursor = Cursors.SizeAll
    End Sub

    Private Sub ShuttleLabel_MouseMove(sender As Object, e As MouseEventArgs) Handles ShuttleLabel.MouseMove

        If ShuttleLabel.Capture = False Then
            Exit Sub
        End If

        Dim movePoint As Point = e.Location
        movePoint.Offset(-DownPoint.X, -DownPoint.Y)

        If Math.Sqrt(movePoint.X ^ 2 + movePoint.Y ^ 2) < 5 Then
            Exit Sub
        End If

        With ShuttleLabel
            .Location = New Point(.Location.X + movePoint.X, .Location.Y + movePoint.Y)
            .ImageIndex = ChangeIndex()
        End With

    End Sub

    Private Sub ShuttleLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles ShuttleLabel.MouseUp

        If ShuttleLabel.Capture = False Then
            Exit Sub
        End If

        ShuttleLabel.ImageIndex = 0
        ShuttleLabel.Cursor = Cursors.Default
    End Sub
End Class
