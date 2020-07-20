Imports System.Data.OleDb



Public Class LoginMenu
    Dim teachers As Boolean
    Dim count As Integer
    Dim validID As Boolean
    

    Private Sub btnMenuStu_Click(sender As Object, e As EventArgs) Handles btnMenuStu.Click
        Try
            globalvariables.StuID = txtStuID.Text
        Catch ex As Exception

        End Try
        CheckID()
        lblID.Text = globalvariables.StuID
    End Sub

    Private Sub btnMenuTe_Click(sender As Object, e As EventArgs) Handles btnMenuTe.Click
        checkteacher()
    End Sub

    Sub CheckTeachers()
        'checks if there are teachers in the database
        Dim strDDl As String
        strDDl = "SELECT COUNT(ID) FROM tblTeacherDetails"
        CheckTeachers2(strDDl)
    End Sub

    Sub CheckTeachers2(ByVal strddl As String)

        'determines if any teachers are in the database

        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        'Give strDDL SQL SELECT query string to DataAdapter
        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)
        If dt.Rows(0)(0) > 0 Then
            count = dt.Rows(0)(0)
            teachers = True
        Else
            teachers = False
        End If

        CON.Close()
        CON.Dispose()

    End Sub

    Sub CheckID()
        Dim valid As Boolean = False
        Dim strDDL As String
        Dim id As Integer = globalvariables.StuID
            Try
                globalvariables.StuID = txtStuID.Text
                strDDL = "SELECT ID FROM tblStudentDetails WHERE ID = " & id & ";"
                runCommand(strDDL)

                Me.Hide()
                Student_Menu.ShowDialog()
                Me.Show()
            Catch ex As Exception
                MessageBox.Show("Invalid Student ID please re-enter")
            End Try
    End Sub

    Sub checkteacher()
        ' checks if the teachers id and password are correct
        Dim strDDL As String
        strDDL = "SELECT DISTINCT ID FROM tblTeacherDetails;"
        checkTeacherId(strDDL)
        If validID = False Then
            MsgBox("Invalid ID")
        Else
            strDDL = "Select PW FROM tblTeacherDetails WHERE ID = '" & txtTeaID.Text & "';"
            checkTeacherpassword(strDDL)
        End If

    End Sub

    Sub checkTeacherId(ByVal strddl As String)
        'checks for a valid teacher ID

        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        'Give strDDL SQL SELECT query string to DataAdapter
        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)

        For a = 0 To count - 1
            If txtTeaID.Text = dt.Rows(a)(0) Then
                validID = True
            End If
        Next
    End Sub

    Sub checkTeacherpassword(ByVal strddl As String)
        'checks if the password is correct

        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        'Give strDDL SQL SELECT query string to DataAdapter
        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)


        If txtPassword.Text = dt.Rows(0)(0).ToString Then
            Teacher_Menu.ShowDialog()
            Me.Show()
        Else
            MsgBox("Invalid Password")
        End If

        CON.Close()
        CON.Dispose()
    End Sub

    Sub runCommand(ByVal strddl As String)
        'Moves data between program and database
        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        'Give strDDL SQL SELECT query string to DataAdapter
        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)
        globalvariables.StuID = dt.Rows(0)(0).ToString

        CON.Close()
        CON.Dispose()
    End Sub

    Sub CreateTables_Student(ByVal strDBname As String)
        'creates the student details table
        Dim strTableName As String = "tblStudentDetails"
        Dim strDDL As String
        'create and open connection object:
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strDBname)
        CON.Open()
        ' create  SQL DDl command to create table tblStudentDetails.  
        strDDL = "DROP TABLE tblStudentDetails;"
        RunCMD(strDDL, CON)
        strDDL = "CREATE TABLE tblStudentDetails(ID INTEGER NOT NULL PRIMARY KEY, FirstName VARCHAR(15), Surname VARCHAR(15), DOB DATE, YearGroup INTEGER, TeacherID VARCHAR(15), FOREIGN KEY(TeacherID) references tblTeacherDetails(TeacherID));"
        'call procedure to run the sql command using DDL script:
        RunCMD(strDDL, CON)
        
        strDDL = "CREATE TABLE tblTeacherDetails(TeacherID VARCHAR(20) NOT NULL PRIMARY KEY, ID VARCHAR(15), Pw VARCHAR(15), FirstName VARCHAR(15), Surname VARCHAR(15));"
        RunCMD(strDDL, CON)



        'tidy up:
        CON.Close()
        CON.Dispose()
    End Sub

    Sub CreateTables_StudentScores(ByVal strDBname As String)
        'creates the student scores table
        Dim strTableName As String = "tblStudentScores"
        Dim strDDL As String
        'create and open connection object:
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strDBname)
        CON.Open()
        ' create  SQL DDl command to create table tblStudentDetails.  
        strDDL = "DROP TABLE tblStudentScores;"
        RunCMD(strDDL, CON)
        strDDL = "CREATE TABLE tblStudentScores(ID INTEGER, TopicNo INTEGER, Score INTEGER, primary key(ID, TopicNO), FOREIGN KEY(ID) references tblStudentDetails(ID), FOREIGN KEY(TopicNO) references tblTopics(TopicNo));"
        RunCMD(strDDL, CON)
       
        CON.Close()
        CON.Dispose()
    End Sub

    Sub CreateTable_Topics(ByVal strDBname As String)
        'creates the topics table
        Dim strTableName As String = "tblTopics"
        Dim strDDL As String
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strDBname)
        CON.Open()
        ' create SQL DDL command to create table tblTopics
        
        strDDL = "CREATE TABLE tblTopics(TopicNo INTEGER NOT NULL PRIMARY KEY, Topic_name VARCHAR(15));"
        RunCMD(strDDL, CON)
        strDDL = "ALTER TABLE tblTopics ADD Active BIT"
        RunCMD(strDDL, CON)
        strDDL = "INSERT INTO tblTopics VALUES (1, 'Pythagoras', 0)"
        RunCMD(strDDL, CON)
        strDDL = "INSERT INTO tblTopics VALUES (2, 'Averages', 0)"
        RunCMD(strDDL, CON)
        strDDL = "INSERT INTO tblTopics VALUES (3, 'Equations', 0)"
        RunCMD(strDDL, CON)
        strDDL = "INSERT INTO tblTopics VALUES (4, 'Rounding', 0)"
        RunCMD(strDDL, CON)
        strDDL = "INSERT INTO tblTopics VALUES (5, 'Angles', 0)"
        RunCMD(strDDL, CON)
        strDDL = "INSERT INTO tblTopics VALUES (6, 'Trigonometry', 0)"
        RunCMD(strDDL, CON)
        strDDL = "INSERT INTO tblTopics VALUES (7, 'Graphs', 0)"
        RunCMD(strDDL, CON)
        strDDL = "INSERT INTO tblTopics VALUES (8, 'Probability', 0)"
        RunCMD(strDDL, CON)
        strDDL = "INSERT INTO tblTopics VALUES (9, 'Measurement', 0)"
        RunCMD(strDDL, CON)
        strDDL = "INSERT INTO tblTopics VALUES (10, 'Sequences', 0)"
        RunCMD(strDDL, CON)
        strDDL = "INSERT INTO tblTopics VALUES (11, 'Mental Maths', 0)"
        RunCMD(strDDL, CON)
        strDDL = "CREATE TABLE tblQuestions(QuestionNo INTEGER PRIMARY KEY, TopicNo INTEGER, Question VARCHAR(250), Answer VARCHAR(100), FOREIGN KEY(TopicNo) references tblTopics(TopicNo));"
        RunCMD(strDDL, CON)
        CON.Close()
        CON.Close()
        CON.Dispose()

    End Sub

   


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'creates the topics database
        Dim strDBName As String = "Student_Details.mdb"

        Dim CAT As New ADOX.Catalog()
        Try
            CAT.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strDBName)
            MessageBox.Show("Succeeded")
        Catch ex As Exception
            MessageBox.Show("Failed:" & vbCrLf & ex.Message)
        Finally
            CAT = Nothing
        End Try
        CreateTable_Topics(strDBName)

    End Sub


    Private Sub RunCMD(ByVal strDDL As String, ByRef CON As OleDbConnection)
        'create command object
        Dim CMD As New OleDbCommand(strDDL, CON)
        Try
            'run command if syntax correct:
            CMD.ExecuteNonQuery()
            MessageBox.Show("Succeeded")
        Catch ex As Exception
            'otherwise show error message:
            MessageBox.Show("Failed:" & vbCrLf & ex.Message)
        Finally
            CMD.Dispose()
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'creates the student details database (details table)
        Dim strDBName As String = "Student_Details.mdb"

        Dim CAT As New ADOX.Catalog()
        Try
            CAT.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strDBName)
            MessageBox.Show("Succeeded")
        Catch ex As Exception
            MessageBox.Show("Failed:" & vbCrLf & ex.Message)
        Finally
            CAT = Nothing
        End Try
        CreateTables_Student(strDBName)
    End Sub



    Private Sub LoginMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckTeachers()

        If teachers = False Then
            Newteachers.ShowDialog()
        Else

            globalvariables.Topics(1) = "Pythagoras"
            globalvariables.Topics(2) = "Averages"
            globalvariables.Topics(3) = "Equations"
            globalvariables.Topics(4) = "Rounding"
            globalvariables.Topics(5) = "Angles"
            globalvariables.Topics(6) = "Trigonometry"
            globalvariables.Topics(7) = "Graphs"
            globalvariables.Topics(8) = "Probability"
            globalvariables.Topics(9) = "Measurement"
            globalvariables.Topics(10) = "Sequences"

            globalvariables.QuestionForm(1) = T1Question
            globalvariables.QuestionForm(2) = T2Question
            'globalvariables.QuestionForm(3) = T3Question
            globalvariables.QuestionForm(4) = T4Question
            globalvariables.QuestionForm(5) = T5Question
            globalvariables.QuestionForm(6) = T6Question
            globalvariables.QuestionForm(7) = T7Question
            'globalvariables.QuestionForm(8) = T8Question
            globalvariables.QuestionForm(9) = T9Question
            globalvariables.QuestionForm(10) = T10Question
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'creates the student details database (scores table)
        Dim strDBName As String = "Student_Details.mdb"

        Dim CAT As New ADOX.Catalog()
        Try
            CAT.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strDBName)
            MessageBox.Show("Succeeded")
        Catch ex As Exception
            MessageBox.Show("Failed:" & vbCrLf & ex.Message)
        Finally
            CAT = Nothing
        End Try
        CreateTables_StudentScores(strDBName)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'creates set tests part of the topics database
        Dim strDBName As String = "Topics.mdb"

        Dim CAT As New ADOX.Catalog()
        Try
            CAT.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strDBName)
            MessageBox.Show("Succeeded")
        Catch ex As Exception
            MessageBox.Show("Failed:" & vbCrLf & ex.Message)
        Finally
            CAT = Nothing
        End Try

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblInfo.Click

    End Sub
End Class
Public Class globalvariables
    Public Shared SetTest As Boolean
    Public Shared testNo As Integer
    Public Shared StuID As Integer
    Public Shared Topics(10) As String
    Public Shared chosenClass As String
    Public Shared QuestionForm(10) As Form
    Public Shared StudentName(1) As String
    Public Shared teacherID As String
End Class

Public NotInheritable Class Graphics
    Inherits MarshalByRefObject
    'Implements IDeviceContext, IDisposable

    Shared Function FromHwnd(intPtr As IntPtr) As Graphics
        Throw New NotImplementedException
    End Function

End Class