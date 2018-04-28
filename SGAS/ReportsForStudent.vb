Imports MySql.Data.MySqlClient
Public Class ReportsForStudent
    Dim DatabaseName As String = "dbclassrec"
    Dim server As String = "localhost"
    Dim userName As String = "root"
    Dim password As String = "1234"
    Dim dB As New MySqlConnection
    Dim cmd As New MySqlCommand
    Public Property FN As String

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

    Private Sub ReportsForStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dBConnect()
        fillAY()
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

    Private Sub cboSubCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubCode.SelectedIndexChanged
        lblSC.Text = cboSubCode.Text
        cboCourse.Items.Clear()
        cboSec.Items.Clear()
        Dim squery As String = "select distinct Course from tblclass where SYear = '" & cboAY.Text & "' and SCode = '" & lblSC.Text & "'"
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
        Dim sq As String = "select  * from tblsubj where SYear = '" & cboAY.Text & "' and SCode = '" & lblSC.Text & "'"
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
        Using conn As New MySqlConnection(String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName))
            conn.Open()
            Dim command As New MySqlCommand("select distinct studnum,lname,fname,mname,tblstudlist.status from tblstudlist,tblclass where SYear='" & cboAY.Text & "' and SCode='" & cboSubCode.Text & "' and tblstudlist.course='" & cboCourse.Text & "' and tblstudlist.section ='" & cboSec.Text & "'", conn)
            Dim adapter As New MySqlDataAdapter
            Dim dt As New DataTable
            adapter.SelectCommand = command
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
            adapter.Dispose()
            command.Dispose()
            conn.Close()
        End Using
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        dB.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        dB.Open()
        Dim squery As String = "select distinct studnum,lname,fname,mname,tblstudlist.status from tblstudlist,tblclass where SYear='" & cboAY.Text & "' and SCode='" & cboSubCode.Text & "' and tblstudlist.course='" & cboCourse.Text & "' and tblstudlist.section ='" & cboSec.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim ds As New DataSet
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(ds)

        xlWorkSheet.Cells(1, 1) = "STUDENT LIST REPORT FOR AY " + cboAY.Text ' Class
        xlWorkSheet.Cells(2, 1) = "Subject: " + cboSubCode.Text ' Class
        xlWorkSheet.Cells(3, 1) = "Instructor: " + FN ' Class
        xlWorkSheet.Cells(4, 1) = "Class: " + cboCourse.Text + "-" + cboSec.Text ' Class
        xlWorkSheet.Cells(5, 1) = "Date Created: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString ' Class

        xlWorkSheet.Cells(8, 1) = "StudentNumber"
        xlWorkSheet.Cells(8, 2) = "LastName"
        xlWorkSheet.Cells(8, 3) = "FirstName"
        xlWorkSheet.Cells(8, 4) = "MiddleName"
        xlWorkSheet.Cells(8, 5) = "Status"
        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    'xlWorkSheet.Cells(8, k) = DataGridView1.Columns(k - 1).HeaderText  'SA ULO 
                    xlWorkSheet.Cells(i + 9, j + 1) = DataGridView1(j, i).Value.ToString ' SA LAMAN
                Next
            Next
        Next
        dB.Close()

        'Saving 
        SaveFileDialog1.Title = "Save an Excel File"
        SaveFileDialog1.ShowDialog()
        If (SaveFileDialog1.FileName = "") Then

        Else
            xlWorkSheet.SaveAs(SaveFileDialog1.FileName.ToString())
            xlWorkBook.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            MsgBox("SuccessFully Save!")
        End If
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class