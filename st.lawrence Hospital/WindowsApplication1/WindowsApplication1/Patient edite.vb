Public Class Patient_edite

    Private Sub Edite__PatientBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edite__PatientBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Edite__PatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SystemDataSet)

    End Sub

    Private Sub Patient_edite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SystemDataSet.Edite__Patient' table. You can move, or remove it, as needed.
        Me.Edite__PatientTableAdapter.Fill(Me.SystemDataSet.Edite__Patient)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Home_Page.Show()
        Me.Hide()

    End Sub
End Class