
Public Class Form1

    Const StartStr As String = "スタート"
    Const ResetStr As String = "リセット"
    Const Last As Integer = 9
    Dim TrainLabels(Last) As Label
    Dim TrainRandom As Random = New Random
    Dim LabelInitTop As Integer
    Dim CopyDistance As Integer
    Dim FinishPosition As Integer
    Dim FinishedTrains(Last) As Boolean
    Dim FinishCounter As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelInitTop = TrainLabel.Location.Y
        CopyDistance = TrainLabel.Size.Width + 12
        With Me
            .Size = New Size(.Size.Width + CopyDistance * 9, .Size.Height)
            .MinimumSize = New Size(.Size.Width, 250)
            .MaximumSize = New Size(.Size.Width, 500)
        End With

        TrainLabels(0) = TrainLabel

        For i As Integer = 1 To Last

            TrainLabels(i) = New Label
            With TrainLabels(i)
                .Location = New Point(TrainLabels(i - 1).Location.X + CopyDistance, LabelInitTop)
                .Size = TrainLabel.Size
                .Image = TrainLabel.Image
                .ImageAlign = TrainLabel.ImageAlign
                .TextAlign = TrainLabel.TextAlign
            End With
        Next
        'Me.Controls.AddRange(TrainLabels)
        Panel1.Controls.AddRange(TrainLabels)

            StartButton.Text = StartStr

    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        If StartButton.Text = StartStr Then
            StartButton.Text = ResetStr
            FinishPosition = Panel1.ClientSize.Height - TrainLabel.Size.Height - 5
            Timer1.Start()

        Else

            StartButton.Text = StartStr
            Timer1.Stop()
            For Each tLabel As Label In TrainLabels
                'tLabel.Location = New Point(tLabel.Location.X, LabelInitTop)
                With tLabel
                    .Text = ""
                    .Location = New Point(tLabel.Location.X, LabelInitTop)
                End With
            Next
            Array.Clear(FinishedTrains, 0, Last + 1)
            FinishCounter = 0
            Me.Size = Me.MinimumSize
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim n As Integer = TrainRandom.Next(0, 10)

        If FinishedTrains(n) Then
            Exit Sub
        End If
        With TrainLabels(n)
            .Location = New Point(.Location.X, .Location.Y + 5)

            If .Location.Y < FinishPosition Then
                Exit Sub
            End If

            FinishedTrains(n) = True
            FinishCounter += 1
            .Text = FinishCounter

        End With

        If FinishCounter > Last Then
            Timer1.Stop()
        End If
    End Sub
End Class
