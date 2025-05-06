<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchASketchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.Location = New System.Drawing.Point(13, 14)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(775, 359)
        Me.DisplayPictureBox.TabIndex = 0
        Me.DisplayPictureBox.TabStop = False
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(13, 400)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(126, 38)
        Me.SelectColorButton.TabIndex = 1
        Me.SelectColorButton.Text = "Select Color"
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(662, 400)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(126, 38)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(461, 400)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(126, 38)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(219, 400)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(126, 38)
        Me.DrawWaveformsButton.TabIndex = 4
        Me.DrawWaveformsButton.Text = "Waveforms"
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'EtchASketchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DrawWaveformsButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Name = "EtchASketchForm"
        Me.Text = "Form1"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents DrawWaveformsButton As Button
End Class
