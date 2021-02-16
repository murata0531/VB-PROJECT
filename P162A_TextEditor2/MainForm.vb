
Imports System.IO, System.Text.Encoding
Public Class MainForm

    Private ReadOnly AppliTitle As String = My.Application.Info.Title

    Private Sub FileExitMenuItem_Click(sender As Object, e As EventArgs) Handles FileExitMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FileNewMenuItem_Click(sender As Object, e As EventArgs) Handles FileNewMenuItem.Click, Me.Load

        With MainTextBox
            .Clear()
            .ReadOnly = False
            .Select(0, 0)
        End With

        Me.Text = "無題" & " - " & AppliTitle

        OpenFileDialog1.FileName = ""
        SaveFileDialog1.FileName = ""
    End Sub

    Private Sub FileOpenMenuItem_Click(sender As Object, e As EventArgs) Handles FileOpenMenuItem.Click

        With OpenFileDialog1
            .ReadOnlyChecked = False

            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If

            Try
                MainTextBox.Text = File.ReadAllText(.FileName, encoding:=[Default])
            Catch ex As Exception
                MessageBox.Show(ex.Message, AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            MainTextBox.ReadOnly = .ReadOnlyChecked
            MainTextBox.Select(0, 0)

            Me.Text = Path.GetFileName(.FileName) & " - " & AppliTitle

            SaveFileDialog1.FileName = .FileName

        End With
    End Sub

    Private Sub FileSaveAsMenuItem_Click(sender As Object, e As EventArgs) Handles FileSaveAsMenuItem.Click

        With SaveFileDialog1
            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If

            If SaveFile(.FileName) = False Then

                .FileName = OpenFileDialog1.FileName
                Exit Sub
            End If

            MainTextBox.ReadOnly = False

            Me.Text = Path.GetFileName(.FileName) & " - " & AppliTitle

            OpenFileDialog1.FileName = .FileName
        End With
    End Sub

    Private Sub FileSaveMenuItem_Click(sender As Object, e As EventArgs) Handles FileSaveMenuItem.Click

        With OpenFileDialog1

            If .FileName = "" OrElse MainTextBox.ReadOnly Then

                FileSaveAsMenuItem.PerformClick()

                Exit Sub

            End If

            SaveFile(.FileName)
        End With


    End Sub

    ''Private 
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        With My.Computer.Screen.Bounds.Size
            Me.Size = New Size(.Width \ 2, .Height * 2 \ 3)
        End With

        With My.Settings
            MainTextBox.Font = .TextFont
            ViewWrapMenuItem.Enabled = .TextWrap
        End With


        With OpenFileDialog1
            .Filter =
                "テキストファイル(*.txt)|*.txt|HTMLファイル(*.htm;*.html)|*.htm; *.html|XMLファイル(*.xml)|*.xml|VBファイル(*.vb)|*.vb|すべてのファイル(*.*)|*.*"
            SaveFileDialog1.Filter = .Filter
        End With
    End Sub
    Private Function SaveFile(ByVal fname As String) As Boolean

        Try
            File.WriteAllText(fname, MainTextBox.Text, encoding:=[Default])

            SaveFile = True
        Catch ex As Exception

            MessageBox.Show(ex.Message, AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveFile = False
        End Try
    End Function

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing


    End Sub
End Class
