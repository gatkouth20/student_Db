Imports MySql.Data.MySqlClient

Public Class Login_form

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextPass.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        register_form.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from  supermarket.register where user_name='" & TextUser.Text & "' and user_Pass='" & TextPass.Text & "'and user_type='" & ComboBox1.Text & "'", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1
            End If
            If (count = 1) Then
                MessageBox.Show("Welcome username and password are correct ")
                TextUser.Text = ""
                TextPass.Text = ""
                Supermarket_home_Page.Show()
                Me.Visible = False
            ElseIf (count > 1) Then
                MessageBox.Show("Duplicate user in the database and access denied")
            Else
                MessageBox.Show("username and password combination does not match")
            End If
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class