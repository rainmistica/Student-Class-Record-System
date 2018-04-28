Public Class frmMain
    Dim ExitYN As System.Windows.Forms.DialogResult
    Public Property ULevel As Integer
    Public Property FN As String
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo, "Confirm")
        If ExitYN = MsgBoxResult.Yes Then
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ExitYN = MsgBox("Do you really want to Logout?", MsgBoxStyle.YesNo, "Confirm")
        If ExitYN = MsgBoxResult.Yes Then
            tDate.Stop()
            frmLog.Show()
            Me.Hide()
        Else
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tDate.Enabled = True
        tDate.Start()
        LevelCheck()
    End Sub

    Private Sub tDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tDate.Tick
        TSSL2.Text = Date.Now
    End Sub

    Private Sub SubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectToolStripMenuItem.Click
        Dim frm As New frmMaintenance
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ClassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassToolStripMenuItem.Click
        Dim frm As New frmClass
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        Dim frm As New frmStud
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GradingSheetToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradingSheetToolStripMenuItem1.Click
        Dim frm As New frmgradesheet
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ViewOverallGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewOverallGradesToolStripMenuItem.Click
        Dim frm As New frmVOG
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub UserAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountsToolStripMenuItem.Click
        Dim frm As New frmUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Public Sub LevelCheck()
        If (ULevel = 3) Then
            FileMaintenanceToolStripMenuItem.Visible = False
            GradingSheetToolStripMenuItem1.Visible = False
            ViewOverallGradesToolStripMenuItem.Visible = False
            AttendanceMonitoringToolStripMenuItem.Visible = False
            PrintToolStripMenuItem.Visible = False
        ElseIf (ULevel = 2) Then
            FileMaintenanceToolStripMenuItem.Visible = False
            GradingSheetToolStripMenuItem1.Visible = False
            AttendanceMonitoringToolStripMenuItem.Visible = False
            PrintToolStripMenuItem.Visible = False
            UserAccountsToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub LogOffToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click
        ExitYN = MsgBox("Do you really want to Logout?", MsgBoxStyle.YesNo, "Confirm")
        If ExitYN = MsgBoxResult.Yes Then
            tDate.Stop()
            frmLog.Show()
            Me.Hide()
        Else
        End If
    End Sub

    Private Sub AttendanceMonitoringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendanceMonitoringToolStripMenuItem.Click
        Dim frm As New frmAttendance
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StudentListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentListToolStripMenuItem1.Click
        Dim frm As New ReportsForStudent
        frm.FN = FN
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GradingPeriodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradingPeriodToolStripMenuItem.Click
        Dim frm As New ReportGradSheet
        frm.FN = FN
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WholeGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WholeGradesToolStripMenuItem.Click
        Dim frm As New ReportFinal
        frm.FN = FN
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class