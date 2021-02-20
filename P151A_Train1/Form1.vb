
Public Class Form1

    Const StartStr As String = "スタート"
    Const ResetStr As String = "リセット"
    Const Last As Integer = 9
    Dim TrainLabels(Last) As Label
    Dim TrainRandom As Random = New Random
    Dim LabelInitTop As Integer
    Dim CopyDistance As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelInitTop = TrainLabel.Location.Y
        CopyDistance = TrainLabel.Size.Width + 12
        With Me
            .Size = New Size(.Size.Width + CopyDistance * 10, .Size.Height)
            .MinimumSize = New Size(.Size.Width, 200)
            .MaximumSize = New Size(.Size.Width, 400)
        End With

        TrainLabels(0) = TrainLabel

        For i As Integer = 1 To 9

            TrainLabels(i) = New Label
            With TrainLabels(i)
                .Location = New Point(TrainLabels(i - 1).Location.X + CopyDistance, LabelInitTop)
                .Size = TrainLabel.Size
                .Image = TrainLabel.Image
                .ImageAlign = TrainLabel.ImageAlign
            End With

            Me.Controls.AddRange(TrainLabels)

            StartButton.Text = StartStr
        Next
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        If StartButton.Text = StartStr Then
            StartButton.Text = ResetStr
            Timer1.Start()

        Else

            StartButton.Text = StartStr
            Timer1.Stop()
            For Each tLabel As Label In TrainLabels
                tLabel.Location = New Point(tLabel.Location.X, LabelInitTop)
            Next
            Me.Size = Me.MinimumSize
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim n As Integer = TrainRandom.Next(0, 10)

        With TrainLabels(n)
            .Location = New Point(.Location.X, .Location.Y + 5)
        End With
    End Sub
End Class
