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
        Me.vsbTemp = New System.Windows.Forms.VScrollBar()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.txtCentigrade = New System.Windows.Forms.TextBox()
        Me.lblCentigrade = New System.Windows.Forms.Label()
        Me.lblFahrenheit = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'vsbTemp
        '
        Me.vsbTemp.Location = New System.Drawing.Point(178, 9)
        Me.vsbTemp.Maximum = 250
        Me.vsbTemp.Minimum = -50
        Me.vsbTemp.Name = "vsbTemp"
        Me.vsbTemp.Size = New System.Drawing.Size(58, 289)
        Me.vsbTemp.TabIndex = 0
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Location = New System.Drawing.Point(71, 104)
        Me.txtFahrenheit.Multiline = True
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(104, 55)
        Me.txtFahrenheit.TabIndex = 1
        '
        'txtCentigrade
        '
        Me.txtCentigrade.Location = New System.Drawing.Point(239, 104)
        Me.txtCentigrade.Multiline = True
        Me.txtCentigrade.Name = "txtCentigrade"
        Me.txtCentigrade.Size = New System.Drawing.Size(100, 55)
        Me.txtCentigrade.TabIndex = 2
        '
        'lblCentigrade
        '
        Me.lblCentigrade.AutoSize = True
        Me.lblCentigrade.Location = New System.Drawing.Point(239, 88)
        Me.lblCentigrade.Name = "lblCentigrade"
        Me.lblCentigrade.Size = New System.Drawing.Size(64, 13)
        Me.lblCentigrade.TabIndex = 3
        Me.lblCentigrade.Text = "Centigraade"
        '
        'lblFahrenheit
        '
        Me.lblFahrenheit.AutoSize = True
        Me.lblFahrenheit.Location = New System.Drawing.Point(118, 88)
        Me.lblFahrenheit.Name = "lblFahrenheit"
        Me.lblFahrenheit.Size = New System.Drawing.Size(57, 13)
        Me.lblFahrenheit.TabIndex = 4
        Me.lblFahrenheit.Text = "Fahrenheit"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(178, 301)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(58, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 349)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblFahrenheit)
        Me.Controls.Add(Me.lblCentigrade)
        Me.Controls.Add(Me.txtCentigrade)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.vsbTemp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vsbTemp As System.Windows.Forms.VScrollBar
    Friend WithEvents txtFahrenheit As System.Windows.Forms.TextBox
    Friend WithEvents txtCentigrade As System.Windows.Forms.TextBox
    Friend WithEvents lblCentigrade As System.Windows.Forms.Label
    Friend WithEvents lblFahrenheit As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
