<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassDisplay
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
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lstClass = New System.Windows.Forms.ListBox()
        Me.lblAverageScore = New System.Windows.Forms.Label()
        Me.btnViewStudent = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnViewClass = New System.Windows.Forms.Button()
        Me.btnViewScores = New System.Windows.Forms.Button()
        Me.btnMM = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMMAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(13, 13)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(63, 13)
        Me.lblClass.TabIndex = 0
        Me.lblClass.Text = "Class Name"
        '
        'lstClass
        '
        Me.lstClass.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstClass.FormattingEnabled = True
        Me.lstClass.HorizontalScrollbar = True
        Me.lstClass.ItemHeight = 14
        Me.lstClass.Location = New System.Drawing.Point(16, 47)
        Me.lstClass.Name = "lstClass"
        Me.lstClass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstClass.ScrollAlwaysVisible = True
        Me.lstClass.Size = New System.Drawing.Size(455, 256)
        Me.lstClass.TabIndex = 1
        '
        'lblAverageScore
        '
        Me.lblAverageScore.AutoSize = True
        Me.lblAverageScore.Location = New System.Drawing.Point(121, 321)
        Me.lblAverageScore.Name = "lblAverageScore"
        Me.lblAverageScore.Size = New System.Drawing.Size(78, 13)
        Me.lblAverageScore.TabIndex = 2
        Me.lblAverageScore.Text = "Average Score"
        '
        'btnViewStudent
        '
        Me.btnViewStudent.Location = New System.Drawing.Point(358, 341)
        Me.btnViewStudent.Name = "btnViewStudent"
        Me.btnViewStudent.Size = New System.Drawing.Size(113, 23)
        Me.btnViewStudent.TabIndex = 3
        Me.btnViewStudent.Text = "View student"
        Me.btnViewStudent.UseVisualStyleBackColor = True
        Me.btnViewStudent.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Class average score:"
        '
        'btnViewClass
        '
        Me.btnViewClass.Location = New System.Drawing.Point(358, 13)
        Me.btnViewClass.Name = "btnViewClass"
        Me.btnViewClass.Size = New System.Drawing.Size(113, 23)
        Me.btnViewClass.TabIndex = 5
        Me.btnViewClass.Text = "View Class"
        Me.btnViewClass.UseVisualStyleBackColor = True
        '
        'btnViewScores
        '
        Me.btnViewScores.Location = New System.Drawing.Point(253, 13)
        Me.btnViewScores.Name = "btnViewScores"
        Me.btnViewScores.Size = New System.Drawing.Size(99, 23)
        Me.btnViewScores.TabIndex = 6
        Me.btnViewScores.Text = "View scores"
        Me.btnViewScores.UseVisualStyleBackColor = True
        Me.btnViewScores.Visible = False
        '
        'btnMM
        '
        Me.btnMM.Location = New System.Drawing.Point(167, 13)
        Me.btnMM.Name = "btnMM"
        Me.btnMM.Size = New System.Drawing.Size(80, 23)
        Me.btnMM.TabIndex = 7
        Me.btnMM.Text = "Mental Maths"
        Me.btnMM.UseVisualStyleBackColor = True
        Me.btnMM.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mental Maths average score:"
        '
        'lblMMAverage
        '
        Me.lblMMAverage.AutoSize = True
        Me.lblMMAverage.Location = New System.Drawing.Point(164, 341)
        Me.lblMMAverage.Name = "lblMMAverage"
        Me.lblMMAverage.Size = New System.Drawing.Size(78, 13)
        Me.lblMMAverage.TabIndex = 9
        Me.lblMMAverage.Text = "Average Score"
        '
        'ClassDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 376)
        Me.Controls.Add(Me.lblMMAverage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnMM)
        Me.Controls.Add(Me.btnViewScores)
        Me.Controls.Add(Me.btnViewClass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewStudent)
        Me.Controls.Add(Me.lblAverageScore)
        Me.Controls.Add(Me.lstClass)
        Me.Controls.Add(Me.lblClass)
        Me.Name = "ClassDisplay"
        Me.Text = "ClassDisplay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents lstClass As System.Windows.Forms.ListBox
    Friend WithEvents lblAverageScore As System.Windows.Forms.Label
    Friend WithEvents btnViewStudent As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnViewClass As System.Windows.Forms.Button
    Friend WithEvents btnViewScores As System.Windows.Forms.Button
    Friend WithEvents btnMM As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMMAverage As System.Windows.Forms.Label
End Class
