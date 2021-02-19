
Public Class Form1

    Dim SigImages(3) As Image
    Dim SigIntervals() As Integer = {2000, 1000, 3000}
    Dim ButtonTexts() As String = {"スタート", "ストップ"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SigImages(0) = My.Resources.SignalG
        SigImages(1) = My.Resources.SignalY
        SigImages(2) = My.Resources.SignalR

        PictureBox1.Image = SigImages(0)
        Timer1.Interval = 2000
        StartButton.Text = ButtonTexts(0)
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

        If n = 2 Then
            n = 0
        Else
            n = n + 1
        End If

        PictureBox1.Image = SigImages(n)
        Timer1.Interval = SigIntervals(n)
    End Sub
End Class
