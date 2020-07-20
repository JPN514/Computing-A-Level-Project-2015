<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayStudent
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnViewGraph = New System.Windows.Forms.Button()
        Me.lblAverageScore = New System.Windows.Forms.Label()
        Me.lstStudentResults = New System.Windows.Forms.ListBox()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.ChartResults = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStrength = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblWeak = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.ChartResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Student average score:"
        '
        'btnViewGraph
        '
        Me.btnViewGraph.Location = New System.Drawing.Point(354, 338)
        Me.btnViewGraph.Name = "btnViewGraph"
        Me.btnViewGraph.Size = New System.Drawing.Size(113, 23)
        Me.btnViewGraph.TabIndex = 8
        Me.btnViewGraph.Text = "View graph"
        Me.btnViewGraph.UseVisualStyleBackColor = True
        '
        'lblAverageScore
        '
        Me.lblAverageScore.AutoSize = True
        Me.lblAverageScore.Location = New System.Drawing.Point(407, 10)
        Me.lblAverageScore.Name = "lblAverageScore"
        Me.lblAverageScore.Size = New System.Drawing.Size(78, 13)
        Me.lblAverageScore.TabIndex = 7
        Me.lblAverageScore.Text = "Average Score"
        '
        'lstStudentResults
        '
        Me.lstStudentResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStudentResults.FormattingEnabled = True
        Me.lstStudentResults.ItemHeight = 14
        Me.lstStudentResults.Location = New System.Drawing.Point(12, 44)
        Me.lstStudentResults.Name = "lstStudentResults"
        Me.lstStudentResults.Size = New System.Drawing.Size(455, 256)
        Me.lstStudentResults.TabIndex = 6
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Location = New System.Drawing.Point(9, 10)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(58, 13)
        Me.lblStudent.TabIndex = 5
        Me.lblStudent.Text = "Student ID"
        '
        'ChartResults
        '
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = 90
        ChartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        ChartArea1.AxisX.Title = "Topics"
        ChartArea1.AxisY.Maximum = 10.0R
        ChartArea1.AxisY.Title = "Score"
        ChartArea1.Name = "ChartArea1"
        Me.ChartResults.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartResults.Legends.Add(Legend1)
        Me.ChartResults.Location = New System.Drawing.Point(36, 26)
        Me.ChartResults.Name = "ChartResults"
        Series1.ChartArea = "ChartArea1"
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "Scores"
        Me.ChartResults.Series.Add(Series1)
        Me.ChartResults.Size = New System.Drawing.Size(411, 300)
        Me.ChartResults.TabIndex = 10
        Me.ChartResults.Text = "Chart1"
        Me.ChartResults.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Strength:"
        '
        'lblStrength
        '
        Me.lblStrength.AutoSize = True
        Me.lblStrength.Location = New System.Drawing.Point(62, 346)
        Me.lblStrength.Name = "lblStrength"
        Me.lblStrength.Size = New System.Drawing.Size(12, 13)
        Me.lblStrength.TabIndex = 12
        Me.lblStrength.Text = "s"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "To be improved:"
        '
        'lblWeak
        '
        Me.lblWeak.AutoSize = True
        Me.lblWeak.Location = New System.Drawing.Point(99, 364)
        Me.lblWeak.Name = "lblWeak"
        Me.lblWeak.Size = New System.Drawing.Size(15, 13)
        Me.lblWeak.TabIndex = 14
        Me.lblWeak.Text = "w"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(74, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 15
        Me.lblName.Text = "Name"
        '
        'DisplayStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 423)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblWeak)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblStrength)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChartResults)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewGraph)
        Me.Controls.Add(Me.lblAverageScore)
        Me.Controls.Add(Me.lstStudentResults)
        Me.Controls.Add(Me.lblStudent)
        Me.Name = "DisplayStudent"
        Me.Text = "DisplayStudent"
        CType(Me.ChartResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnViewGraph As System.Windows.Forms.Button
    Friend WithEvents lblAverageScore As System.Windows.Forms.Label
    Friend WithEvents lstStudentResults As System.Windows.Forms.ListBox
    Friend WithEvents lblStudent As System.Windows.Forms.Label
    Friend WithEvents ChartResults As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblStrength As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblWeak As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class
