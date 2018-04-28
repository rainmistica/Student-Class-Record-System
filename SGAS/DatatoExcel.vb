Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Excel
Public Class DatatoExcel
    Dim DatabaseName As String = "dbclassrec"
    Dim server As String = "localhost"
    Dim userName As String = "root"
    Dim password As String = "1234"
    Dim dB As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub DatatoExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        Dim squery As String = "select * from tblstudlist"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim ds As New DataSet
        scommand.CommandText = squery
        scommand.Connection = dB
        sadapter.SelectCommand = scommand
        sadapter.Fill(ds)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText  'SA ULO 
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString ' SA LAMAN
                    'xlWorkSheet.Cells(i + 1, j + 2) = ds.Tables(0).Rows(i).Item(j)
                Next
            Next
        Next
        dB.Close()
        'USER
        dB.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        dB.Open()
        Dim sq As String = "select * from tbluseracc"
        Dim sa As New MySqlDataAdapter
        Dim sc As New MySqlCommand
        Dim sql As New DataSet
        sc.CommandText = sq
        sc.Connection = dB
        sa.SelectCommand = sc
        sa.Fill(sql)

        xlWorkSheet.Cells(3, 2) = "Creator"
        For i = 0 To sql.Tables(0).Rows.Count - 1
            For j = 0 To sql.Tables(0).Columns.Count - 1
                xlWorkSheet.Cells(i + 3, j + 3) = sql.Tables(0).Rows(i).Item(j)
            Next
        Next
        dB.Close()
        xlWorkSheet.SaveAs("C:\vbexcel.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)



        MsgBox("You can find the file C:\vbexcel.xlsx")

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