
Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.IO, System.Text.Encoding


Public Class MainForm

    Friend ReadOnly AppliTitle As String = My.Application.Info.Title
    Private ReadOnly InitialFont As Font = New Font("ＭＳ ゴシック", 10.5F)

    Private Sub FileExitMenuItem_Click(sender As Object, e As EventArgs) Handles FileExitMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FileNewMenuItem_Click(sender As Object, e As EventArgs) Handles FileNewMenuItem.Click, FileNewButton.Click, Me.Load

        If MainTextBox.Modified AndAlso Not AskSaving("新規作成する前に") Then
            Exit Sub
        End If

        With MainTextBox
            .Clear()
            .ReadOnly = False
            .Select(0, 0)
        End With

        Me.Text = "無題" & " - " & AppliTitle

        OpenFileDialog1.FileName = ""
        SaveFileDialog1.FileName = ""
    End Sub

    Private Sub FileOpenMenuItem_Click(sender As Object, e As EventArgs) Handles FileOpenMenuItem.Click, FileOpenButton.Click

        If MainTextBox.Modified AndAlso Not AskSaving("ファイルを開く前に") Then
            Exit Sub
        End If

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

    Private Sub FileSaveMenuItem_Click(sender As Object, e As EventArgs) Handles FileSaveMenuItem.Click, FileSaveButton.Click

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
            ViewWrapMenuItem.Checked = .TextWrap
            ViewToolbarMenuItem.Checked = .Toolbar
            ViewToolbarStyleMenuItem.Checked = .ToolbarStyle
        End With


        With OpenFileDialog1
            .Filter =
                "テキストファイル(*.txt)|*.txt|HTMLファイル(*.htm;*.html)|*.htm; *.html|XMLファイル(*.xml)|*.xml|VBファイル(*.vb)|*.vb|すべてのファイル(*.*)|*.*"
            SaveFileDialog1.Filter = .Filter
        End With

        PrintPreviewDialog1.StartPosition = FormStartPosition.Manual

        Dim m As Integer = PrinterUnitConvert.Convert(100, PrinterUnit.TenthsOfAMillimeter, PrinterUnit.Display)

        PageSetupDialog1.PageSettings.Margins = New Margins(m, m, m, m)
    End Sub
    Private Function SaveFile(ByVal fname As String) As Boolean

        Try
            File.WriteAllText(fname, MainTextBox.Text, encoding:=[Default])
            MainTextBox.Modified = False
            SaveFile = True
        Catch ex As UnauthorizedAccessException

            MessageBox.Show(ex.Message & vbNewLine & "読み取り専用ファイルの場合は、別のファイル名で保存してください。", AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveFile = False

        Catch ex As Exception

            MessageBox.Show(ex.Message, AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveFile = False
        End Try
    End Function

    Private Function AskSaving(ByVal action As String) As Boolean

        Select Case _
                MessageBox.Show _
            ("内容が変更されています。" & action & "保存しますか？" & vbNewLine &
            "保存する場合は [はい] を選択、" &
            "保存しない場合は [いいえ] を選択してください。",
             AppliTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Case DialogResult.Yes
                FileSaveAsMenuItem.PerformClick()

                AskSaving = Not MainTextBox.Modified

            Case DialogResult.No
                AskSaving = True

            Case Else
                AskSaving = False
        End Select
    End Function

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If MainTextBox.Modified AndAlso Not AskSaving("終了する前に") Then
            e.Cancel = True
            Exit Sub
        End If

        With My.Settings

            .TextFont = MainTextBox.Font
            .TextWrap = ViewWrapMenuItem.Checked
            .Toolbar = ViewToolbarMenuItem.Checked
            .ToolbarStyle = ViewToolbarStyleMenuItem.Checked
        End With

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles SaveFileDialog1.FileOk

        If MainTextBox.ReadOnly AndAlso
                OpenFileDialog1.FileName = SaveFileDialog1.FileName Then

            MessageBox.Show("読み取り専用として開いたファイルは、上書き保存できません。",
                            AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            e.Cancel = True
        End If
    End Sub

    Private Sub ViewHomeMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHomeMenuItem.Click, ViewHomeButton.Click

        With MainTextBox
            .Select(0, 0)
            .ScrollToCaret()
        End With

        EnableEditButton()
    End Sub

    Private Sub ViewWrapMenuItem_Click(sender As Object, e As EventArgs) Handles ViewWrapMenuItem.Click, ViewWrapButton.Click, Me.Shown


        If sender Is ViewWrapButton Then

            ViewWrapMenuItem.Checked = ViewWrapButton.Checked

        Else
            ViewWrapButton.Checked = ViewWrapMenuItem.Checked ''チェック状態切り替え設定''
        End If

        With MainTextBox
            .WordWrap = ViewWrapMenuItem.Checked
            .ScrollToCaret()
        End With
    End Sub

    Private Sub ViewFontMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles ViewFontMenuItem.DropDownOpening

        ViewFontResetMenuItem.Enabled = Not MainTextBox.Font.Equals(InitialFont)
    End Sub

    Private Sub ViewFontSetupMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFontSetupMenuItem.Click

        Try
            With FontDialog1
                .Font = MainTextBox.Font

                If .ShowDialog = DialogResult.Cancel Then
                    Exit Sub
                End If
                MainTextBox.Font = .Font
            End With
        Catch ex As Exception

            MessageBox.Show _
                (ex.Message, AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ViewFontResetMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFontResetMenuItem.Click
        MainTextBox.Font = InitialFont
    End Sub

    Private Sub EditMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles EditMenuItem.DropDownOpening

        With MainTextBox
            EditUndoMenuItem.Enabled = .CanUndo AndAlso Not .ReadOnly

            EditCopyMenuItem.Enabled = .SelectionLength > 0

            EditCutMenuItem.Enabled = EditCopyMenuItem.Enabled AndAlso Not .ReadOnly

            EditPasteMenuItem.Enabled = Clipboard.ContainsText() AndAlso Not .ReadOnly

            EditDeleteMenuItem.Enabled =
                .SelectionStart < .TextLength AndAlso Not .ReadOnly
        End With
    End Sub

    Private Sub EditUndoMenuItem_Click(sender As Object, e As EventArgs) Handles EditUndoMenuItem.Click, EditUndoButton.Click


        With MainTextBox
            .Undo()
            .SelectionLength = 0
        End With
    End Sub

    Private Sub EditCutMenuItem_Click(sender As Object, e As EventArgs) Handles EditCutMenuItem.Click, EditCutButton.Click

        MainTextBox.Cut()
    End Sub

    Private Sub EditCopyMenuItem_Click(sender As Object, e As EventArgs) Handles EditCopyMenuItem.Click, EditCopyButton.Click

        MainTextBox.Copy()
        EnableEditButton()
    End Sub

    Private Sub EditPasteMenuItem_Click(sender As Object, e As EventArgs) Handles EditPasteMenuItem.Click, EditPasteButton.Click

        MainTextBox.Paste()
    End Sub

    Private Sub EditDeleteMenuItem_Click(sender As Object, e As EventArgs) Handles EditDeleteMenuItem.Click, EditDeleteButton.Click

        SendKeys.Send("{DEL}")

    End Sub

    Private Sub EditSelectAllMenuItem_Click(sender As Object, e As EventArgs) Handles EditSelectAllMenuItem.Click

        MainTextBox.SelectAll()
    End Sub

    Private Sub EditFindMenuItem_Click(sender As Object, e As EventArgs) Handles EditFindMenuItem.Click, EditFindButton.Click

        My.Forms.SearchForm.Show(Me)
    End Sub

    Private Sub FilePrintPreviewMenuItem_Click(sender As Object, e As EventArgs) Handles FilePrintPreviewMenuItem.Click, FilePrintPreviewButton.Click

        Try

            PrintPreviewDialog1.Bounds = Me.Bounds

            PrintPreviewDialog1.ShowDialog()

        Catch ex As Exception

            MessageBox.Show(ex.Message, AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub FilePrintMenuItem_Click(sender As Object, e As EventArgs) Handles FilePrintMenuItem.Click, FilePrintButton.Click

        Try

            If PrintDialog1.ShowDialog() = DialogResult.Cancel Then

                Exit Sub

            End If

            PrintDocument1.DocumentName = Me.AppliTitle
            PrintDocument1.Print()

        Catch ex As Exception

            MessageBox.Show(ex.Message, AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Static textIndex As Integer

        Static pageNumber As Integer

        If textIndex = 0 Then

            pageNumber = 1

        Else
            pageNumber += 1
        End If

        Dim headerStr As String =
            Me.Text.Substring(0, Me.Text.LastIndexOf(AppliTitle)) & " Page " & pageNumber.ToString

        Dim marginRectangle As RectangleF = CType(e.MarginBounds, Rectangle)

        e.Graphics.DrawString(headerStr, MainTextBox.Font, Brushes.Black, marginRectangle)

        Dim headerStrrSize As SizeF = e.Graphics.MeasureString(headerStr, MainTextBox.Font)

        Dim leftPoint, rightPoint As Point

        With marginRectangle.Location

            leftPoint = New Point(.X, .Y + headerStrrSize.Height)
            rightPoint = New Point(.X + headerStrrSize.Width, leftPoint.Y)


        End With


        e.Graphics.DrawLine(Pens.Black, leftPoint, rightPoint)

        Dim pageTextStr As String = MainTextBox.Text.Substring(textIndex)

        Dim pageTextRectangle As RectangleF

        Dim headerStrHeight As Single = headerStrrSize.Height * 1.2F

        With marginRectangle

            pageTextRectangle = New RectangleF(.X, .Y + headerStrHeight, .Width, .Height - headerStrHeight)

        End With

        Dim pageTextFormat As StringFormat = New StringFormat(StringFormatFlags.LineLimit)

        e.Graphics.DrawString(pageTextStr, MainTextBox.Font, Brushes.Black, pageTextRectangle, pageTextFormat)

        Dim numCharacters, numLines As Integer

        e.Graphics.MeasureString(pageTextStr, MainTextBox.Font, pageTextRectangle.Size, pageTextFormat, numCharacters, numLines)


        textIndex += numCharacters
        If textIndex < MainTextBox.TextLength Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            textIndex = 0
        End If
    End Sub


    Private Sub FilePageSetupMenuItem_Click(sender As Object, e As EventArgs) Handles FilePageSetupMenuItem.Click

        Try
            PageSetupDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, AppliTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ViewEndMenuItem_Click(sender As Object, e As EventArgs) Handles ViewEndMenuItem.Click, ViewEndButton.Click

        With MainTextBox
            .SelectionStart = .TextLength
            .ScrollToCaret()
        End With

        EnableEditButton()
    End Sub

    Private Sub MainTextBox_TextChanged(sender As Object, e As EventArgs) Handles MainTextBox.TextChanged, MainTextBox.ReadOnlyChanged, Me.Activated

        EnableEditButton()

    End Sub

    Private Sub MainTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles MainTextBox.KeyUp

        EnableEditButton()

    End Sub

    Private Sub MainTextBox_MouseUp(sender As Object, e As MouseEventArgs) Handles MainTextBox.MouseUp

        EnableEditButton()

    End Sub

    Private Sub EnableEditButton()

        With MainTextBox

            EditCopyButton.Enabled = .SelectionLength > 0
            EditCutButton.Enabled = EditCopyButton.Enabled AndAlso Not .ReadOnly

            EditPasteButton.Enabled = Clipboard.ContainsText() AndAlso Not .ReadOnly

            EditUndoButton.Enabled = .CanUndo AndAlso Not .ReadOnly
            EditDeleteButton.Enabled =
                .SelectionStart < .TextLength AndAlso Not .ReadOnly

        End With
    End Sub

    Private Sub ViewToolbarMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolbarMenuItem.Click, Me.Shown

        With ViewToolbarMenuItem

            ToolStrip1.Visible = .Checked ''ツールバーの切り替え''
            ViewToolbarStyleMenuItem.Enabled = .Checked

        End With
    End Sub

    Private Sub ViewToolbarStyleMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolbarStyleMenuItem.Click, Me.Shown

        Dim barStyle As ToolStripItemDisplayStyle

        If ViewToolbarStyleMenuItem.Checked Then

            barStyle = ToolStripItemDisplayStyle.ImageAndText

        Else

            barStyle = ToolStripItemDisplayStyle.Image

        End If

        For Each barButton As ToolStripItem In ToolStrip1.Items

            barButton.DisplayStyle = barStyle ''表示スタイル''
        Next
    End Sub
End Class
