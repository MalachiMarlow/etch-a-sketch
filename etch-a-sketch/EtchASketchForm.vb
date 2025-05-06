Public Class EtchASketchForm

    Dim currentColor As Color = Color.Black
    Dim Drawing As Boolean = False
    Dim colorDialog As New ColorDialog()

    ' Initialize the form and controls
    Private Sub EtchASketchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Etch-A-Sketch"
        Me.Size = New Size(800, 600)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' PictureBox (Drawing area)
        DisplayPictureBox.BackColor = Color.White
        DisplayPictureBox.Location = New Point(10, 10)
        DisplayPictureBox.Size = New Size(760, 480)
        DisplayPictureBox.BorderStyle = BorderStyle.Fixed3D
        AddHandler DisplayPictureBox.MouseMove, AddressOf displayPictureBox_MouseMove
        AddHandler DisplayPictureBox.MouseDown, AddressOf displayPictureBox_MouseDown
        AddHandler DisplayPictureBox.MouseUp, AddressOf displayPictureBox_MouseUp
        AddHandler DisplayPictureBox.MouseClick, AddressOf displayPictureBox_MouseClick

        ' Button: Select Color
        SelectColorButton.Text = "Select Color"
        selectColorButton.Location = New Point(10, 500)
        selectColorButton.Size = New Size(100, 30)
        AddHandler SelectColorButton.Click, AddressOf selectColorButton_Click

        ' Button: Draw Waveforms
        DrawWaveformsButton.Text = "Draw Waveforms"
        drawWaveformsButton.Location = New Point(120, 500)
        drawWaveformsButton.Size = New Size(120, 30)
        drawWaveformsButton.DialogResult = DialogResult.Yes
        AddHandler DrawWaveformsButton.Click, AddressOf drawWaveformsButton_Click

        ' Button: Clear
        ClearButton.Text = "Clear"
        clearButton.Location = New Point(250, 500)
        clearButton.Size = New Size(80, 30)
        AddHandler ClearButton.Click, AddressOf clearButton_Click

        ' Button: Exit
        ExitButton.Text = "Exit"
        exitButton.Location = New Point(340, 500)
        exitButton.Size = New Size(80, 30)
        AddHandler ExitButton.Click, AddressOf exitButton_Click
        'ExitButton.ToolTipText = "Exit the application"


        Dim menuStrip As New MenuStrip()


        Dim fileMenu As New ToolStripMenuItem("File")
        Dim fileExit As New ToolStripMenuItem("Exit")
        AddHandler fileExit.Click, AddressOf exitButton_Click
        fileMenu.DropDownItems.Add(fileExit)


        Dim editMenu As New ToolStripMenuItem("Edit")
        Dim selectColorMenu As New ToolStripMenuItem("Select Color")
        AddHandler selectColorMenu.Click, AddressOf selectColorButton_Click
        Dim drawWaveformsMenu As New ToolStripMenuItem("Draw Waveforms")
        AddHandler drawWaveformsMenu.Click, AddressOf drawWaveformsButton_Click
        Dim clearMenu As New ToolStripMenuItem("Clear")
        AddHandler clearMenu.Click, AddressOf clearButton_Click
        editMenu.DropDownItems.Add(selectColorMenu)
        editMenu.DropDownItems.Add(drawWaveformsMenu)
        editMenu.DropDownItems.Add(clearMenu)

        Dim helpMenu As New ToolStripMenuItem("Help")
        Dim aboutMenu As New ToolStripMenuItem("About")
        helpMenu.DropDownItems.Add(aboutMenu)

        menuStrip.Items.Add(fileMenu)
        menuStrip.Items.Add(editMenu)
        menuStrip.Items.Add(helpMenu)
        Me.MainMenuStrip = menuStrip
        Me.Controls.Add(menuStrip)


        Me.Controls.Add(DisplayPictureBox)
        Me.Controls.Add(selectColorButton)
        Me.Controls.Add(drawWaveformsButton)
        Me.Controls.Add(clearButton)
        Me.Controls.Add(exitButton)
    End Sub

    ' Event Handlers for Mouse actions on the PictureBox
    Private Sub displayPictureBox_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Drawing = True
        End If
    End Sub

    Private Sub displayPictureBox_MouseUp(sender As Object, e As MouseEventArgs)
        Drawing = False
    End Sub

    Private Sub displayPictureBox_MouseMove(sender As Object, e As MouseEventArgs)
        If Drawing Then
            Using g As Graphics = DisplayPictureBox.CreateGraphics()
                g.FillEllipse(New SolidBrush(currentColor), e.X, e.Y, 5, 5)
            End Using
        End If
    End Sub

        Private Sub displayPictureBox_MouseClick(sender As Object, e As MouseEventArgs)
            If e.Button = MouseButtons.Middle Then
            selectColorButton_Click(sender, e)
        End If
        End Sub

        ' Button: Select Color (Color Dialog)
        Private Sub selectColorButton_Click(sender As Object, e As EventArgs)
            If colorDialog.ShowDialog() = DialogResult.OK Then
                currentColor = colorDialog.Color
            End If
        End Sub

        ' Button: Draw Waveforms
        Private Sub drawWaveformsButton_Click(sender As Object, e As EventArgs)
        Using g As Graphics = DisplayPictureBox.CreateGraphics()
            g.Clear(Color.White)

            ' Draw the 10x10 grid (graticule)
            Dim gridSize As Integer = DisplayPictureBox.Width / 10
            For i As Integer = 1 To 9
                g.DrawLine(Pens.Gray, i * gridSize, 0, i * gridSize, DisplayPictureBox.Height)
                g.DrawLine(Pens.Gray, 0, i * gridSize, DisplayPictureBox.Width, i * gridSize)
            Next

            ' Draw Sine, Cosine, and Tangent Waves
            DrawWaveform(g, AddressOf Math.Sin, Color.Red, 0)
            DrawWaveform(g, AddressOf Math.Cos, Color.Green, 1)
            DrawWaveform(g, AddressOf Math.Tan, Color.Blue, 2)
        End Using
    End Sub

        ' Function to draw waveform
        Private Sub DrawWaveform(g As Graphics, func As Func(Of Double, Double), color As Color, offset As Integer)
            Dim width As Integer = displayPictureBox.Width
            Dim height As Integer = displayPictureBox.Height
            Dim points(width) As PointF

            For i As Integer = 0 To width - 1
                Dim x As Single = i
                Dim y As Single = CSng(height / 2 + height / 4 * func(2 * Math.PI * (x / width)))
                points(i) = New PointF(x, y + offset * 40) ' Offset each waveform
            Next

            g.DrawCurve(New Pen(color), points)
        End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs)
            Using g As Graphics = displayPictureBox.CreateGraphics()
                g.Clear(Color.White) ' Clear the picture box
            End Using
        End Sub


    Private Sub exitButton_Click(sender As Object, e As EventArgs)
            Me.Close()
        End Sub


End Class
