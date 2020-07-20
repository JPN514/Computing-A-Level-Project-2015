Imports System.Data.OleDb
Public Class DisplayStudent

    'lets the teacher see the scores of an individual student
    Dim strength As String 'strongest topic
    Dim weak As String 'weakest topic
    Dim total As Integer
    Dim average As Single
    Dim n As Integer 'index used to add data to the listbox
    Dim s As Integer 'index used to add data to the graph
    Dim z, y As Integer
    Dim fmtstr As String = "{0,-25} {1,-5}"
    Dim scores(10) As Integer
    Dim tests As Integer = 10

    Private Sub DisplayStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstStudentResults.Items.Clear()
        lblStudent.Text = ""
        lblName.Text = ""
        total = 0
        average = 0
        lblStudent.Text = globalvariables.StuID

        ShowResults()

        lblAverageScore.Text = average

    End Sub

    Sub ShowResults()
        'selects the students scores for the listbox
        Dim strDDl As String
        lstStudentResults.Items.Add(String.Format(fmtstr, "Topic", "Score"))
        Do Until n = 10
            strDDl = "SELECT Firstname, Surname, tblStudentScores.Score FROM tblStudentDetails, tblStudentScores WHERE tblStudentDetails.ID = " & globalvariables.StuID & ";"
            runCommand2(strDDl)
        Loop
    End Sub

    Sub runCommand2(ByVal strddl As String)

        'Moves data between program and database
        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        'Give strDDL SQL SELECT query string to DataAdapter
        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)



        total = total + dt.Rows(n)(2)
        If dt.Rows(n)(2) = 0 Then
            tests = tests - 1
        End If
        lstStudentResults.Items.Add(String.Format(fmtstr, globalvariables.Topics(n + 1), dt.Rows(n)(2)))
        n = n + 1
        lblName.Text = dt.Rows(0)(0) + " " + dt.Rows(0)(1)
        If n = 10 Then
            average = total / tests
            weak = 10
            For cnt = 0 To 9
                If weak > dt.Rows(cnt)(2) Then
                    weak = dt.Rows(cnt)(2)
                    y = cnt
                End If
            Next
            For cnt = 0 To 9
                If strength < dt.Rows(cnt)(2) Then
                    strength = dt.Rows(cnt)(2)
                    z = cnt
                End If
            Next
            lblStrength.Text = globalvariables.Topics(z + 1) & ": " & strength
            lblWeak.Text = globalvariables.Topics(y + 1) & ": " & weak
        End If
    End Sub

    Sub creategraph(ByVal strddl As String)
        'creates a bar chart to show the students scores

        'Moves data between program and database
        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        'Give strDDL SQL SELECT query string to DataAdapter
        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)

        ChartResults.Series("Scores").Points.AddXY(globalvariables.Topics(s + 1), dt.Rows(s)(0))
        s = s + 1
        ChartResults.ChartAreas("ChartArea1").AxisX.Interval = 1
    End Sub

    Private Sub btnViewGraph_Click(sender As Object, e As EventArgs) Handles btnViewGraph.Click
        Dim strDDl As String
        Do Until s = 10
            strDDl = "SELECT Score FROM tblStudentScores WHERE ID = " & globalvariables.StuID & ";" 'selects all of the students scores
            creategraph(strDDl)
        Loop
        lstStudentResults.Visible = False
        ChartResults.Visible = True
        btnViewGraph.Visible = False
    End Sub


    Private Sub RunCMD(ByVal strDDL As String, ByRef CON As OleDbConnection)

        Dim CMD As New OleDbCommand(strDDL, CON)
        Try

            CMD.ExecuteNonQuery()
            MessageBox.Show("Succeeded")
        Catch ex As Exception

            MessageBox.Show("Failed:" & vbCrLf & ex.Message)
        Finally
            CMD.Dispose()
        End Try
    End Sub

End Class