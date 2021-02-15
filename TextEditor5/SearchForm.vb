
Public Class SearchForm
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close
    End Sub

    Private Sub FindTextBox_TextChanged(sender As Object, e As EventArgs) Handles FindTextBox.TextChanged, Me.Shown

        UpwardButton.Enabled = FindTextBox.TextLength > 0
        DownWardButton.Enabled = UpwardButton.Enabled

    End Sub

    Private Sub SearchForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        With My.Forms.MainForm
            .EditFindMenuItem.Enabled = True
            .Activate()
        End With
    End Sub

    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        With My.Forms.MainForm
            .EditFindMenuItem.Enabled = False
            .EditFindButton.Enabled = False
            Me.Text = .AppliTitle & " [検索] "
            Me.Location = New Point(.Bounds.Right - Me.Size.Width - 23, .Location.Y + 25)
            FindTextBox.Text = .MainTextBox.SelectedText
        End With
    End Sub

    Private Sub UpwardButton_Click(sender As Object, e As EventArgs) Handles UpwardButton.Click, DownWardButton.Click

        Dim foundPosition As Integer

        With My.Forms.MainForm.MainTextBox
            If TryCast(sender, Button) Is DownWardButton Then

                If .SelectedText <> FindTextBox.Text Then
                    .SelectionLength = 0
                End If

                foundPosition = .Text.IndexOf(FindTextBox.Text, .SelectionStart + .SelectionLength) ''''''''''''''''''''''''''''

            ElseIf .SelectionStart >= 1 Then

                foundPosition = .Text.LastIndexOf(FindTextBox.Text, .SelectionStart - 1) ''''''''''''''''''''''''''''

            Else

                foundPosition = -1
            End If


            If foundPosition >= 0 Then

                .Select(foundPosition, FindTextBox.TextLength)
                .ScrollToCaret()

            Else

                MessageBox.Show("文字列" & FindTextBox.Text & "の検索が終了しました。", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        End With
    End Sub
End Class