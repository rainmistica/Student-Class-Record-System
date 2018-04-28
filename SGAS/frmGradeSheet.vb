Imports MySql.Data.MySqlClient
Public Class frmgradesheet
    Dim ExitYN, CYN As System.Windows.Forms.DialogResult
    Dim dB As New MySqlConnection
    Dim DatabaseName As String = "dbclassrec"
    Dim server As String = "localhost"
    Dim userName As String = "root"
    Dim password As String = "1234"
    Dim result As Integer
    Dim cmd As New MySqlCommand
    Dim x, y, z, a As Double
    Dim ass, ex, oth, pro, qu, re, se As Double
    Dim a1, q2, s3, r4, p5, o6, e7 As Double
    Private Sub frmGradeSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dBConnect()
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
    Public Sub dBConnect()
        If Not dB Is Nothing Then dB.Close()
        dB.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        dB.Open()
    End Sub
    Public Sub dBDisconnect()
        dB.Close()
    End Sub
    Public Sub LoadFile()
        ListView1.Items.Clear()
        Dim squery As String = "select  * from tblgradesheet,tblstudlist where status = 'ENROLLED' AND Snum=StudNum  AND SYear='" & cboAY.Text & "' AND SCode='" & cboSubCode.Text & "' AND Course='" & cboCourse.Text & "' AND Section='" & cboSec.Text & "'  AND Term='" & lblGP.Text & "' order by tblgradesheet.lname ASC"
        Dim i As Integer
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            With ListView1
                .Items.Add(sqltable.Rows(i)("SNum"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(sqltable.Rows(i)("LName"))
                    .Add(sqltable.Rows(i)("FName"))
                End With
            End With
        Next
        dBDisconnect()
    End Sub

    Private Sub cboAoG_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAoG.SelectedIndexChanged       
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim halted As Integer
        If (cboAoG.Text = "Assignment") Then
            Dim squery As String = "select  * from tblass,tbltass where tblass.SCode= '" & lblSC.Text & "' and tbltass.SCode= '" & lblSC.Text & "' and Term = '" & lblGP.Text & "' and Pterm= '" & lblGP.Text & "' and SNum= '" & lblSNum.Text & "'  and tbltass.SYear= '" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            If (sqltable.Rows.Count = 0) Then
                MessageBox.Show("Select Student First!", "Confirm")
                halted = 1
            Else
                totalnum.Text = sqltable.Rows(0)("NumTot")
                checkTNum()
                N1.Text = sqltable.Rows(0)("N1") : N2.Text = sqltable.Rows(0)("N2") : N3.Text = sqltable.Rows(0)("N3") : N4.Text = sqltable.Rows(0)("N4") : N5.Text = sqltable.Rows(0)("N5") : N6.Text = sqltable.Rows(0)("N6") : N7.Text = sqltable.Rows(0)("N7") : N8.Text = sqltable.Rows(0)("N8") : N9.Text = sqltable.Rows(0)("N9") : N10.Text = sqltable.Rows(0)("N10") : N11.Text = sqltable.Rows(0)("N11") : N12.Text = sqltable.Rows(0)("N12")
                NT1.Text = sqltable.Rows(0)("NT1") : NT2.Text = sqltable.Rows(0)("NT2") : NT3.Text = sqltable.Rows(0)("NT3") : NT4.Text = sqltable.Rows(0)("NT4") : NT5.Text = sqltable.Rows(0)("NT5") : NT6.Text = sqltable.Rows(0)("NT6") : NT7.Text = sqltable.Rows(0)("NT7") : NT8.Text = sqltable.Rows(0)("NT8") : NT9.Text = sqltable.Rows(0)("NT9") : NT10.Text = sqltable.Rows(0)("NT10") : NT11.Text = sqltable.Rows(0)("NT11") : NT12.Text = sqltable.Rows(0)("NT12")
            End If
        ElseIf (cboAoG.Text = "Quiz") Then
            Dim squery As String = "select  * from tblquiz,tbltquiz where tblquiz.SCode= '" & lblSC.Text & "' and tbltquiz.SCode= '" & lblSC.Text & "' and Term = '" & lblGP.Text & "' and Pterm= '" & lblGP.Text & "' and SNum= '" & lblSNum.Text & "' and tbltquiz.SYear= '" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            If (sqltable.Rows.Count = 0) Then
                MessageBox.Show("Select Student First!", "Confirm")
                halted = 1
            Else
                totalnum.Text = sqltable.Rows(0)("NumTot")
                checkTNum()
                N1.Text = sqltable.Rows(0)("N1") : N2.Text = sqltable.Rows(0)("N2") : N3.Text = sqltable.Rows(0)("N3") : N4.Text = sqltable.Rows(0)("N4") : N5.Text = sqltable.Rows(0)("N5") : N6.Text = sqltable.Rows(0)("N6") : N7.Text = sqltable.Rows(0)("N7") : N8.Text = sqltable.Rows(0)("N8") : N9.Text = sqltable.Rows(0)("N9") : N10.Text = sqltable.Rows(0)("N10") : N11.Text = sqltable.Rows(0)("N11") : N12.Text = sqltable.Rows(0)("N12")
                NT1.Text = sqltable.Rows(0)("NT1") : NT2.Text = sqltable.Rows(0)("NT2") : NT3.Text = sqltable.Rows(0)("NT3") : NT4.Text = sqltable.Rows(0)("NT4") : NT5.Text = sqltable.Rows(0)("NT5") : NT6.Text = sqltable.Rows(0)("NT6") : NT7.Text = sqltable.Rows(0)("NT7") : NT8.Text = sqltable.Rows(0)("NT8") : NT9.Text = sqltable.Rows(0)("NT9") : NT10.Text = sqltable.Rows(0)("NT10") : NT11.Text = sqltable.Rows(0)("NT11") : NT12.Text = sqltable.Rows(0)("NT12")
            End If
        ElseIf (cboAoG.Text = "Seatwork") Then
            Dim squery As String = "select  * from tblseatwork,tbltseatwork where tblseatwork.SCode= '" & lblSC.Text & "' and tbltseatwork.SCode= '" & lblSC.Text & "' and Term = '" & lblGP.Text & "' and Pterm= '" & lblGP.Text & "' and SNum= '" & lblSNum.Text & "' and tbltseatwork.SYear= '" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            If (sqltable.Rows.Count = 0) Then
                MessageBox.Show("Select Student First!", "Confirm")
                halted = 1
            Else
                totalnum.Text = sqltable.Rows(0)("NumTot")
                checkTNum()
                N1.Text = sqltable.Rows(0)("N1") : N2.Text = sqltable.Rows(0)("N2") : N3.Text = sqltable.Rows(0)("N3") : N4.Text = sqltable.Rows(0)("N4") : N5.Text = sqltable.Rows(0)("N5") : N6.Text = sqltable.Rows(0)("N6") : N7.Text = sqltable.Rows(0)("N7") : N8.Text = sqltable.Rows(0)("N8") : N9.Text = sqltable.Rows(0)("N9") : N10.Text = sqltable.Rows(0)("N10") : N11.Text = sqltable.Rows(0)("N11") : N12.Text = sqltable.Rows(0)("N12")
                NT1.Text = sqltable.Rows(0)("NT1") : NT2.Text = sqltable.Rows(0)("NT2") : NT3.Text = sqltable.Rows(0)("NT3") : NT4.Text = sqltable.Rows(0)("NT4") : NT5.Text = sqltable.Rows(0)("NT5") : NT6.Text = sqltable.Rows(0)("NT6") : NT7.Text = sqltable.Rows(0)("NT7") : NT8.Text = sqltable.Rows(0)("NT8") : NT9.Text = sqltable.Rows(0)("NT9") : NT10.Text = sqltable.Rows(0)("NT10") : NT11.Text = sqltable.Rows(0)("NT11") : NT12.Text = sqltable.Rows(0)("NT12")
            End If
        ElseIf (cboAoG.Text = "Recitation") Then
            Dim squery As String = "select  * from tblrec,tbltrec where tblrec.SCode= '" & lblSC.Text & "' and tbltrec.SCode= '" & lblSC.Text & "' and Term = '" & lblGP.Text & "' and Pterm= '" & lblGP.Text & "' and SNum= '" & lblSNum.Text & "' and tbltrec.SYear= '" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            If (sqltable.Rows.Count = 0) Then
                MessageBox.Show("Select Student First!", "Confirm")
                halted = 1
            Else
                totalnum.Text = sqltable.Rows(0)("NumTot")
                checkTNum()
                N1.Text = sqltable.Rows(0)("N1") : N2.Text = sqltable.Rows(0)("N2") : N3.Text = sqltable.Rows(0)("N3") : N4.Text = sqltable.Rows(0)("N4") : N5.Text = sqltable.Rows(0)("N5")
                NT1.Text = sqltable.Rows(0)("NT1") : NT2.Text = sqltable.Rows(0)("NT2") : NT3.Text = sqltable.Rows(0)("NT3") : NT4.Text = sqltable.Rows(0)("NT4") : NT5.Text = sqltable.Rows(0)("NT5")
            End If
        ElseIf (cboAoG.Text = "Project") Then
            Dim squery As String = "select  * from tblproj,tbltproj where tblproj.SCode= '" & lblSC.Text & "' and tbltproj.SCode= '" & lblSC.Text & "' and Term = '" & lblGP.Text & "' and Pterm= '" & lblGP.Text & "' and SNum= '" & lblSNum.Text & "' and tbltproj.SYear= '" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            If (sqltable.Rows.Count = 0) Then
                MessageBox.Show("Select Student First!", "Confirm")
                halted = 1
            Else
                totalnum.Text = sqltable.Rows(0)("NumTot")
                checkTNum()
                N1.Text = sqltable.Rows(0)("N1") : N2.Text = sqltable.Rows(0)("N2") : N3.Text = sqltable.Rows(0)("N3") : N4.Text = sqltable.Rows(0)("N4") : N5.Text = sqltable.Rows(0)("N5")
                NT1.Text = sqltable.Rows(0)("NT1") : NT2.Text = sqltable.Rows(0)("NT2") : NT3.Text = sqltable.Rows(0)("NT3") : NT4.Text = sqltable.Rows(0)("NT4") : NT5.Text = sqltable.Rows(0)("NT5")
            End If
        ElseIf (cboAoG.Text = "Other") Then
            Dim squery As String = "select  * from tblother,tbltother where tblother.SCode= '" & lblSC.Text & "' and tbltother.SCode= '" & lblSC.Text & "' and Term = '" & lblGP.Text & "' and Pterm= '" & lblGP.Text & "' and SNum= '" & lblSNum.Text & "' and tbltother.SYear= '" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            If (sqltable.Rows.Count = 0) Then
                MessageBox.Show("Select Student First!", "Confirm")
                halted = 1
            Else
                totalnum.Text = sqltable.Rows(0)("NumTot")
                checkTNum()
                N1.Text = sqltable.Rows(0)("N1") : N2.Text = sqltable.Rows(0)("N2") : N3.Text = sqltable.Rows(0)("N3") : N4.Text = sqltable.Rows(0)("N4") : N5.Text = sqltable.Rows(0)("N5")
                NT1.Text = sqltable.Rows(0)("NT1") : NT2.Text = sqltable.Rows(0)("NT2") : NT3.Text = sqltable.Rows(0)("NT3") : NT4.Text = sqltable.Rows(0)("NT4") : NT5.Text = sqltable.Rows(0)("NT5")
            End If
        ElseIf (cboAoG.Text = "Examination") Then
            Dim squery As String = "select  * from tblexam,tbltexam where tblexam.SCode= '" & lblSC.Text & "' and tbltexam.SCode= '" & lblSC.Text & "' and Term = '" & lblGP.Text & "' and Pterm= '" & lblGP.Text & "' and SNum= '" & lblSNum.Text & "' and tbltexam.SYear= '" & cboAY.Text & "'"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            If (sqltable.Rows.Count = 0) Then
                MessageBox.Show("Select Student First!", "Confirm")
                halted = 1
            Else
                totalnum.Text = sqltable.Rows(0)("NumTot")
                checkTNum()
                N1.Text = sqltable.Rows(0)("N1")
                NT1.Text = sqltable.Rows(0)("TE")
            End If
            dBDisconnect()           
        End If

            lblTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                        Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
            lblNTot.Text = Convert.ToInt32(NT1.Text) + Convert.ToInt32(NT2.Text) + Convert.ToInt32(NT3.Text) + Convert.ToInt32(NT4.Text) + Convert.ToInt32(NT5.Text) + Convert.ToInt32(NT6.Text) +
                        Convert.ToInt32(NT7.Text) + Convert.ToInt32(NT8.Text) + Convert.ToInt32(NT9.Text) + Convert.ToInt32(NT10.Text) + Convert.ToInt32(NT11.Text) + Convert.ToInt32(NT12.Text)
        Percent()
        If (lblPercent.Text = "0") Then
            DPer.Text = ""
        Else
            DPer.Text = (lblPercent.Text * 100)
            DPer.Text = DPer.Text + "%"
        End If
            If (halted = 0) Then
                Comp()
            End If

    End Sub
    Private Sub cboSubCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubCode.SelectedIndexChanged
        lblSC.Text = cboSubCode.Text
        cboCourse.Items.Clear()
        cboSec.Items.Clear()
        Dim squery As String = "select distinct Course,Section,Scode from tblclass where SYear = '" & cboAY.Text & "' and SCode = '" & lblSC.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            cboCourse.Items.Add(sqltable.Rows(i)("Course"))
        Next
        dBDisconnect()
        Dim squ As String = "select distinct Section from tblclass where SYear = '" & cboAY.Text & "' and SCode = '" & lblSC.Text & "'"
        Dim sad As New MySqlDataAdapter
        Dim sco As New MySqlCommand
        Dim sqla As New DataTable
        sco.CommandText = squ
        sco.Connection = dB
        sad.SelectCommand = sco
        sad.Fill(sqla)
        For i = 0 To sqla.Rows.Count - 1
            cboSec.Items.Add(sqla.Rows(i)("Section"))
        Next
        dBDisconnect()
        Dim sq As String = "select  * from tblsubj where SYear = '" & cboAY.Text & "' and SCode = '" & cboSubCode.Text & "'"
        Dim sa As New MySqlDataAdapter
        Dim sc As New MySqlCommand
        Dim sql As New DataTable
        sc.CommandText = sq
        sc.Connection = dB
        sa.SelectCommand = sc
        sa.Fill(sql)
        lblSubName.Text = sql.Rows(0)("SName")
        dBDisconnect()
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

    Private Sub ListView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If Not ListView1.SelectedItems.Count = 0 Then
            With ListView1.SelectedItems.Item(0)
                Me.lblSNum.Text = .Text
                Me.lblName.Text = .SubItems(1).Text
                lblChupol.Text = .SubItems(2).Text
                lblName.Text = lblName.Text + " " + lblChupol.Text
            End With
        End If
    End Sub
    Private Sub N1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N1.Leave
        If (N1.Text > Convert.ToInt32(NT1.Text)) Then
            MessageBox.Show("INVALID INPUT!", "Confirm")
            N1.Text = ""
        Else
        End If
        If (N1.Text = "") Then
            N1.Text = "0"
        End If
        lblTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
        Comp()
    End Sub

    Private Sub N2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N2.Leave
        If (N2.Text > Convert.ToInt32(NT2.Text)) Then
            MessageBox.Show("INVALID INPUT!", "Confirm")
            N2.Text = ""
        End If
        If (N2.Text = "") Then
            N2.Text = "0"
        End If
        lbltot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                  Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
        Comp()
    End Sub

    Private Sub N3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N3.Leave
        If (N3.Text > Convert.ToInt32(NT3.Text)) Then
            MessageBox.Show("INVALID INPUT!", "Confirm")
            N3.Text = ""
        End If
        If (N3.Text = "") Then
            N3.Text = "0"
        End If
        lbltot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
        Comp()
    End Sub

    Private Sub N4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N4.Leave
        If (N4.Text > Convert.ToInt32(NT4.Text)) Then
            MessageBox.Show("INVALID INPUT!", "Confirm")
            N4.Text = ""
        End If
        If (N4.Text = "") Then
            N4.Text = "0"
        End If
        lbltot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
        Comp()
    End Sub

    Private Sub N5_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N5.Leave
        If (N5.Text > Convert.ToInt32(NT5.Text)) Then
            MessageBox.Show("INVALID INPUT!", "Confirm")
            N5.Text = ""
        End If
        If (N5.Text = "") Then
            N5.Text = "0"
        End If
        lbltot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
        Comp()
    End Sub

    Private Sub N6_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N6.Leave
        If (N6.Text > Convert.ToInt32(NT6.Text)) Then
            MessageBox.Show("INVALID INPUT!", "Confirm")
            N6.Text = ""
        End If
        If (N6.Text = "") Then
            N6.Text = "0"
        End If
        lblTot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
        Comp()
    End Sub

    Private Sub N7_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N7.Leave
        If (N7.Text > Convert.ToInt32(NT7.Text)) Then
            MessageBox.Show("INVALID INPUT!", "Confirm")
            N7.Text = ""
        End If
        If (N7.Text = "") Then
            N7.Text = "0"
        End If
        lbltot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
        Comp()
    End Sub

    Private Sub N8_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N8.Leave
        If (N8.Text > Convert.ToInt32(NT8.Text)) Then
            MessageBox.Show("INVALID INPUT!", "Confirm")
            N8.Text = ""
        End If
        If (N8.Text = "") Then
            N8.Text = "0"
        End If
        lbltot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
        Comp()
    End Sub

    Private Sub N9_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N9.Leave
        If (N9.Text > Convert.ToInt32(NT9.Text)) Then
            MessageBox.Show("INVALID INPUT!", "Confirm")
            N9.Text = ""
        End If
        If (N9.Text = "") Then
            N9.Text = "0"
        End If
        lbltot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
        Comp()
    End Sub

    Private Sub N10_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N10.Leave
        If (N10.Text > Convert.ToInt32(NT10.Text)) Then
            MessageBox.Show("INVALID INPUT!", "Confirm")
            N10.Text = ""
        End If
        If (N10.Text = "") Then
            N10.Text = "0"
        End If
        lbltot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
        Comp()
    End Sub

    Private Sub N11_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N11.Leave
        If (N11.Text > Convert.ToInt32(NT11.Text)) Then
            MessageBox.Show("INVALID INPUT!", "Confirm")
            N11.Text = ""
        End If
        If (N11.Text = "") Then
            N11.Text = "0"
        End If
        lbltot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
        Comp()
    End Sub

    Private Sub N12_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N12.Leave
        If (N12.Text > Convert.ToInt32(NT12.Text)) Then
            MessageBox.Show("INVALID INPUT!", "Confirm")
            N12.Text = ""
        End If
        If (N12.Text = "") Then
            N12.Text = "0"
        End If
        lbltot.Text = Convert.ToInt32(N1.Text) + Convert.ToInt32(N2.Text) + Convert.ToInt32(N3.Text) + Convert.ToInt32(N4.Text) + Convert.ToInt32(N5.Text) + Convert.ToInt32(N6.Text) +
                    Convert.ToInt32(N7.Text) + Convert.ToInt32(N8.Text) + Convert.ToInt32(N9.Text) + Convert.ToInt32(N10.Text) + Convert.ToInt32(N11.Text) + Convert.ToInt32(N12.Text)
        Comp()
    End Sub
    Public Sub Comp()
        x = Convert.ToDouble(lblTot.Text)
        y = Convert.ToDouble(lblNTot.Text)
        z = Convert.ToDouble(lblPercent.Text)
        lblRat.Text = 50 + 50 * (x / y)
        If (lblRat.Text = "NaN") Then
            lblRat.Text = "Error!"
        Else
            lblRat.Text = Decimal.Round(lblRat.Text, 2, MidpointRounding.AwayFromZero)
            a = Convert.ToDouble(lblRat.Text)
        End If
        lblGrad.Text = a * z
        lblGrad.Text = Decimal.Round(lblGrad.Text, 2, MidpointRounding.AwayFromZero)
    End Sub
    Public Sub Comp2()
    End Sub
    Public Sub Percent()
        lblPercent.Text = ""
        Dim sq As String = "select  * from tbltc where SCode='" & cboSubCode.Text & "' and SYear ='" & cboAY.Text & "'"
        Dim sa As New MySqlDataAdapter
        Dim sc As New MySqlCommand
        Dim sqltables As New DataTable
        sc.CommandText = sq : sc.Connection = dB : sa.SelectCommand = sc : sa.Fill(sqltables)
        If (sqltables.Rows.Count = 0) Then
        Else

            If (cboAoG.Text = "Assignment") Then
                lblPercent.Text = sqltables.Rows(0)("Assign")
            ElseIf (cboAoG.Text = "Quiz") Then
                lblPercent.Text = sqltables.Rows(0)("Quiz")

            ElseIf (cboAoG.Text = "Seatwork") Then
                lblPercent.Text = sqltables.Rows(0)("SW")

            ElseIf (cboAoG.Text = "Recitation") Then
                lblPercent.Text = sqltables.Rows(0)("Rec")

            ElseIf (cboAoG.Text = "Project") Then
                lblPercent.Text = sqltables.Rows(0)("Proj")

            ElseIf (cboAoG.Text = "Examination") Then
                lblPercent.Text = sqltables.Rows(0)("Exam")

            ElseIf (cboAoG.Text = "Other") Then
                lblPercent.Text = sqltables.Rows(0)("Other")
            End If
        End If
        dBDisconnect()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If (lblSNum.Text = "" Or cboSubCode.Text = "" Or lblGP.Text = "" Or lblRat.Text = "Error!" Or cboAoG.Text = "") Then
        Else
            dB.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
            If (cboAoG.Text = "Assignment") Then
                Try
                    dBConnect()
                    cmd.Connection = dB
                    cmd.CommandText = "UPDATE tblass SET N1 = '" & N1.Text & "',N2  = '" & N2.Text & "',N3  = '" & N3.Text & "',N4  = '" & N4.Text & "',N5  = '" & N5.Text & "',N6  = '" & N6.Text & "',N7  = '" & N7.Text & "',N8  = '" & N8.Text & "',N9  = '" & N9.Text & "',N10  = '" & N10.Text & "',N11  = '" & N11.Text & "',N12  = '" & N12.Text & "',Total  = '" & lblTot.Text & "',Rat = '" & lblRat.Text & "',Grade = '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "' ;"
                    result = cmd.ExecuteNonQuery
                    cmd.CommandText = "UPDATE tblgradesheet SET AssT  = '" & lblTot.Text & "', AssR = '" & lblRat.Text & "',AssG= '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "';"
                    result = cmd.ExecuteNonQuery
                    If result = 0 Then
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
                    cmd.CommandText = "UPDATE tblquiz SET N1 = '" & N1.Text & "',N2  = '" & N2.Text & "',N3  = '" & N3.Text & "',N4  = '" & N4.Text & "',N5  = '" & N5.Text & "',N6  = '" & N6.Text & "',N7  = '" & N7.Text & "',N8  = '" & N8.Text & "',N9  = '" & N9.Text & "',N10  = '" & N10.Text & "',N11  = '" & N11.Text & "',N12  = '" & N12.Text & "',Total  = '" & lblTot.Text & "',Rat = '" & lblRat.Text & "',Grade = '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "';"
                    result = cmd.ExecuteNonQuery
                    cmd.CommandText = "UPDATE tblgradesheet SET QuiT  = '" & lblTot.Text & "', QuiR = '" & lblRat.Text & "',QuiG= '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "';"
                    result = cmd.ExecuteNonQuery
                    If result = 0 Then
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
                    cmd.CommandText = "UPDATE tblseatwork SET N1 = '" & N1.Text & "',N2  = '" & N2.Text & "',N3  = '" & N3.Text & "',N4  = '" & N4.Text & "',N5  = '" & N5.Text & "',N6  = '" & N6.Text & "',N7  = '" & N7.Text & "',N8  = '" & N8.Text & "',N9  = '" & N9.Text & "',N10  = '" & N10.Text & "',N11  = '" & N11.Text & "',N12  = '" & N12.Text & "',Total  = '" & lblTot.Text & "',Rat = '" & lblRat.Text & "',Grade = '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "';"
                    result = cmd.ExecuteNonQuery
                    cmd.CommandText = "UPDATE tblgradesheet SET SeatT  = '" & lblTot.Text & "', SeatR = '" & lblRat.Text & "',SeatG= '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "' ;"
                    result = cmd.ExecuteNonQuery
                    If result = 0 Then
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
                    cmd.CommandText = "UPDATE tblrec SET N1 = '" & N1.Text & "',N2  = '" & N2.Text & "',N3  = '" & N3.Text & "',N4  = '" & N4.Text & "',N5  = '" & N5.Text & "',Total  = '" & lblTot.Text & "',Rat = '" & lblRat.Text & "',Grade = '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "';"
                    result = cmd.ExecuteNonQuery
                    cmd.CommandText = "UPDATE tblgradesheet SET RecT  = '" & lblTot.Text & "', RecR = '" & lblRat.Text & "',RecG= '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "' ;"
                    result = cmd.ExecuteNonQuery
                    If result = 0 Then
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
                    cmd.CommandText = "UPDATE tblproj SET N1 = '" & N1.Text & "',N2  = '" & N2.Text & "',N3  = '" & N3.Text & "',N4  = '" & N4.Text & "',N5  = '" & N5.Text & "',Total  = '" & lblTot.Text & "',Rat = '" & lblRat.Text & "',Grade = '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "';"
                    result = cmd.ExecuteNonQuery
                    cmd.CommandText = "UPDATE tblgradesheet SET ProT  = '" & lblTot.Text & "', ProR = '" & lblRat.Text & "',ProG= '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "' ;"
                    result = cmd.ExecuteNonQuery
                    If result = 0 Then
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
                    cmd.CommandText = "UPDATE tblother SET N1 = '" & N1.Text & "',N2  = '" & N2.Text & "',N3  = '" & N3.Text & "',N4  = '" & N4.Text & "',N5  = '" & N5.Text & "',Total  = '" & lblTot.Text & "',Rat = '" & lblRat.Text & "',Grade = '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "';"
                    result = cmd.ExecuteNonQuery
                    cmd.CommandText = "UPDATE tblgradesheet SET OthT  = '" & lblTot.Text & "', OthR = '" & lblRat.Text & "',OthG= '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "';"
                    result = cmd.ExecuteNonQuery
                    If result = 0 Then
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
                    cmd.CommandText = "UPDATE tblexam SET N1 = '" & N1.Text & "',Rat = '" & lblRat.Text & "',Grade = '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "' ;"
                    result = cmd.ExecuteNonQuery
                    cmd.CommandText = "UPDATE tblgradesheet SET ExT  = '" & N1.Text & "', ExR = '" & lblRat.Text & "',ExG= '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "';"
                    result = cmd.ExecuteNonQuery
                    If result = 0 Then
                    Else
                        MsgBox("Successfully saved!")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
        dBDisconnect()
        SavegsheeT()
    End Sub
    Public Sub SavegsheeT()
        Dim query As String = "select  * from tblgradesheet where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubCode.Text & "'and Term ='" & lblGP.Text & "'"
        Dim adapter As New MySqlDataAdapter
        Dim command As New MySqlCommand
        Dim qltable As New DataTable
        command.CommandText = query : command.Connection = dB : adapter.SelectCommand = command : adapter.Fill(qltable)
        If (qltable.Rows.Count = "0") Then
            MessageBox.Show("No Data Found!", "Confirm")
        Else
            dB.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
            cmd.Connection = dB
            dBConnect()
            ass = qltable.Rows(0)("AssG") : ex = qltable.Rows(0)("ExG") : oth = qltable.Rows(0)("OthG") : pro = qltable.Rows(0)("ProG")
            qu = qltable.Rows(0)("QuiG") : re = qltable.Rows(0)("RecG") : se = qltable.Rows(0)("SeatG")
            lblAll.Text = ass + ex + oth + pro + qu + re + se
            If (lblAll.Text <= 49) Then
                lblAll.Text = 50
            Else
            End If
            If (lblGP.Text = "P") Then
                cmd.CommandText = "UPDATE tblgsheet SET PGrade= '" & lblAll.Text & "' where snum ='" & lblSNum.Text & "' and Scode='" & cboSubCode.Text & "' and SYear= '" & cboAY.Text & "';"
                result = cmd.ExecuteNonQuery
                cmd.CommandText = "UPDATE tblgradesheet SET TotalGrade= '" & lblAll.Text & "' where snum ='" & lblSNum.Text & "' and Scode='" & cboSubCode.Text & "' and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "';"
                result = cmd.ExecuteNonQuery
            ElseIf (lblGP.Text = "M") Then
                cmd.CommandText = "UPDATE tblgsheet SET MGrade= '" & lblAll.Text & "' where snum ='" & lblSNum.Text & "' and Scode='" & cboSubCode.Text & "' and SYear= '" & cboAY.Text & "';"
                result = cmd.ExecuteNonQuery
                cmd.CommandText = "UPDATE tblgradesheet SET TotalGrade= '" & lblAll.Text & "' where snum ='" & lblSNum.Text & "' and Scode='" & cboSubCode.Text & "' and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "';"
                result = cmd.ExecuteNonQuery
            ElseIf (lblGP.Text = "F") Then
                cmd.CommandText = "UPDATE tblgsheet SET FGrade= '" & lblAll.Text & "' where snum ='" & lblSNum.Text & "' and Scode='" & cboSubCode.Text & "' and SYear= '" & cboAY.Text & "';"
                result = cmd.ExecuteNonQuery
                cmd.CommandText = "UPDATE tblgradesheet SET TotalGrade= '" & lblAll.Text & "' where snum ='" & lblSNum.Text & "' and Scode='" & cboSubCode.Text & "' and Term ='" & lblGP.Text & "' and SYear= '" & cboAY.Text & "';"
                result = cmd.ExecuteNonQuery
            End If
        End If
        dBDisconnect()
        LoadFilesss()
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
    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        cmdSave.PerformClick()
        Clr()
        If (cboAoG.SelectedIndex < cboAoG.Items.Count - 1) Then
            cboAoG.SelectedIndex = cboAoG.SelectedIndex + 1
        End If
    End Sub

    Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        cmdSave.PerformClick()
        Clr()
        If (cboAoG.SelectedIndex > 0) Then
            cboAoG.SelectedIndex = cboAoG.SelectedIndex - 1
        End If
    End Sub
    Private Sub frmgradesheet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyValue = Keys.Left) Then
            cmdNext.PerformClick()
        End If
    End Sub

    Private Sub cboAY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAY.SelectedIndexChanged
        cboSubCode.Items.Clear()
        Dim squery As String = "select distinct SCode from tblsubj where SYear = '" & cboAY.Text & "'"
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
        If (cboAY.Text = "" And cboSubCode.Text = "") Then
            MessageBox.Show("No information added")

        else
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
        End If
        dBDisconnect()
    End Sub

    Private Sub N1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N1.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            N1.Text = 0
            e.Handled = True
        End If
    End Sub

    Private Sub N2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N2.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            N2.Text = 0
            e.Handled = True
        End If
    End Sub

    Private Sub N3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N3.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            N3.Text = 0
            e.Handled = True
        End If
    End Sub

    Private Sub N4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N4.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            N4.Text = 0
            e.Handled = True
        End If
    End Sub

    Private Sub N5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N5.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            N5.Text = 0
            e.Handled = True
        End If
    End Sub

    Private Sub N6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N6.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            N6.Text = 0
            e.Handled = True
        End If
    End Sub

    Private Sub N7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N7.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            N7.Text = 0
            e.Handled = True
        End If
    End Sub

    Private Sub N8_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N8.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            N8.Text = 0
            e.Handled = True
        End If
    End Sub

    Private Sub N9_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N9.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            N9.Text = 0
            e.Handled = True
        End If
    End Sub

    Private Sub N10_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N10.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            N10.Text = 0
            e.Handled = True
        End If
    End Sub

    Private Sub N11_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N11.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            N11.Text = 0
            e.Handled = True
        End If
    End Sub

    Private Sub N12_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N12.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            N12.Text = 0
            e.Handled = True
        End If
    End Sub
    Public Sub LoadFilesss()
        Dim squery As String = "select  * from tblgsheet"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim p, m, f, t As Double
        Dim sm As Double
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        ListView1.View = View.Details
        Dim i As Integer
        dB.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        dB.Open()
        cmd.Connection = dB
        For i = 0 To sqltable.Rows.Count - 1
            p = sqltable.Rows(i)("PGrade")
            m = sqltable.Rows(i)("MGrade")
            f = sqltable.Rows(i)("FGrade")
            Dim namess As Integer
            Dim yearss As String
            namess = sqltable.Rows(i)("SNum")
            yearss = sqltable.Rows(i)("SYear")
            t = (p * 0.3) + (m * 0.3) + (f * 0.4)
            lblTG.Text = t
            If (t = 100 Or t >= 96.6) Then
                sm = 1.0
            ElseIf (t = 96.5 Or t >= 93.5) Then
                sm = 1.25
            ElseIf (t = 93.4 Or t >= 90.5) Then
                sm = 1.5
            ElseIf (t = 90.4 Or t >= 87.5) Then
                sm = 1.75
            ElseIf (t = 87.4 Or t >= 84.5) Then
                sm = 2.0
            ElseIf (t = 84.4 Or t >= 81.5) Then
                sm = 2.25
            ElseIf (t = 81.4 Or t >= 78.5) Then
                sm = 2.5
            ElseIf (t = 78.4 Or t >= 75.5) Then
                sm = 2.75
            ElseIf (t = 75.4 Or t >= 74.6) Then
                sm = 3.0
            ElseIf (t <= 74.5) Then
                sm = 5.0
            ElseIf (t <= 70) Then
                sm = 5.0
            End If
            If (t < 75) Then
                remarklbl.Text = "FAILED"
            Else
                remarklbl.Text = "PASSED"
            End If
            If (lblTG.Text <= 70) Then
                lblTG.Text = 0
            Else
                lblTG.Text = Decimal.Round(lblTG.Text, 4, MidpointRounding.AwayFromZero)
            End If
            cmd.CommandText = "UPDATE tblgsheet SET SFinal= '" & lblTG.Text & "',Fnum= '" & sm & "',Remarks= '" & remarklbl.Text & "' where SNum='" & namess & "' and SYear='" & yearss & "' ;"
            result = cmd.ExecuteNonQuery
            lblTG.Text = ""
            remarklbl.Text = ""
        Next
        dB.Close()
        lblTG.Text = ""
        remarklbl.Text = ""
    End Sub

    Private Sub radMid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMid.CheckedChanged
        If (radMid.Checked = True) Then
            lblGP.Text = "M"
            LoadFile()
            CheckAOG()
        End If
    End Sub

    Private Sub radPre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPre.CheckedChanged
        If (radPre.Checked = True) Then
            lblGP.Text = "P"
            LoadFile()
            CheckAOG()
        End If
    End Sub

    Private Sub radFin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFin.CheckedChanged
        If (radFin.Checked = True) Then
            lblGP.Text = "F"
            LoadFile()
            CheckAOG()
        End If
    End Sub
End Class