<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClass))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdUp = New System.Windows.Forms.Button()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SCode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Course = New System.Windows.Forms.ComboBox()
        Me.Section = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Day = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.lblStudNum = New System.Windows.Forms.Label()
        Me.lblCName = New System.Windows.Forms.Label()
        Me.lblSName = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.dtpSTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpETime = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboAY = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 207)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Class List"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(7, 15)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(423, 184)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SubCode"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Course"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Section"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "StartTime"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "EndTime"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "AcadYear"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Schedule"
        '
        'cmdUp
        '
        Me.cmdUp.BackColor = System.Drawing.Color.Gray
        Me.cmdUp.BackgroundImage = CType(resources.GetObject("cmdUp.BackgroundImage"), System.Drawing.Image)
        Me.cmdUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdUp.FlatAppearance.BorderSize = 0
        Me.cmdUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUp.ForeColor = System.Drawing.Color.White
        Me.cmdUp.Location = New System.Drawing.Point(448, 195)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(56, 23)
        Me.cmdUp.TabIndex = 3
        Me.cmdUp.Text = "&Save"
        Me.cmdUp.UseVisualStyleBackColor = False
        '
        'cmdRemove
        '
        Me.cmdRemove.BackColor = System.Drawing.Color.Gray
        Me.cmdRemove.BackgroundImage = CType(resources.GetObject("cmdRemove.BackgroundImage"), System.Drawing.Image)
        Me.cmdRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdRemove.FlatAppearance.BorderSize = 0
        Me.cmdRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRemove.ForeColor = System.Drawing.Color.White
        Me.cmdRemove.Location = New System.Drawing.Point(448, 166)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(56, 23)
        Me.cmdRemove.TabIndex = 4
        Me.cmdRemove.Text = "&Remove"
        Me.cmdRemove.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Gray
        Me.cmdExit.BackgroundImage = CType(resources.GetObject("cmdExit.BackgroundImage"), System.Drawing.Image)
        Me.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdExit.FlatAppearance.BorderSize = 0
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(448, 224)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(56, 23)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "&Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(5, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Subject Code:"
        '
        'SCode
        '
        Me.SCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SCode.Enabled = False
        Me.SCode.FormattingEnabled = True
        Me.SCode.Location = New System.Drawing.Point(82, 44)
        Me.SCode.Name = "SCode"
        Me.SCode.Size = New System.Drawing.Size(89, 21)
        Me.SCode.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(180, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Course:"
        '
        'Course
        '
        Me.Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Course.Enabled = False
        Me.Course.FormattingEnabled = True
        Me.Course.Location = New System.Drawing.Point(235, 44)
        Me.Course.Name = "Course"
        Me.Course.Size = New System.Drawing.Size(91, 21)
        Me.Course.TabIndex = 9
        '
        'Section
        '
        Me.Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Section.Enabled = False
        Me.Section.FormattingEnabled = True
        Me.Section.Location = New System.Drawing.Point(388, 44)
        Me.Section.Name = "Section"
        Me.Section.Size = New System.Drawing.Size(61, 21)
        Me.Section.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(332, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Section:"
        '
        'Day
        '
        Me.Day.Enabled = False
        Me.Day.Location = New System.Drawing.Point(388, 71)
        Me.Day.Name = "Day"
        Me.Day.Size = New System.Drawing.Size(61, 20)
        Me.Day.TabIndex = 24
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.Gray
        Me.cmdAdd.BackgroundImage = CType(resources.GetObject("cmdAdd.BackgroundImage"), System.Drawing.Image)
        Me.cmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAdd.FlatAppearance.BorderSize = 0
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.ForeColor = System.Drawing.Color.White
        Me.cmdAdd.Location = New System.Drawing.Point(448, 137)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(56, 23)
        Me.cmdAdd.TabIndex = 27
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'lblStudNum
        '
        Me.lblStudNum.AutoSize = True
        Me.lblStudNum.Location = New System.Drawing.Point(635, 39)
        Me.lblStudNum.Name = "lblStudNum"
        Me.lblStudNum.Size = New System.Drawing.Size(61, 13)
        Me.lblStudNum.TabIndex = 28
        Me.lblStudNum.Text = "lblStudNum"
        Me.lblStudNum.Visible = False
        '
        'lblCName
        '
        Me.lblCName.AutoSize = True
        Me.lblCName.Location = New System.Drawing.Point(701, 39)
        Me.lblCName.Name = "lblCName"
        Me.lblCName.Size = New System.Drawing.Size(52, 13)
        Me.lblCName.TabIndex = 29
        Me.lblCName.Text = "lblCName"
        Me.lblCName.Visible = False
        '
        'lblSName
        '
        Me.lblSName.AutoSize = True
        Me.lblSName.Location = New System.Drawing.Point(780, 39)
        Me.lblSName.Name = "lblSName"
        Me.lblSName.Size = New System.Drawing.Size(52, 13)
        Me.lblSName.TabIndex = 30
        Me.lblSName.Text = "lblSName"
        Me.lblSName.Visible = False
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(635, 81)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(51, 13)
        Me.lblLName.TabIndex = 31
        Me.lblLName.Text = "lblLName"
        Me.lblLName.Visible = False
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(701, 81)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(51, 13)
        Me.lblFName.TabIndex = 32
        Me.lblFName.Text = "lblFName"
        Me.lblFName.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(662, 130)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        Me.cmdEdit.Visible = False
        '
        'dtpSTime
        '
        Me.dtpSTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpSTime.Enabled = False
        Me.dtpSTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSTime.Location = New System.Drawing.Point(82, 71)
        Me.dtpSTime.Name = "dtpSTime"
        Me.dtpSTime.Size = New System.Drawing.Size(89, 20)
        Me.dtpSTime.TabIndex = 33
        '
        'dtpETime
        '
        Me.dtpETime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpETime.Enabled = False
        Me.dtpETime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpETime.Location = New System.Drawing.Point(235, 72)
        Me.dtpETime.Name = "dtpETime"
        Me.dtpETime.Size = New System.Drawing.Size(91, 20)
        Me.dtpETime.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(5, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Start Time:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(179, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "End Time:"
        '
        'cboAY
        '
        Me.cboAY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAY.Enabled = False
        Me.cboAY.FormattingEnabled = True
        Me.cboAY.Location = New System.Drawing.Point(127, 13)
        Me.cboAY.Name = "cboAY"
        Me.cboAY.Size = New System.Drawing.Size(84, 21)
        Me.cboAY.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Select Academic Year:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(332, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Day:"
        '
        'gb
        '
        Me.gb.BackColor = System.Drawing.Color.Transparent
        Me.gb.Controls.Add(Me.lblCode)
        Me.gb.Controls.Add(Me.cboAY)
        Me.gb.Controls.Add(Me.Label7)
        Me.gb.Controls.Add(Me.Label6)
        Me.gb.Controls.Add(Me.Label5)
        Me.gb.Controls.Add(Me.Section)
        Me.gb.Controls.Add(Me.Label4)
        Me.gb.Controls.Add(Me.Label1)
        Me.gb.Controls.Add(Me.dtpETime)
        Me.gb.Controls.Add(Me.SCode)
        Me.gb.Controls.Add(Me.dtpSTime)
        Me.gb.Controls.Add(Me.Label2)
        Me.gb.Controls.Add(Me.Course)
        Me.gb.Controls.Add(Me.Label3)
        Me.gb.Controls.Add(Me.Day)
        Me.gb.Location = New System.Drawing.Point(12, 5)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(485, 104)
        Me.gb.TabIndex = 40
        Me.gb.TabStop = False
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(246, 16)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(0, 13)
        Me.lblCode.TabIndex = 40
        Me.lblCode.Visible = False
        '
        'frmClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SGAS.My.Resources.Resources.BG_Class
        Me.ClientSize = New System.Drawing.Size(509, 327)
        Me.Controls.Add(Me.gb)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblSName)
        Me.Controls.Add(Me.lblCName)
        Me.Controls.Add(Me.lblStudNum)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUp)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(515, 351)
        Me.MinimumSize = New System.Drawing.Size(515, 351)
        Me.Name = "frmClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class List"
        Me.GroupBox1.ResumeLayout(False)
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents cmdUp As System.Windows.Forms.Button
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Course As System.Windows.Forms.ComboBox
    Friend WithEvents Section As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Day As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents lblStudNum As System.Windows.Forms.Label
    Friend WithEvents lblCName As System.Windows.Forms.Label
    Friend WithEvents lblSName As System.Windows.Forms.Label
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents dtpSTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpETime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboAY As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCode As System.Windows.Forms.Label
End Class
