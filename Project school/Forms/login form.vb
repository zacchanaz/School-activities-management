Public Class login_form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub Button1(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Login()
    End Sub

    Private Sub login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

    End Sub


    Public Sub Login()

        If Trim(txtPassword.Text) = "" Or Trim(txtUsername.Text) = "" Then
            MessageBox.Show("Please fill in both Username And Password fields", "Fields required", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub


        End If

        If ds.Tables.Contains("users") Then
            ds.Tables.Remove("users")

        End If
        cmd.CommandText = "select * from users where Username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'"
            cmd.Connection = en
        da.SelectCommand = cmd
        da.Fill(ds, "users")

        If ds.Tables("users").Rows.Count = 0 Then
            MessageBox.Show("Username or Password is invalid", "Invalid username or password", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown, txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus, txtUsername.GotFocus
        sender.SelectAll()
    End Sub
End Class