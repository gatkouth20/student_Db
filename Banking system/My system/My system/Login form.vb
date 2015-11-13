Public Class Login_form

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Admin" And TextBox1.Text = "555" Then
            Form1.Show()
            Me.Hide()
        ElseIf ComboBox1.Text = "Staff" And TextBox1.Text = "222" Then
            Home_info.Show()
            Me.Hide()

        End If
    End Sub
End Class