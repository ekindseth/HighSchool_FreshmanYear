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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblPennies2 = New System.Windows.Forms.Label()
        Me.lblNickels2 = New System.Windows.Forms.Label()
        Me.lblDimes2 = New System.Windows.Forms.Label()
        Me.lblQuarters2 = New System.Windows.Forms.Label()
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.lblNbrPennies = New System.Windows.Forms.Label()
        Me.lblNbrNickels = New System.Windows.Forms.Label()
        Me.lblNbrDimes = New System.Windows.Forms.Label()
        Me.lblNbrQuarters = New System.Windows.Forms.Label()
        Me.lblNbrDollars = New System.Windows.Forms.Label()
        Me.lblYCET = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.txtpennies = New System.Windows.Forms.TextBox()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.txtDimes = New System.Windows.Forms.TextBox()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.txtNickels = New System.Windows.Forms.TextBox()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.txtQuarters = New System.Windows.Forms.TextBox()
        Me.lblEYC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "If Zero Type 0"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(74, 429)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 44
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(367, 430)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 43
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblPennies2
        '
        Me.lblPennies2.AutoSize = True
        Me.lblPennies2.Location = New System.Drawing.Point(55, 358)
        Me.lblPennies2.Name = "lblPennies2"
        Me.lblPennies2.Size = New System.Drawing.Size(45, 13)
        Me.lblPennies2.TabIndex = 42
        Me.lblPennies2.Text = "Pennies"
        '
        'lblNickels2
        '
        Me.lblNickels2.AutoSize = True
        Me.lblNickels2.Location = New System.Drawing.Point(55, 338)
        Me.lblNickels2.Name = "lblNickels2"
        Me.lblNickels2.Size = New System.Drawing.Size(42, 13)
        Me.lblNickels2.TabIndex = 41
        Me.lblNickels2.Text = "Nickels"
        '
        'lblDimes2
        '
        Me.lblDimes2.AutoSize = True
        Me.lblDimes2.Location = New System.Drawing.Point(55, 319)
        Me.lblDimes2.Name = "lblDimes2"
        Me.lblDimes2.Size = New System.Drawing.Size(36, 13)
        Me.lblDimes2.TabIndex = 40
        Me.lblDimes2.Text = "Dimes"
        '
        'lblQuarters2
        '
        Me.lblQuarters2.AutoSize = True
        Me.lblQuarters2.Location = New System.Drawing.Point(55, 300)
        Me.lblQuarters2.Name = "lblQuarters2"
        Me.lblQuarters2.Size = New System.Drawing.Size(47, 13)
        Me.lblQuarters2.TabIndex = 39
        Me.lblQuarters2.Text = "Quarters"
        '
        'lblDollars
        '
        Me.lblDollars.AutoSize = True
        Me.lblDollars.Location = New System.Drawing.Point(87, 281)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(39, 13)
        Me.lblDollars.TabIndex = 38
        Me.lblDollars.Text = "Dollars"
        '
        'lblNbrPennies
        '
        Me.lblNbrPennies.AutoSize = True
        Me.lblNbrPennies.Location = New System.Drawing.Point(34, 358)
        Me.lblNbrPennies.Name = "lblNbrPennies"
        Me.lblNbrPennies.Size = New System.Drawing.Size(13, 13)
        Me.lblNbrPennies.TabIndex = 37
        Me.lblNbrPennies.Text = "0"
        '
        'lblNbrNickels
        '
        Me.lblNbrNickels.AutoSize = True
        Me.lblNbrNickels.Location = New System.Drawing.Point(35, 338)
        Me.lblNbrNickels.Name = "lblNbrNickels"
        Me.lblNbrNickels.Size = New System.Drawing.Size(13, 13)
        Me.lblNbrNickels.TabIndex = 36
        Me.lblNbrNickels.Text = "0"
        '
        'lblNbrDimes
        '
        Me.lblNbrDimes.AutoSize = True
        Me.lblNbrDimes.Location = New System.Drawing.Point(34, 319)
        Me.lblNbrDimes.Name = "lblNbrDimes"
        Me.lblNbrDimes.Size = New System.Drawing.Size(13, 13)
        Me.lblNbrDimes.TabIndex = 35
        Me.lblNbrDimes.Text = "0"
        '
        'lblNbrQuarters
        '
        Me.lblNbrQuarters.AutoSize = True
        Me.lblNbrQuarters.Location = New System.Drawing.Point(34, 300)
        Me.lblNbrQuarters.Name = "lblNbrQuarters"
        Me.lblNbrQuarters.Size = New System.Drawing.Size(13, 13)
        Me.lblNbrQuarters.TabIndex = 34
        Me.lblNbrQuarters.Text = "0"
        '
        'lblNbrDollars
        '
        Me.lblNbrDollars.Location = New System.Drawing.Point(35, 281)
        Me.lblNbrDollars.Name = "lblNbrDollars"
        Me.lblNbrDollars.Size = New System.Drawing.Size(39, 13)
        Me.lblNbrDollars.TabIndex = 33
        Me.lblNbrDollars.Text = "0"
        '
        'lblYCET
        '
        Me.lblYCET.Location = New System.Drawing.Point(65, 225)
        Me.lblYCET.Name = "lblYCET"
        Me.lblYCET.Size = New System.Drawing.Size(156, 27)
        Me.lblYCET.TabIndex = 32
        Me.lblYCET.Text = "Your Change Equated to:"
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(430, 140)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(45, 13)
        Me.lblPennies.TabIndex = 31
        Me.lblPennies.Text = "Pennies"
        '
        'txtpennies
        '
        Me.txtpennies.Location = New System.Drawing.Point(305, 133)
        Me.txtpennies.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpennies.Name = "txtpennies"
        Me.txtpennies.Size = New System.Drawing.Size(116, 20)
        Me.txtpennies.TabIndex = 30
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Location = New System.Drawing.Point(430, 83)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(36, 13)
        Me.lblDimes.TabIndex = 29
        Me.lblDimes.Text = "Dimes"
        '
        'txtDimes
        '
        Me.txtDimes.Location = New System.Drawing.Point(305, 77)
        Me.txtDimes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDimes.Name = "txtDimes"
        Me.txtDimes.Size = New System.Drawing.Size(116, 20)
        Me.txtDimes.TabIndex = 28
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Location = New System.Drawing.Point(159, 140)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(42, 13)
        Me.lblNickels.TabIndex = 27
        Me.lblNickels.Text = "Nickels"
        '
        'txtNickels
        '
        Me.txtNickels.Location = New System.Drawing.Point(34, 133)
        Me.txtNickels.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNickels.Name = "txtNickels"
        Me.txtNickels.Size = New System.Drawing.Size(116, 20)
        Me.txtNickels.TabIndex = 26
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarters.Location = New System.Drawing.Point(159, 84)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(54, 15)
        Me.lblQuarters.TabIndex = 25
        Me.lblQuarters.Text = "Quarters"
        '
        'txtQuarters
        '
        Me.txtQuarters.Location = New System.Drawing.Point(34, 77)
        Me.txtQuarters.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuarters.Name = "txtQuarters"
        Me.txtQuarters.Size = New System.Drawing.Size(116, 20)
        Me.txtQuarters.TabIndex = 24
        '
        'lblEYC
        '
        Me.lblEYC.Location = New System.Drawing.Point(62, 39)
        Me.lblEYC.Name = "lblEYC"
        Me.lblEYC.Size = New System.Drawing.Size(117, 26)
        Me.lblEYC.TabIndex = 23
        Me.lblEYC.Text = "Enter Your Coins:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 493)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblPennies2)
        Me.Controls.Add(Me.lblNickels2)
        Me.Controls.Add(Me.lblDimes2)
        Me.Controls.Add(Me.lblQuarters2)
        Me.Controls.Add(Me.lblDollars)
        Me.Controls.Add(Me.lblNbrPennies)
        Me.Controls.Add(Me.lblNbrNickels)
        Me.Controls.Add(Me.lblNbrDimes)
        Me.Controls.Add(Me.lblNbrQuarters)
        Me.Controls.Add(Me.lblNbrDollars)
        Me.Controls.Add(Me.lblYCET)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.txtpennies)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.txtDimes)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.txtNickels)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.txtQuarters)
        Me.Controls.Add(Me.lblEYC)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblPennies2 As System.Windows.Forms.Label
    Friend WithEvents lblNickels2 As System.Windows.Forms.Label
    Friend WithEvents lblDimes2 As System.Windows.Forms.Label
    Friend WithEvents lblQuarters2 As System.Windows.Forms.Label
    Friend WithEvents lblDollars As System.Windows.Forms.Label
    Friend WithEvents lblNbrPennies As System.Windows.Forms.Label
    Friend WithEvents lblNbrNickels As System.Windows.Forms.Label
    Friend WithEvents lblNbrDimes As System.Windows.Forms.Label
    Friend WithEvents lblNbrQuarters As System.Windows.Forms.Label
    Friend WithEvents lblNbrDollars As System.Windows.Forms.Label
    Friend WithEvents lblYCET As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents txtpennies As System.Windows.Forms.TextBox
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents txtDimes As System.Windows.Forms.TextBox
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents txtNickels As System.Windows.Forms.TextBox
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents txtQuarters As System.Windows.Forms.TextBox
    Friend WithEvents lblEYC As System.Windows.Forms.Label

End Class
