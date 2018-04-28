Imports MySql.Data.MySqlClient
Public Class frmLog
    Dim ExitYN, CYN As System.Windows.Forms.DialogResult
    Dim Conn As New MySqlConnection
    Dim DatabaseName As String = "dbclassrec"
    Dim server As String = "localhost"
    Dim userName As String = "root"
    Dim password As String = "1234"
    Dim result As Integer
    Dim cmd As New MySqlCommand
    Dim op As frmStud = New frmStud
    Dim ctr As Integer
    Dim cnt As Integer
    Dim uL As Integer
    Dim FN As String

    Private Sub frmLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqConnect()
        lblctr.Text = ctr
        ctr = 0
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If (txtUser.Text = "" Or txtPass.Text = "") Then
            MessageBox.Show("Please input information!", "Confirm")
        Else
            sqConnect()
            cnt = 1
            Dim squery As String = "select  * from tbluseracc"
            Dim sadapter As New MySqlDataAdapter
            Dim scommand As New MySqlCommand
            Dim sqltable As New DataTable
            Dim i As Integer
            scommand.CommandText = squery
            scommand.Connection = Conn
            sadapter.SelectCommand = scommand
            sadapter.Fill(sqltable)

            For i = 0 To sqltable.Rows.Count - 1
                lbluser.Text = sqltable.Rows(i)("User")
                lblpass.Text = sqltable.Rows(i)("Pass")
                uL = sqltable.Rows(i)("Level")
                FN = sqltable.Rows(i)("FullName")
                If (txtUser.Text = lbluser.Text And txtPass.Text = lblpass.Text) Then
                    Dim frma As New frmMain
                    frma.ULevel = uL
                    frma.FN = FN
                    frma.Show()
                    cnt = 0
                    txtUser.Text = ""
                    txtPass.Text = ""
                    Me.Hide()
                End If
            Next
            Conn.Close()
            If (cnt = 1) Then
                If (ctr = 2) Then
                    MessageBox.Show("Access Denied! System will now exit.", "OK")
                    Application.Exit()
                Else
                    MessageBox.Show("Access Denied!", "OK")
                    ctr += 1
                    txtUser.Text = ""
                    txtPass.Text = ""
                End If
            End If
        End If
        lblctr.Text = ctr
    End Sub
    Public Sub sqConnect()
        If Not Conn Is Nothing Then Conn.Close()
        Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Conn.Open()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            txtPass.PasswordChar = ""
        ElseIf (CheckBox1.Checked = False) Then
            txtPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub frmLog_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
