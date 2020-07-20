<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T10Question
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
        Me.lblT10Question = New System.Windows.Forms.Label()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.btnT10CheckAnswer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblRnd = New System.Windows.Forms.Label()
        Me.lblFib = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblT10Question
        '
        Me.lblT10Question.AutoSize = True
        Me.lblT10Question.Location = New System.Drawing.Point(13, 13)
        Me.lblT10Question.Name = "lblT10Question"
        Me.lblT10Question.Size = New System.Drawing.Size(15, 13)
        Me.lblT10Question.TabIndex = 0
        Me.lblT10Question.Text = "Q"
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(289, 93)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(13, 13)
        Me.lblTest.TabIndex = 2
        Me.lblTest.Text = "?"
        '
        'btnT10CheckAnswer
        '
        Me.btnT10CheckAnswer.Location = New System.Drawing.Point(158, 176)
        Me.btnT10CheckAnswer.Name = "btnT10CheckAnswer"
        Me.btnT10CheckAnswer.Size = New System.Drawing.Size(92, 23)
        Me.btnT10CheckAnswer.TabIndex = 18
        Me.btnT10CheckAnswer.Text = "Check Answer"
        Me.btnT10CheckAnswer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Answer:"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(51, 176)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 20)
        Me.txtAnswer.TabIndex = 16
        '
        'lblRnd
        '
        Me.lblRnd.AutoSize = True
        Me.lblRnd.Location = New System.Drawing.Point(289, 13)
        Me.lblRnd.Name = "lblRnd"
        Me.lblRnd.Size = New System.Drawing.Size(15, 13)
        Me.lblRnd.TabIndex = 19
        Me.lblRnd.Text = "R"
        '
        'lblFib
        '
        Me.lblFib.AutoSize = True
        Me.lblFib.Location = New System.Drawing.Point(13, 73)
        Me.lblFib.Name = "lblFib"
        Me.lblFib.Size = New System.Drawing.Size(10, 13)
        Me.lblFib.TabIndex = 20
        Me.lblFib.Text = "f"
        '
        'T10Question
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 208)
        Me.Controls.Add(Me.lblFib)
        Me.Controls.Add(Me.lblRnd)
        Me.Controls.Add(Me.btnT10CheckAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.lblT10Question)
        Me.Name = "T10Question"
        Me.Text = "Sequences"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblT10Question As System.Windows.Forms.Label
    Friend WithEvents lblTest As System.Windows.Forms.Label
    Friend WithEvents btnT10CheckAnswer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblRnd As System.Windows.Forms.Label
    Friend WithEvents lblFib As System.Windows.Forms.Label
End Class
