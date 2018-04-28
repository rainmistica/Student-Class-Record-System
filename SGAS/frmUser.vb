Imports MySql.Data.MySqlClient
Public Class frmUser
    Dim ExitYN, CYN As System.Windows.Forms.DialogResult
    Dim Conn As New MySqlConnection
    Dim DatabaseName As String = "dbclassrec"
    Dim server As String = "localhost"
    Dim userName As String = "root"
    Dim password As String = "1234"
    Dim result As Integer
    Dim cmd As New MySqlCommand
    Dim addFlag As Integer
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            txtPass.PasswordChar = ""
        ElseIf (CheckBox1.Checked = False) Then
            txtPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub frmUserAcc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqConnect()
        LoadFile()
        cmdEdit.Enabled = False
        cmdRemove.Enabled = False
        cmdUp.Enabled = False
    End Sub
    Public Sub sqConnect()
        If Not Conn Is Nothing Then Conn.Close()
        Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Conn.Open()
    End Sub
    Public Sub LoadFile()
        ListView1.Items.Clear()
        Dim squery As String = "SELECT * FROM tbluseracc"
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
            With ListView1
                .Items.Add(sqltable.Rows(i)("User"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(sqltable.Rows(i)("Pass"))
                    .Add(sqltable.Rows(i)("Level"))
                    .Add(sqltable.Rows(i)("FullName"))
                End With
            End With
        Next
        Conn.Close()
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
                Me.txtUser.Text = .Text
                Me.Label5.Text = .Text
                Me.txtPass.Text = .SubItems(1).Text
                Me.lblAll.Text = .SubItems(3).Text
                txtUser.Enabled = False
                txtPass.Enabled = False
                txtFN.Enabled = False
                txtLN.Enabled = False
                txtMN.Enabled = False
                cboCat.Enabled = False
                CheckBox1.Enabled = False
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
        txtUser.Enabled = True
        txtPass.Enabled = True
        cboCat.Enabled = True
        txtFN.Enabled = True
        txtLN.Enabled = True
        txtMN.Enabled = True
        txtFN.Text = ""
        txtLN.Text = ""
        txtMN.Text = ""
        txtUser.Text = ""
        txtPass.Text = ""
        cboCat.Text = ""
        CheckBox1.Checked = False
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
        txtUser.Enabled = True
        txtPass.Enabled = True
        cboCat.Enabled = True
        CheckBox1.Enabled = True
        txtFN.Enabled = True
        txtLN.Enabled = True
        txtMN.Enabled = True
        addFlag = 1
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        cmdEdit.Enabled = False
        cmdAdd.Enabled = False
        cmdRemove.Enabled = False
        cmdUp.Enabled = True
        cmdExit.Text = "&Cancel"
        ListView1.Enabled = False
        txtUser.Enabled = True
        txtPass.Enabled = True
        cboCat.Enabled = True
        txtFN.Enabled = True
        txtLN.Enabled = True
        txtMN.Enabled = True
        CheckBox1.Enabled = True
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        CYN = MsgBox("Do you really want to Remove this Data?", MsgBoxStyle.YesNo)
        If CYN = MsgBoxResult.Yes Then
            Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
            Try
                Conn.Open()

                With cmd
                    .Connection = Conn
                    .CommandText = "DELETE FROM tbluseracc WHERE User='" & txtUser.Text & "';"
                    result = cmd.ExecuteNonQuery
                    If result = 0 Then
                        MsgBox("Data has been Inserted!")
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


        End If
    End Sub

    Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.Click
        lblAll.Text = txtFN.Text + " " + txtMN.Text + " " + txtLN.Text
        If (txtFN.Text = "" Or txtLN.Text = "" Or txtMN.Text = "" Or txtUser.Text = "" Or txtPass.Text = "") Then
            MessageBox.Show("Please Fill Information!")
        Else
        If addFlag = 0 Then
            Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
            Try
                Conn.Open()
                With cmd
                    .Connection = Conn
                    .CommandText = "UPDATE tbluseracc SET User= '" & txtUser.Text & "',Pass = '" & txtPass.Text & "',FullName = '" & lblAll.Text & "',Level = '" & cboCat.Text & "' where User ='" & Label5.Text & "' ;"
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
        ElseIf addFlag = 1 Then
            Conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
            Try
                Conn.Open()
                With cmd
                    .Connection = Conn
                    .CommandText = "INSERT INTO tbluseracc (`User`, `Pass`,Level,FullName) " & _
                                    "VALUES ('" & txtUser.Text & "','" & txtPass.Text & "','" & cboCat.Text & "','" & lblAll.Text & "');"
                    result = cmd.ExecuteNonQuery
                    If result = 0 Then
                        MsgBox("Data has been Inserted!")
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
            addFlag = 0
            End If
        End If
        addFlag = 0
    End Sub
End Class