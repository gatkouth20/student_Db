Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        'SET THE CONNECTION BETWEEN VISUAL BASIC AND MYSQL DATABASE  
        Dim con As MySqlConnection = New MySqlConnection("server=localhost; user id=root; password=; database=dbuser")
        'A SET OF COMMAND IN MYSQL
        Dim cmd As New MySqlCommand
        'SET A CLASS THAT SERVE THE BRIDGE BETWEEN A DATASET AND DATABASE FOR SAVING AND RETRIEVING DATA.
        Dim da As New MySqlDataAdapter
        'SET A CLASS THAT CONSIST SPECIFIC TABLE IN THE DATABASE
        Dim dt As New DataTable
        Dim sqlQuery As String
        Dim result As Integer
        Try
            If result > 0 Then
                MsgBox("User has been registered.")
            Else
                MsgBox("Failed to register the user.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
   

     
    Private Sub btnreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReg.Click
        sqlQuery = "INSERT INTO supermarket.register ( `user_name`, `user_login`, `user_pass`, `user_type`)" & _
                    "VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')" register (sqlQuery)
        Dim sqlQuery As String
    End Sub
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        sqlQuery = "SELECT * FROM register WHERE Username ='" & TextBox2.Text & "' AND user_pass = '" & TextBox3.Text & "'"
        login(sqlQuery)
    End Sub
End Class
