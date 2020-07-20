Imports System.Data.OleDb
Public Class T1Question
    'Question form for pythagoras topic

    Dim i As Integer
    Dim a, b, c, n As Integer
    Dim score As Integer = 0
    Dim answer As Single
    Dim complete As Boolean
    Dim valid As Boolean = False

    Sub runCommand(ByVal strddl As String)
        'Moves data between program and database
        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        'Give strDDL SQL SELECT query string to DataAdapter
        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)
        lblT1Question.Text = dt.Rows(0)(0)
        CON.Close()
        CON.Dispose()

    End Sub

    Sub GetQuestion()
        'selects the question from the database
        Dim strDDL As String

        strDDL = "SELECT Question FROM tblQuestions WHERE TopicNo = 1;"
        runCommand(strDDL)
    End Sub

    Sub Calc_Answer()
        'calculates the length of the missing side
        answer = 0
        If i = 3 Then 'hypotenuse
            c = a ^ 2 + b ^ 2
            answer = Math.Sqrt(c)
        ElseIf i = 2 Then
            b = c ^ 2 - a ^ 2
            answer = Math.Sqrt(b)
        ElseIf i = 1 Then
            a = c ^ 2 - b ^ 2
            answer = Math.Sqrt(a)
        End If
        answer = Math.Round(answer, 2)
    End Sub

    Sub GetNumbers()
        'gets the randomized side lengths 
        'gets which side is to be found
        Dim upperbound As Integer = 3
        Dim lowerbound As Integer = 1
        Dim uboundSide As Integer = 9
        Dim lboundSide As Integer = 2
        Randomize()
        i = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        If i = 1 Then
            lblT1RndSide.Text = "a"
        ElseIf i = 2 Then
            lblT1RndSide.Text = "b"
        ElseIf i = 3 Then
            lblT1RndSide.Text = "c"
        End If

        If i = 3 Then
            a = CInt(Math.Floor((uboundSide - lboundSide + 1) * Rnd())) + lboundSide
            b = CInt(Math.Floor((uboundSide - lboundSide + 1) * Rnd())) + lboundSide
            lblT1side_a.Text = a
            lblT1side_b.Text = b
            lblT1side_c.Text = "c"
        ElseIf i = 2 Then
            Do Until c > a
                a = CInt(Math.Floor((uboundSide - lboundSide + 1) * Rnd())) + lboundSide
                c = CInt(Math.Floor((uboundSide - lboundSide + 1) * Rnd())) + lboundSide
                lblT1side_a.Text = a
                lblT1side_c.Text = c
                lblT1side_b.Text = "b"
            Loop
        ElseIf i = 1 Then
            Do Until c > b
                b = CInt(Math.Floor((uboundSide - lboundSide + 1) * Rnd())) + lboundSide
                c = CInt(Math.Floor((uboundSide - lboundSide + 1) * Rnd())) + lboundSide
                lblT1side_b.Text = b
                lblT1side_c.Text = c
                lblT1side_a.Text = "a"
            Loop
        End If

    End Sub

    Sub CheckAnswer()
        Dim compare As Single
        Dim ans As String = ""

        Try
            ans = txtAnswer.Text
            valid = True
        Catch ex As Exception
            MessageBox.Show("Please enter an answer")
        End Try


        compare = Convert.ToSingle(ans)
        If compare = answer Then
            score = score + 1
            MsgBox("Correct answer, Score is: " & score)
            GetQuestion()
            GetNumbers()
            Calc_Answer()
            a = 0
            b = 0
            c = 0
        Else
            MsgBox("Incorrect, right answer is: " & answer & " Your Score is: " & score)
            GetQuestion()
            GetNumbers()
            Calc_Answer()
            a = 0
            b = 0
            c = 0
        End If
    End Sub


    Private Sub T1Question_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = 0
        b = 0
        c = 0
        answer = 0
        GetQuestion()
        GetNumbers()
        Calc_Answer()
        lbltest.Text = answer
    End Sub

    Sub CompleteT1()
        Dim strTableName As String = "tblStudentScores"
        Dim column As String = "Score"
        Dim strddl As String
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        strddl = "UPDATE tblStudentScores SET " & column & " = " & score & " WHERE ID = " & globalvariables.StuID & " AND TopicNo = 1"
        RunCMD(strddl, CON)
        CON.Close()
        CON.Dispose()

    End Sub


    Private Sub btnT1CheckAnswer_Click(sender As Object, e As EventArgs) Handles btnT1CheckAnswer.Click

        If txtAnswer.Text = "" Then 'checks if an answer is entered
            MsgBox("Enter an answer") 'if not the student is prompted to enter an answer
        Else
            CheckAnswer()

            If n < 9 Then
                lblT1Question.Text = ""
                txtAnswer.Text = ""
                n = n + 1
                GetQuestion()
                lbltest.Text = answer
            Else
                complete = True
            End If
        End If

        If complete = True Then
            MsgBox("You scored: " & score)
            Dim strDbname As String = "Student_Details.mdb"
            CompleteT1()
            Me.Close()
            Student_Menu.Show()
        End If
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
