Public Class User_Registration

    Private Sub User_registrationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles User_registrationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.User_registrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SystemDataSet1)

    End Sub

    Private Sub User_Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SystemDataSet1.User_registration' table. You can move, or remove it, as needed.
        Me.User_registrationTableAdapter.Fill(Me.SystemDataSet1.User_registration)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Home_Page.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click






    End Sub
End Class