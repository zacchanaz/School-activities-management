<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivities
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblActivities = New System.Windows.Forms.Label()
        Me.gbActivityInfo = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbActivityType = New System.Windows.Forms.ComboBox()
        Me.tbCoach = New System.Windows.Forms.TextBox()
        Me.tbActivityLevel = New System.Windows.Forms.TextBox()
        Me.tbActivityTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbActivityTitle = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cmbActivityTypeMod = New System.Windows.Forms.ComboBox()
        Me.txtCoachMod = New System.Windows.Forms.TextBox()
        Me.txtActivityLevelMod = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gbActivityInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Controls.Add(Me.lblActivities)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 71)
        Me.Panel1.TabIndex = 0
        '
        'lblActivities
        '
        Me.lblActivities.AutoSize = True
        Me.lblActivities.Location = New System.Drawing.Point(638, 26)
        Me.lblActivities.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblActivities.Name = "lblActivities"
        Me.lblActivities.Size = New System.Drawing.Size(109, 29)
        Me.lblActivities.TabIndex = 0
        Me.lblActivities.Text = "Activities"
        Me.lblActivities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbActivityInfo
        '
        Me.gbActivityInfo.Controls.Add(Me.btnAdd)
        Me.gbActivityInfo.Controls.Add(Me.cmbActivityType)
        Me.gbActivityInfo.Controls.Add(Me.tbCoach)
        Me.gbActivityInfo.Controls.Add(Me.tbActivityLevel)
        Me.gbActivityInfo.Controls.Add(Me.tbActivityTitle)
        Me.gbActivityInfo.Controls.Add(Me.Label4)
        Me.gbActivityInfo.Controls.Add(Me.Label3)
        Me.gbActivityInfo.Controls.Add(Me.Label2)
        Me.gbActivityInfo.Controls.Add(Me.Label1)
        Me.gbActivityInfo.Location = New System.Drawing.Point(45, 112)
        Me.gbActivityInfo.Name = "gbActivityInfo"
        Me.gbActivityInfo.Size = New System.Drawing.Size(606, 410)
        Me.gbActivityInfo.TabIndex = 1
        Me.gbActivityInfo.TabStop = False
        Me.gbActivityInfo.Text = "Add New Activity"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(200, 320)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cmbActivityType
        '
        Me.cmbActivityType.FormattingEnabled = True
        Me.cmbActivityType.Items.AddRange(New Object() {"Sport", "Club", "Music"})
        Me.cmbActivityType.Location = New System.Drawing.Point(200, 277)
        Me.cmbActivityType.Name = "cmbActivityType"
        Me.cmbActivityType.Size = New System.Drawing.Size(205, 37)
        Me.cmbActivityType.TabIndex = 2
        '
        'tbCoach
        '
        Me.tbCoach.Location = New System.Drawing.Point(200, 215)
        Me.tbCoach.Name = "tbCoach"
        Me.tbCoach.Size = New System.Drawing.Size(205, 37)
        Me.tbCoach.TabIndex = 1
        '
        'tbActivityLevel
        '
        Me.tbActivityLevel.Location = New System.Drawing.Point(200, 154)
        Me.tbActivityLevel.Name = "tbActivityLevel"
        Me.tbActivityLevel.Size = New System.Drawing.Size(205, 37)
        Me.tbActivityLevel.TabIndex = 1
        '
        'tbActivityTitle
        '
        Me.tbActivityTitle.Location = New System.Drawing.Point(200, 97)
        Me.tbActivityTitle.Name = "tbActivityTitle"
        Me.tbActivityTitle.Size = New System.Drawing.Size(205, 37)
        Me.tbActivityTitle.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Activity type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Coach"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Activity Level"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Activity Title"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbActivityTitle)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.cmbActivityTypeMod)
        Me.GroupBox1.Controls.Add(Me.txtCoachMod)
        Me.GroupBox1.Controls.Add(Me.txtActivityLevelMod)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(692, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 410)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modify Activity"
        '
        'cmbActivityTitle
        '
        Me.cmbActivityTitle.FormattingEnabled = True
        Me.cmbActivityTitle.Location = New System.Drawing.Point(200, 97)
        Me.cmbActivityTitle.Name = "cmbActivityTitle"
        Me.cmbActivityTitle.Size = New System.Drawing.Size(205, 37)
        Me.cmbActivityTitle.TabIndex = 4
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(200, 320)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(119, 35)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cmbActivityTypeMod
        '
        Me.cmbActivityTypeMod.FormattingEnabled = True
        Me.cmbActivityTypeMod.Items.AddRange(New Object() {"Sport", "Club", "Music"})
        Me.cmbActivityTypeMod.Location = New System.Drawing.Point(200, 277)
        Me.cmbActivityTypeMod.Name = "cmbActivityTypeMod"
        Me.cmbActivityTypeMod.Size = New System.Drawing.Size(205, 37)
        Me.cmbActivityTypeMod.TabIndex = 2
        '
        'txtCoachMod
        '
        Me.txtCoachMod.Location = New System.Drawing.Point(200, 215)
        Me.txtCoachMod.Name = "txtCoachMod"
        Me.txtCoachMod.Size = New System.Drawing.Size(205, 37)
        Me.txtCoachMod.TabIndex = 1
        '
        'txtActivityLevelMod
        '
        Me.txtActivityLevelMod.Location = New System.Drawing.Point(200, 154)
        Me.txtActivityLevelMod.Name = "txtActivityLevelMod"
        Me.txtActivityLevelMod.Size = New System.Drawing.Size(205, 37)
        Me.txtActivityLevelMod.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 29)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Activity type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Coach"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 29)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Activity Level"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 29)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Activity Title"
        '
        'frmActivities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbActivityInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "frmActivities"
        Me.Text = "Activities"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbActivityInfo.ResumeLayout(False)
        Me.gbActivityInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblActivities As Label
    Friend WithEvents gbActivityInfo As GroupBox
    Friend WithEvents tbActivityTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmbActivityType As ComboBox
    Friend WithEvents tbCoach As TextBox
    Friend WithEvents tbActivityLevel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbActivityTitle As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cmbActivityTypeMod As ComboBox
    Friend WithEvents txtCoachMod As TextBox
    Friend WithEvents txtActivityLevelMod As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
