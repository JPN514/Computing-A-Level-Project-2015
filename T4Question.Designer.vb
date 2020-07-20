<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T4Question
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
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblPlaces = New System.Windows.Forms.Label()
        Me.lblT4Question = New System.Windows.Forms.Label()
        Me.btnT4CheckAnswer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblRandomNo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(432, 131)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(42, 13)
        Me.lblAnswer.TabIndex = 52
        Me.lblAnswer.Text = "Answer"
        '
        'lblPlaces
        '
        Me.lblPlaces.AutoSize = True
        Me.lblPlaces.Location = New System.Drawing.Point(172, 9)
        Me.lblPlaces.Name = "lblPlaces"
        Me.lblPlaces.Size = New System.Drawing.Size(15, 13)
        Me.lblPlaces.TabIndex = 50
        Me.lblPlaces.Text = "R"
        '
        'lblT4Question
        '
        Me.lblT4Question.AutoSize = True
        Me.lblT4Question.Location = New System.Drawing.Point(12, 9)
        Me.lblT4Question.Name = "lblT4Question"
        Me.lblT4Question.Size = New System.Drawing.Size(15, 13)
        Me.lblT4Question.TabIndex = 49
        Me.lblT4Question.Text = "Q"
        '
        'btnT4CheckAnswer
        '
        Me.btnT4CheckAnswer.Location = New System.Drawing.Point(193, 212)
        Me.btnT4CheckAnswer.Name = "btnT4CheckAnswer"
        Me.btnT4CheckAnswer.Size = New System.Drawing.Size(92, 23)
        Me.btnT4CheckAnswer.TabIndex = 47
        Me.btnT4CheckAnswer.Text = "Check Answer"
        Me.btnT4CheckAnswer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Answer:"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(63, 214)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 20)
        Me.txtAnswer.TabIndex = 45
        '
        'lblRandomNo
        '
        Me.lblRandomNo.AutoSize = True
        Me.lblRandomNo.Location = New System.Drawing.Point(103, 9)
        Me.lblRandomNo.Name = "lblRandomNo"
        Me.lblRandomNo.Size = New System.Drawing.Size(15, 13)
        Me.lblRandomNo.TabIndex = 53
        Me.lblRandomNo.Text = "R"
        '
        'T4Question
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 389)
        Me.Controls.Add(Me.lblRandomNo)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblPlaces)
        Me.Controls.Add(Me.lblT4Question)
        Me.Controls.Add(Me.btnT4CheckAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Name = "T4Question"
        Me.Text = "Rounding"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblPlaces As System.Windows.Forms.Label
    Friend WithEvents lblT4Question As System.Windows.Forms.Label
    Friend WithEvents btnT4CheckAnswer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblRandomNo As System.Windows.Forms.Label
End Class
