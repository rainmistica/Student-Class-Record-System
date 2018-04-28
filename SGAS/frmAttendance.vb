Imports MySql.Data.MySqlClient
Public Class frmAttendance
    Dim ExitYN, CYN As System.Windows.Forms.DialogResult
    Dim Conn As New MySqlConnection
    Dim DatabaseName As String = "dbclassrec"
    Dim server As String = "localhost"
    Dim userName As String = "root"
    Dim password As String = "1234"
    Dim result As Integer
    Dim cmd As New MySqlCommand
    Dim x, y, z, a As Double
    Dim u, v As Integer
    Dim s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20 As Integer
    Private Sub frmAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'sqConnect()
        'FCour()
        'FSec()
        'FSubj()
        'fTerm()
    End Sub
    Public Sub sqConnect()
        If Not Conn Is Nothing Then Conn.Close()
        Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Conn.Open()
    End Sub
    Public Sub LoadFile()
        ListView1.Items.Clear()
        ListView1.View = View.Details
        Dim squery As String = "select  * from tblattendance where Term ='P'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        scommand.CommandText = squery
        scommand.Connection = Conn
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        Dim i As Integer
        For i = 0 To sqltable.Rows.Count - 1
            ListView1.Items.Add(sqltable.Rows(i)("Snum"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("Lname"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("Fname"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S1"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S2"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S3"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S4"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S5"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S6"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S7"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S8"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S9"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S10"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S11"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S12"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S13"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S14"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S15"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S16"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S17"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S18"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S19"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S20"))
        Next
        Conn.Close()
    End Sub
    Public Sub FSubj()
        Dim squery As String = "select  * from tblsubj where status = 'Active'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        With scommand
            .CommandText = squery
            .Connection = Conn

        End With
        With sadapter
            .SelectCommand = scommand
            .Fill(sqltable)
        End With
        For i = 0 To sqltable.Rows.Count - 1
            cboSubj.Items.Add(sqltable.Rows(i)("SCode"))
        Next
        Conn.Close()
    End Sub
    Public Sub FCour()
        Dim squery As String = "select  * from tblcourse where status = 'Active'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        With scommand
            .CommandText = squery
            .Connection = Conn
        End With
        With sadapter
            .SelectCommand = scommand
            .Fill(sqltable)
        End With
        For i = 0 To sqltable.Rows.Count - 1
            cboCou.Items.Add(sqltable.Rows(i)("CCode"))
        Next
        Conn.Close()
    End Sub
    Public Sub FSec()
        Dim squery As String = "select  * from tblsec where status = 'Active'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        With scommand
            .CommandText = squery
            .Connection = Conn

        End With
        With sadapter
            .SelectCommand = scommand
            .Fill(sqltable)
        End With
        For i = 0 To sqltable.Rows.Count - 1
            cboSec.Items.Add(sqltable.Rows(i)("Section"))
        Next
        Conn.Close()

    End Sub
    Public Sub fTerm()
        Dim squery As String = "select  * from tblterm"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        With scommand
            .CommandText = squery
            .Connection = Conn

        End With
        With sadapter
            .SelectCommand = scommand
            .Fill(sqltable)
        End With
        For i = 0 To sqltable.Rows.Count - 1
            cboTerm.Items.Add(sqltable.Rows(i)("TermName"))
        Next
        Conn.Close()
    End Sub
    Private Sub ListView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListClick()
        lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + s20
        gb3.Enabled = True
        GrabSD()
        u = Convert.ToInt32(lblSD.Text)
        v = Convert.ToInt32(lblNP.Text)
        lblNA.Text = u - v
        Cmp()
    End Sub
    Public Sub ListClick()
        If Not ListView1.SelectedItems.Count = 0 Then
            With ListView1.SelectedItems.Item(0)
                Me.lblSNum.Text = .Text
                Me.lblFName.Text = .SubItems(2).Text + " " + .SubItems(1).Text
                'cbox
                If (.SubItems(3).Text = "1") Then
                    cB1.Checked = True
                Else
                    cB1.Checked = False
                End If
                If (.SubItems(4).Text = "1") Then
                    cB2.Checked = True
                Else
                    cB2.Checked = False
                End If
                If (.SubItems(5).Text = "1") Then
                    cB3.Checked = True
                Else
                    cB3.Checked = False
                End If
                If (.SubItems(6).Text = "1") Then
                    cB4.Checked = True
                Else
                    cB4.Checked = False
                End If
                If (.SubItems(7).Text = "1") Then
                    cB5.Checked = True
                Else
                    cB5.Checked = False
                End If
                If (.SubItems(8).Text = "1") Then
                    cB6.Checked = True
                Else
                    cB6.Checked = False
                End If
                If (.SubItems(9).Text = "1") Then
                    cB7.Checked = True
                Else
                    cB7.Checked = False
                End If
                If (.SubItems(10).Text = "1") Then
                    cB8.Checked = True
                Else
                    cB8.Checked = False
                End If
                If (.SubItems(11).Text = "1") Then
                    cB9.Checked = True
                Else
                    cB9.Checked = False
                End If
                If (.SubItems(12).Text = "1") Then
                    cB10.Checked = True
                Else
                    cB10.Checked = False
                End If
                If (.SubItems(13).Text = "1") Then
                    cB11.Checked = True
                Else
                    cB11.Checked = False
                End If
                If (.SubItems(14).Text = "1") Then
                    cB12.Checked = True
                Else
                    cB12.Checked = False
                End If
                If (.SubItems(15).Text = "1") Then
                    cB13.Checked = True
                Else
                    cB13.Checked = False
                End If
                If (.SubItems(16).Text = "1") Then
                    cB14.Checked = True
                Else
                    cB14.Checked = False
                End If
                If (.SubItems(17).Text = "1") Then
                    cB15.Checked = True
                Else
                    cB15.Checked = False
                End If
                If (.SubItems(18).Text = "1") Then
                    cB16.Checked = True
                Else
                    cB16.Checked = False
                End If
                If (.SubItems(19).Text = "1") Then
                    cB17.Checked = True
                Else
                    cB17.Checked = False
                End If
                If (.SubItems(20).Text = "1") Then
                    cB18.Checked = True
                Else
                    cB18.Checked = False
                End If
                If (.SubItems(21).Text = "1") Then
                    cB19.Checked = True
                Else
                    cB19.Checked = False
                End If
                If (.SubItems(22).Text = "1") Then
                    cB20.Checked = True
                Else
                    cB20.Checked = False
                End If
            End With
        End If
    End Sub

    Private Sub cmdCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cboCou.Text = "" Or cboSubj.Text = "" Or cboSec.Text = "" Or cboTerm.Text = "") Then
            MessageBox.Show("Please Search information before editing!", "Help")
        Else
            CYN = MsgBox("Are you sure about the Update?", MsgBoxStyle.YesNo)
            If CYN = MsgBoxResult.Yes Then
                Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
                Try
                    Conn.Open()
                    With cmd
                        .Connection = Conn
                        .CommandText = "UPDATE tblattendance SET s1='" & s1 & "',s2='" & s2 & "',s3='" & s3 & "',s4='" & s4 & "',s5='" & s5 & "',s6='" & s6 & "',s7='" & s7 & "',s8='" & s8 & "',s9='" & s9 & "',s10='" & s10 & "',s11='" & s11 & "',s12='" & s12 & "',s13='" & s13 & "',s14='" & s14 & "',s15='" & s15 & "',s16='" & s16 & "',s17='" & s17 & "',s18='" & s18 & "',s19='" & s19 & "',s20='" & s20 & "',Total='" & v & "',Rat='" & lblRat.Text & "',Grade='" & lblGrad.Text & "' where snum ='" & lblSNum.Text & "' AND SCode ='" & cboSubj.Text & "' AND Course ='" & cboCou.Text & "' AND Section ='" & cboSec.Text & "' AND Term ='" & lblTerm.Text & "';"
                        result = cmd.ExecuteNonQuery
                        .CommandText = "UPDATE gradesheet SET ATT  = '" & lblNP.Text & "', ATR = '" & lblRat.Text & "',ATG= '" & lblGrad.Text & "' where SNum ='" & lblSNum.Text & "' and SCode='" & cboSubj.Text & "'and Term ='" & lblTerm.Text & "' ;"
                        result = cmd.ExecuteNonQuery
                        If result = 0 Then
                            MsgBox("Data has been Edited!")
                        Else
                            MsgBox("Successfully saved!")

                        End If
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Conn.Close()
            Else
            End If
        End If
        LoadFile()
        lblNP.Text = "0"
        lblNA.Text = "0"
        lblRat.Text = "0"
        lblGrad.Text = "0"
    End Sub

    Private Sub cB1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB1.Checked = True) Then
            s1 = 1
        Else
            s1 = 0
        End If
    End Sub

    Private Sub cB2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB2.Checked = True) Then
            s2 = 1
        Else
            s2 = 0
        End If
    End Sub

    Private Sub cB3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB3.Checked = True) Then
            s3 = 1
        Else
            s3 = 0
        End If
        ' lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB4.Checked = True) Then
            s4 = 1
        Else
            s4 = 0
        End If
        'lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB5.Checked = True) Then
            s5 = 1
        Else
            s5 = 0
        End If
        'lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB6.Checked = True) Then
            s6 = 1
        Else
            s6 = 0
        End If
        'lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB7.Checked = True) Then
            s7 = 1
        Else
            s7 = 0
        End If
        'lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB8.Checked = True) Then
            s8 = 1
        Else
            s8 = 0
        End If
        'lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB9.Checked = True) Then
            s9 = 1
        Else
            s9 = 0
        End If
        'lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB10.Checked = True) Then
            s10 = 1
        Else
            s10 = 0
        End If
        'lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB11.Checked = True) Then
            s11 = 1
        Else
            s11 = 0
        End If
        ' lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB12.Checked = True) Then
            s12 = 1
        Else
            s12 = 0
        End If
        'lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB13.Checked = True) Then
            s13 = 1
        Else
            s13 = 0
        End If
        ' lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB14.Checked = True) Then
            s14 = 1
        Else
            s14 = 0
        End If
        'lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB15.Checked = True) Then
            s15 = 1
        Else
            s15 = 0
        End If
        'lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB16.Checked = True) Then
            s16 = 1
        Else
            s16 = 0
        End If
        'lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB17.Checked = True) Then
            s17 = 1
        Else
            s17 = 0
        End If
        'lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB18.Checked = True) Then
            s18 = 1
        Else
            s18 = 0
        End If
        'lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB19.Checked = True) Then
            s19 = 1
        Else
            s19 = 0
        End If
        ' lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cB20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cB20.Checked = True) Then
            s20 = 1
        Else
            s20 = 0
        End If
        ' lblNP.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + 10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + 20

    End Sub

    Private Sub cboTerm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim squery As String = "SELECT  TN FROM tblterm WHERE TermName='" & cboTerm.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        With scommand
            .CommandText = squery
            .Connection = Conn

        End With
        With sadapter
            .SelectCommand = scommand
            .Fill(sqltable)
        End With
        lblTerm.Text = sqltable.Rows(0)("TN")
        Conn.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cboCou.Text = "" And cboSubj.Text = "" And cboSec.Text = "" And cboTerm.Text = "") Then
            MessageBox.Show("Please Complete the Search information!", "Help")
        Else
            Dim squery As String = "SELECT * FROM tblattendance where SCode ='" & cboSubj.Text & "' AND Course='" & cboCou.Text & "' AND Section = '" & cboSec.Text & "' AND Term ='" & lblTerm.Text & "'"
            Dim sadapter As New MySqlDataAdapter
            Dim scommand As New MySqlCommand
            Dim sqltable As New DataTable

            ListView1.Items.Clear()
            scommand.CommandText = squery
            scommand.Connection = Conn
            sadapter.SelectCommand = scommand
            sadapter.Fill(sqltable)
            ListView1.View = View.Details
            If (sqltable.Rows.Count = 0) Then
                MessageBox.Show("Information Does'nt Exist!", "Confirm")
            Else
                Dim i As Integer
                For i = 0 To sqltable.Rows.Count - 1
                    ListView1.Items.Add(sqltable.Rows(i)("Snum"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("Lname"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("Fname"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S1"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S2"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S3"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S4"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S5"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S6"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S7"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S8"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S9"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S10"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S11"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S12"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S13"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S14"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S15"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S16"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S17"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S18"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S19"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("S20"))
                Next
                Conn.Close()
            End If
            Percent()
        End If
        GrabSD()
    End Sub
    Public Sub Percent()
        Dim squery As String = "select  * from tbltc where SCode='" & cboSubj.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        With scommand
            .CommandText = squery
            .Connection = Conn

        End With
        With sadapter
            .SelectCommand = scommand
            .Fill(sqltable)
        End With
        lblPercent.Text = sqltable.Rows(0)("Att")
        Conn.Close()
    End Sub
    Public Sub Cmp()
        x = Convert.ToDouble(lblNP.Text)
        y = Convert.ToDouble(lblSD.Text)
        z = Convert.ToDouble(lblPercent.Text)
        lblRat.Text = 50 + 50 * (x / y)
        a = Convert.ToDouble(lblRat.Text)
        lblGrad.Text = a * z
    End Sub
    Public Sub GrabSD()
        Dim squery As String = "select  * from tbltatt where SCode='" & cboSubj.Text & "' AND PTerm = '" & lblTerm.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        scommand.CommandText = squery
        scommand.Connection = Conn
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        lblSD.Text = sqltable.Rows(i)("Tot")
        Conn.Close()
    End Sub
End Class