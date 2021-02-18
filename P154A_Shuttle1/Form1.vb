
Public Class Form1

    Dim ResetPoint As Point

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
End Class
