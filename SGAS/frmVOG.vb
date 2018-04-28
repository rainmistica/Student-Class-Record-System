Imports MySql.Data.MySqlClient
Public Class frmVOG
    Dim Conn As New MySqlConnection
    Dim DatabaseName As String = "dbclassrec"
    Dim server As String = "localhost"
    Dim userName As String = "root"
    Dim password As String = "1234"
    Dim result As Integer
    Dim cmd As New MySqlCommand
    Dim squery As String = "select  * from tblgsheet"
    Dim sadapter As New MySqlDataAdapter
    Dim scommand As New MySqlCommand
    Dim sqltable As New DataTable
    Dim p, m, f, t As Double
    Dim sm As Double
    Dim namess As Integer
    Dim yearss As String
    Private Sub frmVOG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqConnect()
        fillAY()
        LoadFile()
    End Sub
    Public Sub sqConnect()
        If Not Conn Is Nothing Then Conn.Close()
        Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Conn.Open()
    End Sub
    Public Sub fillAY()
        cboAY.Items.Clear()
        Dim squery As String = "select distinct SYear from tblsubj"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        scommand.CommandText = squery
        scommand.Connection = Conn
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            cboAY.Items.Add(sqltable.Rows(i)("SYear"))
        Next
        Conn.Close()
    End Sub
    Public Sub LoadFile()
        ListView1.Items.Clear()
        scommand.CommandText = squery
        scommand.Connection = Conn
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        ListView1.View = View.Details
        Dim i As Integer
        Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Conn.Open()
        cmd.Connection = Conn
        For i = 0 To sqltable.Rows.Count - 1
            p = sqltable.Rows(i)("PGrade")
            m = sqltable.Rows(i)("MGrade")
            f = sqltable.Rows(i)("FGrade")
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
            ElseIf (t <= 74.6) Then
                sm = 5.0
            ElseIf (t <= 70) Then
                sm = 5.0
            End If
            If (t < 74.5) Then
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
        Conn.Close()
        lblTG.Text = ""
        remarklbl.Text = ""
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        If (cboCourse.Text = "" And cboSubj.Text = "" And cboSec.Text = "") Then
            MessageBox.Show("Please Complete the Search information!", "Help")
        Else
            Dim squery As String = "SELECT * FROM tblgsheet where SCode ='" & cboSubj.Text & "' AND Course='" & cboCourse.Text & "' AND Section = '" & cboSec.Text & "' AND SYear = '" & cboAY.Text & "' order by lname ASC"
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
                Dim i, ii As Integer
                For i = 0 To sqltable.Rows.Count - 1
                    ListView1.Items.Add(sqltable.Rows(i)("SNum"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("LName"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("FName"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("PGrade"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("MGrade"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("FGrade"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sqltable.Rows(i)("SFinal"))
                    For ii = 0 To ListView1.Items.Count - 1
                        If (ListView1.Items(ii).SubItems(6).Text < 75 Or ListView1.Items(ii).SubItems(6).Text = "NA") Then
                            ListView1.Items(ii).ForeColor = Color.Red
                        End If
                    Next
                Next
                Conn.Close()
            End If
        End If
    End Sub

    Private Sub ListView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.Click
        lClick()
    End Sub
    Public Sub lClick()
        If Not ListView1.SelectedItems.Count = 0 Then
            With ListView1.SelectedItems.Item(0)
                If (.SubItems(6).Text = 5) Then

                End If
                If (t = 100 Or t >= 96.6) Then
                    lblFinalGrade.Text = 1.0
                ElseIf (.SubItems(6).Text = 96.5 Or .SubItems(6).Text >= 93.5) Then
                    lblFinalGrade.Text = 1.25
                ElseIf (.SubItems(6).Text = 93.4 Or .SubItems(6).Text >= 90.5) Then
                    lblFinalGrade.Text = 1.5
                ElseIf (.SubItems(6).Text = 90.4 Or .SubItems(6).Text >= 87.5) Then
                    lblFinalGrade.Text = 1.75
                ElseIf (.SubItems(6).Text = 87.4 Or .SubItems(6).Text >= 84.5) Then
                    lblFinalGrade.Text = 2.0
                ElseIf (.SubItems(6).Text = 84.4 Or .SubItems(6).Text >= 81.5) Then
                    lblFinalGrade.Text = 2.25
                ElseIf (.SubItems(6).Text = 81.4 Or .SubItems(6).Text >= 78.5) Then
                    lblFinalGrade.Text = 2.5
                ElseIf (.SubItems(6).Text = 78.4 Or .SubItems(6).Text >= 75.5) Then
                    lblFinalGrade.Text = 2.75
                ElseIf (.SubItems(6).Text = 75.4 Or .SubItems(6).Text >= 74.6) Then
                    lblFinalGrade.Text = 3.0
                ElseIf (.SubItems(6).Text <= 74.5) Then
                    lblFinalGrade.Text = 5.0
                End If
                If (.SubItems(6).Text < 75) Then
                    lblRemark.Text = "FAILED"
                Else
                    lblRemark.Text = "PASSED"
                End If
            End With
        End If
    End Sub
    Private Sub cboAY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAY.SelectedIndexChanged
        cboSubj.Items.Clear()
        Dim squery As String = "select distinct SCode from tblsubj where SYear = '" & cboAY.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        scommand.CommandText = squery
        scommand.Connection = Conn
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            cboSubj.Items.Add(sqltable.Rows(i)("SCode"))
        Next
        Conn.Close()
    End Sub
    Private Sub cboSubj_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubj.SelectedIndexChanged
        cboCourse.Items.Clear()
        cboSec.Items.Clear()
        Dim squery As String = "select distinct Course from tblclass where SYear = '" & cboAY.Text & "' and SCode = '" & cboSubj.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        scommand.CommandText = squery
        scommand.Connection = Conn
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            cboCourse.Items.Add(sqltable.Rows(i)("Course"))
        Next
        Conn.Close()
        Dim squ As String = "select distinct Section from tblclass where SYear = '" & cboAY.Text & "' and SCode = '" & cboSubj.Text & "'"
        Dim sad As New MySqlDataAdapter
        Dim sco As New MySqlCommand
        Dim sql As New DataTable
        sco.CommandText = squ
        sco.Connection = Conn
        sad.SelectCommand = sco
        sad.Fill(sql)
        For i = 0 To sql.Rows.Count - 1
            cboSec.Items.Add(sql.Rows(i)("Section"))
        Next
        Conn.Close()
        
    End Sub
End Class