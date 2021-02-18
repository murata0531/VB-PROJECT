
Public Class Form1

    Dim ButtonTexts() As String = {"スタート", "ストップ"}
    Const BoxSize As Integer = 50
    Const PanelWidth As Integer = 400
    Dim BackColors() As Color = {Color.DarkBlue, Color.MediumBlue, Color.Blue, Color.DodgerBlue, Color.LightSkyBlue}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.BackColor = BackColors(4)
        Me.ClientSize = New Size(PanelWidth, 170)
        Panel1.SetBounds(0, 0, PanelWidth, 120)

        With PictureBox1
            .SetBounds(-BoxSize, 30, BoxSize, BoxSize)
            .Image = ImageList1.Images(0)
        End With

        With StartButton
            .Location = New Point((PanelWidth - .Size.Width) \ 2, 130)
            .Text = ButtonTexts(0)
        End With

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



        With PictureBox1
            .Location = New Point(.Location.X + 5, CInt(0.0012 * (.Location.X - 170) ^ 2 + 10))

            If .Location.X >= Me.ClientSize.Width Then

                .Location = New Point(-BoxSize, .Location.Y)
            End If

            Static t As Integer
            Static u As Integer

            t += 1
            If t = 90 Then
                t = 0
            End If

            If t Mod 10 = 0 Then

                PictureBox1.Image = ImageList1.Images(t \ 10)
                Panel1.BackColor = BackColors(Math.Abs(4 - t \ 10))
            End If
        End With
    End Sub
End Class
