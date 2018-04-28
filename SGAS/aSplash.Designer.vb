<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aSplash
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
        Me.tStart = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'tStart
        '
        Me.tStart.Interval = 1000
        '
        'aSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SGAS.My.Resources.Resources.BG_Flash
        Me.ClientSize = New System.Drawing.Size(486, 149)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(486, 149)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(486, 149)
        Me.Name = "aSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "aSplash"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tStart As System.Windows.Forms.Timer
End Class
