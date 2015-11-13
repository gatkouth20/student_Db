Public Class Form1

    Private Sub Patient_RegistrationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Patient_RegistrationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Patient_RegistrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SystemDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SystemDataSet.Patient_Registration' table. You can move, or remove it, as needed.
        Me.Patient_RegistrationTableAdapter.Fill(Me.SystemDataSet.Patient_Registration)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Home_Page.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()


    End Sub
End Class
