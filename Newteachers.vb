Imports System.Data.OleDb
Public Class Newteachers

    Dim firstname As String
    Dim surname As String
    Dim ID As String
    Dim temp As Char
    Dim int As Integer
    Dim temp2 As String
    Dim pass As String
    Dim classes As String

    Dim alphabet As String = "abcdefghijklmnopqrstuvwxyz"


    Sub IDPassword()
        firstname = txtFirstName.Text
        surname = txtSurname.Text
        classes = txtClass.Text

        firstname = LCase(firstname)

        ID = firstname.ElementAt(0) & "." & surname

        For n = 0 To 2
            temp = firstname.ElementAt(n)

            int = alphabet.IndexOf(temp) + 1

            temp2 = temp2 & int
        Next

        temp2 = firstname.ElementAt(0) & surname.ElementAt(0) & temp2


        Label4.Text = ID
        Label1.Text = temp2

        pass = temp2
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtFirstName.Text.Length < 2 Then
            MsgBox("Enter your first name")
        ElseIf txtSurname.Text.Length < 2 Then
            MsgBox("Enter your last name")
        ElseIf txtClass.Text.Length < 2 Then
            MsgBox("Enter your class")
        Else
            IDPassword()
            firstname = UCase(firstname.ElementAt(0)) + firstname.TrimStart(firstname.ElementAt(0))
            surname = UCase(surname.ElementAt(0)) + surname.TrimStart(surname.ElementAt(0))
            Insert()
            MsgBox("ID is: " & ID)
            MsgBox("Password is: " & pass)

            Teacher_Menu.ShowDialog()
            Me.Close()
        End If

        
    End Sub

    Sub Insert()
        Dim strDDL As String
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "Student_Details.mdb")
        CON.Open()
        strDDL = "INSERT INTO tblTeacherDetails VALUES ('" & classes & "', '" & ID & "', '" & pass & "', '" & firstname & "', '" & surname & "')"
        RunCMD(strDDL, CON)
        CON.Close()
        CON.Dispose()
    End Sub

    Private Sub Newteachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class