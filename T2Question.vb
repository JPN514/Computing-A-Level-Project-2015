Imports System.Data.OleDb
Public Class T2Question

    'question form for averages topic

    Dim score As Integer
    Dim answer As Single
    Dim data(6) As Integer
    Dim i, n As Integer
    Dim mean, mode, median, range As Single
    Dim complete As Boolean
    Dim questions(4) As String
    Dim t As Integer = 1

    

    Private Sub T2Question_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetQuestion()
        GetNumbers()
        DisplayQuestion()
        'lbltest.Text = answer
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


        questions(t) = dt.Rows(t - 1)(0).ToString
        t = t + 1
        DisplayQuestion()
        CON.Close()
        CON.Dispose()
    End Sub

    Sub DisplayQuestion()
        Dim a As Integer
        Randomize()
        a = CInt(Math.Floor((4 - 1 + 1) * Rnd())) + 1
        lblT2Question.Text = questions(a)
    End Sub

    Sub GetQuestion()
        'selects the question form the database
        Dim strDDL As String

        strDDL = "SELECT DISTINCT Question FROM tblQuestions WHERE TopicNo = 2;"
        Do Until t > 3
            runCommand(strDDL)
        Loop
    End Sub

    Sub GetNumbers()
        'gets the randomized numbers 
        Dim upperbound As Integer = 10
        Dim lowerbound As Integer = 1
        Randomize()
        mean = median = range = mode = 0
        Do Until mean <> median And mean <> range And mean <> mode And median <> range And median <> mode And range <> mode And data(6) <> 0
            For cnt = 0 To 6

                data(cnt) = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            Next
            Calc_Answer()
        Loop

        lblData.Text = "Data: "
        For cnt = 0 To 6
            lblData.Text = lblData.Text & data(cnt) & ", "
        Next

    End Sub

    Sub Calc_Answer()
        'mean calculation
        Dim total As Integer = 0
        Dim mean1 As Single
        For cnt = 0 To 6
            total = total + data(cnt)
        Next
        mean1 = total / 7
        mean = Math.Round(mean1, 2)
        lblmean.Text = mean
        lblTotal.Text = total

        'range calculation
        Dim high, low As Integer
        high = 0
        For cnt = 0 To 6
            If data(cnt) > high Then
                high = data(cnt)
            End If
        Next
        low = 10
        For cnt = 0 To 6
            If data(cnt) < low Then
                low = data(cnt)
            End If
        Next
        range = high - low
        lblrange.Text = range

        'median calculation
        Dim temp As Integer
        Dim p As Integer
        i = 0
        Do Until p = (7 * (7 - 1)) / 2
            If data(i) > data(i + 1) Then
                temp = data(i)
                data(i) = data(i + 1)
                data(i + 1) = temp
            End If
            If i = 5 Then
                i = 0
            Else
                i = i + 1
            End If
            p = p + 1
        Loop
        median = data(3)
        lblmedian.Text = median

        'mode calculation

        Dim modal(2) As Integer
        Dim temp2 As Integer
        Dim count(6) As Integer
        For a = 0 To 6
            temp2 = data(a)
            data(a) = data(0)
            data(0) = temp2
            For b = 1 To 6
                If data(0) = data(b) Then
                    modal(0) = data(b)
                    count(a) = count(a) + 1
                End If
            Next
        Next

        For p = 0 To 6
            If modal(0) <> Nothing Then
                If count(p) > modal(0) Then
                    modal(0) = count(p)
                ElseIf count(p) = modal(0) Then
                    modal(1) = count(p)
                End If
            ElseIf modal(1) <> Nothing Then
                If count(p) > modal(2) Then
                    modal(2) = count(p)
                End If
            End If
        Next

        If modal(0) > modal(1) And modal(0) > modal(2) Then
            modal(0) = modal(0)
        ElseIf modal(1) > modal(0) And modal(1) > modal(2) Then
            modal(0) = modal(1)
        ElseIf modal(2) > modal(0) And modal(2) > modal(1) Then
            modal(0) = modal(2)
        End If

        lblmode.Text = "Mode: " & modal(0)
        mode = modal(0)
        'mode = modal(0) & ", " & modal(1) & ", " & modal(2)
        'lblmode.Text = modal(0) & ", " & modal(1) & ", " & modal(2)
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
        If compare = mode Or compare = mean Or compare = median Or compare = range Or compare = mode Then
            score = score + 1
            MsgBox("Correct answer")
        Else
            MsgBox("Incorrect, right answer is: " & answer)
        End If
    End Sub

    Private Sub btnCheckAnswer_Click(sender As Object, e As EventArgs) Handles btnCheckAnswer.Click

        If txtAnswer.Text = "" Then 'checks if an answer is entered
            MsgBox("Enter an answer") 'if not the student is prompted to enter an answer
        Else
            CheckAnswer()
            If n < 2 Then
                lblT2Question.Text = ""
                txtAnswer.Text = ""
                n = n + 1
                For cnt = 0 To 6
                    data(cnt) = 0
                Next
                lblData.Text = ""
                DisplayQuestion()
                GetNumbers()

                lblmedian.Text = median
                lblmean.Text = mean
                lblrange.Text = range

            Else
                complete = True
            End If
        End If
        If complete = True Then
            MsgBox("You scored: " & score)
            Dim strDbname As String = "Student_Details.mdb"
            CompleteT2()
            Me.Close()
            Student_Menu.Show()
        End If
    End Sub

    Sub CompleteT2()
        Dim strTableName As String = "tblStudentScores"
        Dim column As String = "Score"
        Dim strddl As String
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        strddl = "UPDATE tblStudentScores SET " & column & " = " & score & " WHERE ID = " & globalvariables.StuID & " AND TopicNo = 2"
        RunCMD(strddl, CON)
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