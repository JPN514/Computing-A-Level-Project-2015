Imports System.Data.OleDb

Public Class Student_Menu
    Dim i As Integer

    Private Sub Student_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
        txtID.Text = globalvariables.StuID
    End Sub

    Private Sub btnStuMenuBack_Click(sender As Object, e As EventArgs) Handles btnStuMenuBack.Click
        Me.Close()
        LoginMenu.Show()
    End Sub

    Private Sub btnStuTest_Click(sender As Object, e As EventArgs) Handles btnStuTest.Click
        If cbmTests.SelectedItem = "" Then
            MsgBox("Select a test")
        Else
            i = cbmTests.SelectedIndex
            CheckTest()
        End If
       
    End Sub

    Sub CheckTest()
        'checks if the test has been set by the teacher 
        Dim strDDl As String
        strDDl = "SELECT Active FROM tblTopics WHERE TopicNo = " & i + 1 & ""
        runCommand(strDDl)
    End Sub



    Private Sub btnStuScores_Click(sender As Object, e As EventArgs) Handles btnStuScores.Click
        Student_ViewResults.ShowDialog()
        Me.Show()
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
        If dt.Rows(0)(0) = 0 Then
            MessageBox.Show("The test has not been set by your teacher.")
        Else
            globalvariables.QuestionForm(i + 1).ShowDialog()
            Me.Show()
        End If


        CON.Close()
        CON.Dispose()
    End Sub

    Private Sub btnMM_Click(sender As Object, e As EventArgs) Handles btnMM.Click
        TMM.ShowDialog()
        Me.Show()
    End Sub
End Class