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
        Me.smallbtnPress = New System.Windows.Forms.Button()
        Me.txtmessage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'smallbtnPress
        '
        Me.smallbtnPress.Location = New System.Drawing.Point(99, 194)
        Me.smallbtnPress.Name = "smallbtnPress"
        Me.smallbtnPress.Size = New System.Drawing.Size(75, 23)
        Me.smallbtnPress.TabIndex = 0
        Me.smallbtnPress.Text = "press"
        Me.smallbtnPress.UseVisualStyleBackColor = True
        '
        'txtmessage
        '
        Me.txtmessage.Location = New System.Drawing.Point(68, 42)
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.Size = New System.Drawing.Size(118, 20)
        Me.txtmessage.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtmessage)
        Me.Controls.Add(Me.smallbtnPress)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents smallbtnPress As System.Windows.Forms.Button
    Friend WithEvents txtmessage As System.Windows.Forms.TextBox

End Class
