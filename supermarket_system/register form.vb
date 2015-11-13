Imports MySql.Data.MySqlClient

Public Class register_form

    Private Sub Button1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnregister.Click

        If TextUsern.Text = "" Or TextPass.Text = "" Or TextUserTy.Text = "" Then
            MsgBox("information should not empty")
        ElseIf TextPass.Text <> TextRetypePass.Text Then
            MsgBox("password does not matched")

        Else
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into supermarket.register(user_name,user_pass,RetypePass,user_type) values('" & TextUsern.Text & "','" & TextPass.Text & "','" & TextRetypePass.Text & "','" & TextUserTy.Text & "') ", mycon)
                Dim myReader As MySqlDataReader
                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("User Register Successful")
                TextUsern.Text = ""
                TextPass.Text = ""
                TextRetypePass.Text = ""
                TextUserTy.Text = ""
                mycon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextUsern.Text = ""
        TextPass.Text = ""
        TextRetypePass.Text = ""
        TextUserTy.Text = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Login_form.Show()


    End Sub
End Class