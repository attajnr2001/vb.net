Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        Label3.Text = ProgressBar1.Value & "%"

        If (ProgressBar1.Value = 100) Then
            Timer1.Dispose()
            Hide()
            login.Show()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
