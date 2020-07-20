Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Student_ViewResults

    'allows students to view their own individual scores

    Dim n As Integer = 0 'count to insert scores into listbox
    Dim s As Integer = 0 'index used to add data to the graph
    Dim fmtstr As String = "{0,-25} {1,-5}"
    Dim scores(10) As Integer

    Private Sub Student_ViewResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStudentID.Text = globalvariables.StuID
        btnStuSeeGraph.Visible = True
        btnViewResults.Visible = True

    End Sub

    Private Sub btnViewResults_Click(sender As Object, e As EventArgs) Handles btnViewResults.Click
        lstStudentResults.Items.Clear()
        n = 0
        lstStudentResults.Visible = True
        ShowResults()
        btnViewResults.Visible = False
        ChartResults.Visible = False
        btnStuSeeGraph.Visible = True
    End Sub

    Sub ShowResults()
        'selects all of the students scores
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



        lstStudentResults.Items.Add(String.Format(fmtstr, globalvariables.Topics(n + 1), dt.Rows(n)(2)))
        n = n + 1
        ' displays the name of the student
        lblName.Text = dt.Rows(0)(0) + " " + dt.Rows(0)(1)

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

    


    Sub creategraph(ByVal strddl As String)

        'creates the graph of the students results

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

    Private Sub btnStuSeeGraph_Click(sender As Object, e As EventArgs) Handles btnStuSeeGraph.Click
        Dim strDDl As String
        Do Until s = 10
            strDDl = "SELECT Score FROM tblStudentScores WHERE ID = " & globalvariables.StuID & ";"
            creategraph(strDDl)
        Loop
        lstStudentResults.Visible = False
        ChartResults.Visible = True
        btnStuSeeGraph.Visible = False
        btnViewResults.Visible = True
    End Sub
End Class