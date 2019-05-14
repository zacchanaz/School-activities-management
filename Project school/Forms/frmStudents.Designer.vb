<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudents
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbStudentInfo = New System.Windows.Forms.GroupBox()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.tbClass = New System.Windows.Forms.TextBox()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.tbStudentNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkBoxPrint = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.gbStudentInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 155)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(643, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Students"
        '
        'gbStudentInfo
        '
        Me.gbStudentInfo.Controls.Add(Me.tbPhone)
        Me.gbStudentInfo.Controls.Add(Me.lblPhone)
        Me.gbStudentInfo.Controls.Add(Me.tbEmail)
        Me.gbStudentInfo.Controls.Add(Me.lblEmail)
        Me.gbStudentInfo.Controls.Add(Me.tbFirstName)
        Me.gbStudentInfo.Controls.Add(Me.lblFirstname)
        Me.gbStudentInfo.Controls.Add(Me.tbClass)
        Me.gbStudentInfo.Controls.Add(Me.lblClass)
        Me.gbStudentInfo.Controls.Add(Me.tbLastName)
        Me.gbStudentInfo.Controls.Add(Me.lblLastName)
        Me.gbStudentInfo.Controls.Add(Me.tbStudentNum)
        Me.gbStudentInfo.Controls.Add(Me.Label2)
        Me.gbStudentInfo.Location = New System.Drawing.Point(435, 183)
        Me.gbStudentInfo.Name = "gbStudentInfo"
        Me.gbStudentInfo.Size = New System.Drawing.Size(550, 342)
        Me.gbStudentInfo.TabIndex = 0
        Me.gbStudentInfo.TabStop = False
        Me.gbStudentInfo.Text = "Student Information"
        '
        'tbPhone
        '
        Me.tbPhone.Location = New System.Drawing.Point(129, 241)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(318, 37)
        Me.tbPhone.TabIndex = 4
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(6, 244)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(70, 29)
        Me.lblPhone.TabIndex = 10
        Me.lblPhone.Text = "Phone"
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(129, 289)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(318, 37)
        Me.tbEmail.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 289)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(66, 29)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email"
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(129, 89)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(318, 37)
        Me.tbFirstName.TabIndex = 1
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Location = New System.Drawing.Point(6, 92)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(128, 29)
        Me.lblFirstname.TabIndex = 6
        Me.lblFirstname.Text = "First Name"
        '
        'tbClass
        '
        Me.tbClass.Location = New System.Drawing.Point(129, 192)
        Me.tbClass.Name = "tbClass"
        Me.tbClass.Size = New System.Drawing.Size(318, 37)
        Me.tbClass.TabIndex = 3
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(6, 195)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(64, 29)
        Me.lblClass.TabIndex = 4
        Me.lblClass.Text = "Class"
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(129, 140)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(318, 37)
        Me.tbLastName.TabIndex = 2
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(6, 140)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(123, 29)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'tbStudentNum
        '
        Me.tbStudentNum.Location = New System.Drawing.Point(129, 43)
        Me.tbStudentNum.Name = "tbStudentNum"
        Me.tbStudentNum.Size = New System.Drawing.Size(318, 37)
        Me.tbStudentNum.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "StudentID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkBoxPrint)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.btnRegister)
        Me.GroupBox1.Location = New System.Drawing.Point(435, 532)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 72)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'checkBoxPrint
        '
        Me.checkBoxPrint.AutoSize = True
        Me.checkBoxPrint.Checked = True
        Me.checkBoxPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxPrint.Location = New System.Drawing.Point(444, 25)
        Me.checkBoxPrint.Name = "checkBoxPrint"
        Me.checkBoxPrint.Size = New System.Drawing.Size(80, 33)
        Me.checkBoxPrint.TabIndex = 3
        Me.checkBoxPrint.Text = "Print"
        Me.checkBoxPrint.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(278, 25)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 41)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(22, 25)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(112, 41)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(150, 25)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(112, 41)
        Me.btnRegister.TabIndex = 1
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'frmStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbStudentInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "frmStudents"
        Me.Text = "Students"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbStudentInfo.ResumeLayout(False)
        Me.gbStudentInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents gbStudentInfo As GroupBox
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents lblFirstname As Label
    Friend WithEvents tbClass As TextBox
    Friend WithEvents lblClass As Label
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents tbStudentNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents checkBoxPrint As CheckBox
    Friend WithEvents btnNew As Button
End Class
