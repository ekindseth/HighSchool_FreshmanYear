<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.picGuitar = New System.Windows.Forms.PictureBox()
        CType(Me.picGuitar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(197, 198)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 0
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(53, 198)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer.TabIndex = 1
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(53, 21)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(172, 71)
        Me.txtQuestion.TabIndex = 2
        Me.txtQuestion.Text = "What rock and roll instument is often played with sharp, slapping thumb movements" & _
            "?"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(53, 121)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 20)
        Me.txtAnswer.TabIndex = 3
        Me.txtAnswer.Text = "Wrire Answer Here"
        '
        'picGuitar
        '
        Me.picGuitar.Image = CType(resources.GetObject("picGuitar.Image"), System.Drawing.Image)
        Me.picGuitar.Location = New System.Drawing.Point(327, 21)
        Me.picGuitar.Name = "picGuitar"
        Me.picGuitar.Size = New System.Drawing.Size(253, 306)
        Me.picGuitar.TabIndex = 4
        Me.picGuitar.TabStop = False
        Me.picGuitar.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 477)
        Me.Controls.Add(Me.picGuitar)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.btnQuit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picGuitar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents picGuitar As System.Windows.Forms.PictureBox

End Class
