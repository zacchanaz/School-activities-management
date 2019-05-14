Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        connect()

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Trim(txtUserName.Text) = "" Then
            MessageBox.Show("Please enter Username", "Required", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtUserName.Focus()
            Exit Sub
        End If

        If Trim(txtPassword.Text) = "" Then
            MessageBox.Show("Please enter Password", "Required", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtPassword.Focus()
            Exit Sub
        End If

        If Trim(txtConfirmPassword.Text) = "" Then
            MessageBox.Show("Please re-enter Password", "Required", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtConfirmPassword.Focus()
            Exit Sub
        End If

        If Trim(txtPassword.Text) <> Trim(txtConfirmPassword.Text) Then
            MessageBox.Show("Passwords Don't Match", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtPassword.Focus()
            Exit Sub
        End If

        Dim user As String
        cmd.CommandText = "select username from users where username='" & txtUserName.Text & "'"
        cmd.Connection = en
        user = cmd.ExecuteScalar
        If user <> "" Then
            MessageBox.Show("Username already exists", "duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtUserName.Focus()
            Exit Sub
        End If

        cmd.CommandText = "insert into Users(username,password) values('" & txtUserName.Text & "','" & txtPassword.Text & "')"
        cmd.Connection = en
        cmd.ExecuteNonQuery()
        MessageBox.Show("User created Successfully", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Clearfields()



    End Sub
    Public Sub Clearfields()
        txtPassword.Clear()
        txtUserName.Clear()
        txtConfirmPassword.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clearfields()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If Trim(txtUserName1.Text) = "" Then
            MessageBox.Show("Please enter Username", "Required", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtUserName1.Focus()
            Exit Sub
        End If

        If Trim(txtCurrentPass.Text) = "" Then
            MessageBox.Show("Please enter Current Password", "Required", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtCurrentPass.Focus()
            Exit Sub
        End If

        If Trim(txtNewPass.Text) = "" Then
            MessageBox.Show("Please enter New Password", "Required", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtNewPass.Focus()
            Exit Sub
        End If

        If Trim(txtPasswordConfirm.Text) = "" Then
            MessageBox.Show("Please re-enter New Password", "Required", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtPasswordConfirm.Focus()
            Exit Sub
        End If

        If ds.Tables.Contains("users") Then
            ds.Tables.Remove("users")
        End If
        cmd.CommandText = "select * from users where username= '" & txtUserName1.Text & "' and password='" & txtNewPass.Text & "'"
        cmd.Connection = en
        da.SelectCommand = cmd
        da.Fill(ds, "users")
        If ds.Tables("users").Rows.Count = 0 Then
            MessageBox.Show("Username or Password incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtUserName1.Focus()
        End If

        If Trim(txtNewPass.Text) <> Trim(txtPasswordConfirm.Text) Then
            MessageBox.Show("The entered passwords do not match", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtNewPass.Focus()
        End If

        cmd.CommandText = "update users set password='" & txtNewPass.Text & "' where username= '" & txtUserName1.Text & "' and password='" & txtCurrentPass.Text & "'"
        cmd.Connection = en
        cmd.ExecuteNonQuery()
        MessageBox.Show("Password has been changed successfully", "Change Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearChangeFields()
    End Sub



    Public Sub ClearChangeFields()
        txtUserName1.Clear()
        txtPasswordConfirm.Clear()
        txtNewPass.Clear()
        txtCurrentPass.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearChangeFields()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Trim(txtSearch.Text) = "" Then
            MessageBox.Show("Please enter a Student Number to search", "Provide Info", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtSearch.Focus()
            Exit Sub
        End If

        If ds.Tables.Contains("VUUPdate") Then
            ds.Tables.Remove("VUUPdate")
        End If
        cmd.CommandText = "select * from VUUPdate where StudentID=" & txtSearch.Text & ""
        cmd.Connection = en
        da.Fill(ds, "VUUPdate")

        If ds.Tables("VUUPdate").Rows.Count = 0 Then
            MessageBox.Show("Record was not found for StudentID" & txtSearch.Text & "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtSearch.Focus()
            Exit Sub
        End If
        btnUpdate.Enabled=True
        btnDelete.Enabled=true
        txtStudentID.Text = ds.Tables("VUUPdate").Rows(0).Item("StudentID")
        txtFirstName.Text = ds.Tables("VUUPdate").Rows(0).Item("FirstName")
        txtLastName.Text = ds.Tables("VUUPdate").Rows(0).Item("LastName")
        txtClass.Text = ds.Tables("VUUPdate").Rows(0).Item("Class")
        txtPhone.Text = ds.Tables("VUUPdate").Rows(0).Item("phone")
        txtEmail.Text = ds.Tables("VUUPdate").Rows(0).Item("email")


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If MessageBox.Show("Would you like to update record?", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Question) Then
            cmd.CommandText = "Update StudentInfo set Firstname='" & txtFirstName.Text & "',Lastname='" & txtLastName.Text & "',class='" & txtClass.Text & "' ,phone=' " & txtPhone.Text & "',email= '" & txtEmail.Text & "', where studentID='" & txtSearch.Text & ""
            cmd.Connection = en
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record has been updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            clearUpdateInfoFields()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Would you like to Delete Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            cmd.CommandText = "Delete from StudentInfo where StudentID=" & txtSearch.Text & ""
            cmd.Connection = en
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record has been deleted", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Enabled = False
            clearUpdateInfoFields()
            btnDelete.Enabled = False
        End If
    End Sub

    Public Sub clearUpdateInfoFields()
        txtFirstName.Clear()
        txtLastName.Clear()


    End Sub

End Class