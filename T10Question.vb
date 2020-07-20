Imports System.Data.OleDb
Public Class T10Question

    'Question form for sequences topic

    Dim score As Integer = 0
    Dim n, i As Integer
    Dim answer As Single
    Dim complete As Boolean
    Dim Questions(2) As String
    Dim t As Integer = 1
    Dim a As Integer
    Dim term As Integer

    Private Sub T10Question_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim seq As String = ""

        Dim q As Integer = 1


        Do Until q = 10
            seq = seq + ", " + Fib(q).ToString
            q = q + 1
        Loop
        lblTest.Text = ""

        lblFib.Text = seq
        GetQuestion()
        DisplayQuestion()
        GetNumbers()
        Calc_Answer()

    End Sub

    Function Fib(ByVal num As Integer) As Integer
        'Fibonacci sequence
        'using Fn = Fn-1 + fn-2
        '

        If num < 2 Then
            Return num
        Else
            Return Fib(num - 1) + Fib(num - 2) 'generates next term
        End If

    End Function

    Sub GetQuestion()
        'selects the question from the database
        Dim strDDL As String
        strDDL = "SELECT Question FROM tblQuestions WHERE TopicNo = 10;"
        Do Until t > 2
            runCommand(strDDL)
        Loop
    End Sub

    Sub DisplayQuestion()
        'displays the randomized question
        Randomize()
        a = CInt(Math.Floor((2 - 1 + 1) * Rnd())) + 1
        lblT10Question.Text = Questions(a)
    End Sub

    Sub Calc_Answer()
        If i = 1 And a = 1 Then
            lblRnd.Text = term
            answer = Fib(term)
        ElseIf i = 2 And a = 2 Then
            lblRnd.Text = Fib(term)
            answer = term
        End If
        lblTest.Text = answer
    End Sub

    Sub GetNumbers()
        Dim upperbound As Integer = 2
        Dim lowerbound As Integer = 1
        Dim uTerm As Integer = 9
        Dim lTerm As Integer = 4
        Randomize()
        i = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        'i=1 find term, i=2 find n
        term = CInt(Math.Floor((uTerm - lTerm + 1) * Rnd())) + lTerm
        'lblRnd.Text = term
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

    Sub CompleteT10()
        Dim strTableName As String = "tblStudentScores"
        Dim column As String = "Score"
        Dim strddl As String
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        strddl = "UPDATE tblStudentScores SET " & column & " = " & score & " WHERE ID = " & globalvariables.StuID & " AND TopicNo = 10"
        RunCMD(strddl, CON)
        CON.Close()
        CON.Dispose()

    End Sub

    Private Sub btnT10CheckAnswer_Click(sender As Object, e As EventArgs) Handles btnT10CheckAnswer.Click

        If txtAnswer.Text = "" Then 'checks if an answer is entered
            MsgBox("Enter an answer") 'if not the student is prompted to enter an answer
        Else
            CheckAnswer()

            If n < 1 Then
                lblT10Question.Text = ""
                txtAnswer.Text = ""
                lblTest.Text = ""
                n = n + 1
                DisplayQuestion()
                GetNumbers()
                Calc_Answer()
                lblTest.Text = answer
            Else
                complete = True
            End If
        End If

        If complete = True Then
            Dim strDbname As String = "Student_Details.mdb"
            CompleteT10()
            Me.Close()
            Student_Menu.Show()
        End If
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


        Questions(t) = dt.Rows(t - 1)(0).ToString
        t = t + 1
        DisplayQuestion()
        CON.Close()
        CON.Dispose()
    End Sub

    Private Sub RunCMD(ByVal strddl As String, ByRef CON As OleDbConnection)
        'create command object
        Dim CMD As New OleDbCommand(strddl, CON)
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