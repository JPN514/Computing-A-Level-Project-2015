Imports System.Data.OleDb
Public Class AddQuestion

    'Allows teachers to add questions to the questions database

    Dim count As Integer


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

    Sub GetQuestions()
        'counts the number of questions already in the database
        'select statement
        Dim strDDl As String
        strDDl = "SELECT MAX(QuestionNo) FROM tblQuestions;"
        GetQuestions2(strDDl)
    End Sub

    Sub GetQuestions2(ByVal strddl As String)
        'returns the number of qusetions in the database
        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()

        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)
        count = dt.Rows(0)(0)
    End Sub

    Private Sub btnAddQ_Click(sender As Object, e As EventArgs) Handles btnAddQ.Click
        If txtNewQ.Text = "" Or txtNewA.Text = "" Or cmbTopic.SelectedIndex < 0 Then
            MsgBox("You must enter all required information")
        Else
            AddQuestion()
            GetQuestions()
        End If
       
    End Sub

    Sub AddQuestion()
        'adds the teachers new question to the database
        Dim topic As String
        Dim i As Integer
        topic = cmbTopic.Text
        i = cmbTopic.SelectedIndex 'the topic
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        Dim strDDl As String

        CON.Open()
        strDDl = "INSERT INTO tblQuestions values (" & count + 1 & ", '" & i + 1 & "', '" & txtNewQ.Text & "', '" & txtNewA.Text & "')"
        RunCMD(strDDl, CON)
        CON.Close()
        CON.Dispose()
    End Sub

    Private Sub AddQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetQuestions()
    End Sub
End Class