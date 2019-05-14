Public Class frmStudents
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles tbPhone.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbStudentNum.TextChanged

    End Sub

    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()

        If ds.Tables.Contains("StudentInfo") Then
            ds.Tables.Remove("StudentInfo")
        End If

        cmd.CommandText = "select * from StudentInfo"
        cmd.Connection = en
        da.SelectCommand = cmd
        da.Fill(ds, "StudentInfo")

        tbFirstName.Focus()
        Try
            cmd.CommandText = "select max(StudentID) from StudentInfo"
            cmd.Connection = en
            tbStudentNum = cmd.ExecuteScalar + 1
        Catch ex As Exception
            tbStudentNum.Text = 1
        End Try



    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        cmd.CommandText = "insert into StudentInfo(StudentID,FirstName,LastName,Class,Phone,Email )  values ('" & tbStudentNum.Text & "','" & tbFirstName.Text & "', '" & tbLastName.Text & "','" & tbClass.Text & "', '" & tbPhone.Text & "', '" & tbEmail.Text & "')"
        cmd.Connection = en
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registration has been saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearTextBoxes()
    End Sub

    Public Sub ClearTextBoxes()
        tbStudentNum.Clear()
        tbPhone.Clear()
        tbFirstName.Clear()
        tbLastName.Clear()
        tbEmail.Clear()
        tbClass.Clear()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            cmd.CommandText = "select max(StudentID) from StudentInfo"
            cmd.Connection = en
            tbStudentNum.Text = cmd.ExecuteScalar + 1
        Catch ex As Exception
            tbStudentNum.Text = 1
        End Try
    End Sub
End Class