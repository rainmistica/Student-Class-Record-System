Imports MySql.Data.MySqlClient
Public Class frmClass
    Dim ExitYN, CYN As System.Windows.Forms.DialogResult
    Dim Conn As New MySqlConnection
    Dim DatabaseName As String = "dbclassrec"
    Dim server As String = "localhost"
    Dim userName As String = "root"
    Dim password As String = "1234"
    Dim result As Integer
    Dim cmd As New MySqlCommand
    Dim addFlag As Integer
    Private Sub frmClass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdEdit.Enabled = False
        cmdRemove.Enabled = False
        cmdUp.Enabled = False
        dBConnect()
        LoadFile()
        fillAY()
        FillCourse()
        FillSec()
    End Sub
    Public Sub LoadFile()
        ListView1.Items.Clear()
        SCode.Items.Clear()
        Dim squery As String = "select  * from tblclass"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        scommand.CommandText = squery
        scommand.Connection = Conn
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            With ListView1
                .Items.Add(sqltable.Rows(i)("SCode"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(sqltable.Rows(i)("Course"))
                    .Add(sqltable.Rows(i)("Section"))
                    .Add(sqltable.Rows(i)("Stime"))
                    .Add(sqltable.Rows(i)("ETime"))
                    .Add(sqltable.Rows(i)("SYear"))
                    .Add(sqltable.Rows(i)("Day"))
                End With
            End With
        Next
        dBDisconnect()
    End Sub
    Public Sub FillSCode()
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
            SCode.Items.Add(sqltable.Rows(i)("SCode"))
        Next
        Conn.Close()
    End Sub
    Public Sub FillCourse()
        Course.Items.Clear()
        Dim squery As String = "select distinct Course from tblstudlist"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        scommand.CommandText = squery
        scommand.Connection = Conn
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            Course.Items.Add(sqltable.Rows(i)("Course"))
        Next
        dBDisconnect()
    End Sub
    Public Sub FillSec()
        Section.Items.Clear()
        Dim squery As String = "select distinct Section from tblstudlist"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        scommand.CommandText = squery
        scommand.Connection = Conn
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            Section.Items.Add(sqltable.Rows(i)("Section"))
        Next
        dBDisconnect()
    End Sub

    Private Sub ListView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.Click
        ListClick()
        cmdExit.Text = "&Cancel"
        cmdAdd.Enabled = False
        cmdEdit.Enabled = True
        cmdRemove.Enabled = True
    End Sub
    Public Sub ListClick()
        If Not ListView1.SelectedItems.Count = 0 Then
            With ListView1.SelectedItems.Item(0)
                Me.lblCode.Text = .Text
                Me.Course.Text = .SubItems(1).Text
                Me.Section.Text = .SubItems(2).Text
                Me.dtpSTime.Text = .SubItems(3).Text
                Me.dtpETime.Text = .SubItems(4).Text
                Me.Day.Text = .SubItems(5).Text
                Me.cboAY.Text = .SubItems(6).Text
                SCode.Enabled = False
                Course.Enabled = False
                Section.Enabled = False
                Day.Enabled = False
                dtpETime.Enabled = False
                dtpSTime.Enabled = False
                cboAY.Enabled = False
            End With
        End If
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If (cmdExit.Text = "&Cancel") Then
            CYN = MsgBox("Do you really want to cancel?", MsgBoxStyle.YesNo)
            If CYN = MsgBoxResult.Yes Then
                Clear()

            Else
            End If

        ElseIf (cmdExit.Text = "&Exit") Then
            ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
            If ExitYN = MsgBoxResult.Yes Then
                Me.Close()
            Else
            End If
        End If
    End Sub
    Public Sub Clear()
        cmdAdd.Enabled = True
        cmdEdit.Enabled = False
        cmdRemove.Enabled = False
        cmdUp.Enabled = False
        cmdExit.Text = "&Exit"
        ListView1.Enabled = True
        SCode.Enabled = False
        Course.Enabled = False
        Section.Enabled = False
        Day.Enabled = False
        Day.Text = ""
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        cmdEdit.Enabled = False
        cmdAdd.Enabled = False
        cmdRemove.Enabled = False
        cmdUp.Enabled = True
        cmdExit.Text = "&Cancel"
        ListView1.Enabled = False
        SCode.Enabled = True
        Course.Enabled = True
        Section.Enabled = True
        Day.Enabled = True
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If (cmdExit.Text = "&Exit") Then
            cmdExit.Text = "&Cancel"
        End If
        cmdAdd.Enabled = False
        ListView1.Enabled = False
        cmdEdit.Enabled = False
        cmdRemove.Enabled = False
        cmdUp.Enabled = True
        SCode.Enabled = True
        Course.Enabled = True
        Section.Enabled = True
        Day.Enabled = True
        cboAY.Enabled = True
        dtpETime.Enabled = True
        dtpSTime.Enabled = True
        addFlag = 1
    End Sub

    Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.Click
        Dim ry As String = "select  * from tblclass where SYear = '" & cboAY.Text & "' and SCode = '" & SCode.Text & "' and Course = '" & Course.Text & "' and Section = '" & Section.Text & "'"
        Dim er As New MySqlDataAdapter
        Dim nd As New MySqlCommand
        Dim ble As New DataTable
        nd.CommandText = ry : nd.Connection = Conn : er.SelectCommand = nd : er.Fill(ble)
        If (ble.Rows.Count = 1) Then
            MessageBox.Show("Duplicate Entry!")
        Else
            If addFlag = 0 Then
                Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
                Try
                    Conn.Open()
                    With cmd
                        .Connection = Conn
                        If result = 0 Then
                            MsgBox("Data has been Edited!")
                        Else
                            MsgBox("Successfully saved!")
                            LoadFile()
                            Clear()
                        End If
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Conn.Close()
                'add data 
            ElseIf addFlag = 1 Then
                Dim squery As String = "SELECT  COUNT(*) AS Tot FROM tblcmp WHERE SubCode='' AND CourseName='" & Course.Text & "' AND SecName='" & Section.Text & "'"
                Dim sadapter As New MySqlDataAdapter
                Dim scommand As New MySqlCommand
                Dim sqltable As New DataTable
                Dim result As Integer
                With scommand
                    .CommandText = squery
                    .Connection = Conn

                End With
                With sadapter
                    .SelectCommand = scommand
                    .Fill(sqltable)
                End With
                Conn.Close()
                If (sqltable.Rows(0)("Tot") >= 1) Then
                    Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
                    Try
                        Conn.Open()
                        With cmd
                            .Connection = Conn
                            .CommandText = "INSERT INTO `tblclass` (`SCode`, `Course`, `Section`,`Day`,`SYear`,`STime`,`ETime`) " & _
                                            "VALUES ('" & SCode.Text & "','" & Course.Text & "','" & Section.Text & "','" & Day.Text & "','" & cboAY.Text & "','" & dtpSTime.Text & "','" & dtpETime.Text & "');"
                            result = cmd.ExecuteNonQuery
                            .CommandText = "UPDATE tblcmp SET SubCode = '" & SCode.Text & "' WHERE CourseName = '" & Course.Text & "' AND SecName= '" & Section.Text & "';"
                            result = cmd.ExecuteNonQuery
                            If result = 0 Then
                                MsgBox("Data has been Inserted!")
                            Else
                                MsgBox("Successfully saved!")
                            End If
                        End With
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Conn.Close()
                    addDataType1()
                End If
                'dito ilalagay yung inalis
                If (sqltable.Rows(0)("Tot") = 0) Then
                    Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
                    Try
                        Conn.Open()
                        With cmd
                            .Connection = Conn
                            .CommandText = "INSERT INTO `tblclass` (`SCode`, `Course`, `Section`,`Day`,`SYear`,`STime`,`ETime`) " & _
                                           "VALUES ('" & SCode.Text & "','" & Course.Text & "','" & Section.Text & "','" & Day.Text & "','" & cboAY.Text & "','" & dtpSTime.Text & "','" & dtpETime.Text & "');"
                            result = cmd.ExecuteNonQuery
                            If result = 0 Then
                                MsgBox("Data has been Inserted!")
                            Else
                                MsgBox("Successfully saved!")

                            End If
                        End With
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Conn.Close()

                    Dim sq As String = "SELECT * FROM tblcmp WHERE Subcode !='' AND CourseName='" & Course.Text & "' AND SecName='" & Section.Text & "'"
                    Dim sa As New MySqlDataAdapter
                    Dim sc As New MySqlCommand
                    Dim sql As New DataTable
                    Dim i As Integer
                    With sc
                        .CommandText = sq
                        .Connection = Conn

                    End With
                    With sa
                        .SelectCommand = sc
                        .Fill(sql)
                    End With
                    For i = 0 To sql.Rows.Count - 1
                        lblStudNum.Text = sql.Rows(i)("StudNum")
                        lblLName.Text = sql.Rows(i)("LName")
                        lblFName.Text = sql.Rows(i)("FName")
                        lblCName.Text = sql.Rows(i)("CourseName")
                        lblSName.Text = sql.Rows(i)("SecName")
                        'try add
                        Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
                        Try
                            Conn.Open()
                            With cmd
                                .Connection = Conn
                                .CommandText = "INSERT INTO tblass (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                                  "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblass (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                                           "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblass (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                                           "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                'QUIZ
                                .CommandText = "INSERT INTO tblquiz (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                                           "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblquiz (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                                           "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblquiz (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                                           "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                'SEATWORK
                                .CommandText = "INSERT INTO tblseatwork (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                                           "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblseatwork (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                                           "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblseatwork (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                                           "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                'Rec
                                .CommandText = "INSERT INTO tblrec (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                                          "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblrec (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                                          "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblrec (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                                          "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                'Proj
                                .CommandText = "INSERT INTO tblproj (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                                         "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblproj (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                                          "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblproj (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                                          "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                'other
                                .CommandText = "INSERT INTO tblother (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                                         "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblother (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                                          "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblother (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                                          "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                'Exam
                                .CommandText = "INSERT INTO tblexam (SNum,LName,FName,SCode,N1,Rat,Grade,Term,SYear)" & _
                                         "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','P','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblexam (SNum,LName,FName,SCode,N1,Rat,Grade,Term,SYear)" & _
                                         "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','M','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblexam (SNum,LName,FName,SCode,N1,Rat,Grade,Term,SYear)" & _
                                         "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','F','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                'GradeSheet
                                .CommandText = "INSERT INTO tblgradesheet (SNum,LName,FName,SCode,AssT,AssR,AssG,ExT,ExR,ExG,OthT,OthR,OthG,ProT,ProR,ProG,QuiT,QuiR,QuiG,RecT,RecR,RecG,SeatT,SeatR,SeatG,Term,SYear)" & _
                                         "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblgradesheet (SNum,LName,FName,SCode,AssT,AssR,AssG,ExT,ExR,ExG,OthT,OthR,OthG,ProT,ProR,ProG,QuiT,QuiR,QuiG,RecT,RecR,RecG,SeatT,SeatR,SeatG,Term,SYear)" & _
                                         "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                .CommandText = "INSERT INTO tblgradesheet (SNum,LName,FName,SCode,AssT,AssR,AssG,ExT,ExR,ExG,OthT,OthR,OthG,ProT,ProR,ProG,QuiT,QuiR,QuiG,RecT,RecR,RecG,SeatT,SeatR,SeatG,Term,SYear)" & _
                                         "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                                'Gsheet
                                .CommandText = "INSERT INTO tblgsheet (SNum,LName,FName,PGrade,MGrade,FGrade,SFinal,FNum,Remarks,Scode,Course,Section,SYear)" & _
                                         "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','50','50','50','50','0','','" & SCode.Text & "','" & Course.Text & "','" & Section.Text & "','" & cboAY.Text & "');"
                                result = cmd.ExecuteNonQuery
                            End With
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        Conn.Close()
                    Next
                End If
            End If
        End If
        LoadFile()
        Clear()
        addFlag = 0
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        CYN = MsgBox("Do you really want to Remove this Data?", MsgBoxStyle.YesNo)
        If CYN = MsgBoxResult.Yes Then
            Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
            Try
                Conn.Open()

                With cmd
                    .Connection = Conn
                    .CommandText = "delete from tblclass WHERE SCode='" & lblCode.Text & "' AND Course='" & Course.Text & "' AND Section='" & Section.Text & "' ;"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "UPDATE tblcmp SET SubCode = '' WHERE CourseName = '" & Course.Text & "' AND SecName= '" & Section.Text & "';"
                    result = cmd.ExecuteNonQuery
                    If result = 0 Then
                        MsgBox("Data has been Inserted!")
                    Else
                        MsgBox("Successfully saved!")                
                    End If
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Conn.Close()
            Delclass()
            LoadFile()
            Clear()
        End If
    End Sub
    Public Sub addDataType1()
        Dim squery As String = "SELECT * FROM tblcmp WHERE Subcode !='' AND CourseName='" & Course.Text & "' AND SecName='" & Section.Text & "'"
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
            lblStudNum.Text = sqltable.Rows(i)("StudNum")
            lblLName.Text = sqltable.Rows(i)("LName")
            lblFName.Text = sqltable.Rows(i)("FName")
            lblCName.Text = sqltable.Rows(i)("CourseName")
            lblSName.Text = sqltable.Rows(i)("SecName")
            'try add
            Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
            Try
                Conn.Open()
                With cmd
                    .Connection = Conn
                    'ASS
                    .CommandText = "INSERT INTO tblass (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                               "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblass (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                               "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblass (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                               "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    'QUIZ
                    .CommandText = "INSERT INTO tblquiz (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                               "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblquiz (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                               "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblquiz (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                               "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    'SEATWORK
                    .CommandText = "INSERT INTO tblseatwork (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                               "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblseatwork (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                               "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblseatwork (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,Total,Rat,Grade,Term,SYear)" & _
                               "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    'Rec
                    .CommandText = "INSERT INTO tblrec (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                              "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblrec (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                              "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblrec (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                              "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    'Proj
                    .CommandText = "INSERT INTO tblproj (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                             "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblproj (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                              "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblproj (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                              "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    'other
                    .CommandText = "INSERT INTO tblother (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                             "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblother (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                              "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblother (SNum,LName,FName,SCode,N1,N2,N3,N4,N5,Total,Rat,Grade,Term,SYear)" & _
                              "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    'Exam
                    .CommandText = "INSERT INTO tblexam (SNum,LName,FName,SCode,N1,Rat,Grade,Term,SYear)" & _
                             "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','P','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblexam (SNum,LName,FName,SCode,N1,Rat,Grade,Term,SYear)" & _
                             "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','M','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblexam (SNum,LName,FName,SCode,N1,Rat,Grade,Term,SYear)" & _
                             "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','F','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    'GradeSheet
                    .CommandText = "INSERT INTO tblgradesheet (SNum,LName,FName,SCode,AssT,AssR,AssG,ExT,ExR,ExG,OthT,OthR,OthG,ProT,ProR,ProG,QuiT,QuiR,QuiG,RecT,RecR,RecG,SeatT,SeatR,SeatG,Term,SYear)" & _
                             "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','P','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblgradesheet (SNum,LName,FName,SCode,AssT,AssR,AssG,ExT,ExR,ExG,OthT,OthR,OthG,ProT,ProR,ProG,QuiT,QuiR,QuiG,RecT,RecR,RecG,SeatT,SeatR,SeatG,Term,SYear)" & _
                             "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','M','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    .CommandText = "INSERT INTO tblgradesheet (SNum,LName,FName,SCode,AssT,AssR,AssG,ExT,ExR,ExG,OthT,OthR,OthG,ProT,ProR,ProG,QuiT,QuiR,QuiG,RecT,RecR,RecG,SeatT,SeatR,SeatG,Term,SYear)" & _
                             "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','" & SCode.Text & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','F','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                    'Gsheet
                    .CommandText = "INSERT INTO tblgsheet (SNum,LName,FName,PGrade,MGrade,FGrade,SFinal,FNum,Remarks,Scode,Course,Section,SYear)" & _
                             "VALUES ('" & lblStudNum.Text & "','" & lblLName.Text & "','" & lblFName.Text & "','50','50','50','50','0','','" & SCode.Text & "','" & Course.Text & "','" & Section.Text & "','" & cboAY.Text & "');"
                    result = cmd.ExecuteNonQuery
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Conn.Close()
        Next
    End Sub
    Public Sub Delclass()
        Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Try
            Conn.Open()
            With cmd
                .Connection = Conn
                .CommandText = "delete from tblass where SCode = '" & lblCode.Text & "';"
                result = cmd.ExecuteNonQuery
                .CommandText = "delete from tblquiz where SCode = '" & lblCode.Text & "';"
                result = cmd.ExecuteNonQuery
                .CommandText = "delete from tblseatwork where SCode = '" & lblCode.Text & "';"
                result = cmd.ExecuteNonQuery
                .CommandText = "delete from tblrec where SCode = '" & lblCode.Text & "';"
                result = cmd.ExecuteNonQuery
                .CommandText = "delete from tblproj where SCode = '" & lblCode.Text & "';"
                result = cmd.ExecuteNonQuery
                .CommandText = "delete from tblexam where SCode = '" & lblCode.Text & "';"
                result = cmd.ExecuteNonQuery
                .CommandText = "delete from tblother where SCode = '" & lblCode.Text & "';"
                result = cmd.ExecuteNonQuery
                .CommandText = "delete from tblgradesheet where SCode = '" & lblCode.Text & "';"
                result = cmd.ExecuteNonQuery
                .CommandText = "delete from tblgsheet where SCode = '" & lblCode.Text & "';"
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Data has been Edited!")
                Else
                    MsgBox("Successfully saved!")
                    LoadFile()
                    Clear()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub
    Public Sub fillAY()
        cboAY.Items.Clear()
        Dim squery As String = "select distinct SYear from tbltc"
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
        dBDisconnect()
    End Sub
    Public Sub dBConnect()
        If Not Conn Is Nothing Then Conn.Close()
        Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Conn.Open()
    End Sub
    Public Sub dBDisconnect()
        Conn.Close()
    End Sub

    Private Sub cboAY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAY.SelectedIndexChanged
        SCode.Items.Clear()
        Dim squery As String = "select  SCode from tblsubj where SYear = '" & cboAY.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        scommand.CommandText = squery
        scommand.Connection = Conn
        sadapter.SelectCommand = scommand
        sadapter.Fill(sqltable)
        For i = 0 To sqltable.Rows.Count - 1
            SCode.Items.Add(sqltable.Rows(i)("SCode"))
        Next
        dBDisconnect()
    End Sub
End Class
