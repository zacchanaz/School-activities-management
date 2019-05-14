Public Class Form1
    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub TsbExit_Click(sender As Object, e As EventArgs) Handles TsbSettings.Click
        MainPanel.Controls.Clear()
        Dim frm As New frmSettings
        frm.TopLevel = False
        MainPanel.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        MainPanel.Controls.Clear()
        Dim frm As New frmStudents
        frm.TopLevel = False
        MainPanel.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblTime.Text = Format(Now, "hh:mm:ss tt")
        lblDate.Text = Format(Now.Date, "dd-MMM-yyyy")
    End Sub

    Private Sub TsbStudents_Click(sender As Object, e As EventArgs) Handles TsbStudents.Click
        MainPanel.Controls.Clear()
        Dim frm As New frmStudents
        frm.TopLevel = False
        MainPanel.Controls.Add(frm)
        frm.Show()

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TsbActivities_Click(sender As Object, e As EventArgs) Handles TsbActivities.Click
        MainPanel.Controls.Clear()
        Dim frm As New frmActivities
        frm.TopLevel = False
        MainPanel.Controls.Add(frm)
        frm.Show()
    End Sub
End Class
