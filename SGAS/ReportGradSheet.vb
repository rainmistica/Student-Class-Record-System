Imports MySql.Data.MySqlClient
Public Class ReportGradSheet
    Dim DatabaseName As String = "dbclassrec"
    Dim server As String = "localhost"
    Dim userName As String = "root"
    Dim password As String = "1234"
    Dim dB As New MySqlConnection
    Dim cmd As New MySqlCommand
    Public Property FN As String
    Private Sub ReportGradSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dBConnect()
        fillAY()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
        Using conn As New MySqlConnection(String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName))
            conn.Open()
            Dim command As New MySqlCommand("select snum,LName,FName,AssR,assg,exr,exg,othr,othg,pror,prog,quir,quig,recr,recg,seatr,seatg,totalgrade from tblgradesheet where SYear='" & cboAY.Text & "' and SCode='" & cboSubCode.Text & "' and Term ='" & lblTerm.Text & "'", conn)
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
        Dim squery As String = "select snum,LName,FName,AssR,assg,exr,exg,othr,othg,pror,prog,quir,quig,recr,recg,seatr,seatg,totalgrade from tblgradesheet where SYear='" & cboAY.Text & "' and SCode='" & cboSubCode.Text & "' and Term ='" & lblTerm.Text & "'"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim ds As New DataSet
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(ds)

        xlWorkSheet.Cells(1, 1) = "GRADING SHEET REPORT FOR AY " + cboAY.Text ' Class
        xlWorkSheet.Cells(2, 1) = "Subject: " + cboSubCode.Text ' Class
        xlWorkSheet.Cells(3, 1) = "Instructor: " + FN ' Class
        xlWorkSheet.Cells(4, 1) = "Date Created: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString ' Class
        xlWorkSheet.Cells(5, 1) = "Grading Period: " + ComboBox1.Text
        ''''''''''''''''''''''''''''''''''''''''''''''''''
        xlWorkSheet.Cells(9, 1) = "Student Number"
        xlWorkSheet.Cells(9, 2) = "Last Name"
        xlWorkSheet.Cells(9, 3) = "FirstName"
        xlWorkSheet.Cells(9, 4) = "Ass Rating"
        xlWorkSheet.Cells(9, 5) = "Ass Grade"
        xlWorkSheet.Cells(9, 6) = "Exam Rating"
        xlWorkSheet.Cells(9, 7) = "Exam Grade"
        xlWorkSheet.Cells(9, 8) = "Other Rating"
        xlWorkSheet.Cells(9, 9) = "Other Grade"
        xlWorkSheet.Cells(9, 10) = "Project Rating"
        xlWorkSheet.Cells(9, 11) = "Project Grade"
        xlWorkSheet.Cells(9, 12) = "Quiz Rating"
        xlWorkSheet.Cells(9, 13) = "Quiz Grade"
        xlWorkSheet.Cells(9, 14) = "Rec Rating"
        xlWorkSheet.Cells(9, 15) = "Rec Grade"
        xlWorkSheet.Cells(9, 16) = "SW Rating"
        xlWorkSheet.Cells(9, 17) = "SW Grade"
        xlWorkSheet.Cells(9, 18) = "GrandTotal"
        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    ' xlWorkSheet.Cells(7, k) = DataGridView1.Columns(k - 1).HeaderText  'SA ULO 
                    xlWorkSheet.Cells(i + 10, j + 1) = DataGridView1(j, i).Value.ToString ' SA LAMAN
                Next
            Next
        Next
        dB.Close()

        Dim sq As String = "select  * from tbltc where SYear = '" & cboAY.Text & "' and SCode = '" & cboSubCode.Text & "' "
        Dim sa As New MySqlDataAdapter
        Dim sc As New MySqlCommand
        Dim sql As New DataTable
        sc.CommandText = sq
        sc.Connection = dB
        sa.SelectCommand = sc
        sa.Fill(sql)
        xlWorkSheet.Cells(6, 1) = "Assignment(%): "
        xlWorkSheet.Cells(7, 1) = sql.Rows(0)("Assign") * 100
        xlWorkSheet.Cells(6, 2) = "Quiz(%): "
        xlWorkSheet.Cells(7, 2) = sql.Rows(0)("Quiz") * 100
        xlWorkSheet.Cells(6, 3) = "Seatwork(%): "
        xlWorkSheet.Cells(7, 3) = sql.Rows(0)("SW") * 100
        xlWorkSheet.Cells(6, 4) = "Recitation(%): "
        xlWorkSheet.Cells(7, 4) = sql.Rows(0)("Rec") * 100
        xlWorkSheet.Cells(6, 5) = "Project(%): "
        xlWorkSheet.Cells(7, 5) = sql.Rows(0)("Proj") * 100
        xlWorkSheet.Cells(6, 6) = "Other(%): "
        xlWorkSheet.Cells(7, 6) = sql.Rows(0)("Other") * 100
        xlWorkSheet.Cells(6, 7) = "Examination(%): "
        xlWorkSheet.Cells(7, 7) = sql.Rows(0)("Exam") * 100
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
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.Text = "Prelim") Then
            lblTerm.Text = "P"
        ElseIf (ComboBox1.Text = "Midterm") Then
            lblTerm.Text = "M"
        ElseIf (ComboBox1.Text = "Finals") Then
            lblTerm.Text = "F"
        End If
    End Sub
End Class