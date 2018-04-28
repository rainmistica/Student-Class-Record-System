<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Main = New System.Windows.Forms.MenuStrip()
        Me.FileMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradingSheetToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOverallGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceMonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradingSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradingPeriodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WholeGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Stat = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tDate = New System.Windows.Forms.Timer(Me.components)
        Me.Main.SuspendLayout()
        Me.Stat.SuspendLayout()
        Me.SuspendLayout()
        '
        'Main
        '
        Me.Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMaintenanceToolStripMenuItem, Me.GradingSheetToolStripMenuItem1, Me.ViewOverallGradesToolStripMenuItem, Me.AttendanceMonitoringToolStripMenuItem, Me.PrintToolStripMenuItem, Me.UserAccountsToolStripMenuItem, Me.LogOffToolStripMenuItem})
        Me.Main.Location = New System.Drawing.Point(0, 0)
        Me.Main.Name = "Main"
        Me.Main.Size = New System.Drawing.Size(984, 24)
        Me.Main.TabIndex = 0
        Me.Main.Text = "MenuStrip1"
        '
        'FileMaintenanceToolStripMenuItem
        '
        Me.FileMaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubjectToolStripMenuItem, Me.StudentToolStripMenuItem, Me.ClassToolStripMenuItem})
        Me.FileMaintenanceToolStripMenuItem.Name = "FileMaintenanceToolStripMenuItem"
        Me.FileMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.FileMaintenanceToolStripMenuItem.Text = "File Maintenance"
        '
        'SubjectToolStripMenuItem
        '
        Me.SubjectToolStripMenuItem.Name = "SubjectToolStripMenuItem"
        Me.SubjectToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.SubjectToolStripMenuItem.Text = "Subject"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'ClassToolStripMenuItem
        '
        Me.ClassToolStripMenuItem.Name = "ClassToolStripMenuItem"
        Me.ClassToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ClassToolStripMenuItem.Text = "Class"
        '
        'GradingSheetToolStripMenuItem1
        '
        Me.GradingSheetToolStripMenuItem1.Name = "GradingSheetToolStripMenuItem1"
        Me.GradingSheetToolStripMenuItem1.Size = New System.Drawing.Size(93, 20)
        Me.GradingSheetToolStripMenuItem1.Text = "Grading Sheet"
        '
        'ViewOverallGradesToolStripMenuItem
        '
        Me.ViewOverallGradesToolStripMenuItem.Name = "ViewOverallGradesToolStripMenuItem"
        Me.ViewOverallGradesToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.ViewOverallGradesToolStripMenuItem.Text = "View Overall Grades"
        '
        'AttendanceMonitoringToolStripMenuItem
        '
        Me.AttendanceMonitoringToolStripMenuItem.Name = "AttendanceMonitoringToolStripMenuItem"
        Me.AttendanceMonitoringToolStripMenuItem.Size = New System.Drawing.Size(143, 20)
        Me.AttendanceMonitoringToolStripMenuItem.Text = "Attendance Monitoring"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentListToolStripMenuItem1, Me.GradingSheetToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.PrintToolStripMenuItem.Text = "Reports"
        '
        'StudentListToolStripMenuItem1
        '
        Me.StudentListToolStripMenuItem1.Name = "StudentListToolStripMenuItem1"
        Me.StudentListToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.StudentListToolStripMenuItem1.Text = "Student List"
        '
        'GradingSheetToolStripMenuItem
        '
        Me.GradingSheetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GradingPeriodToolStripMenuItem, Me.WholeGradesToolStripMenuItem})
        Me.GradingSheetToolStripMenuItem.Name = "GradingSheetToolStripMenuItem"
        Me.GradingSheetToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GradingSheetToolStripMenuItem.Text = "Grading Sheet"
        '
        'GradingPeriodToolStripMenuItem
        '
        Me.GradingPeriodToolStripMenuItem.Name = "GradingPeriodToolStripMenuItem"
        Me.GradingPeriodToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.GradingPeriodToolStripMenuItem.Text = "Grading Period"
        '
        'WholeGradesToolStripMenuItem
        '
        Me.WholeGradesToolStripMenuItem.Name = "WholeGradesToolStripMenuItem"
        Me.WholeGradesToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.WholeGradesToolStripMenuItem.Text = "Whole Grades"
        '
        'UserAccountsToolStripMenuItem
        '
        Me.UserAccountsToolStripMenuItem.Name = "UserAccountsToolStripMenuItem"
        Me.UserAccountsToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.UserAccountsToolStripMenuItem.Text = "User Accounts"
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LogOffToolStripMenuItem.Text = "Log Off"
        '
        'Stat
        '
        Me.Stat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.TSSL2})
        Me.Stat.Location = New System.Drawing.Point(0, 710)
        Me.Stat.Name = "Stat"
        Me.Stat.Size = New System.Drawing.Size(984, 22)
        Me.Stat.TabIndex = 1
        Me.Stat.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'TSSL2
        '
        Me.TSSL2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TSSL2.Name = "TSSL2"
        Me.TSSL2.Size = New System.Drawing.Size(0, 17)
        Me.TSSL2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tDate
        '
        Me.tDate.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.SGAS.My.Resources.Resources.BG_MainRevised1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 732)
        Me.ControlBox = False
        Me.Controls.Add(Me.Stat)
        Me.Controls.Add(Me.Main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Student Grading and Attendance Monitoring System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Main.ResumeLayout(False)
        Me.Main.PerformLayout()
        Me.Stat.ResumeLayout(False)
        Me.Stat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Main As System.Windows.Forms.MenuStrip
    Friend WithEvents Stat As System.Windows.Forms.StatusStrip
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradingSheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tDate As System.Windows.Forms.Timer
    Friend WithEvents FileMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradingSheetToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewOverallGradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceMonitoringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradingPeriodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WholeGradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
