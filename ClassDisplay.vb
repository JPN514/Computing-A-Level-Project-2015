Imports System.Data.OleDb
Public Class ClassDisplay

    'displays class info to the teacher

    Dim fmtstr As String = "{0,-10} {1,-5} {2,5} {3,10} {4,15}"
    Dim fmtstr2 As String = "{0,-10} {1,15} {2,20}"
    Dim fmtstr3 As String = "{0,-10} {1,10}"
    Dim students As Integer

    Private Sub ClassDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnViewClass.Visible = True
        lstClass.Items.Clear()
        lblClass.Text = globalvariables.chosenClass
        GetStudents()
        GetScores()

    End Sub

    Sub GetData()
        'selects all of the classes data
        Dim strDDl As String
        strDDl = "SELECT * FROM tblStudentDetails WHERE TeacherID = '" & globalvariables.chosenClass & "';"
        GetClass(strDDl)
    End Sub

    Sub GetClass(ByVal strddl As String)

        'Moves data between program and database
        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        'Give strDDL SQL SELECT query string to DataAdapter
        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)
        lstClass.Items.Clear()
        lstClass.Items.Add(String.Format(fmtstr, "ID", "Name", "Surname", "YearGroup", "Class"))
        For n = 0 To students - 1
            lstClass.Items.Add(String.Format(fmtstr, dt.Rows(n)(0), dt.Rows(n)(1), dt.Rows(n)(2), dt.Rows(n)(4), dt.Rows(n)(5)))
        Next

    End Sub

    Sub GetStudents()
        'counts the number of students
        Dim strDDl As String
        strDDl = "SELECT COUNT(ID) FROM tblStudentDetails WHERE TeacherID = '" & globalvariables.chosenClass & "';"
        GetStudents2(strDDl)
    End Sub

    Sub GetStudents2(ByVal strddl As String)
        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        'Give strDDL SQL SELECT query string to DataAdapter
        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)
        students = dt.Rows(0)(0)
    End Sub

    Sub GetScores()
        'selects the scores of the students in the class
        Dim strDDl As String
        strDDl = "SELECT Score FROM tblStudentScores, tblStudentDetails WHERE tblStudentDetails.TeacherID = '" & globalvariables.chosenClass & "';"
        calc_average(strDDl)
    End Sub

    Sub calc_average(ByVal strddl As String)
        Dim total As Integer
        Dim average As Single
        Dim s As Integer
        'calculates the average score across all tests for the class

        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        'Give strDDL SQL SELECT query string to DataAdapter
        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)

        For cnt = 0 To students * 10 - students
            total = total + dt.Rows(cnt)(0)
        Next



        average = total / (students * 10)
        lblAverageScore.Text = average
    End Sub

    Sub GetMentalMaths()
        Dim strDDl As String
        strDDl = "SELECT tblStudentScores.ID, Score FROM tblStudentScores, tblStudentDetails WHERE tblStudentDetails.TeacherID = '" & globalvariables.chosenClass & "' AND TopicNo = 11;"

        GetMentalMaths2(strDDl)
    End Sub

    Sub GetMentalMaths2(ByVal strddl As String)
        Dim total As Integer
        Dim average As Single

        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        'Give strDDL SQL SELECT query string to DataAdapter
        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)

        lstClass.Items.Clear()
        lstClass.Items.Add(String.Format(fmtstr3, "ID", "Score"))

        For n = 0 To students
            lstClass.Items.Add(String.Format(fmtstr3, dt.Rows(n)(0), dt.Rows(n)(1)))
            total = total + dt.Rows(n)(1)
        Next

        lblMMAverage.Text = ""
        average = total / (students + 1)
        lblMMAverage.Text = average
    End Sub

    Sub DisplayScores()
        'displays the entire classes scores
        Dim strDDl As String
        lstClass.Items.Clear()
        lstClass.Items.Add(String.Format(fmtstr2, "ID", "Topic", "Score"))

        strDDl = "SELECT DISTINCT tblStudentScores.ID, TopicNo, Score FROM tblStudentScores, tblStudentDetails WHERE tblStudentDetails.TeacherID = '" & globalvariables.chosenClass & "' AND tblStudentScores.TopicNO <> 11;"
        DisplayScores2(strDDl)
    End Sub

    Sub DisplayScores2(ByVal strddl As String)
        'Moves data between program and database
        Dim s, n As Integer
        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        'Give strDDL SQL SELECT query string to DataAdapter
        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)

        For n = 0 To (students * 10) - 1
            lstClass.Items.Add(String.Format(fmtstr2, dt.Rows(n)(0), globalvariables.Topics(dt.Rows(n)(1)), dt.Rows(n)(2)))
        Next

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

    Private Sub btnViewStudent_Click(sender As Object, e As EventArgs) Handles btnViewStudent.Click
        Dim temp As String = ""
        If lstClass.SelectedItem = "" Then
            MsgBox("Select a student")
        Else
            For cnt = 0 To 5
                temp = temp + lstClass.SelectedItem(cnt)
            Next
            globalvariables.StuID = Convert.ToInt64(temp)
            GetName()
            DisplayStudent.ShowDialog()
            Me.Show()
        End If
        
    End Sub

    Sub GetName()
        Dim strDDl As String
        strDDl = "SELECT Firstname, Surname FROM tblStudentDetails WHERE ID = " & globalvariables.StuID & ";"
        GetName2(strDDl)
    End Sub

    Sub GetName2(ByVal strddl As String)
        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        'Give strDDL SQL SELECT query string to DataAdapter
        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)
        globalvariables.StudentName(0) = dt.Rows(0)(0)
        globalvariables.StudentName(1) = dt.Rows(0)(1)
    End Sub

    Private Sub btnViewClass_Click(sender As Object, e As EventArgs) Handles btnViewClass.Click
        GetData()
        btnViewStudent.Visible = True
        btnViewScores.Visible = True
        btnViewClass.Visible = False
        btnMM.Visible = True

    End Sub

    Private Sub btnViewScores_Click(sender As Object, e As EventArgs) Handles btnViewScores.Click
        lstClass.Items.Clear()
        DisplayScores()
        btnViewScores.Visible = False
        btnViewClass.Visible = True
        btnViewStudent.Visible = False
    End Sub

    Private Sub btnMM_Click(sender As Object, e As EventArgs) Handles btnMM.Click
        GetMentalMaths()
        btnMM.Visible = False
        btnViewStudent.Visible = False
    End Sub
End Class