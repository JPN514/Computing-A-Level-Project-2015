<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Menu
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
        Me.cbmTests = New System.Windows.Forms.ComboBox()
        Me.btnStuTest = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStuScores = New System.Windows.Forms.Button()
        Me.btnStuMenuBack = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMM = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tests"
        '
        'cbmTests
        '
        Me.cbmTests.FormattingEnabled = True
        Me.cbmTests.Items.AddRange(New Object() {"Pythagoras", "Averages", "Equations", "Rounding", "Angles", "Trigonometry", "Graphs", "Probability", "Measurement", "Sequences"})
        Me.cbmTests.Location = New System.Drawing.Point(53, 4)
        Me.cbmTests.Name = "cbmTests"
        Me.cbmTests.Size = New System.Drawing.Size(121, 21)
        Me.cbmTests.TabIndex = 1
        '
        'btnStuTest
        '
        Me.btnStuTest.Location = New System.Drawing.Point(180, 4)
        Me.btnStuTest.Name = "btnStuTest"
        Me.btnStuTest.Size = New System.Drawing.Size(75, 23)
        Me.btnStuTest.TabIndex = 2
        Me.btnStuTest.Text = "Take Test"
        Me.btnStuTest.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Scores"
        '
        'btnStuScores
        '
        Me.btnStuScores.Location = New System.Drawing.Point(180, 28)
        Me.btnStuScores.Name = "btnStuScores"
        Me.btnStuScores.Size = New System.Drawing.Size(75, 23)
        Me.btnStuScores.TabIndex = 4
        Me.btnStuScores.Text = "View scores"
        Me.btnStuScores.UseVisualStyleBackColor = True
        '
        'btnStuMenuBack
        '
        Me.btnStuMenuBack.Location = New System.Drawing.Point(197, 227)
        Me.btnStuMenuBack.Name = "btnStuMenuBack"
        Me.btnStuMenuBack.Size = New System.Drawing.Size(75, 23)
        Me.btnStuMenuBack.TabIndex = 8
        Me.btnStuMenuBack.Text = "Back"
        Me.btnStuMenuBack.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.AutoSize = True
        Me.txtID.Location = New System.Drawing.Point(8, 227)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(39, 13)
        Me.txtID.TabIndex = 9
        Me.txtID.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mental maths"
        '
        'btnMM
        '
        Me.btnMM.Location = New System.Drawing.Point(180, 52)
        Me.btnMM.Name = "btnMM"
        Me.btnMM.Size = New System.Drawing.Size(75, 23)
        Me.btnMM.TabIndex = 11
        Me.btnMM.Text = "Take Test"
        Me.btnMM.UseVisualStyleBackColor = True
        '
        'Student_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnMM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnStuMenuBack)
        Me.Controls.Add(Me.btnStuScores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnStuTest)
        Me.Controls.Add(Me.cbmTests)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Student_Menu"
        Me.Text = "Student_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbmTests As System.Windows.Forms.ComboBox
    Friend WithEvents btnStuTest As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnStuScores As System.Windows.Forms.Button
    Friend WithEvents btnStuMenuBack As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnMM As System.Windows.Forms.Button
End Class
