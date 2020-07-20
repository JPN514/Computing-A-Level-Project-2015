<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T5Question
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
        Me.lblH = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblr = New System.Windows.Forms.Label()
        Me.btnT5CheckAnswer = New System.Windows.Forms.Button()
        Me.lbltest = New System.Windows.Forms.Label()
        Me.ImageT5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblT5Question = New System.Windows.Forms.Label()
        CType(Me.ImageT5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblH
        '
        Me.lblH.AutoSize = True
        Me.lblH.Location = New System.Drawing.Point(237, 261)
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(13, 13)
        Me.lblH.TabIndex = 46
        Me.lblH.Text = "h"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(197, 261)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(13, 13)
        Me.lblB.TabIndex = 45
        Me.lblB.Text = "b"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(155, 261)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(13, 13)
        Me.lblA.TabIndex = 44
        Me.lblA.Text = "a"
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Location = New System.Drawing.Point(110, 261)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(10, 13)
        Me.lblr.TabIndex = 43
        Me.lblr.Text = "r"
        '
        'btnT5CheckAnswer
        '
        Me.btnT5CheckAnswer.Location = New System.Drawing.Point(158, 356)
        Me.btnT5CheckAnswer.Name = "btnT5CheckAnswer"
        Me.btnT5CheckAnswer.Size = New System.Drawing.Size(92, 23)
        Me.btnT5CheckAnswer.TabIndex = 42
        Me.btnT5CheckAnswer.Text = "Check Answer"
        Me.btnT5CheckAnswer.UseVisualStyleBackColor = True
        '
        'lbltest
        '
        Me.lbltest.AutoSize = True
        Me.lbltest.Location = New System.Drawing.Point(433, 107)
        Me.lbltest.Name = "lbltest"
        Me.lbltest.Size = New System.Drawing.Size(34, 13)
        Me.lbltest.TabIndex = 41
        Me.lbltest.Text = "lbltest"
        '
        'ImageT5
        '
        Me.ImageT5.ErrorImage = Nothing
        Me.ImageT5.Location = New System.Drawing.Point(51, 62)
        Me.ImageT5.Name = "ImageT5"
        Me.ImageT5.Size = New System.Drawing.Size(300, 200)
        Me.ImageT5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageT5.TabIndex = 40
        Me.ImageT5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Answer:"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(51, 356)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 20)
        Me.txtAnswer.TabIndex = 38
        '
        'lblT5Question
        '
        Me.lblT5Question.AutoSize = True
        Me.lblT5Question.Location = New System.Drawing.Point(4, 5)
        Me.lblT5Question.Name = "lblT5Question"
        Me.lblT5Question.Size = New System.Drawing.Size(15, 13)
        Me.lblT5Question.TabIndex = 37
        Me.lblT5Question.Text = "Q"
        '
        'T5Question
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 389)
        Me.Controls.Add(Me.lblH)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.btnT5CheckAnswer)
        Me.Controls.Add(Me.lbltest)
        Me.Controls.Add(Me.ImageT5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblT5Question)
        Me.Name = "T5Question"
        Me.Text = "Angles"
        CType(Me.ImageT5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblH As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblr As System.Windows.Forms.Label
    Friend WithEvents btnT5CheckAnswer As System.Windows.Forms.Button
    Friend WithEvents lbltest As System.Windows.Forms.Label
    Friend WithEvents ImageT5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblT5Question As System.Windows.Forms.Label
End Class
