<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddQuestion
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
        Me.txtNewQ = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddQ = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTopic = New System.Windows.Forms.ComboBox()
        Me.txtNewA = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNewQ
        '
        Me.txtNewQ.Location = New System.Drawing.Point(82, 10)
        Me.txtNewQ.Name = "txtNewQ"
        Me.txtNewQ.Size = New System.Drawing.Size(100, 96)
        Me.txtNewQ.TabIndex = 0
        Me.txtNewQ.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Question"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Answer"
        '
        'btnAddQ
        '
        Me.btnAddQ.Location = New System.Drawing.Point(197, 227)
        Me.btnAddQ.Name = "btnAddQ"
        Me.btnAddQ.Size = New System.Drawing.Size(75, 23)
        Me.btnAddQ.TabIndex = 4
        Me.btnAddQ.Text = "Add"
        Me.btnAddQ.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Topic"
        '
        'cmbTopic
        '
        Me.cmbTopic.FormattingEnabled = True
        Me.cmbTopic.Items.AddRange(New Object() {"Pythagoras", "Averages", "Equations", "Rounding", "Angles", "Trigonometry", "Graphs", "Probability", "Measurement", "Sequences"})
        Me.cmbTopic.Location = New System.Drawing.Point(82, 155)
        Me.cmbTopic.Name = "cmbTopic"
        Me.cmbTopic.Size = New System.Drawing.Size(100, 21)
        Me.cmbTopic.TabIndex = 6
        '
        'txtNewA
        '
        Me.txtNewA.Location = New System.Drawing.Point(82, 114)
        Me.txtNewA.Name = "txtNewA"
        Me.txtNewA.Size = New System.Drawing.Size(100, 20)
        Me.txtNewA.TabIndex = 7
        '
        'AddQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtNewA)
        Me.Controls.Add(Me.cmbTopic)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAddQ)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNewQ)
        Me.Name = "AddQuestion"
        Me.Text = "AddQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNewQ As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddQ As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTopic As System.Windows.Forms.ComboBox
    Friend WithEvents txtNewA As System.Windows.Forms.TextBox
End Class
