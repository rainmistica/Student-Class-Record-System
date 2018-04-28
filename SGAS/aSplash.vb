Public Class aSplash
    Dim a As Integer
    Private Sub aSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tStart.Enabled = True
        tStart.Start()
    End Sub

    Private Sub tStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tStart.Tick
        If (a <> 0) Then
            a = a - 1
        Else
            tStart.Stop()
            Me.Hide()
            frmLog.Show()
        End If
    End Sub
End Class