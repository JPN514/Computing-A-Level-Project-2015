Imports System.Data.OleDb
Public Class Teacher_Menu

    'main menu for the teacher

    Dim classes(8) As String
    Dim t As Integer = 0
    Dim i As Integer 'index value of selected test
    Dim max As Integer

    Private Sub Teacher_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
        GetClassNo()
        GetClasses()
    End Sub

    Private Sub btnTeaMenuBack_Click(sender As Object, e As EventArgs) Handles btnTeaMenuBack.Click
        Me.Close()
        LoginMenu.Show()
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        Me.Hide()
        If cmbNew.Text = "Student" Then
            Student_details.ShowDialog()
            Me.Show()
        ElseIf cmbNew.Text = "Question" Then
            AddQuestion.ShowDialog()
            Me.Show()
        Else : Me.Show()
            MsgBox("Select an option.")
        End If

    End Sub

    Private Sub btnSetTest_Click(sender As Object, e As EventArgs) Handles btnSetTest.Click
        i = -1
        i = cmbTests.SelectedIndex
        If i < 0 Then
            MsgBox("Please select a topic.")
        Else
            i = cmbTests.SelectedIndex
            UpdateTests()
            MsgBox("Test set: " & globalvariables.Topics(i + 1) & ".")
        End If
    End Sub



    Sub UpdateTests()
        'activates the selected test
        Dim strTableName As String = "tblTopics"
        Dim column As String = "Active"
        Dim a As Integer = 1
        Dim strddl As String
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        strddl = "UPDATE tblTopics SET " & column & " = " & a & " WHERE TopicNo = " & i + 1 & " AND Topic_name = '" & globalvariables.Topics(i + 1) & "'"
        RunCMD(strddl, CON)
        CON.Close()
        CON.Dispose()
    End Sub

    Sub GetClassNo()
        'counts the number of classes already in the database
        'select statement
        Dim strDDl As String
        strDDl = "SELECT DISTINCT TeacherID FROM tblStudentDetails;"
        GetClassNo2(strDDl)
    End Sub

    Sub GetClassNo2(ByVal strddl As String)
        'returns the number of classes in the database
        Dim a As Integer
        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()

        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)

        max = dt.Rows.Count

    End Sub

    Sub GetClasses()
        'gets all of the classes from the database
        Dim strDDL As String

        strDDL = "SELECT DISTINCT TeacherID FROM tblStudentDetails;"
        Do Until t = max  'needs correct math 
            runCommand(strDDL)
        Loop
    End Sub

    Sub runCommand(ByVal strddl As String)

        Dim DA As OleDbDataAdapter
        Dim dt As New DataTable
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()

        DA = New OleDbDataAdapter(strddl, CON)
        DA.Fill(dt)

        'adds the classes selected from the databse to the dropdown menu

        classes(t) = dt.Rows(t)(0).ToString
        cmbClass.Items.Add(classes(t))
        t = t + 1




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

    Private Sub btnViewClass_Click(sender As Object, e As EventArgs) Handles btnViewClass.Click
        Dim z As Integer
        z = -1
        z = cmbClass.SelectedIndex
        If z < 0 Then
            MsgBox("You must select a class to view.")
        Else
            globalvariables.chosenClass = classes(z)
            ClassDisplay.ShowDialog()
            Me.Show()
        End If
       

    End Sub
End Class