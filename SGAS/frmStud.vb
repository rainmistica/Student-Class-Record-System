Imports MySql.Data.MySqlClient
Public Class frmStud
    Dim ExitYN, CYN As System.Windows.Forms.DialogResult
    Dim dB As New MySqlConnection
    Dim DatabaseName As String = "dbclassrec"
    Dim server As String = "localhost"
    Dim userName As String = "root"
    Dim password As String = "1234"
    Dim result As Integer
    Dim cmd As New MySqlCommand
    Dim addflag As Integer
    Dim dup As Integer
    Private Sub frmStud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dBConnect()
        LoadFile()
        cmdEdit.Enabled = False
        cmdRemove.Enabled = False
        cmdUp.Enabled = False
    End Sub
    Public Sub LoadFile()
        ListView1.Items.Clear()
        Dim squery As String = "select  * from tblstudlist where status = 'ENROLLED' order by lname ASC"
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
                .Items.Add(sqltable.Rows(i)("StudNum"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(sqltable.Rows(i)("LName"))
                    .Add(sqltable.Rows(i)("FName"))
                    .Add(sqltable.Rows(i)("MName"))
                    .Add(sqltable.Rows(i)("Course"))
                    .Add(sqltable.Rows(i)("Section"))
                    .Add(sqltable.Rows(i)("CNum"))
                    .Add(sqltable.Rows(i)("EmailAdd"))
                    .Add(sqltable.Rows(i)("Gender"))
                End With
            End With
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

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If (cmdExit.Text = "&Exit") Then
            cmdExit.Text = "&Cancel"
        End If
        cmdAdd.Enabled = False
        cmdEdit.Enabled = False
        cmdRemove.Enabled = False
        cmdUp.Enabled = True
        ListView1.Enabled = False
        txtSNum.Enabled = True
        txtFN.Enabled = True
        txtMN.Enabled = True
        txtLN.Enabled = True
        cmbCou.Enabled = True
        cmbSec.Enabled = True
        cboSecLet.Enabled = True
        ComboBox1.Enabled = True
        cboGen.Enabled = True
        txtCNum.Enabled = True
        txtEAddd.Enabled = True
        addflag = 1
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        cmdEdit.Enabled = False
        cmdAdd.Enabled = False
        cmdRemove.Enabled = False
        cmdUp.Enabled = True
        cmdExit.Text = "&Cancel"
        ListView1.Enabled = False
        txtSNum.Enabled = True
        txtFN.Enabled = True
        txtMN.Enabled = True
        ComboBox1.Enabled = True
        txtLN.Enabled = True
        cmbCou.Enabled = True
        cmbSec.Enabled = True
        cboSecLet.Enabled = True
        cboGen.Enabled = True
        txtCNum.Enabled = True
        txtEAddd.Enabled = True
        addflag = 0
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If (cmdExit.Text = "&Cancel") Then
            Clear()

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
        txtSNum.Enabled = False
        txtSNum.Text = ""
        txtFN.Enabled = False
        txtFN.Text = ""
        txtMN.Enabled = False
        txtMN.Text = ""
        txtLN.Enabled = False
        txtLN.Text = ""
        cmbCou.Enabled = False
        cmbCou.Text = ""
        cmbSec.Enabled = False
        cmbSec.Text = ""
        cboSecLet.Enabled = False
        cboGen.Enabled = False
        cboGen.Text = ""
        txtCNum.Enabled = False
        ComboBox1.Enabled = False
        txtCNum.Text = ""
        txtEAddd.Enabled = False
        txtEAddd.Text = ""
        lblSection.Text = ""
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
                Me.txtSNum.Text = .Text
                Me.txtLN.Text = .SubItems(1).Text
                Me.txtFN.Text = .SubItems(2).Text
                Me.txtMN.Text = .SubItems(3).Text
                Me.cmbCou.Text = .SubItems(4).Text
                Me.lblSection.Text = .SubItems(5).Text
                Me.txtCNum.Text = .SubItems(6).Text
                Me.txtEAddd.Text = .SubItems(7).Text
                Me.cboGen.Text = .SubItems(8).Text
                txtSNum.Enabled = False
                txtFN.Enabled = False
                txtMN.Enabled = False
                txtLN.Enabled = False
                cmbCou.Enabled = False
                cmbSec.Enabled = False
                cboSecLet.Enabled = False
                cboGen.Enabled = False
                txtCNum.Enabled = False
                txtEAddd.Enabled = False
                ComboBox1.Enabled = False
                lblStudNum.Text = .Text
            End With
        End If
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        CYN = MsgBox("Do you really want to Remove this Data?", MsgBoxStyle.YesNo)
        If CYN = MsgBoxResult.Yes Then
            Try
                dB.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
                dB.Open()
                cmd.Connection = dB
                cmd.CommandText = "update tblstudlist Set Status='DROP' WHERE StudNum='" & lblStudNum.Text & "';"
                result = cmd.ExecuteNonQuery
                cmd.CommandText = "update tblstat Set Status='DROP' WHERE StudentNumber='" & lblStudNum.Text & "';"
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Data has been Inserted!")
                Else
                    MsgBox("Successfully saved!")
                    LoadFile()
                    Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        dBDisconnect()
        LoadFile()
        Clear()
    End Sub

    Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.Click
        If (txtSNum.Text = "" Or txtFN.Text = "" Or txtLN.Text = "" Or cmbSec.Text = "" Or cmbCou.Text = "" Or cboGen.Text = "" Or cboSecLet.Text = "" Or lblSection.Text = "") Then
            MessageBox.Show("Please Enter Info!")
        Else
            ExitYN = MsgBox("Confirm Save?", MsgBoxStyle.YesNo)
            If ExitYN = MsgBoxResult.Yes Then
                Dim squery As String = "select  * from tblstudlist where StudNum = '" & txtSNum.Text & "'"
                Dim sadapter As New MySqlDataAdapter
                Dim scommand As New MySqlCommand
                Dim sqltable As New DataTable
                scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
                If (sqltable.Rows.Count = 1) Then
                    MessageBox.Show("Duplicate Entry!")
                Else
                    If addflag = 0 Then
                        dBConnect()
                        Try
                            cmd.Connection = dB
                            cmd.CommandText = "UPDATE tblstudlist SET StudNum='" & txtSNum.Text & "',lname = '" & txtLN.Text & "',fname  = '" & txtFN.Text & "',mname= '" & txtMN.Text & "',course= '" & cmbCou.Text & "',section = '" & lblSection.Text & "',cnum= '" & txtCNum.Text & "',emailadd= '" & txtEAddd.Text & "',gender= '" & cboGen.Text & "' where studnum ='" & lblStudNum.Text & "' ;"
                            result = cmd.ExecuteNonQuery
                            cmd.CommandText = "Update tblstat set StudentNumber='" & txtSNum.Text & "' where StudentNumber ='" & lblStudNum.Text & "'"
                            result = cmd.ExecuteNonQuery
                            If result = 0 Then
                                MsgBox("Data has been Edited!")
                            Else
                                MsgBox("Successfully saved!")
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        dBDisconnect()
                        LoadFile()
                        Clear()
                    ElseIf addflag = 1 Then
                        dBConnect()
                        Try
                            cmd.Connection = dB
                            cmd.CommandText = "INSERT INTO `tblstudlist` (`StudNum`, `LName`, `FName`, `MName`,`Course`,`Section`,`CNum`,`EmailAdd`,`Status`,`gender`) " & _
                                            "VALUES ('" & txtSNum.Text & "', '" & txtLN.Text & "', '" & txtFN.Text & "', '" & txtMN.Text & "', '" & cmbCou.Text & "', '" & lblSection.Text & "', '" & txtCNum.Text & "', '" & txtEAddd.Text & "', 'ENROLLED', '" & cboGen.Text & "');"
                            result = cmd.ExecuteNonQuery
                            cmd.CommandText = "Insert into tblstat(StudentNumber,Status) Values ('" & txtSNum.Text & "','ENROLLED')"
                            result = cmd.ExecuteNonQuery
                            cmd.CommandText = "Insert into tblcmp(StudNum,LName,FName,SubCode,CourseName,SecName) Values ('" & txtSNum.Text & "','" & txtLN.Text & "','" & txtFN.Text & "','','" & cmbCou.Text & "','" & lblSection.Text & "')"
                            result = cmd.ExecuteNonQuery
                            If result = 0 Then
                                MsgBox("Data has been Edited!")
                            Else
                                MsgBox("Successfully saved!")
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        dBDisconnect()
                        LoadFile()
                        Clear()
                        addflag = 0
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmbCou_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCou.SelectedIndexChanged
        cmbSec.Items.Clear()
        If (cmbCou.Text = "BSHRM" Or cmbCou.Text = "BSE-ENG" Or cmbCou.Text = "BSE-MATH") Then
            For i = 1 To 4
                cmbSec.Items.Add(i)
            Next
        Else
            For i = 1 To 3
                cmbSec.Items.Add(i)
            Next
        End If
    End Sub

    Private Sub cmbSec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSec.SelectedIndexChanged
        lblSection.Text = cmbSec.Text + cboSecLet.Text
    End Sub

    Private Sub cboSecLet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSecLet.SelectedIndexChanged
        lblSection.Text = cmbSec.Text + cboSecLet.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        txtEAdd.Text = txtEAddd.Text + ComboBox1.Text

    End Sub

    Private Sub txtEAddd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEAddd.TextChanged
        txtEAdd.Text = txtEAddd.Text + ComboBox1.Text
    End Sub

    Private Sub txtSNum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSNum.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            txtSNum.Text = ""
            e.Handled = True
        End If
    End Sub

    Private Sub txtCNum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCNum.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            txtCNum.Text = ""
            e.Handled = True
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer
        ListView1.Items.Clear()
        If (cmbSearch.Text = "Student Number") Then
            Dim squery As String = "select  * from tblstudlist where (StudNum LIKE '" + txtSearch.Text + "%')"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            For i = 0 To sqltable.Rows.Count - 1
                With ListView1
                    .Items.Add(sqltable.Rows(i)("StudNum"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(sqltable.Rows(i)("LName"))
                        .Add(sqltable.Rows(i)("FName"))
                        .Add(sqltable.Rows(i)("MName"))
                        .Add(sqltable.Rows(i)("Course"))
                        .Add(sqltable.Rows(i)("Section"))
                        .Add(sqltable.Rows(i)("CNum"))
                        .Add(sqltable.Rows(i)("EmailAdd"))
                        .Add(sqltable.Rows(i)("Gender"))
                    End With
                End With
            Next
        ElseIf (cmbSearch.Text = "Last Name") Then
            Dim squery As String = "select  * from tblstudlist where (LName LIKE '" + txtSearch.Text + "%')"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            For i = 0 To sqltable.Rows.Count - 1
                With ListView1
                    .Items.Add(sqltable.Rows(i)("StudNum"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(sqltable.Rows(i)("LName"))
                        .Add(sqltable.Rows(i)("FName"))
                        .Add(sqltable.Rows(i)("MName"))
                        .Add(sqltable.Rows(i)("Course"))
                        .Add(sqltable.Rows(i)("Section"))
                        .Add(sqltable.Rows(i)("CNum"))
                        .Add(sqltable.Rows(i)("EmailAdd"))
                        .Add(sqltable.Rows(i)("Gender"))
                    End With
                End With
            Next
        ElseIf (cmbSearch.Text = "Course") Then
            Dim squery As String = "select  * from tblstudlist where (Course LIKE '" + txtSearch.Text + "%')"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            For i = 0 To sqltable.Rows.Count - 1
                With ListView1
                    .Items.Add(sqltable.Rows(i)("StudNum"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(sqltable.Rows(i)("LName"))
                        .Add(sqltable.Rows(i)("FName"))
                        .Add(sqltable.Rows(i)("MName"))
                        .Add(sqltable.Rows(i)("Course"))
                        .Add(sqltable.Rows(i)("Section"))
                        .Add(sqltable.Rows(i)("CNum"))
                        .Add(sqltable.Rows(i)("EmailAdd"))
                        .Add(sqltable.Rows(i)("Gender"))
                    End With
                End With
            Next
        ElseIf (cmbSearch.Text = "Gender") Then
            Dim squery As String = "select  * from tblstudlist where (Gender LIKE '" + txtSearch.Text + "%')"
            scommand.CommandText = squery : scommand.Connection = dB : sadapter.SelectCommand = scommand : sadapter.Fill(sqltable)
            For i = 0 To sqltable.Rows.Count - 1
                With ListView1
                    .Items.Add(sqltable.Rows(i)("StudNum"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(sqltable.Rows(i)("LName"))
                        .Add(sqltable.Rows(i)("FName"))
                        .Add(sqltable.Rows(i)("MName"))
                        .Add(sqltable.Rows(i)("Course"))
                        .Add(sqltable.Rows(i)("Section"))
                        .Add(sqltable.Rows(i)("CNum"))
                        .Add(sqltable.Rows(i)("EmailAdd"))
                        .Add(sqltable.Rows(i)("Gender"))
                    End With
                End With
            Next
        End If
        dBDisconnect()
    End Sub
End Class

