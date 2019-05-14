<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblSchoolSystem = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsbStudents = New System.Windows.Forms.ToolStripButton()
        Me.TsbActivities = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.TsbSettings = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.LblTime)
        Me.Panel1.Controls.Add(Me.LblSchoolSystem)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 109)
        Me.Panel1.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(1034, 34)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(61, 29)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Time"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTime.Location = New System.Drawing.Point(898, 34)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(61, 29)
        Me.LblTime.TabIndex = 0
        Me.LblTime.Text = "Time"
        '
        'LblSchoolSystem
        '
        Me.LblSchoolSystem.AutoSize = True
        Me.LblSchoolSystem.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSchoolSystem.Location = New System.Drawing.Point(540, 26)
        Me.LblSchoolSystem.Name = "LblSchoolSystem"
        Me.LblSchoolSystem.Size = New System.Drawing.Size(210, 39)
        Me.LblSchoolSystem.TabIndex = 0
        Me.LblSchoolSystem.Text = "School System"
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MainPanel.Controls.Add(Me.Panel3)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainPanel.Location = New System.Drawing.Point(0, 109)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1284, 640)
        Me.MainPanel.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.btnMinimize)
        Me.Panel3.Controls.Add(Me.ToolStrip1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1284, 82)
        Me.Panel3.TabIndex = 1
        '
        'btnMinimize
        '
        Me.btnMinimize.Location = New System.Drawing.Point(1197, 56)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(75, 23)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.Text = "Minimize"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsbStudents, Me.TsbActivities, Me.ToolStripButton3, Me.TsbSettings, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1284, 82)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TsbStudents
        '
        Me.TsbStudents.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsbStudents.ForeColor = System.Drawing.Color.Yellow
        Me.TsbStudents.Image = CType(resources.GetObject("TsbStudents.Image"), System.Drawing.Image)
        Me.TsbStudents.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TsbStudents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbStudents.Name = "TsbStudents"
        Me.TsbStudents.Size = New System.Drawing.Size(61, 79)
        Me.TsbStudents.Text = "Students"
        Me.TsbStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TsbStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TsbActivities
        '
        Me.TsbActivities.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsbActivities.ForeColor = System.Drawing.Color.Yellow
        Me.TsbActivities.Image = CType(resources.GetObject("TsbActivities.Image"), System.Drawing.Image)
        Me.TsbActivities.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TsbActivities.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbActivities.Name = "TsbActivities"
        Me.TsbActivities.Size = New System.Drawing.Size(63, 79)
        Me.TsbActivities.Text = "Activities"
        Me.TsbActivities.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TsbActivities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(107, 79)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TsbSettings
        '
        Me.TsbSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsbSettings.ForeColor = System.Drawing.Color.Yellow
        Me.TsbSettings.Image = CType(resources.GetObject("TsbSettings.Image"), System.Drawing.Image)
        Me.TsbSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbSettings.Name = "TsbSettings"
        Me.TsbSettings.Size = New System.Drawing.Size(57, 79)
        Me.TsbSettings.Text = "Settings"
        Me.TsbSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TsbSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(32, 79)
        Me.ToolStripButton1.Text = "Exit"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTime As Label
    Friend WithEvents LblSchoolSystem As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TsbStudents As ToolStripButton
    Friend WithEvents TsbActivities As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents TsbSettings As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDate As Label
    Friend WithEvents btnMinimize As Button
End Class
