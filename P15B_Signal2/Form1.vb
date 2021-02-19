

Imports P152B_Signal2.My.Resources
Public Class Form1

    Dim SigPictureBoxs(2) As PictureBox
    Dim SigSequences(,) As Integer = {{0, 0, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 1, 2}}
    Dim SigImages(3) As Image
    Dim ButtonTexts() As String = {"スタート", "ストップ"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SigPictureBoxs(0) = LeftPictureBox
        SigPictureBoxs(1) = RightPictureBox
        SigImages(0) = SignalG
        SigImages(1) = SignalY
        SigImages(2) = SignalR

        LeftPictureBox.Image = SigImages(0)
        RightPictureBox.Image = SigImages(2)
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        Static s As Integer

        If s = 0 Then
            Timer1.Start()
            s = 1
        Else
            Timer1.Stop()
            s = 0
        End If

        StartButton.Text = ButtonTexts(s)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Static n As Integer

        If n = 11 Then
            n = 0
        Else
            n = n + 1
        End If

        For p As Integer = 0 To 1

            SigPictureBoxs(p).Image = SigImages(SigSequences(p, n))
        Next
    End Sub
End Class
