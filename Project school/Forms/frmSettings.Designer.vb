<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpCreateUser = New System.Windows.Forms.TabPage()
        Me.gbCreateUser = New System.Windows.Forms.GroupBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.tpChangePass = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCurrentPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUserName1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.tpUpdateStud = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.gbStudentInfo = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.txtClass = New System.Windows.Forms.TextBox()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpCreateUser.SuspendLayout()
        Me.gbCreateUser.SuspendLayout()
        Me.tpChangePass.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpUpdateStud.SuspendLayout()
        Me.gbStudentInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.lblSettings)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 65)
        Me.Panel1.TabIndex = 0
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.Location = New System.Drawing.Point(628, 26)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(112, 34)
        Me.lblSettings.TabIndex = 0
        Me.lblSettings.Text = "Settings"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpCreateUser)
        Me.TabControl1.Controls.Add(Me.tpChangePass)
        Me.TabControl1.Controls.Add(Me.tpUpdateStud)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 65)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1284, 684)
        Me.TabControl1.TabIndex = 1
        '
        'tpCreateUser
        '
        Me.tpCreateUser.Controls.Add(Me.gbCreateUser)
        Me.tpCreateUser.Location = New System.Drawing.Point(4, 22)
        Me.tpCreateUser.Name = "tpCreateUser"
        Me.tpCreateUser.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCreateUser.Size = New System.Drawing.Size(1276, 658)
        Me.tpCreateUser.TabIndex = 0
        Me.tpCreateUser.Text = "Create User"
        Me.tpCreateUser.UseVisualStyleBackColor = True
        '
        'gbCreateUser
        '
        Me.gbCreateUser.Controls.Add(Me.txtConfirmPassword)
        Me.gbCreateUser.Controls.Add(Me.txtPassword)
        Me.gbCreateUser.Controls.Add(Me.Label3)
        Me.gbCreateUser.Controls.Add(Me.txtUserName)
        Me.gbCreateUser.Controls.Add(Me.Label2)
        Me.gbCreateUser.Controls.Add(Me.Label1)
        Me.gbCreateUser.Controls.Add(Me.btnClear)
        Me.gbCreateUser.Controls.Add(Me.btnCreate)
        Me.gbCreateUser.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCreateUser.Location = New System.Drawing.Point(276, 65)
        Me.gbCreateUser.Name = "gbCreateUser"
        Me.gbCreateUser.Size = New System.Drawing.Size(555, 261)
        Me.gbCreateUser.TabIndex = 0
        Me.gbCreateUser.TabStop = False
        Me.gbCreateUser.Text = "Create New User"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(219, 138)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(292, 28)
        Me.txtConfirmPassword.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(219, 95)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(292, 28)
        Me.txtPassword.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Re-enter Password"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(219, 55)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(292, 28)
        Me.txtUserName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(344, 197)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 40)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(219, 197)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(100, 40)
        Me.btnCreate.TabIndex = 3
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'tpChangePass
        '
        Me.tpChangePass.Controls.Add(Me.GroupBox2)
        Me.tpChangePass.Location = New System.Drawing.Point(4, 22)
        Me.tpChangePass.Name = "tpChangePass"
        Me.tpChangePass.Padding = New System.Windows.Forms.Padding(3)
        Me.tpChangePass.Size = New System.Drawing.Size(1276, 658)
        Me.tpChangePass.TabIndex = 1
        Me.tpChangePass.Text = "Change Password"
        Me.tpChangePass.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPasswordConfirm)
        Me.GroupBox2.Controls.Add(Me.txtNewPass)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCurrentPass)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtUserName1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnChange)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(255, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 299)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Change Password"
        '
        'txtPasswordConfirm
        '
        Me.txtPasswordConfirm.Location = New System.Drawing.Point(219, 182)
        Me.txtPasswordConfirm.Name = "txtPasswordConfirm"
        Me.txtPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordConfirm.Size = New System.Drawing.Size(292, 28)
        Me.txtPasswordConfirm.TabIndex = 2
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(219, 138)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(292, 28)
        Me.txtNewPass.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Confirm Password"
        '
        'txtCurrentPass
        '
        Me.txtCurrentPass.Location = New System.Drawing.Point(219, 95)
        Me.txtCurrentPass.Name = "txtCurrentPass"
        Me.txtCurrentPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPass.Size = New System.Drawing.Size(292, 28)
        Me.txtCurrentPass.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 22)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "New Password"
        '
        'txtUserName1
        '
        Me.txtUserName1.Location = New System.Drawing.Point(219, 55)
        Me.txtUserName1.Name = "txtUserName1"
        Me.txtUserName1.Size = New System.Drawing.Size(292, 28)
        Me.txtUserName1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 22)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Current Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 22)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Username"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(343, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(218, 226)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(100, 40)
        Me.btnChange.TabIndex = 3
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'tpUpdateStud
        '
        Me.tpUpdateStud.Controls.Add(Me.Label9)
        Me.tpUpdateStud.Controls.Add(Me.txtSearch)
        Me.tpUpdateStud.Controls.Add(Me.btnSearch)
        Me.tpUpdateStud.Controls.Add(Me.btnDelete)
        Me.tpUpdateStud.Controls.Add(Me.btnUpdate)
        Me.tpUpdateStud.Controls.Add(Me.gbStudentInfo)
        Me.tpUpdateStud.Location = New System.Drawing.Point(4, 22)
        Me.tpUpdateStud.Name = "tpUpdateStud"
        Me.tpUpdateStud.Padding = New System.Windows.Forms.Padding(3)
        Me.tpUpdateStud.Size = New System.Drawing.Size(1276, 658)
        Me.tpUpdateStud.TabIndex = 2
        Me.tpUpdateStud.Text = "Update Student Information"
        Me.tpUpdateStud.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(324, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Search For a Student(StudentID)"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(558, 72)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(216, 20)
        Me.txtSearch.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(801, 69)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(447, 488)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 35)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(327, 488)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 35)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'gbStudentInfo
        '
        Me.gbStudentInfo.Controls.Add(Me.txtPhone)
        Me.gbStudentInfo.Controls.Add(Me.lblPhone)
        Me.gbStudentInfo.Controls.Add(Me.txtEmail)
        Me.gbStudentInfo.Controls.Add(Me.lblEmail)
        Me.gbStudentInfo.Controls.Add(Me.txtFirstName)
        Me.gbStudentInfo.Controls.Add(Me.lblFirstname)
        Me.gbStudentInfo.Controls.Add(Me.txtClass)
        Me.gbStudentInfo.Controls.Add(Me.lblClass)
        Me.gbStudentInfo.Controls.Add(Me.txtLastName)
        Me.gbStudentInfo.Controls.Add(Me.lblLastName)
        Me.gbStudentInfo.Controls.Add(Me.txtStudentID)
        Me.gbStudentInfo.Controls.Add(Me.Label8)
        Me.gbStudentInfo.Location = New System.Drawing.Point(327, 119)
        Me.gbStudentInfo.Name = "gbStudentInfo"
        Me.gbStudentInfo.Size = New System.Drawing.Size(550, 342)
        Me.gbStudentInfo.TabIndex = 1
        Me.gbStudentInfo.TabStop = False
        Me.gbStudentInfo.Text = "Update Student Information"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(129, 241)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(318, 20)
        Me.txtPhone.TabIndex = 4
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(6, 244)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 10
        Me.lblPhone.Text = "Phone"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(129, 289)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(318, 20)
        Me.txtEmail.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 289)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(129, 89)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(318, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Location = New System.Drawing.Point(6, 92)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstname.TabIndex = 6
        Me.lblFirstname.Text = "First Name"
        '
        'txtClass
        '
        Me.txtClass.Location = New System.Drawing.Point(129, 192)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Size = New System.Drawing.Size(318, 20)
        Me.txtClass.TabIndex = 3
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(6, 195)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(32, 13)
        Me.lblClass.TabIndex = 4
        Me.lblClass.Text = "Class"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(129, 140)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(318, 20)
        Me.txtLastName.TabIndex = 2
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(6, 140)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(129, 43)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(318, 20)
        Me.txtStudentID.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "StudentID"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1276, 658)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpCreateUser.ResumeLayout(False)
        Me.gbCreateUser.ResumeLayout(False)
        Me.gbCreateUser.PerformLayout()
        Me.tpChangePass.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpUpdateStud.ResumeLayout(False)
        Me.tpUpdateStud.PerformLayout()
        Me.gbStudentInfo.ResumeLayout(False)
        Me.gbStudentInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSettings As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpCreateUser As TabPage
    Friend WithEvents gbCreateUser As GroupBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents tpChangePass As TabPage
    Friend WithEvents tpUpdateStud As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPasswordConfirm As TextBox
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCurrentPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUserName1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnChange As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents gbStudentInfo As GroupBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstname As Label
    Friend WithEvents txtClass As TextBox
    Friend WithEvents lblClass As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnDelete As Button
End Class
