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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtNbr1 = New System.Windows.Forms.TextBox()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.txtNbr2 = New System.Windows.Forms.TextBox()
        Me.btnS = New System.Windows.Forms.Button()
        Me.lblE = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(447, 199)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtNbr1
        '
        Me.txtNbr1.Location = New System.Drawing.Point(12, 130)
        Me.txtNbr1.Name = "txtNbr1"
        Me.txtNbr1.Size = New System.Drawing.Size(100, 20)
        Me.txtNbr1.TabIndex = 1
        '
        'btnM
        '
        Me.btnM.Location = New System.Drawing.Point(171, 69)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(75, 23)
        Me.btnM.TabIndex = 2
        Me.btnM.Text = "*"
        Me.btnM.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(90, 69)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(75, 23)
        Me.btnA.TabIndex = 4
        Me.btnA.Text = "+"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Location = New System.Drawing.Point(171, 40)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(75, 23)
        Me.btnD.TabIndex = 5
        Me.btnD.Text = "/"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'txtNbr2
        '
        Me.txtNbr2.Location = New System.Drawing.Point(279, 130)
        Me.txtNbr2.Name = "txtNbr2"
        Me.txtNbr2.Size = New System.Drawing.Size(100, 20)
        Me.txtNbr2.TabIndex = 6
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(90, 40)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(75, 23)
        Me.btnS.TabIndex = 8
        Me.btnS.Text = "-"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'lblE
        '
        Me.lblE.Location = New System.Drawing.Point(386, 105)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(557, 22)
        Me.lblE.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Type Numbers then Select Operator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Operators:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "First Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Second Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(459, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Answer:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 236)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblE)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.txtNbr2)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.btnM)
        Me.Controls.Add(Me.txtNbr1)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtNbr1 As System.Windows.Forms.TextBox
    Friend WithEvents btnM As System.Windows.Forms.Button
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents btnD As System.Windows.Forms.Button
    Friend WithEvents txtNbr2 As System.Windows.Forms.TextBox
    Friend WithEvents btnS As System.Windows.Forms.Button
    Friend WithEvents lblE As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
