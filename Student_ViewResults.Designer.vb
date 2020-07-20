<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_ViewResults
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
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.btnViewResults = New System.Windows.Forms.Button()
        Me.lstStudentResults = New System.Windows.Forms.ListBox()
        Me.btnStuSeeGraph = New System.Windows.Forms.Button()
        Me.ChartResults = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.ChartResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(13, 13)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(18, 13)
        Me.lblStudentID.TabIndex = 1
        Me.lblStudentID.Text = "ID"
        '
        'btnViewResults
        '
        Me.btnViewResults.Location = New System.Drawing.Point(174, 8)
        Me.btnViewResults.Name = "btnViewResults"
        Me.btnViewResults.Size = New System.Drawing.Size(78, 23)
        Me.btnViewResults.TabIndex = 2
        Me.btnViewResults.Text = "View Results"
        Me.btnViewResults.UseVisualStyleBackColor = True
        '
        'lstStudentResults
        '
        Me.lstStudentResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStudentResults.FormattingEnabled = True
        Me.lstStudentResults.ItemHeight = 14
        Me.lstStudentResults.Location = New System.Drawing.Point(12, 90)
        Me.lstStudentResults.Name = "lstStudentResults"
        Me.lstStudentResults.Size = New System.Drawing.Size(240, 158)
        Me.lstStudentResults.TabIndex = 3
        '
        'btnStuSeeGraph
        '
        Me.btnStuSeeGraph.Location = New System.Drawing.Point(258, 8)
        Me.btnStuSeeGraph.Name = "btnStuSeeGraph"
        Me.btnStuSeeGraph.Size = New System.Drawing.Size(75, 23)
        Me.btnStuSeeGraph.TabIndex = 4
        Me.btnStuSeeGraph.Text = "View Graph"
        Me.btnStuSeeGraph.UseVisualStyleBackColor = True
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
        Me.ChartResults.Location = New System.Drawing.Point(12, 37)
        Me.ChartResults.Name = "ChartResults"
        Series1.ChartArea = "ChartArea1"
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "Scores"
        Me.ChartResults.Series.Add(Series1)
        Me.ChartResults.Size = New System.Drawing.Size(411, 300)
        Me.ChartResults.TabIndex = 5
        Me.ChartResults.Text = "Chart1"
        Me.ChartResults.Visible = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(69, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name"
        '
        'Student_ViewResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 336)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.ChartResults)
        Me.Controls.Add(Me.btnStuSeeGraph)
        Me.Controls.Add(Me.lstStudentResults)
        Me.Controls.Add(Me.btnViewResults)
        Me.Controls.Add(Me.lblStudentID)
        Me.Name = "Student_ViewResults"
        Me.Text = "Student_ViewResults"
        CType(Me.ChartResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStudentID As System.Windows.Forms.Label
    Friend WithEvents btnViewResults As System.Windows.Forms.Button
    Friend WithEvents lstStudentResults As System.Windows.Forms.ListBox
    Friend WithEvents btnStuSeeGraph As System.Windows.Forms.Button
    Friend WithEvents ChartResults As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class
