Public Class Form1

    Private Sub Panel1_DragEnter(sender As Object, e As DragEventArgs) Handles PanelFile.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub PanelFile_DragDrop(sender As Object, e As DragEventArgs) Handles PanelFile.DragDrop
        Dim fileName As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())

        Dim fileNameList As New List(Of String)(fileName)
        fileNameList.Sort()


        Dim destDirecPath = TextBoxDest.Text

        '// 遅ければここを非同期化すると速くなるかもしれんね

        LabelStatus.Text = $"0/{fileNameList.Count}"

        For i = 0 To fileNameList.Count - 1
            Dim file = fileNameList(i)
            Dim writeDate = IO.File.GetLastWriteTime(file)

            Dim moveDirec = writeDate.ToString("MM-dd")

            Dim destFilePath = IO.Path.Combine(destDirecPath, moveDirec, IO.Path.GetFileName(file))
            If IO.File.Exists(destFilePath) Then
                MessageBox.Show("移動先にもうファイルがあるよ。処理を中止します。")
                Return
            End If

            IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(destFilePath))

            IO.File.Move(file, destFilePath)

            LabelStatus.Text = $"{i}/{fileNameList.Count}"
            LabelStatus.Update()
        Next

        MessageBox.Show("移動したよ")
    End Sub
End Class
