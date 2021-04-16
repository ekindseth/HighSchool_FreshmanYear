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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttimes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.answer = New System.Windows.Forms.Label()
        Me.btnroll = New System.Windows.Forms.Button()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number to Roll"
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(38, 122)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(100, 20)
        Me.txtnum.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of Times"
        '
        'txttimes
        '
        Me.txttimes.Location = New System.Drawing.Point(239, 121)
        Me.txttimes.Name = "txttimes"
        Me.txttimes.Size = New System.Drawing.Size(100, 20)
        Me.txttimes.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(430, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number of Rolls"
        '
        'answer
        '
        Me.answer.AutoSize = True
        Me.answer.Location = New System.Drawing.Point(433, 121)
        Me.answer.Name = "answer"
        Me.answer.Size = New System.Drawing.Size(0, 13)
        Me.answer.TabIndex = 5
        '
        'btnroll
        '
        Me.btnroll.Location = New System.Drawing.Point(170, 216)
        Me.btnroll.Name = "btnroll"
        Me.btnroll.Size = New System.Drawing.Size(306, 148)
        Me.btnroll.TabIndex = 6
        Me.btnroll.Text = "Roll"
        Me.btnroll.UseVisualStyleBackColor = True
        '
        'btnquit
        '
        Me.btnquit.Location = New System.Drawing.Point(285, 381)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(75, 23)
        Me.btnquit.TabIndex = 7
        Me.btnquit.Text = "Quit"
        Me.btnquit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 436)
        Me.Controls.Add(Me.btnquit)
        Me.Controls.Add(Me.btnroll)
        Me.Controls.Add(Me.answer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttimes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttimes As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents answer As System.Windows.Forms.Label
    Friend WithEvents btnroll As System.Windows.Forms.Button
    Friend WithEvents btnquit As System.Windows.Forms.Button

End Class
