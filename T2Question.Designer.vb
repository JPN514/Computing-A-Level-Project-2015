<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T2Question
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
        Me.lblT2Question = New System.Windows.Forms.Label()
        Me.btnCheckAnswer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblmean = New System.Windows.Forms.Label()
        Me.lblrange = New System.Windows.Forms.Label()
        Me.lblmedian = New System.Windows.Forms.Label()
        Me.lblmode = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblT2Question
        '
        Me.lblT2Question.AutoSize = True
        Me.lblT2Question.Location = New System.Drawing.Point(12, 13)
        Me.lblT2Question.Name = "lblT2Question"
        Me.lblT2Question.Size = New System.Drawing.Size(15, 13)
        Me.lblT2Question.TabIndex = 0
        Me.lblT2Question.Text = "Q"
        '
        'btnCheckAnswer
        '
        Me.btnCheckAnswer.Location = New System.Drawing.Point(160, 357)
        Me.btnCheckAnswer.Name = "btnCheckAnswer"
        Me.btnCheckAnswer.Size = New System.Drawing.Size(92, 23)
        Me.btnCheckAnswer.TabIndex = 18
        Me.btnCheckAnswer.Text = "Check Answer"
        Me.btnCheckAnswer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Answer:"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(53, 357)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 20)
        Me.txtAnswer.TabIndex = 16
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(212, 13)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(30, 13)
        Me.lblData.TabIndex = 19
        Me.lblData.Text = "Data"
        '
        'lblmean
        '
        Me.lblmean.AutoSize = True
        Me.lblmean.Location = New System.Drawing.Point(340, 121)
        Me.lblmean.Name = "lblmean"
        Me.lblmean.Size = New System.Drawing.Size(39, 13)
        Me.lblmean.TabIndex = 20
        Me.lblmean.Text = "Label2"
        '
        'lblrange
        '
        Me.lblrange.AutoSize = True
        Me.lblrange.Location = New System.Drawing.Point(343, 165)
        Me.lblrange.Name = "lblrange"
        Me.lblrange.Size = New System.Drawing.Size(39, 13)
        Me.lblrange.TabIndex = 21
        Me.lblrange.Text = "Label2"
        '
        'lblmedian
        '
        Me.lblmedian.AutoSize = True
        Me.lblmedian.Location = New System.Drawing.Point(346, 201)
        Me.lblmedian.Name = "lblmedian"
        Me.lblmedian.Size = New System.Drawing.Size(39, 13)
        Me.lblmedian.TabIndex = 22
        Me.lblmedian.Text = "Label2"
        '
        'lblmode
        '
        Me.lblmode.AutoSize = True
        Me.lblmode.Location = New System.Drawing.Point(343, 232)
        Me.lblmode.Name = "lblmode"
        Me.lblmode.Size = New System.Drawing.Size(39, 13)
        Me.lblmode.TabIndex = 23
        Me.lblmode.Text = "Label2"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(120, 150)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 13)
        Me.lblTotal.TabIndex = 24
        Me.lblTotal.Text = "Label2"
        '
        'T2Question
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 389)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblmode)
        Me.Controls.Add(Me.lblmedian)
        Me.Controls.Add(Me.lblrange)
        Me.Controls.Add(Me.lblmean)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.btnCheckAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblT2Question)
        Me.Name = "T2Question"
        Me.Text = "Averages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblT2Question As System.Windows.Forms.Label
    Friend WithEvents btnCheckAnswer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblmean As System.Windows.Forms.Label
    Friend WithEvents lblrange As System.Windows.Forms.Label
    Friend WithEvents lblmedian As System.Windows.Forms.Label
    Friend WithEvents lblmode As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
