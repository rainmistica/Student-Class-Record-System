Imports MySql.Data.MySqlClient
Public Class frmMaintenance
    Dim ExitYN, CYN As System.Windows.Forms.DialogResult
    Dim dB As New MySqlConnection
    Dim DatabaseName As String = "dbclassrec"
    Dim server As String = "localhost"
    Dim userName As String = "root"
    Dim password As String = "1234"
    Dim result As Integer
    Dim cmd As New MySqlCommand
    Dim fAY As String
    Dim a, b, c, d, e, f, g, h As Double
    Dim a1, q2, s3, r4, p5, o6, e7 As Double
    Private Sub frmMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dBConnect() : fillDept() : fillAY()
    End Sub
    Public Sub Clr()
        N1.Text = "0"
        N2.Text = "0"
        N3.Text = "0"
        N4.Text = "0"
        N5.Text = "0"
        N6.Text = "0"
        N7.Text = "0"
        N8.Text = "0"
        N9.Text = "0"
        N10.Text = "0"
        N11.Text = "0"
        N12.Text = "0"
    End Sub
    Public Sub dBConnect()
        If Not dB Is Nothing Then dB.Close()
        dB.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        dB.Open()
    End Sub
    Public Sub dBDisconnect()
        dB.Close()
    End Sub
    Public Sub fillDept()
        Dim squery As String = "select  * from tbl_dept"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            cboDept.Items.Add(sqltable.Rows(i)("dept_name"))
        Next
        dBDisconnect()
    End Sub
    Public Sub fillCourse()
        cboCourse.Items.Clear()
        Dim squery As String = "select  * from tbl_course where dept_no = '" & lblDNo.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            cboCourse.Items.Add(sqltable.Rows(i)("short"))
        Next
        dBDisconnect()
    End Sub

    Private Sub cboDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDept.SelectedIndexChanged
        Dim squery As String = "select  dept_no from tbl_dept where dept_name = '" & cboDept.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        lblDNo.Text = sqltable.Rows(0)("dept_no")
        dBDisconnect()
        fillCourse()
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        Dim squery As String = "select  * from tbl_course where short = '" & cboCourse.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        lblCourseName.Text = sqltable.Rows(0)("course_name")
        lblCourse.Text = sqltable.Rows(0)("course_id")
        dBDisconnect()
        cboYear.Items.Clear()
        If (lblDNo.Text = 1 Or lblDNo.Text = 2) Then
            For i = 1 To 4
                cboYear.Items.Add(i)
            Next
        Else
            For i = 1 To 3
                cboYear.Items.Add(i)
            Next
        End If
        fillcur()
    End Sub
    Public Sub fillcur()
        cboCur.Items.Clear()
        Dim squery As String = "select  * from tbl_cur where course_id = '" & lblCourse.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            cboCur.Items.Add(sqltable.Rows(i)("cur_name"))
        Next
        dBDisconnect()
    End Sub

    Private Sub cboCur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCur.SelectedIndexChanged
        Dim squery As String = "select  * from tbl_cur where cur_name = '" & cboCur.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        lblCurr.Text = sqltable.Rows(0)("cur_id")
        dBDisconnect()
    End Sub
    Private Sub ListView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If Not ListView1.SelectedItems.Count = 0 Then
            With ListView1.SelectedItems.Item(0)
                lblSC.Text = .Text
                lblSubD.Text = .SubItems(1).Text
                lblSC.Text = .Text
            End With
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        fAY = dtpCurYear.Text + "-" + dtpNexYear.Text
        If (lblSubD.Text = "" And lblSC.Text = "") Then
            MessageBox.Show("Please Select a Subject to be added")
        Else
            Dim squery As String = "select  * from tblsubj where SCode= '" & lblSC.Text & "' and SName= '" & lblSubD.Text & "' and SYear= '" & fAY & "'"
            Dim sadapter As New MySqlDataAdapter
            Dim scommand As New MySqlCommand
            Dim sqltable As New DataTable
            scommand.CommandText = squery
            scommand.Connection = dB
            sadapter.SelectCommand = scommand
            sadapter.Fill(sqltable)
            If (sqltable.Rows.Count >= 1) Then
                MessageBox.Show("Duplicate Entry!")
            Else
                CYN = MsgBox("Confirm Save?", MsgBoxStyle.YesNo, "Confirm")
                If CYN = MsgBoxResult.No Then
                    lblSC.Text = ""
                    lblSubD.Text = ""
                Else
                    dB.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
                    Try
                        dBConnect()
                        cmd.Connection = dB
                        cmd.CommandText = "INSERT INTO `tblsubj` (`SCode`, `SName`,`SYear`) " & _
                                            "VALUES ('" & lblSC.Text & "','" & lblSubD.Text & "','" & fAY & "');"
                        result = cmd.ExecuteNonQuery
                        cmd.CommandText = "INSERT INTO `tbltc` (`SCode`, `SW`,`Assign`,`Rec`,`Quiz`,`Att`,`Exam`,`Other`,`Proj`,SYear) " & _
                                 "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','0','0','" & fAY & "');"
                        result = cmd.ExecuteNonQuery
                        If result = 0 Then
                            MsgBox("Successfully saved")
                        Else
                            MsgBox("Successfully saved!")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    dBDisconnect()
                    addNI()
                    lblSC.Text = ""
                    lblSubD.Text = ""
                End If
            End If
        End If
        fillAY()
    End Sub
    Public Sub fillAY()
        cboAY.Items.Clear()
        Dim squery As String = "select distinct SYear from tbltc"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            cboAY.Items.Add(sqltable.Rows(i)("SYear"))
        Next
        dBDisconnect()
    End Sub

    Private Sub cboAY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAY.SelectedIndexChanged
        cboSubCode.Items.Clear()
        Dim squery As String = "select  SCode from tbltc where SYear = '" & cboAY.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            cboSubCode.Items.Add(sqltable.Rows(i)("SCode"))
        Next
        dBDisconnect()
    End Sub

    Private Sub cboSubCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubCode.SelectedIndexChanged
        Dim squery As String = "select  * from tblsubj where SYear = '" & cboAY.Text & "' and SCode = '" & cboSubCode.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        lblSD.Text = sqltable.Rows(0)("SName")
        dBDisconnect()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim squery As String = "select * from tbltc where SYear = '" & cboAY.Text & "' and SCode = '" & cboSubCode.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        If (sqltable.Rows.Count = "0") Then
            MessageBox.Show("Wrong Search input")
        Else
            txtSW.Text = sqltable.Rows(0)("SW")
            txtAss.Text = sqltable.Rows(0)("Assign")
            txtRec.Text = sqltable.Rows(0)("Rec")
            txtQuiz.Text = sqltable.Rows(0)("Quiz")
            txtAtt.Text = sqltable.Rows(0)("Att")
            txtProj.Text = sqltable.Rows(0)("Proj")
            txtExam.Text = sqltable.Rows(0)("Exam")
            txtOther.Text = sqltable.Rows(0)("Other")
            Conv2()
            GroupBox5.Enabled = True
            dBDisconnect()
            CheckAOG()
        End If
        
    End Sub
    Public Sub Conv2()
        a = Convert.ToDouble(txtSW.Text)
        a = a * 100
        txtSW.Text = a
        b = Convert.ToDouble(txtAss.Text)
        b = b * 100
        txtAss.Text = b
        c = Convert.ToDouble(txtRec.Text)
        c = c * 100
        txtRec.Text = c
        d = Convert.ToDouble(txtQuiz.Text)
        d = d * 100
        txtQuiz.Text = d
        e = Convert.ToDouble(txtAtt.Text)
        e = e * 100
        txtAtt.Text = e
        f = Convert.ToDouble(txtExam.Text)
        f = f * 100
        txtExam.Text = f
        g = Convert.ToDouble(txtOther.Text)
        g = g * 100
        txtOther.Text = g
        h = Convert.ToDouble(txtProj.Text)
        h = h * 100
        txtProj.Text = h
    End Sub
    Private Sub txtSW_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSW.Leave
        If (txtSW.Text = "" Or IsNumeric(txtSW.Text) = False) Then
            txtSW.Text = "0"
        End If

    End Sub

    Private Sub txtAss_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAss.Leave
        If (txtAss.Text = "" Or IsNumeric(txtAss.Text) = False) Then
            txtAss.Text = "0"
        End If
    End Sub

    Private Sub txtRec_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRec.Leave
        If (txtRec.Text = "" Or IsNumeric(txtRec.Text) = False) Then
            txtRec.Text = "0"
        End If
    End Sub

    Private Sub txtQuiz_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuiz.Leave
        If (txtQuiz.Text = "" Or IsNumeric(txtQuiz.Text) = False) Then
            txtQuiz.Text = "0"
        End If
    End Sub

    Private Sub txtAtt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAtt.Leave
        If (txtAtt.Text = "" Or IsNumeric(txtAtt.Text) = False) Then
            txtAtt.Text = "0"
        End If
    End Sub

    Private Sub txtExam_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExam.Leave
        If (txtExam.Text = "" Or IsNumeric(txtExam.Text) = False) Then
            txtExam.Text = "0"
        End If
    End Sub

    Private Sub txtOther_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOther.Leave
        If (txtOther.Text = "" Or IsNumeric(txtOther.Text) = False) Then
            txtOther.Text = "0"
        End If
    End Sub

    Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.Click
        Clr()
        lblSumTot.Text = Convert.ToInt32(txtSW.Text) + Convert.ToInt32(txtAss.Text) + Convert.ToInt32(txtRec.Text) + Convert.ToInt32(txtQuiz.Text) +
         Convert.ToInt32(txtAtt.Text) + Convert.ToInt32(txtExam.Text) + Convert.ToInt32(txtOther.Text) + Convert.ToInt32(txtProj.Text)
        If (lblSumTot.Text >= 101 Or lblSumTot.Text < 100) Then
            MessageBox.Show("Wrong input!")
        Else
            Conv()
            dB.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
            Try
                dBConnect()
                cmd.Connection = dB
                cmd.CommandText = "UPDATE tbltc SET SW = '" & txtSW.Text & "',Assign= '" & txtAss.Text & "',Rec = '" & txtRec.Text & "',Quiz = '" & txtQuiz.Text & "',Att = '" & txtAtt.Text & "',Other = '" & txtOther.Text & "',Exam = '" & txtExam.Text & "',Proj = '" & txtProj.Text & "' where SYear = '" & cboAY.Text & "' and SCode = '" & cboSubCode.Text & "';"
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Successfully saved")
                    Conv2()
                Else
                    MsgBox("Successfully saved!")
                    Conv2()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            dBDisconnect()
        End If
        Clr()
         CheckAOG()
    End Sub
    Public Sub Conv()
        a = Convert.ToDouble(txtSW.Text)
        a = a / 100
        txtSW.Text = a
        b = Convert.ToDouble(txtAss.Text)
        b = b / 100
        txtAss.Text = b
        c = Convert.ToDouble(txtRec.Text)
        c = c / 100
        txtRec.Text = c
        d = Convert.ToDouble(txtQuiz.Text)
        d = d / 100
        txtQuiz.Text = d
        e = Convert.ToDouble(txtAtt.Text)
        e = e / 100
        txtAtt.Text = e
        f = Convert.ToDouble(txtExam.Text)
        f = f / 100
        txtExam.Text = f
        g = Convert.ToDouble(txtOther.Text)
        g = g / 100
        txtOther.Text = g
        h = Convert.ToDouble(txtProj.Text)
        h = h / 100
        txtProj.Text = h
    End Sub

    Private Sub txtProj_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProj.Leave
        If (txtProj.Text = "" Or IsNumeric(txtProj.Text) = False) Then
            txtProj.Text = "0"
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If (NI.Focus = True) Then
            Button2.PerformClick()
        ElseIf (AOG.Focus = True) Then
            Button2.PerformClick()
            Clr()
        End If
    End Sub

    Private Sub rbF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbF.CheckedChanged
        ListView1.Items.Clear()
        If (rbF.Checked = True) Then
            Dim squery As String = "select  * from tbl_subject where course_id = '" & lblCourse.Text & "' and cur_id = '" & lblCurr.Text & "' and year = '" & cboYear.Text & "'  and sem = '" & rbF.Text & "'"
            Dim sadapter As New MySqlDataAdapter
            Dim scommand As New MySqlCommand
            Dim sqltable As New DataTable
            Dim i As Integer
            scommand.CommandText = squery
            scommand.Connection = dB
            sadapter.SelectCommand = scommand
            sadapter.Fill(sqltable)
            If (sqltable.Rows.Count = 0) Then
                MessageBox.Show("No Data found!", "Error")
            End If
            For i = 0 To sqltable.Rows.Count - 1
                With ListView1
                    .Items.Add(sqltable.Rows(i)("sub_code"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(sqltable.Rows(i)("des_title"))
                    End With
                End With
            Next
        End If
        dBDisconnect()
    End Sub

    Private Sub rbS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbS.CheckedChanged
        ListView1.Items.Clear()
        If (rbS.Checked = True) Then
            Dim squery As String = "select  * from tbl_subject where course_id = '" & lblCourse.Text & "' and cur_id = '" & lblCurr.Text & "' and year = '" & cboYear.Text & "'  and sem = '" & rbS.Text & "'"
            Dim sadapter As New MySqlDataAdapter
            Dim scommand As New MySqlCommand
            Dim sqltable As New DataTable
            Dim i As Integer
            scommand.CommandText = squery
            scommand.Connection = dB
            sadapter.SelectCommand = scommand
            sadapter.Fill(sqltable)
            If (sqltable.Rows.Count = 0) Then
                MessageBox.Show("No Data found!", "Error")
            End If
            For i = 0 To sqltable.Rows.Count - 1
                With ListView1
                    .Items.Add(sqltable.Rows(i)("sub_code"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(sqltable.Rows(i)("des_title"))
                    End With
                End With
            Next
        End If
        dBDisconnect()
    End Sub

    Private Sub radPre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPre.CheckedChanged
        If (radPre.Checked = True) Then
            lblPTerm.Text = "P"
        End If
    End Sub

    Private Sub radMid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMid.CheckedChanged
        If (radMid.Checked = True) Then
            lblPTerm.Text = "M"
        End If
    End Sub

    Private Sub radFin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFin.CheckedChanged
        If (radFin.Checked = True) Then
            lblPTerm.Text = "F"
        End If
    End Sub
    Public Sub addNI()
        dB.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Try
            dBConnect()
                cmd.Connection = dB
            'NI ASSIGNMENT
            cmd.CommandText = "INSERT INTO tbltass (SCode,NT1,NT2,NT3,NT4,NT5,NT6,NT7,NT8,NT9,NT10,NT11,NT12,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','P','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltass (SCode,NT1,NT2,NT3,NT4,NT5,NT6,NT7,NT8,NT9,NT10,NT11,NT12,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','M','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltass (SCode,NT1,NT2,NT3,NT4,NT5,NT6,NT7,NT8,NT9,NT10,NT11,NT12,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','F','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            'NI QUIZ
            cmd.CommandText = "INSERT INTO tbltquiz (SCode,NT1,NT2,NT3,NT4,NT5,NT6,NT7,NT8,NT9,NT10,NT11,NT12,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','P','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltquiz (SCode,NT1,NT2,NT3,NT4,NT5,NT6,NT7,NT8,NT9,NT10,NT11,NT12,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','M','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltquiz (SCode,NT1,NT2,NT3,NT4,NT5,NT6,NT7,NT8,NT9,NT10,NT11,NT12,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','F','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            'NI SEATWORK
            cmd.CommandText = "INSERT INTO tbltseatwork (SCode,NT1,NT2,NT3,NT4,NT5,NT6,NT7,NT8,NT9,NT10,NT11,NT12,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','P','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltseatwork (SCode,NT1,NT2,NT3,NT4,NT5,NT6,NT7,NT8,NT9,NT10,NT11,NT12,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','M','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltseatwork (SCode,NT1,NT2,NT3,NT4,NT5,NT6,NT7,NT8,NT9,NT10,NT11,NT12,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','F','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            'NI Recitation
            cmd.CommandText = "INSERT INTO tbltrec (SCode,NT1,NT2,NT3,NT4,NT5,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','P','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltrec (SCode,NT1,NT2,NT3,NT4,NT5,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','M','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltrec (SCode,NT1,NT2,NT3,NT4,NT5,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','F','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            'NI PROJECT
            cmd.CommandText = "INSERT INTO tbltproj (SCode,NT1,NT2,NT3,NT4,NT5,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','P','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltproj (SCode,NT1,NT2,NT3,NT4,NT5,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','M','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltproj (SCode,NT1,NT2,NT3,NT4,NT5,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','F','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            'NI OTher
            cmd.CommandText = "INSERT INTO tbltother (SCode,NT1,NT2,NT3,NT4,NT5,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','P','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltother (SCode,NT1,NT2,NT3,NT4,NT5,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','M','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltother (SCode,NT1,NT2,NT3,NT4,NT5,Tot,PTerm,NumTot,SYear) " & _
                            "VALUES ('" & lblSC.Text & "','0','0','0','0','0','0','F','0','" & fAY & "');"
            result = cmd.ExecuteNonQuery
            'NI EXAM
            cmd.CommandText = "INSERT INTO tbltexam (SCode,TE,PTerm,SYear,Numtot) " & _
                               "VALUES ('" & lblSC.Text & "','0','P','" & fAY & "','1');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltexam (SCode,TE,PTerm,SYear,Numtot) " & _
                               "VALUES ('" & lblSC.Text & "','0','M','" & fAY & "','1');"
            result = cmd.ExecuteNonQuery
            cmd.CommandText = "INSERT INTO tbltexam (SCode,TE,PTerm,SYear,Numtot) " & _
                               "VALUES ('" & lblSC.Text & "','0','F','" & fAY & "','1');"
            result = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dBDisconnect()
    End Sub

    Private Sub cboAoG_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAoG.SelectedIndexChanged
        Clr()
        txtNI.Enabled = True : cmdOK.Enabled = True
        N1.Enabled = False : N2.Enabled = False : N3.Enabled = False : N4.Enabled = False : N5.Enabled = False : N6.Enabled = False : N7.Enabled = False : N8.Enabled = False : N9.Enabled = False : N10.Enabled = False : N11.Enabled = False : N12.Enabled = False
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        If (cboAoG.Text = "Assignment") Then
            Dim squery As String = "select  * from tbltass where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("NT1") : N2.Text = sqltable.Rows(0)("NT2") : N3.Text = sqltable.Rows(0)("NT3") : N4.Text = sqltable.Rows(0)("NT4") : N5.Text = sqltable.Rows(0)("NT5") : N6.Text = sqltable.Rows(0)("NT6") : N7.Text = sqltable.Rows(0)("NT7") : N8.Text = sqltable.Rows(0)("NT8") : N9.Text = sqltable.Rows(0)("NT9") : N10.Text = sqltable.Rows(0)("NT10") : N11.Text = sqltable.Rows(0)("NT11") : N12.Text = sqltable.Rows(0)("NT12")
            lblNTot.Text = sqltable.Rows(0)("Tot") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        ElseIf (cboAoG.Text = "Quiz") Then
            Dim squery As String = "select  * from tbltquiz where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("NT1") : N2.Text = sqltable.Rows(0)("NT2") : N3.Text = sqltable.Rows(0)("NT3") : N4.Text = sqltable.Rows(0)("NT4") : N5.Text = sqltable.Rows(0)("NT5") : N6.Text = sqltable.Rows(0)("NT6") : N7.Text = sqltable.Rows(0)("NT7") : N8.Text = sqltable.Rows(0)("NT8") : N9.Text = sqltable.Rows(0)("NT9") : N10.Text = sqltable.Rows(0)("NT10") : N11.Text = sqltable.Rows(0)("NT11") : N12.Text = sqltable.Rows(0)("NT12")
            lblNTot.Text = sqltable.Rows(0)("Tot") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        ElseIf (cboAoG.Text = "Seatwork") Then
            Dim squery As String = "select  * from tbltseatwork where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("NT1") : N2.Text = sqltable.Rows(0)("NT2") : N3.Text = sqltable.Rows(0)("NT3") : N4.Text = sqltable.Rows(0)("NT4") : N5.Text = sqltable.Rows(0)("NT5") : N6.Text = sqltable.Rows(0)("NT6") : N7.Text = sqltable.Rows(0)("NT7") : N8.Text = sqltable.Rows(0)("NT8") : N9.Text = sqltable.Rows(0)("NT9") : N10.Text = sqltable.Rows(0)("NT10") : N11.Text = sqltable.Rows(0)("NT11") : N12.Text = sqltable.Rows(0)("NT12")
            lblNTot.Text = sqltable.Rows(0)("Tot") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        ElseIf (cboAoG.Text = "Recitation") Then
            Dim squery As String = "select  * from tbltrec where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("NT1") : N2.Text = sqltable.Rows(0)("NT2") : N3.Text = sqltable.Rows(0)("NT3") : N4.Text = sqltable.Rows(0)("NT4") : N5.Text = sqltable.Rows(0)("NT5")
            lblNTot.Text = sqltable.Rows(0)("Tot") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        ElseIf (cboAoG.Text = "Project") Then
            Dim squery As String = "select  * from tbltproj where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("NT1") : N2.Text = sqltable.Rows(0)("NT2") : N3.Text = sqltable.Rows(0)("NT3") : N4.Text = sqltable.Rows(0)("NT4") : N5.Text = sqltable.Rows(0)("NT5")
            lblNTot.Text = sqltable.Rows(0)("Tot") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        ElseIf (cboAoG.Text = "Other") Then
            Dim squery As String = "select  * from tbltother where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("NT1") : N2.Text = sqltable.Rows(0)("NT2") : N3.Text = sqltable.Rows(0)("NT3") : N4.Text = sqltable.Rows(0)("NT4") : N5.Text = sqltable.Rows(0)("NT5")
            lblNTot.Text = sqltable.Rows(0)("Tot") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        ElseIf (cboAoG.Text = "Examination") Then
            Dim squery As String = "select  * from tbltexam where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("TE")
            lblNTot.Text = sqltable.Rows(0)("TE") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        End If
        dBDisconnect()
    End Sub

    Private Sub N1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N1.Leave
        If (N1.Text = "" Or IsNumeric(N1.Text) = False) Then
            N1.Text = "0"
        End If
        lblNTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
    End Sub

    Private Sub N2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N2.Leave
        If (N2.Text = "" Or IsNumeric(N2.Text) = False) Then
            N2.Text = "0"
        End If
        lblNTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)

    End Sub

    Private Sub N3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N3.Leave
        If (N3.Text = "" Or IsNumeric(N3.Text) = False) Then
            N3.Text = "0"
        End If
        lblNTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)

    End Sub

    Private Sub N4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N4.Leave
        If (N4.Text = "" Or IsNumeric(N4.Text) = False) Then
            N4.Text = "0"
        End If
        lblNTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)

    End Sub

    Private Sub N5_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N5.Leave
        If (N5.Text = "" Or IsNumeric(N5.Text) = False) Then
            N5.Text = "0"
        End If
        lblNTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)

    End Sub

    Private Sub N6_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N6.Leave
        If (N6.Text = "" Or IsNumeric(N6.Text) = False) Then
            N6.Text = "0"
        End If
        lblNTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)

    End Sub

    Private Sub N7_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N7.Leave
        If (N7.Text = "" Or IsNumeric(N7.Text) = False) Then
            N7.Text = "0"
        End If
        lblNTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)

    End Sub

    Private Sub N8_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N8.Leave
        If (N8.Text = "" Or IsNumeric(N8.Text) = False) Then
            N8.Text = "0"
        End If
        lblNTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)

    End Sub

    Private Sub N9_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N9.Leave
        If (N9.Text = "" Or IsNumeric(N9.Text) = False) Then
            N9.Text = "0"
        End If
        lblNTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)

    End Sub

    Private Sub N10_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N10.Leave
        If (N10.Text = "" Or IsNumeric(N10.Text) = False) Then
            N10.Text = "0"
        End If
        lblNTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)

    End Sub

    Private Sub N11_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N11.Leave
        If (N11.Text = "" Or IsNumeric(N11.Text) = False) Then
            N11.Text = "0"
        End If
        lblNTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)

    End Sub

    Private Sub N12_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N12.Leave
        If (N12.Text = "" Or IsNumeric(N12.Text) = False) Then
            N12.Text = "0"
        End If
        lblNTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
    End Sub
    Public Sub checkTNum()
        N1.Enabled = False : N2.Enabled = False : N3.Enabled = False : N4.Enabled = False : N5.Enabled = False : N6.Enabled = False : N7.Enabled = False : N8.Enabled = False : N9.Enabled = False : N10.Enabled = False : N11.Enabled = False : N12.Enabled = False
        If (totalnum.Text = "1") Then
            N1.Enabled = True
        ElseIf (totalnum.Text = "2") Then
            N1.Enabled = True : N2.Enabled = True
        ElseIf (totalnum.Text = "3") Then
            N1.Enabled = True : N2.Enabled = True : N3.Enabled = True
        ElseIf (totalnum.Text = "4") Then
            N1.Enabled = True : N2.Enabled = True : N3.Enabled = True : N4.Enabled = True
        ElseIf (totalnum.Text = "5") Then
            N1.Enabled = True : N2.Enabled = True : N3.Enabled = True : N4.Enabled = True : N5.Enabled = True
        ElseIf (totalnum.Text = "6") Then
            N1.Enabled = True : N2.Enabled = True : N3.Enabled = True : N4.Enabled = True : N5.Enabled = True : N6.Enabled = True
        ElseIf (totalnum.Text = "7") Then
            N1.Enabled = True : N2.Enabled = True : N3.Enabled = True : N4.Enabled = True : N5.Enabled = True : N6.Enabled = True : N7.Enabled = True
        ElseIf (totalnum.Text = "8") Then
            N1.Enabled = True : N2.Enabled = True : N3.Enabled = True : N4.Enabled = True : N5.Enabled = True : N6.Enabled = True : N7.Enabled = True : N8.Enabled = True
        ElseIf (totalnum.Text = "9") Then
            N1.Enabled = True : N2.Enabled = True : N3.Enabled = True : N4.Enabled = True : N5.Enabled = True : N6.Enabled = True : N7.Enabled = True : N8.Enabled = True : N9.Enabled = True
        ElseIf (totalnum.Text = "10") Then
            N1.Enabled = True : N2.Enabled = True : N3.Enabled = True : N4.Enabled = True : N5.Enabled = True : N6.Enabled = True : N7.Enabled = True : N8.Enabled = True : N9.Enabled = True : N10.Enabled = True
        ElseIf (totalnum.Text = "11") Then
            N1.Enabled = True : N2.Enabled = True : N3.Enabled = True : N4.Enabled = True : N5.Enabled = True : N6.Enabled = True : N7.Enabled = True : N8.Enabled = True : N9.Enabled = True : N10.Enabled = True : N11.Enabled = True
        ElseIf (totalnum.Text = "12") Then
            N1.Enabled = True : N2.Enabled = True : N3.Enabled = True : N4.Enabled = True : N5.Enabled = True : N6.Enabled = True : N7.Enabled = True : N8.Enabled = True : N9.Enabled = True : N10.Enabled = True : N11.Enabled = True : N12.Enabled = True
        End If
    End Sub

    Private Sub txtNI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNI.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            txtNI.Text = ""
            e.Handled = True
        End If
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        dB.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        dBConnect()
        cmd.Connection = dB
        If (txtNI.Text = "" Or txtNI.Text = "0") Then
            MessageBox.Show("Invalid input!")
        Else
        If (cboAoG.Text = "Assignment") Then
            Try
                cmd.CommandText = "UPDATE tbltass SET NumTot= '" & txtNI.Text & "' where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "' ;"
                result = cmd.ExecuteNonQuery
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf (cboAoG.Text = "Quiz") Then
                Try
                    cmd.CommandText = "UPDATE tbltquiz SET NumTot= '" & txtNI.Text & "' where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "' ;"
                    result = cmd.ExecuteNonQuery
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
        ElseIf (cboAoG.Text = "Seatwork") Then
                Try
                    cmd.CommandText = "UPDATE tbltseatwork SET NumTot= '" & txtNI.Text & "' where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "' ;"
                    result = cmd.ExecuteNonQuery
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf (cboAoG.Text = "Recitation") Then
                If (txtNI.Text >= 6) Then
                    MessageBox.Show("Wrong Input!")
                Else
                    Try
                        cmd.CommandText = "UPDATE tbltrec SET NumTot= '" & txtNI.Text & "' where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "' ;"
                        result = cmd.ExecuteNonQuery
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            ElseIf (cboAoG.Text = "Project") Then
                If (txtNI.Text >= 6) Then
                    MessageBox.Show("Wrong Input!")
                Else
                    Try
                        cmd.CommandText = "UPDATE tbltproj SET NumTot= '" & txtNI.Text & "' where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "' ;"
                        result = cmd.ExecuteNonQuery

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            ElseIf (cboAoG.Text = "Other") Then
                If (txtNI.Text >= 6) Then
                    MessageBox.Show("Wrong Input!")
                Else
                    Try
                        cmd.CommandText = "UPDATE tbltother SET NumTot= '" & txtNI.Text & "' where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "' ;"
                        result = cmd.ExecuteNonQuery
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            ElseIf (cboAoG.Text = "Examination") Then
                    MessageBox.Show("Only One item!")
                End If
                dBDisconnect()
        End If
        Checking()
        checkTNum()
        txtNI.Text = ""
    End Sub
    Public Sub Checking()
        txtNI.Enabled = True : cmdOK.Enabled = True
        N1.Enabled = False : N2.Enabled = False : N3.Enabled = False : N4.Enabled = False : N5.Enabled = False : N6.Enabled = False : N7.Enabled = False : N8.Enabled = False : N9.Enabled = False : N10.Enabled = False : N11.Enabled = False : N12.Enabled = False
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        If (cboAoG.Text = "Assignment") Then
            Dim squery As String = "select  * from tbltass where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("NT1") : N2.Text = sqltable.Rows(0)("NT2") : N3.Text = sqltable.Rows(0)("NT3") : N4.Text = sqltable.Rows(0)("NT4") : N5.Text = sqltable.Rows(0)("NT5") : N6.Text = sqltable.Rows(0)("NT6") : N7.Text = sqltable.Rows(0)("NT7") : N8.Text = sqltable.Rows(0)("NT8") : N9.Text = sqltable.Rows(0)("NT9") : N10.Text = sqltable.Rows(0)("NT10") : N11.Text = sqltable.Rows(0)("NT11") : N12.Text = sqltable.Rows(0)("NT12")
            lblNTot.Text = sqltable.Rows(0)("Tot") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        ElseIf (cboAoG.Text = "Quiz") Then
            Dim squery As String = "select  * from tbltquiz where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("NT1") : N2.Text = sqltable.Rows(0)("NT2") : N3.Text = sqltable.Rows(0)("NT3") : N4.Text = sqltable.Rows(0)("NT4") : N5.Text = sqltable.Rows(0)("NT5") : N6.Text = sqltable.Rows(0)("NT6") : N7.Text = sqltable.Rows(0)("NT7") : N8.Text = sqltable.Rows(0)("NT8") : N9.Text = sqltable.Rows(0)("NT9") : N10.Text = sqltable.Rows(0)("NT10") : N11.Text = sqltable.Rows(0)("NT11") : N12.Text = sqltable.Rows(0)("NT12")
            lblNTot.Text = sqltable.Rows(0)("Tot") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        ElseIf (cboAoG.Text = "Seatwork") Then
            Dim squery As String = "select  * from tbltseatwork where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("NT1") : N2.Text = sqltable.Rows(0)("NT2") : N3.Text = sqltable.Rows(0)("NT3") : N4.Text = sqltable.Rows(0)("NT4") : N5.Text = sqltable.Rows(0)("NT5") : N6.Text = sqltable.Rows(0)("NT6") : N7.Text = sqltable.Rows(0)("NT7") : N8.Text = sqltable.Rows(0)("NT8") : N9.Text = sqltable.Rows(0)("NT9") : N10.Text = sqltable.Rows(0)("NT10") : N11.Text = sqltable.Rows(0)("NT11") : N12.Text = sqltable.Rows(0)("NT12")
            lblNTot.Text = sqltable.Rows(0)("Tot") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        ElseIf (cboAoG.Text = "Recitation") Then
            Dim squery As String = "select  * from tbltrec where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("NT1") : N2.Text = sqltable.Rows(0)("NT2") : N3.Text = sqltable.Rows(0)("NT3") : N4.Text = sqltable.Rows(0)("NT4") : N5.Text = sqltable.Rows(0)("NT5")
            lblNTot.Text = sqltable.Rows(0)("Tot") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        ElseIf (cboAoG.Text = "Project") Then
            Dim squery As String = "select  * from tbltproj where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("NT1") : N2.Text = sqltable.Rows(0)("NT2") : N3.Text = sqltable.Rows(0)("NT3") : N4.Text = sqltable.Rows(0)("NT4") : N5.Text = sqltable.Rows(0)("NT5")
            lblNTot.Text = sqltable.Rows(0)("Tot") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        ElseIf (cboAoG.Text = "Other") Then
            Dim squery As String = "select  * from tbltother where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("NT1") : N2.Text = sqltable.Rows(0)("NT2") : N3.Text = sqltable.Rows(0)("NT3") : N4.Text = sqltable.Rows(0)("NT4") : N5.Text = sqltable.Rows(0)("NT5")
            lblNTot.Text = sqltable.Rows(0)("Tot") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        ElseIf (cboAoG.Text = "Examination") Then
            Dim squery As String = "select  * from tbltexam where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            N1.Text = sqltable.Rows(0)("TE")
            lblNTot.Text = sqltable.Rows(0)("TE") : totalnum.Text = sqltable.Rows(0)("NumTot")
            If (totalnum.Text = 0) Then
                txtNI.Enabled = True : cmdOK.Enabled = True
            Else
                checkTNum()
            End If
        End If
        dBDisconnect()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        dB.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        If (cboAoG.Text = "Assignment") Then
            Try
                dBConnect()
                cmd.Connection = dB
                cmd.CommandText = "UPDATE tbltass SET NT1 = '" & N1.Text & "',NT2  = '" & N2.Text & "',NT3  = '" & N3.Text & "',NT4  = '" & N4.Text & "',NT5  = '" & N5.Text & "',NT6  = '" & N6.Text & "',NT7  = '" & N7.Text & "',NT8  = '" & N8.Text & "',NT9  = '" & N9.Text & "',NT10  = '" & N10.Text & "',NT11  = '" & N11.Text & "',NT12  = '" & N12.Text & "',Tot  = '" & lblNTot.Text & "'where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "';"
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Data has been Edited!")
                Else
                    MsgBox("Successfully saved!")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf (cboAoG.Text = "Quiz") Then
            Try
                dBConnect()
                cmd.Connection = dB
                cmd.CommandText = "UPDATE tbltquiz SET NT1 = '" & N1.Text & "',NT2  = '" & N2.Text & "',NT3  = '" & N3.Text & "',NT4  = '" & N4.Text & "',NT5  = '" & N5.Text & "',NT6  = '" & N6.Text & "',NT7  = '" & N7.Text & "',NT8  = '" & N8.Text & "',NT9  = '" & N9.Text & "',NT10  = '" & N10.Text & "',NT11  = '" & N11.Text & "',NT12  = '" & N12.Text & "',Tot  = '" & lblNTot.Text & "'where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "';"
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Data has been Edited!")
                Else
                    MsgBox("Successfully saved!")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf (cboAoG.Text = "Seatwork") Then
            Try
               dBConnect()
                cmd.Connection = dB
                cmd.CommandText = "UPDATE tbltseatwork SET NT1 = '" & N1.Text & "',NT2  = '" & N2.Text & "',NT3  = '" & N3.Text & "',NT4  = '" & N4.Text & "',NT5  = '" & N5.Text & "',NT6  = '" & N6.Text & "',NT7  = '" & N7.Text & "',NT8  = '" & N8.Text & "',NT9  = '" & N9.Text & "',NT10  = '" & N10.Text & "',NT11  = '" & N11.Text & "',NT12  = '" & N12.Text & "',Tot  = '" & lblNTot.Text & "'where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "';"
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Data has been Edited!")
                Else
                    MsgBox("Successfully saved!")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf (cboAoG.Text = "Recitation") Then
            Try
               dBConnect()
                cmd.Connection = dB
                cmd.CommandText = "UPDATE tbltrec SET NT1 = '" & N1.Text & "',NT2  = '" & N2.Text & "',NT3  = '" & N3.Text & "',NT4  = '" & N4.Text & "',NT5  = '" & N5.Text & "',Tot  = '" & lblNTot.Text & "'where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "';"
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Data has been Edited!")
                Else
                    MsgBox("Successfully saved!")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf (cboAoG.Text = "Project") Then
            Try
               dBConnect()
                cmd.Connection = dB
                cmd.CommandText = "UPDATE tbltproj SET NT1 = '" & N1.Text & "',NT2  = '" & N2.Text & "',NT3  = '" & N3.Text & "',NT4  = '" & N4.Text & "',NT5  = '" & N5.Text & "',Tot  = '" & lblNTot.Text & "'where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "';"
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Data has been Edited!")
                Else
                    MsgBox("Successfully saved!")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf (cboAoG.Text = "Other") Then
            Try
               dBConnect()
                cmd.Connection = dB
                cmd.CommandText = "UPDATE tbltother SET NT1 = '" & N1.Text & "',NT2  = '" & N2.Text & "',NT3  = '" & N3.Text & "',NT4  = '" & N4.Text & "',NT5  = '" & N5.Text & "',Tot  = '" & lblNTot.Text & "'where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "';"
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Data has been Edited!")
                Else
                    MsgBox("Successfully saved!")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf (cboAoG.Text = "Examination") Then
            Try
                dBConnect()
                cmd.Connection = dB
                cmd.CommandText = "UPDATE tbltexam SET TE = '" & N1.Text & "',TE  = '" & lblNTot.Text & "'where SCode='" & cboSubCode.Text & "' and PTerm='" & lblPTerm.Text & "' and SYear='" & cboAY.Text & "';"
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Data has been Edited!")
                Else
                    MsgBox("Successfully saved!")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        dBDisconnect()
    End Sub

    Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        cmdSave.PerformClick()
        If (cboAoG.SelectedIndex > 0) Then
            cboAoG.SelectedIndex = cboAoG.SelectedIndex - 1
        End If
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        cmdSave.PerformClick()
        If (cboAoG.SelectedIndex < cboAoG.Items.Count - 1) Then
            cboAoG.SelectedIndex = cboAoG.SelectedIndex + 1
        End If
    End Sub
    Public Sub CheckAOG()
        cboAoG.Items.Clear()
        Dim squery As String = "select  * from tbltc where SYear = '" & cboAY.Text & "' and SCode = '" & cboSubCode.Text & "' "
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        a1 = sqltable.Rows(0)("Assign")
        q2 = sqltable.Rows(0)("Quiz")
        s3 = sqltable.Rows(0)("SW")
        r4 = sqltable.Rows(0)("Rec")
        p5 = sqltable.Rows(0)("Proj")
        o6 = sqltable.Rows(0)("Other")
        e7 = sqltable.Rows(0)("Exam")
        If (a1 > 0) Then
            cboAoG.Items.Add("Assignment")
        End If
        If (q2 > 0) Then
            cboAoG.Items.Add("Quiz")
        End If
        If (s3 > 0) Then
            cboAoG.Items.Add("Seatwork")
        End If
        If (r4 > 0) Then
            cboAoG.Items.Add("Recitation")
        End If
        If (p5 > 0) Then
            cboAoG.Items.Add("Project")
        End If
        If (o6 > 0) Then
            cboAoG.Items.Add("Other")
        End If
        If (e7 > 0) Then
            cboAoG.Items.Add("Examination")
        End If
        dBDisconnect()
    End Sub
    Private Sub dtpCurYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCurYear.SelectedIndexChanged
        dtpNexYear.Text = dtpCurYear.Text + 1
    End Sub
End Class