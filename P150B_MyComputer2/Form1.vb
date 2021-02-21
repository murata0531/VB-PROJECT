Imports System.ComponentModel



Public Class Form1

    Const Last As Integer = 9
    Dim ComLabels(Last) As Label
    Dim LabelInitTop As Integer
    Dim CopyDistance As Integer
    Dim Counter As Integer
    Dim FormInitSize As Size

    Private Sub ComLabel_Click(sender As Object, e As EventArgs) Handles ComLabel.Click

        With CType(sender, Label)
            .Location = New Point(.Location.X, .Location.Y + 10)
        End With

        ResetButton.Enabled = True
        Static clicNo As Integer
        clicNo += 1
        Debug.WriteLine(clicNo.ToString("000") & ": Index=" & Array.IndexOf(ComLabels, sender).ToString)
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click

        Me.Size = New Size(Me.Size.Width + CopyDistance, Me.Size.Height)
        Counter += 1
        ComLabels(Counter) = New Label

        With ComLabels(Counter)
            .Location = New Point(ComLabels(Counter - 1).Location.X + CopyDistance, LabelInitTop)
            .Size = ComLabel.Size
            .Image = ComLabel.Image


        End With

        Me.Controls.Add(ComLabels(Counter))

        AddHandler ComLabels(Counter).Click, AddressOf ComLabel_Click

        If Counter = Last Then

            CopyButton.Enabled = False
        End If
        ResetButton.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        FormInitSize = Me.Size
        ResetButton.Enabled = False
        LabelInitTop = ComLabel.Location.Y
        CopyDistance = ComLabel.Size.Width + 10
        ComLabels(0) = ComLabel
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Me.Size = FormInitSize

        For i As Integer = 1 To Counter
            ComLabels(i).Dispose()
            Me.Controls.Remove(ComLabels(i))
            RemoveHandler ComLabels(i).Click, AddressOf ComLabel_Click
        Next

        Counter = 0
        ComLabel.Location = New Point(ComLabel.Location.X, LabelInitTop)

        CopyButton.Enabled = True
        ResetButton.Enabled = False
    End Sub
End Class
