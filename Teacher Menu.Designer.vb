<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher_Menu
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
        Me.cmbTests = New System.Windows.Forms.ComboBox()
        Me.btnSetTest = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.btnViewClass = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbNew = New System.Windows.Forms.ComboBox()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.btnTeaMenuBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tests"
        '
        'cmbTests
        '
        Me.cmbTests.FormattingEnabled = True
        Me.cmbTests.Items.AddRange(New Object() {"Pythagoras", "Averages", "Equations", "Rounding", "Angles", "Trigonometry", "Graphs", "Probability", "Measurement", "Sequences"})
        Me.cmbTests.Location = New System.Drawing.Point(53, 13)
        Me.cmbTests.Name = "cmbTests"
        Me.cmbTests.Size = New System.Drawing.Size(121, 21)
        Me.cmbTests.TabIndex = 1
        '
        'btnSetTest
        '
        Me.btnSetTest.Location = New System.Drawing.Point(181, 10)
        Me.btnSetTest.Name = "btnSetTest"
        Me.btnSetTest.Size = New System.Drawing.Size(75, 23)
        Me.btnSetTest.TabIndex = 2
        Me.btnSetTest.Text = "Set Test"
        Me.btnSetTest.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Class"
        '
        'cmbClass
        '
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(53, 44)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(121, 21)
        Me.cmbClass.TabIndex = 4
        '
        'btnViewClass
        '
        Me.btnViewClass.Location = New System.Drawing.Point(181, 41)
        Me.btnViewClass.Name = "btnViewClass"
        Me.btnViewClass.Size = New System.Drawing.Size(75, 23)
        Me.btnViewClass.TabIndex = 5
        Me.btnViewClass.Text = "View class"
        Me.btnViewClass.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "New"
        '
        'cmbNew
        '
        Me.cmbNew.FormattingEnabled = True
        Me.cmbNew.Items.AddRange(New Object() {"Student", "Question"})
        Me.cmbNew.Location = New System.Drawing.Point(53, 71)
        Me.cmbNew.Name = "cmbNew"
        Me.cmbNew.Size = New System.Drawing.Size(121, 21)
        Me.cmbNew.TabIndex = 10
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Location = New System.Drawing.Point(181, 71)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddNew.TabIndex = 11
        Me.BtnAddNew.Text = "Add"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'btnTeaMenuBack
        '
        Me.btnTeaMenuBack.Location = New System.Drawing.Point(197, 227)
        Me.btnTeaMenuBack.Name = "btnTeaMenuBack"
        Me.btnTeaMenuBack.Size = New System.Drawing.Size(75, 23)
        Me.btnTeaMenuBack.TabIndex = 12
        Me.btnTeaMenuBack.Text = "Back"
        Me.btnTeaMenuBack.UseVisualStyleBackColor = True
        '
        'Teacher_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnTeaMenuBack)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.cmbNew)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnViewClass)
        Me.Controls.Add(Me.cmbClass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSetTest)
        Me.Controls.Add(Me.cmbTests)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Teacher_Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTests As System.Windows.Forms.ComboBox
    Friend WithEvents btnSetTest As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents btnViewClass As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbNew As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnTeaMenuBack As System.Windows.Forms.Button
End Class
