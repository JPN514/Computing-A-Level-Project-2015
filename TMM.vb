Imports System.Data.OleDb
Public Class TMM

    Dim timeleft As Integer
    Dim No1, No2 As Decimal
    Dim score As Integer
    Dim answer As Decimal
    Dim op As Integer '1 addition, 2 subtraction, 3 multiplication, 4 division
    Dim answered As Boolean
    Dim question As Integer = 0
    Dim score1 As Integer


    Private Sub TMM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetScore()
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
        score1 = dt.Rows(0)(0)
        CON.Close()
        CON.Dispose()
        lblPreviousScore.Text = "Your best score: " & score1

    End Sub

    Sub GetScore()
        'selects the question from the database
        Dim strDDL As String

        strDDL = "SELECT Score FROM tblStudentScores WHERE TopicNo = 11 AND ID = " & globalvariables.StuID & ";"
        runCommand(strDDL)
    End Sub

    Sub start()
        timeleft = 120
        timer.Enabled = True
        question = 0
        
        btnStart.Visible = False
        btnCheckAnswer.Visible = True
        lblPreviousScore.Visible = False
        lblNo1.Visible = True
        lblNo2.Visible = True
        lblOp.Visible = True
        txtAnswer.Visible = True
        Label1.Visible = True
        Label4.Visible = True
    End Sub



    Sub GetNumbers()
        Dim upperbound, lowerbound, bound As Integer

        op = CInt(Math.Floor((4 - 1 + 1) * Rnd())) + 1

        If op = 1 Then
            'addition
            upperbound = 100
            lowerbound = 2
            No1 = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            No2 = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            lblNo1.Text = No1
            lblNo2.Text = No2
            lblOp.Text = "+"
        ElseIf op = 2 Then
            'subtraction
            upperbound = 100
            lowerbound = 2
            No1 = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            No2 = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            lblNo1.Text = No1
            lblNo2.Text = No2
            lblOp.Text = "-"
        ElseIf op = 3 Then
            'multiplication
            upperbound = 150
            lowerbound = 2
            bound = 15
            No1 = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            No2 = CInt(Math.Floor((bound - lowerbound + 1) * Rnd())) + lowerbound
            lblNo1.Text = No1
            lblNo2.Text = No2
            lblOp.Text = "x"
        ElseIf op = 4 Then
            'division
            upperbound = 150
            lowerbound = 2
            bound = 15
            Do Until Math.Floor(No1 / No2) = Math.Ceiling(No1 / No2)
                No1 = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
                No2 = CInt(Math.Floor((bound - lowerbound + 1) * Rnd())) + lowerbound
            Loop
            lblNo1.Text = No1
            lblNo2.Text = No2
            lblOp.Text = "÷"
        End If


    End Sub

    Sub Calc_Answer()
        If op = 1 Then
            answer = No1 + No2
        ElseIf op = 2 Then
            answer = No1 - No2
        ElseIf op = 3 Then
            answer = No1 * No2
        ElseIf op = 4 Then
            answer = No1 / No2
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick


        timeleft -= 1
        lblTime.Text = timeleft

        If timeleft < 0 Then
            timer.Stop()
            MsgBox("You scored: " & score)
            timeup()
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        start()

        GetNumbers()
        Calc_Answer()

    End Sub

    Sub CheckAnswer()
        Dim compare As Single
        Dim ans As String = ""

        ans = txtAnswer.Text
        compare = Convert.ToSingle(ans)

        If compare = answer Then
            score = score + 1
        End If
        question += 1
        lblQ.Text = question
        lblScore.Text = score
        txtAnswer.Text = ""

        GetNumbers()
        Calc_Answer()
    End Sub

    Private Sub btnCheckAnswer_Click(sender As Object, e As EventArgs) Handles btnCheckAnswer.Click
        If txtAnswer.Text = "" Then
            GetNumbers()
            Calc_Answer()
            question += 1
            Label3.Visible = True
            lblQ.Visible = True
            lblScore.Visible = True
            lblQ.Text = question
            lblScore.Text = score
            txtAnswer.Text = ""
        Else
            Label3.Visible = True
            lblQ.Visible = True
            lblScore.Visible = True
            CheckAnswer()
        End If

    End Sub

    Sub timeup()
        Dim strTableName As String = "tblStudentScores"
        Dim column As String = "Score"
        Dim strddl As String
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        If score > score1 Then
            CON.Open()
            strddl = "UPDATE tblStudentScores SET " & column & " = " & score & " WHERE ID = " & globalvariables.StuID & " AND TopicNo = 11"
            RunCMD(strddl, CON)
            CON.Close()
            CON.Dispose()
        End If
        Me.Close()
        Student_Menu.Show()
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