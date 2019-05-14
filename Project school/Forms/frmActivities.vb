Public Class frmActivities
    Private Sub frmActivities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        If ds.Tables.Contains("ActivityInfo") Then
            ds.Tables.Remove("ActivityInfo")
        End If
        cmd.CommandText = "select * from ActivityInfo"
        cmd.Connection = en
        da.SelectCommand = cmd
        da.Fill(ds, "ActivityInfo")
        cmbActivityTitle.DataSource = ds.Tables("ActivityInfo")
        cmbActivityTitle.DisplayMember = "ActivityTitle"
        cmbActivityTitle.ValueMember = "ActivityID"

        cmd.CommandText = "select ActivityTitle from ActivityInfo where ActivityID=" & cmbActivityTitle.SelectedValue & ""
        cmd.Connection = en
        txtCoachMod.Text = cmd.ExecuteScalar
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        cmd.CommandText = "insert into ActivityInfo ( ActivityTitle,ActivityLevel,CoachID) '" & tbActivityTitle.Text & "', '" & tbActivityLevel.Text & "'.'" & tbCoach.Text & "'"
        cmd.Connection = en
        cmd.ExecuteNonQuery()
        MessageBox.Show("Activity has been added successfully", "New Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmbActivityTitle_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbActivityTitle.SelectionChangeCommitted
        cmd.CommandText = "select ActivityTitle from ActivityInfo where ActivityID=" & cmbActivityTitle.SelectedValue & ""
        cmd.Connection = en
        txtCoachMod.Text = cmd.ExecuteScalar
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If MessageBox.Show("Are you sure you want to Update the record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            cmd.CommandText = "updateActivityInfo set CoachID=" & txtCoachMod.Text & "where ActivityID=" & cmbActivityTitle.SelectedValue & ""
            cmd.Connection = en
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record has been updated", " Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
End Class