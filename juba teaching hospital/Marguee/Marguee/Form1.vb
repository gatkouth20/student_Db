Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Left = 5

        If Label1.Left <= Width Then
            Label1.Left = Width

        End If

    End Sub
End Class
