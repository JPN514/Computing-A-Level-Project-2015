Imports System.Data.OleDb
'used by teachers to add details of students
Public Class Student_details
    Dim valid As Boolean = False

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        'validate entry
        If txtIDNo.Text = "" Or txtFirstName.Text = "" Or txtSurname.Text = "" Or txtClass.Text = "" Then
            MsgBox("Ensure all fileds contain information")
        Else
            addStudentDetails()
            MsgBox("Student Added: " & txtFirstName.Text & " " & txtSurname.Text)
        End If

    End Sub

    Sub addStudentDetails()
        'create and open connection object:
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        Dim strDDl As String
        CON.Open()
        'inserts the values input by the teacher into the table
        strDDl = "INSERT INTO tblStudentDetails VALUES ('" & txtIDNo.Text & "','" & txtFirstName.Text & "','" & txtSurname.Text & "','" & dtpDOB.Value.Date & "'," & nudYrGr.Value & ",'" & txtClass.Text & "')"

        RunCMD(strDDl, CON)
        For s = 1 To 11
            strDDl = "INSERT INTO tblStudentScores VALUES (" & txtIDNo.Text & ", " & s & " ,0)"
            'run command using SQL DDL script:
            RunCMD(strDDl, CON)
        Next
        'tidy up:
        CON.Close()
        CON.Dispose()

    End Sub

    Private Sub RunCMD(ByVal strDDL As String, ByRef CON As OleDbConnection)
        'create command object
        Dim CMD As New OleDbCommand(strDDL, CON)
        Try
            'run command if syntax correct:
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            'otherwise show error message:
            MessageBox.Show("Failed:" & vbCrLf & ex.Message)
        Finally
            CMD.Dispose()
        End Try
    End Sub


   
    Private Sub Student_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIDNo.Text = ""
        txtFirstName.Text = ""
        txtSurname.Text = ""
        txtClass.Text = ""
    End Sub
End Class