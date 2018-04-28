<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStud))
        Me.cmdUp = New System.Windows.Forms.Button()
        Me.txtEAddd = New System.Windows.Forms.TextBox()
        Me.txtCNum = New System.Windows.Forms.TextBox()
        Me.cmbCou = New System.Windows.Forms.ComboBox()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.txtMN = New System.Windows.Forms.TextBox()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.txtSNum = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Sn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ln = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cou = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Se = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.cboSecLet = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboGen = New System.Windows.Forms.ComboBox()
        Me.cmbSec = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblStudNum = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.txtEAdd = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdUp
        '
        Me.cmdUp.BackColor = System.Drawing.Color.Gray
        Me.cmdUp.BackgroundImage = CType(resources.GetObject("cmdUp.BackgroundImage"), System.Drawing.Image)
        Me.cmdUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdUp.FlatAppearance.BorderSize = 0
        Me.cmdUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUp.ForeColor = System.Drawing.Color.White
        Me.cmdUp.Location = New System.Drawing.Point(638, 240)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(50, 21)
        Me.cmdUp.TabIndex = 56
        Me.cmdUp.Text = "&Save"
        Me.cmdUp.UseVisualStyleBackColor = False
        '
        'txtEAddd
        '
        Me.txtEAddd.Enabled = False
        Me.txtEAddd.Location = New System.Drawing.Point(323, 73)
        Me.txtEAddd.Name = "txtEAddd"
        Me.txtEAddd.Size = New System.Drawing.Size(80, 20)
        Me.txtEAddd.TabIndex = 53
        '
        'txtCNum
        '
        Me.txtCNum.Enabled = False
        Me.txtCNum.Location = New System.Drawing.Point(102, 73)
        Me.txtCNum.Name = "txtCNum"
        Me.txtCNum.Size = New System.Drawing.Size(108, 20)
        Me.txtCNum.TabIndex = 52
        '
        'cmbCou
        '
        Me.cmbCou.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCou.Enabled = False
        Me.cmbCou.FormattingEnabled = True
        Me.cmbCou.Items.AddRange(New Object() {"COET", "ECET", "EET", "CET", "BSHRM", "BSE-ENG", "BSE-MATH"})
        Me.cmbCou.Location = New System.Drawing.Point(323, 19)
        Me.cmbCou.Name = "cmbCou"
        Me.cmbCou.Size = New System.Drawing.Size(145, 21)
        Me.cmbCou.TabIndex = 50
        '
        'txtLN
        '
        Me.txtLN.Enabled = False
        Me.txtLN.Location = New System.Drawing.Point(545, 46)
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(96, 20)
        Me.txtLN.TabIndex = 49
        '
        'txtMN
        '
        Me.txtMN.Enabled = False
        Me.txtMN.Location = New System.Drawing.Point(322, 46)
        Me.txtMN.Name = "txtMN"
        Me.txtMN.Size = New System.Drawing.Size(146, 20)
        Me.txtMN.TabIndex = 48
        '
        'txtFN
        '
        Me.txtFN.Enabled = False
        Me.txtFN.Location = New System.Drawing.Point(102, 45)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(108, 20)
        Me.txtFN.TabIndex = 47
        '
        'txtSNum
        '
        Me.txtSNum.Enabled = False
        Me.txtSNum.Location = New System.Drawing.Point(102, 19)
        Me.txtSNum.Name = "txtSNum"
        Me.txtSNum.Size = New System.Drawing.Size(108, 20)
        Me.txtSNum.TabIndex = 45
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(240, 73)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(76, 13)
        Me.label7.TabIndex = 44
        Me.label7.Text = "Email Address:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(24, 73)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(64, 13)
        Me.label6.TabIndex = 43
        Me.label6.Text = "Contact No."
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(240, 24)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(47, 13)
        Me.label5.TabIndex = 42
        Me.label5.Text = "*Course:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(474, 49)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(65, 13)
        Me.label4.TabIndex = 41
        Me.label4.Text = "*Last Name:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(68, 13)
        Me.label1.TabIndex = 38
        Me.label1.Text = "*Student No:"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Gray
        Me.cmdExit.BackgroundImage = CType(resources.GetObject("cmdExit.BackgroundImage"), System.Drawing.Image)
        Me.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdExit.FlatAppearance.BorderSize = 0
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(638, 267)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(50, 21)
        Me.cmdExit.TabIndex = 37
        Me.cmdExit.Text = "&Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Sn, Me.Ln, Me.Fn, Me.Mn, Me.Cou, Me.Se, Me.Cn, Me.Ea, Me.gen})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(610, 174)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Sn
        '
        Me.Sn.Text = "Student No."
        Me.Sn.Width = 69
        '
        'Ln
        '
        Me.Ln.Text = "Last Name"
        Me.Ln.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Ln.Width = 69
        '
        'Fn
        '
        Me.Fn.Text = "First Name"
        Me.Fn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Fn.Width = 73
        '
        'Mn
        '
        Me.Mn.Text = "Middle Name"
        Me.Mn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mn.Width = 77
        '
        'Cou
        '
        Me.Cou.Text = "Course"
        Me.Cou.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cou.Width = 52
        '
        'Se
        '
        Me.Se.Text = "Section"
        Me.Se.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Se.Width = 46
        '
        'Cn
        '
        Me.Cn.Text = "Contact No."
        Me.Cn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cn.Width = 80
        '
        'Ea
        '
        Me.Ea.Text = "Email Address"
        Me.Ea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Ea.Width = 80
        '
        'gen
        '
        Me.gen.Text = "Gender"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(240, 49)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(72, 13)
        Me.label3.TabIndex = 40
        Me.label3.Text = "Middle Name:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(20, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 13)
        Me.label2.TabIndex = 39
        Me.label2.Text = "*First Name:"
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.Gray
        Me.cmdEdit.BackgroundImage = CType(resources.GetObject("cmdEdit.BackgroundImage"), System.Drawing.Image)
        Me.cmdEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdEdit.FlatAppearance.BorderSize = 0
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.ForeColor = System.Drawing.Color.White
        Me.cmdEdit.Location = New System.Drawing.Point(638, 186)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(50, 21)
        Me.cmdEdit.TabIndex = 35
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.Gray
        Me.cmdAdd.BackgroundImage = CType(resources.GetObject("cmdAdd.BackgroundImage"), System.Drawing.Image)
        Me.cmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAdd.FlatAppearance.BorderSize = 0
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.ForeColor = System.Drawing.Color.White
        Me.cmdAdd.Location = New System.Drawing.Point(638, 159)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(50, 21)
        Me.cmdAdd.TabIndex = 34
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.ListView1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 149)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(620, 199)
        Me.groupBox1.TabIndex = 30
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Master List"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(475, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "*Section: "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.lblSection)
        Me.GroupBox2.Controls.Add(Me.cboSecLet)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cboGen)
        Me.GroupBox2.Controls.Add(Me.cmbSec)
        Me.GroupBox2.Controls.Add(Me.label1)
        Me.GroupBox2.Controls.Add(Me.label2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.label3)
        Me.GroupBox2.Controls.Add(Me.label4)
        Me.GroupBox2.Controls.Add(Me.txtEAddd)
        Me.GroupBox2.Controls.Add(Me.label5)
        Me.GroupBox2.Controls.Add(Me.txtCNum)
        Me.GroupBox2.Controls.Add(Me.label6)
        Me.GroupBox2.Controls.Add(Me.cmbCou)
        Me.GroupBox2.Controls.Add(Me.label7)
        Me.GroupBox2.Controls.Add(Me.txtLN)
        Me.GroupBox2.Controls.Add(Me.txtSNum)
        Me.GroupBox2.Controls.Add(Me.txtMN)
        Me.GroupBox2.Controls.Add(Me.txtFN)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(669, 106)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Info:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"@yahoo.com", "@rocketmail.com", "@gmail.com", "@facebook.com", "@ymail.com"})
        Me.ComboBox1.Location = New System.Drawing.Point(409, 73)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(60, 21)
        Me.ComboBox1.TabIndex = 63
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.Transparent
        Me.lblSection.Location = New System.Drawing.Point(620, 24)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(0, 13)
        Me.lblSection.TabIndex = 62
        '
        'cboSecLet
        '
        Me.cboSecLet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSecLet.Enabled = False
        Me.cboSecLet.FormattingEnabled = True
        Me.cboSecLet.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H"})
        Me.cboSecLet.Location = New System.Drawing.Point(586, 20)
        Me.cboSecLet.Name = "cboSecLet"
        Me.cboSecLet.Size = New System.Drawing.Size(30, 21)
        Me.cboSecLet.TabIndex = 62
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(475, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "*Gender:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cboGen
        '
        Me.cboGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGen.Enabled = False
        Me.cboGen.FormattingEnabled = True
        Me.cboGen.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGen.Location = New System.Drawing.Point(545, 73)
        Me.cboGen.Name = "cboGen"
        Me.cboGen.Size = New System.Drawing.Size(96, 21)
        Me.cboGen.TabIndex = 61
        '
        'cmbSec
        '
        Me.cmbSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSec.Enabled = False
        Me.cmbSec.FormattingEnabled = True
        Me.cmbSec.Location = New System.Drawing.Point(545, 20)
        Me.cmbSec.Name = "cmbSec"
        Me.cmbSec.Size = New System.Drawing.Size(39, 21)
        Me.cmbSec.TabIndex = 59
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(596, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "*(Needed Fields)"
        '
        'lblStudNum
        '
        Me.lblStudNum.AutoSize = True
        Me.lblStudNum.Location = New System.Drawing.Point(587, 52)
        Me.lblStudNum.Name = "lblStudNum"
        Me.lblStudNum.Size = New System.Drawing.Size(0, 13)
        Me.lblStudNum.TabIndex = 60
        Me.lblStudNum.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(12, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Search:"
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"Student Number", "Last Name", "Course", "Gender"})
        Me.cmbSearch.Location = New System.Drawing.Point(62, 10)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(116, 21)
        Me.cmbSearch.TabIndex = 60
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(184, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(115, 20)
        Me.txtSearch.TabIndex = 60
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.Gray
        Me.cmdSearch.BackgroundImage = CType(resources.GetObject("cmdSearch.BackgroundImage"), System.Drawing.Image)
        Me.cmdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSearch.FlatAppearance.BorderSize = 0
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.ForeColor = System.Drawing.Color.White
        Me.cmdSearch.Location = New System.Drawing.Point(305, 9)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 61
        Me.cmdSearch.Text = "Confirm Search"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'cmdRemove
        '
        Me.cmdRemove.BackColor = System.Drawing.Color.Gray
        Me.cmdRemove.BackgroundImage = CType(resources.GetObject("cmdRemove.BackgroundImage"), System.Drawing.Image)
        Me.cmdRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdRemove.FlatAppearance.BorderSize = 0
        Me.cmdRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRemove.ForeColor = System.Drawing.Color.White
        Me.cmdRemove.Location = New System.Drawing.Point(638, 213)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(50, 21)
        Me.cmdRemove.TabIndex = 36
        Me.cmdRemove.Text = "&Drop"
        Me.cmdRemove.UseVisualStyleBackColor = False
        '
        'txtEAdd
        '
        Me.txtEAdd.AutoSize = True
        Me.txtEAdd.BackColor = System.Drawing.Color.Transparent
        Me.txtEAdd.Location = New System.Drawing.Point(414, 21)
        Me.txtEAdd.Name = "txtEAdd"
        Me.txtEAdd.Size = New System.Drawing.Size(0, 13)
        Me.txtEAdd.TabIndex = 64
        Me.txtEAdd.Visible = False
        '
        'frmStud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.SGAS.My.Resources.Resources.BG_Stud
        Me.ClientSize = New System.Drawing.Size(701, 351)
        Me.Controls.Add(Me.txtEAdd)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.lblStudNum)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdUp)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmStud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student List"
        Me.groupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cmdUp As System.Windows.Forms.Button
    Private WithEvents txtEAddd As System.Windows.Forms.TextBox
    Private WithEvents txtCNum As System.Windows.Forms.TextBox
    Private WithEvents cmbCou As System.Windows.Forms.ComboBox
    Private WithEvents txtLN As System.Windows.Forms.TextBox
    Private WithEvents txtMN As System.Windows.Forms.TextBox
    Private WithEvents txtFN As System.Windows.Forms.TextBox
    Private WithEvents txtSNum As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cmdExit As System.Windows.Forms.Button
    Private WithEvents ListView1 As System.Windows.Forms.ListView
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents cmdEdit As System.Windows.Forms.Button
    Private WithEvents cmdAdd As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Sn As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ln As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fn As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mn As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cou As System.Windows.Forms.ColumnHeader
    Friend WithEvents Se As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cn As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ea As System.Windows.Forms.ColumnHeader
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents cmbSec As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Private WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents lblStudNum As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents cmdRemove As System.Windows.Forms.Button
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents cboGen As System.Windows.Forms.ComboBox
    Friend WithEvents gen As System.Windows.Forms.ColumnHeader
    Private WithEvents cboSecLet As System.Windows.Forms.ComboBox
    Private WithEvents lblSection As System.Windows.Forms.Label
    Private WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents txtEAdd As System.Windows.Forms.Label
End Class
