Public Class Form1
    Private Sub ChromeButton1_Click(sender As Object, e As EventArgs) Handles ChromeButton1.Click
        Me.Opacity = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        PictureBox1.Image = screenshot
        Timer1.Enabled = False
        Me.Opacity = 100
    End Sub

    Private Sub ChromeButton2_Click(sender As Object, e As EventArgs) Handles ChromeButton2.Click
        Dim savefiledialog1 As New SaveFileDialog
        Try
            savefiledialog1.Title = "Save File"
            savefiledialog1.FileName = "Capture"
            savefiledialog1.Filter = "JPEG |*.jpeg"
            If savefiledialog1.ShowDialog() = DialogResult.OK Then PictureBox1.Image.Save(savefiledialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
        Catch ex As Exception
            'Do Nothing
        End Try
    End Sub
End Class
