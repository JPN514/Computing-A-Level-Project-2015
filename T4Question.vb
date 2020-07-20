Imports System.Data.OleDb
Public Class T4Question
    'Question form for rounding topic

    Dim score As Integer = 0
    Dim n As Integer = 0
    Dim answer As Single
    Dim complete As Boolean
    Dim random As Single
    Dim i As Integer
    Dim places As Integer

    Private Sub T4Question_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetQuestion()
        GetNumbers()
        Calc_Answer()
        lblAnswer.Text = answer
    End Sub

    Sub GetQuestion()
        'select statement for question from database
        Dim strDDL As String

        strDDL = "SELECT Question FROM tblQuestions WHERE TopicNo = 4;"
        runCommand(strDDL)
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
        lblT4Question.Text = dt.Rows(0)(0)
        CON.Close()
        CON.Dispose()
    End Sub

    Sub GetNumbers()
        Dim upperbound As Integer = 3
        Dim lowerbound As Integer = 1
        Randomize()
        'gets the number to be rounded
        random = VBMath.Rnd((upperbound - lowerbound + 1) * Rnd()) + lowerbound
        lblRandomNo.Text = random
        'gets the number of decimal places it needs to be rounded to 
        places = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        lblPlaces.Text = places
    End Sub

    Sub Calc_Answer()
        answer = Math.Round(random, places)
    End Sub

    Sub CheckAnswer()
        Dim compare As Single
        Dim ans As String = ""
        Dim valid As Boolean = False
        Do Until valid = True And ans = txtAnswer.Text
            Try
                ans = txtAnswer.Text
                valid = True
            Catch ex As Exception
                MessageBox.Show("Please enter an answer")
                valid = False
            End Try
        Loop
        compare = Convert.ToSingle(ans)
        If compare = answer Then
            score = score + 1
            MsgBox("Correct answer")
        Else
            MsgBox("Incorrect, right answer is: " & answer)
        End If
    End Sub

    Sub CompleteT4()
        Dim column As String = "Score"
        Dim strTableName As String = "tblStudentScores"
        Dim strddl As String
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        strddl = "UPDATE tblStudentScores SET " & column & " = " & score & " WHERE ID = " & globalvariables.StuID & " AND TopicNo = 4"
        RunCMD(strddl, CON)
        CON.Close()
        CON.Dispose()
    End Sub

    Private Sub btnT4CheckAnswer_Click(sender As Object, e As EventArgs) Handles btnT4CheckAnswer.Click

        If txtAnswer.Text = "" Then 'checks if an answer is entered
            MsgBox("Enter an answer") 'if not the student is prompted to enter an answer
        Else
            CheckAnswer()
            If n < 0 Then
                lblT4Question.Text = ""
                txtAnswer.Text = ""
                n = n + 1
                GetQuestion()
                GetNumbers()
                Calc_Answer()
                'lbltest.Text = answer
            Else
                complete = True
            End If
        End If
        If complete = True Then
            MsgBox("You scored: " & score)
            Dim strDbname As String = "Student_Details.mdb"
            CompleteT4()
            Me.Close()
            Student_Menu.Show()
        End If
    End Sub

    Private Sub RunCMD(ByVal strDDL As String, ByRef CON As OleDbConnection)
        'create command object
        Dim CMD As New OleDbCommand(strDDL, CON)
        Try
            'run command if syntax correct:
            CMD.ExecuteNonQuery()
            'MessageBox.Show("Succeeded")
        Catch ex As Exception
            'otherwise show error message:
            MessageBox.Show("Failed:" & vbCrLf & ex.Message)
        Finally
            CMD.Dispose()
        End Try
    End Sub
End Class