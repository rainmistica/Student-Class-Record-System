<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatatoExcel
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DbclassrecDataSet1 = New SGAS.dbclassrecDataSet1()
        Me.TblstudlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblstudlistTableAdapter = New SGAS.dbclassrecDataSet1TableAdapters.tblstudlistTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DbclassrecDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstudlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(142, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DbclassrecDataSet1
        '
        Me.DbclassrecDataSet1.DataSetName = "dbclassrecDataSet1"
        Me.DbclassrecDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblstudlistBindingSource
        '
        Me.TblstudlistBindingSource.DataMember = "tblstudlist"
        Me.TblstudlistBindingSource.DataSource = Me.DbclassrecDataSet1
        '
        'TblstudlistTableAdapter
        '
        Me.TblstudlistTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(333, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'DatatoExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 199)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "DatatoExcel"
        Me.Text = "DatatoExcel"
        CType(Me.DbclassrecDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstudlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DbclassrecDataSet1 As SGAS.dbclassrecDataSet1
    Friend WithEvents TblstudlistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblstudlistTableAdapter As SGAS.dbclassrecDataSet1TableAdapters.tblstudlistTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
